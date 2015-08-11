using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds Data Set
    /// </summary>
    public sealed class PF_DataSet : SetBase<PF_Entity>
    {
        internal PF_DataSet(EduHubContext Context)
            : base(Context)
        {
            PFKEY_Index = new Lazy<Dictionary<string, PF_Entity>>(() => this.ToDictionary(e => e.PFKEY));
        }

        public override string SetName { get { return "PF"; } }

        private Lazy<Dictionary<string, PF_Entity>> PFKEY_Index;

        public PF_Entity FindByPFKEY(string Key)
        {
            PF_Entity result;
            if (PFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPFKEY(string Key, out PF_Entity Value)
        {
            return PFKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PF_Entity TryFindByPFKEY(string Key)
        {
            PF_Entity result;
            if (PFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PF_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PF_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PFKEY":
                        mapper[i] = (e, v) => e.PFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "CREATE_EXPORT_FILE":
                        mapper[i] = (e, v) => e.CREATE_EXPORT_FILE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
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
