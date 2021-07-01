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
    /// Home Group Daily Attendance Records Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXHGDataSet : EduHubDataSet<TXHG>
    {
        /// <inheritdoc />
        public override string Name { get { return "TXHG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TXHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<TXHG>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TXHG>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_TXHG_ID = new Lazy<Dictionary<int, TXHG>>(() => this.ToDictionary(i => i.TXHG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXHG" /> fields for each CSV column header</returns>
        internal override Action<TXHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TXHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TXHG_ID":
                        mapper[i] = (e, v) => e.TXHG_ID = int.Parse(v);
                        break;
                    case "TXHG_DATE":
                        mapper[i] = (e, v) => e.TXHG_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "AM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.AM_ROLL_MARKED = v;
                        break;
                    case "PM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.PM_ROLL_MARKED = v;
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
        /// Merges <see cref="TXHG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TXHG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TXHG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TXHG}"/> of entities</returns>
        internal override IEnumerable<TXHG> ApplyDeltaEntities(IEnumerable<TXHG> Entities, List<TXHG> DeltaEntities)
        {
            HashSet<int> Index_TXHG_ID = new HashSet<int>(DeltaEntities.Select(i => i.TXHG_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TXHG_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TXHG_ID.Remove(entity.TXHG_ID);
                            
                            if (entity.TXHG_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TXHG>>> Index_HOME_GROUP;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TXHG>>> Index_LW_DATE;
        private Lazy<Dictionary<int, TXHG>> Index_TXHG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <returns>List of related TXHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> FindByHOME_GROUP(string HOME_GROUP)
        {
            return Index_HOME_GROUP.Value[HOME_GROUP];
        }

        /// <summary>
        /// Attempt to find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <param name="Value">List of related TXHG entities</param>
        /// <returns>True if the list of related TXHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_GROUP(string HOME_GROUP, out IReadOnlyList<TXHG> Value)
        {
            return Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <returns>List of related TXHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> TryFindByHOME_GROUP(string HOME_GROUP)
        {
            IReadOnlyList<TXHG> value;
            if (Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <returns>List of related TXHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <param name="Value">List of related TXHG entities</param>
        /// <returns>True if the list of related TXHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TXHG> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <returns>List of related TXHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TXHG> value;
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
        /// Find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXHG FindByTXHG_ID(int TXHG_ID)
        {
            return Index_TXHG_ID.Value[TXHG_ID];
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <param name="Value">Related TXHG entity</param>
        /// <returns>True if the related TXHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTXHG_ID(int TXHG_ID, out TXHG Value)
        {
            return Index_TXHG_ID.Value.TryGetValue(TXHG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXHG TryFindByTXHG_ID(int TXHG_ID)
        {
            TXHG value;
            if (Index_TXHG_ID.Value.TryGetValue(TXHG_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TXHG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TXHG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TXHG](
        [TXHG_ID] int IDENTITY NOT NULL,
        [TXHG_DATE] datetime NULL,
        [HOME_GROUP] varchar(3) NULL,
        [AM_ROLL_MARKED] varchar(1) NULL,
        [PM_ROLL_MARKED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TXHG_Index_TXHG_ID] PRIMARY KEY CLUSTERED (
            [TXHG_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TXHG_Index_HOME_GROUP] ON [dbo].[TXHG]
    (
            [HOME_GROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [TXHG_Index_LW_DATE] ON [dbo].[TXHG]
    (
            [LW_DATE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXHG]') AND name = N'TXHG_Index_HOME_GROUP')
    ALTER INDEX [TXHG_Index_HOME_GROUP] ON [dbo].[TXHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXHG]') AND name = N'TXHG_Index_LW_DATE')
    ALTER INDEX [TXHG_Index_LW_DATE] ON [dbo].[TXHG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXHG]') AND name = N'TXHG_Index_HOME_GROUP')
    ALTER INDEX [TXHG_Index_HOME_GROUP] ON [dbo].[TXHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXHG]') AND name = N'TXHG_Index_LW_DATE')
    ALTER INDEX [TXHG_Index_LW_DATE] ON [dbo].[TXHG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TXHG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TXHG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TXHG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TXHG_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TXHG_ID.Add(entity.TXHG_ID);
            }

            builder.AppendLine("DELETE [dbo].[TXHG] WHERE");


            // Index_TXHG_ID
            builder.Append("[TXHG_ID] IN (");
            for (int index = 0; index < Index_TXHG_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TXHG_ID
                var parameterTXHG_ID = $"@p{parameterIndex++}";
                builder.Append(parameterTXHG_ID);
                command.Parameters.Add(parameterTXHG_ID, SqlDbType.Int).Value = Index_TXHG_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TXHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TXHG data set</returns>
        public override EduHubDataSetDataReader<TXHG> GetDataSetDataReader()
        {
            return new TXHGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TXHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TXHG data set</returns>
        public override EduHubDataSetDataReader<TXHG> GetDataSetDataReader(List<TXHG> Entities)
        {
            return new TXHGDataReader(new EduHubDataSetLoadedReader<TXHG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TXHGDataReader : EduHubDataSetDataReader<TXHG>
        {
            public TXHGDataReader(IEduHubDataSetReader<TXHG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TXHG_ID
                        return Current.TXHG_ID;
                    case 1: // TXHG_DATE
                        return Current.TXHG_DATE;
                    case 2: // HOME_GROUP
                        return Current.HOME_GROUP;
                    case 3: // AM_ROLL_MARKED
                        return Current.AM_ROLL_MARKED;
                    case 4: // PM_ROLL_MARKED
                        return Current.PM_ROLL_MARKED;
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
                    case 1: // TXHG_DATE
                        return Current.TXHG_DATE == null;
                    case 2: // HOME_GROUP
                        return Current.HOME_GROUP == null;
                    case 3: // AM_ROLL_MARKED
                        return Current.AM_ROLL_MARKED == null;
                    case 4: // PM_ROLL_MARKED
                        return Current.PM_ROLL_MARKED == null;
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
                    case 0: // TXHG_ID
                        return "TXHG_ID";
                    case 1: // TXHG_DATE
                        return "TXHG_DATE";
                    case 2: // HOME_GROUP
                        return "HOME_GROUP";
                    case 3: // AM_ROLL_MARKED
                        return "AM_ROLL_MARKED";
                    case 4: // PM_ROLL_MARKED
                        return "PM_ROLL_MARKED";
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
                    case "TXHG_ID":
                        return 0;
                    case "TXHG_DATE":
                        return 1;
                    case "HOME_GROUP":
                        return 2;
                    case "AM_ROLL_MARKED":
                        return 3;
                    case "PM_ROLL_MARKED":
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
