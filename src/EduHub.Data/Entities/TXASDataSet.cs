using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Actual Sessions Data Set
    /// </summary>
    public sealed class TXASDataSet : SetBase<TXAS>
    {
        private Lazy<Dictionary<int, TXAS>> TIDIndex;

        internal TXASDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, TXAS>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TXAS"; } }

        /// <summary>
        /// Find TXAS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any TXAS entities</exception>
        public TXAS FindByTID(int Key)
        {
            TXAS result;
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
        /// Attempt to find TXAS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find TXAS</param>
        /// <param name="Value">Related TXAS entity</param>
        /// <returns>True if the TXAS entity is found</returns>
        public bool TryFindByTID(int Key, out TXAS Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity, or null if not found</returns>
        public TXAS TryFindByTID(int Key)
        {
            TXAS result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXAS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXAS" /> fields for each CSV column header</returns>
        protected override Action<TXAS, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TXAS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "THTQ_TID":
                        mapper[i] = (e, v) => e.THTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SESSION":
                        mapper[i] = (e, v) => e.CLASS_SESSION = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "PERIOD_NO":
                        mapper[i] = (e, v) => e.PERIOD_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_NO":
                        mapper[i] = (e, v) => e.DAY_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SESSION_DATE":
                        mapper[i] = (e, v) => e.SESSION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERIOD_DESC":
                        mapper[i] = (e, v) => e.PERIOD_DESC = v;
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FINISH_TIME":
                        mapper[i] = (e, v) => e.FINISH_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROLL_MARKED":
                        mapper[i] = (e, v) => e.ROLL_MARKED = v;
                        break;
                    case "SCL_LINK":
                        mapper[i] = (e, v) => e.SCL_LINK = v;
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
