using EduHub.Data.Entities;
using System;

namespace EduHub.Data
{
    /// <summary>
    /// The result of a SQL Server write method
    /// </summary>
    public class EduHubSqlServerWriteResult
    {
        /// <summary>
        /// The Data Set written to the SQL Server
        /// </summary>
        public IEduHubDataSet DataSet { get; private set; }

        /// <summary>
        /// The <see cref="EduHubSqlServerWriteMode"/> mode used to write the data set
        /// </summary>
        public EduHubSqlServerWriteMode Mode { get; private set; }

        /// <summary>
        /// The time the write method began
        /// </summary>
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// The time the data set was last modified
        /// </summary>
        public DateTime LastModified { get; private set; }

        /// <summary>
        /// The maximum last modified entity timestamp (if supported)
        /// </summary>
        public DateTime? EntityLastModifiedMax { get; private set; }

        /// <summary>
        /// The number of entities deleted during the write method, -1 if the table was truncated (emptied).
        /// </summary>
        public int EntitiesDeleted { get; private set; }
        /// <summary>
        /// The number of entities updated during the write method
        /// </summary>
        public int EntitiesUpdated { get; private set; }
        /// <summary>
        /// The number of entities added during the write method
        /// </summary>
        public int EntitiesAdded { get; private set; }

        internal EduHubSqlServerWriteResult(IEduHubDataSet DataSet, EduHubSqlServerWriteMode Mode, DateTime Timestamp, DateTime LastModified)
        {
            this.DataSet = DataSet;
            this.Mode = Mode;
            this.Timestamp = Timestamp;
            this.LastModified = LastModified;
        }

        internal EduHubSqlServerWriteResult(IEduHubDataSet DataSet, EduHubSqlServerWriteMode Mode, DateTime Timestamp, DateTime LastModified, DateTime? EntityLastModifiedMax, int EntitiesDeleted, int EntitiesUpdated, int EntitiesAdded)
            : this(DataSet, Mode, Timestamp, LastModified)
        {
            this.EntityLastModifiedMax = EntityLastModifiedMax;
            this.EntitiesDeleted = EntitiesDeleted;
            this.EntitiesUpdated = EntitiesUpdated;
            this.EntitiesAdded = EntitiesAdded;
        }
    }
}
