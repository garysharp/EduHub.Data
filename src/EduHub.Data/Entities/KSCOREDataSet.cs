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
    /// Scores Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSCOREDataSet : EduHubDataSet<KSCORE>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSCORE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSCOREDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCORE = new Lazy<Dictionary<string, KSCORE>>(() => this.ToDictionary(i => i.SCORE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSCORE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSCORE" /> fields for each CSV column header</returns>
        internal override Action<KSCORE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSCORE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCORE":
                        mapper[i] = (e, v) => e.SCORE = v;
                        break;
                    case "EQUIVALENT":
                        mapper[i] = (e, v) => e.EQUIVALENT = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="KSCORE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSCORE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSCORE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSCORE}"/> of entities</returns>
        internal override IEnumerable<KSCORE> ApplyDeltaEntities(IEnumerable<KSCORE> Entities, List<KSCORE> DeltaEntities)
        {
            HashSet<string> Index_SCORE = new HashSet<string>(DeltaEntities.Select(i => i.SCORE));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCORE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCORE.Remove(entity.SCORE);
                            
                            if (entity.SCORE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KSCORE>> Index_SCORE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSCORE by SCORE field
        /// </summary>
        /// <param name="SCORE">SCORE value used to find KSCORE</param>
        /// <returns>Related KSCORE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSCORE FindBySCORE(string SCORE)
        {
            return Index_SCORE.Value[SCORE];
        }

        /// <summary>
        /// Attempt to find KSCORE by SCORE field
        /// </summary>
        /// <param name="SCORE">SCORE value used to find KSCORE</param>
        /// <param name="Value">Related KSCORE entity</param>
        /// <returns>True if the related KSCORE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCORE(string SCORE, out KSCORE Value)
        {
            return Index_SCORE.Value.TryGetValue(SCORE, out Value);
        }

        /// <summary>
        /// Attempt to find KSCORE by SCORE field
        /// </summary>
        /// <param name="SCORE">SCORE value used to find KSCORE</param>
        /// <returns>Related KSCORE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSCORE TryFindBySCORE(string SCORE)
        {
            KSCORE value;
            if (Index_SCORE.Value.TryGetValue(SCORE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSCORE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSCORE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSCORE](
        [SCORE] varchar(6) NOT NULL,
        [EQUIVALENT] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSCORE_Index_SCORE] PRIMARY KEY CLUSTERED (
            [SCORE] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KSCOREDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KSCOREDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSCORE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSCORE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSCORE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SCORE = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SCORE.Add(entity.SCORE);
            }

            builder.AppendLine("DELETE [dbo].[KSCORE] WHERE");


            // Index_SCORE
            builder.Append("[SCORE] IN (");
            for (int index = 0; index < Index_SCORE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCORE
                var parameterSCORE = $"@p{parameterIndex++}";
                builder.Append(parameterSCORE);
                command.Parameters.Add(parameterSCORE, SqlDbType.VarChar, 6).Value = Index_SCORE[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSCORE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSCORE data set</returns>
        public override EduHubDataSetDataReader<KSCORE> GetDataSetDataReader()
        {
            return new KSCOREDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSCORE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSCORE data set</returns>
        public override EduHubDataSetDataReader<KSCORE> GetDataSetDataReader(List<KSCORE> Entities)
        {
            return new KSCOREDataReader(new EduHubDataSetLoadedReader<KSCORE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSCOREDataReader : EduHubDataSetDataReader<KSCORE>
        {
            public KSCOREDataReader(IEduHubDataSetReader<KSCORE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCORE
                        return Current.SCORE;
                    case 1: // EQUIVALENT
                        return Current.EQUIVALENT;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // EQUIVALENT
                        return Current.EQUIVALENT == null;
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCORE
                        return "SCORE";
                    case 1: // EQUIVALENT
                        return "EQUIVALENT";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCORE":
                        return 0;
                    case "EQUIVALENT":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
