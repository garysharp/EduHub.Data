using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availablity Extras Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAVDataSet : EduHubDataSet<SMAV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMAV"; } }

        internal SMAVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROOM = new Lazy<Dictionary<string, IReadOnlyList<SMAV>>>(() => this.ToGroupedDictionary(i => i.ROOM));
            Index_TID = new Lazy<Dictionary<int, SMAV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMAV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMAV" /> fields for each CSV column header</returns>
        protected override Action<SMAV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMAV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SMAV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SMAV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SMAV" /> items to added or update the base <see cref="SMAV" /> items</param>
        /// <returns>A merged list of <see cref="SMAV" /> items</returns>
        protected override List<SMAV> ApplyDeltaItems(List<SMAV> Items, List<SMAV> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SMAV deltaItem in DeltaItems)
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
                .OrderBy(i => i.ROOM)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SMAV>>> Index_ROOM;
        private Lazy<Dictionary<int, SMAV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <returns>List of related SMAV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAV> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <param name="Value">List of related SMAV entities</param>
        /// <returns>True if the list of related SMAV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SMAV> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <returns>List of related SMAV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAV> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SMAV> value;
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
        /// Find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <returns>Related SMAV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <param name="Value">Related SMAV entity</param>
        /// <returns>True if the related SMAV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMAV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <returns>Related SMAV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAV TryFindByTID(int TID)
        {
            SMAV value;
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
        /// Returns SQL which checks for the existence of a SMAV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMAV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMAV](
        [TID] int IDENTITY NOT NULL,
        [ROOM] varchar(4) NOT NULL,
        [DAY_NUMBER] smallint NULL,
        [START_TIME] datetime NULL,
        [END_TIME] datetime NULL,
        [AVAILABLE_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMAV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SMAV_Index_ROOM] ON [dbo].[SMAV]
    (
            [ROOM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMAV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMAV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SMAVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMAVDataReader : IDataReader, IDataRecord
        {
            private List<SMAV> Items;
            private int CurrentIndex;
            private SMAV CurrentItem;

            public SMAVDataReader(List<SMAV> Items)
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
                    case 1: // ROOM
                        return CurrentItem.ROOM;
                    case 2: // DAY_NUMBER
                        return CurrentItem.DAY_NUMBER;
                    case 3: // START_TIME
                        return CurrentItem.START_TIME;
                    case 4: // END_TIME
                        return CurrentItem.END_TIME;
                    case 5: // AVAILABLE_DATE
                        return CurrentItem.AVAILABLE_DATE;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME;
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
                    case 2: // DAY_NUMBER
                        return CurrentItem.DAY_NUMBER == null;
                    case 3: // START_TIME
                        return CurrentItem.START_TIME == null;
                    case 4: // END_TIME
                        return CurrentItem.END_TIME == null;
                    case 5: // AVAILABLE_DATE
                        return CurrentItem.AVAILABLE_DATE == null;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME == null;
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
                    case 1: // ROOM
                        return "ROOM";
                    case 2: // DAY_NUMBER
                        return "DAY_NUMBER";
                    case 3: // START_TIME
                        return "START_TIME";
                    case 4: // END_TIME
                        return "END_TIME";
                    case 5: // AVAILABLE_DATE
                        return "AVAILABLE_DATE";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
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
                    case "ROOM":
                        return 1;
                    case "DAY_NUMBER":
                        return 2;
                    case "START_TIME":
                        return 3;
                    case "END_TIME":
                        return 4;
                    case "AVAILABLE_DATE":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
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
