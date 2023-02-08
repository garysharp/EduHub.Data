#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHR : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private BKH Cache_BKHRKEY_BKH;
#endif
        private ST Cache_STUDENT_ST;
        private SF Cache_STAFF_SF;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Book code of book
        /// [Uppercase Alphanumeric (13)]
        /// </summary>
        public string BKHRKEY { get; internal set; }

        /// <summary>
        /// Copy number
        /// </summary>
        public short? REF_NUMBER { get; internal set; }

        /// <summary>
        /// Student ID of student making loan
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT { get; internal set; }

        /// <summary>
        /// Staff code of staff member making loan
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }

        /// <summary>
        /// Date of loan
        /// </summary>
        public DateTime? ISSUE_DATE { get; internal set; }

        /// <summary>
        /// Date due to be returned
        /// </summary>
        public DateTime? DUE_DATE { get; internal set; }

        /// <summary>
        /// Date of return
        /// </summary>
        public DateTime? RETURNED_DATE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Memo]
        /// </summary>
        public string CONDITION { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// BKH (Books for Hire) related entity by [BKHR.BKHRKEY]-&gt;[BKH.BKHKEY]
        /// Book code of book
        /// </summary>
        public BKH BKHRKEY_BKH
        {
            get
            {
                if (Cache_BKHRKEY_BKH == null)
                {
                    Cache_BKHRKEY_BKH = Context.BKH.FindByBKHKEY(BKHRKEY);
                }

                return Cache_BKHRKEY_BKH;
            }
        }

#endif
        /// <summary>
        /// ST (Students) related entity by [BKHR.STUDENT]-&gt;[ST.STKEY]
        /// Student ID of student making loan
        /// </summary>
        public ST STUDENT_ST
        {
            get
            {
                if (STUDENT == null)
                {
                    return null;
                }
                if (Cache_STUDENT_ST == null)
                {
                    Cache_STUDENT_ST = Context.ST.FindBySTKEY(STUDENT);
                }

                return Cache_STUDENT_ST;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [BKHR.STAFF]-&gt;[SF.SFKEY]
        /// Staff code of staff member making loan
        /// </summary>
        public SF STAFF_SF
        {
            get
            {
                if (STAFF == null)
                {
                    return null;
                }
                if (Cache_STAFF_SF == null)
                {
                    Cache_STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                }

                return Cache_STAFF_SF;
            }
        }

        #endregion

    }
}
#endif
