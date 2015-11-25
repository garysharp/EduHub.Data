namespace EduHub.Data.Entities
{
    public partial class CRF
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Transaction: {TID} (Creditor: {CODE}; Ref: {TRREF})";
        }
    }
}
