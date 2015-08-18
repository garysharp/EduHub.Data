using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Excluded Data
    /// </summary>
    public class SCEN_ASE : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? ID_RETURN { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? REGISTRATION { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASE_TYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATEUSER { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATED { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LUPDATEUSER { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LUPDATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
