using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt
    /// </summary>
    public class SFAQ : EntityBase
    {
#region Navigation Property Cache
        private SF _SFAQKEY_SF;
        private TH _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFAQKEY { get; internal set; }
        /// <summary>
        /// Quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Day of the timetable cycle
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }
        /// <summary>
        /// Start available period
        /// </summary>
        public short? START_PERIOD { get; internal set; }
        /// <summary>
        /// End available period
        /// </summary>
        public short? END_PERIOD { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SFAQKEY] => [SF].[SFKEY]
        /// Staff key
        /// </summary>
        public SF SFAQKEY_SF {
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
        /// Navigation property for [QKEY] => [TH].[THKEY]
        /// Quilt
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
