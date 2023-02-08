#if !EduHubScoped
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
    /// Employee Super Payment Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PESPDataSet : EduHubDataSet<PESP>
    {
        /// <inheritdoc />
        public override string Name { get { return "PESP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PESPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PESP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PESP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESP" /> fields for each CSV column header</returns>
        internal override Action<PESP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PESP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PAYMENT_AMOUNT":
                        mapper[i] = (e, v) => e.PAYMENT_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FROM_DATE":
                        mapper[i] = (e, v) => e.SUPER_FROM_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SUPER_TO_DATE":
                        mapper[i] = (e, v) => e.SUPER_TO_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PROCESS_DATE":
                        mapper[i] = (e, v) => e.PROCESS_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DATE_ADVISED":
                        mapper[i] = (e, v) => e.DATE_ADVISED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="PESP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PESP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PESP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PESP}"/> of entities</returns>
        internal override IEnumerable<PESP> ApplyDeltaEntities(IEnumerable<PESP> Entities, List<PESP> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<PESP>>> Index_CODE;
        private Lazy<Dictionary<int, PESP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <returns>List of related PESP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESP> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <param name="Value">List of related PESP entities</param>
        /// <returns>True if the list of related PESP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PESP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <returns>List of related PESP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESP> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PESP> value;
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
        /// Find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <returns>Related PESP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <param name="Value">Related PESP entity</param>
        /// <returns>True if the related PESP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PESP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <returns>Related PESP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESP TryFindByTID(int TID)
        {
            PESP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PESP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PESP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PESP](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRTYPE] varchar(1) NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [PAYMENT_DATE] datetime NULL,
        [PAYMENT_AMOUNT] money NULL,
        [SUPER_FROM_DATE] datetime NULL,
        [SUPER_TO_DATE] datetime NULL,
        [PROCESS_DATE] datetime NULL,
        [DATE_ADVISED] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PESP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PESP_Index_CODE] ON [dbo].[PESP]
    (
            [CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PESP]') AND name = N'PESP_Index_TID')
    ALTER INDEX [PESP_Index_TID] ON [dbo].[PESP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PESP]') AND name = N'PESP_Index_TID')
    ALTER INDEX [PESP_Index_TID] ON [dbo].[PESP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PESP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PESP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PESP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PESP] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PESP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PESP data set</returns>
        public override EduHubDataSetDataReader<PESP> GetDataSetDataReader()
        {
            return new PESPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PESP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PESP data set</returns>
        public override EduHubDataSetDataReader<PESP> GetDataSetDataReader(List<PESP> Entities)
        {
            return new PESPDataReader(new EduHubDataSetLoadedReader<PESP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PESPDataReader : EduHubDataSetDataReader<PESP>
        {
            public PESPDataReader(IEduHubDataSetReader<PESP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRTYPE
                        return Current.TRTYPE;
                    case 3: // SUPER_FUND
                        return Current.SUPER_FUND;
                    case 4: // SUPER_MEMBER
                        return Current.SUPER_MEMBER;
                    case 5: // PAYMENT_DATE
                        return Current.PAYMENT_DATE;
                    case 6: // PAYMENT_AMOUNT
                        return Current.PAYMENT_AMOUNT;
                    case 7: // SUPER_FROM_DATE
                        return Current.SUPER_FROM_DATE;
                    case 8: // SUPER_TO_DATE
                        return Current.SUPER_TO_DATE;
                    case 9: // PROCESS_DATE
                        return Current.PROCESS_DATE;
                    case 10: // DATE_ADVISED
                        return Current.DATE_ADVISED;
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
                    case 2: // TRTYPE
                        return Current.TRTYPE == null;
                    case 3: // SUPER_FUND
                        return Current.SUPER_FUND == null;
                    case 4: // SUPER_MEMBER
                        return Current.SUPER_MEMBER == null;
                    case 5: // PAYMENT_DATE
                        return Current.PAYMENT_DATE == null;
                    case 6: // PAYMENT_AMOUNT
                        return Current.PAYMENT_AMOUNT == null;
                    case 7: // SUPER_FROM_DATE
                        return Current.SUPER_FROM_DATE == null;
                    case 8: // SUPER_TO_DATE
                        return Current.SUPER_TO_DATE == null;
                    case 9: // PROCESS_DATE
                        return Current.PROCESS_DATE == null;
                    case 10: // DATE_ADVISED
                        return Current.DATE_ADVISED == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRTYPE
                        return "TRTYPE";
                    case 3: // SUPER_FUND
                        return "SUPER_FUND";
                    case 4: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 5: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 6: // PAYMENT_AMOUNT
                        return "PAYMENT_AMOUNT";
                    case 7: // SUPER_FROM_DATE
                        return "SUPER_FROM_DATE";
                    case 8: // SUPER_TO_DATE
                        return "SUPER_TO_DATE";
                    case 9: // PROCESS_DATE
                        return "PROCESS_DATE";
                    case 10: // DATE_ADVISED
                        return "DATE_ADVISED";
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
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "TRTYPE":
                        return 2;
                    case "SUPER_FUND":
                        return 3;
                    case "SUPER_MEMBER":
                        return 4;
                    case "PAYMENT_DATE":
                        return 5;
                    case "PAYMENT_AMOUNT":
                        return 6;
                    case "SUPER_FROM_DATE":
                        return 7;
                    case "SUPER_TO_DATE":
                        return 8;
                    case "PROCESS_DATE":
                        return 9;
                    case "DATE_ADVISED":
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
#endif
