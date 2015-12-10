using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAQDataSet : DataSetBase<SFAQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFAQ"; } }

        internal SFAQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<SFAQ>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_SFAQKEY = new Lazy<Dictionary<string, IReadOnlyList<SFAQ>>>(() => this.ToGroupedDictionary(i => i.SFAQKEY));
            Index_TID = new Lazy<Dictionary<int, SFAQ>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFAQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFAQ" /> fields for each CSV column header</returns>
        protected override Action<SFAQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFAQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SFAQKEY":
                        mapper[i] = (e, v) => e.SFAQKEY = v;
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SFAQ" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SFAQ" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SFAQ" /> items to added or update the base <see cref="SFAQ" /> items</param>
        /// <returns>A merged list of <see cref="SFAQ" /> items</returns>
        protected override List<SFAQ> ApplyDeltaItems(List<SFAQ> Items, List<SFAQ> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SFAQ deltaItem in DeltaItems)
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
                .OrderBy(i => i.SFAQKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SFAQ>>> Index_QKEY;
        private Lazy<Dictionary<string, IReadOnlyList<SFAQ>>> Index_SFAQKEY;
        private Lazy<Dictionary<int, SFAQ>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <param name="Value">List of related SFAQ entities</param>
        /// <returns>True if the list of related SFAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<SFAQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<SFAQ> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> FindBySFAQKEY(string SFAQKEY)
        {
            return Index_SFAQKEY.Value[SFAQKEY];
        }

        /// <summary>
        /// Attempt to find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <param name="Value">List of related SFAQ entities</param>
        /// <returns>True if the list of related SFAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFAQKEY(string SFAQKEY, out IReadOnlyList<SFAQ> Value)
        {
            return Index_SFAQKEY.Value.TryGetValue(SFAQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> TryFindBySFAQKEY(string SFAQKEY)
        {
            IReadOnlyList<SFAQ> value;
            if (Index_SFAQKEY.Value.TryGetValue(SFAQKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <returns>Related SFAQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <param name="Value">Related SFAQ entity</param>
        /// <returns>True if the related SFAQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFAQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <returns>Related SFAQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAQ TryFindByTID(int TID)
        {
            SFAQ value;
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
        /// Returns SQL which checks for the existence of a SFAQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SFAQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SFAQ](
        [TID] int IDENTITY NOT NULL,
        [SFAQKEY] varchar(4) NOT NULL,
        [QKEY] varchar(8) NULL,
        [DAY_NUMBER] smallint NULL,
        [START_PERIOD] smallint NULL,
        [END_PERIOD] smallint NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SFAQ_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SFAQ_Index_QKEY] ON [dbo].[SFAQ]
    (
            [QKEY] ASC
    );
    CREATE CLUSTERED INDEX [SFAQ_Index_SFAQKEY] ON [dbo].[SFAQ]
    (
            [SFAQKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SFAQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFAQ data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SFAQDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SFAQDataReader : IDataReader, IDataRecord
        {
            private List<SFAQ> Items;
            private int CurrentIndex;
            private SFAQ CurrentItem;

            public SFAQDataReader(List<SFAQ> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 9; } }
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
                    case 1: // SFAQKEY
                        return CurrentItem.SFAQKEY;
                    case 2: // QKEY
                        return CurrentItem.QKEY;
                    case 3: // DAY_NUMBER
                        return CurrentItem.DAY_NUMBER;
                    case 4: // START_PERIOD
                        return CurrentItem.START_PERIOD;
                    case 5: // END_PERIOD
                        return CurrentItem.END_PERIOD;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // QKEY
                        return CurrentItem.QKEY == null;
                    case 3: // DAY_NUMBER
                        return CurrentItem.DAY_NUMBER == null;
                    case 4: // START_PERIOD
                        return CurrentItem.START_PERIOD == null;
                    case 5: // END_PERIOD
                        return CurrentItem.END_PERIOD == null;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 8: // LW_USER
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
                    case 1: // SFAQKEY
                        return "SFAQKEY";
                    case 2: // QKEY
                        return "QKEY";
                    case 3: // DAY_NUMBER
                        return "DAY_NUMBER";
                    case 4: // START_PERIOD
                        return "START_PERIOD";
                    case 5: // END_PERIOD
                        return "END_PERIOD";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_USER
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
                    case "SFAQKEY":
                        return 1;
                    case "QKEY":
                        return 2;
                    case "DAY_NUMBER":
                        return 3;
                    case "START_PERIOD":
                        return 4;
                    case "END_PERIOD":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_USER":
                        return 8;
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
