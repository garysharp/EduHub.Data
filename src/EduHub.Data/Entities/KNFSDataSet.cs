using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family/Student ID Sequence Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNFSDataSet : EduHubDataSet<KNFS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KNFS"; } }

        internal KNFSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KNFSKEY = new Lazy<Dictionary<string, KNFS>>(() => this.ToDictionary(i => i.KNFSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KNFS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KNFS" /> fields for each CSV column header</returns>
        protected override Action<KNFS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KNFS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KNFSKEY":
                        mapper[i] = (e, v) => e.KNFSKEY = v;
                        break;
                    case "NEXT_NUMBER":
                        mapper[i] = (e, v) => e.NEXT_NUMBER = v;
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
        /// Merges <see cref="KNFS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KNFS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KNFS" /> items to added or update the base <see cref="KNFS" /> items</param>
        /// <returns>A merged list of <see cref="KNFS" /> items</returns>
        protected override List<KNFS> ApplyDeltaItems(List<KNFS> Items, List<KNFS> DeltaItems)
        {
            Dictionary<string, int> Index_KNFSKEY = Items.ToIndexDictionary(i => i.KNFSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KNFS deltaItem in DeltaItems)
            {
                int index;

                if (Index_KNFSKEY.TryGetValue(deltaItem.KNFSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KNFSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KNFS>> Index_KNFSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNFS FindByKNFSKEY(string KNFSKEY)
        {
            return Index_KNFSKEY.Value[KNFSKEY];
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <param name="Value">Related KNFS entity</param>
        /// <returns>True if the related KNFS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKNFSKEY(string KNFSKEY, out KNFS Value)
        {
            return Index_KNFSKEY.Value.TryGetValue(KNFSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNFS TryFindByKNFSKEY(string KNFSKEY)
        {
            KNFS value;
            if (Index_KNFSKEY.Value.TryGetValue(KNFSKEY, out value))
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
        /// Returns SQL which checks for the existence of a KNFS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KNFS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KNFS](
        [KNFSKEY] varchar(3) NOT NULL,
        [NEXT_NUMBER] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KNFS_Index_KNFSKEY] PRIMARY KEY CLUSTERED (
            [KNFSKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNFS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNFS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KNFSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KNFSDataReader : IDataReader, IDataRecord
        {
            private List<KNFS> Items;
            private int CurrentIndex;
            private KNFS CurrentItem;

            public KNFSDataReader(List<KNFS> Items)
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
                    case 0: // KNFSKEY
                        return CurrentItem.KNFSKEY;
                    case 1: // NEXT_NUMBER
                        return CurrentItem.NEXT_NUMBER;
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
                    case 1: // NEXT_NUMBER
                        return CurrentItem.NEXT_NUMBER == null;
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
                    case 0: // KNFSKEY
                        return "KNFSKEY";
                    case 1: // NEXT_NUMBER
                        return "NEXT_NUMBER";
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
                    case "KNFSKEY":
                        return 0;
                    case "NEXT_NUMBER":
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
