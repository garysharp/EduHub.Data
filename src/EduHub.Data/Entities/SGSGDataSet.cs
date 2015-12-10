using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Membership Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSGDataSet : DataSetBase<SGSG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGSG"; } }

        internal SGSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGLINK = new Lazy<NullDictionary<string, IReadOnlyList<SGSG>>>(() => this.ToGroupedNullDictionary(i => i.SGLINK));
            Index_SGSGKEY = new Lazy<Dictionary<string, IReadOnlyList<SGSG>>>(() => this.ToGroupedDictionary(i => i.SGSGKEY));
            Index_TID = new Lazy<Dictionary<int, SGSG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSG" /> fields for each CSV column header</returns>
        protected override Action<SGSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGSGKEY":
                        mapper[i] = (e, v) => e.SGSGKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
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
        /// Merges <see cref="SGSG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGSG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGSG" /> items to added or update the base <see cref="SGSG" /> items</param>
        /// <returns>A merged list of <see cref="SGSG" /> items</returns>
        protected override List<SGSG> ApplyDeltaItems(List<SGSG> Items, List<SGSG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGSG deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGSGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SGSG>>> Index_SGLINK;
        private Lazy<Dictionary<string, IReadOnlyList<SGSG>>> Index_SGSGKEY;
        private Lazy<Dictionary<int, SGSG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <returns>List of related SGSG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> FindBySGLINK(string SGLINK)
        {
            return Index_SGLINK.Value[SGLINK];
        }

        /// <summary>
        /// Attempt to find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <param name="Value">List of related SGSG entities</param>
        /// <returns>True if the list of related SGSG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGLINK(string SGLINK, out IReadOnlyList<SGSG> Value)
        {
            return Index_SGLINK.Value.TryGetValue(SGLINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <returns>List of related SGSG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> TryFindBySGLINK(string SGLINK)
        {
            IReadOnlyList<SGSG> value;
            if (Index_SGLINK.Value.TryGetValue(SGLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <returns>List of related SGSG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> FindBySGSGKEY(string SGSGKEY)
        {
            return Index_SGSGKEY.Value[SGSGKEY];
        }

        /// <summary>
        /// Attempt to find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <param name="Value">List of related SGSG entities</param>
        /// <returns>True if the list of related SGSG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGSGKEY(string SGSGKEY, out IReadOnlyList<SGSG> Value)
        {
            return Index_SGSGKEY.Value.TryGetValue(SGSGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <returns>List of related SGSG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> TryFindBySGSGKEY(string SGSGKEY)
        {
            IReadOnlyList<SGSG> value;
            if (Index_SGSGKEY.Value.TryGetValue(SGSGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <returns>Related SGSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <param name="Value">Related SGSG entity</param>
        /// <returns>True if the related SGSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGSG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <returns>Related SGSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSG TryFindByTID(int TID)
        {
            SGSG value;
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
        /// Returns SQL which checks for the existence of a SGSG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGSG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGSG](
        [TID] int IDENTITY NOT NULL,
        [SGSGKEY] varchar(12) NOT NULL,
        [SGLINK] varchar(12) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGSG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SGSG_Index_SGLINK] ON [dbo].[SGSG]
    (
            [SGLINK] ASC
    );
    CREATE CLUSTERED INDEX [SGSG_Index_SGSGKEY] ON [dbo].[SGSG]
    (
            [SGSGKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGSG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGSGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGSGDataReader : IDataReader, IDataRecord
        {
            private List<SGSG> Items;
            private int CurrentIndex;
            private SGSG CurrentItem;

            public SGSGDataReader(List<SGSG> Items)
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
                    case 1: // SGSGKEY
                        return CurrentItem.SGSGKEY;
                    case 2: // SGLINK
                        return CurrentItem.SGLINK;
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
                    case 2: // SGLINK
                        return CurrentItem.SGLINK == null;
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
                    case 1: // SGSGKEY
                        return "SGSGKEY";
                    case 2: // SGLINK
                        return "SGLINK";
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
                    case "SGSGKEY":
                        return 1;
                    case "SGLINK":
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
