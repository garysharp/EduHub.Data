using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Meetings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCAMDataSet : EduHubDataSet<SCAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCAM"; } }

        internal SCAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_MEETING_LOCATION = new Lazy<NullDictionary<int?, IReadOnlyList<SCAM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_LOCATION));
            Index_MEETING_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SCAM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_ROOM));
            Index_SCAMKEY = new Lazy<Dictionary<string, IReadOnlyList<SCAM>>>(() => this.ToGroupedDictionary(i => i.SCAMKEY));
            Index_SCAMKEY_MEETING_DATE_MEETING_TIME = new Lazy<Dictionary<Tuple<string, DateTime?, short?>, SCAM>>(() => this.ToDictionary(i => Tuple.Create(i.SCAMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            Index_TID = new Lazy<Dictionary<int, SCAM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCAM" /> fields for each CSV column header</returns>
        protected override Action<SCAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SCAMKEY":
                        mapper[i] = (e, v) => e.SCAMKEY = v;
                        break;
                    case "MEETING_DATE":
                        mapper[i] = (e, v) => e.MEETING_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MEETING_TIME":
                        mapper[i] = (e, v) => e.MEETING_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MEETING_PURPOSE":
                        mapper[i] = (e, v) => e.MEETING_PURPOSE = v;
                        break;
                    case "MEETING_LOCATION":
                        mapper[i] = (e, v) => e.MEETING_LOCATION = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEETING_ROOM":
                        mapper[i] = (e, v) => e.MEETING_ROOM = v;
                        break;
                    case "MINUTES_MEMO":
                        mapper[i] = (e, v) => e.MINUTES_MEMO = v;
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
        /// Merges <see cref="SCAM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCAM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCAM" /> items to added or update the base <see cref="SCAM" /> items</param>
        /// <returns>A merged list of <see cref="SCAM" /> items</returns>
        protected override List<SCAM> ApplyDeltaItems(List<SCAM> Items, List<SCAM> DeltaItems)
        {
            Dictionary<Tuple<string, DateTime?, short?>, int> Index_SCAMKEY_MEETING_DATE_MEETING_TIME = Items.ToIndexDictionary(i => Tuple.Create(i.SCAMKEY, i.MEETING_DATE, i.MEETING_TIME));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCAM deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME.TryGetValue(Tuple.Create(deltaItem.SCAMKEY, deltaItem.MEETING_DATE, deltaItem.MEETING_TIME), out index))
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
                .OrderBy(i => i.SCAMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SCAM>>> Index_MEETING_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<SCAM>>> Index_MEETING_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<SCAM>>> Index_SCAMKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?, short?>, SCAM>> Index_SCAMKEY_MEETING_DATE_MEETING_TIME;
        private Lazy<Dictionary<int, SCAM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindByMEETING_LOCATION(int? MEETING_LOCATION)
        {
            return Index_MEETING_LOCATION.Value[MEETING_LOCATION];
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_LOCATION(int? MEETING_LOCATION, out IReadOnlyList<SCAM> Value)
        {
            return Index_MEETING_LOCATION.Value.TryGetValue(MEETING_LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindByMEETING_LOCATION(int? MEETING_LOCATION)
        {
            IReadOnlyList<SCAM> value;
            if (Index_MEETING_LOCATION.Value.TryGetValue(MEETING_LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindByMEETING_ROOM(string MEETING_ROOM)
        {
            return Index_MEETING_ROOM.Value[MEETING_ROOM];
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_ROOM(string MEETING_ROOM, out IReadOnlyList<SCAM> Value)
        {
            return Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindByMEETING_ROOM(string MEETING_ROOM)
        {
            IReadOnlyList<SCAM> value;
            if (Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindBySCAMKEY(string SCAMKEY)
        {
            return Index_SCAMKEY.Value[SCAMKEY];
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAMKEY(string SCAMKEY, out IReadOnlyList<SCAM> Value)
        {
            return Index_SCAMKEY.Value.TryGetValue(SCAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindBySCAMKEY(string SCAMKEY)
        {
            IReadOnlyList<SCAM> value;
            if (Index_SCAMKEY.Value.TryGetValue(SCAMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <returns>Related SCAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM FindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            return Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value[Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME)];
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <param name="Value">Related SCAM entity</param>
        /// <returns>True if the related SCAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME, out SCAM Value)
        {
            return Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME), out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <returns>Related SCAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM TryFindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            SCAM value;
            if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <returns>Related SCAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <param name="Value">Related SCAM entity</param>
        /// <returns>True if the related SCAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SCAM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <returns>Related SCAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM TryFindByTID(int TID)
        {
            SCAM value;
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
        /// Returns SQL which checks for the existence of a SCAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCAM](
        [TID] int IDENTITY NOT NULL,
        [SCAMKEY] varchar(15) NOT NULL,
        [MEETING_DATE] datetime NULL,
        [MEETING_TIME] smallint NULL,
        [MEETING_PURPOSE] text NULL,
        [MEETING_LOCATION] int NULL,
        [MEETING_ROOM] varchar(4) NULL,
        [MINUTES_MEMO] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCAM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SCAM_Index_MEETING_LOCATION] ON [dbo].[SCAM]
    (
            [MEETING_LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [SCAM_Index_MEETING_ROOM] ON [dbo].[SCAM]
    (
            [MEETING_ROOM] ASC
    );
    CREATE CLUSTERED INDEX [SCAM_Index_SCAMKEY] ON [dbo].[SCAM]
    (
            [SCAMKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SCAM_Index_SCAMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SCAM]
    (
            [SCAMKEY] ASC,
            [MEETING_DATE] ASC,
            [MEETING_TIME] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCAM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCAMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCAMDataReader : IDataReader, IDataRecord
        {
            private List<SCAM> Items;
            private int CurrentIndex;
            private SCAM CurrentItem;

            public SCAMDataReader(List<SCAM> Items)
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
                    case 1: // SCAMKEY
                        return CurrentItem.SCAMKEY;
                    case 2: // MEETING_DATE
                        return CurrentItem.MEETING_DATE;
                    case 3: // MEETING_TIME
                        return CurrentItem.MEETING_TIME;
                    case 4: // MEETING_PURPOSE
                        return CurrentItem.MEETING_PURPOSE;
                    case 5: // MEETING_LOCATION
                        return CurrentItem.MEETING_LOCATION;
                    case 6: // MEETING_ROOM
                        return CurrentItem.MEETING_ROOM;
                    case 7: // MINUTES_MEMO
                        return CurrentItem.MINUTES_MEMO;
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
                    case 2: // MEETING_DATE
                        return CurrentItem.MEETING_DATE == null;
                    case 3: // MEETING_TIME
                        return CurrentItem.MEETING_TIME == null;
                    case 4: // MEETING_PURPOSE
                        return CurrentItem.MEETING_PURPOSE == null;
                    case 5: // MEETING_LOCATION
                        return CurrentItem.MEETING_LOCATION == null;
                    case 6: // MEETING_ROOM
                        return CurrentItem.MEETING_ROOM == null;
                    case 7: // MINUTES_MEMO
                        return CurrentItem.MINUTES_MEMO == null;
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
                    case 1: // SCAMKEY
                        return "SCAMKEY";
                    case 2: // MEETING_DATE
                        return "MEETING_DATE";
                    case 3: // MEETING_TIME
                        return "MEETING_TIME";
                    case 4: // MEETING_PURPOSE
                        return "MEETING_PURPOSE";
                    case 5: // MEETING_LOCATION
                        return "MEETING_LOCATION";
                    case 6: // MEETING_ROOM
                        return "MEETING_ROOM";
                    case 7: // MINUTES_MEMO
                        return "MINUTES_MEMO";
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
                    case "SCAMKEY":
                        return 1;
                    case "MEETING_DATE":
                        return 2;
                    case "MEETING_TIME":
                        return 3;
                    case "MEETING_PURPOSE":
                        return 4;
                    case "MEETING_LOCATION":
                        return 5;
                    case "MEETING_ROOM":
                        return 6;
                    case "MINUTES_MEMO":
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
