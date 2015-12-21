using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employees
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PE : EduHubEntity
    {

        #region Navigation Property Cache

        private KGT Cache_COUNTRY_KGT;
        private UM Cache_HOMEKEY_UM;
        private UM Cache_MAILKEY_UM;
        private UM Cache_LEAVEKEY_UM;
        private PN Cache_PAYCODE_PN;
        private PX Cache_TAXCODE_PX;
        private PD Cache_DEPARTMENT_PD;
        private PLG Cache_LEAVE_GROUP_PLG;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<PEF> Cache_PEKEY_PEF_CODE;
        private IReadOnlyList<PEFH> Cache_PEKEY_PEFH_CODE;
        private IReadOnlyList<PELA> Cache_PEKEY_PELA_PEKEY;
        private IReadOnlyList<PELD> Cache_PEKEY_PELD_PEKEY;
        private IReadOnlyList<PEM> Cache_PEKEY_PEM_CODE;
        private IReadOnlyList<PEPM> Cache_PEKEY_PEPM_CODE;
        private IReadOnlyList<PEPS> Cache_PEKEY_PEPS_CODE;
        private IReadOnlyList<PEPU> Cache_PEKEY_PEPU_CODE;
        private IReadOnlyList<PEPUH> Cache_PEKEY_PEPUH_CODE;
        private IReadOnlyList<PEPY> Cache_PEKEY_PEPY_CODE;
        private IReadOnlyList<PESH> Cache_PEKEY_PESH_CODE;
        private IReadOnlyList<PESP> Cache_PEKEY_PESP_CODE;
        private IReadOnlyList<PETP> Cache_PEKEY_PETP_CODE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Employee key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEKEY { get; internal set; }

        /// <summary>
        /// Employee title
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Employee surname
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// First name
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Second name
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }

        /// <summary>
        /// Known as or prefered name
        /// [Alphanumeric (15)]
        /// </summary>
        public string PREF_NAME { get; internal set; }

        /// <summary>
        /// Previous surname
        /// [Alphanumeric (30)]
        /// </summary>
        public string PREVIOUS_NAME { get; internal set; }

        /// <summary>
        /// Birth date
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }

        /// <summary>
        /// Gender (M or F)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }

        /// <summary>
        /// Home address
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string HOMEADD01 { get; internal set; }

        /// <summary>
        /// Home address
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string HOMEADD02 { get; internal set; }

        /// <summary>
        /// Home suburb
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string HOMESUBURB { get; internal set; }

        /// <summary>
        /// Home state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string HOMESTATE { get; internal set; }

        /// <summary>
        /// Home post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string HOMEPOST { get; internal set; }

        /// <summary>
        /// Overseas Country
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }

        /// <summary>
        /// Home telephone number
        /// [Alphanumeric (15)]
        /// </summary>
        public string HOMEPHONE { get; internal set; }

        /// <summary>
        /// Business phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string BUS_PHONE { get; internal set; }

        /// <summary>
        /// Phone extention
        /// [Alphanumeric (5)]
        /// </summary>
        public string PHONE_EXT { get; internal set; }

        /// <summary>
        /// Fax number
        /// [Alphanumeric (15)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Mobile
        /// [Alphanumeric (15)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// E-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string EMAIL { get; internal set; }

        /// <summary>
        /// Driver's licence number
        /// [Alphanumeric (15)]
        /// </summary>
        public string DRIVERS_LIC_NO { get; internal set; }

        /// <summary>
        /// Has own transport Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OWN_VEHICLE { get; internal set; }

        /// <summary>
        /// Comments memo field
        /// [Memo]
        /// </summary>
        public string COMMENTS { get; internal set; }

        /// <summary>
        /// Home    address
        /// </summary>
        public int? HOMEKEY { get; internal set; }

        /// <summary>
        /// Mailing address
        /// </summary>
        public int? MAILKEY { get; internal set; }

        /// <summary>
        /// Holiday address
        /// </summary>
        public int? LEAVEKEY { get; internal set; }

        /// <summary>
        /// Payroll group
        /// </summary>
        public short? PAYCODE { get; internal set; }

        /// <summary>
        /// Tax code
        /// </summary>
        public short? TAXCODE { get; internal set; }

        /// <summary>
        /// Department
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEPARTMENT { get; internal set; }

        /// <summary>
        /// Payroll number
        /// </summary>
        public int? PENUMBER { get; internal set; }

        /// <summary>
        /// Tax file number
        /// </summary>
        public int? TAXFILENUM { get; internal set; }

        /// <summary>
        /// Employment type
        /// F.ulltime, P.arttime, C.asual
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMPLOY_TYPE { get; internal set; }

        /// <summary>
        /// Normal number of hours worked
        /// by employee per pay cycle
        /// </summary>
        public double? NORMAL_HOURS { get; internal set; }

        /// <summary>
        /// Full time equivalent
        /// </summary>
        public double? FTE_VALUE { get; internal set; }

        /// <summary>
        /// Annual Salary
        /// </summary>
        public decimal? ANNUAL_SALARY { get; internal set; }

        /// <summary>
        /// Standard hours for this position per pay cycle
        /// </summary>
        public double? STD_HOURS { get; internal set; }

        /// <summary>
        /// Union name
        /// [Alphanumeric (20)]
        /// </summary>
        public string UNION_NAME { get; internal set; }

        /// <summary>
        /// Leave Management Group
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }

        /// <summary>
        /// PAY_TYPE
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PAY_TYPE { get; internal set; }

        /// <summary>
        /// Hourly Pay Rate
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string HOURLY_RATE { get; internal set; }

        /// <summary>
        /// oldname=SUPER_FUND; * Version Six Super fund name
        /// [Alphanumeric (20)]
        /// </summary>
        public string SIX_SUPER_FUND { get; internal set; }

        /// <summary>
        /// oldname=MEMBER_NO;  * Version Six Super member no.
        /// [Alphanumeric (10)]
        /// </summary>
        public string SIX_MEMBER_NO { get; internal set; }

        /// <summary>
        /// Superannuation levy (%)
        /// </summary>
        public double? SUPER_LEVY { get; internal set; }

        /// <summary>
        /// Zone (A,B,C = Zone A special
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ZONE { get; internal set; }

        /// <summary>
        /// oldname=ZONE; * Zone (A,B,C = Zone A special
        ///           D = Zone B special)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ZONE_CODE { get; internal set; }

        /// <summary>
        /// Zone allowance claimed
        /// </summary>
        public decimal? ZONE_ALLOW { get; internal set; }

        /// <summary>
        /// Number of dependents
        /// </summary>
        public short? NO_DEPEND { get; internal set; }

        /// <summary>
        /// Taxable Allowances per week
        /// </summary>
        public decimal? ALLOWANCES { get; internal set; }

        /// <summary>
        /// Annual dependent rebate
        /// </summary>
        public decimal? DEP_REBATE { get; internal set; }

        /// <summary>
        /// Temporary value
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICARE { get; internal set; }

        /// <summary>
        /// Temporary value
        /// Medicare Levy Variation Declaration
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICARE_Q9NOTQ12z { get; internal set; }

        /// <summary>
        /// Answer to Q9
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICARE_Q09A { get; internal set; }

        /// <summary>
        /// Answer to Q10
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICARE_Q10A { get; internal set; }

        /// <summary>
        /// Answer to Q11
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICARE_Q11A { get; internal set; }

        /// <summary>
        /// Answer to Q12
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICARE_Q12A { get; internal set; }

        /// <summary>
        /// Start date
        /// </summary>
        public DateTime? STARTDATE { get; internal set; }

        /// <summary>
        /// Termination date
        /// </summary>
        public DateTime? TERMDATE { get; internal set; }

        /// <summary>
        /// Previous salary review date
        /// </summary>
        public DateTime? SALREVDATE { get; internal set; }

        /// <summary>
        /// Leave Calc Suspended To date
        /// </summary>
        public DateTime? SUSPEND_DATE { get; internal set; }

        /// <summary>
        /// Last pay period updated
        /// </summary>
        public int? LASTPAYPERD { get; internal set; }

        /// <summary>
        /// Next pay period
        /// </summary>
        public int? NEXTPAYPERD { get; internal set; }

        /// <summary>
        /// Last pay date updated
        /// </summary>
        public DateTime? LASTPAYDATE { get; internal set; }

        /// <summary>
        /// Pay rate last period
        /// </summary>
        public double? LASTPAYRATE { get; internal set; }

        /// <summary>
        /// Last normal pay item
        /// </summary>
        public short? LASTNORMITEM { get; internal set; }

        /// <summary>
        /// Gross pay last period
        /// </summary>
        public decimal? LASTPAYGROSS { get; internal set; }

        /// <summary>
        /// Nett pay last period
        /// </summary>
        public decimal? LASTPAYNETT { get; internal set; }

        /// <summary>
        /// Tax last period
        /// </summary>
        public decimal? LASTPAYTAX { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS01 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS02 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS03 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS04 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS05 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS06 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS07 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS08 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS09 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS10 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS11 { get; internal set; }

        /// <summary>
        /// This year monthly gross
        /// </summary>
        public decimal? GROSS12 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT01 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT02 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT03 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT04 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT05 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT06 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT07 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT08 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT09 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT10 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT11 { get; internal set; }

        /// <summary>
        /// This year monthly nett
        /// </summary>
        public decimal? NETT12 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX01 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX02 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX03 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX04 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX05 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX06 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX07 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX08 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX09 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX10 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX11 { get; internal set; }

        /// <summary>
        /// This year monthly tax
        /// </summary>
        public decimal? TAX12 { get; internal set; }

        /// <summary>
        /// PAYG Summary printed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PAYG_SUMMARY { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? YEAR_LEVEL { get; internal set; }

        /// <summary>
        /// Reportable Fringe Benefits
        /// </summary>
        public decimal? REPORTABLE_FB { get; internal set; }

        /// <summary>
        /// Employee picture
        /// </summary>
        public byte[] EMPLOYEE_PIC { get; internal set; }

        /// <summary>
        /// VIT Registration Number
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string VIT_REGISTRATION { get; internal set; }

        /// <summary>
        /// VIT expiry date
        /// </summary>
        public DateTime? VIT_EXPIRY { get; internal set; }

        /// <summary>
        /// Working With Children Check card number
        /// [Uppercase Alphanumeric (11)]
        /// </summary>
        public string WWCC_NUMBER { get; internal set; }

        /// <summary>
        /// WWCC expiry date
        /// </summary>
        public DateTime? WWCC_EXPIRY { get; internal set; }

        /// <summary>
        /// WWCC card Type E=Employee, V=Volunteer
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WWCC_TYPE { get; internal set; }

        /// <summary>
        /// Y if the SGL threshold is ignored for this employee
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ESUPER_IGNORE_THRESHOLD { get; internal set; }

        /// <summary>
        /// Superannuation fund name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ESUPER_FUND01 { get; internal set; }

        /// <summary>
        /// Superannuation fund name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ESUPER_FUND02 { get; internal set; }

        /// <summary>
        /// Superannuation fund name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ESUPER_FUND03 { get; internal set; }

        /// <summary>
        /// Superannuation fund name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ESUPER_FUND04 { get; internal set; }

        /// <summary>
        /// Superannuation fund name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ESUPER_FUND05 { get; internal set; }

        /// <summary>
        /// Superannuation fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ESUPER_MEMBER01 { get; internal set; }

        /// <summary>
        /// Superannuation fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ESUPER_MEMBER02 { get; internal set; }

        /// <summary>
        /// Superannuation fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ESUPER_MEMBER03 { get; internal set; }

        /// <summary>
        /// Superannuation fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ESUPER_MEMBER04 { get; internal set; }

        /// <summary>
        /// Superannuation fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ESUPER_MEMBER05 { get; internal set; }

        /// <summary>
        /// Superannuation percentage
        /// </summary>
        public double? ESUPER_PERCENT01 { get; internal set; }

        /// <summary>
        /// Superannuation percentage
        /// </summary>
        public double? ESUPER_PERCENT02 { get; internal set; }

        /// <summary>
        /// Superannuation percentage
        /// </summary>
        public double? ESUPER_PERCENT03 { get; internal set; }

        /// <summary>
        /// Superannuation percentage
        /// </summary>
        public double? ESUPER_PERCENT04 { get; internal set; }

        /// <summary>
        /// Superannuation percentage
        /// </summary>
        public double? ESUPER_PERCENT05 { get; internal set; }

        /// <summary>
        /// Employee purchased leave agreement in hours
        /// </summary>
        public double? LEAVE_HOURS { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// KGT (Countries) related entity by [PE.COUNTRY]-&gt;[KGT.COUNTRY]
        /// Overseas Country
        /// </summary>
        public KGT COUNTRY_KGT
        {
            get
            {
                if (COUNTRY == null)
                {
                    return null;
                }
                if (Cache_COUNTRY_KGT == null)
                {
                    Cache_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(COUNTRY);
                }

                return Cache_COUNTRY_KGT;
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [PE.HOMEKEY]-&gt;[UM.UMKEY]
        /// Home    address
        /// </summary>
        public UM HOMEKEY_UM
        {
            get
            {
                if (HOMEKEY == null)
                {
                    return null;
                }
                if (Cache_HOMEKEY_UM == null)
                {
                    Cache_HOMEKEY_UM = Context.UM.FindByUMKEY(HOMEKEY.Value);
                }

                return Cache_HOMEKEY_UM;
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [PE.MAILKEY]-&gt;[UM.UMKEY]
        /// Mailing address
        /// </summary>
        public UM MAILKEY_UM
        {
            get
            {
                if (MAILKEY == null)
                {
                    return null;
                }
                if (Cache_MAILKEY_UM == null)
                {
                    Cache_MAILKEY_UM = Context.UM.FindByUMKEY(MAILKEY.Value);
                }

                return Cache_MAILKEY_UM;
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [PE.LEAVEKEY]-&gt;[UM.UMKEY]
        /// Holiday address
        /// </summary>
        public UM LEAVEKEY_UM
        {
            get
            {
                if (LEAVEKEY == null)
                {
                    return null;
                }
                if (Cache_LEAVEKEY_UM == null)
                {
                    Cache_LEAVEKEY_UM = Context.UM.FindByUMKEY(LEAVEKEY.Value);
                }

                return Cache_LEAVEKEY_UM;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entity by [PE.PAYCODE]-&gt;[PN.PNKEY]
        /// Payroll group
        /// </summary>
        public PN PAYCODE_PN
        {
            get
            {
                if (PAYCODE == null)
                {
                    return null;
                }
                if (Cache_PAYCODE_PN == null)
                {
                    Cache_PAYCODE_PN = Context.PN.FindByPNKEY(PAYCODE.Value);
                }

                return Cache_PAYCODE_PN;
            }
        }

        /// <summary>
        /// PX (Tax Scales) related entity by [PE.TAXCODE]-&gt;[PX.PXKEY]
        /// Tax code
        /// </summary>
        public PX TAXCODE_PX
        {
            get
            {
                if (TAXCODE == null)
                {
                    return null;
                }
                if (Cache_TAXCODE_PX == null)
                {
                    Cache_TAXCODE_PX = Context.PX.FindByPXKEY(TAXCODE.Value);
                }

                return Cache_TAXCODE_PX;
            }
        }

        /// <summary>
        /// PD (Departments) related entity by [PE.DEPARTMENT]-&gt;[PD.PDKEY]
        /// Department
        /// </summary>
        public PD DEPARTMENT_PD
        {
            get
            {
                if (DEPARTMENT == null)
                {
                    return null;
                }
                if (Cache_DEPARTMENT_PD == null)
                {
                    Cache_DEPARTMENT_PD = Context.PD.FindByPDKEY(DEPARTMENT);
                }

                return Cache_DEPARTMENT_PD;
            }
        }

        /// <summary>
        /// PLG (Leave Management Group) related entity by [PE.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// Leave Management Group
        /// </summary>
        public PLG LEAVE_GROUP_PLG
        {
            get
            {
                if (LEAVE_GROUP == null)
                {
                    return null;
                }
                if (Cache_LEAVE_GROUP_PLG == null)
                {
                    Cache_LEAVE_GROUP_PLG = Context.PLG.FindByLEAVE_GROUP(LEAVE_GROUP);
                }

                return Cache_LEAVE_GROUP_PLG;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PE.PEKEY]-&gt;[PEF.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEF> PEKEY_PEF_CODE
        {
            get
            {
                if (Cache_PEKEY_PEF_CODE == null &&
                    !Context.PEF.TryFindByCODE(PEKEY, out Cache_PEKEY_PEF_CODE))
                {
                    Cache_PEKEY_PEF_CODE = new List<PEF>().AsReadOnly();
                }

                return Cache_PEKEY_PEF_CODE;
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PE.PEKEY]-&gt;[PEFH.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEFH> PEKEY_PEFH_CODE
        {
            get
            {
                if (Cache_PEKEY_PEFH_CODE == null &&
                    !Context.PEFH.TryFindByCODE(PEKEY, out Cache_PEKEY_PEFH_CODE))
                {
                    Cache_PEKEY_PEFH_CODE = new List<PEFH>().AsReadOnly();
                }

                return Cache_PEKEY_PEFH_CODE;
            }
        }

        /// <summary>
        /// PELA (Employee Leave Audit) related entities by [PE.PEKEY]-&gt;[PELA.PEKEY]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PELA> PEKEY_PELA_PEKEY
        {
            get
            {
                if (Cache_PEKEY_PELA_PEKEY == null &&
                    !Context.PELA.TryFindByPEKEY(PEKEY, out Cache_PEKEY_PELA_PEKEY))
                {
                    Cache_PEKEY_PELA_PEKEY = new List<PELA>().AsReadOnly();
                }

                return Cache_PEKEY_PELA_PEKEY;
            }
        }

        /// <summary>
        /// PELD (Employee Leave Details) related entities by [PE.PEKEY]-&gt;[PELD.PEKEY]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PELD> PEKEY_PELD_PEKEY
        {
            get
            {
                if (Cache_PEKEY_PELD_PEKEY == null &&
                    !Context.PELD.TryFindByPEKEY(PEKEY, out Cache_PEKEY_PELD_PEKEY))
                {
                    Cache_PEKEY_PELD_PEKEY = new List<PELD>().AsReadOnly();
                }

                return Cache_PEKEY_PELD_PEKEY;
            }
        }

        /// <summary>
        /// PEM (Pay Advice Slip Message) related entities by [PE.PEKEY]-&gt;[PEM.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEM> PEKEY_PEM_CODE
        {
            get
            {
                if (Cache_PEKEY_PEM_CODE == null &&
                    !Context.PEM.TryFindByCODE(PEKEY, out Cache_PEKEY_PEM_CODE))
                {
                    Cache_PEKEY_PEM_CODE = new List<PEM>().AsReadOnly();
                }

                return Cache_PEKEY_PEM_CODE;
            }
        }

        /// <summary>
        /// PEPM (Pay Methods) related entities by [PE.PEKEY]-&gt;[PEPM.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEPM> PEKEY_PEPM_CODE
        {
            get
            {
                if (Cache_PEKEY_PEPM_CODE == null &&
                    !Context.PEPM.TryFindByCODE(PEKEY, out Cache_PEKEY_PEPM_CODE))
                {
                    Cache_PEKEY_PEPM_CODE = new List<PEPM>().AsReadOnly();
                }

                return Cache_PEKEY_PEPM_CODE;
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PE.PEKEY]-&gt;[PEPS.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEPS> PEKEY_PEPS_CODE
        {
            get
            {
                if (Cache_PEKEY_PEPS_CODE == null &&
                    !Context.PEPS.TryFindByCODE(PEKEY, out Cache_PEKEY_PEPS_CODE))
                {
                    Cache_PEKEY_PEPS_CODE = new List<PEPS>().AsReadOnly();
                }

                return Cache_PEKEY_PEPS_CODE;
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PE.PEKEY]-&gt;[PEPU.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEPU> PEKEY_PEPU_CODE
        {
            get
            {
                if (Cache_PEKEY_PEPU_CODE == null &&
                    !Context.PEPU.TryFindByCODE(PEKEY, out Cache_PEKEY_PEPU_CODE))
                {
                    Cache_PEKEY_PEPU_CODE = new List<PEPU>().AsReadOnly();
                }

                return Cache_PEKEY_PEPU_CODE;
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PE.PEKEY]-&gt;[PEPUH.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEPUH> PEKEY_PEPUH_CODE
        {
            get
            {
                if (Cache_PEKEY_PEPUH_CODE == null &&
                    !Context.PEPUH.TryFindByCODE(PEKEY, out Cache_PEKEY_PEPUH_CODE))
                {
                    Cache_PEKEY_PEPUH_CODE = new List<PEPUH>().AsReadOnly();
                }

                return Cache_PEKEY_PEPUH_CODE;
            }
        }

        /// <summary>
        /// PEPY (Employee History) related entities by [PE.PEKEY]-&gt;[PEPY.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PEPY> PEKEY_PEPY_CODE
        {
            get
            {
                if (Cache_PEKEY_PEPY_CODE == null &&
                    !Context.PEPY.TryFindByCODE(PEKEY, out Cache_PEKEY_PEPY_CODE))
                {
                    Cache_PEKEY_PEPY_CODE = new List<PEPY>().AsReadOnly();
                }

                return Cache_PEKEY_PEPY_CODE;
            }
        }

        /// <summary>
        /// PESH (Employee Super LTD History) related entities by [PE.PEKEY]-&gt;[PESH.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PESH> PEKEY_PESH_CODE
        {
            get
            {
                if (Cache_PEKEY_PESH_CODE == null &&
                    !Context.PESH.TryFindByCODE(PEKEY, out Cache_PEKEY_PESH_CODE))
                {
                    Cache_PEKEY_PESH_CODE = new List<PESH>().AsReadOnly();
                }

                return Cache_PEKEY_PESH_CODE;
            }
        }

        /// <summary>
        /// PESP (Employee Super Payment Transactions) related entities by [PE.PEKEY]-&gt;[PESP.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PESP> PEKEY_PESP_CODE
        {
            get
            {
                if (Cache_PEKEY_PESP_CODE == null &&
                    !Context.PESP.TryFindByCODE(PEKEY, out Cache_PEKEY_PESP_CODE))
                {
                    Cache_PEKEY_PESP_CODE = new List<PESP>().AsReadOnly();
                }

                return Cache_PEKEY_PESP_CODE;
            }
        }

        /// <summary>
        /// PETP (Termination Payment) related entities by [PE.PEKEY]-&gt;[PETP.CODE]
        /// Employee key
        /// </summary>
        public IReadOnlyList<PETP> PEKEY_PETP_CODE
        {
            get
            {
                if (Cache_PEKEY_PETP_CODE == null &&
                    !Context.PETP.TryFindByCODE(PEKEY, out Cache_PEKEY_PETP_CODE))
                {
                    Cache_PEKEY_PETP_CODE = new List<PETP>().AsReadOnly();
                }

                return Cache_PEKEY_PETP_CODE;
            }
        }

        #endregion

    }
}
