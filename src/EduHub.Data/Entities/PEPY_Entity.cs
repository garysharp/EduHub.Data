using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee History
    /// </summary>
    public class PEPY_Entity : EntityBase
    {
#region Navigation Property Cache
        private PE_Entity _CODE_PE;
        private KPN_Entity _PURPOSE_KPN;
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
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? TRANSDATE { get; internal set; }
        /// <summary>
        /// Originator [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Generic purpose for notes [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PURPOSE { get; internal set; }
        /// <summary>
        /// Employee notes
        ///  [Memo: m]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last user name [Uppercase Alphanumeric: u128]
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
        /// <summary>
        /// Navigation property for [PURPOSE] => [KPN_Entity].[KPNKEY]
        /// Generic purpose for notes
        /// </summary>
        public KPN_Entity PURPOSE_KPN {
            get
            {
                if (PURPOSE != null)
                {
                    if (_PURPOSE_KPN == null)
                    {
                        _PURPOSE_KPN = Context.KPN.FindByKPNKEY(PURPOSE);
                    }
                    return _PURPOSE_KPN;
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
