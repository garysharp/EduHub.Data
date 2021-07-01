namespace EduHub.Data.Entities
{
    public partial class UM
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Address: {UMKEY} ({(ADDRESS01==null ? ADDRESS02 : $"{ADDRESS01}; {ADDRESS02}")}; {ADDRESS03}; {STATE}; {POSTCODE})";
        }
    }
}
