using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship Data Set
    /// </summary>
    public sealed class KPCR_DataSet : SetBase<KPCR_Entity>
    {
        internal KPCR_DataSet(EduHubContext Context)
            : base(Context)
        {
            KPCRKEY_Index = new Lazy<Dictionary<string, KPCR_Entity>>(() => this.ToDictionary(e => e.KPCRKEY));
        }

        public override string SetName { get { return "KPCR"; } }

        private Lazy<Dictionary<string, KPCR_Entity>> KPCRKEY_Index;

        public KPCR_Entity FindByKPCRKEY(string Key)
        {
            KPCR_Entity result;
            if (KPCRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKPCRKEY(string Key, out KPCR_Entity Value)
        {
            return KPCRKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KPCR_Entity TryFindByKPCRKEY(string Key)
        {
            KPCR_Entity result;
            if (KPCRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KPCR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPCR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCRKEY":
                        mapper[i] = (e, v) => e.KPCRKEY = v;
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
