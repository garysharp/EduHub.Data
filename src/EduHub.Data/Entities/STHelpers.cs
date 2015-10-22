namespace EduHub.Data.Entities
{
    public partial class ST
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Student: {STKEY} ({SURNAME}, {FIRST_NAME})";
        }
    }
}
