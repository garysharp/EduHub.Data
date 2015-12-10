using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCLDataSet : DataSetBase<SCL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCL"; } }

        internal SCLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.QUILT));
            Index_QUILT_SUBJECT_CLASS = new Lazy<Dictionary<Tuple<string, string, short?>, SCL>>(() => this.ToDictionary(i => Tuple.Create(i.QUILT, i.SUBJECT, i.CLASS)));
            Index_ROOM01 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.ROOM01));
            Index_ROOM02 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.ROOM02));
            Index_SCLKEY = new Lazy<Dictionary<string, SCL>>(() => this.ToDictionary(i => i.SCLKEY));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_TEACHER01 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER01));
            Index_TEACHER02 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER02));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCL" /> fields for each CSV column header</returns>
        protected override Action<SCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCLKEY":
                        mapper[i] = (e, v) => e.SCLKEY = v;
                        break;
                    case "QUILT":
                        mapper[i] = (e, v) => e.QUILT = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER01":
                        mapper[i] = (e, v) => e.TEACHER01 = v;
                        break;
                    case "TEACHER02":
                        mapper[i] = (e, v) => e.TEACHER02 = v;
                        break;
                    case "ROOM01":
                        mapper[i] = (e, v) => e.ROOM01 = v;
                        break;
                    case "ROOM02":
                        mapper[i] = (e, v) => e.ROOM02 = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRINT_FLAGS01":
                        mapper[i] = (e, v) => e.PRINT_FLAGS01 = v;
                        break;
                    case "PRINT_FLAGS02":
                        mapper[i] = (e, v) => e.PRINT_FLAGS02 = v;
                        break;
                    case "PRINT_FLAGS03":
                        mapper[i] = (e, v) => e.PRINT_FLAGS03 = v;
                        break;
                    case "PERIOD_ABSENCES":
                        mapper[i] = (e, v) => e.PERIOD_ABSENCES = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ALIAS":
                        mapper[i] = (e, v) => e.ALIAS = v;
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
        /// Merges <see cref="SCL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCL" /> items to added or update the base <see cref="SCL" /> items</param>
        /// <returns>A merged list of <see cref="SCL" /> items</returns>
        protected override List<SCL> ApplyDeltaItems(List<SCL> Items, List<SCL> DeltaItems)
        {
            Dictionary<Tuple<string, string, short?>, int> Index_QUILT_SUBJECT_CLASS = Items.ToIndexDictionary(i => Tuple.Create(i.QUILT, i.SUBJECT, i.CLASS));
            Dictionary<string, int> Index_SCLKEY = Items.ToIndexDictionary(i => i.SCLKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCL deltaItem in DeltaItems)
            {
                int index;

                if (Index_QUILT_SUBJECT_CLASS.TryGetValue(Tuple.Create(deltaItem.QUILT, deltaItem.SUBJECT, deltaItem.CLASS), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_SCLKEY.TryGetValue(deltaItem.SCLKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCLKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SCL>>> Index_CAMPUS;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SCL>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_QUILT;
        private Lazy<Dictionary<Tuple<string, string, short?>, SCL>> Index_QUILT_SUBJECT_CLASS;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_ROOM01;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_ROOM02;
        private Lazy<Dictionary<string, SCL>> Index_SCLKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_TEACHER01;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_TEACHER02;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCL by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SCL by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SCL> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SCL> value;
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
        /// Find SCL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SCL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SCL> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SCL> value;
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
        /// Find SCL by QUILT field
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByQUILT(string QUILT)
        {
            return Index_QUILT.Value[QUILT];
        }

        /// <summary>
        /// Attempt to find SCL by QUILT field
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQUILT(string QUILT, out IReadOnlyList<SCL> Value)
        {
            return Index_QUILT.Value.TryGetValue(QUILT, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by QUILT field
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByQUILT(string QUILT)
        {
            IReadOnlyList<SCL> value;
            if (Index_QUILT.Value.TryGetValue(QUILT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by QUILT, SUBJECT and CLASS fields
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="CLASS">CLASS value used to find SCL</param>
        /// <returns>Related SCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL FindByQUILT_SUBJECT_CLASS(string QUILT, string SUBJECT, short? CLASS)
        {
            return Index_QUILT_SUBJECT_CLASS.Value[Tuple.Create(QUILT, SUBJECT, CLASS)];
        }

        /// <summary>
        /// Attempt to find SCL by QUILT, SUBJECT and CLASS fields
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="CLASS">CLASS value used to find SCL</param>
        /// <param name="Value">Related SCL entity</param>
        /// <returns>True if the related SCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQUILT_SUBJECT_CLASS(string QUILT, string SUBJECT, short? CLASS, out SCL Value)
        {
            return Index_QUILT_SUBJECT_CLASS.Value.TryGetValue(Tuple.Create(QUILT, SUBJECT, CLASS), out Value);
        }

        /// <summary>
        /// Attempt to find SCL by QUILT, SUBJECT and CLASS fields
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="CLASS">CLASS value used to find SCL</param>
        /// <returns>Related SCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL TryFindByQUILT_SUBJECT_CLASS(string QUILT, string SUBJECT, short? CLASS)
        {
            SCL value;
            if (Index_QUILT_SUBJECT_CLASS.Value.TryGetValue(Tuple.Create(QUILT, SUBJECT, CLASS), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by ROOM01 field
        /// </summary>
        /// <param name="ROOM01">ROOM01 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByROOM01(string ROOM01)
        {
            return Index_ROOM01.Value[ROOM01];
        }

        /// <summary>
        /// Attempt to find SCL by ROOM01 field
        /// </summary>
        /// <param name="ROOM01">ROOM01 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM01(string ROOM01, out IReadOnlyList<SCL> Value)
        {
            return Index_ROOM01.Value.TryGetValue(ROOM01, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by ROOM01 field
        /// </summary>
        /// <param name="ROOM01">ROOM01 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByROOM01(string ROOM01)
        {
            IReadOnlyList<SCL> value;
            if (Index_ROOM01.Value.TryGetValue(ROOM01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by ROOM02 field
        /// </summary>
        /// <param name="ROOM02">ROOM02 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByROOM02(string ROOM02)
        {
            return Index_ROOM02.Value[ROOM02];
        }

        /// <summary>
        /// Attempt to find SCL by ROOM02 field
        /// </summary>
        /// <param name="ROOM02">ROOM02 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM02(string ROOM02, out IReadOnlyList<SCL> Value)
        {
            return Index_ROOM02.Value.TryGetValue(ROOM02, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by ROOM02 field
        /// </summary>
        /// <param name="ROOM02">ROOM02 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByROOM02(string ROOM02)
        {
            IReadOnlyList<SCL> value;
            if (Index_ROOM02.Value.TryGetValue(ROOM02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by SCLKEY field
        /// </summary>
        /// <param name="SCLKEY">SCLKEY value used to find SCL</param>
        /// <returns>Related SCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL FindBySCLKEY(string SCLKEY)
        {
            return Index_SCLKEY.Value[SCLKEY];
        }

        /// <summary>
        /// Attempt to find SCL by SCLKEY field
        /// </summary>
        /// <param name="SCLKEY">SCLKEY value used to find SCL</param>
        /// <param name="Value">Related SCL entity</param>
        /// <returns>True if the related SCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCLKEY(string SCLKEY, out SCL Value)
        {
            return Index_SCLKEY.Value.TryGetValue(SCLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by SCLKEY field
        /// </summary>
        /// <param name="SCLKEY">SCLKEY value used to find SCL</param>
        /// <returns>Related SCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL TryFindBySCLKEY(string SCLKEY)
        {
            SCL value;
            if (Index_SCLKEY.Value.TryGetValue(SCLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find SCL by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<SCL> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<SCL> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by TEACHER01 field
        /// </summary>
        /// <param name="TEACHER01">TEACHER01 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByTEACHER01(string TEACHER01)
        {
            return Index_TEACHER01.Value[TEACHER01];
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER01 field
        /// </summary>
        /// <param name="TEACHER01">TEACHER01 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER01(string TEACHER01, out IReadOnlyList<SCL> Value)
        {
            return Index_TEACHER01.Value.TryGetValue(TEACHER01, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER01 field
        /// </summary>
        /// <param name="TEACHER01">TEACHER01 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByTEACHER01(string TEACHER01)
        {
            IReadOnlyList<SCL> value;
            if (Index_TEACHER01.Value.TryGetValue(TEACHER01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by TEACHER02 field
        /// </summary>
        /// <param name="TEACHER02">TEACHER02 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByTEACHER02(string TEACHER02)
        {
            return Index_TEACHER02.Value[TEACHER02];
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER02 field
        /// </summary>
        /// <param name="TEACHER02">TEACHER02 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER02(string TEACHER02, out IReadOnlyList<SCL> Value)
        {
            return Index_TEACHER02.Value.TryGetValue(TEACHER02, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER02 field
        /// </summary>
        /// <param name="TEACHER02">TEACHER02 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByTEACHER02(string TEACHER02)
        {
            IReadOnlyList<SCL> value;
            if (Index_TEACHER02.Value.TryGetValue(TEACHER02, out value))
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
        /// Returns SQL which checks for the existence of a SCL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCL](
        [SCLKEY] varchar(17) NOT NULL,
        [QUILT] varchar(8) NULL,
        [SUBJECT] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TEACHER01] varchar(4) NULL,
        [TEACHER02] varchar(4) NULL,
        [ROOM01] varchar(4) NULL,
        [ROOM02] varchar(4) NULL,
        [FREQUENCY] smallint NULL,
        [PRINT_FLAGS01] varchar(1) NULL,
        [PRINT_FLAGS02] varchar(1) NULL,
        [PRINT_FLAGS03] varchar(1) NULL,
        [PERIOD_ABSENCES] varchar(1) NULL,
        [CAMPUS] int NULL,
        [ALIAS] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCL_Index_SCLKEY] PRIMARY KEY CLUSTERED (
            [SCLKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_CAMPUS] ON [dbo].[SCL]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_LW_DATE] ON [dbo].[SCL]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_QUILT] ON [dbo].[SCL]
    (
            [QUILT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_QUILT_SUBJECT_CLASS] ON [dbo].[SCL]
    (
            [QUILT] ASC,
            [SUBJECT] ASC,
            [CLASS] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_ROOM01] ON [dbo].[SCL]
    (
            [ROOM01] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_ROOM02] ON [dbo].[SCL]
    (
            [ROOM02] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_SUBJECT] ON [dbo].[SCL]
    (
            [SUBJECT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_TEACHER01] ON [dbo].[SCL]
    (
            [TEACHER01] ASC
    );
    CREATE NONCLUSTERED INDEX [SCL_Index_TEACHER02] ON [dbo].[SCL]
    (
            [TEACHER02] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCLDataReader : IDataReader, IDataRecord
        {
            private List<SCL> Items;
            private int CurrentIndex;
            private SCL CurrentItem;

            public SCLDataReader(List<SCL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 18; } }
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
                    case 0: // SCLKEY
                        return CurrentItem.SCLKEY;
                    case 1: // QUILT
                        return CurrentItem.QUILT;
                    case 2: // SUBJECT
                        return CurrentItem.SUBJECT;
                    case 3: // CLASS
                        return CurrentItem.CLASS;
                    case 4: // TEACHER01
                        return CurrentItem.TEACHER01;
                    case 5: // TEACHER02
                        return CurrentItem.TEACHER02;
                    case 6: // ROOM01
                        return CurrentItem.ROOM01;
                    case 7: // ROOM02
                        return CurrentItem.ROOM02;
                    case 8: // FREQUENCY
                        return CurrentItem.FREQUENCY;
                    case 9: // PRINT_FLAGS01
                        return CurrentItem.PRINT_FLAGS01;
                    case 10: // PRINT_FLAGS02
                        return CurrentItem.PRINT_FLAGS02;
                    case 11: // PRINT_FLAGS03
                        return CurrentItem.PRINT_FLAGS03;
                    case 12: // PERIOD_ABSENCES
                        return CurrentItem.PERIOD_ABSENCES;
                    case 13: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 14: // ALIAS
                        return CurrentItem.ALIAS;
                    case 15: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 16: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 17: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // QUILT
                        return CurrentItem.QUILT == null;
                    case 2: // SUBJECT
                        return CurrentItem.SUBJECT == null;
                    case 3: // CLASS
                        return CurrentItem.CLASS == null;
                    case 4: // TEACHER01
                        return CurrentItem.TEACHER01 == null;
                    case 5: // TEACHER02
                        return CurrentItem.TEACHER02 == null;
                    case 6: // ROOM01
                        return CurrentItem.ROOM01 == null;
                    case 7: // ROOM02
                        return CurrentItem.ROOM02 == null;
                    case 8: // FREQUENCY
                        return CurrentItem.FREQUENCY == null;
                    case 9: // PRINT_FLAGS01
                        return CurrentItem.PRINT_FLAGS01 == null;
                    case 10: // PRINT_FLAGS02
                        return CurrentItem.PRINT_FLAGS02 == null;
                    case 11: // PRINT_FLAGS03
                        return CurrentItem.PRINT_FLAGS03 == null;
                    case 12: // PERIOD_ABSENCES
                        return CurrentItem.PERIOD_ABSENCES == null;
                    case 13: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 14: // ALIAS
                        return CurrentItem.ALIAS == null;
                    case 15: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 16: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 17: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCLKEY
                        return "SCLKEY";
                    case 1: // QUILT
                        return "QUILT";
                    case 2: // SUBJECT
                        return "SUBJECT";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // TEACHER01
                        return "TEACHER01";
                    case 5: // TEACHER02
                        return "TEACHER02";
                    case 6: // ROOM01
                        return "ROOM01";
                    case 7: // ROOM02
                        return "ROOM02";
                    case 8: // FREQUENCY
                        return "FREQUENCY";
                    case 9: // PRINT_FLAGS01
                        return "PRINT_FLAGS01";
                    case 10: // PRINT_FLAGS02
                        return "PRINT_FLAGS02";
                    case 11: // PRINT_FLAGS03
                        return "PRINT_FLAGS03";
                    case 12: // PERIOD_ABSENCES
                        return "PERIOD_ABSENCES";
                    case 13: // CAMPUS
                        return "CAMPUS";
                    case 14: // ALIAS
                        return "ALIAS";
                    case 15: // LW_DATE
                        return "LW_DATE";
                    case 16: // LW_TIME
                        return "LW_TIME";
                    case 17: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCLKEY":
                        return 0;
                    case "QUILT":
                        return 1;
                    case "SUBJECT":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "TEACHER01":
                        return 4;
                    case "TEACHER02":
                        return 5;
                    case "ROOM01":
                        return 6;
                    case "ROOM02":
                        return 7;
                    case "FREQUENCY":
                        return 8;
                    case "PRINT_FLAGS01":
                        return 9;
                    case "PRINT_FLAGS02":
                        return 10;
                    case "PRINT_FLAGS03":
                        return 11;
                    case "PERIOD_ABSENCES":
                        return 12;
                    case "CAMPUS":
                        return 13;
                    case "ALIAS":
                        return 14;
                    case "LW_DATE":
                        return 15;
                    case "LW_TIME":
                        return 16;
                    case "LW_USER":
                        return 17;
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
