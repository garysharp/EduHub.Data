using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts for Sundry Debtors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRBDataSet : DataSetBase<DRB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DRB"; } }

        internal DRBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DR_CODE = new Lazy<Dictionary<string, IReadOnlyList<DRB>>>(() => this.ToGroupedDictionary(i => i.DR_CODE));
            Index_REFERENCE_NO = new Lazy<NullDictionary<string, IReadOnlyList<DRB>>>(() => this.ToGroupedNullDictionary(i => i.REFERENCE_NO));
            Index_TID = new Lazy<Dictionary<int, DRB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DRB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DRB" /> fields for each CSV column header</returns>
        protected override Action<DRB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DRB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "DR_CODE":
                        mapper[i] = (e, v) => e.DR_CODE = v;
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
        /// Merges <see cref="DRB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DRB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DRB" /> items to added or update the base <see cref="DRB" /> items</param>
        /// <returns>A merged list of <see cref="DRB" /> items</returns>
        protected override List<DRB> ApplyDeltaItems(List<DRB> Items, List<DRB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DRB deltaItem in DeltaItems)
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
                .OrderBy(i => i.DR_CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DRB>>> Index_DR_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DRB>>> Index_REFERENCE_NO;
        private Lazy<Dictionary<int, DRB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DRB by DR_CODE field
        /// </summary>
        /// <param name="DR_CODE">DR_CODE value used to find DRB</param>
        /// <returns>List of related DRB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> FindByDR_CODE(string DR_CODE)
        {
            return Index_DR_CODE.Value[DR_CODE];
        }

        /// <summary>
        /// Attempt to find DRB by DR_CODE field
        /// </summary>
        /// <param name="DR_CODE">DR_CODE value used to find DRB</param>
        /// <param name="Value">List of related DRB entities</param>
        /// <returns>True if the list of related DRB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDR_CODE(string DR_CODE, out IReadOnlyList<DRB> Value)
        {
            return Index_DR_CODE.Value.TryGetValue(DR_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by DR_CODE field
        /// </summary>
        /// <param name="DR_CODE">DR_CODE value used to find DRB</param>
        /// <returns>List of related DRB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> TryFindByDR_CODE(string DR_CODE)
        {
            IReadOnlyList<DRB> value;
            if (Index_DR_CODE.Value.TryGetValue(DR_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DRB</param>
        /// <returns>List of related DRB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> FindByREFERENCE_NO(string REFERENCE_NO)
        {
            return Index_REFERENCE_NO.Value[REFERENCE_NO];
        }

        /// <summary>
        /// Attempt to find DRB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DRB</param>
        /// <param name="Value">List of related DRB entities</param>
        /// <returns>True if the list of related DRB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREFERENCE_NO(string REFERENCE_NO, out IReadOnlyList<DRB> Value)
        {
            return Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DRB</param>
        /// <returns>List of related DRB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRB> TryFindByREFERENCE_NO(string REFERENCE_NO)
        {
            IReadOnlyList<DRB> value;
            if (Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRB</param>
        /// <returns>Related DRB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DRB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DRB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRB</param>
        /// <param name="Value">Related DRB entity</param>
        /// <returns>True if the related DRB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DRB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DRB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRB</param>
        /// <returns>Related DRB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DRB TryFindByTID(int TID)
        {
            DRB value;
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
        /// Returns SQL which checks for the existence of a DRB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DRB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DRB](
        [TID] int IDENTITY NOT NULL,
        [DR_CODE] varchar(10) NOT NULL,
        [REFERENCE_NO] varchar(21) NULL,
        [CUST_REFERENCE] varchar(20) NULL,
        [RECORD_TYPE] varchar(2) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [PAYMENT_TYPE] varchar(2) NULL,
        [AMOUNT] money NULL,
        [PAYMENT_DATE] datetime NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [INVOICE_TID] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DRB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [DRB_Index_DR_CODE] ON [dbo].[DRB]
    (
            [DR_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [DRB_Index_REFERENCE_NO] ON [dbo].[DRB]
    (
            [REFERENCE_NO] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DRB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DRB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DRBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DRBDataReader : IDataReader, IDataRecord
        {
            private List<DRB> Items;
            private int CurrentIndex;
            private DRB CurrentItem;

            public DRBDataReader(List<DRB> Items)
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
                    case 1: // DR_CODE
                        return CurrentItem.DR_CODE;
                    case 2: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO;
                    case 3: // CUST_REFERENCE
                        return CurrentItem.CUST_REFERENCE;
                    case 4: // RECORD_TYPE
                        return CurrentItem.RECORD_TYPE;
                    case 5: // BILLER_CODE
                        return CurrentItem.BILLER_CODE;
                    case 6: // PAYMENT_TYPE
                        return CurrentItem.PAYMENT_TYPE;
                    case 7: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 8: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE;
                    case 9: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG;
                    case 10: // INVOICE_TID
                        return CurrentItem.INVOICE_TID;
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
                    case 2: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO == null;
                    case 3: // CUST_REFERENCE
                        return CurrentItem.CUST_REFERENCE == null;
                    case 4: // RECORD_TYPE
                        return CurrentItem.RECORD_TYPE == null;
                    case 5: // BILLER_CODE
                        return CurrentItem.BILLER_CODE == null;
                    case 6: // PAYMENT_TYPE
                        return CurrentItem.PAYMENT_TYPE == null;
                    case 7: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 8: // PAYMENT_DATE
                        return CurrentItem.PAYMENT_DATE == null;
                    case 9: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG == null;
                    case 10: // INVOICE_TID
                        return CurrentItem.INVOICE_TID == null;
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
                    case 1: // DR_CODE
                        return "DR_CODE";
                    case 2: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 3: // CUST_REFERENCE
                        return "CUST_REFERENCE";
                    case 4: // RECORD_TYPE
                        return "RECORD_TYPE";
                    case 5: // BILLER_CODE
                        return "BILLER_CODE";
                    case 6: // PAYMENT_TYPE
                        return "PAYMENT_TYPE";
                    case 7: // AMOUNT
                        return "AMOUNT";
                    case 8: // PAYMENT_DATE
                        return "PAYMENT_DATE";
                    case 9: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 10: // INVOICE_TID
                        return "INVOICE_TID";
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
                    case "DR_CODE":
                        return 1;
                    case "REFERENCE_NO":
                        return 2;
                    case "CUST_REFERENCE":
                        return 3;
                    case "RECORD_TYPE":
                        return 4;
                    case "BILLER_CODE":
                        return 5;
                    case "PAYMENT_TYPE":
                        return 6;
                    case "AMOUNT":
                        return 7;
                    case "PAYMENT_DATE":
                        return 8;
                    case "DELETE_FLAG":
                        return 9;
                    case "INVOICE_TID":
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
