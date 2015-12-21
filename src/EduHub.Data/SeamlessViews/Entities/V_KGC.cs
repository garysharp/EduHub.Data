using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Home Groups
    /// </summary>
    public class V_KGC : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _KGCKEY;
        private readonly string _ROOM;
        private readonly string _TEACHER;

        #endregion

        internal V_KGC(SeamlessViewsContext Context, KGC KGC)
            : base(Context)
        {
            _KGCKEY = KGC.KGCKEY;
            _ROOM = KGC.ROOM;
            _TEACHER = KGC.TEACHER;
        }

        /// <summary>
        /// Home Group code
        /// </summary>
        public string KGCKEY { get { return _KGCKEY; } }
        /// <summary>
        /// Home group room
        /// </summary>
        public string ROOM { get { return _ROOM; } }
        /// <summary>
        /// Staff code of first or only home group teacher
        /// </summary>
        public string TEACHER { get { return _TEACHER; } }
    }
}
