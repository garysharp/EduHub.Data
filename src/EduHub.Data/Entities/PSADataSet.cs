#if !EduHubScoped
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
    /// Award Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSADataSet : EduHubDataSet<PSA>
    {
        /// <inheritdoc />
        public override string Name { get { return "PSA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PSADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSAKEY = new Lazy<Dictionary<string, PSA>>(() => this.ToDictionary(i => i.PSAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSA" /> fields for each CSV column header</returns>
        internal override Action<PSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSAKEY":
                        mapper[i] = (e, v) => e.PSAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AWARD_TYPE":
                        mapper[i] = (e, v) => e.AWARD_TYPE = v;
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
        /// Merges <see cref="PSA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PSA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PSA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PSA}"/> of entities</returns>
        internal override IEnumerable<PSA> ApplyDeltaEntities(IEnumerable<PSA> Entities, List<PSA> DeltaEntities)
        {
            HashSet<string> Index_PSAKEY = new HashSet<string>(DeltaEntities.Select(i => i.PSAKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PSAKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PSAKEY.Remove(entity.PSAKEY);
                            
                            if (entity.PSAKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, PSA>> Index_PSAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSA FindByPSAKEY(string PSAKEY)
        {
            return Index_PSAKEY.Value[PSAKEY];
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <param name="Value">Related PSA entity</param>
        /// <returns>True if the related PSA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSAKEY(string PSAKEY, out PSA Value)
        {
            return Index_PSAKEY.Value.TryGetValue(PSAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSA TryFindByPSAKEY(string PSAKEY)
        {
            PSA value;
            if (Index_PSAKEY.Value.TryGetValue(PSAKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PSA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PSA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PSA](
        [PSAKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [AWARD_TYPE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PSA_Index_PSAKEY] PRIMARY KEY CLUSTERED (
            [PSAKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PSADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PSADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PSA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PSA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PSA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PSAKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PSAKEY.Add(entity.PSAKEY);
            }

            builder.AppendLine("DELETE [dbo].[PSA] WHERE");


            // Index_PSAKEY
            builder.Append("[PSAKEY] IN (");
            for (int index = 0; index < Index_PSAKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PSAKEY
                var parameterPSAKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPSAKEY);
                command.Parameters.Add(parameterPSAKEY, SqlDbType.VarChar, 10).Value = Index_PSAKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PSA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PSA data set</returns>
        public override EduHubDataSetDataReader<PSA> GetDataSetDataReader()
        {
            return new PSADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PSA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PSA data set</returns>
        public override EduHubDataSetDataReader<PSA> GetDataSetDataReader(List<PSA> Entities)
        {
            return new PSADataReader(new EduHubDataSetLoadedReader<PSA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PSADataReader : EduHubDataSetDataReader<PSA>
        {
            public PSADataReader(IEduHubDataSetReader<PSA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PSAKEY
                        return Current.PSAKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // AWARD_TYPE
                        return Current.AWARD_TYPE;
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
                    case 2: // AWARD_TYPE
                        return Current.AWARD_TYPE == null;
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
                    case 0: // PSAKEY
                        return "PSAKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // AWARD_TYPE
                        return "AWARD_TYPE";
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
                    case "PSAKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "AWARD_TYPE":
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
#endif
