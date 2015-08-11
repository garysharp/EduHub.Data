using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages
    /// </summary>
    public class KGST_Entity : EntityBase
    {
        /// <summary>
        /// Key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string KGSTKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a40]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Sales or Purchases (Capital or Ordinary) [Uppercase Alphanumeric: u2]
        /// </summary>
        public string SALE_PURCH { get; internal set; }
        /// <summary>
        /// Percentage of Tax [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// Any non null will include this in the BAS [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GST_BOX { get; internal set; }
        /// <summary>
        /// GST posting account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLGST_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [GLGST_CODE] => [GL_Entity].[CODE]
        /// GST posting account
        /// </summary>
        public GL_Entity GLGST_CODE_GL { get { return GLGST_CODE == null ? null : Context.GL.FindByCODE(GLGST_CODE); } }
        /// <summary>
        /// Input Claimed? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// GST code to be used for a correction to a prior period transaction [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PRIOR_PERIOD_GST { get; internal set; }
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
