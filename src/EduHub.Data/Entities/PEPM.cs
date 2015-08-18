using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Methods
    /// </summary>
    public class PEPM : EntityBase
    {
#region Navigation Property Cache
        private PE _CODE_PE;
        private KAB _BSB_KAB;
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
        /// Bank Account name
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string NAME { get; internal set; }
        /// <summary>
        /// CA = Cash
        /// CH = Cheque
        /// DD = Direct Debit
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string PAYMODE { get; internal set; }
        /// <summary>
        /// Reference number for CH or DD
        /// [Alphanumeric (20)]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }
        /// <summary>
        /// Temporary value
        /// 
        /// [Alphanumeric (10)]
        /// </summary>
        public string CHQ_NO { get; internal set; }
        /// <summary>
        /// Default amount
        /// </summary>
        public decimal? DAMOUNT { get; internal set; }
        /// <summary>
        /// Bank name
        /// [Alphanumeric (12)]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Bank-state-branch as BBBBBB
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Account number
        /// [Alphanumeric (15)]
        /// </summary>
        public string ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Actual amount
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// S = Standard
        /// L = Last
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FLAG { get; internal set; }
        /// <summary>
        /// Batch number of payroll batch
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// EFT sent to bank Yes or No
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EFT_CREATED { get; internal set; }
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
        /// Navigation property for [BSB] => [KAB].[BSB]
        /// Bank-state-branch as BBBBBB
        /// </summary>
        public KAB BSB_KAB {
            get
            {
                if (BSB != null)
                {
                    if (_BSB_KAB == null)
                    {
                        _BSB_KAB = Context.KAB.FindByBSB(BSB);
                    }
                    return _BSB_KAB;
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
