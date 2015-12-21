using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Grid Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEXDataSet : EduHubDataSet<TTEX>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEX"; } }

        internal TTEXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_EXAM_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTEX>>>(() => this.ToGroupedNullDictionary(i => i.EXAM_ROOM));
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEX>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEX>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEX" /> fields for each CSV column header</returns>
        protected override Action<TTEX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTES_TID":
                        mapper[i] = (e, v) => e.TTES_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_COL":
                        mapper[i] = (e, v) => e.EXAM_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_ROW":
                        mapper[i] = (e, v) => e.EXAM_FIX_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_COL":
                        mapper[i] = (e, v) => e.EXAM_FIX_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_ROOM":
                        mapper[i] = (e, v) => e.EXAM_ROOM = v;
                        break;
                    case "EXAM_DESCRIPTION":
                        mapper[i] = (e, v) => e.EXAM_DESCRIPTION = v;
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
        /// Merges <see cref="TTEX" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TTEX" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TTEX" /> items to added or update the base <see cref="TTEX" /> items</param>
        /// <returns>A merged list of <see cref="TTEX" /> items</returns>
        protected override List<TTEX> ApplyDeltaItems(List<TTEX> Items, List<TTEX> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TTEX deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TTEX>>> Index_EXAM_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<TTEX>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEX>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <returns>List of related TTEX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> FindByEXAM_ROOM(string EXAM_ROOM)
        {
            return Index_EXAM_ROOM.Value[EXAM_ROOM];
        }

        /// <summary>
        /// Attempt to find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <param name="Value">List of related TTEX entities</param>
        /// <returns>True if the list of related TTEX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXAM_ROOM(string EXAM_ROOM, out IReadOnlyList<TTEX> Value)
        {
            return Index_EXAM_ROOM.Value.TryGetValue(EXAM_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <returns>List of related TTEX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> TryFindByEXAM_ROOM(string EXAM_ROOM)
        {
            IReadOnlyList<TTEX> value;
            if (Index_EXAM_ROOM.Value.TryGetValue(EXAM_ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <returns>List of related TTEX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <param name="Value">List of related TTEX entities</param>
        /// <returns>True if the list of related TTEX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEX> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <returns>List of related TTEX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEX> value;
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
        /// Find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <returns>Related TTEX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEX FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <param name="Value">Related TTEX entity</param>
        /// <returns>True if the related TTEX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEX Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <returns>Related TTEX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEX TryFindByTID(int TID)
        {
            TTEX value;
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
        /// Returns SQL which checks for the existence of a TTEX table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEX]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEX](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTES_TID] int NULL,
        [EXAM_ROW] smallint NULL,
        [EXAM_COL] smallint NULL,
        [EXAM_FIX_ROW] smallint NULL,
        [EXAM_FIX_COL] smallint NULL,
        [EXAM_ROOM] varchar(4) NULL,
        [EXAM_DESCRIPTION] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEX_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TTEX_Index_EXAM_ROOM] ON [dbo].[TTEX]
    (
            [EXAM_ROOM] ASC
    );
    CREATE CLUSTERED INDEX [TTEX_Index_GKEY] ON [dbo].[TTEX]
    (
            [GKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEX data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TTEXDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEXDataReader : IDataReader, IDataRecord
        {
            private List<TTEX> Items;
            private int CurrentIndex;
            private TTEX CurrentItem;

            public TTEXDataReader(List<TTEX> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 12; } }
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
                    case 2: // TTES_TID
                        return CurrentItem.TTES_TID;
                    case 3: // EXAM_ROW
                        return CurrentItem.EXAM_ROW;
                    case 4: // EXAM_COL
                        return CurrentItem.EXAM_COL;
                    case 5: // EXAM_FIX_ROW
                        return CurrentItem.EXAM_FIX_ROW;
                    case 6: // EXAM_FIX_COL
                        return CurrentItem.EXAM_FIX_COL;
                    case 7: // EXAM_ROOM
                        return CurrentItem.EXAM_ROOM;
                    case 8: // EXAM_DESCRIPTION
                        return CurrentItem.EXAM_DESCRIPTION;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 11: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TTES_TID
                        return CurrentItem.TTES_TID == null;
                    case 3: // EXAM_ROW
                        return CurrentItem.EXAM_ROW == null;
                    case 4: // EXAM_COL
                        return CurrentItem.EXAM_COL == null;
                    case 5: // EXAM_FIX_ROW
                        return CurrentItem.EXAM_FIX_ROW == null;
                    case 6: // EXAM_FIX_COL
                        return CurrentItem.EXAM_FIX_COL == null;
                    case 7: // EXAM_ROOM
                        return CurrentItem.EXAM_ROOM == null;
                    case 8: // EXAM_DESCRIPTION
                        return CurrentItem.EXAM_DESCRIPTION == null;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 11: // LW_USER
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
                    case 2: // TTES_TID
                        return "TTES_TID";
                    case 3: // EXAM_ROW
                        return "EXAM_ROW";
                    case 4: // EXAM_COL
                        return "EXAM_COL";
                    case 5: // EXAM_FIX_ROW
                        return "EXAM_FIX_ROW";
                    case 6: // EXAM_FIX_COL
                        return "EXAM_FIX_COL";
                    case 7: // EXAM_ROOM
                        return "EXAM_ROOM";
                    case 8: // EXAM_DESCRIPTION
                        return "EXAM_DESCRIPTION";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
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
                    case "TTES_TID":
                        return 2;
                    case "EXAM_ROW":
                        return 3;
                    case "EXAM_COL":
                        return 4;
                    case "EXAM_FIX_ROW":
                        return 5;
                    case "EXAM_FIX_COL":
                        return 6;
                    case "EXAM_ROOM":
                        return 7;
                    case "EXAM_DESCRIPTION":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
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
