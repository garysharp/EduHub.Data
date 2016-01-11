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
    /// Future Pay Steps or Pay Class Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSFDataSet : EduHubDataSet<PSF>
    {
        /// <inheritdoc />
        public override string Name { get { return "PSF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSKEY = new Lazy<Dictionary<short, IReadOnlyList<PSF>>>(() => this.ToGroupedDictionary(i => i.PSKEY));
            Index_TID = new Lazy<Dictionary<int, PSF>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSF" /> fields for each CSV column header</returns>
        internal override Action<PSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "EFFECTIVE_FROM_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EFFECTIVE_TO_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="PSF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PSF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PSF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PSF}"/> of entities</returns>
        internal override IEnumerable<PSF> ApplyDeltaEntities(IEnumerable<PSF> Entities, List<PSF> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.PSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<short, IReadOnlyList<PSF>>> Index_PSKEY;
        private Lazy<Dictionary<int, PSF>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <returns>List of related PSF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PSF> FindByPSKEY(short PSKEY)
        {
            return Index_PSKEY.Value[PSKEY];
        }

        /// <summary>
        /// Attempt to find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <param name="Value">List of related PSF entities</param>
        /// <returns>True if the list of related PSF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSKEY(short PSKEY, out IReadOnlyList<PSF> Value)
        {
            return Index_PSKEY.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <returns>List of related PSF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PSF> TryFindByPSKEY(short PSKEY)
        {
            IReadOnlyList<PSF> value;
            if (Index_PSKEY.Value.TryGetValue(PSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <returns>Related PSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <param name="Value">Related PSF entity</param>
        /// <returns>True if the related PSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PSF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <returns>Related PSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSF TryFindByTID(int TID)
        {
            PSF value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PSF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PSF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PSF](
        [TID] int IDENTITY NOT NULL,
        [PSKEY] smallint NOT NULL,
        [EFFECTIVE_FROM_DATE] datetime NULL,
        [EFFECTIVE_TO_DATE] datetime NULL,
        [ANNUAL_RATE] money NULL,
        [HOURLY_RATE] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PSF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PSF_Index_PSKEY] ON [dbo].[PSF]
    (
            [PSKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PSF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PSF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PSF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PSF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PSF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PSF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PSF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PSF] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PSF data set</returns>
        public override EduHubDataSetDataReader<PSF> GetDataSetDataReader()
        {
            return new PSFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PSF data set</returns>
        public override EduHubDataSetDataReader<PSF> GetDataSetDataReader(List<PSF> Entities)
        {
            return new PSFDataReader(new EduHubDataSetLoadedReader<PSF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PSFDataReader : EduHubDataSetDataReader<PSF>
        {
            public PSFDataReader(IEduHubDataSetReader<PSF> Reader)
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
                    case 1: // PSKEY
                        return Current.PSKEY;
                    case 2: // EFFECTIVE_FROM_DATE
                        return Current.EFFECTIVE_FROM_DATE;
                    case 3: // EFFECTIVE_TO_DATE
                        return Current.EFFECTIVE_TO_DATE;
                    case 4: // ANNUAL_RATE
                        return Current.ANNUAL_RATE;
                    case 5: // HOURLY_RATE
                        return Current.HOURLY_RATE;
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
                    case 2: // EFFECTIVE_FROM_DATE
                        return Current.EFFECTIVE_FROM_DATE == null;
                    case 3: // EFFECTIVE_TO_DATE
                        return Current.EFFECTIVE_TO_DATE == null;
                    case 4: // ANNUAL_RATE
                        return Current.ANNUAL_RATE == null;
                    case 5: // HOURLY_RATE
                        return Current.HOURLY_RATE == null;
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
                    case 1: // PSKEY
                        return "PSKEY";
                    case 2: // EFFECTIVE_FROM_DATE
                        return "EFFECTIVE_FROM_DATE";
                    case 3: // EFFECTIVE_TO_DATE
                        return "EFFECTIVE_TO_DATE";
                    case 4: // ANNUAL_RATE
                        return "ANNUAL_RATE";
                    case 5: // HOURLY_RATE
                        return "HOURLY_RATE";
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
                    case "PSKEY":
                        return 1;
                    case "EFFECTIVE_FROM_DATE":
                        return 2;
                    case "EFFECTIVE_TO_DATE":
                        return 3;
                    case "ANNUAL_RATE":
                        return 4;
                    case "HOURLY_RATE":
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
