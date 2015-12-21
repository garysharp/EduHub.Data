using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Houses
    /// </summary>
    public class V_KGH : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _KGHKEY;
        private readonly string _DESCRIPTION;

        #endregion

        internal V_KGH(SeamlessViewsContext Context, KGH KGH)
            : base(Context)
        {
            _KGHKEY = KGH.KGHKEY;
            _DESCRIPTION = KGH.DESCRIPTION;
        }

        /// <summary>
        /// House code
        /// </summary>
        public string KGHKEY { get { return _KGHKEY; } }
        /// <summary>
        /// House description
        /// </summary>
        public string DESCRIPTION { get { return _DESCRIPTION; } }
    }
}
