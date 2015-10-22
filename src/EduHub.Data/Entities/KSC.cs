﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions
    /// </summary>
    public partial class KSC : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Position code
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KSCKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string SF_POSITION { get; internal set; }
        /// <summary>
        /// Period allowance for this position
        /// </summary>
        public short? ALLOTMENT { get; internal set; }
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
        /// SF (Staff) related entities by [SF.POS_CODE_A]-&gt;[KSC.KSCKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_POS_CODE_A
        {
            get
            {
                return Context.KSC.FindSFByPOS_CODE_A(KSCKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.POS_CODE_B]-&gt;[KSC.KSCKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_POS_CODE_B
        {
            get
            {
                return Context.KSC.FindSFByPOS_CODE_B(KSCKEY);
            }
        }
#endregion
    }
}
