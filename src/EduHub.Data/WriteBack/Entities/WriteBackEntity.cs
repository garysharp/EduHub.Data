namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Base object for Write-Back Entities
    /// </summary>
    public abstract class WriteBackEntity
    {
        internal WriteBackEntity(WriteBackContext Context)
        {
            this.Context = Context;
        }

        /// <summary>
        /// <see cref="WriteBackContext"/> this entity belongs to
        /// </summary>
        public WriteBackContext Context { get; }
    }
}
