using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCM Transfer
    /// </summary>
    public partial class KCM_TFR : EntityBase
    {
#region Navigation Property Cache
        private SKGS _ORIG_SCHOOL_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Orignating School
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }
        /// <summary>
        /// Unique KCM Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string KCM_TRANS_ID { get; internal set; }
        /// <summary>
        /// Medical Condition code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCMKEY { get; internal set; }
        /// <summary>
        /// New Meidcal Cond code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCMKEY_NEW { get; internal set; }
        /// <summary>
        /// Long description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Current Status of Import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string IMP_STATUS { get; internal set; }
        /// <summary>
        /// Actual Date data transfered into live table
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }
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
        /// SKGS (Schools) related entity by [KCM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS ORIG_SCHOOL_SKGS
        {
            get
            {
                if (ORIG_SCHOOL != null)
                {
                    if (_ORIG_SCHOOL_SKGS == null)
                    {
                        _ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                    }
                    return _ORIG_SCHOOL_SKGS;
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
