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
    /// Last Years GL Combined Financial Trans Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLCFPREVDataSet : EduHubDataSet<GLCFPREV>
    {
        /// <inheritdoc />
        public override string Name { get { return "GLCFPREV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal GLCFPREVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, GLCFPREV>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLCFPREV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLCFPREV" /> fields for each CSV column header</returns>
        internal override Action<GLCFPREV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLCFPREV, string>[Headers.Count];

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
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="GLCFPREV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="GLCFPREV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="GLCFPREV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{GLCFPREV}"/> of entities</returns>
        internal override IEnumerable<GLCFPREV> ApplyDeltaEntities(IEnumerable<GLCFPREV> Entities, List<GLCFPREV> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, GLCFPREV>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<GLCFPREV>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLCFPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLCFPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCFPREV</param>
        /// <param name="Value">List of related GLCFPREV entities</param>
        /// <returns>True if the list of related GLCFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLCFPREV> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLCFPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLCFPREV> value;
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
        /// Find GLCFPREV by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find GLCFPREV by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLCFPREV</param>
        /// <param name="Value">List of related GLCFPREV entities</param>
        /// <returns>True if the list of related GLCFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<GLCFPREV> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find GLCFPREV by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<GLCFPREV> value;
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
        /// Find GLCFPREV by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find GLCFPREV by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCFPREV</param>
        /// <param name="Value">List of related GLCFPREV entities</param>
        /// <returns>True if the list of related GLCFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLCFPREV> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find GLCFPREV by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLCFPREV> value;
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
        /// Find GLCFPREV by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find GLCFPREV by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCFPREV</param>
        /// <param name="Value">List of related GLCFPREV entities</param>
        /// <returns>True if the list of related GLCFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLCFPREV> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find GLCFPREV by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLCFPREV> value;
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
        /// Find GLCFPREV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLCFPREV</param>
        /// <returns>Related GLCFPREV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLCFPREV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLCFPREV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLCFPREV</param>
        /// <param name="Value">Related GLCFPREV entity</param>
        /// <returns>True if the related GLCFPREV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLCFPREV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLCFPREV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLCFPREV</param>
        /// <returns>Related GLCFPREV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLCFPREV TryFindByTID(int TID)
        {
            GLCFPREV value;
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
        /// Find GLCFPREV by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find GLCFPREV by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLCFPREV</param>
        /// <param name="Value">List of related GLCFPREV entities</param>
        /// <returns>True if the list of related GLCFPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<GLCFPREV> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find GLCFPREV by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find GLCFPREV</param>
        /// <returns>List of related GLCFPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLCFPREV> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<GLCFPREV> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a GLCFPREV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLCFPREV](
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
        [AMEMO] varchar(MAX) NULL,
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
        CONSTRAINT [GLCFPREV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [GLCFPREV_Index_CODE] ON [dbo].[GLCFPREV]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCFPREV_Index_GST_TYPE] ON [dbo].[GLCFPREV]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCFPREV_Index_INITIATIVE] ON [dbo].[GLCFPREV]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCFPREV_Index_SUBPROGRAM] ON [dbo].[GLCFPREV]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [GLCFPREV_Index_TRREF] ON [dbo].[GLCFPREV]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_GST_TYPE')
    ALTER INDEX [GLCFPREV_Index_GST_TYPE] ON [dbo].[GLCFPREV] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_INITIATIVE')
    ALTER INDEX [GLCFPREV_Index_INITIATIVE] ON [dbo].[GLCFPREV] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_SUBPROGRAM')
    ALTER INDEX [GLCFPREV_Index_SUBPROGRAM] ON [dbo].[GLCFPREV] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_TID')
    ALTER INDEX [GLCFPREV_Index_TID] ON [dbo].[GLCFPREV] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_TRREF')
    ALTER INDEX [GLCFPREV_Index_TRREF] ON [dbo].[GLCFPREV] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_GST_TYPE')
    ALTER INDEX [GLCFPREV_Index_GST_TYPE] ON [dbo].[GLCFPREV] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_INITIATIVE')
    ALTER INDEX [GLCFPREV_Index_INITIATIVE] ON [dbo].[GLCFPREV] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_SUBPROGRAM')
    ALTER INDEX [GLCFPREV_Index_SUBPROGRAM] ON [dbo].[GLCFPREV] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_TID')
    ALTER INDEX [GLCFPREV_Index_TID] ON [dbo].[GLCFPREV] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLCFPREV]') AND name = N'GLCFPREV_Index_TRREF')
    ALTER INDEX [GLCFPREV_Index_TRREF] ON [dbo].[GLCFPREV] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="GLCFPREV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="GLCFPREV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<GLCFPREV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[GLCFPREV] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the GLCFPREV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLCFPREV data set</returns>
        public override EduHubDataSetDataReader<GLCFPREV> GetDataSetDataReader()
        {
            return new GLCFPREVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLCFPREV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLCFPREV data set</returns>
        public override EduHubDataSetDataReader<GLCFPREV> GetDataSetDataReader(List<GLCFPREV> Entities)
        {
            return new GLCFPREVDataReader(new EduHubDataSetLoadedReader<GLCFPREV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLCFPREVDataReader : EduHubDataSetDataReader<GLCFPREV>
        {
            public GLCFPREVDataReader(IEduHubDataSetReader<GLCFPREV> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 66; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // FAMILY
                        return Current.FAMILY;
                    case 3: // TRSTUD
                        return Current.TRSTUD;
                    case 4: // TRBATCH
                        return Current.TRBATCH;
                    case 5: // TRPERD
                        return Current.TRPERD;
                    case 6: // TRTYPE
                        return Current.TRTYPE;
                    case 7: // TRQTY
                        return Current.TRQTY;
                    case 8: // TRCOST
                        return Current.TRCOST;
                    case 9: // TRDATE
                        return Current.TRDATE;
                    case 10: // TRREF
                        return Current.TRREF;
                    case 11: // TRAMT
                        return Current.TRAMT;
                    case 12: // TRDET
                        return Current.TRDET;
                    case 13: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 14: // POST_OPTION
                        return Current.POST_OPTION;
                    case 15: // TRXCODE
                        return Current.TRXCODE;
                    case 16: // TRXTRTYPE
                        return Current.TRXTRTYPE;
                    case 17: // TRSHORT
                        return Current.TRSHORT;
                    case 18: // TRBANK
                        return Current.TRBANK;
                    case 19: // RECONCILE
                        return Current.RECONCILE;
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
                    case 46: // APPEAL
                        return Current.APPEAL;
                    case 47: // EVENT
                        return Current.EVENT;
                    case 48: // FRTYPE
                        return Current.FRTYPE;
                    case 49: // TINCLUDE
                        return Current.TINCLUDE;
                    case 50: // TTRNETT
                        return Current.TTRNETT;
                    case 51: // TTRAMT
                        return Current.TTRAMT;
                    case 52: // TGST_AMOUNT
                        return Current.TGST_AMOUNT;
                    case 53: // AMEMO
                        return Current.AMEMO;
                    case 54: // AMEMO_COPY
                        return Current.AMEMO_COPY;
                    case 55: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE;
                    case 56: // LINE_NO
                        return Current.LINE_NO;
                    case 57: // FLAG
                        return Current.FLAG;
                    case 58: // DEBIT_TOTAL
                        return Current.DEBIT_TOTAL;
                    case 59: // CREDIT_TOTAL
                        return Current.CREDIT_TOTAL;
                    case 60: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 61: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 62: // INITIATIVE
                        return Current.INITIATIVE;
                    case 63: // LW_DATE
                        return Current.LW_DATE;
                    case 64: // LW_TIME
                        return Current.LW_TIME;
                    case 65: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FAMILY
                        return Current.FAMILY == null;
                    case 3: // TRSTUD
                        return Current.TRSTUD == null;
                    case 4: // TRBATCH
                        return Current.TRBATCH == null;
                    case 5: // TRPERD
                        return Current.TRPERD == null;
                    case 6: // TRTYPE
                        return Current.TRTYPE == null;
                    case 7: // TRQTY
                        return Current.TRQTY == null;
                    case 8: // TRCOST
                        return Current.TRCOST == null;
                    case 9: // TRDATE
                        return Current.TRDATE == null;
                    case 10: // TRREF
                        return Current.TRREF == null;
                    case 11: // TRAMT
                        return Current.TRAMT == null;
                    case 12: // TRDET
                        return Current.TRDET == null;
                    case 13: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 14: // POST_OPTION
                        return Current.POST_OPTION == null;
                    case 15: // TRXCODE
                        return Current.TRXCODE == null;
                    case 16: // TRXTRTYPE
                        return Current.TRXTRTYPE == null;
                    case 17: // TRSHORT
                        return Current.TRSHORT == null;
                    case 18: // TRBANK
                        return Current.TRBANK == null;
                    case 19: // RECONCILE
                        return Current.RECONCILE == null;
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
                    case 46: // APPEAL
                        return Current.APPEAL == null;
                    case 47: // EVENT
                        return Current.EVENT == null;
                    case 48: // FRTYPE
                        return Current.FRTYPE == null;
                    case 49: // TINCLUDE
                        return Current.TINCLUDE == null;
                    case 50: // TTRNETT
                        return Current.TTRNETT == null;
                    case 51: // TTRAMT
                        return Current.TTRAMT == null;
                    case 52: // TGST_AMOUNT
                        return Current.TGST_AMOUNT == null;
                    case 53: // AMEMO
                        return Current.AMEMO == null;
                    case 54: // AMEMO_COPY
                        return Current.AMEMO_COPY == null;
                    case 55: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE == null;
                    case 56: // LINE_NO
                        return Current.LINE_NO == null;
                    case 57: // FLAG
                        return Current.FLAG == null;
                    case 58: // DEBIT_TOTAL
                        return Current.DEBIT_TOTAL == null;
                    case 59: // CREDIT_TOTAL
                        return Current.CREDIT_TOTAL == null;
                    case 60: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 61: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 62: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 63: // LW_DATE
                        return Current.LW_DATE == null;
                    case 64: // LW_TIME
                        return Current.LW_TIME == null;
                    case 65: // LW_USER
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

            public override int GetOrdinal(string name)
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
        }

        #endregion

    }
}
