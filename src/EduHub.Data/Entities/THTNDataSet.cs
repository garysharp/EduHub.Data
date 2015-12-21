using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Labels Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTNDataSet : EduHubDataSet<THTN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "THTN"; } }

        internal THTNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<THTN>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_QKEY = new Lazy<Dictionary<string, IReadOnlyList<THTN>>>(() => this.ToGroupedDictionary(i => i.QKEY));
            Index_TID = new Lazy<Dictionary<int, THTN>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="THTN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="THTN" /> fields for each CSV column header</returns>
        protected override Action<THTN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<THTN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "LABEL_NUMBER":
                        mapper[i] = (e, v) => e.LABEL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LABEL_TYPE":
                        mapper[i] = (e, v) => e.LABEL_TYPE = v;
                        break;
                    case "LABEL_NAME":
                        mapper[i] = (e, v) => e.LABEL_NAME = v;
                        break;
                    case "LABEL_COLOUR":
                        mapper[i] = (e, v) => e.LABEL_COLOUR = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="THTN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="THTN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="THTN" /> items to added or update the base <see cref="THTN" /> items</param>
        /// <returns>A merged list of <see cref="THTN" /> items</returns>
        protected override List<THTN> ApplyDeltaItems(List<THTN> Items, List<THTN> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (THTN deltaItem in DeltaItems)
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
                .OrderBy(i => i.QKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<THTN>>> Index_LW_DATE;
        private Lazy<Dictionary<string, IReadOnlyList<THTN>>> Index_QKEY;
        private Lazy<Dictionary<int, THTN>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <returns>List of related THTN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <param name="Value">List of related THTN entities</param>
        /// <returns>True if the list of related THTN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<THTN> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <returns>List of related THTN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<THTN> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <returns>List of related THTN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <param name="Value">List of related THTN entities</param>
        /// <returns>True if the list of related THTN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<THTN> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <returns>List of related THTN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<THTN> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <returns>Related THTN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTN FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <param name="Value">Related THTN entity</param>
        /// <returns>True if the related THTN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out THTN Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <returns>Related THTN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTN TryFindByTID(int TID)
        {
            THTN value;
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
        /// Returns SQL which checks for the existence of a THTN table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[THTN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[THTN](
        [TID] int IDENTITY NOT NULL,
        [QKEY] varchar(8) NOT NULL,
        [LABEL_NUMBER] smallint NULL,
        [LABEL_TYPE] varchar(1) NULL,
        [LABEL_NAME] varchar(20) NULL,
        [LABEL_COLOUR] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [THTN_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [THTN_Index_LW_DATE] ON [dbo].[THTN]
    (
            [LW_DATE] ASC
    );
    CREATE CLUSTERED INDEX [THTN_Index_QKEY] ON [dbo].[THTN]
    (
            [QKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the THTN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the THTN data set</returns>
        public override IDataReader GetDataReader()
        {
            return new THTNDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class THTNDataReader : IDataReader, IDataRecord
        {
            private List<THTN> Items;
            private int CurrentIndex;
            private THTN CurrentItem;

            public THTNDataReader(List<THTN> Items)
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
                    case 1: // QKEY
                        return CurrentItem.QKEY;
                    case 2: // LABEL_NUMBER
                        return CurrentItem.LABEL_NUMBER;
                    case 3: // LABEL_TYPE
                        return CurrentItem.LABEL_TYPE;
                    case 4: // LABEL_NAME
                        return CurrentItem.LABEL_NAME;
                    case 5: // LABEL_COLOUR
                        return CurrentItem.LABEL_COLOUR;
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
                    case 2: // LABEL_NUMBER
                        return CurrentItem.LABEL_NUMBER == null;
                    case 3: // LABEL_TYPE
                        return CurrentItem.LABEL_TYPE == null;
                    case 4: // LABEL_NAME
                        return CurrentItem.LABEL_NAME == null;
                    case 5: // LABEL_COLOUR
                        return CurrentItem.LABEL_COLOUR == null;
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
                    case 1: // QKEY
                        return "QKEY";
                    case 2: // LABEL_NUMBER
                        return "LABEL_NUMBER";
                    case 3: // LABEL_TYPE
                        return "LABEL_TYPE";
                    case 4: // LABEL_NAME
                        return "LABEL_NAME";
                    case 5: // LABEL_COLOUR
                        return "LABEL_COLOUR";
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
                    case "QKEY":
                        return 1;
                    case "LABEL_NUMBER":
                        return 2;
                    case "LABEL_TYPE":
                        return 3;
                    case "LABEL_NAME":
                        return 4;
                    case "LABEL_COLOUR":
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
