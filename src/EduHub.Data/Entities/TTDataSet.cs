using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTDataSet : EduHubDataSet<TT>
    {
        /// <inheritdoc />
        public override string Name { get { return "TT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_SUBJECT_ACADEMIC_YEAR01 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR01));
            Index_SUBJECT_ACADEMIC_YEAR02 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR02));
            Index_SUBJECT_ACADEMIC_YEAR03 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR03));
            Index_SUBJECT_ACADEMIC_YEAR04 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR04));
            Index_SUBJECT_ACADEMIC_YEAR05 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR05));
            Index_SUBJECT_ACADEMIC_YEAR06 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR06));
            Index_SUBJECT_ACADEMIC_YEAR07 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR07));
            Index_SUBJECT_ACADEMIC_YEAR08 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR08));
            Index_SUBJECT_ACADEMIC_YEAR09 = new Lazy<NullDictionary<string, IReadOnlyList<TT>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR09));
            Index_TTKEY = new Lazy<Dictionary<string, TT>>(() => this.ToDictionary(i => i.TTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TT" /> fields for each CSV column header</returns>
        internal override Action<TT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TTKEY":
                        mapper[i] = (e, v) => e.TTKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SELECTABLE":
                        mapper[i] = (e, v) => e.SELECTABLE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TAG01":
                        mapper[i] = (e, v) => e.TAG01 = v;
                        break;
                    case "TAG02":
                        mapper[i] = (e, v) => e.TAG02 = v;
                        break;
                    case "TAG03":
                        mapper[i] = (e, v) => e.TAG03 = v;
                        break;
                    case "TAG04":
                        mapper[i] = (e, v) => e.TAG04 = v;
                        break;
                    case "TAG05":
                        mapper[i] = (e, v) => e.TAG05 = v;
                        break;
                    case "TAG06":
                        mapper[i] = (e, v) => e.TAG06 = v;
                        break;
                    case "TAG07":
                        mapper[i] = (e, v) => e.TAG07 = v;
                        break;
                    case "TAG08":
                        mapper[i] = (e, v) => e.TAG08 = v;
                        break;
                    case "TAG09":
                        mapper[i] = (e, v) => e.TAG09 = v;
                        break;
                    case "TRPERIOD":
                        mapper[i] = (e, v) => e.TRPERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR01":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR01 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR02":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR02 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR03":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR03 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR04":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR04 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR05":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR05 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR06":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR06 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR07":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR07 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR08":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR08 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR09":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR09 = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RESERVE":
                        mapper[i] = (e, v) => e.RESERVE = v;
                        break;
                    case "COSET":
                        mapper[i] = (e, v) => e.COSET = v;
                        break;
                    case "MAXROW":
                        mapper[i] = (e, v) => e.MAXROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXCOL":
                        mapper[i] = (e, v) => e.MAXCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RELAX":
                        mapper[i] = (e, v) => e.RELAX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXDROP":
                        mapper[i] = (e, v) => e.MAXDROP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXSTORE":
                        mapper[i] = (e, v) => e.MAXSTORE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "UTEACH":
                        mapper[i] = (e, v) => e.UTEACH = v;
                        break;
                    case "UROOM":
                        mapper[i] = (e, v) => e.UROOM = v;
                        break;
                    case "URESOURCES":
                        mapper[i] = (e, v) => e.URESOURCES = v;
                        break;
                    case "UFIXED":
                        mapper[i] = (e, v) => e.UFIXED = v;
                        break;
                    case "ULINKS":
                        mapper[i] = (e, v) => e.ULINKS = v;
                        break;
                    case "UTIED":
                        mapper[i] = (e, v) => e.UTIED = v;
                        break;
                    case "URANGE":
                        mapper[i] = (e, v) => e.URANGE = v;
                        break;
                    case "STRATEGY":
                        mapper[i] = (e, v) => e.STRATEGY = v;
                        break;
                    case "GRIDSORT":
                        mapper[i] = (e, v) => e.GRIDSORT = v;
                        break;
                    case "SHARE":
                        mapper[i] = (e, v) => e.SHARE = v;
                        break;
                    case "SHUFFLE":
                        mapper[i] = (e, v) => e.SHUFFLE = v;
                        break;
                    case "UUNITS":
                        mapper[i] = (e, v) => e.UUNITS = v;
                        break;
                    case "GSOLS":
                        mapper[i] = (e, v) => e.GSOLS = null; // eduHub is not encoding byte arrays
                        break;
                    case "HOMEGRID":
                        mapper[i] = (e, v) => e.HOMEGRID = v;
                        break;
                    case "TEACHER_CLASH_FACTOR":
                        mapper[i] = (e, v) => e.TEACHER_CLASH_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROOM_CLASH_FACTOR":
                        mapper[i] = (e, v) => e.ROOM_CLASH_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RESOURCE_CLASH_FACTOR":
                        mapper[i] = (e, v) => e.RESOURCE_CLASH_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STUDENT_DROP_FACTOR":
                        mapper[i] = (e, v) => e.STUDENT_DROP_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_CLASS_SIZE":
                        mapper[i] = (e, v) => e.MAX_CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXTCLASH":
                        mapper[i] = (e, v) => e.MAXTCLASH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXRCLASH":
                        mapper[i] = (e, v) => e.MAXRCLASH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXXCLASH":
                        mapper[i] = (e, v) => e.MAXXCLASH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXBALANCE":
                        mapper[i] = (e, v) => e.MAXBALANCE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TT}"/> of entities</returns>
        internal override IEnumerable<TT> ApplyDeltaEntities(IEnumerable<TT> Entities, List<TT> DeltaEntities)
        {
            HashSet<string> Index_TTKEY = new HashSet<string>(DeltaEntities.Select(i => i.TTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TTKEY.Remove(entity.TTKEY);
                            
                            if (entity.TTKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<TT>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR01;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR02;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR03;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR04;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR05;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR06;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR07;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR08;
        private Lazy<NullDictionary<string, IReadOnlyList<TT>>> Index_SUBJECT_ACADEMIC_YEAR09;
        private Lazy<Dictionary<string, TT>> Index_TTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TT by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find TT by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<TT> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find TT by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<TT> value;
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
        /// Find TT by SUBJECT_ACADEMIC_YEAR01 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR01">SUBJECT_ACADEMIC_YEAR01 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR01(string SUBJECT_ACADEMIC_YEAR01)
        {
            return Index_SUBJECT_ACADEMIC_YEAR01.Value[SUBJECT_ACADEMIC_YEAR01];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR01 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR01">SUBJECT_ACADEMIC_YEAR01 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR01(string SUBJECT_ACADEMIC_YEAR01, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR01.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR01, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR01 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR01">SUBJECT_ACADEMIC_YEAR01 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR01(string SUBJECT_ACADEMIC_YEAR01)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR01.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR02 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR02">SUBJECT_ACADEMIC_YEAR02 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR02(string SUBJECT_ACADEMIC_YEAR02)
        {
            return Index_SUBJECT_ACADEMIC_YEAR02.Value[SUBJECT_ACADEMIC_YEAR02];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR02 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR02">SUBJECT_ACADEMIC_YEAR02 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR02(string SUBJECT_ACADEMIC_YEAR02, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR02.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR02, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR02 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR02">SUBJECT_ACADEMIC_YEAR02 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR02(string SUBJECT_ACADEMIC_YEAR02)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR02.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR03 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR03">SUBJECT_ACADEMIC_YEAR03 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR03(string SUBJECT_ACADEMIC_YEAR03)
        {
            return Index_SUBJECT_ACADEMIC_YEAR03.Value[SUBJECT_ACADEMIC_YEAR03];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR03 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR03">SUBJECT_ACADEMIC_YEAR03 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR03(string SUBJECT_ACADEMIC_YEAR03, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR03.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR03, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR03 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR03">SUBJECT_ACADEMIC_YEAR03 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR03(string SUBJECT_ACADEMIC_YEAR03)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR03.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR03, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR04 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR04">SUBJECT_ACADEMIC_YEAR04 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR04(string SUBJECT_ACADEMIC_YEAR04)
        {
            return Index_SUBJECT_ACADEMIC_YEAR04.Value[SUBJECT_ACADEMIC_YEAR04];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR04 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR04">SUBJECT_ACADEMIC_YEAR04 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR04(string SUBJECT_ACADEMIC_YEAR04, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR04.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR04, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR04 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR04">SUBJECT_ACADEMIC_YEAR04 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR04(string SUBJECT_ACADEMIC_YEAR04)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR04.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR04, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR05 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR05">SUBJECT_ACADEMIC_YEAR05 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR05(string SUBJECT_ACADEMIC_YEAR05)
        {
            return Index_SUBJECT_ACADEMIC_YEAR05.Value[SUBJECT_ACADEMIC_YEAR05];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR05 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR05">SUBJECT_ACADEMIC_YEAR05 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR05(string SUBJECT_ACADEMIC_YEAR05, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR05.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR05, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR05 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR05">SUBJECT_ACADEMIC_YEAR05 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR05(string SUBJECT_ACADEMIC_YEAR05)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR05.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR05, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR06 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR06">SUBJECT_ACADEMIC_YEAR06 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR06(string SUBJECT_ACADEMIC_YEAR06)
        {
            return Index_SUBJECT_ACADEMIC_YEAR06.Value[SUBJECT_ACADEMIC_YEAR06];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR06 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR06">SUBJECT_ACADEMIC_YEAR06 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR06(string SUBJECT_ACADEMIC_YEAR06, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR06.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR06, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR06 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR06">SUBJECT_ACADEMIC_YEAR06 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR06(string SUBJECT_ACADEMIC_YEAR06)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR06.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR06, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR07 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR07">SUBJECT_ACADEMIC_YEAR07 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR07(string SUBJECT_ACADEMIC_YEAR07)
        {
            return Index_SUBJECT_ACADEMIC_YEAR07.Value[SUBJECT_ACADEMIC_YEAR07];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR07 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR07">SUBJECT_ACADEMIC_YEAR07 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR07(string SUBJECT_ACADEMIC_YEAR07, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR07.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR07, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR07 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR07">SUBJECT_ACADEMIC_YEAR07 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR07(string SUBJECT_ACADEMIC_YEAR07)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR07.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR07, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR08 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR08">SUBJECT_ACADEMIC_YEAR08 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR08(string SUBJECT_ACADEMIC_YEAR08)
        {
            return Index_SUBJECT_ACADEMIC_YEAR08.Value[SUBJECT_ACADEMIC_YEAR08];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR08 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR08">SUBJECT_ACADEMIC_YEAR08 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR08(string SUBJECT_ACADEMIC_YEAR08, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR08.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR08, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR08 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR08">SUBJECT_ACADEMIC_YEAR08 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR08(string SUBJECT_ACADEMIC_YEAR08)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR08.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR08, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by SUBJECT_ACADEMIC_YEAR09 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR09">SUBJECT_ACADEMIC_YEAR09 value used to find TT</param>
        /// <returns>List of related TT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> FindBySUBJECT_ACADEMIC_YEAR09(string SUBJECT_ACADEMIC_YEAR09)
        {
            return Index_SUBJECT_ACADEMIC_YEAR09.Value[SUBJECT_ACADEMIC_YEAR09];
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR09 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR09">SUBJECT_ACADEMIC_YEAR09 value used to find TT</param>
        /// <param name="Value">List of related TT entities</param>
        /// <returns>True if the list of related TT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR09(string SUBJECT_ACADEMIC_YEAR09, out IReadOnlyList<TT> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR09.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR09, out Value);
        }

        /// <summary>
        /// Attempt to find TT by SUBJECT_ACADEMIC_YEAR09 field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR09">SUBJECT_ACADEMIC_YEAR09 value used to find TT</param>
        /// <returns>List of related TT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TT> TryFindBySUBJECT_ACADEMIC_YEAR09(string SUBJECT_ACADEMIC_YEAR09)
        {
            IReadOnlyList<TT> value;
            if (Index_SUBJECT_ACADEMIC_YEAR09.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR09, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TT by TTKEY field
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TT</param>
        /// <returns>Related TT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TT FindByTTKEY(string TTKEY)
        {
            return Index_TTKEY.Value[TTKEY];
        }

        /// <summary>
        /// Attempt to find TT by TTKEY field
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TT</param>
        /// <param name="Value">Related TT entity</param>
        /// <returns>True if the related TT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTTKEY(string TTKEY, out TT Value)
        {
            return Index_TTKEY.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TT by TTKEY field
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TT</param>
        /// <returns>Related TT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TT TryFindByTTKEY(string TTKEY)
        {
            TT value;
            if (Index_TTKEY.Value.TryGetValue(TTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TT](
        [TTKEY] varchar(8) NOT NULL,
        [TITLE] varchar(30) NULL,
        [SELECTABLE] varchar(1) NULL,
        [CAMPUS] int NULL,
        [TAG01] varchar(6) NULL,
        [TAG02] varchar(6) NULL,
        [TAG03] varchar(6) NULL,
        [TAG04] varchar(6) NULL,
        [TAG05] varchar(6) NULL,
        [TAG06] varchar(6) NULL,
        [TAG07] varchar(6) NULL,
        [TAG08] varchar(6) NULL,
        [TAG09] varchar(6) NULL,
        [TRPERIOD] int NULL,
        [TTPERIOD] varchar(8) NULL,
        [SUBJECT_ACADEMIC_YEAR01] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR02] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR03] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR04] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR05] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR06] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR07] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR08] varchar(4) NULL,
        [SUBJECT_ACADEMIC_YEAR09] varchar(4) NULL,
        [SEMESTER] smallint NULL,
        [RESERVE] varchar(8) NULL,
        [COSET] varchar(8) NULL,
        [MAXROW] smallint NULL,
        [MAXCOL] smallint NULL,
        [RELAX] smallint NULL,
        [MAXDROP] smallint NULL,
        [MAXSTORE] smallint NULL,
        [UTEACH] varchar(1) NULL,
        [UROOM] varchar(1) NULL,
        [URESOURCES] varchar(1) NULL,
        [UFIXED] varchar(1) NULL,
        [ULINKS] varchar(1) NULL,
        [UTIED] varchar(1) NULL,
        [URANGE] varchar(1) NULL,
        [STRATEGY] varchar(1) NULL,
        [GRIDSORT] varchar(1) NULL,
        [SHARE] varchar(1) NULL,
        [SHUFFLE] varchar(1) NULL,
        [UUNITS] varchar(1) NULL,
        [GSOLS] varbinary(MAX) NULL,
        [HOMEGRID] varchar(1) NULL,
        [TEACHER_CLASH_FACTOR] smallint NULL,
        [ROOM_CLASH_FACTOR] smallint NULL,
        [RESOURCE_CLASH_FACTOR] smallint NULL,
        [STUDENT_DROP_FACTOR] smallint NULL,
        [MAX_CLASS_SIZE] smallint NULL,
        [MAXTCLASH] smallint NULL,
        [MAXRCLASH] smallint NULL,
        [MAXXCLASH] smallint NULL,
        [MAXBALANCE] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TT_Index_TTKEY] PRIMARY KEY CLUSTERED (
            [TTKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TT_Index_CAMPUS] ON [dbo].[TT]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR01] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR01] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR02] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR02] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR03] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR03] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR04] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR04] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR05] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR05] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR06] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR06] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR07] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR07] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR08] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR08] ASC
    );
    CREATE NONCLUSTERED INDEX [TT_Index_SUBJECT_ACADEMIC_YEAR09] ON [dbo].[TT]
    (
            [SUBJECT_ACADEMIC_YEAR09] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR01')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR01] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR02')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR02] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR03')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR03] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR04')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR04] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR05')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR05] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR06')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR06] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR07')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR07] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR08')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR08] ON [dbo].[TT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR09')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR09] ON [dbo].[TT] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR01')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR01] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR02')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR02] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR03')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR03] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR04')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR04] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR05')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR05] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR06')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR06] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR07')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR07] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR08')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR08] ON [dbo].[TT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TT]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR09')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR09] ON [dbo].[TT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_TTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_TTKEY.Add(entity.TTKEY);
            }

            builder.AppendLine("DELETE [dbo].[TT] WHERE");


            // Index_TTKEY
            builder.Append("[TTKEY] IN (");
            for (int index = 0; index < Index_TTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TTKEY
                var parameterTTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterTTKEY);
                command.Parameters.Add(parameterTTKEY, SqlDbType.VarChar, 8).Value = Index_TTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TT data set</returns>
        public override EduHubDataSetDataReader<TT> GetDataSetDataReader()
        {
            return new TTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TT data set</returns>
        public override EduHubDataSetDataReader<TT> GetDataSetDataReader(List<TT> Entities)
        {
            return new TTDataReader(new EduHubDataSetLoadedReader<TT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTDataReader : EduHubDataSetDataReader<TT>
        {
            public TTDataReader(IEduHubDataSetReader<TT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 58; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TTKEY
                        return Current.TTKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // SELECTABLE
                        return Current.SELECTABLE;
                    case 3: // CAMPUS
                        return Current.CAMPUS;
                    case 4: // TAG01
                        return Current.TAG01;
                    case 5: // TAG02
                        return Current.TAG02;
                    case 6: // TAG03
                        return Current.TAG03;
                    case 7: // TAG04
                        return Current.TAG04;
                    case 8: // TAG05
                        return Current.TAG05;
                    case 9: // TAG06
                        return Current.TAG06;
                    case 10: // TAG07
                        return Current.TAG07;
                    case 11: // TAG08
                        return Current.TAG08;
                    case 12: // TAG09
                        return Current.TAG09;
                    case 13: // TRPERIOD
                        return Current.TRPERIOD;
                    case 14: // TTPERIOD
                        return Current.TTPERIOD;
                    case 15: // SUBJECT_ACADEMIC_YEAR01
                        return Current.SUBJECT_ACADEMIC_YEAR01;
                    case 16: // SUBJECT_ACADEMIC_YEAR02
                        return Current.SUBJECT_ACADEMIC_YEAR02;
                    case 17: // SUBJECT_ACADEMIC_YEAR03
                        return Current.SUBJECT_ACADEMIC_YEAR03;
                    case 18: // SUBJECT_ACADEMIC_YEAR04
                        return Current.SUBJECT_ACADEMIC_YEAR04;
                    case 19: // SUBJECT_ACADEMIC_YEAR05
                        return Current.SUBJECT_ACADEMIC_YEAR05;
                    case 20: // SUBJECT_ACADEMIC_YEAR06
                        return Current.SUBJECT_ACADEMIC_YEAR06;
                    case 21: // SUBJECT_ACADEMIC_YEAR07
                        return Current.SUBJECT_ACADEMIC_YEAR07;
                    case 22: // SUBJECT_ACADEMIC_YEAR08
                        return Current.SUBJECT_ACADEMIC_YEAR08;
                    case 23: // SUBJECT_ACADEMIC_YEAR09
                        return Current.SUBJECT_ACADEMIC_YEAR09;
                    case 24: // SEMESTER
                        return Current.SEMESTER;
                    case 25: // RESERVE
                        return Current.RESERVE;
                    case 26: // COSET
                        return Current.COSET;
                    case 27: // MAXROW
                        return Current.MAXROW;
                    case 28: // MAXCOL
                        return Current.MAXCOL;
                    case 29: // RELAX
                        return Current.RELAX;
                    case 30: // MAXDROP
                        return Current.MAXDROP;
                    case 31: // MAXSTORE
                        return Current.MAXSTORE;
                    case 32: // UTEACH
                        return Current.UTEACH;
                    case 33: // UROOM
                        return Current.UROOM;
                    case 34: // URESOURCES
                        return Current.URESOURCES;
                    case 35: // UFIXED
                        return Current.UFIXED;
                    case 36: // ULINKS
                        return Current.ULINKS;
                    case 37: // UTIED
                        return Current.UTIED;
                    case 38: // URANGE
                        return Current.URANGE;
                    case 39: // STRATEGY
                        return Current.STRATEGY;
                    case 40: // GRIDSORT
                        return Current.GRIDSORT;
                    case 41: // SHARE
                        return Current.SHARE;
                    case 42: // SHUFFLE
                        return Current.SHUFFLE;
                    case 43: // UUNITS
                        return Current.UUNITS;
                    case 44: // GSOLS
                        return Current.GSOLS;
                    case 45: // HOMEGRID
                        return Current.HOMEGRID;
                    case 46: // TEACHER_CLASH_FACTOR
                        return Current.TEACHER_CLASH_FACTOR;
                    case 47: // ROOM_CLASH_FACTOR
                        return Current.ROOM_CLASH_FACTOR;
                    case 48: // RESOURCE_CLASH_FACTOR
                        return Current.RESOURCE_CLASH_FACTOR;
                    case 49: // STUDENT_DROP_FACTOR
                        return Current.STUDENT_DROP_FACTOR;
                    case 50: // MAX_CLASS_SIZE
                        return Current.MAX_CLASS_SIZE;
                    case 51: // MAXTCLASH
                        return Current.MAXTCLASH;
                    case 52: // MAXRCLASH
                        return Current.MAXRCLASH;
                    case 53: // MAXXCLASH
                        return Current.MAXXCLASH;
                    case 54: // MAXBALANCE
                        return Current.MAXBALANCE;
                    case 55: // LW_DATE
                        return Current.LW_DATE;
                    case 56: // LW_TIME
                        return Current.LW_TIME;
                    case 57: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // SELECTABLE
                        return Current.SELECTABLE == null;
                    case 3: // CAMPUS
                        return Current.CAMPUS == null;
                    case 4: // TAG01
                        return Current.TAG01 == null;
                    case 5: // TAG02
                        return Current.TAG02 == null;
                    case 6: // TAG03
                        return Current.TAG03 == null;
                    case 7: // TAG04
                        return Current.TAG04 == null;
                    case 8: // TAG05
                        return Current.TAG05 == null;
                    case 9: // TAG06
                        return Current.TAG06 == null;
                    case 10: // TAG07
                        return Current.TAG07 == null;
                    case 11: // TAG08
                        return Current.TAG08 == null;
                    case 12: // TAG09
                        return Current.TAG09 == null;
                    case 13: // TRPERIOD
                        return Current.TRPERIOD == null;
                    case 14: // TTPERIOD
                        return Current.TTPERIOD == null;
                    case 15: // SUBJECT_ACADEMIC_YEAR01
                        return Current.SUBJECT_ACADEMIC_YEAR01 == null;
                    case 16: // SUBJECT_ACADEMIC_YEAR02
                        return Current.SUBJECT_ACADEMIC_YEAR02 == null;
                    case 17: // SUBJECT_ACADEMIC_YEAR03
                        return Current.SUBJECT_ACADEMIC_YEAR03 == null;
                    case 18: // SUBJECT_ACADEMIC_YEAR04
                        return Current.SUBJECT_ACADEMIC_YEAR04 == null;
                    case 19: // SUBJECT_ACADEMIC_YEAR05
                        return Current.SUBJECT_ACADEMIC_YEAR05 == null;
                    case 20: // SUBJECT_ACADEMIC_YEAR06
                        return Current.SUBJECT_ACADEMIC_YEAR06 == null;
                    case 21: // SUBJECT_ACADEMIC_YEAR07
                        return Current.SUBJECT_ACADEMIC_YEAR07 == null;
                    case 22: // SUBJECT_ACADEMIC_YEAR08
                        return Current.SUBJECT_ACADEMIC_YEAR08 == null;
                    case 23: // SUBJECT_ACADEMIC_YEAR09
                        return Current.SUBJECT_ACADEMIC_YEAR09 == null;
                    case 24: // SEMESTER
                        return Current.SEMESTER == null;
                    case 25: // RESERVE
                        return Current.RESERVE == null;
                    case 26: // COSET
                        return Current.COSET == null;
                    case 27: // MAXROW
                        return Current.MAXROW == null;
                    case 28: // MAXCOL
                        return Current.MAXCOL == null;
                    case 29: // RELAX
                        return Current.RELAX == null;
                    case 30: // MAXDROP
                        return Current.MAXDROP == null;
                    case 31: // MAXSTORE
                        return Current.MAXSTORE == null;
                    case 32: // UTEACH
                        return Current.UTEACH == null;
                    case 33: // UROOM
                        return Current.UROOM == null;
                    case 34: // URESOURCES
                        return Current.URESOURCES == null;
                    case 35: // UFIXED
                        return Current.UFIXED == null;
                    case 36: // ULINKS
                        return Current.ULINKS == null;
                    case 37: // UTIED
                        return Current.UTIED == null;
                    case 38: // URANGE
                        return Current.URANGE == null;
                    case 39: // STRATEGY
                        return Current.STRATEGY == null;
                    case 40: // GRIDSORT
                        return Current.GRIDSORT == null;
                    case 41: // SHARE
                        return Current.SHARE == null;
                    case 42: // SHUFFLE
                        return Current.SHUFFLE == null;
                    case 43: // UUNITS
                        return Current.UUNITS == null;
                    case 44: // GSOLS
                        return Current.GSOLS == null;
                    case 45: // HOMEGRID
                        return Current.HOMEGRID == null;
                    case 46: // TEACHER_CLASH_FACTOR
                        return Current.TEACHER_CLASH_FACTOR == null;
                    case 47: // ROOM_CLASH_FACTOR
                        return Current.ROOM_CLASH_FACTOR == null;
                    case 48: // RESOURCE_CLASH_FACTOR
                        return Current.RESOURCE_CLASH_FACTOR == null;
                    case 49: // STUDENT_DROP_FACTOR
                        return Current.STUDENT_DROP_FACTOR == null;
                    case 50: // MAX_CLASS_SIZE
                        return Current.MAX_CLASS_SIZE == null;
                    case 51: // MAXTCLASH
                        return Current.MAXTCLASH == null;
                    case 52: // MAXRCLASH
                        return Current.MAXRCLASH == null;
                    case 53: // MAXXCLASH
                        return Current.MAXXCLASH == null;
                    case 54: // MAXBALANCE
                        return Current.MAXBALANCE == null;
                    case 55: // LW_DATE
                        return Current.LW_DATE == null;
                    case 56: // LW_TIME
                        return Current.LW_TIME == null;
                    case 57: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TTKEY
                        return "TTKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SELECTABLE
                        return "SELECTABLE";
                    case 3: // CAMPUS
                        return "CAMPUS";
                    case 4: // TAG01
                        return "TAG01";
                    case 5: // TAG02
                        return "TAG02";
                    case 6: // TAG03
                        return "TAG03";
                    case 7: // TAG04
                        return "TAG04";
                    case 8: // TAG05
                        return "TAG05";
                    case 9: // TAG06
                        return "TAG06";
                    case 10: // TAG07
                        return "TAG07";
                    case 11: // TAG08
                        return "TAG08";
                    case 12: // TAG09
                        return "TAG09";
                    case 13: // TRPERIOD
                        return "TRPERIOD";
                    case 14: // TTPERIOD
                        return "TTPERIOD";
                    case 15: // SUBJECT_ACADEMIC_YEAR01
                        return "SUBJECT_ACADEMIC_YEAR01";
                    case 16: // SUBJECT_ACADEMIC_YEAR02
                        return "SUBJECT_ACADEMIC_YEAR02";
                    case 17: // SUBJECT_ACADEMIC_YEAR03
                        return "SUBJECT_ACADEMIC_YEAR03";
                    case 18: // SUBJECT_ACADEMIC_YEAR04
                        return "SUBJECT_ACADEMIC_YEAR04";
                    case 19: // SUBJECT_ACADEMIC_YEAR05
                        return "SUBJECT_ACADEMIC_YEAR05";
                    case 20: // SUBJECT_ACADEMIC_YEAR06
                        return "SUBJECT_ACADEMIC_YEAR06";
                    case 21: // SUBJECT_ACADEMIC_YEAR07
                        return "SUBJECT_ACADEMIC_YEAR07";
                    case 22: // SUBJECT_ACADEMIC_YEAR08
                        return "SUBJECT_ACADEMIC_YEAR08";
                    case 23: // SUBJECT_ACADEMIC_YEAR09
                        return "SUBJECT_ACADEMIC_YEAR09";
                    case 24: // SEMESTER
                        return "SEMESTER";
                    case 25: // RESERVE
                        return "RESERVE";
                    case 26: // COSET
                        return "COSET";
                    case 27: // MAXROW
                        return "MAXROW";
                    case 28: // MAXCOL
                        return "MAXCOL";
                    case 29: // RELAX
                        return "RELAX";
                    case 30: // MAXDROP
                        return "MAXDROP";
                    case 31: // MAXSTORE
                        return "MAXSTORE";
                    case 32: // UTEACH
                        return "UTEACH";
                    case 33: // UROOM
                        return "UROOM";
                    case 34: // URESOURCES
                        return "URESOURCES";
                    case 35: // UFIXED
                        return "UFIXED";
                    case 36: // ULINKS
                        return "ULINKS";
                    case 37: // UTIED
                        return "UTIED";
                    case 38: // URANGE
                        return "URANGE";
                    case 39: // STRATEGY
                        return "STRATEGY";
                    case 40: // GRIDSORT
                        return "GRIDSORT";
                    case 41: // SHARE
                        return "SHARE";
                    case 42: // SHUFFLE
                        return "SHUFFLE";
                    case 43: // UUNITS
                        return "UUNITS";
                    case 44: // GSOLS
                        return "GSOLS";
                    case 45: // HOMEGRID
                        return "HOMEGRID";
                    case 46: // TEACHER_CLASH_FACTOR
                        return "TEACHER_CLASH_FACTOR";
                    case 47: // ROOM_CLASH_FACTOR
                        return "ROOM_CLASH_FACTOR";
                    case 48: // RESOURCE_CLASH_FACTOR
                        return "RESOURCE_CLASH_FACTOR";
                    case 49: // STUDENT_DROP_FACTOR
                        return "STUDENT_DROP_FACTOR";
                    case 50: // MAX_CLASS_SIZE
                        return "MAX_CLASS_SIZE";
                    case 51: // MAXTCLASH
                        return "MAXTCLASH";
                    case 52: // MAXRCLASH
                        return "MAXRCLASH";
                    case 53: // MAXXCLASH
                        return "MAXXCLASH";
                    case 54: // MAXBALANCE
                        return "MAXBALANCE";
                    case 55: // LW_DATE
                        return "LW_DATE";
                    case 56: // LW_TIME
                        return "LW_TIME";
                    case 57: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TTKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SELECTABLE":
                        return 2;
                    case "CAMPUS":
                        return 3;
                    case "TAG01":
                        return 4;
                    case "TAG02":
                        return 5;
                    case "TAG03":
                        return 6;
                    case "TAG04":
                        return 7;
                    case "TAG05":
                        return 8;
                    case "TAG06":
                        return 9;
                    case "TAG07":
                        return 10;
                    case "TAG08":
                        return 11;
                    case "TAG09":
                        return 12;
                    case "TRPERIOD":
                        return 13;
                    case "TTPERIOD":
                        return 14;
                    case "SUBJECT_ACADEMIC_YEAR01":
                        return 15;
                    case "SUBJECT_ACADEMIC_YEAR02":
                        return 16;
                    case "SUBJECT_ACADEMIC_YEAR03":
                        return 17;
                    case "SUBJECT_ACADEMIC_YEAR04":
                        return 18;
                    case "SUBJECT_ACADEMIC_YEAR05":
                        return 19;
                    case "SUBJECT_ACADEMIC_YEAR06":
                        return 20;
                    case "SUBJECT_ACADEMIC_YEAR07":
                        return 21;
                    case "SUBJECT_ACADEMIC_YEAR08":
                        return 22;
                    case "SUBJECT_ACADEMIC_YEAR09":
                        return 23;
                    case "SEMESTER":
                        return 24;
                    case "RESERVE":
                        return 25;
                    case "COSET":
                        return 26;
                    case "MAXROW":
                        return 27;
                    case "MAXCOL":
                        return 28;
                    case "RELAX":
                        return 29;
                    case "MAXDROP":
                        return 30;
                    case "MAXSTORE":
                        return 31;
                    case "UTEACH":
                        return 32;
                    case "UROOM":
                        return 33;
                    case "URESOURCES":
                        return 34;
                    case "UFIXED":
                        return 35;
                    case "ULINKS":
                        return 36;
                    case "UTIED":
                        return 37;
                    case "URANGE":
                        return 38;
                    case "STRATEGY":
                        return 39;
                    case "GRIDSORT":
                        return 40;
                    case "SHARE":
                        return 41;
                    case "SHUFFLE":
                        return 42;
                    case "UUNITS":
                        return 43;
                    case "GSOLS":
                        return 44;
                    case "HOMEGRID":
                        return 45;
                    case "TEACHER_CLASH_FACTOR":
                        return 46;
                    case "ROOM_CLASH_FACTOR":
                        return 47;
                    case "RESOURCE_CLASH_FACTOR":
                        return 48;
                    case "STUDENT_DROP_FACTOR":
                        return 49;
                    case "MAX_CLASS_SIZE":
                        return 50;
                    case "MAXTCLASH":
                        return 51;
                    case "MAXRCLASH":
                        return 52;
                    case "MAXXCLASH":
                        return 53;
                    case "MAXBALANCE":
                        return 54;
                    case "LW_DATE":
                        return 55;
                    case "LW_TIME":
                        return 56;
                    case "LW_USER":
                        return 57;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
