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
    /// Event Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TECDataSet : EduHubDataSet<TEC>
    {
        /// <inheritdoc />
        public override string Name { get { return "TEC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TECDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CATEGORY = new Lazy<Dictionary<string, TEC>>(() => this.ToDictionary(i => i.CATEGORY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TEC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TEC" /> fields for each CSV column header</returns>
        internal override Action<TEC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TEC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
        /// Merges <see cref="TEC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TEC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TEC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TEC}"/> of entities</returns>
        internal override IEnumerable<TEC> ApplyDeltaEntities(IEnumerable<TEC> Entities, List<TEC> DeltaEntities)
        {
            HashSet<string> Index_CATEGORY = new HashSet<string>(DeltaEntities.Select(i => i.CATEGORY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CATEGORY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_CATEGORY.Remove(entity.CATEGORY);
                            
                            if (entity.CATEGORY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, TEC>> Index_CATEGORY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TEC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TEC</param>
        /// <returns>Related TEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TEC FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find TEC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TEC</param>
        /// <param name="Value">Related TEC entity</param>
        /// <returns>True if the related TEC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out TEC Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find TEC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TEC</param>
        /// <returns>Related TEC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TEC TryFindByCATEGORY(string CATEGORY)
        {
            TEC value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TEC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TEC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TEC](
        [CATEGORY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TEC_Index_CATEGORY] PRIMARY KEY CLUSTERED (
            [CATEGORY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="TECDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="TECDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TEC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TEC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TEC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_CATEGORY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_CATEGORY.Add(entity.CATEGORY);
            }

            builder.AppendLine("DELETE [dbo].[TEC] WHERE");


            // Index_CATEGORY
            builder.Append("[CATEGORY] IN (");
            for (int index = 0; index < Index_CATEGORY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // CATEGORY
                var parameterCATEGORY = $"@p{parameterIndex++}";
                builder.Append(parameterCATEGORY);
                command.Parameters.Add(parameterCATEGORY, SqlDbType.VarChar, 10).Value = Index_CATEGORY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TEC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TEC data set</returns>
        public override EduHubDataSetDataReader<TEC> GetDataSetDataReader()
        {
            return new TECDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TEC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TEC data set</returns>
        public override EduHubDataSetDataReader<TEC> GetDataSetDataReader(List<TEC> Entities)
        {
            return new TECDataReader(new EduHubDataSetLoadedReader<TEC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TECDataReader : EduHubDataSetDataReader<TEC>
        {
            public TECDataReader(IEduHubDataSetReader<TEC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // CATEGORY
                        return Current.CATEGORY;
                    case 1: // TITLE
                        return Current.TITLE;
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
                    case 1: // TITLE
                        return Current.TITLE == null;
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
                    case 0: // CATEGORY
                        return "CATEGORY";
                    case 1: // TITLE
                        return "TITLE";
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
                    case "CATEGORY":
                        return 0;
                    case "TITLE":
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
