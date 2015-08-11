using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PRMS Order Details Data Set
    /// </summary>
    public sealed class KPRMS_DataSet : SetBase<KPRMS_Entity>
    {
        internal KPRMS_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, KPRMS_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "KPRMS"; } }

        private Lazy<Dictionary<int, KPRMS_Entity>> TID_Index;

        public KPRMS_Entity FindByTID(int Key)
        {
            KPRMS_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out KPRMS_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public KPRMS_Entity TryFindByTID(int Key)
        {
            KPRMS_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KPRMS_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPRMS_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PRMS_ORDERNO":
                        mapper[i] = (e, v) => e.PRMS_ORDERNO = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ORDER_LINENO":
                        mapper[i] = (e, v) => e.ORDER_LINENO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ORDER_DESC":
                        mapper[i] = (e, v) => e.ORDER_DESC = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "GLSUBPROG":
                        mapper[i] = (e, v) => e.GLSUBPROG = v;
                        break;
                    case "GLINIT":
                        mapper[i] = (e, v) => e.GLINIT = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "GST_CODE":
                        mapper[i] = (e, v) => e.GST_CODE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
