using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties
    /// </summary>
    public partial class KSF : EntityBase
    {
#region Navigation Property Cache
        private SF _COORDINATOR_SF;
#endregion

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
                if (COORDINATOR != null)
                {
                    if (_COORDINATOR_SF == null)
                    {
                        _COORDINATOR_SF = Context.SF.FindBySFKEY(COORDINATOR);
                    }
                    return _COORDINATOR_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.FACULTY01]-&gt;[KSF.KSFKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_FACULTY01
        {
            get
            {
                return Context.KSF.FindSFByFACULTY01(KSFKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.FACULTY02]-&gt;[KSF.KSFKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_FACULTY02
        {
            get
            {
                return Context.KSF.FindSFByFACULTY02(KSFKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.FACULTY03]-&gt;[KSF.KSFKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_FACULTY03
        {
            get
            {
                return Context.KSF.FindSFByFACULTY03(KSFKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.FACULTY04]-&gt;[KSF.KSFKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_FACULTY04
        {
            get
            {
                return Context.KSF.FindSFByFACULTY04(KSFKEY);
            }
        }

        /// <summary>
        /// SM (Rooms) related entities by [SM.FACULTY]-&gt;[KSF.KSFKEY]
        /// </summary>
        public IReadOnlyList<SM> SM_FACULTY
        {
            get
            {
                return Context.KSF.FindSMByFACULTY(KSFKEY);
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [SU.FACULTY]-&gt;[KSF.KSFKEY]
        /// </summary>
        public IReadOnlyList<SU> SU_FACULTY
        {
            get
            {
                return Context.KSF.FindSUByFACULTY(KSFKEY);
            }
        }
#endregion
    }
}
