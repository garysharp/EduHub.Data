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
    /// Calendar Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCDataSet : EduHubDataSet<TC>
    {
        /// <inheritdoc />
        public override string Name { get { return "TC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCKEY = new Lazy<Dictionary<DateTime, TC>>(() => this.ToDictionary(i => i.TCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TC" /> fields for each CSV column header</returns>
        internal override Action<TC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCKEY":
                        mapper[i] = (e, v) => e.TCKEY = DateTime.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DAY_COMMENT":
                        mapper[i] = (e, v) => e.DAY_COMMENT = v;
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
        /// Merges <see cref="TC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TC}"/> of entities</returns>
        internal override IEnumerable<TC> ApplyDeltaEntities(IEnumerable<TC> Entities, List<TC> DeltaEntities)
        {
            HashSet<DateTime> Index_TCKEY = new HashSet<DateTime>(DeltaEntities.Select(i => i.TCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TCKEY.Remove(entity.TCKEY);
                            
                            if (entity.TCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<DateTime, TC>> Index_TCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <returns>Related TC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TC FindByTCKEY(DateTime TCKEY)
        {
            return Index_TCKEY.Value[TCKEY];
        }

        /// <summary>
        /// Attempt to find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <param name="Value">Related TC entity</param>
        /// <returns>True if the related TC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCKEY(DateTime TCKEY, out TC Value)
        {
            return Index_TCKEY.Value.TryGetValue(TCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <returns>Related TC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TC TryFindByTCKEY(DateTime TCKEY)
        {
            TC value;
            if (Index_TCKEY.Value.TryGetValue(TCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TC](
        [TCKEY] datetime NOT NULL,
        [TITLE] varchar(30) NULL,
        [DAY_COMMENT] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TC_Index_TCKEY] PRIMARY KEY CLUSTERED (
            [TCKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="TCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="TCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<DateTime> Index_TCKEY = new List<DateTime>();

            foreach (var entity in Entities)
            {
                Index_TCKEY.Add(entity.TCKEY);
            }

            builder.AppendLine("DELETE [dbo].[TC] WHERE");


            // Index_TCKEY
            builder.Append("[TCKEY] IN (");
            for (int index = 0; index < Index_TCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TCKEY
                var parameterTCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterTCKEY);
                command.Parameters.Add(parameterTCKEY, SqlDbType.DateTime).Value = Index_TCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TC data set</returns>
        public override EduHubDataSetDataReader<TC> GetDataSetDataReader()
        {
            return new TCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TC data set</returns>
        public override EduHubDataSetDataReader<TC> GetDataSetDataReader(List<TC> Entities)
        {
            return new TCDataReader(new EduHubDataSetLoadedReader<TC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCDataReader : EduHubDataSetDataReader<TC>
        {
            public TCDataReader(IEduHubDataSetReader<TC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TCKEY
                        return Current.TCKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // DAY_COMMENT
                        return Current.DAY_COMMENT;
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
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // DAY_COMMENT
                        return Current.DAY_COMMENT == null;
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
                    case 0: // TCKEY
                        return "TCKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // DAY_COMMENT
                        return "DAY_COMMENT";
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
                    case "TCKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "DAY_COMMENT":
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
