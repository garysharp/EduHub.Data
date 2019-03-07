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
    /// BPAY Temp Receipts Import Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KBPTDataSet : EduHubDataSet<KBPT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KBPT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KBPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KBPT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KBPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KBPT" /> fields for each CSV column header</returns>
        internal override Action<KBPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KBPT, string>[Headers.Count];

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
        /// Merges <see cref="KBPT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KBPT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KBPT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KBPT}"/> of entities</returns>
        internal override IEnumerable<KBPT> ApplyDeltaEntities(IEnumerable<KBPT> Entities, List<KBPT> DeltaEntities)
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

        private Lazy<Dictionary<int, KBPT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KBPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBPT</param>
        /// <returns>Related KBPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBPT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KBPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBPT</param>
        /// <param name="Value">Related KBPT entity</param>
        /// <returns>True if the related KBPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KBPT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KBPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBPT</param>
        /// <returns>Related KBPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBPT TryFindByTID(int TID)
        {
            KBPT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KBPT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KBPT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KBPT](
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
        CONSTRAINT [KBPT_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KBPTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KBPTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KBPT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KBPT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KBPT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KBPT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KBPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBPT data set</returns>
        public override EduHubDataSetDataReader<KBPT> GetDataSetDataReader()
        {
            return new KBPTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KBPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBPT data set</returns>
        public override EduHubDataSetDataReader<KBPT> GetDataSetDataReader(List<KBPT> Entities)
        {
            return new KBPTDataReader(new EduHubDataSetLoadedReader<KBPT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KBPTDataReader : EduHubDataSetDataReader<KBPT>
        {
            public KBPTDataReader(IEduHubDataSetReader<KBPT> Reader)
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
