using EduHub.Data.WriteBack.Entities;
using System;

namespace EduHub.Data.WriteBack
{
    /// <summary>
    /// Write-Back Writer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWriteBackWriter<T> : IDisposable where T : WriteBackEntity
    {
        /// <summary>
        /// Write-Back DataSet
        /// </summary>
        WriteBackDataSet<T> DataSet { get; }

        /// <summary>
        /// Writes the entity to the data set
        /// </summary>
        /// <param name="Entity"></param>
        void Write(T Entity);

        /// <summary>
        /// Transfers the imported entities into the eduHub directory
        /// </summary>
        void Commit();
    }
}
