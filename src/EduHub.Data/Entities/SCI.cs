using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Information
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCI : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_SCHOOL_LINK_SKGS;
        private SF Cache_SCH_PRINCIPAL_SF;
        private SF Cache_SF_OIC_SF;
        private SF Cache_SF_VPRIN_SF;
        private SF Cache_SF_2VPRIN_SF;
        private SF Cache_SF_3VPRIN_SF;
        private SF Cache_SF_APRIN_SF;
        private SF Cache_SF_BMANAGER_SF;
        private SF Cache_SF_VAC_CONTACT_SF;
        private SF Cache_SF_EMERG_CONTACT_SF;
        private SAM Cache_SAM_SCH_COUNCIL_SAM;
        private TH Cache_CURRENT_QUILT_TH;
        private KCI Cache_REL_INSTR_KCI;
        private SKGS Cache_DESTINATION_SCHOOL_SKGS;
        private SF Cache_SCH_AOIC_SF;
        private SF Cache_SCH_VPRIN_SF;
        private SF Cache_SCH_BMANAGER_SF;
        private SF Cache_SCH_VAC_CONTACT_SF;
        private SF Cache_SCH_EMERG_CONTACT_SF;
        private SAM Cache_SCH_COUNCIL_PRES_SAM;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_SCIKEY_AR_CAMPUS;
        private IReadOnlyList<KCPC> Cache_SCIKEY_KCPC_CAMPUS;
        private IReadOnlyList<KGC> Cache_SCIKEY_KGC_CAMPUS;
        private IReadOnlyList<KGH> Cache_SCIKEY_KGH_CAMPUS;
        private IReadOnlyList<SAD> Cache_SCIKEY_SAD_CAMPUS;
        private IReadOnlyList<SCAM> Cache_SCIKEY_SCAM_MEETING_LOCATION;
        private IReadOnlyList<SCL> Cache_SCIKEY_SCL_CAMPUS;
        private IReadOnlyList<SF> Cache_SCIKEY_SF_CAMPUS;
        private IReadOnlyList<SG> Cache_SCIKEY_SG_FROM_CAMPUS;
        private IReadOnlyList<SG> Cache_SCIKEY_SG_TO_CAMPUS;
        private IReadOnlyList<SID> Cache_SCIKEY_SID_CAMPUS;
        private IReadOnlyList<SM> Cache_SCIKEY_SM_CAMPUS;
        private IReadOnlyList<SMC> Cache_SCIKEY_SMC_CAMPUS;
        private IReadOnlyList<ST> Cache_SCIKEY_ST_CAMPUS;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_AM1_SD_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_PM1_PU_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_AM2_SD_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_PM2_PU_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_AM3_SD_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_PM3_PU_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_AM4_SD_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_PM4_PU_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_AM5_SD_SITE;
        private IReadOnlyList<STBT> Cache_SCIKEY_STBT_PM5_PU_SITE;
        private IReadOnlyList<STRE> Cache_SCIKEY_STRE_ST_CAMPUS;
        private IReadOnlyList<STTRIPS> Cache_SCIKEY_STTRIPS_AM_SETDOWN_CAMPUS;
        private IReadOnlyList<STTRIPS> Cache_SCIKEY_STTRIPS_PM_PICKUP_CAMPUS;
        private IReadOnlyList<STVDI> Cache_SCIKEY_STVDI_CAMPUS;
        private IReadOnlyList<STVDO> Cache_SCIKEY_STVDO_CAMPUS;
        private IReadOnlyList<TE> Cache_SCIKEY_TE_CAMPUS;
        private IReadOnlyList<TT> Cache_SCIKEY_TT_CAMPUS;

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
        /// Sequence no
        /// </summary>
        public int SCIKEY { get; internal set; }

        /// <summary>
        /// (Was DESCRIPTION) Campus name
        /// [Alphanumeric (40)]
        /// </summary>
        public string CAMPUS_NAME { get; internal set; }

        /// <summary>
        /// Campus type: Primary, Secondary, etc
        /// [Alphanumeric (10)]
        /// </summary>
        public string CAMPUS_TYPE { get; internal set; }

        /// <summary>
        /// School ID
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL_LINK { get; internal set; }

        /// <summary>
        /// School type: Primary, Secondary, etc
        /// [Alphanumeric (10)]
        /// </summary>
        public string SCHOOL_TYPE { get; internal set; }

        /// <summary>
        /// Name of school
        /// [Alphanumeric (40)]
        /// </summary>
        public string SCHOOL_NAME { get; internal set; }

        /// <summary>
        /// Master key number for Emergency Services
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string MASTER_KEY { get; internal set; }

        /// <summary>
        /// This campus is the administrative campus for this school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ADMIN_SITE { get; internal set; }

        /// <summary>
        /// Staff code for Principal of School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCH_PRINCIPAL { get; internal set; }

        /// <summary>
        /// Staff code for Principal of Campus
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_OIC { get; internal set; }

        /// <summary>
        /// Staff code for Vice-Principal of School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_VPRIN { get; internal set; }

        /// <summary>
        /// Staff code for 2nd Vice-Principal of School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_2VPRIN { get; internal set; }

        /// <summary>
        /// Staff code for 3rd Vice-Principal of School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_3VPRIN { get; internal set; }

        /// <summary>
        /// Staff code for Acting Principal of School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_APRIN { get; internal set; }

        /// <summary>
        /// Staff code for Business Manager of School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_BMANAGER { get; internal set; }

        /// <summary>
        /// Staff code for Vacation contact person for School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_VAC_CONTACT { get; internal set; }

        /// <summary>
        /// Staff code for Emergency contact person for School
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SF_EMERG_CONTACT { get; internal set; }

        /// <summary>
        /// ID of School Council representative for School
        /// </summary>
        public int? SAM_SCH_COUNCIL { get; internal set; }

        /// <summary>
        /// Department platform identification.
        /// [Alphanumeric (5)]
        /// </summary>
        public string PLATFORM { get; internal set; }

        /// <summary>
        /// DEET product release identification.
        /// [Alphanumeric (20)]
        /// </summary>
        public string CURRENT_RELEASE { get; internal set; }

        /// <summary>
        /// Department release action. (Alpha 1, Beta or Final)
        /// [Alphanumeric (7)]
        /// </summary>
        public string RELEASE_ACTION { get; internal set; }

        /// <summary>
        /// Department date of last release
        /// </summary>
        public DateTime? RELEASE_DATE { get; internal set; }

        /// <summary>
        /// Date time of last schema verification
        /// </summary>
        public DateTime? SCHEMA_VERIFIED { get; internal set; }

        /// <summary>
        /// Schema version as extracted from C:\DSE\SQL\EXE\Schema Version.txt during schema verify
        /// [Alphanumeric (30)]
        /// </summary>
        public string UPGRADE_VERSION { get; internal set; }

        /// <summary>
        /// eCases21 version number format  01.0.0.0
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ECASES21_VERSION { get; internal set; }

        /// <summary>
        /// Data Mirror version
        /// [Alphanumeric (30)]
        /// </summary>
        public string DMIRROR_VERSION { get; internal set; }

        /// <summary>
        /// Code of current quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CURRENT_QUILT { get; internal set; }

        /// <summary>
        /// Semester currently in operation, eg 1998S1
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string CURRENT_SEMESTER { get; internal set; }

        /// <summary>
        /// Last date student promotion task was fully run
        /// </summary>
        public DateTime? LAST_PROMOTION_DATE { get; internal set; }

        /// <summary>
        /// Date at which to calculate ages for groups
        /// </summary>
        public DateTime? AGE_CALCULATION_DATE { get; internal set; }

        /// <summary>
        /// Next school enrolment date
        /// </summary>
        public DateTime? NEXT_ENROLMENT_DATE { get; internal set; }

        /// <summary>
        /// Enrolment date for newly transferred students
        /// </summary>
        public DateTime? TFR_ENROLMENT_DATE { get; internal set; }

        /// <summary>
        /// Gender default
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER_DEFAULT { get; internal set; }

        /// <summary>
        /// Default telephone prefix
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE_PREFIX { get; internal set; }

        /// <summary>
        /// Default religious instruction course
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string REL_INSTR { get; internal set; }

        /// <summary>
        /// Consecutive absent day count
        /// </summary>
        public short? CONSECUTIVE_DAYS { get; internal set; }

        /// <summary>
        /// Cumulative absence period
        /// </summary>
        public short? CUMULATIVE_DAYS { get; internal set; }

        /// <summary>
        /// Overall absences permitted
        /// </summary>
        public short? OVERALL_DAYS { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb name
        /// [Alphanumeric (30)]
        /// </summary>
        public string SUBURB { get; internal set; }

        /// <summary>
        /// State code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Fax no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILING_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILING_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb name for Mailing
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILING_SUBURB { get; internal set; }

        /// <summary>
        /// State code for Mailing
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string MAILING_STATE { get; internal set; }

        /// <summary>
        /// Postcode for Mailing
        /// [Alphanumeric (4)]
        /// </summary>
        public string MAILING_POSTCODE { get; internal set; }

        /// <summary>
        /// Two address lines for Delivery
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines for Delivery
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb name for Delivery
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY_SUBURB { get; internal set; }

        /// <summary>
        /// State code for Delivery
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string DELIVERY_STATE { get; internal set; }

        /// <summary>
        /// Postcode for Delivery
        /// [Alphanumeric (4)]
        /// </summary>
        public string DELIVERY_POSTCODE { get; internal set; }

        /// <summary>
        /// Phone no. for Delivery
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string DELIVERY_TELEPHONE { get; internal set; }

        /// <summary>
        /// Fax no for Delivery
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string DELIVERY_FAX { get; internal set; }

        /// <summary>
        /// Map type: Melway, VicRoads, Country Fire Authority, etc
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAP_TYPE { get; internal set; }

        /// <summary>
        /// Map number
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAP_NUM { get; internal set; }

        /// <summary>
        /// Horizontal grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string X_AXIS { get; internal set; }

        /// <summary>
        /// Vertical grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string Y_AXIS { get; internal set; }

        /// <summary>
        /// Default destination for graduating students
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string DESTINATION_SCHOOL { get; internal set; }

        /// <summary>
        /// Email address of campus contact
        /// [Alphanumeric (60)]
        /// </summary>
        public string CAMPUS_EMAIL_CONTACT { get; internal set; }

        /// <summary>
        /// SFKEY of the staff member that is the Acting School Principal / OIC
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCH_AOIC { get; internal set; }

        /// <summary>
        /// SFKEY of the staff member that is the Assistant School Principal i.e. Vice Principal
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCH_VPRIN { get; internal set; }

        /// <summary>
        /// SFKEY of the staff member that is the School Business Manager
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCH_BMANAGER { get; internal set; }

        /// <summary>
        /// SFKEY of the staff member that is the School Vacation contact
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCH_VAC_CONTACT { get; internal set; }

        /// <summary>
        /// SFKEY of the staff member that is the School Emergency contact
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCH_EMERG_CONTACT { get; internal set; }

        /// <summary>
        /// Link to the school council representative for the school
        /// </summary>
        public int? SCH_COUNCIL_PRES { get; internal set; }

        /// <summary>
        /// Master key for the school
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string SCH_MASTER_KEY { get; internal set; }

        /// <summary>
        /// Flag to indicate if profile details have been updated during the day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PROFILE_UPDATED { get; internal set; }

        /// <summary>
        /// Flag to indicate if campus is open
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CAMPUS_OPEN_IND { get; internal set; }

        /// <summary>
        /// Date profile message sent to DoE
        /// </summary>
        public DateTime? PROFILE_SENT { get; internal set; }

        /// <summary>
        /// Specialised Curriculum on this campus Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SPEC_CURR_IND { get; internal set; }

        /// <summary>
        /// Globally unique ID number used for some financial transactions
        /// </summary>
        public int? GLOBAL_ID { get; internal set; }

        /// <summary>
        /// School defined field titles
        /// [Alphanumeric (20)]
        /// </summary>
        public string SCH_DEFINED01 { get; internal set; }

        /// <summary>
        /// School defined field titles
        /// [Alphanumeric (20)]
        /// </summary>
        public string SCH_DEFINED02 { get; internal set; }

        /// <summary>
        /// Preferred Contact Method
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PREF_MAIL_MECH { get; internal set; }

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
        /// SKGS (Schools) related entity by [SCI.SCHOOL_LINK]-&gt;[SKGS.SCHOOL]
        /// School ID
        /// </summary>
        public SKGS SCHOOL_LINK_SKGS
        {
            get
            {
                if (SCHOOL_LINK == null)
                {
                    return null;
                }
                if (Cache_SCHOOL_LINK_SKGS == null)
                {
                    Cache_SCHOOL_LINK_SKGS = Context.SKGS.FindBySCHOOL(SCHOOL_LINK);
                }

                return Cache_SCHOOL_LINK_SKGS;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SCH_PRINCIPAL]-&gt;[SF.SFKEY]
        /// Staff code for Principal of School
        /// </summary>
        public SF SCH_PRINCIPAL_SF
        {
            get
            {
                if (SCH_PRINCIPAL == null)
                {
                    return null;
                }
                if (Cache_SCH_PRINCIPAL_SF == null)
                {
                    Cache_SCH_PRINCIPAL_SF = Context.SF.FindBySFKEY(SCH_PRINCIPAL);
                }

                return Cache_SCH_PRINCIPAL_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_OIC]-&gt;[SF.SFKEY]
        /// Staff code for Principal of Campus
        /// </summary>
        public SF SF_OIC_SF
        {
            get
            {
                if (SF_OIC == null)
                {
                    return null;
                }
                if (Cache_SF_OIC_SF == null)
                {
                    Cache_SF_OIC_SF = Context.SF.FindBySFKEY(SF_OIC);
                }

                return Cache_SF_OIC_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_VPRIN]-&gt;[SF.SFKEY]
        /// Staff code for Vice-Principal of School
        /// </summary>
        public SF SF_VPRIN_SF
        {
            get
            {
                if (SF_VPRIN == null)
                {
                    return null;
                }
                if (Cache_SF_VPRIN_SF == null)
                {
                    Cache_SF_VPRIN_SF = Context.SF.FindBySFKEY(SF_VPRIN);
                }

                return Cache_SF_VPRIN_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_2VPRIN]-&gt;[SF.SFKEY]
        /// Staff code for 2nd Vice-Principal of School
        /// </summary>
        public SF SF_2VPRIN_SF
        {
            get
            {
                if (SF_2VPRIN == null)
                {
                    return null;
                }
                if (Cache_SF_2VPRIN_SF == null)
                {
                    Cache_SF_2VPRIN_SF = Context.SF.FindBySFKEY(SF_2VPRIN);
                }

                return Cache_SF_2VPRIN_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_3VPRIN]-&gt;[SF.SFKEY]
        /// Staff code for 3rd Vice-Principal of School
        /// </summary>
        public SF SF_3VPRIN_SF
        {
            get
            {
                if (SF_3VPRIN == null)
                {
                    return null;
                }
                if (Cache_SF_3VPRIN_SF == null)
                {
                    Cache_SF_3VPRIN_SF = Context.SF.FindBySFKEY(SF_3VPRIN);
                }

                return Cache_SF_3VPRIN_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_APRIN]-&gt;[SF.SFKEY]
        /// Staff code for Acting Principal of School
        /// </summary>
        public SF SF_APRIN_SF
        {
            get
            {
                if (SF_APRIN == null)
                {
                    return null;
                }
                if (Cache_SF_APRIN_SF == null)
                {
                    Cache_SF_APRIN_SF = Context.SF.FindBySFKEY(SF_APRIN);
                }

                return Cache_SF_APRIN_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_BMANAGER]-&gt;[SF.SFKEY]
        /// Staff code for Business Manager of School
        /// </summary>
        public SF SF_BMANAGER_SF
        {
            get
            {
                if (SF_BMANAGER == null)
                {
                    return null;
                }
                if (Cache_SF_BMANAGER_SF == null)
                {
                    Cache_SF_BMANAGER_SF = Context.SF.FindBySFKEY(SF_BMANAGER);
                }

                return Cache_SF_BMANAGER_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// Staff code for Vacation contact person for School
        /// </summary>
        public SF SF_VAC_CONTACT_SF
        {
            get
            {
                if (SF_VAC_CONTACT == null)
                {
                    return null;
                }
                if (Cache_SF_VAC_CONTACT_SF == null)
                {
                    Cache_SF_VAC_CONTACT_SF = Context.SF.FindBySFKEY(SF_VAC_CONTACT);
                }

                return Cache_SF_VAC_CONTACT_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SF_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// Staff code for Emergency contact person for School
        /// </summary>
        public SF SF_EMERG_CONTACT_SF
        {
            get
            {
                if (SF_EMERG_CONTACT == null)
                {
                    return null;
                }
                if (Cache_SF_EMERG_CONTACT_SF == null)
                {
                    Cache_SF_EMERG_CONTACT_SF = Context.SF.FindBySFKEY(SF_EMERG_CONTACT);
                }

                return Cache_SF_EMERG_CONTACT_SF;
            }
        }

        /// <summary>
        /// SAM (School Association Members) related entity by [SCI.SAM_SCH_COUNCIL]-&gt;[SAM.SAMKEY]
        /// ID of School Council representative for School
        /// </summary>
        public SAM SAM_SCH_COUNCIL_SAM
        {
            get
            {
                if (SAM_SCH_COUNCIL == null)
                {
                    return null;
                }
                if (Cache_SAM_SCH_COUNCIL_SAM == null)
                {
                    Cache_SAM_SCH_COUNCIL_SAM = Context.SAM.FindBySAMKEY(SAM_SCH_COUNCIL.Value);
                }

                return Cache_SAM_SCH_COUNCIL_SAM;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entity by [SCI.CURRENT_QUILT]-&gt;[TH.THKEY]
        /// Code of current quilt
        /// </summary>
        public TH CURRENT_QUILT_TH
        {
            get
            {
                if (CURRENT_QUILT == null)
                {
                    return null;
                }
                if (Cache_CURRENT_QUILT_TH == null)
                {
                    Cache_CURRENT_QUILT_TH = Context.TH.FindByTHKEY(CURRENT_QUILT);
                }

                return Cache_CURRENT_QUILT_TH;
            }
        }

        /// <summary>
        /// KCI (Religious Instruction Curricula) related entity by [SCI.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// Default religious instruction course
        /// </summary>
        public KCI REL_INSTR_KCI
        {
            get
            {
                if (REL_INSTR == null)
                {
                    return null;
                }
                if (Cache_REL_INSTR_KCI == null)
                {
                    Cache_REL_INSTR_KCI = Context.KCI.FindByKCIKEY(REL_INSTR);
                }

                return Cache_REL_INSTR_KCI;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [SCI.DESTINATION_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Default destination for graduating students
        /// </summary>
        public SKGS DESTINATION_SCHOOL_SKGS
        {
            get
            {
                if (DESTINATION_SCHOOL == null)
                {
                    return null;
                }
                if (Cache_DESTINATION_SCHOOL_SKGS == null)
                {
                    Cache_DESTINATION_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(DESTINATION_SCHOOL);
                }

                return Cache_DESTINATION_SCHOOL_SKGS;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SCH_AOIC]-&gt;[SF.SFKEY]
        /// SFKEY of the staff member that is the Acting School Principal / OIC
        /// </summary>
        public SF SCH_AOIC_SF
        {
            get
            {
                if (SCH_AOIC == null)
                {
                    return null;
                }
                if (Cache_SCH_AOIC_SF == null)
                {
                    Cache_SCH_AOIC_SF = Context.SF.FindBySFKEY(SCH_AOIC);
                }

                return Cache_SCH_AOIC_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SCH_VPRIN]-&gt;[SF.SFKEY]
        /// SFKEY of the staff member that is the Assistant School Principal i.e. Vice Principal
        /// </summary>
        public SF SCH_VPRIN_SF
        {
            get
            {
                if (SCH_VPRIN == null)
                {
                    return null;
                }
                if (Cache_SCH_VPRIN_SF == null)
                {
                    Cache_SCH_VPRIN_SF = Context.SF.FindBySFKEY(SCH_VPRIN);
                }

                return Cache_SCH_VPRIN_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SCH_BMANAGER]-&gt;[SF.SFKEY]
        /// SFKEY of the staff member that is the School Business Manager
        /// </summary>
        public SF SCH_BMANAGER_SF
        {
            get
            {
                if (SCH_BMANAGER == null)
                {
                    return null;
                }
                if (Cache_SCH_BMANAGER_SF == null)
                {
                    Cache_SCH_BMANAGER_SF = Context.SF.FindBySFKEY(SCH_BMANAGER);
                }

                return Cache_SCH_BMANAGER_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SCH_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// SFKEY of the staff member that is the School Vacation contact
        /// </summary>
        public SF SCH_VAC_CONTACT_SF
        {
            get
            {
                if (SCH_VAC_CONTACT == null)
                {
                    return null;
                }
                if (Cache_SCH_VAC_CONTACT_SF == null)
                {
                    Cache_SCH_VAC_CONTACT_SF = Context.SF.FindBySFKEY(SCH_VAC_CONTACT);
                }

                return Cache_SCH_VAC_CONTACT_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCI.SCH_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// SFKEY of the staff member that is the School Emergency contact
        /// </summary>
        public SF SCH_EMERG_CONTACT_SF
        {
            get
            {
                if (SCH_EMERG_CONTACT == null)
                {
                    return null;
                }
                if (Cache_SCH_EMERG_CONTACT_SF == null)
                {
                    Cache_SCH_EMERG_CONTACT_SF = Context.SF.FindBySFKEY(SCH_EMERG_CONTACT);
                }

                return Cache_SCH_EMERG_CONTACT_SF;
            }
        }

        /// <summary>
        /// SAM (School Association Members) related entity by [SCI.SCH_COUNCIL_PRES]-&gt;[SAM.SAMKEY]
        /// Link to the school council representative for the school
        /// </summary>
        public SAM SCH_COUNCIL_PRES_SAM
        {
            get
            {
                if (SCH_COUNCIL_PRES == null)
                {
                    return null;
                }
                if (Cache_SCH_COUNCIL_PRES_SAM == null)
                {
                    Cache_SCH_COUNCIL_PRES_SAM = Context.SAM.FindBySAMKEY(SCH_COUNCIL_PRES.Value);
                }

                return Cache_SCH_COUNCIL_PRES_SAM;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// AR (Assets) related entities by [SCI.SCIKEY]-&gt;[AR.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<AR> SCIKEY_AR_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_AR_CAMPUS == null &&
                    !Context.AR.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_AR_CAMPUS))
                {
                    Cache_SCIKEY_AR_CAMPUS = new List<AR>().AsReadOnly();
                }

                return Cache_SCIKEY_AR_CAMPUS;
            }
        }

        /// <summary>
        /// KCPC (Creditor Purchasing Card) related entities by [SCI.SCIKEY]-&gt;[KCPC.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<KCPC> SCIKEY_KCPC_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_KCPC_CAMPUS == null &&
                    !Context.KCPC.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_KCPC_CAMPUS))
                {
                    Cache_SCIKEY_KCPC_CAMPUS = new List<KCPC>().AsReadOnly();
                }

                return Cache_SCIKEY_KCPC_CAMPUS;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [SCI.SCIKEY]-&gt;[KGC.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<KGC> SCIKEY_KGC_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_KGC_CAMPUS == null &&
                    !Context.KGC.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_KGC_CAMPUS))
                {
                    Cache_SCIKEY_KGC_CAMPUS = new List<KGC>().AsReadOnly();
                }

                return Cache_SCIKEY_KGC_CAMPUS;
            }
        }

        /// <summary>
        /// KGH (Houses) related entities by [SCI.SCIKEY]-&gt;[KGH.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<KGH> SCIKEY_KGH_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_KGH_CAMPUS == null &&
                    !Context.KGH.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_KGH_CAMPUS))
                {
                    Cache_SCIKEY_KGH_CAMPUS = new List<KGH>().AsReadOnly();
                }

                return Cache_SCIKEY_KGH_CAMPUS;
            }
        }

        /// <summary>
        /// SAD (Accidents) related entities by [SCI.SCIKEY]-&gt;[SAD.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SAD> SCIKEY_SAD_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SAD_CAMPUS == null &&
                    !Context.SAD.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_SAD_CAMPUS))
                {
                    Cache_SCIKEY_SAD_CAMPUS = new List<SAD>().AsReadOnly();
                }

                return Cache_SCIKEY_SAD_CAMPUS;
            }
        }

        /// <summary>
        /// SCAM (School Association Meetings) related entities by [SCI.SCIKEY]-&gt;[SCAM.MEETING_LOCATION]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SCAM> SCIKEY_SCAM_MEETING_LOCATION
        {
            get
            {
                if (Cache_SCIKEY_SCAM_MEETING_LOCATION == null &&
                    !Context.SCAM.TryFindByMEETING_LOCATION(SCIKEY, out Cache_SCIKEY_SCAM_MEETING_LOCATION))
                {
                    Cache_SCIKEY_SCAM_MEETING_LOCATION = new List<SCAM>().AsReadOnly();
                }

                return Cache_SCIKEY_SCAM_MEETING_LOCATION;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SCI.SCIKEY]-&gt;[SCL.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SCL> SCIKEY_SCL_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SCL_CAMPUS == null &&
                    !Context.SCL.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_SCL_CAMPUS))
                {
                    Cache_SCIKEY_SCL_CAMPUS = new List<SCL>().AsReadOnly();
                }

                return Cache_SCIKEY_SCL_CAMPUS;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SCI.SCIKEY]-&gt;[SF.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SF> SCIKEY_SF_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SF_CAMPUS == null &&
                    !Context.SF.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_SF_CAMPUS))
                {
                    Cache_SCIKEY_SF_CAMPUS = new List<SF>().AsReadOnly();
                }

                return Cache_SCIKEY_SF_CAMPUS;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [SCI.SCIKEY]-&gt;[SG.FROM_CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SG> SCIKEY_SG_FROM_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SG_FROM_CAMPUS == null &&
                    !Context.SG.TryFindByFROM_CAMPUS(SCIKEY, out Cache_SCIKEY_SG_FROM_CAMPUS))
                {
                    Cache_SCIKEY_SG_FROM_CAMPUS = new List<SG>().AsReadOnly();
                }

                return Cache_SCIKEY_SG_FROM_CAMPUS;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [SCI.SCIKEY]-&gt;[SG.TO_CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SG> SCIKEY_SG_TO_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SG_TO_CAMPUS == null &&
                    !Context.SG.TryFindByTO_CAMPUS(SCIKEY, out Cache_SCIKEY_SG_TO_CAMPUS))
                {
                    Cache_SCIKEY_SG_TO_CAMPUS = new List<SG>().AsReadOnly();
                }

                return Cache_SCIKEY_SG_TO_CAMPUS;
            }
        }

        /// <summary>
        /// SID (Disciplinary Incidents) related entities by [SCI.SCIKEY]-&gt;[SID.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SID> SCIKEY_SID_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SID_CAMPUS == null &&
                    !Context.SID.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_SID_CAMPUS))
                {
                    Cache_SCIKEY_SID_CAMPUS = new List<SID>().AsReadOnly();
                }

                return Cache_SCIKEY_SID_CAMPUS;
            }
        }

        /// <summary>
        /// SM (Rooms) related entities by [SCI.SCIKEY]-&gt;[SM.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SM> SCIKEY_SM_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SM_CAMPUS == null &&
                    !Context.SM.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_SM_CAMPUS))
                {
                    Cache_SCIKEY_SM_CAMPUS = new List<SM>().AsReadOnly();
                }

                return Cache_SCIKEY_SM_CAMPUS;
            }
        }

        /// <summary>
        /// SMC (Student Medical Conditions) related entities by [SCI.SCIKEY]-&gt;[SMC.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SMC> SCIKEY_SMC_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_SMC_CAMPUS == null &&
                    !Context.SMC.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_SMC_CAMPUS))
                {
                    Cache_SCIKEY_SMC_CAMPUS = new List<SMC>().AsReadOnly();
                }

                return Cache_SCIKEY_SMC_CAMPUS;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [SCI.SCIKEY]-&gt;[ST.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<ST> SCIKEY_ST_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_ST_CAMPUS == null &&
                    !Context.ST.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_ST_CAMPUS))
                {
                    Cache_SCIKEY_ST_CAMPUS = new List<ST>().AsReadOnly();
                }

                return Cache_SCIKEY_ST_CAMPUS;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.AM1_SD_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_AM1_SD_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_AM1_SD_SITE == null &&
                    !Context.STBT.TryFindByAM1_SD_SITE(SCIKEY, out Cache_SCIKEY_STBT_AM1_SD_SITE))
                {
                    Cache_SCIKEY_STBT_AM1_SD_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_AM1_SD_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.PM1_PU_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_PM1_PU_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_PM1_PU_SITE == null &&
                    !Context.STBT.TryFindByPM1_PU_SITE(SCIKEY, out Cache_SCIKEY_STBT_PM1_PU_SITE))
                {
                    Cache_SCIKEY_STBT_PM1_PU_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_PM1_PU_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.AM2_SD_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_AM2_SD_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_AM2_SD_SITE == null &&
                    !Context.STBT.TryFindByAM2_SD_SITE(SCIKEY, out Cache_SCIKEY_STBT_AM2_SD_SITE))
                {
                    Cache_SCIKEY_STBT_AM2_SD_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_AM2_SD_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.PM2_PU_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_PM2_PU_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_PM2_PU_SITE == null &&
                    !Context.STBT.TryFindByPM2_PU_SITE(SCIKEY, out Cache_SCIKEY_STBT_PM2_PU_SITE))
                {
                    Cache_SCIKEY_STBT_PM2_PU_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_PM2_PU_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.AM3_SD_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_AM3_SD_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_AM3_SD_SITE == null &&
                    !Context.STBT.TryFindByAM3_SD_SITE(SCIKEY, out Cache_SCIKEY_STBT_AM3_SD_SITE))
                {
                    Cache_SCIKEY_STBT_AM3_SD_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_AM3_SD_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.PM3_PU_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_PM3_PU_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_PM3_PU_SITE == null &&
                    !Context.STBT.TryFindByPM3_PU_SITE(SCIKEY, out Cache_SCIKEY_STBT_PM3_PU_SITE))
                {
                    Cache_SCIKEY_STBT_PM3_PU_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_PM3_PU_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.AM4_SD_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_AM4_SD_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_AM4_SD_SITE == null &&
                    !Context.STBT.TryFindByAM4_SD_SITE(SCIKEY, out Cache_SCIKEY_STBT_AM4_SD_SITE))
                {
                    Cache_SCIKEY_STBT_AM4_SD_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_AM4_SD_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.PM4_PU_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_PM4_PU_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_PM4_PU_SITE == null &&
                    !Context.STBT.TryFindByPM4_PU_SITE(SCIKEY, out Cache_SCIKEY_STBT_PM4_PU_SITE))
                {
                    Cache_SCIKEY_STBT_PM4_PU_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_PM4_PU_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.AM5_SD_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_AM5_SD_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_AM5_SD_SITE == null &&
                    !Context.STBT.TryFindByAM5_SD_SITE(SCIKEY, out Cache_SCIKEY_STBT_AM5_SD_SITE))
                {
                    Cache_SCIKEY_STBT_AM5_SD_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_AM5_SD_SITE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [SCI.SCIKEY]-&gt;[STBT.PM5_PU_SITE]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STBT> SCIKEY_STBT_PM5_PU_SITE
        {
            get
            {
                if (Cache_SCIKEY_STBT_PM5_PU_SITE == null &&
                    !Context.STBT.TryFindByPM5_PU_SITE(SCIKEY, out Cache_SCIKEY_STBT_PM5_PU_SITE))
                {
                    Cache_SCIKEY_STBT_PM5_PU_SITE = new List<STBT>().AsReadOnly();
                }

                return Cache_SCIKEY_STBT_PM5_PU_SITE;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SCI.SCIKEY]-&gt;[STRE.ST_CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STRE> SCIKEY_STRE_ST_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_STRE_ST_CAMPUS == null &&
                    !Context.STRE.TryFindByST_CAMPUS(SCIKEY, out Cache_SCIKEY_STRE_ST_CAMPUS))
                {
                    Cache_SCIKEY_STRE_ST_CAMPUS = new List<STRE>().AsReadOnly();
                }

                return Cache_SCIKEY_STRE_ST_CAMPUS;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [SCI.SCIKEY]-&gt;[STTRIPS.AM_SETDOWN_CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STTRIPS> SCIKEY_STTRIPS_AM_SETDOWN_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_STTRIPS_AM_SETDOWN_CAMPUS == null &&
                    !Context.STTRIPS.TryFindByAM_SETDOWN_CAMPUS(SCIKEY, out Cache_SCIKEY_STTRIPS_AM_SETDOWN_CAMPUS))
                {
                    Cache_SCIKEY_STTRIPS_AM_SETDOWN_CAMPUS = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_SCIKEY_STTRIPS_AM_SETDOWN_CAMPUS;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [SCI.SCIKEY]-&gt;[STTRIPS.PM_PICKUP_CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STTRIPS> SCIKEY_STTRIPS_PM_PICKUP_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_STTRIPS_PM_PICKUP_CAMPUS == null &&
                    !Context.STTRIPS.TryFindByPM_PICKUP_CAMPUS(SCIKEY, out Cache_SCIKEY_STTRIPS_PM_PICKUP_CAMPUS))
                {
                    Cache_SCIKEY_STTRIPS_PM_PICKUP_CAMPUS = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_SCIKEY_STTRIPS_PM_PICKUP_CAMPUS;
            }
        }

        /// <summary>
        /// STVDI (VELS Dimension Results) related entities by [SCI.SCIKEY]-&gt;[STVDI.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STVDI> SCIKEY_STVDI_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_STVDI_CAMPUS == null &&
                    !Context.STVDI.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_STVDI_CAMPUS))
                {
                    Cache_SCIKEY_STVDI_CAMPUS = new List<STVDI>().AsReadOnly();
                }

                return Cache_SCIKEY_STVDI_CAMPUS;
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [SCI.SCIKEY]-&gt;[STVDO.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<STVDO> SCIKEY_STVDO_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_STVDO_CAMPUS == null &&
                    !Context.STVDO.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_STVDO_CAMPUS))
                {
                    Cache_SCIKEY_STVDO_CAMPUS = new List<STVDO>().AsReadOnly();
                }

                return Cache_SCIKEY_STVDO_CAMPUS;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [SCI.SCIKEY]-&gt;[TE.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<TE> SCIKEY_TE_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_TE_CAMPUS == null &&
                    !Context.TE.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_TE_CAMPUS))
                {
                    Cache_SCIKEY_TE_CAMPUS = new List<TE>().AsReadOnly();
                }

                return Cache_SCIKEY_TE_CAMPUS;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [SCI.SCIKEY]-&gt;[TT.CAMPUS]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<TT> SCIKEY_TT_CAMPUS
        {
            get
            {
                if (Cache_SCIKEY_TT_CAMPUS == null &&
                    !Context.TT.TryFindByCAMPUS(SCIKEY, out Cache_SCIKEY_TT_CAMPUS))
                {
                    Cache_SCIKEY_TT_CAMPUS = new List<TT>().AsReadOnly();
                }

                return Cache_SCIKEY_TT_CAMPUS;
            }
        }

        #endregion

    }
}
