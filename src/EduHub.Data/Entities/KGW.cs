using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Awards and Prizes
    /// </summary>
    public partial class KGW : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Award code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AWARD { get; internal set; }
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
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// STMB (Student Merit Behaviour Details) related entities by [STMB.AWARD]-&gt;[KGW.AWARD]
        /// </summary>
        public IReadOnlyList<STMB> STMB_AWARD
        {
            get
            {
                return Context.KGW.FindSTMBByAWARD(AWARD);
            }
        }
#endregion
    }
}
