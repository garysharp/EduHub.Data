using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Eligibility Criteria
    /// </summary>
    public class SGHG_Entity : EntityBase
    {
#region Navigation Property Cache
        private SG_Entity _SGHGKEY_SG;
        private KGC_Entity _KGCLINK_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group for which this is a criterion [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGHGKEY { get; internal set; }
        /// <summary>
        /// Code of home group which is a criterion for membership in group SGSGKEY [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KGCLINK { get; internal set; }
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
        /// <summary>
        /// Navigation property for [SGHGKEY] => [SG_Entity].[SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG_Entity SGHGKEY_SG {
            get
            {
                if (SGHGKEY != null)
                {
                    if (_SGHGKEY_SG == null)
                    {
                        _SGHGKEY_SG = Context.SG.FindBySGKEY(SGHGKEY);
                    }
                    return _SGHGKEY_SG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [KGCLINK] => [KGC_Entity].[KGCKEY]
        /// Code of home group which is a criterion for membership in group SGSGKEY
        /// </summary>
        public KGC_Entity KGCLINK_KGC {
            get
            {
                if (KGCLINK != null)
                {
                    if (_KGCLINK_KGC == null)
                    {
                        _KGCLINK_KGC = Context.KGC.FindByKGCKEY(KGCLINK);
                    }
                    return _KGCLINK_KGC;
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
