using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description Data Set
    /// </summary>
    public sealed class PLCDataSet : SetBase<PLC>
    {
        private Lazy<Dictionary<string, PLC>> PLCKEYIndex;

        internal PLCDataSet(EduHubContext Context)
            : base(Context)
        {
            PLCKEYIndex = new Lazy<Dictionary<string, PLC>>(() => this.ToDictionary(e => e.PLCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLC"; } }

        /// <summary>
        /// Find PLC by PLCKEY key field
        /// </summary>
        /// <param name="Key">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PLCKEY value didn't match any PLC entities</exception>
        public PLC FindByPLCKEY(string Key)
        {
            PLC result;
            if (PLCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY key field
        /// </summary>
        /// <param name="Key">PLCKEY value used to find PLC</param>
        /// <param name="Value">Related PLC entity</param>
        /// <returns>True if the PLC entity is found</returns>
        public bool TryFindByPLCKEY(string Key, out PLC Value)
        {
            return PLCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY key field
        /// </summary>
        /// <param name="Key">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity, or null if not found</returns>
        public PLC TryFindByPLCKEY(string Key)
        {
            PLC result;
            if (PLCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLC" /> fields for each CSV column header</returns>
        protected override Action<PLC, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PLC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLCKEY":
                        mapper[i] = (e, v) => e.PLCKEY = v;
                        break;
                    case "LEAVE_DESC":
                        mapper[i] = (e, v) => e.LEAVE_DESC = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
