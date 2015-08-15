using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Advice Slip Message
    /// </summary>
    public class PEM_Entity : EntityBase
    {
#region Navigation Property Cache
        private PE_Entity _CODE_PE;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// OLDNAME=TRPAYPERD ;              * Start pay period [Integer (32bit signed nullable): l]
        /// </summary>
        public int? START_TRPAYPERD { get; internal set; }
        /// <summary>
        /// End pay period [Integer (32bit signed nullable): l]
        /// </summary>
        public int? END_TRPAYPERD { get; internal set; }
        /// <summary>
        /// Message for this employee
        /// For this payperiod
        ///  [Alphanumeric: a90]
        /// </summary>
        public string EMP_MESSAGE { get; internal set; }
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
        /// <summary>
        /// Navigation property for [CODE] => [PE_Entity].[PEKEY]
        /// Employee code
        /// </summary>
        public PE_Entity CODE_PE {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_PE == null)
                    {
                        _CODE_PE = Context.PE.FindByPEKEY(CODE);
                    }
                    return _CODE_PE;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
