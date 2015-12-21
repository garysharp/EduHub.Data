using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMDataSet : EduHubDataSet<SM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SM"; } }

        internal SMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_FACULTY = new Lazy<NullDictionary<string, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY));
            Index_ROOM = new Lazy<Dictionary<string, SM>>(() => this.ToDictionary(i => i.ROOM));
            Index_STAFF_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.STAFF_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SM" /> fields for each CSV column header</returns>
        protected override Action<SM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SEATING":
                        mapper[i] = (e, v) => e.SEATING = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "AREA_CODE":
                        mapper[i] = (e, v) => e.AREA_CODE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STAFF_CODE":
                        mapper[i] = (e, v) => e.STAFF_CODE = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "BOARD":
                        mapper[i] = (e, v) => e.BOARD = v;
                        break;
                    case "BLACKOUT":
                        mapper[i] = (e, v) => e.BLACKOUT = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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
        /// Merges <see cref="SM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SM" /> items to added or update the base <see cref="SM" /> items</param>
        /// <returns>A merged list of <see cref="SM" /> items</returns>
        protected override List<SM> ApplyDeltaItems(List<SM> Items, List<SM> DeltaItems)
        {
            Dictionary<string, int> Index_ROOM = Items.ToIndexDictionary(i => i.ROOM);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SM deltaItem in DeltaItems)
            {
                int index;

                if (Index_ROOM.TryGetValue(deltaItem.ROOM, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ROOM)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SM>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SM>>> Index_FACULTY;
        private Lazy<Dictionary<string, SM>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SM>>> Index_STAFF_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SM> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SM> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindByFACULTY(string FACULTY)
        {
            return Index_FACULTY.Value[FACULTY];
        }

        /// <summary>
        /// Attempt to find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY(string FACULTY, out IReadOnlyList<SM> Value)
        {
            return Index_FACULTY.Value.TryGetValue(FACULTY, out Value);
        }

        /// <summary>
        /// Attempt to find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindByFACULTY(string FACULTY)
        {
            IReadOnlyList<SM> value;
            if (Index_FACULTY.Value.TryGetValue(FACULTY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <returns>Related SM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SM FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <param name="Value">Related SM entity</param>
        /// <returns>True if the related SM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out SM Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <returns>Related SM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SM TryFindByROOM(string ROOM)
        {
            SM value;
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
        /// Find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindBySTAFF_CODE(string STAFF_CODE)
        {
            return Index_STAFF_CODE.Value[STAFF_CODE];
        }

        /// <summary>
        /// Attempt to find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF_CODE(string STAFF_CODE, out IReadOnlyList<SM> Value)
        {
            return Index_STAFF_CODE.Value.TryGetValue(STAFF_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindBySTAFF_CODE(string STAFF_CODE)
        {
            IReadOnlyList<SM> value;
            if (Index_STAFF_CODE.Value.TryGetValue(STAFF_CODE, out value))
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
        /// Returns SQL which checks for the existence of a SM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SM](
        [ROOM] varchar(4) NOT NULL,
        [TITLE] varchar(30) NULL,
        [SEATING] smallint NULL,
        [DESCRIPTION] varchar(40) NULL,
        [ROOM_TYPE] varchar(1) NULL,
        [FACULTY] varchar(10) NULL,
        [AREA_CODE] varchar(4) NULL,
        [CAMPUS] int NULL,
        [STAFF_CODE] varchar(4) NULL,
        [COMMENTA] text NULL,
        [BOARD] varchar(4) NULL,
        [BLACKOUT] varchar(1) NULL,
        [NORMAL_ALLOTMENT] smallint NULL,
        [GROUP_INDICATOR] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SM_Index_ROOM] PRIMARY KEY CLUSTERED (
            [ROOM] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SM_Index_CAMPUS] ON [dbo].[SM]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SM_Index_FACULTY] ON [dbo].[SM]
    (
            [FACULTY] ASC
    );
    CREATE NONCLUSTERED INDEX [SM_Index_STAFF_CODE] ON [dbo].[SM]
    (
            [STAFF_CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMDataReader : IDataReader, IDataRecord
        {
            private List<SM> Items;
            private int CurrentIndex;
            private SM CurrentItem;

            public SMDataReader(List<SM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 17; } }
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
                    case 0: // ROOM
                        return CurrentItem.ROOM;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // SEATING
                        return CurrentItem.SEATING;
                    case 3: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 4: // ROOM_TYPE
                        return CurrentItem.ROOM_TYPE;
                    case 5: // FACULTY
                        return CurrentItem.FACULTY;
                    case 6: // AREA_CODE
                        return CurrentItem.AREA_CODE;
                    case 7: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 8: // STAFF_CODE
                        return CurrentItem.STAFF_CODE;
                    case 9: // COMMENTA
                        return CurrentItem.COMMENTA;
                    case 10: // BOARD
                        return CurrentItem.BOARD;
                    case 11: // BLACKOUT
                        return CurrentItem.BLACKOUT;
                    case 12: // NORMAL_ALLOTMENT
                        return CurrentItem.NORMAL_ALLOTMENT;
                    case 13: // GROUP_INDICATOR
                        return CurrentItem.GROUP_INDICATOR;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // SEATING
                        return CurrentItem.SEATING == null;
                    case 3: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 4: // ROOM_TYPE
                        return CurrentItem.ROOM_TYPE == null;
                    case 5: // FACULTY
                        return CurrentItem.FACULTY == null;
                    case 6: // AREA_CODE
                        return CurrentItem.AREA_CODE == null;
                    case 7: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 8: // STAFF_CODE
                        return CurrentItem.STAFF_CODE == null;
                    case 9: // COMMENTA
                        return CurrentItem.COMMENTA == null;
                    case 10: // BOARD
                        return CurrentItem.BOARD == null;
                    case 11: // BLACKOUT
                        return CurrentItem.BLACKOUT == null;
                    case 12: // NORMAL_ALLOTMENT
                        return CurrentItem.NORMAL_ALLOTMENT == null;
                    case 13: // GROUP_INDICATOR
                        return CurrentItem.GROUP_INDICATOR == null;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ROOM
                        return "ROOM";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SEATING
                        return "SEATING";
                    case 3: // DESCRIPTION
                        return "DESCRIPTION";
                    case 4: // ROOM_TYPE
                        return "ROOM_TYPE";
                    case 5: // FACULTY
                        return "FACULTY";
                    case 6: // AREA_CODE
                        return "AREA_CODE";
                    case 7: // CAMPUS
                        return "CAMPUS";
                    case 8: // STAFF_CODE
                        return "STAFF_CODE";
                    case 9: // COMMENTA
                        return "COMMENTA";
                    case 10: // BOARD
                        return "BOARD";
                    case 11: // BLACKOUT
                        return "BLACKOUT";
                    case 12: // NORMAL_ALLOTMENT
                        return "NORMAL_ALLOTMENT";
                    case 13: // GROUP_INDICATOR
                        return "GROUP_INDICATOR";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ROOM":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SEATING":
                        return 2;
                    case "DESCRIPTION":
                        return 3;
                    case "ROOM_TYPE":
                        return 4;
                    case "FACULTY":
                        return 5;
                    case "AREA_CODE":
                        return 6;
                    case "CAMPUS":
                        return 7;
                    case "STAFF_CODE":
                        return 8;
                    case "COMMENTA":
                        return 9;
                    case "BOARD":
                        return 10;
                    case "BLACKOUT":
                        return 11;
                    case "NORMAL_ALLOTMENT":
                        return 12;
                    case "GROUP_INDICATOR":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
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
