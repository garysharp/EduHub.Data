namespace EduHub.Data.SchemaParser.C7
{
    public class C7Role : IC7Element
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString() => $"ROLE: Name={Name}; Description={Description}";
    }
}
