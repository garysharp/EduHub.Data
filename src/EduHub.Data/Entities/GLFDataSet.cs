using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFDataSet : SetBase<GLF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLF"; } }

        internal GLFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() => this.ToGroupedDictionary(i => i.CODE));
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
        protected override Action<GLF, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        /// <summary>
        /// Merges <see cref="GLF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLF" /> items to added or update the base <see cref="GLF" /> items</param>
        /// <returns>A merged list of <see cref="GLF" /> items</returns>
        protected override List<GLF> ApplyDeltaItems(List<GLF> Items, List<GLF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLF deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<GLF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> Index_CODE;
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

    }
}
