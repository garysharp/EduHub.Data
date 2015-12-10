using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLPROGDataSet : DataSetBase<KGLPROG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLPROG"; } }

        internal KGLPROGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLPROGRAM = new Lazy<Dictionary<string, KGLPROG>>(() => this.ToDictionary(i => i.GLPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLPROG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLPROG" /> fields for each CSV column header</returns>
        protected override Action<KGLPROG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLPROG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KGLPROG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGLPROG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGLPROG" /> items to added or update the base <see cref="KGLPROG" /> items</param>
        /// <returns>A merged list of <see cref="KGLPROG" /> items</returns>
        protected override List<KGLPROG> ApplyDeltaItems(List<KGLPROG> Items, List<KGLPROG> DeltaItems)
        {
            Dictionary<string, int> Index_GLPROGRAM = Items.ToIndexDictionary(i => i.GLPROGRAM);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGLPROG deltaItem in DeltaItems)
            {
                int index;

                if (Index_GLPROGRAM.TryGetValue(deltaItem.GLPROGRAM, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.GLPROGRAM)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGLPROG>> Index_GLPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLPROG FindByGLPROGRAM(string GLPROGRAM)
        {
            return Index_GLPROGRAM.Value[GLPROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <param name="Value">Related KGLPROG entity</param>
        /// <returns>True if the related KGLPROG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM(string GLPROGRAM, out KGLPROG Value)
        {
            return Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLPROG TryFindByGLPROGRAM(string GLPROGRAM)
        {
            KGLPROG value;
            if (Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out value))
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
        /// Returns SQL which checks for the existence of a KGLPROG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGLPROG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGLPROG](
        [GLPROGRAM] varchar(3) NOT NULL,
        [TITLE] varchar(30) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGLPROG_Index_GLPROGRAM] PRIMARY KEY CLUSTERED (
            [GLPROGRAM] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLPROG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLPROG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGLPROGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLPROGDataReader : IDataReader, IDataRecord
        {
            private List<KGLPROG> Items;
            private int CurrentIndex;
            private KGLPROG CurrentItem;

            public KGLPROGDataReader(List<KGLPROG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 0: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
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
                    case 2: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // GLPROGRAM
                        return "GLPROGRAM";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ACTIVE
                        return "ACTIVE";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "GLPROGRAM":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ACTIVE":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
