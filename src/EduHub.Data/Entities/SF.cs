using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff
    /// </summary>
    public partial class SF : EntityBase
    {
#region Navigation Property Cache
        private UM _HOMEKEY_UM;
        private UM _MAILKEY_UM;
        private KSF _FACULTY01_KSF;
        private KSF _FACULTY02_KSF;
        private KSF _FACULTY03_KSF;
        private KSF _FACULTY04_KSF;
        private SU _SUBJECT01_SU;
        private SU _SUBJECT02_SU;
        private SU _SUBJECT03_SU;
        private SU _SUBJECT04_SU;
        private SU _SUBJECT05_SU;
        private SU _SUBJECT06_SU;
        private SU _SUBJECT07_SU;
        private SU _SUBJECT08_SU;
        private SU _SUBJECT09_SU;
        private SU _SUBJECT10_SU;
        private SCI _CAMPUS_SCI;
        private KGH _HOUSE_KGH;
        private SM _ROOM_SM;
        private SM _OTHER_LOCATION_SM;
        private KSC _POS_CODE_A_KSC;
        private KSC _POS_CODE_B_KSC;
        private KSA _MAJORA_KSA;
        private KSA _MAJORB_KSA;
        private KSA _MAJORC_KSA;
        private KGR _RELIGION_KGR;
        private KGT _BIRTH_COUNTRY_KGT;
        private KGL _LANG01_KGL;
        private KGL _LANG02_KGL;
        private KGL _EMERG_LANG01_KGL;
        private KGL _EMERG_LANG02_KGL;
        private DR _DEBTOR_ID_DR;
#endregion

#region Field Properties
        /// <summary>
        /// Staff member code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFKEY { get; internal set; }
        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// Title: Mr, Ms, etc
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE { get; internal set; }
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
        /// [Alphanumeric (15)]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Previous surname if changed
        /// [Titlecase (30)]
        /// </summary>
        public string PREVIOUS_NAME { get; internal set; }
        /// <summary>
        /// Gender of staff member (M/F)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Home address ID
        /// </summary>
        public int? HOMEKEY { get; internal set; }
        /// <summary>
        /// Mail address ID
        /// </summary>
        public int? MAILKEY { get; internal set; }
        /// <summary>
        /// Mobile phone
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Work phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string WORK_PHONE { get; internal set; }
        /// <summary>
        /// E-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Victorian Institute of Teaching ID Number
        /// [Alphanumeric (10)]
        /// </summary>
        public string VIT_NO { get; internal set; }
        /// <summary>
        /// Start date at school
        /// </summary>
        public DateTime? START { get; internal set; }
        /// <summary>
        /// Finished date at school
        /// </summary>
        public DateTime? FINISH { get; internal set; }
        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY01 { get; internal set; }
        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY02 { get; internal set; }
        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY03 { get; internal set; }
        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY04 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT01 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT02 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT03 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT04 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT05 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT06 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT07 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT08 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT09 { get; internal set; }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT10 { get; internal set; }
        /// <summary>
        /// Full time equivalent
        /// </summary>
        public double? FTE { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY01 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY02 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY03 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY04 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY05 { get; internal set; }
        /// <summary>
        /// ?
        /// </summary>
        public short? RANK { get; internal set; }
        /// <summary>
        /// ID of home campus
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// School house
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HOUSE { get; internal set; }
        /// <summary>
        /// Home teaching room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Usual location when not teaching
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string OTHER_LOCATION { get; internal set; }
        /// <summary>
        /// Car registration number
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CAR_REGO { get; internal set; }
        /// <summary>
        /// Teacher available for timetabling: T=Available, N=Non-teacher, L=Left, U=Unavailable, E=Emergency
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STAFF_TYPE { get; internal set; }
        /// <summary>
        /// (Was POS_CODE) Reference to Staff Position (1)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string POS_CODE_A { get; internal set; }
        /// <summary>
        /// Reference to Staff Position (2)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string POS_CODE_B { get; internal set; }
        /// <summary>
        /// Teacher type (Permanent, Secondment, Volunteer, etc)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Staff status: Active,Left school
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF_STATUS { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAJORA { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAJORB { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAJORC { get; internal set; }
        /// <summary>
        /// Details of any additional skills, etc
        /// [Memo]
        /// </summary>
        public string SKILL_QUALIFICATION { get; internal set; }
        /// <summary>
        /// Central payroll record number
        /// [Uppercase Alphanumeric (9)]
        /// </summary>
        public string PAYROLL_REC_NO { get; internal set; }
        /// <summary>
        /// Central payroll classification
        /// [Alphanumeric (20)]
        /// </summary>
        public string PAYROLL_CLASS { get; internal set; }
        /// <summary>
        /// Religion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string RELIGION { get; internal set; }
        /// <summary>
        /// Staff name to be used in reports
        /// [Alphanumeric (30)]
        /// </summary>
        public string REPORT_NAME { get; internal set; }
        /// <summary>
        /// Police clearance? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string POLICE_CLEARANCE { get; internal set; }
        /// <summary>
        /// Last police clearance date
        /// </summary>
        public DateTime? CLEARANCE_DATE { get; internal set; }
        /// <summary>
        /// Staff Photograph
        /// </summary>
        public byte[] STAFF_PIC { get; internal set; }
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
        /// Indicates which periods teacher is available for extras: used by Calendar
        /// </summary>
        public byte[] AVAILABLE { get; internal set; }
        /// <summary>
        /// Maximum number of extras allowed in a year/term
        /// </summary>
        public short? MAX_EXTRAS { get; internal set; }
        /// <summary>
        /// No of extras already taken this year/term
        /// </summary>
        public short? ACC_EXTRAS { get; internal set; }
        /// <summary>
        /// No of extras already taken this cycle/week
        /// </summary>
        public short? WEEK_EXTRAS { get; internal set; }
        /// <summary>
        /// Last date an extra taken
        /// </summary>
        public DateTime? LAST_EXTRAS { get; internal set; }
        /// <summary>
        /// (Was COUNTRY_BIRTH) Country of birth
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Language(s) spoken by this staff member
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LANG01 { get; internal set; }
        /// <summary>
        /// Language(s) spoken by this staff member
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LANG02 { get; internal set; }
        /// <summary>
        /// Able and willing to act as interpreter
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTERPRETER01 { get; internal set; }
        /// <summary>
        /// Able and willing to act as interpreter
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTERPRETER02 { get; internal set; }
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
        /// Relationship to staff member of each person to contact in an emergency
        /// [Titlecase (12)]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to staff member of each person to contact in an emergency
        /// [Titlecase (12)]
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
        /// Is this staff member prepared to be in any special groups? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_AVAILABILITY { get; internal set; }
        /// <summary>
        /// Normal timetable load for this staff member
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Y/N information regarding whether the employee records should be updated via HRMS import
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HRMS_UPDATE { get; internal set; }
        /// <summary>
        /// Last update from HRMS import
        /// </summary>
        public DateTime? HRMS_DATETIME { get; internal set; }
        /// <summary>
        /// Link to sundry debtors
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEBTOR_ID { get; internal set; }
        /// <summary>
        /// Notes - any general purpose
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }
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
        /// UM (Addresses) related entity by [SF.HOMEKEY]-&gt;[UM.UMKEY]
        /// Home address ID
        /// </summary>
        public UM HOMEKEY_UM
        {
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
        /// UM (Addresses) related entity by [SF.MAILKEY]-&gt;[UM.UMKEY]
        /// Mail address ID
        /// </summary>
        public UM MAILKEY_UM
        {
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
        /// KSF (Faculties) related entity by [SF.FACULTY01]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY01_KSF
        {
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
        /// KSF (Faculties) related entity by [SF.FACULTY02]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY02_KSF
        {
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
        /// KSF (Faculties) related entity by [SF.FACULTY03]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY03_KSF
        {
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
        /// KSF (Faculties) related entity by [SF.FACULTY04]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY04_KSF
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT01]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT01_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT02]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT02_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT03]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT03_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT04]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT04_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT05]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT05_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT06]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT06_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT07]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT07_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT08]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT08_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT09]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT09_SU
        {
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
        /// SU (Subjects) related entity by [SF.SUBJECT10]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT10_SU
        {
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
        /// SCI (School Information) related entity by [SF.CAMPUS]-&gt;[SCI.SCIKEY]
        /// ID of home campus
        /// </summary>
        public SCI CAMPUS_SCI
        {
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
        /// KGH (Houses) related entity by [SF.HOUSE]-&gt;[KGH.KGHKEY]
        /// School house
        /// </summary>
        public KGH HOUSE_KGH
        {
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
        /// SM (Rooms) related entity by [SF.ROOM]-&gt;[SM.ROOM]
        /// Home teaching room
        /// </summary>
        public SM ROOM_SM
        {
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
        /// SM (Rooms) related entity by [SF.OTHER_LOCATION]-&gt;[SM.ROOM]
        /// Usual location when not teaching
        /// </summary>
        public SM OTHER_LOCATION_SM
        {
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
        /// KSC (Staff Positions) related entity by [SF.POS_CODE_A]-&gt;[KSC.KSCKEY]
        /// (Was POS_CODE) Reference to Staff Position (1)
        /// </summary>
        public KSC POS_CODE_A_KSC
        {
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
        /// KSC (Staff Positions) related entity by [SF.POS_CODE_B]-&gt;[KSC.KSCKEY]
        /// Reference to Staff Position (2)
        /// </summary>
        public KSC POS_CODE_B_KSC
        {
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
        /// KSA (Areas of Teaching) related entity by [SF.MAJORA]-&gt;[KSA.KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA MAJORA_KSA
        {
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
        /// KSA (Areas of Teaching) related entity by [SF.MAJORB]-&gt;[KSA.KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA MAJORB_KSA
        {
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
        /// KSA (Areas of Teaching) related entity by [SF.MAJORC]-&gt;[KSA.KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA MAJORC_KSA
        {
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
        /// KGR (Religions) related entity by [SF.RELIGION]-&gt;[KGR.RELIGION]
        /// Religion
        /// </summary>
        public KGR RELIGION_KGR
        {
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
        /// KGT (Countries) related entity by [SF.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// (Was COUNTRY_BIRTH) Country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_KGT
        {
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
        /// KGL (Languages) related entity by [SF.LANG01]-&gt;[KGL.KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL LANG01_KGL
        {
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
        /// KGL (Languages) related entity by [SF.LANG02]-&gt;[KGL.KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL LANG02_KGL
        {
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
        /// KGL (Languages) related entity by [SF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG01_KGL
        {
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
        /// KGL (Languages) related entity by [SF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG02_KGL
        {
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
        /// DR (Accounts Receivable) related entity by [SF.DEBTOR_ID]-&gt;[DR.DRKEY]
        /// Link to sundry debtors
        /// </summary>
        public DR DEBTOR_ID_DR
        {
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

        /// <summary>
        /// AKK (Asset Key Holders) related entities by [AKK.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<AKK> AKK_STAFF
        {
            get
            {
                return Context.SF.FindAKKBySTAFF(SFKEY);
            }
        }

        /// <summary>
        /// BKHR (Book Hire Records) related entities by [BKHR.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<BKHR> BKHR_STAFF
        {
            get
            {
                return Context.SF.FindBKHRBySTAFF(SFKEY);
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entities by [KCY.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<KCY> KCY_TEACHER
        {
            get
            {
                return Context.SF.FindKCYByTEACHER(SFKEY);
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entities by [KCY.TEACHER_B]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<KCY> KCY_TEACHER_B
        {
            get
            {
                return Context.SF.FindKCYByTEACHER_B(SFKEY);
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<KGC> KGC_TEACHER
        {
            get
            {
                return Context.SF.FindKGCByTEACHER(SFKEY);
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.TEACHER_B]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<KGC> KGC_TEACHER_B
        {
            get
            {
                return Context.SF.FindKGCByTEACHER_B(SFKEY);
            }
        }

        /// <summary>
        /// KSF (Faculties) related entities by [KSF.COORDINATOR]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<KSF> KSF_COORDINATOR
        {
            get
            {
                return Context.SF.FindKSFByCOORDINATOR(SFKEY);
            }
        }

        /// <summary>
        /// SAD (Accidents) related entities by [SAD.AREA_DUTY_TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SAD> SAD_AREA_DUTY_TEACHER
        {
            get
            {
                return Context.SF.FindSADByAREA_DUTY_TEACHER(SFKEY);
            }
        }

        /// <summary>
        /// SAIM (Sickbay Medication Administrations) related entities by [SAIM.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SAIM> SAIM_STAFF
        {
            get
            {
                return Context.SF.FindSAIMBySTAFF(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_PRINCIPAL]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_PRINCIPAL
        {
            get
            {
                return Context.SF.FindSCIBySCH_PRINCIPAL(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_OIC]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_OIC
        {
            get
            {
                return Context.SF.FindSCIBySF_OIC(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_VPRIN
        {
            get
            {
                return Context.SF.FindSCIBySF_VPRIN(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_2VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_2VPRIN
        {
            get
            {
                return Context.SF.FindSCIBySF_2VPRIN(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_3VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_3VPRIN
        {
            get
            {
                return Context.SF.FindSCIBySF_3VPRIN(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_APRIN]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_APRIN
        {
            get
            {
                return Context.SF.FindSCIBySF_APRIN(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_BMANAGER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_BMANAGER
        {
            get
            {
                return Context.SF.FindSCIBySF_BMANAGER(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_VAC_CONTACT
        {
            get
            {
                return Context.SF.FindSCIBySF_VAC_CONTACT(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SF_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SF_EMERG_CONTACT
        {
            get
            {
                return Context.SF.FindSCIBySF_EMERG_CONTACT(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_AOIC]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_AOIC
        {
            get
            {
                return Context.SF.FindSCIBySCH_AOIC(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_VPRIN
        {
            get
            {
                return Context.SF.FindSCIBySCH_VPRIN(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_BMANAGER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_BMANAGER
        {
            get
            {
                return Context.SF.FindSCIBySCH_BMANAGER(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_VAC_CONTACT
        {
            get
            {
                return Context.SF.FindSCIBySCH_VAC_CONTACT(SFKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_EMERG_CONTACT
        {
            get
            {
                return Context.SF.FindSCIBySCH_EMERG_CONTACT(SFKEY);
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SCL.TEACHER01]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCL> SCL_TEACHER01
        {
            get
            {
                return Context.SF.FindSCLByTEACHER01(SFKEY);
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SCL.TEACHER02]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SCL> SCL_TEACHER02
        {
            get
            {
                return Context.SF.FindSCLByTEACHER02(SFKEY);
            }
        }

        /// <summary>
        /// SDPA (Disciplinary Actions) related entities by [SDPA.TAKEN_BY]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SDPA> SDPA_TAKEN_BY
        {
            get
            {
                return Context.SF.FindSDPAByTAKEN_BY(SFKEY);
            }
        }

        /// <summary>
        /// SFAQ (Staff Availability in Quilt) related entities by [SFAQ.SFAQKEY]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SFAQ> SFAQ_SFAQKEY
        {
            get
            {
                return Context.SF.FindSFAQBySFAQKEY(SFKEY);
            }
        }

        /// <summary>
        /// SFAV (Staff Availability for Calendar Extras) related entities by [SFAV.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SFAV> SFAV_TEACH
        {
            get
            {
                return Context.SF.FindSFAVByTEACH(SFKEY);
            }
        }

        /// <summary>
        /// SFQA (Staff Qualifications) related entities by [SFQA.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SFQA> SFQA_TEACH
        {
            get
            {
                return Context.SF.FindSFQAByTEACH(SFKEY);
            }
        }

        /// <summary>
        /// SM (Rooms) related entities by [SM.STAFF_CODE]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SM> SM_STAFF_CODE
        {
            get
            {
                return Context.SF.FindSMBySTAFF_CODE(SFKEY);
            }
        }

        /// <summary>
        /// SMCD (Student Medication Doses) related entities by [SMCD.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SMCD> SMCD_STAFF
        {
            get
            {
                return Context.SF.FindSMCDBySTAFF(SFKEY);
            }
        }

        /// <summary>
        /// SS (Specialist Subjects) related entities by [SS.DEFAULT_TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SS> SS_DEFAULT_TEACHER
        {
            get
            {
                return Context.SF.FindSSByDEFAULT_TEACHER(SFKEY);
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [SSHG.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<SSHG> SSHG_TEACHER
        {
            get
            {
                return Context.SF.FindSSHGByTEACHER(SFKEY);
            }
        }

        /// <summary>
        /// STSP (Suspension Details) related entities by [STSP.REF_TEACHERA]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<STSP> STSP_REF_TEACHERA
        {
            get
            {
                return Context.SF.FindSTSPByREF_TEACHERA(SFKEY);
            }
        }

        /// <summary>
        /// STSP (Suspension Details) related entities by [STSP.REF_TEACHERB]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<STSP> STSP_REF_TEACHERB
        {
            get
            {
                return Context.SF.FindSTSPByREF_TEACHERB(SFKEY);
            }
        }

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [TCTB.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TCTB> TCTB_TEACHER
        {
            get
            {
                return Context.SF.FindTCTBByTEACHER(SFKEY);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_T1TEACH
        {
            get
            {
                return Context.SF.FindTCTQByT1TEACH(SFKEY);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_T2TEACH
        {
            get
            {
                return Context.SF.FindTCTQByT2TEACH(SFKEY);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_EXTRA_TEACH
        {
            get
            {
                return Context.SF.FindTCTQByEXTRA_TEACH(SFKEY);
            }
        }

        /// <summary>
        /// TCTR (Teacher Replacements) related entities by [TCTR.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TCTR> TCTR_TEACH
        {
            get
            {
                return Context.SF.FindTCTRByTEACH(SFKEY);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_T1TEACH
        {
            get
            {
                return Context.SF.FindTHTQByT1TEACH(SFKEY);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_T2TEACH
        {
            get
            {
                return Context.SF.FindTHTQByT2TEACH(SFKEY);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_EXTRA_TEACH
        {
            get
            {
                return Context.SF.FindTHTQByEXTRA_TEACH(SFKEY);
            }
        }

        /// <summary>
        /// TTEF (Exam Staff) related entities by [TTEF.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TTEF> TTEF_STAFF
        {
            get
            {
                return Context.SF.FindTTEFBySTAFF(SFKEY);
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [TTTG.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TTTG> TTTG_T1TEACH
        {
            get
            {
                return Context.SF.FindTTTGByT1TEACH(SFKEY);
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [TTTG.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TTTG> TTTG_T2TEACH
        {
            get
            {
                return Context.SF.FindTTTGByT2TEACH(SFKEY);
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [TXAS.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        public IReadOnlyList<TXAS> TXAS_TEACHER
        {
            get
            {
                return Context.SF.FindTXASByTEACHER(SFKEY);
            }
        }
#endregion
    }
}
