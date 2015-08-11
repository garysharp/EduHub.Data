using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions Data Set
    /// </summary>
    public sealed class KGR_DataSet : SetBase<KGR_Entity>
    {
        internal KGR_DataSet(EduHubContext Context)
            : base(Context)
        {
            RELIGION_Index = new Lazy<Dictionary<string, KGR_Entity>>(() => this.ToDictionary(e => e.RELIGION));
        }

        public override string SetName { get { return "KGR"; } }

        private Lazy<Dictionary<string, KGR_Entity>> RELIGION_Index;

        public KGR_Entity FindByRELIGION(string Key)
        {
            KGR_Entity result;
            if (RELIGION_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByRELIGION(string Key, out KGR_Entity Value)
        {
            return RELIGION_Index.Value.TryGetValue(Key, out Value);
        }
        public KGR_Entity TryFindByRELIGION(string Key)
        {
            KGR_Entity result;
            if (RELIGION_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
