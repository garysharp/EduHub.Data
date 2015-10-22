using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Types
    /// </summary>
    public partial class AKT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Asset Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AKTKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
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
        /// AR (Assets) related entities by [AR.ASSET_TYPE]-&gt;[AKT.AKTKEY]
        /// </summary>
        public IReadOnlyList<AR> AR_ASSET_TYPE
        {
            get
            {
                return Context.AKT.FindARByASSET_TYPE(AKTKEY);
            }
        }
#endregion
    }
}
