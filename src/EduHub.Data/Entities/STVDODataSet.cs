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
    /// VELS Domain Results Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDODataSet : EduHubDataSet<STVDO>
    {
        /// <inheritdoc />
        public override string Name { get { return "STVDO"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STVDODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_ORIGINAL_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STVDO>>>(() => this.ToGroupedNullDictionary(i => i.ORIGINAL_SCHOOL));
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
        internal override Action<STVDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
        /// Merges <see cref="STVDO" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STVDO" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STVDO" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STVDO}"/> of entities</returns>
        internal override IEnumerable<STVDO> ApplyDeltaEntities(IEnumerable<STVDO> Entities, List<STVDO> DeltaEntities)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<STVDO>>> Index_CAMPUS;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STVDO>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<STVDO>>> Index_ORIGINAL_SCHOOL;
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
        /// Find STVDO by ORIGINAL_SCHOOL field
        /// </summary>
        /// <param name="ORIGINAL_SCHOOL">ORIGINAL_SCHOOL value used to find STVDO</param>
        /// <returns>List of related STVDO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> FindByORIGINAL_SCHOOL(string ORIGINAL_SCHOOL)
        {
            return Index_ORIGINAL_SCHOOL.Value[ORIGINAL_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STVDO by ORIGINAL_SCHOOL field
        /// </summary>
        /// <param name="ORIGINAL_SCHOOL">ORIGINAL_SCHOOL value used to find STVDO</param>
        /// <param name="Value">List of related STVDO entities</param>
        /// <returns>True if the list of related STVDO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIGINAL_SCHOOL(string ORIGINAL_SCHOOL, out IReadOnlyList<STVDO> Value)
        {
            return Index_ORIGINAL_SCHOOL.Value.TryGetValue(ORIGINAL_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO by ORIGINAL_SCHOOL field
        /// </summary>
        /// <param name="ORIGINAL_SCHOOL">ORIGINAL_SCHOOL value used to find STVDO</param>
        /// <returns>List of related STVDO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO> TryFindByORIGINAL_SCHOOL(string ORIGINAL_SCHOOL)
        {
            IReadOnlyList<STVDO> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STVDO table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STVDO](
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
    CREATE NONCLUSTERED INDEX [STVDO_Index_ORIGINAL_SCHOOL] ON [dbo].[STVDO]
    (
            [ORIGINAL_SCHOOL] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[STVDO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[STVDO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_ORIGINAL_SCHOOL')
    ALTER INDEX [Index_ORIGINAL_SCHOOL] ON [dbo].[STVDO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STVDO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_VDIMENSION')
    ALTER INDEX [Index_VDIMENSION] ON [dbo].[STVDO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_VDOMAIN')
    ALTER INDEX [Index_VDOMAIN] ON [dbo].[STVDO] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[STVDO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[STVDO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_ORIGINAL_SCHOOL')
    ALTER INDEX [Index_ORIGINAL_SCHOOL] ON [dbo].[STVDO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STVDO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_VDIMENSION')
    ALTER INDEX [Index_VDIMENSION] ON [dbo].[STVDO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO]') AND name = N'Index_VDOMAIN')
    ALTER INDEX [Index_VDOMAIN] ON [dbo].[STVDO] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STVDO"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STVDO"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STVDO> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STVDO] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STVDO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDO data set</returns>
        public override EduHubDataSetDataReader<STVDO> GetDataSetDataReader()
        {
            return new STVDODataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STVDO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDO data set</returns>
        public override EduHubDataSetDataReader<STVDO> GetDataSetDataReader(List<STVDO> Entities)
        {
            return new STVDODataReader(new EduHubDataSetLoadedReader<STVDO>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STVDODataReader : EduHubDataSetDataReader<STVDO>
        {
            public STVDODataReader(IEduHubDataSetReader<STVDO> Reader)
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
