using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees
    /// </summary>
    public class SA : EntityBase
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
        /// Navigation property for [GLCODE] => [GL].[CODE]
        /// One GL key for each category
        /// </summary>
        public GL GLCODE_GL {
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
        /// Navigation property for [GST_TYPE] => [KGST].[KGSTKEY]
        /// What GST applies to this fee
        /// </summary>
        public KGST GST_TYPE_KGST {
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
        /// Navigation property for [SUBPROGRAM] => [KGLSUB].[SUBPROGRAM]
        /// For every fee there is a subprogram
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
        /// Fee might belong to an Initiative
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
