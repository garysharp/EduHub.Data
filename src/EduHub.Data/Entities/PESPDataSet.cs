using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super Payment Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PESPDataSet : EduHubDataSet<PESP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PESP"; } }

        internal PESPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PESP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PESP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESP" /> fields for each CSV column header</returns>
        protected override Action<PESP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PESP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYMENT_AMOUNT":
                        mapper[i] = (e, v) => e.PAYMENT_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FROM_DATE":
                        mapper[i] = (e, v) => e.SUPER_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_TO_DATE":
                        mapper[i] = (e, v) => e.SUPER_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PROCESS_DATE":
                        mapper[i] = (e, v) => e.PROCESS_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DATE_ADVISED":
                        mapper[i] = (e, v) => e.DATE_ADVISED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="PESP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PESP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PESP" /> items to added or update the base <see cref="PESP" /> items</param>
        /// <returns>A merged list of <see cref="PESP" /> items</returns>
        protected override List<PESP> ApplyDeltaItems(List<PESP> Items, List<PESP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PESP deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PESP>>> Index_CODE;
        private Lazy<Dictionary<int, PESP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <returns>List of related PESP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESP> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <param name="Value">List of related PESP entities</param>
        /// <returns>True if the list of related PESP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PESP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <returns>List of related PESP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESP> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PESP> value;
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
        /// Find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <returns>Related PESP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <param name="Value">Related PESP entity</param>
        /// <returns>True if the related PESP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PESP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <returns>Related PESP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESP TryFindByTID(int TID)
        {
            PESP value;
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
        /// Returns SQL which checks for the existence of a PESP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PESP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PESP](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRTYPE] varchar(1) NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [PAYMENT_DATE] datetime NULL,
        [PAYMENT_AMOUNT] money NULL,
        [SUPER_FROM_DATE] datetime NULL,
        [SUPER_TO_DATE] datetime NULL,
        [PROCESS_DATE] datetime NULL,
        [DATE_ADVISED] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PESP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PESP_Index_CODE] ON [dbo].[PESP]
    (
            [CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PESP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PESP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PESPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PESPDataReader : IDataReader, IDataRecord
        {
            private List<PESP> Items;
            private int CurrentIndex;
            private PESP CurrentItem;

            public PESPDataReader(List<PESP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 14; } }
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
                    case 2: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 3: // SUPER_FUND
                        return CurrentItem.SUPER_FUND;
                    case 4: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER;
                    case 5: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE;
                    case 6: // PAYMENT_AMOUNT
                        return CurrentItem.PAYMENT_AMOUNT;
                    case 7: // SUPER_FROM_DATE
                        return CurrentItem.SUPER_FROM_DATE;
                    case 8: // SUPER_TO_DATE
                        return CurrentItem.SUPER_TO_DATE;
                    case 9: // PROCESS_DATE
                        return CurrentItem.PROCESS_DATE;
                    case 10: // DATE_ADVISED
                        return CurrentItem.DATE_ADVISED;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 3: // SUPER_FUND
                        return CurrentItem.SUPER_FUND == null;
                    case 4: // SUPER_MEMBER
                        return CurrentItem.SUPER_MEMBER == null;
                    case 5: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE == null;
                    case 6: // PAYMENT_AMOUNT
                        return CurrentItem.PAYMENT_AMOUNT == null;
                    case 7: // SUPER_FROM_DATE
                        return CurrentItem.SUPER_FROM_DATE == null;
                    case 8: // SUPER_TO_DATE
                        return CurrentItem.SUPER_TO_DATE == null;
                    case 9: // PROCESS_DATE
                        return CurrentItem.PROCESS_DATE == null;
                    case 10: // DATE_ADVISED
                        return CurrentItem.DATE_ADVISED == null;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 13: // LW_USER
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
                    case 2: // TRTYPE
                        return "TRTYPE";
                    case 3: // SUPER_FUND
                        return "SUPER_FUND";
                    case 4: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 5: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 6: // PAYMENT_AMOUNT
                        return "PAYMENT_AMOUNT";
                    case 7: // SUPER_FROM_DATE
                        return "SUPER_FROM_DATE";
                    case 8: // SUPER_TO_DATE
                        return "SUPER_TO_DATE";
                    case 9: // PROCESS_DATE
                        return "PROCESS_DATE";
                    case 10: // DATE_ADVISED
                        return "DATE_ADVISED";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
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
                    case "TRTYPE":
                        return 2;
                    case "SUPER_FUND":
                        return 3;
                    case "SUPER_MEMBER":
                        return 4;
                    case "PAYMENT_DATE":
                        return 5;
                    case "PAYMENT_AMOUNT":
                        return 6;
                    case "SUPER_FROM_DATE":
                        return 7;
                    case "SUPER_TO_DATE":
                        return 8;
                    case "PROCESS_DATE":
                        return 9;
                    case "DATE_ADVISED":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
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
