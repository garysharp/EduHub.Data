using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Advice Slip Message
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEM : EduHubEntity
    {

        #region Navigation Property Cache

        private PE Cache_CODE_PE;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (unique)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// OLDNAME=TRPAYPERD ;              * Start pay period
        /// </summary>
        public int? START_TRPAYPERD { get; internal set; }

        /// <summary>
        /// End pay period
        /// </summary>
        public int? END_TRPAYPERD { get; internal set; }

        /// <summary>
        /// Message for this employee
        /// For this payperiod
        /// [Alphanumeric (90)]
        /// </summary>
        public string EMP_MESSAGE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// PE (Employees) related entity by [PEM.CODE]-&gt;[PE.PEKEY]
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

        #endregion

    }
}
