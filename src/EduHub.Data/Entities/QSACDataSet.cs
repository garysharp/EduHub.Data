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
    /// Audit Control Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSACDataSet : EduHubDataSet<QSAC>
    {
        /// <inheritdoc />
        public override string Name { get { return "QSAC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal QSACDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QSACKEY = new Lazy<Dictionary<int, QSAC>>(() => this.ToDictionary(i => i.QSACKEY));
            Index_TABLE_NAME = new Lazy<NullDictionary<string, IReadOnlyList<QSAC>>>(() => this.ToGroupedNullDictionary(i => i.TABLE_NAME));
            Index_TABLE_NAME_COLUMN_NAME = new Lazy<Dictionary<Tuple<string, string>, QSAC>>(() => this.ToDictionary(i => Tuple.Create(i.TABLE_NAME, i.COLUMN_NAME)));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QSAC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QSAC" /> fields for each CSV column header</returns>
        internal override Action<QSAC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QSAC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSACKEY":
                        mapper[i] = (e, v) => e.QSACKEY = int.Parse(v);
                        break;
                    case "TABLE_NAME":
                        mapper[i] = (e, v) => e.TABLE_NAME = v;
                        break;
                    case "COLUMN_NAME":
                        mapper[i] = (e, v) => e.COLUMN_NAME = v;
                        break;
                    case "RETAIN_MONTHS":
                        mapper[i] = (e, v) => e.RETAIN_MONTHS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AUDIT_INSERTS":
                        mapper[i] = (e, v) => e.AUDIT_INSERTS = v;
                        break;
                    case "AUDIT_UPDATES":
                        mapper[i] = (e, v) => e.AUDIT_UPDATES = v;
                        break;
                    case "AUDIT_DELETES":
                        mapper[i] = (e, v) => e.AUDIT_DELETES = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "FOR_MANAGEMENT_USE":
                        mapper[i] = (e, v) => e.FOR_MANAGEMENT_USE = v;
                        break;
                    case "FOR_AUDITOR_USE":
                        mapper[i] = (e, v) => e.FOR_AUDITOR_USE = v;
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
        /// Merges <see cref="QSAC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="QSAC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="QSAC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{QSAC}"/> of entities</returns>
        internal override IEnumerable<QSAC> ApplyDeltaEntities(IEnumerable<QSAC> Entities, List<QSAC> DeltaEntities)
        {
            HashSet<int> Index_QSACKEY = new HashSet<int>(DeltaEntities.Select(i => i.QSACKEY));
            HashSet<Tuple<string, string>> Index_TABLE_NAME_COLUMN_NAME = new HashSet<Tuple<string, string>>(DeltaEntities.Select(i => Tuple.Create(i.TABLE_NAME, i.COLUMN_NAME)));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.QSACKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_QSACKEY.Remove(entity.QSACKEY);
                            overwritten = overwritten || Index_TABLE_NAME_COLUMN_NAME.Remove(Tuple.Create(entity.TABLE_NAME, entity.COLUMN_NAME));
                            
                            if (entity.QSACKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, QSAC>> Index_QSACKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<QSAC>>> Index_TABLE_NAME;
        private Lazy<Dictionary<Tuple<string, string>, QSAC>> Index_TABLE_NAME_COLUMN_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QSAC by QSACKEY field
        /// </summary>
        /// <param name="QSACKEY">QSACKEY value used to find QSAC</param>
        /// <returns>Related QSAC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAC FindByQSACKEY(int QSACKEY)
        {
            return Index_QSACKEY.Value[QSACKEY];
        }

        /// <summary>
        /// Attempt to find QSAC by QSACKEY field
        /// </summary>
        /// <param name="QSACKEY">QSACKEY value used to find QSAC</param>
        /// <param name="Value">Related QSAC entity</param>
        /// <returns>True if the related QSAC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQSACKEY(int QSACKEY, out QSAC Value)
        {
            return Index_QSACKEY.Value.TryGetValue(QSACKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QSAC by QSACKEY field
        /// </summary>
        /// <param name="QSACKEY">QSACKEY value used to find QSAC</param>
        /// <returns>Related QSAC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAC TryFindByQSACKEY(int QSACKEY)
        {
            QSAC value;
            if (Index_QSACKEY.Value.TryGetValue(QSACKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find QSAC by TABLE_NAME field
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAC</param>
        /// <returns>List of related QSAC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<QSAC> FindByTABLE_NAME(string TABLE_NAME)
        {
            return Index_TABLE_NAME.Value[TABLE_NAME];
        }

        /// <summary>
        /// Attempt to find QSAC by TABLE_NAME field
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAC</param>
        /// <param name="Value">List of related QSAC entities</param>
        /// <returns>True if the list of related QSAC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTABLE_NAME(string TABLE_NAME, out IReadOnlyList<QSAC> Value)
        {
            return Index_TABLE_NAME.Value.TryGetValue(TABLE_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find QSAC by TABLE_NAME field
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAC</param>
        /// <returns>List of related QSAC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<QSAC> TryFindByTABLE_NAME(string TABLE_NAME)
        {
            IReadOnlyList<QSAC> value;
            if (Index_TABLE_NAME.Value.TryGetValue(TABLE_NAME, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find QSAC by TABLE_NAME and COLUMN_NAME fields
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAC</param>
        /// <param name="COLUMN_NAME">COLUMN_NAME value used to find QSAC</param>
        /// <returns>Related QSAC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAC FindByTABLE_NAME_COLUMN_NAME(string TABLE_NAME, string COLUMN_NAME)
        {
            return Index_TABLE_NAME_COLUMN_NAME.Value[Tuple.Create(TABLE_NAME, COLUMN_NAME)];
        }

        /// <summary>
        /// Attempt to find QSAC by TABLE_NAME and COLUMN_NAME fields
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAC</param>
        /// <param name="COLUMN_NAME">COLUMN_NAME value used to find QSAC</param>
        /// <param name="Value">Related QSAC entity</param>
        /// <returns>True if the related QSAC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTABLE_NAME_COLUMN_NAME(string TABLE_NAME, string COLUMN_NAME, out QSAC Value)
        {
            return Index_TABLE_NAME_COLUMN_NAME.Value.TryGetValue(Tuple.Create(TABLE_NAME, COLUMN_NAME), out Value);
        }

        /// <summary>
        /// Attempt to find QSAC by TABLE_NAME and COLUMN_NAME fields
        /// </summary>
        /// <param name="TABLE_NAME">TABLE_NAME value used to find QSAC</param>
        /// <param name="COLUMN_NAME">COLUMN_NAME value used to find QSAC</param>
        /// <returns>Related QSAC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAC TryFindByTABLE_NAME_COLUMN_NAME(string TABLE_NAME, string COLUMN_NAME)
        {
            QSAC value;
            if (Index_TABLE_NAME_COLUMN_NAME.Value.TryGetValue(Tuple.Create(TABLE_NAME, COLUMN_NAME), out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a QSAC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QSAC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QSAC](
        [QSACKEY] int IDENTITY NOT NULL,
        [TABLE_NAME] varchar(10) NULL,
        [COLUMN_NAME] varchar(32) NULL,
        [RETAIN_MONTHS] smallint NULL,
        [AUDIT_INSERTS] varchar(1) NULL,
        [AUDIT_UPDATES] varchar(1) NULL,
        [AUDIT_DELETES] varchar(1) NULL,
        [ENABLED] varchar(1) NULL,
        [FOR_MANAGEMENT_USE] varchar(1) NULL,
        [FOR_AUDITOR_USE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QSAC_Index_QSACKEY] PRIMARY KEY CLUSTERED (
            [QSACKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [QSAC_Index_TABLE_NAME] ON [dbo].[QSAC]
    (
            [TABLE_NAME] ASC
    );
    CREATE NONCLUSTERED INDEX [QSAC_Index_TABLE_NAME_COLUMN_NAME] ON [dbo].[QSAC]
    (
            [TABLE_NAME] ASC,
            [COLUMN_NAME] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[QSAC]') AND name = N'Index_TABLE_NAME')
    ALTER INDEX [Index_TABLE_NAME] ON [dbo].[QSAC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[QSAC]') AND name = N'Index_TABLE_NAME_COLUMN_NAME')
    ALTER INDEX [Index_TABLE_NAME_COLUMN_NAME] ON [dbo].[QSAC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[QSAC]') AND name = N'Index_TABLE_NAME')
    ALTER INDEX [Index_TABLE_NAME] ON [dbo].[QSAC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[QSAC]') AND name = N'Index_TABLE_NAME_COLUMN_NAME')
    ALTER INDEX [Index_TABLE_NAME_COLUMN_NAME] ON [dbo].[QSAC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="QSAC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="QSAC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<QSAC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_QSACKEY = new List<int>();
            List<Tuple<string, string>> Index_TABLE_NAME_COLUMN_NAME = new List<Tuple<string, string>>();

            foreach (var entity in Entities)
            {
                Index_QSACKEY.Add(entity.QSACKEY);
                Index_TABLE_NAME_COLUMN_NAME.Add(Tuple.Create(entity.TABLE_NAME, entity.COLUMN_NAME));
            }

            builder.AppendLine("DELETE [dbo].[QSAC] WHERE");


            // Index_QSACKEY
            builder.Append("[QSACKEY] IN (");
            for (int index = 0; index < Index_QSACKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // QSACKEY
                var parameterQSACKEY = $"@p{parameterIndex++}";
                builder.Append(parameterQSACKEY);
                command.Parameters.Add(parameterQSACKEY, SqlDbType.Int).Value = Index_QSACKEY[index];
            }
            builder.AppendLine(") OR");

            // Index_TABLE_NAME_COLUMN_NAME
            builder.Append("(");
            for (int index = 0; index < Index_TABLE_NAME_COLUMN_NAME.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // TABLE_NAME
                if (Index_TABLE_NAME_COLUMN_NAME[index].Item1 == null)
                {
                    builder.Append("([TABLE_NAME] IS NULL");
                }
                else
                {
                    var parameterTABLE_NAME = $"@p{parameterIndex++}";
                    builder.Append("([TABLE_NAME]=").Append(parameterTABLE_NAME);
                    command.Parameters.Add(parameterTABLE_NAME, SqlDbType.VarChar, 10).Value = Index_TABLE_NAME_COLUMN_NAME[index].Item1;
                }

                // COLUMN_NAME
                if (Index_TABLE_NAME_COLUMN_NAME[index].Item2 == null)
                {
                    builder.Append(" AND [COLUMN_NAME] IS NULL)");
                }
                else
                {
                    var parameterCOLUMN_NAME = $"@p{parameterIndex++}";
                    builder.Append(" AND [COLUMN_NAME]=").Append(parameterCOLUMN_NAME).Append(")");
                    command.Parameters.Add(parameterCOLUMN_NAME, SqlDbType.VarChar, 32).Value = Index_TABLE_NAME_COLUMN_NAME[index].Item2;
                }
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAC data set</returns>
        public override EduHubDataSetDataReader<QSAC> GetDataSetDataReader()
        {
            return new QSACDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAC data set</returns>
        public override EduHubDataSetDataReader<QSAC> GetDataSetDataReader(List<QSAC> Entities)
        {
            return new QSACDataReader(new EduHubDataSetLoadedReader<QSAC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QSACDataReader : EduHubDataSetDataReader<QSAC>
        {
            public QSACDataReader(IEduHubDataSetReader<QSAC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // QSACKEY
                        return Current.QSACKEY;
                    case 1: // TABLE_NAME
                        return Current.TABLE_NAME;
                    case 2: // COLUMN_NAME
                        return Current.COLUMN_NAME;
                    case 3: // RETAIN_MONTHS
                        return Current.RETAIN_MONTHS;
                    case 4: // AUDIT_INSERTS
                        return Current.AUDIT_INSERTS;
                    case 5: // AUDIT_UPDATES
                        return Current.AUDIT_UPDATES;
                    case 6: // AUDIT_DELETES
                        return Current.AUDIT_DELETES;
                    case 7: // ENABLED
                        return Current.ENABLED;
                    case 8: // FOR_MANAGEMENT_USE
                        return Current.FOR_MANAGEMENT_USE;
                    case 9: // FOR_AUDITOR_USE
                        return Current.FOR_AUDITOR_USE;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TABLE_NAME
                        return Current.TABLE_NAME == null;
                    case 2: // COLUMN_NAME
                        return Current.COLUMN_NAME == null;
                    case 3: // RETAIN_MONTHS
                        return Current.RETAIN_MONTHS == null;
                    case 4: // AUDIT_INSERTS
                        return Current.AUDIT_INSERTS == null;
                    case 5: // AUDIT_UPDATES
                        return Current.AUDIT_UPDATES == null;
                    case 6: // AUDIT_DELETES
                        return Current.AUDIT_DELETES == null;
                    case 7: // ENABLED
                        return Current.ENABLED == null;
                    case 8: // FOR_MANAGEMENT_USE
                        return Current.FOR_MANAGEMENT_USE == null;
                    case 9: // FOR_AUDITOR_USE
                        return Current.FOR_AUDITOR_USE == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // QSACKEY
                        return "QSACKEY";
                    case 1: // TABLE_NAME
                        return "TABLE_NAME";
                    case 2: // COLUMN_NAME
                        return "COLUMN_NAME";
                    case 3: // RETAIN_MONTHS
                        return "RETAIN_MONTHS";
                    case 4: // AUDIT_INSERTS
                        return "AUDIT_INSERTS";
                    case 5: // AUDIT_UPDATES
                        return "AUDIT_UPDATES";
                    case 6: // AUDIT_DELETES
                        return "AUDIT_DELETES";
                    case 7: // ENABLED
                        return "ENABLED";
                    case 8: // FOR_MANAGEMENT_USE
                        return "FOR_MANAGEMENT_USE";
                    case 9: // FOR_AUDITOR_USE
                        return "FOR_AUDITOR_USE";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "QSACKEY":
                        return 0;
                    case "TABLE_NAME":
                        return 1;
                    case "COLUMN_NAME":
                        return 2;
                    case "RETAIN_MONTHS":
                        return 3;
                    case "AUDIT_INSERTS":
                        return 4;
                    case "AUDIT_UPDATES":
                        return 5;
                    case "AUDIT_DELETES":
                        return 6;
                    case "ENABLED":
                        return 7;
                    case "FOR_MANAGEMENT_USE":
                        return 8;
                    case "FOR_AUDITOR_USE":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
