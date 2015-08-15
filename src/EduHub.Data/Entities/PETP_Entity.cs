using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Termination Payment
    /// </summary>
    public class PETP_Entity : EntityBase
    {
#region Navigation Property Cache
        private PE_Entity _CODE_PE;
        private PI_Entity _PAYITEM_PI;
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Pay item code [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PAYITEM { get; internal set; }
        /// <summary>
        /// Link to PEF.TID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PEFTID { get; internal set; }
        /// <summary>
        /// Death benefit (=Y or N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEATH_BENEFIT { get; internal set; }
        /// <summary>
        /// Type of death benefit (=T or O or D) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BENEFIT_TYPE { get; internal set; }
        /// <summary>
        /// Transitional termination payment(Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSITIONAL { get; internal set; }
        /// <summary>
        /// Related to a prior year payment for
        /// same termination (=Y or N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RELATED { get; internal set; }
        /// <summary>
        /// ETP Code [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ETP_CODE { get; internal set; }
        /// <summary>
        /// PI Tax Rate at the time of generation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TAX_RATE { get; internal set; }
        /// <summary>
        /// This record has been generated from the patc
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PATCH_RECORD { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator (u8) in VS3a [Uppercase Alphanumeric: u128]
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
        /// Navigation property for [PAYITEM] => [PI_Entity].[PIKEY]
        /// Pay item code
        /// </summary>
        public PI_Entity PAYITEM_PI {
            get
            {
                if (PAYITEM.HasValue)
                {
                    if (_PAYITEM_PI == null)
                    {
                        _PAYITEM_PI = Context.PI.FindByPIKEY(PAYITEM.Value);
                    }
                    return _PAYITEM_PI;
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
