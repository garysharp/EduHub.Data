using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCOHORTDataSet : SetBase<KCOHORT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCOHORT"; } }

        internal KCOHORTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COHORT = new Lazy<Dictionary<string, KCOHORT>>(() => this.ToDictionary(i => i.COHORT));
            Index_DESCRIPTION = new Lazy<NullDictionary<string, IReadOnlyList<KCOHORT>>>(() => this.ToGroupedNullDictionary(i => i.DESCRIPTION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCOHORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCOHORT" /> fields for each CSV column header</returns>
        protected override Action<KCOHORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCOHORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VELS":
                        mapper[i] = (e, v) => e.VELS = v;
                        break;
                    case "BENCHMARK":
                        mapper[i] = (e, v) => e.BENCHMARK = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCOHORT>> Index_COHORT;
        private Lazy<NullDictionary<string, IReadOnlyList<KCOHORT>>> Index_DESCRIPTION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCOHORT FindByCOHORT(string COHORT)
        {
            return Index_COHORT.Value[COHORT];
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <param name="Value">Related KCOHORT entity</param>
        /// <returns>True if the related KCOHORT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOHORT(string COHORT, out KCOHORT Value)
        {
            return Index_COHORT.Value.TryGetValue(COHORT, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCOHORT TryFindByCOHORT(string COHORT)
        {
            KCOHORT value;
            if (Index_COHORT.Value.TryGetValue(COHORT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>List of related KCOHORT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCOHORT> FindByDESCRIPTION(string DESCRIPTION)
        {
            return Index_DESCRIPTION.Value[DESCRIPTION];
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <param name="Value">List of related KCOHORT entities</param>
        /// <returns>True if the list of related KCOHORT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDESCRIPTION(string DESCRIPTION, out IReadOnlyList<KCOHORT> Value)
        {
            return Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>List of related KCOHORT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCOHORT> TryFindByDESCRIPTION(string DESCRIPTION)
        {
            IReadOnlyList<KCOHORT> value;
            if (Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
