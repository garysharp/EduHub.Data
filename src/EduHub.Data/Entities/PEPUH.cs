using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Super (SGL and Employee) History YTD Transactions
    /// </summary>
    public class PEPUH : EntityBase
    {
#region Navigation Property Cache
        private PE _CODE_PE;
        private PI _PAYITEM_PI;
        private PF _SUPER_FUND_PF;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique)
        /// </summary>
        public int? TID { get; internal set; }
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
        /// Navigation property for [CODE] => [PE].[PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_PE == null)
                    {
                        _CODE_PE = Context.PE.FindByPEKEY(CODE);
                    }
                    return _CODE_PE;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PAYITEM] => [PI].[PIKEY]
        /// Pay item code
        /// </summary>
        public PI PAYITEM_PI {
            get
            {
                if (PAYITEM.HasValue)
                {
                    if (_PAYITEM_PI == null)
                    {
                        _PAYITEM_PI = Context.PI.FindByPIKEY(PAYITEM.Value);
                    }
                    return _PAYITEM_PI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUPER_FUND] => [PF].[PFKEY]
        /// Super fund key
        /// </summary>
        public PF SUPER_FUND_PF {
            get
            {
                if (SUPER_FUND != null)
                {
                    if (_SUPER_FUND_PF == null)
                    {
                        _SUPER_FUND_PF = Context.PF.FindByPFKEY(SUPER_FUND);
                    }
                    return _SUPER_FUND_PF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB {
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
        /// Navigation property for [INITIATIVE] => [KGLINIT].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT {
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
#endregion
    }
}
