using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description Data Set
    /// </summary>
    public sealed class PLC_DataSet : SetBase<PLC_Entity>
    {
        internal PLC_DataSet(EduHubContext Context)
            : base(Context)
        {
            PLCKEY_Index = new Lazy<Dictionary<string, PLC_Entity>>(() => this.ToDictionary(e => e.PLCKEY));
        }

        public override string SetName { get { return "PLC"; } }

        private Lazy<Dictionary<string, PLC_Entity>> PLCKEY_Index;

        public PLC_Entity FindByPLCKEY(string Key)
        {
            PLC_Entity result;
            if (PLCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPLCKEY(string Key, out PLC_Entity Value)
        {
            return PLCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PLC_Entity TryFindByPLCKEY(string Key)
        {
            PLC_Entity result;
            if (PLCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PLC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PLC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLCKEY":
                        mapper[i] = (e, v) => e.PLCKEY = v;
                        break;
                    case "LEAVE_DESC":
                        mapper[i] = (e, v) => e.LEAVE_DESC = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
