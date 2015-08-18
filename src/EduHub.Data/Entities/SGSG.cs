using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Membership Eligibility Criteria
    /// </summary>
    public class SGSG : EntityBase
    {
#region Navigation Property Cache
        private SG _SGSGKEY_SG;
        private SG _SGLINK_SG;
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
        public string SGSGKEY { get; internal set; }
        /// <summary>
        /// Code of group membership of which is a criterion for membership in group SGSGKEY
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGLINK { get; internal set; }
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
        /// Navigation property for [SGSGKEY] => [SG].[SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG SGSGKEY_SG {
            get
            {
                if (SGSGKEY != null)
                {
                    if (_SGSGKEY_SG == null)
                    {
                        _SGSGKEY_SG = Context.SG.FindBySGKEY(SGSGKEY);
                    }
                    return _SGSGKEY_SG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SGLINK] => [SG].[SGKEY]
        /// Code of group membership of which is a criterion for membership in group SGSGKEY
        /// </summary>
        public SG SGLINK_SG {
            get
            {
                if (SGLINK != null)
                {
                    if (_SGLINK_SG == null)
                    {
                        _SGLINK_SG = Context.SG.FindBySGKEY(SGLINK);
                    }
                    return _SGLINK_SG;
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
