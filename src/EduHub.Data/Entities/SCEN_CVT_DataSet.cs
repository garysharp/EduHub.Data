using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Type Data Set
    /// </summary>
    public sealed class SCEN_CVT_DataSet : SetBase<SCEN_CVT_Entity>
    {
        internal SCEN_CVT_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_CVT_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        public override string SetName { get { return "SCEN_CVT"; } }

        private Lazy<Dictionary<int, SCEN_CVT_Entity>> ID_Index;

        public SCEN_CVT_Entity FindByID(int Key)
        {
            SCEN_CVT_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByID(int Key, out SCEN_CVT_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SCEN_CVT_Entity TryFindByID(int Key)
        {
            SCEN_CVT_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SCEN_CVT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_CVT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "VCODE":
                        mapper[i] = (e, v) => e.VCODE = v;
                        break;
                    case "VALIDATIONMESSAGE":
                        mapper[i] = (e, v) => e.VALIDATIONMESSAGE = v;
                        break;
                    case "WARNING":
                        mapper[i] = (e, v) => e.WARNING = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "DETAILEDMESSAGE":
                        mapper[i] = (e, v) => e.DETAILEDMESSAGE = v;
                        break;
                    case "CVT_TYPE":
                        mapper[i] = (e, v) => e.CVT_TYPE = v;
                        break;
                    case "COMMANDNAME":
                        mapper[i] = (e, v) => e.COMMANDNAME = v;
                        break;
                    case "ISENABLED":
                        mapper[i] = (e, v) => e.ISENABLED = v;
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
