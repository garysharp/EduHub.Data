using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors
    /// </summary>
    public class KTIE : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// prime key
        /// </summary>
        public int RECORD_ID { get; internal set; }
        /// <summary>
        /// entity causing error ST,SF,SM or SU
        /// [Alphanumeric (2)]
        /// </summary>
        public string ENTITY { get; internal set; }
        /// <summary>
        /// key of entity which caused problem
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ENTITY_KEY { get; internal set; }
        /// <summary>
        /// not found,not available, bad tag
        /// [Alphanumeric (60)]
        /// </summary>
        public string ERROR_TEXT { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
