using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Departments
    /// </summary>
    public partial class AKD : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEPARTMENT { get; internal set; }
        /// <summary>
        /// Description of department
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
        /// AR (Assets) related entities by [AR.DEPARTMENT]-&gt;[AKD.DEPARTMENT]
        /// </summary>
        public IReadOnlyList<AR> AR_DEPARTMENT
        {
            get
            {
                return Context.AKD.FindARByDEPARTMENT(DEPARTMENT);
            }
        }
#endregion
    }
}
