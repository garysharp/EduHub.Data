﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Error Log
    /// </summary>
    public partial class SEC_ELOG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int ERRORCOUNT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string ERRORDESCRIPTION { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string ERRORTYPE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ERRORTIME { get; internal set; }
#endregion
    }
}
