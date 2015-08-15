using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group
    /// </summary>
    public class SSHG_Entity : EntityBase
    {
#region Navigation Property Cache
        private KGC_Entity _HOMEGROUP_KGC;
        private SS_Entity _SUBJECT_SS;
        private SF_Entity _TEACHER_SF;
        private ST_Entity _STUDENT_ST;
        private KGC_Entity _TEACHING_HG_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// Record identifier [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Home group ID [Uppercase Alphanumeric: u3]
        /// </summary>
        public string HOMEGROUP { get; internal set; }
        /// <summary>
        /// Subject ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Teacher ID [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// IN or OUT [Uppercase Alphanumeric: u3]
        /// </summary>
        public string VARIATION { get; internal set; }
        /// <summary>
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise. [Uppercase Alphanumeric: u3]
        /// </summary>
        public string TEACHING_HG { get; internal set; }
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
        /// Navigation property for [HOMEGROUP] => [KGC_Entity].[KGCKEY]
        /// Home group ID
        /// </summary>
        public KGC_Entity HOMEGROUP_KGC {
            get
            {
                if (HOMEGROUP != null)
                {
                    if (_HOMEGROUP_KGC == null)
                    {
                        _HOMEGROUP_KGC = Context.KGC.FindByKGCKEY(HOMEGROUP);
                    }
                    return _HOMEGROUP_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT] => [SS_Entity].[SSKEY]
        /// Subject ID
        /// </summary>
        public SS_Entity SUBJECT_SS {
            get
            {
                if (SUBJECT != null)
                {
                    if (_SUBJECT_SS == null)
                    {
                        _SUBJECT_SS = Context.SS.FindBySSKEY(SUBJECT);
                    }
                    return _SUBJECT_SS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER] => [SF_Entity].[SFKEY]
        /// Teacher ID
        /// </summary>
        public SF_Entity TEACHER_SF {
            get
            {
                if (TEACHER != null)
                {
                    if (_TEACHER_SF == null)
                    {
                        _TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                    }
                    return _TEACHER_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student ID
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
        /// Navigation property for [TEACHING_HG] => [KGC_Entity].[KGCKEY]
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise.
        /// </summary>
        public KGC_Entity TEACHING_HG_KGC {
            get
            {
                if (TEACHING_HG != null)
                {
                    if (_TEACHING_HG_KGC == null)
                    {
                        _TEACHING_HG_KGC = Context.KGC.FindByKGCKEY(TEACHING_HG);
                    }
                    return _TEACHING_HG_KGC;
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
