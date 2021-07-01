using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SA : EduHubEntity
    {

        #region Navigation Property Cache

        private GL Cache_GLCODE_GL;
        private KGST Cache_GST_TYPE_KGST;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<DFF> Cache_SAKEY_DFF_FEE_CODE;
        private IReadOnlyList<DR> Cache_SAKEY_DR_DRTABLEA;
        private IReadOnlyList<SAB> Cache_SAKEY_SAB_FEE_CODE_1ST;
        private IReadOnlyList<SAB> Cache_SAKEY_SAB_FEE_CODE_2ND;
        private IReadOnlyList<SAB> Cache_SAKEY_SAB_FEE_CODE_3RD;
        private IReadOnlyList<SAB> Cache_SAKEY_SAB_FEE_CODE_4TH;
        private IReadOnlyList<SAB> Cache_SAKEY_SAB_FEE_CODE_KG;
        private IReadOnlyList<SABT> Cache_SAKEY_SABT_FEE_CODE;
        private IReadOnlyList<STSB> Cache_SAKEY_STSB_SPLIT_ITEM;
        private IReadOnlyList<SU> Cache_SAKEY_SU_FEE_CODE;

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
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SAKEY { get; internal set; }

        /// <summary>
        /// Fees table title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Group for reports only
        /// [Alphanumeric (10)]
        /// </summary>
        public string SAGROUP { get; internal set; }

        /// <summary>
        /// Fees tables to be used for auto transactions?
        /// [Alphanumeric (1)]
        /// </summary>
        public string STATEMENT { get; internal set; }

        /// <summary>
        /// Method of fees calculation
        /// [Alphanumeric (1)]
        /// </summary>
        public string METHOD { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? AMOUNT { get; internal set; }

        /// <summary>
        /// Added for DE&amp;T AEGIS 5695
        /// </summary>
        public decimal? GROSS_AMOUNT { get; internal set; }

        /// <summary>
        /// One GL key for each category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// Frequency of billing
        /// </summary>
        public short? FREQUENCY { get; internal set; }

        /// <summary>
        /// What GST applies to this fee
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }

        /// <summary>
        /// For every fee there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Fee might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// Fee is voluntary or compulsory
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VOLUNTARY { get; internal set; }

        /// <summary>
        /// Enable split billing Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SPLIT_BILLING { get; internal set; }

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
        /// GL (General Ledger) related entity by [SA.GLCODE]-&gt;[GL.CODE]
        /// One GL key for each category
        /// </summary>
        public GL GLCODE_GL
        {
            get
            {
                if (GLCODE == null)
                {
                    return null;
                }
                if (Cache_GLCODE_GL == null)
                {
                    Cache_GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                }

                return Cache_GLCODE_GL;
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entity by [SA.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// What GST applies to this fee
        /// </summary>
        public KGST GST_TYPE_KGST
        {
            get
            {
                if (GST_TYPE == null)
                {
                    return null;
                }
                if (Cache_GST_TYPE_KGST == null)
                {
                    Cache_GST_TYPE_KGST = Context.KGST.FindByKGSTKEY(GST_TYPE);
                }

                return Cache_GST_TYPE_KGST;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [SA.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every fee there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
            get
            {
                if (SUBPROGRAM == null)
                {
                    return null;
                }
                if (Cache_SUBPROGRAM_KGLSUB == null)
                {
                    Cache_SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                }

                return Cache_SUBPROGRAM_KGLSUB;
            }
        }

        /// <summary>
        /// KGLINIT (General Ledger Initiatives) related entity by [SA.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Fee might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
            get
            {
                if (INITIATIVE == null)
                {
                    return null;
                }
                if (Cache_INITIATIVE_KGLINIT == null)
                {
                    Cache_INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                }

                return Cache_INITIATIVE_KGLINIT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [SA.SAKEY]-&gt;[DFF.FEE_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DFF> SAKEY_DFF_FEE_CODE
        {
            get
            {
                if (Cache_SAKEY_DFF_FEE_CODE == null &&
                    !Context.DFF.TryFindByFEE_CODE(SAKEY, out Cache_SAKEY_DFF_FEE_CODE))
                {
                    Cache_SAKEY_DFF_FEE_CODE = new List<DFF>().AsReadOnly();
                }

                return Cache_SAKEY_DFF_FEE_CODE;
            }
        }

        /// <summary>
        /// DR (Accounts Receivable) related entities by [SA.SAKEY]-&gt;[DR.DRTABLEA]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DR> SAKEY_DR_DRTABLEA
        {
            get
            {
                if (Cache_SAKEY_DR_DRTABLEA == null &&
                    !Context.DR.TryFindByDRTABLEA(SAKEY, out Cache_SAKEY_DR_DRTABLEA))
                {
                    Cache_SAKEY_DR_DRTABLEA = new List<DR>().AsReadOnly();
                }

                return Cache_SAKEY_DR_DRTABLEA;
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SA.SAKEY]-&gt;[SAB.FEE_CODE_1ST]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SAB> SAKEY_SAB_FEE_CODE_1ST
        {
            get
            {
                if (Cache_SAKEY_SAB_FEE_CODE_1ST == null &&
                    !Context.SAB.TryFindByFEE_CODE_1ST(SAKEY, out Cache_SAKEY_SAB_FEE_CODE_1ST))
                {
                    Cache_SAKEY_SAB_FEE_CODE_1ST = new List<SAB>().AsReadOnly();
                }

                return Cache_SAKEY_SAB_FEE_CODE_1ST;
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SA.SAKEY]-&gt;[SAB.FEE_CODE_2ND]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SAB> SAKEY_SAB_FEE_CODE_2ND
        {
            get
            {
                if (Cache_SAKEY_SAB_FEE_CODE_2ND == null &&
                    !Context.SAB.TryFindByFEE_CODE_2ND(SAKEY, out Cache_SAKEY_SAB_FEE_CODE_2ND))
                {
                    Cache_SAKEY_SAB_FEE_CODE_2ND = new List<SAB>().AsReadOnly();
                }

                return Cache_SAKEY_SAB_FEE_CODE_2ND;
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SA.SAKEY]-&gt;[SAB.FEE_CODE_3RD]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SAB> SAKEY_SAB_FEE_CODE_3RD
        {
            get
            {
                if (Cache_SAKEY_SAB_FEE_CODE_3RD == null &&
                    !Context.SAB.TryFindByFEE_CODE_3RD(SAKEY, out Cache_SAKEY_SAB_FEE_CODE_3RD))
                {
                    Cache_SAKEY_SAB_FEE_CODE_3RD = new List<SAB>().AsReadOnly();
                }

                return Cache_SAKEY_SAB_FEE_CODE_3RD;
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SA.SAKEY]-&gt;[SAB.FEE_CODE_4TH]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SAB> SAKEY_SAB_FEE_CODE_4TH
        {
            get
            {
                if (Cache_SAKEY_SAB_FEE_CODE_4TH == null &&
                    !Context.SAB.TryFindByFEE_CODE_4TH(SAKEY, out Cache_SAKEY_SAB_FEE_CODE_4TH))
                {
                    Cache_SAKEY_SAB_FEE_CODE_4TH = new List<SAB>().AsReadOnly();
                }

                return Cache_SAKEY_SAB_FEE_CODE_4TH;
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SA.SAKEY]-&gt;[SAB.FEE_CODE_KG]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SAB> SAKEY_SAB_FEE_CODE_KG
        {
            get
            {
                if (Cache_SAKEY_SAB_FEE_CODE_KG == null &&
                    !Context.SAB.TryFindByFEE_CODE_KG(SAKEY, out Cache_SAKEY_SAB_FEE_CODE_KG))
                {
                    Cache_SAKEY_SAB_FEE_CODE_KG = new List<SAB>().AsReadOnly();
                }

                return Cache_SAKEY_SAB_FEE_CODE_KG;
            }
        }

        /// <summary>
        /// SABT (Billing Template Transactions) related entities by [SA.SAKEY]-&gt;[SABT.FEE_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SABT> SAKEY_SABT_FEE_CODE
        {
            get
            {
                if (Cache_SAKEY_SABT_FEE_CODE == null &&
                    !Context.SABT.TryFindByFEE_CODE(SAKEY, out Cache_SAKEY_SABT_FEE_CODE))
                {
                    Cache_SAKEY_SABT_FEE_CODE = new List<SABT>().AsReadOnly();
                }

                return Cache_SAKEY_SABT_FEE_CODE;
            }
        }

        /// <summary>
        /// STSB (Family Invoice Allocations) related entities by [SA.SAKEY]-&gt;[STSB.SPLIT_ITEM]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<STSB> SAKEY_STSB_SPLIT_ITEM
        {
            get
            {
                if (Cache_SAKEY_STSB_SPLIT_ITEM == null &&
                    !Context.STSB.TryFindBySPLIT_ITEM(SAKEY, out Cache_SAKEY_STSB_SPLIT_ITEM))
                {
                    Cache_SAKEY_STSB_SPLIT_ITEM = new List<STSB>().AsReadOnly();
                }

                return Cache_SAKEY_STSB_SPLIT_ITEM;
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [SA.SAKEY]-&gt;[SU.FEE_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SU> SAKEY_SU_FEE_CODE
        {
            get
            {
                if (Cache_SAKEY_SU_FEE_CODE == null &&
                    !Context.SU.TryFindByFEE_CODE(SAKEY, out Cache_SAKEY_SU_FEE_CODE))
                {
                    Cache_SAKEY_SU_FEE_CODE = new List<SU>().AsReadOnly();
                }

                return Cache_SAKEY_SU_FEE_CODE;
            }
        }

        #endregion

    }
}
