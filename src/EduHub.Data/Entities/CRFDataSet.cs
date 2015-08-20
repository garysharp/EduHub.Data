using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Financial Transaction Data Set
    /// </summary>
    public sealed class CRFDataSet : SetBase<CRF>
    {
        private Lazy<Dictionary<string, CRF>> TRREFIndex;

        internal CRFDataSet(EduHubContext Context)
            : base(Context)
        {
            TRREFIndex = new Lazy<Dictionary<string, CRF>>(() => this.ToDictionary(e => e.TRREF));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "CRF"; } }

        /// <summary>
        /// Find CRF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find CRF</param>
        /// <returns>Related CRF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TRREF value didn't match any CRF entities</exception>
        public CRF FindByTRREF(string Key)
        {
            CRF result;
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
        /// Attempt to find CRF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find CRF</param>
        /// <param name="Value">Related CRF entity</param>
        /// <returns>True if the CRF entity is found</returns>
        public bool TryFindByTRREF(string Key, out CRF Value)
        {
            return TRREFIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find CRF</param>
        /// <returns>Related CRF entity, or null if not found</returns>
        public CRF TryFindByTRREF(string Key)
        {
            CRF result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRF" /> fields for each CSV column header</returns>
        protected override Action<CRF, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<CRF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "OTID":
                        mapper[i] = (e, v) => e.OTID = v == null ? (int?)null : int.Parse(v);
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
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
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
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRQTYD":
                        mapper[i] = (e, v) => e.TRQTYD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRQTYI":
                        mapper[i] = (e, v) => e.TRQTYI = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRQTYDX":
                        mapper[i] = (e, v) => e.TRQTYDX = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRQTYIX":
                        mapper[i] = (e, v) => e.TRQTYIX = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AUTODELIVER":
                        mapper[i] = (e, v) => e.AUTODELIVER = v;
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DEBIT":
                        mapper[i] = (e, v) => e.DEBIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CREDIT":
                        mapper[i] = (e, v) => e.CREDIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRPAID":
                        mapper[i] = (e, v) => e.TRPAID = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRINV":
                        mapper[i] = (e, v) => e.TRINV = v;
                        break;
                    case "TRDELETE":
                        mapper[i] = (e, v) => e.TRDELETE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRHOLD":
                        mapper[i] = (e, v) => e.TRHOLD = v;
                        break;
                    case "TRORDER":
                        mapper[i] = (e, v) => e.TRORDER = v;
                        break;
                    case "TRBANK":
                        mapper[i] = (e, v) => e.TRBANK = v;
                        break;
                    case "CHQ_NO":
                        mapper[i] = (e, v) => e.CHQ_NO = v;
                        break;
                    case "ORDER_BY":
                        mapper[i] = (e, v) => e.ORDER_BY = v;
                        break;
                    case "COMPLETED":
                        mapper[i] = (e, v) => e.COMPLETED = v;
                        break;
                    case "TRUNIT":
                        mapper[i] = (e, v) => e.TRUNIT = v;
                        break;
                    case "REQ_DATE":
                        mapper[i] = (e, v) => e.REQ_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CATALOGUE":
                        mapper[i] = (e, v) => e.CATALOGUE = v;
                        break;
                    case "DELIVERY":
                        mapper[i] = (e, v) => e.DELIVERY = v;
                        break;
                    case "PRINT_CHEQUE":
                        mapper[i] = (e, v) => e.PRINT_CHEQUE = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "WITHHOLD_AMOUNT":
                        mapper[i] = (e, v) => e.WITHHOLD_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "INV_DATE":
                        mapper[i] = (e, v) => e.INV_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DUE_DATE":
                        mapper[i] = (e, v) => e.DUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
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
                    case "EXPECTED_DATE":
                        mapper[i] = (e, v) => e.EXPECTED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEL_CODE":
                        mapper[i] = (e, v) => e.DEL_CODE = v;
                        break;
                    case "DEL_DOCKET_NO":
                        mapper[i] = (e, v) => e.DEL_DOCKET_NO = v;
                        break;
                    case "ATKEY":
                        mapper[i] = (e, v) => e.ATKEY = v;
                        break;
                    case "TINCLUDE":
                        mapper[i] = (e, v) => e.TINCLUDE = v;
                        break;
                    case "TTRNETT":
                        mapper[i] = (e, v) => e.TTRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTRAMT":
                        mapper[i] = (e, v) => e.TTRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TGST_AMOUNT":
                        mapper[i] = (e, v) => e.TGST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMEMO":
                        mapper[i] = (e, v) => e.AMEMO = v;
                        break;
                    case "AMEMO_COPY":
                        mapper[i] = (e, v) => e.AMEMO_COPY = v;
                        break;
                    case "NEXT_SVC_DATE":
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MASTERTID":
                        mapper[i] = (e, v) => e.MASTERTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ALLOCTID":
                        mapper[i] = (e, v) => e.ALLOCTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PAY_METHOD":
                        mapper[i] = (e, v) => e.PAY_METHOD = v;
                        break;
                    case "WITHHOLD_RATE":
                        mapper[i] = (e, v) => e.WITHHOLD_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRDEL_MONTHS":
                        mapper[i] = (e, v) => e.TRDEL_MONTHS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LINE_NO":
                        mapper[i] = (e, v) => e.LINE_NO = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INVOICEGST":
                        mapper[i] = (e, v) => e.INVOICEGST = v;
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
                    case "CANCELLED":
                        mapper[i] = (e, v) => e.CANCELLED = v;
                        break;
                    case "PRMS_TID":
                        mapper[i] = (e, v) => e.PRMS_TID = v == null ? (int?)null : int.Parse(v);
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
