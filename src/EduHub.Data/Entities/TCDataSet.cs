using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCDataSet : EduHubDataSet<TC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TC"; } }

        internal TCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCKEY = new Lazy<Dictionary<DateTime, TC>>(() => this.ToDictionary(i => i.TCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TC" /> fields for each CSV column header</returns>
        protected override Action<TC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCKEY":
                        mapper[i] = (e, v) => e.TCKEY = DateTime.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DAY_COMMENT":
                        mapper[i] = (e, v) => e.DAY_COMMENT = v;
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
        /// Merges <see cref="TC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TC" /> items to added or update the base <see cref="TC" /> items</param>
        /// <returns>A merged list of <see cref="TC" /> items</returns>
        protected override List<TC> ApplyDeltaItems(List<TC> Items, List<TC> DeltaItems)
        {
            Dictionary<DateTime, int> Index_TCKEY = Items.ToIndexDictionary(i => i.TCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TC deltaItem in DeltaItems)
            {
                int index;

                if (Index_TCKEY.TryGetValue(deltaItem.TCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<DateTime, TC>> Index_TCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <returns>Related TC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TC FindByTCKEY(DateTime TCKEY)
        {
            return Index_TCKEY.Value[TCKEY];
        }

        /// <summary>
        /// Attempt to find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <param name="Value">Related TC entity</param>
        /// <returns>True if the related TC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCKEY(DateTime TCKEY, out TC Value)
        {
            return Index_TCKEY.Value.TryGetValue(TCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <returns>Related TC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TC TryFindByTCKEY(DateTime TCKEY)
        {
            TC value;
            if (Index_TCKEY.Value.TryGetValue(TCKEY, out value))
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
        /// Returns SQL which checks for the existence of a TC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TC](
        [TCKEY] datetime NOT NULL,
        [TITLE] varchar(30) NULL,
        [DAY_COMMENT] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TC_Index_TCKEY] PRIMARY KEY CLUSTERED (
            [TCKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCDataReader : IDataReader, IDataRecord
        {
            private List<TC> Items;
            private int CurrentIndex;
            private TC CurrentItem;

            public TCDataReader(List<TC> Items)
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
                    case 0: // TCKEY
                        return CurrentItem.TCKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // DAY_COMMENT
                        return CurrentItem.DAY_COMMENT;
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
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // DAY_COMMENT
                        return CurrentItem.DAY_COMMENT == null;
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
                    case 0: // TCKEY
                        return "TCKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // DAY_COMMENT
                        return "DAY_COMMENT";
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
                    case "TCKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "DAY_COMMENT":
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
