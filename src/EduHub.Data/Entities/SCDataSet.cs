using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Courses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCDataSet : SetBase<SC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SC"; } }

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
        protected override Action<SC, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

    }
}
