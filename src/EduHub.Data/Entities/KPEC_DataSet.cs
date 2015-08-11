using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Categories Data Set
    /// </summary>
    public sealed class KPEC_DataSet : SetBase<KPEC_Entity>
    {
        internal KPEC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KPECKEY_Index = new Lazy<Dictionary<string, KPEC_Entity>>(() => this.ToDictionary(e => e.KPECKEY));
        }

        public override string SetName { get { return "KPEC"; } }

        private Lazy<Dictionary<string, KPEC_Entity>> KPECKEY_Index;

        public KPEC_Entity FindByKPECKEY(string Key)
        {
            KPEC_Entity result;
            if (KPECKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKPECKEY(string Key, out KPEC_Entity Value)
        {
            return KPECKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KPEC_Entity TryFindByKPECKEY(string Key)
        {
            KPEC_Entity result;
            if (KPECKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KPEC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPEC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPECKEY":
                        mapper[i] = (e, v) => e.KPECKEY = v;
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
