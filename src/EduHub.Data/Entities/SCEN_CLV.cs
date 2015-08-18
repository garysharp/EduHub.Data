using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Data
    /// </summary>
    public class SCEN_CLV : EntityBase
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
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string CLASSCODE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? ID_CLASSVALIDATIONTYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATUS { get; internal set; }
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
