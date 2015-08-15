using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications
    /// </summary>
    public class SFQA_Entity : EntityBase
    {
#region Navigation Property Cache
        private SF_Entity _TEACH_SF;
        private KSQ_Entity _QUALIFICATION_KSQ;
        private KSI_Entity _INSTITUTION_KSI;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff code of teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Name of qualification [Alphanumeric: a30]
        /// </summary>
        public string QUALIFICATION { get; internal set; }
        /// <summary>
        /// When completed [Uppercase Alphanumeric: u4]
        /// </summary>
        public string YEAR_COMPLETED { get; internal set; }
        /// <summary>
        /// Where studied [Alphanumeric: a30]
        /// </summary>
        public string INSTITUTION { get; internal set; }
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
        /// Navigation property for [TEACH] => [SF_Entity].[SFKEY]
        /// Staff code of teacher
        /// </summary>
        public SF_Entity TEACH_SF {
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
        /// Navigation property for [QUALIFICATION] => [KSQ_Entity].[KSQKEY]
        /// Name of qualification
        /// </summary>
        public KSQ_Entity QUALIFICATION_KSQ {
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
        /// Navigation property for [INSTITUTION] => [KSI_Entity].[KSIKEY]
        /// Where studied
        /// </summary>
        public KSI_Entity INSTITUTION_KSI {
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
