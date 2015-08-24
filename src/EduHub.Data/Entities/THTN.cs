﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Labels
    /// </summary>
    public class THTN : EntityBase
    {
#region Navigation Property Cache
        private TH _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Link to Timetable Quilt Header
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Number &gt; 0 for quilt label,&lt; 0 extra labels
        /// </summary>
        public short? LABEL_NUMBER { get; internal set; }
        /// <summary>
        /// R for Row, C for Column
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LABEL_TYPE { get; internal set; }
        /// <summary>
        /// Name for the label
        /// [Alphanumeric (20)]
        /// </summary>
        public string LABEL_NAME { get; internal set; }
        /// <summary>
        /// Display colour for the label
        /// </summary>
        public int? LABEL_COLOUR { get; internal set; }
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
        /// <summary>
        /// Navigation property for [QKEY] => [TH].[THKEY]
        /// Link to Timetable Quilt Header
        /// </summary>
        public TH QKEY_TH {
            get
            {
                if (QKEY != null)
                {
                    if (_QKEY_TH == null)
                    {
                        _QKEY_TH = Context.TH.FindByTHKEY(QKEY);
                    }
                    return _QKEY_TH;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}