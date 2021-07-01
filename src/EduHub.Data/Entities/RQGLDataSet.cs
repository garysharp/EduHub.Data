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
    /// Purchasing Group GL Codes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQGLDataSet : EduHubDataSet<RQGL>
    {
        /// <inheritdoc />
        public override string Name { get { return "RQGL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal RQGLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<RQGL>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GLCODE_SUBPROGRAM_INITIATIVE = new Lazy<Dictionary<Tuple<string, string, string>, RQGL>>(() => this.ToDictionary(i => Tuple.Create(i.GLCODE, i.SUBPROGRAM, i.INITIATIVE)));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<RQGL>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_RQPGKEY = new Lazy<Dictionary<string, IReadOnlyList<RQGL>>>(() => this.ToGroupedDictionary(i => i.RQPGKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<RQGL>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, RQGL>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="RQGL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="RQGL" /> fields for each CSV column header</returns>
        internal override Action<RQGL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<RQGL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "RQPGKEY":
                        mapper[i] = (e, v) => e.RQPGKEY = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "PR_LIMIT":
                        mapper[i] = (e, v) => e.PR_LIMIT = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="RQGL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="RQGL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="RQGL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{RQGL}"/> of entities</returns>
        internal override IEnumerable<RQGL> ApplyDeltaEntities(IEnumerable<RQGL> Entities, List<RQGL> DeltaEntities)
        {
            HashSet<Tuple<string, string, string>> Index_GLCODE_SUBPROGRAM_INITIATIVE = new HashSet<Tuple<string, string, string>>(DeltaEntities.Select(i => Tuple.Create(i.GLCODE, i.SUBPROGRAM, i.INITIATIVE)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.RQPGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_GLCODE_SUBPROGRAM_INITIATIVE.Remove(Tuple.Create(entity.GLCODE, entity.SUBPROGRAM, entity.INITIATIVE));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.RQPGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<RQGL>>> Index_GLCODE;
        private Lazy<Dictionary<Tuple<string, string, string>, RQGL>> Index_GLCODE_SUBPROGRAM_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<RQGL>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, IReadOnlyList<RQGL>>> Index_RQPGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<RQGL>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, RQGL>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find RQGL by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find RQGL</param>
        /// <returns>List of related RQGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find RQGL by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find RQGL</param>
        /// <param name="Value">List of related RQGL entities</param>
        /// <returns>True if the list of related RQGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<RQGL> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find RQGL by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find RQGL</param>
        /// <returns>List of related RQGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<RQGL> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQGL by GLCODE, SUBPROGRAM and INITIATIVE fields
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find RQGL</param>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQGL</param>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQGL</param>
        /// <returns>Related RQGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQGL FindByGLCODE_SUBPROGRAM_INITIATIVE(string GLCODE, string SUBPROGRAM, string INITIATIVE)
        {
            return Index_GLCODE_SUBPROGRAM_INITIATIVE.Value[Tuple.Create(GLCODE, SUBPROGRAM, INITIATIVE)];
        }

        /// <summary>
        /// Attempt to find RQGL by GLCODE, SUBPROGRAM and INITIATIVE fields
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find RQGL</param>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQGL</param>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQGL</param>
        /// <param name="Value">Related RQGL entity</param>
        /// <returns>True if the related RQGL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE_SUBPROGRAM_INITIATIVE(string GLCODE, string SUBPROGRAM, string INITIATIVE, out RQGL Value)
        {
            return Index_GLCODE_SUBPROGRAM_INITIATIVE.Value.TryGetValue(Tuple.Create(GLCODE, SUBPROGRAM, INITIATIVE), out Value);
        }

        /// <summary>
        /// Attempt to find RQGL by GLCODE, SUBPROGRAM and INITIATIVE fields
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find RQGL</param>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQGL</param>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQGL</param>
        /// <returns>Related RQGL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQGL TryFindByGLCODE_SUBPROGRAM_INITIATIVE(string GLCODE, string SUBPROGRAM, string INITIATIVE)
        {
            RQGL value;
            if (Index_GLCODE_SUBPROGRAM_INITIATIVE.Value.TryGetValue(Tuple.Create(GLCODE, SUBPROGRAM, INITIATIVE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQGL by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQGL</param>
        /// <returns>List of related RQGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find RQGL by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQGL</param>
        /// <param name="Value">List of related RQGL entities</param>
        /// <returns>True if the list of related RQGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<RQGL> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find RQGL by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQGL</param>
        /// <returns>List of related RQGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<RQGL> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQGL by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQGL</param>
        /// <returns>List of related RQGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> FindByRQPGKEY(string RQPGKEY)
        {
            return Index_RQPGKEY.Value[RQPGKEY];
        }

        /// <summary>
        /// Attempt to find RQGL by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQGL</param>
        /// <param name="Value">List of related RQGL entities</param>
        /// <returns>True if the list of related RQGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRQPGKEY(string RQPGKEY, out IReadOnlyList<RQGL> Value)
        {
            return Index_RQPGKEY.Value.TryGetValue(RQPGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find RQGL by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQGL</param>
        /// <returns>List of related RQGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> TryFindByRQPGKEY(string RQPGKEY)
        {
            IReadOnlyList<RQGL> value;
            if (Index_RQPGKEY.Value.TryGetValue(RQPGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQGL by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQGL</param>
        /// <returns>List of related RQGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find RQGL by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQGL</param>
        /// <param name="Value">List of related RQGL entities</param>
        /// <returns>True if the list of related RQGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<RQGL> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find RQGL by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQGL</param>
        /// <returns>List of related RQGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQGL> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<RQGL> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQGL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQGL</param>
        /// <returns>Related RQGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQGL FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find RQGL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQGL</param>
        /// <param name="Value">Related RQGL entity</param>
        /// <returns>True if the related RQGL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out RQGL Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find RQGL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQGL</param>
        /// <returns>Related RQGL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQGL TryFindByTID(int TID)
        {
            RQGL value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a RQGL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[RQGL](
        [TID] int IDENTITY NOT NULL,
        [RQPGKEY] varchar(10) NOT NULL,
        [GLCODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [INITIATIVE] varchar(3) NULL,
        [PR_LIMIT] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [RQGL_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [RQGL_Index_GLCODE] ON [dbo].[RQGL]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [RQGL_Index_GLCODE_SUBPROGRAM_INITIATIVE] ON [dbo].[RQGL]
    (
            [GLCODE] ASC,
            [SUBPROGRAM] ASC,
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [RQGL_Index_INITIATIVE] ON [dbo].[RQGL]
    (
            [INITIATIVE] ASC
    );
    CREATE CLUSTERED INDEX [RQGL_Index_RQPGKEY] ON [dbo].[RQGL]
    (
            [RQPGKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [RQGL_Index_SUBPROGRAM] ON [dbo].[RQGL]
    (
            [SUBPROGRAM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[RQGL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_GLCODE_SUBPROGRAM_INITIATIVE')
    ALTER INDEX [Index_GLCODE_SUBPROGRAM_INITIATIVE] ON [dbo].[RQGL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[RQGL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[RQGL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[RQGL] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[RQGL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_GLCODE_SUBPROGRAM_INITIATIVE')
    ALTER INDEX [Index_GLCODE_SUBPROGRAM_INITIATIVE] ON [dbo].[RQGL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[RQGL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[RQGL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQGL]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[RQGL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="RQGL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="RQGL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<RQGL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string, string>> Index_GLCODE_SUBPROGRAM_INITIATIVE = new List<Tuple<string, string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_GLCODE_SUBPROGRAM_INITIATIVE.Add(Tuple.Create(entity.GLCODE, entity.SUBPROGRAM, entity.INITIATIVE));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[RQGL] WHERE");


            // Index_GLCODE_SUBPROGRAM_INITIATIVE
            builder.Append("(");
            for (int index = 0; index < Index_GLCODE_SUBPROGRAM_INITIATIVE.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // GLCODE
                if (Index_GLCODE_SUBPROGRAM_INITIATIVE[index].Item1 == null)
                {
                    builder.Append("([GLCODE] IS NULL");
                }
                else
                {
                    var parameterGLCODE = $"@p{parameterIndex++}";
                    builder.Append("([GLCODE]=").Append(parameterGLCODE);
                    command.Parameters.Add(parameterGLCODE, SqlDbType.VarChar, 10).Value = Index_GLCODE_SUBPROGRAM_INITIATIVE[index].Item1;
                }

                // SUBPROGRAM
                if (Index_GLCODE_SUBPROGRAM_INITIATIVE[index].Item2 == null)
                {
                    builder.Append(" AND [SUBPROGRAM] IS NULL");
                }
                else
                {
                    var parameterSUBPROGRAM = $"@p{parameterIndex++}";
                    builder.Append(" AND [SUBPROGRAM]=").Append(parameterSUBPROGRAM);
                    command.Parameters.Add(parameterSUBPROGRAM, SqlDbType.VarChar, 4).Value = Index_GLCODE_SUBPROGRAM_INITIATIVE[index].Item2;
                }

                // INITIATIVE
                if (Index_GLCODE_SUBPROGRAM_INITIATIVE[index].Item3 == null)
                {
                    builder.Append(" AND [INITIATIVE] IS NULL)");
                }
                else
                {
                    var parameterINITIATIVE = $"@p{parameterIndex++}";
                    builder.Append(" AND [INITIATIVE]=").Append(parameterINITIATIVE).Append(")");
                    command.Parameters.Add(parameterINITIATIVE, SqlDbType.VarChar, 3).Value = Index_GLCODE_SUBPROGRAM_INITIATIVE[index].Item3;
                }
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the RQGL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQGL data set</returns>
        public override EduHubDataSetDataReader<RQGL> GetDataSetDataReader()
        {
            return new RQGLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQGL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQGL data set</returns>
        public override EduHubDataSetDataReader<RQGL> GetDataSetDataReader(List<RQGL> Entities)
        {
            return new RQGLDataReader(new EduHubDataSetLoadedReader<RQGL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class RQGLDataReader : EduHubDataSetDataReader<RQGL>
        {
            public RQGLDataReader(IEduHubDataSetReader<RQGL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // RQPGKEY
                        return Current.RQPGKEY;
                    case 2: // GLCODE
                        return Current.GLCODE;
                    case 3: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 4: // INITIATIVE
                        return Current.INITIATIVE;
                    case 5: // PR_LIMIT
                        return Current.PR_LIMIT;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // GLCODE
                        return Current.GLCODE == null;
                    case 3: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 4: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 5: // PR_LIMIT
                        return Current.PR_LIMIT == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
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
                    case 1: // RQPGKEY
                        return "RQPGKEY";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 4: // INITIATIVE
                        return "INITIATIVE";
                    case 5: // PR_LIMIT
                        return "PR_LIMIT";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
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
                    case "RQPGKEY":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "SUBPROGRAM":
                        return 3;
                    case "INITIATIVE":
                        return 4;
                    case "PR_LIMIT":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
