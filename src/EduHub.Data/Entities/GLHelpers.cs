namespace EduHub.Data.Entities
{
    public partial class GL
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"General Ledger: {CODE} ({TITLE})";
        }
    }
}
