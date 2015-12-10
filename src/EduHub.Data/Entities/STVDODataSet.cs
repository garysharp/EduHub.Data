using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domain Results Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDODataSet : DataSetBase<STVDO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STVDO"; } }

        internal STVDODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STVDO>>(() => this.ToDictionary(i => i.TID));
            Index_VDIMENSION = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.VDIMENSION));
            Index_VDOMAIN = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.VDOMAIN));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STVDO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STVDO" /> fields for each CSV column header</returns>
        protected override Action<STVDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STVDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "VDOMAIN":
                        mapper[i] = (e, v) => e.VDOMAIN = v;
                        break;
                    case "VDIMENSION":
                        mapper[i] = (e, v) => e.VDIMENSION = v;
                        break;
                    case "SCORE":
                        mapper[i] = (e, v) => e.SCORE = v;
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
        /// Merges <see cref="STVDO" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STVDO" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STVDO" /> items to added or update the base <see cref="STVDO" /> items</param>
        /// <returns>A merged list of <see cref="STVDO" /> items</returns>
        protected override List<STVDO> ApplyDeltaItems(List<STVDO> Items, List<STVDO> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STVDO deltaItem in DeltaItems)
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
                .OrderBy(i => i.SKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<STVDO>>> Index_CAMPUS;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDO>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_SCHOOL_YEAR;
        private Lazy<Dictionary<string, IReadOnlyList<STVDO>>> Index_SKEY;
        private Lazy<Dictionary<int, STVDO>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_VDIMENSION;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_VDOMAIN;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STVDO by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find STVDO by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<STVDO> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<STVDO> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find STVDO by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<STVDO> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<STVDO> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find STVDO by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<STVDO> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<STVDO> value;
            if (Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STVDO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STVDO> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STVDO> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO</param>
        /// <returns>Related STVDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STVDO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO</param>
        /// <param name="Value">Related STVDO entity</param>
        /// <returns>True if the related STVDO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STVDO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO</param>
        /// <returns>Related STVDO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO TryFindByTID(int TID)
        {
            STVDO value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByVDIMENSION(string VDIMENSION)
        {
            return Index_VDIMENSION.Value[VDIMENSION];
        }

        /// <summary>
        /// Attempt to find STVDO by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDIMENSION(string VDIMENSION, out IReadOnlyList<STVDO> Value)
        {
            return Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByVDIMENSION(string VDIMENSION)
        {
            IReadOnlyList<STVDO> value;
            if (Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByVDOMAIN(string VDOMAIN)
        {
            return Index_VDOMAIN.Value[VDOMAIN];
        }

        /// <summary>
        /// Attempt to find STVDO by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDOMAIN(string VDOMAIN, out IReadOnlyList<STVDO> Value)
        {
            return Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByVDOMAIN(string VDOMAIN)
        {
            IReadOnlyList<STVDO> value;
            if (Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out value))
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
        /// Returns SQL which checks for the existence of a STVDO table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STVDO](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [CAMPUS] int NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [VDOMAIN] varchar(5) NULL,
        [VDIMENSION] varchar(10) NULL,
        [SCORE] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STVDO_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STVDO_Index_CAMPUS] ON [dbo].[STVDO]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDO_Index_LW_DATE] ON [dbo].[STVDO]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDO_Index_SCHOOL_YEAR] ON [dbo].[STVDO]
    (
            [SCHOOL_YEAR] ASC
    );
    CREATE CLUSTERED INDEX [STVDO_Index_SKEY] ON [dbo].[STVDO]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDO_Index_VDIMENSION] ON [dbo].[STVDO]
    (
            [VDIMENSION] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDO_Index_VDOMAIN] ON [dbo].[STVDO]
    (
            [VDOMAIN] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STVDO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDO data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STVDODataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STVDODataReader : IDataReader, IDataRecord
        {
            private List<STVDO> Items;
            private int CurrentIndex;
            private STVDO CurrentItem;

            public STVDODataReader(List<STVDO> Items)
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // SKEY
                        return CurrentItem.SKEY;
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR;
                    case 3: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 4: // YEAR_SEMESTER
                        return CurrentItem.YEAR_SEMESTER;
                    case 5: // VDOMAIN
                        return CurrentItem.VDOMAIN;
                    case 6: // VDIMENSION
                        return CurrentItem.VDIMENSION;
                    case 7: // SCORE
                        return CurrentItem.SCORE;
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
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR == null;
                    case 3: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 4: // YEAR_SEMESTER
                        return CurrentItem.YEAR_SEMESTER == null;
                    case 5: // VDOMAIN
                        return CurrentItem.VDOMAIN == null;
                    case 6: // VDIMENSION
                        return CurrentItem.VDIMENSION == null;
                    case 7: // SCORE
                        return CurrentItem.SCORE == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // CAMPUS
                        return "CAMPUS";
                    case 4: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 5: // VDOMAIN
                        return "VDOMAIN";
                    case 6: // VDIMENSION
                        return "VDIMENSION";
                    case 7: // SCORE
                        return "SCORE";
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
                    case "TID":
                        return 0;
                    case "SKEY":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "CAMPUS":
                        return 3;
                    case "YEAR_SEMESTER":
                        return 4;
                    case "VDOMAIN":
                        return 5;
                    case "VDIMENSION":
                        return 6;
                    case "SCORE":
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
