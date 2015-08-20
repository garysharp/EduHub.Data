using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes Data Set
    /// </summary>
    public sealed class TRPMODEDataSet : SetBase<TRPMODE>
    {
        private Lazy<Dictionary<int, TRPMODE>> TRANSPORT_MODE_IDIndex;

        internal TRPMODEDataSet(EduHubContext Context)
            : base(Context)
        {
            TRANSPORT_MODE_IDIndex = new Lazy<Dictionary<int, TRPMODE>>(() => this.ToDictionary(e => e.TRANSPORT_MODE_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRPMODE"; } }

        /// <summary>
        /// Find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TRANSPORT_MODE_ID value didn't match any TRPMODE entities</exception>
        public TRPMODE FindByTRANSPORT_MODE_ID(int Key)
        {
            TRPMODE result;
            if (TRANSPORT_MODE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <param name="Value">Related TRPMODE entity</param>
        /// <returns>True if the TRPMODE entity is found</returns>
        public bool TryFindByTRANSPORT_MODE_ID(int Key, out TRPMODE Value)
        {
            return TRANSPORT_MODE_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity, or null if not found</returns>
        public TRPMODE TryFindByTRANSPORT_MODE_ID(int Key)
        {
            TRPMODE result;
            if (TRANSPORT_MODE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRPMODE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRPMODE" /> fields for each CSV column header</returns>
        protected override Action<TRPMODE, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TRPMODE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TRANSPORT_MODE_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_ID = int.Parse(v);
                        break;
                    case "TRANSPORT_MODE_DESC":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_DESC = v;
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
