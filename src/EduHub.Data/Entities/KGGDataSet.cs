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
    /// Year 9-12 Exit Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGGDataSet : EduHubDataSet<KGG>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal KGGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGGKEY = new Lazy<Dictionary<string, KGG>>(() => this.ToDictionary(i => i.KGGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGG" /> fields for each CSV column header</returns>
        internal override Action<KGG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGGKEY":
                        mapper[i] = (e, v) => e.KGGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "EDFLAG_ORDER":
                        mapper[i] = (e, v) => e.EDFLAG_ORDER = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KGG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGG}"/> of entities</returns>
        internal override IEnumerable<KGG> ApplyDeltaEntities(IEnumerable<KGG> Entities, List<KGG> DeltaEntities)
        {
            HashSet<string> Index_KGGKEY = new HashSet<string>(DeltaEntities.Select(i => i.KGGKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGGKEY.Remove(entity.KGGKEY);
                            
                            if (entity.KGGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGG>> Index_KGGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGG FindByKGGKEY(string KGGKEY)
        {
            return Index_KGGKEY.Value[KGGKEY];
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <param name="Value">Related KGG entity</param>
        /// <returns>True if the related KGG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGGKEY(string KGGKEY, out KGG Value)
        {
            return Index_KGGKEY.Value.TryGetValue(KGGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGG TryFindByKGGKEY(string KGGKEY)
        {
            KGG value;
            if (Index_KGGKEY.Value.TryGetValue(KGGKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGG](
        [KGGKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [EDFLAG_ORDER] varchar(2) NULL,
        [OPEN_CLOSED] varchar(1) NULL,
        CONSTRAINT [KGG_Index_KGGKEY] PRIMARY KEY CLUSTERED (
            [KGGKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KGGKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KGGKEY.Add(entity.KGGKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGG] WHERE");


            // Index_KGGKEY
            builder.Append("[KGGKEY] IN (");
            for (int index = 0; index < Index_KGGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGGKEY
                var parameterKGGKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGGKEY);
                command.Parameters.Add(parameterKGGKEY, SqlDbType.VarChar, 2).Value = Index_KGGKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGG data set</returns>
        public override EduHubDataSetDataReader<KGG> GetDataSetDataReader()
        {
            return new KGGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGG data set</returns>
        public override EduHubDataSetDataReader<KGG> GetDataSetDataReader(List<KGG> Entities)
        {
            return new KGGDataReader(new EduHubDataSetLoadedReader<KGG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGGDataReader : EduHubDataSetDataReader<KGG>
        {
            public KGGDataReader(IEduHubDataSetReader<KGG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGGKEY
                        return Current.KGGKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // EDFLAG_ORDER
                        return Current.EDFLAG_ORDER;
                    case 3: // OPEN_CLOSED
                        return Current.OPEN_CLOSED;
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
                    case 2: // EDFLAG_ORDER
                        return Current.EDFLAG_ORDER == null;
                    case 3: // OPEN_CLOSED
                        return Current.OPEN_CLOSED == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGGKEY
                        return "KGGKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // EDFLAG_ORDER
                        return "EDFLAG_ORDER";
                    case 3: // OPEN_CLOSED
                        return "OPEN_CLOSED";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGGKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "EDFLAG_ORDER":
                        return 2;
                    case "OPEN_CLOSED":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
