#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Purchase Requisition Transaction
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQT : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private RQ Cache_TRORDER_RQ;
#endif
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

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
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Requisition number being satisfied
        /// </summary>
        public int TRORDER { get; internal set; }

        /// <summary>
        /// Requisition detail
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// Requisition quantity
        /// </summary>
        public int? TRQTY { get; internal set; }

        /// <summary>
        /// Requisition cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }

        /// <summary>
        /// Requisition trnett
        /// </summary>
        public decimal? TRAMT { get; internal set; }

        /// <summary>
        /// GL code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }

        /// <summary>
        /// Must already exist as a SUBPROGRAM
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// Not mandatory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// RQ (Purchase Requisition) related entity by [RQT.TRORDER]-&gt;[RQ.TRORDER]
        /// Requisition number being satisfied
        /// </summary>
        public RQ TRORDER_RQ
        {
            get
            {
                if (Cache_TRORDER_RQ == null)
                {
                    Cache_TRORDER_RQ = Context.RQ.FindByTRORDER(TRORDER);
                }

                return Cache_TRORDER_RQ;
            }
        }

#endif
        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [RQT.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// Must already exist as a SUBPROGRAM
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
        /// KGLINIT (General Ledger Initiatives) related entity by [RQT.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Not mandatory
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

    }
}
#endif
