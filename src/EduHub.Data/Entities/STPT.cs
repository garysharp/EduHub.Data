using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments
    /// </summary>
    public partial class STPT : EntityBase
    {
#region Navigation Property Cache
        private ST _STPTKEY_ST;
        private SKGS _SCHL_NUM_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STPTKEY { get; internal set; }
        /// <summary>
        /// ID of school (could be home school)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHL_NUM { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year
        /// </summary>
        public double? SGB_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Time fraction of student's attendance
        /// </summary>
        public double? ACTUAL_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENROLLED { get; internal set; }
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
        /// ST (Students) related entity by [STPT.STPTKEY]-&gt;[ST.STKEY]
        /// Student ID
        /// </summary>
        public ST STPTKEY_ST
        {
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
        /// SKGS (Schools) related entity by [STPT.SCHL_NUM]-&gt;[SKGS.SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS SCHL_NUM_SKGS
        {
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
