using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records
    /// </summary>
    public class TXHG_Entity : EntityBase
    {
        /// <summary>
        /// Unique ID for this record [Integer (32bit signed): l]
        /// </summary>
        public int TXHG_ID { get; internal set; }
        /// <summary>
        /// The date to which this record applies [Date Time nullable: d]
        /// </summary>
        public DateTime? TXHG_DATE { get; internal set; }
        /// <summary>
        /// The home group to which this record applies [Uppercase Alphanumeric: u3]
        /// </summary>
        public string HOME_GROUP { get; internal set; }
        /// <summary>
        /// Navigation property for [HOME_GROUP] => [KGC_Entity].[KGCKEY]
        /// The home group to which this record applies
        /// </summary>
        public KGC_Entity HOME_GROUP_KGC { get { return HOME_GROUP == null ? null : Context.KGC.FindByKGCKEY(HOME_GROUP); } }
        /// <summary>
        /// Has the AM roll been marked? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AM_ROLL_MARKED { get; internal set; }
        /// <summary>
        /// Has the PM roll been marked? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PM_ROLL_MARKED { get; internal set; }
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
        
        
    }
}
