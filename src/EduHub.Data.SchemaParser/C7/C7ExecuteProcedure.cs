namespace EduHub.Data.SchemaParser.C7
{
    public class C7ExecuteProcedure : IC7Element
    {
        public string Name { get; set; }

        public override string ToString() => $"EXECUTEPROCEDURE: Name={Name}";
    }
}
