using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Faculties
    /// </summary>
    public class V_KSF : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _KSFKEY;
        private readonly string _DESCRIPTION;

        #endregion

        internal V_KSF(SeamlessViewsContext Context, KSF KSF)
            : base(Context)
        {
            _KSFKEY = KSF.KSFKEY;
            _DESCRIPTION = KSF.DESCRIPTION;
        }

        /// <summary>
        /// Faculty code
        /// </summary>
        public string KSFKEY { get { return _KSFKEY; } }
        /// <summary>
        /// Faculty name
        /// </summary>
        public string DESCRIPTION { get { return _DESCRIPTION; } }
    }
}
