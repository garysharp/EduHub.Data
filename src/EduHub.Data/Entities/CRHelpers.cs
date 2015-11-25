namespace EduHub.Data.Entities
{
    public partial class CR
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Creditor: {CRKEY} ({TITLE})";
        }
    }
}
