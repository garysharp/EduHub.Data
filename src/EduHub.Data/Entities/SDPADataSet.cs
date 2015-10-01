using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Actions Data Set
    /// </summary>
    public sealed class SDPADataSet : SetBase<SDPA>
    {
        private Lazy<Dictionary<int, SDPA>> TIDIndex;

        internal SDPADataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, SDPA>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDPA"; } }

        /// <summary>
        /// Find SDPA by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SDPA</param>
        /// <returns>Related SDPA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any SDPA entities</exception>
        public SDPA FindByTID(int Key)
        {
            SDPA result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SDPA by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SDPA</param>
        /// <param name="Value">Related SDPA entity</param>
        /// <returns>True if the SDPA entity is found</returns>
        public bool TryFindByTID(int Key, out SDPA Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SDPA</param>
        /// <returns>Related SDPA entity, or null if not found</returns>
        public SDPA TryFindByTID(int Key)
        {
            SDPA result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDPA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDPA" /> fields for each CSV column header</returns>
        protected override Action<SDPA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDPA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SDP_STUDENT":
                        mapper[i] = (e, v) => e.SDP_STUDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TAKEN_BY":
                        mapper[i] = (e, v) => e.TAKEN_BY = v;
                        break;
                    case "ACTION_TAKEN":
                        mapper[i] = (e, v) => e.ACTION_TAKEN = v;
                        break;
                    case "OTHER_ACTION":
                        mapper[i] = (e, v) => e.OTHER_ACTION = v;
                        break;
                    case "COMPLIED":
                        mapper[i] = (e, v) => e.COMPLIED = v;
                        break;
                    case "PARENT_INFORMED":
                        mapper[i] = (e, v) => e.PARENT_INFORMED = v;
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
