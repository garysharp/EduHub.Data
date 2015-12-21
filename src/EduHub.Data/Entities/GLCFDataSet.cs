using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GL Combined Financial Trans Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLCFDataSet : EduHubDataSet<GLCF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLCF"; } }

        internal GLCFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_GST_BOX = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.GST_BOX));
            Index_GST_SALE_PURCH = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.GST_SALE_PURCH));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, GLCF>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<GLCF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLCF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLCF" /> fields for each CSV column header</returns>
        protected override Action<GLCF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLCF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "TRSTUD":
                        mapper[i] = (e, v) => e.TRSTUD = v;
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
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "POST_OPTION":
                        mapper[i] = (e, v) => e.POST_OPTION = v;
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
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "EVENT":
                        mapper[i] = (e, v) => e.EVENT = v;
                        break;
                    case "FRTYPE":
                        mapper[i] = (e, v) => e.FRTYPE = v;
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
        /// Merges <see cref="GLCF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLCF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLCF" /> items to added or update the base <see cref="GLCF" /> items</param>
        /// <returns>A merged list of <see cref="GLCF" /> items</returns>
        protected override List<GLCF> ApplyDeltaItems(List<GLCF> Items, List<GLCF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLCF deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<GLCF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_GST_BOX;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_GST_SALE_PURCH;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, GLCF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCF>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLCF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find GLCF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<GLCF> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByBSB(string BSB)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLCF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLCF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by GST_BOX field
        /// </summary>
        /// <param name="GST_BOX">GST_BOX value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByGST_BOX(string GST_BOX)
        {
            return Index_GST_BOX.Value[GST_BOX];
        }

        /// <summary>
        /// Attempt to find GLCF by GST_BOX field
        /// </summary>
        /// <param name="GST_BOX">GST_BOX value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_BOX(string GST_BOX, out IReadOnlyList<GLCF> Value)
        {
            return Index_GST_BOX.Value.TryGetValue(GST_BOX, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by GST_BOX field
        /// </summary>
        /// <param name="GST_BOX">GST_BOX value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByGST_BOX(string GST_BOX)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by GST_SALE_PURCH field
        /// </summary>
        /// <param name="GST_SALE_PURCH">GST_SALE_PURCH value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByGST_SALE_PURCH(string GST_SALE_PURCH)
        {
            return Index_GST_SALE_PURCH.Value[GST_SALE_PURCH];
        }

        /// <summary>
        /// Attempt to find GLCF by GST_SALE_PURCH field
        /// </summary>
        /// <param name="GST_SALE_PURCH">GST_SALE_PURCH value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_SALE_PURCH(string GST_SALE_PURCH, out IReadOnlyList<GLCF> Value)
        {
            return Index_GST_SALE_PURCH.Value.TryGetValue(GST_SALE_PURCH, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by GST_SALE_PURCH field
        /// </summary>
        /// <param name="GST_SALE_PURCH">GST_SALE_PURCH value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByGST_SALE_PURCH(string GST_SALE_PURCH)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find GLCF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<GLCF> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find GLCF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLCF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find GLCF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLCF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLCF> value;
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
        /// Find GLCF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLCF</param>
        /// <returns>Related GLCF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLCF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLCF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLCF</param>
        /// <param name="Value">Related GLCF entity</param>
        /// <returns>True if the related GLCF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLCF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLCF</param>
        /// <returns>Related GLCF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLCF TryFindByTID(int TID)
        {
            GLCF value;
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
        /// Find GLCF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLCF</param>
        /// <returns>List of related GLCF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find GLCF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLCF</param>
        /// <param name="Value">List of related GLCF entities</param>
        /// <returns>True if the list of related GLCF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<GLCF> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find GLCF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLCF</param>
        /// <returns>List of related GLCF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCF> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<GLCF> value;
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
        /// Returns SQL which checks for the existence of a GLCF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLCF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLCF](
        [TID] int NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [FAMILY] varchar(10) NULL,
        [TRSTUD] varchar(10) NULL,
        [TRBATCH] int NULL,
        [TRPERD] int NULL,
        [TRTYPE] varchar(1) NULL,
        [TRQTY] int NULL,
        [TRCOST] money NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRAMT] money NULL,
        [TRDET] varchar(30) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [POST_OPTION] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [TRXTRTYPE] varchar(1) NULL,
        [TRSHORT] varchar(10) NULL,
        [TRBANK] varchar(10) NULL,
        [RECONCILE] varchar(1) NULL,
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
        [APPEAL] varchar(10) NULL,
        [EVENT] varchar(4) NULL,
        [FRTYPE] varchar(1) NULL,
        [TINCLUDE] varchar(1) NULL,
        [TTRNETT] money NULL,
        [TTRAMT] money NULL,
        [TGST_AMOUNT] money NULL,
        [AMEMO] text NULL,
        [AMEMO_COPY] varchar(1) NULL,
        [NEXT_SVC_DATE] datetime NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [DEBIT_TOTAL] money NULL,
        [CREDIT_TOTAL] money NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLCF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_BSB] ON [dbo].[GLCF]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [GLCF_Index_CODE] ON [dbo].[GLCF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_GST_BOX] ON [dbo].[GLCF]
    (
            [GST_BOX] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_GST_SALE_PURCH] ON [dbo].[GLCF]
    (
            [GST_SALE_PURCH] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_GST_TYPE] ON [dbo].[GLCF]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_INITIATIVE] ON [dbo].[GLCF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_SUBPROGRAM] ON [dbo].[GLCF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCF_Index_TRREF] ON [dbo].[GLCF]
    (
            [TRREF] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLCF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLCF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new GLCFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLCFDataReader : IDataReader, IDataRecord
        {
            private List<GLCF> Items;
            private int CurrentIndex;
            private GLCF CurrentItem;

            public GLCFDataReader(List<GLCF> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 66; } }
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
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // FAMILY
                        return CurrentItem.FAMILY;
                    case 3: // TRSTUD
                        return CurrentItem.TRSTUD;
                    case 4: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 5: // TRPERD
                        return CurrentItem.TRPERD;
                    case 6: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 7: // TRQTY
                        return CurrentItem.TRQTY;
                    case 8: // TRCOST
                        return CurrentItem.TRCOST;
                    case 9: // TRDATE
                        return CurrentItem.TRDATE;
                    case 10: // TRREF
                        return CurrentItem.TRREF;
                    case 11: // TRAMT
                        return CurrentItem.TRAMT;
                    case 12: // TRDET
                        return CurrentItem.TRDET;
                    case 13: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 14: // POST_OPTION
                        return CurrentItem.POST_OPTION;
                    case 15: // TRXCODE
                        return CurrentItem.TRXCODE;
                    case 16: // TRXTRTYPE
                        return CurrentItem.TRXTRTYPE;
                    case 17: // TRSHORT
                        return CurrentItem.TRSHORT;
                    case 18: // TRBANK
                        return CurrentItem.TRBANK;
                    case 19: // RECONCILE
                        return CurrentItem.RECONCILE;
                    case 20: // PRINT_CHEQUE
                        return CurrentItem.PRINT_CHEQUE;
                    case 21: // CHEQUE_NO
                        return CurrentItem.CHEQUE_NO;
                    case 22: // PAYEE
                        return CurrentItem.PAYEE;
                    case 23: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 24: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 25: // CHQ_TID
                        return CurrentItem.CHQ_TID;
                    case 26: // GST_BOX
                        return CurrentItem.GST_BOX;
                    case 27: // GST_PERD
                        return CurrentItem.GST_PERD;
                    case 28: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT;
                    case 29: // TRNETT
                        return CurrentItem.TRNETT;
                    case 30: // TRGROSS
                        return CurrentItem.TRGROSS;
                    case 31: // GST_RATE
                        return CurrentItem.GST_RATE;
                    case 32: // GST_TYPE
                        return CurrentItem.GST_TYPE;
                    case 33: // GST_RECLAIM
                        return CurrentItem.GST_RECLAIM;
                    case 34: // GST_SALE_PURCH
                        return CurrentItem.GST_SALE_PURCH;
                    case 35: // SOURCE_TID
                        return CurrentItem.SOURCE_TID;
                    case 36: // WITHHOLD_AMOUNT
                        return CurrentItem.WITHHOLD_AMOUNT;
                    case 37: // WITHHOLD_TYPE
                        return CurrentItem.WITHHOLD_TYPE;
                    case 38: // WITHHOLD_RATE
                        return CurrentItem.WITHHOLD_RATE;
                    case 39: // EOY_KEPT
                        return CurrentItem.EOY_KEPT;
                    case 40: // DRAWER
                        return CurrentItem.DRAWER;
                    case 41: // BSB
                        return CurrentItem.BSB;
                    case 42: // BANK
                        return CurrentItem.BANK;
                    case 43: // BRANCH
                        return CurrentItem.BRANCH;
                    case 44: // ACCOUNT_NUMBER
                        return CurrentItem.ACCOUNT_NUMBER;
                    case 45: // RTYPE
                        return CurrentItem.RTYPE;
                    case 46: // APPEAL
                        return CurrentItem.APPEAL;
                    case 47: // EVENT
                        return CurrentItem.EVENT;
                    case 48: // FRTYPE
                        return CurrentItem.FRTYPE;
                    case 49: // TINCLUDE
                        return CurrentItem.TINCLUDE;
                    case 50: // TTRNETT
                        return CurrentItem.TTRNETT;
                    case 51: // TTRAMT
                        return CurrentItem.TTRAMT;
                    case 52: // TGST_AMOUNT
                        return CurrentItem.TGST_AMOUNT;
                    case 53: // AMEMO
                        return CurrentItem.AMEMO;
                    case 54: // AMEMO_COPY
                        return CurrentItem.AMEMO_COPY;
                    case 55: // NEXT_SVC_DATE
                        return CurrentItem.NEXT_SVC_DATE;
                    case 56: // LINE_NO
                        return CurrentItem.LINE_NO;
                    case 57: // FLAG
                        return CurrentItem.FLAG;
                    case 58: // DEBIT_TOTAL
                        return CurrentItem.DEBIT_TOTAL;
                    case 59: // CREDIT_TOTAL
                        return CurrentItem.CREDIT_TOTAL;
                    case 60: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 61: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 62: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 63: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 64: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 65: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FAMILY
                        return CurrentItem.FAMILY == null;
                    case 3: // TRSTUD
                        return CurrentItem.TRSTUD == null;
                    case 4: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 5: // TRPERD
                        return CurrentItem.TRPERD == null;
                    case 6: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 7: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 8: // TRCOST
                        return CurrentItem.TRCOST == null;
                    case 9: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 10: // TRREF
                        return CurrentItem.TRREF == null;
                    case 11: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 12: // TRDET
                        return CurrentItem.TRDET == null;
                    case 13: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 14: // POST_OPTION
                        return CurrentItem.POST_OPTION == null;
                    case 15: // TRXCODE
                        return CurrentItem.TRXCODE == null;
                    case 16: // TRXTRTYPE
                        return CurrentItem.TRXTRTYPE == null;
                    case 17: // TRSHORT
                        return CurrentItem.TRSHORT == null;
                    case 18: // TRBANK
                        return CurrentItem.TRBANK == null;
                    case 19: // RECONCILE
                        return CurrentItem.RECONCILE == null;
                    case 20: // PRINT_CHEQUE
                        return CurrentItem.PRINT_CHEQUE == null;
                    case 21: // CHEQUE_NO
                        return CurrentItem.CHEQUE_NO == null;
                    case 22: // PAYEE
                        return CurrentItem.PAYEE == null;
                    case 23: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 24: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 25: // CHQ_TID
                        return CurrentItem.CHQ_TID == null;
                    case 26: // GST_BOX
                        return CurrentItem.GST_BOX == null;
                    case 27: // GST_PERD
                        return CurrentItem.GST_PERD == null;
                    case 28: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT == null;
                    case 29: // TRNETT
                        return CurrentItem.TRNETT == null;
                    case 30: // TRGROSS
                        return CurrentItem.TRGROSS == null;
                    case 31: // GST_RATE
                        return CurrentItem.GST_RATE == null;
                    case 32: // GST_TYPE
                        return CurrentItem.GST_TYPE == null;
                    case 33: // GST_RECLAIM
                        return CurrentItem.GST_RECLAIM == null;
                    case 34: // GST_SALE_PURCH
                        return CurrentItem.GST_SALE_PURCH == null;
                    case 35: // SOURCE_TID
                        return CurrentItem.SOURCE_TID == null;
                    case 36: // WITHHOLD_AMOUNT
                        return CurrentItem.WITHHOLD_AMOUNT == null;
                    case 37: // WITHHOLD_TYPE
                        return CurrentItem.WITHHOLD_TYPE == null;
                    case 38: // WITHHOLD_RATE
                        return CurrentItem.WITHHOLD_RATE == null;
                    case 39: // EOY_KEPT
                        return CurrentItem.EOY_KEPT == null;
                    case 40: // DRAWER
                        return CurrentItem.DRAWER == null;
                    case 41: // BSB
                        return CurrentItem.BSB == null;
                    case 42: // BANK
                        return CurrentItem.BANK == null;
                    case 43: // BRANCH
                        return CurrentItem.BRANCH == null;
                    case 44: // ACCOUNT_NUMBER
                        return CurrentItem.ACCOUNT_NUMBER == null;
                    case 45: // RTYPE
                        return CurrentItem.RTYPE == null;
                    case 46: // APPEAL
                        return CurrentItem.APPEAL == null;
                    case 47: // EVENT
                        return CurrentItem.EVENT == null;
                    case 48: // FRTYPE
                        return CurrentItem.FRTYPE == null;
                    case 49: // TINCLUDE
                        return CurrentItem.TINCLUDE == null;
                    case 50: // TTRNETT
                        return CurrentItem.TTRNETT == null;
                    case 51: // TTRAMT
                        return CurrentItem.TTRAMT == null;
                    case 52: // TGST_AMOUNT
                        return CurrentItem.TGST_AMOUNT == null;
                    case 53: // AMEMO
                        return CurrentItem.AMEMO == null;
                    case 54: // AMEMO_COPY
                        return CurrentItem.AMEMO_COPY == null;
                    case 55: // NEXT_SVC_DATE
                        return CurrentItem.NEXT_SVC_DATE == null;
                    case 56: // LINE_NO
                        return CurrentItem.LINE_NO == null;
                    case 57: // FLAG
                        return CurrentItem.FLAG == null;
                    case 58: // DEBIT_TOTAL
                        return CurrentItem.DEBIT_TOTAL == null;
                    case 59: // CREDIT_TOTAL
                        return CurrentItem.CREDIT_TOTAL == null;
                    case 60: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 61: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 62: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 63: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 64: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 65: // LW_USER
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // FAMILY
                        return "FAMILY";
                    case 3: // TRSTUD
                        return "TRSTUD";
                    case 4: // TRBATCH
                        return "TRBATCH";
                    case 5: // TRPERD
                        return "TRPERD";
                    case 6: // TRTYPE
                        return "TRTYPE";
                    case 7: // TRQTY
                        return "TRQTY";
                    case 8: // TRCOST
                        return "TRCOST";
                    case 9: // TRDATE
                        return "TRDATE";
                    case 10: // TRREF
                        return "TRREF";
                    case 11: // TRAMT
                        return "TRAMT";
                    case 12: // TRDET
                        return "TRDET";
                    case 13: // TRXLEDGER
                        return "TRXLEDGER";
                    case 14: // POST_OPTION
                        return "POST_OPTION";
                    case 15: // TRXCODE
                        return "TRXCODE";
                    case 16: // TRXTRTYPE
                        return "TRXTRTYPE";
                    case 17: // TRSHORT
                        return "TRSHORT";
                    case 18: // TRBANK
                        return "TRBANK";
                    case 19: // RECONCILE
                        return "RECONCILE";
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
                    case 46: // APPEAL
                        return "APPEAL";
                    case 47: // EVENT
                        return "EVENT";
                    case 48: // FRTYPE
                        return "FRTYPE";
                    case 49: // TINCLUDE
                        return "TINCLUDE";
                    case 50: // TTRNETT
                        return "TTRNETT";
                    case 51: // TTRAMT
                        return "TTRAMT";
                    case 52: // TGST_AMOUNT
                        return "TGST_AMOUNT";
                    case 53: // AMEMO
                        return "AMEMO";
                    case 54: // AMEMO_COPY
                        return "AMEMO_COPY";
                    case 55: // NEXT_SVC_DATE
                        return "NEXT_SVC_DATE";
                    case 56: // LINE_NO
                        return "LINE_NO";
                    case 57: // FLAG
                        return "FLAG";
                    case 58: // DEBIT_TOTAL
                        return "DEBIT_TOTAL";
                    case 59: // CREDIT_TOTAL
                        return "CREDIT_TOTAL";
                    case 60: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 61: // GLPROGRAM
                        return "GLPROGRAM";
                    case 62: // INITIATIVE
                        return "INITIATIVE";
                    case 63: // LW_DATE
                        return "LW_DATE";
                    case 64: // LW_TIME
                        return "LW_TIME";
                    case 65: // LW_USER
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
                    case "CODE":
                        return 1;
                    case "FAMILY":
                        return 2;
                    case "TRSTUD":
                        return 3;
                    case "TRBATCH":
                        return 4;
                    case "TRPERD":
                        return 5;
                    case "TRTYPE":
                        return 6;
                    case "TRQTY":
                        return 7;
                    case "TRCOST":
                        return 8;
                    case "TRDATE":
                        return 9;
                    case "TRREF":
                        return 10;
                    case "TRAMT":
                        return 11;
                    case "TRDET":
                        return 12;
                    case "TRXLEDGER":
                        return 13;
                    case "POST_OPTION":
                        return 14;
                    case "TRXCODE":
                        return 15;
                    case "TRXTRTYPE":
                        return 16;
                    case "TRSHORT":
                        return 17;
                    case "TRBANK":
                        return 18;
                    case "RECONCILE":
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
                    case "APPEAL":
                        return 46;
                    case "EVENT":
                        return 47;
                    case "FRTYPE":
                        return 48;
                    case "TINCLUDE":
                        return 49;
                    case "TTRNETT":
                        return 50;
                    case "TTRAMT":
                        return 51;
                    case "TGST_AMOUNT":
                        return 52;
                    case "AMEMO":
                        return 53;
                    case "AMEMO_COPY":
                        return 54;
                    case "NEXT_SVC_DATE":
                        return 55;
                    case "LINE_NO":
                        return 56;
                    case "FLAG":
                        return 57;
                    case "DEBIT_TOTAL":
                        return 58;
                    case "CREDIT_TOTAL":
                        return 59;
                    case "SUBPROGRAM":
                        return 60;
                    case "GLPROGRAM":
                        return 61;
                    case "INITIATIVE":
                        return 62;
                    case "LW_DATE":
                        return 63;
                    case "LW_TIME":
                        return 64;
                    case "LW_USER":
                        return 65;
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
