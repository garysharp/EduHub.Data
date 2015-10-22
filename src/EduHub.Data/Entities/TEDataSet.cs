using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events Data Set
    /// </summary>
    public sealed partial class TEDataSet : SetBase<TE>
    {
        private Lazy<Dictionary<int, TE>> TEKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<TETE>>> TETE_TETEKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<TETN>>> TETN_TETNKEYForeignIndex;

        internal TEDataSet(EduHubContext Context)
            : base(Context)
        {
            TEKEYIndex = new Lazy<Dictionary<int, TE>>(() => this.ToDictionary(e => e.TEKEY));

            TETE_TETEKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<TETE>>>(() =>
                    Context.TETE
                          .Where(e => e.TETEKEY != null)
                          .GroupBy(e => e.TETEKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TETE>)g.ToList()
                          .AsReadOnly()));

            TETN_TETNKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<TETN>>>(() =>
                    Context.TETN
                          .Where(e => e.TETNKEY != null)
                          .GroupBy(e => e.TETNKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TETN>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TE"; } }

        /// <summary>
        /// Find TE by TEKEY key field
        /// </summary>
        /// <param name="Key">TEKEY value used to find TE</param>
        /// <returns>Related TE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TEKEY value didn't match any TE entities</exception>
        public TE FindByTEKEY(int Key)
        {
            TE result;
            if (TEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TE by TEKEY key field
        /// </summary>
        /// <param name="Key">TEKEY value used to find TE</param>
        /// <param name="Value">Related TE entity</param>
        /// <returns>True if the TE entity is found</returns>
        public bool TryFindByTEKEY(int Key, out TE Value)
        {
            return TEKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TE by TEKEY key field
        /// </summary>
        /// <param name="Key">TEKEY value used to find TE</param>
        /// <returns>Related TE entity, or null if not found</returns>
        public TE TryFindByTEKEY(int Key)
        {
            TE result;
            if (TEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all TETE (Event Instances) entities by [TETE.TETEKEY]-&gt;[TE.TEKEY]
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TETE entities</param>
        /// <returns>A list of related TETE entities</returns>
        public IReadOnlyList<TETE> FindTETEByTETEKEY(int TEKEY)
        {
            IReadOnlyList<TETE> result;
            if (TETE_TETEKEYForeignIndex.Value.TryGetValue(TEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TETE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TETE entities by [TETE.TETEKEY]-&gt;[TE.TEKEY]
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TETE entities</param>
        /// <param name="Value">A list of related TETE entities</param>
        /// <returns>True if any TETE entities are found</returns>
        public bool TryFindTETEByTETEKEY(int TEKEY, out IReadOnlyList<TETE> Value)
        {
            return TETE_TETEKEYForeignIndex.Value.TryGetValue(TEKEY, out Value);
        }

        /// <summary>
        /// Find all TETN (Event Attendees) entities by [TETN.TETNKEY]-&gt;[TE.TEKEY]
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TETN entities</param>
        /// <returns>A list of related TETN entities</returns>
        public IReadOnlyList<TETN> FindTETNByTETNKEY(int TEKEY)
        {
            IReadOnlyList<TETN> result;
            if (TETN_TETNKEYForeignIndex.Value.TryGetValue(TEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TETN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TETN entities by [TETN.TETNKEY]-&gt;[TE.TEKEY]
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TETN entities</param>
        /// <param name="Value">A list of related TETN entities</param>
        /// <returns>True if any TETN entities are found</returns>
        public bool TryFindTETNByTETNKEY(int TEKEY, out IReadOnlyList<TETN> Value)
        {
            return TETN_TETNKEYForeignIndex.Value.TryGetValue(TEKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TE" /> fields for each CSV column header</returns>
        protected override Action<TE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TEKEY":
                        mapper[i] = (e, v) => e.TEKEY = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECURRENCE":
                        mapper[i] = (e, v) => e.RECURRENCE = v;
                        break;
                    case "RECUR_DAYS":
                        mapper[i] = (e, v) => e.RECUR_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "EVENT_GROUP":
                        mapper[i] = (e, v) => e.EVENT_GROUP = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "COLOUR":
                        mapper[i] = (e, v) => e.COLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EVENT_CODE":
                        mapper[i] = (e, v) => e.EVENT_CODE = v;
                        break;
                    case "START_YEAR":
                        mapper[i] = (e, v) => e.START_YEAR = v;
                        break;
                    case "END_YEAR":
                        mapper[i] = (e, v) => e.END_YEAR = v;
                        break;
                    case "START_FORM":
                        mapper[i] = (e, v) => e.START_FORM = v;
                        break;
                    case "END_FORM":
                        mapper[i] = (e, v) => e.END_FORM = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "START_CLASS_NUM":
                        mapper[i] = (e, v) => e.START_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_CLASS_NUM":
                        mapper[i] = (e, v) => e.END_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
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
