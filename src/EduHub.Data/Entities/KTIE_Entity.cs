using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors
    /// </summary>
    public class KTIE_Entity : EntityBase
    {
        /// <summary>
        /// prime key [Integer (32bit signed): l]
        /// </summary>
        public int RECORD_ID { get; internal set; }
        /// <summary>
        /// entity causing error ST,SF,SM or SU [Alphanumeric: a2]
        /// </summary>
        public string ENTITY { get; internal set; }
        /// <summary>
        /// key of entity which caused problem [Uppercase Alphanumeric: u20]
        /// </summary>
        public string ENTITY_KEY { get; internal set; }
        /// <summary>
        /// not found,not available, bad tag [Alphanumeric: a60]
        /// </summary>
        public string ERROR_TEXT { get; internal set; }
        
        
    }
}
