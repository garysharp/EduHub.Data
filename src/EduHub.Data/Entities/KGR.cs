using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGR : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SF> Cache_RELIGION_SF_RELIGION;
        private IReadOnlyList<ST> Cache_RELIGION_ST_RELIGION;

        #endregion

        #region Field Properties

        /// <summary>
        /// Religion code
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string RELIGION { get; internal set; }

        /// <summary>
        /// Religion description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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
        /// SF (Staff) related entities by [KGR.RELIGION]-&gt;[SF.RELIGION]
        /// Religion code
        /// </summary>
        public IReadOnlyList<SF> RELIGION_SF_RELIGION
        {
            get
            {
                if (Cache_RELIGION_SF_RELIGION == null &&
                    !Context.SF.TryFindByRELIGION(RELIGION, out Cache_RELIGION_SF_RELIGION))
                {
                    Cache_RELIGION_SF_RELIGION = new List<SF>().AsReadOnly();
                }

                return Cache_RELIGION_SF_RELIGION;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGR.RELIGION]-&gt;[ST.RELIGION]
        /// Religion code
        /// </summary>
        public IReadOnlyList<ST> RELIGION_ST_RELIGION
        {
            get
            {
                if (Cache_RELIGION_ST_RELIGION == null &&
                    !Context.ST.TryFindByRELIGION(RELIGION, out Cache_RELIGION_ST_RELIGION))
                {
                    Cache_RELIGION_ST_RELIGION = new List<ST>().AsReadOnly();
                }

                return Cache_RELIGION_ST_RELIGION;
            }
        }

        #endregion

    }
}
