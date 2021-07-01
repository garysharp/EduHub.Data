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
    /// Religions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGRDataSet : EduHubDataSet<KGR>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RELIGION = new Lazy<Dictionary<string, KGR>>(() => this.ToDictionary(i => i.RELIGION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGR" /> fields for each CSV column header</returns>
        internal override Action<KGR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
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
        /// Merges <see cref="KGR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGR}"/> of entities</returns>
        internal override IEnumerable<KGR> ApplyDeltaEntities(IEnumerable<KGR> Entities, List<KGR> DeltaEntities)
        {
            HashSet<string> Index_RELIGION = new HashSet<string>(DeltaEntities.Select(i => i.RELIGION));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.RELIGION;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_RELIGION.Remove(entity.RELIGION);
                            
                            if (entity.RELIGION.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGR>> Index_RELIGION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGR FindByRELIGION(string RELIGION)
        {
            return Index_RELIGION.Value[RELIGION];
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <param name="Value">Related KGR entity</param>
        /// <returns>True if the related KGR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELIGION(string RELIGION, out KGR Value)
        {
            return Index_RELIGION.Value.TryGetValue(RELIGION, out Value);
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGR TryFindByRELIGION(string RELIGION)
        {
            KGR value;
            if (Index_RELIGION.Value.TryGetValue(RELIGION, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGR](
        [RELIGION] varchar(12) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGR_Index_RELIGION] PRIMARY KEY CLUSTERED (
            [RELIGION] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_RELIGION = new List<string>();

            foreach (var entity in Entities)
            {
                Index_RELIGION.Add(entity.RELIGION);
            }

            builder.AppendLine("DELETE [dbo].[KGR] WHERE");


            // Index_RELIGION
            builder.Append("[RELIGION] IN (");
            for (int index = 0; index < Index_RELIGION.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // RELIGION
                var parameterRELIGION = $"@p{parameterIndex++}";
                builder.Append(parameterRELIGION);
                command.Parameters.Add(parameterRELIGION, SqlDbType.VarChar, 12).Value = Index_RELIGION[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGR data set</returns>
        public override EduHubDataSetDataReader<KGR> GetDataSetDataReader()
        {
            return new KGRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGR data set</returns>
        public override EduHubDataSetDataReader<KGR> GetDataSetDataReader(List<KGR> Entities)
        {
            return new KGRDataReader(new EduHubDataSetLoadedReader<KGR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGRDataReader : EduHubDataSetDataReader<KGR>
        {
            public KGRDataReader(IEduHubDataSetReader<KGR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // RELIGION
                        return Current.RELIGION;
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
                    case 0: // RELIGION
                        return "RELIGION";
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
                    case "RELIGION":
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
