﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types
    /// </summary>
    public partial class TCAT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Staff Absence Type Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TCATKEY { get; internal set; }
        /// <summary>
        /// Staff Absence Type Title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
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
        /// TCTB (Teacher Absences) related entities by [TCTB.ABSENCE_TYPE]-&gt;[TCAT.TCATKEY]
        /// </summary>
        public IReadOnlyList<TCTB> TCTB_ABSENCE_TYPE
        {
            get
            {
                return Context.TCAT.FindTCTBByABSENCE_TYPE(TCATKEY);
            }
        }
#endregion
    }
}
