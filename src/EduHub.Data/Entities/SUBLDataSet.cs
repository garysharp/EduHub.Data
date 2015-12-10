using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Book List Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUBLDataSet : DataSetBase<SUBL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SUBL"; } }

        internal SUBLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BLKEY = new Lazy<Dictionary<string, IReadOnlyList<SUBL>>>(() => this.ToGroupedDictionary(i => i.BLKEY));
            Index_BOOK = new Lazy<NullDictionary<string, IReadOnlyList<SUBL>>>(() => this.ToGroupedNullDictionary(i => i.BOOK));
            Index_TID = new Lazy<Dictionary<int, SUBL>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SUBL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SUBL" /> fields for each CSV column header</returns>
        protected override Action<SUBL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SUBL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BLKEY":
                        mapper[i] = (e, v) => e.BLKEY = v;
                        break;
                    case "BOOK":
                        mapper[i] = (e, v) => e.BOOK = v;
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "TAG":
                        mapper[i] = (e, v) => e.TAG = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_REQUIRED":
                        mapper[i] = (e, v) => e.NUMBER_REQUIRED = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SUBL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SUBL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SUBL" /> items to added or update the base <see cref="SUBL" /> items</param>
        /// <returns>A merged list of <see cref="SUBL" /> items</returns>
        protected override List<SUBL> ApplyDeltaItems(List<SUBL> Items, List<SUBL> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SUBL deltaItem in DeltaItems)
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
                .OrderBy(i => i.BLKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SUBL>>> Index_BLKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SUBL>>> Index_BOOK;
        private Lazy<Dictionary<int, SUBL>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <returns>List of related SUBL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> FindByBLKEY(string BLKEY)
        {
            return Index_BLKEY.Value[BLKEY];
        }

        /// <summary>
        /// Attempt to find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <param name="Value">List of related SUBL entities</param>
        /// <returns>True if the list of related SUBL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBLKEY(string BLKEY, out IReadOnlyList<SUBL> Value)
        {
            return Index_BLKEY.Value.TryGetValue(BLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <returns>List of related SUBL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> TryFindByBLKEY(string BLKEY)
        {
            IReadOnlyList<SUBL> value;
            if (Index_BLKEY.Value.TryGetValue(BLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <returns>List of related SUBL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> FindByBOOK(string BOOK)
        {
            return Index_BOOK.Value[BOOK];
        }

        /// <summary>
        /// Attempt to find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <param name="Value">List of related SUBL entities</param>
        /// <returns>True if the list of related SUBL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBOOK(string BOOK, out IReadOnlyList<SUBL> Value)
        {
            return Index_BOOK.Value.TryGetValue(BOOK, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <returns>List of related SUBL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> TryFindByBOOK(string BOOK)
        {
            IReadOnlyList<SUBL> value;
            if (Index_BOOK.Value.TryGetValue(BOOK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <returns>Related SUBL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUBL FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <param name="Value">Related SUBL entity</param>
        /// <returns>True if the related SUBL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SUBL Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <returns>Related SUBL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUBL TryFindByTID(int TID)
        {
            SUBL value;
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
        /// Returns SQL which checks for the existence of a SUBL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SUBL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SUBL](
        [TID] int IDENTITY NOT NULL,
        [BLKEY] varchar(5) NOT NULL,
        [BOOK] varchar(13) NULL,
        [TTPERIOD] varchar(6) NULL,
        [TAG] varchar(4) NULL,
        [SEMESTER] smallint NULL,
        [NUMBER_REQUIRED] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SUBL_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SUBL_Index_BLKEY] ON [dbo].[SUBL]
    (
            [BLKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SUBL_Index_BOOK] ON [dbo].[SUBL]
    (
            [BOOK] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SUBL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SUBL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SUBLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SUBLDataReader : IDataReader, IDataRecord
        {
            private List<SUBL> Items;
            private int CurrentIndex;
            private SUBL CurrentItem;

            public SUBLDataReader(List<SUBL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 10; } }
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
                    case 1: // BLKEY
                        return CurrentItem.BLKEY;
                    case 2: // BOOK
                        return CurrentItem.BOOK;
                    case 3: // TTPERIOD
                        return CurrentItem.TTPERIOD;
                    case 4: // TAG
                        return CurrentItem.TAG;
                    case 5: // SEMESTER
                        return CurrentItem.SEMESTER;
                    case 6: // NUMBER_REQUIRED
                        return CurrentItem.NUMBER_REQUIRED;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 9: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // BOOK
                        return CurrentItem.BOOK == null;
                    case 3: // TTPERIOD
                        return CurrentItem.TTPERIOD == null;
                    case 4: // TAG
                        return CurrentItem.TAG == null;
                    case 5: // SEMESTER
                        return CurrentItem.SEMESTER == null;
                    case 6: // NUMBER_REQUIRED
                        return CurrentItem.NUMBER_REQUIRED == null;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 9: // LW_USER
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
                    case 1: // BLKEY
                        return "BLKEY";
                    case 2: // BOOK
                        return "BOOK";
                    case 3: // TTPERIOD
                        return "TTPERIOD";
                    case 4: // TAG
                        return "TAG";
                    case 5: // SEMESTER
                        return "SEMESTER";
                    case 6: // NUMBER_REQUIRED
                        return "NUMBER_REQUIRED";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
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
                    case "BLKEY":
                        return 1;
                    case "BOOK":
                        return 2;
                    case "TTPERIOD":
                        return 3;
                    case "TAG":
                        return 4;
                    case "SEMESTER":
                        return 5;
                    case "NUMBER_REQUIRED":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
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
