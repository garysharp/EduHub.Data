using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries Data Set
    /// </summary>
    public sealed class KGT_DataSet : SetBase<KGT_Entity>
    {
        internal KGT_DataSet(EduHubContext Context)
            : base(Context)
        {
            COUNTRY_Index = new Lazy<Dictionary<string, KGT_Entity>>(() => this.ToDictionary(e => e.COUNTRY));
        }

        public override string SetName { get { return "KGT"; } }

        private Lazy<Dictionary<string, KGT_Entity>> COUNTRY_Index;

        public KGT_Entity FindByCOUNTRY(string Key)
        {
            KGT_Entity result;
            if (COUNTRY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByCOUNTRY(string Key, out KGT_Entity Value)
        {
            return COUNTRY_Index.Value.TryGetValue(Key, out Value);
        }
        public KGT_Entity TryFindByCOUNTRY(string Key)
        {
            KGT_Entity result;
            if (COUNTRY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ENGLISH_SPEAKING":
                        mapper[i] = (e, v) => e.ENGLISH_SPEAKING = v;
                        break;
                    case "SACC":
                        mapper[i] = (e, v) => e.SACC = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
