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
    /// Auditable Tables Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSATDataSet : EduHubDataSet<QSAT>
    {
        /// <inheritdoc />
        public override string Name { get { return "QSAT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal QSATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GROUPING = new Lazy<NullDictionary<string, IReadOnlyList<QSAT>>>(() => this.ToGroupedNullDictionary(i => i.GROUPING));
            Index_TABLE_NAME = new Lazy<Dictionary<string, QSAT>>(() => this.ToDictionary(i => i.TABLE_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QSAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QSAT" /> fields for each CSV column header</returns>
        internal override Action<QSAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QSAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TABLE_NAME":
                        mapper[i] = (e, v) => e.TABLE_NAME = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GROUPING":
                        mapper[i] = (e, v) => e.GROUPING = v;
                        break;
                    case "KEY_COLUMN":
                        mapper[i] = (e, v) => e.KEY_COLUMN = v;
                        break;
                    case "DESCRIPTION_COLUMN":
                        mapper[i] = (e, v) => e.DESCRIPTION_COLUMN = v;
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
        /// Merges <see cref="QSAT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="QSAT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="QSAT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{QSAT}"/> of entities</returns>
        internal override IEnumerable<QSAT> ApplyDeltaEntities(IEnumerable<QSAT> Entities, List<QSAT> DeltaEntities)
        {
            HashSet<string> Index_TABLE_NAME = new HashSet<string>(DeltaEntities.Select(i => i.TABLE_NAME));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TABLE_NAME;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TABLE_NAME.Remove(entity.TABLE_NAME);
                            
                            if (entity.TABLE_NAME.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<QSAT>>> Index_GROUPING;
        private Lazy<Dictionary<string, QSAT>> Index_TABLE_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QSAT by GROUPING field
        /// </summary>
        /// <param name="GROUPING">GROUPING value used to find QSAT</param>
        /// <returns>List of related QSAT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<QSAT> FindByGROUPING(string GROUPING)
        {
            return Index_GROUPING.Value[GROUPING];
        }

        /// <summary>
        /// Attempt to find QSAT by GROUPING field
        /// </summary>
        /// <param name="GROUPING">GROUPING value used to find QSAT</param>
        /// <param name="Value">List of related QSAT entities</param>
        /// <returns>True if the list of related QSAT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPING(string GROUPING, out IReadOnlyList<QSAT> Value)
        {
            return Index_GROUPING.Value.TryGetValue(GROUPING, out Value);
        }

        /// <summary>
        /// Attempt to find QSAT by GROUPING field
        /// </summary>
        /// <param name="GROUPING">GROUPING value used to find QSAT</param>
        /// <returns>List of related QSAT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<QSAT> TryFindByGROUPING(string GROUPING)
        {
            IReadOnlyList<QSAT> value;
            if (Index_GROUPING.Value.TryGetValue(GROUPING, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find QSAT by TABLE_NAME field
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAT</param>
        /// <returns>Related QSAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAT FindByTABLE_NAME(string TABLE_NAME)
        {
            return Index_TABLE_NAME.Value[TABLE_NAME];
        }

        /// <summary>
        /// Attempt to find QSAT by TABLE_NAME field
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAT</param>
        /// <param name="Value">Related QSAT entity</param>
        /// <returns>True if the related QSAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTABLE_NAME(string TABLE_NAME, out QSAT Value)
        {
            return Index_TABLE_NAME.Value.TryGetValue(TABLE_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find QSAT by TABLE_NAME field
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAT</param>
        /// <returns>Related QSAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAT TryFindByTABLE_NAME(string TABLE_NAME)
        {
            QSAT value;
            if (Index_TABLE_NAME.Value.TryGetValue(TABLE_NAME, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a QSAT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QSAT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QSAT](
        [TABLE_NAME] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(32) NULL,
        [GROUPING] varchar(10) NULL,
        [KEY_COLUMN] varchar(32) NULL,
        [DESCRIPTION_COLUMN] varchar(32) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QSAT_Index_TABLE_NAME] PRIMARY KEY CLUSTERED (
            [TABLE_NAME] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [QSAT_Index_GROUPING] ON [dbo].[QSAT]
    (
            [GROUPING] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[QSAT]') AND name = N'Index_GROUPING')
    ALTER INDEX [Index_GROUPING] ON [dbo].[QSAT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[QSAT]') AND name = N'Index_GROUPING')
    ALTER INDEX [Index_GROUPING] ON [dbo].[QSAT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="QSAT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="QSAT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<QSAT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_TABLE_NAME = new List<string>();

            foreach (var entity in Entities)
            {
                Index_TABLE_NAME.Add(entity.TABLE_NAME);
            }

            builder.AppendLine("DELETE [dbo].[QSAT] WHERE");


            // Index_TABLE_NAME
            builder.Append("[TABLE_NAME] IN (");
            for (int index = 0; index < Index_TABLE_NAME.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TABLE_NAME
                var parameterTABLE_NAME = $"@p{parameterIndex++}";
                builder.Append(parameterTABLE_NAME);
                command.Parameters.Add(parameterTABLE_NAME, SqlDbType.VarChar, 10).Value = Index_TABLE_NAME[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAT data set</returns>
        public override EduHubDataSetDataReader<QSAT> GetDataSetDataReader()
        {
            return new QSATDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAT data set</returns>
        public override EduHubDataSetDataReader<QSAT> GetDataSetDataReader(List<QSAT> Entities)
        {
            return new QSATDataReader(new EduHubDataSetLoadedReader<QSAT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QSATDataReader : EduHubDataSetDataReader<QSAT>
        {
            public QSATDataReader(IEduHubDataSetReader<QSAT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TABLE_NAME
                        return Current.TABLE_NAME;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // GROUPING
                        return Current.GROUPING;
                    case 3: // KEY_COLUMN
                        return Current.KEY_COLUMN;
                    case 4: // DESCRIPTION_COLUMN
                        return Current.DESCRIPTION_COLUMN;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // GROUPING
                        return Current.GROUPING == null;
                    case 3: // KEY_COLUMN
                        return Current.KEY_COLUMN == null;
                    case 4: // DESCRIPTION_COLUMN
                        return Current.DESCRIPTION_COLUMN == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TABLE_NAME
                        return "TABLE_NAME";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GROUPING
                        return "GROUPING";
                    case 3: // KEY_COLUMN
                        return "KEY_COLUMN";
                    case 4: // DESCRIPTION_COLUMN
                        return "DESCRIPTION_COLUMN";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TABLE_NAME":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GROUPING":
                        return 2;
                    case "KEY_COLUMN":
                        return 3;
                    case "DESCRIPTION_COLUMN":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
