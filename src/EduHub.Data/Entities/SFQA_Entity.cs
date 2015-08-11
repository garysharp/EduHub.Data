using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications
    /// </summary>
    public class SFQA_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff code of teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACH] => [SF_Entity].[SFKEY]
        /// Staff code of teacher
        /// </summary>
        public SF_Entity TEACH_SF { get { return TEACH == null ? null : Context.SF.FindBySFKEY(TEACH); } }
        /// <summary>
        /// Name of qualification [Alphanumeric: a30]
        /// </summary>
        public string QUALIFICATION { get; internal set; }
        /// <summary>
        /// Navigation property for [QUALIFICATION] => [KSQ_Entity].[KSQKEY]
        /// Name of qualification
        /// </summary>
        public KSQ_Entity QUALIFICATION_KSQ { get { return QUALIFICATION == null ? null : Context.KSQ.FindByKSQKEY(QUALIFICATION); } }
        /// <summary>
        /// When completed [Uppercase Alphanumeric: u4]
        /// </summary>
        public string YEAR_COMPLETED { get; internal set; }
        /// <summary>
        /// Where studied [Alphanumeric: a30]
        /// </summary>
        public string INSTITUTION { get; internal set; }
        /// <summary>
        /// Navigation property for [INSTITUTION] => [KSI_Entity].[KSIKEY]
        /// Where studied
        /// </summary>
        public KSI_Entity INSTITUTION_KSI { get { return INSTITUTION == null ? null : Context.KSI.FindByKSIKEY(INSTITUTION); } }
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
        
        
    }
}
