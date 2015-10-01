using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Special Group Meetings Data Set
    /// </summary>
    public sealed class SGMDataSet : SetBase<SGM>
    {
        private Lazy<Dictionary<DateTime, SGM>> MEETING_DATEIndex;

        internal SGMDataSet(EduHubContext Context)
            : base(Context)
        {
            MEETING_DATEIndex = new Lazy<Dictionary<DateTime, SGM>>(() => this.ToDictionary(e => e.MEETING_DATE));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGM"; } }

        /// <summary>
        /// Find SGM by MEETING_DATE key field
        /// </summary>
        /// <param name="Key">MEETING_DATE value used to find SGM</param>
        /// <returns>Related SGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">MEETING_DATE value didn't match any SGM entities</exception>
        public SGM FindByMEETING_DATE(DateTime Key)
        {
            SGM result;
            if (MEETING_DATEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_DATE key field
        /// </summary>
        /// <param name="Key">MEETING_DATE value used to find SGM</param>
        /// <param name="Value">Related SGM entity</param>
        /// <returns>True if the SGM entity is found</returns>
        public bool TryFindByMEETING_DATE(DateTime Key, out SGM Value)
        {
            return MEETING_DATEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_DATE key field
        /// </summary>
        /// <param name="Key">MEETING_DATE value used to find SGM</param>
        /// <returns>Related SGM entity, or null if not found</returns>
        public SGM TryFindByMEETING_DATE(DateTime Key)
        {
            SGM result;
            if (MEETING_DATEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGM" /> fields for each CSV column header</returns>
        protected override Action<SGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGMKEY":
                        mapper[i] = (e, v) => e.SGMKEY = v;
                        break;
                    case "MEETING_DATE":
                        mapper[i] = (e, v) => e.MEETING_DATE = DateTime.Parse(v);
                        break;
                    case "MEETING_TIME":
                        mapper[i] = (e, v) => e.MEETING_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PURPOSE_BRIEF":
                        mapper[i] = (e, v) => e.PURPOSE_BRIEF = v;
                        break;
                    case "PURPOSE_DETAIL":
                        mapper[i] = (e, v) => e.PURPOSE_DETAIL = v;
                        break;
                    case "MEETING_ROOM":
                        mapper[i] = (e, v) => e.MEETING_ROOM = v;
                        break;
                    case "MINUTES_MEMO":
                        mapper[i] = (e, v) => e.MINUTES_MEMO = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
