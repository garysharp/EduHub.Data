using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXHGDataSet : EduHubDataSet<TXHG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TXHG"; } }

        internal TXHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<TXHG>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TXHG>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_TXHG_ID = new Lazy<Dictionary<int, TXHG>>(() => this.ToDictionary(i => i.TXHG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXHG" /> fields for each CSV column header</returns>
        protected override Action<TXHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TXHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TXHG_ID":
                        mapper[i] = (e, v) => e.TXHG_ID = int.Parse(v);
                        break;
                    case "TXHG_DATE":
                        mapper[i] = (e, v) => e.TXHG_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "AM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.AM_ROLL_MARKED = v;
                        break;
                    case "PM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.PM_ROLL_MARKED = v;
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
        /// Merges <see cref="TXHG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TXHG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TXHG" /> items to added or update the base <see cref="TXHG" /> items</param>
        /// <returns>A merged list of <see cref="TXHG" /> items</returns>
        protected override List<TXHG> ApplyDeltaItems(List<TXHG> Items, List<TXHG> DeltaItems)
        {
            Dictionary<int, int> Index_TXHG_ID = Items.ToIndexDictionary(i => i.TXHG_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TXHG deltaItem in DeltaItems)
            {
                int index;

                if (Index_TXHG_ID.TryGetValue(deltaItem.TXHG_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TXHG_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TXHG>>> Index_HOME_GROUP;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TXHG>>> Index_LW_DATE;
        private Lazy<Dictionary<int, TXHG>> Index_TXHG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <returns>List of related TXHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> FindByHOME_GROUP(string HOME_GROUP)
        {
            return Index_HOME_GROUP.Value[HOME_GROUP];
        }

        /// <summary>
        /// Attempt to find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <param name="Value">List of related TXHG entities</param>
        /// <returns>True if the list of related TXHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_GROUP(string HOME_GROUP, out IReadOnlyList<TXHG> Value)
        {
            return Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <returns>List of related TXHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> TryFindByHOME_GROUP(string HOME_GROUP)
        {
            IReadOnlyList<TXHG> value;
            if (Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <returns>List of related TXHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <param name="Value">List of related TXHG entities</param>
        /// <returns>True if the list of related TXHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TXHG> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <returns>List of related TXHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TXHG> value;
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
        /// Find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXHG FindByTXHG_ID(int TXHG_ID)
        {
            return Index_TXHG_ID.Value[TXHG_ID];
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <param name="Value">Related TXHG entity</param>
        /// <returns>True if the related TXHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTXHG_ID(int TXHG_ID, out TXHG Value)
        {
            return Index_TXHG_ID.Value.TryGetValue(TXHG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXHG TryFindByTXHG_ID(int TXHG_ID)
        {
            TXHG value;
            if (Index_TXHG_ID.Value.TryGetValue(TXHG_ID, out value))
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
        /// Returns SQL which checks for the existence of a TXHG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TXHG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TXHG](
        [TXHG_ID] int IDENTITY NOT NULL,
        [TXHG_DATE] datetime NULL,
        [HOME_GROUP] varchar(3) NULL,
        [AM_ROLL_MARKED] varchar(1) NULL,
        [PM_ROLL_MARKED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TXHG_Index_TXHG_ID] PRIMARY KEY CLUSTERED (
            [TXHG_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TXHG_Index_HOME_GROUP] ON [dbo].[TXHG]
    (
            [HOME_GROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [TXHG_Index_LW_DATE] ON [dbo].[TXHG]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TXHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TXHG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TXHGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TXHGDataReader : IDataReader, IDataRecord
        {
            private List<TXHG> Items;
            private int CurrentIndex;
            private TXHG CurrentItem;

            public TXHGDataReader(List<TXHG> Items)
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
                    case 0: // TXHG_ID
                        return CurrentItem.TXHG_ID;
                    case 1: // TXHG_DATE
                        return CurrentItem.TXHG_DATE;
                    case 2: // HOME_GROUP
                        return CurrentItem.HOME_GROUP;
                    case 3: // AM_ROLL_MARKED
                        return CurrentItem.AM_ROLL_MARKED;
                    case 4: // PM_ROLL_MARKED
                        return CurrentItem.PM_ROLL_MARKED;
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
                    case 1: // TXHG_DATE
                        return CurrentItem.TXHG_DATE == null;
                    case 2: // HOME_GROUP
                        return CurrentItem.HOME_GROUP == null;
                    case 3: // AM_ROLL_MARKED
                        return CurrentItem.AM_ROLL_MARKED == null;
                    case 4: // PM_ROLL_MARKED
                        return CurrentItem.PM_ROLL_MARKED == null;
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
                    case 0: // TXHG_ID
                        return "TXHG_ID";
                    case 1: // TXHG_DATE
                        return "TXHG_DATE";
                    case 2: // HOME_GROUP
                        return "HOME_GROUP";
                    case 3: // AM_ROLL_MARKED
                        return "AM_ROLL_MARKED";
                    case 4: // PM_ROLL_MARKED
                        return "PM_ROLL_MARKED";
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
                    case "TXHG_ID":
                        return 0;
                    case "TXHG_DATE":
                        return 1;
                    case "HOME_GROUP":
                        return 2;
                    case "AM_ROLL_MARKED":
                        return 3;
                    case "PM_ROLL_MARKED":
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
