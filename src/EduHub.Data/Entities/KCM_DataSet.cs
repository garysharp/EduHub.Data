using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions Data Set
    /// </summary>
    public sealed class KCM_DataSet : SetBase<KCM_Entity>
    {
        internal KCM_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCMKEY_Index = new Lazy<Dictionary<string, KCM_Entity>>(() => this.ToDictionary(e => e.KCMKEY));
        }

        public override string SetName { get { return "KCM"; } }

        private Lazy<Dictionary<string, KCM_Entity>> KCMKEY_Index;

        public KCM_Entity FindByKCMKEY(string Key)
        {
            KCM_Entity result;
            if (KCMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKCMKEY(string Key, out KCM_Entity Value)
        {
            return KCMKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KCM_Entity TryFindByKCMKEY(string Key)
        {
            KCM_Entity result;
            if (KCMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KCM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
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
