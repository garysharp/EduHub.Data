using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties
    /// </summary>
    public class KSF : EntityBase
    {
#region Navigation Property Cache
        private SF _COORDINATOR_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Faculty code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KSFKEY { get; internal set; }
        /// <summary>
        /// Faculty name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Staff code of KLA co-ordinator
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string COORDINATOR { get; internal set; }
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
        /// Navigation property for [COORDINATOR] => [SF].[SFKEY]
        /// Staff code of KLA co-ordinator
        /// </summary>
        public SF COORDINATOR_SF {
            get
            {
                if (COORDINATOR != null)
                {
                    if (_COORDINATOR_SF == null)
                    {
                        _COORDINATOR_SF = Context.SF.FindBySFKEY(COORDINATOR);
                    }
                    return _COORDINATOR_SF;
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
