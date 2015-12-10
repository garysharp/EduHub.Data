using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLSUBDataSet : DataSetBase<KGLSUB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLSUB"; } }

        internal KGLSUBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GL_PROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<KGLSUB>>>(() => this.ToGroupedNullDictionary(i => i.GL_PROGRAM));
            Index_SUBPROGRAM = new Lazy<Dictionary<string, KGLSUB>>(() => this.ToDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLSUB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLSUB" /> fields for each CSV column header</returns>
        protected override Action<KGLSUB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLSUB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GL_PROGRAM":
                        mapper[i] = (e, v) => e.GL_PROGRAM = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "RESERVED":
                        mapper[i] = (e, v) => e.RESERVED = v;
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
        /// Merges <see cref="KGLSUB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGLSUB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGLSUB" /> items to added or update the base <see cref="KGLSUB" /> items</param>
        /// <returns>A merged list of <see cref="KGLSUB" /> items</returns>
        protected override List<KGLSUB> ApplyDeltaItems(List<KGLSUB> Items, List<KGLSUB> DeltaItems)
        {
            Dictionary<string, int> Index_SUBPROGRAM = Items.ToIndexDictionary(i => i.SUBPROGRAM);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGLSUB deltaItem in DeltaItems)
            {
                int index;

                if (Index_SUBPROGRAM.TryGetValue(deltaItem.SUBPROGRAM, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SUBPROGRAM)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KGLSUB>>> Index_GL_PROGRAM;
        private Lazy<Dictionary<string, KGLSUB>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <returns>List of related KGLSUB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGLSUB> FindByGL_PROGRAM(string GL_PROGRAM)
        {
            return Index_GL_PROGRAM.Value[GL_PROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <param name="Value">List of related KGLSUB entities</param>
        /// <returns>True if the list of related KGLSUB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_PROGRAM(string GL_PROGRAM, out IReadOnlyList<KGLSUB> Value)
        {
            return Index_GL_PROGRAM.Value.TryGetValue(GL_PROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <returns>List of related KGLSUB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGLSUB> TryFindByGL_PROGRAM(string GL_PROGRAM)
        {
            IReadOnlyList<KGLSUB> value;
            if (Index_GL_PROGRAM.Value.TryGetValue(GL_PROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLSUB FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <param name="Value">Related KGLSUB entity</param>
        /// <returns>True if the related KGLSUB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out KGLSUB Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLSUB TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            KGLSUB value;
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
        /// Returns SQL which checks for the existence of a KGLSUB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGLSUB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGLSUB](
        [SUBPROGRAM] varchar(4) NOT NULL,
        [TITLE] varchar(30) NULL,
        [GL_PROGRAM] varchar(3) NULL,
        [ACTIVE] varchar(1) NULL,
        [USER_DEFINABLE] varchar(1) NULL,
        [RESERVED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGLSUB_Index_SUBPROGRAM] PRIMARY KEY CLUSTERED (
            [SUBPROGRAM] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGLSUB_Index_GL_PROGRAM] ON [dbo].[KGLSUB]
    (
            [GL_PROGRAM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLSUB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLSUB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGLSUBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLSUBDataReader : IDataReader, IDataRecord
        {
            private List<KGLSUB> Items;
            private int CurrentIndex;
            private KGLSUB CurrentItem;

            public KGLSUBDataReader(List<KGLSUB> Items)
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
                    case 0: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // GL_PROGRAM
                        return CurrentItem.GL_PROGRAM;
                    case 3: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 4: // USER_DEFINABLE
                        return CurrentItem.USER_DEFINABLE;
                    case 5: // RESERVED
                        return CurrentItem.RESERVED;
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
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // GL_PROGRAM
                        return CurrentItem.GL_PROGRAM == null;
                    case 3: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 4: // USER_DEFINABLE
                        return CurrentItem.USER_DEFINABLE == null;
                    case 5: // RESERVED
                        return CurrentItem.RESERVED == null;
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
                    case 0: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // GL_PROGRAM
                        return "GL_PROGRAM";
                    case 3: // ACTIVE
                        return "ACTIVE";
                    case 4: // USER_DEFINABLE
                        return "USER_DEFINABLE";
                    case 5: // RESERVED
                        return "RESERVED";
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
                    case "SUBPROGRAM":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "GL_PROGRAM":
                        return 2;
                    case "ACTIVE":
                        return 3;
                    case "USER_DEFINABLE":
                        return 4;
                    case "RESERVED":
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
