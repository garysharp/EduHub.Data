using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients Data Set
    /// </summary>
    public sealed partial class SPREPLYDataSet : SetBase<SPREPLY>
    {
        private Lazy<Dictionary<int, SPREPLY>> TIDIndex;


        internal SPREPLYDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, SPREPLY>>(() => this.ToDictionary(e => e.TID));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPREPLY"; } }

        /// <summary>
        /// Find SPREPLY by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any SPREPLY entities</exception>
        public SPREPLY FindByTID(int Key)
        {
            SPREPLY result;
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
        /// Attempt to find SPREPLY by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPREPLY</param>
        /// <param name="Value">Related SPREPLY entity</param>
        /// <returns>True if the SPREPLY entity is found</returns>
        public bool TryFindByTID(int Key, out SPREPLY Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity, or null if not found</returns>
        public SPREPLY TryFindByTID(int Key)
        {
            SPREPLY result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPREPLY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPREPLY" /> fields for each CSV column header</returns>
        protected override Action<SPREPLY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPREPLY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SPRECIP_TID":
                        mapper[i] = (e, v) => e.SPRECIP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "PHONE_NUMBER":
                        mapper[i] = (e, v) => e.PHONE_NUMBER = v;
                        break;
                    case "RECEIVED_DATE":
                        mapper[i] = (e, v) => e.RECEIVED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
