namespace EduHub.Data.Entities
{
    public partial class GLF
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"General Ledger Transaction: {TID} (General Ledger: {CODE}; Ref: {TRREF})";
        }
    }
}
