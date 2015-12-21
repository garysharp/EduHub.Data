using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCDataSet : EduHubDataSet<KGC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGC"; } }

        internal KGCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_KGCKEY = new Lazy<Dictionary<string, KGC>>(() => this.ToDictionary(i => i.KGCKEY));
            Index_MAX_AC_YR = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.MAX_AC_YR));
            Index_MIN_AC_YR = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.MIN_AC_YR));
            Index_NEXT_HG = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_HG));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHER_B = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER_B));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGC" /> fields for each CSV column header</returns>
        protected override Action<KGC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "HG_SIZE":
                        mapper[i] = (e, v) => e.HG_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MIN_AC_YR":
                        mapper[i] = (e, v) => e.MIN_AC_YR = v;
                        break;
                    case "MAX_AC_YR":
                        mapper[i] = (e, v) => e.MAX_AC_YR = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
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
        /// Merges <see cref="KGC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGC" /> items to added or update the base <see cref="KGC" /> items</param>
        /// <returns>A merged list of <see cref="KGC" /> items</returns>
        protected override List<KGC> ApplyDeltaItems(List<KGC> Items, List<KGC> DeltaItems)
        {
            Dictionary<string, int> Index_KGCKEY = Items.ToIndexDictionary(i => i.KGCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGCKEY.TryGetValue(deltaItem.KGCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<KGC>>> Index_CAMPUS;
        private Lazy<Dictionary<string, KGC>> Index_KGCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_MAX_AC_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_MIN_AC_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_NEXT_HG;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_TEACHER_B;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find KGC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<KGC> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<KGC> value;
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
        /// Find KGC by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGC FindByKGCKEY(string KGCKEY)
        {
            return Index_KGCKEY.Value[KGCKEY];
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC</param>
        /// <param name="Value">Related KGC entity</param>
        /// <returns>True if the related KGC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCKEY(string KGCKEY, out KGC Value)
        {
            return Index_KGCKEY.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGC TryFindByKGCKEY(string KGCKEY)
        {
            KGC value;
            if (Index_KGCKEY.Value.TryGetValue(KGCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by MAX_AC_YR field
        /// </summary>
        /// <param name="MAX_AC_YR">MAX_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByMAX_AC_YR(string MAX_AC_YR)
        {
            return Index_MAX_AC_YR.Value[MAX_AC_YR];
        }

        /// <summary>
        /// Attempt to find KGC by MAX_AC_YR field
        /// </summary>
        /// <param name="MAX_AC_YR">MAX_AC_YR value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAX_AC_YR(string MAX_AC_YR, out IReadOnlyList<KGC> Value)
        {
            return Index_MAX_AC_YR.Value.TryGetValue(MAX_AC_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by MAX_AC_YR field
        /// </summary>
        /// <param name="MAX_AC_YR">MAX_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByMAX_AC_YR(string MAX_AC_YR)
        {
            IReadOnlyList<KGC> value;
            if (Index_MAX_AC_YR.Value.TryGetValue(MAX_AC_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by MIN_AC_YR field
        /// </summary>
        /// <param name="MIN_AC_YR">MIN_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByMIN_AC_YR(string MIN_AC_YR)
        {
            return Index_MIN_AC_YR.Value[MIN_AC_YR];
        }

        /// <summary>
        /// Attempt to find KGC by MIN_AC_YR field
        /// </summary>
        /// <param name="MIN_AC_YR">MIN_AC_YR value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMIN_AC_YR(string MIN_AC_YR, out IReadOnlyList<KGC> Value)
        {
            return Index_MIN_AC_YR.Value.TryGetValue(MIN_AC_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by MIN_AC_YR field
        /// </summary>
        /// <param name="MIN_AC_YR">MIN_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByMIN_AC_YR(string MIN_AC_YR)
        {
            IReadOnlyList<KGC> value;
            if (Index_MIN_AC_YR.Value.TryGetValue(MIN_AC_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByNEXT_HG(string NEXT_HG)
        {
            return Index_NEXT_HG.Value[NEXT_HG];
        }

        /// <summary>
        /// Attempt to find KGC by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_HG(string NEXT_HG, out IReadOnlyList<KGC> Value)
        {
            return Index_NEXT_HG.Value.TryGetValue(NEXT_HG, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByNEXT_HG(string NEXT_HG)
        {
            IReadOnlyList<KGC> value;
            if (Index_NEXT_HG.Value.TryGetValue(NEXT_HG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find KGC by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<KGC> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<KGC> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<KGC> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<KGC> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByTEACHER_B(string TEACHER_B)
        {
            return Index_TEACHER_B.Value[TEACHER_B];
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER_B(string TEACHER_B, out IReadOnlyList<KGC> Value)
        {
            return Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByTEACHER_B(string TEACHER_B)
        {
            IReadOnlyList<KGC> value;
            if (Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out value))
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
        /// Returns SQL which checks for the existence of a KGC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGC](
        [KGCKEY] varchar(3) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [CAMPUS] int NULL,
        [TEACHER] varchar(4) NULL,
        [TEACHER_B] varchar(4) NULL,
        [ACTIVE] varchar(1) NULL,
        [ROOM] varchar(4) NULL,
        [HG_SIZE] smallint NULL,
        [MALES] smallint NULL,
        [FEMALES] smallint NULL,
        [MIN_AC_YR] varchar(4) NULL,
        [MAX_AC_YR] varchar(4) NULL,
        [NEXT_HG] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGC_Index_KGCKEY] PRIMARY KEY CLUSTERED (
            [KGCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_CAMPUS] ON [dbo].[KGC]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_MAX_AC_YR] ON [dbo].[KGC]
    (
            [MAX_AC_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_MIN_AC_YR] ON [dbo].[KGC]
    (
            [MIN_AC_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_NEXT_HG] ON [dbo].[KGC]
    (
            [NEXT_HG] ASC
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_ROOM] ON [dbo].[KGC]
    (
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_TEACHER] ON [dbo].[KGC]
    (
            [TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [KGC_Index_TEACHER_B] ON [dbo].[KGC]
    (
            [TEACHER_B] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGCDataReader : IDataReader, IDataRecord
        {
            private List<KGC> Items;
            private int CurrentIndex;
            private KGC CurrentItem;

            public KGCDataReader(List<KGC> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 16; } }
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
                    case 0: // KGCKEY
                        return CurrentItem.KGCKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 3: // TEACHER
                        return CurrentItem.TEACHER;
                    case 4: // TEACHER_B
                        return CurrentItem.TEACHER_B;
                    case 5: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 6: // ROOM
                        return CurrentItem.ROOM;
                    case 7: // HG_SIZE
                        return CurrentItem.HG_SIZE;
                    case 8: // MALES
                        return CurrentItem.MALES;
                    case 9: // FEMALES
                        return CurrentItem.FEMALES;
                    case 10: // MIN_AC_YR
                        return CurrentItem.MIN_AC_YR;
                    case 11: // MAX_AC_YR
                        return CurrentItem.MAX_AC_YR;
                    case 12: // NEXT_HG
                        return CurrentItem.NEXT_HG;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 15: // LW_USER
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
                    case 2: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 3: // TEACHER
                        return CurrentItem.TEACHER == null;
                    case 4: // TEACHER_B
                        return CurrentItem.TEACHER_B == null;
                    case 5: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 6: // ROOM
                        return CurrentItem.ROOM == null;
                    case 7: // HG_SIZE
                        return CurrentItem.HG_SIZE == null;
                    case 8: // MALES
                        return CurrentItem.MALES == null;
                    case 9: // FEMALES
                        return CurrentItem.FEMALES == null;
                    case 10: // MIN_AC_YR
                        return CurrentItem.MIN_AC_YR == null;
                    case 11: // MAX_AC_YR
                        return CurrentItem.MAX_AC_YR == null;
                    case 12: // NEXT_HG
                        return CurrentItem.NEXT_HG == null;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGCKEY
                        return "KGCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // CAMPUS
                        return "CAMPUS";
                    case 3: // TEACHER
                        return "TEACHER";
                    case 4: // TEACHER_B
                        return "TEACHER_B";
                    case 5: // ACTIVE
                        return "ACTIVE";
                    case 6: // ROOM
                        return "ROOM";
                    case 7: // HG_SIZE
                        return "HG_SIZE";
                    case 8: // MALES
                        return "MALES";
                    case 9: // FEMALES
                        return "FEMALES";
                    case 10: // MIN_AC_YR
                        return "MIN_AC_YR";
                    case 11: // MAX_AC_YR
                        return "MAX_AC_YR";
                    case 12: // NEXT_HG
                        return "NEXT_HG";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "CAMPUS":
                        return 2;
                    case "TEACHER":
                        return 3;
                    case "TEACHER_B":
                        return 4;
                    case "ACTIVE":
                        return 5;
                    case "ROOM":
                        return 6;
                    case "HG_SIZE":
                        return 7;
                    case "MALES":
                        return 8;
                    case "FEMALES":
                        return 9;
                    case "MIN_AC_YR":
                        return 10;
                    case "MAX_AC_YR":
                        return 11;
                    case "NEXT_HG":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
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
