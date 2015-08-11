using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL Data Set
    /// </summary>
    public sealed class SEC_URL_DataSet : SetBase<SEC_URL_Entity>
    {
        internal SEC_URL_DataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLURLID_Index = new Lazy<Dictionary<int, SEC_URL_Entity>>(() => this.ToDictionary(e => e.SCHOOLURLID));
        }

        public override string SetName { get { return "SEC_URL"; } }

        private Lazy<Dictionary<int, SEC_URL_Entity>> SCHOOLURLID_Index;

        public SEC_URL_Entity FindBySCHOOLURLID(int Key)
        {
            SEC_URL_Entity result;
            if (SCHOOLURLID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySCHOOLURLID(int Key, out SEC_URL_Entity Value)
        {
            return SCHOOLURLID_Index.Value.TryGetValue(Key, out Value);
        }
        public SEC_URL_Entity TryFindBySCHOOLURLID(int Key)
        {
            SEC_URL_Entity result;
            if (SCHOOLURLID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SEC_URL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_URL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLURLID":
                        mapper[i] = (e, v) => e.SCHOOLURLID = int.Parse(v);
                        break;
                    case "LINKNAME":
                        mapper[i] = (e, v) => e.LINKNAME = v;
                        break;
                    case "MAINURL":
                        mapper[i] = (e, v) => e.MAINURL = v;
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
