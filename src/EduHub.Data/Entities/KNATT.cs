using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Notes and Attachment Type
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNATT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<STNAT> Cache_KNATTKEY_STNAT_NOTE_TYPE;

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
        /// Note key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KNATTKEY { get; internal set; }

        /// <summary>
        /// Note type description
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// STNAT (Student Notes and Attachments) related entities by [KNATT.KNATTKEY]-&gt;[STNAT.NOTE_TYPE]
        /// Note key
        /// </summary>
        public IReadOnlyList<STNAT> KNATTKEY_STNAT_NOTE_TYPE
        {
            get
            {
                if (Cache_KNATTKEY_STNAT_NOTE_TYPE == null &&
                    !Context.STNAT.TryFindByNOTE_TYPE(KNATTKEY, out Cache_KNATTKEY_STNAT_NOTE_TYPE))
                {
                    Cache_KNATTKEY_STNAT_NOTE_TYPE = new List<STNAT>().AsReadOnly();
                }

                return Cache_KNATTKEY_STNAT_NOTE_TYPE;
            }
        }

        #endregion

    }
}
