using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report email templates Data Set
    /// </summary>
    public sealed class SPEMAIL_DataSet : SetBase<SPEMAIL_Entity>
    {
        internal SPEMAIL_DataSet(EduHubContext Context)
            : base(Context)
        {
            SPEMAILKEY_Index = new Lazy<Dictionary<string, SPEMAIL_Entity>>(() => this.ToDictionary(e => e.SPEMAILKEY));
        }

        public override string SetName { get { return "SPEMAIL"; } }

        private Lazy<Dictionary<string, SPEMAIL_Entity>> SPEMAILKEY_Index;

        public SPEMAIL_Entity FindBySPEMAILKEY(string Key)
        {
            SPEMAIL_Entity result;
            if (SPEMAILKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySPEMAILKEY(string Key, out SPEMAIL_Entity Value)
        {
            return SPEMAILKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SPEMAIL_Entity TryFindBySPEMAILKEY(string Key)
        {
            SPEMAIL_Entity result;
            if (SPEMAILKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SPEMAIL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SPEMAIL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPEMAILKEY":
                        mapper[i] = (e, v) => e.SPEMAILKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "REPORT":
                        mapper[i] = (e, v) => e.REPORT = v;
                        break;
                    case "PRINT_PATH":
                        mapper[i] = (e, v) => e.PRINT_PATH = v;
                        break;
                    case "IMPORTANCE":
                        mapper[i] = (e, v) => e.IMPORTANCE = v;
                        break;
                    case "SEND_OPTION":
                        mapper[i] = (e, v) => e.SEND_OPTION = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "EMAIL_HTML":
                        mapper[i] = (e, v) => e.EMAIL_HTML = v;
                        break;
                    case "HTML_MESSAGE":
                        mapper[i] = (e, v) => e.HTML_MESSAGE = v;
                        break;
                    case "FROM_ADDRESS":
                        mapper[i] = (e, v) => e.FROM_ADDRESS = v;
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
