namespace EduHub.Data.Entities
{
    public partial class KGL
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Language: {KGLKEY} ({DESCRIPTION})";
        }
    }
}
