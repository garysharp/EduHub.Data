using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCMDataSet : DataSetBase<KCM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCM"; } }

        internal KCMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCMKEY = new Lazy<Dictionary<string, KCM>>(() => this.ToDictionary(i => i.KCMKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KCM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM" /> fields for each CSV column header</returns>
        protected override Action<KCM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
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
        /// Merges <see cref="KCM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCM" /> items to added or update the base <see cref="KCM" /> items</param>
        /// <returns>A merged list of <see cref="KCM" /> items</returns>
        protected override List<KCM> ApplyDeltaItems(List<KCM> Items, List<KCM> DeltaItems)
        {
            Dictionary<string, int> Index_KCMKEY = Items.ToIndexDictionary(i => i.KCMKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCM deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCMKEY.TryGetValue(deltaItem.KCMKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCM>> Index_KCMKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KCM>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM FindByKCMKEY(string KCMKEY)
        {
            return Index_KCMKEY.Value[KCMKEY];
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <param name="Value">Related KCM entity</param>
        /// <returns>True if the related KCM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCMKEY(string KCMKEY, out KCM Value)
        {
            return Index_KCMKEY.Value.TryGetValue(KCMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM TryFindByKCMKEY(string KCMKEY)
        {
            KCM value;
            if (Index_KCMKEY.Value.TryGetValue(KCMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <returns>List of related KCM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <param name="Value">List of related KCM entities</param>
        /// <returns>True if the list of related KCM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KCM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <returns>List of related KCM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KCM> value;
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
        /// Returns SQL which checks for the existence of a KCM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCM](
        [KCMKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCM_Index_KCMKEY] PRIMARY KEY CLUSTERED (
            [KCMKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCM_Index_LW_DATE] ON [dbo].[KCM]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCMDataReader : IDataReader, IDataRecord
        {
            private List<KCM> Items;
            private int CurrentIndex;
            private KCM CurrentItem;

            public KCMDataReader(List<KCM> Items)
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
                    case 0: // KCMKEY
                        return CurrentItem.KCMKEY;
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
                    case 0: // KCMKEY
                        return "KCMKEY";
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
                    case "KCMKEY":
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
