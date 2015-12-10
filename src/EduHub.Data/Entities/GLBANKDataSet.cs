using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBANKDataSet : DataSetBase<GLBANK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLBANK"; } }

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
        protected override Action<GLBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.INVESTMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MATURITY_DATE":
                        mapper[i] = (e, v) => e.MATURITY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INTEREST_EARNED":
                        mapper[i] = (e, v) => e.INTEREST_EARNED = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
        /// Merges <see cref="GLBANK" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLBANK" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLBANK" /> items to added or update the base <see cref="GLBANK" /> items</param>
        /// <returns>A merged list of <see cref="GLBANK" /> items</returns>
        protected override List<GLBANK> ApplyDeltaItems(List<GLBANK> Items, List<GLBANK> DeltaItems)
        {
            Dictionary<int, int> Index_GLBANKKEY = Items.ToIndexDictionary(i => i.GLBANKKEY);
            Dictionary<string, int> Index_GLCODE = Items.ToIndexDictionary(i => i.GLCODE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLBANK deltaItem in DeltaItems)
            {
                int index;

                if (Index_GLBANKKEY.TryGetValue(deltaItem.GLBANKKEY, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_GLCODE.TryGetValue(deltaItem.GLCODE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.GLCODE)
                .ToList();
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
        /// Returns SQL which checks for the existence of a GLBANK table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLBANK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
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
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLBANK data set</returns>
        public override IDataReader GetDataReader()
        {
            return new GLBANKDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLBANKDataReader : IDataReader, IDataRecord
        {
            private List<GLBANK> Items;
            private int CurrentIndex;
            private GLBANK CurrentItem;

            public GLBANKDataReader(List<GLBANK> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 42; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // GLCODE
                        return CurrentItem.GLCODE;
                    case 1: // GLBANKKEY
                        return CurrentItem.GLBANKKEY;
                    case 2: // ACCOUNT_TYPE
                        return CurrentItem.ACCOUNT_TYPE;
                    case 3: // INTEREST_RATE
                        return CurrentItem.INTEREST_RATE;
                    case 4: // INVESTMENT_DATE
                        return CurrentItem.INVESTMENT_DATE;
                    case 5: // MATURITY_DATE
                        return CurrentItem.MATURITY_DATE;
                    case 6: // INTEREST_EARNED
                        return CurrentItem.INTEREST_EARNED;
                    case 7: // COMMENTS
                        return CurrentItem.COMMENTS;
                    case 8: // TOTAL_BANK_BALANCE
                        return CurrentItem.TOTAL_BANK_BALANCE;
                    case 9: // LY_BANK_BALANCE
                        return CurrentItem.LY_BANK_BALANCE;
                    case 10: // CASH_GRANT
                        return CurrentItem.CASH_GRANT;
                    case 11: // LY_CASH_GRANT
                        return CurrentItem.LY_CASH_GRANT;
                    case 12: // OPERATING_RESERVE
                        return CurrentItem.OPERATING_RESERVE;
                    case 13: // LY_OPERATING_RESERVE
                        return CurrentItem.LY_OPERATING_RESERVE;
                    case 14: // CURR01
                        return CurrentItem.CURR01;
                    case 15: // CURR02
                        return CurrentItem.CURR02;
                    case 16: // CURR03
                        return CurrentItem.CURR03;
                    case 17: // CURR04
                        return CurrentItem.CURR04;
                    case 18: // CURR05
                        return CurrentItem.CURR05;
                    case 19: // CURR06
                        return CurrentItem.CURR06;
                    case 20: // CURR07
                        return CurrentItem.CURR07;
                    case 21: // CURR08
                        return CurrentItem.CURR08;
                    case 22: // CURR09
                        return CurrentItem.CURR09;
                    case 23: // CURR10
                        return CurrentItem.CURR10;
                    case 24: // CURR11
                        return CurrentItem.CURR11;
                    case 25: // CURR12
                        return CurrentItem.CURR12;
                    case 26: // LASTYR01
                        return CurrentItem.LASTYR01;
                    case 27: // LASTYR02
                        return CurrentItem.LASTYR02;
                    case 28: // LASTYR03
                        return CurrentItem.LASTYR03;
                    case 29: // LASTYR04
                        return CurrentItem.LASTYR04;
                    case 30: // LASTYR05
                        return CurrentItem.LASTYR05;
                    case 31: // LASTYR06
                        return CurrentItem.LASTYR06;
                    case 32: // LASTYR07
                        return CurrentItem.LASTYR07;
                    case 33: // LASTYR08
                        return CurrentItem.LASTYR08;
                    case 34: // LASTYR09
                        return CurrentItem.LASTYR09;
                    case 35: // LASTYR10
                        return CurrentItem.LASTYR10;
                    case 36: // LASTYR11
                        return CurrentItem.LASTYR11;
                    case 37: // LASTYR12
                        return CurrentItem.LASTYR12;
                    case 38: // OPBAL
                        return CurrentItem.OPBAL;
                    case 39: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 40: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 41: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ACCOUNT_TYPE
                        return CurrentItem.ACCOUNT_TYPE == null;
                    case 3: // INTEREST_RATE
                        return CurrentItem.INTEREST_RATE == null;
                    case 4: // INVESTMENT_DATE
                        return CurrentItem.INVESTMENT_DATE == null;
                    case 5: // MATURITY_DATE
                        return CurrentItem.MATURITY_DATE == null;
                    case 6: // INTEREST_EARNED
                        return CurrentItem.INTEREST_EARNED == null;
                    case 7: // COMMENTS
                        return CurrentItem.COMMENTS == null;
                    case 8: // TOTAL_BANK_BALANCE
                        return CurrentItem.TOTAL_BANK_BALANCE == null;
                    case 9: // LY_BANK_BALANCE
                        return CurrentItem.LY_BANK_BALANCE == null;
                    case 10: // CASH_GRANT
                        return CurrentItem.CASH_GRANT == null;
                    case 11: // LY_CASH_GRANT
                        return CurrentItem.LY_CASH_GRANT == null;
                    case 12: // OPERATING_RESERVE
                        return CurrentItem.OPERATING_RESERVE == null;
                    case 13: // LY_OPERATING_RESERVE
                        return CurrentItem.LY_OPERATING_RESERVE == null;
                    case 14: // CURR01
                        return CurrentItem.CURR01 == null;
                    case 15: // CURR02
                        return CurrentItem.CURR02 == null;
                    case 16: // CURR03
                        return CurrentItem.CURR03 == null;
                    case 17: // CURR04
                        return CurrentItem.CURR04 == null;
                    case 18: // CURR05
                        return CurrentItem.CURR05 == null;
                    case 19: // CURR06
                        return CurrentItem.CURR06 == null;
                    case 20: // CURR07
                        return CurrentItem.CURR07 == null;
                    case 21: // CURR08
                        return CurrentItem.CURR08 == null;
                    case 22: // CURR09
                        return CurrentItem.CURR09 == null;
                    case 23: // CURR10
                        return CurrentItem.CURR10 == null;
                    case 24: // CURR11
                        return CurrentItem.CURR11 == null;
                    case 25: // CURR12
                        return CurrentItem.CURR12 == null;
                    case 26: // LASTYR01
                        return CurrentItem.LASTYR01 == null;
                    case 27: // LASTYR02
                        return CurrentItem.LASTYR02 == null;
                    case 28: // LASTYR03
                        return CurrentItem.LASTYR03 == null;
                    case 29: // LASTYR04
                        return CurrentItem.LASTYR04 == null;
                    case 30: // LASTYR05
                        return CurrentItem.LASTYR05 == null;
                    case 31: // LASTYR06
                        return CurrentItem.LASTYR06 == null;
                    case 32: // LASTYR07
                        return CurrentItem.LASTYR07 == null;
                    case 33: // LASTYR08
                        return CurrentItem.LASTYR08 == null;
                    case 34: // LASTYR09
                        return CurrentItem.LASTYR09 == null;
                    case 35: // LASTYR10
                        return CurrentItem.LASTYR10 == null;
                    case 36: // LASTYR11
                        return CurrentItem.LASTYR11 == null;
                    case 37: // LASTYR12
                        return CurrentItem.LASTYR12 == null;
                    case 38: // OPBAL
                        return CurrentItem.OPBAL == null;
                    case 39: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 40: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 41: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
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
                    case 8: // TOTAL_BANK_BALANCE
                        return "TOTAL_BANK_BALANCE";
                    case 9: // LY_BANK_BALANCE
                        return "LY_BANK_BALANCE";
                    case 10: // CASH_GRANT
                        return "CASH_GRANT";
                    case 11: // LY_CASH_GRANT
                        return "LY_CASH_GRANT";
                    case 12: // OPERATING_RESERVE
                        return "OPERATING_RESERVE";
                    case 13: // LY_OPERATING_RESERVE
                        return "LY_OPERATING_RESERVE";
                    case 14: // CURR01
                        return "CURR01";
                    case 15: // CURR02
                        return "CURR02";
                    case 16: // CURR03
                        return "CURR03";
                    case 17: // CURR04
                        return "CURR04";
                    case 18: // CURR05
                        return "CURR05";
                    case 19: // CURR06
                        return "CURR06";
                    case 20: // CURR07
                        return "CURR07";
                    case 21: // CURR08
                        return "CURR08";
                    case 22: // CURR09
                        return "CURR09";
                    case 23: // CURR10
                        return "CURR10";
                    case 24: // CURR11
                        return "CURR11";
                    case 25: // CURR12
                        return "CURR12";
                    case 26: // LASTYR01
                        return "LASTYR01";
                    case 27: // LASTYR02
                        return "LASTYR02";
                    case 28: // LASTYR03
                        return "LASTYR03";
                    case 29: // LASTYR04
                        return "LASTYR04";
                    case 30: // LASTYR05
                        return "LASTYR05";
                    case 31: // LASTYR06
                        return "LASTYR06";
                    case 32: // LASTYR07
                        return "LASTYR07";
                    case 33: // LASTYR08
                        return "LASTYR08";
                    case 34: // LASTYR09
                        return "LASTYR09";
                    case 35: // LASTYR10
                        return "LASTYR10";
                    case 36: // LASTYR11
                        return "LASTYR11";
                    case 37: // LASTYR12
                        return "LASTYR12";
                    case 38: // OPBAL
                        return "OPBAL";
                    case 39: // LW_DATE
                        return "LW_DATE";
                    case 40: // LW_TIME
                        return "LW_TIME";
                    case 41: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
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
                    case "TOTAL_BANK_BALANCE":
                        return 8;
                    case "LY_BANK_BALANCE":
                        return 9;
                    case "CASH_GRANT":
                        return 10;
                    case "LY_CASH_GRANT":
                        return 11;
                    case "OPERATING_RESERVE":
                        return 12;
                    case "LY_OPERATING_RESERVE":
                        return 13;
                    case "CURR01":
                        return 14;
                    case "CURR02":
                        return 15;
                    case "CURR03":
                        return 16;
                    case "CURR04":
                        return 17;
                    case "CURR05":
                        return 18;
                    case "CURR06":
                        return 19;
                    case "CURR07":
                        return 20;
                    case "CURR08":
                        return 21;
                    case "CURR09":
                        return 22;
                    case "CURR10":
                        return 23;
                    case "CURR11":
                        return 24;
                    case "CURR12":
                        return 25;
                    case "LASTYR01":
                        return 26;
                    case "LASTYR02":
                        return 27;
                    case "LASTYR03":
                        return 28;
                    case "LASTYR04":
                        return 29;
                    case "LASTYR05":
                        return 30;
                    case "LASTYR06":
                        return 31;
                    case "LASTYR07":
                        return 32;
                    case "LASTYR08":
                        return 33;
                    case "LASTYR09":
                        return 34;
                    case "LASTYR10":
                        return 35;
                    case "LASTYR11":
                        return 36;
                    case "LASTYR12":
                        return 37;
                    case "OPBAL":
                        return 38;
                    case "LW_DATE":
                        return 39;
                    case "LW_TIME":
                        return 40;
                    case "LW_USER":
                        return 41;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
