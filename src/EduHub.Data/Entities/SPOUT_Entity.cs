using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored Procedure Return Values
    /// </summary>
    public class SPOUT_Entity : EntityBase
    {
        /// <summary>
        /// Unique identifier consisting of school number,user name and timestamp [Alphanumeric: a100]
        /// </summary>
        public string SPOUTKEY { get; internal set; }
        /// <summary>
        /// Name of import file [Alphanumeric: a200]
        /// </summary>
        public string FILE_NAME { get; internal set; }
        /// <summary>
        /// Key of account table [Uppercase Alphanumeric: u10]
        /// </summary>
        public string ENTITYID { get; internal set; }
        /// <summary>
        /// Y/N flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FLAG01 { get; internal set; }
        /// <summary>
        /// Y/N flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FLAG02 { get; internal set; }
        /// <summary>
        /// Y/N flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FLAG03 { get; internal set; }
        /// <summary>
        /// Y/N flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FLAG04 { get; internal set; }
        /// <summary>
        /// Output texts [Alphanumeric: a40]
        /// </summary>
        public string TXT01 { get; internal set; }
        /// <summary>
        /// Output texts [Alphanumeric: a40]
        /// </summary>
        public string TXT02 { get; internal set; }
        /// <summary>
        /// Output texts [Alphanumeric: a40]
        /// </summary>
        public string TXT03 { get; internal set; }
        /// <summary>
        /// Output texts [Alphanumeric: a40]
        /// </summary>
        public string TXT04 { get; internal set; }
        /// <summary>
        /// Output integers [Integer (32bit signed nullable): l]
        /// </summary>
        public int? NUM01 { get; internal set; }
        /// <summary>
        /// Output integers [Integer (32bit signed nullable): l]
        /// </summary>
        public int? NUM02 { get; internal set; }
        /// <summary>
        /// Output integers [Integer (32bit signed nullable): l]
        /// </summary>
        public int? NUM03 { get; internal set; }
        /// <summary>
        /// Output integers [Integer (32bit signed nullable): l]
        /// </summary>
        public int? NUM04 { get; internal set; }
        /// <summary>
        /// Output error message or long text data [Memo: m]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
