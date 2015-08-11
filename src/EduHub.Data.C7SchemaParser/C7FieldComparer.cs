using System.Collections.Generic;

namespace EduHub.Data.C7SchemaParser
{
    class C7FieldComparer : IEqualityComparer<C7Field>
    {
        public bool Equals(C7Field x, C7Field y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(C7Field obj)
        {
            return obj.GetHashCode();
        }
    }
}
