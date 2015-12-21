using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSFDataSet : EduHubDataSet<KSF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSF"; } }

        internal KSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COORDINATOR = new Lazy<NullDictionary<string, IReadOnlyList<KSF>>>(() => this.ToGroupedNullDictionary(i => i.COORDINATOR));
            Index_KSFKEY = new Lazy<Dictionary<string, KSF>>(() => this.ToDictionary(i => i.KSFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSF" /> fields for each CSV column header</returns>
        protected override Action<KSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSFKEY":
                        mapper[i] = (e, v) => e.KSFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "COORDINATOR":
                        mapper[i] = (e, v) => e.COORDINATOR = v;
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
        /// Merges <see cref="KSF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KSF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KSF" /> items to added or update the base <see cref="KSF" /> items</param>
        /// <returns>A merged list of <see cref="KSF" /> items</returns>
        protected override List<KSF> ApplyDeltaItems(List<KSF> Items, List<KSF> DeltaItems)
        {
            Dictionary<string, int> Index_KSFKEY = Items.ToIndexDictionary(i => i.KSFKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KSF deltaItem in DeltaItems)
            {
                int index;

                if (Index_KSFKEY.TryGetValue(deltaItem.KSFKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KSFKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KSF>>> Index_COORDINATOR;
        private Lazy<Dictionary<string, KSF>> Index_KSFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <returns>List of related KSF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSF> FindByCOORDINATOR(string COORDINATOR)
        {
            return Index_COORDINATOR.Value[COORDINATOR];
        }

        /// <summary>
        /// Attempt to find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <param name="Value">List of related KSF entities</param>
        /// <returns>True if the list of related KSF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOORDINATOR(string COORDINATOR, out IReadOnlyList<KSF> Value)
        {
            return Index_COORDINATOR.Value.TryGetValue(COORDINATOR, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <returns>List of related KSF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSF> TryFindByCOORDINATOR(string COORDINATOR)
        {
            IReadOnlyList<KSF> value;
            if (Index_COORDINATOR.Value.TryGetValue(COORDINATOR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSF FindByKSFKEY(string KSFKEY)
        {
            return Index_KSFKEY.Value[KSFKEY];
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <param name="Value">Related KSF entity</param>
        /// <returns>True if the related KSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSFKEY(string KSFKEY, out KSF Value)
        {
            return Index_KSFKEY.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSF TryFindByKSFKEY(string KSFKEY)
        {
            KSF value;
            if (Index_KSFKEY.Value.TryGetValue(KSFKEY, out value))
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
        /// Returns SQL which checks for the existence of a KSF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSF](
        [KSFKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [COORDINATOR] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSF_Index_KSFKEY] PRIMARY KEY CLUSTERED (
            [KSFKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KSF_Index_COORDINATOR] ON [dbo].[KSF]
    (
            [COORDINATOR] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KSFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSFDataReader : IDataReader, IDataRecord
        {
            private List<KSF> Items;
            private int CurrentIndex;
            private KSF CurrentItem;

            public KSFDataReader(List<KSF> Items)
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
                    case 0: // KSFKEY
                        return CurrentItem.KSFKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // COORDINATOR
                        return CurrentItem.COORDINATOR;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // COORDINATOR
                        return CurrentItem.COORDINATOR == null;
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
                    case 0: // KSFKEY
                        return "KSFKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // COORDINATOR
                        return "COORDINATOR";
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
                    case "KSFKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "COORDINATOR":
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
