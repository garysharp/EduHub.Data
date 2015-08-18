using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial History Data Set
    /// </summary>
    public sealed class FINHISTDataSet : SetBase<FINHIST>
    {
        private Lazy<Dictionary<int, FINHIST>> IDIndex;

        internal FINHISTDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, FINHIST>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FINHIST"; } }

        /// <summary>
        /// Find FINHIST by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any FINHIST entities</exception>
        public FINHIST FindByID(int Key)
        {
            FINHIST result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find FINHIST by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find FINHIST</param>
        /// <param name="Value">Related FINHIST entity</param>
        /// <returns>True if the FINHIST Entity is found</returns>
        public bool TryFindByID(int Key, out FINHIST Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find FINHIST by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity, or null if not found</returns>
        public FINHIST TryFindByID(int Key)
        {
            FINHIST result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<FINHIST, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<FINHIST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "LEDGER":
                        mapper[i] = (e, v) => e.LEDGER = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "TRANSACTION_ID":
                        mapper[i] = (e, v) => e.TRANSACTION_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
