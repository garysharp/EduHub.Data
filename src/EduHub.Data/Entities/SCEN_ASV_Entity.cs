using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Validation Data
    /// </summary>
    public class SCEN_ASV_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ID_RETURN { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? REGISTRATION { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ID_STUDENTVALIDATIONTYPE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string FIELDVALUES { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string CREATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LUPDATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LUPDATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
