using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Super (SGL and Employee) History YTD Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPUHDataSet : DataSetBase<PEPUH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPUH"; } }

        internal PEPUHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_SUPER_FUND = new Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.SUPER_FUND));
            Index_TID = new Lazy<Dictionary<int, PEPUH>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPUH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPUH" /> fields for each CSV column header</returns>
        protected override Action<PEPUH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPUH, string>[Headers.Count];

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
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
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
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRPAYAMT":
                        mapper[i] = (e, v) => e.TRPAYAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRSUPER_PC":
                        mapper[i] = (e, v) => e.TRSUPER_PC = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRSUPER_AMT":
                        mapper[i] = (e, v) => e.TRSUPER_AMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
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
        /// Merges <see cref="PEPUH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPUH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPUH" /> items to added or update the base <see cref="PEPUH" /> items</param>
        /// <returns>A merged list of <see cref="PEPUH" /> items</returns>
        protected override List<PEPUH> ApplyDeltaItems(List<PEPUH> Items, List<PEPUH> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPUH deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEPUH>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPUH>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>> Index_SUPER_FUND;
        private Lazy<Dictionary<int, PEPUH>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPUH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPUH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPUH> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPUH> value;
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
        /// Find PEPUH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEPUH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPUH> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPUH> value;
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
        /// Find PEPUH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEPUH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEPUH> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEPUH> value;
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
        /// Find PEPUH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEPUH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPUH> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPUH> value;
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
        /// Find PEPUH by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindBySUPER_FUND(string SUPER_FUND)
        {
            return Index_SUPER_FUND.Value[SUPER_FUND];
        }

        /// <summary>
        /// Attempt to find PEPUH by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPER_FUND(string SUPER_FUND, out IReadOnlyList<PEPUH> Value)
        {
            return Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindBySUPER_FUND(string SUPER_FUND)
        {
            IReadOnlyList<PEPUH> value;
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
        /// Find PEPUH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPUH</param>
        /// <returns>Related PEPUH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPUH FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPUH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPUH</param>
        /// <param name="Value">Related PEPUH entity</param>
        /// <returns>True if the related PEPUH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPUH Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPUH</param>
        /// <returns>Related PEPUH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPUH TryFindByTID(int TID)
        {
            PEPUH value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns SQL which checks for the existence of a PEPUH table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPUH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPUH](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [PAYITEM] smallint NULL,
        [TRBATCH] int NULL,
        [TRPERD] int NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRQTY] float NULL,
        [TRDET] varchar(30) NULL,
        [TRTYPE] varchar(1) NULL,
        [TRPAYAMT] money NULL,
        [TRSUPER_PC] float NULL,
        [TRSUPER_AMT] money NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPUH_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEPUH_Index_CODE] ON [dbo].[PEPUH]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPUH_Index_INITIATIVE] ON [dbo].[PEPUH]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPUH_Index_PAYITEM] ON [dbo].[PEPUH]
    (
            [PAYITEM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPUH_Index_SUBPROGRAM] ON [dbo].[PEPUH]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPUH_Index_SUPER_FUND] ON [dbo].[PEPUH]
    (
            [SUPER_FUND] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPUH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPUH data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEPUHDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPUHDataReader : IDataReader, IDataRecord
        {
            private List<PEPUH> Items;
            private int CurrentIndex;
            private PEPUH CurrentItem;

            public PEPUHDataReader(List<PEPUH> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 21; } }
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
                    case 3: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 4: // TRPERD
                        return CurrentItem.TRPERD;
                    case 5: // TRDATE
                        return CurrentItem.TRDATE;
                    case 6: // TRREF
                        return CurrentItem.TRREF;
                    case 7: // TRQTY
                        return CurrentItem.TRQTY;
                    case 8: // TRDET
                        return CurrentItem.TRDET;
                    case 9: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 10: // TRPAYAMT
                        return CurrentItem.TRPAYAMT;
                    case 11: // TRSUPER_PC
                        return CurrentItem.TRSUPER_PC;
                    case 12: // TRSUPER_AMT
                        return CurrentItem.TRSUPER_AMT;
                    case 13: // SUPER_FUND
                        return CurrentItem.SUPER_FUND;
                    case 14: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER;
                    case 15: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 16: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 17: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 20: // LW_USER
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
                    case 3: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 4: // TRPERD
                        return CurrentItem.TRPERD == null;
                    case 5: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 6: // TRREF
                        return CurrentItem.TRREF == null;
                    case 7: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 8: // TRDET
                        return CurrentItem.TRDET == null;
                    case 9: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 10: // TRPAYAMT
                        return CurrentItem.TRPAYAMT == null;
                    case 11: // TRSUPER_PC
                        return CurrentItem.TRSUPER_PC == null;
                    case 12: // TRSUPER_AMT
                        return CurrentItem.TRSUPER_AMT == null;
                    case 13: // SUPER_FUND
                        return CurrentItem.SUPER_FUND == null;
                    case 14: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER == null;
                    case 15: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 16: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 17: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 20: // LW_USER
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
                    case 3: // TRBATCH
                        return "TRBATCH";
                    case 4: // TRPERD
                        return "TRPERD";
                    case 5: // TRDATE
                        return "TRDATE";
                    case 6: // TRREF
                        return "TRREF";
                    case 7: // TRQTY
                        return "TRQTY";
                    case 8: // TRDET
                        return "TRDET";
                    case 9: // TRTYPE
                        return "TRTYPE";
                    case 10: // TRPAYAMT
                        return "TRPAYAMT";
                    case 11: // TRSUPER_PC
                        return "TRSUPER_PC";
                    case 12: // TRSUPER_AMT
                        return "TRSUPER_AMT";
                    case 13: // SUPER_FUND
                        return "SUPER_FUND";
                    case 14: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 15: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 16: // GLPROGRAM
                        return "GLPROGRAM";
                    case 17: // INITIATIVE
                        return "INITIATIVE";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
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
                    case "TRBATCH":
                        return 3;
                    case "TRPERD":
                        return 4;
                    case "TRDATE":
                        return 5;
                    case "TRREF":
                        return 6;
                    case "TRQTY":
                        return 7;
                    case "TRDET":
                        return 8;
                    case "TRTYPE":
                        return 9;
                    case "TRPAYAMT":
                        return 10;
                    case "TRSUPER_PC":
                        return 11;
                    case "TRSUPER_AMT":
                        return 12;
                    case "SUPER_FUND":
                        return 13;
                    case "SUPER_MEMBER":
                        return 14;
                    case "SUBPROGRAM":
                        return 15;
                    case "GLPROGRAM":
                        return 16;
                    case "INITIATIVE":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
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
