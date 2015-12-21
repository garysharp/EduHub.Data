using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard and Last Pays Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPSDataSet : EduHubDataSet<PEPS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPS"; } }

        internal PEPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAY_STEP = new Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.PAY_STEP));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_SUPER_FUND = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.SUPER_FUND));
            Index_TID = new Lazy<Dictionary<int, PEPS>>(() => this.ToDictionary(i => i.TID));
            Index_TRCENTRE = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.TRCENTRE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPS" /> fields for each CSV column header</returns>
        protected override Action<PEPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPS, string>[Headers.Count];

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
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRPAYSPAN":
                        mapper[i] = (e, v) => e.TRPAYSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRTAXSPAN":
                        mapper[i] = (e, v) => e.TRTAXSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIMESHEET_NO":
                        mapper[i] = (e, v) => e.TIMESHEET_NO = v;
                        break;
                    case "PAY_STEP":
                        mapper[i] = (e, v) => e.PAY_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "SUPER_PERCENT":
                        mapper[i] = (e, v) => e.SUPER_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRCENTRE":
                        mapper[i] = (e, v) => e.TRCENTRE = v;
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
        /// Merges <see cref="PEPS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPS" /> items to added or update the base <see cref="PEPS" /> items</param>
        /// <returns>A merged list of <see cref="PEPS" /> items</returns>
        protected override List<PEPS> ApplyDeltaItems(List<PEPS> Items, List<PEPS> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPS deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>> Index_PAY_STEP;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_SUPER_FUND;
        private Lazy<Dictionary<int, PEPS>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_TRCENTRE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPS by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPS by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPS> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPS> value;
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
        /// Find PEPS by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEPS by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPS> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPS> value;
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
        /// Find PEPS by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByPAY_STEP(short? PAY_STEP)
        {
            return Index_PAY_STEP.Value[PAY_STEP];
        }

        /// <summary>
        /// Attempt to find PEPS by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAY_STEP(short? PAY_STEP, out IReadOnlyList<PEPS> Value)
        {
            return Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByPAY_STEP(short? PAY_STEP)
        {
            IReadOnlyList<PEPS> value;
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
        /// Find PEPS by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEPS by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEPS> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEPS> value;
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
        /// Find PEPS by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEPS by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPS> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPS> value;
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
        /// Find PEPS by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindBySUPER_FUND(string SUPER_FUND)
        {
            return Index_SUPER_FUND.Value[SUPER_FUND];
        }

        /// <summary>
        /// Attempt to find PEPS by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPER_FUND(string SUPER_FUND, out IReadOnlyList<PEPS> Value)
        {
            return Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindBySUPER_FUND(string SUPER_FUND)
        {
            IReadOnlyList<PEPS> value;
            if (Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPS</param>
        /// <returns>Related PEPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPS</param>
        /// <param name="Value">Related PEPS entity</param>
        /// <returns>True if the related PEPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPS</param>
        /// <returns>Related PEPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPS TryFindByTID(int TID)
        {
            PEPS value;
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
        /// Find PEPS by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByTRCENTRE(string TRCENTRE)
        {
            return Index_TRCENTRE.Value[TRCENTRE];
        }

        /// <summary>
        /// Attempt to find PEPS by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRCENTRE(string TRCENTRE, out IReadOnlyList<PEPS> Value)
        {
            return Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByTRCENTRE(string TRCENTRE)
        {
            IReadOnlyList<PEPS> value;
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
        /// Returns SQL which checks for the existence of a PEPS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPS](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [PAYITEM] smallint NULL,
        [TRCOST] float NULL,
        [TRQTY] float NULL,
        [TRAMT] money NULL,
        [TRDET] varchar(30) NULL,
        [FLAG] varchar(1) NULL,
        [TRPAYSPAN] smallint NULL,
        [TRTAXSPAN] smallint NULL,
        [TRDATE] datetime NULL,
        [TIMESHEET_NO] varchar(15) NULL,
        [PAY_STEP] smallint NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [SUPER_PERCENT] float NULL,
        [TRCENTRE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [SPLIT_PERCENT] float NULL,
        [ALTER_TRQTY] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPS_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEPS_Index_CODE] ON [dbo].[PEPS]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPS_Index_INITIATIVE] ON [dbo].[PEPS]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPS_Index_PAY_STEP] ON [dbo].[PEPS]
    (
            [PAY_STEP] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPS_Index_PAYITEM] ON [dbo].[PEPS]
    (
            [PAYITEM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPS_Index_SUBPROGRAM] ON [dbo].[PEPS]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPS_Index_SUPER_FUND] ON [dbo].[PEPS]
    (
            [SUPER_FUND] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPS_Index_TRCENTRE] ON [dbo].[PEPS]
    (
            [TRCENTRE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEPSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPSDataReader : IDataReader, IDataRecord
        {
            private List<PEPS> Items;
            private int CurrentIndex;
            private PEPS CurrentItem;

            public PEPSDataReader(List<PEPS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 25; } }
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
                    case 3: // TRCOST
                        return CurrentItem.TRCOST;
                    case 4: // TRQTY
                        return CurrentItem.TRQTY;
                    case 5: // TRAMT
                        return CurrentItem.TRAMT;
                    case 6: // TRDET
                        return CurrentItem.TRDET;
                    case 7: // FLAG
                        return CurrentItem.FLAG;
                    case 8: // TRPAYSPAN
                        return CurrentItem.TRPAYSPAN;
                    case 9: // TRTAXSPAN
                        return CurrentItem.TRTAXSPAN;
                    case 10: // TRDATE
                        return CurrentItem.TRDATE;
                    case 11: // TIMESHEET_NO
                        return CurrentItem.TIMESHEET_NO;
                    case 12: // PAY_STEP
                        return CurrentItem.PAY_STEP;
                    case 13: // SUPER_FUND
                        return CurrentItem.SUPER_FUND;
                    case 14: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER;
                    case 15: // SUPER_PERCENT
                        return CurrentItem.SUPER_PERCENT;
                    case 16: // TRCENTRE
                        return CurrentItem.TRCENTRE;
                    case 17: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 18: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 19: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 20: // SPLIT_PERCENT
                        return CurrentItem.SPLIT_PERCENT;
                    case 21: // ALTER_TRQTY
                        return CurrentItem.ALTER_TRQTY;
                    case 22: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 23: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 24: // LW_USER
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
                    case 3: // TRCOST
                        return CurrentItem.TRCOST == null;
                    case 4: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 5: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 6: // TRDET
                        return CurrentItem.TRDET == null;
                    case 7: // FLAG
                        return CurrentItem.FLAG == null;
                    case 8: // TRPAYSPAN
                        return CurrentItem.TRPAYSPAN == null;
                    case 9: // TRTAXSPAN
                        return CurrentItem.TRTAXSPAN == null;
                    case 10: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 11: // TIMESHEET_NO
                        return CurrentItem.TIMESHEET_NO == null;
                    case 12: // PAY_STEP
                        return CurrentItem.PAY_STEP == null;
                    case 13: // SUPER_FUND
                        return CurrentItem.SUPER_FUND == null;
                    case 14: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER == null;
                    case 15: // SUPER_PERCENT
                        return CurrentItem.SUPER_PERCENT == null;
                    case 16: // TRCENTRE
                        return CurrentItem.TRCENTRE == null;
                    case 17: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 18: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 19: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 20: // SPLIT_PERCENT
                        return CurrentItem.SPLIT_PERCENT == null;
                    case 21: // ALTER_TRQTY
                        return CurrentItem.ALTER_TRQTY == null;
                    case 22: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 23: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 24: // LW_USER
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
                    case 3: // TRCOST
                        return "TRCOST";
                    case 4: // TRQTY
                        return "TRQTY";
                    case 5: // TRAMT
                        return "TRAMT";
                    case 6: // TRDET
                        return "TRDET";
                    case 7: // FLAG
                        return "FLAG";
                    case 8: // TRPAYSPAN
                        return "TRPAYSPAN";
                    case 9: // TRTAXSPAN
                        return "TRTAXSPAN";
                    case 10: // TRDATE
                        return "TRDATE";
                    case 11: // TIMESHEET_NO
                        return "TIMESHEET_NO";
                    case 12: // PAY_STEP
                        return "PAY_STEP";
                    case 13: // SUPER_FUND
                        return "SUPER_FUND";
                    case 14: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 15: // SUPER_PERCENT
                        return "SUPER_PERCENT";
                    case 16: // TRCENTRE
                        return "TRCENTRE";
                    case 17: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 18: // GLPROGRAM
                        return "GLPROGRAM";
                    case 19: // INITIATIVE
                        return "INITIATIVE";
                    case 20: // SPLIT_PERCENT
                        return "SPLIT_PERCENT";
                    case 21: // ALTER_TRQTY
                        return "ALTER_TRQTY";
                    case 22: // LW_DATE
                        return "LW_DATE";
                    case 23: // LW_TIME
                        return "LW_TIME";
                    case 24: // LW_USER
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
                    case "TRCOST":
                        return 3;
                    case "TRQTY":
                        return 4;
                    case "TRAMT":
                        return 5;
                    case "TRDET":
                        return 6;
                    case "FLAG":
                        return 7;
                    case "TRPAYSPAN":
                        return 8;
                    case "TRTAXSPAN":
                        return 9;
                    case "TRDATE":
                        return 10;
                    case "TIMESHEET_NO":
                        return 11;
                    case "PAY_STEP":
                        return 12;
                    case "SUPER_FUND":
                        return 13;
                    case "SUPER_MEMBER":
                        return 14;
                    case "SUPER_PERCENT":
                        return 15;
                    case "TRCENTRE":
                        return 16;
                    case "SUBPROGRAM":
                        return 17;
                    case "GLPROGRAM":
                        return 18;
                    case "INITIATIVE":
                        return 19;
                    case "SPLIT_PERCENT":
                        return 20;
                    case "ALTER_TRQTY":
                        return 21;
                    case "LW_DATE":
                        return 22;
                    case "LW_TIME":
                        return 23;
                    case "LW_USER":
                        return 24;
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
