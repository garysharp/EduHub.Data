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
    /// Faculties Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSFDataSet : EduHubDataSet<KSF>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COORDINATOR = new Lazy<NullDictionary<string, IReadOnlyList<KSF>>>(() => this.ToGroupedNullDictionary(i => i.COORDINATOR));
            Index_KSFKEY = new Lazy<Dictionary<string, KSF>>(() => this.ToDictionary(i => i.KSFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSF" /> fields for each CSV column header</returns>
        internal override Action<KSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSFKEY":
                        mapper[i] = (e, v) => e.KSFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "COORDINATOR":
                        mapper[i] = (e, v) => e.COORDINATOR = v;
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
        /// Merges <see cref="KSF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSF}"/> of entities</returns>
        internal override IEnumerable<KSF> ApplyDeltaEntities(IEnumerable<KSF> Entities, List<KSF> DeltaEntities)
        {
            HashSet<string> Index_KSFKEY = new HashSet<string>(DeltaEntities.Select(i => i.KSFKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KSFKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KSFKEY.Remove(entity.KSFKEY);
                            
                            if (entity.KSFKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KSF>>> Index_COORDINATOR;
        private Lazy<Dictionary<string, KSF>> Index_KSFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <returns>List of related KSF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSF> FindByCOORDINATOR(string COORDINATOR)
        {
            return Index_COORDINATOR.Value[COORDINATOR];
        }

        /// <summary>
        /// Attempt to find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <param name="Value">List of related KSF entities</param>
        /// <returns>True if the list of related KSF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOORDINATOR(string COORDINATOR, out IReadOnlyList<KSF> Value)
        {
            return Index_COORDINATOR.Value.TryGetValue(COORDINATOR, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <returns>List of related KSF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSF> TryFindByCOORDINATOR(string COORDINATOR)
        {
            IReadOnlyList<KSF> value;
            if (Index_COORDINATOR.Value.TryGetValue(COORDINATOR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSF FindByKSFKEY(string KSFKEY)
        {
            return Index_KSFKEY.Value[KSFKEY];
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <param name="Value">Related KSF entity</param>
        /// <returns>True if the related KSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSFKEY(string KSFKEY, out KSF Value)
        {
            return Index_KSFKEY.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSF TryFindByKSFKEY(string KSFKEY)
        {
            KSF value;
            if (Index_KSFKEY.Value.TryGetValue(KSFKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSF](
        [KSFKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [COORDINATOR] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSF_Index_KSFKEY] PRIMARY KEY CLUSTERED (
            [KSFKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KSF_Index_COORDINATOR] ON [dbo].[KSF]
    (
            [COORDINATOR] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KSF]') AND name = N'KSF_Index_COORDINATOR')
    ALTER INDEX [KSF_Index_COORDINATOR] ON [dbo].[KSF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KSF]') AND name = N'KSF_Index_COORDINATOR')
    ALTER INDEX [KSF_Index_COORDINATOR] ON [dbo].[KSF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KSFKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KSFKEY.Add(entity.KSFKEY);
            }

            builder.AppendLine("DELETE [dbo].[KSF] WHERE");


            // Index_KSFKEY
            builder.Append("[KSFKEY] IN (");
            for (int index = 0; index < Index_KSFKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KSFKEY
                var parameterKSFKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKSFKEY);
                command.Parameters.Add(parameterKSFKEY, SqlDbType.VarChar, 10).Value = Index_KSFKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSF data set</returns>
        public override EduHubDataSetDataReader<KSF> GetDataSetDataReader()
        {
            return new KSFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSF data set</returns>
        public override EduHubDataSetDataReader<KSF> GetDataSetDataReader(List<KSF> Entities)
        {
            return new KSFDataReader(new EduHubDataSetLoadedReader<KSF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSFDataReader : EduHubDataSetDataReader<KSF>
        {
            public KSFDataReader(IEduHubDataSetReader<KSF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KSFKEY
                        return Current.KSFKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // COORDINATOR
                        return Current.COORDINATOR;
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
                    case 2: // COORDINATOR
                        return Current.COORDINATOR == null;
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
                    case 0: // KSFKEY
                        return "KSFKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // COORDINATOR
                        return "COORDINATOR";
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
                    case "KSFKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "COORDINATOR":
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
