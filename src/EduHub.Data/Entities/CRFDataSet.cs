using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Financial Transaction Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRFDataSet : EduHubDataSet<CRF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "CRF"; } }

        internal CRFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ATKEY = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.ATKEY));
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_DEL_CODE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.DEL_CODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_INVOICEGST = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.INVOICEGST));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, CRF>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
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

        /// <summary>
        /// Merges <see cref="CRF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="CRF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="CRF" /> items to added or update the base <see cref="CRF" /> items</param>
        /// <returns>A merged list of <see cref="CRF" /> items</returns>
        protected override List<CRF> ApplyDeltaItems(List<CRF> Items, List<CRF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (CRF deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_ATKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_DEL_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_INVOICEGST;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, CRF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_TRREF;

        #endregion

        #region Index Methods

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

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns SQL which checks for the existence of a CRF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CRF](
        [TID] int NOT NULL,
        [OTID] int NULL,
        [CODE] varchar(10) NOT NULL,
        [TRBATCH] int NULL,
        [TRPERD] int NULL,
        [TRTYPE] varchar(1) NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [TRXTRTYPE] varchar(1) NULL,
        [TRCOST] money NULL,
        [TRQTY] int NULL,
        [TRQTYD] int NULL,
        [TRQTYI] int NULL,
        [TRQTYDX] int NULL,
        [TRQTYIX] int NULL,
        [AUTODELIVER] varchar(1) NULL,
        [TRAMT] money NULL,
        [DEBIT] money NULL,
        [CREDIT] money NULL,
        [TRPAID] money NULL,
        [TRINV] varchar(10) NULL,
        [TRDELETE] smallint NULL,
        [TRDET] varchar(30) NULL,
        [TRHOLD] varchar(1) NULL,
        [TRORDER] varchar(10) NULL,
        [TRBANK] varchar(10) NULL,
        [CHQ_NO] varchar(10) NULL,
        [ORDER_BY] varchar(5) NULL,
        [COMPLETED] varchar(1) NULL,
        [TRUNIT] varchar(10) NULL,
        [REQ_DATE] datetime NULL,
        [CATALOGUE] varchar(15) NULL,
        [DELIVERY] varchar(30) NULL,
        [PRINT_CHEQUE] varchar(1) NULL,
        [TAX] varchar(1) NULL,
        [TRNETT] money NULL,
        [TRGROSS] money NULL,
        [GST_AMOUNT] money NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RATE] float NULL,
        [GST_RECLAIM] varchar(1) NULL,
        [WITHHOLD_AMOUNT] money NULL,
        [INV_DATE] datetime NULL,
        [DUE_DATE] datetime NULL,
        [RTYPE] varchar(2) NULL,
        [DRAWER] varchar(20) NULL,
        [BSB] varchar(6) NULL,
        [BANK] varchar(20) NULL,
        [BRANCH] varchar(20) NULL,
        [ACCOUNT_NUMBER] int NULL,
        [EXPECTED_DATE] datetime NULL,
        [DEL_CODE] varchar(10) NULL,
        [DEL_DOCKET_NO] varchar(10) NULL,
        [ATKEY] varchar(10) NULL,
        [TINCLUDE] varchar(1) NULL,
        [TTRNETT] money NULL,
        [TTRAMT] money NULL,
        [TGST_AMOUNT] money NULL,
        [AMEMO] text NULL,
        [AMEMO_COPY] varchar(1) NULL,
        [NEXT_SVC_DATE] datetime NULL,
        [MASTERTID] int NULL,
        [ALLOCTID] int NULL,
        [PAY_METHOD] varchar(2) NULL,
        [WITHHOLD_RATE] float NULL,
        [TRDEL_MONTHS] smallint NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [INVOICEGST] varchar(4) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [CANCELLED] varchar(3) NULL,
        [PRMS_TID] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CRF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_ATKEY] ON [dbo].[CRF]
    (
            [ATKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_BSB] ON [dbo].[CRF]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [CRF_Index_CODE] ON [dbo].[CRF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_DEL_CODE] ON [dbo].[CRF]
    (
            [DEL_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_GST_TYPE] ON [dbo].[CRF]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_INITIATIVE] ON [dbo].[CRF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_INVOICEGST] ON [dbo].[CRF]
    (
            [INVOICEGST] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_SUBPROGRAM] ON [dbo].[CRF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_TRREF] ON [dbo].[CRF]
    (
            [TRREF] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new CRFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRFDataReader : IDataReader, IDataRecord
        {
            private List<CRF> Items;
            private int CurrentIndex;
            private CRF CurrentItem;

            public CRFDataReader(List<CRF> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 79; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // OTID
                        return CurrentItem.OTID;
                    case 2: // CODE
                        return CurrentItem.CODE;
                    case 3: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 4: // TRPERD
                        return CurrentItem.TRPERD;
                    case 5: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 6: // TRDATE
                        return CurrentItem.TRDATE;
                    case 7: // TRREF
                        return CurrentItem.TRREF;
                    case 8: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 9: // TRXCODE
                        return CurrentItem.TRXCODE;
                    case 10: // TRXTRTYPE
                        return CurrentItem.TRXTRTYPE;
                    case 11: // TRCOST
                        return CurrentItem.TRCOST;
                    case 12: // TRQTY
                        return CurrentItem.TRQTY;
                    case 13: // TRQTYD
                        return CurrentItem.TRQTYD;
                    case 14: // TRQTYI
                        return CurrentItem.TRQTYI;
                    case 15: // TRQTYDX
                        return CurrentItem.TRQTYDX;
                    case 16: // TRQTYIX
                        return CurrentItem.TRQTYIX;
                    case 17: // AUTODELIVER
                        return CurrentItem.AUTODELIVER;
                    case 18: // TRAMT
                        return CurrentItem.TRAMT;
                    case 19: // DEBIT
                        return CurrentItem.DEBIT;
                    case 20: // CREDIT
                        return CurrentItem.CREDIT;
                    case 21: // TRPAID
                        return CurrentItem.TRPAID;
                    case 22: // TRINV
                        return CurrentItem.TRINV;
                    case 23: // TRDELETE
                        return CurrentItem.TRDELETE;
                    case 24: // TRDET
                        return CurrentItem.TRDET;
                    case 25: // TRHOLD
                        return CurrentItem.TRHOLD;
                    case 26: // TRORDER
                        return CurrentItem.TRORDER;
                    case 27: // TRBANK
                        return CurrentItem.TRBANK;
                    case 28: // CHQ_NO
                        return CurrentItem.CHQ_NO;
                    case 29: // ORDER_BY
                        return CurrentItem.ORDER_BY;
                    case 30: // COMPLETED
                        return CurrentItem.COMPLETED;
                    case 31: // TRUNIT
                        return CurrentItem.TRUNIT;
                    case 32: // REQ_DATE
                        return CurrentItem.REQ_DATE;
                    case 33: // CATALOGUE
                        return CurrentItem.CATALOGUE;
                    case 34: // DELIVERY
                        return CurrentItem.DELIVERY;
                    case 35: // PRINT_CHEQUE
                        return CurrentItem.PRINT_CHEQUE;
                    case 36: // TAX
                        return CurrentItem.TAX;
                    case 37: // TRNETT
                        return CurrentItem.TRNETT;
                    case 38: // TRGROSS
                        return CurrentItem.TRGROSS;
                    case 39: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT;
                    case 40: // GST_TYPE
                        return CurrentItem.GST_TYPE;
                    case 41: // GST_RATE
                        return CurrentItem.GST_RATE;
                    case 42: // GST_RECLAIM
                        return CurrentItem.GST_RECLAIM;
                    case 43: // WITHHOLD_AMOUNT
                        return CurrentItem.WITHHOLD_AMOUNT;
                    case 44: // INV_DATE
                        return CurrentItem.INV_DATE;
                    case 45: // DUE_DATE
                        return CurrentItem.DUE_DATE;
                    case 46: // RTYPE
                        return CurrentItem.RTYPE;
                    case 47: // DRAWER
                        return CurrentItem.DRAWER;
                    case 48: // BSB
                        return CurrentItem.BSB;
                    case 49: // BANK
                        return CurrentItem.BANK;
                    case 50: // BRANCH
                        return CurrentItem.BRANCH;
                    case 51: // ACCOUNT_NUMBER
                        return CurrentItem.ACCOUNT_NUMBER;
                    case 52: // EXPECTED_DATE
                        return CurrentItem.EXPECTED_DATE;
                    case 53: // DEL_CODE
                        return CurrentItem.DEL_CODE;
                    case 54: // DEL_DOCKET_NO
                        return CurrentItem.DEL_DOCKET_NO;
                    case 55: // ATKEY
                        return CurrentItem.ATKEY;
                    case 56: // TINCLUDE
                        return CurrentItem.TINCLUDE;
                    case 57: // TTRNETT
                        return CurrentItem.TTRNETT;
                    case 58: // TTRAMT
                        return CurrentItem.TTRAMT;
                    case 59: // TGST_AMOUNT
                        return CurrentItem.TGST_AMOUNT;
                    case 60: // AMEMO
                        return CurrentItem.AMEMO;
                    case 61: // AMEMO_COPY
                        return CurrentItem.AMEMO_COPY;
                    case 62: // NEXT_SVC_DATE
                        return CurrentItem.NEXT_SVC_DATE;
                    case 63: // MASTERTID
                        return CurrentItem.MASTERTID;
                    case 64: // ALLOCTID
                        return CurrentItem.ALLOCTID;
                    case 65: // PAY_METHOD
                        return CurrentItem.PAY_METHOD;
                    case 66: // WITHHOLD_RATE
                        return CurrentItem.WITHHOLD_RATE;
                    case 67: // TRDEL_MONTHS
                        return CurrentItem.TRDEL_MONTHS;
                    case 68: // LINE_NO
                        return CurrentItem.LINE_NO;
                    case 69: // FLAG
                        return CurrentItem.FLAG;
                    case 70: // INVOICEGST
                        return CurrentItem.INVOICEGST;
                    case 71: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 72: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 73: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 74: // CANCELLED
                        return CurrentItem.CANCELLED;
                    case 75: // PRMS_TID
                        return CurrentItem.PRMS_TID;
                    case 76: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 77: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 78: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // OTID
                        return CurrentItem.OTID == null;
                    case 3: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 4: // TRPERD
                        return CurrentItem.TRPERD == null;
                    case 5: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 6: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 7: // TRREF
                        return CurrentItem.TRREF == null;
                    case 8: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 9: // TRXCODE
                        return CurrentItem.TRXCODE == null;
                    case 10: // TRXTRTYPE
                        return CurrentItem.TRXTRTYPE == null;
                    case 11: // TRCOST
                        return CurrentItem.TRCOST == null;
                    case 12: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 13: // TRQTYD
                        return CurrentItem.TRQTYD == null;
                    case 14: // TRQTYI
                        return CurrentItem.TRQTYI == null;
                    case 15: // TRQTYDX
                        return CurrentItem.TRQTYDX == null;
                    case 16: // TRQTYIX
                        return CurrentItem.TRQTYIX == null;
                    case 17: // AUTODELIVER
                        return CurrentItem.AUTODELIVER == null;
                    case 18: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 19: // DEBIT
                        return CurrentItem.DEBIT == null;
                    case 20: // CREDIT
                        return CurrentItem.CREDIT == null;
                    case 21: // TRPAID
                        return CurrentItem.TRPAID == null;
                    case 22: // TRINV
                        return CurrentItem.TRINV == null;
                    case 23: // TRDELETE
                        return CurrentItem.TRDELETE == null;
                    case 24: // TRDET
                        return CurrentItem.TRDET == null;
                    case 25: // TRHOLD
                        return CurrentItem.TRHOLD == null;
                    case 26: // TRORDER
                        return CurrentItem.TRORDER == null;
                    case 27: // TRBANK
                        return CurrentItem.TRBANK == null;
                    case 28: // CHQ_NO
                        return CurrentItem.CHQ_NO == null;
                    case 29: // ORDER_BY
                        return CurrentItem.ORDER_BY == null;
                    case 30: // COMPLETED
                        return CurrentItem.COMPLETED == null;
                    case 31: // TRUNIT
                        return CurrentItem.TRUNIT == null;
                    case 32: // REQ_DATE
                        return CurrentItem.REQ_DATE == null;
                    case 33: // CATALOGUE
                        return CurrentItem.CATALOGUE == null;
                    case 34: // DELIVERY
                        return CurrentItem.DELIVERY == null;
                    case 35: // PRINT_CHEQUE
                        return CurrentItem.PRINT_CHEQUE == null;
                    case 36: // TAX
                        return CurrentItem.TAX == null;
                    case 37: // TRNETT
                        return CurrentItem.TRNETT == null;
                    case 38: // TRGROSS
                        return CurrentItem.TRGROSS == null;
                    case 39: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT == null;
                    case 40: // GST_TYPE
                        return CurrentItem.GST_TYPE == null;
                    case 41: // GST_RATE
                        return CurrentItem.GST_RATE == null;
                    case 42: // GST_RECLAIM
                        return CurrentItem.GST_RECLAIM == null;
                    case 43: // WITHHOLD_AMOUNT
                        return CurrentItem.WITHHOLD_AMOUNT == null;
                    case 44: // INV_DATE
                        return CurrentItem.INV_DATE == null;
                    case 45: // DUE_DATE
                        return CurrentItem.DUE_DATE == null;
                    case 46: // RTYPE
                        return CurrentItem.RTYPE == null;
                    case 47: // DRAWER
                        return CurrentItem.DRAWER == null;
                    case 48: // BSB
                        return CurrentItem.BSB == null;
                    case 49: // BANK
                        return CurrentItem.BANK == null;
                    case 50: // BRANCH
                        return CurrentItem.BRANCH == null;
                    case 51: // ACCOUNT_NUMBER
                        return CurrentItem.ACCOUNT_NUMBER == null;
                    case 52: // EXPECTED_DATE
                        return CurrentItem.EXPECTED_DATE == null;
                    case 53: // DEL_CODE
                        return CurrentItem.DEL_CODE == null;
                    case 54: // DEL_DOCKET_NO
                        return CurrentItem.DEL_DOCKET_NO == null;
                    case 55: // ATKEY
                        return CurrentItem.ATKEY == null;
                    case 56: // TINCLUDE
                        return CurrentItem.TINCLUDE == null;
                    case 57: // TTRNETT
                        return CurrentItem.TTRNETT == null;
                    case 58: // TTRAMT
                        return CurrentItem.TTRAMT == null;
                    case 59: // TGST_AMOUNT
                        return CurrentItem.TGST_AMOUNT == null;
                    case 60: // AMEMO
                        return CurrentItem.AMEMO == null;
                    case 61: // AMEMO_COPY
                        return CurrentItem.AMEMO_COPY == null;
                    case 62: // NEXT_SVC_DATE
                        return CurrentItem.NEXT_SVC_DATE == null;
                    case 63: // MASTERTID
                        return CurrentItem.MASTERTID == null;
                    case 64: // ALLOCTID
                        return CurrentItem.ALLOCTID == null;
                    case 65: // PAY_METHOD
                        return CurrentItem.PAY_METHOD == null;
                    case 66: // WITHHOLD_RATE
                        return CurrentItem.WITHHOLD_RATE == null;
                    case 67: // TRDEL_MONTHS
                        return CurrentItem.TRDEL_MONTHS == null;
                    case 68: // LINE_NO
                        return CurrentItem.LINE_NO == null;
                    case 69: // FLAG
                        return CurrentItem.FLAG == null;
                    case 70: // INVOICEGST
                        return CurrentItem.INVOICEGST == null;
                    case 71: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 72: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 73: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 74: // CANCELLED
                        return CurrentItem.CANCELLED == null;
                    case 75: // PRMS_TID
                        return CurrentItem.PRMS_TID == null;
                    case 76: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 77: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 78: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // OTID
                        return "OTID";
                    case 2: // CODE
                        return "CODE";
                    case 3: // TRBATCH
                        return "TRBATCH";
                    case 4: // TRPERD
                        return "TRPERD";
                    case 5: // TRTYPE
                        return "TRTYPE";
                    case 6: // TRDATE
                        return "TRDATE";
                    case 7: // TRREF
                        return "TRREF";
                    case 8: // TRXLEDGER
                        return "TRXLEDGER";
                    case 9: // TRXCODE
                        return "TRXCODE";
                    case 10: // TRXTRTYPE
                        return "TRXTRTYPE";
                    case 11: // TRCOST
                        return "TRCOST";
                    case 12: // TRQTY
                        return "TRQTY";
                    case 13: // TRQTYD
                        return "TRQTYD";
                    case 14: // TRQTYI
                        return "TRQTYI";
                    case 15: // TRQTYDX
                        return "TRQTYDX";
                    case 16: // TRQTYIX
                        return "TRQTYIX";
                    case 17: // AUTODELIVER
                        return "AUTODELIVER";
                    case 18: // TRAMT
                        return "TRAMT";
                    case 19: // DEBIT
                        return "DEBIT";
                    case 20: // CREDIT
                        return "CREDIT";
                    case 21: // TRPAID
                        return "TRPAID";
                    case 22: // TRINV
                        return "TRINV";
                    case 23: // TRDELETE
                        return "TRDELETE";
                    case 24: // TRDET
                        return "TRDET";
                    case 25: // TRHOLD
                        return "TRHOLD";
                    case 26: // TRORDER
                        return "TRORDER";
                    case 27: // TRBANK
                        return "TRBANK";
                    case 28: // CHQ_NO
                        return "CHQ_NO";
                    case 29: // ORDER_BY
                        return "ORDER_BY";
                    case 30: // COMPLETED
                        return "COMPLETED";
                    case 31: // TRUNIT
                        return "TRUNIT";
                    case 32: // REQ_DATE
                        return "REQ_DATE";
                    case 33: // CATALOGUE
                        return "CATALOGUE";
                    case 34: // DELIVERY
                        return "DELIVERY";
                    case 35: // PRINT_CHEQUE
                        return "PRINT_CHEQUE";
                    case 36: // TAX
                        return "TAX";
                    case 37: // TRNETT
                        return "TRNETT";
                    case 38: // TRGROSS
                        return "TRGROSS";
                    case 39: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 40: // GST_TYPE
                        return "GST_TYPE";
                    case 41: // GST_RATE
                        return "GST_RATE";
                    case 42: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 43: // WITHHOLD_AMOUNT
                        return "WITHHOLD_AMOUNT";
                    case 44: // INV_DATE
                        return "INV_DATE";
                    case 45: // DUE_DATE
                        return "DUE_DATE";
                    case 46: // RTYPE
                        return "RTYPE";
                    case 47: // DRAWER
                        return "DRAWER";
                    case 48: // BSB
                        return "BSB";
                    case 49: // BANK
                        return "BANK";
                    case 50: // BRANCH
                        return "BRANCH";
                    case 51: // ACCOUNT_NUMBER
                        return "ACCOUNT_NUMBER";
                    case 52: // EXPECTED_DATE
                        return "EXPECTED_DATE";
                    case 53: // DEL_CODE
                        return "DEL_CODE";
                    case 54: // DEL_DOCKET_NO
                        return "DEL_DOCKET_NO";
                    case 55: // ATKEY
                        return "ATKEY";
                    case 56: // TINCLUDE
                        return "TINCLUDE";
                    case 57: // TTRNETT
                        return "TTRNETT";
                    case 58: // TTRAMT
                        return "TTRAMT";
                    case 59: // TGST_AMOUNT
                        return "TGST_AMOUNT";
                    case 60: // AMEMO
                        return "AMEMO";
                    case 61: // AMEMO_COPY
                        return "AMEMO_COPY";
                    case 62: // NEXT_SVC_DATE
                        return "NEXT_SVC_DATE";
                    case 63: // MASTERTID
                        return "MASTERTID";
                    case 64: // ALLOCTID
                        return "ALLOCTID";
                    case 65: // PAY_METHOD
                        return "PAY_METHOD";
                    case 66: // WITHHOLD_RATE
                        return "WITHHOLD_RATE";
                    case 67: // TRDEL_MONTHS
                        return "TRDEL_MONTHS";
                    case 68: // LINE_NO
                        return "LINE_NO";
                    case 69: // FLAG
                        return "FLAG";
                    case 70: // INVOICEGST
                        return "INVOICEGST";
                    case 71: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 72: // GLPROGRAM
                        return "GLPROGRAM";
                    case 73: // INITIATIVE
                        return "INITIATIVE";
                    case 74: // CANCELLED
                        return "CANCELLED";
                    case 75: // PRMS_TID
                        return "PRMS_TID";
                    case 76: // LW_DATE
                        return "LW_DATE";
                    case 77: // LW_TIME
                        return "LW_TIME";
                    case 78: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "OTID":
                        return 1;
                    case "CODE":
                        return 2;
                    case "TRBATCH":
                        return 3;
                    case "TRPERD":
                        return 4;
                    case "TRTYPE":
                        return 5;
                    case "TRDATE":
                        return 6;
                    case "TRREF":
                        return 7;
                    case "TRXLEDGER":
                        return 8;
                    case "TRXCODE":
                        return 9;
                    case "TRXTRTYPE":
                        return 10;
                    case "TRCOST":
                        return 11;
                    case "TRQTY":
                        return 12;
                    case "TRQTYD":
                        return 13;
                    case "TRQTYI":
                        return 14;
                    case "TRQTYDX":
                        return 15;
                    case "TRQTYIX":
                        return 16;
                    case "AUTODELIVER":
                        return 17;
                    case "TRAMT":
                        return 18;
                    case "DEBIT":
                        return 19;
                    case "CREDIT":
                        return 20;
                    case "TRPAID":
                        return 21;
                    case "TRINV":
                        return 22;
                    case "TRDELETE":
                        return 23;
                    case "TRDET":
                        return 24;
                    case "TRHOLD":
                        return 25;
                    case "TRORDER":
                        return 26;
                    case "TRBANK":
                        return 27;
                    case "CHQ_NO":
                        return 28;
                    case "ORDER_BY":
                        return 29;
                    case "COMPLETED":
                        return 30;
                    case "TRUNIT":
                        return 31;
                    case "REQ_DATE":
                        return 32;
                    case "CATALOGUE":
                        return 33;
                    case "DELIVERY":
                        return 34;
                    case "PRINT_CHEQUE":
                        return 35;
                    case "TAX":
                        return 36;
                    case "TRNETT":
                        return 37;
                    case "TRGROSS":
                        return 38;
                    case "GST_AMOUNT":
                        return 39;
                    case "GST_TYPE":
                        return 40;
                    case "GST_RATE":
                        return 41;
                    case "GST_RECLAIM":
                        return 42;
                    case "WITHHOLD_AMOUNT":
                        return 43;
                    case "INV_DATE":
                        return 44;
                    case "DUE_DATE":
                        return 45;
                    case "RTYPE":
                        return 46;
                    case "DRAWER":
                        return 47;
                    case "BSB":
                        return 48;
                    case "BANK":
                        return 49;
                    case "BRANCH":
                        return 50;
                    case "ACCOUNT_NUMBER":
                        return 51;
                    case "EXPECTED_DATE":
                        return 52;
                    case "DEL_CODE":
                        return 53;
                    case "DEL_DOCKET_NO":
                        return 54;
                    case "ATKEY":
                        return 55;
                    case "TINCLUDE":
                        return 56;
                    case "TTRNETT":
                        return 57;
                    case "TTRAMT":
                        return 58;
                    case "TGST_AMOUNT":
                        return 59;
                    case "AMEMO":
                        return 60;
                    case "AMEMO_COPY":
                        return 61;
                    case "NEXT_SVC_DATE":
                        return 62;
                    case "MASTERTID":
                        return 63;
                    case "ALLOCTID":
                        return 64;
                    case "PAY_METHOD":
                        return 65;
                    case "WITHHOLD_RATE":
                        return 66;
                    case "TRDEL_MONTHS":
                        return 67;
                    case "LINE_NO":
                        return 68;
                    case "FLAG":
                        return 69;
                    case "INVOICEGST":
                        return 70;
                    case "SUBPROGRAM":
                        return 71;
                    case "GLPROGRAM":
                        return 72;
                    case "INITIATIVE":
                        return 73;
                    case "CANCELLED":
                        return 74;
                    case "PRMS_TID":
                        return 75;
                    case "LW_DATE":
                        return 76;
                    case "LW_TIME":
                        return 77;
                    case "LW_USER":
                        return 78;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
