using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors
    /// </summary>
    public class KERROR_Entity : EntityBase
    {
#region Navigation Property Cache
        private SPOUT_Entity _SPOUTKEY_SPOUT;
#endregion

#region Field Properties
        /// <summary>
        /// prime key [Integer (32bit signed): l]
        /// </summary>
        public int KERROR_ID { get; internal set; }
        /// <summary>
        /// Type of import/update eg PSD HRMS [Alphanumeric: a10]
        /// </summary>
        public string SOURCE { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT01 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT02 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT03 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT04 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT05 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT06 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT07 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT08 { get; internal set; }
        /// <summary>
        /// data elements in source file [Alphanumeric: a30]
        /// </summary>
        public string TEXT09 { get; internal set; }
        /// <summary>
        /// Error number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? VALIDATION { get; internal set; }
        /// <summary>
        /// Date/time when message processed by CASES21 [Date Time nullable: d]
        /// </summary>
        public DateTime? PROCESSED { get; internal set; }
        /// <summary>
        /// Either DEL = can be deleted or NEW [Alphanumeric: a3]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Error text [Memo: m]
        /// </summary>
        public string ERROR_TEXT { get; internal set; }
        /// <summary>
        /// Unique user session ID [Alphanumeric: a100]
        /// </summary>
        public string SPOUTKEY { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SPOUTKEY] => [SPOUT_Entity].[SPOUTKEY]
        /// Unique user session ID
        /// </summary>
        public SPOUT_Entity SPOUTKEY_SPOUT {
            get
            {
                if (SPOUTKEY != null)
                {
                    if (_SPOUTKEY_SPOUT == null)
                    {
                        _SPOUTKEY_SPOUT = Context.SPOUT.FindBySPOUTKEY(SPOUTKEY);
                    }
                    return _SPOUTKEY_SPOUT;
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
