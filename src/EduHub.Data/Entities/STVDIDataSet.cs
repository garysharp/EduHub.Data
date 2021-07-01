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
    /// VELS Dimension Results Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDIDataSet : EduHubDataSet<STVDI>
    {
        /// <inheritdoc />
        public override string Name { get { return "STVDI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STVDIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STVDI>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDI>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_ORIGINAL_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STVDI>>>(() => this.ToGroupedNullDictionary(i => i.ORIGINAL_SCHOOL));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STVDI>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE = new Lazy<Dictionary<Tuple<string, string, string, string, string>, IReadOnlyList<STVDI>>>(() => this.ToGroupedDictionary(i => Tuple.Create(i.SKEY, i.VDIMENSION, i.VDOMAIN, i.YEAR_SEMESTER, i.SCORE)));
            Index_TID = new Lazy<Dictionary<int, STVDI>>(() => this.ToDictionary(i => i.TID));
            Index_VDIMENSION = new Lazy<NullDictionary<string, IReadOnlyList<STVDI>>>(() => this.ToGroupedNullDictionary(i => i.VDIMENSION));
            Index_VDOMAIN = new Lazy<NullDictionary<string, IReadOnlyList<STVDI>>>(() => this.ToGroupedNullDictionary(i => i.VDOMAIN));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STVDI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STVDI" /> fields for each CSV column header</returns>
        internal override Action<STVDI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STVDI, string>[Headers.Count];

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
                    case "ORIGINAL_SCHOOL":
                        mapper[i] = (e, v) => e.ORIGINAL_SCHOOL = v;
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
        /// Merges <see cref="STVDI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STVDI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STVDI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STVDI}"/> of entities</returns>
        internal override IEnumerable<STVDI> ApplyDeltaEntities(IEnumerable<STVDI> Entities, List<STVDI> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<STVDI>>> Index_CAMPUS;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDI>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDI>>> Index_ORIGINAL_SCHOOL;
        private Lazy<Dictionary<string, IReadOnlyList<STVDI>>> Index_SKEY;
        private Lazy<Dictionary<Tuple<string, string, string, string, string>, IReadOnlyList<STVDI>>> Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE;
        private Lazy<Dictionary<int, STVDI>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDI>>> Index_VDIMENSION;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDI>>> Index_VDOMAIN;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STVDI by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find STVDI by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<STVDI> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<STVDI> value;
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
        /// Find STVDI by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find STVDI by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<STVDI> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<STVDI> value;
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
        /// Find STVDI by ORIGINAL_SCHOOL field
        /// </summary>
        /// <param name="ORIGINAL_SCHOOL">ORIGINAL_SCHOOL value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindByORIGINAL_SCHOOL(string ORIGINAL_SCHOOL)
        {
            return Index_ORIGINAL_SCHOOL.Value[ORIGINAL_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STVDI by ORIGINAL_SCHOOL field
        /// </summary>
        /// <param name="ORIGINAL_SCHOOL">ORIGINAL_SCHOOL value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIGINAL_SCHOOL(string ORIGINAL_SCHOOL, out IReadOnlyList<STVDI> Value)
        {
            return Index_ORIGINAL_SCHOOL.Value.TryGetValue(ORIGINAL_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by ORIGINAL_SCHOOL field
        /// </summary>
        /// <param name="ORIGINAL_SCHOOL">ORIGINAL_SCHOOL value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindByORIGINAL_SCHOOL(string ORIGINAL_SCHOOL)
        {
            IReadOnlyList<STVDI> value;
            if (Index_ORIGINAL_SCHOOL.Value.TryGetValue(ORIGINAL_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDI by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STVDI by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STVDI> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STVDI> value;
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
        /// Find STVDI by SKEY, VDIMENSION, VDOMAIN, YEAR_SEMESTER and SCORE fields
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDI</param>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDI</param>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDI</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find STVDI</param>
        /// <param name="SCORE">SCORE value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindBySKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE(string SKEY, string VDIMENSION, string VDOMAIN, string YEAR_SEMESTER, string SCORE)
        {
            return Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE.Value[Tuple.Create(SKEY, VDIMENSION, VDOMAIN, YEAR_SEMESTER, SCORE)];
        }

        /// <summary>
        /// Attempt to find STVDI by SKEY, VDIMENSION, VDOMAIN, YEAR_SEMESTER and SCORE fields
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDI</param>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDI</param>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDI</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find STVDI</param>
        /// <param name="SCORE">SCORE value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE(string SKEY, string VDIMENSION, string VDOMAIN, string YEAR_SEMESTER, string SCORE, out IReadOnlyList<STVDI> Value)
        {
            return Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE.Value.TryGetValue(Tuple.Create(SKEY, VDIMENSION, VDOMAIN, YEAR_SEMESTER, SCORE), out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by SKEY, VDIMENSION, VDOMAIN, YEAR_SEMESTER and SCORE fields
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STVDI</param>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDI</param>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDI</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find STVDI</param>
        /// <param name="SCORE">SCORE value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindBySKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE(string SKEY, string VDIMENSION, string VDOMAIN, string YEAR_SEMESTER, string SCORE)
        {
            IReadOnlyList<STVDI> value;
            if (Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE.Value.TryGetValue(Tuple.Create(SKEY, VDIMENSION, VDOMAIN, YEAR_SEMESTER, SCORE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDI</param>
        /// <returns>Related STVDI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STVDI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDI</param>
        /// <param name="Value">Related STVDI entity</param>
        /// <returns>True if the related STVDI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STVDI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDI</param>
        /// <returns>Related STVDI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDI TryFindByTID(int TID)
        {
            STVDI value;
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
        /// Find STVDI by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindByVDIMENSION(string VDIMENSION)
        {
            return Index_VDIMENSION.Value[VDIMENSION];
        }

        /// <summary>
        /// Attempt to find STVDI by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDIMENSION(string VDIMENSION, out IReadOnlyList<STVDI> Value)
        {
            return Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindByVDIMENSION(string VDIMENSION)
        {
            IReadOnlyList<STVDI> value;
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
        /// Find STVDI by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDI</param>
        /// <returns>List of related STVDI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> FindByVDOMAIN(string VDOMAIN)
        {
            return Index_VDOMAIN.Value[VDOMAIN];
        }

        /// <summary>
        /// Attempt to find STVDI by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDI</param>
        /// <param name="Value">List of related STVDI entities</param>
        /// <returns>True if the list of related STVDI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDOMAIN(string VDOMAIN, out IReadOnlyList<STVDI> Value)
        {
            return Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find STVDI</param>
        /// <returns>List of related STVDI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI> TryFindByVDOMAIN(string VDOMAIN)
        {
            IReadOnlyList<STVDI> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STVDI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STVDI](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [CAMPUS] int NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [VDOMAIN] varchar(10) NULL,
        [VDIMENSION] varchar(10) NULL,
        [SCORE] varchar(6) NULL,
        [ORIGINAL_SCHOOL] varchar(8) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STVDI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STVDI_Index_CAMPUS] ON [dbo].[STVDI]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDI_Index_LW_DATE] ON [dbo].[STVDI]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDI_Index_ORIGINAL_SCHOOL] ON [dbo].[STVDI]
    (
            [ORIGINAL_SCHOOL] ASC
    );
    CREATE CLUSTERED INDEX [STVDI_Index_SKEY] ON [dbo].[STVDI]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDI_Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE] ON [dbo].[STVDI]
    (
            [SKEY] ASC,
            [VDIMENSION] ASC,
            [VDOMAIN] ASC,
            [YEAR_SEMESTER] ASC,
            [SCORE] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDI_Index_VDIMENSION] ON [dbo].[STVDI]
    (
            [VDIMENSION] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDI_Index_VDOMAIN] ON [dbo].[STVDI]
    (
            [VDOMAIN] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_CAMPUS')
    ALTER INDEX [STVDI_Index_CAMPUS] ON [dbo].[STVDI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_LW_DATE')
    ALTER INDEX [STVDI_Index_LW_DATE] ON [dbo].[STVDI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_ORIGINAL_SCHOOL')
    ALTER INDEX [STVDI_Index_ORIGINAL_SCHOOL] ON [dbo].[STVDI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE')
    ALTER INDEX [STVDI_Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE] ON [dbo].[STVDI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_TID')
    ALTER INDEX [STVDI_Index_TID] ON [dbo].[STVDI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_VDIMENSION')
    ALTER INDEX [STVDI_Index_VDIMENSION] ON [dbo].[STVDI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_VDOMAIN')
    ALTER INDEX [STVDI_Index_VDOMAIN] ON [dbo].[STVDI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_CAMPUS')
    ALTER INDEX [STVDI_Index_CAMPUS] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_LW_DATE')
    ALTER INDEX [STVDI_Index_LW_DATE] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_ORIGINAL_SCHOOL')
    ALTER INDEX [STVDI_Index_ORIGINAL_SCHOOL] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE')
    ALTER INDEX [STVDI_Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_TID')
    ALTER INDEX [STVDI_Index_TID] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_VDIMENSION')
    ALTER INDEX [STVDI_Index_VDIMENSION] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI]') AND name = N'STVDI_Index_VDOMAIN')
    ALTER INDEX [STVDI_Index_VDOMAIN] ON [dbo].[STVDI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STVDI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STVDI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STVDI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STVDI] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STVDI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDI data set</returns>
        public override EduHubDataSetDataReader<STVDI> GetDataSetDataReader()
        {
            return new STVDIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STVDI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDI data set</returns>
        public override EduHubDataSetDataReader<STVDI> GetDataSetDataReader(List<STVDI> Entities)
        {
            return new STVDIDataReader(new EduHubDataSetLoadedReader<STVDI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STVDIDataReader : EduHubDataSetDataReader<STVDI>
        {
            public STVDIDataReader(IEduHubDataSetReader<STVDI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 12; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 3: // CAMPUS
                        return Current.CAMPUS;
                    case 4: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER;
                    case 5: // VDOMAIN
                        return Current.VDOMAIN;
                    case 6: // VDIMENSION
                        return Current.VDIMENSION;
                    case 7: // SCORE
                        return Current.SCORE;
                    case 8: // ORIGINAL_SCHOOL
                        return Current.ORIGINAL_SCHOOL;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_TIME
                        return Current.LW_TIME;
                    case 11: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 3: // CAMPUS
                        return Current.CAMPUS == null;
                    case 4: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER == null;
                    case 5: // VDOMAIN
                        return Current.VDOMAIN == null;
                    case 6: // VDIMENSION
                        return Current.VDIMENSION == null;
                    case 7: // SCORE
                        return Current.SCORE == null;
                    case 8: // ORIGINAL_SCHOOL
                        return Current.ORIGINAL_SCHOOL == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_TIME
                        return Current.LW_TIME == null;
                    case 11: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
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
                    case 8: // ORIGINAL_SCHOOL
                        return "ORIGINAL_SCHOOL";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
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
                    case "ORIGINAL_SCHOOL":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
