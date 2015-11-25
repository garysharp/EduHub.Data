using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Visa Subclasses
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCV : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<ST> Cache_VISA_SUBCLASS_ST_VISA_SUBCLASS;
        private IReadOnlyList<STRE> Cache_VISA_SUBCLASS_STRE_ST_VISA_SUBCLASS;

        #endregion

        #region Field Properties

        /// <summary>
        /// Visa Subclass code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }

        /// <summary>
        /// Visa Subclass description
        /// [Alphanumeric (52)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Australian residence status of persons with this Visa Subclass: P=Permanent, T=Temporary
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VISA_RESIDENCY { get; internal set; }

        /// <summary>
        /// Indicates whether students with this Visa Subclass are eligible for (SRP) funding(Y/M)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }

        /// <summary>
        /// Indicates whether the Visa Statistical Code should be checked for students with this Visa Subclass (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHECK_STAT_CODE { get; internal set; }

        /// <summary>
        /// Indicates whether the expiry date should be checked for students with this Visa Subclass (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHECK_EXPIRY_DATE { get; internal set; }

        /// <summary>
        /// Identifies visa sub-classes that require an international student id
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHECK_ISID { get; internal set; }

        /// <summary>
        /// Identifies if Visa subclass is a refugee type for EAL (refer Aegis 7210).
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REFUGEE { get; internal set; }

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
        /// ST (Students) related entities by [KCV.VISA_SUBCLASS]-&gt;[ST.VISA_SUBCLASS]
        /// Visa Subclass code
        /// </summary>
        public IReadOnlyList<ST> VISA_SUBCLASS_ST_VISA_SUBCLASS
        {
            get
            {
                if (Cache_VISA_SUBCLASS_ST_VISA_SUBCLASS == null &&
                    !Context.ST.TryFindByVISA_SUBCLASS(VISA_SUBCLASS, out Cache_VISA_SUBCLASS_ST_VISA_SUBCLASS))
                {
                    Cache_VISA_SUBCLASS_ST_VISA_SUBCLASS = new List<ST>().AsReadOnly();
                }

                return Cache_VISA_SUBCLASS_ST_VISA_SUBCLASS;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KCV.VISA_SUBCLASS]-&gt;[STRE.ST_VISA_SUBCLASS]
        /// Visa Subclass code
        /// </summary>
        public IReadOnlyList<STRE> VISA_SUBCLASS_STRE_ST_VISA_SUBCLASS
        {
            get
            {
                if (Cache_VISA_SUBCLASS_STRE_ST_VISA_SUBCLASS == null &&
                    !Context.STRE.TryFindByST_VISA_SUBCLASS(VISA_SUBCLASS, out Cache_VISA_SUBCLASS_STRE_ST_VISA_SUBCLASS))
                {
                    Cache_VISA_SUBCLASS_STRE_ST_VISA_SUBCLASS = new List<STRE>().AsReadOnly();
                }

                return Cache_VISA_SUBCLASS_STRE_ST_VISA_SUBCLASS;
            }
        }

        #endregion

    }
}
