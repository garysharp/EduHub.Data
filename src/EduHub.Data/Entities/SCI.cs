using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Information
    /// </summary>
    public class SCI : EntityBase
    {
#region Navigation Property Cache
        private SKGS _SCHOOL_LINK_SKGS;
        private SF _SCH_PRINCIPAL_SF;
        private SF _SF_OIC_SF;
        private SF _SF_VPRIN_SF;
        private SF _SF_2VPRIN_SF;
        private SF _SF_3VPRIN_SF;
        private SF _SF_APRIN_SF;
        private SF _SF_BMANAGER_SF;
        private SF _SF_VAC_CONTACT_SF;
        private SF _SF_EMERG_CONTACT_SF;
        private SAM _SAM_SCH_COUNCIL_SAM;
        private TH _CURRENT_QUILT_TH;
        private KCI _REL_INSTR_KCI;
        private SKGS _DESTINATION_SCHOOL_SKGS;
        private SF _SCH_AOIC_SF;
        private SF _SCH_VPRIN_SF;
        private SF _SCH_BMANAGER_SF;
        private SF _SCH_VAC_CONTACT_SF;
        private SF _SCH_EMERG_CONTACT_SF;
        private SAM _SCH_COUNCIL_PRES_SAM;
#endregion

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
        /// Navigation property for [SCHOOL_LINK] => [SKGS].[SCHOOL]
        /// School ID
        /// </summary>
        public SKGS SCHOOL_LINK_SKGS {
            get
            {
                if (SCHOOL_LINK != null)
                {
                    if (_SCHOOL_LINK_SKGS == null)
                    {
                        _SCHOOL_LINK_SKGS = Context.SKGS.FindBySCHOOL(SCHOOL_LINK);
                    }
                    return _SCHOOL_LINK_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_PRINCIPAL] => [SF].[SFKEY]
        /// Staff code for Principal of School
        /// </summary>
        public SF SCH_PRINCIPAL_SF {
            get
            {
                if (SCH_PRINCIPAL != null)
                {
                    if (_SCH_PRINCIPAL_SF == null)
                    {
                        _SCH_PRINCIPAL_SF = Context.SF.FindBySFKEY(SCH_PRINCIPAL);
                    }
                    return _SCH_PRINCIPAL_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_OIC] => [SF].[SFKEY]
        /// Staff code for Principal of Campus
        /// </summary>
        public SF SF_OIC_SF {
            get
            {
                if (SF_OIC != null)
                {
                    if (_SF_OIC_SF == null)
                    {
                        _SF_OIC_SF = Context.SF.FindBySFKEY(SF_OIC);
                    }
                    return _SF_OIC_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_VPRIN] => [SF].[SFKEY]
        /// Staff code for Vice-Principal of School
        /// </summary>
        public SF SF_VPRIN_SF {
            get
            {
                if (SF_VPRIN != null)
                {
                    if (_SF_VPRIN_SF == null)
                    {
                        _SF_VPRIN_SF = Context.SF.FindBySFKEY(SF_VPRIN);
                    }
                    return _SF_VPRIN_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_2VPRIN] => [SF].[SFKEY]
        /// Staff code for 2nd Vice-Principal of School
        /// </summary>
        public SF SF_2VPRIN_SF {
            get
            {
                if (SF_2VPRIN != null)
                {
                    if (_SF_2VPRIN_SF == null)
                    {
                        _SF_2VPRIN_SF = Context.SF.FindBySFKEY(SF_2VPRIN);
                    }
                    return _SF_2VPRIN_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_3VPRIN] => [SF].[SFKEY]
        /// Staff code for 3rd Vice-Principal of School
        /// </summary>
        public SF SF_3VPRIN_SF {
            get
            {
                if (SF_3VPRIN != null)
                {
                    if (_SF_3VPRIN_SF == null)
                    {
                        _SF_3VPRIN_SF = Context.SF.FindBySFKEY(SF_3VPRIN);
                    }
                    return _SF_3VPRIN_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_APRIN] => [SF].[SFKEY]
        /// Staff code for Acting Principal of School
        /// </summary>
        public SF SF_APRIN_SF {
            get
            {
                if (SF_APRIN != null)
                {
                    if (_SF_APRIN_SF == null)
                    {
                        _SF_APRIN_SF = Context.SF.FindBySFKEY(SF_APRIN);
                    }
                    return _SF_APRIN_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_BMANAGER] => [SF].[SFKEY]
        /// Staff code for Business Manager of School
        /// </summary>
        public SF SF_BMANAGER_SF {
            get
            {
                if (SF_BMANAGER != null)
                {
                    if (_SF_BMANAGER_SF == null)
                    {
                        _SF_BMANAGER_SF = Context.SF.FindBySFKEY(SF_BMANAGER);
                    }
                    return _SF_BMANAGER_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_VAC_CONTACT] => [SF].[SFKEY]
        /// Staff code for Vacation contact person for School
        /// </summary>
        public SF SF_VAC_CONTACT_SF {
            get
            {
                if (SF_VAC_CONTACT != null)
                {
                    if (_SF_VAC_CONTACT_SF == null)
                    {
                        _SF_VAC_CONTACT_SF = Context.SF.FindBySFKEY(SF_VAC_CONTACT);
                    }
                    return _SF_VAC_CONTACT_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SF_EMERG_CONTACT] => [SF].[SFKEY]
        /// Staff code for Emergency contact person for School
        /// </summary>
        public SF SF_EMERG_CONTACT_SF {
            get
            {
                if (SF_EMERG_CONTACT != null)
                {
                    if (_SF_EMERG_CONTACT_SF == null)
                    {
                        _SF_EMERG_CONTACT_SF = Context.SF.FindBySFKEY(SF_EMERG_CONTACT);
                    }
                    return _SF_EMERG_CONTACT_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SAM_SCH_COUNCIL] => [SAM].[SAMKEY]
        /// ID of School Council representative for School
        /// </summary>
        public SAM SAM_SCH_COUNCIL_SAM {
            get
            {
                if (SAM_SCH_COUNCIL.HasValue)
                {
                    if (_SAM_SCH_COUNCIL_SAM == null)
                    {
                        _SAM_SCH_COUNCIL_SAM = Context.SAM.FindBySAMKEY(SAM_SCH_COUNCIL.Value);
                    }
                    return _SAM_SCH_COUNCIL_SAM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CURRENT_QUILT] => [TH].[THKEY]
        /// Code of current quilt
        /// </summary>
        public TH CURRENT_QUILT_TH {
            get
            {
                if (CURRENT_QUILT != null)
                {
                    if (_CURRENT_QUILT_TH == null)
                    {
                        _CURRENT_QUILT_TH = Context.TH.FindByTHKEY(CURRENT_QUILT);
                    }
                    return _CURRENT_QUILT_TH;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [REL_INSTR] => [KCI].[KCIKEY]
        /// Default religious instruction course
        /// </summary>
        public KCI REL_INSTR_KCI {
            get
            {
                if (REL_INSTR != null)
                {
                    if (_REL_INSTR_KCI == null)
                    {
                        _REL_INSTR_KCI = Context.KCI.FindByKCIKEY(REL_INSTR);
                    }
                    return _REL_INSTR_KCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DESTINATION_SCHOOL] => [SKGS].[SCHOOL]
        /// Default destination for graduating students
        /// </summary>
        public SKGS DESTINATION_SCHOOL_SKGS {
            get
            {
                if (DESTINATION_SCHOOL != null)
                {
                    if (_DESTINATION_SCHOOL_SKGS == null)
                    {
                        _DESTINATION_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(DESTINATION_SCHOOL);
                    }
                    return _DESTINATION_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_AOIC] => [SF].[SFKEY]
        /// SFKEY of the staff member that is the Acting School Principal / OIC
        /// </summary>
        public SF SCH_AOIC_SF {
            get
            {
                if (SCH_AOIC != null)
                {
                    if (_SCH_AOIC_SF == null)
                    {
                        _SCH_AOIC_SF = Context.SF.FindBySFKEY(SCH_AOIC);
                    }
                    return _SCH_AOIC_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_VPRIN] => [SF].[SFKEY]
        /// SFKEY of the staff member that is the Assistant School Principal i.e. Vice Principal
        /// </summary>
        public SF SCH_VPRIN_SF {
            get
            {
                if (SCH_VPRIN != null)
                {
                    if (_SCH_VPRIN_SF == null)
                    {
                        _SCH_VPRIN_SF = Context.SF.FindBySFKEY(SCH_VPRIN);
                    }
                    return _SCH_VPRIN_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_BMANAGER] => [SF].[SFKEY]
        /// SFKEY of the staff member that is the School Business Manager
        /// </summary>
        public SF SCH_BMANAGER_SF {
            get
            {
                if (SCH_BMANAGER != null)
                {
                    if (_SCH_BMANAGER_SF == null)
                    {
                        _SCH_BMANAGER_SF = Context.SF.FindBySFKEY(SCH_BMANAGER);
                    }
                    return _SCH_BMANAGER_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_VAC_CONTACT] => [SF].[SFKEY]
        /// SFKEY of the staff member that is the School Vacation contact
        /// </summary>
        public SF SCH_VAC_CONTACT_SF {
            get
            {
                if (SCH_VAC_CONTACT != null)
                {
                    if (_SCH_VAC_CONTACT_SF == null)
                    {
                        _SCH_VAC_CONTACT_SF = Context.SF.FindBySFKEY(SCH_VAC_CONTACT);
                    }
                    return _SCH_VAC_CONTACT_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_EMERG_CONTACT] => [SF].[SFKEY]
        /// SFKEY of the staff member that is the School Emergency contact
        /// </summary>
        public SF SCH_EMERG_CONTACT_SF {
            get
            {
                if (SCH_EMERG_CONTACT != null)
                {
                    if (_SCH_EMERG_CONTACT_SF == null)
                    {
                        _SCH_EMERG_CONTACT_SF = Context.SF.FindBySFKEY(SCH_EMERG_CONTACT);
                    }
                    return _SCH_EMERG_CONTACT_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCH_COUNCIL_PRES] => [SAM].[SAMKEY]
        /// Link to the school council representative for the school
        /// </summary>
        public SAM SCH_COUNCIL_PRES_SAM {
            get
            {
                if (SCH_COUNCIL_PRES.HasValue)
                {
                    if (_SCH_COUNCIL_PRES_SAM == null)
                    {
                        _SCH_COUNCIL_PRES_SAM = Context.SAM.FindBySAMKEY(SCH_COUNCIL_PRES.Value);
                    }
                    return _SCH_COUNCIL_PRES_SAM;
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
