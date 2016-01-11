namespace EduHub.Data
{
    /// <summary>
    /// Describes the mode used to write entities to the SQL Server
    /// </summary>
    public enum EduHubSqlServerWriteMode
    {
        /// <summary>
        /// No entities were written to the SQL Server
        /// </summary>
        Skipped = 0,
        /// <summary>
        /// All entities were written to the SQL Server, including Delta entities if available
        /// </summary>
        Full = 1,
        /// <summary>
        /// Delta entities were written to the SQL Server
        /// </summary>
        Delta = 2,
        /// <summary>
        /// A subset of Delta entities were written to the SQL Server
        /// </summary>
        DeltaPartial = 3
    }
}
