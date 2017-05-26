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
    /// Standard Disciplinary Actions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAMDataSet : EduHubDataSet<KAM>
    {
        /// <inheritdoc />
        public override string Name { get { return "KAM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KAMKEY = new Lazy<Dictionary<string, KAM>>(() => this.ToDictionary(i => i.KAMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAM" /> fields for each CSV column header</returns>
        internal override Action<KAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAMKEY":
                        mapper[i] = (e, v) => e.KAMKEY = v;
                        break;
                    case "BRIEF":
                        mapper[i] = (e, v) => e.BRIEF = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
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
        /// Merges <see cref="KAM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KAM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KAM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KAM}"/> of entities</returns>
        internal override IEnumerable<KAM> ApplyDeltaEntities(IEnumerable<KAM> Entities, List<KAM> DeltaEntities)
        {
            HashSet<string> Index_KAMKEY = new HashSet<string>(DeltaEntities.Select(i => i.KAMKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KAMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KAMKEY.Remove(entity.KAMKEY);
                            
                            if (entity.KAMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KAM>> Index_KAMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAM FindByKAMKEY(string KAMKEY)
        {
            return Index_KAMKEY.Value[KAMKEY];
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <param name="Value">Related KAM entity</param>
        /// <returns>True if the related KAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKAMKEY(string KAMKEY, out KAM Value)
        {
            return Index_KAMKEY.Value.TryGetValue(KAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAM TryFindByKAMKEY(string KAMKEY)
        {
            KAM value;
            if (Index_KAMKEY.Value.TryGetValue(KAMKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAM](
        [KAMKEY] varchar(5) NOT NULL,
        [BRIEF] varchar(40) NULL,
        [DETAIL] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAM_Index_KAMKEY] PRIMARY KEY CLUSTERED (
            [KAMKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KAMDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KAMDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KAM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KAM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KAM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KAMKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KAMKEY.Add(entity.KAMKEY);
            }

            builder.AppendLine("DELETE [dbo].[KAM] WHERE");


            // Index_KAMKEY
            builder.Append("[KAMKEY] IN (");
            for (int index = 0; index < Index_KAMKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KAMKEY
                var parameterKAMKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKAMKEY);
                command.Parameters.Add(parameterKAMKEY, SqlDbType.VarChar, 5).Value = Index_KAMKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAM data set</returns>
        public override EduHubDataSetDataReader<KAM> GetDataSetDataReader()
        {
            return new KAMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAM data set</returns>
        public override EduHubDataSetDataReader<KAM> GetDataSetDataReader(List<KAM> Entities)
        {
            return new KAMDataReader(new EduHubDataSetLoadedReader<KAM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KAMDataReader : EduHubDataSetDataReader<KAM>
        {
            public KAMDataReader(IEduHubDataSetReader<KAM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KAMKEY
                        return Current.KAMKEY;
                    case 1: // BRIEF
                        return Current.BRIEF;
                    case 2: // DETAIL
                        return Current.DETAIL;
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
                    case 1: // BRIEF
                        return Current.BRIEF == null;
                    case 2: // DETAIL
                        return Current.DETAIL == null;
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
                    case 0: // KAMKEY
                        return "KAMKEY";
                    case 1: // BRIEF
                        return "BRIEF";
                    case 2: // DETAIL
                        return "DETAIL";
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
                    case "KAMKEY":
                        return 0;
                    case "BRIEF":
                        return 1;
                    case "DETAIL":
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
