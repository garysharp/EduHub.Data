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
    /// BPAY Receipts Import Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KBPDataSet : EduHubDataSet<KBP>
    {
        /// <inheritdoc />
        public override string Name { get { return "KBP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KBPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_REFERENCE_NO = new Lazy<NullDictionary<string, IReadOnlyList<KBP>>>(() => this.ToGroupedNullDictionary(i => i.REFERENCE_NO));
            Index_TID = new Lazy<Dictionary<int, KBP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KBP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KBP" /> fields for each CSV column header</returns>
        internal override Action<KBP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KBP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CUST_REFERENCE":
                        mapper[i] = (e, v) => e.CUST_REFERENCE = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "INVOICE_TID":
                        mapper[i] = (e, v) => e.INVOICE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
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
        /// Merges <see cref="KBP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KBP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KBP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KBP}"/> of entities</returns>
        internal override IEnumerable<KBP> ApplyDeltaEntities(IEnumerable<KBP> Entities, List<KBP> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KBP>>> Index_REFERENCE_NO;
        private Lazy<Dictionary<int, KBP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KBP by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find KBP</param>
        /// <returns>List of related KBP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KBP> FindByREFERENCE_NO(string REFERENCE_NO)
        {
            return Index_REFERENCE_NO.Value[REFERENCE_NO];
        }

        /// <summary>
        /// Attempt to find KBP by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find KBP</param>
        /// <param name="Value">List of related KBP entities</param>
        /// <returns>True if the list of related KBP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREFERENCE_NO(string REFERENCE_NO, out IReadOnlyList<KBP> Value)
        {
            return Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out Value);
        }

        /// <summary>
        /// Attempt to find KBP by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find KBP</param>
        /// <returns>List of related KBP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KBP> TryFindByREFERENCE_NO(string REFERENCE_NO)
        {
            IReadOnlyList<KBP> value;
            if (Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KBP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBP</param>
        /// <returns>Related KBP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KBP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBP</param>
        /// <param name="Value">Related KBP entity</param>
        /// <returns>True if the related KBP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KBP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KBP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBP</param>
        /// <returns>Related KBP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBP TryFindByTID(int TID)
        {
            KBP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KBP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KBP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KBP](
        [TID] int IDENTITY NOT NULL,
        [REFERENCE_NO] varchar(21) NULL,
        [CUST_REFERENCE] varchar(20) NULL,
        [RECORD_TYPE] varchar(2) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [PAYMENT_TYPE] varchar(2) NULL,
        [AMOUNT] money NULL,
        [PAYMENT_DATE] datetime NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [INVOICE_TID] int NULL,
        [TRXLEDGER] varchar(2) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KBP_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KBP_Index_REFERENCE_NO] ON [dbo].[KBP]
    (
            [REFERENCE_NO] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KBP]') AND name = N'Index_REFERENCE_NO')
    ALTER INDEX [Index_REFERENCE_NO] ON [dbo].[KBP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KBP]') AND name = N'Index_REFERENCE_NO')
    ALTER INDEX [Index_REFERENCE_NO] ON [dbo].[KBP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KBP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KBP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KBP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KBP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KBP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBP data set</returns>
        public override EduHubDataSetDataReader<KBP> GetDataSetDataReader()
        {
            return new KBPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KBP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBP data set</returns>
        public override EduHubDataSetDataReader<KBP> GetDataSetDataReader(List<KBP> Entities)
        {
            return new KBPDataReader(new EduHubDataSetLoadedReader<KBP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KBPDataReader : EduHubDataSetDataReader<KBP>
        {
            public KBPDataReader(IEduHubDataSetReader<KBP> Reader)
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
                    case 1: // REFERENCE_NO
                        return Current.REFERENCE_NO;
                    case 2: // CUST_REFERENCE
                        return Current.CUST_REFERENCE;
                    case 3: // RECORD_TYPE
                        return Current.RECORD_TYPE;
                    case 4: // BILLER_CODE
                        return Current.BILLER_CODE;
                    case 5: // PAYMENT_TYPE
                        return Current.PAYMENT_TYPE;
                    case 6: // AMOUNT
                        return Current.AMOUNT;
                    case 7: // PAYMENT_DATE
                        return Current.PAYMENT_DATE;
                    case 8: // DELETE_FLAG
                        return Current.DELETE_FLAG;
                    case 9: // INVOICE_TID
                        return Current.INVOICE_TID;
                    case 10: // TRXLEDGER
                        return Current.TRXLEDGER;
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
                    case 1: // REFERENCE_NO
                        return Current.REFERENCE_NO == null;
                    case 2: // CUST_REFERENCE
                        return Current.CUST_REFERENCE == null;
                    case 3: // RECORD_TYPE
                        return Current.RECORD_TYPE == null;
                    case 4: // BILLER_CODE
                        return Current.BILLER_CODE == null;
                    case 5: // PAYMENT_TYPE
                        return Current.PAYMENT_TYPE == null;
                    case 6: // AMOUNT
                        return Current.AMOUNT == null;
                    case 7: // PAYMENT_DATE
                        return Current.PAYMENT_DATE == null;
                    case 8: // DELETE_FLAG
                        return Current.DELETE_FLAG == null;
                    case 9: // INVOICE_TID
                        return Current.INVOICE_TID == null;
                    case 10: // TRXLEDGER
                        return Current.TRXLEDGER == null;
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
                    case 1: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 2: // CUST_REFERENCE
                        return "CUST_REFERENCE";
                    case 3: // RECORD_TYPE
                        return "RECORD_TYPE";
                    case 4: // BILLER_CODE
                        return "BILLER_CODE";
                    case 5: // PAYMENT_TYPE
                        return "PAYMENT_TYPE";
                    case 6: // AMOUNT
                        return "AMOUNT";
                    case 7: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 8: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 9: // INVOICE_TID
                        return "INVOICE_TID";
                    case 10: // TRXLEDGER
                        return "TRXLEDGER";
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
                    case "REFERENCE_NO":
                        return 1;
                    case "CUST_REFERENCE":
                        return 2;
                    case "RECORD_TYPE":
                        return 3;
                    case "BILLER_CODE":
                        return 4;
                    case "PAYMENT_TYPE":
                        return 5;
                    case "AMOUNT":
                        return 6;
                    case "PAYMENT_DATE":
                        return 7;
                    case "DELETE_FLAG":
                        return 8;
                    case "INVOICE_TID":
                        return 9;
                    case "TRXLEDGER":
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
