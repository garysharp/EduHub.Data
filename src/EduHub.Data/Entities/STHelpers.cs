namespace EduHub.Data.Entities
{
    public partial class ST
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Student: {STKEY} ({SURNAME}, {FIRST_NAME})";
        }
    }
}
