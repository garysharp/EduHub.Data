using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Visa Subclasses Data Set
    /// </summary>
    public sealed class KCV_DataSet : SetBase<KCV_Entity>
    {
        internal KCV_DataSet(EduHubContext Context)
            : base(Context)
        {
            VISA_SUBCLASS_Index = new Lazy<Dictionary<string, KCV_Entity>>(() => this.ToDictionary(e => e.VISA_SUBCLASS));
        }

        public override string SetName { get { return "KCV"; } }

        private Lazy<Dictionary<string, KCV_Entity>> VISA_SUBCLASS_Index;

        public KCV_Entity FindByVISA_SUBCLASS(string Key)
        {
            KCV_Entity result;
            if (VISA_SUBCLASS_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByVISA_SUBCLASS(string Key, out KCV_Entity Value)
        {
            return VISA_SUBCLASS_Index.Value.TryGetValue(Key, out Value);
        }
        public KCV_Entity TryFindByVISA_SUBCLASS(string Key)
        {
            KCV_Entity result;
            if (VISA_SUBCLASS_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KCV_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCV_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VISA_RESIDENCY":
                        mapper[i] = (e, v) => e.VISA_RESIDENCY = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "CHECK_STAT_CODE":
                        mapper[i] = (e, v) => e.CHECK_STAT_CODE = v;
                        break;
                    case "CHECK_EXPIRY_DATE":
                        mapper[i] = (e, v) => e.CHECK_EXPIRY_DATE = v;
                        break;
                    case "CHECK_ISID":
                        mapper[i] = (e, v) => e.CHECK_ISID = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
