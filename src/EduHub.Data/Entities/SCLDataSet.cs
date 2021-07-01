using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCLDataSet : EduHubDataSet<SCL>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<SCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// <param name="Entities">Iterator for base <see cref="SCL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCL}"/> of entities</returns>
        internal override IEnumerable<SCL> ApplyDeltaEntities(IEnumerable<SCL> Entities, List<SCL> DeltaEntities)
        {
            HashSet<Tuple<string, string, short?>> Index_QUILT_SUBJECT_CLASS = new HashSet<Tuple<string, string, short?>>(DeltaEntities.Select(i => Tuple.Create(i.QUILT, i.SUBJECT, i.CLASS)));
            HashSet<string> Index_SCLKEY = new HashSet<string>(DeltaEntities.Select(i => i.SCLKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCLKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_QUILT_SUBJECT_CLASS.Remove(Tuple.Create(entity.QUILT, entity.SUBJECT, entity.CLASS));
                            overwritten = overwritten || Index_SCLKEY.Remove(entity.SCLKEY);
                            
                            if (entity.SCLKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
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
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_QUILT')
    ALTER INDEX [Index_QUILT] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_QUILT_SUBJECT_CLASS')
    ALTER INDEX [Index_QUILT_SUBJECT_CLASS] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_ROOM01')
    ALTER INDEX [Index_ROOM01] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_ROOM02')
    ALTER INDEX [Index_ROOM02] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_SUBJECT')
    ALTER INDEX [Index_SUBJECT] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_TEACHER01')
    ALTER INDEX [Index_TEACHER01] ON [dbo].[SCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_TEACHER02')
    ALTER INDEX [Index_TEACHER02] ON [dbo].[SCL] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_QUILT')
    ALTER INDEX [Index_QUILT] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_QUILT_SUBJECT_CLASS')
    ALTER INDEX [Index_QUILT_SUBJECT_CLASS] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_ROOM01')
    ALTER INDEX [Index_ROOM01] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_ROOM02')
    ALTER INDEX [Index_ROOM02] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_SUBJECT')
    ALTER INDEX [Index_SUBJECT] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_TEACHER01')
    ALTER INDEX [Index_TEACHER01] ON [dbo].[SCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCL]') AND name = N'Index_TEACHER02')
    ALTER INDEX [Index_TEACHER02] ON [dbo].[SCL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string, short?>> Index_QUILT_SUBJECT_CLASS = new List<Tuple<string, string, short?>>();
            List<string> Index_SCLKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_QUILT_SUBJECT_CLASS.Add(Tuple.Create(entity.QUILT, entity.SUBJECT, entity.CLASS));
                Index_SCLKEY.Add(entity.SCLKEY);
            }

            builder.AppendLine("DELETE [dbo].[SCL] WHERE");


            // Index_QUILT_SUBJECT_CLASS
            builder.Append("(");
            for (int index = 0; index < Index_QUILT_SUBJECT_CLASS.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // QUILT
                if (Index_QUILT_SUBJECT_CLASS[index].Item1 == null)
                {
                    builder.Append("([QUILT] IS NULL");
                }
                else
                {
                    var parameterQUILT = $"@p{parameterIndex++}";
                    builder.Append("([QUILT]=").Append(parameterQUILT);
                    command.Parameters.Add(parameterQUILT, SqlDbType.VarChar, 8).Value = Index_QUILT_SUBJECT_CLASS[index].Item1;
                }

                // SUBJECT
                if (Index_QUILT_SUBJECT_CLASS[index].Item2 == null)
                {
                    builder.Append(" AND [SUBJECT] IS NULL");
                }
                else
                {
                    var parameterSUBJECT = $"@p{parameterIndex++}";
                    builder.Append(" AND [SUBJECT]=").Append(parameterSUBJECT);
                    command.Parameters.Add(parameterSUBJECT, SqlDbType.VarChar, 5).Value = Index_QUILT_SUBJECT_CLASS[index].Item2;
                }

                // CLASS
                if (Index_QUILT_SUBJECT_CLASS[index].Item3 == null)
                {
                    builder.Append(" AND [CLASS] IS NULL)");
                }
                else
                {
                    var parameterCLASS = $"@p{parameterIndex++}";
                    builder.Append(" AND [CLASS]=").Append(parameterCLASS).Append(")");
                    command.Parameters.Add(parameterCLASS, SqlDbType.SmallInt).Value = Index_QUILT_SUBJECT_CLASS[index].Item3;
                }
            }
            builder.AppendLine(") OR");

            // Index_SCLKEY
            builder.Append("[SCLKEY] IN (");
            for (int index = 0; index < Index_SCLKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCLKEY
                var parameterSCLKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSCLKEY);
                command.Parameters.Add(parameterSCLKEY, SqlDbType.VarChar, 17).Value = Index_SCLKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCL data set</returns>
        public override EduHubDataSetDataReader<SCL> GetDataSetDataReader()
        {
            return new SCLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCL data set</returns>
        public override EduHubDataSetDataReader<SCL> GetDataSetDataReader(List<SCL> Entities)
        {
            return new SCLDataReader(new EduHubDataSetLoadedReader<SCL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCLDataReader : EduHubDataSetDataReader<SCL>
        {
            public SCLDataReader(IEduHubDataSetReader<SCL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 18; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCLKEY
                        return Current.SCLKEY;
                    case 1: // QUILT
                        return Current.QUILT;
                    case 2: // SUBJECT
                        return Current.SUBJECT;
                    case 3: // CLASS
                        return Current.CLASS;
                    case 4: // TEACHER01
                        return Current.TEACHER01;
                    case 5: // TEACHER02
                        return Current.TEACHER02;
                    case 6: // ROOM01
                        return Current.ROOM01;
                    case 7: // ROOM02
                        return Current.ROOM02;
                    case 8: // FREQUENCY
                        return Current.FREQUENCY;
                    case 9: // PRINT_FLAGS01
                        return Current.PRINT_FLAGS01;
                    case 10: // PRINT_FLAGS02
                        return Current.PRINT_FLAGS02;
                    case 11: // PRINT_FLAGS03
                        return Current.PRINT_FLAGS03;
                    case 12: // PERIOD_ABSENCES
                        return Current.PERIOD_ABSENCES;
                    case 13: // CAMPUS
                        return Current.CAMPUS;
                    case 14: // ALIAS
                        return Current.ALIAS;
                    case 15: // LW_DATE
                        return Current.LW_DATE;
                    case 16: // LW_TIME
                        return Current.LW_TIME;
                    case 17: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // QUILT
                        return Current.QUILT == null;
                    case 2: // SUBJECT
                        return Current.SUBJECT == null;
                    case 3: // CLASS
                        return Current.CLASS == null;
                    case 4: // TEACHER01
                        return Current.TEACHER01 == null;
                    case 5: // TEACHER02
                        return Current.TEACHER02 == null;
                    case 6: // ROOM01
                        return Current.ROOM01 == null;
                    case 7: // ROOM02
                        return Current.ROOM02 == null;
                    case 8: // FREQUENCY
                        return Current.FREQUENCY == null;
                    case 9: // PRINT_FLAGS01
                        return Current.PRINT_FLAGS01 == null;
                    case 10: // PRINT_FLAGS02
                        return Current.PRINT_FLAGS02 == null;
                    case 11: // PRINT_FLAGS03
                        return Current.PRINT_FLAGS03 == null;
                    case 12: // PERIOD_ABSENCES
                        return Current.PERIOD_ABSENCES == null;
                    case 13: // CAMPUS
                        return Current.CAMPUS == null;
                    case 14: // ALIAS
                        return Current.ALIAS == null;
                    case 15: // LW_DATE
                        return Current.LW_DATE == null;
                    case 16: // LW_TIME
                        return Current.LW_TIME == null;
                    case 17: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
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

            public override int GetOrdinal(string name)
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
        }

        #endregion

    }
}
