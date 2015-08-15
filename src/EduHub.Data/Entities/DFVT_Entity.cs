using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Voluntary Transactions
    /// </summary>
    public class DFVT_Entity : EntityBase
    {
#region Navigation Property Cache
        private DF_Entity _FAMILY_DF;
        private KGST_Entity _GST_TYPE_KGST;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Family key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Ledger type GL,IV [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// GL or IV code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Transaction value [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Transaction description [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Amount before GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Equals TRAMT,added for
        /// compatibility with mixed batches [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// Amount of GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Relate to KGST [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// Rate of GST [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// What group does this belong to e.g. Building fund [Uppercase Alphanumeric: u2]
        /// </summary>
        public string GROUPING { get; internal set; }
        /// <summary>
        /// date TO CALULATE PAID FROM
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? FROM_DATE { get; internal set; }
        /// <summary>
        /// How to select this in receipting [Uppercase Alphanumeric: u2]
        /// </summary>
        public string SHORTCUT { get; internal set; }
        /// <summary>
        /// Appeal fund [Uppercase Alphanumeric: u10]
        /// </summary>
        public string APPEAL { get; internal set; }
        /// <summary>
        /// Only used for DN transactions [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
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
        /// Navigation property for [FAMILY] => [DF_Entity].[DFKEY]
        /// Family key
        /// </summary>
        public DF_Entity FAMILY_DF {
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
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// Relate to KGST
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
#endregion
    }
}
