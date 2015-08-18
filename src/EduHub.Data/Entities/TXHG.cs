using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records
    /// </summary>
    public class TXHG : EntityBase
    {
#region Navigation Property Cache
        private KGC _HOME_GROUP_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// Unique ID for this record
        /// </summary>
        public int TXHG_ID { get; internal set; }
        /// <summary>
        /// The date to which this record applies
        /// </summary>
        public DateTime? TXHG_DATE { get; internal set; }
        /// <summary>
        /// The home group to which this record applies
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string HOME_GROUP { get; internal set; }
        /// <summary>
        /// Has the AM roll been marked? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_ROLL_MARKED { get; internal set; }
        /// <summary>
        /// Has the PM roll been marked? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_ROLL_MARKED { get; internal set; }
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
        /// <summary>
        /// Navigation property for [HOME_GROUP] => [KGC].[KGCKEY]
        /// The home group to which this record applies
        /// </summary>
        public KGC HOME_GROUP_KGC {
            get
            {
                if (HOME_GROUP != null)
                {
                    if (_HOME_GROUP_KGC == null)
                    {
                        _HOME_GROUP_KGC = Context.KGC.FindByKGCKEY(HOME_GROUP);
                    }
                    return _HOME_GROUP_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
