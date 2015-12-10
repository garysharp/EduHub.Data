using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGHGDataSet : DataSetBase<SGHG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGHG"; } }

        internal SGHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGCLINK = new Lazy<NullDictionary<string, IReadOnlyList<SGHG>>>(() => this.ToGroupedNullDictionary(i => i.KGCLINK));
            Index_SGHGKEY = new Lazy<Dictionary<string, IReadOnlyList<SGHG>>>(() => this.ToGroupedDictionary(i => i.SGHGKEY));
            Index_TID = new Lazy<Dictionary<int, SGHG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGHG" /> fields for each CSV column header</returns>
        protected override Action<SGHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGHGKEY":
                        mapper[i] = (e, v) => e.SGHGKEY = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
        /// Merges <see cref="SGHG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGHG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGHG" /> items to added or update the base <see cref="SGHG" /> items</param>
        /// <returns>A merged list of <see cref="SGHG" /> items</returns>
        protected override List<SGHG> ApplyDeltaItems(List<SGHG> Items, List<SGHG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGHG deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGHGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SGHG>>> Index_KGCLINK;
        private Lazy<Dictionary<string, IReadOnlyList<SGHG>>> Index_SGHGKEY;
        private Lazy<Dictionary<int, SGHG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <returns>List of related SGHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> FindByKGCLINK(string KGCLINK)
        {
            return Index_KGCLINK.Value[KGCLINK];
        }

        /// <summary>
        /// Attempt to find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <param name="Value">List of related SGHG entities</param>
        /// <returns>True if the list of related SGHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCLINK(string KGCLINK, out IReadOnlyList<SGHG> Value)
        {
            return Index_KGCLINK.Value.TryGetValue(KGCLINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <returns>List of related SGHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> TryFindByKGCLINK(string KGCLINK)
        {
            IReadOnlyList<SGHG> value;
            if (Index_KGCLINK.Value.TryGetValue(KGCLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <returns>List of related SGHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> FindBySGHGKEY(string SGHGKEY)
        {
            return Index_SGHGKEY.Value[SGHGKEY];
        }

        /// <summary>
        /// Attempt to find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <param name="Value">List of related SGHG entities</param>
        /// <returns>True if the list of related SGHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGHGKEY(string SGHGKEY, out IReadOnlyList<SGHG> Value)
        {
            return Index_SGHGKEY.Value.TryGetValue(SGHGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <returns>List of related SGHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> TryFindBySGHGKEY(string SGHGKEY)
        {
            IReadOnlyList<SGHG> value;
            if (Index_SGHGKEY.Value.TryGetValue(SGHGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <returns>Related SGHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGHG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <param name="Value">Related SGHG entity</param>
        /// <returns>True if the related SGHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGHG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <returns>Related SGHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGHG TryFindByTID(int TID)
        {
            SGHG value;
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
        /// Returns SQL which checks for the existence of a SGHG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGHG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGHG](
        [TID] int IDENTITY NOT NULL,
        [SGHGKEY] varchar(12) NOT NULL,
        [KGCLINK] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGHG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SGHG_Index_KGCLINK] ON [dbo].[SGHG]
    (
            [KGCLINK] ASC
    );
    CREATE CLUSTERED INDEX [SGHG_Index_SGHGKEY] ON [dbo].[SGHG]
    (
            [SGHGKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGHG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGHGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGHGDataReader : IDataReader, IDataRecord
        {
            private List<SGHG> Items;
            private int CurrentIndex;
            private SGHG CurrentItem;

            public SGHGDataReader(List<SGHG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 1: // SGHGKEY
                        return CurrentItem.SGHGKEY;
                    case 2: // KGCLINK
                        return CurrentItem.KGCLINK;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // KGCLINK
                        return CurrentItem.KGCLINK == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
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
                    case 1: // SGHGKEY
                        return "SGHGKEY";
                    case 2: // KGCLINK
                        return "KGCLINK";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
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
                    case "SGHGKEY":
                        return 1;
                    case "KGCLINK":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
