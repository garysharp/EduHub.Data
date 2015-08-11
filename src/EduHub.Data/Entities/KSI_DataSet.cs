using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Institutions Data Set
    /// </summary>
    public sealed class KSI_DataSet : SetBase<KSI_Entity>
    {
        internal KSI_DataSet(EduHubContext Context)
            : base(Context)
        {
            KSIKEY_Index = new Lazy<Dictionary<string, KSI_Entity>>(() => this.ToDictionary(e => e.KSIKEY));
        }

        public override string SetName { get { return "KSI"; } }

        private Lazy<Dictionary<string, KSI_Entity>> KSIKEY_Index;

        public KSI_Entity FindByKSIKEY(string Key)
        {
            KSI_Entity result;
            if (KSIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKSIKEY(string Key, out KSI_Entity Value)
        {
            return KSIKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KSI_Entity TryFindByKSIKEY(string Key)
        {
            KSI_Entity result;
            if (KSIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KSI_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSI_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSIKEY":
                        mapper[i] = (e, v) => e.KSIKEY = v;
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
