using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTBDataSet : EduHubDataSet<TCTB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTB"; } }

        internal TCTBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABSENCE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.ABSENCE_TYPE));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_TCTBKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTB>>>(() => this.ToGroupedDictionary(i => i.TCTBKEY));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TID = new Lazy<Dictionary<int, TCTB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTB" /> fields for each CSV column header</returns>
        protected override Action<TCTB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTBKEY":
                        mapper[i] = (e, v) => e.TCTBKEY = DateTime.Parse(v);
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TEACHER_AVAILABLE":
                        mapper[i] = (e, v) => e.TEACHER_AVAILABLE = v;
                        break;
                    case "ROOM_AVAILABLE":
                        mapper[i] = (e, v) => e.ROOM_AVAILABLE = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "COMMENT_A":
                        mapper[i] = (e, v) => e.COMMENT_A = v;
                        break;
                    case "ABSENCE_TYPE":
                        mapper[i] = (e, v) => e.ABSENCE_TYPE = v;
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
        /// Merges <see cref="TCTB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TCTB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TCTB" /> items to added or update the base <see cref="TCTB" /> items</param>
        /// <returns>A merged list of <see cref="TCTB" /> items</returns>
        protected override List<TCTB> ApplyDeltaItems(List<TCTB> Items, List<TCTB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TCTB deltaItem in DeltaItems)
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
                .OrderBy(i => i.TCTBKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_ABSENCE_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_SUBJ;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTB>>> Index_TCTBKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_TEACHER;
        private Lazy<Dictionary<int, TCTB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTB by ABSENCE_TYPE field
        /// </summary>
        /// <param name="ABSENCE_TYPE">ABSENCE_TYPE value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByABSENCE_TYPE(string ABSENCE_TYPE)
        {
            return Index_ABSENCE_TYPE.Value[ABSENCE_TYPE];
        }

        /// <summary>
        /// Attempt to find TCTB by ABSENCE_TYPE field
        /// </summary>
        /// <param name="ABSENCE_TYPE">ABSENCE_TYPE value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABSENCE_TYPE(string ABSENCE_TYPE, out IReadOnlyList<TCTB> Value)
        {
            return Index_ABSENCE_TYPE.Value.TryGetValue(ABSENCE_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by ABSENCE_TYPE field
        /// </summary>
        /// <param name="ABSENCE_TYPE">ABSENCE_TYPE value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByABSENCE_TYPE(string ABSENCE_TYPE)
        {
            IReadOnlyList<TCTB> value;
            if (Index_ABSENCE_TYPE.Value.TryGetValue(ABSENCE_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TCTB by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TCTB> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TCTB> value;
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
        /// Find TCTB by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TCTB by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TCTB> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TCTB> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by TCTBKEY field
        /// </summary>
        /// <param name="TCTBKEY">TCTBKEY value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByTCTBKEY(DateTime TCTBKEY)
        {
            return Index_TCTBKEY.Value[TCTBKEY];
        }

        /// <summary>
        /// Attempt to find TCTB by TCTBKEY field
        /// </summary>
        /// <param name="TCTBKEY">TCTBKEY value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTBKEY(DateTime TCTBKEY, out IReadOnlyList<TCTB> Value)
        {
            return Index_TCTBKEY.Value.TryGetValue(TCTBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by TCTBKEY field
        /// </summary>
        /// <param name="TCTBKEY">TCTBKEY value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByTCTBKEY(DateTime TCTBKEY)
        {
            IReadOnlyList<TCTB> value;
            if (Index_TCTBKEY.Value.TryGetValue(TCTBKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find TCTB by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<TCTB> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<TCTB> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTB</param>
        /// <returns>Related TCTB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTB</param>
        /// <param name="Value">Related TCTB entity</param>
        /// <returns>True if the related TCTB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTB</param>
        /// <returns>Related TCTB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTB TryFindByTID(int TID)
        {
            TCTB value;
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
        /// Returns SQL which checks for the existence of a TCTB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCTB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCTB](
        [TID] int IDENTITY NOT NULL,
        [TCTBKEY] datetime NOT NULL,
        [SUBJ] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TEACHER] varchar(4) NULL,
        [ROOM] varchar(4) NULL,
        [TEACHER_AVAILABLE] varchar(1) NULL,
        [ROOM_AVAILABLE] varchar(1) NULL,
        [TIME_FROM] datetime NULL,
        [TIME_TO] datetime NULL,
        [COMMENT_A] text NULL,
        [ABSENCE_TYPE] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCTB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TCTB_Index_ABSENCE_TYPE] ON [dbo].[TCTB]
    (
            [ABSENCE_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTB_Index_ROOM] ON [dbo].[TCTB]
    (
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTB_Index_SUBJ] ON [dbo].[TCTB]
    (
            [SUBJ] ASC
    );
    CREATE CLUSTERED INDEX [TCTB_Index_TCTBKEY] ON [dbo].[TCTB]
    (
            [TCTBKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTB_Index_TEACHER] ON [dbo].[TCTB]
    (
            [TEACHER] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TCTBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCTBDataReader : IDataReader, IDataRecord
        {
            private List<TCTB> Items;
            private int CurrentIndex;
            private TCTB CurrentItem;

            public TCTBDataReader(List<TCTB> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 15; } }
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
                    case 1: // TCTBKEY
                        return CurrentItem.TCTBKEY;
                    case 2: // SUBJ
                        return CurrentItem.SUBJ;
                    case 3: // CLASS
                        return CurrentItem.CLASS;
                    case 4: // TEACHER
                        return CurrentItem.TEACHER;
                    case 5: // ROOM
                        return CurrentItem.ROOM;
                    case 6: // TEACHER_AVAILABLE
                        return CurrentItem.TEACHER_AVAILABLE;
                    case 7: // ROOM_AVAILABLE
                        return CurrentItem.ROOM_AVAILABLE;
                    case 8: // TIME_FROM
                        return CurrentItem.TIME_FROM;
                    case 9: // TIME_TO
                        return CurrentItem.TIME_TO;
                    case 10: // COMMENT_A
                        return CurrentItem.COMMENT_A;
                    case 11: // ABSENCE_TYPE
                        return CurrentItem.ABSENCE_TYPE;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SUBJ
                        return CurrentItem.SUBJ == null;
                    case 3: // CLASS
                        return CurrentItem.CLASS == null;
                    case 4: // TEACHER
                        return CurrentItem.TEACHER == null;
                    case 5: // ROOM
                        return CurrentItem.ROOM == null;
                    case 6: // TEACHER_AVAILABLE
                        return CurrentItem.TEACHER_AVAILABLE == null;
                    case 7: // ROOM_AVAILABLE
                        return CurrentItem.ROOM_AVAILABLE == null;
                    case 8: // TIME_FROM
                        return CurrentItem.TIME_FROM == null;
                    case 9: // TIME_TO
                        return CurrentItem.TIME_TO == null;
                    case 10: // COMMENT_A
                        return CurrentItem.COMMENT_A == null;
                    case 11: // ABSENCE_TYPE
                        return CurrentItem.ABSENCE_TYPE == null;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 14: // LW_USER
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
                    case 1: // TCTBKEY
                        return "TCTBKEY";
                    case 2: // SUBJ
                        return "SUBJ";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // TEACHER
                        return "TEACHER";
                    case 5: // ROOM
                        return "ROOM";
                    case 6: // TEACHER_AVAILABLE
                        return "TEACHER_AVAILABLE";
                    case 7: // ROOM_AVAILABLE
                        return "ROOM_AVAILABLE";
                    case 8: // TIME_FROM
                        return "TIME_FROM";
                    case 9: // TIME_TO
                        return "TIME_TO";
                    case 10: // COMMENT_A
                        return "COMMENT_A";
                    case 11: // ABSENCE_TYPE
                        return "ABSENCE_TYPE";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
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
                    case "TCTBKEY":
                        return 1;
                    case "SUBJ":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "TEACHER":
                        return 4;
                    case "ROOM":
                        return 5;
                    case "TEACHER_AVAILABLE":
                        return 6;
                    case "ROOM_AVAILABLE":
                        return 7;
                    case "TIME_FROM":
                        return 8;
                    case "TIME_TO":
                        return 9;
                    case "COMMENT_A":
                        return 10;
                    case "ABSENCE_TYPE":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
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
