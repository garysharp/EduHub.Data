using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Positions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAP : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SAM> Cache_SAPKEY_SAM_ASSOC_POSN;

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
        /// Association position code
        /// [Uppercase Alphanumeric (25)]
        /// </summary>
        public string SAPKEY { get; internal set; }

        /// <summary>
        /// Association position long name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Field for sorting
        /// </summary>
        public short? SORT_CODE { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// SAM (School Association Members) related entities by [SAP.SAPKEY]-&gt;[SAM.ASSOC_POSN]
        /// Association position code
        /// </summary>
        public IReadOnlyList<SAM> SAPKEY_SAM_ASSOC_POSN
        {
            get
            {
                if (Cache_SAPKEY_SAM_ASSOC_POSN == null &&
                    !Context.SAM.TryFindByASSOC_POSN(SAPKEY, out Cache_SAPKEY_SAM_ASSOC_POSN))
                {
                    Cache_SAPKEY_SAM_ASSOC_POSN = new List<SAM>().AsReadOnly();
                }

                return Cache_SAPKEY_SAM_ASSOC_POSN;
            }
        }

        #endregion

    }
}
