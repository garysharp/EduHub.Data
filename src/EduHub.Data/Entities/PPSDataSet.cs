using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Supplier Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPSDataSet : EduHubDataSet<PPS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PPS"; } }

        internal PPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPS>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_POSTAL_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPS>>>(() => this.ToGroupedNullDictionary(i => i.POSTAL_COUNTRY));
            Index_PPSKEY = new Lazy<Dictionary<string, PPS>>(() => this.ToDictionary(i => i.PPSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPS" /> fields for each CSV column header</returns>
        protected override Action<PPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPSKEY":
                        mapper[i] = (e, v) => e.PPSKEY = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "CONTACT_PHONE":
                        mapper[i] = (e, v) => e.CONTACT_PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "FILE_REFERENCE":
                        mapper[i] = (e, v) => e.FILE_REFERENCE = v;
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
                    case "POSTAL_L1_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L1_ADD = v;
                        break;
                    case "POSTAL_L2_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L2_ADD = v;
                        break;
                    case "POSTAL_SUBURB":
                        mapper[i] = (e, v) => e.POSTAL_SUBURB = v;
                        break;
                    case "POSTAL_STATE":
                        mapper[i] = (e, v) => e.POSTAL_STATE = v;
                        break;
                    case "POSTAL_POSTCODE":
                        mapper[i] = (e, v) => e.POSTAL_POSTCODE = v;
                        break;
                    case "POSTAL_COUNTRY":
                        mapper[i] = (e, v) => e.POSTAL_COUNTRY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
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
        /// Merges <see cref="PPS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PPS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PPS" /> items to added or update the base <see cref="PPS" /> items</param>
        /// <returns>A merged list of <see cref="PPS" /> items</returns>
        protected override List<PPS> ApplyDeltaItems(List<PPS> Items, List<PPS> DeltaItems)
        {
            Dictionary<string, int> Index_PPSKEY = Items.ToIndexDictionary(i => i.PPSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PPS deltaItem in DeltaItems)
            {
                int index;

                if (Index_PPSKEY.TryGetValue(deltaItem.PPSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PPSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PPS>>> Index_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<PPS>>> Index_POSTAL_COUNTRY;
        private Lazy<Dictionary<string, PPS>> Index_PPSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <param name="Value">List of related PPS entities</param>
        /// <returns>True if the list of related PPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPS> value;
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
        /// Find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> FindByPOSTAL_COUNTRY(string POSTAL_COUNTRY)
        {
            return Index_POSTAL_COUNTRY.Value[POSTAL_COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <param name="Value">List of related PPS entities</param>
        /// <returns>True if the list of related PPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPOSTAL_COUNTRY(string POSTAL_COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return Index_POSTAL_COUNTRY.Value.TryGetValue(POSTAL_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> TryFindByPOSTAL_COUNTRY(string POSTAL_COUNTRY)
        {
            IReadOnlyList<PPS> value;
            if (Index_POSTAL_COUNTRY.Value.TryGetValue(POSTAL_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <returns>Related PPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPS FindByPPSKEY(string PPSKEY)
        {
            return Index_PPSKEY.Value[PPSKEY];
        }

        /// <summary>
        /// Attempt to find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <param name="Value">Related PPS entity</param>
        /// <returns>True if the related PPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPSKEY(string PPSKEY, out PPS Value)
        {
            return Index_PPSKEY.Value.TryGetValue(PPSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <returns>Related PPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPS TryFindByPPSKEY(string PPSKEY)
        {
            PPS value;
            if (Index_PPSKEY.Value.TryGetValue(PPSKEY, out value))
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
        /// Returns SQL which checks for the existence of a PPS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PPS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PPS](
        [PPSKEY] varchar(10) NOT NULL,
        [ABN] varchar(11) NULL,
        [NAME] varchar(76) NULL,
        [CONTACT_NAME] varchar(38) NULL,
        [CONTACT_PHONE] varchar(15) NULL,
        [FACSIMILE] varchar(15) NULL,
        [FILE_REFERENCE] varchar(16) NULL,
        [L1_ADDRESS] varchar(38) NULL,
        [L2_ADDRESS] varchar(38) NULL,
        [SUBURB] varchar(27) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [COUNTRY] varchar(6) NULL,
        [POSTAL_L1_ADD] varchar(38) NULL,
        [POSTAL_L2_ADD] varchar(38) NULL,
        [POSTAL_SUBURB] varchar(27) NULL,
        [POSTAL_STATE] varchar(3) NULL,
        [POSTAL_POSTCODE] varchar(4) NULL,
        [POSTAL_COUNTRY] varchar(6) NULL,
        [EMAIL_ADDRESS] varchar(76) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PPS_Index_PPSKEY] PRIMARY KEY CLUSTERED (
            [PPSKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PPS_Index_COUNTRY] ON [dbo].[PPS]
    (
            [COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [PPS_Index_POSTAL_COUNTRY] ON [dbo].[PPS]
    (
            [POSTAL_COUNTRY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PPS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PPSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PPSDataReader : IDataReader, IDataRecord
        {
            private List<PPS> Items;
            private int CurrentIndex;
            private PPS CurrentItem;

            public PPSDataReader(List<PPS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 23; } }
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
                    case 0: // PPSKEY
                        return CurrentItem.PPSKEY;
                    case 1: // ABN
                        return CurrentItem.ABN;
                    case 2: // NAME
                        return CurrentItem.NAME;
                    case 3: // CONTACT_NAME
                        return CurrentItem.CONTACT_NAME;
                    case 4: // CONTACT_PHONE
                        return CurrentItem.CONTACT_PHONE;
                    case 5: // FACSIMILE
                        return CurrentItem.FACSIMILE;
                    case 6: // FILE_REFERENCE
                        return CurrentItem.FILE_REFERENCE;
                    case 7: // L1_ADDRESS
                        return CurrentItem.L1_ADDRESS;
                    case 8: // L2_ADDRESS
                        return CurrentItem.L2_ADDRESS;
                    case 9: // SUBURB
                        return CurrentItem.SUBURB;
                    case 10: // STATE
                        return CurrentItem.STATE;
                    case 11: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 12: // COUNTRY
                        return CurrentItem.COUNTRY;
                    case 13: // POSTAL_L1_ADD
                        return CurrentItem.POSTAL_L1_ADD;
                    case 14: // POSTAL_L2_ADD
                        return CurrentItem.POSTAL_L2_ADD;
                    case 15: // POSTAL_SUBURB
                        return CurrentItem.POSTAL_SUBURB;
                    case 16: // POSTAL_STATE
                        return CurrentItem.POSTAL_STATE;
                    case 17: // POSTAL_POSTCODE
                        return CurrentItem.POSTAL_POSTCODE;
                    case 18: // POSTAL_COUNTRY
                        return CurrentItem.POSTAL_COUNTRY;
                    case 19: // EMAIL_ADDRESS
                        return CurrentItem.EMAIL_ADDRESS;
                    case 20: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 21: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 22: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ABN
                        return CurrentItem.ABN == null;
                    case 2: // NAME
                        return CurrentItem.NAME == null;
                    case 3: // CONTACT_NAME
                        return CurrentItem.CONTACT_NAME == null;
                    case 4: // CONTACT_PHONE
                        return CurrentItem.CONTACT_PHONE == null;
                    case 5: // FACSIMILE
                        return CurrentItem.FACSIMILE == null;
                    case 6: // FILE_REFERENCE
                        return CurrentItem.FILE_REFERENCE == null;
                    case 7: // L1_ADDRESS
                        return CurrentItem.L1_ADDRESS == null;
                    case 8: // L2_ADDRESS
                        return CurrentItem.L2_ADDRESS == null;
                    case 9: // SUBURB
                        return CurrentItem.SUBURB == null;
                    case 10: // STATE
                        return CurrentItem.STATE == null;
                    case 11: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 12: // COUNTRY
                        return CurrentItem.COUNTRY == null;
                    case 13: // POSTAL_L1_ADD
                        return CurrentItem.POSTAL_L1_ADD == null;
                    case 14: // POSTAL_L2_ADD
                        return CurrentItem.POSTAL_L2_ADD == null;
                    case 15: // POSTAL_SUBURB
                        return CurrentItem.POSTAL_SUBURB == null;
                    case 16: // POSTAL_STATE
                        return CurrentItem.POSTAL_STATE == null;
                    case 17: // POSTAL_POSTCODE
                        return CurrentItem.POSTAL_POSTCODE == null;
                    case 18: // POSTAL_COUNTRY
                        return CurrentItem.POSTAL_COUNTRY == null;
                    case 19: // EMAIL_ADDRESS
                        return CurrentItem.EMAIL_ADDRESS == null;
                    case 20: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 21: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 22: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PPSKEY
                        return "PPSKEY";
                    case 1: // ABN
                        return "ABN";
                    case 2: // NAME
                        return "NAME";
                    case 3: // CONTACT_NAME
                        return "CONTACT_NAME";
                    case 4: // CONTACT_PHONE
                        return "CONTACT_PHONE";
                    case 5: // FACSIMILE
                        return "FACSIMILE";
                    case 6: // FILE_REFERENCE
                        return "FILE_REFERENCE";
                    case 7: // L1_ADDRESS
                        return "L1_ADDRESS";
                    case 8: // L2_ADDRESS
                        return "L2_ADDRESS";
                    case 9: // SUBURB
                        return "SUBURB";
                    case 10: // STATE
                        return "STATE";
                    case 11: // POSTCODE
                        return "POSTCODE";
                    case 12: // COUNTRY
                        return "COUNTRY";
                    case 13: // POSTAL_L1_ADD
                        return "POSTAL_L1_ADD";
                    case 14: // POSTAL_L2_ADD
                        return "POSTAL_L2_ADD";
                    case 15: // POSTAL_SUBURB
                        return "POSTAL_SUBURB";
                    case 16: // POSTAL_STATE
                        return "POSTAL_STATE";
                    case 17: // POSTAL_POSTCODE
                        return "POSTAL_POSTCODE";
                    case 18: // POSTAL_COUNTRY
                        return "POSTAL_COUNTRY";
                    case 19: // EMAIL_ADDRESS
                        return "EMAIL_ADDRESS";
                    case 20: // LW_DATE
                        return "LW_DATE";
                    case 21: // LW_TIME
                        return "LW_TIME";
                    case 22: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PPSKEY":
                        return 0;
                    case "ABN":
                        return 1;
                    case "NAME":
                        return 2;
                    case "CONTACT_NAME":
                        return 3;
                    case "CONTACT_PHONE":
                        return 4;
                    case "FACSIMILE":
                        return 5;
                    case "FILE_REFERENCE":
                        return 6;
                    case "L1_ADDRESS":
                        return 7;
                    case "L2_ADDRESS":
                        return 8;
                    case "SUBURB":
                        return 9;
                    case "STATE":
                        return 10;
                    case "POSTCODE":
                        return 11;
                    case "COUNTRY":
                        return 12;
                    case "POSTAL_L1_ADD":
                        return 13;
                    case "POSTAL_L2_ADD":
                        return 14;
                    case "POSTAL_SUBURB":
                        return 15;
                    case "POSTAL_STATE":
                        return 16;
                    case "POSTAL_POSTCODE":
                        return 17;
                    case "POSTAL_COUNTRY":
                        return 18;
                    case "EMAIL_ADDRESS":
                        return 19;
                    case "LW_DATE":
                        return 20;
                    case "LW_TIME":
                        return 21;
                    case "LW_USER":
                        return 22;
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
