using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties Data Set
    /// </summary>
    public sealed class KSF_DataSet : SetBase<KSF_Entity>
    {
        internal KSF_DataSet(EduHubContext Context)
            : base(Context)
        {
            KSFKEY_Index = new Lazy<Dictionary<string, KSF_Entity>>(() => this.ToDictionary(e => e.KSFKEY));
        }

        public override string SetName { get { return "KSF"; } }

        private Lazy<Dictionary<string, KSF_Entity>> KSFKEY_Index;

        public KSF_Entity FindByKSFKEY(string Key)
        {
            KSF_Entity result;
            if (KSFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKSFKEY(string Key, out KSF_Entity Value)
        {
            return KSFKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KSF_Entity TryFindByKSFKEY(string Key)
        {
            KSF_Entity result;
            if (KSFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KSF_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSF_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSFKEY":
                        mapper[i] = (e, v) => e.KSFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "COORDINATOR":
                        mapper[i] = (e, v) => e.COORDINATOR = v;
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
