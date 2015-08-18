using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PRMS Order Details Data Set
    /// </summary>
    public sealed class KPRMSDataSet : SetBase<KPRMS>
    {
        private Lazy<Dictionary<int, KPRMS>> TIDIndex;

        internal KPRMSDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, KPRMS>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPRMS"; } }

        /// <summary>
        /// Find KPRMS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any KPRMS entities</exception>
        public KPRMS FindByTID(int Key)
        {
            KPRMS result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPRMS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KPRMS</param>
        /// <param name="Value">Related KPRMS entity</param>
        /// <returns>True if the KPRMS Entity is found</returns>
        public bool TryFindByTID(int Key, out KPRMS Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPRMS by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity, or null if not found</returns>
        public KPRMS TryFindByTID(int Key)
        {
            KPRMS result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KPRMS, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPRMS, string>[Headers.Count];

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
