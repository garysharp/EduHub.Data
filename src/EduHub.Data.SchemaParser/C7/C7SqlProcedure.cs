namespace EduHub.Data.SchemaParser.C7
{
    public class C7SqlProcedure : IC7Element
    {
        public string Content { get; set; }
        public string SchemaComment { get; set; }

        public override string ToString() => $"SQLPROCEDURE: (Content Not Parsed); Comment={SchemaComment}";
    }
}
