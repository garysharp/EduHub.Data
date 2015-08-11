using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Available Qualifications Data Set
    /// </summary>
    public sealed class KSQ_DataSet : SetBase<KSQ_Entity>
    {
        internal KSQ_DataSet(EduHubContext Context)
            : base(Context)
        {
            KSQKEY_Index = new Lazy<Dictionary<string, KSQ_Entity>>(() => this.ToDictionary(e => e.KSQKEY));
        }

        public override string SetName { get { return "KSQ"; } }

        private Lazy<Dictionary<string, KSQ_Entity>> KSQKEY_Index;

        public KSQ_Entity FindByKSQKEY(string Key)
        {
            KSQ_Entity result;
            if (KSQKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKSQKEY(string Key, out KSQ_Entity Value)
        {
            return KSQKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KSQ_Entity TryFindByKSQKEY(string Key)
        {
            KSQ_Entity result;
            if (KSQKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KSQ_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSQ_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSQKEY":
                        mapper[i] = (e, v) => e.KSQKEY = v;
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
