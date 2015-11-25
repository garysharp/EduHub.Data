using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Aggregated Dimensions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SVAGDataSet : SetBase<SVAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SVAG"; } }

        internal SVAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SVAGKEY = new Lazy<Dictionary<int, SVAG>>(() => this.ToDictionary(i => i.SVAGKEY));
            Index_COHORT = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.COHORT));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_VDIMENSION = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.VDIMENSION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SVAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SVAG" /> fields for each CSV column header</returns>
        protected override Action<SVAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SVAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SVAGKEY":
                        mapper[i] = (e, v) => e.SVAGKEY = int.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "VDIMENSION":
                        mapper[i] = (e, v) => e.VDIMENSION = v;
                        break;
                    case "NUMBER_AT01":
                        mapper[i] = (e, v) => e.NUMBER_AT01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT02":
                        mapper[i] = (e, v) => e.NUMBER_AT02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT03":
                        mapper[i] = (e, v) => e.NUMBER_AT03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT04":
                        mapper[i] = (e, v) => e.NUMBER_AT04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT05":
                        mapper[i] = (e, v) => e.NUMBER_AT05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT06":
                        mapper[i] = (e, v) => e.NUMBER_AT06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT07":
                        mapper[i] = (e, v) => e.NUMBER_AT07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT08":
                        mapper[i] = (e, v) => e.NUMBER_AT08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT09":
                        mapper[i] = (e, v) => e.NUMBER_AT09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT10":
                        mapper[i] = (e, v) => e.NUMBER_AT10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT11":
                        mapper[i] = (e, v) => e.NUMBER_AT11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT12":
                        mapper[i] = (e, v) => e.NUMBER_AT12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT13":
                        mapper[i] = (e, v) => e.NUMBER_AT13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT14":
                        mapper[i] = (e, v) => e.NUMBER_AT14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT15":
                        mapper[i] = (e, v) => e.NUMBER_AT15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT16":
                        mapper[i] = (e, v) => e.NUMBER_AT16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT17":
                        mapper[i] = (e, v) => e.NUMBER_AT17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT18":
                        mapper[i] = (e, v) => e.NUMBER_AT18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT19":
                        mapper[i] = (e, v) => e.NUMBER_AT19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT20":
                        mapper[i] = (e, v) => e.NUMBER_AT20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT21":
                        mapper[i] = (e, v) => e.NUMBER_AT21 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT22":
                        mapper[i] = (e, v) => e.NUMBER_AT22 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT23":
                        mapper[i] = (e, v) => e.NUMBER_AT23 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT24":
                        mapper[i] = (e, v) => e.NUMBER_AT24 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT25":
                        mapper[i] = (e, v) => e.NUMBER_AT25 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT26":
                        mapper[i] = (e, v) => e.NUMBER_AT26 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT27":
                        mapper[i] = (e, v) => e.NUMBER_AT27 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT28":
                        mapper[i] = (e, v) => e.NUMBER_AT28 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT29":
                        mapper[i] = (e, v) => e.NUMBER_AT29 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT30":
                        mapper[i] = (e, v) => e.NUMBER_AT30 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_NA":
                        mapper[i] = (e, v) => e.NO_NA = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOTAL_NUMBER":
                        mapper[i] = (e, v) => e.TOTAL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENT_TO_DEET":
                        mapper[i] = (e, v) => e.SENT_TO_DEET = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        private Lazy<Dictionary<int, SVAG>> Index_SVAGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_COHORT;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_SCHOOL_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_VDIMENSION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <returns>Related SVAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SVAG FindBySVAGKEY(int SVAGKEY)
        {
            return Index_SVAGKEY.Value[SVAGKEY];
        }

        /// <summary>
        /// Attempt to find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <param name="Value">Related SVAG entity</param>
        /// <returns>True if the related SVAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySVAGKEY(int SVAGKEY, out SVAG Value)
        {
            return Index_SVAGKEY.Value.TryGetValue(SVAGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <returns>Related SVAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SVAG TryFindBySVAGKEY(int SVAGKEY)
        {
            SVAG value;
            if (Index_SVAGKEY.Value.TryGetValue(SVAGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByCOHORT(string COHORT)
        {
            return Index_COHORT.Value[COHORT];
        }

        /// <summary>
        /// Attempt to find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOHORT(string COHORT, out IReadOnlyList<SVAG> Value)
        {
            return Index_COHORT.Value.TryGetValue(COHORT, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByCOHORT(string COHORT)
        {
            IReadOnlyList<SVAG> value;
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
        /// Find SVAG by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find SVAG by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<SVAG> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<SVAG> value;
            if (Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByVDIMENSION(string VDIMENSION)
        {
            return Index_VDIMENSION.Value[VDIMENSION];
        }

        /// <summary>
        /// Attempt to find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDIMENSION(string VDIMENSION, out IReadOnlyList<SVAG> Value)
        {
            return Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByVDIMENSION(string VDIMENSION)
        {
            IReadOnlyList<SVAG> value;
            if (Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out value))
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
