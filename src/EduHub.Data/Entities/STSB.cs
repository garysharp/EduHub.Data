using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Invoice Allocations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSB : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private DF Cache_FAMILY_DF;
        private SA Cache_SPLIT_ITEM_SA;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Family key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMILY { get; internal set; }

        /// <summary>
        /// Percentage of transaction amount to split for family
        /// </summary>
        public short? PERCENTAGE { get; internal set; }

        /// <summary>
        /// Item that the family pays
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SPLIT_ITEM { get; internal set; }

        /// <summary>
        /// only F - Fee code
        /// [Alphanumeric (1)]
        /// </summary>
        public string ITEM_TYPE { get; internal set; }

        /// <summary>
        /// Used to relate the subject code. Not used in CASES21.
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SPLIT_ITEM_SU { get; internal set; }

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
        /// ST (Students) related entity by [STSB.SKEY]-&gt;[ST.STKEY]
        /// Student key
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
        /// DF (Families) related entity by [STSB.FAMILY]-&gt;[DF.DFKEY]
        /// Family key
        /// </summary>
        public DF FAMILY_DF
        {
            get
            {
                if (FAMILY == null)
                {
                    return null;
                }
                if (Cache_FAMILY_DF == null)
                {
                    Cache_FAMILY_DF = Context.DF.FindByDFKEY(FAMILY);
                }

                return Cache_FAMILY_DF;
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [STSB.SPLIT_ITEM]-&gt;[SA.SAKEY]
        /// Item that the family pays
        /// </summary>
        public SA SPLIT_ITEM_SA
        {
            get
            {
                if (SPLIT_ITEM == null)
                {
                    return null;
                }
                if (Cache_SPLIT_ITEM_SA == null)
                {
                    Cache_SPLIT_ITEM_SA = Context.SA.FindBySAKEY(SPLIT_ITEM);
                }

                return Cache_SPLIT_ITEM_SA;
            }
        }

        #endregion

    }
}
