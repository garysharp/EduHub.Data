using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGTDataSet : EduHubDataSet<KGT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGT"; } }

        internal KGTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<Dictionary<string, KGT>>(() => this.ToDictionary(i => i.COUNTRY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KGT>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGT" /> fields for each CSV column header</returns>
        protected override Action<KGT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ENGLISH_SPEAKING":
                        mapper[i] = (e, v) => e.ENGLISH_SPEAKING = v;
                        break;
                    case "SACC":
                        mapper[i] = (e, v) => e.SACC = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
        /// Merges <see cref="KGT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGT" /> items to added or update the base <see cref="KGT" /> items</param>
        /// <returns>A merged list of <see cref="KGT" /> items</returns>
        protected override List<KGT> ApplyDeltaItems(List<KGT> Items, List<KGT> DeltaItems)
        {
            Dictionary<string, int> Index_COUNTRY = Items.ToIndexDictionary(i => i.COUNTRY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGT deltaItem in DeltaItems)
            {
                int index;

                if (Index_COUNTRY.TryGetValue(deltaItem.COUNTRY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.COUNTRY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGT>> Index_COUNTRY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KGT>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGT FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <param name="Value">Related KGT entity</param>
        /// <returns>True if the related KGT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out KGT Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGT TryFindByCOUNTRY(string COUNTRY)
        {
            KGT value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <returns>List of related KGT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGT> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <param name="Value">List of related KGT entities</param>
        /// <returns>True if the list of related KGT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KGT> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <returns>List of related KGT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGT> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KGT> value;
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
        /// Returns SQL which checks for the existence of a KGT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGT](
        [COUNTRY] varchar(6) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [ENGLISH_SPEAKING] varchar(1) NULL,
        [SACC] varchar(4) NULL,
        [OBSOLETE] varchar(1) NULL,
        [REFUGEE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGT_Index_COUNTRY] PRIMARY KEY CLUSTERED (
            [COUNTRY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGT_Index_LW_DATE] ON [dbo].[KGT]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGTDataReader : IDataReader, IDataRecord
        {
            private List<KGT> Items;
            private int CurrentIndex;
            private KGT CurrentItem;

            public KGTDataReader(List<KGT> Items)
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
                    case 0: // COUNTRY
                        return CurrentItem.COUNTRY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // ENGLISH_SPEAKING
                        return CurrentItem.ENGLISH_SPEAKING;
                    case 3: // SACC
                        return CurrentItem.SACC;
                    case 4: // OBSOLETE
                        return CurrentItem.OBSOLETE;
                    case 5: // REFUGEE
                        return CurrentItem.REFUGEE;
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
                    case 2: // ENGLISH_SPEAKING
                        return CurrentItem.ENGLISH_SPEAKING == null;
                    case 3: // SACC
                        return CurrentItem.SACC == null;
                    case 4: // OBSOLETE
                        return CurrentItem.OBSOLETE == null;
                    case 5: // REFUGEE
                        return CurrentItem.REFUGEE == null;
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
                    case 0: // COUNTRY
                        return "COUNTRY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ENGLISH_SPEAKING
                        return "ENGLISH_SPEAKING";
                    case 3: // SACC
                        return "SACC";
                    case 4: // OBSOLETE
                        return "OBSOLETE";
                    case 5: // REFUGEE
                        return "REFUGEE";
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
                    case "COUNTRY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ENGLISH_SPEAKING":
                        return 2;
                    case "SACC":
                        return 3;
                    case "OBSOLETE":
                        return 4;
                    case "REFUGEE":
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
