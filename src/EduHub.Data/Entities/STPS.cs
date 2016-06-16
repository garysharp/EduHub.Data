using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Previous School
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPS : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private SKGS Cache_SCHOOL_SKGS;

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
        /// Original student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

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
        /// ST (Students) related entity by [STPS.SKEY]-&gt;[ST.STKEY]
        /// Original student key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (Cache_SKEY_ST == null)
                {
                    Cache_SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                }

                return Cache_SKEY_ST;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STPS.SCHOOL]-&gt;[SKGS.SCHOOL]
        /// School attended
        /// </summary>
        public SKGS SCHOOL_SKGS
        {
            get
            {
                if (SCHOOL == null)
                {
                    return null;
                }
                if (Cache_SCHOOL_SKGS == null)
                {
                    Cache_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(SCHOOL);
                }

                return Cache_SCHOOL_SKGS;
            }
        }

        #endregion

    }
}
