namespace EduHub.Data.Entities
{
    public partial class SKGS
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"School: {SCHOOL} (School: {NAME}; Campus: {CAMPUS_NAME})";
        }
    }
}
