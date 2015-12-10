using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Methods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPMDataSet : DataSetBase<PEPM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPM"; } }

        internal PEPMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<PEPM>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPM>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEPM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPM" /> fields for each CSV column header</returns>
        protected override Action<PEPM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "PAYMODE":
                        mapper[i] = (e, v) => e.PAYMODE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CHQ_NO":
                        mapper[i] = (e, v) => e.CHQ_NO = v;
                        break;
                    case "DAMOUNT":
                        mapper[i] = (e, v) => e.DAMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EFT_CREATED":
                        mapper[i] = (e, v) => e.EFT_CREATED = v;
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
        /// Merges <see cref="PEPM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPM" /> items to added or update the base <see cref="PEPM" /> items</param>
        /// <returns>A merged list of <see cref="PEPM" /> items</returns>
        protected override List<PEPM> ApplyDeltaItems(List<PEPM> Items, List<PEPM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPM deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PEPM>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<PEPM>>> Index_CODE;
        private Lazy<Dictionary<int, PEPM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <returns>List of related PEPM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <param name="Value">List of related PEPM entities</param>
        /// <returns>True if the list of related PEPM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<PEPM> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <returns>List of related PEPM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> TryFindByBSB(string BSB)
        {
            IReadOnlyList<PEPM> value;
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
        /// Find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <returns>List of related PEPM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <param name="Value">List of related PEPM entities</param>
        /// <returns>True if the list of related PEPM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPM> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <returns>List of related PEPM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPM> value;
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
        /// Find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <returns>Related PEPM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <param name="Value">Related PEPM entity</param>
        /// <returns>True if the related PEPM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <returns>Related PEPM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPM TryFindByTID(int TID)
        {
            PEPM value;
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
        /// Returns SQL which checks for the existence of a PEPM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPM](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [NAME] varchar(30) NULL,
        [PAYMODE] varchar(2) NULL,
        [REFERENCE_NO] varchar(20) NULL,
        [CHQ_NO] varchar(10) NULL,
        [DAMOUNT] money NULL,
        [BANK] varchar(12) NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [AMOUNT] money NULL,
        [FLAG] varchar(1) NULL,
        [TRBATCH] int NULL,
        [EFT_CREATED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PEPM_Index_BSB] ON [dbo].[PEPM]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [PEPM_Index_CODE] ON [dbo].[PEPM]
    (
            [CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEPMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPMDataReader : IDataReader, IDataRecord
        {
            private List<PEPM> Items;
            private int CurrentIndex;
            private PEPM CurrentItem;

            public PEPMDataReader(List<PEPM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 17; } }
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
                    case 2: // NAME
                        return CurrentItem.NAME;
                    case 3: // PAYMODE
                        return CurrentItem.PAYMODE;
                    case 4: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO;
                    case 5: // CHQ_NO
                        return CurrentItem.CHQ_NO;
                    case 6: // DAMOUNT
                        return CurrentItem.DAMOUNT;
                    case 7: // BANK
                        return CurrentItem.BANK;
                    case 8: // BSB
                        return CurrentItem.BSB;
                    case 9: // ACCOUNT_NO
                        return CurrentItem.ACCOUNT_NO;
                    case 10: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 11: // FLAG
                        return CurrentItem.FLAG;
                    case 12: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 13: // EFT_CREATED
                        return CurrentItem.EFT_CREATED;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // NAME
                        return CurrentItem.NAME == null;
                    case 3: // PAYMODE
                        return CurrentItem.PAYMODE == null;
                    case 4: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO == null;
                    case 5: // CHQ_NO
                        return CurrentItem.CHQ_NO == null;
                    case 6: // DAMOUNT
                        return CurrentItem.DAMOUNT == null;
                    case 7: // BANK
                        return CurrentItem.BANK == null;
                    case 8: // BSB
                        return CurrentItem.BSB == null;
                    case 9: // ACCOUNT_NO
                        return CurrentItem.ACCOUNT_NO == null;
                    case 10: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 11: // FLAG
                        return CurrentItem.FLAG == null;
                    case 12: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 13: // EFT_CREATED
                        return CurrentItem.EFT_CREATED == null;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 16: // LW_USER
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
                    case 2: // NAME
                        return "NAME";
                    case 3: // PAYMODE
                        return "PAYMODE";
                    case 4: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 5: // CHQ_NO
                        return "CHQ_NO";
                    case 6: // DAMOUNT
                        return "DAMOUNT";
                    case 7: // BANK
                        return "BANK";
                    case 8: // BSB
                        return "BSB";
                    case 9: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 10: // AMOUNT
                        return "AMOUNT";
                    case 11: // FLAG
                        return "FLAG";
                    case 12: // TRBATCH
                        return "TRBATCH";
                    case 13: // EFT_CREATED
                        return "EFT_CREATED";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
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
                    case "NAME":
                        return 2;
                    case "PAYMODE":
                        return 3;
                    case "REFERENCE_NO":
                        return 4;
                    case "CHQ_NO":
                        return 5;
                    case "DAMOUNT":
                        return 6;
                    case "BANK":
                        return 7;
                    case "BSB":
                        return 8;
                    case "ACCOUNT_NO":
                        return 9;
                    case "AMOUNT":
                        return 10;
                    case "FLAG":
                        return 11;
                    case "TRBATCH":
                        return 12;
                    case "EFT_CREATED":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
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
