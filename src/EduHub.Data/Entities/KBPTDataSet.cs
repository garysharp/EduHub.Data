using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Temp Receipts Import Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KBPTDataSet : EduHubDataSet<KBPT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KBPT"; } }

        internal KBPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KBPT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KBPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KBPT" /> fields for each CSV column header</returns>
        protected override Action<KBPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KBPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CUST_REFERENCE":
                        mapper[i] = (e, v) => e.CUST_REFERENCE = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "INVOICE_TID":
                        mapper[i] = (e, v) => e.INVOICE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
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
        /// Merges <see cref="KBPT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KBPT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KBPT" /> items to added or update the base <see cref="KBPT" /> items</param>
        /// <returns>A merged list of <see cref="KBPT" /> items</returns>
        protected override List<KBPT> ApplyDeltaItems(List<KBPT> Items, List<KBPT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KBPT deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KBPT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KBPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBPT</param>
        /// <returns>Related KBPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBPT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KBPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBPT</param>
        /// <param name="Value">Related KBPT entity</param>
        /// <returns>True if the related KBPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KBPT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KBPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KBPT</param>
        /// <returns>Related KBPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBPT TryFindByTID(int TID)
        {
            KBPT value;
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
        /// Returns SQL which checks for the existence of a KBPT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KBPT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KBPT](
        [TID] int IDENTITY NOT NULL,
        [REFERENCE_NO] varchar(21) NULL,
        [CUST_REFERENCE] varchar(20) NULL,
        [RECORD_TYPE] varchar(2) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [PAYMENT_TYPE] varchar(2) NULL,
        [AMOUNT] money NULL,
        [PAYMENT_DATE] datetime NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [INVOICE_TID] int NULL,
        [TRXLEDGER] varchar(2) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KBPT_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KBPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KBPT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KBPTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KBPTDataReader : IDataReader, IDataRecord
        {
            private List<KBPT> Items;
            private int CurrentIndex;
            private KBPT CurrentItem;

            public KBPTDataReader(List<KBPT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 14; } }
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO;
                    case 2: // CUST_REFERENCE
                        return CurrentItem.CUST_REFERENCE;
                    case 3: // RECORD_TYPE
                        return CurrentItem.RECORD_TYPE;
                    case 4: // BILLER_CODE
                        return CurrentItem.BILLER_CODE;
                    case 5: // PAYMENT_TYPE
                        return CurrentItem.PAYMENT_TYPE;
                    case 6: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 7: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE;
                    case 8: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG;
                    case 9: // INVOICE_TID
                        return CurrentItem.INVOICE_TID;
                    case 10: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO == null;
                    case 2: // CUST_REFERENCE
                        return CurrentItem.CUST_REFERENCE == null;
                    case 3: // RECORD_TYPE
                        return CurrentItem.RECORD_TYPE == null;
                    case 4: // BILLER_CODE
                        return CurrentItem.BILLER_CODE == null;
                    case 5: // PAYMENT_TYPE
                        return CurrentItem.PAYMENT_TYPE == null;
                    case 6: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 7: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE == null;
                    case 8: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG == null;
                    case 9: // INVOICE_TID
                        return CurrentItem.INVOICE_TID == null;
                    case 10: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 2: // CUST_REFERENCE
                        return "CUST_REFERENCE";
                    case 3: // RECORD_TYPE
                        return "RECORD_TYPE";
                    case 4: // BILLER_CODE
                        return "BILLER_CODE";
                    case 5: // PAYMENT_TYPE
                        return "PAYMENT_TYPE";
                    case 6: // AMOUNT
                        return "AMOUNT";
                    case 7: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 8: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 9: // INVOICE_TID
                        return "INVOICE_TID";
                    case 10: // TRXLEDGER
                        return "TRXLEDGER";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "REFERENCE_NO":
                        return 1;
                    case "CUST_REFERENCE":
                        return 2;
                    case "RECORD_TYPE":
                        return 3;
                    case "BILLER_CODE":
                        return 4;
                    case "PAYMENT_TYPE":
                        return 5;
                    case "AMOUNT":
                        return 6;
                    case "PAYMENT_DATE":
                        return 7;
                    case "DELETE_FLAG":
                        return 8;
                    case "INVOICE_TID":
                        return 9;
                    case "TRXLEDGER":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
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
