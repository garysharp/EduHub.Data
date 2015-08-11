using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// EMA Receipt details Data Set
    /// </summary>
    public sealed class KEMA_DataSet : SetBase<KEMA_Entity>
    {
        internal KEMA_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, KEMA_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "KEMA"; } }

        private Lazy<Dictionary<int, KEMA_Entity>> TID_Index;

        public KEMA_Entity FindByTID(int Key)
        {
            KEMA_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out KEMA_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public KEMA_Entity TryFindByTID(int Key)
        {
            KEMA_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KEMA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KEMA_Entity, string>[Headers.Count];

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
