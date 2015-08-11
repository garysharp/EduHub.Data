using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Members
    /// </summary>
    public class SAM_Entity : EntityBase
    {
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int SAMKEY { get; internal set; }
        /// <summary>
        /// (Was SOURCE) Table to which PERSON refers: NO=No existing record, SF=Staff member, DF=Family member, ST=Student, DN=Donor [Uppercase Alphanumeric: u2]
        /// </summary>
        public string PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code of person in table identified in PERSON_TYPE [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PERSON { get; internal set; }
        /// <summary>
        /// (If PERSON_TYPE indicates family) Which parent/guardian? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string WHICH_PARENT { get; internal set; }
        /// <summary>
        /// M or F [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Do you identify as an Aboriginal or Torres Strait Islander? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string KOORIE { get; internal set; }
        /// <summary>
        /// Were you or one of your parents born overseas? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PARENT_OS { get; internal set; }
        /// <summary>
        /// Do you speak a language other than English at home? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOTE { get; internal set; }
        /// <summary>
        /// Do you have a culturally and linguistically diverse background? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LBOTE { get; internal set; }
        /// <summary>
        /// Do you identify as a person with a disability? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISABILITY { get; internal set; }
        /// <summary>
        /// Association name [Uppercase Alphanumeric: u15]
        /// </summary>
        public string ASSOC_NAME { get; internal set; }
        /// <summary>
        /// Navigation property for [ASSOC_NAME] => [SCA_Entity].[SCAKEY]
        /// Association name
        /// </summary>
        public SCA_Entity ASSOC_NAME_SCA { get { return ASSOC_NAME == null ? null : Context.SCA.FindBySCAKEY(ASSOC_NAME); } }
        /// <summary>
        /// Position within association [Uppercase Alphanumeric: u25]
        /// </summary>
        public string ASSOC_POSN { get; internal set; }
        /// <summary>
        /// Navigation property for [ASSOC_POSN] => [SAP_Entity].[SAPKEY]
        /// Position within association
        /// </summary>
        public SAP_Entity ASSOC_POSN_SAP { get { return ASSOC_POSN == null ? null : Context.SAP.FindBySAPKEY(ASSOC_POSN); } }
        /// <summary>
        /// Actual address [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ADDRESSKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [ADDRESSKEY] => [UM_Entity].[UMKEY]
        /// Actual address
        /// </summary>
        public UM_Entity ADDRESSKEY_UM { get { return ADDRESSKEY.HasValue ? Context.UM.FindByUMKEY(ADDRESSKEY.Value) : null; } }
        /// <summary>
        /// Postal address [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MAILKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [MAILKEY] => [UM_Entity].[UMKEY]
        /// Postal address
        /// </summary>
        public UM_Entity MAILKEY_UM { get { return MAILKEY.HasValue ? Context.UM.FindByUMKEY(MAILKEY.Value) : null; } }
        /// <summary>
        /// (Was HOME_EMAIL) Home e-mail [Alphanumeric: a60]
        /// </summary>
        public string HOME_E_MAIL { get; internal set; }
        /// <summary>
        /// Work phone [Uppercase Alphanumeric: u20]
        /// </summary>
        public string WORK_PHONE { get; internal set; }
        /// <summary>
        /// Work fax [Uppercase Alphanumeric: u20]
        /// </summary>
        public string WORK_FAX { get; internal set; }
        /// <summary>
        /// (Was WORK_EMAIL) Work e-mail [Alphanumeric: a60]
        /// </summary>
        public string WORK_E_MAIL { get; internal set; }
        /// <summary>
        /// Member's surname and title if not identified in PERSON [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// Member's first given name if not identified in PERSON [Titlecase: t20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Person title: Mr, Mrs, etc if not identified in PERSON [Titlecase: t4]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Mobile phone no [Alphanumeric: a20]
        /// </summary>
        public string MOBILE_PHONE { get; internal set; }
        /// <summary>
        /// Association cheque account signatory? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SIGNATORY { get; internal set; }
        /// <summary>
        /// Memo [Memo: m]
        /// </summary>
        public string SAM_COMMENT { get; internal set; }
        /// <summary>
        /// Start date [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// End date [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
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
