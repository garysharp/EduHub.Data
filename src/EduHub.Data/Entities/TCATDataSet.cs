using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCATDataSet : DataSetBase<TCAT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCAT"; } }

        internal TCATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCATKEY = new Lazy<Dictionary<string, TCAT>>(() => this.ToDictionary(i => i.TCATKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCAT" /> fields for each CSV column header</returns>
        protected override Action<TCAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCATKEY":
                        mapper[i] = (e, v) => e.TCATKEY = v;
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
        /// Merges <see cref="TCAT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TCAT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TCAT" /> items to added or update the base <see cref="TCAT" /> items</param>
        /// <returns>A merged list of <see cref="TCAT" /> items</returns>
        protected override List<TCAT> ApplyDeltaItems(List<TCAT> Items, List<TCAT> DeltaItems)
        {
            Dictionary<string, int> Index_TCATKEY = Items.ToIndexDictionary(i => i.TCATKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TCAT deltaItem in DeltaItems)
            {
                int index;

                if (Index_TCATKEY.TryGetValue(deltaItem.TCATKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TCATKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, TCAT>> Index_TCATKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCAT FindByTCATKEY(string TCATKEY)
        {
            return Index_TCATKEY.Value[TCATKEY];
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <param name="Value">Related TCAT entity</param>
        /// <returns>True if the related TCAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCATKEY(string TCATKEY, out TCAT Value)
        {
            return Index_TCATKEY.Value.TryGetValue(TCATKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCAT TryFindByTCATKEY(string TCATKEY)
        {
            TCAT value;
            if (Index_TCATKEY.Value.TryGetValue(TCATKEY, out value))
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
        /// Returns SQL which checks for the existence of a TCAT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCAT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCAT](
        [TCATKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCAT_Index_TCATKEY] PRIMARY KEY CLUSTERED (
            [TCATKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCAT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TCATDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCATDataReader : IDataReader, IDataRecord
        {
            private List<TCAT> Items;
            private int CurrentIndex;
            private TCAT CurrentItem;

            public TCATDataReader(List<TCAT> Items)
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
                    case 0: // TCATKEY
                        return CurrentItem.TCATKEY;
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
                    case 0: // TCATKEY
                        return "TCATKEY";
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
                    case "TCATKEY":
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
