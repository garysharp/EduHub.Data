using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Languages
    /// </summary>
    public class V_KGL : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _KGLKEY;
        private readonly string _DESCRIPTION;

        #endregion

        internal V_KGL(SeamlessViewsContext Context, KGL KGL)
            : base(Context)
        {
            _KGLKEY = KGL.KGLKEY;
            _DESCRIPTION = KGL.DESCRIPTION;
        }

        /// <summary>
        /// Language code
        /// </summary>
        public string KGLKEY { get { return _KGLKEY; } }
        /// <summary>
        /// Long description
        /// </summary>
        public string DESCRIPTION { get { return _DESCRIPTION; } }
    }
}
