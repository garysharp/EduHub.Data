using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEIDataSet : EduHubDataSet<TTEI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEI"; } }

        internal TTEIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEI>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEI" /> fields for each CSV column header</returns>
        protected override Action<TTEI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAX_SIZE":
                        mapper[i] = (e, v) => e.MAX_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_LINES":
                        mapper[i] = (e, v) => e.MAX_LINES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "USE_FIXED":
                        mapper[i] = (e, v) => e.USE_FIXED = v;
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
        /// Merges <see cref="TTEI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TTEI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TTEI" /> items to added or update the base <see cref="TTEI" /> items</param>
        /// <returns>A merged list of <see cref="TTEI" /> items</returns>
        protected override List<TTEI> ApplyDeltaItems(List<TTEI> Items, List<TTEI> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TTEI deltaItem in DeltaItems)
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
                .OrderBy(i => i.GKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<TTEI>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <returns>List of related TTEI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEI> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <param name="Value">List of related TTEI entities</param>
        /// <returns>True if the list of related TTEI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEI> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <returns>List of related TTEI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEI> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEI> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <param name="Value">Related TTEI entity</param>
        /// <returns>True if the related TTEI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEI TryFindByTID(int TID)
        {
            TTEI value;
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
        /// Returns SQL which checks for the existence of a TTEI table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEI](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [MAX_SIZE] smallint NULL,
        [MAX_LINES] smallint NULL,
        [USE_FIXED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTEI_Index_GKEY] ON [dbo].[TTEI]
    (
            [GKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEI data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TTEIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEIDataReader : IDataReader, IDataRecord
        {
            private List<TTEI> Items;
            private int CurrentIndex;
            private TTEI CurrentItem;

            public TTEIDataReader(List<TTEI> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 10; } }
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
                    case 1: // GKEY
                        return CurrentItem.GKEY;
                    case 2: // START_DATE
                        return CurrentItem.START_DATE;
                    case 3: // END_DATE
                        return CurrentItem.END_DATE;
                    case 4: // MAX_SIZE
                        return CurrentItem.MAX_SIZE;
                    case 5: // MAX_LINES
                        return CurrentItem.MAX_LINES;
                    case 6: // USE_FIXED
                        return CurrentItem.USE_FIXED;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 9: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 3: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 4: // MAX_SIZE
                        return CurrentItem.MAX_SIZE == null;
                    case 5: // MAX_LINES
                        return CurrentItem.MAX_LINES == null;
                    case 6: // USE_FIXED
                        return CurrentItem.USE_FIXED == null;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 9: // LW_USER
                        return CurrentItem.LW_USER == null;
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
                    case 1: // GKEY
                        return "GKEY";
                    case 2: // START_DATE
                        return "START_DATE";
                    case 3: // END_DATE
                        return "END_DATE";
                    case 4: // MAX_SIZE
                        return "MAX_SIZE";
                    case 5: // MAX_LINES
                        return "MAX_LINES";
                    case 6: // USE_FIXED
                        return "USE_FIXED";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
                        return "LW_USER";
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
                    case "GKEY":
                        return 1;
                    case "START_DATE":
                        return 2;
                    case "END_DATE":
                        return 3;
                    case "MAX_SIZE":
                        return 4;
                    case "MAX_LINES":
                        return 5;
                    case "USE_FIXED":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
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
