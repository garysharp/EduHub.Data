using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SP2 dummy table
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBUDG : EduHubEntity
    {

        #region Navigation Property Cache

        private GLBUDG Cache_BKEY_GLBUDG;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// GLBUDG link
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string BKEY { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal? TRAMT { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// GLBUDG (General Ledger Budgets) related entity by [GLFBUDG.BKEY]-&gt;[GLBUDG.BUDGETKEY]
        /// GLBUDG link
        /// </summary>
        public GLBUDG BKEY_GLBUDG
        {
            get
            {
                if (Cache_BKEY_GLBUDG == null)
                {
                    Cache_BKEY_GLBUDG = Context.GLBUDG.FindByBUDGETKEY(BKEY);
                }

                return Cache_BKEY_GLBUDG;
            }
        }

        #endregion

    }
}
