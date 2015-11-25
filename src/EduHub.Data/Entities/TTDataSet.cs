using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTDataSet : SetBase<TT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TT"; } }

        internal TTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TTKEY = new Lazy<Dictionary<string, TT>>(() => this.ToDictionary(i => i.TTKEY));
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
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TT" /> fields for each CSV column header</returns>
        protected override Action<TT, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        #region Index Fields

        private Lazy<Dictionary<string, TT>> Index_TTKEY;
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

        #endregion

        #region Index Methods

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

        #endregion

    }
}
