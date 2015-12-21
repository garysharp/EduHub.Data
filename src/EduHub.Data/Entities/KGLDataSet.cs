using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLDataSet : EduHubDataSet<KGL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGL"; } }

        internal KGLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGLKEY = new Lazy<Dictionary<string, KGL>>(() => this.ToDictionary(i => i.KGLKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KGL>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGL" /> fields for each CSV column header</returns>
        protected override Action<KGL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGLKEY":
                        mapper[i] = (e, v) => e.KGLKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NOTICES_AVAILABLE":
                        mapper[i] = (e, v) => e.NOTICES_AVAILABLE = v;
                        break;
                    case "ASCL":
                        mapper[i] = (e, v) => e.ASCL = v;
                        break;
                    case "CASESKEY":
                        mapper[i] = (e, v) => e.CASESKEY = v;
                        break;
                    case "CASES_CASES21_CONV":
                        mapper[i] = (e, v) => e.CASES_CASES21_CONV = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
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
        /// Merges <see cref="KGL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGL" /> items to added or update the base <see cref="KGL" /> items</param>
        /// <returns>A merged list of <see cref="KGL" /> items</returns>
        protected override List<KGL> ApplyDeltaItems(List<KGL> Items, List<KGL> DeltaItems)
        {
            Dictionary<string, int> Index_KGLKEY = Items.ToIndexDictionary(i => i.KGLKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGL deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGLKEY.TryGetValue(deltaItem.KGLKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGLKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGL>> Index_KGLKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KGL>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGL FindByKGLKEY(string KGLKEY)
        {
            return Index_KGLKEY.Value[KGLKEY];
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <param name="Value">Related KGL entity</param>
        /// <returns>True if the related KGL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGLKEY(string KGLKEY, out KGL Value)
        {
            return Index_KGLKEY.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGL TryFindByKGLKEY(string KGLKEY)
        {
            KGL value;
            if (Index_KGLKEY.Value.TryGetValue(KGLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <returns>List of related KGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGL> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <param name="Value">List of related KGL entities</param>
        /// <returns>True if the list of related KGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KGL> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <returns>List of related KGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGL> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KGL> value;
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
        /// Returns SQL which checks for the existence of a KGL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGL](
        [KGLKEY] varchar(7) NOT NULL,
        [DESCRIPTION] varchar(75) NULL,
        [NOTICES_AVAILABLE] varchar(1) NULL,
        [ASCL] varchar(4) NULL,
        [CASESKEY] varchar(2) NULL,
        [CASES_CASES21_CONV] varchar(1) NULL,
        [OBSOLETE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGL_Index_KGLKEY] PRIMARY KEY CLUSTERED (
            [KGLKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGL_Index_LW_DATE] ON [dbo].[KGL]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLDataReader : IDataReader, IDataRecord
        {
            private List<KGL> Items;
            private int CurrentIndex;
            private KGL CurrentItem;

            public KGLDataReader(List<KGL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 10; } }
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
                    case 0: // KGLKEY
                        return CurrentItem.KGLKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // NOTICES_AVAILABLE
                        return CurrentItem.NOTICES_AVAILABLE;
                    case 3: // ASCL
                        return CurrentItem.ASCL;
                    case 4: // CASESKEY
                        return CurrentItem.CASESKEY;
                    case 5: // CASES_CASES21_CONV
                        return CurrentItem.CASES_CASES21_CONV;
                    case 6: // OBSOLETE
                        return CurrentItem.OBSOLETE;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 9: // LW_USER
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
                    case 2: // NOTICES_AVAILABLE
                        return CurrentItem.NOTICES_AVAILABLE == null;
                    case 3: // ASCL
                        return CurrentItem.ASCL == null;
                    case 4: // CASESKEY
                        return CurrentItem.CASESKEY == null;
                    case 5: // CASES_CASES21_CONV
                        return CurrentItem.CASES_CASES21_CONV == null;
                    case 6: // OBSOLETE
                        return CurrentItem.OBSOLETE == null;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 9: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGLKEY
                        return "KGLKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // NOTICES_AVAILABLE
                        return "NOTICES_AVAILABLE";
                    case 3: // ASCL
                        return "ASCL";
                    case 4: // CASESKEY
                        return "CASESKEY";
                    case 5: // CASES_CASES21_CONV
                        return "CASES_CASES21_CONV";
                    case 6: // OBSOLETE
                        return "OBSOLETE";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGLKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "NOTICES_AVAILABLE":
                        return 2;
                    case "ASCL":
                        return 3;
                    case "CASESKEY":
                        return 4;
                    case "CASES_CASES21_CONV":
                        return 5;
                    case "OBSOLETE":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
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
