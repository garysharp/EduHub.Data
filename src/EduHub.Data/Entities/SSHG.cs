using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SSHG : EduHubEntity
    {

        #region Navigation Property Cache

        private KGC Cache_HOMEGROUP_KGC;
        private SS Cache_SUBJECT_SS;
        private SF Cache_TEACHER_SF;
        private ST Cache_STUDENT_ST;
        private KGC Cache_TEACHING_HG_KGC;

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
        /// Record identifier
        /// </summary>
        public int TID { get; internal set; }

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
                if (HOMEGROUP == null)
                {
                    return null;
                }
                if (Cache_HOMEGROUP_KGC == null)
                {
                    Cache_HOMEGROUP_KGC = Context.KGC.FindByKGCKEY(HOMEGROUP);
                }

                return Cache_HOMEGROUP_KGC;
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
                if (Cache_SUBJECT_SS == null)
                {
                    Cache_SUBJECT_SS = Context.SS.FindBySSKEY(SUBJECT);
                }

                return Cache_SUBJECT_SS;
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
                if (TEACHER == null)
                {
                    return null;
                }
                if (Cache_TEACHER_SF == null)
                {
                    Cache_TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                }

                return Cache_TEACHER_SF;
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
        /// KGC (Home Groups) related entity by [SSHG.TEACHING_HG]-&gt;[KGC.KGCKEY]
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise.
        /// </summary>
        public KGC TEACHING_HG_KGC
        {
            get
            {
                if (TEACHING_HG == null)
                {
                    return null;
                }
                if (Cache_TEACHING_HG_KGC == null)
                {
                    Cache_TEACHING_HG_KGC = Context.KGC.FindByKGCKEY(TEACHING_HG);
                }

                return Cache_TEACHING_HG_KGC;
            }
        }

        #endregion

    }
}
