using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUDataSet : SetBase<SU>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SU"; } }

        internal SUDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FACULTY = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_PROMOTE = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.PROMOTE));
            Index_SUBJECT_ACADEMIC_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR));
            Index_SUKEY = new Lazy<Dictionary<string, SU>>(() => this.ToDictionary(i => i.SUKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SU" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SU" /> fields for each CSV column header</returns>
        protected override Action<SU, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SU, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUKEY":
                        mapper[i] = (e, v) => e.SUKEY = v;
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "SHORTNAME":
                        mapper[i] = (e, v) => e.SHORTNAME = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "PROMOTE":
                        mapper[i] = (e, v) => e.PROMOTE = v;
                        break;
                    case "OVERVIEW":
                        mapper[i] = (e, v) => e.OVERVIEW = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUBJECT_ACADEMIC_YEAR":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DURATION":
                        mapper[i] = (e, v) => e.DURATION = v;
                        break;
                    case "SUBJECT_TYPE":
                        mapper[i] = (e, v) => e.SUBJECT_TYPE = v;
                        break;
                    case "PRINT_SEQ_NO":
                        mapper[i] = (e, v) => e.PRINT_SEQ_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ELECTIVE":
                        mapper[i] = (e, v) => e.ELECTIVE = v;
                        break;
                    case "VCAA_ID":
                        mapper[i] = (e, v) => e.VCAA_ID = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
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

        /// <summary>
        /// Merges <see cref="SU" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SU" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SU" /> items to added or update the base <see cref="SU" /> items</param>
        /// <returns>A merged list of <see cref="SU" /> items</returns>
        protected override List<SU> ApplyDeltaItems(List<SU> Items, List<SU> DeltaItems)
        {
            Dictionary<string, int> Index_SUKEY = Items.ToIndexDictionary(i => i.SUKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SU deltaItem in DeltaItems)
            {
                int index;

                if (Index_SUKEY.TryGetValue(deltaItem.SUKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SUKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_FACULTY;
        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_FEE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_PROMOTE;
        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_SUBJECT_ACADEMIC_YEAR;
        private Lazy<Dictionary<string, SU>> Index_SUKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SU by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindByFACULTY(string FACULTY)
        {
            return Index_FACULTY.Value[FACULTY];
        }

        /// <summary>
        /// Attempt to find SU by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY(string FACULTY, out IReadOnlyList<SU> Value)
        {
            return Index_FACULTY.Value.TryGetValue(FACULTY, out Value);
        }

        /// <summary>
        /// Attempt to find SU by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindByFACULTY(string FACULTY)
        {
            IReadOnlyList<SU> value;
            if (Index_FACULTY.Value.TryGetValue(FACULTY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find SU by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<SU> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SU by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<SU> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by PROMOTE field
        /// </summary>
        /// <param name="PROMOTE">PROMOTE value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindByPROMOTE(string PROMOTE)
        {
            return Index_PROMOTE.Value[PROMOTE];
        }

        /// <summary>
        /// Attempt to find SU by PROMOTE field
        /// </summary>
        /// <param name="PROMOTE">PROMOTE value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPROMOTE(string PROMOTE, out IReadOnlyList<SU> Value)
        {
            return Index_PROMOTE.Value.TryGetValue(PROMOTE, out Value);
        }

        /// <summary>
        /// Attempt to find SU by PROMOTE field
        /// </summary>
        /// <param name="PROMOTE">PROMOTE value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindByPROMOTE(string PROMOTE)
        {
            IReadOnlyList<SU> value;
            if (Index_PROMOTE.Value.TryGetValue(PROMOTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR)
        {
            return Index_SUBJECT_ACADEMIC_YEAR.Value[SUBJECT_ACADEMIC_YEAR];
        }

        /// <summary>
        /// Attempt to find SU by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR, out IReadOnlyList<SU> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find SU by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR)
        {
            IReadOnlyList<SU> value;
            if (Index_SUBJECT_ACADEMIC_YEAR.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by SUKEY field
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU</param>
        /// <returns>Related SU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SU FindBySUKEY(string SUKEY)
        {
            return Index_SUKEY.Value[SUKEY];
        }

        /// <summary>
        /// Attempt to find SU by SUKEY field
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU</param>
        /// <param name="Value">Related SU entity</param>
        /// <returns>True if the related SU entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUKEY(string SUKEY, out SU Value)
        {
            return Index_SUKEY.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SU by SUKEY field
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU</param>
        /// <returns>Related SU entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SU TryFindBySUKEY(string SUKEY)
        {
            SU value;
            if (Index_SUKEY.Value.TryGetValue(SUKEY, out value))
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
