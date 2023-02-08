#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// STPS Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPS_TFR : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_ORIG_SCHOOL_SKGS;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Originating School
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }

        /// <summary>
        /// Unique STPS Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string STPS_TRANS_ID { get; internal set; }

        /// <summary>
        /// Original student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// New student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY_NEW { get; internal set; }

        /// <summary>
        /// School attended
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL { get; internal set; }

        /// <summary>
        /// Enrolment date
        /// </summary>
        public DateTime? ENROL_DATE { get; internal set; }

        /// <summary>
        /// Departure date
        /// </summary>
        public DateTime? DEPART_DATE { get; internal set; }

        /// <summary>
        /// Reason for leaving
        /// [Memo]
        /// </summary>
        public string REASON_LEFT { get; internal set; }

        /// <summary>
        /// Unique ST Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }

        /// <summary>
        /// Current status of import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string IMP_STATUS { get; internal set; }

        /// <summary>
        /// Actual date data transferred into live table
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
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// SKGS (Schools) related entity by [STPS_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Originating School
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
#endif
