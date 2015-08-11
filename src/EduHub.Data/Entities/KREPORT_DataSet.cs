using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing Data Set
    /// </summary>
    public sealed class KREPORT_DataSet : SetBase<KREPORT_Entity>
    {
        internal KREPORT_DataSet(EduHubContext Context)
            : base(Context)
        {
            KREPORTKEY_Index = new Lazy<Dictionary<string, KREPORT_Entity>>(() => this.ToDictionary(e => e.KREPORTKEY));
        }

        public override string SetName { get { return "KREPORT"; } }

        private Lazy<Dictionary<string, KREPORT_Entity>> KREPORTKEY_Index;

        public KREPORT_Entity FindByKREPORTKEY(string Key)
        {
            KREPORT_Entity result;
            if (KREPORTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKREPORTKEY(string Key, out KREPORT_Entity Value)
        {
            return KREPORTKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KREPORT_Entity TryFindByKREPORTKEY(string Key)
        {
            KREPORT_Entity result;
            if (KREPORTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KREPORT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KREPORT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KREPORTKEY":
                        mapper[i] = (e, v) => e.KREPORTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_CODE":
                        mapper[i] = (e, v) => e.ROLE_CODE = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
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
