using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments
    /// </summary>
    public class STPT_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _STPTKEY_ST;
        private SKGS_Entity _SCHL_NUM_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STPTKEY { get; internal set; }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string SCHL_NUM { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SGB_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Time fraction of student's attendance [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ACTUAL_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENROLLED { get; internal set; }
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
        /// Navigation property for [STPTKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STPTKEY_ST {
            get
            {
                if (STPTKEY != null)
                {
                    if (_STPTKEY_ST == null)
                    {
                        _STPTKEY_ST = Context.ST.FindBySTKEY(STPTKEY);
                    }
                    return _STPTKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCHL_NUM] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity SCHL_NUM_SKGS {
            get
            {
                if (SCHL_NUM != null)
                {
                    if (_SCHL_NUM_SKGS == null)
                    {
                        _SCHL_NUM_SKGS = Context.SKGS.FindBySCHOOL(SCHL_NUM);
                    }
                    return _SCHL_NUM_SKGS;
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
