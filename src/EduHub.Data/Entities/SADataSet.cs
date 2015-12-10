using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADataSet : DataSetBase<SA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SA"; } }

        internal SADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<SA>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SA>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<SA>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SAKEY = new Lazy<Dictionary<string, SA>>(() => this.ToDictionary(i => i.SAKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<SA>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SA" /> fields for each CSV column header</returns>
        protected override Action<SA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAKEY":
                        mapper[i] = (e, v) => e.SAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SAGROUP":
                        mapper[i] = (e, v) => e.SAGROUP = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
                        break;
                    case "METHOD":
                        mapper[i] = (e, v) => e.METHOD = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS_AMOUNT":
                        mapper[i] = (e, v) => e.GROSS_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "VOLUNTARY":
                        mapper[i] = (e, v) => e.VOLUNTARY = v;
                        break;
                    case "SPLIT_BILLING":
                        mapper[i] = (e, v) => e.SPLIT_BILLING = v;
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
        /// Merges <see cref="SA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SA" /> items to added or update the base <see cref="SA" /> items</param>
        /// <returns>A merged list of <see cref="SA" /> items</returns>
        protected override List<SA> ApplyDeltaItems(List<SA> Items, List<SA> DeltaItems)
        {
            Dictionary<string, int> Index_SAKEY = Items.ToIndexDictionary(i => i.SAKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SA deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAKEY.TryGetValue(deltaItem.SAKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SA>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<SA>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SA>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, SA>> Index_SAKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SA>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SA by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SA</param>
        /// <returns>List of related SA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find SA by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SA</param>
        /// <param name="Value">List of related SA entities</param>
        /// <returns>True if the list of related SA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<SA> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find SA by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SA</param>
        /// <returns>List of related SA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<SA> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SA by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SA</param>
        /// <returns>List of related SA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find SA by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SA</param>
        /// <param name="Value">List of related SA entities</param>
        /// <returns>True if the list of related SA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<SA> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SA by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SA</param>
        /// <returns>List of related SA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<SA> value;
            if (Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SA by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SA</param>
        /// <returns>List of related SA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find SA by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SA</param>
        /// <param name="Value">List of related SA entities</param>
        /// <returns>True if the list of related SA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<SA> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find SA by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SA</param>
        /// <returns>List of related SA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<SA> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SA by SAKEY field
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SA</param>
        /// <returns>Related SA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SA FindBySAKEY(string SAKEY)
        {
            return Index_SAKEY.Value[SAKEY];
        }

        /// <summary>
        /// Attempt to find SA by SAKEY field
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SA</param>
        /// <param name="Value">Related SA entity</param>
        /// <returns>True if the related SA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAKEY(string SAKEY, out SA Value)
        {
            return Index_SAKEY.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SA by SAKEY field
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SA</param>
        /// <returns>Related SA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SA TryFindBySAKEY(string SAKEY)
        {
            SA value;
            if (Index_SAKEY.Value.TryGetValue(SAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SA by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SA</param>
        /// <returns>List of related SA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find SA by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SA</param>
        /// <param name="Value">List of related SA entities</param>
        /// <returns>True if the list of related SA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<SA> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find SA by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SA</param>
        /// <returns>List of related SA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SA> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<SA> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
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
        /// Returns SQL which checks for the existence of a SA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SA](
        [SAKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [SAGROUP] varchar(10) NULL,
        [STATEMENT] varchar(1) NULL,
        [METHOD] varchar(1) NULL,
        [AMOUNT] money NULL,
        [GROSS_AMOUNT] money NULL,
        [GLCODE] varchar(10) NULL,
        [FREQUENCY] smallint NULL,
        [GST_TYPE] varchar(4) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [VOLUNTARY] varchar(1) NULL,
        [SPLIT_BILLING] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SA_Index_SAKEY] PRIMARY KEY CLUSTERED (
            [SAKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SA_Index_GLCODE] ON [dbo].[SA]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [SA_Index_GST_TYPE] ON [dbo].[SA]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SA_Index_INITIATIVE] ON [dbo].[SA]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [SA_Index_SUBPROGRAM] ON [dbo].[SA]
    (
            [SUBPROGRAM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADataReader : IDataReader, IDataRecord
        {
            private List<SA> Items;
            private int CurrentIndex;
            private SA CurrentItem;

            public SADataReader(List<SA> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 18; } }
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
                    case 0: // SAKEY
                        return CurrentItem.SAKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // SAGROUP
                        return CurrentItem.SAGROUP;
                    case 3: // STATEMENT
                        return CurrentItem.STATEMENT;
                    case 4: // METHOD
                        return CurrentItem.METHOD;
                    case 5: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 6: // GROSS_AMOUNT
                        return CurrentItem.GROSS_AMOUNT;
                    case 7: // GLCODE
                        return CurrentItem.GLCODE;
                    case 8: // FREQUENCY
                        return CurrentItem.FREQUENCY;
                    case 9: // GST_TYPE
                        return CurrentItem.GST_TYPE;
                    case 10: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 11: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 12: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 13: // VOLUNTARY
                        return CurrentItem.VOLUNTARY;
                    case 14: // SPLIT_BILLING
                        return CurrentItem.SPLIT_BILLING;
                    case 15: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 16: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 17: // LW_USER
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
                    case 2: // SAGROUP
                        return CurrentItem.SAGROUP == null;
                    case 3: // STATEMENT
                        return CurrentItem.STATEMENT == null;
                    case 4: // METHOD
                        return CurrentItem.METHOD == null;
                    case 5: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 6: // GROSS_AMOUNT
                        return CurrentItem.GROSS_AMOUNT == null;
                    case 7: // GLCODE
                        return CurrentItem.GLCODE == null;
                    case 8: // FREQUENCY
                        return CurrentItem.FREQUENCY == null;
                    case 9: // GST_TYPE
                        return CurrentItem.GST_TYPE == null;
                    case 10: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 11: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 12: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 13: // VOLUNTARY
                        return CurrentItem.VOLUNTARY == null;
                    case 14: // SPLIT_BILLING
                        return CurrentItem.SPLIT_BILLING == null;
                    case 15: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 16: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 17: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SAKEY
                        return "SAKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SAGROUP
                        return "SAGROUP";
                    case 3: // STATEMENT
                        return "STATEMENT";
                    case 4: // METHOD
                        return "METHOD";
                    case 5: // AMOUNT
                        return "AMOUNT";
                    case 6: // GROSS_AMOUNT
                        return "GROSS_AMOUNT";
                    case 7: // GLCODE
                        return "GLCODE";
                    case 8: // FREQUENCY
                        return "FREQUENCY";
                    case 9: // GST_TYPE
                        return "GST_TYPE";
                    case 10: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 11: // GLPROGRAM
                        return "GLPROGRAM";
                    case 12: // INITIATIVE
                        return "INITIATIVE";
                    case 13: // VOLUNTARY
                        return "VOLUNTARY";
                    case 14: // SPLIT_BILLING
                        return "SPLIT_BILLING";
                    case 15: // LW_DATE
                        return "LW_DATE";
                    case 16: // LW_TIME
                        return "LW_TIME";
                    case 17: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SAKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SAGROUP":
                        return 2;
                    case "STATEMENT":
                        return 3;
                    case "METHOD":
                        return 4;
                    case "AMOUNT":
                        return 5;
                    case "GROSS_AMOUNT":
                        return 6;
                    case "GLCODE":
                        return 7;
                    case "FREQUENCY":
                        return 8;
                    case "GST_TYPE":
                        return 9;
                    case "SUBPROGRAM":
                        return 10;
                    case "GLPROGRAM":
                        return 11;
                    case "INITIATIVE":
                        return 12;
                    case "VOLUNTARY":
                        return 13;
                    case "SPLIT_BILLING":
                        return 14;
                    case "LW_DATE":
                        return 15;
                    case "LW_TIME":
                        return 16;
                    case "LW_USER":
                        return 17;
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
