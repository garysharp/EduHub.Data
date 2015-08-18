using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Data Export
    /// </summary>
    public class FDT_EXP : EntityBase
    {
#region Navigation Property Cache
        private SKGS _DEST_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string DEST { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string DEST_ID { get; internal set; }
        /// <summary>
        /// Table/Type of Fin data (CR,DR,PE etc)
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SOURCE { get; internal set; }
        /// <summary>
        /// Source Record Key  (CRKEY, DRKEY, PEKEY etc)
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SOURCE_KEY { get; internal set; }
        /// <summary>
        /// Export Comment
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Date exported to disk
        /// </summary>
        public DateTime? EXP_DATE { get; internal set; }
        /// <summary>
        /// Time exported to disk
        /// </summary>
        public short? EXP_TIME { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [DEST] => [SKGS].[SCHOOL]
        /// 
        /// </summary>
        public SKGS DEST_SKGS {
            get
            {
                if (DEST != null)
                {
                    if (_DEST_SKGS == null)
                    {
                        _DEST_SKGS = Context.SKGS.FindBySCHOOL(DEST);
                    }
                    return _DEST_SKGS;
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
