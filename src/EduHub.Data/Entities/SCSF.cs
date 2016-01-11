using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSF : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SCSFAG> Cache_SCSFKEY_SCSFAG_SCSFKEY;

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
        /// CSF Outcome Code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SCSFKEY { get; internal set; }

        /// <summary>
        /// Key Learning Area description
        /// [Alphanumeric (40)]
        /// </summary>
        public string KLA { get; internal set; }

        /// <summary>
        /// Strand description
        /// [Titlecase (40)]
        /// </summary>
        public string STRAND { get; internal set; }

        /// <summary>
        /// Sub-strand description
        /// [Titlecase (40)]
        /// </summary>
        public string SUB_STRAND { get; internal set; }

        /// <summary>
        /// Is this Strand activated? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENABLED { get; internal set; }

        /// <summary>
        /// Is assessment of this Strand compulsory for Department? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DEET_REQUIRED { get; internal set; }

        /// <summary>
        /// CSF low level (1 to 6)
        /// </summary>
        public short? LOW_LEVEL { get; internal set; }

        /// <summary>
        /// CSF high level(1 to 6)
        /// </summary>
        public short? HIGH_LEVEL { get; internal set; }

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
        /// SCSFAG (CSF Data Aggregates) related entities by [SCSF.SCSFKEY]-&gt;[SCSFAG.SCSFKEY]
        /// CSF Outcome Code
        /// </summary>
        public IReadOnlyList<SCSFAG> SCSFKEY_SCSFAG_SCSFKEY
        {
            get
            {
                if (Cache_SCSFKEY_SCSFAG_SCSFKEY == null &&
                    !Context.SCSFAG.TryFindBySCSFKEY(SCSFKEY, out Cache_SCSFKEY_SCSFAG_SCSFKEY))
                {
                    Cache_SCSFKEY_SCSFAG_SCSFKEY = new List<SCSFAG>().AsReadOnly();
                }

                return Cache_SCSFKEY_SCSFAG_SCSFKEY;
            }
        }

        #endregion

    }
}
