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
    /// Street Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSTREETDataSet : EduHubDataSet<KSTREET>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSTREET"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSTREETDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSTREET = new Lazy<Dictionary<string, KSTREET>>(() => this.ToDictionary(i => i._KSTREET));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSTREET" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSTREET" /> fields for each CSV column header</returns>
        internal override Action<KSTREET, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSTREET, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSTREET":
                        mapper[i] = (e, v) => e._KSTREET = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KSTREET" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSTREET" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSTREET" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSTREET}"/> of entities</returns>
        internal override IEnumerable<KSTREET> ApplyDeltaEntities(IEnumerable<KSTREET> Entities, List<KSTREET> DeltaEntities)
        {
            HashSet<string> Index_KSTREET = new HashSet<string>(DeltaEntities.Select(i => i._KSTREET));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current._KSTREET;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KSTREET.Remove(entity._KSTREET);
                            
                            if (entity._KSTREET.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KSTREET>> Index_KSTREET;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSTREET by KSTREET field
        /// </summary>
        /// <param name="KSTREET">KSTREET value used to find KSTREET</param>
        /// <returns>Related KSTREET entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSTREET FindByKSTREET(string KSTREET)
        {
            return Index_KSTREET.Value[KSTREET];
        }

        /// <summary>
        /// Attempt to find KSTREET by KSTREET field
        /// </summary>
        /// <param name="KSTREET">KSTREET value used to find KSTREET</param>
        /// <param name="Value">Related KSTREET entity</param>
        /// <returns>True if the related KSTREET entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSTREET(string KSTREET, out KSTREET Value)
        {
            return Index_KSTREET.Value.TryGetValue(KSTREET, out Value);
        }

        /// <summary>
        /// Attempt to find KSTREET by KSTREET field
        /// </summary>
        /// <param name="KSTREET">KSTREET value used to find KSTREET</param>
        /// <returns>Related KSTREET entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSTREET TryFindByKSTREET(string KSTREET)
        {
            KSTREET value;
            if (Index_KSTREET.Value.TryGetValue(KSTREET, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSTREET table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSTREET]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSTREET](
        [KSTREET] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSTREET_Index_KSTREET] PRIMARY KEY CLUSTERED (
            [KSTREET] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KSTREETDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KSTREETDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSTREET"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSTREET"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSTREET> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KSTREET = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KSTREET.Add(entity._KSTREET);
            }

            builder.AppendLine("DELETE [dbo].[KSTREET] WHERE");


            // Index_KSTREET
            builder.Append("[KSTREET] IN (");
            for (int index = 0; index < Index_KSTREET.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KSTREET
                var parameterKSTREET = $"@p{parameterIndex++}";
                builder.Append(parameterKSTREET);
                command.Parameters.Add(parameterKSTREET, SqlDbType.VarChar, 10).Value = Index_KSTREET[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSTREET data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSTREET data set</returns>
        public override EduHubDataSetDataReader<KSTREET> GetDataSetDataReader()
        {
            return new KSTREETDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSTREET data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSTREET data set</returns>
        public override EduHubDataSetDataReader<KSTREET> GetDataSetDataReader(List<KSTREET> Entities)
        {
            return new KSTREETDataReader(new EduHubDataSetLoadedReader<KSTREET>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSTREETDataReader : EduHubDataSetDataReader<KSTREET>
        {
            public KSTREETDataReader(IEduHubDataSetReader<KSTREET> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // _KSTREET
                        return Current._KSTREET;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
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
                    case 0: // KSTREET
                        return "KSTREET";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
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
                    case "KSTREET":
                        return 0;
                    case "DESCRIPTION":
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
