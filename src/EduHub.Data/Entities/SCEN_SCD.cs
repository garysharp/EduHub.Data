using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Column-Display Metadata for displaying Student Data
    /// </summary>
    public class SCEN_SCD : EntityBase
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
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string COLUMNNAME { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string COLUMNDISPLAYNAME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? DEFAULTCOLUMNDISPLAYWIDTH { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? DEFAULTCOLUMNDISPLAYORDER { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PREFERREDCOLUMNDISPLAYWIDTH { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PREFERREDCOLUMNDISPLAYORDER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
