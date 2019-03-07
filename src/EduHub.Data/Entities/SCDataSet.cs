using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Courses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCDataSet : EduHubDataSet<SC>
    {
        /// <inheritdoc />
        public override string Name { get { return "SC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COURSE = new Lazy<Dictionary<string, SC>>(() => this.ToDictionary(i => i.COURSE));
            Index_SUBJ01 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ01));
            Index_SUBJ02 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ02));
            Index_SUBJ03 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ03));
            Index_SUBJ04 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ04));
            Index_SUBJ05 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ05));
            Index_SUBJ06 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ06));
            Index_SUBJ07 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ07));
            Index_SUBJ08 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ08));
            Index_SUBJ09 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ09));
            Index_SUBJ10 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ10));
            Index_SUBJ11 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ11));
            Index_SUBJ12 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ12));
            Index_SUBJ13 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ13));
            Index_SUBJ14 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ14));
            Index_SUBJ15 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ15));
            Index_SUBJ16 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ16));
            Index_SUBJ17 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ17));
            Index_SUBJ18 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ18));
            Index_SUBJ19 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ19));
            Index_SUBJ20 = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ20));
            Index_SUBJECT_ACADEMIC_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<SC>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SC" /> fields for each CSV column header</returns>
        internal override Action<SC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COURSE":
                        mapper[i] = (e, v) => e.COURSE = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "SUBJ01":
                        mapper[i] = (e, v) => e.SUBJ01 = v;
                        break;
                    case "SUBJ02":
                        mapper[i] = (e, v) => e.SUBJ02 = v;
                        break;
                    case "SUBJ03":
                        mapper[i] = (e, v) => e.SUBJ03 = v;
                        break;
                    case "SUBJ04":
                        mapper[i] = (e, v) => e.SUBJ04 = v;
                        break;
                    case "SUBJ05":
                        mapper[i] = (e, v) => e.SUBJ05 = v;
                        break;
                    case "SUBJ06":
                        mapper[i] = (e, v) => e.SUBJ06 = v;
                        break;
                    case "SUBJ07":
                        mapper[i] = (e, v) => e.SUBJ07 = v;
                        break;
                    case "SUBJ08":
                        mapper[i] = (e, v) => e.SUBJ08 = v;
                        break;
                    case "SUBJ09":
                        mapper[i] = (e, v) => e.SUBJ09 = v;
                        break;
                    case "SUBJ10":
                        mapper[i] = (e, v) => e.SUBJ10 = v;
                        break;
                    case "SUBJ11":
                        mapper[i] = (e, v) => e.SUBJ11 = v;
                        break;
                    case "SUBJ12":
                        mapper[i] = (e, v) => e.SUBJ12 = v;
                        break;
                    case "SUBJ13":
                        mapper[i] = (e, v) => e.SUBJ13 = v;
                        break;
                    case "SUBJ14":
                        mapper[i] = (e, v) => e.SUBJ14 = v;
                        break;
                    case "SUBJ15":
                        mapper[i] = (e, v) => e.SUBJ15 = v;
                        break;
                    case "SUBJ16":
                        mapper[i] = (e, v) => e.SUBJ16 = v;
                        break;
                    case "SUBJ17":
                        mapper[i] = (e, v) => e.SUBJ17 = v;
                        break;
                    case "SUBJ18":
                        mapper[i] = (e, v) => e.SUBJ18 = v;
                        break;
                    case "SUBJ19":
                        mapper[i] = (e, v) => e.SUBJ19 = v;
                        break;
                    case "SUBJ20":
                        mapper[i] = (e, v) => e.SUBJ20 = v;
                        break;
                    case "CLASS01":
                        mapper[i] = (e, v) => e.CLASS01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS02":
                        mapper[i] = (e, v) => e.CLASS02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS03":
                        mapper[i] = (e, v) => e.CLASS03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS04":
                        mapper[i] = (e, v) => e.CLASS04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS05":
                        mapper[i] = (e, v) => e.CLASS05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS06":
                        mapper[i] = (e, v) => e.CLASS06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS07":
                        mapper[i] = (e, v) => e.CLASS07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS08":
                        mapper[i] = (e, v) => e.CLASS08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS09":
                        mapper[i] = (e, v) => e.CLASS09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS10":
                        mapper[i] = (e, v) => e.CLASS10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS11":
                        mapper[i] = (e, v) => e.CLASS11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS12":
                        mapper[i] = (e, v) => e.CLASS12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS13":
                        mapper[i] = (e, v) => e.CLASS13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS14":
                        mapper[i] = (e, v) => e.CLASS14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS15":
                        mapper[i] = (e, v) => e.CLASS15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS16":
                        mapper[i] = (e, v) => e.CLASS16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS17":
                        mapper[i] = (e, v) => e.CLASS17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS18":
                        mapper[i] = (e, v) => e.CLASS18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS19":
                        mapper[i] = (e, v) => e.CLASS19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS20":
                        mapper[i] = (e, v) => e.CLASS20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LOCK01":
                        mapper[i] = (e, v) => e.LOCK01 = v;
                        break;
                    case "LOCK02":
                        mapper[i] = (e, v) => e.LOCK02 = v;
                        break;
                    case "LOCK03":
                        mapper[i] = (e, v) => e.LOCK03 = v;
                        break;
                    case "LOCK04":
                        mapper[i] = (e, v) => e.LOCK04 = v;
                        break;
                    case "LOCK05":
                        mapper[i] = (e, v) => e.LOCK05 = v;
                        break;
                    case "LOCK06":
                        mapper[i] = (e, v) => e.LOCK06 = v;
                        break;
                    case "LOCK07":
                        mapper[i] = (e, v) => e.LOCK07 = v;
                        break;
                    case "LOCK08":
                        mapper[i] = (e, v) => e.LOCK08 = v;
                        break;
                    case "LOCK09":
                        mapper[i] = (e, v) => e.LOCK09 = v;
                        break;
                    case "LOCK10":
                        mapper[i] = (e, v) => e.LOCK10 = v;
                        break;
                    case "LOCK11":
                        mapper[i] = (e, v) => e.LOCK11 = v;
                        break;
                    case "LOCK12":
                        mapper[i] = (e, v) => e.LOCK12 = v;
                        break;
                    case "LOCK13":
                        mapper[i] = (e, v) => e.LOCK13 = v;
                        break;
                    case "LOCK14":
                        mapper[i] = (e, v) => e.LOCK14 = v;
                        break;
                    case "LOCK15":
                        mapper[i] = (e, v) => e.LOCK15 = v;
                        break;
                    case "LOCK16":
                        mapper[i] = (e, v) => e.LOCK16 = v;
                        break;
                    case "LOCK17":
                        mapper[i] = (e, v) => e.LOCK17 = v;
                        break;
                    case "LOCK18":
                        mapper[i] = (e, v) => e.LOCK18 = v;
                        break;
                    case "LOCK19":
                        mapper[i] = (e, v) => e.LOCK19 = v;
                        break;
                    case "LOCK20":
                        mapper[i] = (e, v) => e.LOCK20 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SC}"/> of entities</returns>
        internal override IEnumerable<SC> ApplyDeltaEntities(IEnumerable<SC> Entities, List<SC> DeltaEntities)
        {
            HashSet<string> Index_COURSE = new HashSet<string>(DeltaEntities.Select(i => i.COURSE));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.COURSE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_COURSE.Remove(entity.COURSE);
                            
                            if (entity.COURSE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SC>> Index_COURSE;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ01;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ02;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ03;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ04;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ05;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ06;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ07;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ08;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ09;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ10;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ11;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ12;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ13;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ14;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ15;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ16;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ17;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ18;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ19;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJ20;
        private Lazy<NullDictionary<string, IReadOnlyList<SC>>> Index_SUBJECT_ACADEMIC_YEAR;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SC by COURSE field
        /// </summary>
        /// <param name="COURSE">COURSE value used to find SC</param>
        /// <returns>Related SC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SC FindByCOURSE(string COURSE)
        {
            return Index_COURSE.Value[COURSE];
        }

        /// <summary>
        /// Attempt to find SC by COURSE field
        /// </summary>
        /// <param name="COURSE">COURSE value used to find SC</param>
        /// <param name="Value">Related SC entity</param>
        /// <returns>True if the related SC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOURSE(string COURSE, out SC Value)
        {
            return Index_COURSE.Value.TryGetValue(COURSE, out Value);
        }

        /// <summary>
        /// Attempt to find SC by COURSE field
        /// </summary>
        /// <param name="COURSE">COURSE value used to find SC</param>
        /// <returns>Related SC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SC TryFindByCOURSE(string COURSE)
        {
            SC value;
            if (Index_COURSE.Value.TryGetValue(COURSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ01 field
        /// </summary>
        /// <param name="SUBJ01">SUBJ01 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ01(string SUBJ01)
        {
            return Index_SUBJ01.Value[SUBJ01];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ01 field
        /// </summary>
        /// <param name="SUBJ01">SUBJ01 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ01(string SUBJ01, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ01.Value.TryGetValue(SUBJ01, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ01 field
        /// </summary>
        /// <param name="SUBJ01">SUBJ01 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ01(string SUBJ01)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ01.Value.TryGetValue(SUBJ01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ02 field
        /// </summary>
        /// <param name="SUBJ02">SUBJ02 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ02(string SUBJ02)
        {
            return Index_SUBJ02.Value[SUBJ02];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ02 field
        /// </summary>
        /// <param name="SUBJ02">SUBJ02 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ02(string SUBJ02, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ02.Value.TryGetValue(SUBJ02, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ02 field
        /// </summary>
        /// <param name="SUBJ02">SUBJ02 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ02(string SUBJ02)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ02.Value.TryGetValue(SUBJ02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ03 field
        /// </summary>
        /// <param name="SUBJ03">SUBJ03 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ03(string SUBJ03)
        {
            return Index_SUBJ03.Value[SUBJ03];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ03 field
        /// </summary>
        /// <param name="SUBJ03">SUBJ03 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ03(string SUBJ03, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ03.Value.TryGetValue(SUBJ03, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ03 field
        /// </summary>
        /// <param name="SUBJ03">SUBJ03 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ03(string SUBJ03)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ03.Value.TryGetValue(SUBJ03, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ04 field
        /// </summary>
        /// <param name="SUBJ04">SUBJ04 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ04(string SUBJ04)
        {
            return Index_SUBJ04.Value[SUBJ04];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ04 field
        /// </summary>
        /// <param name="SUBJ04">SUBJ04 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ04(string SUBJ04, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ04.Value.TryGetValue(SUBJ04, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ04 field
        /// </summary>
        /// <param name="SUBJ04">SUBJ04 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ04(string SUBJ04)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ04.Value.TryGetValue(SUBJ04, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ05 field
        /// </summary>
        /// <param name="SUBJ05">SUBJ05 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ05(string SUBJ05)
        {
            return Index_SUBJ05.Value[SUBJ05];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ05 field
        /// </summary>
        /// <param name="SUBJ05">SUBJ05 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ05(string SUBJ05, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ05.Value.TryGetValue(SUBJ05, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ05 field
        /// </summary>
        /// <param name="SUBJ05">SUBJ05 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ05(string SUBJ05)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ05.Value.TryGetValue(SUBJ05, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ06 field
        /// </summary>
        /// <param name="SUBJ06">SUBJ06 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ06(string SUBJ06)
        {
            return Index_SUBJ06.Value[SUBJ06];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ06 field
        /// </summary>
        /// <param name="SUBJ06">SUBJ06 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ06(string SUBJ06, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ06.Value.TryGetValue(SUBJ06, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ06 field
        /// </summary>
        /// <param name="SUBJ06">SUBJ06 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ06(string SUBJ06)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ06.Value.TryGetValue(SUBJ06, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ07 field
        /// </summary>
        /// <param name="SUBJ07">SUBJ07 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ07(string SUBJ07)
        {
            return Index_SUBJ07.Value[SUBJ07];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ07 field
        /// </summary>
        /// <param name="SUBJ07">SUBJ07 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ07(string SUBJ07, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ07.Value.TryGetValue(SUBJ07, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ07 field
        /// </summary>
        /// <param name="SUBJ07">SUBJ07 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ07(string SUBJ07)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ07.Value.TryGetValue(SUBJ07, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ08 field
        /// </summary>
        /// <param name="SUBJ08">SUBJ08 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ08(string SUBJ08)
        {
            return Index_SUBJ08.Value[SUBJ08];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ08 field
        /// </summary>
        /// <param name="SUBJ08">SUBJ08 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ08(string SUBJ08, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ08.Value.TryGetValue(SUBJ08, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ08 field
        /// </summary>
        /// <param name="SUBJ08">SUBJ08 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ08(string SUBJ08)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ08.Value.TryGetValue(SUBJ08, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ09 field
        /// </summary>
        /// <param name="SUBJ09">SUBJ09 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ09(string SUBJ09)
        {
            return Index_SUBJ09.Value[SUBJ09];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ09 field
        /// </summary>
        /// <param name="SUBJ09">SUBJ09 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ09(string SUBJ09, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ09.Value.TryGetValue(SUBJ09, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ09 field
        /// </summary>
        /// <param name="SUBJ09">SUBJ09 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ09(string SUBJ09)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ09.Value.TryGetValue(SUBJ09, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ10 field
        /// </summary>
        /// <param name="SUBJ10">SUBJ10 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ10(string SUBJ10)
        {
            return Index_SUBJ10.Value[SUBJ10];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ10 field
        /// </summary>
        /// <param name="SUBJ10">SUBJ10 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ10(string SUBJ10, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ10.Value.TryGetValue(SUBJ10, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ10 field
        /// </summary>
        /// <param name="SUBJ10">SUBJ10 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ10(string SUBJ10)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ10.Value.TryGetValue(SUBJ10, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ11 field
        /// </summary>
        /// <param name="SUBJ11">SUBJ11 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ11(string SUBJ11)
        {
            return Index_SUBJ11.Value[SUBJ11];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ11 field
        /// </summary>
        /// <param name="SUBJ11">SUBJ11 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ11(string SUBJ11, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ11.Value.TryGetValue(SUBJ11, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ11 field
        /// </summary>
        /// <param name="SUBJ11">SUBJ11 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ11(string SUBJ11)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ11.Value.TryGetValue(SUBJ11, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ12 field
        /// </summary>
        /// <param name="SUBJ12">SUBJ12 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ12(string SUBJ12)
        {
            return Index_SUBJ12.Value[SUBJ12];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ12 field
        /// </summary>
        /// <param name="SUBJ12">SUBJ12 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ12(string SUBJ12, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ12.Value.TryGetValue(SUBJ12, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ12 field
        /// </summary>
        /// <param name="SUBJ12">SUBJ12 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ12(string SUBJ12)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ12.Value.TryGetValue(SUBJ12, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ13 field
        /// </summary>
        /// <param name="SUBJ13">SUBJ13 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ13(string SUBJ13)
        {
            return Index_SUBJ13.Value[SUBJ13];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ13 field
        /// </summary>
        /// <param name="SUBJ13">SUBJ13 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ13(string SUBJ13, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ13.Value.TryGetValue(SUBJ13, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ13 field
        /// </summary>
        /// <param name="SUBJ13">SUBJ13 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ13(string SUBJ13)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ13.Value.TryGetValue(SUBJ13, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ14 field
        /// </summary>
        /// <param name="SUBJ14">SUBJ14 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ14(string SUBJ14)
        {
            return Index_SUBJ14.Value[SUBJ14];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ14 field
        /// </summary>
        /// <param name="SUBJ14">SUBJ14 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ14(string SUBJ14, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ14.Value.TryGetValue(SUBJ14, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ14 field
        /// </summary>
        /// <param name="SUBJ14">SUBJ14 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ14(string SUBJ14)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ14.Value.TryGetValue(SUBJ14, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ15 field
        /// </summary>
        /// <param name="SUBJ15">SUBJ15 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ15(string SUBJ15)
        {
            return Index_SUBJ15.Value[SUBJ15];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ15 field
        /// </summary>
        /// <param name="SUBJ15">SUBJ15 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ15(string SUBJ15, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ15.Value.TryGetValue(SUBJ15, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ15 field
        /// </summary>
        /// <param name="SUBJ15">SUBJ15 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ15(string SUBJ15)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ15.Value.TryGetValue(SUBJ15, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ16 field
        /// </summary>
        /// <param name="SUBJ16">SUBJ16 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ16(string SUBJ16)
        {
            return Index_SUBJ16.Value[SUBJ16];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ16 field
        /// </summary>
        /// <param name="SUBJ16">SUBJ16 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ16(string SUBJ16, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ16.Value.TryGetValue(SUBJ16, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ16 field
        /// </summary>
        /// <param name="SUBJ16">SUBJ16 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ16(string SUBJ16)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ16.Value.TryGetValue(SUBJ16, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ17 field
        /// </summary>
        /// <param name="SUBJ17">SUBJ17 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ17(string SUBJ17)
        {
            return Index_SUBJ17.Value[SUBJ17];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ17 field
        /// </summary>
        /// <param name="SUBJ17">SUBJ17 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ17(string SUBJ17, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ17.Value.TryGetValue(SUBJ17, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ17 field
        /// </summary>
        /// <param name="SUBJ17">SUBJ17 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ17(string SUBJ17)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ17.Value.TryGetValue(SUBJ17, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ18 field
        /// </summary>
        /// <param name="SUBJ18">SUBJ18 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ18(string SUBJ18)
        {
            return Index_SUBJ18.Value[SUBJ18];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ18 field
        /// </summary>
        /// <param name="SUBJ18">SUBJ18 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ18(string SUBJ18, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ18.Value.TryGetValue(SUBJ18, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ18 field
        /// </summary>
        /// <param name="SUBJ18">SUBJ18 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ18(string SUBJ18)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ18.Value.TryGetValue(SUBJ18, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ19 field
        /// </summary>
        /// <param name="SUBJ19">SUBJ19 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ19(string SUBJ19)
        {
            return Index_SUBJ19.Value[SUBJ19];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ19 field
        /// </summary>
        /// <param name="SUBJ19">SUBJ19 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ19(string SUBJ19, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ19.Value.TryGetValue(SUBJ19, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ19 field
        /// </summary>
        /// <param name="SUBJ19">SUBJ19 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ19(string SUBJ19)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ19.Value.TryGetValue(SUBJ19, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJ20 field
        /// </summary>
        /// <param name="SUBJ20">SUBJ20 value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJ20(string SUBJ20)
        {
            return Index_SUBJ20.Value[SUBJ20];
        }

        /// <summary>
        /// Attempt to find SC by SUBJ20 field
        /// </summary>
        /// <param name="SUBJ20">SUBJ20 value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ20(string SUBJ20, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJ20.Value.TryGetValue(SUBJ20, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJ20 field
        /// </summary>
        /// <param name="SUBJ20">SUBJ20 value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJ20(string SUBJ20)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJ20.Value.TryGetValue(SUBJ20, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SC by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SC</param>
        /// <returns>List of related SC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> FindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR)
        {
            return Index_SUBJECT_ACADEMIC_YEAR.Value[SUBJECT_ACADEMIC_YEAR];
        }

        /// <summary>
        /// Attempt to find SC by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SC</param>
        /// <param name="Value">List of related SC entities</param>
        /// <returns>True if the list of related SC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR, out IReadOnlyList<SC> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find SC by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SC</param>
        /// <returns>List of related SC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SC> TryFindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR)
        {
            IReadOnlyList<SC> value;
            if (Index_SUBJECT_ACADEMIC_YEAR.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SC](
        [COURSE] varchar(5) NOT NULL,
        [NAME] varchar(30) NULL,
        [SUBJ01] varchar(5) NULL,
        [SUBJ02] varchar(5) NULL,
        [SUBJ03] varchar(5) NULL,
        [SUBJ04] varchar(5) NULL,
        [SUBJ05] varchar(5) NULL,
        [SUBJ06] varchar(5) NULL,
        [SUBJ07] varchar(5) NULL,
        [SUBJ08] varchar(5) NULL,
        [SUBJ09] varchar(5) NULL,
        [SUBJ10] varchar(5) NULL,
        [SUBJ11] varchar(5) NULL,
        [SUBJ12] varchar(5) NULL,
        [SUBJ13] varchar(5) NULL,
        [SUBJ14] varchar(5) NULL,
        [SUBJ15] varchar(5) NULL,
        [SUBJ16] varchar(5) NULL,
        [SUBJ17] varchar(5) NULL,
        [SUBJ18] varchar(5) NULL,
        [SUBJ19] varchar(5) NULL,
        [SUBJ20] varchar(5) NULL,
        [CLASS01] smallint NULL,
        [CLASS02] smallint NULL,
        [CLASS03] smallint NULL,
        [CLASS04] smallint NULL,
        [CLASS05] smallint NULL,
        [CLASS06] smallint NULL,
        [CLASS07] smallint NULL,
        [CLASS08] smallint NULL,
        [CLASS09] smallint NULL,
        [CLASS10] smallint NULL,
        [CLASS11] smallint NULL,
        [CLASS12] smallint NULL,
        [CLASS13] smallint NULL,
        [CLASS14] smallint NULL,
        [CLASS15] smallint NULL,
        [CLASS16] smallint NULL,
        [CLASS17] smallint NULL,
        [CLASS18] smallint NULL,
        [CLASS19] smallint NULL,
        [CLASS20] smallint NULL,
        [LOCK01] varchar(1) NULL,
        [LOCK02] varchar(1) NULL,
        [LOCK03] varchar(1) NULL,
        [LOCK04] varchar(1) NULL,
        [LOCK05] varchar(1) NULL,
        [LOCK06] varchar(1) NULL,
        [LOCK07] varchar(1) NULL,
        [LOCK08] varchar(1) NULL,
        [LOCK09] varchar(1) NULL,
        [LOCK10] varchar(1) NULL,
        [LOCK11] varchar(1) NULL,
        [LOCK12] varchar(1) NULL,
        [LOCK13] varchar(1) NULL,
        [LOCK14] varchar(1) NULL,
        [LOCK15] varchar(1) NULL,
        [LOCK16] varchar(1) NULL,
        [LOCK17] varchar(1) NULL,
        [LOCK18] varchar(1) NULL,
        [LOCK19] varchar(1) NULL,
        [LOCK20] varchar(1) NULL,
        [SUBJECT_ACADEMIC_YEAR] varchar(4) NULL,
        [SEMESTER] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SC_Index_COURSE] PRIMARY KEY CLUSTERED (
            [COURSE] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ01] ON [dbo].[SC]
    (
            [SUBJ01] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ02] ON [dbo].[SC]
    (
            [SUBJ02] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ03] ON [dbo].[SC]
    (
            [SUBJ03] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ04] ON [dbo].[SC]
    (
            [SUBJ04] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ05] ON [dbo].[SC]
    (
            [SUBJ05] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ06] ON [dbo].[SC]
    (
            [SUBJ06] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ07] ON [dbo].[SC]
    (
            [SUBJ07] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ08] ON [dbo].[SC]
    (
            [SUBJ08] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ09] ON [dbo].[SC]
    (
            [SUBJ09] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ10] ON [dbo].[SC]
    (
            [SUBJ10] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ11] ON [dbo].[SC]
    (
            [SUBJ11] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ12] ON [dbo].[SC]
    (
            [SUBJ12] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ13] ON [dbo].[SC]
    (
            [SUBJ13] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ14] ON [dbo].[SC]
    (
            [SUBJ14] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ15] ON [dbo].[SC]
    (
            [SUBJ15] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ16] ON [dbo].[SC]
    (
            [SUBJ16] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ17] ON [dbo].[SC]
    (
            [SUBJ17] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ18] ON [dbo].[SC]
    (
            [SUBJ18] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ19] ON [dbo].[SC]
    (
            [SUBJ19] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJ20] ON [dbo].[SC]
    (
            [SUBJ20] ASC
    );
    CREATE NONCLUSTERED INDEX [SC_Index_SUBJECT_ACADEMIC_YEAR] ON [dbo].[SC]
    (
            [SUBJECT_ACADEMIC_YEAR] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ01')
    ALTER INDEX [Index_SUBJ01] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ02')
    ALTER INDEX [Index_SUBJ02] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ03')
    ALTER INDEX [Index_SUBJ03] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ04')
    ALTER INDEX [Index_SUBJ04] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ05')
    ALTER INDEX [Index_SUBJ05] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ06')
    ALTER INDEX [Index_SUBJ06] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ07')
    ALTER INDEX [Index_SUBJ07] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ08')
    ALTER INDEX [Index_SUBJ08] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ09')
    ALTER INDEX [Index_SUBJ09] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ10')
    ALTER INDEX [Index_SUBJ10] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ11')
    ALTER INDEX [Index_SUBJ11] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ12')
    ALTER INDEX [Index_SUBJ12] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ13')
    ALTER INDEX [Index_SUBJ13] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ14')
    ALTER INDEX [Index_SUBJ14] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ15')
    ALTER INDEX [Index_SUBJ15] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ16')
    ALTER INDEX [Index_SUBJ16] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ17')
    ALTER INDEX [Index_SUBJ17] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ18')
    ALTER INDEX [Index_SUBJ18] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ19')
    ALTER INDEX [Index_SUBJ19] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ20')
    ALTER INDEX [Index_SUBJ20] ON [dbo].[SC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR] ON [dbo].[SC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ01')
    ALTER INDEX [Index_SUBJ01] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ02')
    ALTER INDEX [Index_SUBJ02] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ03')
    ALTER INDEX [Index_SUBJ03] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ04')
    ALTER INDEX [Index_SUBJ04] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ05')
    ALTER INDEX [Index_SUBJ05] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ06')
    ALTER INDEX [Index_SUBJ06] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ07')
    ALTER INDEX [Index_SUBJ07] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ08')
    ALTER INDEX [Index_SUBJ08] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ09')
    ALTER INDEX [Index_SUBJ09] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ10')
    ALTER INDEX [Index_SUBJ10] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ11')
    ALTER INDEX [Index_SUBJ11] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ12')
    ALTER INDEX [Index_SUBJ12] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ13')
    ALTER INDEX [Index_SUBJ13] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ14')
    ALTER INDEX [Index_SUBJ14] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ15')
    ALTER INDEX [Index_SUBJ15] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ16')
    ALTER INDEX [Index_SUBJ16] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ17')
    ALTER INDEX [Index_SUBJ17] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ18')
    ALTER INDEX [Index_SUBJ18] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ19')
    ALTER INDEX [Index_SUBJ19] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJ20')
    ALTER INDEX [Index_SUBJ20] ON [dbo].[SC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SC]') AND name = N'Index_SUBJECT_ACADEMIC_YEAR')
    ALTER INDEX [Index_SUBJECT_ACADEMIC_YEAR] ON [dbo].[SC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_COURSE = new List<string>();

            foreach (var entity in Entities)
            {
                Index_COURSE.Add(entity.COURSE);
            }

            builder.AppendLine("DELETE [dbo].[SC] WHERE");


            // Index_COURSE
            builder.Append("[COURSE] IN (");
            for (int index = 0; index < Index_COURSE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // COURSE
                var parameterCOURSE = $"@p{parameterIndex++}";
                builder.Append(parameterCOURSE);
                command.Parameters.Add(parameterCOURSE, SqlDbType.VarChar, 5).Value = Index_COURSE[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SC data set</returns>
        public override EduHubDataSetDataReader<SC> GetDataSetDataReader()
        {
            return new SCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SC data set</returns>
        public override EduHubDataSetDataReader<SC> GetDataSetDataReader(List<SC> Entities)
        {
            return new SCDataReader(new EduHubDataSetLoadedReader<SC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCDataReader : EduHubDataSetDataReader<SC>
        {
            public SCDataReader(IEduHubDataSetReader<SC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 67; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // COURSE
                        return Current.COURSE;
                    case 1: // NAME
                        return Current.NAME;
                    case 2: // SUBJ01
                        return Current.SUBJ01;
                    case 3: // SUBJ02
                        return Current.SUBJ02;
                    case 4: // SUBJ03
                        return Current.SUBJ03;
                    case 5: // SUBJ04
                        return Current.SUBJ04;
                    case 6: // SUBJ05
                        return Current.SUBJ05;
                    case 7: // SUBJ06
                        return Current.SUBJ06;
                    case 8: // SUBJ07
                        return Current.SUBJ07;
                    case 9: // SUBJ08
                        return Current.SUBJ08;
                    case 10: // SUBJ09
                        return Current.SUBJ09;
                    case 11: // SUBJ10
                        return Current.SUBJ10;
                    case 12: // SUBJ11
                        return Current.SUBJ11;
                    case 13: // SUBJ12
                        return Current.SUBJ12;
                    case 14: // SUBJ13
                        return Current.SUBJ13;
                    case 15: // SUBJ14
                        return Current.SUBJ14;
                    case 16: // SUBJ15
                        return Current.SUBJ15;
                    case 17: // SUBJ16
                        return Current.SUBJ16;
                    case 18: // SUBJ17
                        return Current.SUBJ17;
                    case 19: // SUBJ18
                        return Current.SUBJ18;
                    case 20: // SUBJ19
                        return Current.SUBJ19;
                    case 21: // SUBJ20
                        return Current.SUBJ20;
                    case 22: // CLASS01
                        return Current.CLASS01;
                    case 23: // CLASS02
                        return Current.CLASS02;
                    case 24: // CLASS03
                        return Current.CLASS03;
                    case 25: // CLASS04
                        return Current.CLASS04;
                    case 26: // CLASS05
                        return Current.CLASS05;
                    case 27: // CLASS06
                        return Current.CLASS06;
                    case 28: // CLASS07
                        return Current.CLASS07;
                    case 29: // CLASS08
                        return Current.CLASS08;
                    case 30: // CLASS09
                        return Current.CLASS09;
                    case 31: // CLASS10
                        return Current.CLASS10;
                    case 32: // CLASS11
                        return Current.CLASS11;
                    case 33: // CLASS12
                        return Current.CLASS12;
                    case 34: // CLASS13
                        return Current.CLASS13;
                    case 35: // CLASS14
                        return Current.CLASS14;
                    case 36: // CLASS15
                        return Current.CLASS15;
                    case 37: // CLASS16
                        return Current.CLASS16;
                    case 38: // CLASS17
                        return Current.CLASS17;
                    case 39: // CLASS18
                        return Current.CLASS18;
                    case 40: // CLASS19
                        return Current.CLASS19;
                    case 41: // CLASS20
                        return Current.CLASS20;
                    case 42: // LOCK01
                        return Current.LOCK01;
                    case 43: // LOCK02
                        return Current.LOCK02;
                    case 44: // LOCK03
                        return Current.LOCK03;
                    case 45: // LOCK04
                        return Current.LOCK04;
                    case 46: // LOCK05
                        return Current.LOCK05;
                    case 47: // LOCK06
                        return Current.LOCK06;
                    case 48: // LOCK07
                        return Current.LOCK07;
                    case 49: // LOCK08
                        return Current.LOCK08;
                    case 50: // LOCK09
                        return Current.LOCK09;
                    case 51: // LOCK10
                        return Current.LOCK10;
                    case 52: // LOCK11
                        return Current.LOCK11;
                    case 53: // LOCK12
                        return Current.LOCK12;
                    case 54: // LOCK13
                        return Current.LOCK13;
                    case 55: // LOCK14
                        return Current.LOCK14;
                    case 56: // LOCK15
                        return Current.LOCK15;
                    case 57: // LOCK16
                        return Current.LOCK16;
                    case 58: // LOCK17
                        return Current.LOCK17;
                    case 59: // LOCK18
                        return Current.LOCK18;
                    case 60: // LOCK19
                        return Current.LOCK19;
                    case 61: // LOCK20
                        return Current.LOCK20;
                    case 62: // SUBJECT_ACADEMIC_YEAR
                        return Current.SUBJECT_ACADEMIC_YEAR;
                    case 63: // SEMESTER
                        return Current.SEMESTER;
                    case 64: // LW_DATE
                        return Current.LW_DATE;
                    case 65: // LW_TIME
                        return Current.LW_TIME;
                    case 66: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // NAME
                        return Current.NAME == null;
                    case 2: // SUBJ01
                        return Current.SUBJ01 == null;
                    case 3: // SUBJ02
                        return Current.SUBJ02 == null;
                    case 4: // SUBJ03
                        return Current.SUBJ03 == null;
                    case 5: // SUBJ04
                        return Current.SUBJ04 == null;
                    case 6: // SUBJ05
                        return Current.SUBJ05 == null;
                    case 7: // SUBJ06
                        return Current.SUBJ06 == null;
                    case 8: // SUBJ07
                        return Current.SUBJ07 == null;
                    case 9: // SUBJ08
                        return Current.SUBJ08 == null;
                    case 10: // SUBJ09
                        return Current.SUBJ09 == null;
                    case 11: // SUBJ10
                        return Current.SUBJ10 == null;
                    case 12: // SUBJ11
                        return Current.SUBJ11 == null;
                    case 13: // SUBJ12
                        return Current.SUBJ12 == null;
                    case 14: // SUBJ13
                        return Current.SUBJ13 == null;
                    case 15: // SUBJ14
                        return Current.SUBJ14 == null;
                    case 16: // SUBJ15
                        return Current.SUBJ15 == null;
                    case 17: // SUBJ16
                        return Current.SUBJ16 == null;
                    case 18: // SUBJ17
                        return Current.SUBJ17 == null;
                    case 19: // SUBJ18
                        return Current.SUBJ18 == null;
                    case 20: // SUBJ19
                        return Current.SUBJ19 == null;
                    case 21: // SUBJ20
                        return Current.SUBJ20 == null;
                    case 22: // CLASS01
                        return Current.CLASS01 == null;
                    case 23: // CLASS02
                        return Current.CLASS02 == null;
                    case 24: // CLASS03
                        return Current.CLASS03 == null;
                    case 25: // CLASS04
                        return Current.CLASS04 == null;
                    case 26: // CLASS05
                        return Current.CLASS05 == null;
                    case 27: // CLASS06
                        return Current.CLASS06 == null;
                    case 28: // CLASS07
                        return Current.CLASS07 == null;
                    case 29: // CLASS08
                        return Current.CLASS08 == null;
                    case 30: // CLASS09
                        return Current.CLASS09 == null;
                    case 31: // CLASS10
                        return Current.CLASS10 == null;
                    case 32: // CLASS11
                        return Current.CLASS11 == null;
                    case 33: // CLASS12
                        return Current.CLASS12 == null;
                    case 34: // CLASS13
                        return Current.CLASS13 == null;
                    case 35: // CLASS14
                        return Current.CLASS14 == null;
                    case 36: // CLASS15
                        return Current.CLASS15 == null;
                    case 37: // CLASS16
                        return Current.CLASS16 == null;
                    case 38: // CLASS17
                        return Current.CLASS17 == null;
                    case 39: // CLASS18
                        return Current.CLASS18 == null;
                    case 40: // CLASS19
                        return Current.CLASS19 == null;
                    case 41: // CLASS20
                        return Current.CLASS20 == null;
                    case 42: // LOCK01
                        return Current.LOCK01 == null;
                    case 43: // LOCK02
                        return Current.LOCK02 == null;
                    case 44: // LOCK03
                        return Current.LOCK03 == null;
                    case 45: // LOCK04
                        return Current.LOCK04 == null;
                    case 46: // LOCK05
                        return Current.LOCK05 == null;
                    case 47: // LOCK06
                        return Current.LOCK06 == null;
                    case 48: // LOCK07
                        return Current.LOCK07 == null;
                    case 49: // LOCK08
                        return Current.LOCK08 == null;
                    case 50: // LOCK09
                        return Current.LOCK09 == null;
                    case 51: // LOCK10
                        return Current.LOCK10 == null;
                    case 52: // LOCK11
                        return Current.LOCK11 == null;
                    case 53: // LOCK12
                        return Current.LOCK12 == null;
                    case 54: // LOCK13
                        return Current.LOCK13 == null;
                    case 55: // LOCK14
                        return Current.LOCK14 == null;
                    case 56: // LOCK15
                        return Current.LOCK15 == null;
                    case 57: // LOCK16
                        return Current.LOCK16 == null;
                    case 58: // LOCK17
                        return Current.LOCK17 == null;
                    case 59: // LOCK18
                        return Current.LOCK18 == null;
                    case 60: // LOCK19
                        return Current.LOCK19 == null;
                    case 61: // LOCK20
                        return Current.LOCK20 == null;
                    case 62: // SUBJECT_ACADEMIC_YEAR
                        return Current.SUBJECT_ACADEMIC_YEAR == null;
                    case 63: // SEMESTER
                        return Current.SEMESTER == null;
                    case 64: // LW_DATE
                        return Current.LW_DATE == null;
                    case 65: // LW_TIME
                        return Current.LW_TIME == null;
                    case 66: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // COURSE
                        return "COURSE";
                    case 1: // NAME
                        return "NAME";
                    case 2: // SUBJ01
                        return "SUBJ01";
                    case 3: // SUBJ02
                        return "SUBJ02";
                    case 4: // SUBJ03
                        return "SUBJ03";
                    case 5: // SUBJ04
                        return "SUBJ04";
                    case 6: // SUBJ05
                        return "SUBJ05";
                    case 7: // SUBJ06
                        return "SUBJ06";
                    case 8: // SUBJ07
                        return "SUBJ07";
                    case 9: // SUBJ08
                        return "SUBJ08";
                    case 10: // SUBJ09
                        return "SUBJ09";
                    case 11: // SUBJ10
                        return "SUBJ10";
                    case 12: // SUBJ11
                        return "SUBJ11";
                    case 13: // SUBJ12
                        return "SUBJ12";
                    case 14: // SUBJ13
                        return "SUBJ13";
                    case 15: // SUBJ14
                        return "SUBJ14";
                    case 16: // SUBJ15
                        return "SUBJ15";
                    case 17: // SUBJ16
                        return "SUBJ16";
                    case 18: // SUBJ17
                        return "SUBJ17";
                    case 19: // SUBJ18
                        return "SUBJ18";
                    case 20: // SUBJ19
                        return "SUBJ19";
                    case 21: // SUBJ20
                        return "SUBJ20";
                    case 22: // CLASS01
                        return "CLASS01";
                    case 23: // CLASS02
                        return "CLASS02";
                    case 24: // CLASS03
                        return "CLASS03";
                    case 25: // CLASS04
                        return "CLASS04";
                    case 26: // CLASS05
                        return "CLASS05";
                    case 27: // CLASS06
                        return "CLASS06";
                    case 28: // CLASS07
                        return "CLASS07";
                    case 29: // CLASS08
                        return "CLASS08";
                    case 30: // CLASS09
                        return "CLASS09";
                    case 31: // CLASS10
                        return "CLASS10";
                    case 32: // CLASS11
                        return "CLASS11";
                    case 33: // CLASS12
                        return "CLASS12";
                    case 34: // CLASS13
                        return "CLASS13";
                    case 35: // CLASS14
                        return "CLASS14";
                    case 36: // CLASS15
                        return "CLASS15";
                    case 37: // CLASS16
                        return "CLASS16";
                    case 38: // CLASS17
                        return "CLASS17";
                    case 39: // CLASS18
                        return "CLASS18";
                    case 40: // CLASS19
                        return "CLASS19";
                    case 41: // CLASS20
                        return "CLASS20";
                    case 42: // LOCK01
                        return "LOCK01";
                    case 43: // LOCK02
                        return "LOCK02";
                    case 44: // LOCK03
                        return "LOCK03";
                    case 45: // LOCK04
                        return "LOCK04";
                    case 46: // LOCK05
                        return "LOCK05";
                    case 47: // LOCK06
                        return "LOCK06";
                    case 48: // LOCK07
                        return "LOCK07";
                    case 49: // LOCK08
                        return "LOCK08";
                    case 50: // LOCK09
                        return "LOCK09";
                    case 51: // LOCK10
                        return "LOCK10";
                    case 52: // LOCK11
                        return "LOCK11";
                    case 53: // LOCK12
                        return "LOCK12";
                    case 54: // LOCK13
                        return "LOCK13";
                    case 55: // LOCK14
                        return "LOCK14";
                    case 56: // LOCK15
                        return "LOCK15";
                    case 57: // LOCK16
                        return "LOCK16";
                    case 58: // LOCK17
                        return "LOCK17";
                    case 59: // LOCK18
                        return "LOCK18";
                    case 60: // LOCK19
                        return "LOCK19";
                    case 61: // LOCK20
                        return "LOCK20";
                    case 62: // SUBJECT_ACADEMIC_YEAR
                        return "SUBJECT_ACADEMIC_YEAR";
                    case 63: // SEMESTER
                        return "SEMESTER";
                    case 64: // LW_DATE
                        return "LW_DATE";
                    case 65: // LW_TIME
                        return "LW_TIME";
                    case 66: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "COURSE":
                        return 0;
                    case "NAME":
                        return 1;
                    case "SUBJ01":
                        return 2;
                    case "SUBJ02":
                        return 3;
                    case "SUBJ03":
                        return 4;
                    case "SUBJ04":
                        return 5;
                    case "SUBJ05":
                        return 6;
                    case "SUBJ06":
                        return 7;
                    case "SUBJ07":
                        return 8;
                    case "SUBJ08":
                        return 9;
                    case "SUBJ09":
                        return 10;
                    case "SUBJ10":
                        return 11;
                    case "SUBJ11":
                        return 12;
                    case "SUBJ12":
                        return 13;
                    case "SUBJ13":
                        return 14;
                    case "SUBJ14":
                        return 15;
                    case "SUBJ15":
                        return 16;
                    case "SUBJ16":
                        return 17;
                    case "SUBJ17":
                        return 18;
                    case "SUBJ18":
                        return 19;
                    case "SUBJ19":
                        return 20;
                    case "SUBJ20":
                        return 21;
                    case "CLASS01":
                        return 22;
                    case "CLASS02":
                        return 23;
                    case "CLASS03":
                        return 24;
                    case "CLASS04":
                        return 25;
                    case "CLASS05":
                        return 26;
                    case "CLASS06":
                        return 27;
                    case "CLASS07":
                        return 28;
                    case "CLASS08":
                        return 29;
                    case "CLASS09":
                        return 30;
                    case "CLASS10":
                        return 31;
                    case "CLASS11":
                        return 32;
                    case "CLASS12":
                        return 33;
                    case "CLASS13":
                        return 34;
                    case "CLASS14":
                        return 35;
                    case "CLASS15":
                        return 36;
                    case "CLASS16":
                        return 37;
                    case "CLASS17":
                        return 38;
                    case "CLASS18":
                        return 39;
                    case "CLASS19":
                        return 40;
                    case "CLASS20":
                        return 41;
                    case "LOCK01":
                        return 42;
                    case "LOCK02":
                        return 43;
                    case "LOCK03":
                        return 44;
                    case "LOCK04":
                        return 45;
                    case "LOCK05":
                        return 46;
                    case "LOCK06":
                        return 47;
                    case "LOCK07":
                        return 48;
                    case "LOCK08":
                        return 49;
                    case "LOCK09":
                        return 50;
                    case "LOCK10":
                        return 51;
                    case "LOCK11":
                        return 52;
                    case "LOCK12":
                        return 53;
                    case "LOCK13":
                        return 54;
                    case "LOCK14":
                        return 55;
                    case "LOCK15":
                        return 56;
                    case "LOCK16":
                        return 57;
                    case "LOCK17":
                        return 58;
                    case "LOCK18":
                        return 59;
                    case "LOCK19":
                        return 60;
                    case "LOCK20":
                        return 61;
                    case "SUBJECT_ACADEMIC_YEAR":
                        return 62;
                    case "SEMESTER":
                        return 63;
                    case "LW_DATE":
                        return 64;
                    case "LW_TIME":
                        return 65;
                    case "LW_USER":
                        return 66;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
