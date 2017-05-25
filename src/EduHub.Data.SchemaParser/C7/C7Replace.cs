namespace EduHub.Data.SchemaParser.C7
{
    public class C7Replace : IC7Element
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string SchemaComment { get; set; }

        public override string ToString() => $"REPLACE: Name={Name}; Value={Value}; Comment={SchemaComment}";
    }
}
