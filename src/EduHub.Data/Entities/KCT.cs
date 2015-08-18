using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types
    /// </summary>
    public class KCT : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Absence type code
        /// </summary>
        public short KCTKEY { get; internal set; }
        /// <summary>
        /// Description of absence type
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Abbreviated description of absence type
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ABBREV_DESC { get; internal set; }
        /// <summary>
        /// Is absence type curriculum-related? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CURRICULUM { get; internal set; }
        /// <summary>
        /// Corresponding DEET absence type code for statistics purposes
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DOE_TYPE { get; internal set; }
        /// <summary>
        /// Has this absence type been enabled by the school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENABLED { get; internal set; }
        /// <summary>
        /// Is this absence type pre-approved? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRE_APPROVED { get; internal set; }
        /// <summary>
        /// Value of Absence Rate, Negative or Positive Integer
        /// </summary>
        public short? ABS_RATE { get; internal set; }
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

#region Navigation Properties
#endregion
    }
}
