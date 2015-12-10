using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PFDataSet : DataSetBase<PF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PF"; } }

        internal PFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PF>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_PFKEY = new Lazy<Dictionary<string, PF>>(() => this.ToDictionary(i => i.PFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PF" /> fields for each CSV column header</returns>
        protected override Action<PF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PFKEY":
                        mapper[i] = (e, v) => e.PFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "CREATE_EXPORT_FILE":
                        mapper[i] = (e, v) => e.CREATE_EXPORT_FILE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
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
        /// Merges <see cref="PF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PF" /> items to added or update the base <see cref="PF" /> items</param>
        /// <returns>A merged list of <see cref="PF" /> items</returns>
        protected override List<PF> ApplyDeltaItems(List<PF> Items, List<PF> DeltaItems)
        {
            Dictionary<string, int> Index_PFKEY = Items.ToIndexDictionary(i => i.PFKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PF deltaItem in DeltaItems)
            {
                int index;

                if (Index_PFKEY.TryGetValue(deltaItem.PFKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PFKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PF>>> Index_GLCODE;
        private Lazy<Dictionary<string, PF>> Index_PFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <returns>List of related PF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PF> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <param name="Value">List of related PF entities</param>
        /// <returns>True if the list of related PF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PF> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <returns>List of related PF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PF> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PF> value;
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
        /// Find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <returns>Related PF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PF FindByPFKEY(string PFKEY)
        {
            return Index_PFKEY.Value[PFKEY];
        }

        /// <summary>
        /// Attempt to find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <param name="Value">Related PF entity</param>
        /// <returns>True if the related PF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPFKEY(string PFKEY, out PF Value)
        {
            return Index_PFKEY.Value.TryGetValue(PFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <returns>Related PF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PF TryFindByPFKEY(string PFKEY)
        {
            PF value;
            if (Index_PFKEY.Value.TryGetValue(PFKEY, out value))
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
        /// Returns SQL which checks for the existence of a PF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PF](
        [PFKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [CREATE_EXPORT_FILE] varchar(1) NULL,
        [ABN] varchar(11) NULL,
        [USI] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PF_Index_PFKEY] PRIMARY KEY CLUSTERED (
            [PFKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PF_Index_GLCODE] ON [dbo].[PF]
    (
            [GLCODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PFDataReader : IDataReader, IDataRecord
        {
            private List<PF> Items;
            private int CurrentIndex;
            private PF CurrentItem;

            public PFDataReader(List<PF> Items)
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
                    case 0: // PFKEY
                        return CurrentItem.PFKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // GLCODE
                        return CurrentItem.GLCODE;
                    case 3: // CREATE_EXPORT_FILE
                        return CurrentItem.CREATE_EXPORT_FILE;
                    case 4: // ABN
                        return CurrentItem.ABN;
                    case 5: // USI
                        return CurrentItem.USI;
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
                    case 2: // GLCODE
                        return CurrentItem.GLCODE == null;
                    case 3: // CREATE_EXPORT_FILE
                        return CurrentItem.CREATE_EXPORT_FILE == null;
                    case 4: // ABN
                        return CurrentItem.ABN == null;
                    case 5: // USI
                        return CurrentItem.USI == null;
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
                    case 0: // PFKEY
                        return "PFKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // CREATE_EXPORT_FILE
                        return "CREATE_EXPORT_FILE";
                    case 4: // ABN
                        return "ABN";
                    case 5: // USI
                        return "USI";
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
                    case "PFKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "CREATE_EXPORT_FILE":
                        return 3;
                    case "ABN":
                        return 4;
                    case "USI":
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
