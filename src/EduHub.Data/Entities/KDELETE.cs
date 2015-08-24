﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Data deleted from DataMirror monitored tables
    /// </summary>
    public class KDELETE : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// SQL identity
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        /// The table from which the record was deleted
        /// [Alphanumeric (10)]
        /// </summary>
        public string TABLENAME { get; internal set; }
        /// <summary>
        /// The prime key data value that was deleted
        /// [Alphanumeric (30)]
        /// </summary>
        public string IDVALUE { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}