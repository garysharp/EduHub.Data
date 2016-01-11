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
    /// Batch Headers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QBDataSet : EduHubDataSet<QB>
    {
        /// <inheritdoc />
        public override string Name { get { return "QB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal QBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QBKEY = new Lazy<Dictionary<int, QB>>(() => this.ToDictionary(i => i.QBKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QB" /> fields for each CSV column header</returns>
        internal override Action<QB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QBKEY":
                        mapper[i] = (e, v) => e.QBKEY = int.Parse(v);
                        break;
                    case "NARRATIVE":
                        mapper[i] = (e, v) => e.NARRATIVE = v;
                        break;
                    case "TOTAL":
                        mapper[i] = (e, v) => e.TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v;
                        break;
                    case "QUANTITY":
                        mapper[i] = (e, v) => e.QUANTITY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BATCHTYPE":
                        mapper[i] = (e, v) => e.BATCHTYPE = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "BATCHDATA":
                        mapper[i] = (e, v) => e.BATCHDATA = null; // eduHub is not encoding byte arrays
                        break;
                    case "BATCHPRINTED":
                        mapper[i] = (e, v) => e.BATCHPRINTED = v;
                        break;
                    case "BANKPRINTED":
                        mapper[i] = (e, v) => e.BANKPRINTED = v;
                        break;
                    case "BATCHTRACE":
                        mapper[i] = (e, v) => e.BATCHTRACE = v;
                        break;
                    case "BATCHCLASS":
                        mapper[i] = (e, v) => e.BATCHCLASS = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="QB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="QB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="QB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{QB}"/> of entities</returns>
        internal override IEnumerable<QB> ApplyDeltaEntities(IEnumerable<QB> Entities, List<QB> DeltaEntities)
        {
            HashSet<int> Index_QBKEY = new HashSet<int>(DeltaEntities.Select(i => i.QBKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.QBKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_QBKEY.Remove(entity.QBKEY);
                            
                            if (entity.QBKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, QB>> Index_QBKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <returns>Related QB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QB FindByQBKEY(int QBKEY)
        {
            return Index_QBKEY.Value[QBKEY];
        }

        /// <summary>
        /// Attempt to find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <param name="Value">Related QB entity</param>
        /// <returns>True if the related QB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQBKEY(int QBKEY, out QB Value)
        {
            return Index_QBKEY.Value.TryGetValue(QBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <returns>Related QB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QB TryFindByQBKEY(int QBKEY)
        {
            QB value;
            if (Index_QBKEY.Value.TryGetValue(QBKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a QB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QB](
        [QBKEY] int NOT NULL,
        [NARRATIVE] varchar(40) NULL,
        [TOTAL] money NULL,
        [CLASS] varchar(2) NULL,
        [QUANTITY] int NULL,
        [BATCHTYPE] varchar(1) NULL,
        [TRANSTYPE] varchar(1) NULL,
        [BATCHDATA] image NULL,
        [BATCHPRINTED] varchar(1) NULL,
        [BANKPRINTED] varchar(1) NULL,
        [BATCHTRACE] varchar(1) NULL,
        [BATCHCLASS] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QB_Index_QBKEY] PRIMARY KEY CLUSTERED (
            [QBKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="QBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="QBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="QB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="QB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<QB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_QBKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_QBKEY.Add(entity.QBKEY);
            }

            builder.AppendLine("DELETE [dbo].[QB] WHERE");


            // Index_QBKEY
            builder.Append("[QBKEY] IN (");
            for (int index = 0; index < Index_QBKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // QBKEY
                var parameterQBKEY = $"@p{parameterIndex++}";
                builder.Append(parameterQBKEY);
                command.Parameters.Add(parameterQBKEY, SqlDbType.Int).Value = Index_QBKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QB data set</returns>
        public override EduHubDataSetDataReader<QB> GetDataSetDataReader()
        {
            return new QBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QB data set</returns>
        public override EduHubDataSetDataReader<QB> GetDataSetDataReader(List<QB> Entities)
        {
            return new QBDataReader(new EduHubDataSetLoadedReader<QB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QBDataReader : EduHubDataSetDataReader<QB>
        {
            public QBDataReader(IEduHubDataSetReader<QB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 15; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // QBKEY
                        return Current.QBKEY;
                    case 1: // NARRATIVE
                        return Current.NARRATIVE;
                    case 2: // TOTAL
                        return Current.TOTAL;
                    case 3: // CLASS
                        return Current.CLASS;
                    case 4: // QUANTITY
                        return Current.QUANTITY;
                    case 5: // BATCHTYPE
                        return Current.BATCHTYPE;
                    case 6: // TRANSTYPE
                        return Current.TRANSTYPE;
                    case 7: // BATCHDATA
                        return Current.BATCHDATA;
                    case 8: // BATCHPRINTED
                        return Current.BATCHPRINTED;
                    case 9: // BANKPRINTED
                        return Current.BANKPRINTED;
                    case 10: // BATCHTRACE
                        return Current.BATCHTRACE;
                    case 11: // BATCHCLASS
                        return Current.BATCHCLASS;
                    case 12: // LW_DATE
                        return Current.LW_DATE;
                    case 13: // LW_TIME
                        return Current.LW_TIME;
                    case 14: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // NARRATIVE
                        return Current.NARRATIVE == null;
                    case 2: // TOTAL
                        return Current.TOTAL == null;
                    case 3: // CLASS
                        return Current.CLASS == null;
                    case 4: // QUANTITY
                        return Current.QUANTITY == null;
                    case 5: // BATCHTYPE
                        return Current.BATCHTYPE == null;
                    case 6: // TRANSTYPE
                        return Current.TRANSTYPE == null;
                    case 7: // BATCHDATA
                        return Current.BATCHDATA == null;
                    case 8: // BATCHPRINTED
                        return Current.BATCHPRINTED == null;
                    case 9: // BANKPRINTED
                        return Current.BANKPRINTED == null;
                    case 10: // BATCHTRACE
                        return Current.BATCHTRACE == null;
                    case 11: // BATCHCLASS
                        return Current.BATCHCLASS == null;
                    case 12: // LW_DATE
                        return Current.LW_DATE == null;
                    case 13: // LW_TIME
                        return Current.LW_TIME == null;
                    case 14: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // QBKEY
                        return "QBKEY";
                    case 1: // NARRATIVE
                        return "NARRATIVE";
                    case 2: // TOTAL
                        return "TOTAL";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // QUANTITY
                        return "QUANTITY";
                    case 5: // BATCHTYPE
                        return "BATCHTYPE";
                    case 6: // TRANSTYPE
                        return "TRANSTYPE";
                    case 7: // BATCHDATA
                        return "BATCHDATA";
                    case 8: // BATCHPRINTED
                        return "BATCHPRINTED";
                    case 9: // BANKPRINTED
                        return "BANKPRINTED";
                    case 10: // BATCHTRACE
                        return "BATCHTRACE";
                    case 11: // BATCHCLASS
                        return "BATCHCLASS";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "QBKEY":
                        return 0;
                    case "NARRATIVE":
                        return 1;
                    case "TOTAL":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "QUANTITY":
                        return 4;
                    case "BATCHTYPE":
                        return 5;
                    case "TRANSTYPE":
                        return 6;
                    case "BATCHDATA":
                        return 7;
                    case "BATCHPRINTED":
                        return 8;
                    case "BANKPRINTED":
                        return 9;
                    case "BATCHTRACE":
                        return 10;
                    case "BATCHCLASS":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
