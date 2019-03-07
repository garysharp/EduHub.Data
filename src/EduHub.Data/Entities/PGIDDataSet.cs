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
    /// General Ledger Import Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGIDDataSet : EduHubDataSet<PGID>
    {
        /// <inheritdoc />
        public override string Name { get { return "PGID"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PGIDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DATE_IMPORTED = new Lazy<Dictionary<DateTime, IReadOnlyList<PGID>>>(() => this.ToGroupedDictionary(i => i.DATE_IMPORTED));
            Index_GLID = new Lazy<Dictionary<int, PGID>>(() => this.ToDictionary(i => i.GLID));
            Index_IMPORTED_BY = new Lazy<NullDictionary<string, IReadOnlyList<PGID>>>(() => this.ToGroupedNullDictionary(i => i.IMPORTED_BY));
            Index_SCHOOL_LINK = new Lazy<Dictionary<string, IReadOnlyList<PGID>>>(() => this.ToGroupedDictionary(i => i.SCHOOL_LINK));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PGID" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PGID" /> fields for each CSV column header</returns>
        internal override Action<PGID, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PGID, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLID":
                        mapper[i] = (e, v) => e.GLID = int.Parse(v);
                        break;
                    case "SCHOOL_LINK":
                        mapper[i] = (e, v) => e.SCHOOL_LINK = v;
                        break;
                    case "FILE_IMPORTED":
                        mapper[i] = (e, v) => e.FILE_IMPORTED = v;
                        break;
                    case "DATE_IMPORTED":
                        mapper[i] = (e, v) => e.DATE_IMPORTED = DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ROWS_IMPORTED":
                        mapper[i] = (e, v) => e.ROWS_IMPORTED = int.Parse(v);
                        break;
                    case "IMPORTED_BY":
                        mapper[i] = (e, v) => e.IMPORTED_BY = v;
                        break;
                    case "IMPORT_STATUS":
                        mapper[i] = (e, v) => e.IMPORT_STATUS = v;
                        break;
                    case "FAILURE_NOTIFICATION":
                        mapper[i] = (e, v) => e.FAILURE_NOTIFICATION = v;
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
        /// Merges <see cref="PGID" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PGID" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PGID" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PGID}"/> of entities</returns>
        internal override IEnumerable<PGID> ApplyDeltaEntities(IEnumerable<PGID> Entities, List<PGID> DeltaEntities)
        {
            HashSet<int> Index_GLID = new HashSet<int>(DeltaEntities.Select(i => i.GLID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GLID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_GLID.Remove(entity.GLID);
                            
                            if (entity.GLID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<DateTime, IReadOnlyList<PGID>>> Index_DATE_IMPORTED;
        private Lazy<Dictionary<int, PGID>> Index_GLID;
        private Lazy<NullDictionary<string, IReadOnlyList<PGID>>> Index_IMPORTED_BY;
        private Lazy<Dictionary<string, IReadOnlyList<PGID>>> Index_SCHOOL_LINK;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PGID by DATE_IMPORTED field
        /// </summary>
        /// <param name="DATE_IMPORTED">DATE_IMPORTED value used to find PGID</param>
        /// <returns>List of related PGID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGID> FindByDATE_IMPORTED(DateTime DATE_IMPORTED)
        {
            return Index_DATE_IMPORTED.Value[DATE_IMPORTED];
        }

        /// <summary>
        /// Attempt to find PGID by DATE_IMPORTED field
        /// </summary>
        /// <param name="DATE_IMPORTED">DATE_IMPORTED value used to find PGID</param>
        /// <param name="Value">List of related PGID entities</param>
        /// <returns>True if the list of related PGID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDATE_IMPORTED(DateTime DATE_IMPORTED, out IReadOnlyList<PGID> Value)
        {
            return Index_DATE_IMPORTED.Value.TryGetValue(DATE_IMPORTED, out Value);
        }

        /// <summary>
        /// Attempt to find PGID by DATE_IMPORTED field
        /// </summary>
        /// <param name="DATE_IMPORTED">DATE_IMPORTED value used to find PGID</param>
        /// <returns>List of related PGID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGID> TryFindByDATE_IMPORTED(DateTime DATE_IMPORTED)
        {
            IReadOnlyList<PGID> value;
            if (Index_DATE_IMPORTED.Value.TryGetValue(DATE_IMPORTED, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PGID by GLID field
        /// </summary>
        /// <param name="GLID">GLID value used to find PGID</param>
        /// <returns>Related PGID entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PGID FindByGLID(int GLID)
        {
            return Index_GLID.Value[GLID];
        }

        /// <summary>
        /// Attempt to find PGID by GLID field
        /// </summary>
        /// <param name="GLID">GLID value used to find PGID</param>
        /// <param name="Value">Related PGID entity</param>
        /// <returns>True if the related PGID entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLID(int GLID, out PGID Value)
        {
            return Index_GLID.Value.TryGetValue(GLID, out Value);
        }

        /// <summary>
        /// Attempt to find PGID by GLID field
        /// </summary>
        /// <param name="GLID">GLID value used to find PGID</param>
        /// <returns>Related PGID entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PGID TryFindByGLID(int GLID)
        {
            PGID value;
            if (Index_GLID.Value.TryGetValue(GLID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PGID by IMPORTED_BY field
        /// </summary>
        /// <param name="IMPORTED_BY">IMPORTED_BY value used to find PGID</param>
        /// <returns>List of related PGID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGID> FindByIMPORTED_BY(string IMPORTED_BY)
        {
            return Index_IMPORTED_BY.Value[IMPORTED_BY];
        }

        /// <summary>
        /// Attempt to find PGID by IMPORTED_BY field
        /// </summary>
        /// <param name="IMPORTED_BY">IMPORTED_BY value used to find PGID</param>
        /// <param name="Value">List of related PGID entities</param>
        /// <returns>True if the list of related PGID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByIMPORTED_BY(string IMPORTED_BY, out IReadOnlyList<PGID> Value)
        {
            return Index_IMPORTED_BY.Value.TryGetValue(IMPORTED_BY, out Value);
        }

        /// <summary>
        /// Attempt to find PGID by IMPORTED_BY field
        /// </summary>
        /// <param name="IMPORTED_BY">IMPORTED_BY value used to find PGID</param>
        /// <returns>List of related PGID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGID> TryFindByIMPORTED_BY(string IMPORTED_BY)
        {
            IReadOnlyList<PGID> value;
            if (Index_IMPORTED_BY.Value.TryGetValue(IMPORTED_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PGID by SCHOOL_LINK field
        /// </summary>
        /// <param name="SCHOOL_LINK">SCHOOL_LINK value used to find PGID</param>
        /// <returns>List of related PGID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGID> FindBySCHOOL_LINK(string SCHOOL_LINK)
        {
            return Index_SCHOOL_LINK.Value[SCHOOL_LINK];
        }

        /// <summary>
        /// Attempt to find PGID by SCHOOL_LINK field
        /// </summary>
        /// <param name="SCHOOL_LINK">SCHOOL_LINK value used to find PGID</param>
        /// <param name="Value">List of related PGID entities</param>
        /// <returns>True if the list of related PGID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_LINK(string SCHOOL_LINK, out IReadOnlyList<PGID> Value)
        {
            return Index_SCHOOL_LINK.Value.TryGetValue(SCHOOL_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find PGID by SCHOOL_LINK field
        /// </summary>
        /// <param name="SCHOOL_LINK">SCHOOL_LINK value used to find PGID</param>
        /// <returns>List of related PGID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGID> TryFindBySCHOOL_LINK(string SCHOOL_LINK)
        {
            IReadOnlyList<PGID> value;
            if (Index_SCHOOL_LINK.Value.TryGetValue(SCHOOL_LINK, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PGID table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PGID](
        [GLID] int IDENTITY NOT NULL,
        [SCHOOL_LINK] varchar(8) NOT NULL,
        [FILE_IMPORTED] varchar(30) NOT NULL,
        [DATE_IMPORTED] datetime NOT NULL,
        [ROWS_IMPORTED] int NOT NULL,
        [IMPORTED_BY] varchar(4) NULL,
        [IMPORT_STATUS] varchar(7) NOT NULL,
        [FAILURE_NOTIFICATION] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PGID_Index_GLID] PRIMARY KEY CLUSTERED (
            [GLID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PGID_Index_DATE_IMPORTED] ON [dbo].[PGID]
    (
            [DATE_IMPORTED] ASC
    );
    CREATE NONCLUSTERED INDEX [PGID_Index_IMPORTED_BY] ON [dbo].[PGID]
    (
            [IMPORTED_BY] ASC
    );
    CREATE NONCLUSTERED INDEX [PGID_Index_SCHOOL_LINK] ON [dbo].[PGID]
    (
            [SCHOOL_LINK] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND name = N'Index_DATE_IMPORTED')
    ALTER INDEX [Index_DATE_IMPORTED] ON [dbo].[PGID] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND name = N'Index_IMPORTED_BY')
    ALTER INDEX [Index_IMPORTED_BY] ON [dbo].[PGID] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND name = N'Index_SCHOOL_LINK')
    ALTER INDEX [Index_SCHOOL_LINK] ON [dbo].[PGID] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND name = N'Index_DATE_IMPORTED')
    ALTER INDEX [Index_DATE_IMPORTED] ON [dbo].[PGID] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND name = N'Index_IMPORTED_BY')
    ALTER INDEX [Index_IMPORTED_BY] ON [dbo].[PGID] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGID]') AND name = N'Index_SCHOOL_LINK')
    ALTER INDEX [Index_SCHOOL_LINK] ON [dbo].[PGID] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PGID"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PGID"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PGID> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_GLID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_GLID.Add(entity.GLID);
            }

            builder.AppendLine("DELETE [dbo].[PGID] WHERE");


            // Index_GLID
            builder.Append("[GLID] IN (");
            for (int index = 0; index < Index_GLID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // GLID
                var parameterGLID = $"@p{parameterIndex++}";
                builder.Append(parameterGLID);
                command.Parameters.Add(parameterGLID, SqlDbType.Int).Value = Index_GLID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PGID data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PGID data set</returns>
        public override EduHubDataSetDataReader<PGID> GetDataSetDataReader()
        {
            return new PGIDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PGID data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PGID data set</returns>
        public override EduHubDataSetDataReader<PGID> GetDataSetDataReader(List<PGID> Entities)
        {
            return new PGIDDataReader(new EduHubDataSetLoadedReader<PGID>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PGIDDataReader : EduHubDataSetDataReader<PGID>
        {
            public PGIDDataReader(IEduHubDataSetReader<PGID> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // GLID
                        return Current.GLID;
                    case 1: // SCHOOL_LINK
                        return Current.SCHOOL_LINK;
                    case 2: // FILE_IMPORTED
                        return Current.FILE_IMPORTED;
                    case 3: // DATE_IMPORTED
                        return Current.DATE_IMPORTED;
                    case 4: // ROWS_IMPORTED
                        return Current.ROWS_IMPORTED;
                    case 5: // IMPORTED_BY
                        return Current.IMPORTED_BY;
                    case 6: // IMPORT_STATUS
                        return Current.IMPORT_STATUS;
                    case 7: // FAILURE_NOTIFICATION
                        return Current.FAILURE_NOTIFICATION;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 5: // IMPORTED_BY
                        return Current.IMPORTED_BY == null;
                    case 7: // FAILURE_NOTIFICATION
                        return Current.FAILURE_NOTIFICATION == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // GLID
                        return "GLID";
                    case 1: // SCHOOL_LINK
                        return "SCHOOL_LINK";
                    case 2: // FILE_IMPORTED
                        return "FILE_IMPORTED";
                    case 3: // DATE_IMPORTED
                        return "DATE_IMPORTED";
                    case 4: // ROWS_IMPORTED
                        return "ROWS_IMPORTED";
                    case 5: // IMPORTED_BY
                        return "IMPORTED_BY";
                    case 6: // IMPORT_STATUS
                        return "IMPORT_STATUS";
                    case 7: // FAILURE_NOTIFICATION
                        return "FAILURE_NOTIFICATION";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "GLID":
                        return 0;
                    case "SCHOOL_LINK":
                        return 1;
                    case "FILE_IMPORTED":
                        return 2;
                    case "DATE_IMPORTED":
                        return 3;
                    case "ROWS_IMPORTED":
                        return 4;
                    case "IMPORTED_BY":
                        return 5;
                    case "IMPORT_STATUS":
                        return 6;
                    case "FAILURE_NOTIFICATION":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
