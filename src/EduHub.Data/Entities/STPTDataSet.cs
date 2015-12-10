using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPTDataSet : DataSetBase<STPT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STPT"; } }

        internal STPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHL_NUM = new Lazy<NullDictionary<string, IReadOnlyList<STPT>>>(() => this.ToGroupedNullDictionary(i => i.SCHL_NUM));
            Index_STPTKEY = new Lazy<Dictionary<string, IReadOnlyList<STPT>>>(() => this.ToGroupedDictionary(i => i.STPTKEY));
            Index_STPTKEY_SCHL_NUM = new Lazy<Dictionary<Tuple<string, string>, STPT>>(() => this.ToDictionary(i => Tuple.Create(i.STPTKEY, i.SCHL_NUM)));
            Index_TID = new Lazy<Dictionary<int, STPT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPT" /> fields for each CSV column header</returns>
        protected override Action<STPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STPTKEY":
                        mapper[i] = (e, v) => e.STPTKEY = v;
                        break;
                    case "SCHL_NUM":
                        mapper[i] = (e, v) => e.SCHL_NUM = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ENROLLED":
                        mapper[i] = (e, v) => e.ENROLLED = v;
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
        /// Merges <see cref="STPT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STPT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STPT" /> items to added or update the base <see cref="STPT" /> items</param>
        /// <returns>A merged list of <see cref="STPT" /> items</returns>
        protected override List<STPT> ApplyDeltaItems(List<STPT> Items, List<STPT> DeltaItems)
        {
            Dictionary<Tuple<string, string>, int> Index_STPTKEY_SCHL_NUM = Items.ToIndexDictionary(i => Tuple.Create(i.STPTKEY, i.SCHL_NUM));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STPT deltaItem in DeltaItems)
            {
                int index;

                if (Index_STPTKEY_SCHL_NUM.TryGetValue(Tuple.Create(deltaItem.STPTKEY, deltaItem.SCHL_NUM), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.STPTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<STPT>>> Index_SCHL_NUM;
        private Lazy<Dictionary<string, IReadOnlyList<STPT>>> Index_STPTKEY;
        private Lazy<Dictionary<Tuple<string, string>, STPT>> Index_STPTKEY_SCHL_NUM;
        private Lazy<Dictionary<int, STPT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>List of related STPT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> FindBySCHL_NUM(string SCHL_NUM)
        {
            return Index_SCHL_NUM.Value[SCHL_NUM];
        }

        /// <summary>
        /// Attempt to find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <param name="Value">List of related STPT entities</param>
        /// <returns>True if the list of related STPT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHL_NUM(string SCHL_NUM, out IReadOnlyList<STPT> Value)
        {
            return Index_SCHL_NUM.Value.TryGetValue(SCHL_NUM, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>List of related STPT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> TryFindBySCHL_NUM(string SCHL_NUM)
        {
            IReadOnlyList<STPT> value;
            if (Index_SCHL_NUM.Value.TryGetValue(SCHL_NUM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <returns>List of related STPT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> FindBySTPTKEY(string STPTKEY)
        {
            return Index_STPTKEY.Value[STPTKEY];
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="Value">List of related STPT entities</param>
        /// <returns>True if the list of related STPT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPTKEY(string STPTKEY, out IReadOnlyList<STPT> Value)
        {
            return Index_STPTKEY.Value.TryGetValue(STPTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <returns>List of related STPT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> TryFindBySTPTKEY(string STPTKEY)
        {
            IReadOnlyList<STPT> value;
            if (Index_STPTKEY.Value.TryGetValue(STPTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>Related STPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT FindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM)
        {
            return Index_STPTKEY_SCHL_NUM.Value[Tuple.Create(STPTKEY, SCHL_NUM)];
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <param name="Value">Related STPT entity</param>
        /// <returns>True if the related STPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM, out STPT Value)
        {
            return Index_STPTKEY_SCHL_NUM.Value.TryGetValue(Tuple.Create(STPTKEY, SCHL_NUM), out Value);
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>Related STPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT TryFindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM)
        {
            STPT value;
            if (Index_STPTKEY_SCHL_NUM.Value.TryGetValue(Tuple.Create(STPTKEY, SCHL_NUM), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <returns>Related STPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <param name="Value">Related STPT entity</param>
        /// <returns>True if the related STPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <returns>Related STPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT TryFindByTID(int TID)
        {
            STPT value;
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
        /// Returns SQL which checks for the existence of a STPT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STPT](
        [TID] int IDENTITY NOT NULL,
        [STPTKEY] varchar(10) NOT NULL,
        [SCHL_NUM] varchar(8) NULL,
        [SGB_TIME_FRACTION] float NULL,
        [ACTUAL_TIME_FRACTION] float NULL,
        [ENROLLED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STPT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STPT_Index_SCHL_NUM] ON [dbo].[STPT]
    (
            [SCHL_NUM] ASC
    );
    CREATE CLUSTERED INDEX [STPT_Index_STPTKEY] ON [dbo].[STPT]
    (
            [STPTKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STPT_Index_STPTKEY_SCHL_NUM] ON [dbo].[STPT]
    (
            [STPTKEY] ASC,
            [SCHL_NUM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STPTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STPTDataReader : IDataReader, IDataRecord
        {
            private List<STPT> Items;
            private int CurrentIndex;
            private STPT CurrentItem;

            public STPTDataReader(List<STPT> Items)
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // STPTKEY
                        return CurrentItem.STPTKEY;
                    case 2: // SCHL_NUM
                        return CurrentItem.SCHL_NUM;
                    case 3: // SGB_TIME_FRACTION
                        return CurrentItem.SGB_TIME_FRACTION;
                    case 4: // ACTUAL_TIME_FRACTION
                        return CurrentItem.ACTUAL_TIME_FRACTION;
                    case 5: // ENROLLED
                        return CurrentItem.ENROLLED;
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
                    case 2: // SCHL_NUM
                        return CurrentItem.SCHL_NUM == null;
                    case 3: // SGB_TIME_FRACTION
                        return CurrentItem.SGB_TIME_FRACTION == null;
                    case 4: // ACTUAL_TIME_FRACTION
                        return CurrentItem.ACTUAL_TIME_FRACTION == null;
                    case 5: // ENROLLED
                        return CurrentItem.ENROLLED == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // STPTKEY
                        return "STPTKEY";
                    case 2: // SCHL_NUM
                        return "SCHL_NUM";
                    case 3: // SGB_TIME_FRACTION
                        return "SGB_TIME_FRACTION";
                    case 4: // ACTUAL_TIME_FRACTION
                        return "ACTUAL_TIME_FRACTION";
                    case 5: // ENROLLED
                        return "ENROLLED";
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
                    case "TID":
                        return 0;
                    case "STPTKEY":
                        return 1;
                    case "SCHL_NUM":
                        return 2;
                    case "SGB_TIME_FRACTION":
                        return 3;
                    case "ACTUAL_TIME_FRACTION":
                        return 4;
                    case "ENROLLED":
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
