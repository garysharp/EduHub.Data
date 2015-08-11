using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FTE Student Retentions Data Set
    /// </summary>
    public sealed class SRAG_DataSet : SetBase<SRAG_Entity>
    {
        internal SRAG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SRAG_ID_Index = new Lazy<Dictionary<int, SRAG_Entity>>(() => this.ToDictionary(e => e.SRAG_ID));
        }

        public override string SetName { get { return "SRAG"; } }

        private Lazy<Dictionary<int, SRAG_Entity>> SRAG_ID_Index;

        public SRAG_Entity FindBySRAG_ID(int Key)
        {
            SRAG_Entity result;
            if (SRAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySRAG_ID(int Key, out SRAG_Entity Value)
        {
            return SRAG_ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SRAG_Entity TryFindBySRAG_ID(int Key)
        {
            SRAG_Entity result;
            if (SRAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SRAG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SRAG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SRAG_ID":
                        mapper[i] = (e, v) => e.SRAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "RETENTION":
                        mapper[i] = (e, v) => e.RETENTION = v == null ? (double?)null : double.Parse(v);
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
