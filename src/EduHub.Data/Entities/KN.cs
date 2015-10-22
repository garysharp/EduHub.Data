using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Notes
    /// </summary>
    public partial class KN : EntityBase
    {
#region Field Properties
        /// <summary>
        /// ID
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string NOTE_ID { get; internal set; }
        /// <summary>
        /// note body
        /// [Memo]
        /// </summary>
        public string CONTENTS { get; internal set; }
        /// <summary>
        /// Allow note to be used(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// B - Balance Sheet , O - Operating Statement
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SCOPE { get; internal set; }
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
    }
}
