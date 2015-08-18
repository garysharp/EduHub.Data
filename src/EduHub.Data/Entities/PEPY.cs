using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee History
    /// </summary>
    public class PEPY : EntityBase
    {
#region Navigation Property Cache
        private PE _CODE_PE;
        private KPN _PURPOSE_KPN;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TRANSDATE { get; internal set; }
        /// <summary>
        /// Originator
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Generic purpose for notes
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PURPOSE { get; internal set; }
        /// <summary>
        /// Employee notes
        /// 
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last user name
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [PE].[PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE {
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
        /// Navigation property for [PURPOSE] => [KPN].[KPNKEY]
        /// Generic purpose for notes
        /// </summary>
        public KPN PURPOSE_KPN {
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
