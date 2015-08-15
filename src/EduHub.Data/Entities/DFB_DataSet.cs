using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Data Set
    /// </summary>
    public sealed class DFB_DataSet : SetBase<DFB_Entity>
    {
        private Lazy<Dictionary<string, DFB_Entity>> REFERENCE_NO_Index;

        internal DFB_DataSet(EduHubContext Context)
            : base(Context)
        {
            REFERENCE_NO_Index = new Lazy<Dictionary<string, DFB_Entity>>(() => this.ToDictionary(e => e.REFERENCE_NO));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "DFB"; } }

        /// <summary>
        /// Find DFB by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find DFB</param>
        /// <returns>Related DFB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">REFERENCE_NO value didn't match any DFB entities</exception>
        public DFB_Entity FindByREFERENCE_NO(string Key)
        {
            DFB_Entity result;
            if (REFERENCE_NO_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find DFB by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find DFB</param>
        /// <param name="Value">Related DFB entity</param>
        /// <returns>True if the DFB Entity is found</returns>
        public bool TryFindByREFERENCE_NO(string Key, out DFB_Entity Value)
        {
            return REFERENCE_NO_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by REFERENCE_NO key field
        /// </summary>
        /// <param name="Key">REFERENCE_NO value used to find DFB</param>
        /// <returns>Related DFB entity, or null if not found</returns>
        public DFB_Entity TryFindByREFERENCE_NO(string Key)
        {
            DFB_Entity result;
            if (REFERENCE_NO_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<DFB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<DFB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FAM_CODE":
                        mapper[i] = (e, v) => e.FAM_CODE = v;
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
