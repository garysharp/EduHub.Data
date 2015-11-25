namespace EduHub.Data.Entities
{
    public partial class KGLT
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"General Ledger Account Type: {GL_TYPE} ({TITLE})";
        }
    }
}
