namespace EduHub.Data.Entities
{
    public partial class UM
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Address: {UMKEY} ({(ADDRESS01==null ? ADDRESS02 : $"{ADDRESS01}; {ADDRESS02}")}; {ADDRESS03}; {STATE}; {POSTCODE})";
        }
    }
}
