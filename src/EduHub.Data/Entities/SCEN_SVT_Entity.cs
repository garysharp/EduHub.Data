using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Validation Type Data
    /// </summary>
    public class SCEN_SVT_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u15]
        /// </summary>
        public string VCODE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string VALIDATIONMESSAGE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string WARNING { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERIOD { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string DETAILEDMESSAGE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string FIELDS { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string COMMANDNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ISENABLED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
