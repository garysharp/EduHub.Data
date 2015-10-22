﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Note Categories
    /// </summary>
    public partial class KPN : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KPNKEY { get; internal set; }
        /// <summary>
        /// Description
        /// 
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
        /// PEPY (Employee History) related entities by [PEPY.PURPOSE]-&gt;[KPN.KPNKEY]
        /// </summary>
        public IReadOnlyList<PEPY> PEPY_PURPOSE
        {
            get
            {
                return Context.KPN.FindPEPYByPURPOSE(KPNKEY);
            }
        }
#endregion
    }
}
