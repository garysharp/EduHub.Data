using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Prevention Measures
    /// </summary>
    public class SADP_Entity : EntityBase
    {
#region Navigation Property Cache
        private SAD_Entity _ACCIDENTID_SAD;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCIDENTID { get; internal set; }
        /// <summary>
        /// Code identifying preventative action taken [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PREVENTION { get; internal set; }
        /// <summary>
        /// Description of any other preventative action taken [Memo: m]
        /// </summary>
        public string OTHER_PREV_INFO { get; internal set; }
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
        /// Navigation property for [ACCIDENTID] => [SAD_Entity].[SADKEY]
        /// Sequence no of accident
        /// </summary>
        public SAD_Entity ACCIDENTID_SAD {
            get
            {
                if (ACCIDENTID.HasValue)
                {
                    if (_ACCIDENTID_SAD == null)
                    {
                        _ACCIDENTID_SAD = Context.SAD.FindBySADKEY(ACCIDENTID.Value);
                    }
                    return _ACCIDENTID_SAD;
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
