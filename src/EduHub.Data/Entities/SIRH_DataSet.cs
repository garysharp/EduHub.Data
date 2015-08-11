using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// On line receipt history Data Set
    /// </summary>
    public sealed class SIRH_DataSet : SetBase<SIRH_Entity>
    {
        internal SIRH_DataSet(EduHubContext Context)
            : base(Context)
        {
            SIRHKEY_Index = new Lazy<Dictionary<string, SIRH_Entity>>(() => this.ToDictionary(e => e.SIRHKEY));
        }

        public override string SetName { get { return "SIRH"; } }

        private Lazy<Dictionary<string, SIRH_Entity>> SIRHKEY_Index;

        public SIRH_Entity FindBySIRHKEY(string Key)
        {
            SIRH_Entity result;
            if (SIRHKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySIRHKEY(string Key, out SIRH_Entity Value)
        {
            return SIRHKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SIRH_Entity TryFindBySIRHKEY(string Key)
        {
            SIRH_Entity result;
            if (SIRHKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SIRH_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SIRH_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIRHKEY":
                        mapper[i] = (e, v) => e.SIRHKEY = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "RECEIPT_USER":
                        mapper[i] = (e, v) => e.RECEIPT_USER = v;
                        break;
                    case "RECEIPT_DATE":
                        mapper[i] = (e, v) => e.RECEIPT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECEIPT_TIME":
                        mapper[i] = (e, v) => e.RECEIPT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NEW_TRREF":
                        mapper[i] = (e, v) => e.NEW_TRREF = v;
                        break;
                    case "ERROR_FLAG":
                        mapper[i] = (e, v) => e.ERROR_FLAG = v;
                        break;
                    case "ERROR_COMMENT":
                        mapper[i] = (e, v) => e.ERROR_COMMENT = v;
                        break;
                    case "ERROR_USER":
                        mapper[i] = (e, v) => e.ERROR_USER = v;
                        break;
                    case "FORMAT_ID":
                        mapper[i] = (e, v) => e.FORMAT_ID = v;
                        break;
                    case "PRINT_ID":
                        mapper[i] = (e, v) => e.PRINT_ID = v == null ? (int?)null : int.Parse(v);
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
