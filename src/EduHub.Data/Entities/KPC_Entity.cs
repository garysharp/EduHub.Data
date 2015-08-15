using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts
    /// </summary>
    public class KPC_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Contact code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCKEY { get; internal set; }
        /// <summary>
        /// Contact surname [Alphanumeric: a20]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First name [Alphanumeric: a15]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name [Alphanumeric: a15]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Gender [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Post code [Alphanumeric: a4]
        /// </summary>
        public string POST { get; internal set; }
        /// <summary>
        /// Business phone [Alphanumeric: a15]
        /// </summary>
        public string BUS_PHONE { get; internal set; }
        /// <summary>
        /// Alternate/ home phone [Alphanumeric: a15]
        /// </summary>
        public string HOME_PHONE { get; internal set; }
        /// <summary>
        /// Mobile phone [Alphanumeric: a15]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Email address
        ///  [Memo: m]
        /// </summary>
        public string EMAIL { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
