using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PCDataSet : DataSetBase<PC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PC"; } }

        internal PCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PCKEY = new Lazy<Dictionary<string, PC>>(() => this.ToDictionary(i => i.PCKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PC" /> fields for each CSV column header</returns>
        protected override Action<PC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PCKEY":
                        mapper[i] = (e, v) => e.PCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
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
        /// Merges <see cref="PC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PC" /> items to added or update the base <see cref="PC" /> items</param>
        /// <returns>A merged list of <see cref="PC" /> items</returns>
        protected override List<PC> ApplyDeltaItems(List<PC> Items, List<PC> DeltaItems)
        {
            Dictionary<string, int> Index_PCKEY = Items.ToIndexDictionary(i => i.PCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PC deltaItem in DeltaItems)
            {
                int index;

                if (Index_PCKEY.TryGetValue(deltaItem.PCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, PC>> Index_PCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PC> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PC> value;
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
        /// Find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PC> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PC> value;
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
        /// Find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <returns>Related PC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PC FindByPCKEY(string PCKEY)
        {
            return Index_PCKEY.Value[PCKEY];
        }

        /// <summary>
        /// Attempt to find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <param name="Value">Related PC entity</param>
        /// <returns>True if the related PC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPCKEY(string PCKEY, out PC Value)
        {
            return Index_PCKEY.Value.TryGetValue(PCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <returns>Related PC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PC TryFindByPCKEY(string PCKEY)
        {
            PC value;
            if (Index_PCKEY.Value.TryGetValue(PCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PC> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PC> value;
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
        /// Returns SQL which checks for the existence of a PC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PC](
        [PCKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PC_Index_PCKEY] PRIMARY KEY CLUSTERED (
            [PCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PC_Index_GLCODE] ON [dbo].[PC]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PC_Index_INITIATIVE] ON [dbo].[PC]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PC_Index_SUBPROGRAM] ON [dbo].[PC]
    (
            [SUBPROGRAM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PCDataReader : IDataReader, IDataRecord
        {
            private List<PC> Items;
            private int CurrentIndex;
            private PC CurrentItem;

            public PCDataReader(List<PC> Items)
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
                    case 0: // PCKEY
                        return CurrentItem.PCKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // GLCODE
                        return CurrentItem.GLCODE;
                    case 3: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 4: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 5: // INITIATIVE
                        return CurrentItem.INITIATIVE;
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
                    case 3: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 4: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 5: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
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
                    case 0: // PCKEY
                        return "PCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 4: // GLPROGRAM
                        return "GLPROGRAM";
                    case 5: // INITIATIVE
                        return "INITIATIVE";
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
                    case "PCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "SUBPROGRAM":
                        return 3;
                    case "GLPROGRAM":
                        return 4;
                    case "INITIATIVE":
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
