using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDFCDataSet : EduHubDataSet<SDFC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDFC"; } }

        internal SDFCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SDFCKEY = new Lazy<Dictionary<string, SDFC>>(() => this.ToDictionary(i => i.SDFCKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDFC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDFC" /> fields for each CSV column header</returns>
        protected override Action<SDFC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDFC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDFCKEY":
                        mapper[i] = (e, v) => e.SDFCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SDGROUP":
                        mapper[i] = (e, v) => e.SDGROUP = v;
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
        /// Merges <see cref="SDFC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDFC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDFC" /> items to added or update the base <see cref="SDFC" /> items</param>
        /// <returns>A merged list of <see cref="SDFC" /> items</returns>
        protected override List<SDFC> ApplyDeltaItems(List<SDFC> Items, List<SDFC> DeltaItems)
        {
            Dictionary<string, int> Index_SDFCKEY = Items.ToIndexDictionary(i => i.SDFCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDFC deltaItem in DeltaItems)
            {
                int index;

                if (Index_SDFCKEY.TryGetValue(deltaItem.SDFCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SDFCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, SDFC>> Index_SDFCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find SDFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<SDFC> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<SDFC> value;
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
        /// Find SDFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find SDFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<SDFC> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<SDFC> value;
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
        /// Find SDFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find SDFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<SDFC> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<SDFC> value;
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
        /// Find SDFC by SDFCKEY field
        /// </summary>
        /// <param name="SDFCKEY">SDFCKEY value used to find SDFC</param>
        /// <returns>Related SDFC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDFC FindBySDFCKEY(string SDFCKEY)
        {
            return Index_SDFCKEY.Value[SDFCKEY];
        }

        /// <summary>
        /// Attempt to find SDFC by SDFCKEY field
        /// </summary>
        /// <param name="SDFCKEY">SDFCKEY value used to find SDFC</param>
        /// <param name="Value">Related SDFC entity</param>
        /// <returns>True if the related SDFC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDFCKEY(string SDFCKEY, out SDFC Value)
        {
            return Index_SDFCKEY.Value.TryGetValue(SDFCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by SDFCKEY field
        /// </summary>
        /// <param name="SDFCKEY">SDFCKEY value used to find SDFC</param>
        /// <returns>Related SDFC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDFC TryFindBySDFCKEY(string SDFCKEY)
        {
            SDFC value;
            if (Index_SDFCKEY.Value.TryGetValue(SDFCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find SDFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<SDFC> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<SDFC> value;
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
        /// Returns SQL which checks for the existence of a SDFC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDFC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDFC](
        [SDFCKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [SDGROUP] varchar(10) NULL,
        [STATEMENT] varchar(1) NULL,
        [METHOD] varchar(1) NULL,
        [AMOUNT] money NULL,
        [GROSS_AMOUNT] money NULL,
        [GLCODE] varchar(10) NULL,
        [GST_TYPE] varchar(4) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDFC_Index_SDFCKEY] PRIMARY KEY CLUSTERED (
            [SDFCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SDFC_Index_GLCODE] ON [dbo].[SDFC]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [SDFC_Index_GST_TYPE] ON [dbo].[SDFC]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SDFC_Index_INITIATIVE] ON [dbo].[SDFC]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [SDFC_Index_SUBPROGRAM] ON [dbo].[SDFC]
    (
            [SUBPROGRAM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDFC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDFC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SDFCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDFCDataReader : IDataReader, IDataRecord
        {
            private List<SDFC> Items;
            private int CurrentIndex;
            private SDFC CurrentItem;

            public SDFCDataReader(List<SDFC> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 15; } }
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
                    case 0: // SDFCKEY
                        return CurrentItem.SDFCKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // SDGROUP
                        return CurrentItem.SDGROUP;
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
                    case 8: // GST_TYPE
                        return CurrentItem.GST_TYPE;
                    case 9: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 10: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 11: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 14: // LW_USER
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
                    case 2: // SDGROUP
                        return CurrentItem.SDGROUP == null;
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
                    case 8: // GST_TYPE
                        return CurrentItem.GST_TYPE == null;
                    case 9: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 10: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 11: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SDFCKEY
                        return "SDFCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SDGROUP
                        return "SDGROUP";
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
                    case 8: // GST_TYPE
                        return "GST_TYPE";
                    case 9: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 10: // GLPROGRAM
                        return "GLPROGRAM";
                    case 11: // INITIATIVE
                        return "INITIATIVE";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SDFCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SDGROUP":
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
                    case "GST_TYPE":
                        return 8;
                    case "SUBPROGRAM":
                        return 9;
                    case "GLPROGRAM":
                        return 10;
                    case "INITIATIVE":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
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
