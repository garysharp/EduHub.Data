using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Return Summary Data
    /// </summary>
    public class SCEN_RTN_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RN_SCHOOLNUMBER { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u40]
        /// </summary>
        public string RN_SCHOOLNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u40]
        /// </summary>
        public string RN_SCHOOLTYPE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string RN_MONTH { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RN_YEAR { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RN_STATUS { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? RN_CREATED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string RN_CREATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? RN_LUPDATED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string RN_LUPDATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? SD_LREFRESHED { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? SD_LVALIDATED { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SD_SRPFUNDEDFTE { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SD_NOTSRPFUNDEDFTE { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SD_TOTALFTE { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_INCLUDEDHC { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_SYSTEMEXCLUDEDHC { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_MANUALLYEXCLUDEDHC { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_TOTALHC { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_ERRORCOUNT { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_UNPROCESSEDWARNINGCOUNT { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SD_ACKNOWLEDGEDWARNINGCOUNT { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CSD_LHMGREFRESHED { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CSD_LUPDATED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string CSD_LUPDATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CSD_LVALIDATED { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CSD_CLASSCOUNT { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CSD_STUDENTHC { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? CSD_TEACHERFTE { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CSD_ERRORCOUNT { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CSD_UNPROCESSEDWARNINGCOUNT { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CSD_ACKNOWLEDGEDWARNINGCOUNT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u80]
        /// </summary>
        public string LD_CONTACTNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u20]
        /// </summary>
        public string LD_CONTACTPHONE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u80]
        /// </summary>
        public string LD_PRINCIPALNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u20]
        /// </summary>
        public string LD_PRINCIPALPHONE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string LD_COMMENTS { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LD_USERCERTIFICATION { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string LD_FINALREPORTLOCATION { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LD_STATUS { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LD_CREATED { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LD_LODGED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LD_LUPDATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LD_LUPDATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
