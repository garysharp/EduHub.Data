using System.Collections.Generic;

namespace EduHub.Data.SchemaParser.C7
{
    public class C7Trans : IC7Entity
    {
        public string Name { get; set; }
        public string AccountReference { get; set; }
        public string Description { get; set; }
        public bool IsFinancial { get; set; }
        public bool IsOrders { get; set; }
        public bool IsDbSeq { get; set; }
        public List<string> Read { get; set; }
        public List<string> Write { get; set; }

        public List<C7Field> Fields { get; set; }

        public List<string> Keys { get; set; }
        public List<string> MoreInfo { get; set; }
        public List<string> NoDups { get; set; }

        public override string ToString() => $"TRANS: Name={Name}; Description={Description}; IsFinancial={IsFinancial}; IsOrders={IsOrders}; Keys={(Keys == null ? "(none)" : string.Join(", ", Keys))}; Fields={Fields.Count}";
    }
}
