using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Notes and Attachments
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STNAT : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private KNATT Cache_NOTE_TYPE_KNATT;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Original student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Note type
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string NOTE_TYPE { get; internal set; }

        /// <summary>
        /// Student note description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Remark / comment
        /// [Memo]
        /// </summary>
        public string REMARK { get; internal set; }

        /// <summary>
        /// The attachment
        /// </summary>
        public byte[] ATTACHMENT { get; internal set; }

        /// <summary>
        /// Default to date of attachment
        /// </summary>
        public DateTime? ATTACH_DATE { get; internal set; }

        /// <summary>
        /// User who added the record
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string ADDED_BY { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [STNAT.SKEY]-&gt;[ST.STKEY]
        /// Original student key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (Cache_SKEY_ST == null)
                {
                    Cache_SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                }

                return Cache_SKEY_ST;
            }
        }

        /// <summary>
        /// KNATT (Notes and Attachment Type) related entity by [STNAT.NOTE_TYPE]-&gt;[KNATT.KNATTKEY]
        /// Note type
        /// </summary>
        public KNATT NOTE_TYPE_KNATT
        {
            get
            {
                if (NOTE_TYPE == null)
                {
                    return null;
                }
                if (Cache_NOTE_TYPE_KNATT == null)
                {
                    Cache_NOTE_TYPE_KNATT = Context.KNATT.FindByKNATTKEY(NOTE_TYPE);
                }

                return Cache_NOTE_TYPE_KNATT;
            }
        }

        #endregion

    }
}
