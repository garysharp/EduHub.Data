using EduHub.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
#if NET452
using System.Data.SqlClient;
#elif NET10_0
using Microsoft.Data.SqlClient;
#endif
using System.Threading.Tasks;

namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Write-back data set contract
    /// </summary>
    public interface IWriteBackDataSet : IList
    {
        /// <summary>
        /// Write-back Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Write-back Description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The expected location for this write-back
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// Indicates if the data set exists in the write-back directory
        /// </summary>
        bool IsPresent { get; }

        /// <summary>
        /// Timestamp of the write-back
        /// </summary>
        DateTime? Age { get; }

        /// <summary>
        /// Response from the last write-back processed
        /// </summary>
        IWriteBackResponse LatestResponse { get; }
    }
}
