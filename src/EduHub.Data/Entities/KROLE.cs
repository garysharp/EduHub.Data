using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Role Codes
    /// </summary>
    public partial class KROLE : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Code
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string KROLEKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Role for the code
        /// 
        /// [Uppercase Alphanumeric (32)]
        /// </summary>
        public string ROLE_NAME { get; internal set; }
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
        /// KREPORT (Reports for emailing) related entities by [KREPORT.ROLE_CODE]-&gt;[KROLE.KROLEKEY]
        /// </summary>
        public IReadOnlyList<KREPORT> KREPORT_ROLE_CODE
        {
            get
            {
                return Context.KROLE.FindKREPORTByROLE_CODE(KROLEKEY);
            }
        }
#endregion
    }
}
