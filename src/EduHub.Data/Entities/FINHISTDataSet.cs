using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FINHISTDataSet : EduHubDataSet<FINHIST>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FINHIST"; } }

        internal FINHISTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, FINHIST>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FINHIST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FINHIST" /> fields for each CSV column header</returns>
        protected override Action<FINHIST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FINHIST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "LEDGER":
                        mapper[i] = (e, v) => e.LEDGER = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "TRANSACTION_ID":
                        mapper[i] = (e, v) => e.TRANSACTION_ID = v == null ? (int?)null : int.Parse(v);
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
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="FINHIST" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="FINHIST" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="FINHIST" /> items to added or update the base <see cref="FINHIST" /> items</param>
        /// <returns>A merged list of <see cref="FINHIST" /> items</returns>
        protected override List<FINHIST> ApplyDeltaItems(List<FINHIST> Items, List<FINHIST> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (FINHIST deltaItem in DeltaItems)
            {
                int index;

                if (Index_ID.TryGetValue(deltaItem.ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, FINHIST>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FINHIST FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <param name="Value">Related FINHIST entity</param>
        /// <returns>True if the related FINHIST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out FINHIST Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FINHIST TryFindByID(int ID)
        {
            FINHIST value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns SQL which checks for the existence of a FINHIST table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FINHIST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[FINHIST](
        [ID] int IDENTITY NOT NULL,
        [LEDGER] varchar(10) NULL,
        [ENTITY] varchar(10) NULL,
        [TRANSACTION_ID] int NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [ACCOUNT_NAME] varchar(60) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [CREATION_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [FINHIST_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FINHIST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FINHIST data set</returns>
        public override IDataReader GetDataReader()
        {
            return new FINHISTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class FINHISTDataReader : IDataReader, IDataRecord
        {
            private List<FINHIST> Items;
            private int CurrentIndex;
            private FINHIST CurrentItem;

            public FINHISTDataReader(List<FINHIST> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 13; } }
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
                    case 0: // ID
                        return CurrentItem.ID;
                    case 1: // LEDGER
                        return CurrentItem.LEDGER;
                    case 2: // ENTITY
                        return CurrentItem.ENTITY;
                    case 3: // TRANSACTION_ID
                        return CurrentItem.TRANSACTION_ID;
                    case 4: // BSB
                        return CurrentItem.BSB;
                    case 5: // ACCOUNT_NO
                        return CurrentItem.ACCOUNT_NO;
                    case 6: // ACCOUNT_NAME
                        return CurrentItem.ACCOUNT_NAME;
                    case 7: // BILLER_CODE
                        return CurrentItem.BILLER_CODE;
                    case 8: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE;
                    case 9: // CREATION_DATE
                        return CurrentItem.CREATION_DATE;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 12: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEDGER
                        return CurrentItem.LEDGER == null;
                    case 2: // ENTITY
                        return CurrentItem.ENTITY == null;
                    case 3: // TRANSACTION_ID
                        return CurrentItem.TRANSACTION_ID == null;
                    case 4: // BSB
                        return CurrentItem.BSB == null;
                    case 5: // ACCOUNT_NO
                        return CurrentItem.ACCOUNT_NO == null;
                    case 6: // ACCOUNT_NAME
                        return CurrentItem.ACCOUNT_NAME == null;
                    case 7: // BILLER_CODE
                        return CurrentItem.BILLER_CODE == null;
                    case 8: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE == null;
                    case 9: // CREATION_DATE
                        return CurrentItem.CREATION_DATE == null;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 12: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // LEDGER
                        return "LEDGER";
                    case 2: // ENTITY
                        return "ENTITY";
                    case 3: // TRANSACTION_ID
                        return "TRANSACTION_ID";
                    case 4: // BSB
                        return "BSB";
                    case 5: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 6: // ACCOUNT_NAME
                        return "ACCOUNT_NAME";
                    case 7: // BILLER_CODE
                        return "BILLER_CODE";
                    case 8: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 9: // CREATION_DATE
                        return "CREATION_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "LEDGER":
                        return 1;
                    case "ENTITY":
                        return 2;
                    case "TRANSACTION_ID":
                        return 3;
                    case "BSB":
                        return 4;
                    case "ACCOUNT_NO":
                        return 5;
                    case "ACCOUNT_NAME":
                        return 6;
                    case "BILLER_CODE":
                        return 7;
                    case "BPAY_REFERENCE":
                        return 8;
                    case "CREATION_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_USER":
                        return 12;
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
