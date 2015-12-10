using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Aggregated Dimensions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SVAGDataSet : DataSetBase<SVAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SVAG"; } }

        internal SVAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COHORT = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.COHORT));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_SVAGKEY = new Lazy<Dictionary<int, SVAG>>(() => this.ToDictionary(i => i.SVAGKEY));
            Index_VDIMENSION = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.VDIMENSION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SVAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SVAG" /> fields for each CSV column header</returns>
        protected override Action<SVAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SVAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SVAGKEY":
                        mapper[i] = (e, v) => e.SVAGKEY = int.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
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
                    case "VDIMENSION":
                        mapper[i] = (e, v) => e.VDIMENSION = v;
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
                    case "NUMBER_AT29":
                        mapper[i] = (e, v) => e.NUMBER_AT29 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT30":
                        mapper[i] = (e, v) => e.NUMBER_AT30 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_NA":
                        mapper[i] = (e, v) => e.NO_NA = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOTAL_NUMBER":
                        mapper[i] = (e, v) => e.TOTAL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENT_TO_DEET":
                        mapper[i] = (e, v) => e.SENT_TO_DEET = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SVAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SVAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SVAG" /> items to added or update the base <see cref="SVAG" /> items</param>
        /// <returns>A merged list of <see cref="SVAG" /> items</returns>
        protected override List<SVAG> ApplyDeltaItems(List<SVAG> Items, List<SVAG> DeltaItems)
        {
            Dictionary<int, int> Index_SVAGKEY = Items.ToIndexDictionary(i => i.SVAGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SVAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SVAGKEY.TryGetValue(deltaItem.SVAGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SVAGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_COHORT;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_SCHOOL_YEAR;
        private Lazy<Dictionary<int, SVAG>> Index_SVAGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_VDIMENSION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByCOHORT(string COHORT)
        {
            return Index_COHORT.Value[COHORT];
        }

        /// <summary>
        /// Attempt to find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOHORT(string COHORT, out IReadOnlyList<SVAG> Value)
        {
            return Index_COHORT.Value.TryGetValue(COHORT, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByCOHORT(string COHORT)
        {
            IReadOnlyList<SVAG> value;
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
        /// Find SVAG by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find SVAG by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<SVAG> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<SVAG> value;
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
        /// Find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <returns>Related SVAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SVAG FindBySVAGKEY(int SVAGKEY)
        {
            return Index_SVAGKEY.Value[SVAGKEY];
        }

        /// <summary>
        /// Attempt to find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <param name="Value">Related SVAG entity</param>
        /// <returns>True if the related SVAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySVAGKEY(int SVAGKEY, out SVAG Value)
        {
            return Index_SVAGKEY.Value.TryGetValue(SVAGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <returns>Related SVAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SVAG TryFindBySVAGKEY(int SVAGKEY)
        {
            SVAG value;
            if (Index_SVAGKEY.Value.TryGetValue(SVAGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByVDIMENSION(string VDIMENSION)
        {
            return Index_VDIMENSION.Value[VDIMENSION];
        }

        /// <summary>
        /// Attempt to find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDIMENSION(string VDIMENSION, out IReadOnlyList<SVAG> Value)
        {
            return Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByVDIMENSION(string VDIMENSION)
        {
            IReadOnlyList<SVAG> value;
            if (Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out value))
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
        /// Returns SQL which checks for the existence of a SVAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SVAG](
        [SVAGKEY] int IDENTITY NOT NULL,
        [COHORT] varchar(2) NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [CAMPUS] int NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [VDIMENSION] varchar(10) NULL,
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
        [NUMBER_AT29] smallint NULL,
        [NUMBER_AT30] smallint NULL,
        [NO_NA] smallint NULL,
        [TOTAL_NUMBER] smallint NULL,
        [SENT_TO_DEET] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SVAG_Index_SVAGKEY] PRIMARY KEY CLUSTERED (
            [SVAGKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SVAG_Index_COHORT] ON [dbo].[SVAG]
    (
            [COHORT] ASC
    );
    CREATE NONCLUSTERED INDEX [SVAG_Index_SCHOOL_YEAR] ON [dbo].[SVAG]
    (
            [SCHOOL_YEAR] ASC
    );
    CREATE NONCLUSTERED INDEX [SVAG_Index_VDIMENSION] ON [dbo].[SVAG]
    (
            [VDIMENSION] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SVAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SVAG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SVAGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SVAGDataReader : IDataReader, IDataRecord
        {
            private List<SVAG> Items;
            private int CurrentIndex;
            private SVAG CurrentItem;

            public SVAGDataReader(List<SVAG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 42; } }
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
                    case 0: // SVAGKEY
                        return CurrentItem.SVAGKEY;
                    case 1: // COHORT
                        return CurrentItem.COHORT;
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR;
                    case 3: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 4: // YEAR_SEMESTER
                        return CurrentItem.YEAR_SEMESTER;
                    case 5: // VDIMENSION
                        return CurrentItem.VDIMENSION;
                    case 6: // NUMBER_AT01
                        return CurrentItem.NUMBER_AT01;
                    case 7: // NUMBER_AT02
                        return CurrentItem.NUMBER_AT02;
                    case 8: // NUMBER_AT03
                        return CurrentItem.NUMBER_AT03;
                    case 9: // NUMBER_AT04
                        return CurrentItem.NUMBER_AT04;
                    case 10: // NUMBER_AT05
                        return CurrentItem.NUMBER_AT05;
                    case 11: // NUMBER_AT06
                        return CurrentItem.NUMBER_AT06;
                    case 12: // NUMBER_AT07
                        return CurrentItem.NUMBER_AT07;
                    case 13: // NUMBER_AT08
                        return CurrentItem.NUMBER_AT08;
                    case 14: // NUMBER_AT09
                        return CurrentItem.NUMBER_AT09;
                    case 15: // NUMBER_AT10
                        return CurrentItem.NUMBER_AT10;
                    case 16: // NUMBER_AT11
                        return CurrentItem.NUMBER_AT11;
                    case 17: // NUMBER_AT12
                        return CurrentItem.NUMBER_AT12;
                    case 18: // NUMBER_AT13
                        return CurrentItem.NUMBER_AT13;
                    case 19: // NUMBER_AT14
                        return CurrentItem.NUMBER_AT14;
                    case 20: // NUMBER_AT15
                        return CurrentItem.NUMBER_AT15;
                    case 21: // NUMBER_AT16
                        return CurrentItem.NUMBER_AT16;
                    case 22: // NUMBER_AT17
                        return CurrentItem.NUMBER_AT17;
                    case 23: // NUMBER_AT18
                        return CurrentItem.NUMBER_AT18;
                    case 24: // NUMBER_AT19
                        return CurrentItem.NUMBER_AT19;
                    case 25: // NUMBER_AT20
                        return CurrentItem.NUMBER_AT20;
                    case 26: // NUMBER_AT21
                        return CurrentItem.NUMBER_AT21;
                    case 27: // NUMBER_AT22
                        return CurrentItem.NUMBER_AT22;
                    case 28: // NUMBER_AT23
                        return CurrentItem.NUMBER_AT23;
                    case 29: // NUMBER_AT24
                        return CurrentItem.NUMBER_AT24;
                    case 30: // NUMBER_AT25
                        return CurrentItem.NUMBER_AT25;
                    case 31: // NUMBER_AT26
                        return CurrentItem.NUMBER_AT26;
                    case 32: // NUMBER_AT27
                        return CurrentItem.NUMBER_AT27;
                    case 33: // NUMBER_AT28
                        return CurrentItem.NUMBER_AT28;
                    case 34: // NUMBER_AT29
                        return CurrentItem.NUMBER_AT29;
                    case 35: // NUMBER_AT30
                        return CurrentItem.NUMBER_AT30;
                    case 36: // NO_NA
                        return CurrentItem.NO_NA;
                    case 37: // TOTAL_NUMBER
                        return CurrentItem.TOTAL_NUMBER;
                    case 38: // SENT_TO_DEET
                        return CurrentItem.SENT_TO_DEET;
                    case 39: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 40: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 41: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // COHORT
                        return CurrentItem.COHORT == null;
                    case 2: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR == null;
                    case 3: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 4: // YEAR_SEMESTER
                        return CurrentItem.YEAR_SEMESTER == null;
                    case 5: // VDIMENSION
                        return CurrentItem.VDIMENSION == null;
                    case 6: // NUMBER_AT01
                        return CurrentItem.NUMBER_AT01 == null;
                    case 7: // NUMBER_AT02
                        return CurrentItem.NUMBER_AT02 == null;
                    case 8: // NUMBER_AT03
                        return CurrentItem.NUMBER_AT03 == null;
                    case 9: // NUMBER_AT04
                        return CurrentItem.NUMBER_AT04 == null;
                    case 10: // NUMBER_AT05
                        return CurrentItem.NUMBER_AT05 == null;
                    case 11: // NUMBER_AT06
                        return CurrentItem.NUMBER_AT06 == null;
                    case 12: // NUMBER_AT07
                        return CurrentItem.NUMBER_AT07 == null;
                    case 13: // NUMBER_AT08
                        return CurrentItem.NUMBER_AT08 == null;
                    case 14: // NUMBER_AT09
                        return CurrentItem.NUMBER_AT09 == null;
                    case 15: // NUMBER_AT10
                        return CurrentItem.NUMBER_AT10 == null;
                    case 16: // NUMBER_AT11
                        return CurrentItem.NUMBER_AT11 == null;
                    case 17: // NUMBER_AT12
                        return CurrentItem.NUMBER_AT12 == null;
                    case 18: // NUMBER_AT13
                        return CurrentItem.NUMBER_AT13 == null;
                    case 19: // NUMBER_AT14
                        return CurrentItem.NUMBER_AT14 == null;
                    case 20: // NUMBER_AT15
                        return CurrentItem.NUMBER_AT15 == null;
                    case 21: // NUMBER_AT16
                        return CurrentItem.NUMBER_AT16 == null;
                    case 22: // NUMBER_AT17
                        return CurrentItem.NUMBER_AT17 == null;
                    case 23: // NUMBER_AT18
                        return CurrentItem.NUMBER_AT18 == null;
                    case 24: // NUMBER_AT19
                        return CurrentItem.NUMBER_AT19 == null;
                    case 25: // NUMBER_AT20
                        return CurrentItem.NUMBER_AT20 == null;
                    case 26: // NUMBER_AT21
                        return CurrentItem.NUMBER_AT21 == null;
                    case 27: // NUMBER_AT22
                        return CurrentItem.NUMBER_AT22 == null;
                    case 28: // NUMBER_AT23
                        return CurrentItem.NUMBER_AT23 == null;
                    case 29: // NUMBER_AT24
                        return CurrentItem.NUMBER_AT24 == null;
                    case 30: // NUMBER_AT25
                        return CurrentItem.NUMBER_AT25 == null;
                    case 31: // NUMBER_AT26
                        return CurrentItem.NUMBER_AT26 == null;
                    case 32: // NUMBER_AT27
                        return CurrentItem.NUMBER_AT27 == null;
                    case 33: // NUMBER_AT28
                        return CurrentItem.NUMBER_AT28 == null;
                    case 34: // NUMBER_AT29
                        return CurrentItem.NUMBER_AT29 == null;
                    case 35: // NUMBER_AT30
                        return CurrentItem.NUMBER_AT30 == null;
                    case 36: // NO_NA
                        return CurrentItem.NO_NA == null;
                    case 37: // TOTAL_NUMBER
                        return CurrentItem.TOTAL_NUMBER == null;
                    case 38: // SENT_TO_DEET
                        return CurrentItem.SENT_TO_DEET == null;
                    case 39: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 40: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 41: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SVAGKEY
                        return "SVAGKEY";
                    case 1: // COHORT
                        return "COHORT";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // CAMPUS
                        return "CAMPUS";
                    case 4: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 5: // VDIMENSION
                        return "VDIMENSION";
                    case 6: // NUMBER_AT01
                        return "NUMBER_AT01";
                    case 7: // NUMBER_AT02
                        return "NUMBER_AT02";
                    case 8: // NUMBER_AT03
                        return "NUMBER_AT03";
                    case 9: // NUMBER_AT04
                        return "NUMBER_AT04";
                    case 10: // NUMBER_AT05
                        return "NUMBER_AT05";
                    case 11: // NUMBER_AT06
                        return "NUMBER_AT06";
                    case 12: // NUMBER_AT07
                        return "NUMBER_AT07";
                    case 13: // NUMBER_AT08
                        return "NUMBER_AT08";
                    case 14: // NUMBER_AT09
                        return "NUMBER_AT09";
                    case 15: // NUMBER_AT10
                        return "NUMBER_AT10";
                    case 16: // NUMBER_AT11
                        return "NUMBER_AT11";
                    case 17: // NUMBER_AT12
                        return "NUMBER_AT12";
                    case 18: // NUMBER_AT13
                        return "NUMBER_AT13";
                    case 19: // NUMBER_AT14
                        return "NUMBER_AT14";
                    case 20: // NUMBER_AT15
                        return "NUMBER_AT15";
                    case 21: // NUMBER_AT16
                        return "NUMBER_AT16";
                    case 22: // NUMBER_AT17
                        return "NUMBER_AT17";
                    case 23: // NUMBER_AT18
                        return "NUMBER_AT18";
                    case 24: // NUMBER_AT19
                        return "NUMBER_AT19";
                    case 25: // NUMBER_AT20
                        return "NUMBER_AT20";
                    case 26: // NUMBER_AT21
                        return "NUMBER_AT21";
                    case 27: // NUMBER_AT22
                        return "NUMBER_AT22";
                    case 28: // NUMBER_AT23
                        return "NUMBER_AT23";
                    case 29: // NUMBER_AT24
                        return "NUMBER_AT24";
                    case 30: // NUMBER_AT25
                        return "NUMBER_AT25";
                    case 31: // NUMBER_AT26
                        return "NUMBER_AT26";
                    case 32: // NUMBER_AT27
                        return "NUMBER_AT27";
                    case 33: // NUMBER_AT28
                        return "NUMBER_AT28";
                    case 34: // NUMBER_AT29
                        return "NUMBER_AT29";
                    case 35: // NUMBER_AT30
                        return "NUMBER_AT30";
                    case 36: // NO_NA
                        return "NO_NA";
                    case 37: // TOTAL_NUMBER
                        return "TOTAL_NUMBER";
                    case 38: // SENT_TO_DEET
                        return "SENT_TO_DEET";
                    case 39: // LW_DATE
                        return "LW_DATE";
                    case 40: // LW_TIME
                        return "LW_TIME";
                    case 41: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SVAGKEY":
                        return 0;
                    case "COHORT":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "CAMPUS":
                        return 3;
                    case "YEAR_SEMESTER":
                        return 4;
                    case "VDIMENSION":
                        return 5;
                    case "NUMBER_AT01":
                        return 6;
                    case "NUMBER_AT02":
                        return 7;
                    case "NUMBER_AT03":
                        return 8;
                    case "NUMBER_AT04":
                        return 9;
                    case "NUMBER_AT05":
                        return 10;
                    case "NUMBER_AT06":
                        return 11;
                    case "NUMBER_AT07":
                        return 12;
                    case "NUMBER_AT08":
                        return 13;
                    case "NUMBER_AT09":
                        return 14;
                    case "NUMBER_AT10":
                        return 15;
                    case "NUMBER_AT11":
                        return 16;
                    case "NUMBER_AT12":
                        return 17;
                    case "NUMBER_AT13":
                        return 18;
                    case "NUMBER_AT14":
                        return 19;
                    case "NUMBER_AT15":
                        return 20;
                    case "NUMBER_AT16":
                        return 21;
                    case "NUMBER_AT17":
                        return 22;
                    case "NUMBER_AT18":
                        return 23;
                    case "NUMBER_AT19":
                        return 24;
                    case "NUMBER_AT20":
                        return 25;
                    case "NUMBER_AT21":
                        return 26;
                    case "NUMBER_AT22":
                        return 27;
                    case "NUMBER_AT23":
                        return 28;
                    case "NUMBER_AT24":
                        return 29;
                    case "NUMBER_AT25":
                        return 30;
                    case "NUMBER_AT26":
                        return 31;
                    case "NUMBER_AT27":
                        return 32;
                    case "NUMBER_AT28":
                        return 33;
                    case "NUMBER_AT29":
                        return 34;
                    case "NUMBER_AT30":
                        return 35;
                    case "NO_NA":
                        return 36;
                    case "TOTAL_NUMBER":
                        return 37;
                    case "SENT_TO_DEET":
                        return 38;
                    case "LW_DATE":
                        return 39;
                    case "LW_TIME":
                        return 40;
                    case "LW_USER":
                        return 41;
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
