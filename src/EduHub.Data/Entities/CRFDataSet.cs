using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Financial Transaction Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRFDataSet : EduHubDataSet<CRF>
    {
        /// <inheritdoc />
        public override string Name { get { return "CRF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal CRFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_APPROVED_BY = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.APPROVED_BY));
            Index_ATKEY = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.ATKEY));
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_DEL_CODE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.DEL_CODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_INVOICEGST = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.INVOICEGST));
            Index_STAFF_ORDER_BY = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.STAFF_ORDER_BY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, CRF>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<CRF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRF" /> fields for each CSV column header</returns>
        internal override Action<CRF, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "PO_PRINTED":
                        mapper[i] = (e, v) => e.PO_PRINTED = v;
                        break;
                    case "APPROVED_BY":
                        mapper[i] = (e, v) => e.APPROVED_BY = v;
                        break;
                    case "STAFF_ORDER_BY":
                        mapper[i] = (e, v) => e.STAFF_ORDER_BY = v;
                        break;
                    case "CRPRTID":
                        mapper[i] = (e, v) => e.CRPRTID = v == null ? (int?)null : int.Parse(v);
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
                        mapper[i] = (e, v) => e.REQ_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.INV_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DUE_DATE":
                        mapper[i] = (e, v) => e.DUE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.EXPECTED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "KCPC_TID":
                        mapper[i] = (e, v) => e.KCPC_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// <param name="Entities">Iterator for base <see cref="CRF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="CRF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{CRF}"/> of entities</returns>
        internal override IEnumerable<CRF> ApplyDeltaEntities(IEnumerable<CRF> Entities, List<CRF> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_APPROVED_BY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_ATKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_DEL_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_INVOICEGST;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_STAFF_ORDER_BY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, CRF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRF>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CRF by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindByAPPROVED_BY(string APPROVED_BY)
        {
            return Index_APPROVED_BY.Value[APPROVED_BY];
        }

        /// <summary>
        /// Attempt to find CRF by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAPPROVED_BY(string APPROVED_BY, out IReadOnlyList<CRF> Value)
        {
            return Index_APPROVED_BY.Value.TryGetValue(APPROVED_BY, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindByAPPROVED_BY(string APPROVED_BY)
        {
            IReadOnlyList<CRF> value;
            if (Index_APPROVED_BY.Value.TryGetValue(APPROVED_BY, out value))
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
        /// Find CRF by STAFF_ORDER_BY field
        /// </summary>
        /// <param name="STAFF_ORDER_BY">STAFF_ORDER_BY value used to find CRF</param>
        /// <returns>List of related CRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> FindBySTAFF_ORDER_BY(string STAFF_ORDER_BY)
        {
            return Index_STAFF_ORDER_BY.Value[STAFF_ORDER_BY];
        }

        /// <summary>
        /// Attempt to find CRF by STAFF_ORDER_BY field
        /// </summary>
        /// <param name="STAFF_ORDER_BY">STAFF_ORDER_BY value used to find CRF</param>
        /// <param name="Value">List of related CRF entities</param>
        /// <returns>True if the list of related CRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF_ORDER_BY(string STAFF_ORDER_BY, out IReadOnlyList<CRF> Value)
        {
            return Index_STAFF_ORDER_BY.Value.TryGetValue(STAFF_ORDER_BY, out Value);
        }

        /// <summary>
        /// Attempt to find CRF by STAFF_ORDER_BY field
        /// </summary>
        /// <param name="STAFF_ORDER_BY">STAFF_ORDER_BY value used to find CRF</param>
        /// <returns>List of related CRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRF> TryFindBySTAFF_ORDER_BY(string STAFF_ORDER_BY)
        {
            IReadOnlyList<CRF> value;
            if (Index_STAFF_ORDER_BY.Value.TryGetValue(STAFF_ORDER_BY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a CRF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
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
        [PO_PRINTED] varchar(1) NULL,
        [APPROVED_BY] varchar(4) NULL,
        [STAFF_ORDER_BY] varchar(4) NULL,
        [CRPRTID] int NULL,
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
        [AMEMO] varchar(MAX) NULL,
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
        [KCPC_TID] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CRF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_APPROVED_BY] ON [dbo].[CRF]
    (
            [APPROVED_BY] ASC
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
    CREATE NONCLUSTERED INDEX [CRF_Index_STAFF_ORDER_BY] ON [dbo].[CRF]
    (
            [STAFF_ORDER_BY] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_SUBPROGRAM] ON [dbo].[CRF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [CRF_Index_TRREF] ON [dbo].[CRF]
    (
            [TRREF] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_APPROVED_BY')
    ALTER INDEX [Index_APPROVED_BY] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_ATKEY')
    ALTER INDEX [Index_ATKEY] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_DEL_CODE')
    ALTER INDEX [Index_DEL_CODE] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_INVOICEGST')
    ALTER INDEX [Index_INVOICEGST] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_STAFF_ORDER_BY')
    ALTER INDEX [Index_STAFF_ORDER_BY] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[CRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[CRF] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_APPROVED_BY')
    ALTER INDEX [Index_APPROVED_BY] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_ATKEY')
    ALTER INDEX [Index_ATKEY] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_DEL_CODE')
    ALTER INDEX [Index_DEL_CODE] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_INVOICEGST')
    ALTER INDEX [Index_INVOICEGST] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_STAFF_ORDER_BY')
    ALTER INDEX [Index_STAFF_ORDER_BY] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[CRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRF]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[CRF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="CRF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="CRF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<CRF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[CRF] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRF data set</returns>
        public override EduHubDataSetDataReader<CRF> GetDataSetDataReader()
        {
            return new CRFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRF data set</returns>
        public override EduHubDataSetDataReader<CRF> GetDataSetDataReader(List<CRF> Entities)
        {
            return new CRFDataReader(new EduHubDataSetLoadedReader<CRF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRFDataReader : EduHubDataSetDataReader<CRF>
        {
            public CRFDataReader(IEduHubDataSetReader<CRF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 84; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // OTID
                        return Current.OTID;
                    case 2: // CODE
                        return Current.CODE;
                    case 3: // TRBATCH
                        return Current.TRBATCH;
                    case 4: // TRPERD
                        return Current.TRPERD;
                    case 5: // TRTYPE
                        return Current.TRTYPE;
                    case 6: // TRDATE
                        return Current.TRDATE;
                    case 7: // TRREF
                        return Current.TRREF;
                    case 8: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 9: // TRXCODE
                        return Current.TRXCODE;
                    case 10: // TRXTRTYPE
                        return Current.TRXTRTYPE;
                    case 11: // TRCOST
                        return Current.TRCOST;
                    case 12: // TRQTY
                        return Current.TRQTY;
                    case 13: // TRQTYD
                        return Current.TRQTYD;
                    case 14: // TRQTYI
                        return Current.TRQTYI;
                    case 15: // TRQTYDX
                        return Current.TRQTYDX;
                    case 16: // TRQTYIX
                        return Current.TRQTYIX;
                    case 17: // AUTODELIVER
                        return Current.AUTODELIVER;
                    case 18: // TRAMT
                        return Current.TRAMT;
                    case 19: // DEBIT
                        return Current.DEBIT;
                    case 20: // CREDIT
                        return Current.CREDIT;
                    case 21: // TRPAID
                        return Current.TRPAID;
                    case 22: // TRINV
                        return Current.TRINV;
                    case 23: // TRDELETE
                        return Current.TRDELETE;
                    case 24: // TRDET
                        return Current.TRDET;
                    case 25: // TRHOLD
                        return Current.TRHOLD;
                    case 26: // TRORDER
                        return Current.TRORDER;
                    case 27: // PO_PRINTED
                        return Current.PO_PRINTED;
                    case 28: // APPROVED_BY
                        return Current.APPROVED_BY;
                    case 29: // STAFF_ORDER_BY
                        return Current.STAFF_ORDER_BY;
                    case 30: // CRPRTID
                        return Current.CRPRTID;
                    case 31: // TRBANK
                        return Current.TRBANK;
                    case 32: // CHQ_NO
                        return Current.CHQ_NO;
                    case 33: // ORDER_BY
                        return Current.ORDER_BY;
                    case 34: // COMPLETED
                        return Current.COMPLETED;
                    case 35: // TRUNIT
                        return Current.TRUNIT;
                    case 36: // REQ_DATE
                        return Current.REQ_DATE;
                    case 37: // CATALOGUE
                        return Current.CATALOGUE;
                    case 38: // DELIVERY
                        return Current.DELIVERY;
                    case 39: // PRINT_CHEQUE
                        return Current.PRINT_CHEQUE;
                    case 40: // TAX
                        return Current.TAX;
                    case 41: // TRNETT
                        return Current.TRNETT;
                    case 42: // TRGROSS
                        return Current.TRGROSS;
                    case 43: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 44: // GST_TYPE
                        return Current.GST_TYPE;
                    case 45: // GST_RATE
                        return Current.GST_RATE;
                    case 46: // GST_RECLAIM
                        return Current.GST_RECLAIM;
                    case 47: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT;
                    case 48: // INV_DATE
                        return Current.INV_DATE;
                    case 49: // DUE_DATE
                        return Current.DUE_DATE;
                    case 50: // RTYPE
                        return Current.RTYPE;
                    case 51: // DRAWER
                        return Current.DRAWER;
                    case 52: // BSB
                        return Current.BSB;
                    case 53: // BANK
                        return Current.BANK;
                    case 54: // BRANCH
                        return Current.BRANCH;
                    case 55: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER;
                    case 56: // EXPECTED_DATE
                        return Current.EXPECTED_DATE;
                    case 57: // DEL_CODE
                        return Current.DEL_CODE;
                    case 58: // DEL_DOCKET_NO
                        return Current.DEL_DOCKET_NO;
                    case 59: // ATKEY
                        return Current.ATKEY;
                    case 60: // TINCLUDE
                        return Current.TINCLUDE;
                    case 61: // TTRNETT
                        return Current.TTRNETT;
                    case 62: // TTRAMT
                        return Current.TTRAMT;
                    case 63: // TGST_AMOUNT
                        return Current.TGST_AMOUNT;
                    case 64: // AMEMO
                        return Current.AMEMO;
                    case 65: // AMEMO_COPY
                        return Current.AMEMO_COPY;
                    case 66: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE;
                    case 67: // MASTERTID
                        return Current.MASTERTID;
                    case 68: // ALLOCTID
                        return Current.ALLOCTID;
                    case 69: // PAY_METHOD
                        return Current.PAY_METHOD;
                    case 70: // WITHHOLD_RATE
                        return Current.WITHHOLD_RATE;
                    case 71: // TRDEL_MONTHS
                        return Current.TRDEL_MONTHS;
                    case 72: // LINE_NO
                        return Current.LINE_NO;
                    case 73: // FLAG
                        return Current.FLAG;
                    case 74: // INVOICEGST
                        return Current.INVOICEGST;
                    case 75: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 76: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 77: // INITIATIVE
                        return Current.INITIATIVE;
                    case 78: // CANCELLED
                        return Current.CANCELLED;
                    case 79: // PRMS_TID
                        return Current.PRMS_TID;
                    case 80: // KCPC_TID
                        return Current.KCPC_TID;
                    case 81: // LW_DATE
                        return Current.LW_DATE;
                    case 82: // LW_TIME
                        return Current.LW_TIME;
                    case 83: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // OTID
                        return Current.OTID == null;
                    case 3: // TRBATCH
                        return Current.TRBATCH == null;
                    case 4: // TRPERD
                        return Current.TRPERD == null;
                    case 5: // TRTYPE
                        return Current.TRTYPE == null;
                    case 6: // TRDATE
                        return Current.TRDATE == null;
                    case 7: // TRREF
                        return Current.TRREF == null;
                    case 8: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 9: // TRXCODE
                        return Current.TRXCODE == null;
                    case 10: // TRXTRTYPE
                        return Current.TRXTRTYPE == null;
                    case 11: // TRCOST
                        return Current.TRCOST == null;
                    case 12: // TRQTY
                        return Current.TRQTY == null;
                    case 13: // TRQTYD
                        return Current.TRQTYD == null;
                    case 14: // TRQTYI
                        return Current.TRQTYI == null;
                    case 15: // TRQTYDX
                        return Current.TRQTYDX == null;
                    case 16: // TRQTYIX
                        return Current.TRQTYIX == null;
                    case 17: // AUTODELIVER
                        return Current.AUTODELIVER == null;
                    case 18: // TRAMT
                        return Current.TRAMT == null;
                    case 19: // DEBIT
                        return Current.DEBIT == null;
                    case 20: // CREDIT
                        return Current.CREDIT == null;
                    case 21: // TRPAID
                        return Current.TRPAID == null;
                    case 22: // TRINV
                        return Current.TRINV == null;
                    case 23: // TRDELETE
                        return Current.TRDELETE == null;
                    case 24: // TRDET
                        return Current.TRDET == null;
                    case 25: // TRHOLD
                        return Current.TRHOLD == null;
                    case 26: // TRORDER
                        return Current.TRORDER == null;
                    case 27: // PO_PRINTED
                        return Current.PO_PRINTED == null;
                    case 28: // APPROVED_BY
                        return Current.APPROVED_BY == null;
                    case 29: // STAFF_ORDER_BY
                        return Current.STAFF_ORDER_BY == null;
                    case 30: // CRPRTID
                        return Current.CRPRTID == null;
                    case 31: // TRBANK
                        return Current.TRBANK == null;
                    case 32: // CHQ_NO
                        return Current.CHQ_NO == null;
                    case 33: // ORDER_BY
                        return Current.ORDER_BY == null;
                    case 34: // COMPLETED
                        return Current.COMPLETED == null;
                    case 35: // TRUNIT
                        return Current.TRUNIT == null;
                    case 36: // REQ_DATE
                        return Current.REQ_DATE == null;
                    case 37: // CATALOGUE
                        return Current.CATALOGUE == null;
                    case 38: // DELIVERY
                        return Current.DELIVERY == null;
                    case 39: // PRINT_CHEQUE
                        return Current.PRINT_CHEQUE == null;
                    case 40: // TAX
                        return Current.TAX == null;
                    case 41: // TRNETT
                        return Current.TRNETT == null;
                    case 42: // TRGROSS
                        return Current.TRGROSS == null;
                    case 43: // GST_AMOUNT
                        return Current.GST_AMOUNT == null;
                    case 44: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 45: // GST_RATE
                        return Current.GST_RATE == null;
                    case 46: // GST_RECLAIM
                        return Current.GST_RECLAIM == null;
                    case 47: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT == null;
                    case 48: // INV_DATE
                        return Current.INV_DATE == null;
                    case 49: // DUE_DATE
                        return Current.DUE_DATE == null;
                    case 50: // RTYPE
                        return Current.RTYPE == null;
                    case 51: // DRAWER
                        return Current.DRAWER == null;
                    case 52: // BSB
                        return Current.BSB == null;
                    case 53: // BANK
                        return Current.BANK == null;
                    case 54: // BRANCH
                        return Current.BRANCH == null;
                    case 55: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER == null;
                    case 56: // EXPECTED_DATE
                        return Current.EXPECTED_DATE == null;
                    case 57: // DEL_CODE
                        return Current.DEL_CODE == null;
                    case 58: // DEL_DOCKET_NO
                        return Current.DEL_DOCKET_NO == null;
                    case 59: // ATKEY
                        return Current.ATKEY == null;
                    case 60: // TINCLUDE
                        return Current.TINCLUDE == null;
                    case 61: // TTRNETT
                        return Current.TTRNETT == null;
                    case 62: // TTRAMT
                        return Current.TTRAMT == null;
                    case 63: // TGST_AMOUNT
                        return Current.TGST_AMOUNT == null;
                    case 64: // AMEMO
                        return Current.AMEMO == null;
                    case 65: // AMEMO_COPY
                        return Current.AMEMO_COPY == null;
                    case 66: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE == null;
                    case 67: // MASTERTID
                        return Current.MASTERTID == null;
                    case 68: // ALLOCTID
                        return Current.ALLOCTID == null;
                    case 69: // PAY_METHOD
                        return Current.PAY_METHOD == null;
                    case 70: // WITHHOLD_RATE
                        return Current.WITHHOLD_RATE == null;
                    case 71: // TRDEL_MONTHS
                        return Current.TRDEL_MONTHS == null;
                    case 72: // LINE_NO
                        return Current.LINE_NO == null;
                    case 73: // FLAG
                        return Current.FLAG == null;
                    case 74: // INVOICEGST
                        return Current.INVOICEGST == null;
                    case 75: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 76: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 77: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 78: // CANCELLED
                        return Current.CANCELLED == null;
                    case 79: // PRMS_TID
                        return Current.PRMS_TID == null;
                    case 80: // KCPC_TID
                        return Current.KCPC_TID == null;
                    case 81: // LW_DATE
                        return Current.LW_DATE == null;
                    case 82: // LW_TIME
                        return Current.LW_TIME == null;
                    case 83: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
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
                    case 27: // PO_PRINTED
                        return "PO_PRINTED";
                    case 28: // APPROVED_BY
                        return "APPROVED_BY";
                    case 29: // STAFF_ORDER_BY
                        return "STAFF_ORDER_BY";
                    case 30: // CRPRTID
                        return "CRPRTID";
                    case 31: // TRBANK
                        return "TRBANK";
                    case 32: // CHQ_NO
                        return "CHQ_NO";
                    case 33: // ORDER_BY
                        return "ORDER_BY";
                    case 34: // COMPLETED
                        return "COMPLETED";
                    case 35: // TRUNIT
                        return "TRUNIT";
                    case 36: // REQ_DATE
                        return "REQ_DATE";
                    case 37: // CATALOGUE
                        return "CATALOGUE";
                    case 38: // DELIVERY
                        return "DELIVERY";
                    case 39: // PRINT_CHEQUE
                        return "PRINT_CHEQUE";
                    case 40: // TAX
                        return "TAX";
                    case 41: // TRNETT
                        return "TRNETT";
                    case 42: // TRGROSS
                        return "TRGROSS";
                    case 43: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 44: // GST_TYPE
                        return "GST_TYPE";
                    case 45: // GST_RATE
                        return "GST_RATE";
                    case 46: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 47: // WITHHOLD_AMOUNT
                        return "WITHHOLD_AMOUNT";
                    case 48: // INV_DATE
                        return "INV_DATE";
                    case 49: // DUE_DATE
                        return "DUE_DATE";
                    case 50: // RTYPE
                        return "RTYPE";
                    case 51: // DRAWER
                        return "DRAWER";
                    case 52: // BSB
                        return "BSB";
                    case 53: // BANK
                        return "BANK";
                    case 54: // BRANCH
                        return "BRANCH";
                    case 55: // ACCOUNT_NUMBER
                        return "ACCOUNT_NUMBER";
                    case 56: // EXPECTED_DATE
                        return "EXPECTED_DATE";
                    case 57: // DEL_CODE
                        return "DEL_CODE";
                    case 58: // DEL_DOCKET_NO
                        return "DEL_DOCKET_NO";
                    case 59: // ATKEY
                        return "ATKEY";
                    case 60: // TINCLUDE
                        return "TINCLUDE";
                    case 61: // TTRNETT
                        return "TTRNETT";
                    case 62: // TTRAMT
                        return "TTRAMT";
                    case 63: // TGST_AMOUNT
                        return "TGST_AMOUNT";
                    case 64: // AMEMO
                        return "AMEMO";
                    case 65: // AMEMO_COPY
                        return "AMEMO_COPY";
                    case 66: // NEXT_SVC_DATE
                        return "NEXT_SVC_DATE";
                    case 67: // MASTERTID
                        return "MASTERTID";
                    case 68: // ALLOCTID
                        return "ALLOCTID";
                    case 69: // PAY_METHOD
                        return "PAY_METHOD";
                    case 70: // WITHHOLD_RATE
                        return "WITHHOLD_RATE";
                    case 71: // TRDEL_MONTHS
                        return "TRDEL_MONTHS";
                    case 72: // LINE_NO
                        return "LINE_NO";
                    case 73: // FLAG
                        return "FLAG";
                    case 74: // INVOICEGST
                        return "INVOICEGST";
                    case 75: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 76: // GLPROGRAM
                        return "GLPROGRAM";
                    case 77: // INITIATIVE
                        return "INITIATIVE";
                    case 78: // CANCELLED
                        return "CANCELLED";
                    case 79: // PRMS_TID
                        return "PRMS_TID";
                    case 80: // KCPC_TID
                        return "KCPC_TID";
                    case 81: // LW_DATE
                        return "LW_DATE";
                    case 82: // LW_TIME
                        return "LW_TIME";
                    case 83: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
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
                    case "PO_PRINTED":
                        return 27;
                    case "APPROVED_BY":
                        return 28;
                    case "STAFF_ORDER_BY":
                        return 29;
                    case "CRPRTID":
                        return 30;
                    case "TRBANK":
                        return 31;
                    case "CHQ_NO":
                        return 32;
                    case "ORDER_BY":
                        return 33;
                    case "COMPLETED":
                        return 34;
                    case "TRUNIT":
                        return 35;
                    case "REQ_DATE":
                        return 36;
                    case "CATALOGUE":
                        return 37;
                    case "DELIVERY":
                        return 38;
                    case "PRINT_CHEQUE":
                        return 39;
                    case "TAX":
                        return 40;
                    case "TRNETT":
                        return 41;
                    case "TRGROSS":
                        return 42;
                    case "GST_AMOUNT":
                        return 43;
                    case "GST_TYPE":
                        return 44;
                    case "GST_RATE":
                        return 45;
                    case "GST_RECLAIM":
                        return 46;
                    case "WITHHOLD_AMOUNT":
                        return 47;
                    case "INV_DATE":
                        return 48;
                    case "DUE_DATE":
                        return 49;
                    case "RTYPE":
                        return 50;
                    case "DRAWER":
                        return 51;
                    case "BSB":
                        return 52;
                    case "BANK":
                        return 53;
                    case "BRANCH":
                        return 54;
                    case "ACCOUNT_NUMBER":
                        return 55;
                    case "EXPECTED_DATE":
                        return 56;
                    case "DEL_CODE":
                        return 57;
                    case "DEL_DOCKET_NO":
                        return 58;
                    case "ATKEY":
                        return 59;
                    case "TINCLUDE":
                        return 60;
                    case "TTRNETT":
                        return 61;
                    case "TTRAMT":
                        return 62;
                    case "TGST_AMOUNT":
                        return 63;
                    case "AMEMO":
                        return 64;
                    case "AMEMO_COPY":
                        return 65;
                    case "NEXT_SVC_DATE":
                        return 66;
                    case "MASTERTID":
                        return 67;
                    case "ALLOCTID":
                        return 68;
                    case "PAY_METHOD":
                        return 69;
                    case "WITHHOLD_RATE":
                        return 70;
                    case "TRDEL_MONTHS":
                        return 71;
                    case "LINE_NO":
                        return 72;
                    case "FLAG":
                        return 73;
                    case "INVOICEGST":
                        return 74;
                    case "SUBPROGRAM":
                        return 75;
                    case "GLPROGRAM":
                        return 76;
                    case "INITIATIVE":
                        return 77;
                    case "CANCELLED":
                        return 78;
                    case "PRMS_TID":
                        return 79;
                    case "KCPC_TID":
                        return 80;
                    case "LW_DATE":
                        return 81;
                    case "LW_TIME":
                        return 82;
                    case "LW_USER":
                        return 83;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
