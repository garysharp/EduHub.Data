using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCLDataSet : EduHubDataSet<KPCL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPCL"; } }

        internal KPCLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<KPCL>>>(() => this.ToGroupedNullDictionary(i => i.CONTACT));
            Index_CONTACT_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<KPCL>>>(() => this.ToGroupedNullDictionary(i => i.CONTACT_TYPE));
            Index_KPCLKEY = new Lazy<Dictionary<int, KPCL>>(() => this.ToDictionary(i => i.KPCLKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCL" /> fields for each CSV column header</returns>
        protected override Action<KPCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCLKEY":
                        mapper[i] = (e, v) => e.KPCLKEY = int.Parse(v);
                        break;
                    case "LINK":
                        mapper[i] = (e, v) => e.LINK = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_TYPE":
                        mapper[i] = (e, v) => e.CONTACT_TYPE = v;
                        break;
                    case "CONTACT_PREFERENCE":
                        mapper[i] = (e, v) => e.CONTACT_PREFERENCE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KPCL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPCL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPCL" /> items to added or update the base <see cref="KPCL" /> items</param>
        /// <returns>A merged list of <see cref="KPCL" /> items</returns>
        protected override List<KPCL> ApplyDeltaItems(List<KPCL> Items, List<KPCL> DeltaItems)
        {
            Dictionary<int, int> Index_KPCLKEY = Items.ToIndexDictionary(i => i.KPCLKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPCL deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPCLKEY.TryGetValue(deltaItem.KPCLKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPCLKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KPCL>>> Index_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<KPCL>>> Index_CONTACT_TYPE;
        private Lazy<Dictionary<int, KPCL>> Index_KPCLKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <returns>List of related KPCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> FindByCONTACT(string CONTACT)
        {
            return Index_CONTACT.Value[CONTACT];
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <param name="Value">List of related KPCL entities</param>
        /// <returns>True if the list of related KPCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCONTACT(string CONTACT, out IReadOnlyList<KPCL> Value)
        {
            return Index_CONTACT.Value.TryGetValue(CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <returns>List of related KPCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> TryFindByCONTACT(string CONTACT)
        {
            IReadOnlyList<KPCL> value;
            if (Index_CONTACT.Value.TryGetValue(CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <returns>List of related KPCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> FindByCONTACT_TYPE(string CONTACT_TYPE)
        {
            return Index_CONTACT_TYPE.Value[CONTACT_TYPE];
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <param name="Value">List of related KPCL entities</param>
        /// <returns>True if the list of related KPCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCONTACT_TYPE(string CONTACT_TYPE, out IReadOnlyList<KPCL> Value)
        {
            return Index_CONTACT_TYPE.Value.TryGetValue(CONTACT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <returns>List of related KPCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> TryFindByCONTACT_TYPE(string CONTACT_TYPE)
        {
            IReadOnlyList<KPCL> value;
            if (Index_CONTACT_TYPE.Value.TryGetValue(CONTACT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCL FindByKPCLKEY(int KPCLKEY)
        {
            return Index_KPCLKEY.Value[KPCLKEY];
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <param name="Value">Related KPCL entity</param>
        /// <returns>True if the related KPCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCLKEY(int KPCLKEY, out KPCL Value)
        {
            return Index_KPCLKEY.Value.TryGetValue(KPCLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCL TryFindByKPCLKEY(int KPCLKEY)
        {
            KPCL value;
            if (Index_KPCLKEY.Value.TryGetValue(KPCLKEY, out value))
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
        /// Returns SQL which checks for the existence of a KPCL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPCL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPCL](
        [KPCLKEY] int IDENTITY NOT NULL,
        [LINK] varchar(10) NULL,
        [SOURCE] varchar(3) NULL,
        [CONTACT] varchar(10) NULL,
        [CONTACT_TYPE] varchar(10) NULL,
        [CONTACT_PREFERENCE] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPCL_Index_KPCLKEY] PRIMARY KEY CLUSTERED (
            [KPCLKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KPCL_Index_CONTACT] ON [dbo].[KPCL]
    (
            [CONTACT] ASC
    );
    CREATE NONCLUSTERED INDEX [KPCL_Index_CONTACT_TYPE] ON [dbo].[KPCL]
    (
            [CONTACT_TYPE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPCL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPCL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KPCLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPCLDataReader : IDataReader, IDataRecord
        {
            private List<KPCL> Items;
            private int CurrentIndex;
            private KPCL CurrentItem;

            public KPCLDataReader(List<KPCL> Items)
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
                    case 0: // KPCLKEY
                        return CurrentItem.KPCLKEY;
                    case 1: // LINK
                        return CurrentItem.LINK;
                    case 2: // SOURCE
                        return CurrentItem.SOURCE;
                    case 3: // CONTACT
                        return CurrentItem.CONTACT;
                    case 4: // CONTACT_TYPE
                        return CurrentItem.CONTACT_TYPE;
                    case 5: // CONTACT_PREFERENCE
                        return CurrentItem.CONTACT_PREFERENCE;
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
                    case 1: // LINK
                        return CurrentItem.LINK == null;
                    case 2: // SOURCE
                        return CurrentItem.SOURCE == null;
                    case 3: // CONTACT
                        return CurrentItem.CONTACT == null;
                    case 4: // CONTACT_TYPE
                        return CurrentItem.CONTACT_TYPE == null;
                    case 5: // CONTACT_PREFERENCE
                        return CurrentItem.CONTACT_PREFERENCE == null;
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
                    case 0: // KPCLKEY
                        return "KPCLKEY";
                    case 1: // LINK
                        return "LINK";
                    case 2: // SOURCE
                        return "SOURCE";
                    case 3: // CONTACT
                        return "CONTACT";
                    case 4: // CONTACT_TYPE
                        return "CONTACT_TYPE";
                    case 5: // CONTACT_PREFERENCE
                        return "CONTACT_PREFERENCE";
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
                    case "KPCLKEY":
                        return 0;
                    case "LINK":
                        return 1;
                    case "SOURCE":
                        return 2;
                    case "CONTACT":
                        return 3;
                    case "CONTACT_TYPE":
                        return 4;
                    case "CONTACT_PREFERENCE":
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
