using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees
    /// </summary>
    public partial class SA : EntityBase
    {
#region Navigation Property Cache
        private GL _GLCODE_GL;
        private KGST _GST_TYPE_KGST;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

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
        /// 
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
                if (GLCODE != null)
                {
                    if (_GLCODE_GL == null)
                    {
                        _GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                    }
                    return _GLCODE_GL;
                }
                else
                {
                    return null;
                }
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
                if (GST_TYPE != null)
                {
                    if (_GST_TYPE_KGST == null)
                    {
                        _GST_TYPE_KGST = Context.KGST.FindByKGSTKEY(GST_TYPE);
                    }
                    return _GST_TYPE_KGST;
                }
                else
                {
                    return null;
                }
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
                if (SUBPROGRAM != null)
                {
                    if (_SUBPROGRAM_KGLSUB == null)
                    {
                        _SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                    }
                    return _SUBPROGRAM_KGLSUB;
                }
                else
                {
                    return null;
                }
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
                if (INITIATIVE != null)
                {
                    if (_INITIATIVE_KGLINIT == null)
                    {
                        _INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                    }
                    return _INITIATIVE_KGLINIT;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DFF.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<DFF> DFF_FEE_CODE
        {
            get
            {
                return Context.SA.FindDFFByFEE_CODE(SAKEY);
            }
        }

        /// <summary>
        /// DR (Accounts Receivable) related entities by [DR.DRTABLEA]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<DR> DR_DRTABLEA
        {
            get
            {
                return Context.SA.FindDRByDRTABLEA(SAKEY);
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SAB.FEE_CODE_1ST]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SAB> SAB_FEE_CODE_1ST
        {
            get
            {
                return Context.SA.FindSABByFEE_CODE_1ST(SAKEY);
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SAB.FEE_CODE_2ND]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SAB> SAB_FEE_CODE_2ND
        {
            get
            {
                return Context.SA.FindSABByFEE_CODE_2ND(SAKEY);
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SAB.FEE_CODE_3RD]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SAB> SAB_FEE_CODE_3RD
        {
            get
            {
                return Context.SA.FindSABByFEE_CODE_3RD(SAKEY);
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SAB.FEE_CODE_4TH]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SAB> SAB_FEE_CODE_4TH
        {
            get
            {
                return Context.SA.FindSABByFEE_CODE_4TH(SAKEY);
            }
        }

        /// <summary>
        /// SAB (Fees - Billing Templates) related entities by [SAB.FEE_CODE_KG]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SAB> SAB_FEE_CODE_KG
        {
            get
            {
                return Context.SA.FindSABByFEE_CODE_KG(SAKEY);
            }
        }

        /// <summary>
        /// SABT (Billing Template Transactions) related entities by [SABT.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SABT> SABT_FEE_CODE
        {
            get
            {
                return Context.SA.FindSABTByFEE_CODE(SAKEY);
            }
        }

        /// <summary>
        /// STSB (Family Invoice Allocations) related entities by [STSB.SPLIT_ITEM]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<STSB> STSB_SPLIT_ITEM
        {
            get
            {
                return Context.SA.FindSTSBBySPLIT_ITEM(SAKEY);
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [SU.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        public IReadOnlyList<SU> SU_FEE_CODE
        {
            get
            {
                return Context.SA.FindSUByFEE_CODE(SAKEY);
            }
        }
#endregion
    }
}
