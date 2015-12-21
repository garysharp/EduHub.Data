using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// HRMS Import Table
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SK_HRMS : EduHubEntity
    {

        #region Field Properties

        /// <summary>
        /// Seq
        /// </summary>
        public int SEQ { get; internal set; }

        /// <summary>
        /// School Identifier, DEPTID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEPTID { get; internal set; }

        /// <summary>
        /// Central Payroll Record No
        /// [Uppercase Alphanumeric (11)]
        /// </summary>
        public string EMPLID { get; internal set; }

        /// <summary>
        /// Central Payroll Classification
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string JOBCODE { get; internal set; }

        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string LAST_NAME { get; internal set; }

        /// <summary>
        /// Title
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PREFIX { get; internal set; }

        /// <summary>
        /// Given name
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Other names
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string MIDDLE_NAME { get; internal set; }

        /// <summary>
        /// Preferred name
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string PREF_NAME { get; internal set; }

        /// <summary>
        /// Previous Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string PREV_SURNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? BIRTH_DATE { get; internal set; }

        /// <summary>
        /// Home address line 1
        /// [Alphanumeric (55)]
        /// </summary>
        public string H_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Home address line 1
        /// [Alphanumeric (55)]
        /// </summary>
        public string H_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Home address line 1
        /// [Alphanumeric (55)]
        /// </summary>
        public string H_ADDRESS03 { get; internal set; }

        /// <summary>
        /// Home state
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string H_STATE { get; internal set; }

        /// <summary>
        /// Home postcode
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string H_POST_CODE { get; internal set; }

        /// <summary>
        /// Post address
        /// [Alphanumeric (55)]
        /// </summary>
        public string P_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Post address
        /// [Alphanumeric (55)]
        /// </summary>
        public string P_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Post address
        /// [Alphanumeric (55)]
        /// </summary>
        public string P_ADDRESS03 { get; internal set; }

        /// <summary>
        /// Post state
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string P_STATE { get; internal set; }

        /// <summary>
        /// Post postcode
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string P_POST_CODE { get; internal set; }

        /// <summary>
        /// Home telephone no
        /// [Uppercase Alphanumeric (24)]
        /// </summary>
        public string HOME_PHONE { get; internal set; }

        /// <summary>
        /// Mobile phone no
        /// [Uppercase Alphanumeric (31)]
        /// </summary>
        public string MOBILE_PHONE { get; internal set; }

        /// <summary>
        /// Work Phone no
        /// [Uppercase Alphanumeric (24)]
        /// </summary>
        public string WORK_PHONE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (70)]
        /// </summary>
        public string EMAIL_ADDRESS { get; internal set; }

        /// <summary>
        /// Emergency Contact Name
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string EMERG_CONTACT { get; internal set; }

        /// <summary>
        /// Emergency Contact Relationship
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string EMERG_RELATE { get; internal set; }

        /// <summary>
        /// Emergecny Contact Phone
        /// [Uppercase Alphanumeric (24)]
        /// </summary>
        public string EMERG_PHONE { get; internal set; }

        /// <summary>
        /// Start Date
        /// </summary>
        public DateTime? START_DATE { get; internal set; }

        /// <summary>
        /// Finish Date
        /// </summary>
        public DateTime? FINISH_DATE { get; internal set; }

        /// <summary>
        /// Staff fte
        /// </summary>
        public short? FTE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REC_TYPE_FLAG { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REC_PROCESS_FLAG { get; internal set; }

        #endregion

    }
}
