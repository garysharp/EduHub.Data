using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Data Export
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FDT_EXP : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_DEST_SKGS;

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
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string DEST { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string DEST_ID { get; internal set; }

        /// <summary>
        /// Table/Type of Fin data (CR,DR,PE etc)
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SOURCE { get; internal set; }

        /// <summary>
        /// Source Record Key  (CRKEY, DRKEY, PEKEY etc)
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SOURCE_KEY { get; internal set; }

        /// <summary>
        /// Export Comment
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }

        /// <summary>
        /// Date exported to disk
        /// </summary>
        public DateTime? EXP_DATE { get; internal set; }

        /// <summary>
        /// Time exported to disk
        /// </summary>
        public short? EXP_TIME { get; internal set; }

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
        /// SKGS (Schools) related entity by [FDT_EXP.DEST]-&gt;[SKGS.SCHOOL]
        /// &lt;No documentation available&gt;
        /// </summary>
        public SKGS DEST_SKGS
        {
            get
            {
                if (Cache_DEST_SKGS == null)
                {
                    Cache_DEST_SKGS = Context.SKGS.FindBySCHOOL(DEST);
                }

                return Cache_DEST_SKGS;
            }
        }

        #endregion

    }
}
