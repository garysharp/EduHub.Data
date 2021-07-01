namespace EduHub.Data.Entities
{
    public partial class GLF
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"General Ledger Transaction: {TID} (General Ledger: {CODE}; Ref: {TRREF})";
        }
    }
}
