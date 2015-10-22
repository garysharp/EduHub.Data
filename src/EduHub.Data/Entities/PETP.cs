using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Termination Payment
    /// </summary>
    public partial class PETP : EntityBase
    {
#region Navigation Property Cache
        private PE _CODE_PE;
        private PI _PAYITEM_PI;
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Pay item code
        /// </summary>
        public short? PAYITEM { get; internal set; }
        /// <summary>
        /// Link to PEF.TID
        /// </summary>
        public int? PEFTID { get; internal set; }
        /// <summary>
        /// Death benefit (=Y or N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DEATH_BENEFIT { get; internal set; }
        /// <summary>
        /// Type of death benefit (=T or O or D)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BENEFIT_TYPE { get; internal set; }
        /// <summary>
        /// Transitional termination payment(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSITIONAL { get; internal set; }
        /// <summary>
        /// Related to a prior year payment for
        /// same termination (=Y or N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RELATED { get; internal set; }
        /// <summary>
        /// ETP Code
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ETP_CODE { get; internal set; }
        /// <summary>
        /// PI Tax Rate at the time of generation
        /// </summary>
        public double? TAX_RATE { get; internal set; }
        /// <summary>
        /// This record has been generated from the patc
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PATCH_RECORD { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator (u8) in VS3a
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// PE (Employees) related entity by [PETP.CODE]-&gt;[PE.PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE
        {
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
        /// PI (Pay Items) related entity by [PETP.PAYITEM]-&gt;[PI.PIKEY]
        /// Pay item code
        /// </summary>
        public PI PAYITEM_PI
        {
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
