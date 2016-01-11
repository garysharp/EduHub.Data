using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCM Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCM_TFR : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_ORIG_SCHOOL_SKGS;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

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
                if (Cache_ORIG_SCHOOL_SKGS == null)
                {
                    Cache_ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                }

                return Cache_ORIG_SCHOOL_SKGS;
            }
        }

        #endregion

    }
}
