using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Period Information
    /// </summary>
    public class TCTD_Entity : EntityBase
    {
#region Navigation Property Cache
        private TC_Entity _TCTDKEY_TC;
        private TH_Entity _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Owner relation [Date Time nullable: d]
        /// </summary>
        public DateTime? TCTDKEY { get; internal set; }
        /// <summary>
        /// Associated Quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Time slot number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TIME_INDEX { get; internal set; }
        /// <summary>
        /// Start time of each period hhmm 24 hr clock [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_START { get; internal set; }
        /// <summary>
        /// End time of each period hhmm 24 hr clock [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_END { get; internal set; }
        /// <summary>
        /// What the time slot is for [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TIME_TYPE { get; internal set; }
        /// <summary>
        /// A caption for the timeslot [Alphanumeric: a20]
        /// </summary>
        public string TIME_NAME { get; internal set; }
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
        /// Navigation property for [TCTDKEY] => [TC_Entity].[TCKEY]
        /// Owner relation
        /// </summary>
        public TC_Entity TCTDKEY_TC {
            get
            {
                if (TCTDKEY.HasValue)
                {
                    if (_TCTDKEY_TC == null)
                    {
                        _TCTDKEY_TC = Context.TC.FindByTCKEY(TCTDKEY.Value);
                    }
                    return _TCTDKEY_TC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [QKEY] => [TH_Entity].[THKEY]
        /// Associated Quilt
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
