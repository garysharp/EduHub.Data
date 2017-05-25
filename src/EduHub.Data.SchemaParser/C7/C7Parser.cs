using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.SchemaParser.C7
{
    public static class C7Parser
    {
        // Constants
        private static readonly char[] NewLineChars = new char[] { '\n', '\r' };
        private static readonly char[] TerminationChars = new char[] { SemicolonSymbol, '\n', '\r' };
        private const char SemicolonSymbol = ';';
        private const char ColonSymbol = ':';
        private const char CommaSymbol = ',';
        private const char EqualsSymbol = '=';
        private const char UnderscoreSymbol = '_';
        private const char AtSymbol = '@';
        private const char AsterixSymbol = '*';
        private const char SpaceSymbol = ' ';
        private const char TabSymbol = (char)9;
        private const char DotSymbol = '.';
        private const char ParenthesesOpenSymbol = '(';
        private const char ParenthesesCloseSymbol = ')';

        // General Parsers
        private static readonly Parser<char> LetterOrDigitOrUnderscore =
            Parse.Char(c => char.IsLetterOrDigit(c) || c == UnderscoreSymbol, "letter or digit or underscore symbol");
        private static readonly Parser<char> LetterOrDigitOrUnderscoreOrDotOrColon =
            Parse.Char(c => char.IsLetterOrDigit(c) || c == UnderscoreSymbol || c == DotSymbol || c == ColonSymbol, "letter or digit or underscore symbol or dot symbol or colon symbol");
        private static readonly Parser<char> LetterOrAt =
            Parse.Char(c => char.IsLetter(c) || c == AtSymbol, "letter or at symbol");
        private static readonly Parser<char> WhiteSpaceSameLine =
            Parse.Char(c => c == SpaceSymbol || c == TabSymbol, "space or tab");
        private static readonly Parser<char> WhiteSpaceSameLineOrColon =
            Parse.Char(c => c == SpaceSymbol || c == TabSymbol || c == ColonSymbol, "space or tab or colon symbol");

        private static readonly Parser<IEnumerable<char>> Identifier =
            from first in Parse.Letter.Once()
            from rest in LetterOrDigitOrUnderscore.Many()
            select first.Concat(rest).ToArray();
        private static readonly Parser<IEnumerable<char>> IdentifierIncAsterix =
            from first in Parse.Letter.Or(Parse.Char(AsterixSymbol)).Once()
            from rest in LetterOrDigitOrUnderscore.Many()
            select first.Concat(rest).ToArray();
        private static readonly Parser<IEnumerable<char>> IdentifierIncDotAndColon =
            from first in Parse.Letter.Once()
            from rest in LetterOrDigitOrUnderscoreOrDotOrColon.Many()
            select first.Concat(rest).ToArray();
        private static readonly Parser<IEnumerable<char>> IdentifierWithAt =
            from first in LetterOrAt.Once()
            from rest in LetterOrDigitOrUnderscore.Many()
            select first.Concat(rest).ToArray();
        private static Parser<T> SameLineToken<T>(Parser<T> parser) =>
            from leading in WhiteSpaceSameLine.Many()
            from item in parser
            from trailing in WhiteSpaceSameLine.Many()
            select item;

        private static Parser<T> PositiveLookAhead<T>(this Parser<T> parser)
        {
            if (parser == null) throw new ArgumentNullException(nameof(parser));

            return i =>
            {
                var result = parser(i);

                if (result.WasSuccessful)
                {
                    return Result.Success(default(T), i);
                }
                else
                {
                    var msg = $"`{string.Join(", ", result.Expectations)}' was not expected";
                    return Result.Failure<T>(i, msg, new string[0]);
                }
            };
        }

        // Comment Parsers
        private static readonly Parser<string> Comment =
            from leading in Parse.WhiteSpace.Many()
            from first in Parse.Char(AsterixSymbol).Then(_ => Parse.Optional(WhiteSpaceSameLine))
            from content in Parse.CharExcept(NewLineChars).Many().Text()
            from trailing in Parse.WhiteSpace.Many()
            select content.TrimEnd();
        private static readonly Parser<string> CommentSingleLine =
            from leading in Parse.WhiteSpace.Many()
            from first in Parse.Char(AsterixSymbol).Then(_ => Parse.Optional(WhiteSpaceSameLine))
            from content in Parse.CharExcept(NewLineChars).Many().Text()
            from trailing in Parse.Chars(NewLineChars).Many()
            select content.TrimEnd();
        private static readonly Parser<string> EndOfLineComment =
            from leading in WhiteSpaceSameLine.Many()
            from first in Parse.Optional(Parse.Char(AsterixSymbol).Then(_ => Parse.Optional(WhiteSpaceSameLine)))
            from content in Parse.CharExcept(NewLineChars).Many().Text()
            from trailing in Parse.Chars(NewLineChars).Many()
            select content.TrimEnd();

        // Element Parsers
        private static readonly Parser<C7Comment> CommentElementParser =
            from comment in Comment
            select new C7Comment()
            {
                Comment = comment
            };
        private static readonly Parser<C7Procedure> ProcedureElementParser =
            from description in Parse.CharExcept(TerminationChars).Many().Text()
            from optionalComment in Parse.Optional(Parse.Chars(SemicolonSymbol).Then(_ => EndOfLineComment))
            from content in Parse.AnyChar.Except(Parse.String("ENDPROCEDURE")).Many().Text()
            from endword in Parse.String("ENDPROCEDURE").Then(_ => WhiteSpaceSameLineOrColon.Optional()).Then(_ => Parse.Char(SemicolonSymbol).Many())
            from trailing in Parse.WhiteSpace.Many()
            select new C7Procedure()
            {
                Description = description.Trim(),
                SchemaComment = optionalComment.GetOrDefault(),
                Content = content
            };
        private static readonly Parser<C7Task> TaskElementParser =
            from name in Parse.Token(Identifier).Text()
            from argSep1 in Parse.Char(CommaSymbol)
            from description in Parse.CharExcept(new char[] { CommaSymbol, SemicolonSymbol }).Many().Text()
            from args in Parse.Char(CommaSymbol).Then(_ => Parse.CharExcept(new char[] { CommaSymbol, SemicolonSymbol }).Many().Text()).Many()
            from argSep5 in Parse.Char(SemicolonSymbol)
            from optionalComment in Parse.Optional(EndOfLineComment)
            from content in Parse.AnyChar.Except(Parse.String("ENDTASK")).Many().Text()
            from endword in Parse.String("ENDTASK").Then(_ => WhiteSpaceSameLineOrColon.Optional()).Then(_ => Parse.Char(SemicolonSymbol).Many())
            from trailing in Parse.WhiteSpace.Many()
            select new C7Task()
            {
                Name = name,
                Description = description.Trim(),
                Arguments = args.ToList(),
                Content = content
            };
        private static readonly Parser<C7SqlProcedure> SqlProcedureElementParser =
            from leading in WhiteSpaceSameLine.Many()
            from optionalComment in Parse.Optional(Parse.Chars(SemicolonSymbol).Then(_ => EndOfLineComment))
            from content in Parse.AnyChar.Except(Parse.String("ENDSQLPROCEDURE")).Many().Text()
            from endword in Parse.String("ENDSQLPROCEDURE").Then(_ => WhiteSpaceSameLineOrColon.Optional()).Then(_ => Parse.Char(SemicolonSymbol).Many())
            from trailing in Parse.WhiteSpace.Many()
            select new C7SqlProcedure()
            {
                SchemaComment = optionalComment.GetOrDefault(),
                Content = content
            };
        private static readonly Parser<C7SqlTrigger> SqlTriggerElementParser =
            from leading in WhiteSpaceSameLine.Many()
            from optionalComment in Parse.Optional(Parse.Chars(SemicolonSymbol).Then(_ => EndOfLineComment))
            from content in Parse.AnyChar.Except(Parse.String("ENDSQLTRIGGER")).Many().Text()
            from endword in Parse.String("ENDSQLTRIGGER").Then(_ => WhiteSpaceSameLineOrColon.Optional()).Then(_ => Parse.Char(SemicolonSymbol).Many())
            from trailing in Parse.WhiteSpace.Many()
            select new C7SqlTrigger()
            {
                SchemaComment = optionalComment.GetOrDefault(),
                Content = content
            };
        private static readonly Parser<C7ExecuteProcedure> ExecuteProcedureElementParser =
            from leading in WhiteSpaceSameLine.Many()
            from name in Parse.Token(Parse.CharExcept(SemicolonSymbol).Many()).Text()
            from terminator in Parse.Char(SemicolonSymbol).Many()
            from trailing in Parse.WhiteSpace.Many()
            select new C7ExecuteProcedure()
            {
                Name = name
            };
        private static readonly Parser<C7SqlView> SqlViewElementParser =
            from leading in WhiteSpaceSameLine.Many()
            from optionalComment in Parse.Optional(Parse.Chars(SemicolonSymbol).Then(_ => EndOfLineComment))
            from content in Parse.AnyChar.Except(Parse.String("ENDSQLVIEW")).Many().Text()
            from endword in Parse.String("ENDSQLVIEW").Then(_ => WhiteSpaceSameLineOrColon.Optional()).Then(_ => Parse.Char(SemicolonSymbol).Many())
            from trailing in Parse.WhiteSpace.Many()
            select new C7SqlView()
            {
                SchemaComment = optionalComment.GetOrDefault(),
                Content = content
            };
        private static readonly Parser<C7CazSignature> CazSignatureElementParser =
            from leading in WhiteSpaceSameLine.Many()
            from keyword in Parse.Token(Parse.String("<CazSignature>")).Text()
            from content in Parse.AnyChar.Except(Parse.String("</CazSignature>")).Many().Text()
            from endword in Parse.String("</CazSignature>")
            from trailing in Parse.WhiteSpace.Many()
            select new C7CazSignature()
            {
                Content = content
            };
        private static readonly Parser<C7Field> FieldElementParser =
            from name in Parse.Not(SameLineToken(Parse.LetterOrDigit.Many()).Then(_ => Parse.Char(ColonSymbol)))
                .Then(_ => Parse.Token(Identifier).Text())
            from relationship in Parse.Optional(
                from leading in WhiteSpaceSameLine.Many()
                from openPeren in Parse.Char(ParenthesesOpenSymbol)
                from relationshipEntity in SameLineToken(Identifier).Text()
                from sep in Parse.Char(DotSymbol)
                from relationshipField in SameLineToken(Identifier).Text()
                from relationshipTag in Parse.Optional(
                    from tagToken in Parse.Char(ColonSymbol)
                    from tag in SameLineToken(IdentifierIncDotAndColon).Text()
                    select tag
                    )
                from closePeren in Parse.Char(ParenthesesCloseSymbol)
                from trailing in Parse.WhiteSpace.Many()
                select (Entity: relationshipEntity, Field: relationshipField, Tag: relationshipTag.GetOrDefault()))
            from sep1 in Parse.Char(CommaSymbol)
            from type in SameLineToken(Parse.LetterOrDigit.AtLeastOnce()).Text()
            from sep2 in Parse.Char(CommaSymbol).Optional()
            from flags in CommaValuesParserIgnoreCase("SEQUENCE", "EDITABLE", "SPLIT").Many()
            from read in Parse.Optional(InlineCommaListParser("READ", EqualsSymbol, IdentifierIncAsterix))
            from write in Parse.Optional(InlineCommaListParser("WRITE", EqualsSymbol, IdentifierIncAsterix))
            from terminator in WhiteSpaceSameLine.Many().Then(_ => Parse.Char(SemicolonSymbol))
            from comment in Parse.Optional(EndOfLineComment)
            from moreComments in Parse.Optional(WhiteSpaceSameLine.Repeat(8).Then(_ => CommentSingleLine).Many())
            from trailing in Parse.WhiteSpace.Many()
            select new C7Field()
            {
                Name = name,
                Relationship = relationship.GetOrDefault(),
                Type = type,
                IsSequence = flags.Any(s => s.Equals("SEQUENCE", StringComparison.OrdinalIgnoreCase)),
                IsEditable = flags.Any(s => s.Equals("EDITABLE", StringComparison.OrdinalIgnoreCase)),
                IsSplit = flags.Any(s => s.Equals("SPLIT", StringComparison.OrdinalIgnoreCase)),
                Read = read.IsDefined ? read.Get().ToList() : null,
                Write = write.IsDefined ? write.Get().ToList() : null,
                SchemaComment = moreComments.IsDefined ? comment.GetOrDefault() + Environment.NewLine + string.Join(Environment.NewLine, moreComments.Get()) : comment.GetOrDefault()
            };

        private static readonly Parser<C7Account> AccountElementParser =
            from keyword in Parse.Token(Parse.String("ACCOUNT")).Text()
            from sep1 in Parse.Char(CommaSymbol)
            from name in Parse.Token(Identifier).Text()
            from sep2 in Parse.Char(CommaSymbol)
            from description in Parse.CharExcept(CommaSymbol).Many().Text()
            from sep3 in Parse.Char(CommaSymbol)
            from flags in CommaValuesParser("MINOR", "AUTOKEY", "DBSEQ").Many()
            from read in InlineCommaListParser("READ", EqualsSymbol, IdentifierIncAsterix)
            from write in InlineCommaListParser("WRITE", EqualsSymbol, IdentifierIncAsterix)
            from sep5 in Parse.Char(SemicolonSymbol)
            from comment in Parse.CharExcept(NewLineChars).Many()
            from fields in (((Parser<IC7Element>)CommentElementParser).Or(FieldElementParser))
                .AtLeastOnce()
            from attributes in CommentElementParser.Return(default((string Name, List<string> Values))).Or(CommaListParser("KEYS", "MOREINFO", "NODUPS", "QUICKADD")).Many()
            select new C7Account()
            {
                Name = name,
                Description = description,
                IsMinor = flags.Contains("MINOR"),
                IsAutoKey = flags.Contains("AUTOKEY"),
                IsDbSeq = flags.Contains("DBSEQ"),
                Read = read.ToList(),
                Write = write.ToList(),
                Fields = fields.OfType<C7Field>().ToList(),
                Keys = attributes.SingleOrDefault(l => l.Name == "KEYS").Values,
                MoreInfo = attributes.SingleOrDefault(l => l.Name == "MOREINFO").Values,
                NoDups = attributes.SingleOrDefault(l => l.Name == "NODUPS").Values,
                QuickAdd = attributes.SingleOrDefault(l => l.Name == "QUICKADD").Values
            };

        private static readonly Parser<C7Trans> TransElementParser =
            from keyword in Parse.Token(Parse.String("TRANS")).Text()
            from sep1 in Parse.Char(CommaSymbol)
            from name in Parse.Token(Identifier).Text()
            from relSep1 in Parse.Char(ParenthesesOpenSymbol)
            from account in Parse.Token(Identifier).Text()
            from relSep2 in Parse.Char(ParenthesesCloseSymbol)
            from sep2 in Parse.Char(CommaSymbol)
            from description in Parse.CharExcept(CommaSymbol).Many().Text()
            from sep3 in Parse.Char(CommaSymbol)
            from flags in CommaValuesParser("FINANCIAL", "ORDERS", "DBSEQ").Many()
            from read in InlineCommaListParser("READ", EqualsSymbol, IdentifierIncAsterix)
            from write in InlineCommaListParser("WRITE", EqualsSymbol, IdentifierIncAsterix)
            from sep5 in Parse.Char(SemicolonSymbol)
            from comment in Parse.CharExcept(NewLineChars).Many()
            from fields in (((Parser<IC7Element>)CommentElementParser).Or(FieldElementParser))
                .AtLeastOnce()
            from attributes in CommentElementParser.Return(default((string Name, List<string> Values))).Or(CommaListParser("KEYS", "MOREINFO", "NODUPS")).Many()
            select new C7Trans()
            {
                Name = name,
                AccountReference = account,
                Description = description,
                IsFinancial = flags.Contains("FINANCIAL"),
                IsOrders = flags.Contains("ORDERS"),
                IsDbSeq = flags.Contains("DBSEQ"),
                Read = read.ToList(),
                Write = write.ToList(),
                Fields = fields.OfType<C7Field>().ToList(),
                Keys = attributes.SingleOrDefault(l => l.Name == "KEYS").Values,
                MoreInfo = attributes.SingleOrDefault(l => l.Name == "MOREINFO").Values,
                NoDups = attributes.SingleOrDefault(l => l.Name == "NODUPS").Values
            };

        private static Parser<(string Name, List<string> Values)> CommaListParser(params string[] AllowedNames) =>
            from name in Parse.Token(AllowedNames.Select(n => Parse.String(n)).Aggregate((a, b) => a.Or(b))).Text()
            from sep in Parse.Char(ColonSymbol)
            from values in (from token in SameLineToken(Parse.CharExcept(new char[] { CommaSymbol, SemicolonSymbol, NewLineChars[0], NewLineChars[1] }).AtLeastOnce()).Text()
                            from terminator in Parse.Chars(CommaSymbol, SemicolonSymbol)
                            select token).AtLeastOnce().Or(Parse.CharExcept(NewLineChars).Many().Return(Enumerable.Empty<string>()))
            select (Name: name, Values: values.ToList());
        private static Parser<IEnumerable<string>> InlineCommaListParser(string Name, char ListSeperator, Parser<IEnumerable<char>> ValueParser) =>
            from name in Parse.Token(Parse.String(Name)).Text()
            from sep in Parse.Char(ListSeperator)
            from values in (from token in SameLineToken(ValueParser).Text().Optional()
                            from terminator in Parse.Char(CommaSymbol).Or(PositiveLookAhead(Parse.Char(SemicolonSymbol)))
                            select token.GetOrDefault()).AtLeastOnce()
            select values.Where(v => v != null);
        private static Parser<string> CommaValuesParser(IEnumerable<Parser<string>> AllowedValues) =>
            from name in Parse.Token(AllowedValues.Select(n => n).Aggregate((a, b) => a.Or(b))).Text()
            from sep in Parse.Char(CommaSymbol).Or(PositiveLookAhead(Parse.Char(SemicolonSymbol)))
            select name;
        private static Parser<string> CommaValuesParser(params string[] AllowedValues) =>
            CommaValuesParser(AllowedValues.Select(v => Parse.String(v).Text()));
        private static Parser<string> CommaValuesParserIgnoreCase(params string[] AllowedValues) =>
            CommaValuesParser(AllowedValues.Select(v => Parse.IgnoreCase(v).Text()));

        // Elements
        private static readonly List<Parser<IC7Element>> ElementParsers = new List<Parser<IC7Element>>()
        {
            CommentElementParser,
            BuildKeyValueParser("ROLE", Identifier, CommaSymbol, v => new C7Role() { Name=v.name, Description=v.value }),
            BuildKeyValueParser("REPLACE", IdentifierWithAt, EqualsSymbol, v => new C7Replace() { Name=v.name, Value=v.value, SchemaComment=v.comment }),
            BuildKeyValueParser("DEF", IdentifierWithAt, EqualsSymbol, v => new C7Def() { Name=v.name, Value=v.value, SchemaComment=v.comment }),
            BuildKeyValueParser("NDEF", IdentifierWithAt, EqualsSymbol, v => new C7NDef() { Name=v.name, Value=v.value, SchemaComment=v.comment }),
            BuildKeyValueParser("DDEF", IdentifierWithAt, EqualsSymbol, v => new C7DDef() { Name=v.name, Value=v.value, SchemaComment=v.comment }),
            BuildBlockParser("DATABASE-PROPERTIES", "END-DATABASE-PROPERTIES", v => new C7DatabaseProperties() { Content = v}),
            BuildElementParser("PROCEDURE", ProcedureElementParser),
            BuildElementParser("TASK", TaskElementParser),
            BuildElementParser("SQLPROCEDURE", SqlProcedureElementParser),
            BuildElementParser("SQLTRIGGER", SqlTriggerElementParser),
            BuildElementParser("SQLVIEW", SqlViewElementParser),
            BuildElementParser("EXECUTEPROCEDURE", ExecuteProcedureElementParser),
            AccountElementParser,
            TransElementParser,
            CazSignatureElementParser,
        };
        private static Parser<T> BuildElementParser<T>(string Keyword, Parser<T> ElementParser) =>
            from keyword in Parse.Token(Parse.String(Keyword)).Text()
            from seperator in Parse.Char(ColonSymbol)
            from value in ElementParser
            select value;
        private static Parser<T> BuildKeyValueParser<T>
            (string Keyword, Parser<IEnumerable<char>> IdentifierParser, char ValueSeperator, Func<(string name, string value, string comment), T> Factory) =>
            BuildElementParser(Keyword,
                from name in Parse.Token(IdentifierParser).Text()
                from seperator in Parse.Char(ValueSeperator)
                from leadingWhitespace in Parse.WhiteSpace.Many()
                from value in Parse.CharExcept(TerminationChars).Many().Text()
                from optionalComment in Parse.Optional(Parse.Chars(SemicolonSymbol).Then(_ => EndOfLineComment))
                from trailing in Parse.WhiteSpace.Many()
                select Factory((name, value, optionalComment.GetOrDefault())));
        private static Parser<T> BuildBlockParser<T>
            (string Keyword, string Endword, Func<string, T> Factory) =>
            BuildElementParser(Keyword,
                from content in Parse.AnyChar.Except(Parse.String(Endword)).Many().Text()
                from endword in Parse.String(Endword).Then(_ => WhiteSpaceSameLineOrColon.Optional()).Then(_ => Parse.Char(SemicolonSymbol).Many())
                from trailing in Parse.WhiteSpace.Many()
                select Factory(content));

        private static readonly Parser<IC7Element> Element = ElementParsers.Aggregate((a, b) => a.Or(b));

        private static readonly Parser<IEnumerable<IC7Element>> Elements =
            from element in Element.AtLeastOnce()
            select element;

        public static List<IC7Element> ParseSchema(IEnumerable<string> C7Content)
        {
            var c7Schema = Preprocess(C7Content);

            var elements = Elements.End().Parse(c7Schema).ToList();

            return elements;
        }

        public static List<IC7Element> ParseSchemaFile(string Filename)
        {
            return ParseSchema(System.IO.File.ReadLines(Filename));
        }

        private static string Preprocess(IEnumerable<string> C7Content)
        {
            var ouput = new StringBuilder();
            var directives = new HashSet<string>();
            var state = new Stack<Func<HashSet<string>, bool>>();
            var included = true;

            foreach (var originalLine in C7Content)
            {
                var line = originalLine.TrimStart();

                if (line.Length > 1 && line[0] == '#')
                {
                    if (line.StartsWith("#COMPILE"))
                    {
                        // Add directive
                        var directive = line.Substring(8, line.IndexOf(';') - 8).Trim();

                        // Override for CHESS (eduHub is always CHESS)
                        if (directive == "NOCHESS")
                        {
                            directive = "CHESS";
                        }

                        directives.Add(directive);
                    }
                    else if (line.StartsWith("#IF"))
                    {
                        string directive;
                        var terminator = line.IndexOf(';');
                        if (terminator > 0)
                        {
                            directive = line.Substring(4, terminator - 4);
                        }
                        else
                        {
                            directive = line.Substring(4);
                        }

                        var expressionDirectives = directive.Split('|').Select(d => d.Trim()).ToList();

                        if (expressionDirectives.Count == 0)
                        {
                            throw new InvalidOperationException("Invalid schema command");
                        }

                        // Push to state
                        state.Push(values => values.Any(v => expressionDirectives.Any(d => v == d)));
                    }
                    else if (line.StartsWith("#ELSE"))
                    {
                        // Push inverse to state
                        var directive = state.Pop();
                        // Inverse
                        state.Push(values => !directive(values));
                    }
                    else if (line.StartsWith("#ENDIF"))
                    {
                        // Pop state
                        var directive = state.Pop();
                    }
                    else if (included)
                    {
                        ouput.AppendLine(originalLine);
                    }

                    included = state.Count == 0 || state.All(s => s(directives));
                }
                else if (included)
                {
                    ouput.AppendLine(originalLine);
                }
            }

            return ouput.ToString();
        }
    }
}
