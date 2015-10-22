using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses
    /// </summary>
    public partial class KAD : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KADKEY { get; internal set; }
        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
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
        /// CRF (Creditor Financial Transaction) related entities by [CRF.DEL_CODE]-&gt;[KAD.KADKEY]
        /// </summary>
        public IReadOnlyList<CRF> CRF_DEL_CODE
        {
            get
            {
                return Context.KAD.FindCRFByDEL_CODE(KADKEY);
            }
        }
#endregion
    }
}
