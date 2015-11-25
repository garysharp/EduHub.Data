namespace EduHub.Data.Entities
{
    public partial class SF
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Staff Member: {SFKEY} ({TITLE} {FIRST_NAME} {SURNAME}; Record Number: {PAYROLL_REC_NO})";
        }
    }
}
