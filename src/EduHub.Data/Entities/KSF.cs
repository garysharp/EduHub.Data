using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSF : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_COORDINATOR_SF;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SF> Cache_KSFKEY_SF_FACULTY01;
        private IReadOnlyList<SF> Cache_KSFKEY_SF_FACULTY02;
        private IReadOnlyList<SF> Cache_KSFKEY_SF_FACULTY03;
        private IReadOnlyList<SF> Cache_KSFKEY_SF_FACULTY04;
        private IReadOnlyList<SM> Cache_KSFKEY_SM_FACULTY;
        private IReadOnlyList<SU> Cache_KSFKEY_SU_FACULTY;

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
        /// Faculty code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KSFKEY { get; internal set; }

        /// <summary>
        /// Faculty name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Staff code of KLA co-ordinator
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string COORDINATOR { get; internal set; }

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
        /// SF (Staff) related entity by [KSF.COORDINATOR]-&gt;[SF.SFKEY]
        /// Staff code of KLA co-ordinator
        /// </summary>
        public SF COORDINATOR_SF
        {
            get
            {
                if (COORDINATOR == null)
                {
                    return null;
                }
                if (Cache_COORDINATOR_SF == null)
                {
                    Cache_COORDINATOR_SF = Context.SF.FindBySFKEY(COORDINATOR);
                }

                return Cache_COORDINATOR_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SF (Staff) related entities by [KSF.KSFKEY]-&gt;[SF.FACULTY01]
        /// Faculty code
        /// </summary>
        public IReadOnlyList<SF> KSFKEY_SF_FACULTY01
        {
            get
            {
                if (Cache_KSFKEY_SF_FACULTY01 == null &&
                    !Context.SF.TryFindByFACULTY01(KSFKEY, out Cache_KSFKEY_SF_FACULTY01))
                {
                    Cache_KSFKEY_SF_FACULTY01 = new List<SF>().AsReadOnly();
                }

                return Cache_KSFKEY_SF_FACULTY01;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KSF.KSFKEY]-&gt;[SF.FACULTY02]
        /// Faculty code
        /// </summary>
        public IReadOnlyList<SF> KSFKEY_SF_FACULTY02
        {
            get
            {
                if (Cache_KSFKEY_SF_FACULTY02 == null &&
                    !Context.SF.TryFindByFACULTY02(KSFKEY, out Cache_KSFKEY_SF_FACULTY02))
                {
                    Cache_KSFKEY_SF_FACULTY02 = new List<SF>().AsReadOnly();
                }

                return Cache_KSFKEY_SF_FACULTY02;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KSF.KSFKEY]-&gt;[SF.FACULTY03]
        /// Faculty code
        /// </summary>
        public IReadOnlyList<SF> KSFKEY_SF_FACULTY03
        {
            get
            {
                if (Cache_KSFKEY_SF_FACULTY03 == null &&
                    !Context.SF.TryFindByFACULTY03(KSFKEY, out Cache_KSFKEY_SF_FACULTY03))
                {
                    Cache_KSFKEY_SF_FACULTY03 = new List<SF>().AsReadOnly();
                }

                return Cache_KSFKEY_SF_FACULTY03;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KSF.KSFKEY]-&gt;[SF.FACULTY04]
        /// Faculty code
        /// </summary>
        public IReadOnlyList<SF> KSFKEY_SF_FACULTY04
        {
            get
            {
                if (Cache_KSFKEY_SF_FACULTY04 == null &&
                    !Context.SF.TryFindByFACULTY04(KSFKEY, out Cache_KSFKEY_SF_FACULTY04))
                {
                    Cache_KSFKEY_SF_FACULTY04 = new List<SF>().AsReadOnly();
                }

                return Cache_KSFKEY_SF_FACULTY04;
            }
        }

        /// <summary>
        /// SM (Rooms) related entities by [KSF.KSFKEY]-&gt;[SM.FACULTY]
        /// Faculty code
        /// </summary>
        public IReadOnlyList<SM> KSFKEY_SM_FACULTY
        {
            get
            {
                if (Cache_KSFKEY_SM_FACULTY == null &&
                    !Context.SM.TryFindByFACULTY(KSFKEY, out Cache_KSFKEY_SM_FACULTY))
                {
                    Cache_KSFKEY_SM_FACULTY = new List<SM>().AsReadOnly();
                }

                return Cache_KSFKEY_SM_FACULTY;
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [KSF.KSFKEY]-&gt;[SU.FACULTY]
        /// Faculty code
        /// </summary>
        public IReadOnlyList<SU> KSFKEY_SU_FACULTY
        {
            get
            {
                if (Cache_KSFKEY_SU_FACULTY == null &&
                    !Context.SU.TryFindByFACULTY(KSFKEY, out Cache_KSFKEY_SU_FACULTY))
                {
                    Cache_KSFKEY_SU_FACULTY = new List<SU>().AsReadOnly();
                }

                return Cache_KSFKEY_SU_FACULTY;
            }
        }

        #endregion

    }
}
