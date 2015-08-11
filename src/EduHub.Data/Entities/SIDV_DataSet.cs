using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients Data Set
    /// </summary>
    public sealed class SIDV_DataSet : SetBase<SIDV_Entity>
    {
        internal SIDV_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, SIDV_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "SIDV"; } }

        private Lazy<Dictionary<int, SIDV_Entity>> TID_Index;

        public SIDV_Entity FindByTID(int Key)
        {
            SIDV_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out SIDV_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public SIDV_Entity TryFindByTID(int Key)
        {
            SIDV_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SIDV_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SIDV_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "RECIPIENT_TYPE":
                        mapper[i] = (e, v) => e.RECIPIENT_TYPE = v;
                        break;
                    case "RECIPIENT":
                        mapper[i] = (e, v) => e.RECIPIENT = v;
                        break;
                    case "RECIPIENT_NAME":
                        mapper[i] = (e, v) => e.RECIPIENT_NAME = v;
                        break;
                    case "RECIPIENT_ADDRESS":
                        mapper[i] = (e, v) => e.RECIPIENT_ADDRESS = v;
                        break;
                    case "RECIPIENT_PHONE":
                        mapper[i] = (e, v) => e.RECIPIENT_PHONE = v;
                        break;
                    case "HOW_AFFECTED":
                        mapper[i] = (e, v) => e.HOW_AFFECTED = v;
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
