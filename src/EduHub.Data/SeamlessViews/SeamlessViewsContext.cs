using EduHub.Data.SeamlessViews.Entities;

namespace EduHub.Data.SeamlessViews
{
    /// <summary>
    /// Seamless Views Context
    /// </summary>
    public class SeamlessViewsContext
    {
        private readonly EduHubContext eduHubContext;

        private readonly V_STDataSet _V_ST;
        private readonly V_AIMDataSet _V_AIM;

        internal SeamlessViewsContext(EduHubContext EduHubContext)
        {
            eduHubContext = EduHubContext;

            _V_ST = new V_STDataSet(this);
            _V_AIM = new V_AIMDataSet(this);
        }

        /// <summary>
        /// eduHub Context
        /// </summary>
        public EduHubContext EduHubContext { get { return eduHubContext; } }

        /// <summary>
        /// Identifies Student Data View
        /// </summary>
        public V_STDataSet V_ST { get { return _V_ST; } }

        /// <summary>
        /// AIM
        /// </summary>
        public V_AIMDataSet V_AIM { get { return _V_AIM; } }
    }
}
