namespace EduHub.Data.Entities
{
    public partial class SF
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Staff Member: {SFKEY} ({TITLE} {FIRST_NAME} {SURNAME}; Record Number: {PAYROLL_REC_NO})";
        }
    }
}
