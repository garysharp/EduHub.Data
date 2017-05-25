namespace EduHub.Data.SchemaParser.C7
{
    public class C7DDef : IC7Element
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string SchemaComment { get; set; }

        public override string ToString() => $"DDEF: Name={Name}; Value={Value}; Comment={SchemaComment}";
    }
}
