using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KBANKDataSet : EduHubDataSet<KBANK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KBANK"; } }

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
        protected override Action<KBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.LAST_RECONCILE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_RECONCILE_DIFF":
                        mapper[i] = (e, v) => e.LAST_RECONCILE_DIFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KBANK" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KBANK" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KBANK" /> items to added or update the base <see cref="KBANK" /> items</param>
        /// <returns>A merged list of <see cref="KBANK" /> items</returns>
        protected override List<KBANK> ApplyDeltaItems(List<KBANK> Items, List<KBANK> DeltaItems)
        {
            Dictionary<string, int> Index_GLCODE = Items.ToIndexDictionary(i => i.GLCODE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KBANK deltaItem in DeltaItems)
            {
                int index;

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
        /// Returns SQL which checks for the existence of a KBANK table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KBANK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
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
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KBANK_Index_GLCODE] PRIMARY KEY CLUSTERED (
            [GLCODE] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBANK data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KBANKDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KBANKDataReader : IDataReader, IDataRecord
        {
            private List<KBANK> Items;
            private int CurrentIndex;
            private KBANK CurrentItem;

            public KBANKDataReader(List<KBANK> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 19; } }
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
                    case 1: // GLTITLE
                        return CurrentItem.GLTITLE;
                    case 2: // BILLER_CODE
                        return CurrentItem.BILLER_CODE;
                    case 3: // BANK_NAME
                        return CurrentItem.BANK_NAME;
                    case 4: // BANK_BRANCH
                        return CurrentItem.BANK_BRANCH;
                    case 5: // BANK_ADDRESS01
                        return CurrentItem.BANK_ADDRESS01;
                    case 6: // BANK_ADDRESS02
                        return CurrentItem.BANK_ADDRESS02;
                    case 7: // BANK_ACCOUNT_NAME
                        return CurrentItem.BANK_ACCOUNT_NAME;
                    case 8: // BANK_ACCOUNT_BSB
                        return CurrentItem.BANK_ACCOUNT_BSB;
                    case 9: // BANK_ACCOUNT_NO
                        return CurrentItem.BANK_ACCOUNT_NO;
                    case 10: // BANK_ABBREVIATION
                        return CurrentItem.BANK_ABBREVIATION;
                    case 11: // APCA_NUMBER
                        return CurrentItem.APCA_NUMBER;
                    case 12: // BALANCE_ENTRY
                        return CurrentItem.BALANCE_ENTRY;
                    case 13: // LAST_RECONCILE_DATE
                        return CurrentItem.LAST_RECONCILE_DATE;
                    case 14: // LAST_RECONCILE_DIFF
                        return CurrentItem.LAST_RECONCILE_DIFF;
                    case 15: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 16: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 17: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 18: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // GLTITLE
                        return CurrentItem.GLTITLE == null;
                    case 2: // BILLER_CODE
                        return CurrentItem.BILLER_CODE == null;
                    case 3: // BANK_NAME
                        return CurrentItem.BANK_NAME == null;
                    case 4: // BANK_BRANCH
                        return CurrentItem.BANK_BRANCH == null;
                    case 5: // BANK_ADDRESS01
                        return CurrentItem.BANK_ADDRESS01 == null;
                    case 6: // BANK_ADDRESS02
                        return CurrentItem.BANK_ADDRESS02 == null;
                    case 7: // BANK_ACCOUNT_NAME
                        return CurrentItem.BANK_ACCOUNT_NAME == null;
                    case 8: // BANK_ACCOUNT_BSB
                        return CurrentItem.BANK_ACCOUNT_BSB == null;
                    case 9: // BANK_ACCOUNT_NO
                        return CurrentItem.BANK_ACCOUNT_NO == null;
                    case 10: // BANK_ABBREVIATION
                        return CurrentItem.BANK_ABBREVIATION == null;
                    case 11: // APCA_NUMBER
                        return CurrentItem.APCA_NUMBER == null;
                    case 12: // BALANCE_ENTRY
                        return CurrentItem.BALANCE_ENTRY == null;
                    case 13: // LAST_RECONCILE_DATE
                        return CurrentItem.LAST_RECONCILE_DATE == null;
                    case 14: // LAST_RECONCILE_DIFF
                        return CurrentItem.LAST_RECONCILE_DIFF == null;
                    case 15: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 16: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 17: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 18: // LW_USER
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
                    case 16: // LW_DATE
                        return "LW_DATE";
                    case 17: // LW_TIME
                        return "LW_TIME";
                    case 18: // LW_USER
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
                    case "LW_DATE":
                        return 16;
                    case "LW_TIME":
                        return 17;
                    case "LW_USER":
                        return 18;
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
