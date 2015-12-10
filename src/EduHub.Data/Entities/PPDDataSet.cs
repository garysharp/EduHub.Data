using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payer Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPDDataSet : DataSetBase<PPD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PPD"; } }

        internal PPDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPD>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_PPDKEY = new Lazy<Dictionary<string, PPD>>(() => this.ToDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPD" /> fields for each CSV column header</returns>
        protected override Action<PPD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PPD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABN_OR_WPN":
                        mapper[i] = (e, v) => e.ABN_OR_WPN = v;
                        break;
                    case "NUMBER_TYPE":
                        mapper[i] = (e, v) => e.NUMBER_TYPE = v;
                        break;
                    case "BRANCH_NUMBER":
                        mapper[i] = (e, v) => e.BRANCH_NUMBER = v;
                        break;
                    case "FINANCIAL_YEAR":
                        mapper[i] = (e, v) => e.FINANCIAL_YEAR = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "TRADING_NAME":
                        mapper[i] = (e, v) => e.TRADING_NAME = v;
                        break;
                    case "L1_ADDRESS":
                        mapper[i] = (e, v) => e.L1_ADDRESS = v;
                        break;
                    case "L2_ADDRESS":
                        mapper[i] = (e, v) => e.L2_ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "SIGNATURE":
                        mapper[i] = (e, v) => e.SIGNATURE = v;
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
        /// Merges <see cref="PPD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PPD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PPD" /> items to added or update the base <see cref="PPD" /> items</param>
        /// <returns>A merged list of <see cref="PPD" /> items</returns>
        protected override List<PPD> ApplyDeltaItems(List<PPD> Items, List<PPD> DeltaItems)
        {
            Dictionary<string, int> Index_PPDKEY = Items.ToIndexDictionary(i => i.PPDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PPD deltaItem in DeltaItems)
            {
                int index;

                if (Index_PPDKEY.TryGetValue(deltaItem.PPDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PPDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PPD>>> Index_COUNTRY;
        private Lazy<Dictionary<string, PPD>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <returns>List of related PPD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPD> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <param name="Value">List of related PPD entities</param>
        /// <returns>True if the list of related PPD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PPD> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <returns>List of related PPD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPD> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPD> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPD FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <param name="Value">Related PPD entity</param>
        /// <returns>True if the related PPD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out PPD Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPD TryFindByPPDKEY(string PPDKEY)
        {
            PPD value;
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
        /// Returns SQL which checks for the existence of a PPD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PPD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PPD](
        [PPDKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ABN_OR_WPN] varchar(11) NULL,
        [NUMBER_TYPE] varchar(1) NULL,
        [BRANCH_NUMBER] varchar(3) NULL,
        [FINANCIAL_YEAR] varchar(4) NULL,
        [NAME] varchar(40) NULL,
        [TRADING_NAME] varchar(40) NULL,
        [L1_ADDRESS] varchar(38) NULL,
        [L2_ADDRESS] varchar(38) NULL,
        [SUBURB] varchar(27) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [COUNTRY] varchar(6) NULL,
        [CONTACT_NAME] varchar(25) NULL,
        [PHONE] varchar(15) NULL,
        [FACSIMILE] varchar(15) NULL,
        [SIGNATURE] varchar(25) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PPD_Index_PPDKEY] PRIMARY KEY CLUSTERED (
            [PPDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PPD_Index_COUNTRY] ON [dbo].[PPD]
    (
            [COUNTRY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PPD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PPD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PPDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PPDDataReader : IDataReader, IDataRecord
        {
            private List<PPD> Items;
            private int CurrentIndex;
            private PPD CurrentItem;

            public PPDDataReader(List<PPD> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 21; } }
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
                    case 0: // PPDKEY
                        return CurrentItem.PPDKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // ABN_OR_WPN
                        return CurrentItem.ABN_OR_WPN;
                    case 3: // NUMBER_TYPE
                        return CurrentItem.NUMBER_TYPE;
                    case 4: // BRANCH_NUMBER
                        return CurrentItem.BRANCH_NUMBER;
                    case 5: // FINANCIAL_YEAR
                        return CurrentItem.FINANCIAL_YEAR;
                    case 6: // NAME
                        return CurrentItem.NAME;
                    case 7: // TRADING_NAME
                        return CurrentItem.TRADING_NAME;
                    case 8: // L1_ADDRESS
                        return CurrentItem.L1_ADDRESS;
                    case 9: // L2_ADDRESS
                        return CurrentItem.L2_ADDRESS;
                    case 10: // SUBURB
                        return CurrentItem.SUBURB;
                    case 11: // STATE
                        return CurrentItem.STATE;
                    case 12: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 13: // COUNTRY
                        return CurrentItem.COUNTRY;
                    case 14: // CONTACT_NAME
                        return CurrentItem.CONTACT_NAME;
                    case 15: // PHONE
                        return CurrentItem.PHONE;
                    case 16: // FACSIMILE
                        return CurrentItem.FACSIMILE;
                    case 17: // SIGNATURE
                        return CurrentItem.SIGNATURE;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // ABN_OR_WPN
                        return CurrentItem.ABN_OR_WPN == null;
                    case 3: // NUMBER_TYPE
                        return CurrentItem.NUMBER_TYPE == null;
                    case 4: // BRANCH_NUMBER
                        return CurrentItem.BRANCH_NUMBER == null;
                    case 5: // FINANCIAL_YEAR
                        return CurrentItem.FINANCIAL_YEAR == null;
                    case 6: // NAME
                        return CurrentItem.NAME == null;
                    case 7: // TRADING_NAME
                        return CurrentItem.TRADING_NAME == null;
                    case 8: // L1_ADDRESS
                        return CurrentItem.L1_ADDRESS == null;
                    case 9: // L2_ADDRESS
                        return CurrentItem.L2_ADDRESS == null;
                    case 10: // SUBURB
                        return CurrentItem.SUBURB == null;
                    case 11: // STATE
                        return CurrentItem.STATE == null;
                    case 12: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 13: // COUNTRY
                        return CurrentItem.COUNTRY == null;
                    case 14: // CONTACT_NAME
                        return CurrentItem.CONTACT_NAME == null;
                    case 15: // PHONE
                        return CurrentItem.PHONE == null;
                    case 16: // FACSIMILE
                        return CurrentItem.FACSIMILE == null;
                    case 17: // SIGNATURE
                        return CurrentItem.SIGNATURE == null;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PPDKEY
                        return "PPDKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ABN_OR_WPN
                        return "ABN_OR_WPN";
                    case 3: // NUMBER_TYPE
                        return "NUMBER_TYPE";
                    case 4: // BRANCH_NUMBER
                        return "BRANCH_NUMBER";
                    case 5: // FINANCIAL_YEAR
                        return "FINANCIAL_YEAR";
                    case 6: // NAME
                        return "NAME";
                    case 7: // TRADING_NAME
                        return "TRADING_NAME";
                    case 8: // L1_ADDRESS
                        return "L1_ADDRESS";
                    case 9: // L2_ADDRESS
                        return "L2_ADDRESS";
                    case 10: // SUBURB
                        return "SUBURB";
                    case 11: // STATE
                        return "STATE";
                    case 12: // POSTCODE
                        return "POSTCODE";
                    case 13: // COUNTRY
                        return "COUNTRY";
                    case 14: // CONTACT_NAME
                        return "CONTACT_NAME";
                    case 15: // PHONE
                        return "PHONE";
                    case 16: // FACSIMILE
                        return "FACSIMILE";
                    case 17: // SIGNATURE
                        return "SIGNATURE";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PPDKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ABN_OR_WPN":
                        return 2;
                    case "NUMBER_TYPE":
                        return 3;
                    case "BRANCH_NUMBER":
                        return 4;
                    case "FINANCIAL_YEAR":
                        return 5;
                    case "NAME":
                        return 6;
                    case "TRADING_NAME":
                        return 7;
                    case "L1_ADDRESS":
                        return 8;
                    case "L2_ADDRESS":
                        return 9;
                    case "SUBURB":
                        return 10;
                    case "STATE":
                        return 11;
                    case "POSTCODE":
                        return 12;
                    case "COUNTRY":
                        return 13;
                    case "CONTACT_NAME":
                        return 14;
                    case "PHONE":
                        return 15;
                    case "FACSIMILE":
                        return 16;
                    case "SIGNATURE":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
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
