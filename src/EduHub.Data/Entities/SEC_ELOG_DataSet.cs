using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Error Log Data Set
    /// </summary>
    public sealed class SEC_ELOG_DataSet : SetBase<SEC_ELOG_Entity>
    {
        internal SEC_ELOG_DataSet(EduHubContext Context)
            : base(Context)
        {
            ERRORCOUNT_Index = new Lazy<Dictionary<int, SEC_ELOG_Entity>>(() => this.ToDictionary(e => e.ERRORCOUNT));
        }

        public override string SetName { get { return "SEC_ELOG"; } }

        private Lazy<Dictionary<int, SEC_ELOG_Entity>> ERRORCOUNT_Index;

        public SEC_ELOG_Entity FindByERRORCOUNT(int Key)
        {
            SEC_ELOG_Entity result;
            if (ERRORCOUNT_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByERRORCOUNT(int Key, out SEC_ELOG_Entity Value)
        {
            return ERRORCOUNT_Index.Value.TryGetValue(Key, out Value);
        }
        public SEC_ELOG_Entity TryFindByERRORCOUNT(int Key)
        {
            SEC_ELOG_Entity result;
            if (ERRORCOUNT_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SEC_ELOG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_ELOG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ERRORCOUNT":
                        mapper[i] = (e, v) => e.ERRORCOUNT = int.Parse(v);
                        break;
                    case "ERRORDESCRIPTION":
                        mapper[i] = (e, v) => e.ERRORDESCRIPTION = v;
                        break;
                    case "ERRORTYPE":
                        mapper[i] = (e, v) => e.ERRORTYPE = v;
                        break;
                    case "ERRORTIME":
                        mapper[i] = (e, v) => e.ERRORTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
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
