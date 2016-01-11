using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Represents an eduHub Data Set Reader which progressively loads a data set
    /// </summary>
    /// <typeparam name="T">The <see cref="EduHubEntity"/> this reader loads</typeparam>
    public interface IEduHubDataSetReader<T> : IEnumerable<T>, IDisposable where T : EduHubEntity
    {
        /// <summary>
        /// The name of the data set being loaded
        /// </summary>
        string Name { get; }

        /// <summary>
        /// <see cref="EduHubContext"/> this reader belongs to
        /// </summary>
        EduHubContext Context { get; }

        /// <summary>
        /// <see cref="EduHubDataSet{T}"/> this reader belongs to
        /// </summary>
        EduHubDataSet<T> DataSet { get; }

        /// <summary>
        /// Indicates whether the set is empty
        /// </summary>
        bool HasEntities { get; }

        /// <summary>
        /// The approximate progress of data set loading
        /// </summary>
        double Progress { get; }

        /// <summary>
        /// Number of entities read
        /// </summary>
        int EntitiesRead { get; }

        /// <summary>
        /// The latest entity last written timestamp (if supported by the entity)
        /// </summary>
        DateTime? EntityLastModifiedMax { get; }
    }
}
