using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Eligibility Criteria
    /// </summary>
    public partial class SGHG : EntityBase
    {
#region Navigation Property Cache
        private SG _SGHGKEY_SG;
        private KGC _KGCLINK_KGC;
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
        public string SGHGKEY { get; internal set; }
        /// <summary>
        /// Code of home group which is a criterion for membership in group SGSGKEY
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KGCLINK { get; internal set; }
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
        /// SG (Student Groupings) related entity by [SGHG.SGHGKEY]-&gt;[SG.SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG SGHGKEY_SG
        {
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
        /// KGC (Home Groups) related entity by [SGHG.KGCLINK]-&gt;[KGC.KGCKEY]
        /// Code of home group which is a criterion for membership in group SGSGKEY
        /// </summary>
        public KGC KGCLINK_KGC
        {
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
