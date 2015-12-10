using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Periods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEPDataSet : DataSetBase<TTEP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEP"; } }

        internal TTEPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEP>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEP" /> fields for each CSV column header</returns>
        protected override Action<TTEP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEI_TID":
                        mapper[i] = (e, v) => e.TTEI_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_DATE":
                        mapper[i] = (e, v) => e.EXAM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TTEP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TTEP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TTEP" /> items to added or update the base <see cref="TTEP" /> items</param>
        /// <returns>A merged list of <see cref="TTEP" /> items</returns>
        protected override List<TTEP> ApplyDeltaItems(List<TTEP> Items, List<TTEP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TTEP deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEP>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEP by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEP</param>
        /// <returns>List of related TTEP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEP> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEP by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEP</param>
        /// <param name="Value">List of related TTEP entities</param>
        /// <returns>True if the list of related TTEP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEP> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEP by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEP</param>
        /// <returns>List of related TTEP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEP> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEP> value;
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
        /// Find TTEP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEP</param>
        /// <returns>Related TTEP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEP</param>
        /// <param name="Value">Related TTEP entity</param>
        /// <returns>True if the related TTEP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEP</param>
        /// <returns>Related TTEP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEP TryFindByTID(int TID)
        {
            TTEP value;
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
        /// Returns SQL which checks for the existence of a TTEP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEP](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTEI_TID] int NULL,
        [EXAM_DATE] datetime NULL,
        [TIME_START] datetime NULL,
        [TIME_END] datetime NULL,
        [EXAM_ROW] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTEP_Index_GKEY] ON [dbo].[TTEP]
    (
            [GKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TTEPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEPDataReader : IDataReader, IDataRecord
        {
            private List<TTEP> Items;
            private int CurrentIndex;
            private TTEP CurrentItem;

            public TTEPDataReader(List<TTEP> Items)
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
                    case 2: // TTEI_TID
                        return CurrentItem.TTEI_TID;
                    case 3: // EXAM_DATE
                        return CurrentItem.EXAM_DATE;
                    case 4: // TIME_START
                        return CurrentItem.TIME_START;
                    case 5: // TIME_END
                        return CurrentItem.TIME_END;
                    case 6: // EXAM_ROW
                        return CurrentItem.EXAM_ROW;
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
                    case 2: // TTEI_TID
                        return CurrentItem.TTEI_TID == null;
                    case 3: // EXAM_DATE
                        return CurrentItem.EXAM_DATE == null;
                    case 4: // TIME_START
                        return CurrentItem.TIME_START == null;
                    case 5: // TIME_END
                        return CurrentItem.TIME_END == null;
                    case 6: // EXAM_ROW
                        return CurrentItem.EXAM_ROW == null;
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
                    case 2: // TTEI_TID
                        return "TTEI_TID";
                    case 3: // EXAM_DATE
                        return "EXAM_DATE";
                    case 4: // TIME_START
                        return "TIME_START";
                    case 5: // TIME_END
                        return "TIME_END";
                    case 6: // EXAM_ROW
                        return "EXAM_ROW";
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
                    case "TTEI_TID":
                        return 2;
                    case "EXAM_DATE":
                        return 3;
                    case "TIME_START":
                        return 4;
                    case "TIME_END":
                        return 5;
                    case "EXAM_ROW":
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
