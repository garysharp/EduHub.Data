using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee History
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPY : EduHubEntity
    {

        #region Navigation Property Cache

        private PE Cache_CODE_PE;
        private KPN Cache_PURPOSE_KPN;

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
        /// Transaction ID (unique)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? TRANSDATE { get; internal set; }

        /// <summary>
        /// Originator
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STAFF { get; internal set; }

        /// <summary>
        /// Generic purpose for notes
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PURPOSE { get; internal set; }

        /// <summary>
        /// Employee notes
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }

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
        /// PE (Employees) related entity by [PEPY.CODE]-&gt;[PE.PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE
        {
            get
            {
                if (Cache_CODE_PE == null)
                {
                    Cache_CODE_PE = Context.PE.FindByPEKEY(CODE);
                }

                return Cache_CODE_PE;
            }
        }

        /// <summary>
        /// KPN (Note Categories) related entity by [PEPY.PURPOSE]-&gt;[KPN.KPNKEY]
        /// Generic purpose for notes
        /// </summary>
        public KPN PURPOSE_KPN
        {
            get
            {
                if (PURPOSE == null)
                {
                    return null;
                }
                if (Cache_PURPOSE_KPN == null)
                {
                    Cache_PURPOSE_KPN = Context.KPN.FindByKPNKEY(PURPOSE);
                }

                return Cache_PURPOSE_KPN;
            }
        }

        #endregion

    }
}
