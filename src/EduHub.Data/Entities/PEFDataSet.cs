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
    /// Payroll Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEFDataSet : EduHubDataSet<PEF>
    {
        /// <inheritdoc />
        public override string Name { get { return "PEF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PEFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAY_STEP = new Lazy<NullDictionary<short?, IReadOnlyList<PEF>>>(() => this.ToGroupedNullDictionary(i => i.PAY_STEP));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEF>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, PEF>>(() => this.ToDictionary(i => i.TID));
            Index_TRCENTRE = new Lazy<NullDictionary<string, IReadOnlyList<PEF>>>(() => this.ToGroupedNullDictionary(i => i.TRCENTRE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEF" /> fields for each CSV column header</returns>
        internal override Action<PEF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRCENTRE":
                        mapper[i] = (e, v) => e.TRCENTRE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPAYCODE":
                        mapper[i] = (e, v) => e.TRPAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRPAYPERD":
                        mapper[i] = (e, v) => e.TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRPITYPE":
                        mapper[i] = (e, v) => e.TRPITYPE = v;
                        break;
                    case "TRUNIT":
                        mapper[i] = (e, v) => e.TRUNIT = v;
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRNEXTPAYDATE":
                        mapper[i] = (e, v) => e.TRNEXTPAYDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TRNEXTPAYPERD":
                        mapper[i] = (e, v) => e.TRNEXTPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPAYSPAN":
                        mapper[i] = (e, v) => e.TRPAYSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRTAXSPAN":
                        mapper[i] = (e, v) => e.TRTAXSPAN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PNNEXTPAYDATE":
                        mapper[i] = (e, v) => e.PNNEXTPAYDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "WORKED_HOURS":
                        mapper[i] = (e, v) => e.WORKED_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PAY_STEP":
                        mapper[i] = (e, v) => e.PAY_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYSIGNTYPE":
                        mapper[i] = (e, v) => e.PAYSIGNTYPE = v;
                        break;
                    case "SYSTEM_TAX":
                        mapper[i] = (e, v) => e.SYSTEM_TAX = v;
                        break;
                    case "LINE_NO":
                        mapper[i] = (e, v) => e.LINE_NO = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TERMINATION_TYPE":
                        mapper[i] = (e, v) => e.TERMINATION_TYPE = v;
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
                    case "SPLIT_PERCENT":
                        mapper[i] = (e, v) => e.SPLIT_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ALTER_TRQTY":
                        mapper[i] = (e, v) => e.ALTER_TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ANNUALISED_LOADING":
                        mapper[i] = (e, v) => e.ANNUALISED_LOADING = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="PEF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PEF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PEF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PEF}"/> of entities</returns>
        internal override IEnumerable<PEF> ApplyDeltaEntities(IEnumerable<PEF> Entities, List<PEF> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEF>>> Index_PAY_STEP;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEF>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, PEF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<PEF>>> Index_TRCENTRE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEF</param>
        /// <returns>List of related PEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEF</param>
        /// <param name="Value">List of related PEF entities</param>
        /// <returns>True if the list of related PEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEF</param>
        /// <returns>List of related PEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEF> value;
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
        /// Find PEF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEF</param>
        /// <returns>List of related PEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEF</param>
        /// <param name="Value">List of related PEF entities</param>
        /// <returns>True if the list of related PEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEF</param>
        /// <returns>List of related PEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEF> value;
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
        /// Find PEF by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEF</param>
        /// <returns>List of related PEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> FindByPAY_STEP(short? PAY_STEP)
        {
            return Index_PAY_STEP.Value[PAY_STEP];
        }

        /// <summary>
        /// Attempt to find PEF by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEF</param>
        /// <param name="Value">List of related PEF entities</param>
        /// <returns>True if the list of related PEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAY_STEP(short? PAY_STEP, out IReadOnlyList<PEF> Value)
        {
            return Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEF</param>
        /// <returns>List of related PEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> TryFindByPAY_STEP(short? PAY_STEP)
        {
            IReadOnlyList<PEF> value;
            if (Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEF by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEF</param>
        /// <returns>List of related PEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEF by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEF</param>
        /// <param name="Value">List of related PEF entities</param>
        /// <returns>True if the list of related PEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEF> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEF</param>
        /// <returns>List of related PEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEF> value;
            if (Index_PAYITEM.Value.TryGetValue(PAYITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEF</param>
        /// <returns>List of related PEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEF</param>
        /// <param name="Value">List of related PEF entities</param>
        /// <returns>True if the list of related PEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEF</param>
        /// <returns>List of related PEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEF> value;
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
        /// Find PEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEF</param>
        /// <returns>Related PEF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEF</param>
        /// <param name="Value">Related PEF entity</param>
        /// <returns>True if the related PEF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEF</param>
        /// <returns>Related PEF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEF TryFindByTID(int TID)
        {
            PEF value;
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
        /// Find PEF by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEF</param>
        /// <returns>List of related PEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> FindByTRCENTRE(string TRCENTRE)
        {
            return Index_TRCENTRE.Value[TRCENTRE];
        }

        /// <summary>
        /// Attempt to find PEF by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEF</param>
        /// <param name="Value">List of related PEF entities</param>
        /// <returns>True if the list of related PEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRCENTRE(string TRCENTRE, out IReadOnlyList<PEF> Value)
        {
            return Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out Value);
        }

        /// <summary>
        /// Attempt to find PEF by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEF</param>
        /// <returns>List of related PEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEF> TryFindByTRCENTRE(string TRCENTRE)
        {
            IReadOnlyList<PEF> value;
            if (Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PEF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEF](
        [TID] int NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [PAYITEM] smallint NULL,
        [TRCENTRE] varchar(10) NULL,
        [TRTYPE] varchar(1) NULL,
        [TRBATCH] int NULL,
        [TRPAYCODE] smallint NULL,
        [TRPAYPERD] int NULL,
        [TRPERD] int NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRCOST] float NULL,
        [TRQTY] float NULL,
        [TRAMT] money NULL,
        [TRPITYPE] varchar(1) NULL,
        [TRUNIT] varchar(3) NULL,
        [TRDET] varchar(30) NULL,
        [TRNEXTPAYDATE] datetime NULL,
        [TRNEXTPAYPERD] int NULL,
        [TRPAYSPAN] smallint NULL,
        [TRTAXSPAN] float NULL,
        [PNNEXTPAYDATE] datetime NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [WORKED_HOURS] float NULL,
        [PAY_STEP] smallint NULL,
        [TRNETT] money NULL,
        [GST_AMOUNT] money NULL,
        [TRGROSS] money NULL,
        [PAYSIGNTYPE] varchar(1) NULL,
        [SYSTEM_TAX] varchar(1) NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [TERMINATION_TYPE] varchar(1) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [SPLIT_PERCENT] float NULL,
        [ALTER_TRQTY] float NULL,
        [ANNUALISED_LOADING] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEF_Index_CODE] ON [dbo].[PEF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEF_Index_INITIATIVE] ON [dbo].[PEF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEF_Index_PAY_STEP] ON [dbo].[PEF]
    (
            [PAY_STEP] ASC
    );
    CREATE NONCLUSTERED INDEX [PEF_Index_PAYITEM] ON [dbo].[PEF]
    (
            [PAYITEM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEF_Index_SUBPROGRAM] ON [dbo].[PEF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEF_Index_TRCENTRE] ON [dbo].[PEF]
    (
            [TRCENTRE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_INITIATIVE')
    ALTER INDEX [PEF_Index_INITIATIVE] ON [dbo].[PEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_PAY_STEP')
    ALTER INDEX [PEF_Index_PAY_STEP] ON [dbo].[PEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_PAYITEM')
    ALTER INDEX [PEF_Index_PAYITEM] ON [dbo].[PEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_SUBPROGRAM')
    ALTER INDEX [PEF_Index_SUBPROGRAM] ON [dbo].[PEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_TID')
    ALTER INDEX [PEF_Index_TID] ON [dbo].[PEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_TRCENTRE')
    ALTER INDEX [PEF_Index_TRCENTRE] ON [dbo].[PEF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_INITIATIVE')
    ALTER INDEX [PEF_Index_INITIATIVE] ON [dbo].[PEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_PAY_STEP')
    ALTER INDEX [PEF_Index_PAY_STEP] ON [dbo].[PEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_PAYITEM')
    ALTER INDEX [PEF_Index_PAYITEM] ON [dbo].[PEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_SUBPROGRAM')
    ALTER INDEX [PEF_Index_SUBPROGRAM] ON [dbo].[PEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_TID')
    ALTER INDEX [PEF_Index_TID] ON [dbo].[PEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEF]') AND name = N'PEF_Index_TRCENTRE')
    ALTER INDEX [PEF_Index_TRCENTRE] ON [dbo].[PEF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PEF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PEF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PEF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PEF] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PEF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEF data set</returns>
        public override EduHubDataSetDataReader<PEF> GetDataSetDataReader()
        {
            return new PEFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEF data set</returns>
        public override EduHubDataSetDataReader<PEF> GetDataSetDataReader(List<PEF> Entities)
        {
            return new PEFDataReader(new EduHubDataSetLoadedReader<PEF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEFDataReader : EduHubDataSetDataReader<PEF>
        {
            public PEFDataReader(IEduHubDataSetReader<PEF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 43; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // PAYITEM
                        return Current.PAYITEM;
                    case 3: // TRCENTRE
                        return Current.TRCENTRE;
                    case 4: // TRTYPE
                        return Current.TRTYPE;
                    case 5: // TRBATCH
                        return Current.TRBATCH;
                    case 6: // TRPAYCODE
                        return Current.TRPAYCODE;
                    case 7: // TRPAYPERD
                        return Current.TRPAYPERD;
                    case 8: // TRPERD
                        return Current.TRPERD;
                    case 9: // TRDATE
                        return Current.TRDATE;
                    case 10: // TRREF
                        return Current.TRREF;
                    case 11: // TRCOST
                        return Current.TRCOST;
                    case 12: // TRQTY
                        return Current.TRQTY;
                    case 13: // TRAMT
                        return Current.TRAMT;
                    case 14: // TRPITYPE
                        return Current.TRPITYPE;
                    case 15: // TRUNIT
                        return Current.TRUNIT;
                    case 16: // TRDET
                        return Current.TRDET;
                    case 17: // TRNEXTPAYDATE
                        return Current.TRNEXTPAYDATE;
                    case 18: // TRNEXTPAYPERD
                        return Current.TRNEXTPAYPERD;
                    case 19: // TRPAYSPAN
                        return Current.TRPAYSPAN;
                    case 20: // TRTAXSPAN
                        return Current.TRTAXSPAN;
                    case 21: // PNNEXTPAYDATE
                        return Current.PNNEXTPAYDATE;
                    case 22: // SUPER_FUND
                        return Current.SUPER_FUND;
                    case 23: // SUPER_MEMBER
                        return Current.SUPER_MEMBER;
                    case 24: // WORKED_HOURS
                        return Current.WORKED_HOURS;
                    case 25: // PAY_STEP
                        return Current.PAY_STEP;
                    case 26: // TRNETT
                        return Current.TRNETT;
                    case 27: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 28: // TRGROSS
                        return Current.TRGROSS;
                    case 29: // PAYSIGNTYPE
                        return Current.PAYSIGNTYPE;
                    case 30: // SYSTEM_TAX
                        return Current.SYSTEM_TAX;
                    case 31: // LINE_NO
                        return Current.LINE_NO;
                    case 32: // FLAG
                        return Current.FLAG;
                    case 33: // TERMINATION_TYPE
                        return Current.TERMINATION_TYPE;
                    case 34: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 35: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 36: // INITIATIVE
                        return Current.INITIATIVE;
                    case 37: // SPLIT_PERCENT
                        return Current.SPLIT_PERCENT;
                    case 38: // ALTER_TRQTY
                        return Current.ALTER_TRQTY;
                    case 39: // ANNUALISED_LOADING
                        return Current.ANNUALISED_LOADING;
                    case 40: // LW_DATE
                        return Current.LW_DATE;
                    case 41: // LW_TIME
                        return Current.LW_TIME;
                    case 42: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PAYITEM
                        return Current.PAYITEM == null;
                    case 3: // TRCENTRE
                        return Current.TRCENTRE == null;
                    case 4: // TRTYPE
                        return Current.TRTYPE == null;
                    case 5: // TRBATCH
                        return Current.TRBATCH == null;
                    case 6: // TRPAYCODE
                        return Current.TRPAYCODE == null;
                    case 7: // TRPAYPERD
                        return Current.TRPAYPERD == null;
                    case 8: // TRPERD
                        return Current.TRPERD == null;
                    case 9: // TRDATE
                        return Current.TRDATE == null;
                    case 10: // TRREF
                        return Current.TRREF == null;
                    case 11: // TRCOST
                        return Current.TRCOST == null;
                    case 12: // TRQTY
                        return Current.TRQTY == null;
                    case 13: // TRAMT
                        return Current.TRAMT == null;
                    case 14: // TRPITYPE
                        return Current.TRPITYPE == null;
                    case 15: // TRUNIT
                        return Current.TRUNIT == null;
                    case 16: // TRDET
                        return Current.TRDET == null;
                    case 17: // TRNEXTPAYDATE
                        return Current.TRNEXTPAYDATE == null;
                    case 18: // TRNEXTPAYPERD
                        return Current.TRNEXTPAYPERD == null;
                    case 19: // TRPAYSPAN
                        return Current.TRPAYSPAN == null;
                    case 20: // TRTAXSPAN
                        return Current.TRTAXSPAN == null;
                    case 21: // PNNEXTPAYDATE
                        return Current.PNNEXTPAYDATE == null;
                    case 22: // SUPER_FUND
                        return Current.SUPER_FUND == null;
                    case 23: // SUPER_MEMBER
                        return Current.SUPER_MEMBER == null;
                    case 24: // WORKED_HOURS
                        return Current.WORKED_HOURS == null;
                    case 25: // PAY_STEP
                        return Current.PAY_STEP == null;
                    case 26: // TRNETT
                        return Current.TRNETT == null;
                    case 27: // GST_AMOUNT
                        return Current.GST_AMOUNT == null;
                    case 28: // TRGROSS
                        return Current.TRGROSS == null;
                    case 29: // PAYSIGNTYPE
                        return Current.PAYSIGNTYPE == null;
                    case 30: // SYSTEM_TAX
                        return Current.SYSTEM_TAX == null;
                    case 31: // LINE_NO
                        return Current.LINE_NO == null;
                    case 32: // FLAG
                        return Current.FLAG == null;
                    case 33: // TERMINATION_TYPE
                        return Current.TERMINATION_TYPE == null;
                    case 34: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 35: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 36: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 37: // SPLIT_PERCENT
                        return Current.SPLIT_PERCENT == null;
                    case 38: // ALTER_TRQTY
                        return Current.ALTER_TRQTY == null;
                    case 39: // ANNUALISED_LOADING
                        return Current.ANNUALISED_LOADING == null;
                    case 40: // LW_DATE
                        return Current.LW_DATE == null;
                    case 41: // LW_TIME
                        return Current.LW_TIME == null;
                    case 42: // LW_USER
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
                    case 2: // PAYITEM
                        return "PAYITEM";
                    case 3: // TRCENTRE
                        return "TRCENTRE";
                    case 4: // TRTYPE
                        return "TRTYPE";
                    case 5: // TRBATCH
                        return "TRBATCH";
                    case 6: // TRPAYCODE
                        return "TRPAYCODE";
                    case 7: // TRPAYPERD
                        return "TRPAYPERD";
                    case 8: // TRPERD
                        return "TRPERD";
                    case 9: // TRDATE
                        return "TRDATE";
                    case 10: // TRREF
                        return "TRREF";
                    case 11: // TRCOST
                        return "TRCOST";
                    case 12: // TRQTY
                        return "TRQTY";
                    case 13: // TRAMT
                        return "TRAMT";
                    case 14: // TRPITYPE
                        return "TRPITYPE";
                    case 15: // TRUNIT
                        return "TRUNIT";
                    case 16: // TRDET
                        return "TRDET";
                    case 17: // TRNEXTPAYDATE
                        return "TRNEXTPAYDATE";
                    case 18: // TRNEXTPAYPERD
                        return "TRNEXTPAYPERD";
                    case 19: // TRPAYSPAN
                        return "TRPAYSPAN";
                    case 20: // TRTAXSPAN
                        return "TRTAXSPAN";
                    case 21: // PNNEXTPAYDATE
                        return "PNNEXTPAYDATE";
                    case 22: // SUPER_FUND
                        return "SUPER_FUND";
                    case 23: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 24: // WORKED_HOURS
                        return "WORKED_HOURS";
                    case 25: // PAY_STEP
                        return "PAY_STEP";
                    case 26: // TRNETT
                        return "TRNETT";
                    case 27: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 28: // TRGROSS
                        return "TRGROSS";
                    case 29: // PAYSIGNTYPE
                        return "PAYSIGNTYPE";
                    case 30: // SYSTEM_TAX
                        return "SYSTEM_TAX";
                    case 31: // LINE_NO
                        return "LINE_NO";
                    case 32: // FLAG
                        return "FLAG";
                    case 33: // TERMINATION_TYPE
                        return "TERMINATION_TYPE";
                    case 34: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 35: // GLPROGRAM
                        return "GLPROGRAM";
                    case 36: // INITIATIVE
                        return "INITIATIVE";
                    case 37: // SPLIT_PERCENT
                        return "SPLIT_PERCENT";
                    case 38: // ALTER_TRQTY
                        return "ALTER_TRQTY";
                    case 39: // ANNUALISED_LOADING
                        return "ANNUALISED_LOADING";
                    case 40: // LW_DATE
                        return "LW_DATE";
                    case 41: // LW_TIME
                        return "LW_TIME";
                    case 42: // LW_USER
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
                    case "PAYITEM":
                        return 2;
                    case "TRCENTRE":
                        return 3;
                    case "TRTYPE":
                        return 4;
                    case "TRBATCH":
                        return 5;
                    case "TRPAYCODE":
                        return 6;
                    case "TRPAYPERD":
                        return 7;
                    case "TRPERD":
                        return 8;
                    case "TRDATE":
                        return 9;
                    case "TRREF":
                        return 10;
                    case "TRCOST":
                        return 11;
                    case "TRQTY":
                        return 12;
                    case "TRAMT":
                        return 13;
                    case "TRPITYPE":
                        return 14;
                    case "TRUNIT":
                        return 15;
                    case "TRDET":
                        return 16;
                    case "TRNEXTPAYDATE":
                        return 17;
                    case "TRNEXTPAYPERD":
                        return 18;
                    case "TRPAYSPAN":
                        return 19;
                    case "TRTAXSPAN":
                        return 20;
                    case "PNNEXTPAYDATE":
                        return 21;
                    case "SUPER_FUND":
                        return 22;
                    case "SUPER_MEMBER":
                        return 23;
                    case "WORKED_HOURS":
                        return 24;
                    case "PAY_STEP":
                        return 25;
                    case "TRNETT":
                        return 26;
                    case "GST_AMOUNT":
                        return 27;
                    case "TRGROSS":
                        return 28;
                    case "PAYSIGNTYPE":
                        return 29;
                    case "SYSTEM_TAX":
                        return 30;
                    case "LINE_NO":
                        return 31;
                    case "FLAG":
                        return 32;
                    case "TERMINATION_TYPE":
                        return 33;
                    case "SUBPROGRAM":
                        return 34;
                    case "GLPROGRAM":
                        return 35;
                    case "INITIATIVE":
                        return 36;
                    case "SPLIT_PERCENT":
                        return 37;
                    case "ALTER_TRQTY":
                        return 38;
                    case "ANNUALISED_LOADING":
                        return 39;
                    case "LW_DATE":
                        return 40;
                    case "LW_TIME":
                        return 41;
                    case "LW_USER":
                        return 42;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
