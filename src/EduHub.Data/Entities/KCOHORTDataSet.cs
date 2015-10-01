using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation Data Set
    /// </summary>
    public sealed class KCOHORTDataSet : SetBase<KCOHORT>
    {
        private Lazy<Dictionary<string, KCOHORT>> COHORTIndex;
        private Lazy<Dictionary<string, KCOHORT>> DESCRIPTIONIndex;

        internal KCOHORTDataSet(EduHubContext Context)
            : base(Context)
        {
            COHORTIndex = new Lazy<Dictionary<string, KCOHORT>>(() => this.ToDictionary(e => e.COHORT));
            DESCRIPTIONIndex = new Lazy<Dictionary<string, KCOHORT>>(() => this.ToDictionary(e => e.DESCRIPTION));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCOHORT"; } }

        /// <summary>
        /// Find KCOHORT by COHORT key field
        /// </summary>
        /// <param name="Key">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COHORT value didn't match any KCOHORT entities</exception>
        public KCOHORT FindByCOHORT(string Key)
        {
            KCOHORT result;
            if (COHORTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT key field
        /// </summary>
        /// <param name="Key">COHORT value used to find KCOHORT</param>
        /// <param name="Value">Related KCOHORT entity</param>
        /// <returns>True if the KCOHORT entity is found</returns>
        public bool TryFindByCOHORT(string Key, out KCOHORT Value)
        {
            return COHORTIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT key field
        /// </summary>
        /// <param name="Key">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        public KCOHORT TryFindByCOHORT(string Key)
        {
            KCOHORT result;
            if (COHORTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCOHORT by DESCRIPTION key field
        /// </summary>
        /// <param name="Key">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">DESCRIPTION value didn't match any KCOHORT entities</exception>
        public KCOHORT FindByDESCRIPTION(string Key)
        {
            KCOHORT result;
            if (DESCRIPTIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION key field
        /// </summary>
        /// <param name="Key">DESCRIPTION value used to find KCOHORT</param>
        /// <param name="Value">Related KCOHORT entity</param>
        /// <returns>True if the KCOHORT entity is found</returns>
        public bool TryFindByDESCRIPTION(string Key, out KCOHORT Value)
        {
            return DESCRIPTIONIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION key field
        /// </summary>
        /// <param name="Key">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        public KCOHORT TryFindByDESCRIPTION(string Key)
        {
            KCOHORT result;
            if (DESCRIPTIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
