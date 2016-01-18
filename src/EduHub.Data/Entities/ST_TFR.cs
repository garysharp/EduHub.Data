using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// ST Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST_TFR : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_ORIG_SCHOOL_SKGS;
        private KCY Cache_SCHOOL_YEAR_NEW_KCY;
        private KGC Cache_HOME_GROUP_NEW_KGC;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Unique ST Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }

        /// <summary>
        /// Orignating School
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY { get; internal set; }

        /// <summary>
        /// Newly generated STKEY at dest.
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY_NEW { get; internal set; }

        /// <summary>
        /// Y if duplicate family exists
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DUP_FAMILY { get; internal set; }

        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// First given name
        /// [Alphanumeric (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Second given name
        /// [Alphanumeric (20)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }

        /// <summary>
        /// Preferred name
        /// [Alphanumeric (20)]
        /// </summary>
        public string PREF_NAME { get; internal set; }

        /// <summary>
        /// Title (eg Mr, Ms)
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Student's prime family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMILY { get; internal set; }

        /// <summary>
        /// Existing family key from CASES21
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMILY_DUP { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FAMILY_DUP_ACT { get; internal set; }

        /// <summary>
        /// Does the prime family receive academic reports? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACADEMIC_A { get; internal set; }

        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_A { get; internal set; }

        /// <summary>
        /// Relationships to Adults A and B in prime family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_A01 { get; internal set; }

        /// <summary>
        /// Relationships to Adults A and B in prime family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_A02 { get; internal set; }

        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_A { get; internal set; }

        /// <summary>
        /// Student's alternative family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMB { get; internal set; }

        /// <summary>
        /// Existing family key from CASES21
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMB_DUP { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FAMB_DUP_ACT { get; internal set; }

        /// <summary>
        /// Does the alternative family receive academic reports? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACADEMIC_B { get; internal set; }

        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_B { get; internal set; }

        /// <summary>
        /// Relationships to Adults A and B in alternative family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_B01 { get; internal set; }

        /// <summary>
        /// Relationships to Adults A and B in alternative family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_B02 { get; internal set; }

        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_B { get; internal set; }

        /// <summary>
        /// Student's additional contact family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMC { get; internal set; }

        /// <summary>
        /// Existing family key from CASES21
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMC_DUP { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FAMC_DUP_ACT { get; internal set; }

        /// <summary>
        /// Does the additional contact family receive academic reports? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACADEMIC_C { get; internal set; }

        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_C { get; internal set; }

        /// <summary>
        /// Relationships to Adults A and B in additional contact family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_C01 { get; internal set; }

        /// <summary>
        /// Relationships to Adults A and B in additional contact family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_C02 { get; internal set; }

        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_C { get; internal set; }

        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_ARR { get; internal set; }

        /// <summary>
        /// E-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string E_MAIL { get; internal set; }

        /// <summary>
        /// Student mobile telephone number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAP_TYPE { get; internal set; }

        /// <summary>
        /// (Was MELWAY_PAGE) Map no (MELWAY or other)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAP_NUM { get; internal set; }

        /// <summary>
        /// (Was MELWAY_GRID_X) Horizontal grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string X_AXIS { get; internal set; }

        /// <summary>
        /// (Was MELWAY_GRID_Y) Vertical grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string Y_AXIS { get; internal set; }

        /// <summary>
        /// Student Gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }

        /// <summary>
        /// Proof of birthdate sighted? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PROOF_DOB { get; internal set; }

        /// <summary>
        /// Australian residence status: P=Permanent, T=Temporary
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESIDENT_STATUS { get; internal set; }

        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERMANENT_BASIS { get; internal set; }

        /// <summary>
        /// Date of arrival in or return to Australia (BLANK if born in Australia!)
        /// </summary>
        public DateTime? ARRIVAL { get; internal set; }

        /// <summary>
        /// Date of first enrolment in an Australian school (Triggered if PREVIOUS_SCHOOL filled OR defaults to ENTRY)
        /// </summary>
        public DateTime? AUSSIE_SCHOOL { get; internal set; }

        /// <summary>
        /// Aide required to assist integration into school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTEGRATION { get; internal set; }

        /// <summary>
        /// Order in family (automatically maintained by software)
        /// </summary>
        public short? FAM_ORDER { get; internal set; }

        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }

        /// <summary>
        /// Year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }

        /// <summary>
        /// New Year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR_NEW { get; internal set; }

        /// <summary>
        /// New Home Group
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string HOME_GROUP_NEW { get; internal set; }

        /// <summary>
        /// Religion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string RELIGION { get; internal set; }

        /// <summary>
        /// Visa Sub-class
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }

        /// <summary>
        /// Visa statistical code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string VISA_STAT_CODE { get; internal set; }

        /// <summary>
        /// Visa expiry date
        /// </summary>
        public DateTime? VISA_EXPIRY { get; internal set; }

        /// <summary>
        /// Country of birth
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }

        /// <summary>
        /// Student speaks English? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENG_SPEAK { get; internal set; }

        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string HOME_LANG { get; internal set; }

        /// <summary>
        /// Born overseas? (Y/N): set to Y if ST.BIRTH_COUNTRY &lt;&gt; "1101": if Y then ARRIVAL is requested
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OVERSEAS { get; internal set; }

        /// <summary>
        /// Indigenous background: K=Aboriginal, T=Torres Strait Islander, B=Both Aboriginal and Torres Strait Islander, N=No indigenous background, X=Declined to Respond
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string KOORIE { get; internal set; }

        /// <summary>
        /// Restricted access memo
        /// [Memo]
        /// </summary>
        public string ACCESS { get; internal set; }

        /// <summary>
        /// Type of access restriction
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ACCESS_TYPE { get; internal set; }

        /// <summary>
        /// Access alert? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACCESS_ALERT { get; internal set; }

        /// <summary>
        /// Access alert? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RISK_ALERT { get; internal set; }

        /// <summary>
        /// Restricted risk memo
        /// [Memo]
        /// </summary>
        public string RISK_MEMO { get; internal set; }

        /// <summary>
        /// Student's regular medical practitioner
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DOCTOR { get; internal set; }

        /// <summary>
        /// Name(s) of person(s) to contact in an emergency
        /// [Titlecase (30)]
        /// </summary>
        public string EMERG_NAME01 { get; internal set; }

        /// <summary>
        /// Name(s) of person(s) to contact in an emergency
        /// [Titlecase (30)]
        /// </summary>
        public string EMERG_NAME02 { get; internal set; }

        /// <summary>
        /// Language spoken by person(s) to contact in an emergency
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string EMERG_LANG01 { get; internal set; }

        /// <summary>
        /// Language spoken by person(s) to contact in an emergency
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string EMERG_LANG02 { get; internal set; }

        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (11)]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }

        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (11)]
        /// </summary>
        public string EMERG_RELATION02 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT01 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT02 { get; internal set; }

        /// <summary>
        /// School has received authority to react to accident? (Y/N) (held on DF and copied here on creation)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACC_DECLARATION { get; internal set; }

        /// <summary>
        /// Medicare No (held on DF and copied here on creation)
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string MEDICARE_NO { get; internal set; }

        /// <summary>
        /// International Student Id (7 Numeric)
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string INTERNATIONAL_ST_ID { get; internal set; }

        /// <summary>
        /// Medical alert flag (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICAL_ALERT { get; internal set; }

        /// <summary>
        /// Is there an associated SMC record? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICAL_CONDITION { get; internal set; }

        /// <summary>
        /// Activity restriction which may affect group membership
        /// [Memo]
        /// </summary>
        public string ACTIVITY_RESTRICTION { get; internal set; }

        /// <summary>
        /// C = complete, I = Incomplete, N = Not Sighted
        /// [Alphanumeric (1)]
        /// </summary>
        public string IMMUNISE_CERT_STATUS { get; internal set; }

        /// <summary>
        /// Immunisation certificate sighted? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string IMMUN_CERT_SIGHTED { get; internal set; }

        /// <summary>
        /// Permission for immunisation program Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string IMMUNISE_PERMISSION { get; internal set; }

        /// <summary>
        /// Overall Immunisation status
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string IMMUNIZE { get; internal set; }

        /// <summary>
        /// OK to publish picture Y/N
        /// [Alphanumeric (1)]
        /// </summary>
        public string OK_TO_PUBLISH { get; internal set; }

        /// <summary>
        /// Date/time of last change
        /// </summary>
        public DateTime? PIC_LW_DATE { get; internal set; }

        /// <summary>
        /// N=New, R=Ready to upload, C=Copied
        /// [Alphanumeric (1)]
        /// </summary>
        public string PIC_STATUS { get; internal set; }

        /// <summary>
        /// Years of previous education
        /// </summary>
        public short? YEARS_PREVIOUS_EDUCATION { get; internal set; }

        /// <summary>
        /// Years of interruption to education
        /// </summary>
        public short? YEARS_INTERRUPTION_EDUCATION { get; internal set; }

        /// <summary>
        /// Language of previous schooling
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LANGUAGE_PREVIOUS_SCHOOLING { get; internal set; }

        /// <summary>
        /// The Language other than English spoken at home by student
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LOTE_HOME_CODE { get; internal set; }

        /// <summary>
        /// Victorian Studant Number
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string VSN { get; internal set; }

        /// <summary>
        /// Specialised curriculum RE = Reggio Emilia, S = Steiner, M = Montessori, IB = International Baccalaureate
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SPEC_CURR { get; internal set; }

        /// <summary>
        /// Unique Contact A DF Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string DFA_TRANS_ID { get; internal set; }

        /// <summary>
        /// Unique Contact B DF Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string DFB_TRANS_ID { get; internal set; }

        /// <summary>
        /// Unique Contact C DF Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string DFC_TRANS_ID { get; internal set; }

        /// <summary>
        /// Unique KCD Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string KCD_TRANS_ID { get; internal set; }

        /// <summary>
        /// Current Status of Import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string IMP_STATUS { get; internal set; }

        /// <summary>
        /// Actual Date data transfered into live table
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }

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
        /// SKGS (Schools) related entity by [ST_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS ORIG_SCHOOL_SKGS
        {
            get
            {
                if (Cache_ORIG_SCHOOL_SKGS == null)
                {
                    Cache_ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                }

                return Cache_ORIG_SCHOOL_SKGS;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [ST_TFR.SCHOOL_YEAR_NEW]-&gt;[KCY.KCYKEY]
        /// New Year level
        /// </summary>
        public KCY SCHOOL_YEAR_NEW_KCY
        {
            get
            {
                if (SCHOOL_YEAR_NEW == null)
                {
                    return null;
                }
                if (Cache_SCHOOL_YEAR_NEW_KCY == null)
                {
                    Cache_SCHOOL_YEAR_NEW_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR_NEW);
                }

                return Cache_SCHOOL_YEAR_NEW_KCY;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [ST_TFR.HOME_GROUP_NEW]-&gt;[KGC.KGCKEY]
        /// New Home Group
        /// </summary>
        public KGC HOME_GROUP_NEW_KGC
        {
            get
            {
                if (HOME_GROUP_NEW == null)
                {
                    return null;
                }
                if (Cache_HOME_GROUP_NEW_KGC == null)
                {
                    Cache_HOME_GROUP_NEW_KGC = Context.KGC.FindByKGCKEY(HOME_GROUP_NEW);
                }

                return Cache_HOME_GROUP_NEW_KGC;
            }
        }

        #endregion

    }
}
