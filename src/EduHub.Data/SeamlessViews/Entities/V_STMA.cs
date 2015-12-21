using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Subject Selections &amp; Marks
    /// </summary>
    public class V_STMA : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _SKEY;
        private readonly string _MKEY;
        private readonly short? _CLASS;
        private readonly string _FULLNAME;
        private readonly string _TEACHER_NAME;
        private readonly string _TTPERIOD;

        #endregion

        internal V_STMA(SeamlessViewsContext Context, STMA STMA)
            : base(Context)
        {
            _SKEY = STMA.SKEY;
            _MKEY = STMA.MKEY;
            _CLASS = STMA.CLASS;
            _FULLNAME = STMA.FULLNAME;
            _TEACHER_NAME = STMA.TEACHER_NAME;
            _TTPERIOD = STMA.TTPERIOD;
        }

        /// <summary>
        /// Student ID
        /// </summary>
        public string SKEY { get { return _SKEY; } }
        /// <summary>
        /// Subject code
        /// </summary>
        public string MKEY { get { return _MKEY; } }
        /// <summary>
        /// Class: distinguishes different groups of students taking the same subject on the same timetable
        /// </summary>
        public short? CLASS { get { return _CLASS; } }
        /// <summary>
        /// Full name of subject
        /// </summary>
        public string FULLNAME { get { return _FULLNAME; } }
        /// <summary>
        /// Teacher taking subject
        /// </summary>
        public string TEACHER_NAME { get { return _TEACHER_NAME; } }
        /// <summary>
        ///  Timetabling year/semester in which the subject is completed (eg 1998S1, 1998)
        /// </summary>
        public string TTPERIOD { get { return _TTPERIOD; } }
    }
}
