using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Actions Data Set
    /// </summary>
    public sealed class SDPA_DataSet : SetBase<SDPA_Entity>
    {
        internal SDPA_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, SDPA_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "SDPA"; } }

        private Lazy<Dictionary<int, SDPA_Entity>> TID_Index;

        public SDPA_Entity FindByTID(int Key)
        {
            SDPA_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out SDPA_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public SDPA_Entity TryFindByTID(int Key)
        {
            SDPA_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SDPA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SDPA_Entity, string>[Headers.Count];

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
