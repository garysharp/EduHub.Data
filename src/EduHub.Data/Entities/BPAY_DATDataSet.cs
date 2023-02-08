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
    /// BPay Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BPAY_DATDataSet : EduHubDataSet<BPAY_DAT>
    {
        /// <inheritdoc />
        public override string Name { get { return "BPAY_DAT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal BPAY_DATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, BPAY_DAT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BPAY_DAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BPAY_DAT" /> fields for each CSV column header</returns>
        internal override Action<BPAY_DAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BPAY_DAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v;
                        break;
                    case "CUST_REF":
                        mapper[i] = (e, v) => e.CUST_REF = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "SUPPORT_REF":
                        mapper[i] = (e, v) => e.SUPPORT_REF = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
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
        /// Merges <see cref="BPAY_DAT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="BPAY_DAT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="BPAY_DAT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{BPAY_DAT}"/> of entities</returns>
        internal override IEnumerable<BPAY_DAT> ApplyDeltaEntities(IEnumerable<BPAY_DAT> Entities, List<BPAY_DAT> DeltaEntities)
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

        private Lazy<Dictionary<int, BPAY_DAT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BPAY_DAT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <param name="Value">Related BPAY_DAT entity</param>
        /// <returns>True if the related BPAY_DAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BPAY_DAT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BPAY_DAT TryFindByTID(int TID)
        {
            BPAY_DAT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a BPAY_DAT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BPAY_DAT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BPAY_DAT](
        [TID] int IDENTITY NOT NULL,
        [LINE_TYPE] varchar(1) NULL,
        [RECORD] varchar(255) NULL,
        [PAYMENT_DATE] varchar(8) NULL,
        [CUST_REF] varchar(50) NULL,
        [AMOUNT] money NULL,
        [PAYMENT_TYPE] varchar(2) NULL,
        [BILLER_CODE] varchar(5) NULL,
        [SUPPORT_REF] varchar(21) NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [RECORD_TYPE] varchar(2) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BPAY_DAT_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="BPAY_DATDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="BPAY_DATDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="BPAY_DAT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="BPAY_DAT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<BPAY_DAT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[BPAY_DAT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the BPAY_DAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BPAY_DAT data set</returns>
        public override EduHubDataSetDataReader<BPAY_DAT> GetDataSetDataReader()
        {
            return new BPAY_DATDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BPAY_DAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BPAY_DAT data set</returns>
        public override EduHubDataSetDataReader<BPAY_DAT> GetDataSetDataReader(List<BPAY_DAT> Entities)
        {
            return new BPAY_DATDataReader(new EduHubDataSetLoadedReader<BPAY_DAT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BPAY_DATDataReader : EduHubDataSetDataReader<BPAY_DAT>
        {
            public BPAY_DATDataReader(IEduHubDataSetReader<BPAY_DAT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 15; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // LINE_TYPE
                        return Current.LINE_TYPE;
                    case 2: // RECORD
                        return Current.RECORD;
                    case 3: // PAYMENT_DATE
                        return Current.PAYMENT_DATE;
                    case 4: // CUST_REF
                        return Current.CUST_REF;
                    case 5: // AMOUNT
                        return Current.AMOUNT;
                    case 6: // PAYMENT_TYPE
                        return Current.PAYMENT_TYPE;
                    case 7: // BILLER_CODE
                        return Current.BILLER_CODE;
                    case 8: // SUPPORT_REF
                        return Current.SUPPORT_REF;
                    case 9: // DELETE_FLAG
                        return Current.DELETE_FLAG;
                    case 10: // RECORD_TYPE
                        return Current.RECORD_TYPE;
                    case 11: // TRXLEDGER
                        return Current.TRXLEDGER;
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
                    case 1: // LINE_TYPE
                        return Current.LINE_TYPE == null;
                    case 2: // RECORD
                        return Current.RECORD == null;
                    case 3: // PAYMENT_DATE
                        return Current.PAYMENT_DATE == null;
                    case 4: // CUST_REF
                        return Current.CUST_REF == null;
                    case 5: // AMOUNT
                        return Current.AMOUNT == null;
                    case 6: // PAYMENT_TYPE
                        return Current.PAYMENT_TYPE == null;
                    case 7: // BILLER_CODE
                        return Current.BILLER_CODE == null;
                    case 8: // SUPPORT_REF
                        return Current.SUPPORT_REF == null;
                    case 9: // DELETE_FLAG
                        return Current.DELETE_FLAG == null;
                    case 10: // RECORD_TYPE
                        return Current.RECORD_TYPE == null;
                    case 11: // TRXLEDGER
                        return Current.TRXLEDGER == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // LINE_TYPE
                        return "LINE_TYPE";
                    case 2: // RECORD
                        return "RECORD";
                    case 3: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 4: // CUST_REF
                        return "CUST_REF";
                    case 5: // AMOUNT
                        return "AMOUNT";
                    case 6: // PAYMENT_TYPE
                        return "PAYMENT_TYPE";
                    case 7: // BILLER_CODE
                        return "BILLER_CODE";
                    case 8: // SUPPORT_REF
                        return "SUPPORT_REF";
                    case 9: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 10: // RECORD_TYPE
                        return "RECORD_TYPE";
                    case 11: // TRXLEDGER
                        return "TRXLEDGER";
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
                    case "TID":
                        return 0;
                    case "LINE_TYPE":
                        return 1;
                    case "RECORD":
                        return 2;
                    case "PAYMENT_DATE":
                        return 3;
                    case "CUST_REF":
                        return 4;
                    case "AMOUNT":
                        return 5;
                    case "PAYMENT_TYPE":
                        return 6;
                    case "BILLER_CODE":
                        return 7;
                    case "SUPPORT_REF":
                        return 8;
                    case "DELETE_FLAG":
                        return 9;
                    case "RECORD_TYPE":
                        return 10;
                    case "TRXLEDGER":
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
#endif
