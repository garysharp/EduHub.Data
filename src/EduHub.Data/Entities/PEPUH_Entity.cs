using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Super (SGL and Employee) History YTD Transactions
    /// </summary>
    public class PEPUH_Entity : EntityBase
    {
#region Navigation Property Cache
        private PE_Entity _CODE_PE;
        private PI_Entity _PAYITEM_PI;
        private PF_Entity _SUPER_FUND_PF;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Pay item code [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PAYITEM { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Transaction period [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Reference [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Detail [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// "G" = SGC levy "U" = Personal superannuation [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// This period's amount of pay [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRPAYAMT { get; internal set; }
        /// <summary>
        /// This period's super percentage [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRSUPER_PC { get; internal set; }
        /// <summary>
        /// This period's super amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRSUPER_AMT { get; internal set; }
        /// <summary>
        /// Super fund key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [PE_Entity].[PEKEY]
        /// Employee code
        /// </summary>
        public PE_Entity CODE_PE {
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
        /// Navigation property for [PAYITEM] => [PI_Entity].[PIKEY]
        /// Pay item code
        /// </summary>
        public PI_Entity PAYITEM_PI {
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
        /// Navigation property for [SUPER_FUND] => [PF_Entity].[PFKEY]
        /// Super fund key
        /// </summary>
        public PF_Entity SUPER_FUND_PF {
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
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB {
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
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT {
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
