using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SP2 dummy table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBUDGDataSet : DataSetBase<GLFBUDG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLFBUDG"; } }

        internal GLFBUDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKEY = new Lazy<Dictionary<string, IReadOnlyList<GLFBUDG>>>(() => this.ToGroupedDictionary(i => i.BKEY));
            Index_TID = new Lazy<Dictionary<int, GLFBUDG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFBUDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFBUDG" /> fields for each CSV column header</returns>
        protected override Action<GLFBUDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFBUDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BKEY":
                        mapper[i] = (e, v) => e.BKEY = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLFBUDG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLFBUDG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLFBUDG" /> items to added or update the base <see cref="GLFBUDG" /> items</param>
        /// <returns>A merged list of <see cref="GLFBUDG" /> items</returns>
        protected override List<GLFBUDG> ApplyDeltaItems(List<GLFBUDG> Items, List<GLFBUDG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLFBUDG deltaItem in DeltaItems)
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
                .OrderBy(i => i.BKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<GLFBUDG>>> Index_BKEY;
        private Lazy<Dictionary<int, GLFBUDG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <returns>List of related GLFBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBUDG> FindByBKEY(string BKEY)
        {
            return Index_BKEY.Value[BKEY];
        }

        /// <summary>
        /// Attempt to find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <param name="Value">List of related GLFBUDG entities</param>
        /// <returns>True if the list of related GLFBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKEY(string BKEY, out IReadOnlyList<GLFBUDG> Value)
        {
            return Index_BKEY.Value.TryGetValue(BKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <returns>List of related GLFBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBUDG> TryFindByBKEY(string BKEY)
        {
            IReadOnlyList<GLFBUDG> value;
            if (Index_BKEY.Value.TryGetValue(BKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <returns>Related GLFBUDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBUDG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <param name="Value">Related GLFBUDG entity</param>
        /// <returns>True if the related GLFBUDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFBUDG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <returns>Related GLFBUDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBUDG TryFindByTID(int TID)
        {
            GLFBUDG value;
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
        /// Returns SQL which checks for the existence of a GLFBUDG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLFBUDG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLFBUDG](
        [TID] int IDENTITY NOT NULL,
        [BKEY] varchar(15) NOT NULL,
        [TRBATCH] int NULL,
        [TRAMT] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLFBUDG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [GLFBUDG_Index_BKEY] ON [dbo].[GLFBUDG]
    (
            [BKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLFBUDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFBUDG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new GLFBUDGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLFBUDGDataReader : IDataReader, IDataRecord
        {
            private List<GLFBUDG> Items;
            private int CurrentIndex;
            private GLFBUDG CurrentItem;

            public GLFBUDGDataReader(List<GLFBUDG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 1: // BKEY
                        return CurrentItem.BKEY;
                    case 2: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 3: // TRAMT
                        return CurrentItem.TRAMT;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 3: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // BKEY
                        return "BKEY";
                    case 2: // TRBATCH
                        return "TRBATCH";
                    case 3: // TRAMT
                        return "TRAMT";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "BKEY":
                        return 1;
                    case "TRBATCH":
                        return 2;
                    case "TRAMT":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
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
