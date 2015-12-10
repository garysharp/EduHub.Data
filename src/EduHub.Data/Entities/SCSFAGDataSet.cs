using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Data Aggregates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSFAGDataSet : DataSetBase<SCSFAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCSFAG"; } }

        internal SCSFAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCSFKEY = new Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>>(() => this.ToGroupedDictionary(i => i.SCSFKEY));
            Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = new Lazy<Dictionary<Tuple<string, string, int?, string, string>, SCSFAG>>(() => this.ToDictionary(i => Tuple.Create(i.SCSFKEY, i.YEAR_SEMESTER, i.ST_CAMPUS, i.ST_YEAR_LEVEL, i.ST_CATEGORY)));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SCSFAG>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_TID = new Lazy<Dictionary<int, SCSFAG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSFAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSFAG" /> fields for each CSV column header</returns>
        protected override Action<SCSFAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSFAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "ST_CAMPUS":
                        mapper[i] = (e, v) => e.ST_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ST_CATEGORY":
                        mapper[i] = (e, v) => e.ST_CATEGORY = v;
                        break;
                    case "TOTAL_IN_GROUP":
                        mapper[i] = (e, v) => e.TOTAL_IN_GROUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT01":
                        mapper[i] = (e, v) => e.NUMBER_AT01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT02":
                        mapper[i] = (e, v) => e.NUMBER_AT02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT03":
                        mapper[i] = (e, v) => e.NUMBER_AT03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT04":
                        mapper[i] = (e, v) => e.NUMBER_AT04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT05":
                        mapper[i] = (e, v) => e.NUMBER_AT05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT06":
                        mapper[i] = (e, v) => e.NUMBER_AT06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT07":
                        mapper[i] = (e, v) => e.NUMBER_AT07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT08":
                        mapper[i] = (e, v) => e.NUMBER_AT08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT09":
                        mapper[i] = (e, v) => e.NUMBER_AT09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT10":
                        mapper[i] = (e, v) => e.NUMBER_AT10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT11":
                        mapper[i] = (e, v) => e.NUMBER_AT11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT12":
                        mapper[i] = (e, v) => e.NUMBER_AT12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT13":
                        mapper[i] = (e, v) => e.NUMBER_AT13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT14":
                        mapper[i] = (e, v) => e.NUMBER_AT14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT15":
                        mapper[i] = (e, v) => e.NUMBER_AT15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT16":
                        mapper[i] = (e, v) => e.NUMBER_AT16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT17":
                        mapper[i] = (e, v) => e.NUMBER_AT17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT18":
                        mapper[i] = (e, v) => e.NUMBER_AT18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT19":
                        mapper[i] = (e, v) => e.NUMBER_AT19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT20":
                        mapper[i] = (e, v) => e.NUMBER_AT20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT21":
                        mapper[i] = (e, v) => e.NUMBER_AT21 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT22":
                        mapper[i] = (e, v) => e.NUMBER_AT22 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT23":
                        mapper[i] = (e, v) => e.NUMBER_AT23 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT24":
                        mapper[i] = (e, v) => e.NUMBER_AT24 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT25":
                        mapper[i] = (e, v) => e.NUMBER_AT25 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT26":
                        mapper[i] = (e, v) => e.NUMBER_AT26 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT27":
                        mapper[i] = (e, v) => e.NUMBER_AT27 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT28":
                        mapper[i] = (e, v) => e.NUMBER_AT28 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_MEAN":
                        mapper[i] = (e, v) => e.SCHOOL_MEAN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MIN":
                        mapper[i] = (e, v) => e.SCHOOL_MIN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MAX":
                        mapper[i] = (e, v) => e.SCHOOL_MAX = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_15TH":
                        mapper[i] = (e, v) => e.SCHOOL_15TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_25TH":
                        mapper[i] = (e, v) => e.SCHOOL_25TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_75TH":
                        mapper[i] = (e, v) => e.SCHOOL_75TH = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SCSFAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCSFAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCSFAG" /> items to added or update the base <see cref="SCSFAG" /> items</param>
        /// <returns>A merged list of <see cref="SCSFAG" /> items</returns>
        protected override List<SCSFAG> ApplyDeltaItems(List<SCSFAG> Items, List<SCSFAG> DeltaItems)
        {
            Dictionary<Tuple<string, string, int?, string, string>, int> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = Items.ToIndexDictionary(i => Tuple.Create(i.SCSFKEY, i.YEAR_SEMESTER, i.ST_CAMPUS, i.ST_YEAR_LEVEL, i.ST_CATEGORY));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCSFAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.TryGetValue(Tuple.Create(deltaItem.SCSFKEY, deltaItem.YEAR_SEMESTER, deltaItem.ST_CAMPUS, deltaItem.ST_YEAR_LEVEL, deltaItem.ST_CATEGORY), out index))
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
                .OrderBy(i => i.SCSFKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>> Index_SCSFKEY;
        private Lazy<Dictionary<Tuple<string, string, int?, string, string>, SCSFAG>> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<SCSFAG>>> Index_ST_YEAR_LEVEL;
        private Lazy<Dictionary<int, SCSFAG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> FindBySCSFKEY(string SCSFKEY)
        {
            return Index_SCSFKEY.Value[SCSFKEY];
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="Value">List of related SCSFAG entities</param>
        /// <returns>True if the list of related SCSFAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY(string SCSFKEY, out IReadOnlyList<SCSFAG> Value)
        {
            return Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> TryFindBySCSFKEY(string SCSFKEY)
        {
            IReadOnlyList<SCSFAG> value;
            if (Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG FindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY)
        {
            return Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value[Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY)];
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <param name="Value">Related SCSFAG entity</param>
        /// <returns>True if the related SCSFAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY, out SCSFAG Value)
        {
            return Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value.TryGetValue(Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY), out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG TryFindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY)
        {
            SCSFAG value;
            if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value.TryGetValue(Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="Value">List of related SCSFAG entities</param>
        /// <returns>True if the list of related SCSFAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SCSFAG> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SCSFAG> value;
            if (Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <param name="Value">Related SCSFAG entity</param>
        /// <returns>True if the related SCSFAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SCSFAG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG TryFindByTID(int TID)
        {
            SCSFAG value;
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
        /// Returns SQL which checks for the existence of a SCSFAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCSFAG](
        [TID] int IDENTITY NOT NULL,
        [SCSFKEY] varchar(5) NOT NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [ST_CAMPUS] int NULL,
        [ST_YEAR_LEVEL] varchar(4) NULL,
        [ST_CATEGORY] varchar(2) NULL,
        [TOTAL_IN_GROUP] smallint NULL,
        [NUMBER_AT01] smallint NULL,
        [NUMBER_AT02] smallint NULL,
        [NUMBER_AT03] smallint NULL,
        [NUMBER_AT04] smallint NULL,
        [NUMBER_AT05] smallint NULL,
        [NUMBER_AT06] smallint NULL,
        [NUMBER_AT07] smallint NULL,
        [NUMBER_AT08] smallint NULL,
        [NUMBER_AT09] smallint NULL,
        [NUMBER_AT10] smallint NULL,
        [NUMBER_AT11] smallint NULL,
        [NUMBER_AT12] smallint NULL,
        [NUMBER_AT13] smallint NULL,
        [NUMBER_AT14] smallint NULL,
        [NUMBER_AT15] smallint NULL,
        [NUMBER_AT16] smallint NULL,
        [NUMBER_AT17] smallint NULL,
        [NUMBER_AT18] smallint NULL,
        [NUMBER_AT19] smallint NULL,
        [NUMBER_AT20] smallint NULL,
        [NUMBER_AT21] smallint NULL,
        [NUMBER_AT22] smallint NULL,
        [NUMBER_AT23] smallint NULL,
        [NUMBER_AT24] smallint NULL,
        [NUMBER_AT25] smallint NULL,
        [NUMBER_AT26] smallint NULL,
        [NUMBER_AT27] smallint NULL,
        [NUMBER_AT28] smallint NULL,
        [SCHOOL_MEAN] float NULL,
        [SCHOOL_MIN] float NULL,
        [SCHOOL_MAX] float NULL,
        [SCHOOL_15TH] float NULL,
        [SCHOOL_25TH] float NULL,
        [SCHOOL_75TH] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCSFAG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SCSFAG_Index_SCSFKEY] ON [dbo].[SCSFAG]
    (
            [SCSFKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SCSFAG_Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY] ON [dbo].[SCSFAG]
    (
            [SCSFKEY] ASC,
            [YEAR_SEMESTER] ASC,
            [ST_CAMPUS] ASC,
            [ST_YEAR_LEVEL] ASC,
            [ST_CATEGORY] ASC
    );
    CREATE NONCLUSTERED INDEX [SCSFAG_Index_ST_YEAR_LEVEL] ON [dbo].[SCSFAG]
    (
            [ST_YEAR_LEVEL] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCSFAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCSFAG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCSFAGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCSFAGDataReader : IDataReader, IDataRecord
        {
            private List<SCSFAG> Items;
            private int CurrentIndex;
            private SCSFAG CurrentItem;

            public SCSFAGDataReader(List<SCSFAG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 44; } }
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
                    case 1: // SCSFKEY
                        return CurrentItem.SCSFKEY;
                    case 2: // YEAR_SEMESTER
                        return CurrentItem.YEAR_SEMESTER;
                    case 3: // ST_CAMPUS
                        return CurrentItem.ST_CAMPUS;
                    case 4: // ST_YEAR_LEVEL
                        return CurrentItem.ST_YEAR_LEVEL;
                    case 5: // ST_CATEGORY
                        return CurrentItem.ST_CATEGORY;
                    case 6: // TOTAL_IN_GROUP
                        return CurrentItem.TOTAL_IN_GROUP;
                    case 7: // NUMBER_AT01
                        return CurrentItem.NUMBER_AT01;
                    case 8: // NUMBER_AT02
                        return CurrentItem.NUMBER_AT02;
                    case 9: // NUMBER_AT03
                        return CurrentItem.NUMBER_AT03;
                    case 10: // NUMBER_AT04
                        return CurrentItem.NUMBER_AT04;
                    case 11: // NUMBER_AT05
                        return CurrentItem.NUMBER_AT05;
                    case 12: // NUMBER_AT06
                        return CurrentItem.NUMBER_AT06;
                    case 13: // NUMBER_AT07
                        return CurrentItem.NUMBER_AT07;
                    case 14: // NUMBER_AT08
                        return CurrentItem.NUMBER_AT08;
                    case 15: // NUMBER_AT09
                        return CurrentItem.NUMBER_AT09;
                    case 16: // NUMBER_AT10
                        return CurrentItem.NUMBER_AT10;
                    case 17: // NUMBER_AT11
                        return CurrentItem.NUMBER_AT11;
                    case 18: // NUMBER_AT12
                        return CurrentItem.NUMBER_AT12;
                    case 19: // NUMBER_AT13
                        return CurrentItem.NUMBER_AT13;
                    case 20: // NUMBER_AT14
                        return CurrentItem.NUMBER_AT14;
                    case 21: // NUMBER_AT15
                        return CurrentItem.NUMBER_AT15;
                    case 22: // NUMBER_AT16
                        return CurrentItem.NUMBER_AT16;
                    case 23: // NUMBER_AT17
                        return CurrentItem.NUMBER_AT17;
                    case 24: // NUMBER_AT18
                        return CurrentItem.NUMBER_AT18;
                    case 25: // NUMBER_AT19
                        return CurrentItem.NUMBER_AT19;
                    case 26: // NUMBER_AT20
                        return CurrentItem.NUMBER_AT20;
                    case 27: // NUMBER_AT21
                        return CurrentItem.NUMBER_AT21;
                    case 28: // NUMBER_AT22
                        return CurrentItem.NUMBER_AT22;
                    case 29: // NUMBER_AT23
                        return CurrentItem.NUMBER_AT23;
                    case 30: // NUMBER_AT24
                        return CurrentItem.NUMBER_AT24;
                    case 31: // NUMBER_AT25
                        return CurrentItem.NUMBER_AT25;
                    case 32: // NUMBER_AT26
                        return CurrentItem.NUMBER_AT26;
                    case 33: // NUMBER_AT27
                        return CurrentItem.NUMBER_AT27;
                    case 34: // NUMBER_AT28
                        return CurrentItem.NUMBER_AT28;
                    case 35: // SCHOOL_MEAN
                        return CurrentItem.SCHOOL_MEAN;
                    case 36: // SCHOOL_MIN
                        return CurrentItem.SCHOOL_MIN;
                    case 37: // SCHOOL_MAX
                        return CurrentItem.SCHOOL_MAX;
                    case 38: // SCHOOL_15TH
                        return CurrentItem.SCHOOL_15TH;
                    case 39: // SCHOOL_25TH
                        return CurrentItem.SCHOOL_25TH;
                    case 40: // SCHOOL_75TH
                        return CurrentItem.SCHOOL_75TH;
                    case 41: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 42: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 43: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // YEAR_SEMESTER
                        return CurrentItem.YEAR_SEMESTER == null;
                    case 3: // ST_CAMPUS
                        return CurrentItem.ST_CAMPUS == null;
                    case 4: // ST_YEAR_LEVEL
                        return CurrentItem.ST_YEAR_LEVEL == null;
                    case 5: // ST_CATEGORY
                        return CurrentItem.ST_CATEGORY == null;
                    case 6: // TOTAL_IN_GROUP
                        return CurrentItem.TOTAL_IN_GROUP == null;
                    case 7: // NUMBER_AT01
                        return CurrentItem.NUMBER_AT01 == null;
                    case 8: // NUMBER_AT02
                        return CurrentItem.NUMBER_AT02 == null;
                    case 9: // NUMBER_AT03
                        return CurrentItem.NUMBER_AT03 == null;
                    case 10: // NUMBER_AT04
                        return CurrentItem.NUMBER_AT04 == null;
                    case 11: // NUMBER_AT05
                        return CurrentItem.NUMBER_AT05 == null;
                    case 12: // NUMBER_AT06
                        return CurrentItem.NUMBER_AT06 == null;
                    case 13: // NUMBER_AT07
                        return CurrentItem.NUMBER_AT07 == null;
                    case 14: // NUMBER_AT08
                        return CurrentItem.NUMBER_AT08 == null;
                    case 15: // NUMBER_AT09
                        return CurrentItem.NUMBER_AT09 == null;
                    case 16: // NUMBER_AT10
                        return CurrentItem.NUMBER_AT10 == null;
                    case 17: // NUMBER_AT11
                        return CurrentItem.NUMBER_AT11 == null;
                    case 18: // NUMBER_AT12
                        return CurrentItem.NUMBER_AT12 == null;
                    case 19: // NUMBER_AT13
                        return CurrentItem.NUMBER_AT13 == null;
                    case 20: // NUMBER_AT14
                        return CurrentItem.NUMBER_AT14 == null;
                    case 21: // NUMBER_AT15
                        return CurrentItem.NUMBER_AT15 == null;
                    case 22: // NUMBER_AT16
                        return CurrentItem.NUMBER_AT16 == null;
                    case 23: // NUMBER_AT17
                        return CurrentItem.NUMBER_AT17 == null;
                    case 24: // NUMBER_AT18
                        return CurrentItem.NUMBER_AT18 == null;
                    case 25: // NUMBER_AT19
                        return CurrentItem.NUMBER_AT19 == null;
                    case 26: // NUMBER_AT20
                        return CurrentItem.NUMBER_AT20 == null;
                    case 27: // NUMBER_AT21
                        return CurrentItem.NUMBER_AT21 == null;
                    case 28: // NUMBER_AT22
                        return CurrentItem.NUMBER_AT22 == null;
                    case 29: // NUMBER_AT23
                        return CurrentItem.NUMBER_AT23 == null;
                    case 30: // NUMBER_AT24
                        return CurrentItem.NUMBER_AT24 == null;
                    case 31: // NUMBER_AT25
                        return CurrentItem.NUMBER_AT25 == null;
                    case 32: // NUMBER_AT26
                        return CurrentItem.NUMBER_AT26 == null;
                    case 33: // NUMBER_AT27
                        return CurrentItem.NUMBER_AT27 == null;
                    case 34: // NUMBER_AT28
                        return CurrentItem.NUMBER_AT28 == null;
                    case 35: // SCHOOL_MEAN
                        return CurrentItem.SCHOOL_MEAN == null;
                    case 36: // SCHOOL_MIN
                        return CurrentItem.SCHOOL_MIN == null;
                    case 37: // SCHOOL_MAX
                        return CurrentItem.SCHOOL_MAX == null;
                    case 38: // SCHOOL_15TH
                        return CurrentItem.SCHOOL_15TH == null;
                    case 39: // SCHOOL_25TH
                        return CurrentItem.SCHOOL_25TH == null;
                    case 40: // SCHOOL_75TH
                        return CurrentItem.SCHOOL_75TH == null;
                    case 41: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 42: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 43: // LW_USER
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
                    case 1: // SCSFKEY
                        return "SCSFKEY";
                    case 2: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 3: // ST_CAMPUS
                        return "ST_CAMPUS";
                    case 4: // ST_YEAR_LEVEL
                        return "ST_YEAR_LEVEL";
                    case 5: // ST_CATEGORY
                        return "ST_CATEGORY";
                    case 6: // TOTAL_IN_GROUP
                        return "TOTAL_IN_GROUP";
                    case 7: // NUMBER_AT01
                        return "NUMBER_AT01";
                    case 8: // NUMBER_AT02
                        return "NUMBER_AT02";
                    case 9: // NUMBER_AT03
                        return "NUMBER_AT03";
                    case 10: // NUMBER_AT04
                        return "NUMBER_AT04";
                    case 11: // NUMBER_AT05
                        return "NUMBER_AT05";
                    case 12: // NUMBER_AT06
                        return "NUMBER_AT06";
                    case 13: // NUMBER_AT07
                        return "NUMBER_AT07";
                    case 14: // NUMBER_AT08
                        return "NUMBER_AT08";
                    case 15: // NUMBER_AT09
                        return "NUMBER_AT09";
                    case 16: // NUMBER_AT10
                        return "NUMBER_AT10";
                    case 17: // NUMBER_AT11
                        return "NUMBER_AT11";
                    case 18: // NUMBER_AT12
                        return "NUMBER_AT12";
                    case 19: // NUMBER_AT13
                        return "NUMBER_AT13";
                    case 20: // NUMBER_AT14
                        return "NUMBER_AT14";
                    case 21: // NUMBER_AT15
                        return "NUMBER_AT15";
                    case 22: // NUMBER_AT16
                        return "NUMBER_AT16";
                    case 23: // NUMBER_AT17
                        return "NUMBER_AT17";
                    case 24: // NUMBER_AT18
                        return "NUMBER_AT18";
                    case 25: // NUMBER_AT19
                        return "NUMBER_AT19";
                    case 26: // NUMBER_AT20
                        return "NUMBER_AT20";
                    case 27: // NUMBER_AT21
                        return "NUMBER_AT21";
                    case 28: // NUMBER_AT22
                        return "NUMBER_AT22";
                    case 29: // NUMBER_AT23
                        return "NUMBER_AT23";
                    case 30: // NUMBER_AT24
                        return "NUMBER_AT24";
                    case 31: // NUMBER_AT25
                        return "NUMBER_AT25";
                    case 32: // NUMBER_AT26
                        return "NUMBER_AT26";
                    case 33: // NUMBER_AT27
                        return "NUMBER_AT27";
                    case 34: // NUMBER_AT28
                        return "NUMBER_AT28";
                    case 35: // SCHOOL_MEAN
                        return "SCHOOL_MEAN";
                    case 36: // SCHOOL_MIN
                        return "SCHOOL_MIN";
                    case 37: // SCHOOL_MAX
                        return "SCHOOL_MAX";
                    case 38: // SCHOOL_15TH
                        return "SCHOOL_15TH";
                    case 39: // SCHOOL_25TH
                        return "SCHOOL_25TH";
                    case 40: // SCHOOL_75TH
                        return "SCHOOL_75TH";
                    case 41: // LW_DATE
                        return "LW_DATE";
                    case 42: // LW_TIME
                        return "LW_TIME";
                    case 43: // LW_USER
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
                    case "SCSFKEY":
                        return 1;
                    case "YEAR_SEMESTER":
                        return 2;
                    case "ST_CAMPUS":
                        return 3;
                    case "ST_YEAR_LEVEL":
                        return 4;
                    case "ST_CATEGORY":
                        return 5;
                    case "TOTAL_IN_GROUP":
                        return 6;
                    case "NUMBER_AT01":
                        return 7;
                    case "NUMBER_AT02":
                        return 8;
                    case "NUMBER_AT03":
                        return 9;
                    case "NUMBER_AT04":
                        return 10;
                    case "NUMBER_AT05":
                        return 11;
                    case "NUMBER_AT06":
                        return 12;
                    case "NUMBER_AT07":
                        return 13;
                    case "NUMBER_AT08":
                        return 14;
                    case "NUMBER_AT09":
                        return 15;
                    case "NUMBER_AT10":
                        return 16;
                    case "NUMBER_AT11":
                        return 17;
                    case "NUMBER_AT12":
                        return 18;
                    case "NUMBER_AT13":
                        return 19;
                    case "NUMBER_AT14":
                        return 20;
                    case "NUMBER_AT15":
                        return 21;
                    case "NUMBER_AT16":
                        return 22;
                    case "NUMBER_AT17":
                        return 23;
                    case "NUMBER_AT18":
                        return 24;
                    case "NUMBER_AT19":
                        return 25;
                    case "NUMBER_AT20":
                        return 26;
                    case "NUMBER_AT21":
                        return 27;
                    case "NUMBER_AT22":
                        return 28;
                    case "NUMBER_AT23":
                        return 29;
                    case "NUMBER_AT24":
                        return 30;
                    case "NUMBER_AT25":
                        return 31;
                    case "NUMBER_AT26":
                        return 32;
                    case "NUMBER_AT27":
                        return 33;
                    case "NUMBER_AT28":
                        return 34;
                    case "SCHOOL_MEAN":
                        return 35;
                    case "SCHOOL_MIN":
                        return 36;
                    case "SCHOOL_MAX":
                        return 37;
                    case "SCHOOL_15TH":
                        return 38;
                    case "SCHOOL_25TH":
                        return 39;
                    case "SCHOOL_75TH":
                        return 40;
                    case "LW_DATE":
                        return 41;
                    case "LW_TIME":
                        return 42;
                    case "LW_USER":
                        return 43;
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
