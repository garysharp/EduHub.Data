using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class A_DECRYPDataSet : EduHubDataSet<A_DECRYP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "A_DECRYP"; } }

        internal A_DECRYPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, A_DECRYP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="A_DECRYP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="A_DECRYP" /> fields for each CSV column header</returns>
        protected override Action<A_DECRYP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<A_DECRYP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="A_DECRYP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="A_DECRYP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="A_DECRYP" /> items to added or update the base <see cref="A_DECRYP" /> items</param>
        /// <returns>A merged list of <see cref="A_DECRYP" /> items</returns>
        protected override List<A_DECRYP> ApplyDeltaItems(List<A_DECRYP> Items, List<A_DECRYP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (A_DECRYP deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, A_DECRYP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public A_DECRYP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <param name="Value">Related A_DECRYP entity</param>
        /// <returns>True if the related A_DECRYP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out A_DECRYP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public A_DECRYP TryFindByTID(int TID)
        {
            A_DECRYP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns SQL which checks for the existence of a A_DECRYP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[A_DECRYP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[A_DECRYP](
        [TID] int IDENTITY NOT NULL,
        [LINE_TYPE] varchar(10) NULL,
        [RECORD] varchar(200) NULL,
        [LW_DATE] datetime NULL,
        CONSTRAINT [A_DECRYP_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the A_DECRYP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the A_DECRYP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new A_DECRYPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class A_DECRYPDataReader : IDataReader, IDataRecord
        {
            private List<A_DECRYP> Items;
            private int CurrentIndex;
            private A_DECRYP CurrentItem;

            public A_DECRYPDataReader(List<A_DECRYP> Items)
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // LINE_TYPE
                        return CurrentItem.LINE_TYPE;
                    case 2: // RECORD
                        return CurrentItem.RECORD;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LINE_TYPE
                        return CurrentItem.LINE_TYPE == null;
                    case 2: // RECORD
                        return CurrentItem.RECORD == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // LINE_TYPE
                        return "LINE_TYPE";
                    case 2: // RECORD
                        return "RECORD";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "LINE_TYPE":
                        return 1;
                    case "RECORD":
                        return 2;
                    case "LW_DATE":
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
