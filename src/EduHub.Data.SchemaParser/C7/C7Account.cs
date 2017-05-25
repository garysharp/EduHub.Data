using System.Collections.Generic;

namespace EduHub.Data.SchemaParser.C7
{
    public class C7Account : IC7Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMinor { get; set; }
        public bool IsAutoKey { get; set; }
        public bool IsDbSeq { get; set; }
        public List<string> Read { get; set; }
        public List<string> Write { get; set; }

        public List<C7Field> Fields { get; set; }

        public List<string> Keys { get; set; }
        public List<string> MoreInfo { get; set; }
        public List<string> NoDups { get; set; }
        public List<string> QuickAdd { get; set; }

        public override string ToString() => $"ACCOUNT: Name={Name}; Description={Description}; IsMinor={IsMinor}; Keys={(Keys == null ? "(none)" : string.Join(", ", Keys))}; Fields={Fields.Count}";
    }
}
