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
    /// Trade Type Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTTDataSet : EduHubDataSet<KTT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KTT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KTTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KTTKEY = new Lazy<Dictionary<string, KTT>>(() => this.ToDictionary(i => i.KTTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTT" /> fields for each CSV column header</returns>
        internal override Action<KTT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KTTKEY":
                        mapper[i] = (e, v) => e.KTTKEY = v;
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
        /// Merges <see cref="KTT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KTT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KTT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KTT}"/> of entities</returns>
        internal override IEnumerable<KTT> ApplyDeltaEntities(IEnumerable<KTT> Entities, List<KTT> DeltaEntities)
        {
            HashSet<string> Index_KTTKEY = new HashSet<string>(DeltaEntities.Select(i => i.KTTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KTTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KTTKEY.Remove(entity.KTTKEY);
                            
                            if (entity.KTTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KTT>> Index_KTTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTT by KTTKEY field
        /// </summary>
        /// <param name="KTTKEY">KTTKEY value used to find KTT</param>
        /// <returns>Related KTT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTT FindByKTTKEY(string KTTKEY)
        {
            return Index_KTTKEY.Value[KTTKEY];
        }

        /// <summary>
        /// Attempt to find KTT by KTTKEY field
        /// </summary>
        /// <param name="KTTKEY">KTTKEY value used to find KTT</param>
        /// <param name="Value">Related KTT entity</param>
        /// <returns>True if the related KTT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKTTKEY(string KTTKEY, out KTT Value)
        {
            return Index_KTTKEY.Value.TryGetValue(KTTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KTT by KTTKEY field
        /// </summary>
        /// <param name="KTTKEY">KTTKEY value used to find KTT</param>
        /// <returns>Related KTT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTT TryFindByKTTKEY(string KTTKEY)
        {
            KTT value;
            if (Index_KTTKEY.Value.TryGetValue(KTTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KTT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KTT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KTT](
        [KTTKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KTT_Index_KTTKEY] PRIMARY KEY CLUSTERED (
            [KTTKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KTTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KTTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KTT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KTT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KTT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KTTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KTTKEY.Add(entity.KTTKEY);
            }

            builder.AppendLine("DELETE [dbo].[KTT] WHERE");


            // Index_KTTKEY
            builder.Append("[KTTKEY] IN (");
            for (int index = 0; index < Index_KTTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KTTKEY
                var parameterKTTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKTTKEY);
                command.Parameters.Add(parameterKTTKEY, SqlDbType.VarChar, 10).Value = Index_KTTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTT data set</returns>
        public override EduHubDataSetDataReader<KTT> GetDataSetDataReader()
        {
            return new KTTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTT data set</returns>
        public override EduHubDataSetDataReader<KTT> GetDataSetDataReader(List<KTT> Entities)
        {
            return new KTTDataReader(new EduHubDataSetLoadedReader<KTT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KTTDataReader : EduHubDataSetDataReader<KTT>
        {
            public KTTDataReader(IEduHubDataSetReader<KTT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KTTKEY
                        return Current.KTTKEY;
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
                    case 0: // KTTKEY
                        return "KTTKEY";
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
                    case "KTTKEY":
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
