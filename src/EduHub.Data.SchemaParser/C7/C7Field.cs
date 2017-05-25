using System.Collections.Generic;

namespace EduHub.Data.SchemaParser.C7
{
    public class C7Field : IC7Element
    {
        public string Name { get; set; }
        public (string Entity, string Field, string Tag) Relationship { get; set; }
        public string Type { get; set; }
        public bool IsSequence { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSplit { get; set; }
        public List<string> Read { get; set; }
        public List<string> Write { get; set; }

        public string SchemaComment { get; set; }

        public override string ToString() => $"FIELD: Name={Name}; Relationship={ (Relationship.Entity != null ? ($"{Relationship.Entity}.{Relationship.Field}:{Relationship.Tag}") : "[None]" )}; Type={Type}; IsSequence={IsSequence}; Comment={SchemaComment}";
    }
}
