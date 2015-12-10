using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Selections &amp; Marks Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STMADataSet : DataSetBase<STMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STMA"; } }

        internal STMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CKEY = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.CKEY));
            Index_IDENT = new Lazy<NullDictionary<int?, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.IDENT));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_MKEY = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.MKEY));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STMA>>(() => this.ToDictionary(i => i.TID));
            Index_TTPERIOD = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.TTPERIOD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STMA" /> fields for each CSV column header</returns>
        protected override Action<STMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "MKEY":
                        mapper[i] = (e, v) => e.MKEY = v;
                        break;
                    case "CKEY":
                        mapper[i] = (e, v) => e.CKEY = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "TEACHER_NAME":
                        mapper[i] = (e, v) => e.TEACHER_NAME = v;
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LOCK":
                        mapper[i] = (e, v) => e.LOCK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRPERIOD":
                        mapper[i] = (e, v) => e.TRPERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "CYEAR":
                        mapper[i] = (e, v) => e.CYEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DROPOUT":
                        mapper[i] = (e, v) => e.DROPOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GRADE01":
                        mapper[i] = (e, v) => e.GRADE01 = v;
                        break;
                    case "GRADE02":
                        mapper[i] = (e, v) => e.GRADE02 = v;
                        break;
                    case "GRADE03":
                        mapper[i] = (e, v) => e.GRADE03 = v;
                        break;
                    case "GRADE04":
                        mapper[i] = (e, v) => e.GRADE04 = v;
                        break;
                    case "GRADE05":
                        mapper[i] = (e, v) => e.GRADE05 = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "COMMENTB":
                        mapper[i] = (e, v) => e.COMMENTB = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "TOT_CLASS_PERIODS":
                        mapper[i] = (e, v) => e.TOT_CLASS_PERIODS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOT_APPROVED_ABS":
                        mapper[i] = (e, v) => e.TOT_APPROVED_ABS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOT_UNAPPROVED_ABS":
                        mapper[i] = (e, v) => e.TOT_UNAPPROVED_ABS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EQUIVALENT_KLA":
                        mapper[i] = (e, v) => e.EQUIVALENT_KLA = v;
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
        /// Merges <see cref="STMA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STMA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STMA" /> items to added or update the base <see cref="STMA" /> items</param>
        /// <returns>A merged list of <see cref="STMA" /> items</returns>
        protected override List<STMA> ApplyDeltaItems(List<STMA> Items, List<STMA> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STMA deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_CKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<STMA>>> Index_IDENT;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STMA>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_MKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_SCHOOL_YEAR;
        private Lazy<Dictionary<string, IReadOnlyList<STMA>>> Index_SKEY;
        private Lazy<Dictionary<int, STMA>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_TTPERIOD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STMA by CKEY field
        /// </summary>
        /// <param name="CKEY">CKEY value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByCKEY(string CKEY)
        {
            return Index_CKEY.Value[CKEY];
        }

        /// <summary>
        /// Attempt to find STMA by CKEY field
        /// </summary>
        /// <param name="CKEY">CKEY value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCKEY(string CKEY, out IReadOnlyList<STMA> Value)
        {
            return Index_CKEY.Value.TryGetValue(CKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by CKEY field
        /// </summary>
        /// <param name="CKEY">CKEY value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByCKEY(string CKEY)
        {
            IReadOnlyList<STMA> value;
            if (Index_CKEY.Value.TryGetValue(CKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByIDENT(int? IDENT)
        {
            return Index_IDENT.Value[IDENT];
        }

        /// <summary>
        /// Attempt to find STMA by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByIDENT(int? IDENT, out IReadOnlyList<STMA> Value)
        {
            return Index_IDENT.Value.TryGetValue(IDENT, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByIDENT(int? IDENT)
        {
            IReadOnlyList<STMA> value;
            if (Index_IDENT.Value.TryGetValue(IDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find STMA by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<STMA> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<STMA> value;
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
        /// Find STMA by MKEY field
        /// </summary>
        /// <param name="MKEY">MKEY value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByMKEY(string MKEY)
        {
            return Index_MKEY.Value[MKEY];
        }

        /// <summary>
        /// Attempt to find STMA by MKEY field
        /// </summary>
        /// <param name="MKEY">MKEY value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMKEY(string MKEY, out IReadOnlyList<STMA> Value)
        {
            return Index_MKEY.Value.TryGetValue(MKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by MKEY field
        /// </summary>
        /// <param name="MKEY">MKEY value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByMKEY(string MKEY)
        {
            IReadOnlyList<STMA> value;
            if (Index_MKEY.Value.TryGetValue(MKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find STMA by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<STMA> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<STMA> value;
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
        /// Find STMA by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STMA by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STMA> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STMA> value;
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
        /// Find STMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMA</param>
        /// <returns>Related STMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMA</param>
        /// <param name="Value">Related STMA entity</param>
        /// <returns>True if the related STMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMA</param>
        /// <returns>Related STMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMA TryFindByTID(int TID)
        {
            STMA value;
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
        /// Find STMA by TTPERIOD field
        /// </summary>
        /// <param name="TTPERIOD">TTPERIOD value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByTTPERIOD(string TTPERIOD)
        {
            return Index_TTPERIOD.Value[TTPERIOD];
        }

        /// <summary>
        /// Attempt to find STMA by TTPERIOD field
        /// </summary>
        /// <param name="TTPERIOD">TTPERIOD value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTTPERIOD(string TTPERIOD, out IReadOnlyList<STMA> Value)
        {
            return Index_TTPERIOD.Value.TryGetValue(TTPERIOD, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by TTPERIOD field
        /// </summary>
        /// <param name="TTPERIOD">TTPERIOD value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByTTPERIOD(string TTPERIOD)
        {
            IReadOnlyList<STMA> value;
            if (Index_TTPERIOD.Value.TryGetValue(TTPERIOD, out value))
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
        /// Returns SQL which checks for the existence of a STMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STMA](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [MKEY] varchar(5) NULL,
        [CKEY] varchar(5) NULL,
        [PRIORITY] smallint NULL,
        [CLASS] smallint NULL,
        [FULLNAME] varchar(30) NULL,
        [TEACHER_NAME] varchar(30) NULL,
        [IDENT] int NULL,
        [LOCK] smallint NULL,
        [TRPERIOD] int NULL,
        [TTPERIOD] varchar(8) NULL,
        [CYEAR] smallint NULL,
        [CREATED] datetime NULL,
        [DROPOUT] smallint NULL,
        [GRADE01] varchar(1) NULL,
        [GRADE02] varchar(1) NULL,
        [GRADE03] varchar(1) NULL,
        [GRADE04] varchar(1) NULL,
        [GRADE05] varchar(1) NULL,
        [COMMENTA] text NULL,
        [COMMENTB] text NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [TOT_CLASS_PERIODS] smallint NULL,
        [TOT_APPROVED_ABS] smallint NULL,
        [TOT_UNAPPROVED_ABS] smallint NULL,
        [EQUIVALENT_KLA] varchar(8) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STMA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STMA_Index_CKEY] ON [dbo].[STMA]
    (
            [CKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STMA_Index_IDENT] ON [dbo].[STMA]
    (
            [IDENT] ASC
    );
    CREATE NONCLUSTERED INDEX [STMA_Index_LW_DATE] ON [dbo].[STMA]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [STMA_Index_MKEY] ON [dbo].[STMA]
    (
            [MKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STMA_Index_SCHOOL_YEAR] ON [dbo].[STMA]
    (
            [SCHOOL_YEAR] ASC
    );
    CREATE CLUSTERED INDEX [STMA_Index_SKEY] ON [dbo].[STMA]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STMA_Index_TTPERIOD] ON [dbo].[STMA]
    (
            [TTPERIOD] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STMA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STMADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STMADataReader : IDataReader, IDataRecord
        {
            private List<STMA> Items;
            private int CurrentIndex;
            private STMA CurrentItem;

            public STMADataReader(List<STMA> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 30; } }
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
                    case 2: // MKEY
                        return CurrentItem.MKEY;
                    case 3: // CKEY
                        return CurrentItem.CKEY;
                    case 4: // PRIORITY
                        return CurrentItem.PRIORITY;
                    case 5: // CLASS
                        return CurrentItem.CLASS;
                    case 6: // FULLNAME
                        return CurrentItem.FULLNAME;
                    case 7: // TEACHER_NAME
                        return CurrentItem.TEACHER_NAME;
                    case 8: // IDENT
                        return CurrentItem.IDENT;
                    case 9: // LOCK
                        return CurrentItem.LOCK;
                    case 10: // TRPERIOD
                        return CurrentItem.TRPERIOD;
                    case 11: // TTPERIOD
                        return CurrentItem.TTPERIOD;
                    case 12: // CYEAR
                        return CurrentItem.CYEAR;
                    case 13: // CREATED
                        return CurrentItem.CREATED;
                    case 14: // DROPOUT
                        return CurrentItem.DROPOUT;
                    case 15: // GRADE01
                        return CurrentItem.GRADE01;
                    case 16: // GRADE02
                        return CurrentItem.GRADE02;
                    case 17: // GRADE03
                        return CurrentItem.GRADE03;
                    case 18: // GRADE04
                        return CurrentItem.GRADE04;
                    case 19: // GRADE05
                        return CurrentItem.GRADE05;
                    case 20: // COMMENTA
                        return CurrentItem.COMMENTA;
                    case 21: // COMMENTB
                        return CurrentItem.COMMENTB;
                    case 22: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR;
                    case 23: // TOT_CLASS_PERIODS
                        return CurrentItem.TOT_CLASS_PERIODS;
                    case 24: // TOT_APPROVED_ABS
                        return CurrentItem.TOT_APPROVED_ABS;
                    case 25: // TOT_UNAPPROVED_ABS
                        return CurrentItem.TOT_UNAPPROVED_ABS;
                    case 26: // EQUIVALENT_KLA
                        return CurrentItem.EQUIVALENT_KLA;
                    case 27: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 28: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 29: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // MKEY
                        return CurrentItem.MKEY == null;
                    case 3: // CKEY
                        return CurrentItem.CKEY == null;
                    case 4: // PRIORITY
                        return CurrentItem.PRIORITY == null;
                    case 5: // CLASS
                        return CurrentItem.CLASS == null;
                    case 6: // FULLNAME
                        return CurrentItem.FULLNAME == null;
                    case 7: // TEACHER_NAME
                        return CurrentItem.TEACHER_NAME == null;
                    case 8: // IDENT
                        return CurrentItem.IDENT == null;
                    case 9: // LOCK
                        return CurrentItem.LOCK == null;
                    case 10: // TRPERIOD
                        return CurrentItem.TRPERIOD == null;
                    case 11: // TTPERIOD
                        return CurrentItem.TTPERIOD == null;
                    case 12: // CYEAR
                        return CurrentItem.CYEAR == null;
                    case 13: // CREATED
                        return CurrentItem.CREATED == null;
                    case 14: // DROPOUT
                        return CurrentItem.DROPOUT == null;
                    case 15: // GRADE01
                        return CurrentItem.GRADE01 == null;
                    case 16: // GRADE02
                        return CurrentItem.GRADE02 == null;
                    case 17: // GRADE03
                        return CurrentItem.GRADE03 == null;
                    case 18: // GRADE04
                        return CurrentItem.GRADE04 == null;
                    case 19: // GRADE05
                        return CurrentItem.GRADE05 == null;
                    case 20: // COMMENTA
                        return CurrentItem.COMMENTA == null;
                    case 21: // COMMENTB
                        return CurrentItem.COMMENTB == null;
                    case 22: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR == null;
                    case 23: // TOT_CLASS_PERIODS
                        return CurrentItem.TOT_CLASS_PERIODS == null;
                    case 24: // TOT_APPROVED_ABS
                        return CurrentItem.TOT_APPROVED_ABS == null;
                    case 25: // TOT_UNAPPROVED_ABS
                        return CurrentItem.TOT_UNAPPROVED_ABS == null;
                    case 26: // EQUIVALENT_KLA
                        return CurrentItem.EQUIVALENT_KLA == null;
                    case 27: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 28: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 29: // LW_USER
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
                    case 2: // MKEY
                        return "MKEY";
                    case 3: // CKEY
                        return "CKEY";
                    case 4: // PRIORITY
                        return "PRIORITY";
                    case 5: // CLASS
                        return "CLASS";
                    case 6: // FULLNAME
                        return "FULLNAME";
                    case 7: // TEACHER_NAME
                        return "TEACHER_NAME";
                    case 8: // IDENT
                        return "IDENT";
                    case 9: // LOCK
                        return "LOCK";
                    case 10: // TRPERIOD
                        return "TRPERIOD";
                    case 11: // TTPERIOD
                        return "TTPERIOD";
                    case 12: // CYEAR
                        return "CYEAR";
                    case 13: // CREATED
                        return "CREATED";
                    case 14: // DROPOUT
                        return "DROPOUT";
                    case 15: // GRADE01
                        return "GRADE01";
                    case 16: // GRADE02
                        return "GRADE02";
                    case 17: // GRADE03
                        return "GRADE03";
                    case 18: // GRADE04
                        return "GRADE04";
                    case 19: // GRADE05
                        return "GRADE05";
                    case 20: // COMMENTA
                        return "COMMENTA";
                    case 21: // COMMENTB
                        return "COMMENTB";
                    case 22: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 23: // TOT_CLASS_PERIODS
                        return "TOT_CLASS_PERIODS";
                    case 24: // TOT_APPROVED_ABS
                        return "TOT_APPROVED_ABS";
                    case 25: // TOT_UNAPPROVED_ABS
                        return "TOT_UNAPPROVED_ABS";
                    case 26: // EQUIVALENT_KLA
                        return "EQUIVALENT_KLA";
                    case 27: // LW_DATE
                        return "LW_DATE";
                    case 28: // LW_TIME
                        return "LW_TIME";
                    case 29: // LW_USER
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
                    case "MKEY":
                        return 2;
                    case "CKEY":
                        return 3;
                    case "PRIORITY":
                        return 4;
                    case "CLASS":
                        return 5;
                    case "FULLNAME":
                        return 6;
                    case "TEACHER_NAME":
                        return 7;
                    case "IDENT":
                        return 8;
                    case "LOCK":
                        return 9;
                    case "TRPERIOD":
                        return 10;
                    case "TTPERIOD":
                        return 11;
                    case "CYEAR":
                        return 12;
                    case "CREATED":
                        return 13;
                    case "DROPOUT":
                        return 14;
                    case "GRADE01":
                        return 15;
                    case "GRADE02":
                        return 16;
                    case "GRADE03":
                        return 17;
                    case "GRADE04":
                        return 18;
                    case "GRADE05":
                        return 19;
                    case "COMMENTA":
                        return 20;
                    case "COMMENTB":
                        return 21;
                    case "SCHOOL_YEAR":
                        return 22;
                    case "TOT_CLASS_PERIODS":
                        return 23;
                    case "TOT_APPROVED_ABS":
                        return 24;
                    case "TOT_UNAPPROVED_ABS":
                        return 25;
                    case "EQUIVALENT_KLA":
                        return 26;
                    case "LW_DATE":
                        return 27;
                    case "LW_TIME":
                        return 28;
                    case "LW_USER":
                        return 29;
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
