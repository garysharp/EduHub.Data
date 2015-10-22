using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Categories
    /// </summary>
    public partial class TEC : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Title
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
        /// TE (Calendar Events) related entities by [TE.CATEGORY]-&gt;[TEC.CATEGORY]
        /// </summary>
        public IReadOnlyList<TE> TE_CATEGORY
        {
            get
            {
                return Context.TEC.FindTEByCATEGORY(CATEGORY);
            }
        }
#endregion
    }
}
