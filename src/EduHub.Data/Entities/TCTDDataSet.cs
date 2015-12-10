using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Period Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTDDataSet : DataSetBase<TCTD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTD"; } }

        internal TCTDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<TCTD>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_TCTDKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>>(() => this.ToGroupedDictionary(i => i.TCTDKEY));
            Index_TID = new Lazy<Dictionary<int, TCTD>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTD" /> fields for each CSV column header</returns>
        protected override Action<TCTD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTDKEY":
                        mapper[i] = (e, v) => e.TCTDKEY = DateTime.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "TIME_INDEX":
                        mapper[i] = (e, v) => e.TIME_INDEX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TYPE":
                        mapper[i] = (e, v) => e.TIME_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_NAME":
                        mapper[i] = (e, v) => e.TIME_NAME = v;
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
        /// Merges <see cref="TCTD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TCTD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TCTD" /> items to added or update the base <see cref="TCTD" /> items</param>
        /// <returns>A merged list of <see cref="TCTD" /> items</returns>
        protected override List<TCTD> ApplyDeltaItems(List<TCTD> Items, List<TCTD> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TCTD deltaItem in DeltaItems)
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
                .OrderBy(i => i.TCTDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TCTD>>> Index_QKEY;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>> Index_TCTDKEY;
        private Lazy<Dictionary<int, TCTD>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<TCTD> value;
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
        /// Find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByTCTDKEY(DateTime TCTDKEY)
        {
            return Index_TCTDKEY.Value[TCTDKEY];
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTDKEY(DateTime TCTDKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_TCTDKEY.Value.TryGetValue(TCTDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByTCTDKEY(DateTime TCTDKEY)
        {
            IReadOnlyList<TCTD> value;
            if (Index_TCTDKEY.Value.TryGetValue(TCTDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <returns>Related TCTD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <param name="Value">Related TCTD entity</param>
        /// <returns>True if the related TCTD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <returns>Related TCTD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTD TryFindByTID(int TID)
        {
            TCTD value;
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
        /// Returns SQL which checks for the existence of a TCTD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCTD](
        [TID] int IDENTITY NOT NULL,
        [TCTDKEY] datetime NOT NULL,
        [QKEY] varchar(8) NULL,
        [TIME_INDEX] smallint NULL,
        [TIME_START] datetime NULL,
        [TIME_END] datetime NULL,
        [TIME_TYPE] smallint NULL,
        [TIME_NAME] varchar(20) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCTD_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TCTD_Index_QKEY] ON [dbo].[TCTD]
    (
            [QKEY] ASC
    );
    CREATE CLUSTERED INDEX [TCTD_Index_TCTDKEY] ON [dbo].[TCTD]
    (
            [TCTDKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TCTDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCTDDataReader : IDataReader, IDataRecord
        {
            private List<TCTD> Items;
            private int CurrentIndex;
            private TCTD CurrentItem;

            public TCTDDataReader(List<TCTD> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 1: // TCTDKEY
                        return CurrentItem.TCTDKEY;
                    case 2: // QKEY
                        return CurrentItem.QKEY;
                    case 3: // TIME_INDEX
                        return CurrentItem.TIME_INDEX;
                    case 4: // TIME_START
                        return CurrentItem.TIME_START;
                    case 5: // TIME_END
                        return CurrentItem.TIME_END;
                    case 6: // TIME_TYPE
                        return CurrentItem.TIME_TYPE;
                    case 7: // TIME_NAME
                        return CurrentItem.TIME_NAME;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
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
                    case 3: // TIME_INDEX
                        return CurrentItem.TIME_INDEX == null;
                    case 4: // TIME_START
                        return CurrentItem.TIME_START == null;
                    case 5: // TIME_END
                        return CurrentItem.TIME_END == null;
                    case 6: // TIME_TYPE
                        return CurrentItem.TIME_TYPE == null;
                    case 7: // TIME_NAME
                        return CurrentItem.TIME_NAME == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
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
                    case 1: // TCTDKEY
                        return "TCTDKEY";
                    case 2: // QKEY
                        return "QKEY";
                    case 3: // TIME_INDEX
                        return "TIME_INDEX";
                    case 4: // TIME_START
                        return "TIME_START";
                    case 5: // TIME_END
                        return "TIME_END";
                    case 6: // TIME_TYPE
                        return "TIME_TYPE";
                    case 7: // TIME_NAME
                        return "TIME_NAME";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
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
                    case "TCTDKEY":
                        return 1;
                    case "QKEY":
                        return 2;
                    case "TIME_INDEX":
                        return 3;
                    case "TIME_START":
                        return 4;
                    case "TIME_END":
                        return 5;
                    case "TIME_TYPE":
                        return 6;
                    case "TIME_NAME":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
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
