namespace EduHub.Data.Entities
{
    public partial class SKGS
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"School: {SCHOOL} (School: {NAME}; Campus: {CAMPUS_NAME})";
        }
    }
}
