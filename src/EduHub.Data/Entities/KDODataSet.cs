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
    /// VELS Domains Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDODataSet : EduHubDataSet<KDO>
    {
        /// <inheritdoc />
        public override string Name { get { return "KDO"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KDODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KDOKEY = new Lazy<Dictionary<string, KDO>>(() => this.ToDictionary(i => i.KDOKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDO" /> fields for each CSV column header</returns>
        internal override Action<KDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AUSVELS_START":
                        mapper[i] = (e, v) => e.AUSVELS_START = v;
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
        /// Merges <see cref="KDO" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KDO" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KDO" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KDO}"/> of entities</returns>
        internal override IEnumerable<KDO> ApplyDeltaEntities(IEnumerable<KDO> Entities, List<KDO> DeltaEntities)
        {
            HashSet<string> Index_KDOKEY = new HashSet<string>(DeltaEntities.Select(i => i.KDOKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KDOKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KDOKEY.Remove(entity.KDOKEY);
                            
                            if (entity.KDOKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KDO>> Index_KDOKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDO FindByKDOKEY(string KDOKEY)
        {
            return Index_KDOKEY.Value[KDOKEY];
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <param name="Value">Related KDO entity</param>
        /// <returns>True if the related KDO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKDOKEY(string KDOKEY, out KDO Value)
        {
            return Index_KDOKEY.Value.TryGetValue(KDOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDO TryFindByKDOKEY(string KDOKEY)
        {
            KDO value;
            if (Index_KDOKEY.Value.TryGetValue(KDOKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KDO table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KDO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KDO](
        [KDOKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(255) NULL,
        [AUSVELS_START] varchar(6) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KDO_Index_KDOKEY] PRIMARY KEY CLUSTERED (
            [KDOKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KDODataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KDODataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KDO"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KDO"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KDO> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KDOKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KDOKEY.Add(entity.KDOKEY);
            }

            builder.AppendLine("DELETE [dbo].[KDO] WHERE");


            // Index_KDOKEY
            builder.Append("[KDOKEY] IN (");
            for (int index = 0; index < Index_KDOKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KDOKEY
                var parameterKDOKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKDOKEY);
                command.Parameters.Add(parameterKDOKEY, SqlDbType.VarChar, 10).Value = Index_KDOKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDO data set</returns>
        public override EduHubDataSetDataReader<KDO> GetDataSetDataReader()
        {
            return new KDODataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDO data set</returns>
        public override EduHubDataSetDataReader<KDO> GetDataSetDataReader(List<KDO> Entities)
        {
            return new KDODataReader(new EduHubDataSetLoadedReader<KDO>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KDODataReader : EduHubDataSetDataReader<KDO>
        {
            public KDODataReader(IEduHubDataSetReader<KDO> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KDOKEY
                        return Current.KDOKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // AUSVELS_START
                        return Current.AUSVELS_START;
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
                    case 2: // AUSVELS_START
                        return Current.AUSVELS_START == null;
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
                    case 0: // KDOKEY
                        return "KDOKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // AUSVELS_START
                        return "AUSVELS_START";
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
                    case "KDOKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "AUSVELS_START":
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
