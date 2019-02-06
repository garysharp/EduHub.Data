using System;
using System.Collections.Generic;

namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Write-Back Response
    /// </summary>
    public interface IWriteBackResponse
    {
        /// <summary>
        /// Write-Back Data Set
        /// </summary>
        IWriteBackDataSet DataSet { get; }

        /// <summary>
        /// Location of write-back response file
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// Time write-back response was generated
        /// </summary>
        DateTime Age { get; }

        /// <summary>
        /// Indicates if the response is positive
        /// </summary>
        bool IsSuccess { get; }

        /// <summary>
        /// If failure, a generic error message, otherwise the success message
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Records associated with this response
        /// </summary>
        IEnumerable<IWriteBackResponseRecord> Records { get; }
    }
}
