using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Converted Student Half-Day Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXABCONVDataSet : DataSetBase<SXABCONV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SXABCONV"; } }

        internal SXABCONVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AM_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.AM_TYPE));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_PM_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.PM_TYPE));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_STKEY = new Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.STKEY));
            Index_STKEY_ABSENCE_DATE = new Lazy<Dictionary<Tuple<string, DateTime?>, SXABCONV>>(() => this.ToDictionary(i => Tuple.Create(i.STKEY, i.ABSENCE_DATE)));
            Index_SXABCONV_ID = new Lazy<Dictionary<int, SXABCONV>>(() => this.ToDictionary(i => i.SXABCONV_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SXABCONV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SXABCONV" /> fields for each CSV column header</returns>
        protected override Action<SXABCONV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SXABCONV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SXABCONV_ID":
                        mapper[i] = (e, v) => e.SXABCONV_ID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AM_TYPE":
                        mapper[i] = (e, v) => e.AM_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_ATTENDED":
                        mapper[i] = (e, v) => e.AM_ATTENDED = v;
                        break;
                    case "AM_APPROVED":
                        mapper[i] = (e, v) => e.AM_APPROVED = v;
                        break;
                    case "PM_TYPE":
                        mapper[i] = (e, v) => e.PM_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_ATTENDED":
                        mapper[i] = (e, v) => e.PM_ATTENDED = v;
                        break;
                    case "PM_APPROVED":
                        mapper[i] = (e, v) => e.PM_APPROVED = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RECORD_SOURCE":
                        mapper[i] = (e, v) => e.RECORD_SOURCE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SXABCONV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SXABCONV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SXABCONV" /> items to added or update the base <see cref="SXABCONV" /> items</param>
        /// <returns>A merged list of <see cref="SXABCONV" /> items</returns>
        protected override List<SXABCONV> ApplyDeltaItems(List<SXABCONV> Items, List<SXABCONV> DeltaItems)
        {
            Dictionary<Tuple<string, DateTime?>, int> Index_STKEY_ABSENCE_DATE = Items.ToIndexDictionary(i => Tuple.Create(i.STKEY, i.ABSENCE_DATE));
            Dictionary<int, int> Index_SXABCONV_ID = Items.ToIndexDictionary(i => i.SXABCONV_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SXABCONV deltaItem in DeltaItems)
            {
                int index;

                if (Index_STKEY_ABSENCE_DATE.TryGetValue(Tuple.Create(deltaItem.STKEY, deltaItem.ABSENCE_DATE), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_SXABCONV_ID.TryGetValue(deltaItem.SXABCONV_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SXABCONV_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>> Index_AM_TYPE;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SXABCONV>>> Index_LW_DATE;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>> Index_PM_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>> Index_ST_YEAR_LEVEL;
        private Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>> Index_STKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?>, SXABCONV>> Index_STKEY_ABSENCE_DATE;
        private Lazy<Dictionary<int, SXABCONV>> Index_SXABCONV_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SXABCONV by AM_TYPE field
        /// </summary>
        /// <param name="AM_TYPE">AM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByAM_TYPE(short? AM_TYPE)
        {
            return Index_AM_TYPE.Value[AM_TYPE];
        }

        /// <summary>
        /// Attempt to find SXABCONV by AM_TYPE field
        /// </summary>
        /// <param name="AM_TYPE">AM_TYPE value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_TYPE(short? AM_TYPE, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_AM_TYPE.Value.TryGetValue(AM_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by AM_TYPE field
        /// </summary>
        /// <param name="AM_TYPE">AM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByAM_TYPE(short? AM_TYPE)
        {
            IReadOnlyList<SXABCONV> value;
            if (Index_AM_TYPE.Value.TryGetValue(AM_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXABCONV by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SXABCONV by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SXABCONV> value;
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
        /// Find SXABCONV by PM_TYPE field
        /// </summary>
        /// <param name="PM_TYPE">PM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByPM_TYPE(short? PM_TYPE)
        {
            return Index_PM_TYPE.Value[PM_TYPE];
        }

        /// <summary>
        /// Attempt to find SXABCONV by PM_TYPE field
        /// </summary>
        /// <param name="PM_TYPE">PM_TYPE value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_TYPE(short? PM_TYPE, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_PM_TYPE.Value.TryGetValue(PM_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by PM_TYPE field
        /// </summary>
        /// <param name="PM_TYPE">PM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByPM_TYPE(short? PM_TYPE)
        {
            IReadOnlyList<SXABCONV> value;
            if (Index_PM_TYPE.Value.TryGetValue(PM_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXABCONV by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SXABCONV by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SXABCONV> value;
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
        /// Find SXABCONV by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<SXABCONV> value;
            if (Index_STKEY.Value.TryGetValue(STKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXABCONV by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV FindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE)
        {
            return Index_STKEY_ABSENCE_DATE.Value[Tuple.Create(STKEY, ABSENCE_DATE)];
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXABCONV</param>
        /// <param name="Value">Related SXABCONV entity</param>
        /// <returns>True if the related SXABCONV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE, out SXABCONV Value)
        {
            return Index_STKEY_ABSENCE_DATE.Value.TryGetValue(Tuple.Create(STKEY, ABSENCE_DATE), out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV TryFindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE)
        {
            SXABCONV value;
            if (Index_STKEY_ABSENCE_DATE.Value.TryGetValue(Tuple.Create(STKEY, ABSENCE_DATE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXABCONV by SXABCONV_ID field
        /// </summary>
        /// <param name="SXABCONV_ID">SXABCONV_ID value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV FindBySXABCONV_ID(int SXABCONV_ID)
        {
            return Index_SXABCONV_ID.Value[SXABCONV_ID];
        }

        /// <summary>
        /// Attempt to find SXABCONV by SXABCONV_ID field
        /// </summary>
        /// <param name="SXABCONV_ID">SXABCONV_ID value used to find SXABCONV</param>
        /// <param name="Value">Related SXABCONV entity</param>
        /// <returns>True if the related SXABCONV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySXABCONV_ID(int SXABCONV_ID, out SXABCONV Value)
        {
            return Index_SXABCONV_ID.Value.TryGetValue(SXABCONV_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by SXABCONV_ID field
        /// </summary>
        /// <param name="SXABCONV_ID">SXABCONV_ID value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV TryFindBySXABCONV_ID(int SXABCONV_ID)
        {
            SXABCONV value;
            if (Index_SXABCONV_ID.Value.TryGetValue(SXABCONV_ID, out value))
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
        /// Returns SQL which checks for the existence of a SXABCONV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SXABCONV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SXABCONV](
        [SXABCONV_ID] int IDENTITY NOT NULL,
        [STKEY] varchar(10) NULL,
        [ST_YEAR_LEVEL] varchar(4) NULL,
        [ABSENCE_DATE] datetime NULL,
        [AM_TYPE] smallint NULL,
        [AM_ATTENDED] varchar(1) NULL,
        [AM_APPROVED] varchar(1) NULL,
        [PM_TYPE] smallint NULL,
        [PM_ATTENDED] varchar(1) NULL,
        [PM_APPROVED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [RECORD_SOURCE] varchar(20) NULL,
        CONSTRAINT [SXABCONV_Index_SXABCONV_ID] PRIMARY KEY CLUSTERED (
            [SXABCONV_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SXABCONV_Index_AM_TYPE] ON [dbo].[SXABCONV]
    (
            [AM_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXABCONV_Index_LW_DATE] ON [dbo].[SXABCONV]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXABCONV_Index_PM_TYPE] ON [dbo].[SXABCONV]
    (
            [PM_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXABCONV_Index_ST_YEAR_LEVEL] ON [dbo].[SXABCONV]
    (
            [ST_YEAR_LEVEL] ASC
    );
    CREATE NONCLUSTERED INDEX [SXABCONV_Index_STKEY] ON [dbo].[SXABCONV]
    (
            [STKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SXABCONV_Index_STKEY_ABSENCE_DATE] ON [dbo].[SXABCONV]
    (
            [STKEY] ASC,
            [ABSENCE_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SXABCONV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SXABCONV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SXABCONVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SXABCONVDataReader : IDataReader, IDataRecord
        {
            private List<SXABCONV> Items;
            private int CurrentIndex;
            private SXABCONV CurrentItem;

            public SXABCONVDataReader(List<SXABCONV> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 13; } }
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
                    case 0: // SXABCONV_ID
                        return CurrentItem.SXABCONV_ID;
                    case 1: // STKEY
                        return CurrentItem.STKEY;
                    case 2: // ST_YEAR_LEVEL
                        return CurrentItem.ST_YEAR_LEVEL;
                    case 3: // ABSENCE_DATE
                        return CurrentItem.ABSENCE_DATE;
                    case 4: // AM_TYPE
                        return CurrentItem.AM_TYPE;
                    case 5: // AM_ATTENDED
                        return CurrentItem.AM_ATTENDED;
                    case 6: // AM_APPROVED
                        return CurrentItem.AM_APPROVED;
                    case 7: // PM_TYPE
                        return CurrentItem.PM_TYPE;
                    case 8: // PM_ATTENDED
                        return CurrentItem.PM_ATTENDED;
                    case 9: // PM_APPROVED
                        return CurrentItem.PM_APPROVED;
                    case 10: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 11: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 12: // RECORD_SOURCE
                        return CurrentItem.RECORD_SOURCE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // STKEY
                        return CurrentItem.STKEY == null;
                    case 2: // ST_YEAR_LEVEL
                        return CurrentItem.ST_YEAR_LEVEL == null;
                    case 3: // ABSENCE_DATE
                        return CurrentItem.ABSENCE_DATE == null;
                    case 4: // AM_TYPE
                        return CurrentItem.AM_TYPE == null;
                    case 5: // AM_ATTENDED
                        return CurrentItem.AM_ATTENDED == null;
                    case 6: // AM_APPROVED
                        return CurrentItem.AM_APPROVED == null;
                    case 7: // PM_TYPE
                        return CurrentItem.PM_TYPE == null;
                    case 8: // PM_ATTENDED
                        return CurrentItem.PM_ATTENDED == null;
                    case 9: // PM_APPROVED
                        return CurrentItem.PM_APPROVED == null;
                    case 10: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 11: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 12: // RECORD_SOURCE
                        return CurrentItem.RECORD_SOURCE == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SXABCONV_ID
                        return "SXABCONV_ID";
                    case 1: // STKEY
                        return "STKEY";
                    case 2: // ST_YEAR_LEVEL
                        return "ST_YEAR_LEVEL";
                    case 3: // ABSENCE_DATE
                        return "ABSENCE_DATE";
                    case 4: // AM_TYPE
                        return "AM_TYPE";
                    case 5: // AM_ATTENDED
                        return "AM_ATTENDED";
                    case 6: // AM_APPROVED
                        return "AM_APPROVED";
                    case 7: // PM_TYPE
                        return "PM_TYPE";
                    case 8: // PM_ATTENDED
                        return "PM_ATTENDED";
                    case 9: // PM_APPROVED
                        return "PM_APPROVED";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // RECORD_SOURCE
                        return "RECORD_SOURCE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SXABCONV_ID":
                        return 0;
                    case "STKEY":
                        return 1;
                    case "ST_YEAR_LEVEL":
                        return 2;
                    case "ABSENCE_DATE":
                        return 3;
                    case "AM_TYPE":
                        return 4;
                    case "AM_ATTENDED":
                        return 5;
                    case "AM_APPROVED":
                        return 6;
                    case "PM_TYPE":
                        return 7;
                    case "PM_ATTENDED":
                        return 8;
                    case "PM_APPROVED":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "RECORD_SOURCE":
                        return 12;
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
