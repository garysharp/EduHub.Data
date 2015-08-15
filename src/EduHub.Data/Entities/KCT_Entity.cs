using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types
    /// </summary>
    public class KCT_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Absence type code [Integer (16bit signed): i]
        /// </summary>
        public short KCTKEY { get; internal set; }
        /// <summary>
        /// Description of absence type [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Abbreviated description of absence type [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ABBREV_DESC { get; internal set; }
        /// <summary>
        /// Is absence type curriculum-related? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CURRICULUM { get; internal set; }
        /// <summary>
        /// Corresponding DEET absence type code for statistics purposes [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DOE_TYPE { get; internal set; }
        /// <summary>
        /// Has this absence type been enabled by the school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENABLED { get; internal set; }
        /// <summary>
        /// Is this absence type pre-approved? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRE_APPROVED { get; internal set; }
        /// <summary>
        /// Value of Absence Rate, Negative or Positive Integer [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ABS_RATE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
