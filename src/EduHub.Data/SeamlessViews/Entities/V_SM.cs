using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Rooms
    /// </summary>
    public class V_SM : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _ROOM;
        private readonly string _TITLE;
        private readonly string _DESCRIPTION;
        private readonly short? _SEATING;
        private readonly string _FACULTY;

        #endregion

        internal V_SM(SeamlessViewsContext Context, SM SM)
            : base(Context)
        {
            _ROOM = SM.ROOM;
            _TITLE = SM.TITLE;
            _DESCRIPTION = SM.DESCRIPTION;
            _SEATING = SM.SEATING;
            _FACULTY = SM.FACULTY;
        }

        /// <summary>
        /// Room code
        /// </summary>
        public string ROOM { get { return _ROOM; } }
        /// <summary>
        /// Room name
        /// </summary>
        public string TITLE { get { return _TITLE; } }
        /// <summary>
        /// Description of room
        /// </summary>
        public string DESCRIPTION { get { return _DESCRIPTION; } }
        /// <summary>
        /// Maximum capacity
        /// </summary>
        public short? SEATING { get { return _SEATING; } }
        /// <summary>
        /// Code of the faculty responsible for this room
        /// </summary>
        public string FACULTY { get { return _FACULTY; } }
    }
}
