using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Termination Payment
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PETP : EduHubEntity
    {

        #region Navigation Property Cache

        private PE Cache_CODE_PE;
        private PI Cache_PAYITEM_PI;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TID { get; internal set; }

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
                if (Cache_CODE_PE == null)
                {
                    Cache_CODE_PE = Context.PE.FindByPEKEY(CODE);
                }

                return Cache_CODE_PE;
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
                if (PAYITEM == null)
                {
                    return null;
                }
                if (Cache_PAYITEM_PI == null)
                {
                    Cache_PAYITEM_PI = Context.PI.FindByPIKEY(PAYITEM.Value);
                }

                return Cache_PAYITEM_PI;
            }
        }

        #endregion

    }
}
