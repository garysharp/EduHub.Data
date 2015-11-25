using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domain Results Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDODataSet : SetBase<STVDO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STVDO"; } }

        internal STVDODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_TID = new Lazy<Dictionary<int, STVDO>>(() => this.ToDictionary(i => i.TID));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_VDOMAIN = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.VDOMAIN));
            Index_VDIMENSION = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.VDIMENSION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STVDO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STVDO" /> fields for each CSV column header</returns>
        protected override Action<STVDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STVDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
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
                    case "VDOMAIN":
                        mapper[i] = (e, v) => e.VDOMAIN = v;
                        break;
                    case "VDIMENSION":
                        mapper[i] = (e, v) => e.VDIMENSION = v;
                        break;
                    case "SCORE":
                        mapper[i] = (e, v) => e.SCORE = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STVDO>>> Index_SKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDO>>> Index_LW_DATE;
        private Lazy<Dictionary<int, STVDO>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_SCHOOL_YEAR;
        private Lazy<NullDictionary<int?, IReadOnlyList<STVDO>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_VDOMAIN;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_VDIMENSION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STVDO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STVDO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STVDO> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STVDO> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find STVDO by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<STVDO> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<STVDO> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO</param>
        /// <returns>Related STVDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STVDO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO</param>
        /// <param name="Value">Related STVDO entity</param>
        /// <returns>True if the related STVDO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STVDO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO</param>
        /// <returns>Related STVDO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO TryFindByTID(int TID)
        {
            STVDO value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find STVDO by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<STVDO> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<STVDO> value;
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
        /// Find STVDO by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find STVDO by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<STVDO> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<STVDO> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByVDOMAIN(string VDOMAIN)
        {
            return Index_VDOMAIN.Value[VDOMAIN];
        }

        /// <summary>
        /// Attempt to find STVDO by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDOMAIN(string VDOMAIN, out IReadOnlyList<STVDO> Value)
        {
            return Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByVDOMAIN(string VDOMAIN)
        {
            IReadOnlyList<STVDO> value;
            if (Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByVDIMENSION(string VDIMENSION)
        {
            return Index_VDIMENSION.Value[VDIMENSION];
        }

        /// <summary>
        /// Attempt to find STVDO by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDIMENSION(string VDIMENSION, out IReadOnlyList<STVDO> Value)
        {
            return Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByVDIMENSION(string VDIMENSION)
        {
            IReadOnlyList<STVDO> value;
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
