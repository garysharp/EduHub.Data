using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject/Class Eligibility Criteria
    /// </summary>
    public class SGSC : EntityBase
    {
#region Navigation Property Cache
        private SG _SGSCKEY_SG;
        private SU _SULINK_SU;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group for which this is a criterion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGSCKEY { get; internal set; }
        /// <summary>
        /// Code of subject which is a criterion for membership in group SGSGKEY
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SULINK { get; internal set; }
        /// <summary>
        /// Code of class which is a criterion for membership in group SGSGKEY
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTPERIOD { get; internal set; }
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
        /// Navigation property for [SGSCKEY] => [SG].[SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG SGSCKEY_SG {
            get
            {
                if (SGSCKEY != null)
                {
                    if (_SGSCKEY_SG == null)
                    {
                        _SGSCKEY_SG = Context.SG.FindBySGKEY(SGSCKEY);
                    }
                    return _SGSCKEY_SG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SULINK] => [SU].[SUKEY]
        /// Code of subject which is a criterion for membership in group SGSGKEY
        /// </summary>
        public SU SULINK_SU {
            get
            {
                if (SULINK != null)
                {
                    if (_SULINK_SU == null)
                    {
                        _SULINK_SU = Context.SU.FindBySUKEY(SULINK);
                    }
                    return _SULINK_SU;
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
