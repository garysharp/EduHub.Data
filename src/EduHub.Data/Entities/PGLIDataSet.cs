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
    /// General Ledger Import Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGLIDataSet : EduHubDataSet<PGLI>
    {
        /// <inheritdoc />
        public override string Name { get { return "PGLI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PGLIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PGLI>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FILE_ID = new Lazy<Dictionary<int, IReadOnlyList<PGLI>>>(() => this.ToGroupedDictionary(i => i.FILE_ID));
            Index_TID = new Lazy<Dictionary<int, PGLI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PGLI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PGLI" /> fields for each CSV column header</returns>
        internal override Action<PGLI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PGLI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FILE_ID":
                        mapper[i] = (e, v) => e.FILE_ID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = int.Parse(v);
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = int.Parse(v);
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRBANK":
                        mapper[i] = (e, v) => e.TRBANK = v;
                        break;
                    case "PAYEE":
                        mapper[i] = (e, v) => e.PAYEE = v;
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = decimal.Parse(v);
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = decimal.Parse(v);
                        break;
                    case "WITHHOLD_AMOUNT":
                        mapper[i] = (e, v) => e.WITHHOLD_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DEBIT_TOTAL":
                        mapper[i] = (e, v) => e.DEBIT_TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CREDIT_TOTAL":
                        mapper[i] = (e, v) => e.CREDIT_TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
        /// Merges <see cref="PGLI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PGLI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PGLI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PGLI}"/> of entities</returns>
        internal override IEnumerable<PGLI> ApplyDeltaEntities(IEnumerable<PGLI> Entities, List<PGLI> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.FILE_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.FILE_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<PGLI>>> Index_CODE;
        private Lazy<Dictionary<int, IReadOnlyList<PGLI>>> Index_FILE_ID;
        private Lazy<Dictionary<int, PGLI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PGLI by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PGLI</param>
        /// <returns>List of related PGLI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGLI> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PGLI by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PGLI</param>
        /// <param name="Value">List of related PGLI entities</param>
        /// <returns>True if the list of related PGLI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PGLI> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PGLI by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PGLI</param>
        /// <returns>List of related PGLI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGLI> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PGLI> value;
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
        /// Find PGLI by FILE_ID field
        /// </summary>
        /// <param name="FILE_ID">FILE_ID value used to find PGLI</param>
        /// <returns>List of related PGLI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGLI> FindByFILE_ID(int FILE_ID)
        {
            return Index_FILE_ID.Value[FILE_ID];
        }

        /// <summary>
        /// Attempt to find PGLI by FILE_ID field
        /// </summary>
        /// <param name="FILE_ID">FILE_ID value used to find PGLI</param>
        /// <param name="Value">List of related PGLI entities</param>
        /// <returns>True if the list of related PGLI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFILE_ID(int FILE_ID, out IReadOnlyList<PGLI> Value)
        {
            return Index_FILE_ID.Value.TryGetValue(FILE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find PGLI by FILE_ID field
        /// </summary>
        /// <param name="FILE_ID">FILE_ID value used to find PGLI</param>
        /// <returns>List of related PGLI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PGLI> TryFindByFILE_ID(int FILE_ID)
        {
            IReadOnlyList<PGLI> value;
            if (Index_FILE_ID.Value.TryGetValue(FILE_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PGLI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PGLI</param>
        /// <returns>Related PGLI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PGLI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PGLI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PGLI</param>
        /// <param name="Value">Related PGLI entity</param>
        /// <returns>True if the related PGLI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PGLI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PGLI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PGLI</param>
        /// <returns>Related PGLI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PGLI TryFindByTID(int TID)
        {
            PGLI value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PGLI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PGLI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PGLI](
        [TID] int IDENTITY NOT NULL,
        [FILE_ID] int NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRBATCH] int NOT NULL,
        [TRPERD] int NOT NULL,
        [TRTYPE] varchar(1) NOT NULL,
        [TRDATE] datetime NOT NULL,
        [TRREF] varchar(10) NOT NULL,
        [TRAMT] money NOT NULL,
        [TRDET] varchar(30) NOT NULL,
        [TRXLEDGER] varchar(2) NOT NULL,
        [TRBANK] varchar(10) NULL,
        [PAYEE] varchar(30) NOT NULL,
        [GST_AMOUNT] money NOT NULL,
        [TRNETT] money NOT NULL,
        [TRGROSS] money NOT NULL,
        [WITHHOLD_AMOUNT] money NULL,
        [DEBIT_TOTAL] money NULL,
        [CREDIT_TOTAL] money NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PGLI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PGLI_Index_CODE] ON [dbo].[PGLI]
    (
            [CODE] ASC
    );
    CREATE CLUSTERED INDEX [PGLI_Index_FILE_ID] ON [dbo].[PGLI]
    (
            [FILE_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGLI]') AND name = N'PGLI_Index_CODE')
    ALTER INDEX [PGLI_Index_CODE] ON [dbo].[PGLI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGLI]') AND name = N'PGLI_Index_TID')
    ALTER INDEX [PGLI_Index_TID] ON [dbo].[PGLI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGLI]') AND name = N'PGLI_Index_CODE')
    ALTER INDEX [PGLI_Index_CODE] ON [dbo].[PGLI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PGLI]') AND name = N'PGLI_Index_TID')
    ALTER INDEX [PGLI_Index_TID] ON [dbo].[PGLI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PGLI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PGLI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PGLI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PGLI] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PGLI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PGLI data set</returns>
        public override EduHubDataSetDataReader<PGLI> GetDataSetDataReader()
        {
            return new PGLIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PGLI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PGLI data set</returns>
        public override EduHubDataSetDataReader<PGLI> GetDataSetDataReader(List<PGLI> Entities)
        {
            return new PGLIDataReader(new EduHubDataSetLoadedReader<PGLI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PGLIDataReader : EduHubDataSetDataReader<PGLI>
        {
            public PGLIDataReader(IEduHubDataSetReader<PGLI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 25; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // FILE_ID
                        return Current.FILE_ID;
                    case 2: // CODE
                        return Current.CODE;
                    case 3: // TRBATCH
                        return Current.TRBATCH;
                    case 4: // TRPERD
                        return Current.TRPERD;
                    case 5: // TRTYPE
                        return Current.TRTYPE;
                    case 6: // TRDATE
                        return Current.TRDATE;
                    case 7: // TRREF
                        return Current.TRREF;
                    case 8: // TRAMT
                        return Current.TRAMT;
                    case 9: // TRDET
                        return Current.TRDET;
                    case 10: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 11: // TRBANK
                        return Current.TRBANK;
                    case 12: // PAYEE
                        return Current.PAYEE;
                    case 13: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 14: // TRNETT
                        return Current.TRNETT;
                    case 15: // TRGROSS
                        return Current.TRGROSS;
                    case 16: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT;
                    case 17: // DEBIT_TOTAL
                        return Current.DEBIT_TOTAL;
                    case 18: // CREDIT_TOTAL
                        return Current.CREDIT_TOTAL;
                    case 19: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 20: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 21: // INITIATIVE
                        return Current.INITIATIVE;
                    case 22: // LW_DATE
                        return Current.LW_DATE;
                    case 23: // LW_TIME
                        return Current.LW_TIME;
                    case 24: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 11: // TRBANK
                        return Current.TRBANK == null;
                    case 16: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT == null;
                    case 17: // DEBIT_TOTAL
                        return Current.DEBIT_TOTAL == null;
                    case 18: // CREDIT_TOTAL
                        return Current.CREDIT_TOTAL == null;
                    case 19: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 20: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 21: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 22: // LW_DATE
                        return Current.LW_DATE == null;
                    case 23: // LW_TIME
                        return Current.LW_TIME == null;
                    case 24: // LW_USER
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
                    case 1: // FILE_ID
                        return "FILE_ID";
                    case 2: // CODE
                        return "CODE";
                    case 3: // TRBATCH
                        return "TRBATCH";
                    case 4: // TRPERD
                        return "TRPERD";
                    case 5: // TRTYPE
                        return "TRTYPE";
                    case 6: // TRDATE
                        return "TRDATE";
                    case 7: // TRREF
                        return "TRREF";
                    case 8: // TRAMT
                        return "TRAMT";
                    case 9: // TRDET
                        return "TRDET";
                    case 10: // TRXLEDGER
                        return "TRXLEDGER";
                    case 11: // TRBANK
                        return "TRBANK";
                    case 12: // PAYEE
                        return "PAYEE";
                    case 13: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 14: // TRNETT
                        return "TRNETT";
                    case 15: // TRGROSS
                        return "TRGROSS";
                    case 16: // WITHHOLD_AMOUNT
                        return "WITHHOLD_AMOUNT";
                    case 17: // DEBIT_TOTAL
                        return "DEBIT_TOTAL";
                    case 18: // CREDIT_TOTAL
                        return "CREDIT_TOTAL";
                    case 19: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 20: // GLPROGRAM
                        return "GLPROGRAM";
                    case 21: // INITIATIVE
                        return "INITIATIVE";
                    case 22: // LW_DATE
                        return "LW_DATE";
                    case 23: // LW_TIME
                        return "LW_TIME";
                    case 24: // LW_USER
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
                    case "FILE_ID":
                        return 1;
                    case "CODE":
                        return 2;
                    case "TRBATCH":
                        return 3;
                    case "TRPERD":
                        return 4;
                    case "TRTYPE":
                        return 5;
                    case "TRDATE":
                        return 6;
                    case "TRREF":
                        return 7;
                    case "TRAMT":
                        return 8;
                    case "TRDET":
                        return 9;
                    case "TRXLEDGER":
                        return 10;
                    case "TRBANK":
                        return 11;
                    case "PAYEE":
                        return 12;
                    case "GST_AMOUNT":
                        return 13;
                    case "TRNETT":
                        return 14;
                    case "TRGROSS":
                        return 15;
                    case "WITHHOLD_AMOUNT":
                        return 16;
                    case "DEBIT_TOTAL":
                        return 17;
                    case "CREDIT_TOTAL":
                        return 18;
                    case "SUBPROGRAM":
                        return 19;
                    case "GLPROGRAM":
                        return 20;
                    case "INITIATIVE":
                        return 21;
                    case "LW_DATE":
                        return 22;
                    case "LW_TIME":
                        return 23;
                    case "LW_USER":
                        return 24;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
