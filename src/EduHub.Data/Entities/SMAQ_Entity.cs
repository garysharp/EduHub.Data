using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availability in Quilt
    /// </summary>
    public class SMAQ_Entity : EntityBase
    {
#region Navigation Property Cache
        private SM_Entity _SMAQKEY_SM;
        private TH_Entity _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Room key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SMAQKEY { get; internal set; }
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
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SMAQKEY] => [SM_Entity].[ROOM]
        /// Room key
        /// </summary>
        public SM_Entity SMAQKEY_SM {
            get
            {
                if (SMAQKEY != null)
                {
                    if (_SMAQKEY_SM == null)
                    {
                        _SMAQKEY_SM = Context.SM.FindByROOM(SMAQKEY);
                    }
                    return _SMAQKEY_SM;
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
