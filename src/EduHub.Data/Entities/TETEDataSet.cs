using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Instances Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETEDataSet : EduHubDataSet<TETE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TETE"; } }

        internal TETEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TETE>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_TETEKEY = new Lazy<Dictionary<int, IReadOnlyList<TETE>>>(() => this.ToGroupedDictionary(i => i.TETEKEY));
            Index_TID = new Lazy<Dictionary<int, TETE>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETE" /> fields for each CSV column header</returns>
        protected override Action<TETE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TETEKEY":
                        mapper[i] = (e, v) => e.TETEKEY = int.Parse(v);
                        break;
                    case "EVENT_DATE":
                        mapper[i] = (e, v) => e.EVENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
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
        /// Merges <see cref="TETE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TETE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TETE" /> items to added or update the base <see cref="TETE" /> items</param>
        /// <returns>A merged list of <see cref="TETE" /> items</returns>
        protected override List<TETE> ApplyDeltaItems(List<TETE> Items, List<TETE> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TETE deltaItem in DeltaItems)
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
                .OrderBy(i => i.TETEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TETE>>> Index_LOCATION;
        private Lazy<Dictionary<int, IReadOnlyList<TETE>>> Index_TETEKEY;
        private Lazy<Dictionary<int, TETE>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <returns>List of related TETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <param name="Value">List of related TETE entities</param>
        /// <returns>True if the list of related TETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TETE> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <returns>List of related TETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TETE> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <returns>List of related TETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> FindByTETEKEY(int TETEKEY)
        {
            return Index_TETEKEY.Value[TETEKEY];
        }

        /// <summary>
        /// Attempt to find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <param name="Value">List of related TETE entities</param>
        /// <returns>True if the list of related TETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETEKEY(int TETEKEY, out IReadOnlyList<TETE> Value)
        {
            return Index_TETEKEY.Value.TryGetValue(TETEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <returns>List of related TETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> TryFindByTETEKEY(int TETEKEY)
        {
            IReadOnlyList<TETE> value;
            if (Index_TETEKEY.Value.TryGetValue(TETEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <returns>Related TETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETE FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <param name="Value">Related TETE entity</param>
        /// <returns>True if the related TETE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TETE Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <returns>Related TETE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETE TryFindByTID(int TID)
        {
            TETE value;
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
        /// Returns SQL which checks for the existence of a TETE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TETE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TETE](
        [TID] int IDENTITY NOT NULL,
        [TETEKEY] int NOT NULL,
        [EVENT_DATE] datetime NULL,
        [COMMENTS] text NULL,
        [TIME_FROM] datetime NULL,
        [TIME_TO] datetime NULL,
        [CONVENOR] varchar(10) NULL,
        [CONVENOR_TYPE] varchar(8) NULL,
        [LOCATION] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TETE_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TETE_Index_LOCATION] ON [dbo].[TETE]
    (
            [LOCATION] ASC
    );
    CREATE CLUSTERED INDEX [TETE_Index_TETEKEY] ON [dbo].[TETE]
    (
            [TETEKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TETE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TETE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TETEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TETEDataReader : IDataReader, IDataRecord
        {
            private List<TETE> Items;
            private int CurrentIndex;
            private TETE CurrentItem;

            public TETEDataReader(List<TETE> Items)
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
                    case 1: // TETEKEY
                        return CurrentItem.TETEKEY;
                    case 2: // EVENT_DATE
                        return CurrentItem.EVENT_DATE;
                    case 3: // COMMENTS
                        return CurrentItem.COMMENTS;
                    case 4: // TIME_FROM
                        return CurrentItem.TIME_FROM;
                    case 5: // TIME_TO
                        return CurrentItem.TIME_TO;
                    case 6: // CONVENOR
                        return CurrentItem.CONVENOR;
                    case 7: // CONVENOR_TYPE
                        return CurrentItem.CONVENOR_TYPE;
                    case 8: // LOCATION
                        return CurrentItem.LOCATION;
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
                    case 2: // EVENT_DATE
                        return CurrentItem.EVENT_DATE == null;
                    case 3: // COMMENTS
                        return CurrentItem.COMMENTS == null;
                    case 4: // TIME_FROM
                        return CurrentItem.TIME_FROM == null;
                    case 5: // TIME_TO
                        return CurrentItem.TIME_TO == null;
                    case 6: // CONVENOR
                        return CurrentItem.CONVENOR == null;
                    case 7: // CONVENOR_TYPE
                        return CurrentItem.CONVENOR_TYPE == null;
                    case 8: // LOCATION
                        return CurrentItem.LOCATION == null;
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
                    case 1: // TETEKEY
                        return "TETEKEY";
                    case 2: // EVENT_DATE
                        return "EVENT_DATE";
                    case 3: // COMMENTS
                        return "COMMENTS";
                    case 4: // TIME_FROM
                        return "TIME_FROM";
                    case 5: // TIME_TO
                        return "TIME_TO";
                    case 6: // CONVENOR
                        return "CONVENOR";
                    case 7: // CONVENOR_TYPE
                        return "CONVENOR_TYPE";
                    case 8: // LOCATION
                        return "LOCATION";
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
                    case "TETEKEY":
                        return 1;
                    case "EVENT_DATE":
                        return 2;
                    case "COMMENTS":
                        return 3;
                    case "TIME_FROM":
                        return 4;
                    case "TIME_TO":
                        return 5;
                    case "CONVENOR":
                        return 6;
                    case "CONVENOR_TYPE":
                        return 7;
                    case "LOCATION":
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
