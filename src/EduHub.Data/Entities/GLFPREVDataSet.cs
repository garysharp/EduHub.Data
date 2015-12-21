using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Last Years GL Financial Trans Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFPREVDataSet : EduHubDataSet<GLFPREV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLFPREV"; } }

        internal GLFPREVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_GLPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>>(() => this.ToGroupedNullDictionary(i => i.GLPROGRAM));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, GLFPREV>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFPREV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFPREV" /> fields for each CSV column header</returns>
        protected override Action<GLFPREV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFPREV, string>[Headers.Count];

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
        /// Merges <see cref="GLFPREV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLFPREV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLFPREV" /> items to added or update the base <see cref="GLFPREV" /> items</param>
        /// <returns>A merged list of <see cref="GLFPREV" /> items</returns>
        protected override List<GLFPREV> ApplyDeltaItems(List<GLFPREV> Items, List<GLFPREV> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLFPREV deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>> Index_GLPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, GLFPREV>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<GLFPREV>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLFPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFPREV</param>
        /// <param name="Value">List of related GLFPREV entities</param>
        /// <returns>True if the list of related GLFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLFPREV> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLFPREV> value;
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
        /// Find GLFPREV by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> FindByGLPROGRAM(string GLPROGRAM)
        {
            return Index_GLPROGRAM.Value[GLPROGRAM];
        }

        /// <summary>
        /// Attempt to find GLFPREV by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLFPREV</param>
        /// <param name="Value">List of related GLFPREV entities</param>
        /// <returns>True if the list of related GLFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM(string GLPROGRAM, out IReadOnlyList<GLFPREV> Value)
        {
            return Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> TryFindByGLPROGRAM(string GLPROGRAM)
        {
            IReadOnlyList<GLFPREV> value;
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
        /// Find GLFPREV by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find GLFPREV by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLFPREV</param>
        /// <param name="Value">List of related GLFPREV entities</param>
        /// <returns>True if the list of related GLFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<GLFPREV> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<GLFPREV> value;
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
        /// Find GLFPREV by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find GLFPREV by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLFPREV</param>
        /// <param name="Value">List of related GLFPREV entities</param>
        /// <returns>True if the list of related GLFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLFPREV> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLFPREV> value;
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
        /// Find GLFPREV by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find GLFPREV by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLFPREV</param>
        /// <param name="Value">List of related GLFPREV entities</param>
        /// <returns>True if the list of related GLFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLFPREV> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLFPREV> value;
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
        /// Find GLFPREV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFPREV</param>
        /// <returns>Related GLFPREV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFPREV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFPREV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFPREV</param>
        /// <param name="Value">Related GLFPREV entity</param>
        /// <returns>True if the related GLFPREV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFPREV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFPREV</param>
        /// <returns>Related GLFPREV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFPREV TryFindByTID(int TID)
        {
            GLFPREV value;
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
        /// Find GLFPREV by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find GLFPREV by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLFPREV</param>
        /// <param name="Value">List of related GLFPREV entities</param>
        /// <returns>True if the list of related GLFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<GLFPREV> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find GLFPREV by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLFPREV</param>
        /// <returns>List of related GLFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFPREV> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<GLFPREV> value;
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
        /// Returns SQL which checks for the existence of a GLFPREV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLFPREV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLFPREV](
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
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLFPREV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [GLFPREV_Index_CODE] ON [dbo].[GLFPREV]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFPREV_Index_GLPROGRAM] ON [dbo].[GLFPREV]
    (
            [GLPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFPREV_Index_GST_TYPE] ON [dbo].[GLFPREV]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFPREV_Index_INITIATIVE] ON [dbo].[GLFPREV]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFPREV_Index_SUBPROGRAM] ON [dbo].[GLFPREV]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFPREV_Index_TRREF] ON [dbo].[GLFPREV]
    (
            [TRREF] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLFPREV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFPREV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new GLFPREVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLFPREVDataReader : IDataReader, IDataRecord
        {
            private List<GLFPREV> Items;
            private int CurrentIndex;
            private GLFPREV CurrentItem;

            public GLFPREVDataReader(List<GLFPREV> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 59; } }
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
                    case 2: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 3: // TRPERD
                        return CurrentItem.TRPERD;
                    case 4: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 5: // TRQTY
                        return CurrentItem.TRQTY;
                    case 6: // TRDATE
                        return CurrentItem.TRDATE;
                    case 7: // TRREF
                        return CurrentItem.TRREF;
                    case 8: // TRAMT
                        return CurrentItem.TRAMT;
                    case 9: // TRDET
                        return CurrentItem.TRDET;
                    case 10: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 11: // TRXCODE
                        return CurrentItem.TRXCODE;
                    case 12: // TRXTRTYPE
                        return CurrentItem.TRXTRTYPE;
                    case 13: // TRSHORT
                        return CurrentItem.TRSHORT;
                    case 14: // TRBANK
                        return CurrentItem.TRBANK;
                    case 15: // RECONCILE
                        return CurrentItem.RECONCILE;
                    case 16: // RECONCILE_FLAGGED
                        return CurrentItem.RECONCILE_FLAGGED;
                    case 17: // RECONCILE_DATE
                        return CurrentItem.RECONCILE_DATE;
                    case 18: // RECONCILE_USER
                        return CurrentItem.RECONCILE_USER;
                    case 19: // RECONCILE_STATEMENT
                        return CurrentItem.RECONCILE_STATEMENT;
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
                    case 46: // LINE_NO
                        return CurrentItem.LINE_NO;
                    case 47: // FLAG
                        return CurrentItem.FLAG;
                    case 48: // DEBIT_TOTAL
                        return CurrentItem.DEBIT_TOTAL;
                    case 49: // CREDIT_TOTAL
                        return CurrentItem.CREDIT_TOTAL;
                    case 50: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 51: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 52: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 53: // DEBIT
                        return CurrentItem.DEBIT;
                    case 54: // CREDIT
                        return CurrentItem.CREDIT;
                    case 55: // CANCELLED
                        return CurrentItem.CANCELLED;
                    case 56: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 57: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 58: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 3: // TRPERD
                        return CurrentItem.TRPERD == null;
                    case 4: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 5: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 6: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 7: // TRREF
                        return CurrentItem.TRREF == null;
                    case 8: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 9: // TRDET
                        return CurrentItem.TRDET == null;
                    case 10: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 11: // TRXCODE
                        return CurrentItem.TRXCODE == null;
                    case 12: // TRXTRTYPE
                        return CurrentItem.TRXTRTYPE == null;
                    case 13: // TRSHORT
                        return CurrentItem.TRSHORT == null;
                    case 14: // TRBANK
                        return CurrentItem.TRBANK == null;
                    case 15: // RECONCILE
                        return CurrentItem.RECONCILE == null;
                    case 16: // RECONCILE_FLAGGED
                        return CurrentItem.RECONCILE_FLAGGED == null;
                    case 17: // RECONCILE_DATE
                        return CurrentItem.RECONCILE_DATE == null;
                    case 18: // RECONCILE_USER
                        return CurrentItem.RECONCILE_USER == null;
                    case 19: // RECONCILE_STATEMENT
                        return CurrentItem.RECONCILE_STATEMENT == null;
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
                    case 46: // LINE_NO
                        return CurrentItem.LINE_NO == null;
                    case 47: // FLAG
                        return CurrentItem.FLAG == null;
                    case 48: // DEBIT_TOTAL
                        return CurrentItem.DEBIT_TOTAL == null;
                    case 49: // CREDIT_TOTAL
                        return CurrentItem.CREDIT_TOTAL == null;
                    case 50: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 51: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 52: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 53: // DEBIT
                        return CurrentItem.DEBIT == null;
                    case 54: // CREDIT
                        return CurrentItem.CREDIT == null;
                    case 55: // CANCELLED
                        return CurrentItem.CANCELLED == null;
                    case 56: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 57: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 58: // LW_USER
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
                    case 56: // LW_DATE
                        return "LW_DATE";
                    case 57: // LW_TIME
                        return "LW_TIME";
                    case 58: // LW_USER
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
                    case "LW_DATE":
                        return 56;
                    case "LW_TIME":
                        return 57;
                    case "LW_USER":
                        return 58;
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
