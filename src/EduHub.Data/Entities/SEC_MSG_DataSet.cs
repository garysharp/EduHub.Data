using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message Data Set
    /// </summary>
    public sealed class SEC_MSG_DataSet : SetBase<SEC_MSG_Entity>
    {
        internal SEC_MSG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLMSGID_Index = new Lazy<Dictionary<int, SEC_MSG_Entity>>(() => this.ToDictionary(e => e.SCHOOLMSGID));
        }

        public override string SetName { get { return "SEC_MSG"; } }

        private Lazy<Dictionary<int, SEC_MSG_Entity>> SCHOOLMSGID_Index;

        public SEC_MSG_Entity FindBySCHOOLMSGID(int Key)
        {
            SEC_MSG_Entity result;
            if (SCHOOLMSGID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySCHOOLMSGID(int Key, out SEC_MSG_Entity Value)
        {
            return SCHOOLMSGID_Index.Value.TryGetValue(Key, out Value);
        }
        public SEC_MSG_Entity TryFindBySCHOOLMSGID(int Key)
        {
            SEC_MSG_Entity result;
            if (SCHOOLMSGID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SEC_MSG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_MSG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLMSGID":
                        mapper[i] = (e, v) => e.SCHOOLMSGID = int.Parse(v);
                        break;
                    case "MSGTEXT":
                        mapper[i] = (e, v) => e.MSGTEXT = v;
                        break;
                    case "EDITBYUSERID":
                        mapper[i] = (e, v) => e.EDITBYUSERID = v;
                        break;
                    case "EDITDATE":
                        mapper[i] = (e, v) => e.EDITDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
