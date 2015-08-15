using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Temp Receipts Import Data Set
    /// </summary>
    public sealed class KBPT_DataSet : SetBase<KBPT_Entity>
    {
        private Lazy<Dictionary<int, KBPT_Entity>> TID_Index;

        internal KBPT_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, KBPT_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KBPT"; } }

        /// <summary>
        /// Find KBPT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KBPT</param>
        /// <returns>Related KBPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any KBPT entities</exception>
        public KBPT_Entity FindByTID(int Key)
        {
            KBPT_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KBPT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KBPT</param>
        /// <param name="Value">Related KBPT entity</param>
        /// <returns>True if the KBPT Entity is found</returns>
        public bool TryFindByTID(int Key, out KBPT_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KBPT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KBPT</param>
        /// <returns>Related KBPT entity, or null if not found</returns>
        public KBPT_Entity TryFindByTID(int Key)
        {
            KBPT_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KBPT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KBPT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CUST_REFERENCE":
                        mapper[i] = (e, v) => e.CUST_REFERENCE = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "INVOICE_TID":
                        mapper[i] = (e, v) => e.INVOICE_TID = v == null ? (int?)null : int.Parse(v);
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
