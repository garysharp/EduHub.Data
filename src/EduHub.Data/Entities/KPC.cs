using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts
    /// </summary>
    public class KPC : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Contact code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCKEY { get; internal set; }
        /// <summary>
        /// Contact surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First name
        /// [Alphanumeric (15)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name
        /// [Alphanumeric (15)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string POST { get; internal set; }
        /// <summary>
        /// Business phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string BUS_PHONE { get; internal set; }
        /// <summary>
        /// Alternate/ home phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string HOME_PHONE { get; internal set; }
        /// <summary>
        /// Mobile phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Email address
        /// 
        /// [Memo]
        /// </summary>
        public string EMAIL { get; internal set; }
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
#endregion
    }
}
