using System;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Base object for EduHub Entities
    /// </summary>
    public abstract class EduHubEntity : IEduHubEntity
    {
        internal EduHubEntity()
        { }

        /// <inheritdoc />
        public EduHubContext Context { get; internal set; }

        /// <inheritdoc />
        public abstract DateTime? EntityLastModified { get; }
    }
}
