using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups Data Set
    /// </summary>
    public sealed class KGC_DataSet : SetBase<KGC_Entity>
    {
        internal KGC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGCKEY_Index = new Lazy<Dictionary<string, KGC_Entity>>(() => this.ToDictionary(e => e.KGCKEY));
        }

        public override string SetName { get { return "KGC"; } }

        private Lazy<Dictionary<string, KGC_Entity>> KGCKEY_Index;

        public KGC_Entity FindByKGCKEY(string Key)
        {
            KGC_Entity result;
            if (KGCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKGCKEY(string Key, out KGC_Entity Value)
        {
            return KGCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KGC_Entity TryFindByKGCKEY(string Key)
        {
            KGC_Entity result;
            if (KGCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "HG_SIZE":
                        mapper[i] = (e, v) => e.HG_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MIN_AC_YR":
                        mapper[i] = (e, v) => e.MIN_AC_YR = v;
                        break;
                    case "MAX_AC_YR":
                        mapper[i] = (e, v) => e.MAX_AC_YR = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
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
