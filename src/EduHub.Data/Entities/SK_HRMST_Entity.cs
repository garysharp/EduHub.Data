using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// HRMS Temp Import Table
    /// </summary>
    public class SK_HRMST_Entity : EntityBase
    {
        /// <summary>
        /// Seq [Integer (32bit signed): l]
        /// </summary>
        public int SEQ { get; internal set; }
        /// <summary>
        /// School Identifier, DEPTID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DEPTID { get; internal set; }
        /// <summary>
        /// Central Payroll Record No [Uppercase Alphanumeric: u11]
        /// </summary>
        public string EMPLID { get; internal set; }
        /// <summary>
        /// Central Payroll Classification [Uppercase Alphanumeric: u6]
        /// </summary>
        public string JOBCODE { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string LAST_NAME { get; internal set; }
        /// <summary>
        /// Title [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PREFIX { get; internal set; }
        /// <summary>
        /// Given name [Uppercase Alphanumeric: u30]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Other names [Uppercase Alphanumeric: u30]
        /// </summary>
        public string MIDDLE_NAME { get; internal set; }
        /// <summary>
        /// Preferred name [Uppercase Alphanumeric: u30]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Previous Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string PREV_SURNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTH_DATE { get; internal set; }
        /// <summary>
        /// Home address line 1 [Alphanumeric: a55]
        /// </summary>
        public string H_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Home address line 1 [Alphanumeric: a55]
        /// </summary>
        public string H_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Home address line 1 [Alphanumeric: a55]
        /// </summary>
        public string H_ADDRESS03 { get; internal set; }
        /// <summary>
        /// Home state [Uppercase Alphanumeric: u6]
        /// </summary>
        public string H_STATE { get; internal set; }
        /// <summary>
        /// Home postcode [Uppercase Alphanumeric: u12]
        /// </summary>
        public string H_POST_CODE { get; internal set; }
        /// <summary>
        /// Post address [Alphanumeric: a55]
        /// </summary>
        public string P_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Post address [Alphanumeric: a55]
        /// </summary>
        public string P_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Post address [Alphanumeric: a55]
        /// </summary>
        public string P_ADDRESS03 { get; internal set; }
        /// <summary>
        /// Post state [Uppercase Alphanumeric: u6]
        /// </summary>
        public string P_STATE { get; internal set; }
        /// <summary>
        /// Post postcode [Uppercase Alphanumeric: u12]
        /// </summary>
        public string P_POST_CODE { get; internal set; }
        /// <summary>
        /// Home telephone no [Uppercase Alphanumeric: u24]
        /// </summary>
        public string HOME_PHONE { get; internal set; }
        /// <summary>
        /// Mobile phone no [Uppercase Alphanumeric: u31]
        /// </summary>
        public string MOBILE_PHONE { get; internal set; }
        /// <summary>
        /// Work Phone no [Uppercase Alphanumeric: u24]
        /// </summary>
        public string WORK_PHONE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u70]
        /// </summary>
        public string EMAIL_ADDRESS { get; internal set; }
        /// <summary>
        /// Emergency Contact Name [Uppercase Alphanumeric: u50]
        /// </summary>
        public string EMERG_CONTACT { get; internal set; }
        /// <summary>
        /// Emergency Contact Relationship [Uppercase Alphanumeric: u30]
        /// </summary>
        public string EMERG_RELATE { get; internal set; }
        /// <summary>
        /// Emergecny Contact Phone [Uppercase Alphanumeric: u24]
        /// </summary>
        public string EMERG_PHONE { get; internal set; }
        /// <summary>
        /// Start Date [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Finish Date [Date Time nullable: d]
        /// </summary>
        public DateTime? FINISH_DATE { get; internal set; }
        
        
    }
}
