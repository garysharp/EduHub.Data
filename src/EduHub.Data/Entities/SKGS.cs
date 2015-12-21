using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Schools
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SKGS : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<DF_TFR> Cache_SCHOOL_DF_TFR_ORIG_SCHOOL;
        private IReadOnlyList<FDT_EXP> Cache_SCHOOL_FDT_EXP_DEST;
        private IReadOnlyList<FER_FDT> Cache_SCHOOL_FER_FDT_SOURCE;
        private IReadOnlyList<KCD_TFR> Cache_SCHOOL_KCD_TFR_ORIG_SCHOOL;
        private IReadOnlyList<KCM_TFR> Cache_SCHOOL_KCM_TFR_ORIG_SCHOOL;
        private SCI Cache_SCHOOL_SCI_SCHOOL_LINK;
        private IReadOnlyList<SCI> Cache_SCHOOL_SCI_DESTINATION_SCHOOL;
        private IReadOnlyList<SMC_TFR> Cache_SCHOOL_SMC_TFR_ORIG_SCHOOL;
        private IReadOnlyList<ST> Cache_SCHOOL_ST_PREVIOUS_SCHOOL;
        private IReadOnlyList<ST> Cache_SCHOOL_ST_NEXT_SCHOOL;
        private IReadOnlyList<ST_TFR> Cache_SCHOOL_ST_TFR_ORIG_SCHOOL;
        private IReadOnlyList<ST_TFRIO> Cache_SCHOOL_ST_TFRIO_DEST_SCHOOL;
        private IReadOnlyList<STPT> Cache_SCHOOL_STPT_SCHL_NUM;
        private IReadOnlyList<STRE> Cache_SCHOOL_STRE_ST_PREVIOUS_SCHOOL;
        private IReadOnlyList<STRE> Cache_SCHOOL_STRE_STPT_SCHL_NUM01;
        private IReadOnlyList<STRE> Cache_SCHOOL_STRE_STPT_SCHL_NUM02;
        private IReadOnlyList<STRE> Cache_SCHOOL_STRE_STPT_SCHL_NUM03;
        private IReadOnlyList<STRE> Cache_SCHOOL_STRE_STPT_SCHL_NUM04;
        private IReadOnlyList<STRE> Cache_SCHOOL_STRE_ST_NEXT_SCHOOL;
        private IReadOnlyList<UM_TFR> Cache_SCHOOL_UM_TFR_ORIG_SCHOOL;

        #endregion

        #region Field Properties

        /// <summary>
        /// School ID
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL { get; internal set; }

        /// <summary>
        /// School Name
        /// [Alphanumeric (40)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// School type: Primary, Secondary, Special, etc
        /// [Alphanumeric (33)]
        /// </summary>
        public string SCHOOL_TYPE { get; internal set; }

        /// <summary>
        /// School type: Government, Private, etc
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ENTITY { get; internal set; }

        /// <summary>
        /// DEET-defined school ID
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }

        /// <summary>
        /// (Was SCHOOL_CAMPUS) Campus number
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SCHOOL_NUMBER { get; internal set; }

        /// <summary>
        /// Campus type: Primary, etc
        /// [Alphanumeric (33)]
        /// </summary>
        public string CAMPUS_TYPE { get; internal set; }

        /// <summary>
        /// Campus name
        /// [Alphanumeric (40)]
        /// </summary>
        public string CAMPUS_NAME { get; internal set; }

        /// <summary>
        /// Region
        /// </summary>
        public short? REGION { get; internal set; }

        /// <summary>
        /// Name of Region
        /// [Alphanumeric (30)]
        /// </summary>
        public string REGION_NAME { get; internal set; }

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
        /// (Was E_MAIL_ADDRESS) E-mail address
        /// [Alphanumeric (255)]
        /// </summary>
        public string E_MAIL { get; internal set; }

        /// <summary>
        /// Internet address
        /// [Alphanumeric (255)]
        /// </summary>
        public string INTERNET_ADDRESS { get; internal set; }

        /// <summary>
        /// CASES 21 release no
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string CASES21_RELEASE { get; internal set; }

        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAP_TYPE { get; internal set; }

        /// <summary>
        /// Map no
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
        /// School Principal's Title: Mr, Mrs, etc
        /// [Titlecase (4)]
        /// </summary>
        public string SCH_PRINCIPAL_SALUTATION { get; internal set; }

        /// <summary>
        /// School Principal's First Name
        /// [Titlecase (20)]
        /// </summary>
        public string SCH_PRINCIPAL_FIRST_NAME { get; internal set; }

        /// <summary>
        /// School Principal's Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SCH_PRINCIPAL_SURNAME { get; internal set; }

        /// <summary>
        /// School Principal's Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SCH_PRINCIPAL_TELEPHONE { get; internal set; }

        /// <summary>
        /// Campus Principal's title: Mr, Mrs, etc
        /// [Titlecase (4)]
        /// </summary>
        public string SALUTATION { get; internal set; }

        /// <summary>
        /// Campus Principal's surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// Campus Principal's first given name
        /// [Titlecase (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// School closed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLOSED { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// DF_TFR (DF Transfer) related entities by [SKGS.SCHOOL]-&gt;[DF_TFR.ORIG_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<DF_TFR> SCHOOL_DF_TFR_ORIG_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_DF_TFR_ORIG_SCHOOL == null &&
                    !Context.DF_TFR.TryFindByORIG_SCHOOL(SCHOOL, out Cache_SCHOOL_DF_TFR_ORIG_SCHOOL))
                {
                    Cache_SCHOOL_DF_TFR_ORIG_SCHOOL = new List<DF_TFR>().AsReadOnly();
                }

                return Cache_SCHOOL_DF_TFR_ORIG_SCHOOL;
            }
        }

        /// <summary>
        /// FDT_EXP (Financial Data Export) related entities by [SKGS.SCHOOL]-&gt;[FDT_EXP.DEST]
        /// School ID
        /// </summary>
        public IReadOnlyList<FDT_EXP> SCHOOL_FDT_EXP_DEST
        {
            get
            {
                if (Cache_SCHOOL_FDT_EXP_DEST == null &&
                    !Context.FDT_EXP.TryFindByDEST(SCHOOL, out Cache_SCHOOL_FDT_EXP_DEST))
                {
                    Cache_SCHOOL_FDT_EXP_DEST = new List<FDT_EXP>().AsReadOnly();
                }

                return Cache_SCHOOL_FDT_EXP_DEST;
            }
        }

        /// <summary>
        /// FER_FDT (FDT Financal Holding Table) related entities by [SKGS.SCHOOL]-&gt;[FER_FDT.SOURCE]
        /// School ID
        /// </summary>
        public IReadOnlyList<FER_FDT> SCHOOL_FER_FDT_SOURCE
        {
            get
            {
                if (Cache_SCHOOL_FER_FDT_SOURCE == null &&
                    !Context.FER_FDT.TryFindBySOURCE(SCHOOL, out Cache_SCHOOL_FER_FDT_SOURCE))
                {
                    Cache_SCHOOL_FER_FDT_SOURCE = new List<FER_FDT>().AsReadOnly();
                }

                return Cache_SCHOOL_FER_FDT_SOURCE;
            }
        }

        /// <summary>
        /// KCD_TFR (KCD Transfer) related entities by [SKGS.SCHOOL]-&gt;[KCD_TFR.ORIG_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<KCD_TFR> SCHOOL_KCD_TFR_ORIG_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_KCD_TFR_ORIG_SCHOOL == null &&
                    !Context.KCD_TFR.TryFindByORIG_SCHOOL(SCHOOL, out Cache_SCHOOL_KCD_TFR_ORIG_SCHOOL))
                {
                    Cache_SCHOOL_KCD_TFR_ORIG_SCHOOL = new List<KCD_TFR>().AsReadOnly();
                }

                return Cache_SCHOOL_KCD_TFR_ORIG_SCHOOL;
            }
        }

        /// <summary>
        /// KCM_TFR (KCM Transfer) related entities by [SKGS.SCHOOL]-&gt;[KCM_TFR.ORIG_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<KCM_TFR> SCHOOL_KCM_TFR_ORIG_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_KCM_TFR_ORIG_SCHOOL == null &&
                    !Context.KCM_TFR.TryFindByORIG_SCHOOL(SCHOOL, out Cache_SCHOOL_KCM_TFR_ORIG_SCHOOL))
                {
                    Cache_SCHOOL_KCM_TFR_ORIG_SCHOOL = new List<KCM_TFR>().AsReadOnly();
                }

                return Cache_SCHOOL_KCM_TFR_ORIG_SCHOOL;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SKGS.SCHOOL]-&gt;[SCI.SCHOOL_LINK]
        /// School ID
        /// </summary>
        public SCI SCHOOL_SCI_SCHOOL_LINK
        {
            get
            {
                if (Cache_SCHOOL_SCI_SCHOOL_LINK == null &&
                    !Context.SCI.TryFindBySCHOOL_LINK(SCHOOL, out Cache_SCHOOL_SCI_SCHOOL_LINK))
                {
                    Cache_SCHOOL_SCI_SCHOOL_LINK = null;
                }

                return Cache_SCHOOL_SCI_SCHOOL_LINK;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SKGS.SCHOOL]-&gt;[SCI.DESTINATION_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<SCI> SCHOOL_SCI_DESTINATION_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_SCI_DESTINATION_SCHOOL == null &&
                    !Context.SCI.TryFindByDESTINATION_SCHOOL(SCHOOL, out Cache_SCHOOL_SCI_DESTINATION_SCHOOL))
                {
                    Cache_SCHOOL_SCI_DESTINATION_SCHOOL = new List<SCI>().AsReadOnly();
                }

                return Cache_SCHOOL_SCI_DESTINATION_SCHOOL;
            }
        }

        /// <summary>
        /// SMC_TFR (SMC Transfer) related entities by [SKGS.SCHOOL]-&gt;[SMC_TFR.ORIG_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<SMC_TFR> SCHOOL_SMC_TFR_ORIG_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_SMC_TFR_ORIG_SCHOOL == null &&
                    !Context.SMC_TFR.TryFindByORIG_SCHOOL(SCHOOL, out Cache_SCHOOL_SMC_TFR_ORIG_SCHOOL))
                {
                    Cache_SCHOOL_SMC_TFR_ORIG_SCHOOL = new List<SMC_TFR>().AsReadOnly();
                }

                return Cache_SCHOOL_SMC_TFR_ORIG_SCHOOL;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [SKGS.SCHOOL]-&gt;[ST.PREVIOUS_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<ST> SCHOOL_ST_PREVIOUS_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_ST_PREVIOUS_SCHOOL == null &&
                    !Context.ST.TryFindByPREVIOUS_SCHOOL(SCHOOL, out Cache_SCHOOL_ST_PREVIOUS_SCHOOL))
                {
                    Cache_SCHOOL_ST_PREVIOUS_SCHOOL = new List<ST>().AsReadOnly();
                }

                return Cache_SCHOOL_ST_PREVIOUS_SCHOOL;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [SKGS.SCHOOL]-&gt;[ST.NEXT_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<ST> SCHOOL_ST_NEXT_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_ST_NEXT_SCHOOL == null &&
                    !Context.ST.TryFindByNEXT_SCHOOL(SCHOOL, out Cache_SCHOOL_ST_NEXT_SCHOOL))
                {
                    Cache_SCHOOL_ST_NEXT_SCHOOL = new List<ST>().AsReadOnly();
                }

                return Cache_SCHOOL_ST_NEXT_SCHOOL;
            }
        }

        /// <summary>
        /// ST_TFR (ST Transfer) related entities by [SKGS.SCHOOL]-&gt;[ST_TFR.ORIG_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<ST_TFR> SCHOOL_ST_TFR_ORIG_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_ST_TFR_ORIG_SCHOOL == null &&
                    !Context.ST_TFR.TryFindByORIG_SCHOOL(SCHOOL, out Cache_SCHOOL_ST_TFR_ORIG_SCHOOL))
                {
                    Cache_SCHOOL_ST_TFR_ORIG_SCHOOL = new List<ST_TFR>().AsReadOnly();
                }

                return Cache_SCHOOL_ST_TFR_ORIG_SCHOOL;
            }
        }

        /// <summary>
        /// ST_TFRIO (Student Data Transfer Table) related entities by [SKGS.SCHOOL]-&gt;[ST_TFRIO.DEST_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<ST_TFRIO> SCHOOL_ST_TFRIO_DEST_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_ST_TFRIO_DEST_SCHOOL == null &&
                    !Context.ST_TFRIO.TryFindByDEST_SCHOOL(SCHOOL, out Cache_SCHOOL_ST_TFRIO_DEST_SCHOOL))
                {
                    Cache_SCHOOL_ST_TFRIO_DEST_SCHOOL = new List<ST_TFRIO>().AsReadOnly();
                }

                return Cache_SCHOOL_ST_TFRIO_DEST_SCHOOL;
            }
        }

        /// <summary>
        /// STPT (Student Part-Time Enrolments) related entities by [SKGS.SCHOOL]-&gt;[STPT.SCHL_NUM]
        /// School ID
        /// </summary>
        public IReadOnlyList<STPT> SCHOOL_STPT_SCHL_NUM
        {
            get
            {
                if (Cache_SCHOOL_STPT_SCHL_NUM == null &&
                    !Context.STPT.TryFindBySCHL_NUM(SCHOOL, out Cache_SCHOOL_STPT_SCHL_NUM))
                {
                    Cache_SCHOOL_STPT_SCHL_NUM = new List<STPT>().AsReadOnly();
                }

                return Cache_SCHOOL_STPT_SCHL_NUM;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SKGS.SCHOOL]-&gt;[STRE.ST_PREVIOUS_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<STRE> SCHOOL_STRE_ST_PREVIOUS_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_STRE_ST_PREVIOUS_SCHOOL == null &&
                    !Context.STRE.TryFindByST_PREVIOUS_SCHOOL(SCHOOL, out Cache_SCHOOL_STRE_ST_PREVIOUS_SCHOOL))
                {
                    Cache_SCHOOL_STRE_ST_PREVIOUS_SCHOOL = new List<STRE>().AsReadOnly();
                }

                return Cache_SCHOOL_STRE_ST_PREVIOUS_SCHOOL;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SKGS.SCHOOL]-&gt;[STRE.STPT_SCHL_NUM01]
        /// School ID
        /// </summary>
        public IReadOnlyList<STRE> SCHOOL_STRE_STPT_SCHL_NUM01
        {
            get
            {
                if (Cache_SCHOOL_STRE_STPT_SCHL_NUM01 == null &&
                    !Context.STRE.TryFindBySTPT_SCHL_NUM01(SCHOOL, out Cache_SCHOOL_STRE_STPT_SCHL_NUM01))
                {
                    Cache_SCHOOL_STRE_STPT_SCHL_NUM01 = new List<STRE>().AsReadOnly();
                }

                return Cache_SCHOOL_STRE_STPT_SCHL_NUM01;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SKGS.SCHOOL]-&gt;[STRE.STPT_SCHL_NUM02]
        /// School ID
        /// </summary>
        public IReadOnlyList<STRE> SCHOOL_STRE_STPT_SCHL_NUM02
        {
            get
            {
                if (Cache_SCHOOL_STRE_STPT_SCHL_NUM02 == null &&
                    !Context.STRE.TryFindBySTPT_SCHL_NUM02(SCHOOL, out Cache_SCHOOL_STRE_STPT_SCHL_NUM02))
                {
                    Cache_SCHOOL_STRE_STPT_SCHL_NUM02 = new List<STRE>().AsReadOnly();
                }

                return Cache_SCHOOL_STRE_STPT_SCHL_NUM02;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SKGS.SCHOOL]-&gt;[STRE.STPT_SCHL_NUM03]
        /// School ID
        /// </summary>
        public IReadOnlyList<STRE> SCHOOL_STRE_STPT_SCHL_NUM03
        {
            get
            {
                if (Cache_SCHOOL_STRE_STPT_SCHL_NUM03 == null &&
                    !Context.STRE.TryFindBySTPT_SCHL_NUM03(SCHOOL, out Cache_SCHOOL_STRE_STPT_SCHL_NUM03))
                {
                    Cache_SCHOOL_STRE_STPT_SCHL_NUM03 = new List<STRE>().AsReadOnly();
                }

                return Cache_SCHOOL_STRE_STPT_SCHL_NUM03;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SKGS.SCHOOL]-&gt;[STRE.STPT_SCHL_NUM04]
        /// School ID
        /// </summary>
        public IReadOnlyList<STRE> SCHOOL_STRE_STPT_SCHL_NUM04
        {
            get
            {
                if (Cache_SCHOOL_STRE_STPT_SCHL_NUM04 == null &&
                    !Context.STRE.TryFindBySTPT_SCHL_NUM04(SCHOOL, out Cache_SCHOOL_STRE_STPT_SCHL_NUM04))
                {
                    Cache_SCHOOL_STRE_STPT_SCHL_NUM04 = new List<STRE>().AsReadOnly();
                }

                return Cache_SCHOOL_STRE_STPT_SCHL_NUM04;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [SKGS.SCHOOL]-&gt;[STRE.ST_NEXT_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<STRE> SCHOOL_STRE_ST_NEXT_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_STRE_ST_NEXT_SCHOOL == null &&
                    !Context.STRE.TryFindByST_NEXT_SCHOOL(SCHOOL, out Cache_SCHOOL_STRE_ST_NEXT_SCHOOL))
                {
                    Cache_SCHOOL_STRE_ST_NEXT_SCHOOL = new List<STRE>().AsReadOnly();
                }

                return Cache_SCHOOL_STRE_ST_NEXT_SCHOOL;
            }
        }

        /// <summary>
        /// UM_TFR (UM Transfer) related entities by [SKGS.SCHOOL]-&gt;[UM_TFR.ORIG_SCHOOL]
        /// School ID
        /// </summary>
        public IReadOnlyList<UM_TFR> SCHOOL_UM_TFR_ORIG_SCHOOL
        {
            get
            {
                if (Cache_SCHOOL_UM_TFR_ORIG_SCHOOL == null &&
                    !Context.UM_TFR.TryFindByORIG_SCHOOL(SCHOOL, out Cache_SCHOOL_UM_TFR_ORIG_SCHOOL))
                {
                    Cache_SCHOOL_UM_TFR_ORIG_SCHOOL = new List<UM_TFR>().AsReadOnly();
                }

                return Cache_SCHOOL_UM_TFR_ORIG_SCHOOL;
            }
        }

        #endregion

    }
}
