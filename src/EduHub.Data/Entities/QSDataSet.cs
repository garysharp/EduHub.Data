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
    /// Stored SQL Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSDataSet : EduHubDataSet<QS>
    {
        /// <inheritdoc />
        public override string Name { get { return "QS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal QSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QSKEY = new Lazy<Dictionary<string, QS>>(() => this.ToDictionary(i => i.QSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QS" /> fields for each CSV column header</returns>
        internal override Action<QS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSKEY":
                        mapper[i] = (e, v) => e.QSKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SQLTEXT":
                        mapper[i] = (e, v) => e.SQLTEXT = v;
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
        /// Merges <see cref="QS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="QS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="QS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{QS}"/> of entities</returns>
        internal override IEnumerable<QS> ApplyDeltaEntities(IEnumerable<QS> Entities, List<QS> DeltaEntities)
        {
            HashSet<string> Index_QSKEY = new HashSet<string>(DeltaEntities.Select(i => i.QSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.QSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_QSKEY.Remove(entity.QSKEY);
                            
                            if (entity.QSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, QS>> Index_QSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <returns>Related QS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QS FindByQSKEY(string QSKEY)
        {
            return Index_QSKEY.Value[QSKEY];
        }

        /// <summary>
        /// Attempt to find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <param name="Value">Related QS entity</param>
        /// <returns>True if the related QS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQSKEY(string QSKEY, out QS Value)
        {
            return Index_QSKEY.Value.TryGetValue(QSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <returns>Related QS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QS TryFindByQSKEY(string QSKEY)
        {
            QS value;
            if (Index_QSKEY.Value.TryGetValue(QSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a QS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QS](
        [QSKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [SQLTEXT] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QS_Index_QSKEY] PRIMARY KEY CLUSTERED (
            [QSKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="QSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="QSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="QS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="QS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<QS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_QSKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_QSKEY.Add(entity.QSKEY);
            }

            builder.AppendLine("DELETE [dbo].[QS] WHERE");


            // Index_QSKEY
            builder.Append("[QSKEY] IN (");
            for (int index = 0; index < Index_QSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // QSKEY
                var parameterQSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterQSKEY);
                command.Parameters.Add(parameterQSKEY, SqlDbType.VarChar, 10).Value = Index_QSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QS data set</returns>
        public override EduHubDataSetDataReader<QS> GetDataSetDataReader()
        {
            return new QSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QS data set</returns>
        public override EduHubDataSetDataReader<QS> GetDataSetDataReader(List<QS> Entities)
        {
            return new QSDataReader(new EduHubDataSetLoadedReader<QS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QSDataReader : EduHubDataSetDataReader<QS>
        {
            public QSDataReader(IEduHubDataSetReader<QS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // QSKEY
                        return Current.QSKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // SQLTEXT
                        return Current.SQLTEXT;
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
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // SQLTEXT
                        return Current.SQLTEXT == null;
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
                    case 0: // QSKEY
                        return "QSKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SQLTEXT
                        return "SQLTEXT";
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
                    case "QSKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SQLTEXT":
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
