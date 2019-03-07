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
    /// Timetable Import Errors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTIEDataSet : EduHubDataSet<KTIE>
    {
        /// <inheritdoc />
        public override string Name { get { return "KTIE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal KTIEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RECORD_ID = new Lazy<Dictionary<int, KTIE>>(() => this.ToDictionary(i => i.RECORD_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTIE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTIE" /> fields for each CSV column header</returns>
        internal override Action<KTIE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTIE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RECORD_ID":
                        mapper[i] = (e, v) => e.RECORD_ID = int.Parse(v);
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KTIE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KTIE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KTIE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KTIE}"/> of entities</returns>
        internal override IEnumerable<KTIE> ApplyDeltaEntities(IEnumerable<KTIE> Entities, List<KTIE> DeltaEntities)
        {
            HashSet<int> Index_RECORD_ID = new HashSet<int>(DeltaEntities.Select(i => i.RECORD_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.RECORD_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_RECORD_ID.Remove(entity.RECORD_ID);
                            
                            if (entity.RECORD_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KTIE>> Index_RECORD_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTIE FindByRECORD_ID(int RECORD_ID)
        {
            return Index_RECORD_ID.Value[RECORD_ID];
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <param name="Value">Related KTIE entity</param>
        /// <returns>True if the related KTIE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRECORD_ID(int RECORD_ID, out KTIE Value)
        {
            return Index_RECORD_ID.Value.TryGetValue(RECORD_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTIE TryFindByRECORD_ID(int RECORD_ID)
        {
            KTIE value;
            if (Index_RECORD_ID.Value.TryGetValue(RECORD_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KTIE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KTIE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KTIE](
        [RECORD_ID] int IDENTITY NOT NULL,
        [ENTITY] varchar(2) NULL,
        [ENTITY_KEY] varchar(20) NULL,
        [ERROR_TEXT] varchar(60) NULL,
        CONSTRAINT [KTIE_Index_RECORD_ID] PRIMARY KEY CLUSTERED (
            [RECORD_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KTIEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KTIEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KTIE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KTIE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KTIE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_RECORD_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_RECORD_ID.Add(entity.RECORD_ID);
            }

            builder.AppendLine("DELETE [dbo].[KTIE] WHERE");


            // Index_RECORD_ID
            builder.Append("[RECORD_ID] IN (");
            for (int index = 0; index < Index_RECORD_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // RECORD_ID
                var parameterRECORD_ID = $"@p{parameterIndex++}";
                builder.Append(parameterRECORD_ID);
                command.Parameters.Add(parameterRECORD_ID, SqlDbType.Int).Value = Index_RECORD_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTIE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTIE data set</returns>
        public override EduHubDataSetDataReader<KTIE> GetDataSetDataReader()
        {
            return new KTIEDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTIE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTIE data set</returns>
        public override EduHubDataSetDataReader<KTIE> GetDataSetDataReader(List<KTIE> Entities)
        {
            return new KTIEDataReader(new EduHubDataSetLoadedReader<KTIE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KTIEDataReader : EduHubDataSetDataReader<KTIE>
        {
            public KTIEDataReader(IEduHubDataSetReader<KTIE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // RECORD_ID
                        return Current.RECORD_ID;
                    case 1: // ENTITY
                        return Current.ENTITY;
                    case 2: // ENTITY_KEY
                        return Current.ENTITY_KEY;
                    case 3: // ERROR_TEXT
                        return Current.ERROR_TEXT;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ENTITY
                        return Current.ENTITY == null;
                    case 2: // ENTITY_KEY
                        return Current.ENTITY_KEY == null;
                    case 3: // ERROR_TEXT
                        return Current.ERROR_TEXT == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // RECORD_ID
                        return "RECORD_ID";
                    case 1: // ENTITY
                        return "ENTITY";
                    case 2: // ENTITY_KEY
                        return "ENTITY_KEY";
                    case 3: // ERROR_TEXT
                        return "ERROR_TEXT";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "RECORD_ID":
                        return 0;
                    case "ENTITY":
                        return 1;
                    case "ENTITY_KEY":
                        return 2;
                    case "ERROR_TEXT":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
