using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PDDataSet : DataSetBase<PD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PD"; } }

        internal PDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLBANK = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLBANK));
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GLTAX = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLTAX));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PDKEY = new Lazy<Dictionary<string, PD>>(() => this.ToDictionary(i => i.PDKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PD" /> fields for each CSV column header</returns>
        protected override Action<PD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PDKEY":
                        mapper[i] = (e, v) => e.PDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANK":
                        mapper[i] = (e, v) => e.GLBANK = v;
                        break;
                    case "GLTAX":
                        mapper[i] = (e, v) => e.GLTAX = v;
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
        /// Merges <see cref="PD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PD" /> items to added or update the base <see cref="PD" /> items</param>
        /// <returns>A merged list of <see cref="PD" /> items</returns>
        protected override List<PD> ApplyDeltaItems(List<PD> Items, List<PD> DeltaItems)
        {
            Dictionary<string, int> Index_PDKEY = Items.ToIndexDictionary(i => i.PDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PD deltaItem in DeltaItems)
            {
                int index;

                if (Index_PDKEY.TryGetValue(deltaItem.PDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLBANK;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLTAX;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, PD>> Index_PDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLBANK(string GLBANK)
        {
            return Index_GLBANK.Value[GLBANK];
        }

        /// <summary>
        /// Attempt to find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANK(string GLBANK, out IReadOnlyList<PD> Value)
        {
            return Index_GLBANK.Value.TryGetValue(GLBANK, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLBANK(string GLBANK)
        {
            IReadOnlyList<PD> value;
            if (Index_GLBANK.Value.TryGetValue(GLBANK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PD> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PD> value;
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
        /// Find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLTAX(string GLTAX)
        {
            return Index_GLTAX.Value[GLTAX];
        }

        /// <summary>
        /// Attempt to find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLTAX(string GLTAX, out IReadOnlyList<PD> Value)
        {
            return Index_GLTAX.Value.TryGetValue(GLTAX, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLTAX(string GLTAX)
        {
            IReadOnlyList<PD> value;
            if (Index_GLTAX.Value.TryGetValue(GLTAX, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PD> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PD> value;
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
        /// Find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <returns>Related PD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PD FindByPDKEY(string PDKEY)
        {
            return Index_PDKEY.Value[PDKEY];
        }

        /// <summary>
        /// Attempt to find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <param name="Value">Related PD entity</param>
        /// <returns>True if the related PD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPDKEY(string PDKEY, out PD Value)
        {
            return Index_PDKEY.Value.TryGetValue(PDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <returns>Related PD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PD TryFindByPDKEY(string PDKEY)
        {
            PD value;
            if (Index_PDKEY.Value.TryGetValue(PDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PD> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PD> value;
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
        /// Returns SQL which checks for the existence of a PD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PD](
        [PDKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [GLBANK] varchar(10) NULL,
        [GLTAX] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PD_Index_PDKEY] PRIMARY KEY CLUSTERED (
            [PDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PD_Index_GLBANK] ON [dbo].[PD]
    (
            [GLBANK] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_GLCODE] ON [dbo].[PD]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_GLTAX] ON [dbo].[PD]
    (
            [GLTAX] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_INITIATIVE] ON [dbo].[PD]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_SUBPROGRAM] ON [dbo].[PD]
    (
            [SUBPROGRAM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PDDataReader : IDataReader, IDataRecord
        {
            private List<PD> Items;
            private int CurrentIndex;
            private PD CurrentItem;

            public PDDataReader(List<PD> Items)
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
                    case 0: // PDKEY
                        return CurrentItem.PDKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // GLCODE
                        return CurrentItem.GLCODE;
                    case 3: // GLBANK
                        return CurrentItem.GLBANK;
                    case 4: // GLTAX
                        return CurrentItem.GLTAX;
                    case 5: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 6: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 7: // INITIATIVE
                        return CurrentItem.INITIATIVE;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // GLCODE
                        return CurrentItem.GLCODE == null;
                    case 3: // GLBANK
                        return CurrentItem.GLBANK == null;
                    case 4: // GLTAX
                        return CurrentItem.GLTAX == null;
                    case 5: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 6: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 7: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
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
                    case 0: // PDKEY
                        return "PDKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // GLBANK
                        return "GLBANK";
                    case 4: // GLTAX
                        return "GLTAX";
                    case 5: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 6: // GLPROGRAM
                        return "GLPROGRAM";
                    case 7: // INITIATIVE
                        return "INITIATIVE";
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
                    case "PDKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "GLBANK":
                        return 3;
                    case "GLTAX":
                        return 4;
                    case "SUBPROGRAM":
                        return 5;
                    case "GLPROGRAM":
                        return 6;
                    case "INITIATIVE":
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
