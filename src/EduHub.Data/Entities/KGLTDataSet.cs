using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLTDataSet : EduHubDataSet<KGLT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLT"; } }

        internal KGLTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GL_TYPE = new Lazy<Dictionary<string, KGLT>>(() => this.ToDictionary(i => i.GL_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLT" /> fields for each CSV column header</returns>
        protected override Action<KGLT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GL_TYPE":
                        mapper[i] = (e, v) => e.GL_TYPE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
        /// Merges <see cref="KGLT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGLT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGLT" /> items to added or update the base <see cref="KGLT" /> items</param>
        /// <returns>A merged list of <see cref="KGLT" /> items</returns>
        protected override List<KGLT> ApplyDeltaItems(List<KGLT> Items, List<KGLT> DeltaItems)
        {
            Dictionary<string, int> Index_GL_TYPE = Items.ToIndexDictionary(i => i.GL_TYPE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGLT deltaItem in DeltaItems)
            {
                int index;

                if (Index_GL_TYPE.TryGetValue(deltaItem.GL_TYPE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.GL_TYPE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGLT>> Index_GL_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLT by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find KGLT</param>
        /// <returns>Related KGLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLT FindByGL_TYPE(string GL_TYPE)
        {
            return Index_GL_TYPE.Value[GL_TYPE];
        }

        /// <summary>
        /// Attempt to find KGLT by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find KGLT</param>
        /// <param name="Value">Related KGLT entity</param>
        /// <returns>True if the related KGLT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_TYPE(string GL_TYPE, out KGLT Value)
        {
            return Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find KGLT by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find KGLT</param>
        /// <returns>Related KGLT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLT TryFindByGL_TYPE(string GL_TYPE)
        {
            KGLT value;
            if (Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out value))
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
        /// Returns SQL which checks for the existence of a KGLT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGLT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGLT](
        [GL_TYPE] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGLT_Index_GL_TYPE] PRIMARY KEY CLUSTERED (
            [GL_TYPE] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGLTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLTDataReader : IDataReader, IDataRecord
        {
            private List<KGLT> Items;
            private int CurrentIndex;
            private KGLT CurrentItem;

            public KGLTDataReader(List<KGLT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 5; } }
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
                    case 0: // GL_TYPE
                        return CurrentItem.GL_TYPE;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 3: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 3: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 4: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // GL_TYPE
                        return "GL_TYPE";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "GL_TYPE":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
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
