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
    /// Bank Account Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KBANKDataSet : EduHubDataSet<KBANK>
    {
        /// <inheritdoc />
        public override string Name { get { return "KBANK"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<Dictionary<string, KBANK>>(() => this.ToDictionary(i => i.GLCODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KBANK" /> fields for each CSV column header</returns>
        internal override Action<KBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLTITLE":
                        mapper[i] = (e, v) => e.GLTITLE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BANK_NAME":
                        mapper[i] = (e, v) => e.BANK_NAME = v;
                        break;
                    case "BANK_BRANCH":
                        mapper[i] = (e, v) => e.BANK_BRANCH = v;
                        break;
                    case "BANK_ADDRESS01":
                        mapper[i] = (e, v) => e.BANK_ADDRESS01 = v;
                        break;
                    case "BANK_ADDRESS02":
                        mapper[i] = (e, v) => e.BANK_ADDRESS02 = v;
                        break;
                    case "BANK_ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.BANK_ACCOUNT_NAME = v;
                        break;
                    case "BANK_ACCOUNT_BSB":
                        mapper[i] = (e, v) => e.BANK_ACCOUNT_BSB = v;
                        break;
                    case "BANK_ACCOUNT_NO":
                        mapper[i] = (e, v) => e.BANK_ACCOUNT_NO = v;
                        break;
                    case "BANK_ABBREVIATION":
                        mapper[i] = (e, v) => e.BANK_ABBREVIATION = v;
                        break;
                    case "APCA_NUMBER":
                        mapper[i] = (e, v) => e.APCA_NUMBER = v;
                        break;
                    case "BALANCE_ENTRY":
                        mapper[i] = (e, v) => e.BALANCE_ENTRY = v;
                        break;
                    case "LAST_RECONCILE_DATE":
                        mapper[i] = (e, v) => e.LAST_RECONCILE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_RECONCILE_DIFF":
                        mapper[i] = (e, v) => e.LAST_RECONCILE_DIFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KBANK" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KBANK" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KBANK" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KBANK}"/> of entities</returns>
        internal override IEnumerable<KBANK> ApplyDeltaEntities(IEnumerable<KBANK> Entities, List<KBANK> DeltaEntities)
        {
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

                            bool overwritten = Index_GLCODE.Remove(entity.GLCODE);
                            
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

        private Lazy<Dictionary<string, KBANK>> Index_GLCODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find KBANK</param>
        /// <returns>Related KBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBANK FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find KBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find KBANK</param>
        /// <param name="Value">Related KBANK entity</param>
        /// <returns>True if the related KBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out KBANK Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find KBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find KBANK</param>
        /// <returns>Related KBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBANK TryFindByGLCODE(string GLCODE)
        {
            KBANK value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KBANK table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KBANK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KBANK](
        [GLCODE] varchar(10) NOT NULL,
        [GLTITLE] varchar(25) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [BANK_NAME] varchar(23) NULL,
        [BANK_BRANCH] varchar(25) NULL,
        [BANK_ADDRESS01] varchar(30) NULL,
        [BANK_ADDRESS02] varchar(30) NULL,
        [BANK_ACCOUNT_NAME] varchar(45) NULL,
        [BANK_ACCOUNT_BSB] varchar(6) NULL,
        [BANK_ACCOUNT_NO] varchar(15) NULL,
        [BANK_ABBREVIATION] varchar(3) NULL,
        [APCA_NUMBER] varchar(6) NULL,
        [BALANCE_ENTRY] varchar(1) NULL,
        [LAST_RECONCILE_DATE] datetime NULL,
        [LAST_RECONCILE_DIFF] money NULL,
        [ACTIVE] varchar(1) NULL,
        [ACCOUNT_TYPE] smallint NULL,
        [INTEREST_RATE] float NULL,
        [INVESTMENT_DATE] datetime NULL,
        [MATURITY_DATE] datetime NULL,
        [INTEREST_EARNED] money NULL,
        [COMMENTS] varchar(200) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KBANK_Index_GLCODE] PRIMARY KEY CLUSTERED (
            [GLCODE] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KBANKDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KBANKDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KBANK"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KBANK"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KBANK> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_GLCODE = new List<string>();

            foreach (var entity in Entities)
            {
                Index_GLCODE.Add(entity.GLCODE);
            }

            builder.AppendLine("DELETE [dbo].[KBANK] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBANK data set</returns>
        public override EduHubDataSetDataReader<KBANK> GetDataSetDataReader()
        {
            return new KBANKDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBANK data set</returns>
        public override EduHubDataSetDataReader<KBANK> GetDataSetDataReader(List<KBANK> Entities)
        {
            return new KBANKDataReader(new EduHubDataSetLoadedReader<KBANK>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KBANKDataReader : EduHubDataSetDataReader<KBANK>
        {
            public KBANKDataReader(IEduHubDataSetReader<KBANK> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 25; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // GLCODE
                        return Current.GLCODE;
                    case 1: // GLTITLE
                        return Current.GLTITLE;
                    case 2: // BILLER_CODE
                        return Current.BILLER_CODE;
                    case 3: // BANK_NAME
                        return Current.BANK_NAME;
                    case 4: // BANK_BRANCH
                        return Current.BANK_BRANCH;
                    case 5: // BANK_ADDRESS01
                        return Current.BANK_ADDRESS01;
                    case 6: // BANK_ADDRESS02
                        return Current.BANK_ADDRESS02;
                    case 7: // BANK_ACCOUNT_NAME
                        return Current.BANK_ACCOUNT_NAME;
                    case 8: // BANK_ACCOUNT_BSB
                        return Current.BANK_ACCOUNT_BSB;
                    case 9: // BANK_ACCOUNT_NO
                        return Current.BANK_ACCOUNT_NO;
                    case 10: // BANK_ABBREVIATION
                        return Current.BANK_ABBREVIATION;
                    case 11: // APCA_NUMBER
                        return Current.APCA_NUMBER;
                    case 12: // BALANCE_ENTRY
                        return Current.BALANCE_ENTRY;
                    case 13: // LAST_RECONCILE_DATE
                        return Current.LAST_RECONCILE_DATE;
                    case 14: // LAST_RECONCILE_DIFF
                        return Current.LAST_RECONCILE_DIFF;
                    case 15: // ACTIVE
                        return Current.ACTIVE;
                    case 16: // ACCOUNT_TYPE
                        return Current.ACCOUNT_TYPE;
                    case 17: // INTEREST_RATE
                        return Current.INTEREST_RATE;
                    case 18: // INVESTMENT_DATE
                        return Current.INVESTMENT_DATE;
                    case 19: // MATURITY_DATE
                        return Current.MATURITY_DATE;
                    case 20: // INTEREST_EARNED
                        return Current.INTEREST_EARNED;
                    case 21: // COMMENTS
                        return Current.COMMENTS;
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
                    case 1: // GLTITLE
                        return Current.GLTITLE == null;
                    case 2: // BILLER_CODE
                        return Current.BILLER_CODE == null;
                    case 3: // BANK_NAME
                        return Current.BANK_NAME == null;
                    case 4: // BANK_BRANCH
                        return Current.BANK_BRANCH == null;
                    case 5: // BANK_ADDRESS01
                        return Current.BANK_ADDRESS01 == null;
                    case 6: // BANK_ADDRESS02
                        return Current.BANK_ADDRESS02 == null;
                    case 7: // BANK_ACCOUNT_NAME
                        return Current.BANK_ACCOUNT_NAME == null;
                    case 8: // BANK_ACCOUNT_BSB
                        return Current.BANK_ACCOUNT_BSB == null;
                    case 9: // BANK_ACCOUNT_NO
                        return Current.BANK_ACCOUNT_NO == null;
                    case 10: // BANK_ABBREVIATION
                        return Current.BANK_ABBREVIATION == null;
                    case 11: // APCA_NUMBER
                        return Current.APCA_NUMBER == null;
                    case 12: // BALANCE_ENTRY
                        return Current.BALANCE_ENTRY == null;
                    case 13: // LAST_RECONCILE_DATE
                        return Current.LAST_RECONCILE_DATE == null;
                    case 14: // LAST_RECONCILE_DIFF
                        return Current.LAST_RECONCILE_DIFF == null;
                    case 15: // ACTIVE
                        return Current.ACTIVE == null;
                    case 16: // ACCOUNT_TYPE
                        return Current.ACCOUNT_TYPE == null;
                    case 17: // INTEREST_RATE
                        return Current.INTEREST_RATE == null;
                    case 18: // INVESTMENT_DATE
                        return Current.INVESTMENT_DATE == null;
                    case 19: // MATURITY_DATE
                        return Current.MATURITY_DATE == null;
                    case 20: // INTEREST_EARNED
                        return Current.INTEREST_EARNED == null;
                    case 21: // COMMENTS
                        return Current.COMMENTS == null;
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
                    case 0: // GLCODE
                        return "GLCODE";
                    case 1: // GLTITLE
                        return "GLTITLE";
                    case 2: // BILLER_CODE
                        return "BILLER_CODE";
                    case 3: // BANK_NAME
                        return "BANK_NAME";
                    case 4: // BANK_BRANCH
                        return "BANK_BRANCH";
                    case 5: // BANK_ADDRESS01
                        return "BANK_ADDRESS01";
                    case 6: // BANK_ADDRESS02
                        return "BANK_ADDRESS02";
                    case 7: // BANK_ACCOUNT_NAME
                        return "BANK_ACCOUNT_NAME";
                    case 8: // BANK_ACCOUNT_BSB
                        return "BANK_ACCOUNT_BSB";
                    case 9: // BANK_ACCOUNT_NO
                        return "BANK_ACCOUNT_NO";
                    case 10: // BANK_ABBREVIATION
                        return "BANK_ABBREVIATION";
                    case 11: // APCA_NUMBER
                        return "APCA_NUMBER";
                    case 12: // BALANCE_ENTRY
                        return "BALANCE_ENTRY";
                    case 13: // LAST_RECONCILE_DATE
                        return "LAST_RECONCILE_DATE";
                    case 14: // LAST_RECONCILE_DIFF
                        return "LAST_RECONCILE_DIFF";
                    case 15: // ACTIVE
                        return "ACTIVE";
                    case 16: // ACCOUNT_TYPE
                        return "ACCOUNT_TYPE";
                    case 17: // INTEREST_RATE
                        return "INTEREST_RATE";
                    case 18: // INVESTMENT_DATE
                        return "INVESTMENT_DATE";
                    case 19: // MATURITY_DATE
                        return "MATURITY_DATE";
                    case 20: // INTEREST_EARNED
                        return "INTEREST_EARNED";
                    case 21: // COMMENTS
                        return "COMMENTS";
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
                    case "GLCODE":
                        return 0;
                    case "GLTITLE":
                        return 1;
                    case "BILLER_CODE":
                        return 2;
                    case "BANK_NAME":
                        return 3;
                    case "BANK_BRANCH":
                        return 4;
                    case "BANK_ADDRESS01":
                        return 5;
                    case "BANK_ADDRESS02":
                        return 6;
                    case "BANK_ACCOUNT_NAME":
                        return 7;
                    case "BANK_ACCOUNT_BSB":
                        return 8;
                    case "BANK_ACCOUNT_NO":
                        return 9;
                    case "BANK_ABBREVIATION":
                        return 10;
                    case "APCA_NUMBER":
                        return 11;
                    case "BALANCE_ENTRY":
                        return 12;
                    case "LAST_RECONCILE_DATE":
                        return 13;
                    case "LAST_RECONCILE_DIFF":
                        return 14;
                    case "ACTIVE":
                        return 15;
                    case "ACCOUNT_TYPE":
                        return 16;
                    case "INTEREST_RATE":
                        return 17;
                    case "INVESTMENT_DATE":
                        return 18;
                    case "MATURITY_DATE":
                        return 19;
                    case "INTEREST_EARNED":
                        return 20;
                    case "COMMENTS":
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
