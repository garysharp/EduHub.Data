using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details Data Set
    /// </summary>
    public sealed class TTEI_DataSet : SetBase<TTEI_Entity>
    {
        internal TTEI_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, TTEI_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "TTEI"; } }

        private Lazy<Dictionary<int, TTEI_Entity>> TID_Index;

        public TTEI_Entity FindByTID(int Key)
        {
            TTEI_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out TTEI_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public TTEI_Entity TryFindByTID(int Key)
        {
            TTEI_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<TTEI_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TTEI_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAX_SIZE":
                        mapper[i] = (e, v) => e.MAX_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_LINES":
                        mapper[i] = (e, v) => e.MAX_LINES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "USE_FIXED":
                        mapper[i] = (e, v) => e.USE_FIXED = v;
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
