using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Financial Transaction Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRFDataSet : SetBase<CRF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "CRF"; } }

        internal CRFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, CRF>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_DEL_CODE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.DEL_CODE));
            Index_ATKEY = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.ATKEY));
            Index_INVOICEGST = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.INVOICEGST));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRF" /> fields for each CSV column header</returns>
        protected override Action<CRF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CRF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> Index_CODE;
        private Lazy<Dictionary<int, CRF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_TRREF;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_BSB;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_DEL_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_ATKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_INVOICEGST;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CRF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find CRF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<CRF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<CRF> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRF</param>
        /// <returns>Related CRF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find CRF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRF</param>
        /// <param name="Value">Related CRF entity</param>
        /// <returns>True if the related CRF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out CRF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRF</param>
        /// <returns>Related CRF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRF TryFindByTID(int TID)
        {
            CRF value;
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
        /// Find CRF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find CRF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<CRF> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<CRF> value;
            if (Index_TRREF.Value.TryGetValue(TRREF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find CRF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<CRF> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<CRF> value;
            if (Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find CRF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<CRF> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByBSB(string BSB)
        {
            IReadOnlyList<CRF> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by DEL_CODE field
        /// </summary>
        /// <param name="DEL_CODE">DEL_CODE value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByDEL_CODE(string DEL_CODE)
        {
            return Index_DEL_CODE.Value[DEL_CODE];
        }

        /// <summary>
        /// Attempt to find CRF by DEL_CODE field
        /// </summary>
        /// <param name="DEL_CODE">DEL_CODE value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEL_CODE(string DEL_CODE, out IReadOnlyList<CRF> Value)
        {
            return Index_DEL_CODE.Value.TryGetValue(DEL_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by DEL_CODE field
        /// </summary>
        /// <param name="DEL_CODE">DEL_CODE value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByDEL_CODE(string DEL_CODE)
        {
            IReadOnlyList<CRF> value;
            if (Index_DEL_CODE.Value.TryGetValue(DEL_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by ATKEY field
        /// </summary>
        /// <param name="ATKEY">ATKEY value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByATKEY(string ATKEY)
        {
            return Index_ATKEY.Value[ATKEY];
        }

        /// <summary>
        /// Attempt to find CRF by ATKEY field
        /// </summary>
        /// <param name="ATKEY">ATKEY value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByATKEY(string ATKEY, out IReadOnlyList<CRF> Value)
        {
            return Index_ATKEY.Value.TryGetValue(ATKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by ATKEY field
        /// </summary>
        /// <param name="ATKEY">ATKEY value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByATKEY(string ATKEY)
        {
            IReadOnlyList<CRF> value;
            if (Index_ATKEY.Value.TryGetValue(ATKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by INVOICEGST field
        /// </summary>
        /// <param name="INVOICEGST">INVOICEGST value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByINVOICEGST(string INVOICEGST)
        {
            return Index_INVOICEGST.Value[INVOICEGST];
        }

        /// <summary>
        /// Attempt to find CRF by INVOICEGST field
        /// </summary>
        /// <param name="INVOICEGST">INVOICEGST value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOICEGST(string INVOICEGST, out IReadOnlyList<CRF> Value)
        {
            return Index_INVOICEGST.Value.TryGetValue(INVOICEGST, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by INVOICEGST field
        /// </summary>
        /// <param name="INVOICEGST">INVOICEGST value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByINVOICEGST(string INVOICEGST)
        {
            IReadOnlyList<CRF> value;
            if (Index_INVOICEGST.Value.TryGetValue(INVOICEGST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find CRF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<CRF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<CRF> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find CRF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<CRF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<CRF> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
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
