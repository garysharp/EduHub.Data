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
    /// Assets - Sub-Category Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKBDataSet : EduHubDataSet<AKB>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BRANCH = new Lazy<Dictionary<string, AKB>>(() => this.ToDictionary(i => i.BRANCH));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKB" /> fields for each CSV column header</returns>
        internal override Action<AKB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BRANCH":
                        mapper[i] = (e, v) => e.BRANCH = v;
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
        /// Merges <see cref="AKB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKB}"/> of entities</returns>
        internal override IEnumerable<AKB> ApplyDeltaEntities(IEnumerable<AKB> Entities, List<AKB> DeltaEntities)
        {
            HashSet<string> Index_BRANCH = new HashSet<string>(DeltaEntities.Select(i => i.BRANCH));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BRANCH;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_BRANCH.Remove(entity.BRANCH);
                            
                            if (entity.BRANCH.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, AKB>> Index_BRANCH;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKB by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AKB</param>
        /// <returns>Related AKB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKB FindByBRANCH(string BRANCH)
        {
            return Index_BRANCH.Value[BRANCH];
        }

        /// <summary>
        /// Attempt to find AKB by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AKB</param>
        /// <param name="Value">Related AKB entity</param>
        /// <returns>True if the related AKB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBRANCH(string BRANCH, out AKB Value)
        {
            return Index_BRANCH.Value.TryGetValue(BRANCH, out Value);
        }

        /// <summary>
        /// Attempt to find AKB by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AKB</param>
        /// <returns>Related AKB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKB TryFindByBRANCH(string BRANCH)
        {
            AKB value;
            if (Index_BRANCH.Value.TryGetValue(BRANCH, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKB](
        [BRANCH] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKB_Index_BRANCH] PRIMARY KEY CLUSTERED (
            [BRANCH] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="AKBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="AKBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_BRANCH = new List<string>();

            foreach (var entity in Entities)
            {
                Index_BRANCH.Add(entity.BRANCH);
            }

            builder.AppendLine("DELETE [dbo].[AKB] WHERE");


            // Index_BRANCH
            builder.Append("[BRANCH] IN (");
            for (int index = 0; index < Index_BRANCH.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // BRANCH
                var parameterBRANCH = $"@p{parameterIndex++}";
                builder.Append(parameterBRANCH);
                command.Parameters.Add(parameterBRANCH, SqlDbType.VarChar, 10).Value = Index_BRANCH[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKB data set</returns>
        public override EduHubDataSetDataReader<AKB> GetDataSetDataReader()
        {
            return new AKBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKB data set</returns>
        public override EduHubDataSetDataReader<AKB> GetDataSetDataReader(List<AKB> Entities)
        {
            return new AKBDataReader(new EduHubDataSetLoadedReader<AKB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKBDataReader : EduHubDataSetDataReader<AKB>
        {
            public AKBDataReader(IEduHubDataSetReader<AKB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // BRANCH
                        return Current.BRANCH;
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
                    case 0: // BRANCH
                        return "BRANCH";
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
                    case "BRANCH":
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
