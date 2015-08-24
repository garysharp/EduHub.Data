﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvement Injuries
    /// </summary>
    public class SAII : EntityBase
    {
#region Navigation Property Cache
        private SAI _INVOLVEMENTID_SAI;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident involvement
        /// </summary>
        public int? INVOLVEMENTID { get; internal set; }
        /// <summary>
        /// Code identifying Injury Severity
        /// </summary>
        public short? SEVERITY { get; internal set; }
        /// <summary>
        /// Code identifying Serious Reportable Injury
        /// </summary>
        public short? SRI_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying Nature of Injury
        /// </summary>
        public short? NATURE { get; internal set; }
        /// <summary>
        /// Notes if NATURE = Other
        /// [Memo]
        /// </summary>
        public string OTHER_INFO { get; internal set; }
        /// <summary>
        /// Code identifying Body Location of injury
        /// </summary>
        public short? LOCATION { get; internal set; }
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
        /// <summary>
        /// Navigation property for [INVOLVEMENTID] => [SAI].[SAIKEY]
        /// Sequence no of accident involvement
        /// </summary>
        public SAI INVOLVEMENTID_SAI {
            get
            {
                if (INVOLVEMENTID.HasValue)
                {
                    if (_INVOLVEMENTID_SAI == null)
                    {
                        _INVOLVEMENTID_SAI = Context.SAI.FindBySAIKEY(INVOLVEMENTID.Value);
                    }
                    return _INVOLVEMENTID_SAI;
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