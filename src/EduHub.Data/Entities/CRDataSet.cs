using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRDataSet : DataSetBase<CR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "CR"; } }

        internal CRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CRKEY = new Lazy<Dictionary<string, CR>>(() => this.ToDictionary(i => i.CRKEY));
            Index_PPDKEY = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CR" /> fields for each CSV column header</returns>
        protected override Action<CR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MTDPURCH":
                        mapper[i] = (e, v) => e.MTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "YTDPURCH":
                        mapper[i] = (e, v) => e.YTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED01":
                        mapper[i] = (e, v) => e.AGED01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED02":
                        mapper[i] = (e, v) => e.AGED02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED03":
                        mapper[i] = (e, v) => e.AGED03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED04":
                        mapper[i] = (e, v) => e.AGED04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED05":
                        mapper[i] = (e, v) => e.AGED05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRLIMIT":
                        mapper[i] = (e, v) => e.CRLIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAY":
                        mapper[i] = (e, v) => e.LASTPAY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERMS":
                        mapper[i] = (e, v) => e.TERMS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DISCOUNT":
                        mapper[i] = (e, v) => e.DISCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "CR_EMAIL":
                        mapper[i] = (e, v) => e.CR_EMAIL = v;
                        break;
                    case "EMAIL_FOR_PAYMENTS":
                        mapper[i] = (e, v) => e.EMAIL_FOR_PAYMENTS = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "COMMITMENT":
                        mapper[i] = (e, v) => e.COMMITMENT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STOP_FLAG":
                        mapper[i] = (e, v) => e.STOP_FLAG = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "PAYG_RATE":
                        mapper[i] = (e, v) => e.PAYG_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "LODGE_REF":
                        mapper[i] = (e, v) => e.LODGE_REF = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PAYG_BIRTHDATE":
                        mapper[i] = (e, v) => e.PAYG_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_STARTDATE":
                        mapper[i] = (e, v) => e.PAYG_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_TERMDATE":
                        mapper[i] = (e, v) => e.PAYG_TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_ADDRESS01":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS01 = v;
                        break;
                    case "PAYG_ADDRESS02":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS02 = v;
                        break;
                    case "PAYG_SUBURB":
                        mapper[i] = (e, v) => e.PAYG_SUBURB = v;
                        break;
                    case "PAYG_STATE":
                        mapper[i] = (e, v) => e.PAYG_STATE = v;
                        break;
                    case "PAYG_POST":
                        mapper[i] = (e, v) => e.PAYG_POST = v;
                        break;
                    case "PAYG_COUNTRY":
                        mapper[i] = (e, v) => e.PAYG_COUNTRY = v;
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PRMS_FLAG":
                        mapper[i] = (e, v) => e.PRMS_FLAG = v;
                        break;
                    case "LW_PRMSINFO_DATE":
                        mapper[i] = (e, v) => e.LW_PRMSINFO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="CR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="CR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="CR" /> items to added or update the base <see cref="CR" /> items</param>
        /// <returns>A merged list of <see cref="CR" /> items</returns>
        protected override List<CR> ApplyDeltaItems(List<CR> Items, List<CR> DeltaItems)
        {
            Dictionary<string, int> Index_CRKEY = Items.ToIndexDictionary(i => i.CRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (CR deltaItem in DeltaItems)
            {
                int index;

                if (Index_CRKEY.TryGetValue(deltaItem.CRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_BSB;
        private Lazy<Dictionary<string, CR>> Index_CRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<CR> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByBSB(string BSB)
        {
            IReadOnlyList<CR> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR FindByCRKEY(string CRKEY)
        {
            return Index_CRKEY.Value[CRKEY];
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <param name="Value">Related CR entity</param>
        /// <returns>True if the related CR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCRKEY(string CRKEY, out CR Value)
        {
            return Index_CRKEY.Value.TryGetValue(CRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR TryFindByCRKEY(string CRKEY)
        {
            CR value;
            if (Index_CRKEY.Value.TryGetValue(CRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out IReadOnlyList<CR> Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByPPDKEY(string PPDKEY)
        {
            IReadOnlyList<CR> value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
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
        /// Returns SQL which checks for the existence of a CR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CR](
        [CRKEY] varchar(10) NOT NULL,
        [TITLE] varchar(40) NULL,
        [ALLOCAMT] money NULL,
        [MTDPURCH] money NULL,
        [YTDPURCH] money NULL,
        [AGED01] money NULL,
        [AGED02] money NULL,
        [AGED03] money NULL,
        [AGED04] money NULL,
        [AGED05] money NULL,
        [OPBAL] money NULL,
        [CRLIMIT] money NULL,
        [LASTPAYDATE] datetime NULL,
        [LASTPAY] money NULL,
        [ACCTYPE] smallint NULL,
        [TERMS] smallint NULL,
        [DISCOUNT] float NULL,
        [CONTACT] varchar(30) NULL,
        [ADDRESS01] varchar(40) NULL,
        [ADDRESS02] varchar(40) NULL,
        [ADDRESS03] varchar(40) NULL,
        [STATE] varchar(4) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(15) NULL,
        [FAX] varchar(15) NULL,
        [CR_EMAIL] varchar(60) NULL,
        [EMAIL_FOR_PAYMENTS] varchar(60) NULL,
        [MOBILE] varchar(15) NULL,
        [COMMITMENT] money NULL,
        [STOP_FLAG] varchar(1) NULL,
        [ABN] varchar(15) NULL,
        [PAYG_RATE] float NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [ACCOUNT_NAME] varchar(60) NULL,
        [LODGE_REF] varchar(18) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(15) NULL,
        [SECOND_NAME] varchar(15) NULL,
        [PAYG_BIRTHDATE] datetime NULL,
        [PAYG_STARTDATE] datetime NULL,
        [PAYG_TERMDATE] datetime NULL,
        [PAYG_ADDRESS01] varchar(38) NULL,
        [PAYG_ADDRESS02] varchar(38) NULL,
        [PAYG_SUBURB] varchar(20) NULL,
        [PAYG_STATE] varchar(3) NULL,
        [PAYG_POST] varchar(4) NULL,
        [PAYG_COUNTRY] varchar(20) NULL,
        [PPDKEY] varchar(10) NULL,
        [PRMS_FLAG] varchar(1) NULL,
        [LW_PRMSINFO_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CR_Index_CRKEY] PRIMARY KEY CLUSTERED (
            [CRKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [CR_Index_BSB] ON [dbo].[CR]
    (
            [BSB] ASC
    );
    CREATE NONCLUSTERED INDEX [CR_Index_PPDKEY] ON [dbo].[CR]
    (
            [PPDKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new CRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRDataReader : IDataReader, IDataRecord
        {
            private List<CR> Items;
            private int CurrentIndex;
            private CR CurrentItem;

            public CRDataReader(List<CR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 56; } }
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
                    case 0: // CRKEY
                        return CurrentItem.CRKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // ALLOCAMT
                        return CurrentItem.ALLOCAMT;
                    case 3: // MTDPURCH
                        return CurrentItem.MTDPURCH;
                    case 4: // YTDPURCH
                        return CurrentItem.YTDPURCH;
                    case 5: // AGED01
                        return CurrentItem.AGED01;
                    case 6: // AGED02
                        return CurrentItem.AGED02;
                    case 7: // AGED03
                        return CurrentItem.AGED03;
                    case 8: // AGED04
                        return CurrentItem.AGED04;
                    case 9: // AGED05
                        return CurrentItem.AGED05;
                    case 10: // OPBAL
                        return CurrentItem.OPBAL;
                    case 11: // CRLIMIT
                        return CurrentItem.CRLIMIT;
                    case 12: // LASTPAYDATE
                        return CurrentItem.LASTPAYDATE;
                    case 13: // LASTPAY
                        return CurrentItem.LASTPAY;
                    case 14: // ACCTYPE
                        return CurrentItem.ACCTYPE;
                    case 15: // TERMS
                        return CurrentItem.TERMS;
                    case 16: // DISCOUNT
                        return CurrentItem.DISCOUNT;
                    case 17: // CONTACT
                        return CurrentItem.CONTACT;
                    case 18: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 19: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 20: // ADDRESS03
                        return CurrentItem.ADDRESS03;
                    case 21: // STATE
                        return CurrentItem.STATE;
                    case 22: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 23: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 24: // FAX
                        return CurrentItem.FAX;
                    case 25: // CR_EMAIL
                        return CurrentItem.CR_EMAIL;
                    case 26: // EMAIL_FOR_PAYMENTS
                        return CurrentItem.EMAIL_FOR_PAYMENTS;
                    case 27: // MOBILE
                        return CurrentItem.MOBILE;
                    case 28: // COMMITMENT
                        return CurrentItem.COMMITMENT;
                    case 29: // STOP_FLAG
                        return CurrentItem.STOP_FLAG;
                    case 30: // ABN
                        return CurrentItem.ABN;
                    case 31: // PAYG_RATE
                        return CurrentItem.PAYG_RATE;
                    case 32: // BSB
                        return CurrentItem.BSB;
                    case 33: // ACCOUNT_NO
                        return CurrentItem.ACCOUNT_NO;
                    case 34: // ACCOUNT_NAME
                        return CurrentItem.ACCOUNT_NAME;
                    case 35: // LODGE_REF
                        return CurrentItem.LODGE_REF;
                    case 36: // BILLER_CODE
                        return CurrentItem.BILLER_CODE;
                    case 37: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE;
                    case 38: // SURNAME
                        return CurrentItem.SURNAME;
                    case 39: // FIRST_NAME
                        return CurrentItem.FIRST_NAME;
                    case 40: // SECOND_NAME
                        return CurrentItem.SECOND_NAME;
                    case 41: // PAYG_BIRTHDATE
                        return CurrentItem.PAYG_BIRTHDATE;
                    case 42: // PAYG_STARTDATE
                        return CurrentItem.PAYG_STARTDATE;
                    case 43: // PAYG_TERMDATE
                        return CurrentItem.PAYG_TERMDATE;
                    case 44: // PAYG_ADDRESS01
                        return CurrentItem.PAYG_ADDRESS01;
                    case 45: // PAYG_ADDRESS02
                        return CurrentItem.PAYG_ADDRESS02;
                    case 46: // PAYG_SUBURB
                        return CurrentItem.PAYG_SUBURB;
                    case 47: // PAYG_STATE
                        return CurrentItem.PAYG_STATE;
                    case 48: // PAYG_POST
                        return CurrentItem.PAYG_POST;
                    case 49: // PAYG_COUNTRY
                        return CurrentItem.PAYG_COUNTRY;
                    case 50: // PPDKEY
                        return CurrentItem.PPDKEY;
                    case 51: // PRMS_FLAG
                        return CurrentItem.PRMS_FLAG;
                    case 52: // LW_PRMSINFO_DATE
                        return CurrentItem.LW_PRMSINFO_DATE;
                    case 53: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 54: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 55: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // ALLOCAMT
                        return CurrentItem.ALLOCAMT == null;
                    case 3: // MTDPURCH
                        return CurrentItem.MTDPURCH == null;
                    case 4: // YTDPURCH
                        return CurrentItem.YTDPURCH == null;
                    case 5: // AGED01
                        return CurrentItem.AGED01 == null;
                    case 6: // AGED02
                        return CurrentItem.AGED02 == null;
                    case 7: // AGED03
                        return CurrentItem.AGED03 == null;
                    case 8: // AGED04
                        return CurrentItem.AGED04 == null;
                    case 9: // AGED05
                        return CurrentItem.AGED05 == null;
                    case 10: // OPBAL
                        return CurrentItem.OPBAL == null;
                    case 11: // CRLIMIT
                        return CurrentItem.CRLIMIT == null;
                    case 12: // LASTPAYDATE
                        return CurrentItem.LASTPAYDATE == null;
                    case 13: // LASTPAY
                        return CurrentItem.LASTPAY == null;
                    case 14: // ACCTYPE
                        return CurrentItem.ACCTYPE == null;
                    case 15: // TERMS
                        return CurrentItem.TERMS == null;
                    case 16: // DISCOUNT
                        return CurrentItem.DISCOUNT == null;
                    case 17: // CONTACT
                        return CurrentItem.CONTACT == null;
                    case 18: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 19: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 20: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
                    case 21: // STATE
                        return CurrentItem.STATE == null;
                    case 22: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 23: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 24: // FAX
                        return CurrentItem.FAX == null;
                    case 25: // CR_EMAIL
                        return CurrentItem.CR_EMAIL == null;
                    case 26: // EMAIL_FOR_PAYMENTS
                        return CurrentItem.EMAIL_FOR_PAYMENTS == null;
                    case 27: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 28: // COMMITMENT
                        return CurrentItem.COMMITMENT == null;
                    case 29: // STOP_FLAG
                        return CurrentItem.STOP_FLAG == null;
                    case 30: // ABN
                        return CurrentItem.ABN == null;
                    case 31: // PAYG_RATE
                        return CurrentItem.PAYG_RATE == null;
                    case 32: // BSB
                        return CurrentItem.BSB == null;
                    case 33: // ACCOUNT_NO
                        return CurrentItem.ACCOUNT_NO == null;
                    case 34: // ACCOUNT_NAME
                        return CurrentItem.ACCOUNT_NAME == null;
                    case 35: // LODGE_REF
                        return CurrentItem.LODGE_REF == null;
                    case 36: // BILLER_CODE
                        return CurrentItem.BILLER_CODE == null;
                    case 37: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE == null;
                    case 38: // SURNAME
                        return CurrentItem.SURNAME == null;
                    case 39: // FIRST_NAME
                        return CurrentItem.FIRST_NAME == null;
                    case 40: // SECOND_NAME
                        return CurrentItem.SECOND_NAME == null;
                    case 41: // PAYG_BIRTHDATE
                        return CurrentItem.PAYG_BIRTHDATE == null;
                    case 42: // PAYG_STARTDATE
                        return CurrentItem.PAYG_STARTDATE == null;
                    case 43: // PAYG_TERMDATE
                        return CurrentItem.PAYG_TERMDATE == null;
                    case 44: // PAYG_ADDRESS01
                        return CurrentItem.PAYG_ADDRESS01 == null;
                    case 45: // PAYG_ADDRESS02
                        return CurrentItem.PAYG_ADDRESS02 == null;
                    case 46: // PAYG_SUBURB
                        return CurrentItem.PAYG_SUBURB == null;
                    case 47: // PAYG_STATE
                        return CurrentItem.PAYG_STATE == null;
                    case 48: // PAYG_POST
                        return CurrentItem.PAYG_POST == null;
                    case 49: // PAYG_COUNTRY
                        return CurrentItem.PAYG_COUNTRY == null;
                    case 50: // PPDKEY
                        return CurrentItem.PPDKEY == null;
                    case 51: // PRMS_FLAG
                        return CurrentItem.PRMS_FLAG == null;
                    case 52: // LW_PRMSINFO_DATE
                        return CurrentItem.LW_PRMSINFO_DATE == null;
                    case 53: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 54: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 55: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // CRKEY
                        return "CRKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ALLOCAMT
                        return "ALLOCAMT";
                    case 3: // MTDPURCH
                        return "MTDPURCH";
                    case 4: // YTDPURCH
                        return "YTDPURCH";
                    case 5: // AGED01
                        return "AGED01";
                    case 6: // AGED02
                        return "AGED02";
                    case 7: // AGED03
                        return "AGED03";
                    case 8: // AGED04
                        return "AGED04";
                    case 9: // AGED05
                        return "AGED05";
                    case 10: // OPBAL
                        return "OPBAL";
                    case 11: // CRLIMIT
                        return "CRLIMIT";
                    case 12: // LASTPAYDATE
                        return "LASTPAYDATE";
                    case 13: // LASTPAY
                        return "LASTPAY";
                    case 14: // ACCTYPE
                        return "ACCTYPE";
                    case 15: // TERMS
                        return "TERMS";
                    case 16: // DISCOUNT
                        return "DISCOUNT";
                    case 17: // CONTACT
                        return "CONTACT";
                    case 18: // ADDRESS01
                        return "ADDRESS01";
                    case 19: // ADDRESS02
                        return "ADDRESS02";
                    case 20: // ADDRESS03
                        return "ADDRESS03";
                    case 21: // STATE
                        return "STATE";
                    case 22: // POSTCODE
                        return "POSTCODE";
                    case 23: // TELEPHONE
                        return "TELEPHONE";
                    case 24: // FAX
                        return "FAX";
                    case 25: // CR_EMAIL
                        return "CR_EMAIL";
                    case 26: // EMAIL_FOR_PAYMENTS
                        return "EMAIL_FOR_PAYMENTS";
                    case 27: // MOBILE
                        return "MOBILE";
                    case 28: // COMMITMENT
                        return "COMMITMENT";
                    case 29: // STOP_FLAG
                        return "STOP_FLAG";
                    case 30: // ABN
                        return "ABN";
                    case 31: // PAYG_RATE
                        return "PAYG_RATE";
                    case 32: // BSB
                        return "BSB";
                    case 33: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 34: // ACCOUNT_NAME
                        return "ACCOUNT_NAME";
                    case 35: // LODGE_REF
                        return "LODGE_REF";
                    case 36: // BILLER_CODE
                        return "BILLER_CODE";
                    case 37: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 38: // SURNAME
                        return "SURNAME";
                    case 39: // FIRST_NAME
                        return "FIRST_NAME";
                    case 40: // SECOND_NAME
                        return "SECOND_NAME";
                    case 41: // PAYG_BIRTHDATE
                        return "PAYG_BIRTHDATE";
                    case 42: // PAYG_STARTDATE
                        return "PAYG_STARTDATE";
                    case 43: // PAYG_TERMDATE
                        return "PAYG_TERMDATE";
                    case 44: // PAYG_ADDRESS01
                        return "PAYG_ADDRESS01";
                    case 45: // PAYG_ADDRESS02
                        return "PAYG_ADDRESS02";
                    case 46: // PAYG_SUBURB
                        return "PAYG_SUBURB";
                    case 47: // PAYG_STATE
                        return "PAYG_STATE";
                    case 48: // PAYG_POST
                        return "PAYG_POST";
                    case 49: // PAYG_COUNTRY
                        return "PAYG_COUNTRY";
                    case 50: // PPDKEY
                        return "PPDKEY";
                    case 51: // PRMS_FLAG
                        return "PRMS_FLAG";
                    case 52: // LW_PRMSINFO_DATE
                        return "LW_PRMSINFO_DATE";
                    case 53: // LW_DATE
                        return "LW_DATE";
                    case 54: // LW_TIME
                        return "LW_TIME";
                    case 55: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "CRKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ALLOCAMT":
                        return 2;
                    case "MTDPURCH":
                        return 3;
                    case "YTDPURCH":
                        return 4;
                    case "AGED01":
                        return 5;
                    case "AGED02":
                        return 6;
                    case "AGED03":
                        return 7;
                    case "AGED04":
                        return 8;
                    case "AGED05":
                        return 9;
                    case "OPBAL":
                        return 10;
                    case "CRLIMIT":
                        return 11;
                    case "LASTPAYDATE":
                        return 12;
                    case "LASTPAY":
                        return 13;
                    case "ACCTYPE":
                        return 14;
                    case "TERMS":
                        return 15;
                    case "DISCOUNT":
                        return 16;
                    case "CONTACT":
                        return 17;
                    case "ADDRESS01":
                        return 18;
                    case "ADDRESS02":
                        return 19;
                    case "ADDRESS03":
                        return 20;
                    case "STATE":
                        return 21;
                    case "POSTCODE":
                        return 22;
                    case "TELEPHONE":
                        return 23;
                    case "FAX":
                        return 24;
                    case "CR_EMAIL":
                        return 25;
                    case "EMAIL_FOR_PAYMENTS":
                        return 26;
                    case "MOBILE":
                        return 27;
                    case "COMMITMENT":
                        return 28;
                    case "STOP_FLAG":
                        return 29;
                    case "ABN":
                        return 30;
                    case "PAYG_RATE":
                        return 31;
                    case "BSB":
                        return 32;
                    case "ACCOUNT_NO":
                        return 33;
                    case "ACCOUNT_NAME":
                        return 34;
                    case "LODGE_REF":
                        return 35;
                    case "BILLER_CODE":
                        return 36;
                    case "BPAY_REFERENCE":
                        return 37;
                    case "SURNAME":
                        return 38;
                    case "FIRST_NAME":
                        return 39;
                    case "SECOND_NAME":
                        return 40;
                    case "PAYG_BIRTHDATE":
                        return 41;
                    case "PAYG_STARTDATE":
                        return 42;
                    case "PAYG_TERMDATE":
                        return 43;
                    case "PAYG_ADDRESS01":
                        return 44;
                    case "PAYG_ADDRESS02":
                        return 45;
                    case "PAYG_SUBURB":
                        return 46;
                    case "PAYG_STATE":
                        return 47;
                    case "PAYG_POST":
                        return 48;
                    case "PAYG_COUNTRY":
                        return 49;
                    case "PPDKEY":
                        return 50;
                    case "PRMS_FLAG":
                        return 51;
                    case "LW_PRMSINFO_DATE":
                        return 52;
                    case "LW_DATE":
                        return 53;
                    case "LW_TIME":
                        return 54;
                    case "LW_USER":
                        return 55;
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
