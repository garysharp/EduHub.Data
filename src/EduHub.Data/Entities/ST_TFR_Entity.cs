using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// ST Transfer
    /// </summary>
    public class ST_TFR_Entity : EntityBase
    {
#region Navigation Property Cache
        private SKGS_Entity _ORIG_SCHOOL_SKGS;
        private KCY_Entity _SCHOOL_YEAR_NEW_KCY;
        private KGC_Entity _HOME_GROUP_NEW_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Unique ST Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }
        /// <summary>
        /// Orignating School [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// Newly generated STKEY at dest. [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY_NEW { get; internal set; }
        /// <summary>
        /// Y if duplicate family exists [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DUP_FAMILY { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First given name [Alphanumeric: a20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second given name [Alphanumeric: a20]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Preferred name [Alphanumeric: a20]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Title (eg Mr, Ms) [Titlecase: t4]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Student's prime family [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Existing family key from CASES21 [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMILY_DUP { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FAMILY_DUP_ACT { get; internal set; }
        /// <summary>
        /// Does the prime family receive academic reports? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACADEMIC_A { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_A { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in prime family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_A01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in prime family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_A02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_A { get; internal set; }
        /// <summary>
        /// Student's alternative family [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMB { get; internal set; }
        /// <summary>
        /// Existing family key from CASES21 [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMB_DUP { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FAMB_DUP_ACT { get; internal set; }
        /// <summary>
        /// Does the alternative family receive academic reports? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACADEMIC_B { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_B { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in alternative family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_B01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in alternative family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_B02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_B { get; internal set; }
        /// <summary>
        /// Student's additional contact family [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMC { get; internal set; }
        /// <summary>
        /// Existing family key from CASES21 [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMC_DUP { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FAMC_DUP_ACT { get; internal set; }
        /// <summary>
        /// Does the additional contact family receive academic reports? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACADEMIC_C { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_C { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in additional contact family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_C01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in additional contact family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_C02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_C { get; internal set; }
        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_ARR { get; internal set; }
        /// <summary>
        /// E-mail address [Alphanumeric: a60]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Student mobile telephone number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MAP_TYPE { get; internal set; }
        /// <summary>
        /// (Was MELWAY_PAGE) Map no (MELWAY or other) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAP_NUM { get; internal set; }
        /// <summary>
        /// (Was MELWAY_GRID_X) Horizontal grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string X_AXIS { get; internal set; }
        /// <summary>
        /// (Was MELWAY_GRID_Y) Vertical grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string Y_AXIS { get; internal set; }
        /// <summary>
        /// Student Gender [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of birth [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Proof of birthdate sighted? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PROOF_DOB { get; internal set; }
        /// <summary>
        /// Australian residence status: P=Permanent, T=Temporary [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RESIDENT_STATUS { get; internal set; }
        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERMANENT_BASIS { get; internal set; }
        /// <summary>
        /// Date of arrival in or return to Australia (BLANK if born in Australia!) [Date Time nullable: d]
        /// </summary>
        public DateTime? ARRIVAL { get; internal set; }
        /// <summary>
        /// Date of first enrolment in an Australian school (Triggered if PREVIOUS_SCHOOL filled OR defaults to ENTRY) [Date Time nullable: d]
        /// </summary>
        public DateTime? AUSSIE_SCHOOL { get; internal set; }
        /// <summary>
        /// Aide required to assist integration into school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTEGRATION { get; internal set; }
        /// <summary>
        /// Order in family (automatically maintained by software) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FAM_ORDER { get; internal set; }
        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }
        /// <summary>
        /// Year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// New Year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_YEAR_NEW { get; internal set; }
        /// <summary>
        /// New Home Group [Uppercase Alphanumeric: u3]
        /// </summary>
        public string HOME_GROUP_NEW { get; internal set; }
        /// <summary>
        /// Religion [Uppercase Alphanumeric: u12]
        /// </summary>
        public string RELIGION { get; internal set; }
        /// <summary>
        /// Visa Sub-class [Uppercase Alphanumeric: u3]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }
        /// <summary>
        /// Visa statistical code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string VISA_STAT_CODE { get; internal set; }
        /// <summary>
        /// Visa expiry date [Date Time nullable: d]
        /// </summary>
        public DateTime? VISA_EXPIRY { get; internal set; }
        /// <summary>
        /// Country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Student speaks English? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENG_SPEAK { get; internal set; }
        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most [Uppercase Alphanumeric: u7]
        /// </summary>
        public string HOME_LANG { get; internal set; }
        /// <summary>
        /// Born overseas? (Y/N): set to Y if ST.BIRTH_COUNTRY <> "1101": if Y then ARRIVAL is requested [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OVERSEAS { get; internal set; }
        /// <summary>
        /// Indigenous background: K=Aboriginal, T=Torres Strait Islander, B=Both Aboriginal and Torres Strait Islander, N=No indigenous background, X=Declined to Respond [Uppercase Alphanumeric: u1]
        /// </summary>
        public string KOORIE { get; internal set; }
        /// <summary>
        /// Restricted access memo [Memo: m]
        /// </summary>
        public string ACCESS { get; internal set; }
        /// <summary>
        /// Type of access restriction [Uppercase Alphanumeric: u20]
        /// </summary>
        public string ACCESS_TYPE { get; internal set; }
        /// <summary>
        /// Access alert? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACCESS_ALERT { get; internal set; }
        /// <summary>
        /// Access alert? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RISK_ALERT { get; internal set; }
        /// <summary>
        /// Restricted risk memo [Memo: m]
        /// </summary>
        public string RISK_MEMO { get; internal set; }
        /// <summary>
        /// Student's regular medical practitioner [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DOCTOR { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency [Titlecase: t30]
        /// </summary>
        public string EMERG_NAME01 { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency [Titlecase: t30]
        /// </summary>
        public string EMERG_NAME02 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG01 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG02 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION02 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT01 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT02 { get; internal set; }
        /// <summary>
        /// School has received authority to react to accident? (Y/N) (held on DF and copied here on creation) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACC_DECLARATION { get; internal set; }
        /// <summary>
        /// Medicare No (held on DF and copied here on creation) [Uppercase Alphanumeric: u12]
        /// </summary>
        public string MEDICARE_NO { get; internal set; }
        /// <summary>
        /// International Student Id (7 Numeric) [Uppercase Alphanumeric: u7]
        /// </summary>
        public string INTERNATIONAL_ST_ID { get; internal set; }
        /// <summary>
        /// Medical alert flag (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEDICAL_ALERT { get; internal set; }
        /// <summary>
        /// Is there an associated SMC record? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEDICAL_CONDITION { get; internal set; }
        /// <summary>
        /// Activity restriction which may affect group membership [Memo: m]
        /// </summary>
        public string ACTIVITY_RESTRICTION { get; internal set; }
        /// <summary>
        /// C = complete, I = Incomplete, N = Not Sighted [Alphanumeric: a1]
        /// </summary>
        public string IMMUNISE_CERT_STATUS { get; internal set; }
        /// <summary>
        /// Immunisation certificate sighted? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string IMMUN_CERT_SIGHTED { get; internal set; }
        /// <summary>
        /// Overall Immunisation status [Uppercase Alphanumeric: u1]
        /// </summary>
        public string IMMUNIZE { get; internal set; }
        /// <summary>
        /// OK to publish picture Y/N [Alphanumeric: a1]
        /// </summary>
        public string OK_TO_PUBLISH { get; internal set; }
        /// <summary>
        /// Date/time of last change [Date Time nullable: d]
        /// </summary>
        public DateTime? PIC_LW_DATE { get; internal set; }
        /// <summary>
        /// N=New, R=Ready to upload, C=Copied [Alphanumeric: a1]
        /// </summary>
        public string PIC_STATUS { get; internal set; }
        /// <summary>
        /// Years of previous education [Integer (16bit signed nullable): i]
        /// </summary>
        public short? YEARS_PREVIOUS_EDUCATION { get; internal set; }
        /// <summary>
        /// Years of interruption to education [Integer (16bit signed nullable): i]
        /// </summary>
        public short? YEARS_INTERRUPTION_EDUCATION { get; internal set; }
        /// <summary>
        /// Language of previous schooling [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LANGUAGE_PREVIOUS_SCHOOLING { get; internal set; }
        /// <summary>
        /// The Language other than English spoken at home by student [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LOTE_HOME_CODE { get; internal set; }
        /// <summary>
        /// Victorian Studant Number [Uppercase Alphanumeric: u12]
        /// </summary>
        public string VSN { get; internal set; }
        /// <summary>
        /// Specialised curriculum RE = Reggio Emilia, S = Steiner, M = Montessori, IB = International Baccalaureate [Uppercase Alphanumeric: u2]
        /// </summary>
        public string SPEC_CURR { get; internal set; }
        /// <summary>
        /// Unique Contact A DF Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string DFA_TRANS_ID { get; internal set; }
        /// <summary>
        /// Unique Contact B DF Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string DFB_TRANS_ID { get; internal set; }
        /// <summary>
        /// Unique Contact C DF Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string DFC_TRANS_ID { get; internal set; }
        /// <summary>
        /// Unique KCD Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string KCD_TRANS_ID { get; internal set; }
        /// <summary>
        /// Current Status of Import [Uppercase Alphanumeric: u15]
        /// </summary>
        public string IMP_STATUS { get; internal set; }
        /// <summary>
        /// Actual Date data transfered into live table [Date Time nullable: d]
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }
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
        /// Navigation property for [ORIG_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS_Entity ORIG_SCHOOL_SKGS {
            get
            {
                if (ORIG_SCHOOL != null)
                {
                    if (_ORIG_SCHOOL_SKGS == null)
                    {
                        _ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                    }
                    return _ORIG_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCHOOL_YEAR_NEW] => [KCY_Entity].[KCYKEY]
        /// New Year level
        /// </summary>
        public KCY_Entity SCHOOL_YEAR_NEW_KCY {
            get
            {
                if (SCHOOL_YEAR_NEW != null)
                {
                    if (_SCHOOL_YEAR_NEW_KCY == null)
                    {
                        _SCHOOL_YEAR_NEW_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR_NEW);
                    }
                    return _SCHOOL_YEAR_NEW_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOME_GROUP_NEW] => [KGC_Entity].[KGCKEY]
        /// New Home Group
        /// </summary>
        public KGC_Entity HOME_GROUP_NEW_KGC {
            get
            {
                if (HOME_GROUP_NEW != null)
                {
                    if (_HOME_GROUP_NEW_KGC == null)
                    {
                        _HOME_GROUP_NEW_KGC = Context.KGC.FindByKGCKEY(HOME_GROUP_NEW);
                    }
                    return _HOME_GROUP_NEW_KGC;
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
