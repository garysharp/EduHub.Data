namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Base object for Seamless Views Entities
    /// </summary>
    public abstract class SeamlessViewsEntity
    {
        internal SeamlessViewsEntity(SeamlessViewsContext Context)
        {
            this.Context = Context;
        }

        /// <summary>
        /// <see cref="SeamlessViewsContext"/> this entity belongs to
        /// </summary>
        public SeamlessViewsContext Context { get; internal set; }
    }
}
