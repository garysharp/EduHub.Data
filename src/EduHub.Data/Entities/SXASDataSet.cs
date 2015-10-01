using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Scheduled Sessions Data Set
    /// </summary>
    public sealed class SXASDataSet : SetBase<SXAS>
    {
        private Lazy<Dictionary<int, SXAS>> TIDIndex;

        internal SXASDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, SXAS>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SXAS"; } }

        /// <summary>
        /// Find SXAS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SXAS</param>
        /// <returns>Related SXAS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any SXAS entities</exception>
        public SXAS FindByTID(int Key)
        {
            SXAS result;
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
        /// Attempt to find SXAS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SXAS</param>
        /// <param name="Value">Related SXAS entity</param>
        /// <returns>True if the SXAS entity is found</returns>
        public bool TryFindByTID(int Key, out SXAS Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SXAS</param>
        /// <returns>Related SXAS entity, or null if not found</returns>
        public SXAS TryFindByTID(int Key)
        {
            SXAS result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SXAS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SXAS" /> fields for each CSV column header</returns>
        protected override Action<SXAS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SXAS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TXAS_ID":
                        mapper[i] = (e, v) => e.TXAS_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "EXP_ABS_TYPE":
                        mapper[i] = (e, v) => e.EXP_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
                        break;
                    case "ACT_ABS_TYPE":
                        mapper[i] = (e, v) => e.ACT_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "ACTION_TAKEN":
                        mapper[i] = (e, v) => e.ACTION_TAKEN = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ABSENCE_PERIOD":
                        mapper[i] = (e, v) => e.ABSENCE_PERIOD = v == null ? (short?)null : short.Parse(v);
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
