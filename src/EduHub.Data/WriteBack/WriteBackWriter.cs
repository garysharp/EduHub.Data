using EduHub.Data.WriteBack.Entities;

namespace EduHub.Data.WriteBack
{
    /// <summary>
    /// Write-Back Writer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class WriteBackWriter<T> : IWriteBackWriter<T> where T : WriteBackEntity
    {
        /// <summary>
        /// Write-Back Context
        /// </summary>
        protected readonly WriteBackContext Context;

        /// <summary>
        /// Write-Back Writer Constructor
        /// </summary>
        /// <param name="Context">Write-Back Context</param>
        /// <param name="DataSet">Write-Back DataSet</param>
        protected WriteBackWriter(WriteBackContext Context, WriteBackDataSet<T> DataSet)
        {
            this.Context = Context;
            this.DataSet = DataSet;
        }

        /// <summary>
        /// Write-Back DataSet
        /// </summary>
        public WriteBackDataSet<T> DataSet { get; }

        /// <summary>
        /// Writes the entity to the data set
        /// </summary>
        /// <param name="Entity"></param>
        public abstract void Write(T Entity);

        /// <summary>
        /// Transfers the imported entities into the eduHub directory
        /// </summary>
        public abstract void Commit();

        /// <inheritdoc />
        public abstract void Dispose(bool Disposed);
        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
