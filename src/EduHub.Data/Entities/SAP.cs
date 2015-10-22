using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Positions
    /// </summary>
    public partial class SAP : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Association position code
        /// [Uppercase Alphanumeric (25)]
        /// </summary>
        public string SAPKEY { get; internal set; }
        /// <summary>
        /// Association position long name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Field for sorting
        /// </summary>
        public short? SORT_CODE { get; internal set; }
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
        /// SAM (School Association Members) related entities by [SAM.ASSOC_POSN]-&gt;[SAP.SAPKEY]
        /// </summary>
        public IReadOnlyList<SAM> SAM_ASSOC_POSN
        {
            get
            {
                return Context.SAP.FindSAMByASSOC_POSN(SAPKEY);
            }
        }
#endregion
    }
}
