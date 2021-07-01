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
    /// FTE Student Retentions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SRAGDataSet : EduHubDataSet<SRAG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SRAG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SRAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SRAG_ID = new Lazy<Dictionary<int, SRAG>>(() => this.ToDictionary(i => i.SRAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SRAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SRAG" /> fields for each CSV column header</returns>
        internal override Action<SRAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SRAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SRAG_ID":
                        mapper[i] = (e, v) => e.SRAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "RETENTION":
                        mapper[i] = (e, v) => e.RETENTION = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SRAG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SRAG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SRAG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SRAG}"/> of entities</returns>
        internal override IEnumerable<SRAG> ApplyDeltaEntities(IEnumerable<SRAG> Entities, List<SRAG> DeltaEntities)
        {
            HashSet<int> Index_SRAG_ID = new HashSet<int>(DeltaEntities.Select(i => i.SRAG_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SRAG_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SRAG_ID.Remove(entity.SRAG_ID);
                            
                            if (entity.SRAG_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SRAG>> Index_SRAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SRAG FindBySRAG_ID(int SRAG_ID)
        {
            return Index_SRAG_ID.Value[SRAG_ID];
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <param name="Value">Related SRAG entity</param>
        /// <returns>True if the related SRAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySRAG_ID(int SRAG_ID, out SRAG Value)
        {
            return Index_SRAG_ID.Value.TryGetValue(SRAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SRAG TryFindBySRAG_ID(int SRAG_ID)
        {
            SRAG value;
            if (Index_SRAG_ID.Value.TryGetValue(SRAG_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SRAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SRAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SRAG](
        [SRAG_ID] int IDENTITY NOT NULL,
        [BRY] smallint NULL,
        [PERIOD] varchar(20) NULL,
        [RETENTION] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SRAG_Index_SRAG_ID] PRIMARY KEY CLUSTERED (
            [SRAG_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SRAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SRAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SRAG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SRAG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SRAG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SRAG_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SRAG_ID.Add(entity.SRAG_ID);
            }

            builder.AppendLine("DELETE [dbo].[SRAG] WHERE");


            // Index_SRAG_ID
            builder.Append("[SRAG_ID] IN (");
            for (int index = 0; index < Index_SRAG_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SRAG_ID
                var parameterSRAG_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSRAG_ID);
                command.Parameters.Add(parameterSRAG_ID, SqlDbType.Int).Value = Index_SRAG_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SRAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SRAG data set</returns>
        public override EduHubDataSetDataReader<SRAG> GetDataSetDataReader()
        {
            return new SRAGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SRAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SRAG data set</returns>
        public override EduHubDataSetDataReader<SRAG> GetDataSetDataReader(List<SRAG> Entities)
        {
            return new SRAGDataReader(new EduHubDataSetLoadedReader<SRAG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SRAGDataReader : EduHubDataSetDataReader<SRAG>
        {
            public SRAGDataReader(IEduHubDataSetReader<SRAG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SRAG_ID
                        return Current.SRAG_ID;
                    case 1: // BRY
                        return Current.BRY;
                    case 2: // PERIOD
                        return Current.PERIOD;
                    case 3: // RETENTION
                        return Current.RETENTION;
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
                    case 1: // BRY
                        return Current.BRY == null;
                    case 2: // PERIOD
                        return Current.PERIOD == null;
                    case 3: // RETENTION
                        return Current.RETENTION == null;
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
                    case 0: // SRAG_ID
                        return "SRAG_ID";
                    case 1: // BRY
                        return "BRY";
                    case 2: // PERIOD
                        return "PERIOD";
                    case 3: // RETENTION
                        return "RETENTION";
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
                    case "SRAG_ID":
                        return 0;
                    case "BRY":
                        return 1;
                    case "PERIOD":
                        return 2;
                    case "RETENTION":
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
