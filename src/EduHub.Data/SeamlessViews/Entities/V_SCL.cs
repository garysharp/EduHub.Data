using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Subject Classes
    /// </summary>
    public class V_SCL : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _SCLKEY;
        private readonly string _SUBJECT;
        private readonly short? _CLASS;
        private readonly string _TEACHER01;
        private readonly string _ROOM01;

        #endregion

        internal V_SCL(SeamlessViewsContext Context, SCL SCL)
            : base(Context)
        {
            _SCLKEY = SCL.SCLKEY;
            _SUBJECT = SCL.SUBJECT;
            _CLASS = SCL.CLASS;
            _TEACHER01 = SCL.TEACHER01;
            _ROOM01 = SCL.ROOM01;
        }

        /// <summary>
        /// Class code
        /// </summary>
        public string SCLKEY { get { return _SCLKEY; } }
        /// <summary>
        /// Subject code
        /// </summary>
        public string SUBJECT { get { return _SUBJECT; } }
        /// <summary>
        /// Class number
        /// </summary>
        public short? CLASS { get { return _CLASS; } }
        /// <summary>
        /// Teachers
        /// </summary>
        public string TEACHER01 { get { return _TEACHER01; } }
        /// <summary>
        /// Rooms
        /// </summary>
        public string ROOM01 { get { return _ROOM01; } }
    }
}
