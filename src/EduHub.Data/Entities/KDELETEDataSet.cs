using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Data deleted from DataMirror monitored tables Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDELETEDataSet : DataSetBase<KDELETE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDELETE"; } }

        internal KDELETEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, KDELETE>>(() => this.ToDictionary(i => i.ID));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KDELETE>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDELETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDELETE" /> fields for each CSV column header</returns>
        protected override Action<KDELETE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDELETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TABLENAME":
                        mapper[i] = (e, v) => e.TABLENAME = v;
                        break;
                    case "IDVALUE":
                        mapper[i] = (e, v) => e.IDVALUE = v;
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
        /// Merges <see cref="KDELETE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KDELETE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KDELETE" /> items to added or update the base <see cref="KDELETE" /> items</param>
        /// <returns>A merged list of <see cref="KDELETE" /> items</returns>
        protected override List<KDELETE> ApplyDeltaItems(List<KDELETE> Items, List<KDELETE> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KDELETE deltaItem in DeltaItems)
            {
                int index;

                if (Index_ID.TryGetValue(deltaItem.ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KDELETE>> Index_ID;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KDELETE>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDELETE FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <param name="Value">Related KDELETE entity</param>
        /// <returns>True if the related KDELETE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out KDELETE Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDELETE TryFindByID(int ID)
        {
            KDELETE value;
            if (Index_ID.Value.TryGetValue(ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <returns>List of related KDELETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KDELETE> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <param name="Value">List of related KDELETE entities</param>
        /// <returns>True if the list of related KDELETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KDELETE> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <returns>List of related KDELETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KDELETE> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KDELETE> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
        /// Returns SQL which checks for the existence of a KDELETE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KDELETE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KDELETE](
        [ID] int IDENTITY NOT NULL,
        [TABLENAME] varchar(10) NULL,
        [IDVALUE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KDELETE_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KDELETE_Index_LW_DATE] ON [dbo].[KDELETE]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDELETE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDELETE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KDELETEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KDELETEDataReader : IDataReader, IDataRecord
        {
            private List<KDELETE> Items;
            private int CurrentIndex;
            private KDELETE CurrentItem;

            public KDELETEDataReader(List<KDELETE> Items)
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
                    case 0: // ID
                        return CurrentItem.ID;
                    case 1: // TABLENAME
                        return CurrentItem.TABLENAME;
                    case 2: // IDVALUE
                        return CurrentItem.IDVALUE;
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
                    case 1: // TABLENAME
                        return CurrentItem.TABLENAME == null;
                    case 2: // IDVALUE
                        return CurrentItem.IDVALUE == null;
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
                    case 0: // ID
                        return "ID";
                    case 1: // TABLENAME
                        return "TABLENAME";
                    case 2: // IDVALUE
                        return "IDVALUE";
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
                    case "ID":
                        return 0;
                    case "TABLENAME":
                        return 1;
                    case "IDVALUE":
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
