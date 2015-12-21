using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Student Groupings
    /// </summary>
    public class V_SG : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _SGKEY;
        private readonly string _TITLE;
        private readonly string _ADULT_RESPONSIBLE;

        #endregion

        internal V_SG(SeamlessViewsContext Context, SG SG)
            : base(Context)
        {
            _SGKEY = SG.SGKEY;
            _TITLE = SG.TITLE;
            _ADULT_RESPONSIBLE = SG.ADULT_RESPONSIBLE;
        }

        /// <summary>
        /// Student Grouping code
        /// </summary>
        public string SGKEY { get { return _SGKEY; } }
        /// <summary>
        /// Name of Student Grouping
        /// </summary>
        public string TITLE { get { return _TITLE; } }
        /// <summary>
        /// Reference in table SF or DF to person in charge
        /// </summary>
        public string ADULT_RESPONSIBLE { get { return _ADULT_RESPONSIBLE; } }
    }
}
