using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employees
    /// </summary>
    public class PE : EntityBase
    {
#region Navigation Property Cache
        private KGT _COUNTRY_KGT;
        private UM _HOMEKEY_UM;
        private UM _MAILKEY_UM;
        private UM _LEAVEKEY_UM;
        private PN _PAYCODE_PN;
        private PX _TAXCODE_PX;
        private PD _DEPARTMENT_PD;
        private PLG _LEAVE_GROUP_PLG;
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
        /// 
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
        /// D = Zone B special)
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public DateTime? SUSPEND_DATE { get; internal set; }
        /// <summary>
        /// Last pay period updated
        /// </summary>
        public int? LASTPAYPERD { get; internal set; }
        /// <summary>
        /// Next pay period
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// 
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
        /// Navigation property for [COUNTRY] => [KGT].[COUNTRY]
        /// Overseas Country
        /// </summary>
        public KGT COUNTRY_KGT {
            get
            {
                if (COUNTRY != null)
                {
                    if (_COUNTRY_KGT == null)
                    {
                        _COUNTRY_KGT = Context.KGT.FindByCOUNTRY(COUNTRY);
                    }
                    return _COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOMEKEY] => [UM].[UMKEY]
        /// Home    address
        /// </summary>
        public UM HOMEKEY_UM {
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
        /// Navigation property for [MAILKEY] => [UM].[UMKEY]
        /// Mailing address
        /// </summary>
        public UM MAILKEY_UM {
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
        /// Navigation property for [LEAVEKEY] => [UM].[UMKEY]
        /// Holiday address
        /// </summary>
        public UM LEAVEKEY_UM {
            get
            {
                if (LEAVEKEY.HasValue)
                {
                    if (_LEAVEKEY_UM == null)
                    {
                        _LEAVEKEY_UM = Context.UM.FindByUMKEY(LEAVEKEY.Value);
                    }
                    return _LEAVEKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PAYCODE] => [PN].[PNKEY]
        /// Payroll group
        /// </summary>
        public PN PAYCODE_PN {
            get
            {
                if (PAYCODE.HasValue)
                {
                    if (_PAYCODE_PN == null)
                    {
                        _PAYCODE_PN = Context.PN.FindByPNKEY(PAYCODE.Value);
                    }
                    return _PAYCODE_PN;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TAXCODE] => [PX].[PXKEY]
        /// Tax code
        /// </summary>
        public PX TAXCODE_PX {
            get
            {
                if (TAXCODE.HasValue)
                {
                    if (_TAXCODE_PX == null)
                    {
                        _TAXCODE_PX = Context.PX.FindByPXKEY(TAXCODE.Value);
                    }
                    return _TAXCODE_PX;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DEPARTMENT] => [PD].[PDKEY]
        /// Department
        /// </summary>
        public PD DEPARTMENT_PD {
            get
            {
                if (DEPARTMENT != null)
                {
                    if (_DEPARTMENT_PD == null)
                    {
                        _DEPARTMENT_PD = Context.PD.FindByPDKEY(DEPARTMENT);
                    }
                    return _DEPARTMENT_PD;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LEAVE_GROUP] => [PLG].[LEAVE_GROUP]
        /// Leave Management Group
        /// </summary>
        public PLG LEAVE_GROUP_PLG {
            get
            {
                if (LEAVE_GROUP != null)
                {
                    if (_LEAVE_GROUP_PLG == null)
                    {
                        _LEAVE_GROUP_PLG = Context.PLG.FindByLEAVE_GROUP(LEAVE_GROUP);
                    }
                    return _LEAVE_GROUP_PLG;
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
