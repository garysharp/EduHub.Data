using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSFDataSet : DataSetBase<SCSF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCSF"; } }

        internal SCSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCSFKEY = new Lazy<Dictionary<string, SCSF>>(() => this.ToDictionary(i => i.SCSFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSF" /> fields for each CSV column header</returns>
        protected override Action<SCSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "KLA":
                        mapper[i] = (e, v) => e.KLA = v;
                        break;
                    case "STRAND":
                        mapper[i] = (e, v) => e.STRAND = v;
                        break;
                    case "SUB_STRAND":
                        mapper[i] = (e, v) => e.SUB_STRAND = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "DEET_REQUIRED":
                        mapper[i] = (e, v) => e.DEET_REQUIRED = v;
                        break;
                    case "LOW_LEVEL":
                        mapper[i] = (e, v) => e.LOW_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HIGH_LEVEL":
                        mapper[i] = (e, v) => e.HIGH_LEVEL = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SCSF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCSF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCSF" /> items to added or update the base <see cref="SCSF" /> items</param>
        /// <returns>A merged list of <see cref="SCSF" /> items</returns>
        protected override List<SCSF> ApplyDeltaItems(List<SCSF> Items, List<SCSF> DeltaItems)
        {
            Dictionary<string, int> Index_SCSFKEY = Items.ToIndexDictionary(i => i.SCSFKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCSF deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCSFKEY.TryGetValue(deltaItem.SCSFKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCSFKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SCSF>> Index_SCSFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSF FindBySCSFKEY(string SCSFKEY)
        {
            return Index_SCSFKEY.Value[SCSFKEY];
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <param name="Value">Related SCSF entity</param>
        /// <returns>True if the related SCSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY(string SCSFKEY, out SCSF Value)
        {
            return Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSF TryFindBySCSFKEY(string SCSFKEY)
        {
            SCSF value;
            if (Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out value))
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
        /// Returns SQL which checks for the existence of a SCSF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCSF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCSF](
        [SCSFKEY] varchar(5) NOT NULL,
        [KLA] varchar(40) NULL,
        [STRAND] varchar(40) NULL,
        [SUB_STRAND] varchar(40) NULL,
        [ENABLED] varchar(1) NULL,
        [DEET_REQUIRED] varchar(1) NULL,
        [LOW_LEVEL] smallint NULL,
        [HIGH_LEVEL] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCSF_Index_SCSFKEY] PRIMARY KEY CLUSTERED (
            [SCSFKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCSF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCSFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCSFDataReader : IDataReader, IDataRecord
        {
            private List<SCSF> Items;
            private int CurrentIndex;
            private SCSF CurrentItem;

            public SCSFDataReader(List<SCSF> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 0: // SCSFKEY
                        return CurrentItem.SCSFKEY;
                    case 1: // KLA
                        return CurrentItem.KLA;
                    case 2: // STRAND
                        return CurrentItem.STRAND;
                    case 3: // SUB_STRAND
                        return CurrentItem.SUB_STRAND;
                    case 4: // ENABLED
                        return CurrentItem.ENABLED;
                    case 5: // DEET_REQUIRED
                        return CurrentItem.DEET_REQUIRED;
                    case 6: // LOW_LEVEL
                        return CurrentItem.LOW_LEVEL;
                    case 7: // HIGH_LEVEL
                        return CurrentItem.HIGH_LEVEL;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // KLA
                        return CurrentItem.KLA == null;
                    case 2: // STRAND
                        return CurrentItem.STRAND == null;
                    case 3: // SUB_STRAND
                        return CurrentItem.SUB_STRAND == null;
                    case 4: // ENABLED
                        return CurrentItem.ENABLED == null;
                    case 5: // DEET_REQUIRED
                        return CurrentItem.DEET_REQUIRED == null;
                    case 6: // LOW_LEVEL
                        return CurrentItem.LOW_LEVEL == null;
                    case 7: // HIGH_LEVEL
                        return CurrentItem.HIGH_LEVEL == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCSFKEY
                        return "SCSFKEY";
                    case 1: // KLA
                        return "KLA";
                    case 2: // STRAND
                        return "STRAND";
                    case 3: // SUB_STRAND
                        return "SUB_STRAND";
                    case 4: // ENABLED
                        return "ENABLED";
                    case 5: // DEET_REQUIRED
                        return "DEET_REQUIRED";
                    case 6: // LOW_LEVEL
                        return "LOW_LEVEL";
                    case 7: // HIGH_LEVEL
                        return "HIGH_LEVEL";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCSFKEY":
                        return 0;
                    case "KLA":
                        return 1;
                    case "STRAND":
                        return 2;
                    case "SUB_STRAND":
                        return 3;
                    case "ENABLED":
                        return 4;
                    case "DEET_REQUIRED":
                        return 5;
                    case "LOW_LEVEL":
                        return 6;
                    case "HIGH_LEVEL":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
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
