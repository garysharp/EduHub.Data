using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fees
    /// </summary>
    public class SDFC_Entity : EntityBase
    {
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SDFCKEY { get; internal set; }
        /// <summary>
        /// Fees table title [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Group for reports only [Alphanumeric: a10]
        /// </summary>
        public string SDGROUP { get; internal set; }
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
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GROSS_AMOUNT { get; internal set; }
        /// <summary>
        /// One GL key for each category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Navigation property for [GLCODE] => [GL_Entity].[CODE]
        /// One GL key for each category
        /// </summary>
        public GL_Entity GLCODE_GL { get { return GLCODE == null ? null : Context.GL.FindByCODE(GLCODE); } }
        /// <summary>
        /// What GST applies to this fee [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// What GST applies to this fee
        /// </summary>
        public KGST_Entity GST_TYPE_KGST { get { return GST_TYPE == null ? null : Context.KGST.FindByKGSTKEY(GST_TYPE); } }
        /// <summary>
        /// For every fee there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every fee there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB { get { return SUBPROGRAM == null ? null : Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM); } }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Fee might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Fee might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT { get { return INITIATIVE == null ? null : Context.KGLINIT.FindByINITIATIVE(INITIATIVE); } }
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
        
        
    }
}
