using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Notes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNOTE_CR : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CODE_CR;

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
        /// Creditor Key
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
        /// CR (Accounts Payable) related entity by [KNOTE_CR.CODE]-&gt;[CR.CRKEY]
        /// Creditor Key
        /// </summary>
        public CR CODE_CR
        {
            get
            {
                if (Cache_CODE_CR == null)
                {
                    Cache_CODE_CR = Context.CR.FindByCRKEY(CODE);
                }

                return Cache_CODE_CR;
            }
        }

        #endregion

    }
}
