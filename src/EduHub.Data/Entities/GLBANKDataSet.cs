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
    /// Bank Account Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBANKDataSet : EduHubDataSet<GLBANK>
    {
        /// <inheritdoc />
        public override string Name { get { return "GLBANK"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal GLBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLBANKKEY = new Lazy<Dictionary<int, GLBANK>>(() => this.ToDictionary(i => i.GLBANKKEY));
            Index_GLCODE = new Lazy<Dictionary<string, GLBANK>>(() => this.ToDictionary(i => i.GLCODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLBANK" /> fields for each CSV column header</returns>
        internal override Action<GLBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANKKEY":
                        mapper[i] = (e, v) => e.GLBANKKEY = int.Parse(v);
                        break;
                    case "ACCOUNT_TYPE":
                        mapper[i] = (e, v) => e.ACCOUNT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INTEREST_RATE":
                        mapper[i] = (e, v) => e.INTEREST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "INVESTMENT_DATE":
                        mapper[i] = (e, v) => e.INVESTMENT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "MATURITY_DATE":
                        mapper[i] = (e, v) => e.MATURITY_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "INTEREST_EARNED":
                        mapper[i] = (e, v) => e.INTEREST_EARNED = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "COMMENTS_COMMIT":
                        mapper[i] = (e, v) => e.COMMENTS_COMMIT = v;
                        break;
                    case "TOTAL_BANK_BALANCE":
                        mapper[i] = (e, v) => e.TOTAL_BANK_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_BANK_BALANCE":
                        mapper[i] = (e, v) => e.LY_BANK_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CASH_GRANT":
                        mapper[i] = (e, v) => e.CASH_GRANT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_CASH_GRANT":
                        mapper[i] = (e, v) => e.LY_CASH_GRANT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPERATING_RESERVE":
                        mapper[i] = (e, v) => e.OPERATING_RESERVE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_OPERATING_RESERVE":
                        mapper[i] = (e, v) => e.LY_OPERATING_RESERVE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLBANK" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="GLBANK" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="GLBANK" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{GLBANK}"/> of entities</returns>
        internal override IEnumerable<GLBANK> ApplyDeltaEntities(IEnumerable<GLBANK> Entities, List<GLBANK> DeltaEntities)
        {
            HashSet<int> Index_GLBANKKEY = new HashSet<int>(DeltaEntities.Select(i => i.GLBANKKEY));
            HashSet<string> Index_GLCODE = new HashSet<string>(DeltaEntities.Select(i => i.GLCODE));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GLCODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_GLBANKKEY.Remove(entity.GLBANKKEY);
                            overwritten = overwritten || Index_GLCODE.Remove(entity.GLCODE);
                            
                            if (entity.GLCODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, GLBANK>> Index_GLBANKKEY;
        private Lazy<Dictionary<string, GLBANK>> Index_GLCODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLBANK by GLBANKKEY field
        /// </summary>
        /// <param name="GLBANKKEY">GLBANKKEY value used to find GLBANK</param>
        /// <returns>Related GLBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK FindByGLBANKKEY(int GLBANKKEY)
        {
            return Index_GLBANKKEY.Value[GLBANKKEY];
        }

        /// <summary>
        /// Attempt to find GLBANK by GLBANKKEY field
        /// </summary>
        /// <param name="GLBANKKEY">GLBANKKEY value used to find GLBANK</param>
        /// <param name="Value">Related GLBANK entity</param>
        /// <returns>True if the related GLBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANKKEY(int GLBANKKEY, out GLBANK Value)
        {
            return Index_GLBANKKEY.Value.TryGetValue(GLBANKKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLBANK by GLBANKKEY field
        /// </summary>
        /// <param name="GLBANKKEY">GLBANKKEY value used to find GLBANK</param>
        /// <returns>Related GLBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK TryFindByGLBANKKEY(int GLBANKKEY)
        {
            GLBANK value;
            if (Index_GLBANKKEY.Value.TryGetValue(GLBANKKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find GLBANK</param>
        /// <returns>Related GLBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find GLBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find GLBANK</param>
        /// <param name="Value">Related GLBANK entity</param>
        /// <returns>True if the related GLBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out GLBANK Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find GLBANK</param>
        /// <returns>Related GLBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK TryFindByGLCODE(string GLCODE)
        {
            GLBANK value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a GLBANK table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLBANK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLBANK](
        [GLCODE] varchar(10) NOT NULL,
        [GLBANKKEY] int IDENTITY NOT NULL,
        [ACCOUNT_TYPE] smallint NULL,
        [INTEREST_RATE] float NULL,
        [INVESTMENT_DATE] datetime NULL,
        [MATURITY_DATE] datetime NULL,
        [INTEREST_EARNED] money NULL,
        [COMMENTS] varchar(250) NULL,
        [COMMENTS_COMMIT] varchar(250) NULL,
        [TOTAL_BANK_BALANCE] money NULL,
        [LY_BANK_BALANCE] money NULL,
        [CASH_GRANT] money NULL,
        [LY_CASH_GRANT] money NULL,
        [OPERATING_RESERVE] money NULL,
        [LY_OPERATING_RESERVE] money NULL,
        [CURR01] money NULL,
        [CURR02] money NULL,
        [CURR03] money NULL,
        [CURR04] money NULL,
        [CURR05] money NULL,
        [CURR06] money NULL,
        [CURR07] money NULL,
        [CURR08] money NULL,
        [CURR09] money NULL,
        [CURR10] money NULL,
        [CURR11] money NULL,
        [CURR12] money NULL,
        [LASTYR01] money NULL,
        [LASTYR02] money NULL,
        [LASTYR03] money NULL,
        [LASTYR04] money NULL,
        [LASTYR05] money NULL,
        [LASTYR06] money NULL,
        [LASTYR07] money NULL,
        [LASTYR08] money NULL,
        [LASTYR09] money NULL,
        [LASTYR10] money NULL,
        [LASTYR11] money NULL,
        [LASTYR12] money NULL,
        [OPBAL] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLBANK_Index_GLCODE] PRIMARY KEY CLUSTERED (
            [GLCODE] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [GLBANK_Index_GLBANKKEY] ON [dbo].[GLBANK]
    (
            [GLBANKKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLBANK]') AND name = N'Index_GLBANKKEY')
    ALTER INDEX [Index_GLBANKKEY] ON [dbo].[GLBANK] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLBANK]') AND name = N'Index_GLBANKKEY')
    ALTER INDEX [Index_GLBANKKEY] ON [dbo].[GLBANK] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="GLBANK"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="GLBANK"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<GLBANK> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_GLBANKKEY = new List<int>();
            List<string> Index_GLCODE = new List<string>();

            foreach (var entity in Entities)
            {
                Index_GLBANKKEY.Add(entity.GLBANKKEY);
                Index_GLCODE.Add(entity.GLCODE);
            }

            builder.AppendLine("DELETE [dbo].[GLBANK] WHERE");


            // Index_GLBANKKEY
            builder.Append("[GLBANKKEY] IN (");
            for (int index = 0; index < Index_GLBANKKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // GLBANKKEY
                var parameterGLBANKKEY = $"@p{parameterIndex++}";
                builder.Append(parameterGLBANKKEY);
                command.Parameters.Add(parameterGLBANKKEY, SqlDbType.Int).Value = Index_GLBANKKEY[index];
            }
            builder.AppendLine(") OR");

            // Index_GLCODE
            builder.Append("[GLCODE] IN (");
            for (int index = 0; index < Index_GLCODE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // GLCODE
                var parameterGLCODE = $"@p{parameterIndex++}";
                builder.Append(parameterGLCODE);
                command.Parameters.Add(parameterGLCODE, SqlDbType.VarChar, 10).Value = Index_GLCODE[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLBANK data set</returns>
        public override EduHubDataSetDataReader<GLBANK> GetDataSetDataReader()
        {
            return new GLBANKDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLBANK data set</returns>
        public override EduHubDataSetDataReader<GLBANK> GetDataSetDataReader(List<GLBANK> Entities)
        {
            return new GLBANKDataReader(new EduHubDataSetLoadedReader<GLBANK>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLBANKDataReader : EduHubDataSetDataReader<GLBANK>
        {
            public GLBANKDataReader(IEduHubDataSetReader<GLBANK> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 43; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // GLCODE
                        return Current.GLCODE;
                    case 1: // GLBANKKEY
                        return Current.GLBANKKEY;
                    case 2: // ACCOUNT_TYPE
                        return Current.ACCOUNT_TYPE;
                    case 3: // INTEREST_RATE
                        return Current.INTEREST_RATE;
                    case 4: // INVESTMENT_DATE
                        return Current.INVESTMENT_DATE;
                    case 5: // MATURITY_DATE
                        return Current.MATURITY_DATE;
                    case 6: // INTEREST_EARNED
                        return Current.INTEREST_EARNED;
                    case 7: // COMMENTS
                        return Current.COMMENTS;
                    case 8: // COMMENTS_COMMIT
                        return Current.COMMENTS_COMMIT;
                    case 9: // TOTAL_BANK_BALANCE
                        return Current.TOTAL_BANK_BALANCE;
                    case 10: // LY_BANK_BALANCE
                        return Current.LY_BANK_BALANCE;
                    case 11: // CASH_GRANT
                        return Current.CASH_GRANT;
                    case 12: // LY_CASH_GRANT
                        return Current.LY_CASH_GRANT;
                    case 13: // OPERATING_RESERVE
                        return Current.OPERATING_RESERVE;
                    case 14: // LY_OPERATING_RESERVE
                        return Current.LY_OPERATING_RESERVE;
                    case 15: // CURR01
                        return Current.CURR01;
                    case 16: // CURR02
                        return Current.CURR02;
                    case 17: // CURR03
                        return Current.CURR03;
                    case 18: // CURR04
                        return Current.CURR04;
                    case 19: // CURR05
                        return Current.CURR05;
                    case 20: // CURR06
                        return Current.CURR06;
                    case 21: // CURR07
                        return Current.CURR07;
                    case 22: // CURR08
                        return Current.CURR08;
                    case 23: // CURR09
                        return Current.CURR09;
                    case 24: // CURR10
                        return Current.CURR10;
                    case 25: // CURR11
                        return Current.CURR11;
                    case 26: // CURR12
                        return Current.CURR12;
                    case 27: // LASTYR01
                        return Current.LASTYR01;
                    case 28: // LASTYR02
                        return Current.LASTYR02;
                    case 29: // LASTYR03
                        return Current.LASTYR03;
                    case 30: // LASTYR04
                        return Current.LASTYR04;
                    case 31: // LASTYR05
                        return Current.LASTYR05;
                    case 32: // LASTYR06
                        return Current.LASTYR06;
                    case 33: // LASTYR07
                        return Current.LASTYR07;
                    case 34: // LASTYR08
                        return Current.LASTYR08;
                    case 35: // LASTYR09
                        return Current.LASTYR09;
                    case 36: // LASTYR10
                        return Current.LASTYR10;
                    case 37: // LASTYR11
                        return Current.LASTYR11;
                    case 38: // LASTYR12
                        return Current.LASTYR12;
                    case 39: // OPBAL
                        return Current.OPBAL;
                    case 40: // LW_DATE
                        return Current.LW_DATE;
                    case 41: // LW_TIME
                        return Current.LW_TIME;
                    case 42: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ACCOUNT_TYPE
                        return Current.ACCOUNT_TYPE == null;
                    case 3: // INTEREST_RATE
                        return Current.INTEREST_RATE == null;
                    case 4: // INVESTMENT_DATE
                        return Current.INVESTMENT_DATE == null;
                    case 5: // MATURITY_DATE
                        return Current.MATURITY_DATE == null;
                    case 6: // INTEREST_EARNED
                        return Current.INTEREST_EARNED == null;
                    case 7: // COMMENTS
                        return Current.COMMENTS == null;
                    case 8: // COMMENTS_COMMIT
                        return Current.COMMENTS_COMMIT == null;
                    case 9: // TOTAL_BANK_BALANCE
                        return Current.TOTAL_BANK_BALANCE == null;
                    case 10: // LY_BANK_BALANCE
                        return Current.LY_BANK_BALANCE == null;
                    case 11: // CASH_GRANT
                        return Current.CASH_GRANT == null;
                    case 12: // LY_CASH_GRANT
                        return Current.LY_CASH_GRANT == null;
                    case 13: // OPERATING_RESERVE
                        return Current.OPERATING_RESERVE == null;
                    case 14: // LY_OPERATING_RESERVE
                        return Current.LY_OPERATING_RESERVE == null;
                    case 15: // CURR01
                        return Current.CURR01 == null;
                    case 16: // CURR02
                        return Current.CURR02 == null;
                    case 17: // CURR03
                        return Current.CURR03 == null;
                    case 18: // CURR04
                        return Current.CURR04 == null;
                    case 19: // CURR05
                        return Current.CURR05 == null;
                    case 20: // CURR06
                        return Current.CURR06 == null;
                    case 21: // CURR07
                        return Current.CURR07 == null;
                    case 22: // CURR08
                        return Current.CURR08 == null;
                    case 23: // CURR09
                        return Current.CURR09 == null;
                    case 24: // CURR10
                        return Current.CURR10 == null;
                    case 25: // CURR11
                        return Current.CURR11 == null;
                    case 26: // CURR12
                        return Current.CURR12 == null;
                    case 27: // LASTYR01
                        return Current.LASTYR01 == null;
                    case 28: // LASTYR02
                        return Current.LASTYR02 == null;
                    case 29: // LASTYR03
                        return Current.LASTYR03 == null;
                    case 30: // LASTYR04
                        return Current.LASTYR04 == null;
                    case 31: // LASTYR05
                        return Current.LASTYR05 == null;
                    case 32: // LASTYR06
                        return Current.LASTYR06 == null;
                    case 33: // LASTYR07
                        return Current.LASTYR07 == null;
                    case 34: // LASTYR08
                        return Current.LASTYR08 == null;
                    case 35: // LASTYR09
                        return Current.LASTYR09 == null;
                    case 36: // LASTYR10
                        return Current.LASTYR10 == null;
                    case 37: // LASTYR11
                        return Current.LASTYR11 == null;
                    case 38: // LASTYR12
                        return Current.LASTYR12 == null;
                    case 39: // OPBAL
                        return Current.OPBAL == null;
                    case 40: // LW_DATE
                        return Current.LW_DATE == null;
                    case 41: // LW_TIME
                        return Current.LW_TIME == null;
                    case 42: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // GLCODE
                        return "GLCODE";
                    case 1: // GLBANKKEY
                        return "GLBANKKEY";
                    case 2: // ACCOUNT_TYPE
                        return "ACCOUNT_TYPE";
                    case 3: // INTEREST_RATE
                        return "INTEREST_RATE";
                    case 4: // INVESTMENT_DATE
                        return "INVESTMENT_DATE";
                    case 5: // MATURITY_DATE
                        return "MATURITY_DATE";
                    case 6: // INTEREST_EARNED
                        return "INTEREST_EARNED";
                    case 7: // COMMENTS
                        return "COMMENTS";
                    case 8: // COMMENTS_COMMIT
                        return "COMMENTS_COMMIT";
                    case 9: // TOTAL_BANK_BALANCE
                        return "TOTAL_BANK_BALANCE";
                    case 10: // LY_BANK_BALANCE
                        return "LY_BANK_BALANCE";
                    case 11: // CASH_GRANT
                        return "CASH_GRANT";
                    case 12: // LY_CASH_GRANT
                        return "LY_CASH_GRANT";
                    case 13: // OPERATING_RESERVE
                        return "OPERATING_RESERVE";
                    case 14: // LY_OPERATING_RESERVE
                        return "LY_OPERATING_RESERVE";
                    case 15: // CURR01
                        return "CURR01";
                    case 16: // CURR02
                        return "CURR02";
                    case 17: // CURR03
                        return "CURR03";
                    case 18: // CURR04
                        return "CURR04";
                    case 19: // CURR05
                        return "CURR05";
                    case 20: // CURR06
                        return "CURR06";
                    case 21: // CURR07
                        return "CURR07";
                    case 22: // CURR08
                        return "CURR08";
                    case 23: // CURR09
                        return "CURR09";
                    case 24: // CURR10
                        return "CURR10";
                    case 25: // CURR11
                        return "CURR11";
                    case 26: // CURR12
                        return "CURR12";
                    case 27: // LASTYR01
                        return "LASTYR01";
                    case 28: // LASTYR02
                        return "LASTYR02";
                    case 29: // LASTYR03
                        return "LASTYR03";
                    case 30: // LASTYR04
                        return "LASTYR04";
                    case 31: // LASTYR05
                        return "LASTYR05";
                    case 32: // LASTYR06
                        return "LASTYR06";
                    case 33: // LASTYR07
                        return "LASTYR07";
                    case 34: // LASTYR08
                        return "LASTYR08";
                    case 35: // LASTYR09
                        return "LASTYR09";
                    case 36: // LASTYR10
                        return "LASTYR10";
                    case 37: // LASTYR11
                        return "LASTYR11";
                    case 38: // LASTYR12
                        return "LASTYR12";
                    case 39: // OPBAL
                        return "OPBAL";
                    case 40: // LW_DATE
                        return "LW_DATE";
                    case 41: // LW_TIME
                        return "LW_TIME";
                    case 42: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "GLCODE":
                        return 0;
                    case "GLBANKKEY":
                        return 1;
                    case "ACCOUNT_TYPE":
                        return 2;
                    case "INTEREST_RATE":
                        return 3;
                    case "INVESTMENT_DATE":
                        return 4;
                    case "MATURITY_DATE":
                        return 5;
                    case "INTEREST_EARNED":
                        return 6;
                    case "COMMENTS":
                        return 7;
                    case "COMMENTS_COMMIT":
                        return 8;
                    case "TOTAL_BANK_BALANCE":
                        return 9;
                    case "LY_BANK_BALANCE":
                        return 10;
                    case "CASH_GRANT":
                        return 11;
                    case "LY_CASH_GRANT":
                        return 12;
                    case "OPERATING_RESERVE":
                        return 13;
                    case "LY_OPERATING_RESERVE":
                        return 14;
                    case "CURR01":
                        return 15;
                    case "CURR02":
                        return 16;
                    case "CURR03":
                        return 17;
                    case "CURR04":
                        return 18;
                    case "CURR05":
                        return 19;
                    case "CURR06":
                        return 20;
                    case "CURR07":
                        return 21;
                    case "CURR08":
                        return 22;
                    case "CURR09":
                        return 23;
                    case "CURR10":
                        return 24;
                    case "CURR11":
                        return 25;
                    case "CURR12":
                        return 26;
                    case "LASTYR01":
                        return 27;
                    case "LASTYR02":
                        return 28;
                    case "LASTYR03":
                        return 29;
                    case "LASTYR04":
                        return 30;
                    case "LASTYR05":
                        return 31;
                    case "LASTYR06":
                        return 32;
                    case "LASTYR07":
                        return 33;
                    case "LASTYR08":
                        return 34;
                    case "LASTYR09":
                        return 35;
                    case "LASTYR10":
                        return 36;
                    case "LASTYR11":
                        return 37;
                    case "LASTYR12":
                        return 38;
                    case "OPBAL":
                        return 39;
                    case "LW_DATE":
                        return 40;
                    case "LW_TIME":
                        return 41;
                    case "LW_USER":
                        return 42;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
