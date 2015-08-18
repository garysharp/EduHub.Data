using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates Data Set
    /// </summary>
    public sealed class TTDataSet : SetBase<TT>
    {
        private Lazy<Dictionary<string, TT>> TTKEYIndex;

        internal TTDataSet(EduHubContext Context)
            : base(Context)
        {
            TTKEYIndex = new Lazy<Dictionary<string, TT>>(() => this.ToDictionary(e => e.TTKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TT"; } }

        /// <summary>
        /// Find TT by TTKEY key field
        /// </summary>
        /// <param name="Key">TTKEY value used to find TT</param>
        /// <returns>Related TT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TTKEY value didn't match any TT entities</exception>
        public TT FindByTTKEY(string Key)
        {
            TT result;
            if (TTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TT by TTKEY key field
        /// </summary>
        /// <param name="Key">TTKEY value used to find TT</param>
        /// <param name="Value">Related TT entity</param>
        /// <returns>True if the TT Entity is found</returns>
        public bool TryFindByTTKEY(string Key, out TT Value)
        {
            return TTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TT by TTKEY key field
        /// </summary>
        /// <param name="Key">TTKEY value used to find TT</param>
        /// <returns>Related TT entity, or null if not found</returns>
        public TT TryFindByTTKEY(string Key)
        {
            TT result;
            if (TTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TT, string>[] BuildMapper(List<string> Headers)
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
    }
}
