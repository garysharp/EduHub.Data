using System.Collections.Generic;

namespace EduHub.Data.SchemaParser.C7
{
    public interface IC7Entity : IC7Element
    {
        string Name { get; set; }
        string Description { get; set; }
        bool IsDbSeq { get; set; }
        List<string> Read { get; set; }
        List<string> Write { get; set; }

        List<C7Field> Fields { get; set; }

        List<string> Keys { get; set; }
        List<string> MoreInfo { get; set; }
        List<string> NoDups { get; set; }
    }
}