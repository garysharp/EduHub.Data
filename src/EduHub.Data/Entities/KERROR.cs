using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KERROR : EduHubEntity
    {

        #region Navigation Property Cache

        private SPOUT Cache_SPOUTKEY_SPOUT;

        #endregion

        #region Field Properties

        /// <summary>
        /// prime key
        /// </summary>
        public int KERROR_ID { get; internal set; }

        /// <summary>
        /// Type of import/update eg PSD HRMS
        /// [Alphanumeric (10)]
        /// </summary>
        public string SOURCE { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT01 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT02 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT03 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT04 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT05 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT06 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT07 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT08 { get; internal set; }

        /// <summary>
        /// data elements in source file
        /// [Alphanumeric (30)]
        /// </summary>
        public string TEXT09 { get; internal set; }

        /// <summary>
        /// Error number
        /// </summary>
        public short? VALIDATION { get; internal set; }

        /// <summary>
        /// Date/time when message processed by CASES21
        /// </summary>
        public DateTime? PROCESSED { get; internal set; }

        /// <summary>
        /// Either DEL = can be deleted or NEW
        /// [Alphanumeric (3)]
        /// </summary>
        public string STATUS { get; internal set; }

        /// <summary>
        /// Error text
        /// [Memo]
        /// </summary>
        public string ERROR_TEXT { get; internal set; }

        /// <summary>
        /// Unique user session ID
        /// [Alphanumeric (100)]
        /// </summary>
        public string SPOUTKEY { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// SPOUT (Stored Procedure Return Values) related entity by [KERROR.SPOUTKEY]-&gt;[SPOUT.SPOUTKEY]
        /// Unique user session ID
        /// </summary>
        public SPOUT SPOUTKEY_SPOUT
        {
            get
            {
                if (SPOUTKEY == null)
                {
                    return null;
                }
                if (Cache_SPOUTKEY_SPOUT == null)
                {
                    Cache_SPOUTKEY_SPOUT = Context.SPOUT.FindBySPOUTKEY(SPOUTKEY);
                }

                return Cache_SPOUTKEY_SPOUT;
            }
        }

        #endregion

    }
}
