using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADAGDataSet : EduHubDataSet<SADAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SADAG"; } }

        internal SADAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SADAG_ID = new Lazy<Dictionary<int, SADAG>>(() => this.ToDictionary(i => i.SADAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADAG" /> fields for each CSV column header</returns>
        protected override Action<SADAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADAG_ID":
                        mapper[i] = (e, v) => e.SADAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_CODE":
                        mapper[i] = (e, v) => e.ABS_CODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYS":
                        mapper[i] = (e, v) => e.DAYS = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SADAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SADAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SADAG" /> items to added or update the base <see cref="SADAG" /> items</param>
        /// <returns>A merged list of <see cref="SADAG" /> items</returns>
        protected override List<SADAG> ApplyDeltaItems(List<SADAG> Items, List<SADAG> DeltaItems)
        {
            Dictionary<int, int> Index_SADAG_ID = Items.ToIndexDictionary(i => i.SADAG_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SADAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SADAG_ID.TryGetValue(deltaItem.SADAG_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SADAG_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SADAG>> Index_SADAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADAG FindBySADAG_ID(int SADAG_ID)
        {
            return Index_SADAG_ID.Value[SADAG_ID];
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <param name="Value">Related SADAG entity</param>
        /// <returns>True if the related SADAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySADAG_ID(int SADAG_ID, out SADAG Value)
        {
            return Index_SADAG_ID.Value.TryGetValue(SADAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADAG TryFindBySADAG_ID(int SADAG_ID)
        {
            SADAG value;
            if (Index_SADAG_ID.Value.TryGetValue(SADAG_ID, out value))
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
        /// Returns SQL which checks for the existence of a SADAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SADAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SADAG](
        [SADAG_ID] int IDENTITY NOT NULL,
        [BRY] smallint NULL,
        [SCHOOL_YEAR] varchar(2) NULL,
        [FTE] float NULL,
        [ABS_CODE] smallint NULL,
        [DAYS] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SADAG_Index_SADAG_ID] PRIMARY KEY CLUSTERED (
            [SADAG_ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADAG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SADAGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADAGDataReader : IDataReader, IDataRecord
        {
            private List<SADAG> Items;
            private int CurrentIndex;
            private SADAG CurrentItem;

            public SADAGDataReader(List<SADAG> Items)
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
                    case 0: // SADAG_ID
                        return CurrentItem.SADAG_ID;
                    case 1: // BRY
                        return CurrentItem.BRY;
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR;
                    case 3: // FTE
                        return CurrentItem.FTE;
                    case 4: // ABS_CODE
                        return CurrentItem.ABS_CODE;
                    case 5: // DAYS
                        return CurrentItem.DAYS;
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
                    case 1: // BRY
                        return CurrentItem.BRY == null;
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR == null;
                    case 3: // FTE
                        return CurrentItem.FTE == null;
                    case 4: // ABS_CODE
                        return CurrentItem.ABS_CODE == null;
                    case 5: // DAYS
                        return CurrentItem.DAYS == null;
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
                    case 0: // SADAG_ID
                        return "SADAG_ID";
                    case 1: // BRY
                        return "BRY";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // FTE
                        return "FTE";
                    case 4: // ABS_CODE
                        return "ABS_CODE";
                    case 5: // DAYS
                        return "DAYS";
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
                    case "SADAG_ID":
                        return 0;
                    case "BRY":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "FTE":
                        return 3;
                    case "ABS_CODE":
                        return 4;
                    case "DAYS":
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
