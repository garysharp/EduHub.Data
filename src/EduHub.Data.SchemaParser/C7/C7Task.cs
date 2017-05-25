using System.Collections.Generic;

namespace EduHub.Data.SchemaParser.C7
{
    public class C7Task : IC7Element
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Arguments { get; set; }

        public string Content { get; set; }

        public override string ToString() => $"TASK: Name={Name}; Description={Description}; Args={(Arguments == null ? "(None)" : string.Join("; ", Arguments))};";
    }
}
