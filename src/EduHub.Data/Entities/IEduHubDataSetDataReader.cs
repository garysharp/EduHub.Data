using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Represents an eduHub Data Set Data Reader which progressively loads a data set
    /// </summary>
    public interface IEduHubDataSetDataReader : IDataReader, IDataRecord
    {
        /// <summary>
        /// Indicates whether the set is empty
        /// </summary>
        bool HasEntities { get; }

        /// <summary>
        /// The approximate progress of data set reading
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
