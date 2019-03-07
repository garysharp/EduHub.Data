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
    /// General Ledger Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFDataSet : EduHubDataSet<GLF>
    {
        /// <inheritdoc />
        public override string Name { get { return "GLF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal GLFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_GLPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.GLPROGRAM));
            Index_GST_BOX = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.GST_BOX));
            Index_GST_SALE_PURCH = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.GST_SALE_PURCH));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, GLF>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLF" /> fields for each CSV column header</returns>
        internal override Action<GLF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.RECONCILE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "RECONCILE_USER":
                        mapper[i] = (e, v) => e.RECONCILE_USER = v;
                        break;
                    case "RECONCILE_STATEMENT":
                        mapper[i] = (e, v) => e.RECONCILE_STATEMENT = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
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
        /// Merges <see cref="GLF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="GLF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="GLF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{GLF}"/> of entities</returns>
        internal override IEnumerable<GLF> ApplyDeltaEntities(IEnumerable<GLF> Entities, List<GLF> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_FEE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_GLPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_GST_BOX;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_GST_SALE_PURCH;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, GLF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find GLF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<GLF> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByBSB(string BSB)
        {
            IReadOnlyList<GLF> value;
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
        /// Find GLF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLF> value;
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
        /// Find GLF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find GLF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<GLF> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<GLF> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLF by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByGLPROGRAM(string GLPROGRAM)
        {
            return Index_GLPROGRAM.Value[GLPROGRAM];
        }

        /// <summary>
        /// Attempt to find GLF by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM(string GLPROGRAM, out IReadOnlyList<GLF> Value)
        {
            return Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByGLPROGRAM(string GLPROGRAM)
        {
            IReadOnlyList<GLF> value;
            if (Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLF by GST_BOX field
        /// </summary>
        /// <param name="GST_BOX">GST_BOX value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByGST_BOX(string GST_BOX)
        {
            return Index_GST_BOX.Value[GST_BOX];
        }

        /// <summary>
        /// Attempt to find GLF by GST_BOX field
        /// </summary>
        /// <param name="GST_BOX">GST_BOX value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_BOX(string GST_BOX, out IReadOnlyList<GLF> Value)
        {
            return Index_GST_BOX.Value.TryGetValue(GST_BOX, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by GST_BOX field
        /// </summary>
        /// <param name="GST_BOX">GST_BOX value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByGST_BOX(string GST_BOX)
        {
            IReadOnlyList<GLF> value;
            if (Index_GST_BOX.Value.TryGetValue(GST_BOX, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLF by GST_SALE_PURCH field
        /// </summary>
        /// <param name="GST_SALE_PURCH">GST_SALE_PURCH value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByGST_SALE_PURCH(string GST_SALE_PURCH)
        {
            return Index_GST_SALE_PURCH.Value[GST_SALE_PURCH];
        }

        /// <summary>
        /// Attempt to find GLF by GST_SALE_PURCH field
        /// </summary>
        /// <param name="GST_SALE_PURCH">GST_SALE_PURCH value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_SALE_PURCH(string GST_SALE_PURCH, out IReadOnlyList<GLF> Value)
        {
            return Index_GST_SALE_PURCH.Value.TryGetValue(GST_SALE_PURCH, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by GST_SALE_PURCH field
        /// </summary>
        /// <param name="GST_SALE_PURCH">GST_SALE_PURCH value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByGST_SALE_PURCH(string GST_SALE_PURCH)
        {
            IReadOnlyList<GLF> value;
            if (Index_GST_SALE_PURCH.Value.TryGetValue(GST_SALE_PURCH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find GLF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<GLF> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<GLF> value;
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
        /// Find GLF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find GLF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLF> value;
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
        /// Find GLF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find GLF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLF> value;
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
        /// Find GLF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLF</param>
        /// <returns>Related GLF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLF</param>
        /// <param name="Value">Related GLF entity</param>
        /// <returns>True if the related GLF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLF</param>
        /// <returns>Related GLF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLF TryFindByTID(int TID)
        {
            GLF value;
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
        /// Find GLF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLF</param>
        /// <returns>List of related GLF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find GLF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLF</param>
        /// <param name="Value">List of related GLF entities</param>
        /// <returns>True if the list of related GLF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<GLF> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find GLF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLF</param>
        /// <returns>List of related GLF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLF> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<GLF> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a GLF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLF](
        [TID] int NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRBATCH] int NULL,
        [TRPERD] int NULL,
        [TRTYPE] varchar(1) NULL,
        [TRQTY] int NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRAMT] money NULL,
        [TRDET] varchar(30) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [TRXTRTYPE] varchar(1) NULL,
        [TRSHORT] varchar(10) NULL,
        [TRBANK] varchar(10) NULL,
        [RECONCILE] varchar(1) NULL,
        [RECONCILE_FLAGGED] varchar(1) NULL,
        [RECONCILE_DATE] datetime NULL,
        [RECONCILE_USER] varchar(128) NULL,
        [RECONCILE_STATEMENT] datetime NULL,
        [PRINT_CHEQUE] varchar(1) NULL,
        [CHEQUE_NO] varchar(10) NULL,
        [PAYEE] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [CHQ_TID] int NULL,
        [GST_BOX] varchar(3) NULL,
        [GST_PERD] int NULL,
        [GST_AMOUNT] money NULL,
        [TRNETT] money NULL,
        [TRGROSS] money NULL,
        [GST_RATE] float NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RECLAIM] varchar(1) NULL,
        [GST_SALE_PURCH] varchar(2) NULL,
        [SOURCE_TID] int NULL,
        [WITHHOLD_AMOUNT] money NULL,
        [WITHHOLD_TYPE] varchar(4) NULL,
        [WITHHOLD_RATE] float NULL,
        [EOY_KEPT] varchar(1) NULL,
        [DRAWER] varchar(20) NULL,
        [BSB] varchar(6) NULL,
        [BANK] varchar(20) NULL,
        [BRANCH] varchar(20) NULL,
        [ACCOUNT_NUMBER] int NULL,
        [RTYPE] varchar(2) NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [DEBIT_TOTAL] money NULL,
        [CREDIT_TOTAL] money NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [DEBIT] money NULL,
        [CREDIT] money NULL,
        [CANCELLED] varchar(3) NULL,
        [FEE_CODE] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_BSB] ON [dbo].[GLF]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [GLF_Index_CODE] ON [dbo].[GLF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_FEE_CODE] ON [dbo].[GLF]
    (
            [FEE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_GLPROGRAM] ON [dbo].[GLF]
    (
            [GLPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_GST_BOX] ON [dbo].[GLF]
    (
            [GST_BOX] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_GST_SALE_PURCH] ON [dbo].[GLF]
    (
            [GST_SALE_PURCH] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_GST_TYPE] ON [dbo].[GLF]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_INITIATIVE] ON [dbo].[GLF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_SUBPROGRAM] ON [dbo].[GLF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [GLF_Index_TRREF] ON [dbo].[GLF]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_FEE_CODE')
    ALTER INDEX [Index_FEE_CODE] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GLPROGRAM')
    ALTER INDEX [Index_GLPROGRAM] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GST_BOX')
    ALTER INDEX [Index_GST_BOX] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GST_SALE_PURCH')
    ALTER INDEX [Index_GST_SALE_PURCH] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[GLF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[GLF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_FEE_CODE')
    ALTER INDEX [Index_FEE_CODE] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GLPROGRAM')
    ALTER INDEX [Index_GLPROGRAM] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GST_BOX')
    ALTER INDEX [Index_GST_BOX] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GST_SALE_PURCH')
    ALTER INDEX [Index_GST_SALE_PURCH] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[GLF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLF]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[GLF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="GLF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="GLF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<GLF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[GLF] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the GLF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLF data set</returns>
        public override EduHubDataSetDataReader<GLF> GetDataSetDataReader()
        {
            return new GLFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLF data set</returns>
        public override EduHubDataSetDataReader<GLF> GetDataSetDataReader(List<GLF> Entities)
        {
            return new GLFDataReader(new EduHubDataSetLoadedReader<GLF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLFDataReader : EduHubDataSetDataReader<GLF>
        {
            public GLFDataReader(IEduHubDataSetReader<GLF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 60; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRBATCH
                        return Current.TRBATCH;
                    case 3: // TRPERD
                        return Current.TRPERD;
                    case 4: // TRTYPE
                        return Current.TRTYPE;
                    case 5: // TRQTY
                        return Current.TRQTY;
                    case 6: // TRDATE
                        return Current.TRDATE;
                    case 7: // TRREF
                        return Current.TRREF;
                    case 8: // TRAMT
                        return Current.TRAMT;
                    case 9: // TRDET
                        return Current.TRDET;
                    case 10: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 11: // TRXCODE
                        return Current.TRXCODE;
                    case 12: // TRXTRTYPE
                        return Current.TRXTRTYPE;
                    case 13: // TRSHORT
                        return Current.TRSHORT;
                    case 14: // TRBANK
                        return Current.TRBANK;
                    case 15: // RECONCILE
                        return Current.RECONCILE;
                    case 16: // RECONCILE_FLAGGED
                        return Current.RECONCILE_FLAGGED;
                    case 17: // RECONCILE_DATE
                        return Current.RECONCILE_DATE;
                    case 18: // RECONCILE_USER
                        return Current.RECONCILE_USER;
                    case 19: // RECONCILE_STATEMENT
                        return Current.RECONCILE_STATEMENT;
                    case 20: // PRINT_CHEQUE
                        return Current.PRINT_CHEQUE;
                    case 21: // CHEQUE_NO
                        return Current.CHEQUE_NO;
                    case 22: // PAYEE
                        return Current.PAYEE;
                    case 23: // ADDRESS01
                        return Current.ADDRESS01;
                    case 24: // ADDRESS02
                        return Current.ADDRESS02;
                    case 25: // CHQ_TID
                        return Current.CHQ_TID;
                    case 26: // GST_BOX
                        return Current.GST_BOX;
                    case 27: // GST_PERD
                        return Current.GST_PERD;
                    case 28: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 29: // TRNETT
                        return Current.TRNETT;
                    case 30: // TRGROSS
                        return Current.TRGROSS;
                    case 31: // GST_RATE
                        return Current.GST_RATE;
                    case 32: // GST_TYPE
                        return Current.GST_TYPE;
                    case 33: // GST_RECLAIM
                        return Current.GST_RECLAIM;
                    case 34: // GST_SALE_PURCH
                        return Current.GST_SALE_PURCH;
                    case 35: // SOURCE_TID
                        return Current.SOURCE_TID;
                    case 36: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT;
                    case 37: // WITHHOLD_TYPE
                        return Current.WITHHOLD_TYPE;
                    case 38: // WITHHOLD_RATE
                        return Current.WITHHOLD_RATE;
                    case 39: // EOY_KEPT
                        return Current.EOY_KEPT;
                    case 40: // DRAWER
                        return Current.DRAWER;
                    case 41: // BSB
                        return Current.BSB;
                    case 42: // BANK
                        return Current.BANK;
                    case 43: // BRANCH
                        return Current.BRANCH;
                    case 44: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER;
                    case 45: // RTYPE
                        return Current.RTYPE;
                    case 46: // LINE_NO
                        return Current.LINE_NO;
                    case 47: // FLAG
                        return Current.FLAG;
                    case 48: // DEBIT_TOTAL
                        return Current.DEBIT_TOTAL;
                    case 49: // CREDIT_TOTAL
                        return Current.CREDIT_TOTAL;
                    case 50: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 51: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 52: // INITIATIVE
                        return Current.INITIATIVE;
                    case 53: // DEBIT
                        return Current.DEBIT;
                    case 54: // CREDIT
                        return Current.CREDIT;
                    case 55: // CANCELLED
                        return Current.CANCELLED;
                    case 56: // FEE_CODE
                        return Current.FEE_CODE;
                    case 57: // LW_DATE
                        return Current.LW_DATE;
                    case 58: // LW_TIME
                        return Current.LW_TIME;
                    case 59: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRBATCH
                        return Current.TRBATCH == null;
                    case 3: // TRPERD
                        return Current.TRPERD == null;
                    case 4: // TRTYPE
                        return Current.TRTYPE == null;
                    case 5: // TRQTY
                        return Current.TRQTY == null;
                    case 6: // TRDATE
                        return Current.TRDATE == null;
                    case 7: // TRREF
                        return Current.TRREF == null;
                    case 8: // TRAMT
                        return Current.TRAMT == null;
                    case 9: // TRDET
                        return Current.TRDET == null;
                    case 10: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 11: // TRXCODE
                        return Current.TRXCODE == null;
                    case 12: // TRXTRTYPE
                        return Current.TRXTRTYPE == null;
                    case 13: // TRSHORT
                        return Current.TRSHORT == null;
                    case 14: // TRBANK
                        return Current.TRBANK == null;
                    case 15: // RECONCILE
                        return Current.RECONCILE == null;
                    case 16: // RECONCILE_FLAGGED
                        return Current.RECONCILE_FLAGGED == null;
                    case 17: // RECONCILE_DATE
                        return Current.RECONCILE_DATE == null;
                    case 18: // RECONCILE_USER
                        return Current.RECONCILE_USER == null;
                    case 19: // RECONCILE_STATEMENT
                        return Current.RECONCILE_STATEMENT == null;
                    case 20: // PRINT_CHEQUE
                        return Current.PRINT_CHEQUE == null;
                    case 21: // CHEQUE_NO
                        return Current.CHEQUE_NO == null;
                    case 22: // PAYEE
                        return Current.PAYEE == null;
                    case 23: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 24: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 25: // CHQ_TID
                        return Current.CHQ_TID == null;
                    case 26: // GST_BOX
                        return Current.GST_BOX == null;
                    case 27: // GST_PERD
                        return Current.GST_PERD == null;
                    case 28: // GST_AMOUNT
                        return Current.GST_AMOUNT == null;
                    case 29: // TRNETT
                        return Current.TRNETT == null;
                    case 30: // TRGROSS
                        return Current.TRGROSS == null;
                    case 31: // GST_RATE
                        return Current.GST_RATE == null;
                    case 32: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 33: // GST_RECLAIM
                        return Current.GST_RECLAIM == null;
                    case 34: // GST_SALE_PURCH
                        return Current.GST_SALE_PURCH == null;
                    case 35: // SOURCE_TID
                        return Current.SOURCE_TID == null;
                    case 36: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT == null;
                    case 37: // WITHHOLD_TYPE
                        return Current.WITHHOLD_TYPE == null;
                    case 38: // WITHHOLD_RATE
                        return Current.WITHHOLD_RATE == null;
                    case 39: // EOY_KEPT
                        return Current.EOY_KEPT == null;
                    case 40: // DRAWER
                        return Current.DRAWER == null;
                    case 41: // BSB
                        return Current.BSB == null;
                    case 42: // BANK
                        return Current.BANK == null;
                    case 43: // BRANCH
                        return Current.BRANCH == null;
                    case 44: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER == null;
                    case 45: // RTYPE
                        return Current.RTYPE == null;
                    case 46: // LINE_NO
                        return Current.LINE_NO == null;
                    case 47: // FLAG
                        return Current.FLAG == null;
                    case 48: // DEBIT_TOTAL
                        return Current.DEBIT_TOTAL == null;
                    case 49: // CREDIT_TOTAL
                        return Current.CREDIT_TOTAL == null;
                    case 50: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 51: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 52: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 53: // DEBIT
                        return Current.DEBIT == null;
                    case 54: // CREDIT
                        return Current.CREDIT == null;
                    case 55: // CANCELLED
                        return Current.CANCELLED == null;
                    case 56: // FEE_CODE
                        return Current.FEE_CODE == null;
                    case 57: // LW_DATE
                        return Current.LW_DATE == null;
                    case 58: // LW_TIME
                        return Current.LW_TIME == null;
                    case 59: // LW_USER
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRBATCH
                        return "TRBATCH";
                    case 3: // TRPERD
                        return "TRPERD";
                    case 4: // TRTYPE
                        return "TRTYPE";
                    case 5: // TRQTY
                        return "TRQTY";
                    case 6: // TRDATE
                        return "TRDATE";
                    case 7: // TRREF
                        return "TRREF";
                    case 8: // TRAMT
                        return "TRAMT";
                    case 9: // TRDET
                        return "TRDET";
                    case 10: // TRXLEDGER
                        return "TRXLEDGER";
                    case 11: // TRXCODE
                        return "TRXCODE";
                    case 12: // TRXTRTYPE
                        return "TRXTRTYPE";
                    case 13: // TRSHORT
                        return "TRSHORT";
                    case 14: // TRBANK
                        return "TRBANK";
                    case 15: // RECONCILE
                        return "RECONCILE";
                    case 16: // RECONCILE_FLAGGED
                        return "RECONCILE_FLAGGED";
                    case 17: // RECONCILE_DATE
                        return "RECONCILE_DATE";
                    case 18: // RECONCILE_USER
                        return "RECONCILE_USER";
                    case 19: // RECONCILE_STATEMENT
                        return "RECONCILE_STATEMENT";
                    case 20: // PRINT_CHEQUE
                        return "PRINT_CHEQUE";
                    case 21: // CHEQUE_NO
                        return "CHEQUE_NO";
                    case 22: // PAYEE
                        return "PAYEE";
                    case 23: // ADDRESS01
                        return "ADDRESS01";
                    case 24: // ADDRESS02
                        return "ADDRESS02";
                    case 25: // CHQ_TID
                        return "CHQ_TID";
                    case 26: // GST_BOX
                        return "GST_BOX";
                    case 27: // GST_PERD
                        return "GST_PERD";
                    case 28: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 29: // TRNETT
                        return "TRNETT";
                    case 30: // TRGROSS
                        return "TRGROSS";
                    case 31: // GST_RATE
                        return "GST_RATE";
                    case 32: // GST_TYPE
                        return "GST_TYPE";
                    case 33: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 34: // GST_SALE_PURCH
                        return "GST_SALE_PURCH";
                    case 35: // SOURCE_TID
                        return "SOURCE_TID";
                    case 36: // WITHHOLD_AMOUNT
                        return "WITHHOLD_AMOUNT";
                    case 37: // WITHHOLD_TYPE
                        return "WITHHOLD_TYPE";
                    case 38: // WITHHOLD_RATE
                        return "WITHHOLD_RATE";
                    case 39: // EOY_KEPT
                        return "EOY_KEPT";
                    case 40: // DRAWER
                        return "DRAWER";
                    case 41: // BSB
                        return "BSB";
                    case 42: // BANK
                        return "BANK";
                    case 43: // BRANCH
                        return "BRANCH";
                    case 44: // ACCOUNT_NUMBER
                        return "ACCOUNT_NUMBER";
                    case 45: // RTYPE
                        return "RTYPE";
                    case 46: // LINE_NO
                        return "LINE_NO";
                    case 47: // FLAG
                        return "FLAG";
                    case 48: // DEBIT_TOTAL
                        return "DEBIT_TOTAL";
                    case 49: // CREDIT_TOTAL
                        return "CREDIT_TOTAL";
                    case 50: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 51: // GLPROGRAM
                        return "GLPROGRAM";
                    case 52: // INITIATIVE
                        return "INITIATIVE";
                    case 53: // DEBIT
                        return "DEBIT";
                    case 54: // CREDIT
                        return "CREDIT";
                    case 55: // CANCELLED
                        return "CANCELLED";
                    case 56: // FEE_CODE
                        return "FEE_CODE";
                    case 57: // LW_DATE
                        return "LW_DATE";
                    case 58: // LW_TIME
                        return "LW_TIME";
                    case 59: // LW_USER
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
                    case "CODE":
                        return 1;
                    case "TRBATCH":
                        return 2;
                    case "TRPERD":
                        return 3;
                    case "TRTYPE":
                        return 4;
                    case "TRQTY":
                        return 5;
                    case "TRDATE":
                        return 6;
                    case "TRREF":
                        return 7;
                    case "TRAMT":
                        return 8;
                    case "TRDET":
                        return 9;
                    case "TRXLEDGER":
                        return 10;
                    case "TRXCODE":
                        return 11;
                    case "TRXTRTYPE":
                        return 12;
                    case "TRSHORT":
                        return 13;
                    case "TRBANK":
                        return 14;
                    case "RECONCILE":
                        return 15;
                    case "RECONCILE_FLAGGED":
                        return 16;
                    case "RECONCILE_DATE":
                        return 17;
                    case "RECONCILE_USER":
                        return 18;
                    case "RECONCILE_STATEMENT":
                        return 19;
                    case "PRINT_CHEQUE":
                        return 20;
                    case "CHEQUE_NO":
                        return 21;
                    case "PAYEE":
                        return 22;
                    case "ADDRESS01":
                        return 23;
                    case "ADDRESS02":
                        return 24;
                    case "CHQ_TID":
                        return 25;
                    case "GST_BOX":
                        return 26;
                    case "GST_PERD":
                        return 27;
                    case "GST_AMOUNT":
                        return 28;
                    case "TRNETT":
                        return 29;
                    case "TRGROSS":
                        return 30;
                    case "GST_RATE":
                        return 31;
                    case "GST_TYPE":
                        return 32;
                    case "GST_RECLAIM":
                        return 33;
                    case "GST_SALE_PURCH":
                        return 34;
                    case "SOURCE_TID":
                        return 35;
                    case "WITHHOLD_AMOUNT":
                        return 36;
                    case "WITHHOLD_TYPE":
                        return 37;
                    case "WITHHOLD_RATE":
                        return 38;
                    case "EOY_KEPT":
                        return 39;
                    case "DRAWER":
                        return 40;
                    case "BSB":
                        return 41;
                    case "BANK":
                        return 42;
                    case "BRANCH":
                        return 43;
                    case "ACCOUNT_NUMBER":
                        return 44;
                    case "RTYPE":
                        return 45;
                    case "LINE_NO":
                        return 46;
                    case "FLAG":
                        return 47;
                    case "DEBIT_TOTAL":
                        return 48;
                    case "CREDIT_TOTAL":
                        return 49;
                    case "SUBPROGRAM":
                        return 50;
                    case "GLPROGRAM":
                        return 51;
                    case "INITIATIVE":
                        return 52;
                    case "DEBIT":
                        return 53;
                    case "CREDIT":
                        return 54;
                    case "CANCELLED":
                        return 55;
                    case "FEE_CODE":
                        return 56;
                    case "LW_DATE":
                        return 57;
                    case "LW_TIME":
                        return 58;
                    case "LW_USER":
                        return 59;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
