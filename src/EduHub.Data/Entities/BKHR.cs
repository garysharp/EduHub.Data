using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records
    /// </summary>
    public partial class BKHR : EntityBase
    {
#region Navigation Property Cache
        private BKH _BKHRKEY_BKH;
        private ST _STUDENT_ST;
        private SF _STAFF_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
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
        /// 
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

        /// <summary>
        /// BKH (Books for Hire) related entity by [BKHR.BKHRKEY]-&gt;[BKH.BKHKEY]
        /// Book code of book
        /// </summary>
        public BKH BKHRKEY_BKH
        {
            get
            {
                if (BKHRKEY != null)
                {
                    if (_BKHRKEY_BKH == null)
                    {
                        _BKHRKEY_BKH = Context.BKH.FindByBKHKEY(BKHRKEY);
                    }
                    return _BKHRKEY_BKH;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ST (Students) related entity by [BKHR.STUDENT]-&gt;[ST.STKEY]
        /// Student ID of student making loan
        /// </summary>
        public ST STUDENT_ST
        {
            get
            {
                if (STUDENT != null)
                {
                    if (_STUDENT_ST == null)
                    {
                        _STUDENT_ST = Context.ST.FindBySTKEY(STUDENT);
                    }
                    return _STUDENT_ST;
                }
                else
                {
                    return null;
                }
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
                if (STAFF != null)
                {
                    if (_STAFF_SF == null)
                    {
                        _STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                    }
                    return _STAFF_SF;
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
