using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts for Sundry Debtors Data Set
    /// </summary>
    public sealed class DRBDataSet : SetBase<DRB>
    {
        private Lazy<Dictionary<string, DRB>> REFERENCE_NOIndex;

        internal DRBDataSet(EduHubContext Context)
            : base(Context)
        {
            REFERENCE_NOIndex = new Lazy<Dictionary<string, DRB>>(() => this.ToDictionary(e => e.REFERENCE_NO));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DRB"; } }

        /// <summary>
        /// Find DRB by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find DRB</param>
        /// <returns>Related DRB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">REFERENCE_NO value didn't match any DRB entities</exception>
        public DRB FindByREFERENCE_NO(string Key)
        {
            DRB result;
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
        /// Attempt to find DRB by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find DRB</param>
        /// <param name="Value">Related DRB entity</param>
        /// <returns>True if the DRB entity is found</returns>
        public bool TryFindByREFERENCE_NO(string Key, out DRB Value)
        {
            return REFERENCE_NOIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find DRB</param>
        /// <returns>Related DRB entity, or null if not found</returns>
        public DRB TryFindByREFERENCE_NO(string Key)
        {
            DRB result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="DRB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DRB" /> fields for each CSV column header</returns>
        protected override Action<DRB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DRB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DR_CODE":
                        mapper[i] = (e, v) => e.DR_CODE = v;
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
