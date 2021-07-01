namespace EduHub.Data.Entities
{
    public partial class SCI
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"School Information: {SCIKEY} (Link: {SCHOOL_LINK}; Name: {SCHOOL_NAME}; Campus: {CAMPUS_NAME})";
        }
    }
}
