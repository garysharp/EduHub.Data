using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages
    /// </summary>
    public class KGST : EntityBase
    {
#region Navigation Property Cache
        private GL _GLGST_CODE_GL;
#endregion

#region Field Properties
        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string KGSTKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Sales or Purchases (Capital or Ordinary)
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SALE_PURCH { get; internal set; }
        /// <summary>
        /// Percentage of Tax
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// Any non null will include this in the BAS
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GST_BOX { get; internal set; }
        /// <summary>
        /// GST posting account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLGST_CODE { get; internal set; }
        /// <summary>
        /// Input Claimed?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// GST code to be used for a correction to a prior period transaction
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PRIOR_PERIOD_GST { get; internal set; }
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
        /// Navigation property for [GLGST_CODE] => [GL].[CODE]
        /// GST posting account
        /// </summary>
        public GL GLGST_CODE_GL {
            get
            {
                if (GLGST_CODE != null)
                {
                    if (_GLGST_CODE_GL == null)
                    {
                        _GLGST_CODE_GL = Context.GL.FindByCODE(GLGST_CODE);
                    }
                    return _GLGST_CODE_GL;
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
