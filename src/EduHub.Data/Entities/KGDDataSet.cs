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
    /// Year 9-12 Exit Destinations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGDDataSet : EduHubDataSet<KGD>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal KGDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGDKEY = new Lazy<Dictionary<string, KGD>>(() => this.ToDictionary(i => i.KGDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGD" /> fields for each CSV column header</returns>
        internal override Action<KGD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGDKEY":
                        mapper[i] = (e, v) => e.KGDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
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
        /// Merges <see cref="KGD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGD}"/> of entities</returns>
        internal override IEnumerable<KGD> ApplyDeltaEntities(IEnumerable<KGD> Entities, List<KGD> DeltaEntities)
        {
            HashSet<string> Index_KGDKEY = new HashSet<string>(DeltaEntities.Select(i => i.KGDKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGDKEY.Remove(entity.KGDKEY);
                            
                            if (entity.KGDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGD>> Index_KGDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGD FindByKGDKEY(string KGDKEY)
        {
            return Index_KGDKEY.Value[KGDKEY];
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <param name="Value">Related KGD entity</param>
        /// <returns>True if the related KGD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGDKEY(string KGDKEY, out KGD Value)
        {
            return Index_KGDKEY.Value.TryGetValue(KGDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGD TryFindByKGDKEY(string KGDKEY)
        {
            KGD value;
            if (Index_KGDKEY.Value.TryGetValue(KGDKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGD](
        [KGDKEY] varchar(6) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [CATEGORY] varchar(50) NULL,
        [OPEN_CLOSED] varchar(1) NULL,
        CONSTRAINT [KGD_Index_KGDKEY] PRIMARY KEY CLUSTERED (
            [KGDKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KGDKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KGDKEY.Add(entity.KGDKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGD] WHERE");


            // Index_KGDKEY
            builder.Append("[KGDKEY] IN (");
            for (int index = 0; index < Index_KGDKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGDKEY
                var parameterKGDKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGDKEY);
                command.Parameters.Add(parameterKGDKEY, SqlDbType.VarChar, 6).Value = Index_KGDKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGD data set</returns>
        public override EduHubDataSetDataReader<KGD> GetDataSetDataReader()
        {
            return new KGDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGD data set</returns>
        public override EduHubDataSetDataReader<KGD> GetDataSetDataReader(List<KGD> Entities)
        {
            return new KGDDataReader(new EduHubDataSetLoadedReader<KGD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGDDataReader : EduHubDataSetDataReader<KGD>
        {
            public KGDDataReader(IEduHubDataSetReader<KGD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGDKEY
                        return Current.KGDKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // CATEGORY
                        return Current.CATEGORY;
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
                    case 2: // CATEGORY
                        return Current.CATEGORY == null;
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
                    case 0: // KGDKEY
                        return "KGDKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // CATEGORY
                        return "CATEGORY";
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
                    case "KGDKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "CATEGORY":
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
