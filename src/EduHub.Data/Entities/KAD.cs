using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAD : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<CRF> Cache_KADKEY_CRF_DEL_CODE;

        #endregion

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

        #region Foreign Navigation Properties

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [KAD.KADKEY]-&gt;[CRF.DEL_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRF> KADKEY_CRF_DEL_CODE
        {
            get
            {
                if (Cache_KADKEY_CRF_DEL_CODE == null &&
                    !Context.CRF.TryFindByDEL_CODE(KADKEY, out Cache_KADKEY_CRF_DEL_CODE))
                {
                    Cache_KADKEY_CRF_DEL_CODE = new List<CRF>().AsReadOnly();
                }

                return Cache_KADKEY_CRF_DEL_CODE;
            }
        }

        #endregion

    }
}
