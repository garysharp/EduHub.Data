using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Transaction History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEFHDataSet : EduHubDataSet<PEFH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEFH"; } }

        internal PEFHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAY_STEP = new Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.PAY_STEP));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, PEFH>>(() => this.ToDictionary(i => i.TID));
            Index_TRCENTRE = new Lazy<NullDictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.TRCENTRE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEFH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEFH" /> fields for each CSV column header</returns>
        protected override Action<PEFH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEFH, string>[Headers.Count];

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
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.TRNEXTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.PNNEXTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="PEFH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEFH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEFH" /> items to added or update the base <see cref="PEFH" /> items</param>
        /// <returns>A merged list of <see cref="PEFH" /> items</returns>
        protected override List<PEFH> ApplyDeltaItems(List<PEFH> Items, List<PEFH> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEFH deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEFH>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEFH>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>> Index_PAY_STEP;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEFH>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, PEFH>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<PEFH>>> Index_TRCENTRE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEFH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEFH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEFH> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEFH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEFH> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByPAY_STEP(short? PAY_STEP)
        {
            return Index_PAY_STEP.Value[PAY_STEP];
        }

        /// <summary>
        /// Attempt to find PEFH by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAY_STEP(short? PAY_STEP, out IReadOnlyList<PEFH> Value)
        {
            return Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByPAY_STEP(short? PAY_STEP)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEFH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEFH> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEFH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEFH> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEFH</param>
        /// <returns>Related PEFH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEFH FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEFH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEFH</param>
        /// <param name="Value">Related PEFH entity</param>
        /// <returns>True if the related PEFH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEFH Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEFH</param>
        /// <returns>Related PEFH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEFH TryFindByTID(int TID)
        {
            PEFH value;
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
        /// Find PEFH by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByTRCENTRE(string TRCENTRE)
        {
            return Index_TRCENTRE.Value[TRCENTRE];
        }

        /// <summary>
        /// Attempt to find PEFH by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRCENTRE(string TRCENTRE, out IReadOnlyList<PEFH> Value)
        {
            return Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByTRCENTRE(string TRCENTRE)
        {
            IReadOnlyList<PEFH> value;
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
        /// Returns SQL which checks for the existence of a PEFH table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEFH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEFH](
        [TID] int IDENTITY NOT NULL,
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
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [SPLIT_PERCENT] float NULL,
        [ALTER_TRQTY] float NULL,
        [ANNUALISED_LOADING] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEFH_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEFH_Index_CODE] ON [dbo].[PEFH]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEFH_Index_INITIATIVE] ON [dbo].[PEFH]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEFH_Index_PAY_STEP] ON [dbo].[PEFH]
    (
            [PAY_STEP] ASC
    );
    CREATE NONCLUSTERED INDEX [PEFH_Index_PAYITEM] ON [dbo].[PEFH]
    (
            [PAYITEM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEFH_Index_SUBPROGRAM] ON [dbo].[PEFH]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEFH_Index_TRCENTRE] ON [dbo].[PEFH]
    (
            [TRCENTRE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEFH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEFH data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEFHDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEFHDataReader : IDataReader, IDataRecord
        {
            private List<PEFH> Items;
            private int CurrentIndex;
            private PEFH CurrentItem;

            public PEFHDataReader(List<PEFH> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 42; } }
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
                    case 2: // PAYITEM
                        return CurrentItem.PAYITEM;
                    case 3: // TRCENTRE
                        return CurrentItem.TRCENTRE;
                    case 4: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 5: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 6: // TRPAYCODE
                        return CurrentItem.TRPAYCODE;
                    case 7: // TRPAYPERD
                        return CurrentItem.TRPAYPERD;
                    case 8: // TRPERD
                        return CurrentItem.TRPERD;
                    case 9: // TRDATE
                        return CurrentItem.TRDATE;
                    case 10: // TRREF
                        return CurrentItem.TRREF;
                    case 11: // TRCOST
                        return CurrentItem.TRCOST;
                    case 12: // TRQTY
                        return CurrentItem.TRQTY;
                    case 13: // TRAMT
                        return CurrentItem.TRAMT;
                    case 14: // TRPITYPE
                        return CurrentItem.TRPITYPE;
                    case 15: // TRUNIT
                        return CurrentItem.TRUNIT;
                    case 16: // TRDET
                        return CurrentItem.TRDET;
                    case 17: // TRNEXTPAYDATE
                        return CurrentItem.TRNEXTPAYDATE;
                    case 18: // TRNEXTPAYPERD
                        return CurrentItem.TRNEXTPAYPERD;
                    case 19: // TRPAYSPAN
                        return CurrentItem.TRPAYSPAN;
                    case 20: // TRTAXSPAN
                        return CurrentItem.TRTAXSPAN;
                    case 21: // PNNEXTPAYDATE
                        return CurrentItem.PNNEXTPAYDATE;
                    case 22: // SUPER_FUND
                        return CurrentItem.SUPER_FUND;
                    case 23: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER;
                    case 24: // WORKED_HOURS
                        return CurrentItem.WORKED_HOURS;
                    case 25: // PAY_STEP
                        return CurrentItem.PAY_STEP;
                    case 26: // TRNETT
                        return CurrentItem.TRNETT;
                    case 27: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT;
                    case 28: // TRGROSS
                        return CurrentItem.TRGROSS;
                    case 29: // PAYSIGNTYPE
                        return CurrentItem.PAYSIGNTYPE;
                    case 30: // SYSTEM_TAX
                        return CurrentItem.SYSTEM_TAX;
                    case 31: // LINE_NO
                        return CurrentItem.LINE_NO;
                    case 32: // FLAG
                        return CurrentItem.FLAG;
                    case 33: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 34: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 35: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 36: // SPLIT_PERCENT
                        return CurrentItem.SPLIT_PERCENT;
                    case 37: // ALTER_TRQTY
                        return CurrentItem.ALTER_TRQTY;
                    case 38: // ANNUALISED_LOADING
                        return CurrentItem.ANNUALISED_LOADING;
                    case 39: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 40: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 41: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PAYITEM
                        return CurrentItem.PAYITEM == null;
                    case 3: // TRCENTRE
                        return CurrentItem.TRCENTRE == null;
                    case 4: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 5: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 6: // TRPAYCODE
                        return CurrentItem.TRPAYCODE == null;
                    case 7: // TRPAYPERD
                        return CurrentItem.TRPAYPERD == null;
                    case 8: // TRPERD
                        return CurrentItem.TRPERD == null;
                    case 9: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 10: // TRREF
                        return CurrentItem.TRREF == null;
                    case 11: // TRCOST
                        return CurrentItem.TRCOST == null;
                    case 12: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 13: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 14: // TRPITYPE
                        return CurrentItem.TRPITYPE == null;
                    case 15: // TRUNIT
                        return CurrentItem.TRUNIT == null;
                    case 16: // TRDET
                        return CurrentItem.TRDET == null;
                    case 17: // TRNEXTPAYDATE
                        return CurrentItem.TRNEXTPAYDATE == null;
                    case 18: // TRNEXTPAYPERD
                        return CurrentItem.TRNEXTPAYPERD == null;
                    case 19: // TRPAYSPAN
                        return CurrentItem.TRPAYSPAN == null;
                    case 20: // TRTAXSPAN
                        return CurrentItem.TRTAXSPAN == null;
                    case 21: // PNNEXTPAYDATE
                        return CurrentItem.PNNEXTPAYDATE == null;
                    case 22: // SUPER_FUND
                        return CurrentItem.SUPER_FUND == null;
                    case 23: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER == null;
                    case 24: // WORKED_HOURS
                        return CurrentItem.WORKED_HOURS == null;
                    case 25: // PAY_STEP
                        return CurrentItem.PAY_STEP == null;
                    case 26: // TRNETT
                        return CurrentItem.TRNETT == null;
                    case 27: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT == null;
                    case 28: // TRGROSS
                        return CurrentItem.TRGROSS == null;
                    case 29: // PAYSIGNTYPE
                        return CurrentItem.PAYSIGNTYPE == null;
                    case 30: // SYSTEM_TAX
                        return CurrentItem.SYSTEM_TAX == null;
                    case 31: // LINE_NO
                        return CurrentItem.LINE_NO == null;
                    case 32: // FLAG
                        return CurrentItem.FLAG == null;
                    case 33: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 34: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 35: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 36: // SPLIT_PERCENT
                        return CurrentItem.SPLIT_PERCENT == null;
                    case 37: // ALTER_TRQTY
                        return CurrentItem.ALTER_TRQTY == null;
                    case 38: // ANNUALISED_LOADING
                        return CurrentItem.ANNUALISED_LOADING == null;
                    case 39: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 40: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 41: // LW_USER
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
                    case 33: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 34: // GLPROGRAM
                        return "GLPROGRAM";
                    case 35: // INITIATIVE
                        return "INITIATIVE";
                    case 36: // SPLIT_PERCENT
                        return "SPLIT_PERCENT";
                    case 37: // ALTER_TRQTY
                        return "ALTER_TRQTY";
                    case 38: // ANNUALISED_LOADING
                        return "ANNUALISED_LOADING";
                    case 39: // LW_DATE
                        return "LW_DATE";
                    case 40: // LW_TIME
                        return "LW_TIME";
                    case 41: // LW_USER
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
                    case "SUBPROGRAM":
                        return 33;
                    case "GLPROGRAM":
                        return 34;
                    case "INITIATIVE":
                        return 35;
                    case "SPLIT_PERCENT":
                        return 36;
                    case "ALTER_TRQTY":
                        return 37;
                    case "ANNUALISED_LOADING":
                        return 38;
                    case "LW_DATE":
                        return 39;
                    case "LW_TIME":
                        return 40;
                    case "LW_USER":
                        return 41;
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
