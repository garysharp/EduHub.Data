using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Tax
    /// </summary>
    public class AKCT_Entity : EntityBase
    {
#region Navigation Property Cache
        private KADM_Entity _DEPN_TMETHOD_KADM;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key (formerly GROUP) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Description of category [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Default deprn method for taxation [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEPN_TMETHOD { get; internal set; }
        /// <summary>
        /// Default deprn rate for taxation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DEPN_TRATE { get; internal set; }
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
        /// Navigation property for [DEPN_TMETHOD] => [KADM_Entity].[KADMKEY]
        /// Default deprn method for taxation
        /// </summary>
        public KADM_Entity DEPN_TMETHOD_KADM {
            get
            {
                if (DEPN_TMETHOD != null)
                {
                    if (_DEPN_TMETHOD_KADM == null)
                    {
                        _DEPN_TMETHOD_KADM = Context.KADM.FindByKADMKEY(DEPN_TMETHOD);
                    }
                    return _DEPN_TMETHOD_KADM;
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
