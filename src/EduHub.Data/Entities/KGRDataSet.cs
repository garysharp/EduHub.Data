using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGRDataSet : DataSetBase<KGR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGR"; } }

        internal KGRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RELIGION = new Lazy<Dictionary<string, KGR>>(() => this.ToDictionary(i => i.RELIGION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGR" /> fields for each CSV column header</returns>
        protected override Action<KGR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KGR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGR" /> items to added or update the base <see cref="KGR" /> items</param>
        /// <returns>A merged list of <see cref="KGR" /> items</returns>
        protected override List<KGR> ApplyDeltaItems(List<KGR> Items, List<KGR> DeltaItems)
        {
            Dictionary<string, int> Index_RELIGION = Items.ToIndexDictionary(i => i.RELIGION);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGR deltaItem in DeltaItems)
            {
                int index;

                if (Index_RELIGION.TryGetValue(deltaItem.RELIGION, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.RELIGION)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGR>> Index_RELIGION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGR FindByRELIGION(string RELIGION)
        {
            return Index_RELIGION.Value[RELIGION];
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <param name="Value">Related KGR entity</param>
        /// <returns>True if the related KGR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELIGION(string RELIGION, out KGR Value)
        {
            return Index_RELIGION.Value.TryGetValue(RELIGION, out Value);
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGR TryFindByRELIGION(string RELIGION)
        {
            KGR value;
            if (Index_RELIGION.Value.TryGetValue(RELIGION, out value))
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
        /// Returns SQL which checks for the existence of a KGR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGR](
        [RELIGION] varchar(12) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGR_Index_RELIGION] PRIMARY KEY CLUSTERED (
            [RELIGION] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGRDataReader : IDataReader, IDataRecord
        {
            private List<KGR> Items;
            private int CurrentIndex;
            private KGR CurrentItem;

            public KGRDataReader(List<KGR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 5; } }
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
                    case 0: // RELIGION
                        return CurrentItem.RELIGION;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 3: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 3: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 4: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // RELIGION
                        return "RELIGION";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "RELIGION":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
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
