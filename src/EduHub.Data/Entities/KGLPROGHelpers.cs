namespace EduHub.Data.Entities
{
    public partial class KGLPROG
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"General Ledger Program: {GLPROGRAM} ({TITLE})";
        }
    }
}
