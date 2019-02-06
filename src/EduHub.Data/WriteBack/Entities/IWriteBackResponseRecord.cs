namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Write-Back Response Record
    /// </summary>
    public interface IWriteBackResponseRecord
    {
        /// <summary>
        /// Entity Type to cause an error in CASES21 Import process
        /// (ST for Student, AB for Absence Code, DT for Date, YR for Year level)
        /// </summary>
        string Entity { get; }
        /// <summary>
        /// Identifying Key for the problem entity (e.g. STKEY or YEAR_LEVEL)
        /// </summary>
        string EntityKey { get; }
        /// <summary>
        /// Error Text describing the error encountered
        /// </summary>
        string ErrorText { get; }
    }
}
