using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCMDataSet : EduHubDataSet<KCM>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCMKEY = new Lazy<Dictionary<string, KCM>>(() => this.ToDictionary(i => i.KCMKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KCM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM" /> fields for each CSV column header</returns>
        internal override Action<KCM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="KCM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCM}"/> of entities</returns>
        internal override IEnumerable<KCM> ApplyDeltaEntities(IEnumerable<KCM> Entities, List<KCM> DeltaEntities)
        {
            HashSet<string> Index_KCMKEY = new HashSet<string>(DeltaEntities.Select(i => i.KCMKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCMKEY.Remove(entity.KCMKEY);
                            
                            if (entity.KCMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCM>> Index_KCMKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KCM>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM FindByKCMKEY(string KCMKEY)
        {
            return Index_KCMKEY.Value[KCMKEY];
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <param name="Value">Related KCM entity</param>
        /// <returns>True if the related KCM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCMKEY(string KCMKEY, out KCM Value)
        {
            return Index_KCMKEY.Value.TryGetValue(KCMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM TryFindByKCMKEY(string KCMKEY)
        {
            KCM value;
            if (Index_KCMKEY.Value.TryGetValue(KCMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <returns>List of related KCM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <param name="Value">List of related KCM entities</param>
        /// <returns>True if the list of related KCM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KCM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <returns>List of related KCM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KCM> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCM](
        [KCMKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [DISABILITY] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCM_Index_KCMKEY] PRIMARY KEY CLUSTERED (
            [KCMKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCM_Index_LW_DATE] ON [dbo].[KCM]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCM]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[KCM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCM]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[KCM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KCMKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KCMKEY.Add(entity.KCMKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCM] WHERE");


            // Index_KCMKEY
            builder.Append("[KCMKEY] IN (");
            for (int index = 0; index < Index_KCMKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCMKEY
                var parameterKCMKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCMKEY);
                command.Parameters.Add(parameterKCMKEY, SqlDbType.VarChar, 10).Value = Index_KCMKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCM data set</returns>
        public override EduHubDataSetDataReader<KCM> GetDataSetDataReader()
        {
            return new KCMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCM data set</returns>
        public override EduHubDataSetDataReader<KCM> GetDataSetDataReader(List<KCM> Entities)
        {
            return new KCMDataReader(new EduHubDataSetLoadedReader<KCM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCMDataReader : EduHubDataSetDataReader<KCM>
        {
            public KCMDataReader(IEduHubDataSetReader<KCM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCMKEY
                        return Current.KCMKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // DISABILITY
                        return Current.DISABILITY;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
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
                    case 2: // DISABILITY
                        return Current.DISABILITY == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCMKEY
                        return "KCMKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // DISABILITY
                        return "DISABILITY";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCMKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "DISABILITY":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
