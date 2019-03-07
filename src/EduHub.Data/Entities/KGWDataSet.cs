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
    /// Awards and Prizes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGWDataSet : EduHubDataSet<KGW>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGW"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AWARD = new Lazy<Dictionary<string, KGW>>(() => this.ToDictionary(i => i.AWARD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGW" /> fields for each CSV column header</returns>
        internal override Action<KGW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KGW" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGW" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGW" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGW}"/> of entities</returns>
        internal override IEnumerable<KGW> ApplyDeltaEntities(IEnumerable<KGW> Entities, List<KGW> DeltaEntities)
        {
            HashSet<string> Index_AWARD = new HashSet<string>(DeltaEntities.Select(i => i.AWARD));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.AWARD;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_AWARD.Remove(entity.AWARD);
                            
                            if (entity.AWARD.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGW>> Index_AWARD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGW by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGW FindByAWARD(string AWARD)
        {
            return Index_AWARD.Value[AWARD];
        }

        /// <summary>
        /// Attempt to find KGW by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find KGW</param>
        /// <param name="Value">Related KGW entity</param>
        /// <returns>True if the related KGW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAWARD(string AWARD, out KGW Value)
        {
            return Index_AWARD.Value.TryGetValue(AWARD, out Value);
        }

        /// <summary>
        /// Attempt to find KGW by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGW TryFindByAWARD(string AWARD)
        {
            KGW value;
            if (Index_AWARD.Value.TryGetValue(AWARD, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGW table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGW]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGW](
        [AWARD] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGW_Index_AWARD] PRIMARY KEY CLUSTERED (
            [AWARD] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGWDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGWDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGW"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGW"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGW> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_AWARD = new List<string>();

            foreach (var entity in Entities)
            {
                Index_AWARD.Add(entity.AWARD);
            }

            builder.AppendLine("DELETE [dbo].[KGW] WHERE");


            // Index_AWARD
            builder.Append("[AWARD] IN (");
            for (int index = 0; index < Index_AWARD.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // AWARD
                var parameterAWARD = $"@p{parameterIndex++}";
                builder.Append(parameterAWARD);
                command.Parameters.Add(parameterAWARD, SqlDbType.VarChar, 10).Value = Index_AWARD[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGW data set</returns>
        public override EduHubDataSetDataReader<KGW> GetDataSetDataReader()
        {
            return new KGWDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGW data set</returns>
        public override EduHubDataSetDataReader<KGW> GetDataSetDataReader(List<KGW> Entities)
        {
            return new KGWDataReader(new EduHubDataSetLoadedReader<KGW>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGWDataReader : EduHubDataSetDataReader<KGW>
        {
            public KGWDataReader(IEduHubDataSetReader<KGW> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // AWARD
                        return Current.AWARD;
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
                    case 0: // AWARD
                        return "AWARD";
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
                    case "AWARD":
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
