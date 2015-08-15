using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt
    /// </summary>
    public class SFAQ_Entity : EntityBase
    {
#region Navigation Property Cache
        private SF_Entity _SFAQKEY_SF;
        private TH_Entity _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SFAQKEY { get; internal set; }
        /// <summary>
        /// Quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Day of the timetable cycle [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }
        /// <summary>
        /// Start available period [Integer (16bit signed nullable): i]
        /// </summary>
        public short? START_PERIOD { get; internal set; }
        /// <summary>
        /// End available period [Integer (16bit signed nullable): i]
        /// </summary>
        public short? END_PERIOD { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SFAQKEY] => [SF_Entity].[SFKEY]
        /// Staff key
        /// </summary>
        public SF_Entity SFAQKEY_SF {
            get
            {
                if (SFAQKEY != null)
                {
                    if (_SFAQKEY_SF == null)
                    {
                        _SFAQKEY_SF = Context.SF.FindBySFKEY(SFAQKEY);
                    }
                    return _SFAQKEY_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [QKEY] => [TH_Entity].[THKEY]
        /// Quilt
        /// </summary>
        public TH_Entity QKEY_TH {
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
