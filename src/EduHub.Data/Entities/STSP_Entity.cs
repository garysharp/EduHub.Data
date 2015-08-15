using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Suspension Details
    /// </summary>
    public class STSP_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _SPKEY_ST;
        private SF_Entity _REF_TEACHERA_SF;
        private SF_Entity _REF_TEACHERB_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SPKEY { get; internal set; }
        /// <summary>
        /// Date record of suspension was created [Date Time nullable: d]
        /// </summary>
        public DateTime? ENTRY_DATE { get; internal set; }
        /// <summary>
        /// Suspension no - entered at school [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUSP_NUMBER { get; internal set; }
        /// <summary>
        /// Staff code of first or only teacher involved [Uppercase Alphanumeric: u4]
        /// </summary>
        public string REF_TEACHERA { get; internal set; }
        /// <summary>
        /// Staff code of second teacher involved (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string REF_TEACHERB { get; internal set; }
        /// <summary>
        /// Number of days this suspension [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? NO_DAYS { get; internal set; }
        /// <summary>
        /// First date of suspension [Date Time nullable: d]
        /// </summary>
        public DateTime? FROM_DATE { get; internal set; }
        /// <summary>
        /// Last date of suspension [Date Time nullable: d]
        /// </summary>
        public DateTime? TO_DATE { get; internal set; }
        /// <summary>
        /// Date of return to school [Date Time nullable: d]
        /// </summary>
        public DateTime? RETURN_DATE { get; internal set; }
        /// <summary>
        /// Non-compliance, etc [Uppercase Alphanumeric: u1]
        /// </summary>
        public string NON_COMP { get; internal set; }
        /// <summary>
        /// School avoidance [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SCH_AVOID { get; internal set; }
        /// <summary>
        /// Verbal abuse? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string VERBAL { get; internal set; }
        /// <summary>
        /// Physical abuse? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PHYSICAL { get; internal set; }
        /// <summary>
        /// Misuse of property? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MISUSE { get; internal set; }
        /// <summary>
        /// Sexual harassment [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SEXUAL { get; internal set; }
        /// <summary>
        /// Intimidatory/threatening behaviour [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTIM { get; internal set; }
        /// <summary>
        /// Vandalism [Uppercase Alphanumeric: u1]
        /// </summary>
        public string VANDAL { get; internal set; }
        /// <summary>
        /// Stealing [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STEALING { get; internal set; }
        /// <summary>
        /// Smoking [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SMOKING { get; internal set; }
        /// <summary>
        /// Drugs [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DRUGS { get; internal set; }
        /// <summary>
        /// Fair hearing [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FAIR { get; internal set; }
        /// <summary>
        /// Consultation & discussion [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONSULT { get; internal set; }
        /// <summary>
        /// School procedures [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PROCED { get; internal set; }
        /// <summary>
        /// School counsellor [Uppercase Alphanumeric: u1]
        /// </summary>
        public string COUNSEL { get; internal set; }
        /// <summary>
        /// Alternative curriculum [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CURRIC { get; internal set; }
        /// <summary>
        /// Parent/guardian [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PARENT { get; internal set; }
        /// <summary>
        /// Schools director [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DIRECT { get; internal set; }
        /// <summary>
        /// Right of appeal [Uppercase Alphanumeric: u1]
        /// </summary>
        public string APPEAL { get; internal set; }
        /// <summary>
        /// Other agencies [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OTHER_AGENCIES { get; internal set; }
        /// <summary>
        /// Police involvement [Uppercase Alphanumeric: u1]
        /// </summary>
        public string POLICE { get; internal set; }
        /// <summary>
        /// Other reasons [Memo: m]
        /// </summary>
        public string OTHER_REAS { get; internal set; }
        /// <summary>
        /// Other recommendations [Memo: m]
        /// </summary>
        public string DETAIL { get; internal set; }
        /// <summary>
        /// Other actions [Memo: m]
        /// </summary>
        public string OTHER { get; internal set; }
        /// <summary>
        /// Inlist of principal's decisions [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINC_DECISION { get; internal set; }
        /// <summary>
        /// Inlist of principal's recommendations [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINC_RECOM { get; internal set; }
        /// <summary>
        /// Recommendation made to director [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECOM_DIRECT { get; internal set; }
        /// <summary>
        /// School comment [Memo: m]
        /// </summary>
        public string SCHOOL_COMM { get; internal set; }
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
        /// Navigation property for [SPKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity SPKEY_ST {
            get
            {
                if (SPKEY != null)
                {
                    if (_SPKEY_ST == null)
                    {
                        _SPKEY_ST = Context.ST.FindBySTKEY(SPKEY);
                    }
                    return _SPKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [REF_TEACHERA] => [SF_Entity].[SFKEY]
        /// Staff code of first or only teacher involved
        /// </summary>
        public SF_Entity REF_TEACHERA_SF {
            get
            {
                if (REF_TEACHERA != null)
                {
                    if (_REF_TEACHERA_SF == null)
                    {
                        _REF_TEACHERA_SF = Context.SF.FindBySFKEY(REF_TEACHERA);
                    }
                    return _REF_TEACHERA_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [REF_TEACHERB] => [SF_Entity].[SFKEY]
        /// Staff code of second teacher involved (if any)
        /// </summary>
        public SF_Entity REF_TEACHERB_SF {
            get
            {
                if (REF_TEACHERB != null)
                {
                    if (_REF_TEACHERB_SF == null)
                    {
                        _REF_TEACHERB_SF = Context.SF.FindBySFKEY(REF_TEACHERB);
                    }
                    return _REF_TEACHERB_SF;
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
