using EduHub.Data.Entities;
using System;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Student Half-Day Absences
    /// </summary>
    public class V_SXAB : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly int _SXAB_ID;
        private readonly DateTime? _ABSENCE_DATE;
        private readonly string _STKEY;
        private readonly short? _AM_ACT_TYPE;
        private readonly short? _PM_ACT_TYPE;

        #endregion

        internal V_SXAB(SeamlessViewsContext Context, SXAB SXAB)
            : base(Context)
        {
            _SXAB_ID = SXAB.SXAB_ID;
            _ABSENCE_DATE = SXAB.ABSENCE_DATE;
            _STKEY = SXAB.STKEY;
            _AM_ACT_TYPE = SXAB.AM_ACT_TYPE;
            _PM_ACT_TYPE = SXAB.PM_ACT_TYPE;
        }

        /// <summary>
        /// Unique record ID
        /// </summary>
        public int SXAB_ID { get { return _SXAB_ID; } }
        /// <summary>
        /// Date of absence
        /// </summary>
        public DateTime? ABSENCE_DATE { get { return _ABSENCE_DATE; } }
        /// <summary>
        /// Student ID
        /// </summary>
        public string STKEY { get { return _STKEY; } }
        /// <summary>
        /// Actual attendance type in the morning
        /// </summary>
        public short? AM_ACT_TYPE { get { return _AM_ACT_TYPE; } }
        /// <summary>
        /// Actual attendance type in the afternoon
        /// </summary>
        public short? PM_ACT_TYPE { get { return _PM_ACT_TYPE; } }
    }
}
