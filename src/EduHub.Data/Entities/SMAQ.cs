using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availability in Quilt
    /// </summary>
    public partial class SMAQ : EntityBase
    {
#region Navigation Property Cache
        private SM _SMAQKEY_SM;
        private TH _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Room key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SMAQKEY { get; internal set; }
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
        /// SM (Rooms) related entity by [SMAQ.SMAQKEY]-&gt;[SM.ROOM]
        /// Room key
        /// </summary>
        public SM SMAQKEY_SM
        {
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
        /// TH (Timetable Quilt Headers) related entity by [SMAQ.QKEY]-&gt;[TH.THKEY]
        /// Quilt
        /// </summary>
        public TH QKEY_TH
        {
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
