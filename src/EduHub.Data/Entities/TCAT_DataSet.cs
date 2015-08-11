using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types Data Set
    /// </summary>
    public sealed class TCAT_DataSet : SetBase<TCAT_Entity>
    {
        internal TCAT_DataSet(EduHubContext Context)
            : base(Context)
        {
            TCATKEY_Index = new Lazy<Dictionary<string, TCAT_Entity>>(() => this.ToDictionary(e => e.TCATKEY));
        }

        public override string SetName { get { return "TCAT"; } }

        private Lazy<Dictionary<string, TCAT_Entity>> TCATKEY_Index;

        public TCAT_Entity FindByTCATKEY(string Key)
        {
            TCAT_Entity result;
            if (TCATKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTCATKEY(string Key, out TCAT_Entity Value)
        {
            return TCATKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public TCAT_Entity TryFindByTCATKEY(string Key)
        {
            TCAT_Entity result;
            if (TCATKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<TCAT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TCAT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCATKEY":
                        mapper[i] = (e, v) => e.TCATKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
