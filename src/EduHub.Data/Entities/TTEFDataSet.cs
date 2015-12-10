using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Staff Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEFDataSet : DataSetBase<TTEF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEF"; } }

        internal TTEFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, TTEF>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEF" /> fields for each CSV column header</returns>
        protected override Action<TTEF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEP_TID":
                        mapper[i] = (e, v) => e.TTEP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
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
        /// Merges <see cref="TTEF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TTEF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TTEF" /> items to added or update the base <see cref="TTEF" /> items</param>
        /// <returns>A merged list of <see cref="TTEF" /> items</returns>
        protected override List<TTEF> ApplyDeltaItems(List<TTEF> Items, List<TTEF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TTEF deltaItem in DeltaItems)
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
                .OrderBy(i => i.GKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<TTEF>>> Index_GKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEF>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEF>>> Index_STAFF;
        private Lazy<Dictionary<int, TTEF>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEF> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEF> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TTEF> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TTEF> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<TTEF> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<TTEF> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <returns>Related TTEF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <param name="Value">Related TTEF entity</param>
        /// <returns>True if the related TTEF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <returns>Related TTEF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEF TryFindByTID(int TID)
        {
            TTEF value;
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
        /// Returns SQL which checks for the existence of a TTEF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEF](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTEP_TID] int NULL,
        [TIME_START] datetime NULL,
        [TIME_END] datetime NULL,
        [STAFF] varchar(4) NULL,
        [ROOM] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTEF_Index_GKEY] ON [dbo].[TTEF]
    (
            [GKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TTEF_Index_ROOM] ON [dbo].[TTEF]
    (
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TTEF_Index_STAFF] ON [dbo].[TTEF]
    (
            [STAFF] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TTEFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEFDataReader : IDataReader, IDataRecord
        {
            private List<TTEF> Items;
            private int CurrentIndex;
            private TTEF CurrentItem;

            public TTEFDataReader(List<TTEF> Items)
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
                    case 1: // GKEY
                        return CurrentItem.GKEY;
                    case 2: // TTEP_TID
                        return CurrentItem.TTEP_TID;
                    case 3: // TIME_START
                        return CurrentItem.TIME_START;
                    case 4: // TIME_END
                        return CurrentItem.TIME_END;
                    case 5: // STAFF
                        return CurrentItem.STAFF;
                    case 6: // ROOM
                        return CurrentItem.ROOM;
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
                    case 2: // TTEP_TID
                        return CurrentItem.TTEP_TID == null;
                    case 3: // TIME_START
                        return CurrentItem.TIME_START == null;
                    case 4: // TIME_END
                        return CurrentItem.TIME_END == null;
                    case 5: // STAFF
                        return CurrentItem.STAFF == null;
                    case 6: // ROOM
                        return CurrentItem.ROOM == null;
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
                    case 1: // GKEY
                        return "GKEY";
                    case 2: // TTEP_TID
                        return "TTEP_TID";
                    case 3: // TIME_START
                        return "TIME_START";
                    case 4: // TIME_END
                        return "TIME_END";
                    case 5: // STAFF
                        return "STAFF";
                    case 6: // ROOM
                        return "ROOM";
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
                    case "GKEY":
                        return 1;
                    case "TTEP_TID":
                        return 2;
                    case "TIME_START":
                        return 3;
                    case "TIME_END":
                        return 4;
                    case "STAFF":
                        return 5;
                    case "ROOM":
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
