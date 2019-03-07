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
    /// Purchase Requisition Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQDataSet : EduHubDataSet<RQ>
    {
        /// <inheritdoc />
        public override string Name { get { return "RQ"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal RQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_APPROVED_BY = new Lazy<NullDictionary<string, IReadOnlyList<RQ>>>(() => this.ToGroupedNullDictionary(i => i.APPROVED_BY));
            Index_CODE = new Lazy<NullDictionary<string, IReadOnlyList<RQ>>>(() => this.ToGroupedNullDictionary(i => i.CODE));
            Index_ORDER_BY = new Lazy<NullDictionary<string, IReadOnlyList<RQ>>>(() => this.ToGroupedNullDictionary(i => i.ORDER_BY));
            Index_TRORDER = new Lazy<Dictionary<int, RQ>>(() => this.ToDictionary(i => i.TRORDER));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="RQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="RQ" /> fields for each CSV column header</returns>
        internal override Action<RQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<RQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TRORDER":
                        mapper[i] = (e, v) => e.TRORDER = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "PRCOMMENT":
                        mapper[i] = (e, v) => e.PRCOMMENT = v;
                        break;
                    case "ORDER_BY":
                        mapper[i] = (e, v) => e.ORDER_BY = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "APPROVED_BY":
                        mapper[i] = (e, v) => e.APPROVED_BY = v;
                        break;
                    case "APPROVED_DATE":
                        mapper[i] = (e, v) => e.APPROVED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DECLINED_COMMENT":
                        mapper[i] = (e, v) => e.DECLINED_COMMENT = v;
                        break;
                    case "PRINTED":
                        mapper[i] = (e, v) => e.PRINTED = v;
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
        /// Merges <see cref="RQ" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="RQ" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="RQ" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{RQ}"/> of entities</returns>
        internal override IEnumerable<RQ> ApplyDeltaEntities(IEnumerable<RQ> Entities, List<RQ> DeltaEntities)
        {
            HashSet<int> Index_TRORDER = new HashSet<int>(DeltaEntities.Select(i => i.TRORDER));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TRORDER;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TRORDER.Remove(entity.TRORDER);
                            
                            if (entity.TRORDER.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<RQ>>> Index_APPROVED_BY;
        private Lazy<NullDictionary<string, IReadOnlyList<RQ>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<RQ>>> Index_ORDER_BY;
        private Lazy<Dictionary<int, RQ>> Index_TRORDER;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find RQ by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find RQ</param>
        /// <returns>List of related RQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQ> FindByAPPROVED_BY(string APPROVED_BY)
        {
            return Index_APPROVED_BY.Value[APPROVED_BY];
        }

        /// <summary>
        /// Attempt to find RQ by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find RQ</param>
        /// <param name="Value">List of related RQ entities</param>
        /// <returns>True if the list of related RQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAPPROVED_BY(string APPROVED_BY, out IReadOnlyList<RQ> Value)
        {
            return Index_APPROVED_BY.Value.TryGetValue(APPROVED_BY, out Value);
        }

        /// <summary>
        /// Attempt to find RQ by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find RQ</param>
        /// <returns>List of related RQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQ> TryFindByAPPROVED_BY(string APPROVED_BY)
        {
            IReadOnlyList<RQ> value;
            if (Index_APPROVED_BY.Value.TryGetValue(APPROVED_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQ by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find RQ</param>
        /// <returns>List of related RQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQ> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find RQ by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find RQ</param>
        /// <param name="Value">List of related RQ entities</param>
        /// <returns>True if the list of related RQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<RQ> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find RQ by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find RQ</param>
        /// <returns>List of related RQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQ> TryFindByCODE(string CODE)
        {
            IReadOnlyList<RQ> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQ by ORDER_BY field
        /// </summary>
        /// <param name="ORDER_BY">ORDER_BY value used to find RQ</param>
        /// <returns>List of related RQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQ> FindByORDER_BY(string ORDER_BY)
        {
            return Index_ORDER_BY.Value[ORDER_BY];
        }

        /// <summary>
        /// Attempt to find RQ by ORDER_BY field
        /// </summary>
        /// <param name="ORDER_BY">ORDER_BY value used to find RQ</param>
        /// <param name="Value">List of related RQ entities</param>
        /// <returns>True if the list of related RQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORDER_BY(string ORDER_BY, out IReadOnlyList<RQ> Value)
        {
            return Index_ORDER_BY.Value.TryGetValue(ORDER_BY, out Value);
        }

        /// <summary>
        /// Attempt to find RQ by ORDER_BY field
        /// </summary>
        /// <param name="ORDER_BY">ORDER_BY value used to find RQ</param>
        /// <returns>List of related RQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQ> TryFindByORDER_BY(string ORDER_BY)
        {
            IReadOnlyList<RQ> value;
            if (Index_ORDER_BY.Value.TryGetValue(ORDER_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQ by TRORDER field
        /// </summary>
        /// <param name="TRORDER">TRORDER value used to find RQ</param>
        /// <returns>Related RQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQ FindByTRORDER(int TRORDER)
        {
            return Index_TRORDER.Value[TRORDER];
        }

        /// <summary>
        /// Attempt to find RQ by TRORDER field
        /// </summary>
        /// <param name="TRORDER">TRORDER value used to find RQ</param>
        /// <param name="Value">Related RQ entity</param>
        /// <returns>True if the related RQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRORDER(int TRORDER, out RQ Value)
        {
            return Index_TRORDER.Value.TryGetValue(TRORDER, out Value);
        }

        /// <summary>
        /// Attempt to find RQ by TRORDER field
        /// </summary>
        /// <param name="TRORDER">TRORDER value used to find RQ</param>
        /// <returns>Related RQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQ TryFindByTRORDER(int TRORDER)
        {
            RQ value;
            if (Index_TRORDER.Value.TryGetValue(TRORDER, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a RQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[RQ](
        [TRORDER] int IDENTITY NOT NULL,
        [CODE] varchar(10) NULL,
        [TRDATE] datetime NULL,
        [TRXLEDGER] varchar(2) NULL,
        [PRCOMMENT] varchar(MAX) NULL,
        [ORDER_BY] varchar(4) NULL,
        [STATUS] varchar(1) NULL,
        [APPROVED_BY] varchar(4) NULL,
        [APPROVED_DATE] datetime NULL,
        [DECLINED_COMMENT] varchar(MAX) NULL,
        [PRINTED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [RQ_Index_TRORDER] PRIMARY KEY CLUSTERED (
            [TRORDER] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [RQ_Index_APPROVED_BY] ON [dbo].[RQ]
    (
            [APPROVED_BY] ASC
    );
    CREATE NONCLUSTERED INDEX [RQ_Index_CODE] ON [dbo].[RQ]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [RQ_Index_ORDER_BY] ON [dbo].[RQ]
    (
            [ORDER_BY] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND name = N'Index_APPROVED_BY')
    ALTER INDEX [Index_APPROVED_BY] ON [dbo].[RQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND name = N'Index_CODE')
    ALTER INDEX [Index_CODE] ON [dbo].[RQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND name = N'Index_ORDER_BY')
    ALTER INDEX [Index_ORDER_BY] ON [dbo].[RQ] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND name = N'Index_APPROVED_BY')
    ALTER INDEX [Index_APPROVED_BY] ON [dbo].[RQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND name = N'Index_CODE')
    ALTER INDEX [Index_CODE] ON [dbo].[RQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQ]') AND name = N'Index_ORDER_BY')
    ALTER INDEX [Index_ORDER_BY] ON [dbo].[RQ] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="RQ"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="RQ"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<RQ> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TRORDER = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TRORDER.Add(entity.TRORDER);
            }

            builder.AppendLine("DELETE [dbo].[RQ] WHERE");


            // Index_TRORDER
            builder.Append("[TRORDER] IN (");
            for (int index = 0; index < Index_TRORDER.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TRORDER
                var parameterTRORDER = $"@p{parameterIndex++}";
                builder.Append(parameterTRORDER);
                command.Parameters.Add(parameterTRORDER, SqlDbType.Int).Value = Index_TRORDER[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQ data set</returns>
        public override EduHubDataSetDataReader<RQ> GetDataSetDataReader()
        {
            return new RQDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQ data set</returns>
        public override EduHubDataSetDataReader<RQ> GetDataSetDataReader(List<RQ> Entities)
        {
            return new RQDataReader(new EduHubDataSetLoadedReader<RQ>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class RQDataReader : EduHubDataSetDataReader<RQ>
        {
            public RQDataReader(IEduHubDataSetReader<RQ> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TRORDER
                        return Current.TRORDER;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRDATE
                        return Current.TRDATE;
                    case 3: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 4: // PRCOMMENT
                        return Current.PRCOMMENT;
                    case 5: // ORDER_BY
                        return Current.ORDER_BY;
                    case 6: // STATUS
                        return Current.STATUS;
                    case 7: // APPROVED_BY
                        return Current.APPROVED_BY;
                    case 8: // APPROVED_DATE
                        return Current.APPROVED_DATE;
                    case 9: // DECLINED_COMMENT
                        return Current.DECLINED_COMMENT;
                    case 10: // PRINTED
                        return Current.PRINTED;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CODE
                        return Current.CODE == null;
                    case 2: // TRDATE
                        return Current.TRDATE == null;
                    case 3: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 4: // PRCOMMENT
                        return Current.PRCOMMENT == null;
                    case 5: // ORDER_BY
                        return Current.ORDER_BY == null;
                    case 6: // STATUS
                        return Current.STATUS == null;
                    case 7: // APPROVED_BY
                        return Current.APPROVED_BY == null;
                    case 8: // APPROVED_DATE
                        return Current.APPROVED_DATE == null;
                    case 9: // DECLINED_COMMENT
                        return Current.DECLINED_COMMENT == null;
                    case 10: // PRINTED
                        return Current.PRINTED == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TRORDER
                        return "TRORDER";
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRDATE
                        return "TRDATE";
                    case 3: // TRXLEDGER
                        return "TRXLEDGER";
                    case 4: // PRCOMMENT
                        return "PRCOMMENT";
                    case 5: // ORDER_BY
                        return "ORDER_BY";
                    case 6: // STATUS
                        return "STATUS";
                    case 7: // APPROVED_BY
                        return "APPROVED_BY";
                    case 8: // APPROVED_DATE
                        return "APPROVED_DATE";
                    case 9: // DECLINED_COMMENT
                        return "DECLINED_COMMENT";
                    case 10: // PRINTED
                        return "PRINTED";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TRORDER":
                        return 0;
                    case "CODE":
                        return 1;
                    case "TRDATE":
                        return 2;
                    case "TRXLEDGER":
                        return 3;
                    case "PRCOMMENT":
                        return 4;
                    case "ORDER_BY":
                        return 5;
                    case "STATUS":
                        return 6;
                    case "APPROVED_BY":
                        return 7;
                    case "APPROVED_DATE":
                        return 8;
                    case "DECLINED_COMMENT":
                        return 9;
                    case "PRINTED":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
