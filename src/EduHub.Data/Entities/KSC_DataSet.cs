using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions Data Set
    /// </summary>
    public sealed class KSC_DataSet : SetBase<KSC_Entity>
    {
        internal KSC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KSCKEY_Index = new Lazy<Dictionary<string, KSC_Entity>>(() => this.ToDictionary(e => e.KSCKEY));
        }

        public override string SetName { get { return "KSC"; } }

        private Lazy<Dictionary<string, KSC_Entity>> KSCKEY_Index;

        public KSC_Entity FindByKSCKEY(string Key)
        {
            KSC_Entity result;
            if (KSCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKSCKEY(string Key, out KSC_Entity Value)
        {
            return KSCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KSC_Entity TryFindByKSCKEY(string Key)
        {
            KSC_Entity result;
            if (KSCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KSC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSCKEY":
                        mapper[i] = (e, v) => e.KSCKEY = v;
                        break;
                    case "SF_POSITION":
                        mapper[i] = (e, v) => e.SF_POSITION = v;
                        break;
                    case "ALLOTMENT":
                        mapper[i] = (e, v) => e.ALLOTMENT = v == null ? (short?)null : short.Parse(v);
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
