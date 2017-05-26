using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// STVDO Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDO_TR : EduHubEntity
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
        /// Unique STVDO Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string STVDO_TRANS_ID { get; internal set; }

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
        /// Year level at the time of result
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }

        /// <summary>
        /// Campus at the time of the result
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// YYYY.S eg 2005.1
        /// [Alphanumeric (6)]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }

        /// <summary>
        /// Link to domain
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string VDOMAIN { get; internal set; }

        /// <summary>
        /// Link to dimension
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string VDIMENSION { get; internal set; }

        /// <summary>
        /// Grade assigned to student A to E
        /// [Alphanumeric (6)]
        /// </summary>
        public string SCORE { get; internal set; }

        /// <summary>
        /// Original school
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIGINAL_SCHOOL { get; internal set; }

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
        /// SKGS (Schools) related entity by [STVDO_TR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
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
