using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Available Qualifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSQDataSet : EduHubDataSet<KSQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSQ"; } }

        internal KSQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSQKEY = new Lazy<Dictionary<string, KSQ>>(() => this.ToDictionary(i => i.KSQKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSQ" /> fields for each CSV column header</returns>
        protected override Action<KSQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSQKEY":
                        mapper[i] = (e, v) => e.KSQKEY = v;
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
        /// Merges <see cref="KSQ" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KSQ" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KSQ" /> items to added or update the base <see cref="KSQ" /> items</param>
        /// <returns>A merged list of <see cref="KSQ" /> items</returns>
        protected override List<KSQ> ApplyDeltaItems(List<KSQ> Items, List<KSQ> DeltaItems)
        {
            Dictionary<string, int> Index_KSQKEY = Items.ToIndexDictionary(i => i.KSQKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KSQ deltaItem in DeltaItems)
            {
                int index;

                if (Index_KSQKEY.TryGetValue(deltaItem.KSQKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KSQKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KSQ>> Index_KSQKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSQ FindByKSQKEY(string KSQKEY)
        {
            return Index_KSQKEY.Value[KSQKEY];
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <param name="Value">Related KSQ entity</param>
        /// <returns>True if the related KSQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSQKEY(string KSQKEY, out KSQ Value)
        {
            return Index_KSQKEY.Value.TryGetValue(KSQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSQ TryFindByKSQKEY(string KSQKEY)
        {
            KSQ value;
            if (Index_KSQKEY.Value.TryGetValue(KSQKEY, out value))
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
        /// Returns SQL which checks for the existence of a KSQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSQ](
        [KSQKEY] varchar(30) NOT NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSQ_Index_KSQKEY] PRIMARY KEY CLUSTERED (
            [KSQKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSQ data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KSQDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSQDataReader : IDataReader, IDataRecord
        {
            private List<KSQ> Items;
            private int CurrentIndex;
            private KSQ CurrentItem;

            public KSQDataReader(List<KSQ> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 4; } }
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
                    case 0: // KSQKEY
                        return CurrentItem.KSQKEY;
                    case 1: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 2: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 3: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 2: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 3: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KSQKEY
                        return "KSQKEY";
                    case 1: // LW_DATE
                        return "LW_DATE";
                    case 2: // LW_TIME
                        return "LW_TIME";
                    case 3: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KSQKEY":
                        return 0;
                    case "LW_DATE":
                        return 1;
                    case "LW_TIME":
                        return 2;
                    case "LW_USER":
                        return 3;
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
