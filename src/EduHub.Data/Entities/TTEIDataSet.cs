using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details Data Set
    /// </summary>
    public sealed class TTEIDataSet : SetBase<TTEI>
    {
        private Lazy<Dictionary<int, TTEI>> TIDIndex;

        internal TTEIDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, TTEI>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEI"; } }

        /// <summary>
        /// Find TTEI by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any TTEI entities</exception>
        public TTEI FindByTID(int Key)
        {
            TTEI result;
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
        /// Attempt to find TTEI by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find TTEI</param>
        /// <param name="Value">Related TTEI entity</param>
        /// <returns>True if the TTEI entity is found</returns>
        public bool TryFindByTID(int Key, out TTEI Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity, or null if not found</returns>
        public TTEI TryFindByTID(int Key)
        {
            TTEI result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEI" /> fields for each CSV column header</returns>
        protected override Action<TTEI, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TTEI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAX_SIZE":
                        mapper[i] = (e, v) => e.MAX_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_LINES":
                        mapper[i] = (e, v) => e.MAX_LINES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "USE_FIXED":
                        mapper[i] = (e, v) => e.USE_FIXED = v;
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
