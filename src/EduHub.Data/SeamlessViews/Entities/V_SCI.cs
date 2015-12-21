using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// School Information
    /// </summary>
    public class V_SCI : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly int _SCIKEY;
        private readonly string _CAMPUS_NAME;
        private readonly string _CAMPUS_TYPE;
        private readonly string _SCHOOL_NAME;
        private readonly string _SCHOOL_TYPE;

        #endregion

        internal V_SCI(SeamlessViewsContext Context, SCI SCI)
            : base(Context)
        {
            _SCIKEY = SCI.SCIKEY;
            _CAMPUS_NAME = SCI.CAMPUS_NAME;
            _CAMPUS_TYPE = SCI.CAMPUS_TYPE;
            _SCHOOL_NAME = SCI.SCHOOL_NAME;
            _SCHOOL_TYPE = SCI.SCHOOL_TYPE;
        }

        /// <summary>
        /// Sequence no
        /// </summary>
        public int SCIKEY { get { return _SCIKEY; } }
        /// <summary>
        /// Campus name
        /// </summary>
        public string CAMPUS_NAME { get { return _CAMPUS_NAME; } }
        /// <summary>
        /// Campus type: Primary, Secondary, etc
        /// </summary>
        public string CAMPUS_TYPE { get { return _CAMPUS_TYPE; } }
        /// <summary>
        /// Name of school
        /// </summary>
        public string SCHOOL_NAME { get { return _SCHOOL_NAME; } }
        /// <summary>
        /// School type: Primary, Secondary, etc
        /// </summary>
        public string SCHOOL_TYPE { get { return _SCHOOL_TYPE; } }
    }
}
