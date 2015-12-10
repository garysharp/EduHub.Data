using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SSDataSet : DataSetBase<SS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SS"; } }

        internal SSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEFAULT_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.DEFAULT_TEACHER));
            Index_FROM_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.FROM_HOMEGROUP));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SSKEY = new Lazy<Dictionary<string, SS>>(() => this.ToDictionary(i => i.SSKEY));
            Index_TO_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.TO_HOMEGROUP));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SS" /> fields for each CSV column header</returns>
        protected override Action<SS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SSKEY":
                        mapper[i] = (e, v) => e.SSKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FROM_HOMEGROUP":
                        mapper[i] = (e, v) => e.FROM_HOMEGROUP = v;
                        break;
                    case "TO_HOMEGROUP":
                        mapper[i] = (e, v) => e.TO_HOMEGROUP = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "DEFAULT_TEACHER":
                        mapper[i] = (e, v) => e.DEFAULT_TEACHER = v;
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
        /// Merges <see cref="SS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SS" /> items to added or update the base <see cref="SS" /> items</param>
        /// <returns>A merged list of <see cref="SS" /> items</returns>
        protected override List<SS> ApplyDeltaItems(List<SS> Items, List<SS> DeltaItems)
        {
            Dictionary<string, int> Index_SSKEY = Items.ToIndexDictionary(i => i.SSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SS deltaItem in DeltaItems)
            {
                int index;

                if (Index_SSKEY.TryGetValue(deltaItem.SSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SS>>> Index_DEFAULT_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<SS>>> Index_FROM_HOMEGROUP;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SS>>> Index_LW_DATE;
        private Lazy<Dictionary<string, SS>> Index_SSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SS>>> Index_TO_HOMEGROUP;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SS by DEFAULT_TEACHER field
        /// </summary>
        /// <param name="DEFAULT_TEACHER">DEFAULT_TEACHER value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByDEFAULT_TEACHER(string DEFAULT_TEACHER)
        {
            return Index_DEFAULT_TEACHER.Value[DEFAULT_TEACHER];
        }

        /// <summary>
        /// Attempt to find SS by DEFAULT_TEACHER field
        /// </summary>
        /// <param name="DEFAULT_TEACHER">DEFAULT_TEACHER value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEFAULT_TEACHER(string DEFAULT_TEACHER, out IReadOnlyList<SS> Value)
        {
            return Index_DEFAULT_TEACHER.Value.TryGetValue(DEFAULT_TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SS by DEFAULT_TEACHER field
        /// </summary>
        /// <param name="DEFAULT_TEACHER">DEFAULT_TEACHER value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByDEFAULT_TEACHER(string DEFAULT_TEACHER)
        {
            IReadOnlyList<SS> value;
            if (Index_DEFAULT_TEACHER.Value.TryGetValue(DEFAULT_TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by FROM_HOMEGROUP field
        /// </summary>
        /// <param name="FROM_HOMEGROUP">FROM_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByFROM_HOMEGROUP(string FROM_HOMEGROUP)
        {
            return Index_FROM_HOMEGROUP.Value[FROM_HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SS by FROM_HOMEGROUP field
        /// </summary>
        /// <param name="FROM_HOMEGROUP">FROM_HOMEGROUP value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFROM_HOMEGROUP(string FROM_HOMEGROUP, out IReadOnlyList<SS> Value)
        {
            return Index_FROM_HOMEGROUP.Value.TryGetValue(FROM_HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SS by FROM_HOMEGROUP field
        /// </summary>
        /// <param name="FROM_HOMEGROUP">FROM_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByFROM_HOMEGROUP(string FROM_HOMEGROUP)
        {
            IReadOnlyList<SS> value;
            if (Index_FROM_HOMEGROUP.Value.TryGetValue(FROM_HOMEGROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SS> value;
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
        /// Find SS by SSKEY field
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SS</param>
        /// <returns>Related SS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SS FindBySSKEY(string SSKEY)
        {
            return Index_SSKEY.Value[SSKEY];
        }

        /// <summary>
        /// Attempt to find SS by SSKEY field
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SS</param>
        /// <param name="Value">Related SS entity</param>
        /// <returns>True if the related SS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySSKEY(string SSKEY, out SS Value)
        {
            return Index_SSKEY.Value.TryGetValue(SSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SS by SSKEY field
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SS</param>
        /// <returns>Related SS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SS TryFindBySSKEY(string SSKEY)
        {
            SS value;
            if (Index_SSKEY.Value.TryGetValue(SSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by TO_HOMEGROUP field
        /// </summary>
        /// <param name="TO_HOMEGROUP">TO_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByTO_HOMEGROUP(string TO_HOMEGROUP)
        {
            return Index_TO_HOMEGROUP.Value[TO_HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SS by TO_HOMEGROUP field
        /// </summary>
        /// <param name="TO_HOMEGROUP">TO_HOMEGROUP value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTO_HOMEGROUP(string TO_HOMEGROUP, out IReadOnlyList<SS> Value)
        {
            return Index_TO_HOMEGROUP.Value.TryGetValue(TO_HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SS by TO_HOMEGROUP field
        /// </summary>
        /// <param name="TO_HOMEGROUP">TO_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByTO_HOMEGROUP(string TO_HOMEGROUP)
        {
            IReadOnlyList<SS> value;
            if (Index_TO_HOMEGROUP.Value.TryGetValue(TO_HOMEGROUP, out value))
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
        /// Returns SQL which checks for the existence of a SS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SS](
        [SSKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [FROM_HOMEGROUP] varchar(3) NULL,
        [TO_HOMEGROUP] varchar(3) NULL,
        [ACTIVE] varchar(1) NULL,
        [DEFAULT_TEACHER] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SS_Index_SSKEY] PRIMARY KEY CLUSTERED (
            [SSKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SS_Index_DEFAULT_TEACHER] ON [dbo].[SS]
    (
            [DEFAULT_TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [SS_Index_FROM_HOMEGROUP] ON [dbo].[SS]
    (
            [FROM_HOMEGROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [SS_Index_LW_DATE] ON [dbo].[SS]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SS_Index_TO_HOMEGROUP] ON [dbo].[SS]
    (
            [TO_HOMEGROUP] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SSDataReader : IDataReader, IDataRecord
        {
            private List<SS> Items;
            private int CurrentIndex;
            private SS CurrentItem;

            public SSDataReader(List<SS> Items)
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
                    case 0: // SSKEY
                        return CurrentItem.SSKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // FROM_HOMEGROUP
                        return CurrentItem.FROM_HOMEGROUP;
                    case 3: // TO_HOMEGROUP
                        return CurrentItem.TO_HOMEGROUP;
                    case 4: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 5: // DEFAULT_TEACHER
                        return CurrentItem.DEFAULT_TEACHER;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // FROM_HOMEGROUP
                        return CurrentItem.FROM_HOMEGROUP == null;
                    case 3: // TO_HOMEGROUP
                        return CurrentItem.TO_HOMEGROUP == null;
                    case 4: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 5: // DEFAULT_TEACHER
                        return CurrentItem.DEFAULT_TEACHER == null;
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
                    case 0: // SSKEY
                        return "SSKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // FROM_HOMEGROUP
                        return "FROM_HOMEGROUP";
                    case 3: // TO_HOMEGROUP
                        return "TO_HOMEGROUP";
                    case 4: // ACTIVE
                        return "ACTIVE";
                    case 5: // DEFAULT_TEACHER
                        return "DEFAULT_TEACHER";
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
                    case "SSKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "FROM_HOMEGROUP":
                        return 2;
                    case "TO_HOMEGROUP":
                        return 3;
                    case "ACTIVE":
                        return 4;
                    case "DEFAULT_TEACHER":
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
