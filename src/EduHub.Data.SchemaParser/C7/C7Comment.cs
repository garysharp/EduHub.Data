namespace EduHub.Data.SchemaParser.C7
{
    public class C7Comment : IC7Element
    {
        public string Comment { get; set; }

        public override string ToString() => $"Comment: {Comment}";
    }
}
