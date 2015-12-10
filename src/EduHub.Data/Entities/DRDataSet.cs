using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Receivable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRDataSet : DataSetBase<DR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DR"; } }

        internal DRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DRKEY = new Lazy<Dictionary<string, DR>>(() => this.ToDictionary(i => i.DRKEY));
            Index_DRTABLEA = new Lazy<NullDictionary<string, IReadOnlyList<DR>>>(() => this.ToGroupedNullDictionary(i => i.DRTABLEA));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DR" /> fields for each CSV column header</returns>
        protected override Action<DR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DRKEY":
                        mapper[i] = (e, v) => e.DRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES":
                        mapper[i] = (e, v) => e.CHARGES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES_YTD":
                        mapper[i] = (e, v) => e.CHARGES_YTD = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "LASTREC":
                        mapper[i] = (e, v) => e.LASTREC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTRECDATE":
                        mapper[i] = (e, v) => e.LASTRECDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "DRTYPE":
                        mapper[i] = (e, v) => e.DRTYPE = v;
                        break;
                    case "DRTABLEA":
                        mapper[i] = (e, v) => e.DRTABLEA = v;
                        break;
                    case "BUSNAME":
                        mapper[i] = (e, v) => e.BUSNAME = v;
                        break;
                    case "BUSADD01":
                        mapper[i] = (e, v) => e.BUSADD01 = v;
                        break;
                    case "BUSADD02":
                        mapper[i] = (e, v) => e.BUSADD02 = v;
                        break;
                    case "BUSSTATE":
                        mapper[i] = (e, v) => e.BUSSTATE = v;
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
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "BILLING_EMAIL":
                        mapper[i] = (e, v) => e.BILLING_EMAIL = v;
                        break;
                    case "MAILNAME":
                        mapper[i] = (e, v) => e.MAILNAME = v;
                        break;
                    case "MAILADD01":
                        mapper[i] = (e, v) => e.MAILADD01 = v;
                        break;
                    case "MAILADD02":
                        mapper[i] = (e, v) => e.MAILADD02 = v;
                        break;
                    case "MAILSTATE":
                        mapper[i] = (e, v) => e.MAILSTATE = v;
                        break;
                    case "MAILPOST":
                        mapper[i] = (e, v) => e.MAILPOST = v;
                        break;
                    case "DELNAME":
                        mapper[i] = (e, v) => e.DELNAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "DELIVPOST":
                        mapper[i] = (e, v) => e.DELIVPOST = v;
                        break;
                    case "REMARK":
                        mapper[i] = (e, v) => e.REMARK = v;
                        break;
                    case "PRICELEVEL":
                        mapper[i] = (e, v) => e.PRICELEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MEMO_FLAG":
                        mapper[i] = (e, v) => e.MEMO_FLAG = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "DRSHORT":
                        mapper[i] = (e, v) => e.DRSHORT = v;
                        break;
                    case "CSR":
                        mapper[i] = (e, v) => e.CSR = v;
                        break;
                    case "DRGROUP":
                        mapper[i] = (e, v) => e.DRGROUP = v;
                        break;
                    case "COMMENCE":
                        mapper[i] = (e, v) => e.COMMENCE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DRFCOUNT":
                        mapper[i] = (e, v) => e.DRFCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TAX_INVOICE":
                        mapper[i] = (e, v) => e.TAX_INVOICE = v;
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
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
        /// Merges <see cref="DR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DR" /> items to added or update the base <see cref="DR" /> items</param>
        /// <returns>A merged list of <see cref="DR" /> items</returns>
        protected override List<DR> ApplyDeltaItems(List<DR> Items, List<DR> DeltaItems)
        {
            Dictionary<string, int> Index_DRKEY = Items.ToIndexDictionary(i => i.DRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DR deltaItem in DeltaItems)
            {
                int index;

                if (Index_DRKEY.TryGetValue(deltaItem.DRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.DRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, DR>> Index_DRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DR>>> Index_DRTABLEA;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <returns>Related DR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DR FindByDRKEY(string DRKEY)
        {
            return Index_DRKEY.Value[DRKEY];
        }

        /// <summary>
        /// Attempt to find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <param name="Value">Related DR entity</param>
        /// <returns>True if the related DR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDRKEY(string DRKEY, out DR Value)
        {
            return Index_DRKEY.Value.TryGetValue(DRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <returns>Related DR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DR TryFindByDRKEY(string DRKEY)
        {
            DR value;
            if (Index_DRKEY.Value.TryGetValue(DRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <returns>List of related DR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> FindByDRTABLEA(string DRTABLEA)
        {
            return Index_DRTABLEA.Value[DRTABLEA];
        }

        /// <summary>
        /// Attempt to find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <param name="Value">List of related DR entities</param>
        /// <returns>True if the list of related DR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDRTABLEA(string DRTABLEA, out IReadOnlyList<DR> Value)
        {
            return Index_DRTABLEA.Value.TryGetValue(DRTABLEA, out Value);
        }

        /// <summary>
        /// Attempt to find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <returns>List of related DR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> TryFindByDRTABLEA(string DRTABLEA)
        {
            IReadOnlyList<DR> value;
            if (Index_DRTABLEA.Value.TryGetValue(DRTABLEA, out value))
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
        /// Returns SQL which checks for the existence of a DR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DR](
        [DRKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [ALLOCAMT] money NULL,
        [CHARGES] money NULL,
        [CHARGES_YTD] money NULL,
        [AGED01] money NULL,
        [AGED02] money NULL,
        [AGED03] money NULL,
        [AGED04] money NULL,
        [AGED05] money NULL,
        [OPBAL] money NULL,
        [LASTREC] money NULL,
        [LASTRECDATE] datetime NULL,
        [ACCTYPE] smallint NULL,
        [CONTACT] varchar(30) NULL,
        [DRTYPE] varchar(1) NULL,
        [DRTABLEA] varchar(10) NULL,
        [BUSNAME] varchar(30) NULL,
        [BUSADD01] varchar(30) NULL,
        [BUSADD02] varchar(30) NULL,
        [BUSSTATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(15) NULL,
        [MOBILE] varchar(15) NULL,
        [BILLING_EMAIL] varchar(60) NULL,
        [MAILNAME] varchar(30) NULL,
        [MAILADD01] varchar(30) NULL,
        [MAILADD02] varchar(30) NULL,
        [MAILSTATE] varchar(3) NULL,
        [MAILPOST] varchar(4) NULL,
        [DELNAME] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [DELIVPOST] varchar(4) NULL,
        [REMARK] text NULL,
        [PRICELEVEL] smallint NULL,
        [MEMO_FLAG] varchar(1) NULL,
        [NOTES] text NULL,
        [DRSHORT] varchar(10) NULL,
        [CSR] varchar(4) NULL,
        [DRGROUP] varchar(10) NULL,
        [COMMENCE] datetime NULL,
        [DRFCOUNT] float NULL,
        [TAX_INVOICE] varchar(1) NULL,
        [BPAY_SEQUENCE] int NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DR_Index_DRKEY] PRIMARY KEY CLUSTERED (
            [DRKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [DR_Index_DRTABLEA] ON [dbo].[DR]
    (
            [DRTABLEA] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DRDataReader : IDataReader, IDataRecord
        {
            private List<DR> Items;
            private int CurrentIndex;
            private DR CurrentItem;

            public DRDataReader(List<DR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 50; } }
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
                    case 0: // DRKEY
                        return CurrentItem.DRKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // ALLOCAMT
                        return CurrentItem.ALLOCAMT;
                    case 3: // CHARGES
                        return CurrentItem.CHARGES;
                    case 4: // CHARGES_YTD
                        return CurrentItem.CHARGES_YTD;
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
                    case 11: // LASTREC
                        return CurrentItem.LASTREC;
                    case 12: // LASTRECDATE
                        return CurrentItem.LASTRECDATE;
                    case 13: // ACCTYPE
                        return CurrentItem.ACCTYPE;
                    case 14: // CONTACT
                        return CurrentItem.CONTACT;
                    case 15: // DRTYPE
                        return CurrentItem.DRTYPE;
                    case 16: // DRTABLEA
                        return CurrentItem.DRTABLEA;
                    case 17: // BUSNAME
                        return CurrentItem.BUSNAME;
                    case 18: // BUSADD01
                        return CurrentItem.BUSADD01;
                    case 19: // BUSADD02
                        return CurrentItem.BUSADD02;
                    case 20: // BUSSTATE
                        return CurrentItem.BUSSTATE;
                    case 21: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 22: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 23: // FAX
                        return CurrentItem.FAX;
                    case 24: // MOBILE
                        return CurrentItem.MOBILE;
                    case 25: // BILLING_EMAIL
                        return CurrentItem.BILLING_EMAIL;
                    case 26: // MAILNAME
                        return CurrentItem.MAILNAME;
                    case 27: // MAILADD01
                        return CurrentItem.MAILADD01;
                    case 28: // MAILADD02
                        return CurrentItem.MAILADD02;
                    case 29: // MAILSTATE
                        return CurrentItem.MAILSTATE;
                    case 30: // MAILPOST
                        return CurrentItem.MAILPOST;
                    case 31: // DELNAME
                        return CurrentItem.DELNAME;
                    case 32: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 33: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 34: // DELIVPOST
                        return CurrentItem.DELIVPOST;
                    case 35: // REMARK
                        return CurrentItem.REMARK;
                    case 36: // PRICELEVEL
                        return CurrentItem.PRICELEVEL;
                    case 37: // MEMO_FLAG
                        return CurrentItem.MEMO_FLAG;
                    case 38: // NOTES
                        return CurrentItem.NOTES;
                    case 39: // DRSHORT
                        return CurrentItem.DRSHORT;
                    case 40: // CSR
                        return CurrentItem.CSR;
                    case 41: // DRGROUP
                        return CurrentItem.DRGROUP;
                    case 42: // COMMENCE
                        return CurrentItem.COMMENCE;
                    case 43: // DRFCOUNT
                        return CurrentItem.DRFCOUNT;
                    case 44: // TAX_INVOICE
                        return CurrentItem.TAX_INVOICE;
                    case 45: // BPAY_SEQUENCE
                        return CurrentItem.BPAY_SEQUENCE;
                    case 46: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE;
                    case 47: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 48: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 49: // LW_USER
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
                    case 3: // CHARGES
                        return CurrentItem.CHARGES == null;
                    case 4: // CHARGES_YTD
                        return CurrentItem.CHARGES_YTD == null;
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
                    case 11: // LASTREC
                        return CurrentItem.LASTREC == null;
                    case 12: // LASTRECDATE
                        return CurrentItem.LASTRECDATE == null;
                    case 13: // ACCTYPE
                        return CurrentItem.ACCTYPE == null;
                    case 14: // CONTACT
                        return CurrentItem.CONTACT == null;
                    case 15: // DRTYPE
                        return CurrentItem.DRTYPE == null;
                    case 16: // DRTABLEA
                        return CurrentItem.DRTABLEA == null;
                    case 17: // BUSNAME
                        return CurrentItem.BUSNAME == null;
                    case 18: // BUSADD01
                        return CurrentItem.BUSADD01 == null;
                    case 19: // BUSADD02
                        return CurrentItem.BUSADD02 == null;
                    case 20: // BUSSTATE
                        return CurrentItem.BUSSTATE == null;
                    case 21: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 22: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 23: // FAX
                        return CurrentItem.FAX == null;
                    case 24: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 25: // BILLING_EMAIL
                        return CurrentItem.BILLING_EMAIL == null;
                    case 26: // MAILNAME
                        return CurrentItem.MAILNAME == null;
                    case 27: // MAILADD01
                        return CurrentItem.MAILADD01 == null;
                    case 28: // MAILADD02
                        return CurrentItem.MAILADD02 == null;
                    case 29: // MAILSTATE
                        return CurrentItem.MAILSTATE == null;
                    case 30: // MAILPOST
                        return CurrentItem.MAILPOST == null;
                    case 31: // DELNAME
                        return CurrentItem.DELNAME == null;
                    case 32: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 33: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 34: // DELIVPOST
                        return CurrentItem.DELIVPOST == null;
                    case 35: // REMARK
                        return CurrentItem.REMARK == null;
                    case 36: // PRICELEVEL
                        return CurrentItem.PRICELEVEL == null;
                    case 37: // MEMO_FLAG
                        return CurrentItem.MEMO_FLAG == null;
                    case 38: // NOTES
                        return CurrentItem.NOTES == null;
                    case 39: // DRSHORT
                        return CurrentItem.DRSHORT == null;
                    case 40: // CSR
                        return CurrentItem.CSR == null;
                    case 41: // DRGROUP
                        return CurrentItem.DRGROUP == null;
                    case 42: // COMMENCE
                        return CurrentItem.COMMENCE == null;
                    case 43: // DRFCOUNT
                        return CurrentItem.DRFCOUNT == null;
                    case 44: // TAX_INVOICE
                        return CurrentItem.TAX_INVOICE == null;
                    case 45: // BPAY_SEQUENCE
                        return CurrentItem.BPAY_SEQUENCE == null;
                    case 46: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE == null;
                    case 47: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 48: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 49: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // DRKEY
                        return "DRKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ALLOCAMT
                        return "ALLOCAMT";
                    case 3: // CHARGES
                        return "CHARGES";
                    case 4: // CHARGES_YTD
                        return "CHARGES_YTD";
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
                    case 11: // LASTREC
                        return "LASTREC";
                    case 12: // LASTRECDATE
                        return "LASTRECDATE";
                    case 13: // ACCTYPE
                        return "ACCTYPE";
                    case 14: // CONTACT
                        return "CONTACT";
                    case 15: // DRTYPE
                        return "DRTYPE";
                    case 16: // DRTABLEA
                        return "DRTABLEA";
                    case 17: // BUSNAME
                        return "BUSNAME";
                    case 18: // BUSADD01
                        return "BUSADD01";
                    case 19: // BUSADD02
                        return "BUSADD02";
                    case 20: // BUSSTATE
                        return "BUSSTATE";
                    case 21: // POSTCODE
                        return "POSTCODE";
                    case 22: // TELEPHONE
                        return "TELEPHONE";
                    case 23: // FAX
                        return "FAX";
                    case 24: // MOBILE
                        return "MOBILE";
                    case 25: // BILLING_EMAIL
                        return "BILLING_EMAIL";
                    case 26: // MAILNAME
                        return "MAILNAME";
                    case 27: // MAILADD01
                        return "MAILADD01";
                    case 28: // MAILADD02
                        return "MAILADD02";
                    case 29: // MAILSTATE
                        return "MAILSTATE";
                    case 30: // MAILPOST
                        return "MAILPOST";
                    case 31: // DELNAME
                        return "DELNAME";
                    case 32: // ADDRESS01
                        return "ADDRESS01";
                    case 33: // ADDRESS02
                        return "ADDRESS02";
                    case 34: // DELIVPOST
                        return "DELIVPOST";
                    case 35: // REMARK
                        return "REMARK";
                    case 36: // PRICELEVEL
                        return "PRICELEVEL";
                    case 37: // MEMO_FLAG
                        return "MEMO_FLAG";
                    case 38: // NOTES
                        return "NOTES";
                    case 39: // DRSHORT
                        return "DRSHORT";
                    case 40: // CSR
                        return "CSR";
                    case 41: // DRGROUP
                        return "DRGROUP";
                    case 42: // COMMENCE
                        return "COMMENCE";
                    case 43: // DRFCOUNT
                        return "DRFCOUNT";
                    case 44: // TAX_INVOICE
                        return "TAX_INVOICE";
                    case 45: // BPAY_SEQUENCE
                        return "BPAY_SEQUENCE";
                    case 46: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 47: // LW_DATE
                        return "LW_DATE";
                    case 48: // LW_TIME
                        return "LW_TIME";
                    case 49: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "DRKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ALLOCAMT":
                        return 2;
                    case "CHARGES":
                        return 3;
                    case "CHARGES_YTD":
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
                    case "LASTREC":
                        return 11;
                    case "LASTRECDATE":
                        return 12;
                    case "ACCTYPE":
                        return 13;
                    case "CONTACT":
                        return 14;
                    case "DRTYPE":
                        return 15;
                    case "DRTABLEA":
                        return 16;
                    case "BUSNAME":
                        return 17;
                    case "BUSADD01":
                        return 18;
                    case "BUSADD02":
                        return 19;
                    case "BUSSTATE":
                        return 20;
                    case "POSTCODE":
                        return 21;
                    case "TELEPHONE":
                        return 22;
                    case "FAX":
                        return 23;
                    case "MOBILE":
                        return 24;
                    case "BILLING_EMAIL":
                        return 25;
                    case "MAILNAME":
                        return 26;
                    case "MAILADD01":
                        return 27;
                    case "MAILADD02":
                        return 28;
                    case "MAILSTATE":
                        return 29;
                    case "MAILPOST":
                        return 30;
                    case "DELNAME":
                        return 31;
                    case "ADDRESS01":
                        return 32;
                    case "ADDRESS02":
                        return 33;
                    case "DELIVPOST":
                        return 34;
                    case "REMARK":
                        return 35;
                    case "PRICELEVEL":
                        return 36;
                    case "MEMO_FLAG":
                        return 37;
                    case "NOTES":
                        return 38;
                    case "DRSHORT":
                        return 39;
                    case "CSR":
                        return 40;
                    case "DRGROUP":
                        return 41;
                    case "COMMENCE":
                        return 42;
                    case "DRFCOUNT":
                        return 43;
                    case "TAX_INVOICE":
                        return 44;
                    case "BPAY_SEQUENCE":
                        return 45;
                    case "BPAY_REFERENCE":
                        return 46;
                    case "LW_DATE":
                        return 47;
                    case "LW_TIME":
                        return 48;
                    case "LW_USER":
                        return 49;
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
