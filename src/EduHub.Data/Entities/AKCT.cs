using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Tax
    /// </summary>
    public partial class AKCT : EntityBase
    {
#region Navigation Property Cache
        private KADM _DEPN_TMETHOD_KADM;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key (formerly GROUP)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Description of category
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Default deprn method for taxation
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DEPN_TMETHOD { get; internal set; }
        /// <summary>
        /// Default deprn rate for taxation
        /// </summary>
        public double? DEPN_TRATE { get; internal set; }
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
        /// KADM (Asset Depreciation Methods) related entity by [AKCT.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// Default deprn method for taxation
        /// </summary>
        public KADM DEPN_TMETHOD_KADM
        {
            get
            {
                if (DEPN_TMETHOD != null)
                {
                    if (_DEPN_TMETHOD_KADM == null)
                    {
                        _DEPN_TMETHOD_KADM = Context.KADM.FindByKADMKEY(DEPN_TMETHOD);
                    }
                    return _DEPN_TMETHOD_KADM;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [AR.TAX_CATEGORY]-&gt;[AKCT.CATEGORY]
        /// </summary>
        public IReadOnlyList<AR> AR_TAX_CATEGORY
        {
            get
            {
                return Context.AKCT.FindARByTAX_CATEGORY(CATEGORY);
            }
        }
#endregion
    }
}
