using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Attendees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETNDataSet : DataSetBase<TETN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TETN"; } }

        internal TETNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TETNKEY = new Lazy<Dictionary<int, IReadOnlyList<TETN>>>(() => this.ToGroupedDictionary(i => i.TETNKEY));
            Index_TID = new Lazy<Dictionary<int, TETN>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETN" /> fields for each CSV column header</returns>
        protected override Action<TETN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TETNKEY":
                        mapper[i] = (e, v) => e.TETNKEY = int.Parse(v);
                        break;
                    case "TETELINK":
                        mapper[i] = (e, v) => e.TETELINK = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDEE":
                        mapper[i] = (e, v) => e.ATTENDEE = v;
                        break;
                    case "ATTENDEE_TYPE":
                        mapper[i] = (e, v) => e.ATTENDEE_TYPE = v;
                        break;
                    case "ATTENDEE_DETAIL":
                        mapper[i] = (e, v) => e.ATTENDEE_DETAIL = v;
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
        /// Merges <see cref="TETN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TETN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TETN" /> items to added or update the base <see cref="TETN" /> items</param>
        /// <returns>A merged list of <see cref="TETN" /> items</returns>
        protected override List<TETN> ApplyDeltaItems(List<TETN> Items, List<TETN> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TETN deltaItem in DeltaItems)
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
                .OrderBy(i => i.TETNKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<TETN>>> Index_TETNKEY;
        private Lazy<Dictionary<int, TETN>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <returns>List of related TETN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> FindByTETNKEY(int TETNKEY)
        {
            return Index_TETNKEY.Value[TETNKEY];
        }

        /// <summary>
        /// Attempt to find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <param name="Value">List of related TETN entities</param>
        /// <returns>True if the list of related TETN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETNKEY(int TETNKEY, out IReadOnlyList<TETN> Value)
        {
            return Index_TETNKEY.Value.TryGetValue(TETNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <returns>List of related TETN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> TryFindByTETNKEY(int TETNKEY)
        {
            IReadOnlyList<TETN> value;
            if (Index_TETNKEY.Value.TryGetValue(TETNKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <returns>Related TETN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETN FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <param name="Value">Related TETN entity</param>
        /// <returns>True if the related TETN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TETN Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <returns>Related TETN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETN TryFindByTID(int TID)
        {
            TETN value;
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
        /// Returns SQL which checks for the existence of a TETN table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TETN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TETN](
        [TID] int IDENTITY NOT NULL,
        [TETNKEY] int NOT NULL,
        [TETELINK] int NULL,
        [ATTENDEE] varchar(10) NULL,
        [ATTENDEE_TYPE] varchar(8) NULL,
        [ATTENDEE_DETAIL] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TETN_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TETN_Index_TETNKEY] ON [dbo].[TETN]
    (
            [TETNKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TETN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TETN data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TETNDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TETNDataReader : IDataReader, IDataRecord
        {
            private List<TETN> Items;
            private int CurrentIndex;
            private TETN CurrentItem;

            public TETNDataReader(List<TETN> Items)
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
                    case 1: // TETNKEY
                        return CurrentItem.TETNKEY;
                    case 2: // TETELINK
                        return CurrentItem.TETELINK;
                    case 3: // ATTENDEE
                        return CurrentItem.ATTENDEE;
                    case 4: // ATTENDEE_TYPE
                        return CurrentItem.ATTENDEE_TYPE;
                    case 5: // ATTENDEE_DETAIL
                        return CurrentItem.ATTENDEE_DETAIL;
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
                    case 2: // TETELINK
                        return CurrentItem.TETELINK == null;
                    case 3: // ATTENDEE
                        return CurrentItem.ATTENDEE == null;
                    case 4: // ATTENDEE_TYPE
                        return CurrentItem.ATTENDEE_TYPE == null;
                    case 5: // ATTENDEE_DETAIL
                        return CurrentItem.ATTENDEE_DETAIL == null;
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
                    case 1: // TETNKEY
                        return "TETNKEY";
                    case 2: // TETELINK
                        return "TETELINK";
                    case 3: // ATTENDEE
                        return "ATTENDEE";
                    case 4: // ATTENDEE_TYPE
                        return "ATTENDEE_TYPE";
                    case 5: // ATTENDEE_DETAIL
                        return "ATTENDEE_DETAIL";
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
                    case "TETNKEY":
                        return 1;
                    case "TETELINK":
                        return 2;
                    case "ATTENDEE":
                        return 3;
                    case "ATTENDEE_TYPE":
                        return 4;
                    case "ATTENDEE_DETAIL":
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
