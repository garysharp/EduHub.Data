using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Debtor Notes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNOTE_DR : EduHubEntity
    {

        #region Navigation Property Cache

        private DR Cache_CODE_DR;

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
        /// Debtor Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime? NOTE_DATE { get; internal set; }

        /// <summary>
        /// Notes
        /// [Memo]
        /// </summary>
        public string NOTE_MEMO { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last user name
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// DR (Accounts Receivable) related entity by [KNOTE_DR.CODE]-&gt;[DR.DRKEY]
        /// Debtor Key
        /// </summary>
        public DR CODE_DR
        {
            get
            {
                if (Cache_CODE_DR == null)
                {
                    Cache_CODE_DR = Context.DR.FindByDRKEY(CODE);
                }

                return Cache_CODE_DR;
            }
        }

        #endregion

    }
}
