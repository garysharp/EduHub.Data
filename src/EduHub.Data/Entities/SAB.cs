using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees - Billing Templates
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAB : EduHubEntity
    {

        #region Navigation Property Cache

        private SA Cache_FEE_CODE_1ST_SA;
        private SA Cache_FEE_CODE_2ND_SA;
        private SA Cache_FEE_CODE_3RD_SA;
        private SA Cache_FEE_CODE_4TH_SA;
        private SA Cache_FEE_CODE_KG_SA;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SABT> Cache_SABKEY_SABT_SABTKEY;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Billing key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SABKEY { get; internal set; }

        /// <summary>
        /// Billing title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Billing type: Student, Class, Family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string BILL_TYPE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FROM_CLASS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TO_CLASS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FROM_YEAR { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TO_YEAR { get; internal set; }

        /// <summary>
        /// Non-overseas(N) or Overseas(O)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RES_STATUS { get; internal set; }

        /// <summary>
        /// Fee code for the 1st child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_1ST { get; internal set; }

        /// <summary>
        /// Fee code for the 2nd child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_2ND { get; internal set; }

        /// <summary>
        /// Fee code for the 3rd child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_3RD { get; internal set; }

        /// <summary>
        /// Fee code for the 4th child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_4TH { get; internal set; }

        /// <summary>
        /// Fee code for the Kindergarten child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_KG { get; internal set; }

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
        /// SA (Fees) related entity by [SAB.FEE_CODE_1ST]-&gt;[SA.SAKEY]
        /// Fee code for the 1st child
        /// </summary>
        public SA FEE_CODE_1ST_SA
        {
            get
            {
                if (FEE_CODE_1ST == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_1ST_SA == null)
                {
                    Cache_FEE_CODE_1ST_SA = Context.SA.FindBySAKEY(FEE_CODE_1ST);
                }

                return Cache_FEE_CODE_1ST_SA;
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [SAB.FEE_CODE_2ND]-&gt;[SA.SAKEY]
        /// Fee code for the 2nd child
        /// </summary>
        public SA FEE_CODE_2ND_SA
        {
            get
            {
                if (FEE_CODE_2ND == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_2ND_SA == null)
                {
                    Cache_FEE_CODE_2ND_SA = Context.SA.FindBySAKEY(FEE_CODE_2ND);
                }

                return Cache_FEE_CODE_2ND_SA;
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [SAB.FEE_CODE_3RD]-&gt;[SA.SAKEY]
        /// Fee code for the 3rd child
        /// </summary>
        public SA FEE_CODE_3RD_SA
        {
            get
            {
                if (FEE_CODE_3RD == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_3RD_SA == null)
                {
                    Cache_FEE_CODE_3RD_SA = Context.SA.FindBySAKEY(FEE_CODE_3RD);
                }

                return Cache_FEE_CODE_3RD_SA;
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [SAB.FEE_CODE_4TH]-&gt;[SA.SAKEY]
        /// Fee code for the 4th child
        /// </summary>
        public SA FEE_CODE_4TH_SA
        {
            get
            {
                if (FEE_CODE_4TH == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_4TH_SA == null)
                {
                    Cache_FEE_CODE_4TH_SA = Context.SA.FindBySAKEY(FEE_CODE_4TH);
                }

                return Cache_FEE_CODE_4TH_SA;
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [SAB.FEE_CODE_KG]-&gt;[SA.SAKEY]
        /// Fee code for the Kindergarten child
        /// </summary>
        public SA FEE_CODE_KG_SA
        {
            get
            {
                if (FEE_CODE_KG == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_KG_SA == null)
                {
                    Cache_FEE_CODE_KG_SA = Context.SA.FindBySAKEY(FEE_CODE_KG);
                }

                return Cache_FEE_CODE_KG_SA;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SABT (Billing Template Transactions) related entities by [SAB.SABKEY]-&gt;[SABT.SABTKEY]
        /// Billing key
        /// </summary>
        public IReadOnlyList<SABT> SABKEY_SABT_SABTKEY
        {
            get
            {
                if (Cache_SABKEY_SABT_SABTKEY == null &&
                    !Context.SABT.TryFindBySABTKEY(SABKEY, out Cache_SABKEY_SABT_SABTKEY))
                {
                    Cache_SABKEY_SABT_SABTKEY = new List<SABT>().AsReadOnly();
                }

                return Cache_SABKEY_SABT_SABTKEY;
            }
        }

        #endregion

    }
}
