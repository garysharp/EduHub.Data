using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group
    /// </summary>
    public partial class SSHG : EntityBase
    {
#region Navigation Property Cache
        private KGC _HOMEGROUP_KGC;
        private SS _SUBJECT_SS;
        private SF _TEACHER_SF;
        private ST _STUDENT_ST;
        private KGC _TEACHING_HG_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// Record identifier
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Home group ID
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string HOMEGROUP { get; internal set; }
        /// <summary>
        /// Subject ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Teacher ID
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// IN or OUT
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VARIATION { get; internal set; }
        /// <summary>
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise.
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string TEACHING_HG { get; internal set; }
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
        /// KGC (Home Groups) related entity by [SSHG.HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// Home group ID
        /// </summary>
        public KGC HOMEGROUP_KGC
        {
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
        /// SS (Specialist Subjects) related entity by [SSHG.SUBJECT]-&gt;[SS.SSKEY]
        /// Subject ID
        /// </summary>
        public SS SUBJECT_SS
        {
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
        /// SF (Staff) related entity by [SSHG.TEACHER]-&gt;[SF.SFKEY]
        /// Teacher ID
        /// </summary>
        public SF TEACHER_SF
        {
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
        /// ST (Students) related entity by [SSHG.STUDENT]-&gt;[ST.STKEY]
        /// Student ID
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
        /// KGC (Home Groups) related entity by [SSHG.TEACHING_HG]-&gt;[KGC.KGCKEY]
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise.
        /// </summary>
        public KGC TEACHING_HG_KGC
        {
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
