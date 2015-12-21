using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TEDataSet : EduHubDataSet<TE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TE"; } }

        internal TEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_CATEGORY = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.CATEGORY));
            Index_END_FORM = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.END_FORM));
            Index_END_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.END_YEAR));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_START_FORM = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.START_FORM));
            Index_START_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.START_YEAR));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_TEKEY = new Lazy<Dictionary<int, TE>>(() => this.ToDictionary(i => i.TEKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TE" /> fields for each CSV column header</returns>
        protected override Action<TE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TEKEY":
                        mapper[i] = (e, v) => e.TEKEY = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECURRENCE":
                        mapper[i] = (e, v) => e.RECURRENCE = v;
                        break;
                    case "RECUR_DAYS":
                        mapper[i] = (e, v) => e.RECUR_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "EVENT_GROUP":
                        mapper[i] = (e, v) => e.EVENT_GROUP = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "COLOUR":
                        mapper[i] = (e, v) => e.COLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EVENT_CODE":
                        mapper[i] = (e, v) => e.EVENT_CODE = v;
                        break;
                    case "START_YEAR":
                        mapper[i] = (e, v) => e.START_YEAR = v;
                        break;
                    case "END_YEAR":
                        mapper[i] = (e, v) => e.END_YEAR = v;
                        break;
                    case "START_FORM":
                        mapper[i] = (e, v) => e.START_FORM = v;
                        break;
                    case "END_FORM":
                        mapper[i] = (e, v) => e.END_FORM = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "START_CLASS_NUM":
                        mapper[i] = (e, v) => e.START_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_CLASS_NUM":
                        mapper[i] = (e, v) => e.END_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TE" /> items to added or update the base <see cref="TE" /> items</param>
        /// <returns>A merged list of <see cref="TE" /> items</returns>
        protected override List<TE> ApplyDeltaItems(List<TE> Items, List<TE> DeltaItems)
        {
            Dictionary<int, int> Index_TEKEY = Items.ToIndexDictionary(i => i.TEKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TE deltaItem in DeltaItems)
            {
                int index;

                if (Index_TEKEY.TryGetValue(deltaItem.TEKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<TE>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_END_FORM;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_END_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_START_FORM;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_START_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_SUBJ;
        private Lazy<Dictionary<int, TE>> Index_TEKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TE by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find TE by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<TE> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find TE by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<TE> value;
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
        /// Find TE by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find TE by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out IReadOnlyList<TE> Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find TE by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByCATEGORY(string CATEGORY)
        {
            IReadOnlyList<TE> value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by END_FORM field
        /// </summary>
        /// <param name="END_FORM">END_FORM value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByEND_FORM(string END_FORM)
        {
            return Index_END_FORM.Value[END_FORM];
        }

        /// <summary>
        /// Attempt to find TE by END_FORM field
        /// </summary>
        /// <param name="END_FORM">END_FORM value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEND_FORM(string END_FORM, out IReadOnlyList<TE> Value)
        {
            return Index_END_FORM.Value.TryGetValue(END_FORM, out Value);
        }

        /// <summary>
        /// Attempt to find TE by END_FORM field
        /// </summary>
        /// <param name="END_FORM">END_FORM value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByEND_FORM(string END_FORM)
        {
            IReadOnlyList<TE> value;
            if (Index_END_FORM.Value.TryGetValue(END_FORM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by END_YEAR field
        /// </summary>
        /// <param name="END_YEAR">END_YEAR value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByEND_YEAR(string END_YEAR)
        {
            return Index_END_YEAR.Value[END_YEAR];
        }

        /// <summary>
        /// Attempt to find TE by END_YEAR field
        /// </summary>
        /// <param name="END_YEAR">END_YEAR value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEND_YEAR(string END_YEAR, out IReadOnlyList<TE> Value)
        {
            return Index_END_YEAR.Value.TryGetValue(END_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find TE by END_YEAR field
        /// </summary>
        /// <param name="END_YEAR">END_YEAR value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByEND_YEAR(string END_YEAR)
        {
            IReadOnlyList<TE> value;
            if (Index_END_YEAR.Value.TryGetValue(END_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TE> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TE> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by START_FORM field
        /// </summary>
        /// <param name="START_FORM">START_FORM value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindBySTART_FORM(string START_FORM)
        {
            return Index_START_FORM.Value[START_FORM];
        }

        /// <summary>
        /// Attempt to find TE by START_FORM field
        /// </summary>
        /// <param name="START_FORM">START_FORM value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTART_FORM(string START_FORM, out IReadOnlyList<TE> Value)
        {
            return Index_START_FORM.Value.TryGetValue(START_FORM, out Value);
        }

        /// <summary>
        /// Attempt to find TE by START_FORM field
        /// </summary>
        /// <param name="START_FORM">START_FORM value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindBySTART_FORM(string START_FORM)
        {
            IReadOnlyList<TE> value;
            if (Index_START_FORM.Value.TryGetValue(START_FORM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by START_YEAR field
        /// </summary>
        /// <param name="START_YEAR">START_YEAR value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindBySTART_YEAR(string START_YEAR)
        {
            return Index_START_YEAR.Value[START_YEAR];
        }

        /// <summary>
        /// Attempt to find TE by START_YEAR field
        /// </summary>
        /// <param name="START_YEAR">START_YEAR value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTART_YEAR(string START_YEAR, out IReadOnlyList<TE> Value)
        {
            return Index_START_YEAR.Value.TryGetValue(START_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find TE by START_YEAR field
        /// </summary>
        /// <param name="START_YEAR">START_YEAR value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindBySTART_YEAR(string START_YEAR)
        {
            IReadOnlyList<TE> value;
            if (Index_START_YEAR.Value.TryGetValue(START_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TE by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TE> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TE by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TE> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by TEKEY field
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TE</param>
        /// <returns>Related TE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TE FindByTEKEY(int TEKEY)
        {
            return Index_TEKEY.Value[TEKEY];
        }

        /// <summary>
        /// Attempt to find TE by TEKEY field
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TE</param>
        /// <param name="Value">Related TE entity</param>
        /// <returns>True if the related TE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEKEY(int TEKEY, out TE Value)
        {
            return Index_TEKEY.Value.TryGetValue(TEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TE by TEKEY field
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TE</param>
        /// <returns>Related TE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TE TryFindByTEKEY(int TEKEY)
        {
            TE value;
            if (Index_TEKEY.Value.TryGetValue(TEKEY, out value))
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
        /// Returns SQL which checks for the existence of a TE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TE](
        [TEKEY] int IDENTITY NOT NULL,
        [TITLE] varchar(30) NULL,
        [CAMPUS] int NULL,
        [COMMENTS] text NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [RECURRENCE] varchar(1) NULL,
        [RECUR_DAYS] smallint NULL,
        [TIME_FROM] datetime NULL,
        [TIME_TO] datetime NULL,
        [CONVENOR] varchar(10) NULL,
        [CONVENOR_TYPE] varchar(8) NULL,
        [LOCATION] varchar(4) NULL,
        [EVENT_GROUP] varchar(12) NULL,
        [CATEGORY] varchar(10) NULL,
        [COLOUR] int NULL,
        [EVENT_CODE] varchar(4) NULL,
        [START_YEAR] varchar(4) NULL,
        [END_YEAR] varchar(4) NULL,
        [START_FORM] varchar(3) NULL,
        [END_FORM] varchar(3) NULL,
        [SUBJ] varchar(5) NULL,
        [START_CLASS_NUM] smallint NULL,
        [END_CLASS_NUM] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TE_Index_TEKEY] PRIMARY KEY CLUSTERED (
            [TEKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TE_Index_CAMPUS] ON [dbo].[TE]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_CATEGORY] ON [dbo].[TE]
    (
            [CATEGORY] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_END_FORM] ON [dbo].[TE]
    (
            [END_FORM] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_END_YEAR] ON [dbo].[TE]
    (
            [END_YEAR] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_LOCATION] ON [dbo].[TE]
    (
            [LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_START_FORM] ON [dbo].[TE]
    (
            [START_FORM] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_START_YEAR] ON [dbo].[TE]
    (
            [START_YEAR] ASC
    );
    CREATE NONCLUSTERED INDEX [TE_Index_SUBJ] ON [dbo].[TE]
    (
            [SUBJ] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TEDataReader : IDataReader, IDataRecord
        {
            private List<TE> Items;
            private int CurrentIndex;
            private TE CurrentItem;

            public TEDataReader(List<TE> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 27; } }
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
                    case 0: // TEKEY
                        return CurrentItem.TEKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 3: // COMMENTS
                        return CurrentItem.COMMENTS;
                    case 4: // START_DATE
                        return CurrentItem.START_DATE;
                    case 5: // END_DATE
                        return CurrentItem.END_DATE;
                    case 6: // RECURRENCE
                        return CurrentItem.RECURRENCE;
                    case 7: // RECUR_DAYS
                        return CurrentItem.RECUR_DAYS;
                    case 8: // TIME_FROM
                        return CurrentItem.TIME_FROM;
                    case 9: // TIME_TO
                        return CurrentItem.TIME_TO;
                    case 10: // CONVENOR
                        return CurrentItem.CONVENOR;
                    case 11: // CONVENOR_TYPE
                        return CurrentItem.CONVENOR_TYPE;
                    case 12: // LOCATION
                        return CurrentItem.LOCATION;
                    case 13: // EVENT_GROUP
                        return CurrentItem.EVENT_GROUP;
                    case 14: // CATEGORY
                        return CurrentItem.CATEGORY;
                    case 15: // COLOUR
                        return CurrentItem.COLOUR;
                    case 16: // EVENT_CODE
                        return CurrentItem.EVENT_CODE;
                    case 17: // START_YEAR
                        return CurrentItem.START_YEAR;
                    case 18: // END_YEAR
                        return CurrentItem.END_YEAR;
                    case 19: // START_FORM
                        return CurrentItem.START_FORM;
                    case 20: // END_FORM
                        return CurrentItem.END_FORM;
                    case 21: // SUBJ
                        return CurrentItem.SUBJ;
                    case 22: // START_CLASS_NUM
                        return CurrentItem.START_CLASS_NUM;
                    case 23: // END_CLASS_NUM
                        return CurrentItem.END_CLASS_NUM;
                    case 24: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 25: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 26: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 3: // COMMENTS
                        return CurrentItem.COMMENTS == null;
                    case 4: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 5: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 6: // RECURRENCE
                        return CurrentItem.RECURRENCE == null;
                    case 7: // RECUR_DAYS
                        return CurrentItem.RECUR_DAYS == null;
                    case 8: // TIME_FROM
                        return CurrentItem.TIME_FROM == null;
                    case 9: // TIME_TO
                        return CurrentItem.TIME_TO == null;
                    case 10: // CONVENOR
                        return CurrentItem.CONVENOR == null;
                    case 11: // CONVENOR_TYPE
                        return CurrentItem.CONVENOR_TYPE == null;
                    case 12: // LOCATION
                        return CurrentItem.LOCATION == null;
                    case 13: // EVENT_GROUP
                        return CurrentItem.EVENT_GROUP == null;
                    case 14: // CATEGORY
                        return CurrentItem.CATEGORY == null;
                    case 15: // COLOUR
                        return CurrentItem.COLOUR == null;
                    case 16: // EVENT_CODE
                        return CurrentItem.EVENT_CODE == null;
                    case 17: // START_YEAR
                        return CurrentItem.START_YEAR == null;
                    case 18: // END_YEAR
                        return CurrentItem.END_YEAR == null;
                    case 19: // START_FORM
                        return CurrentItem.START_FORM == null;
                    case 20: // END_FORM
                        return CurrentItem.END_FORM == null;
                    case 21: // SUBJ
                        return CurrentItem.SUBJ == null;
                    case 22: // START_CLASS_NUM
                        return CurrentItem.START_CLASS_NUM == null;
                    case 23: // END_CLASS_NUM
                        return CurrentItem.END_CLASS_NUM == null;
                    case 24: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 25: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 26: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TEKEY
                        return "TEKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // CAMPUS
                        return "CAMPUS";
                    case 3: // COMMENTS
                        return "COMMENTS";
                    case 4: // START_DATE
                        return "START_DATE";
                    case 5: // END_DATE
                        return "END_DATE";
                    case 6: // RECURRENCE
                        return "RECURRENCE";
                    case 7: // RECUR_DAYS
                        return "RECUR_DAYS";
                    case 8: // TIME_FROM
                        return "TIME_FROM";
                    case 9: // TIME_TO
                        return "TIME_TO";
                    case 10: // CONVENOR
                        return "CONVENOR";
                    case 11: // CONVENOR_TYPE
                        return "CONVENOR_TYPE";
                    case 12: // LOCATION
                        return "LOCATION";
                    case 13: // EVENT_GROUP
                        return "EVENT_GROUP";
                    case 14: // CATEGORY
                        return "CATEGORY";
                    case 15: // COLOUR
                        return "COLOUR";
                    case 16: // EVENT_CODE
                        return "EVENT_CODE";
                    case 17: // START_YEAR
                        return "START_YEAR";
                    case 18: // END_YEAR
                        return "END_YEAR";
                    case 19: // START_FORM
                        return "START_FORM";
                    case 20: // END_FORM
                        return "END_FORM";
                    case 21: // SUBJ
                        return "SUBJ";
                    case 22: // START_CLASS_NUM
                        return "START_CLASS_NUM";
                    case 23: // END_CLASS_NUM
                        return "END_CLASS_NUM";
                    case 24: // LW_DATE
                        return "LW_DATE";
                    case 25: // LW_TIME
                        return "LW_TIME";
                    case 26: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TEKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "CAMPUS":
                        return 2;
                    case "COMMENTS":
                        return 3;
                    case "START_DATE":
                        return 4;
                    case "END_DATE":
                        return 5;
                    case "RECURRENCE":
                        return 6;
                    case "RECUR_DAYS":
                        return 7;
                    case "TIME_FROM":
                        return 8;
                    case "TIME_TO":
                        return 9;
                    case "CONVENOR":
                        return 10;
                    case "CONVENOR_TYPE":
                        return 11;
                    case "LOCATION":
                        return 12;
                    case "EVENT_GROUP":
                        return 13;
                    case "CATEGORY":
                        return 14;
                    case "COLOUR":
                        return 15;
                    case "EVENT_CODE":
                        return 16;
                    case "START_YEAR":
                        return 17;
                    case "END_YEAR":
                        return 18;
                    case "START_FORM":
                        return 19;
                    case "END_FORM":
                        return 20;
                    case "SUBJ":
                        return 21;
                    case "START_CLASS_NUM":
                        return 22;
                    case "END_CLASS_NUM":
                        return 23;
                    case "LW_DATE":
                        return 24;
                    case "LW_TIME":
                        return 25;
                    case "LW_USER":
                        return 26;
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
