using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Type
    /// </summary>
    public class SCEN_CVT_Entity : EntityBase
    {
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u15]
        /// </summary>
        public string VCODE { get; internal set; }
        /// <summary>
        ///  [Memo: m]
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
        ///  [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CVT_TYPE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string COMMANDNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ISENABLED { get; internal set; }
        
        
    }
}
