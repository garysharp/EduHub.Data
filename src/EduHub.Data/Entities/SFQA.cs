using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications
    /// </summary>
    public partial class SFQA : EntityBase
    {
#region Navigation Property Cache
        private SF _TEACH_SF;
        private KSQ _QUALIFICATION_KSQ;
        private KSI _INSTITUTION_KSI;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff code of teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Name of qualification
        /// [Alphanumeric (30)]
        /// </summary>
        public string QUALIFICATION { get; internal set; }
        /// <summary>
        /// When completed
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string YEAR_COMPLETED { get; internal set; }
        /// <summary>
        /// Where studied
        /// [Alphanumeric (30)]
        /// </summary>
        public string INSTITUTION { get; internal set; }
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
        /// SF (Staff) related entity by [SFQA.TEACH]-&gt;[SF.SFKEY]
        /// Staff code of teacher
        /// </summary>
        public SF TEACH_SF
        {
            get
            {
                if (TEACH != null)
                {
                    if (_TEACH_SF == null)
                    {
                        _TEACH_SF = Context.SF.FindBySFKEY(TEACH);
                    }
                    return _TEACH_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KSQ (Available Qualifications) related entity by [SFQA.QUALIFICATION]-&gt;[KSQ.KSQKEY]
        /// Name of qualification
        /// </summary>
        public KSQ QUALIFICATION_KSQ
        {
            get
            {
                if (QUALIFICATION != null)
                {
                    if (_QUALIFICATION_KSQ == null)
                    {
                        _QUALIFICATION_KSQ = Context.KSQ.FindByKSQKEY(QUALIFICATION);
                    }
                    return _QUALIFICATION_KSQ;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KSI (Institutions) related entity by [SFQA.INSTITUTION]-&gt;[KSI.KSIKEY]
        /// Where studied
        /// </summary>
        public KSI INSTITUTION_KSI
        {
            get
            {
                if (INSTITUTION != null)
                {
                    if (_INSTITUTION_KSI == null)
                    {
                        _INSTITUTION_KSI = Context.KSI.FindByKSIKEY(INSTITUTION);
                    }
                    return _INSTITUTION_KSI;
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
