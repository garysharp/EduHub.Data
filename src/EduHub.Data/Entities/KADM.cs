using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods
    /// </summary>
    public partial class KADM : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.DEPN_AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<AKC> AKC_DEPN_AMETHOD
        {
            get
            {
                return Context.KADM.FindAKCByDEPN_AMETHOD(KADMKEY);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<AKC> AKC_DEPN_TMETHOD
        {
            get
            {
                return Context.KADM.FindAKCByDEPN_TMETHOD(KADMKEY);
            }
        }

        /// <summary>
        /// AKCT (Assets - Categories Tax) related entities by [AKCT.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<AKCT> AKCT_DEPN_TMETHOD
        {
            get
            {
                return Context.KADM.FindAKCTByDEPN_TMETHOD(KADMKEY);
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [AR.AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<AR> AR_AMETHOD
        {
            get
            {
                return Context.KADM.FindARByAMETHOD(KADMKEY);
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [AR.TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<AR> AR_TMETHOD
        {
            get
            {
                return Context.KADM.FindARByTMETHOD(KADMKEY);
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<ARF> ARF_AMETHOD
        {
            get
            {
                return Context.KADM.FindARFByAMETHOD(KADMKEY);
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        public IReadOnlyList<ARF> ARF_TMETHOD
        {
            get
            {
                return Context.KADM.FindARFByTMETHOD(KADMKEY);
            }
        }
#endregion
    }
}
