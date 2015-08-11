using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Application Message Data Data Set
    /// </summary>
    public sealed class SCEN_APP_DataSet : SetBase<SCEN_APP_Entity>
    {
        internal SCEN_APP_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_APP_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        public override string SetName { get { return "SCEN_APP"; } }

        private Lazy<Dictionary<int, SCEN_APP_Entity>> ID_Index;

        public SCEN_APP_Entity FindByID(int Key)
        {
            SCEN_APP_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByID(int Key, out SCEN_APP_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SCEN_APP_Entity TryFindByID(int Key)
        {
            SCEN_APP_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SCEN_APP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_APP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ITEMNAME":
                        mapper[i] = (e, v) => e.ITEMNAME = v;
                        break;
                    case "ITEMVALUE":
                        mapper[i] = (e, v) => e.ITEMVALUE = v;
                        break;
                    case "ITEMTYPE":
                        mapper[i] = (e, v) => e.ITEMTYPE = v;
                        break;
                    case "ITEMMINITYPE":
                        mapper[i] = (e, v) => e.ITEMMINITYPE = v;
                        break;
                    case "ITEMCOMMENTS":
                        mapper[i] = (e, v) => e.ITEMCOMMENTS = v;
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
