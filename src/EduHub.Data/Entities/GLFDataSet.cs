using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Transactions Data Set
    /// </summary>
    public sealed class GLFDataSet : SetBase<GLF>
    {
        private Lazy<Dictionary<string, GLF>> TRREFIndex;
        private Lazy<Dictionary<string, GLF>> GST_BOXIndex;
        private Lazy<Dictionary<string, GLF>> GST_SALE_PURCHIndex;

        internal GLFDataSet(EduHubContext Context)
            : base(Context)
        {
            TRREFIndex = new Lazy<Dictionary<string, GLF>>(() => this.ToDictionary(e => e.TRREF));
            GST_BOXIndex = new Lazy<Dictionary<string, GLF>>(() => this.ToDictionary(e => e.GST_BOX));
            GST_SALE_PURCHIndex = new Lazy<Dictionary<string, GLF>>(() => this.ToDictionary(e => e.GST_SALE_PURCH));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLF"; } }

        /// <summary>
        /// Find GLF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find GLF</param>
        /// <returns>Related GLF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TRREF value didn't match any GLF entities</exception>
        public GLF FindByTRREF(string Key)
        {
            GLF result;
            if (TRREFIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find GLF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find GLF</param>
        /// <param name="Value">Related GLF entity</param>
        /// <returns>True if the GLF entity is found</returns>
        public bool TryFindByTRREF(string Key, out GLF Value)
        {
            return TRREFIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find GLF</param>
        /// <returns>Related GLF entity, or null if not found</returns>
        public GLF TryFindByTRREF(string Key)
        {
            GLF result;
            if (TRREFIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLF by GST_BOX key field
        /// </summary>
        /// <param name="Key">GST_BOX value used to find GLF</param>
        /// <returns>Related GLF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GST_BOX value didn't match any GLF entities</exception>
        public GLF FindByGST_BOX(string Key)
        {
            GLF result;
            if (GST_BOXIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find GLF by GST_BOX key field
        /// </summary>
        /// <param name="Key">GST_BOX value used to find GLF</param>
        /// <param name="Value">Related GLF entity</param>
        /// <returns>True if the GLF entity is found</returns>
        public bool TryFindByGST_BOX(string Key, out GLF Value)
        {
            return GST_BOXIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by GST_BOX key field
        /// </summary>
        /// <param name="Key">GST_BOX value used to find GLF</param>
        /// <returns>Related GLF entity, or null if not found</returns>
        public GLF TryFindByGST_BOX(string Key)
        {
            GLF result;
            if (GST_BOXIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLF by GST_SALE_PURCH key field
        /// </summary>
        /// <param name="Key">GST_SALE_PURCH value used to find GLF</param>
        /// <returns>Related GLF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GST_SALE_PURCH value didn't match any GLF entities</exception>
        public GLF FindByGST_SALE_PURCH(string Key)
        {
            GLF result;
            if (GST_SALE_PURCHIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find GLF by GST_SALE_PURCH key field
        /// </summary>
        /// <param name="Key">GST_SALE_PURCH value used to find GLF</param>
        /// <param name="Value">Related GLF entity</param>
        /// <returns>True if the GLF entity is found</returns>
        public bool TryFindByGST_SALE_PURCH(string Key, out GLF Value)
        {
            return GST_SALE_PURCHIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by GST_SALE_PURCH key field
        /// </summary>
        /// <param name="Key">GST_SALE_PURCH value used to find GLF</param>
        /// <returns>Related GLF entity, or null if not found</returns>
        public GLF TryFindByGST_SALE_PURCH(string Key)
        {
            GLF result;
            if (GST_SALE_PURCHIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLF" /> fields for each CSV column header</returns>
        protected override Action<GLF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "TRXTRTYPE":
                        mapper[i] = (e, v) => e.TRXTRTYPE = v;
                        break;
                    case "TRSHORT":
                        mapper[i] = (e, v) => e.TRSHORT = v;
                        break;
                    case "TRBANK":
                        mapper[i] = (e, v) => e.TRBANK = v;
                        break;
                    case "RECONCILE":
                        mapper[i] = (e, v) => e.RECONCILE = v;
                        break;
                    case "RECONCILE_FLAGGED":
                        mapper[i] = (e, v) => e.RECONCILE_FLAGGED = v;
                        break;
                    case "RECONCILE_DATE":
                        mapper[i] = (e, v) => e.RECONCILE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECONCILE_USER":
                        mapper[i] = (e, v) => e.RECONCILE_USER = v;
                        break;
                    case "RECONCILE_STATEMENT":
                        mapper[i] = (e, v) => e.RECONCILE_STATEMENT = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PRINT_CHEQUE":
                        mapper[i] = (e, v) => e.PRINT_CHEQUE = v;
                        break;
                    case "CHEQUE_NO":
                        mapper[i] = (e, v) => e.CHEQUE_NO = v;
                        break;
                    case "PAYEE":
                        mapper[i] = (e, v) => e.PAYEE = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "CHQ_TID":
                        mapper[i] = (e, v) => e.CHQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GST_PERD":
                        mapper[i] = (e, v) => e.GST_PERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "GST_SALE_PURCH":
                        mapper[i] = (e, v) => e.GST_SALE_PURCH = v;
                        break;
                    case "SOURCE_TID":
                        mapper[i] = (e, v) => e.SOURCE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "WITHHOLD_AMOUNT":
                        mapper[i] = (e, v) => e.WITHHOLD_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WITHHOLD_TYPE":
                        mapper[i] = (e, v) => e.WITHHOLD_TYPE = v;
                        break;
                    case "WITHHOLD_RATE":
                        mapper[i] = (e, v) => e.WITHHOLD_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "EOY_KEPT":
                        mapper[i] = (e, v) => e.EOY_KEPT = v;
                        break;
                    case "DRAWER":
                        mapper[i] = (e, v) => e.DRAWER = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "BRANCH":
                        mapper[i] = (e, v) => e.BRANCH = v;
                        break;
                    case "ACCOUNT_NUMBER":
                        mapper[i] = (e, v) => e.ACCOUNT_NUMBER = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "LINE_NO":
                        mapper[i] = (e, v) => e.LINE_NO = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DEBIT_TOTAL":
                        mapper[i] = (e, v) => e.DEBIT_TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CREDIT_TOTAL":
                        mapper[i] = (e, v) => e.CREDIT_TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "DEBIT":
                        mapper[i] = (e, v) => e.DEBIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CREDIT":
                        mapper[i] = (e, v) => e.CREDIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CANCELLED":
                        mapper[i] = (e, v) => e.CANCELLED = v;
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
