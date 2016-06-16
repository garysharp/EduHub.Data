using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCM : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SMC> Cache_KCMKEY_SMC_MED_CONDITION;

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
        /// Medical Condition code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCMKEY { get; internal set; }

        /// <summary>
        /// Long description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Disability flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISABILITY { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// SMC (Student Medical Conditions) related entities by [KCM.KCMKEY]-&gt;[SMC.MED_CONDITION]
        /// Medical Condition code
        /// </summary>
        public IReadOnlyList<SMC> KCMKEY_SMC_MED_CONDITION
        {
            get
            {
                if (Cache_KCMKEY_SMC_MED_CONDITION == null &&
                    !Context.SMC.TryFindByMED_CONDITION(KCMKEY, out Cache_KCMKEY_SMC_MED_CONDITION))
                {
                    Cache_KCMKEY_SMC_MED_CONDITION = new List<SMC>().AsReadOnly();
                }

                return Cache_KCMKEY_SMC_MED_CONDITION;
            }
        }

        #endregion

    }
}
