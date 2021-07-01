using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SS : EduHubEntity
    {

        #region Navigation Property Cache

        private KGC Cache_FROM_HOMEGROUP_KGC;
        private KGC Cache_TO_HOMEGROUP_KGC;
        private SF Cache_DEFAULT_TEACHER_SF;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SSHG> Cache_SSKEY_SSHG_SUBJECT;

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
        /// Subject code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SSKEY { get; internal set; }

        /// <summary>
        /// Subject name
        /// [Titlecase (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Minimum home group taking the subject
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string FROM_HOMEGROUP { get; internal set; }

        /// <summary>
        /// Maximum home group taking the subject
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string TO_HOMEGROUP { get; internal set; }

        /// <summary>
        /// Specialist subject active Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

        /// <summary>
        /// Optional default teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string DEFAULT_TEACHER { get; internal set; }

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
        /// KGC (Home Groups) related entity by [SS.FROM_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// Minimum home group taking the subject
        /// </summary>
        public KGC FROM_HOMEGROUP_KGC
        {
            get
            {
                if (FROM_HOMEGROUP == null)
                {
                    return null;
                }
                if (Cache_FROM_HOMEGROUP_KGC == null)
                {
                    Cache_FROM_HOMEGROUP_KGC = Context.KGC.FindByKGCKEY(FROM_HOMEGROUP);
                }

                return Cache_FROM_HOMEGROUP_KGC;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [SS.TO_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// Maximum home group taking the subject
        /// </summary>
        public KGC TO_HOMEGROUP_KGC
        {
            get
            {
                if (TO_HOMEGROUP == null)
                {
                    return null;
                }
                if (Cache_TO_HOMEGROUP_KGC == null)
                {
                    Cache_TO_HOMEGROUP_KGC = Context.KGC.FindByKGCKEY(TO_HOMEGROUP);
                }

                return Cache_TO_HOMEGROUP_KGC;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SS.DEFAULT_TEACHER]-&gt;[SF.SFKEY]
        /// Optional default teacher
        /// </summary>
        public SF DEFAULT_TEACHER_SF
        {
            get
            {
                if (DEFAULT_TEACHER == null)
                {
                    return null;
                }
                if (Cache_DEFAULT_TEACHER_SF == null)
                {
                    Cache_DEFAULT_TEACHER_SF = Context.SF.FindBySFKEY(DEFAULT_TEACHER);
                }

                return Cache_DEFAULT_TEACHER_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [SS.SSKEY]-&gt;[SSHG.SUBJECT]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SSHG> SSKEY_SSHG_SUBJECT
        {
            get
            {
                if (Cache_SSKEY_SSHG_SUBJECT == null &&
                    !Context.SSHG.TryFindBySUBJECT(SSKEY, out Cache_SSKEY_SSHG_SUBJECT))
                {
                    Cache_SSKEY_SSHG_SUBJECT = new List<SSHG>().AsReadOnly();
                }

                return Cache_SSKEY_SSHG_SUBJECT;
            }
        }

        #endregion

    }
}
