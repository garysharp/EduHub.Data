using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMGROUPDataSet : EduHubDataSet<SMGROUP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMGROUP"; } }

        internal SMGROUPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GROUPKEY = new Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>>(() => this.ToGroupedDictionary(i => i.GROUPKEY));
            Index_GROUPKEY_ROOM = new Lazy<Dictionary<Tuple<string, string>, SMGROUP>>(() => this.ToDictionary(i => Tuple.Create(i.GROUPKEY, i.ROOM)));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SMGROUP>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_TID = new Lazy<Dictionary<int, SMGROUP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMGROUP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMGROUP" /> fields for each CSV column header</returns>
        protected override Action<SMGROUP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMGROUP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GROUPKEY":
                        mapper[i] = (e, v) => e.GROUPKEY = v;
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
        /// Merges <see cref="SMGROUP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SMGROUP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SMGROUP" /> items to added or update the base <see cref="SMGROUP" /> items</param>
        /// <returns>A merged list of <see cref="SMGROUP" /> items</returns>
        protected override List<SMGROUP> ApplyDeltaItems(List<SMGROUP> Items, List<SMGROUP> DeltaItems)
        {
            Dictionary<Tuple<string, string>, int> Index_GROUPKEY_ROOM = Items.ToIndexDictionary(i => Tuple.Create(i.GROUPKEY, i.ROOM));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SMGROUP deltaItem in DeltaItems)
            {
                int index;

                if (Index_GROUPKEY_ROOM.TryGetValue(Tuple.Create(deltaItem.GROUPKEY, deltaItem.ROOM), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.GROUPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>> Index_GROUPKEY;
        private Lazy<Dictionary<Tuple<string, string>, SMGROUP>> Index_GROUPKEY_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SMGROUP>>> Index_ROOM;
        private Lazy<Dictionary<int, SMGROUP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> FindByGROUPKEY(string GROUPKEY)
        {
            return Index_GROUPKEY.Value[GROUPKEY];
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="Value">List of related SMGROUP entities</param>
        /// <returns>True if the list of related SMGROUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPKEY(string GROUPKEY, out IReadOnlyList<SMGROUP> Value)
        {
            return Index_GROUPKEY.Value.TryGetValue(GROUPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> TryFindByGROUPKEY(string GROUPKEY)
        {
            IReadOnlyList<SMGROUP> value;
            if (Index_GROUPKEY.Value.TryGetValue(GROUPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP FindByGROUPKEY_ROOM(string GROUPKEY, string ROOM)
        {
            return Index_GROUPKEY_ROOM.Value[Tuple.Create(GROUPKEY, ROOM)];
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <param name="Value">Related SMGROUP entity</param>
        /// <returns>True if the related SMGROUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPKEY_ROOM(string GROUPKEY, string ROOM, out SMGROUP Value)
        {
            return Index_GROUPKEY_ROOM.Value.TryGetValue(Tuple.Create(GROUPKEY, ROOM), out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP TryFindByGROUPKEY_ROOM(string GROUPKEY, string ROOM)
        {
            SMGROUP value;
            if (Index_GROUPKEY_ROOM.Value.TryGetValue(Tuple.Create(GROUPKEY, ROOM), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <param name="Value">List of related SMGROUP entities</param>
        /// <returns>True if the list of related SMGROUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SMGROUP> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SMGROUP> value;
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
        /// Find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <param name="Value">Related SMGROUP entity</param>
        /// <returns>True if the related SMGROUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMGROUP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP TryFindByTID(int TID)
        {
            SMGROUP value;
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
        /// Returns SQL which checks for the existence of a SMGROUP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMGROUP](
        [TID] int IDENTITY NOT NULL,
        [GROUPKEY] varchar(4) NOT NULL,
        [ROOM] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMGROUP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SMGROUP_Index_GROUPKEY] ON [dbo].[SMGROUP]
    (
            [GROUPKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SMGROUP_Index_GROUPKEY_ROOM] ON [dbo].[SMGROUP]
    (
            [GROUPKEY] ASC,
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [SMGROUP_Index_ROOM] ON [dbo].[SMGROUP]
    (
            [ROOM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMGROUP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMGROUP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SMGROUPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMGROUPDataReader : IDataReader, IDataRecord
        {
            private List<SMGROUP> Items;
            private int CurrentIndex;
            private SMGROUP CurrentItem;

            public SMGROUPDataReader(List<SMGROUP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 1: // GROUPKEY
                        return CurrentItem.GROUPKEY;
                    case 2: // ROOM
                        return CurrentItem.ROOM;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ROOM
                        return CurrentItem.ROOM == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
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
                    case 1: // GROUPKEY
                        return "GROUPKEY";
                    case 2: // ROOM
                        return "ROOM";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
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
                    case "GROUPKEY":
                        return 1;
                    case "ROOM":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
