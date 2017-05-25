namespace EduHub.Data.SchemaParser.C7
{
    public class C7Procedure : IC7Element
    {
        public string Description { get; set; }
        public string Content { get; set; }
        public string SchemaComment { get; set; }

        public override string ToString() => $"PROCEDURE: Description={Description}; (Content Not Parsed); Comment={SchemaComment}";
    }
}
