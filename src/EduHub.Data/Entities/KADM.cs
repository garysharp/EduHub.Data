using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADM : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<AKC> Cache_KADMKEY_AKC_DEPN_AMETHOD;
        private IReadOnlyList<AKC> Cache_KADMKEY_AKC_DEPN_TMETHOD;
        private IReadOnlyList<AKCT> Cache_KADMKEY_AKCT_DEPN_TMETHOD;
        private IReadOnlyList<AR> Cache_KADMKEY_AR_AMETHOD;
        private IReadOnlyList<AR> Cache_KADMKEY_AR_TMETHOD;
        private IReadOnlyList<ARF> Cache_KADMKEY_ARF_AMETHOD;
        private IReadOnlyList<ARF> Cache_KADMKEY_ARF_TMETHOD;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Method Code
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string KADMKEY { get; internal set; }

        /// <summary>
        /// Method Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Detail description of calculation,
        /// eg. calculation examples
        /// [Memo]
        /// </summary>
        public string DETAIL { get; internal set; }

        /// <summary>
        /// Date-Based method Y/N?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DATE_BASED { get; internal set; }

        /// <summary>
        /// Is this method used for tax depreciation Y/N?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAX { get; internal set; }

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
        /// AKC (Assets - Categories) related entities by [KADM.KADMKEY]-&gt;[AKC.DEPN_AMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<AKC> KADMKEY_AKC_DEPN_AMETHOD
        {
            get
            {
                if (Cache_KADMKEY_AKC_DEPN_AMETHOD == null &&
                    !Context.AKC.TryFindByDEPN_AMETHOD(KADMKEY, out Cache_KADMKEY_AKC_DEPN_AMETHOD))
                {
                    Cache_KADMKEY_AKC_DEPN_AMETHOD = new List<AKC>().AsReadOnly();
                }

                return Cache_KADMKEY_AKC_DEPN_AMETHOD;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [KADM.KADMKEY]-&gt;[AKC.DEPN_TMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<AKC> KADMKEY_AKC_DEPN_TMETHOD
        {
            get
            {
                if (Cache_KADMKEY_AKC_DEPN_TMETHOD == null &&
                    !Context.AKC.TryFindByDEPN_TMETHOD(KADMKEY, out Cache_KADMKEY_AKC_DEPN_TMETHOD))
                {
                    Cache_KADMKEY_AKC_DEPN_TMETHOD = new List<AKC>().AsReadOnly();
                }

                return Cache_KADMKEY_AKC_DEPN_TMETHOD;
            }
        }

        /// <summary>
        /// AKCT (Assets - Categories Tax) related entities by [KADM.KADMKEY]-&gt;[AKCT.DEPN_TMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<AKCT> KADMKEY_AKCT_DEPN_TMETHOD
        {
            get
            {
                if (Cache_KADMKEY_AKCT_DEPN_TMETHOD == null &&
                    !Context.AKCT.TryFindByDEPN_TMETHOD(KADMKEY, out Cache_KADMKEY_AKCT_DEPN_TMETHOD))
                {
                    Cache_KADMKEY_AKCT_DEPN_TMETHOD = new List<AKCT>().AsReadOnly();
                }

                return Cache_KADMKEY_AKCT_DEPN_TMETHOD;
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [KADM.KADMKEY]-&gt;[AR.AMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<AR> KADMKEY_AR_AMETHOD
        {
            get
            {
                if (Cache_KADMKEY_AR_AMETHOD == null &&
                    !Context.AR.TryFindByAMETHOD(KADMKEY, out Cache_KADMKEY_AR_AMETHOD))
                {
                    Cache_KADMKEY_AR_AMETHOD = new List<AR>().AsReadOnly();
                }

                return Cache_KADMKEY_AR_AMETHOD;
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [KADM.KADMKEY]-&gt;[AR.TMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<AR> KADMKEY_AR_TMETHOD
        {
            get
            {
                if (Cache_KADMKEY_AR_TMETHOD == null &&
                    !Context.AR.TryFindByTMETHOD(KADMKEY, out Cache_KADMKEY_AR_TMETHOD))
                {
                    Cache_KADMKEY_AR_TMETHOD = new List<AR>().AsReadOnly();
                }

                return Cache_KADMKEY_AR_TMETHOD;
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [KADM.KADMKEY]-&gt;[ARF.AMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<ARF> KADMKEY_ARF_AMETHOD
        {
            get
            {
                if (Cache_KADMKEY_ARF_AMETHOD == null &&
                    !Context.ARF.TryFindByAMETHOD(KADMKEY, out Cache_KADMKEY_ARF_AMETHOD))
                {
                    Cache_KADMKEY_ARF_AMETHOD = new List<ARF>().AsReadOnly();
                }

                return Cache_KADMKEY_ARF_AMETHOD;
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [KADM.KADMKEY]-&gt;[ARF.TMETHOD]
        /// Method Code
        /// </summary>
        public IReadOnlyList<ARF> KADMKEY_ARF_TMETHOD
        {
            get
            {
                if (Cache_KADMKEY_ARF_TMETHOD == null &&
                    !Context.ARF.TryFindByTMETHOD(KADMKEY, out Cache_KADMKEY_ARF_TMETHOD))
                {
                    Cache_KADMKEY_ARF_TMETHOD = new List<ARF>().AsReadOnly();
                }

                return Cache_KADMKEY_ARF_TMETHOD;
            }
        }

        #endregion

    }
}
