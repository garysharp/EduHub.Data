using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Item Leave Items Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PILIDataSet : DataSetBase<PILI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PILI"; } }

        internal PILIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_LEAVE_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_GROUP));
            Index_PIKEY = new Lazy<Dictionary<short, IReadOnlyList<PILI>>>(() => this.ToGroupedDictionary(i => i.PIKEY));
            Index_PLTKEY = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.PLTKEY));
            Index_TID = new Lazy<Dictionary<int, PILI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PILI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PILI" /> fields for each CSV column header</returns>
        protected override Action<PILI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PILI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PIKEY":
                        mapper[i] = (e, v) => e.PIKEY = short.Parse(v);
                        break;
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
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
        /// Merges <see cref="PILI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PILI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PILI" /> items to added or update the base <see cref="PILI" /> items</param>
        /// <returns>A merged list of <see cref="PILI" /> items</returns>
        protected override List<PILI> ApplyDeltaItems(List<PILI> Items, List<PILI> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PILI deltaItem in DeltaItems)
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
                .OrderBy(i => i.PIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_LEAVE_GROUP;
        private Lazy<Dictionary<short, IReadOnlyList<PILI>>> Index_PIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_PLTKEY;
        private Lazy<Dictionary<int, PILI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PILI> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PILI> value;
            if (Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PILI> Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PILI> value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByPIKEY(short PIKEY)
        {
            return Index_PIKEY.Value[PIKEY];
        }

        /// <summary>
        /// Attempt to find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPIKEY(short PIKEY, out IReadOnlyList<PILI> Value)
        {
            return Index_PIKEY.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByPIKEY(short PIKEY)
        {
            IReadOnlyList<PILI> value;
            if (Index_PIKEY.Value.TryGetValue(PIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out IReadOnlyList<PILI> Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PILI> value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <returns>Related PILI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PILI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <param name="Value">Related PILI entity</param>
        /// <returns>True if the related PILI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PILI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <returns>Related PILI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PILI TryFindByTID(int TID)
        {
            PILI value;
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
        /// Returns SQL which checks for the existence of a PILI table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PILI](
        [TID] int IDENTITY NOT NULL,
        [PIKEY] smallint NOT NULL,
        [PLTKEY] varchar(16) NULL,
        [LEAVE_GROUP] varchar(8) NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PILI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PILI_Index_LEAVE_CODE] ON [dbo].[PILI]
    (
            [LEAVE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PILI_Index_LEAVE_GROUP] ON [dbo].[PILI]
    (
            [LEAVE_GROUP] ASC
    );
    CREATE CLUSTERED INDEX [PILI_Index_PIKEY] ON [dbo].[PILI]
    (
            [PIKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PILI_Index_PLTKEY] ON [dbo].[PILI]
    (
            [PLTKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PILI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PILI data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PILIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PILIDataReader : IDataReader, IDataRecord
        {
            private List<PILI> Items;
            private int CurrentIndex;
            private PILI CurrentItem;

            public PILIDataReader(List<PILI> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 8; } }
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
                    case 1: // PIKEY
                        return CurrentItem.PIKEY;
                    case 2: // PLTKEY
                        return CurrentItem.PLTKEY;
                    case 3: // LEAVE_GROUP
                        return CurrentItem.LEAVE_GROUP;
                    case 4: // LEAVE_CODE
                        return CurrentItem.LEAVE_CODE;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 7: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PLTKEY
                        return CurrentItem.PLTKEY == null;
                    case 3: // LEAVE_GROUP
                        return CurrentItem.LEAVE_GROUP == null;
                    case 4: // LEAVE_CODE
                        return CurrentItem.LEAVE_CODE == null;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 7: // LW_USER
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
                    case 1: // PIKEY
                        return "PIKEY";
                    case 2: // PLTKEY
                        return "PLTKEY";
                    case 3: // LEAVE_GROUP
                        return "LEAVE_GROUP";
                    case 4: // LEAVE_CODE
                        return "LEAVE_CODE";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
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
                    case "PIKEY":
                        return 1;
                    case "PLTKEY":
                        return 2;
                    case "LEAVE_GROUP":
                        return 3;
                    case "LEAVE_CODE":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
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
