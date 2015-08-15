using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Field-Display Metadata for Census Return Data
    /// </summary>
    public class SCEN_RFD_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string COLUMNNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string COLUMNDISPLAYNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string RFD_TYPE { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TYPEORDER { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DEFAULTCOLUMNDISPLAYORDER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
