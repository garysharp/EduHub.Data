using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Data Transfer Table
    /// </summary>
    public class ST_TFRIO_Entity : EntityBase
    {
#region Navigation Property Cache
        private SKGS_Entity _DEST_SCHOOL_SKGS;
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Unique Record ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }
        /// <summary>
        /// ST.STKEY [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// ST.STKEY NEW [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY_NEW { get; internal set; }
        /// <summary>
        /// ST.REGISTRATION [Integer (16bit signed nullable): i]
        /// </summary>
        public short? REGISTRATION { get; internal set; }
        /// <summary>
        /// Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TFR_PERMISSION { get; internal set; }
        /// <summary>
        /// Source school ID [Uppercase Alphanumeric: u8]
        /// </summary>
        public string SOURCE_SCHOOL { get; internal set; }
        /// <summary>
        /// Destination school ID [Uppercase Alphanumeric: u8]
        /// </summary>
        public string DEST_SCHOOL { get; internal set; }
        /// <summary>
        /// Y or blank, confirmation of receipt at destination [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECD_AT_DEST { get; internal set; }
        /// <summary>
        /// TRANSFER, RETRANSFER and COMPLETE [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TFR_STATUS { get; internal set; }
        /// <summary>
        /// Date of transfer/import [Date Time nullable: d]
        /// </summary>
        public DateTime? TFR_DATE { get; internal set; }
        /// <summary>
        /// Transfer comments [Alphanumeric: a250]
        /// </summary>
        public string TFR_COMMENT { get; internal set; }
        /// <summary>
        /// Last Write Date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write Time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last Write User [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [DEST_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Destination school ID
        /// </summary>
        public SKGS_Entity DEST_SCHOOL_SKGS {
            get
            {
                if (DEST_SCHOOL != null)
                {
                    if (_DEST_SCHOOL_SKGS == null)
                    {
                        _DEST_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(DEST_SCHOOL);
                    }
                    return _DEST_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
