namespace EduHub.Data.Entities
{
    public partial class GLBUDG
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return $"Budget: {BUDGETKEY} ({TITLE})";
        }
    }
}
