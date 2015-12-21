using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Voluntary Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFVTDataSet : EduHubDataSet<DFVT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFVT"; } }

        internal DFVTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAMILY = new Lazy<Dictionary<string, IReadOnlyList<DFVT>>>(() => this.ToGroupedDictionary(i => i.FAMILY));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<DFVT>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_TID = new Lazy<Dictionary<int, DFVT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFVT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFVT" /> fields for each CSV column header</returns>
        protected override Action<DFVT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFVT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
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
                    case "GROUPING":
                        mapper[i] = (e, v) => e.GROUPING = v;
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SHORTCUT":
                        mapper[i] = (e, v) => e.SHORTCUT = v;
                        break;
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
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
        /// Merges <see cref="DFVT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFVT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFVT" /> items to added or update the base <see cref="DFVT" /> items</param>
        /// <returns>A merged list of <see cref="DFVT" /> items</returns>
        protected override List<DFVT> ApplyDeltaItems(List<DFVT> Items, List<DFVT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFVT deltaItem in DeltaItems)
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
                .OrderBy(i => i.FAMILY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFVT>>> Index_FAMILY;
        private Lazy<NullDictionary<string, IReadOnlyList<DFVT>>> Index_GST_TYPE;
        private Lazy<Dictionary<int, DFVT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <returns>List of related DFVT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <param name="Value">List of related DFVT entities</param>
        /// <returns>True if the list of related DFVT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<DFVT> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <returns>List of related DFVT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<DFVT> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <returns>List of related DFVT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <param name="Value">List of related DFVT entities</param>
        /// <returns>True if the list of related DFVT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<DFVT> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <returns>List of related DFVT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<DFVT> value;
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
        /// Find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <returns>Related DFVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFVT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <param name="Value">Related DFVT entity</param>
        /// <returns>True if the related DFVT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFVT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <returns>Related DFVT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFVT TryFindByTID(int TID)
        {
            DFVT value;
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
        /// Returns SQL which checks for the existence of a DFVT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DFVT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DFVT](
        [TID] int IDENTITY NOT NULL,
        [FAMILY] varchar(10) NOT NULL,
        [TRBATCH] int NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [TRAMT] money NULL,
        [TRDET] varchar(30) NULL,
        [TRNETT] money NULL,
        [TRGROSS] money NULL,
        [GST_AMOUNT] money NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RATE] float NULL,
        [GROUPING] varchar(2) NULL,
        [FROM_DATE] datetime NULL,
        [SHORTCUT] varchar(2) NULL,
        [APPEAL] varchar(10) NULL,
        [TRTYPE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DFVT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [DFVT_Index_FAMILY] ON [dbo].[DFVT]
    (
            [FAMILY] ASC
    );
    CREATE NONCLUSTERED INDEX [DFVT_Index_GST_TYPE] ON [dbo].[DFVT]
    (
            [GST_TYPE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DFVT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFVT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DFVTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFVTDataReader : IDataReader, IDataRecord
        {
            private List<DFVT> Items;
            private int CurrentIndex;
            private DFVT CurrentItem;

            public DFVTDataReader(List<DFVT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 20; } }
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
                    case 1: // FAMILY
                        return CurrentItem.FAMILY;
                    case 2: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 3: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 4: // TRXCODE
                        return CurrentItem.TRXCODE;
                    case 5: // TRAMT
                        return CurrentItem.TRAMT;
                    case 6: // TRDET
                        return CurrentItem.TRDET;
                    case 7: // TRNETT
                        return CurrentItem.TRNETT;
                    case 8: // TRGROSS
                        return CurrentItem.TRGROSS;
                    case 9: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT;
                    case 10: // GST_TYPE
                        return CurrentItem.GST_TYPE;
                    case 11: // GST_RATE
                        return CurrentItem.GST_RATE;
                    case 12: // GROUPING
                        return CurrentItem.GROUPING;
                    case 13: // FROM_DATE
                        return CurrentItem.FROM_DATE;
                    case 14: // SHORTCUT
                        return CurrentItem.SHORTCUT;
                    case 15: // APPEAL
                        return CurrentItem.APPEAL;
                    case 16: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 17: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 18: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 19: // LW_USER
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
                    case 3: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 4: // TRXCODE
                        return CurrentItem.TRXCODE == null;
                    case 5: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 6: // TRDET
                        return CurrentItem.TRDET == null;
                    case 7: // TRNETT
                        return CurrentItem.TRNETT == null;
                    case 8: // TRGROSS
                        return CurrentItem.TRGROSS == null;
                    case 9: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT == null;
                    case 10: // GST_TYPE
                        return CurrentItem.GST_TYPE == null;
                    case 11: // GST_RATE
                        return CurrentItem.GST_RATE == null;
                    case 12: // GROUPING
                        return CurrentItem.GROUPING == null;
                    case 13: // FROM_DATE
                        return CurrentItem.FROM_DATE == null;
                    case 14: // SHORTCUT
                        return CurrentItem.SHORTCUT == null;
                    case 15: // APPEAL
                        return CurrentItem.APPEAL == null;
                    case 16: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 17: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 18: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 19: // LW_USER
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
                    case 1: // FAMILY
                        return "FAMILY";
                    case 2: // TRBATCH
                        return "TRBATCH";
                    case 3: // TRXLEDGER
                        return "TRXLEDGER";
                    case 4: // TRXCODE
                        return "TRXCODE";
                    case 5: // TRAMT
                        return "TRAMT";
                    case 6: // TRDET
                        return "TRDET";
                    case 7: // TRNETT
                        return "TRNETT";
                    case 8: // TRGROSS
                        return "TRGROSS";
                    case 9: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 10: // GST_TYPE
                        return "GST_TYPE";
                    case 11: // GST_RATE
                        return "GST_RATE";
                    case 12: // GROUPING
                        return "GROUPING";
                    case 13: // FROM_DATE
                        return "FROM_DATE";
                    case 14: // SHORTCUT
                        return "SHORTCUT";
                    case 15: // APPEAL
                        return "APPEAL";
                    case 16: // TRTYPE
                        return "TRTYPE";
                    case 17: // LW_DATE
                        return "LW_DATE";
                    case 18: // LW_TIME
                        return "LW_TIME";
                    case 19: // LW_USER
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
                    case "FAMILY":
                        return 1;
                    case "TRBATCH":
                        return 2;
                    case "TRXLEDGER":
                        return 3;
                    case "TRXCODE":
                        return 4;
                    case "TRAMT":
                        return 5;
                    case "TRDET":
                        return 6;
                    case "TRNETT":
                        return 7;
                    case "TRGROSS":
                        return 8;
                    case "GST_AMOUNT":
                        return 9;
                    case "GST_TYPE":
                        return 10;
                    case "GST_RATE":
                        return 11;
                    case "GROUPING":
                        return 12;
                    case "FROM_DATE":
                        return 13;
                    case "SHORTCUT":
                        return 14;
                    case "APPEAL":
                        return 15;
                    case "TRTYPE":
                        return 16;
                    case "LW_DATE":
                        return 17;
                    case "LW_TIME":
                        return 18;
                    case "LW_USER":
                        return 19;
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
