using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSEF Receipt details Data Set
    /// </summary>
    public sealed class KEMADataSet : SetBase<KEMA>
    {
        private Lazy<Dictionary<int, KEMA>> TIDIndex;

        internal KEMADataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, KEMA>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KEMA"; } }

        /// <summary>
        /// Find KEMA by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any KEMA entities</exception>
        public KEMA FindByTID(int Key)
        {
            KEMA result;
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
        /// Attempt to find KEMA by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KEMA</param>
        /// <param name="Value">Related KEMA entity</param>
        /// <returns>True if the KEMA entity is found</returns>
        public bool TryFindByTID(int Key, out KEMA Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KEMA by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity, or null if not found</returns>
        public KEMA TryFindByTID(int Key)
        {
            KEMA result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="KEMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KEMA" /> fields for each CSV column header</returns>
        protected override Action<KEMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KEMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY_KEY":
                        mapper[i] = (e, v) => e.FAMILY_KEY = v;
                        break;
                    case "STREGISTRATION":
                        mapper[i] = (e, v) => e.STREGISTRATION = v;
                        break;
                    case "EMA_PERIOD":
                        mapper[i] = (e, v) => e.EMA_PERIOD = v;
                        break;
                    case "EMA_TRAMT":
                        mapper[i] = (e, v) => e.EMA_TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
