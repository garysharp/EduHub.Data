using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages Data Set
    /// </summary>
    public sealed class KGL_DataSet : SetBase<KGL_Entity>
    {
        internal KGL_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGLKEY_Index = new Lazy<Dictionary<string, KGL_Entity>>(() => this.ToDictionary(e => e.KGLKEY));
        }

        public override string SetName { get { return "KGL"; } }

        private Lazy<Dictionary<string, KGL_Entity>> KGLKEY_Index;

        public KGL_Entity FindByKGLKEY(string Key)
        {
            KGL_Entity result;
            if (KGLKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKGLKEY(string Key, out KGL_Entity Value)
        {
            return KGLKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KGL_Entity TryFindByKGLKEY(string Key)
        {
            KGL_Entity result;
            if (KGLKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGLKEY":
                        mapper[i] = (e, v) => e.KGLKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NOTICES_AVAILABLE":
                        mapper[i] = (e, v) => e.NOTICES_AVAILABLE = v;
                        break;
                    case "ASCL":
                        mapper[i] = (e, v) => e.ASCL = v;
                        break;
                    case "CASESKEY":
                        mapper[i] = (e, v) => e.CASESKEY = v;
                        break;
                    case "CASES_CASES21_CONV":
                        mapper[i] = (e, v) => e.CASES_CASES21_CONV = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
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
