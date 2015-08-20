using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPay Data Data Set
    /// </summary>
    public sealed class BPAY_DATDataSet : SetBase<BPAY_DAT>
    {
        private Lazy<Dictionary<int, BPAY_DAT>> TIDIndex;

        internal BPAY_DATDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, BPAY_DAT>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BPAY_DAT"; } }

        /// <summary>
        /// Find BPAY_DAT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any BPAY_DAT entities</exception>
        public BPAY_DAT FindByTID(int Key)
        {
            BPAY_DAT result;
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
        /// Attempt to find BPAY_DAT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find BPAY_DAT</param>
        /// <param name="Value">Related BPAY_DAT entity</param>
        /// <returns>True if the BPAY_DAT entity is found</returns>
        public bool TryFindByTID(int Key, out BPAY_DAT Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity, or null if not found</returns>
        public BPAY_DAT TryFindByTID(int Key)
        {
            BPAY_DAT result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BPAY_DAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BPAY_DAT" /> fields for each CSV column header</returns>
        protected override Action<BPAY_DAT, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<BPAY_DAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v;
                        break;
                    case "CUST_REF":
                        mapper[i] = (e, v) => e.CUST_REF = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "SUPPORT_REF":
                        mapper[i] = (e, v) => e.SUPPORT_REF = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
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
