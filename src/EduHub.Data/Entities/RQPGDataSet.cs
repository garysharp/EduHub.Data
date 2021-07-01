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
    /// Purchasing Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQPGDataSet : EduHubDataSet<RQPG>
    {
        /// <inheritdoc />
        public override string Name { get { return "RQPG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal RQPGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RQPGKEY = new Lazy<Dictionary<string, RQPG>>(() => this.ToDictionary(i => i.RQPGKEY));
            Index_SFKEY = new Lazy<NullDictionary<string, IReadOnlyList<RQPG>>>(() => this.ToGroupedNullDictionary(i => i.SFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="RQPG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="RQPG" /> fields for each CSV column header</returns>
        internal override Action<RQPG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<RQPG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RQPGKEY":
                        mapper[i] = (e, v) => e.RQPGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SFKEY":
                        mapper[i] = (e, v) => e.SFKEY = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="RQPG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="RQPG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="RQPG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{RQPG}"/> of entities</returns>
        internal override IEnumerable<RQPG> ApplyDeltaEntities(IEnumerable<RQPG> Entities, List<RQPG> DeltaEntities)
        {
            HashSet<string> Index_RQPGKEY = new HashSet<string>(DeltaEntities.Select(i => i.RQPGKEY));

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

                            bool overwritten = Index_RQPGKEY.Remove(entity.RQPGKEY);
                            
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

        private Lazy<Dictionary<string, RQPG>> Index_RQPGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<RQPG>>> Index_SFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find RQPG by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQPG</param>
        /// <returns>Related RQPG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQPG FindByRQPGKEY(string RQPGKEY)
        {
            return Index_RQPGKEY.Value[RQPGKEY];
        }

        /// <summary>
        /// Attempt to find RQPG by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQPG</param>
        /// <param name="Value">Related RQPG entity</param>
        /// <returns>True if the related RQPG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRQPGKEY(string RQPGKEY, out RQPG Value)
        {
            return Index_RQPGKEY.Value.TryGetValue(RQPGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find RQPG by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQPG</param>
        /// <returns>Related RQPG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQPG TryFindByRQPGKEY(string RQPGKEY)
        {
            RQPG value;
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
        /// Find RQPG by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQPG</param>
        /// <returns>List of related RQPG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQPG> FindBySFKEY(string SFKEY)
        {
            return Index_SFKEY.Value[SFKEY];
        }

        /// <summary>
        /// Attempt to find RQPG by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQPG</param>
        /// <param name="Value">List of related RQPG entities</param>
        /// <returns>True if the list of related RQPG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFKEY(string SFKEY, out IReadOnlyList<RQPG> Value)
        {
            return Index_SFKEY.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find RQPG by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQPG</param>
        /// <returns>List of related RQPG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQPG> TryFindBySFKEY(string SFKEY)
        {
            IReadOnlyList<RQPG> value;
            if (Index_SFKEY.Value.TryGetValue(SFKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a RQPG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[RQPG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[RQPG](
        [RQPGKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [SFKEY] varchar(4) NULL,
        [EMAIL] varchar(40) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [RQPG_Index_RQPGKEY] PRIMARY KEY CLUSTERED (
            [RQPGKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [RQPG_Index_SFKEY] ON [dbo].[RQPG]
    (
            [SFKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQPG]') AND name = N'Index_SFKEY')
    ALTER INDEX [Index_SFKEY] ON [dbo].[RQPG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQPG]') AND name = N'Index_SFKEY')
    ALTER INDEX [Index_SFKEY] ON [dbo].[RQPG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="RQPG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="RQPG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<RQPG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_RQPGKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_RQPGKEY.Add(entity.RQPGKEY);
            }

            builder.AppendLine("DELETE [dbo].[RQPG] WHERE");


            // Index_RQPGKEY
            builder.Append("[RQPGKEY] IN (");
            for (int index = 0; index < Index_RQPGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // RQPGKEY
                var parameterRQPGKEY = $"@p{parameterIndex++}";
                builder.Append(parameterRQPGKEY);
                command.Parameters.Add(parameterRQPGKEY, SqlDbType.VarChar, 10).Value = Index_RQPGKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQPG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQPG data set</returns>
        public override EduHubDataSetDataReader<RQPG> GetDataSetDataReader()
        {
            return new RQPGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQPG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQPG data set</returns>
        public override EduHubDataSetDataReader<RQPG> GetDataSetDataReader(List<RQPG> Entities)
        {
            return new RQPGDataReader(new EduHubDataSetLoadedReader<RQPG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class RQPGDataReader : EduHubDataSetDataReader<RQPG>
        {
            public RQPGDataReader(IEduHubDataSetReader<RQPG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // RQPGKEY
                        return Current.RQPGKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // SFKEY
                        return Current.SFKEY;
                    case 3: // EMAIL
                        return Current.EMAIL;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
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
                    case 2: // SFKEY
                        return Current.SFKEY == null;
                    case 3: // EMAIL
                        return Current.EMAIL == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
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
                    case 0: // RQPGKEY
                        return "RQPGKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SFKEY
                        return "SFKEY";
                    case 3: // EMAIL
                        return "EMAIL";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_DATE
                        return "LW_DATE";
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
                    case "RQPGKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SFKEY":
                        return 2;
                    case "EMAIL":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_DATE":
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
