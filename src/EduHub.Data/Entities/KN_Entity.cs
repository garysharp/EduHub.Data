using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Notes
    /// </summary>
    public class KN_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// ID [Uppercase Alphanumeric: u4]
        /// </summary>
        public string NOTE_ID { get; internal set; }
        /// <summary>
        /// note body [Memo: m]
        /// </summary>
        public string CONTENTS { get; internal set; }
        /// <summary>
        /// Allow note to be used(Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// B - Balance Sheet , O - Operating Statement [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SCOPE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
