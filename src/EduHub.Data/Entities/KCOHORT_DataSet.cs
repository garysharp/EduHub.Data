using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation Data Set
    /// </summary>
    public sealed class KCOHORT_DataSet : SetBase<KCOHORT_Entity>
    {
        private Lazy<Dictionary<string, KCOHORT_Entity>> COHORT_Index;
        private Lazy<Dictionary<string, KCOHORT_Entity>> DESCRIPTION_Index;

        internal KCOHORT_DataSet(EduHubContext Context)
            : base(Context)
        {
            COHORT_Index = new Lazy<Dictionary<string, KCOHORT_Entity>>(() => this.ToDictionary(e => e.COHORT));
            DESCRIPTION_Index = new Lazy<Dictionary<string, KCOHORT_Entity>>(() => this.ToDictionary(e => e.DESCRIPTION));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KCOHORT"; } }

        /// <summary>
        /// Find KCOHORT by COHORT key field
        /// </summary>
        /// <param name="Key">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COHORT value didn't match any KCOHORT entities</exception>
        public KCOHORT_Entity FindByCOHORT(string Key)
        {
            KCOHORT_Entity result;
            if (COHORT_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the KCOHORT Entity is found</returns>
        public bool TryFindByCOHORT(string Key, out KCOHORT_Entity Value)
        {
            return COHORT_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT key field
        /// </summary>
        /// <param name="Key">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        public KCOHORT_Entity TryFindByCOHORT(string Key)
        {
            KCOHORT_Entity result;
            if (COHORT_Index.Value.TryGetValue(Key, out result))
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
        public KCOHORT_Entity FindByDESCRIPTION(string Key)
        {
            KCOHORT_Entity result;
            if (DESCRIPTION_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the KCOHORT Entity is found</returns>
        public bool TryFindByDESCRIPTION(string Key, out KCOHORT_Entity Value)
        {
            return DESCRIPTION_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION key field
        /// </summary>
        /// <param name="Key">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        public KCOHORT_Entity TryFindByDESCRIPTION(string Key)
        {
            KCOHORT_Entity result;
            if (DESCRIPTION_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KCOHORT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCOHORT_Entity, string>[Headers.Count];

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
