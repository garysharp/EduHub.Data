namespace EduHub.Data.Entities
{
    public abstract class EntityBase
    {
        internal EntityBase()
        { }

        /// <summary>
        /// <see cref="EduHubContext"/> this entity belongs to
        /// </summary>
        public EduHubContext Context { get; internal set; }
    }
}
