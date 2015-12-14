namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Base object for Seamless Views Entities
    /// </summary>
    public abstract class SeamlessViewsEntityBase
    {
        internal SeamlessViewsEntityBase()
        { }

        /// <summary>
        /// <see cref="EduHubContext"/> this entity belongs to
        /// </summary>
        public EduHubContext Context { get; internal set; }
    }
}
