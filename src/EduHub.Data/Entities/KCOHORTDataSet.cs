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
    /// Cohorts for data aggregation Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCOHORTDataSet : EduHubDataSet<KCOHORT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCOHORT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCOHORTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COHORT = new Lazy<Dictionary<string, KCOHORT>>(() => this.ToDictionary(i => i.COHORT));
            Index_DESCRIPTION = new Lazy<NullDictionary<string, IReadOnlyList<KCOHORT>>>(() => this.ToGroupedNullDictionary(i => i.DESCRIPTION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCOHORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCOHORT" /> fields for each CSV column header</returns>
        internal override Action<KCOHORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCOHORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VELS":
                        mapper[i] = (e, v) => e.VELS = v;
                        break;
                    case "BENCHMARK":
                        mapper[i] = (e, v) => e.BENCHMARK = v;
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
        /// Merges <see cref="KCOHORT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCOHORT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCOHORT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCOHORT}"/> of entities</returns>
        internal override IEnumerable<KCOHORT> ApplyDeltaEntities(IEnumerable<KCOHORT> Entities, List<KCOHORT> DeltaEntities)
        {
            HashSet<string> Index_COHORT = new HashSet<string>(DeltaEntities.Select(i => i.COHORT));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.COHORT;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_COHORT.Remove(entity.COHORT);
                            
                            if (entity.COHORT.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCOHORT>> Index_COHORT;
        private Lazy<NullDictionary<string, IReadOnlyList<KCOHORT>>> Index_DESCRIPTION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCOHORT FindByCOHORT(string COHORT)
        {
            return Index_COHORT.Value[COHORT];
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <param name="Value">Related KCOHORT entity</param>
        /// <returns>True if the related KCOHORT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOHORT(string COHORT, out KCOHORT Value)
        {
            return Index_COHORT.Value.TryGetValue(COHORT, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find KCOHORT</param>
        /// <returns>Related KCOHORT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCOHORT TryFindByCOHORT(string COHORT)
        {
            KCOHORT value;
            if (Index_COHORT.Value.TryGetValue(COHORT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>List of related KCOHORT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCOHORT> FindByDESCRIPTION(string DESCRIPTION)
        {
            return Index_DESCRIPTION.Value[DESCRIPTION];
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <param name="Value">List of related KCOHORT entities</param>
        /// <returns>True if the list of related KCOHORT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDESCRIPTION(string DESCRIPTION, out IReadOnlyList<KCOHORT> Value)
        {
            return Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out Value);
        }

        /// <summary>
        /// Attempt to find KCOHORT by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find KCOHORT</param>
        /// <returns>List of related KCOHORT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCOHORT> TryFindByDESCRIPTION(string DESCRIPTION)
        {
            IReadOnlyList<KCOHORT> value;
            if (Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCOHORT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCOHORT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCOHORT](
        [COHORT] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [VELS] varchar(1) NULL,
        [BENCHMARK] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCOHORT_Index_COHORT] PRIMARY KEY CLUSTERED (
            [COHORT] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCOHORT_Index_DESCRIPTION] ON [dbo].[KCOHORT]
    (
            [DESCRIPTION] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCOHORT]') AND name = N'KCOHORT_Index_DESCRIPTION')
    ALTER INDEX [KCOHORT_Index_DESCRIPTION] ON [dbo].[KCOHORT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCOHORT]') AND name = N'KCOHORT_Index_DESCRIPTION')
    ALTER INDEX [KCOHORT_Index_DESCRIPTION] ON [dbo].[KCOHORT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCOHORT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCOHORT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCOHORT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_COHORT = new List<string>();

            foreach (var entity in Entities)
            {
                Index_COHORT.Add(entity.COHORT);
            }

            builder.AppendLine("DELETE [dbo].[KCOHORT] WHERE");


            // Index_COHORT
            builder.Append("[COHORT] IN (");
            for (int index = 0; index < Index_COHORT.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // COHORT
                var parameterCOHORT = $"@p{parameterIndex++}";
                builder.Append(parameterCOHORT);
                command.Parameters.Add(parameterCOHORT, SqlDbType.VarChar, 2).Value = Index_COHORT[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCOHORT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCOHORT data set</returns>
        public override EduHubDataSetDataReader<KCOHORT> GetDataSetDataReader()
        {
            return new KCOHORTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCOHORT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCOHORT data set</returns>
        public override EduHubDataSetDataReader<KCOHORT> GetDataSetDataReader(List<KCOHORT> Entities)
        {
            return new KCOHORTDataReader(new EduHubDataSetLoadedReader<KCOHORT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCOHORTDataReader : EduHubDataSetDataReader<KCOHORT>
        {
            public KCOHORTDataReader(IEduHubDataSetReader<KCOHORT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // COHORT
                        return Current.COHORT;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // VELS
                        return Current.VELS;
                    case 3: // BENCHMARK
                        return Current.BENCHMARK;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
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
                    case 2: // VELS
                        return Current.VELS == null;
                    case 3: // BENCHMARK
                        return Current.BENCHMARK == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // COHORT
                        return "COHORT";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // VELS
                        return "VELS";
                    case 3: // BENCHMARK
                        return "BENCHMARK";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "COHORT":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "VELS":
                        return 2;
                    case "BENCHMARK":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
