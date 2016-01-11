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
    /// Areas of Teaching Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSADataSet : EduHubDataSet<KSA>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSAKEY = new Lazy<Dictionary<string, KSA>>(() => this.ToDictionary(i => i.KSAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSA" /> fields for each CSV column header</returns>
        internal override Action<KSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSAKEY":
                        mapper[i] = (e, v) => e.KSAKEY = v;
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
        /// Merges <see cref="KSA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSA}"/> of entities</returns>
        internal override IEnumerable<KSA> ApplyDeltaEntities(IEnumerable<KSA> Entities, List<KSA> DeltaEntities)
        {
            HashSet<string> Index_KSAKEY = new HashSet<string>(DeltaEntities.Select(i => i.KSAKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KSAKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KSAKEY.Remove(entity.KSAKEY);
                            
                            if (entity.KSAKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KSA>> Index_KSAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSA by KSAKEY field
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSA FindByKSAKEY(string KSAKEY)
        {
            return Index_KSAKEY.Value[KSAKEY];
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY field
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find KSA</param>
        /// <param name="Value">Related KSA entity</param>
        /// <returns>True if the related KSA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSAKEY(string KSAKEY, out KSA Value)
        {
            return Index_KSAKEY.Value.TryGetValue(KSAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY field
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSA TryFindByKSAKEY(string KSAKEY)
        {
            KSA value;
            if (Index_KSAKEY.Value.TryGetValue(KSAKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSA](
        [KSAKEY] varchar(4) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSA_Index_KSAKEY] PRIMARY KEY CLUSTERED (
            [KSAKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KSADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KSADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KSAKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KSAKEY.Add(entity.KSAKEY);
            }

            builder.AppendLine("DELETE [dbo].[KSA] WHERE");


            // Index_KSAKEY
            builder.Append("[KSAKEY] IN (");
            for (int index = 0; index < Index_KSAKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KSAKEY
                var parameterKSAKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKSAKEY);
                command.Parameters.Add(parameterKSAKEY, SqlDbType.VarChar, 4).Value = Index_KSAKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSA data set</returns>
        public override EduHubDataSetDataReader<KSA> GetDataSetDataReader()
        {
            return new KSADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSA data set</returns>
        public override EduHubDataSetDataReader<KSA> GetDataSetDataReader(List<KSA> Entities)
        {
            return new KSADataReader(new EduHubDataSetLoadedReader<KSA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSADataReader : EduHubDataSetDataReader<KSA>
        {
            public KSADataReader(IEduHubDataSetReader<KSA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KSAKEY
                        return Current.KSAKEY;
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
                    case 0: // KSAKEY
                        return "KSAKEY";
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
                    case "KSAKEY":
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
