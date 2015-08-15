using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Key Holders
    /// </summary>
    public class AKK_Entity : EntityBase
    {
#region Navigation Property Cache
        private AR_Entity _CODE_AR;
        private SF_Entity _STAFF_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Asset code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Staff [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF { get; internal set; }
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
        /// Navigation property for [CODE] => [AR_Entity].[ARKEY]
        /// Asset code
        /// </summary>
        public AR_Entity CODE_AR {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_AR == null)
                    {
                        _CODE_AR = Context.AR.FindByARKEY(CODE);
                    }
                    return _CODE_AR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STAFF] => [SF_Entity].[SFKEY]
        /// Staff
        /// </summary>
        public SF_Entity STAFF_SF {
            get
            {
                if (STAFF != null)
                {
                    if (_STAFF_SF == null)
                    {
                        _STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                    }
                    return _STAFF_SF;
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
