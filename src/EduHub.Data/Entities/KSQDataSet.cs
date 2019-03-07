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
    /// Available Qualifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSQDataSet : EduHubDataSet<KSQ>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSQ"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSQKEY = new Lazy<Dictionary<string, KSQ>>(() => this.ToDictionary(i => i.KSQKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSQ" /> fields for each CSV column header</returns>
        internal override Action<KSQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSQKEY":
                        mapper[i] = (e, v) => e.KSQKEY = v;
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
        /// Merges <see cref="KSQ" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSQ" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSQ" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSQ}"/> of entities</returns>
        internal override IEnumerable<KSQ> ApplyDeltaEntities(IEnumerable<KSQ> Entities, List<KSQ> DeltaEntities)
        {
            HashSet<string> Index_KSQKEY = new HashSet<string>(DeltaEntities.Select(i => i.KSQKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KSQKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KSQKEY.Remove(entity.KSQKEY);
                            
                            if (entity.KSQKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KSQ>> Index_KSQKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSQ FindByKSQKEY(string KSQKEY)
        {
            return Index_KSQKEY.Value[KSQKEY];
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <param name="Value">Related KSQ entity</param>
        /// <returns>True if the related KSQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSQKEY(string KSQKEY, out KSQ Value)
        {
            return Index_KSQKEY.Value.TryGetValue(KSQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSQ TryFindByKSQKEY(string KSQKEY)
        {
            KSQ value;
            if (Index_KSQKEY.Value.TryGetValue(KSQKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSQ](
        [KSQKEY] varchar(30) NOT NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSQ_Index_KSQKEY] PRIMARY KEY CLUSTERED (
            [KSQKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KSQDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KSQDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSQ"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSQ"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSQ> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KSQKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KSQKEY.Add(entity.KSQKEY);
            }

            builder.AppendLine("DELETE [dbo].[KSQ] WHERE");


            // Index_KSQKEY
            builder.Append("[KSQKEY] IN (");
            for (int index = 0; index < Index_KSQKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KSQKEY
                var parameterKSQKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKSQKEY);
                command.Parameters.Add(parameterKSQKEY, SqlDbType.VarChar, 30).Value = Index_KSQKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSQ data set</returns>
        public override EduHubDataSetDataReader<KSQ> GetDataSetDataReader()
        {
            return new KSQDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSQ data set</returns>
        public override EduHubDataSetDataReader<KSQ> GetDataSetDataReader(List<KSQ> Entities)
        {
            return new KSQDataReader(new EduHubDataSetLoadedReader<KSQ>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSQDataReader : EduHubDataSetDataReader<KSQ>
        {
            public KSQDataReader(IEduHubDataSetReader<KSQ> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KSQKEY
                        return Current.KSQKEY;
                    case 1: // LW_DATE
                        return Current.LW_DATE;
                    case 2: // LW_TIME
                        return Current.LW_TIME;
                    case 3: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LW_DATE
                        return Current.LW_DATE == null;
                    case 2: // LW_TIME
                        return Current.LW_TIME == null;
                    case 3: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KSQKEY
                        return "KSQKEY";
                    case 1: // LW_DATE
                        return "LW_DATE";
                    case 2: // LW_TIME
                        return "LW_TIME";
                    case 3: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KSQKEY":
                        return 0;
                    case "LW_DATE":
                        return 1;
                    case "LW_TIME":
                        return 2;
                    case "LW_USER":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
