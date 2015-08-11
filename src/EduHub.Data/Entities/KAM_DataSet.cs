using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions Data Set
    /// </summary>
    public sealed class KAM_DataSet : SetBase<KAM_Entity>
    {
        internal KAM_DataSet(EduHubContext Context)
            : base(Context)
        {
            KAMKEY_Index = new Lazy<Dictionary<string, KAM_Entity>>(() => this.ToDictionary(e => e.KAMKEY));
        }

        public override string SetName { get { return "KAM"; } }

        private Lazy<Dictionary<string, KAM_Entity>> KAMKEY_Index;

        public KAM_Entity FindByKAMKEY(string Key)
        {
            KAM_Entity result;
            if (KAMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKAMKEY(string Key, out KAM_Entity Value)
        {
            return KAMKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KAM_Entity TryFindByKAMKEY(string Key)
        {
            KAM_Entity result;
            if (KAMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KAM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KAM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAMKEY":
                        mapper[i] = (e, v) => e.KAMKEY = v;
                        break;
                    case "BRIEF":
                        mapper[i] = (e, v) => e.BRIEF = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
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
