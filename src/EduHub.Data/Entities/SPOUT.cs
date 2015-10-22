using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored Procedure Return Values
    /// </summary>
    public partial class SPOUT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Unique identifier consisting of school number,user name and timestamp
        /// [Alphanumeric (100)]
        /// </summary>
        public string SPOUTKEY { get; internal set; }
        /// <summary>
        /// Name of import file
        /// [Alphanumeric (200)]
        /// </summary>
        public string FILE_NAME { get; internal set; }
        /// <summary>
        /// Key of account table
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ENTITYID { get; internal set; }
        /// <summary>
        /// Y/N flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FLAG01 { get; internal set; }
        /// <summary>
        /// Y/N flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FLAG02 { get; internal set; }
        /// <summary>
        /// Y/N flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FLAG03 { get; internal set; }
        /// <summary>
        /// Y/N flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FLAG04 { get; internal set; }
        /// <summary>
        /// Output texts
        /// [Alphanumeric (40)]
        /// </summary>
        public string TXT01 { get; internal set; }
        /// <summary>
        /// Output texts
        /// [Alphanumeric (40)]
        /// </summary>
        public string TXT02 { get; internal set; }
        /// <summary>
        /// Output texts
        /// [Alphanumeric (40)]
        /// </summary>
        public string TXT03 { get; internal set; }
        /// <summary>
        /// Output texts
        /// [Alphanumeric (40)]
        /// </summary>
        public string TXT04 { get; internal set; }
        /// <summary>
        /// Output integers
        /// </summary>
        public int? NUM01 { get; internal set; }
        /// <summary>
        /// Output integers
        /// </summary>
        public int? NUM02 { get; internal set; }
        /// <summary>
        /// Output integers
        /// </summary>
        public int? NUM03 { get; internal set; }
        /// <summary>
        /// Output integers
        /// </summary>
        public int? NUM04 { get; internal set; }
        /// <summary>
        /// Output error message or long text data
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// KERROR (Import or Update Errors) related entities by [KERROR.SPOUTKEY]-&gt;[SPOUT.SPOUTKEY]
        /// </summary>
        public IReadOnlyList<KERROR> KERROR_SPOUTKEY
        {
            get
            {
                return Context.SPOUT.FindKERRORBySPOUTKEY(SPOUTKEY);
            }
        }
#endregion
    }
}
