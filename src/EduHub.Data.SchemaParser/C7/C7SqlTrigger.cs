namespace EduHub.Data.SchemaParser.C7
{
    public class C7SqlTrigger : IC7Element
    {
        public string Content { get; set; }
        public string SchemaComment { get; set; }

        public override string ToString() => $"SQLTRIGGER: (Content Not Parsed); Comment={SchemaComment}";
    }
}
