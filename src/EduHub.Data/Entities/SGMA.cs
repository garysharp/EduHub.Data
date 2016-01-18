using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Meeting Attendance
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGMA : EduHubEntity
    {

        #region Navigation Property Cache

        private SG Cache_SGMAKEY_SG;

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
        /// SG (Student Groupings) related entity by [SGMA.SGMAKEY]-&gt;[SG.SGKEY]
        /// Code of group holding this meeting
        /// </summary>
        public SG SGMAKEY_SG
        {
            get
            {
                if (Cache_SGMAKEY_SG == null)
                {
                    Cache_SGMAKEY_SG = Context.SG.FindBySGKEY(SGMAKEY);
                }

                return Cache_SGMAKEY_SG;
            }
        }

        #endregion

    }
}
