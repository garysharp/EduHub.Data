using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records
    /// </summary>
    public class BKHR_Entity : EntityBase
    {
#region Navigation Property Cache
        private BKH_Entity _BKHRKEY_BKH;
        private ST_Entity _STUDENT_ST;
        private SF_Entity _STAFF_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Book code of book [Uppercase Alphanumeric: u13]
        /// </summary>
        public string BKHRKEY { get; internal set; }
        /// <summary>
        /// Copy number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? REF_NUMBER { get; internal set; }
        /// <summary>
        /// Student ID of student making loan [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// Staff code of staff member making loan [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Date of loan [Date Time nullable: d]
        /// </summary>
        public DateTime? ISSUE_DATE { get; internal set; }
        /// <summary>
        /// Date due to be returned [Date Time nullable: d]
        /// </summary>
        public DateTime? DUE_DATE { get; internal set; }
        /// <summary>
        /// Date of return [Date Time nullable: d]
        /// </summary>
        public DateTime? RETURNED_DATE { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string CONDITION { get; internal set; }
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
        /// Navigation property for [BKHRKEY] => [BKH_Entity].[BKHKEY]
        /// Book code of book
        /// </summary>
        public BKH_Entity BKHRKEY_BKH {
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
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student ID of student making loan
        /// </summary>
        public ST_Entity STUDENT_ST {
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
        /// Navigation property for [STAFF] => [SF_Entity].[SFKEY]
        /// Staff code of staff member making loan
        /// </summary>
        public SF_Entity STAFF_SF {
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
