using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCOHORTDataSet : DataSetBase<KCOHORT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCOHORT"; } }

        internal KCOHORTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COHORT = new Lazy<Dictionary<string, KCOHORT>>(() => this.ToDictionary(i => i.COHORT));
            Index_DESCRIPTION = new Lazy<NullDictionary<string, IReadOnlyList<KCOHORT>>>(() => this.ToGroupedNullDictionary(i => i.DESCRIPTION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCOHORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCOHORT" /> fields for each CSV column header</returns>
        protected override Action<KCOHORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCOHORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VELS":
                        mapper[i] = (e, v) => e.VELS = v;
                        break;
                    case "BENCHMARK":
                        mapper[i] = (e, v) => e.BENCHMARK = v;
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
        /// Merges <see cref="KCOHORT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCOHORT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCOHORT" /> items to added or update the base <see cref="KCOHORT" /> items</param>
        /// <returns>A merged list of <see cref="KCOHORT" /> items</returns>
        protected override List<KCOHORT> ApplyDeltaItems(List<KCOHORT> Items, List<KCOHORT> DeltaItems)
        {
            Dictionary<string, int> Index_COHORT = Items.ToIndexDictionary(i => i.COHORT);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCOHORT deltaItem in DeltaItems)
            {
                int index;

                if (Index_COHORT.TryGetValue(deltaItem.COHORT, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.COHORT)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCOHORT>> Index_COHORT;
        private Lazy<NullDictionary<string, IReadOnlyList<KCOHORT>>> Index_DESCRIPTION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCOHORT FindByCOHORT(string COHORT)
        {
            return Index_COHORT.Value[COHORT];
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <param name="Value">Related KCOHORT entity</param>
        /// <returns>True if the related KCOHORT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOHORT(string COHORT, out KCOHORT Value)
        {
            return Index_COHORT.Value.TryGetValue(COHORT, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCOHORT TryFindByCOHORT(string COHORT)
        {
            KCOHORT value;
            if (Index_COHORT.Value.TryGetValue(COHORT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>List of related KCOHORT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCOHORT> FindByDESCRIPTION(string DESCRIPTION)
        {
            return Index_DESCRIPTION.Value[DESCRIPTION];
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <param name="Value">List of related KCOHORT entities</param>
        /// <returns>True if the list of related KCOHORT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDESCRIPTION(string DESCRIPTION, out IReadOnlyList<KCOHORT> Value)
        {
            return Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>List of related KCOHORT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCOHORT> TryFindByDESCRIPTION(string DESCRIPTION)
        {
            IReadOnlyList<KCOHORT> value;
            if (Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out value))
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
        /// Returns SQL which checks for the existence of a KCOHORT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCOHORT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCOHORT](
        [COHORT] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [VELS] varchar(1) NULL,
        [BENCHMARK] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCOHORT_Index_COHORT] PRIMARY KEY CLUSTERED (
            [COHORT] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCOHORT_Index_DESCRIPTION] ON [dbo].[KCOHORT]
    (
            [DESCRIPTION] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCOHORT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCOHORT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCOHORTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCOHORTDataReader : IDataReader, IDataRecord
        {
            private List<KCOHORT> Items;
            private int CurrentIndex;
            private KCOHORT CurrentItem;

            public KCOHORTDataReader(List<KCOHORT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 0: // COHORT
                        return CurrentItem.COHORT;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // VELS
                        return CurrentItem.VELS;
                    case 3: // BENCHMARK
                        return CurrentItem.BENCHMARK;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // VELS
                        return CurrentItem.VELS == null;
                    case 3: // BENCHMARK
                        return CurrentItem.BENCHMARK == null;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // COHORT
                        return "COHORT";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // VELS
                        return "VELS";
                    case 3: // BENCHMARK
                        return "BENCHMARK";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "COHORT":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "VELS":
                        return 2;
                    case "BENCHMARK":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
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
