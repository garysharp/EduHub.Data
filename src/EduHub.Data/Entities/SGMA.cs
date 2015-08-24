﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Meeting Attendance
    /// </summary>
    public class SGMA : EntityBase
    {
#region Navigation Property Cache
        private SG _SGMAKEY_SG;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group holding this meeting
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGMAKEY { get; internal set; }
        /// <summary>
        /// TID of the meeting
        /// </summary>
        public int? SGM_TID { get; internal set; }
        /// <summary>
        /// Is this person a student, staff member or parent/guardian? ST=Student, SF=Staff Member, DF=Parent/guardian
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string MEMBER_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code of this person in table ST, SF or DF
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string MEMBER_LINK { get; internal set; }
        /// <summary>
        /// (If this person is a parent/guardian) Identifies which of the two adults in the family this person is
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DF_PARTICIPATION { get; internal set; }
        /// <summary>
        /// Did this person attended this meeting? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ATTENDED { get; internal set; }
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
        /// Navigation property for [SGMAKEY] => [SG].[SGKEY]
        /// Code of group holding this meeting
        /// </summary>
        public SG SGMAKEY_SG {
            get
            {
                if (SGMAKEY != null)
                {
                    if (_SGMAKEY_SG == null)
                    {
                        _SGMAKEY_SG = Context.SG.FindBySGKEY(SGMAKEY);
                    }
                    return _SGMAKEY_SG;
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