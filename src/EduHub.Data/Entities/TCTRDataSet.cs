using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTRDataSet : DataSetBase<TCTR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTR"; } }

        internal TCTRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTR>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_TCTRKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>>(() => this.ToGroupedDictionary(i => i.TCTRKEY));
            Index_TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TCTR>>>(() => this.ToGroupedNullDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, TCTR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTR" /> fields for each CSV column header</returns>
        protected override Action<TCTR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTRKEY":
                        mapper[i] = (e, v) => e.TCTRKEY = DateTime.Parse(v);
                        break;
                    case "TCTQ_TID":
                        mapper[i] = (e, v) => e.TCTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "COMMENT_R":
                        mapper[i] = (e, v) => e.COMMENT_R = v;
                        break;
                    case "COUNT_EXTRAS":
                        mapper[i] = (e, v) => e.COUNT_EXTRAS = v;
                        break;
                    case "EXTRAS_VALUE":
                        mapper[i] = (e, v) => e.EXTRAS_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABSENTEE_TID":
                        mapper[i] = (e, v) => e.ABSENTEE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER_CLASH":
                        mapper[i] = (e, v) => e.TEACHER_CLASH = v;
                        break;
                    case "ROOM_CLASH":
                        mapper[i] = (e, v) => e.ROOM_CLASH = v;
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
        /// Merges <see cref="TCTR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TCTR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TCTR" /> items to added or update the base <see cref="TCTR" /> items</param>
        /// <returns>A merged list of <see cref="TCTR" /> items</returns>
        protected override List<TCTR> ApplyDeltaItems(List<TCTR> Items, List<TCTR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TCTR deltaItem in DeltaItems)
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
                .OrderBy(i => i.TCTRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TCTR>>> Index_ROOM;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>> Index_TCTRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTR>>> Index_TEACH;
        private Lazy<Dictionary<int, TCTR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TCTR> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TCTR> value;
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
        /// Find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByTCTRKEY(DateTime TCTRKEY)
        {
            return Index_TCTRKEY.Value[TCTRKEY];
        }

        /// <summary>
        /// Attempt to find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTRKEY(DateTime TCTRKEY, out IReadOnlyList<TCTR> Value)
        {
            return Index_TCTRKEY.Value.TryGetValue(TCTRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByTCTRKEY(DateTime TCTRKEY)
        {
            IReadOnlyList<TCTR> value;
            if (Index_TCTRKEY.Value.TryGetValue(TCTRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<TCTR> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<TCTR> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <returns>Related TCTR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <param name="Value">Related TCTR entity</param>
        /// <returns>True if the related TCTR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <returns>Related TCTR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTR TryFindByTID(int TID)
        {
            TCTR value;
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
        /// Returns SQL which checks for the existence of a TCTR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCTR](
        [TID] int IDENTITY NOT NULL,
        [TCTRKEY] datetime NOT NULL,
        [TCTQ_TID] int NULL,
        [TEACH] varchar(4) NULL,
        [ROOM] varchar(4) NULL,
        [COMMENT_R] text NULL,
        [COUNT_EXTRAS] varchar(1) NULL,
        [EXTRAS_VALUE] float NULL,
        [ABSENTEE_TID] int NULL,
        [TEACHER_CLASH] varchar(1) NULL,
        [ROOM_CLASH] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCTR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TCTR_Index_ROOM] ON [dbo].[TCTR]
    (
            [ROOM] ASC
    );
    CREATE CLUSTERED INDEX [TCTR_Index_TCTRKEY] ON [dbo].[TCTR]
    (
            [TCTRKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTR_Index_TEACH] ON [dbo].[TCTR]
    (
            [TEACH] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TCTRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCTRDataReader : IDataReader, IDataRecord
        {
            private List<TCTR> Items;
            private int CurrentIndex;
            private TCTR CurrentItem;

            public TCTRDataReader(List<TCTR> Items)
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
                    case 1: // TCTRKEY
                        return CurrentItem.TCTRKEY;
                    case 2: // TCTQ_TID
                        return CurrentItem.TCTQ_TID;
                    case 3: // TEACH
                        return CurrentItem.TEACH;
                    case 4: // ROOM
                        return CurrentItem.ROOM;
                    case 5: // COMMENT_R
                        return CurrentItem.COMMENT_R;
                    case 6: // COUNT_EXTRAS
                        return CurrentItem.COUNT_EXTRAS;
                    case 7: // EXTRAS_VALUE
                        return CurrentItem.EXTRAS_VALUE;
                    case 8: // ABSENTEE_TID
                        return CurrentItem.ABSENTEE_TID;
                    case 9: // TEACHER_CLASH
                        return CurrentItem.TEACHER_CLASH;
                    case 10: // ROOM_CLASH
                        return CurrentItem.ROOM_CLASH;
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
                    case 2: // TCTQ_TID
                        return CurrentItem.TCTQ_TID == null;
                    case 3: // TEACH
                        return CurrentItem.TEACH == null;
                    case 4: // ROOM
                        return CurrentItem.ROOM == null;
                    case 5: // COMMENT_R
                        return CurrentItem.COMMENT_R == null;
                    case 6: // COUNT_EXTRAS
                        return CurrentItem.COUNT_EXTRAS == null;
                    case 7: // EXTRAS_VALUE
                        return CurrentItem.EXTRAS_VALUE == null;
                    case 8: // ABSENTEE_TID
                        return CurrentItem.ABSENTEE_TID == null;
                    case 9: // TEACHER_CLASH
                        return CurrentItem.TEACHER_CLASH == null;
                    case 10: // ROOM_CLASH
                        return CurrentItem.ROOM_CLASH == null;
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
                    case 1: // TCTRKEY
                        return "TCTRKEY";
                    case 2: // TCTQ_TID
                        return "TCTQ_TID";
                    case 3: // TEACH
                        return "TEACH";
                    case 4: // ROOM
                        return "ROOM";
                    case 5: // COMMENT_R
                        return "COMMENT_R";
                    case 6: // COUNT_EXTRAS
                        return "COUNT_EXTRAS";
                    case 7: // EXTRAS_VALUE
                        return "EXTRAS_VALUE";
                    case 8: // ABSENTEE_TID
                        return "ABSENTEE_TID";
                    case 9: // TEACHER_CLASH
                        return "TEACHER_CLASH";
                    case 10: // ROOM_CLASH
                        return "ROOM_CLASH";
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
                    case "TCTRKEY":
                        return 1;
                    case "TCTQ_TID":
                        return 2;
                    case "TEACH":
                        return 3;
                    case "ROOM":
                        return 4;
                    case "COMMENT_R":
                        return 5;
                    case "COUNT_EXTRAS":
                        return 6;
                    case "EXTRAS_VALUE":
                        return 7;
                    case "ABSENTEE_TID":
                        return 8;
                    case "TEACHER_CLASH":
                        return 9;
                    case "ROOM_CLASH":
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
