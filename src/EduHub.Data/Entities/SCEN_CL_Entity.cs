using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Data
    /// </summary>
    public class SCEN_CL_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CAMPUSNUMBER { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u5]
        /// </summary>
        public string CLASSCODE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CLASSTYPE { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? FTETEACHERS { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PREP { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR01 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR02 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR03 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR04 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR05 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR06 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR07 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR08 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR09 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR10 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR11 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SCHOOL_YEAR12 { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PRIMARYUG { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SENIORUG { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string CREATEUSER { get; internal set; }
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
