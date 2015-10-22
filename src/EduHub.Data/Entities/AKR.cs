using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types
    /// </summary>
    public partial class AKR : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Asset Release Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AKRKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
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
        /// AR (Assets) related entities by [AR.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// </summary>
        public IReadOnlyList<AR> AR_RELEASE_TYPE
        {
            get
            {
                return Context.AKR.FindARByRELEASE_TYPE(AKRKEY);
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// </summary>
        public IReadOnlyList<ARF> ARF_RELEASE_TYPE
        {
            get
            {
                return Context.AKR.FindARFByRELEASE_TYPE(AKRKEY);
            }
        }
#endregion
    }
}
