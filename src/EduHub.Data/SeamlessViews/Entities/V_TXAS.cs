using EduHub.Data.Entities;
using System;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Actual Sessions
    /// </summary>
    public class V_TXAS : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly short? _CLASS;
        private readonly short? _DAY_NO;
        private readonly string _LOCATION;
        private readonly short? _PERIOD_NO;
        private readonly DateTime? _SESSION_DATE;
        private readonly string _SUBJECT;
        private readonly string _TEACHER;

        #endregion

        internal V_TXAS(SeamlessViewsContext Context, TXAS TXAS)
            : base(Context)
        {
            _CLASS = TXAS.CLASS;
            _DAY_NO = TXAS.DAY_NO;
            _LOCATION = TXAS.LOCATION;
            _PERIOD_NO = TXAS.PERIOD_NO;
            _SESSION_DATE = TXAS.SESSION_DATE;
            _SUBJECT = TXAS.SUBJECT;
            _TEACHER = TXAS.TEACHER;
        }

        /// <summary>
        /// Class for this session
        /// </summary>
        public short? CLASS { get { return _CLASS; } }
        /// <summary>
        /// Day number in the current timetable cycle
        /// </summary>
        public short? DAY_NO { get { return _DAY_NO; } }
        /// <summary>
        /// Room code of room for this session
        /// </summary>
        public string LOCATION { get { return _LOCATION; } }
        /// <summary>
        /// Period number within the day
        /// </summary>
        public short? PERIOD_NO { get { return _PERIOD_NO; } }
        /// <summary>
        /// Date of this session
        /// </summary>
        public DateTime? SESSION_DATE { get { return _SESSION_DATE; } }
        /// <summary>
        /// Subject for this session
        /// </summary>
        public string SUBJECT { get { return _SUBJECT; } }
        /// <summary>
        /// Staff code of teacher for this session
        /// </summary>
        public string TEACHER { get { return _TEACHER; } }
    }
}
