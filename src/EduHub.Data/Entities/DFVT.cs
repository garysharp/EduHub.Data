﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Voluntary Transactions
    /// </summary>
    public class DFVT : EntityBase
    {
#region Navigation Property Cache
        private DF _FAMILY_DF;
        private KGST _GST_TYPE_KGST;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Family key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Ledger type GL,IV
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// GL or IV code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Transaction value
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Transaction description
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Amount before GST
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Equals TRAMT,added for
        /// compatibility with mixed batches
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// Amount of GST
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Relate to KGST
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// Rate of GST
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// What group does this belong to e.g. Building fund
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string GROUPING { get; internal set; }
        /// <summary>
        /// date TO CALULATE PAID FROM
        /// 
        /// </summary>
        public DateTime? FROM_DATE { get; internal set; }
        /// <summary>
        /// How to select this in receipting
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SHORTCUT { get; internal set; }
        /// <summary>
        /// Appeal fund
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string APPEAL { get; internal set; }
        /// <summary>
        /// Only used for DN transactions
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }
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
        /// Navigation property for [FAMILY] => [DF].[DFKEY]
        /// Family key
        /// </summary>
        public DF FAMILY_DF {
            get
            {
                if (FAMILY != null)
                {
                    if (_FAMILY_DF == null)
                    {
                        _FAMILY_DF = Context.DF.FindByDFKEY(FAMILY);
                    }
                    return _FAMILY_DF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GST_TYPE] => [KGST].[KGSTKEY]
        /// Relate to KGST
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
#endregion
    }
}