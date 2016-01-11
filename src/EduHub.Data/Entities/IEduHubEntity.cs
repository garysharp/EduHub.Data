using System;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eduHub entity contract
    /// </summary>
    public interface IEduHubEntity
    {
        /// <summary>
        /// <see cref="EduHubContext"/> this entity belongs to
        /// </summary>
        EduHubContext Context { get; }

        /// <summary>
        /// The last time the entity was modified. Typically maps to the LW_DATE field.
        /// </summary>
        DateTime? EntityLastModified { get; }
    }
}
