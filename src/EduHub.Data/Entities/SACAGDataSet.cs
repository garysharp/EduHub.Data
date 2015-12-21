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
    public sealed partial class SACAGDataSet : EduHubDataSet<SACAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SACAG"; } }

        internal SACAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SACAG_ID = new Lazy<Dictionary<int, SACAG>>(() => this.ToDictionary(i => i.SACAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SACAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SACAG" /> fields for each CSV column header</returns>
        protected override Action<SACAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SACAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SACAG_ID":
                        mapper[i] = (e, v) => e.SACAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "UNAPPROVED":
                        mapper[i] = (e, v) => e.UNAPPROVED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SACAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SACAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SACAG" /> items to added or update the base <see cref="SACAG" /> items</param>
        /// <returns>A merged list of <see cref="SACAG" /> items</returns>
        protected override List<SACAG> ApplyDeltaItems(List<SACAG> Items, List<SACAG> DeltaItems)
        {
            Dictionary<int, int> Index_SACAG_ID = Items.ToIndexDictionary(i => i.SACAG_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SACAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SACAG_ID.TryGetValue(deltaItem.SACAG_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SACAG_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SACAG>> Index_SACAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <returns>Related SACAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SACAG FindBySACAG_ID(int SACAG_ID)
        {
            return Index_SACAG_ID.Value[SACAG_ID];
        }

        /// <summary>
        /// Attempt to find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <param name="Value">Related SACAG entity</param>
        /// <returns>True if the related SACAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySACAG_ID(int SACAG_ID, out SACAG Value)
        {
            return Index_SACAG_ID.Value.TryGetValue(SACAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <returns>Related SACAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SACAG TryFindBySACAG_ID(int SACAG_ID)
        {
            SACAG value;
            if (Index_SACAG_ID.Value.TryGetValue(SACAG_ID, out value))
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
        /// Returns SQL which checks for the existence of a SACAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SACAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SACAG](
        [SACAG_ID] int IDENTITY NOT NULL,
        [BRY] smallint NULL,
        [SCHOOL_YEAR] varchar(2) NULL,
        [SEMESTER] smallint NULL,
        [COHORT] varchar(2) NULL,
        [FTE] float NULL,
        [UNAPPROVED] float NULL,
        [APPROVED] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SACAG_Index_SACAG_ID] PRIMARY KEY CLUSTERED (
            [SACAG_ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SACAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SACAG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SACAGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SACAGDataReader : IDataReader, IDataRecord
        {
            private List<SACAG> Items;
            private int CurrentIndex;
            private SACAG CurrentItem;

            public SACAGDataReader(List<SACAG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 0: // SACAG_ID
                        return CurrentItem.SACAG_ID;
                    case 1: // BRY
                        return CurrentItem.BRY;
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR;
                    case 3: // SEMESTER
                        return CurrentItem.SEMESTER;
                    case 4: // COHORT
                        return CurrentItem.COHORT;
                    case 5: // FTE
                        return CurrentItem.FTE;
                    case 6: // UNAPPROVED
                        return CurrentItem.UNAPPROVED;
                    case 7: // APPROVED
                        return CurrentItem.APPROVED;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
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
                    case 3: // SEMESTER
                        return CurrentItem.SEMESTER == null;
                    case 4: // COHORT
                        return CurrentItem.COHORT == null;
                    case 5: // FTE
                        return CurrentItem.FTE == null;
                    case 6: // UNAPPROVED
                        return CurrentItem.UNAPPROVED == null;
                    case 7: // APPROVED
                        return CurrentItem.APPROVED == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SACAG_ID
                        return "SACAG_ID";
                    case 1: // BRY
                        return "BRY";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // SEMESTER
                        return "SEMESTER";
                    case 4: // COHORT
                        return "COHORT";
                    case 5: // FTE
                        return "FTE";
                    case 6: // UNAPPROVED
                        return "UNAPPROVED";
                    case 7: // APPROVED
                        return "APPROVED";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SACAG_ID":
                        return 0;
                    case "BRY":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "SEMESTER":
                        return 3;
                    case "COHORT":
                        return 4;
                    case "FTE":
                        return 5;
                    case "UNAPPROVED":
                        return 6;
                    case "APPROVED":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
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
