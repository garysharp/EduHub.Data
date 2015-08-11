using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching Data Set
    /// </summary>
    public sealed class KSA_DataSet : SetBase<KSA_Entity>
    {
        internal KSA_DataSet(EduHubContext Context)
            : base(Context)
        {
            KSAKEY_Index = new Lazy<Dictionary<string, KSA_Entity>>(() => this.ToDictionary(e => e.KSAKEY));
        }

        public override string SetName { get { return "KSA"; } }

        private Lazy<Dictionary<string, KSA_Entity>> KSAKEY_Index;

        public KSA_Entity FindByKSAKEY(string Key)
        {
            KSA_Entity result;
            if (KSAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKSAKEY(string Key, out KSA_Entity Value)
        {
            return KSAKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KSA_Entity TryFindByKSAKEY(string Key)
        {
            KSA_Entity result;
            if (KSAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KSA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSA_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSAKEY":
                        mapper[i] = (e, v) => e.KSAKEY = v;
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
