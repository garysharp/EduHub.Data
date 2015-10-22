using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Schools
    /// </summary>
    public partial class SKGS : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// DF_TFR (DF Transfer) related entities by [DF_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<DF_TFR> DF_TFR_ORIG_SCHOOL
        {
            get
            {
                return Context.SKGS.FindDF_TFRByORIG_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// FDT_EXP (Financial Data Export) related entities by [FDT_EXP.DEST]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<FDT_EXP> FDT_EXP_DEST
        {
            get
            {
                return Context.SKGS.FindFDT_EXPByDEST(SCHOOL);
            }
        }

        /// <summary>
        /// FER_FDT (FDT Financal Holding Table) related entities by [FER_FDT.SOURCE]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<FER_FDT> FER_FDT_SOURCE
        {
            get
            {
                return Context.SKGS.FindFER_FDTBySOURCE(SCHOOL);
            }
        }

        /// <summary>
        /// KCD_TFR (KCD Transfer) related entities by [KCD_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<KCD_TFR> KCD_TFR_ORIG_SCHOOL
        {
            get
            {
                return Context.SKGS.FindKCD_TFRByORIG_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// KCM_TFR (KCM Transfer) related entities by [KCM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<KCM_TFR> KCM_TFR_ORIG_SCHOOL
        {
            get
            {
                return Context.SKGS.FindKCM_TFRByORIG_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCHOOL_LINK]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCHOOL_LINK
        {
            get
            {
                return Context.SKGS.FindSCIBySCHOOL_LINK(SCHOOL);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.DESTINATION_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<SCI> SCI_DESTINATION_SCHOOL
        {
            get
            {
                return Context.SKGS.FindSCIByDESTINATION_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// SMC_TFR (SMC Transfer) related entities by [SMC_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<SMC_TFR> SMC_TFR_ORIG_SCHOOL
        {
            get
            {
                return Context.SKGS.FindSMC_TFRByORIG_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<ST> ST_PREVIOUS_SCHOOL
        {
            get
            {
                return Context.SKGS.FindSTByPREVIOUS_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<ST> ST_NEXT_SCHOOL
        {
            get
            {
                return Context.SKGS.FindSTByNEXT_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// ST_TFR (ST Transfer) related entities by [ST_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<ST_TFR> ST_TFR_ORIG_SCHOOL
        {
            get
            {
                return Context.SKGS.FindST_TFRByORIG_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// ST_TFRIO (Student Data Transfer Table) related entities by [ST_TFRIO.DEST_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<ST_TFRIO> ST_TFRIO_DEST_SCHOOL
        {
            get
            {
                return Context.SKGS.FindST_TFRIOByDEST_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// STPT (Student Part-Time Enrolments) related entities by [STPT.SCHL_NUM]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STPT> STPT_SCHL_NUM
        {
            get
            {
                return Context.SKGS.FindSTPTBySCHL_NUM(SCHOOL);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_PREVIOUS_SCHOOL
        {
            get
            {
                return Context.SKGS.FindSTREByST_PREVIOUS_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.STPT_SCHL_NUM01]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STRE> STRE_STPT_SCHL_NUM01
        {
            get
            {
                return Context.SKGS.FindSTREBySTPT_SCHL_NUM01(SCHOOL);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.STPT_SCHL_NUM02]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STRE> STRE_STPT_SCHL_NUM02
        {
            get
            {
                return Context.SKGS.FindSTREBySTPT_SCHL_NUM02(SCHOOL);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.STPT_SCHL_NUM03]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STRE> STRE_STPT_SCHL_NUM03
        {
            get
            {
                return Context.SKGS.FindSTREBySTPT_SCHL_NUM03(SCHOOL);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.STPT_SCHL_NUM04]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STRE> STRE_STPT_SCHL_NUM04
        {
            get
            {
                return Context.SKGS.FindSTREBySTPT_SCHL_NUM04(SCHOOL);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_NEXT_SCHOOL
        {
            get
            {
                return Context.SKGS.FindSTREByST_NEXT_SCHOOL(SCHOOL);
            }
        }

        /// <summary>
        /// UM_TFR (UM Transfer) related entities by [UM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        public IReadOnlyList<UM_TFR> UM_TFR_ORIG_SCHOOL
        {
            get
            {
                return Context.SKGS.FindUM_TFRByORIG_SCHOOL(SCHOOL);
            }
        }
#endregion
    }
}
