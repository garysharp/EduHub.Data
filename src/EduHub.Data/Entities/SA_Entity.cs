using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees
    /// </summary>
    public class SA_Entity : EntityBase
    {
#region Navigation Property Cache
        private GL_Entity _GLCODE_GL;
        private KGST_Entity _GST_TYPE_KGST;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SAKEY { get; internal set; }
        /// <summary>
        /// Fees table title [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Group for reports only [Alphanumeric: a10]
        /// </summary>
        public string SAGROUP { get; internal set; }
        /// <summary>
        /// Fees tables to be used for auto transactions? [Alphanumeric: a1]
        /// </summary>
        public string STATEMENT { get; internal set; }
        /// <summary>
        /// Method of fees calculation [Alphanumeric: a1]
        /// </summary>
        public string METHOD { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// Added for DE&T AEGIS 5695 [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GROSS_AMOUNT { get; internal set; }
        /// <summary>
        /// One GL key for each category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Frequency of billing [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FREQUENCY { get; internal set; }
        /// <summary>
        /// What GST applies to this fee [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// For every fee there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Fee might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Fee is voluntary or compulsory [Uppercase Alphanumeric: u1]
        /// </summary>
        public string VOLUNTARY { get; internal set; }
        /// <summary>
        /// Enable split billing Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SPLIT_BILLING { get; internal set; }
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
        /// Navigation property for [GLCODE] => [GL_Entity].[CODE]
        /// One GL key for each category
        /// </summary>
        public GL_Entity GLCODE_GL {
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
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// What GST applies to this fee
        /// </summary>
        public KGST_Entity GST_TYPE_KGST {
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
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every fee there is a subprogram
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
        /// Fee might belong to an Initiative
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
