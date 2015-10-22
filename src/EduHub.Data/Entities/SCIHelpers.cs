namespace EduHub.Data.Entities
{
    public partial class SCI
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"School Information: {SCIKEY} (Link: {SCHOOL_LINK}; Name: {SCHOOL_NAME}; Campus: {CAMPUS_NAME})";
        }
    }
}
