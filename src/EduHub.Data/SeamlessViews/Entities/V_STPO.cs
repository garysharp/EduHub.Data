using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Position or Group Memberships
    /// </summary>
    public class V_STPO : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _STPOKEY;
        private readonly string _SGLINK;

        #endregion

        internal V_STPO(SeamlessViewsContext Context, STPO STPO)
            : base(Context)
        {
            _STPOKEY = STPO.STPOKEY;
            _SGLINK = STPO.SGLINK;
        }

        /// <summary>
        /// Student ID
        /// </summary>
        public string STPOKEY { get { return _STPOKEY; } }
        /// <summary>
        /// Position or Group code
        /// </summary>
        public string SGLINK { get { return _SGLINK; } }
    }
}
