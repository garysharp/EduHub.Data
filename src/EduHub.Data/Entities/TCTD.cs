using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Period Information
    /// </summary>
    public partial class TCTD : EntityBase
    {
#region Navigation Property Cache
        private TC _TCTDKEY_TC;
        private TH _QKEY_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Owner relation
        /// </summary>
        public DateTime? TCTDKEY { get; internal set; }
        /// <summary>
        /// Associated Quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Time slot number
        /// </summary>
        public short? TIME_INDEX { get; internal set; }
        /// <summary>
        /// Start time of each period hhmm 24 hr clock
        /// </summary>
        public DateTime? TIME_START { get; internal set; }
        /// <summary>
        /// End time of each period hhmm 24 hr clock
        /// </summary>
        public DateTime? TIME_END { get; internal set; }
        /// <summary>
        /// What the time slot is for
        /// </summary>
        public short? TIME_TYPE { get; internal set; }
        /// <summary>
        /// A caption for the timeslot
        /// [Alphanumeric (20)]
        /// </summary>
        public string TIME_NAME { get; internal set; }
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
        /// TC (Calendar) related entity by [TCTD.TCTDKEY]-&gt;[TC.TCKEY]
        /// Owner relation
        /// </summary>
        public TC TCTDKEY_TC
        {
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
        /// TH (Timetable Quilt Headers) related entity by [TCTD.QKEY]-&gt;[TH.THKEY]
        /// Associated Quilt
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
