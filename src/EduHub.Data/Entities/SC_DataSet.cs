using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Courses Data Set
    /// </summary>
    public sealed class SC_DataSet : SetBase<SC_Entity>
    {
        private Lazy<Dictionary<string, SC_Entity>> COURSE_Index;

        internal SC_DataSet(EduHubContext Context)
            : base(Context)
        {
            COURSE_Index = new Lazy<Dictionary<string, SC_Entity>>(() => this.ToDictionary(e => e.COURSE));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SC"; } }

        /// <summary>
        /// Find SC by COURSE key field
        /// </summary>
        /// <param name="Key">COURSE value used to find SC</param>
        /// <returns>Related SC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COURSE value didn't match any SC entities</exception>
        public SC_Entity FindByCOURSE(string Key)
        {
            SC_Entity result;
            if (COURSE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SC by COURSE key field
        /// </summary>
        /// <param name="Key">COURSE value used to find SC</param>
        /// <param name="Value">Related SC entity</param>
        /// <returns>True if the SC Entity is found</returns>
        public bool TryFindByCOURSE(string Key, out SC_Entity Value)
        {
            return COURSE_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SC by COURSE key field
        /// </summary>
        /// <param name="Key">COURSE value used to find SC</param>
        /// <returns>Related SC entity, or null if not found</returns>
        public SC_Entity TryFindByCOURSE(string Key)
        {
            SC_Entity result;
            if (COURSE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SC_Entity, string>[Headers.Count];

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
    }
}
