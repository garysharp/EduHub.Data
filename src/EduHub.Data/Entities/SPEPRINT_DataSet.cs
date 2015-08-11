using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report file audit Data Set
    /// </summary>
    public sealed class SPEPRINT_DataSet : SetBase<SPEPRINT_Entity>
    {
        internal SPEPRINT_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, SPEPRINT_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "SPEPRINT"; } }

        private Lazy<Dictionary<int, SPEPRINT_Entity>> TID_Index;

        public SPEPRINT_Entity FindByTID(int Key)
        {
            SPEPRINT_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out SPEPRINT_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public SPEPRINT_Entity TryFindByTID(int Key)
        {
            SPEPRINT_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SPEPRINT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SPEPRINT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PRINT_DATE":
                        mapper[i] = (e, v) => e.PRINT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PRINT_BY":
                        mapper[i] = (e, v) => e.PRINT_BY = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SEND_BY":
                        mapper[i] = (e, v) => e.SEND_BY = v;
                        break;
                    case "ENTITY_TABLE":
                        mapper[i] = (e, v) => e.ENTITY_TABLE = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "COPY_ADDRESS":
                        mapper[i] = (e, v) => e.COPY_ADDRESS = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "ATTACHMENT_PATH":
                        mapper[i] = (e, v) => e.ATTACHMENT_PATH = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "DISPLAY":
                        mapper[i] = (e, v) => e.DISPLAY = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
