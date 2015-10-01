using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Import Data Set
    /// </summary>
    public sealed class KBPDataSet : SetBase<KBP>
    {
        private Lazy<Dictionary<int, KBP>> TIDIndex;
        private Lazy<Dictionary<string, KBP>> REFERENCE_NOIndex;

        internal KBPDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, KBP>>(() => this.ToDictionary(e => e.TID));
            REFERENCE_NOIndex = new Lazy<Dictionary<string, KBP>>(() => this.ToDictionary(e => e.REFERENCE_NO));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KBP"; } }

        /// <summary>
        /// Find KBP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KBP</param>
        /// <returns>Related KBP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any KBP entities</exception>
        public KBP FindByTID(int Key)
        {
            KBP result;
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
        /// Attempt to find KBP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KBP</param>
        /// <param name="Value">Related KBP entity</param>
        /// <returns>True if the KBP entity is found</returns>
        public bool TryFindByTID(int Key, out KBP Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KBP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KBP</param>
        /// <returns>Related KBP entity, or null if not found</returns>
        public KBP TryFindByTID(int Key)
        {
            KBP result;
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
        /// Find KBP by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find KBP</param>
        /// <returns>Related KBP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">REFERENCE_NO value didn't match any KBP entities</exception>
        public KBP FindByREFERENCE_NO(string Key)
        {
            KBP result;
            if (REFERENCE_NOIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KBP by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find KBP</param>
        /// <param name="Value">Related KBP entity</param>
        /// <returns>True if the KBP entity is found</returns>
        public bool TryFindByREFERENCE_NO(string Key, out KBP Value)
        {
            return REFERENCE_NOIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KBP by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find KBP</param>
        /// <returns>Related KBP entity, or null if not found</returns>
        public KBP TryFindByREFERENCE_NO(string Key)
        {
            KBP result;
            if (REFERENCE_NOIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KBP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KBP" /> fields for each CSV column header</returns>
        protected override Action<KBP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KBP, string>[Headers.Count];

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
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
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
