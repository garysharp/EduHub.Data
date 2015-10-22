﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Type
    /// </summary>
    public partial class SCEN_CVT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string VCODE { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string VALIDATIONMESSAGE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WARNING { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERIOD { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string DETAILEDMESSAGE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CVT_TYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string COMMANDNAME { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ISENABLED { get; internal set; }
#endregion
    }
}
