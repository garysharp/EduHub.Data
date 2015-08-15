using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff
    /// </summary>
    public class SF_Entity : EntityBase
    {
#region Navigation Property Cache
        private UM_Entity _HOMEKEY_UM;
        private UM_Entity _MAILKEY_UM;
        private KSF_Entity _FACULTY01_KSF;
        private KSF_Entity _FACULTY02_KSF;
        private KSF_Entity _FACULTY03_KSF;
        private KSF_Entity _FACULTY04_KSF;
        private SU_Entity _SUBJECT01_SU;
        private SU_Entity _SUBJECT02_SU;
        private SU_Entity _SUBJECT03_SU;
        private SU_Entity _SUBJECT04_SU;
        private SU_Entity _SUBJECT05_SU;
        private SU_Entity _SUBJECT06_SU;
        private SU_Entity _SUBJECT07_SU;
        private SU_Entity _SUBJECT08_SU;
        private SU_Entity _SUBJECT09_SU;
        private SU_Entity _SUBJECT10_SU;
        private SCI_Entity _CAMPUS_SCI;
        private KGH_Entity _HOUSE_KGH;
        private SM_Entity _ROOM_SM;
        private SM_Entity _OTHER_LOCATION_SM;
        private KSC_Entity _POS_CODE_A_KSC;
        private KSC_Entity _POS_CODE_B_KSC;
        private KSA_Entity _MAJORA_KSA;
        private KSA_Entity _MAJORB_KSA;
        private KSA_Entity _MAJORC_KSA;
        private KGR_Entity _RELIGION_KGR;
        private KGT_Entity _BIRTH_COUNTRY_KGT;
        private KGL_Entity _LANG01_KGL;
        private KGL_Entity _LANG02_KGL;
        private KGL_Entity _EMERG_LANG01_KGL;
        private KGL_Entity _EMERG_LANG02_KGL;
        private DR_Entity _DEBTOR_ID_DR;
#endregion

#region Field Properties
        /// <summary>
        /// Staff member code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SFKEY { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// Title: Mr, Ms, etc [Titlecase: t4]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// First given name [Alphanumeric: a20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second given name [Alphanumeric: a20]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Preferred name [Alphanumeric: a15]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Previous surname if changed [Titlecase: t30]
        /// </summary>
        public string PREVIOUS_NAME { get; internal set; }
        /// <summary>
        /// Gender of staff member (M/F) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of Birth [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Home address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? HOMEKEY { get; internal set; }
        /// <summary>
        /// Mail address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MAILKEY { get; internal set; }
        /// <summary>
        /// Mobile phone [Uppercase Alphanumeric: u20]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Work phone [Alphanumeric: a20]
        /// </summary>
        public string WORK_PHONE { get; internal set; }
        /// <summary>
        /// E-mail address [Alphanumeric: a60]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Victorian Institute of Teaching ID Number [Alphanumeric: a10]
        /// </summary>
        public string VIT_NO { get; internal set; }
        /// <summary>
        /// Start date at school [Date Time nullable: d]
        /// </summary>
        public DateTime? START { get; internal set; }
        /// <summary>
        /// Finished date at school [Date Time nullable: d]
        /// </summary>
        public DateTime? FINISH { get; internal set; }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY01 { get; internal set; }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY02 { get; internal set; }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY03 { get; internal set; }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY04 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT01 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT02 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT03 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT04 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT05 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT06 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT07 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT08 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT09 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT10 { get; internal set; }
        /// <summary>
        /// Full time equivalent [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? FTE { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY01 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY02 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY03 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY04 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY05 { get; internal set; }
        /// <summary>
        /// ? [Integer (16bit signed nullable): i]
        /// </summary>
        public short? RANK { get; internal set; }
        /// <summary>
        /// ID of home campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// School house [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HOUSE { get; internal set; }
        /// <summary>
        /// Home teaching room [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Usual location when not teaching [Uppercase Alphanumeric: u4]
        /// </summary>
        public string OTHER_LOCATION { get; internal set; }
        /// <summary>
        /// Car registration number [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CAR_REGO { get; internal set; }
        /// <summary>
        /// Teacher available for timetabling: T=Available, N=Non-teacher, L=Left, U=Unavailable, E=Emergency [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STAFF_TYPE { get; internal set; }
        /// <summary>
        /// (Was POS_CODE) Reference to Staff Position (1) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string POS_CODE_A { get; internal set; }
        /// <summary>
        /// Reference to Staff Position (2) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string POS_CODE_B { get; internal set; }
        /// <summary>
        /// Teacher type (Permanent, Secondment, Volunteer, etc) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Staff status: Active,Left school [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF_STATUS { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAJORA { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAJORB { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAJORC { get; internal set; }
        /// <summary>
        /// Details of any additional skills, etc [Memo: m]
        /// </summary>
        public string SKILL_QUALIFICATION { get; internal set; }
        /// <summary>
        /// Central payroll record number [Uppercase Alphanumeric: u9]
        /// </summary>
        public string PAYROLL_REC_NO { get; internal set; }
        /// <summary>
        /// Central payroll classification [Alphanumeric: a20]
        /// </summary>
        public string PAYROLL_CLASS { get; internal set; }
        /// <summary>
        /// Religion [Uppercase Alphanumeric: u12]
        /// </summary>
        public string RELIGION { get; internal set; }
        /// <summary>
        /// Staff name to be used in reports [Alphanumeric: a30]
        /// </summary>
        public string REPORT_NAME { get; internal set; }
        /// <summary>
        /// Police clearance? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string POLICE_CLEARANCE { get; internal set; }
        /// <summary>
        /// Last police clearance date [Date Time nullable: d]
        /// </summary>
        public DateTime? CLEARANCE_DATE { get; internal set; }
        /// <summary>
        /// Staff Photograph [Picture (byte array): bp]
        /// </summary>
        public byte[] STAFF_PIC { get; internal set; }
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
        /// Indicates which periods teacher is available for extras: used by Calendar [Available (byte array): ba]
        /// </summary>
        public byte[] AVAILABLE { get; internal set; }
        /// <summary>
        /// Maximum number of extras allowed in a year/term [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_EXTRAS { get; internal set; }
        /// <summary>
        /// No of extras already taken this year/term [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACC_EXTRAS { get; internal set; }
        /// <summary>
        /// No of extras already taken this cycle/week [Integer (16bit signed nullable): i]
        /// </summary>
        public short? WEEK_EXTRAS { get; internal set; }
        /// <summary>
        /// Last date an extra taken [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_EXTRAS { get; internal set; }
        /// <summary>
        /// (Was COUNTRY_BIRTH) Country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Language(s) spoken by this staff member [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LANG01 { get; internal set; }
        /// <summary>
        /// Language(s) spoken by this staff member [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LANG02 { get; internal set; }
        /// <summary>
        /// Able and willing to act as interpreter [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER01 { get; internal set; }
        /// <summary>
        /// Able and willing to act as interpreter [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER02 { get; internal set; }
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
        /// Relationship to staff member of each person to contact in an emergency [Titlecase: t12]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to staff member of each person to contact in an emergency [Titlecase: t12]
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
        /// Is this staff member prepared to be in any special groups? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GROUP_AVAILABILITY { get; internal set; }
        /// <summary>
        /// Normal timetable load for this staff member [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Y/N information regarding whether the employee records should be updated via HRMS import [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HRMS_UPDATE { get; internal set; }
        /// <summary>
        /// Last update from HRMS import [Date Time nullable: d]
        /// </summary>
        public DateTime? HRMS_DATETIME { get; internal set; }
        /// <summary>
        /// Link to sundry debtors [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DEBTOR_ID { get; internal set; }
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
        /// Navigation property for [HOMEKEY] => [UM_Entity].[UMKEY]
        /// Home address ID
        /// </summary>
        public UM_Entity HOMEKEY_UM {
            get
            {
                if (HOMEKEY.HasValue)
                {
                    if (_HOMEKEY_UM == null)
                    {
                        _HOMEKEY_UM = Context.UM.FindByUMKEY(HOMEKEY.Value);
                    }
                    return _HOMEKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MAILKEY] => [UM_Entity].[UMKEY]
        /// Mail address ID
        /// </summary>
        public UM_Entity MAILKEY_UM {
            get
            {
                if (MAILKEY.HasValue)
                {
                    if (_MAILKEY_UM == null)
                    {
                        _MAILKEY_UM = Context.UM.FindByUMKEY(MAILKEY.Value);
                    }
                    return _MAILKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FACULTY01] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY01_KSF {
            get
            {
                if (FACULTY01 != null)
                {
                    if (_FACULTY01_KSF == null)
                    {
                        _FACULTY01_KSF = Context.KSF.FindByKSFKEY(FACULTY01);
                    }
                    return _FACULTY01_KSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FACULTY02] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY02_KSF {
            get
            {
                if (FACULTY02 != null)
                {
                    if (_FACULTY02_KSF == null)
                    {
                        _FACULTY02_KSF = Context.KSF.FindByKSFKEY(FACULTY02);
                    }
                    return _FACULTY02_KSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FACULTY03] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY03_KSF {
            get
            {
                if (FACULTY03 != null)
                {
                    if (_FACULTY03_KSF == null)
                    {
                        _FACULTY03_KSF = Context.KSF.FindByKSFKEY(FACULTY03);
                    }
                    return _FACULTY03_KSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FACULTY04] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY04_KSF {
            get
            {
                if (FACULTY04 != null)
                {
                    if (_FACULTY04_KSF == null)
                    {
                        _FACULTY04_KSF = Context.KSF.FindByKSFKEY(FACULTY04);
                    }
                    return _FACULTY04_KSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT01] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT01_SU {
            get
            {
                if (SUBJECT01 != null)
                {
                    if (_SUBJECT01_SU == null)
                    {
                        _SUBJECT01_SU = Context.SU.FindBySUKEY(SUBJECT01);
                    }
                    return _SUBJECT01_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT02] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT02_SU {
            get
            {
                if (SUBJECT02 != null)
                {
                    if (_SUBJECT02_SU == null)
                    {
                        _SUBJECT02_SU = Context.SU.FindBySUKEY(SUBJECT02);
                    }
                    return _SUBJECT02_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT03] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT03_SU {
            get
            {
                if (SUBJECT03 != null)
                {
                    if (_SUBJECT03_SU == null)
                    {
                        _SUBJECT03_SU = Context.SU.FindBySUKEY(SUBJECT03);
                    }
                    return _SUBJECT03_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT04] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT04_SU {
            get
            {
                if (SUBJECT04 != null)
                {
                    if (_SUBJECT04_SU == null)
                    {
                        _SUBJECT04_SU = Context.SU.FindBySUKEY(SUBJECT04);
                    }
                    return _SUBJECT04_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT05] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT05_SU {
            get
            {
                if (SUBJECT05 != null)
                {
                    if (_SUBJECT05_SU == null)
                    {
                        _SUBJECT05_SU = Context.SU.FindBySUKEY(SUBJECT05);
                    }
                    return _SUBJECT05_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT06] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT06_SU {
            get
            {
                if (SUBJECT06 != null)
                {
                    if (_SUBJECT06_SU == null)
                    {
                        _SUBJECT06_SU = Context.SU.FindBySUKEY(SUBJECT06);
                    }
                    return _SUBJECT06_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT07] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT07_SU {
            get
            {
                if (SUBJECT07 != null)
                {
                    if (_SUBJECT07_SU == null)
                    {
                        _SUBJECT07_SU = Context.SU.FindBySUKEY(SUBJECT07);
                    }
                    return _SUBJECT07_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT08] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT08_SU {
            get
            {
                if (SUBJECT08 != null)
                {
                    if (_SUBJECT08_SU == null)
                    {
                        _SUBJECT08_SU = Context.SU.FindBySUKEY(SUBJECT08);
                    }
                    return _SUBJECT08_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT09] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT09_SU {
            get
            {
                if (SUBJECT09 != null)
                {
                    if (_SUBJECT09_SU == null)
                    {
                        _SUBJECT09_SU = Context.SU.FindBySUKEY(SUBJECT09);
                    }
                    return _SUBJECT09_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT10] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT10_SU {
            get
            {
                if (SUBJECT10 != null)
                {
                    if (_SUBJECT10_SU == null)
                    {
                        _SUBJECT10_SU = Context.SU.FindBySUKEY(SUBJECT10);
                    }
                    return _SUBJECT10_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// ID of home campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOUSE] => [KGH_Entity].[KGHKEY]
        /// School house
        /// </summary>
        public KGH_Entity HOUSE_KGH {
            get
            {
                if (HOUSE != null)
                {
                    if (_HOUSE_KGH == null)
                    {
                        _HOUSE_KGH = Context.KGH.FindByKGHKEY(HOUSE);
                    }
                    return _HOUSE_KGH;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Home teaching room
        /// </summary>
        public SM_Entity ROOM_SM {
            get
            {
                if (ROOM != null)
                {
                    if (_ROOM_SM == null)
                    {
                        _ROOM_SM = Context.SM.FindByROOM(ROOM);
                    }
                    return _ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [OTHER_LOCATION] => [SM_Entity].[ROOM]
        /// Usual location when not teaching
        /// </summary>
        public SM_Entity OTHER_LOCATION_SM {
            get
            {
                if (OTHER_LOCATION != null)
                {
                    if (_OTHER_LOCATION_SM == null)
                    {
                        _OTHER_LOCATION_SM = Context.SM.FindByROOM(OTHER_LOCATION);
                    }
                    return _OTHER_LOCATION_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [POS_CODE_A] => [KSC_Entity].[KSCKEY]
        /// (Was POS_CODE) Reference to Staff Position (1)
        /// </summary>
        public KSC_Entity POS_CODE_A_KSC {
            get
            {
                if (POS_CODE_A != null)
                {
                    if (_POS_CODE_A_KSC == null)
                    {
                        _POS_CODE_A_KSC = Context.KSC.FindByKSCKEY(POS_CODE_A);
                    }
                    return _POS_CODE_A_KSC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [POS_CODE_B] => [KSC_Entity].[KSCKEY]
        /// Reference to Staff Position (2)
        /// </summary>
        public KSC_Entity POS_CODE_B_KSC {
            get
            {
                if (POS_CODE_B != null)
                {
                    if (_POS_CODE_B_KSC == null)
                    {
                        _POS_CODE_B_KSC = Context.KSC.FindByKSCKEY(POS_CODE_B);
                    }
                    return _POS_CODE_B_KSC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MAJORA] => [KSA_Entity].[KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA_Entity MAJORA_KSA {
            get
            {
                if (MAJORA != null)
                {
                    if (_MAJORA_KSA == null)
                    {
                        _MAJORA_KSA = Context.KSA.FindByKSAKEY(MAJORA);
                    }
                    return _MAJORA_KSA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MAJORB] => [KSA_Entity].[KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA_Entity MAJORB_KSA {
            get
            {
                if (MAJORB != null)
                {
                    if (_MAJORB_KSA == null)
                    {
                        _MAJORB_KSA = Context.KSA.FindByKSAKEY(MAJORB);
                    }
                    return _MAJORB_KSA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MAJORC] => [KSA_Entity].[KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA_Entity MAJORC_KSA {
            get
            {
                if (MAJORC != null)
                {
                    if (_MAJORC_KSA == null)
                    {
                        _MAJORC_KSA = Context.KSA.FindByKSAKEY(MAJORC);
                    }
                    return _MAJORC_KSA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [RELIGION] => [KGR_Entity].[RELIGION]
        /// Religion
        /// </summary>
        public KGR_Entity RELIGION_KGR {
            get
            {
                if (RELIGION != null)
                {
                    if (_RELIGION_KGR == null)
                    {
                        _RELIGION_KGR = Context.KGR.FindByRELIGION(RELIGION);
                    }
                    return _RELIGION_KGR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// (Was COUNTRY_BIRTH) Country of birth
        /// </summary>
        public KGT_Entity BIRTH_COUNTRY_KGT {
            get
            {
                if (BIRTH_COUNTRY != null)
                {
                    if (_BIRTH_COUNTRY_KGT == null)
                    {
                        _BIRTH_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY);
                    }
                    return _BIRTH_COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LANG01] => [KGL_Entity].[KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL_Entity LANG01_KGL {
            get
            {
                if (LANG01 != null)
                {
                    if (_LANG01_KGL == null)
                    {
                        _LANG01_KGL = Context.KGL.FindByKGLKEY(LANG01);
                    }
                    return _LANG01_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LANG02] => [KGL_Entity].[KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL_Entity LANG02_KGL {
            get
            {
                if (LANG02 != null)
                {
                    if (_LANG02_KGL == null)
                    {
                        _LANG02_KGL = Context.KGL.FindByKGLKEY(LANG02);
                    }
                    return _LANG02_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EMERG_LANG01] => [KGL_Entity].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL_Entity EMERG_LANG01_KGL {
            get
            {
                if (EMERG_LANG01 != null)
                {
                    if (_EMERG_LANG01_KGL == null)
                    {
                        _EMERG_LANG01_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG01);
                    }
                    return _EMERG_LANG01_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EMERG_LANG02] => [KGL_Entity].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL_Entity EMERG_LANG02_KGL {
            get
            {
                if (EMERG_LANG02 != null)
                {
                    if (_EMERG_LANG02_KGL == null)
                    {
                        _EMERG_LANG02_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG02);
                    }
                    return _EMERG_LANG02_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DEBTOR_ID] => [DR_Entity].[DRKEY]
        /// Link to sundry debtors
        /// </summary>
        public DR_Entity DEBTOR_ID_DR {
            get
            {
                if (DEBTOR_ID != null)
                {
                    if (_DEBTOR_ID_DR == null)
                    {
                        _DEBTOR_ID_DR = Context.DR.FindByDRKEY(DEBTOR_ID);
                    }
                    return _DEBTOR_ID_DR;
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
