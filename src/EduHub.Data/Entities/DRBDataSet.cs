using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts for Sundry Debtors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRBDataSet : SetBase<DRB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DRB"; } }

        internal DRBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DR_CODE = new Lazy<Dictionary<string, IReadOnlyList<DRB>>>(() => this.ToGroupedDictionary(i => i.DR_CODE));
            Index_TID = new Lazy<Dictionary<int, DRB>>(() => this.ToDictionary(i => i.TID));
            Index_REFERENCE_NO = new Lazy<NullDictionary<string, IReadOnlyList<DRB>>>(() => this.ToGroupedNullDictionary(i => i.REFERENCE_NO));
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
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DRB>>> Index_DR_CODE;
        private Lazy<Dictionary<int, DRB>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<DRB>>> Index_REFERENCE_NO;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DRB by DR_CODE field
        /// </summary>
        /// <param name="DR_CODE">DR_CODE value used to find DRB</param>
        /// <returns>List of related DRB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> FindByDR_CODE(string DR_CODE)
        {
            return Index_DR_CODE.Value[DR_CODE];
        }

        /// <summary>
        /// Attempt to find DRB by DR_CODE field
        /// </summary>
        /// <param name="DR_CODE">DR_CODE value used to find DRB</param>
        /// <param name="Value">List of related DRB entities</param>
        /// <returns>True if the list of related DRB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDR_CODE(string DR_CODE, out IReadOnlyList<DRB> Value)
        {
            return Index_DR_CODE.Value.TryGetValue(DR_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by DR_CODE field
        /// </summary>
        /// <param name="DR_CODE">DR_CODE value used to find DRB</param>
        /// <returns>List of related DRB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> TryFindByDR_CODE(string DR_CODE)
        {
            IReadOnlyList<DRB> value;
            if (Index_DR_CODE.Value.TryGetValue(DR_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRB</param>
        /// <returns>Related DRB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DRB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DRB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRB</param>
        /// <param name="Value">Related DRB entity</param>
        /// <returns>True if the related DRB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DRB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRB</param>
        /// <returns>Related DRB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DRB TryFindByTID(int TID)
        {
            DRB value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DRB</param>
        /// <returns>List of related DRB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> FindByREFERENCE_NO(string REFERENCE_NO)
        {
            return Index_REFERENCE_NO.Value[REFERENCE_NO];
        }

        /// <summary>
        /// Attempt to find DRB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DRB</param>
        /// <param name="Value">List of related DRB entities</param>
        /// <returns>True if the list of related DRB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREFERENCE_NO(string REFERENCE_NO, out IReadOnlyList<DRB> Value)
        {
            return Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DRB</param>
        /// <returns>List of related DRB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> TryFindByREFERENCE_NO(string REFERENCE_NO)
        {
            IReadOnlyList<DRB> value;
            if (Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
