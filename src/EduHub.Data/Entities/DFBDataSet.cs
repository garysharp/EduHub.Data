using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFBDataSet : DataSetBase<DFB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFB"; } }

        internal DFBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAM_CODE = new Lazy<Dictionary<string, IReadOnlyList<DFB>>>(() => this.ToGroupedDictionary(i => i.FAM_CODE));
            Index_REFERENCE_NO = new Lazy<NullDictionary<string, IReadOnlyList<DFB>>>(() => this.ToGroupedNullDictionary(i => i.REFERENCE_NO));
            Index_TID = new Lazy<Dictionary<int, DFB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFB" /> fields for each CSV column header</returns>
        protected override Action<DFB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAM_CODE":
                        mapper[i] = (e, v) => e.FAM_CODE = v;
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
        /// Merges <see cref="DFB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFB" /> items to added or update the base <see cref="DFB" /> items</param>
        /// <returns>A merged list of <see cref="DFB" /> items</returns>
        protected override List<DFB> ApplyDeltaItems(List<DFB> Items, List<DFB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFB deltaItem in DeltaItems)
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
                .OrderBy(i => i.FAM_CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFB>>> Index_FAM_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFB>>> Index_REFERENCE_NO;
        private Lazy<Dictionary<int, DFB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFB by FAM_CODE field
        /// </summary>
        /// <param name="FAM_CODE">FAM_CODE value used to find DFB</param>
        /// <returns>List of related DFB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> FindByFAM_CODE(string FAM_CODE)
        {
            return Index_FAM_CODE.Value[FAM_CODE];
        }

        /// <summary>
        /// Attempt to find DFB by FAM_CODE field
        /// </summary>
        /// <param name="FAM_CODE">FAM_CODE value used to find DFB</param>
        /// <param name="Value">List of related DFB entities</param>
        /// <returns>True if the list of related DFB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAM_CODE(string FAM_CODE, out IReadOnlyList<DFB> Value)
        {
            return Index_FAM_CODE.Value.TryGetValue(FAM_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by FAM_CODE field
        /// </summary>
        /// <param name="FAM_CODE">FAM_CODE value used to find DFB</param>
        /// <returns>List of related DFB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> TryFindByFAM_CODE(string FAM_CODE)
        {
            IReadOnlyList<DFB> value;
            if (Index_FAM_CODE.Value.TryGetValue(FAM_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DFB</param>
        /// <returns>List of related DFB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> FindByREFERENCE_NO(string REFERENCE_NO)
        {
            return Index_REFERENCE_NO.Value[REFERENCE_NO];
        }

        /// <summary>
        /// Attempt to find DFB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DFB</param>
        /// <param name="Value">List of related DFB entities</param>
        /// <returns>True if the list of related DFB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREFERENCE_NO(string REFERENCE_NO, out IReadOnlyList<DFB> Value)
        {
            return Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DFB</param>
        /// <returns>List of related DFB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> TryFindByREFERENCE_NO(string REFERENCE_NO)
        {
            IReadOnlyList<DFB> value;
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
        /// Find DFB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFB</param>
        /// <returns>Related DFB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFB</param>
        /// <param name="Value">Related DFB entity</param>
        /// <returns>True if the related DFB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFB</param>
        /// <returns>Related DFB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFB TryFindByTID(int TID)
        {
            DFB value;
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
        /// Returns SQL which checks for the existence of a DFB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DFB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DFB](
        [TID] int IDENTITY NOT NULL,
        [FAM_CODE] varchar(10) NOT NULL,
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
        CONSTRAINT [DFB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [DFB_Index_FAM_CODE] ON [dbo].[DFB]
    (
            [FAM_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [DFB_Index_REFERENCE_NO] ON [dbo].[DFB]
    (
            [REFERENCE_NO] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DFB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DFBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFBDataReader : IDataReader, IDataRecord
        {
            private List<DFB> Items;
            private int CurrentIndex;
            private DFB CurrentItem;

            public DFBDataReader(List<DFB> Items)
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
                    case 1: // FAM_CODE
                        return CurrentItem.FAM_CODE;
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
                    case 1: // FAM_CODE
                        return "FAM_CODE";
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
                    case "FAM_CODE":
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
