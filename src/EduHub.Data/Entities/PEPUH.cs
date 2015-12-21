using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Super (SGL and Employee) History YTD Transactions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPUH : EduHubEntity
    {

        #region Navigation Property Cache

        private PE Cache_CODE_PE;
        private PI Cache_PAYITEM_PI;
        private PF Cache_SUPER_FUND_PF;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

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
        /// Pay item code
        /// </summary>
        public short? PAYITEM { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// Transaction period
        /// </summary>
        public int? TRPERD { get; internal set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Reference
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }

        /// <summary>
        /// Hours
        /// </summary>
        public double? TRQTY { get; internal set; }

        /// <summary>
        /// Detail
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// "G" = SGC levy "U" = Personal superannuation
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// This period's amount of pay
        /// </summary>
        public decimal? TRPAYAMT { get; internal set; }

        /// <summary>
        /// This period's super percentage
        /// </summary>
        public double? TRSUPER_PC { get; internal set; }

        /// <summary>
        /// This period's super amount
        /// </summary>
        public decimal? TRSUPER_AMT { get; internal set; }

        /// <summary>
        /// Super fund key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPER_FUND { get; internal set; }

        /// <summary>
        /// Super fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }

        /// <summary>
        /// For every transaction there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Transaction might belong to an Initiative
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

        /// <summary>
        /// PE (Employees) related entity by [PEPUH.CODE]-&gt;[PE.PEKEY]
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
        /// PI (Pay Items) related entity by [PEPUH.PAYITEM]-&gt;[PI.PIKEY]
        /// Pay item code
        /// </summary>
        public PI PAYITEM_PI
        {
            get
            {
                if (PAYITEM == null)
                {
                    return null;
                }
                if (Cache_PAYITEM_PI == null)
                {
                    Cache_PAYITEM_PI = Context.PI.FindByPIKEY(PAYITEM.Value);
                }

                return Cache_PAYITEM_PI;
            }
        }

        /// <summary>
        /// PF (Superannuation Funds) related entity by [PEPUH.SUPER_FUND]-&gt;[PF.PFKEY]
        /// Super fund key
        /// </summary>
        public PF SUPER_FUND_PF
        {
            get
            {
                if (SUPER_FUND == null)
                {
                    return null;
                }
                if (Cache_SUPER_FUND_PF == null)
                {
                    Cache_SUPER_FUND_PF = Context.PF.FindByPFKEY(SUPER_FUND);
                }

                return Cache_SUPER_FUND_PF;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [PEPUH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PEPUH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
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
