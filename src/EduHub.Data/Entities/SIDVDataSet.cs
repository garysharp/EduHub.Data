using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients Data Set
    /// </summary>
    public sealed class SIDVDataSet : SetBase<SIDV>
    {
        private Lazy<Dictionary<int, SIDV>> TIDIndex;

        internal SIDVDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, SIDV>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SIDV"; } }

        /// <summary>
        /// Find SIDV by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any SIDV entities</exception>
        public SIDV FindByTID(int Key)
        {
            SIDV result;
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
        /// Attempt to find SIDV by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SIDV</param>
        /// <param name="Value">Related SIDV entity</param>
        /// <returns>True if the SIDV entity is found</returns>
        public bool TryFindByTID(int Key, out SIDV Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity, or null if not found</returns>
        public SIDV TryFindByTID(int Key)
        {
            SIDV result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIDV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIDV" /> fields for each CSV column header</returns>
        protected override Action<SIDV, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SIDV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "RECIPIENT_TYPE":
                        mapper[i] = (e, v) => e.RECIPIENT_TYPE = v;
                        break;
                    case "RECIPIENT":
                        mapper[i] = (e, v) => e.RECIPIENT = v;
                        break;
                    case "RECIPIENT_NAME":
                        mapper[i] = (e, v) => e.RECIPIENT_NAME = v;
                        break;
                    case "RECIPIENT_ADDRESS":
                        mapper[i] = (e, v) => e.RECIPIENT_ADDRESS = v;
                        break;
                    case "RECIPIENT_PHONE":
                        mapper[i] = (e, v) => e.RECIPIENT_PHONE = v;
                        break;
                    case "HOW_AFFECTED":
                        mapper[i] = (e, v) => e.HOW_AFFECTED = v;
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
