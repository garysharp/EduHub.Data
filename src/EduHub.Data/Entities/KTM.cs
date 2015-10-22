﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Task Message
    /// </summary>
    public partial class KTM : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Stored procedure name
        /// [Alphanumeric (30)]
        /// </summary>
        public string KTMKEY { get; internal set; }
        /// <summary>
        /// Message detail
        /// [Alphanumeric (200)]
        /// </summary>
        public string MESSAGE { get; internal set; }
#endregion
    }
}
