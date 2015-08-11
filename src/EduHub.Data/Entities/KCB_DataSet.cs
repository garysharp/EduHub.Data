using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications Data Set
    /// </summary>
    public sealed class KCB_DataSet : SetBase<KCB_Entity>
    {
        internal KCB_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCBKEY_Index = new Lazy<Dictionary<string, KCB_Entity>>(() => this.ToDictionary(e => e.KCBKEY));
        }

        public override string SetName { get { return "KCB"; } }

        private Lazy<Dictionary<string, KCB_Entity>> KCBKEY_Index;

        public KCB_Entity FindByKCBKEY(string Key)
        {
            KCB_Entity result;
            if (KCBKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKCBKEY(string Key, out KCB_Entity Value)
        {
            return KCBKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KCB_Entity TryFindByKCBKEY(string Key)
        {
            KCB_Entity result;
            if (KCBKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KCB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCBKEY":
                        mapper[i] = (e, v) => e.KCBKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "POS_NEG":
                        mapper[i] = (e, v) => e.POS_NEG = v;
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
