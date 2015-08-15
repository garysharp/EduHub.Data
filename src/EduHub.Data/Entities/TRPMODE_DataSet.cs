using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes Data Set
    /// </summary>
    public sealed class TRPMODE_DataSet : SetBase<TRPMODE_Entity>
    {
        private Lazy<Dictionary<int, TRPMODE_Entity>> TRANSPORT_MODE_ID_Index;

        internal TRPMODE_DataSet(EduHubContext Context)
            : base(Context)
        {
            TRANSPORT_MODE_ID_Index = new Lazy<Dictionary<int, TRPMODE_Entity>>(() => this.ToDictionary(e => e.TRANSPORT_MODE_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "TRPMODE"; } }

        /// <summary>
        /// Find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TRANSPORT_MODE_ID value didn't match any TRPMODE entities</exception>
        public TRPMODE_Entity FindByTRANSPORT_MODE_ID(int Key)
        {
            TRPMODE_Entity result;
            if (TRANSPORT_MODE_ID_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the TRPMODE Entity is found</returns>
        public bool TryFindByTRANSPORT_MODE_ID(int Key, out TRPMODE_Entity Value)
        {
            return TRANSPORT_MODE_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity, or null if not found</returns>
        public TRPMODE_Entity TryFindByTRANSPORT_MODE_ID(int Key)
        {
            TRPMODE_Entity result;
            if (TRANSPORT_MODE_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TRPMODE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TRPMODE_Entity, string>[Headers.Count];

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
