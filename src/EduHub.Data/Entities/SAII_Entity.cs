using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvement Injuries
    /// </summary>
    public class SAII_Entity : EntityBase
    {
#region Navigation Property Cache
        private SAI_Entity _INVOLVEMENTID_SAI;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident involvement [Integer (32bit signed nullable): l]
        /// </summary>
        public int? INVOLVEMENTID { get; internal set; }
        /// <summary>
        /// Code identifying Injury Severity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEVERITY { get; internal set; }
        /// <summary>
        /// Code identifying Serious Reportable Injury [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SRI_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying Nature of Injury [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NATURE { get; internal set; }
        /// <summary>
        /// Notes if NATURE = Other [Memo: m]
        /// </summary>
        public string OTHER_INFO { get; internal set; }
        /// <summary>
        /// Code identifying Body Location of injury [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LOCATION { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [INVOLVEMENTID] => [SAI_Entity].[SAIKEY]
        /// Sequence no of accident involvement
        /// </summary>
        public SAI_Entity INVOLVEMENTID_SAI {
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
