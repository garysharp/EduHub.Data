using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family/Student ID Sequence Numbers
    /// </summary>
    public partial class KNFS : EntityBase
    {
#region Field Properties
        /// <summary>
        /// First 3 characters of Family/Student Name
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KNFSKEY { get; internal set; }
        /// <summary>
        /// Next sequence number to be used
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string NEXT_NUMBER { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion
    }
}
