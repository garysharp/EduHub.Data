using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPay Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BPAY_DATDataSet : EduHubDataSet<BPAY_DAT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BPAY_DAT"; } }

        internal BPAY_DATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, BPAY_DAT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BPAY_DAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BPAY_DAT" /> fields for each CSV column header</returns>
        protected override Action<BPAY_DAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BPAY_DAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v;
                        break;
                    case "CUST_REF":
                        mapper[i] = (e, v) => e.CUST_REF = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "SUPPORT_REF":
                        mapper[i] = (e, v) => e.SUPPORT_REF = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
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
        /// Merges <see cref="BPAY_DAT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="BPAY_DAT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="BPAY_DAT" /> items to added or update the base <see cref="BPAY_DAT" /> items</param>
        /// <returns>A merged list of <see cref="BPAY_DAT" /> items</returns>
        protected override List<BPAY_DAT> ApplyDeltaItems(List<BPAY_DAT> Items, List<BPAY_DAT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (BPAY_DAT deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, BPAY_DAT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BPAY_DAT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <param name="Value">Related BPAY_DAT entity</param>
        /// <returns>True if the related BPAY_DAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BPAY_DAT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BPAY_DAT TryFindByTID(int TID)
        {
            BPAY_DAT value;
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
        /// Returns SQL which checks for the existence of a BPAY_DAT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BPAY_DAT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BPAY_DAT](
        [TID] int IDENTITY NOT NULL,
        [LINE_TYPE] varchar(1) NULL,
        [RECORD] varchar(255) NULL,
        [PAYMENT_DATE] varchar(8) NULL,
        [CUST_REF] varchar(50) NULL,
        [AMOUNT] money NULL,
        [PAYMENT_TYPE] varchar(2) NULL,
        [BILLER_CODE] varchar(5) NULL,
        [SUPPORT_REF] varchar(21) NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [RECORD_TYPE] varchar(2) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BPAY_DAT_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BPAY_DAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BPAY_DAT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new BPAY_DATDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BPAY_DATDataReader : IDataReader, IDataRecord
        {
            private List<BPAY_DAT> Items;
            private int CurrentIndex;
            private BPAY_DAT CurrentItem;

            public BPAY_DATDataReader(List<BPAY_DAT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 15; } }
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
                    case 1: // LINE_TYPE
                        return CurrentItem.LINE_TYPE;
                    case 2: // RECORD
                        return CurrentItem.RECORD;
                    case 3: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE;
                    case 4: // CUST_REF
                        return CurrentItem.CUST_REF;
                    case 5: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 6: // PAYMENT_TYPE
                        return CurrentItem.PAYMENT_TYPE;
                    case 7: // BILLER_CODE
                        return CurrentItem.BILLER_CODE;
                    case 8: // SUPPORT_REF
                        return CurrentItem.SUPPORT_REF;
                    case 9: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG;
                    case 10: // RECORD_TYPE
                        return CurrentItem.RECORD_TYPE;
                    case 11: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LINE_TYPE
                        return CurrentItem.LINE_TYPE == null;
                    case 2: // RECORD
                        return CurrentItem.RECORD == null;
                    case 3: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE == null;
                    case 4: // CUST_REF
                        return CurrentItem.CUST_REF == null;
                    case 5: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 6: // PAYMENT_TYPE
                        return CurrentItem.PAYMENT_TYPE == null;
                    case 7: // BILLER_CODE
                        return CurrentItem.BILLER_CODE == null;
                    case 8: // SUPPORT_REF
                        return CurrentItem.SUPPORT_REF == null;
                    case 9: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG == null;
                    case 10: // RECORD_TYPE
                        return CurrentItem.RECORD_TYPE == null;
                    case 11: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 14: // LW_USER
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
                    case 1: // LINE_TYPE
                        return "LINE_TYPE";
                    case 2: // RECORD
                        return "RECORD";
                    case 3: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 4: // CUST_REF
                        return "CUST_REF";
                    case 5: // AMOUNT
                        return "AMOUNT";
                    case 6: // PAYMENT_TYPE
                        return "PAYMENT_TYPE";
                    case 7: // BILLER_CODE
                        return "BILLER_CODE";
                    case 8: // SUPPORT_REF
                        return "SUPPORT_REF";
                    case 9: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 10: // RECORD_TYPE
                        return "RECORD_TYPE";
                    case 11: // TRXLEDGER
                        return "TRXLEDGER";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
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
                    case "LINE_TYPE":
                        return 1;
                    case "RECORD":
                        return 2;
                    case "PAYMENT_DATE":
                        return 3;
                    case "CUST_REF":
                        return 4;
                    case "AMOUNT":
                        return 5;
                    case "PAYMENT_TYPE":
                        return 6;
                    case "BILLER_CODE":
                        return 7;
                    case "SUPPORT_REF":
                        return 8;
                    case "DELETE_FLAG":
                        return 9;
                    case "RECORD_TYPE":
                        return 10;
                    case "TRXLEDGER":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
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
