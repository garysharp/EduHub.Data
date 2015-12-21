using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// On line receipt history Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIRHDataSet : EduHubDataSet<SIRH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SIRH"; } }

        internal SIRHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PRINT_ID = new Lazy<Dictionary<int, SIRH>>(() => this.ToDictionary(i => i.PRINT_ID));
            Index_SIRHKEY = new Lazy<Dictionary<string, SIRH>>(() => this.ToDictionary(i => i.SIRHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIRH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIRH" /> fields for each CSV column header</returns>
        protected override Action<SIRH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIRH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIRHKEY":
                        mapper[i] = (e, v) => e.SIRHKEY = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "RECEIPT_USER":
                        mapper[i] = (e, v) => e.RECEIPT_USER = v;
                        break;
                    case "RECEIPT_DATE":
                        mapper[i] = (e, v) => e.RECEIPT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECEIPT_TIME":
                        mapper[i] = (e, v) => e.RECEIPT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NEW_TRREF":
                        mapper[i] = (e, v) => e.NEW_TRREF = v;
                        break;
                    case "ERROR_FLAG":
                        mapper[i] = (e, v) => e.ERROR_FLAG = v;
                        break;
                    case "ERROR_COMMENT":
                        mapper[i] = (e, v) => e.ERROR_COMMENT = v;
                        break;
                    case "ERROR_USER":
                        mapper[i] = (e, v) => e.ERROR_USER = v;
                        break;
                    case "FORMAT_ID":
                        mapper[i] = (e, v) => e.FORMAT_ID = v;
                        break;
                    case "PRINT_ID":
                        mapper[i] = (e, v) => e.PRINT_ID = int.Parse(v);
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
        /// Merges <see cref="SIRH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SIRH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SIRH" /> items to added or update the base <see cref="SIRH" /> items</param>
        /// <returns>A merged list of <see cref="SIRH" /> items</returns>
        protected override List<SIRH> ApplyDeltaItems(List<SIRH> Items, List<SIRH> DeltaItems)
        {
            Dictionary<int, int> Index_PRINT_ID = Items.ToIndexDictionary(i => i.PRINT_ID);
            Dictionary<string, int> Index_SIRHKEY = Items.ToIndexDictionary(i => i.SIRHKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SIRH deltaItem in DeltaItems)
            {
                int index;

                if (Index_PRINT_ID.TryGetValue(deltaItem.PRINT_ID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_SIRHKEY.TryGetValue(deltaItem.SIRHKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SIRHKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SIRH>> Index_PRINT_ID;
        private Lazy<Dictionary<string, SIRH>> Index_SIRHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH FindByPRINT_ID(int PRINT_ID)
        {
            return Index_PRINT_ID.Value[PRINT_ID];
        }

        /// <summary>
        /// Attempt to find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the related SIRH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPRINT_ID(int PRINT_ID, out SIRH Value)
        {
            return Index_PRINT_ID.Value.TryGetValue(PRINT_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH TryFindByPRINT_ID(int PRINT_ID)
        {
            SIRH value;
            if (Index_PRINT_ID.Value.TryGetValue(PRINT_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH FindBySIRHKEY(string SIRHKEY)
        {
            return Index_SIRHKEY.Value[SIRHKEY];
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the related SIRH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIRHKEY(string SIRHKEY, out SIRH Value)
        {
            return Index_SIRHKEY.Value.TryGetValue(SIRHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH TryFindBySIRHKEY(string SIRHKEY)
        {
            SIRH value;
            if (Index_SIRHKEY.Value.TryGetValue(SIRHKEY, out value))
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
        /// Returns SQL which checks for the existence of a SIRH table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SIRH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SIRH](
        [SIRHKEY] varchar(20) NOT NULL,
        [CODE] varchar(10) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRREF] varchar(10) NULL,
        [TRBATCH] int NULL,
        [TRDET] varchar(30) NULL,
        [TRDATE] datetime NULL,
        [TRAMT] money NULL,
        [RTYPE] varchar(2) NULL,
        [RECEIPT_USER] varchar(128) NULL,
        [RECEIPT_DATE] datetime NULL,
        [RECEIPT_TIME] smallint NULL,
        [NEW_TRREF] varchar(10) NULL,
        [ERROR_FLAG] varchar(1) NULL,
        [ERROR_COMMENT] text NULL,
        [ERROR_USER] varchar(128) NULL,
        [FORMAT_ID] varchar(7) NULL,
        [PRINT_ID] int IDENTITY NOT NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SIRH_Index_SIRHKEY] PRIMARY KEY CLUSTERED (
            [SIRHKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SIRH_Index_PRINT_ID] ON [dbo].[SIRH]
    (
            [PRINT_ID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SIRH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SIRH data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SIRHDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SIRHDataReader : IDataReader, IDataRecord
        {
            private List<SIRH> Items;
            private int CurrentIndex;
            private SIRH CurrentItem;

            public SIRHDataReader(List<SIRH> Items)
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
                    case 0: // SIRHKEY
                        return CurrentItem.SIRHKEY;
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 3: // TRREF
                        return CurrentItem.TRREF;
                    case 4: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 5: // TRDET
                        return CurrentItem.TRDET;
                    case 6: // TRDATE
                        return CurrentItem.TRDATE;
                    case 7: // TRAMT
                        return CurrentItem.TRAMT;
                    case 8: // RTYPE
                        return CurrentItem.RTYPE;
                    case 9: // RECEIPT_USER
                        return CurrentItem.RECEIPT_USER;
                    case 10: // RECEIPT_DATE
                        return CurrentItem.RECEIPT_DATE;
                    case 11: // RECEIPT_TIME
                        return CurrentItem.RECEIPT_TIME;
                    case 12: // NEW_TRREF
                        return CurrentItem.NEW_TRREF;
                    case 13: // ERROR_FLAG
                        return CurrentItem.ERROR_FLAG;
                    case 14: // ERROR_COMMENT
                        return CurrentItem.ERROR_COMMENT;
                    case 15: // ERROR_USER
                        return CurrentItem.ERROR_USER;
                    case 16: // FORMAT_ID
                        return CurrentItem.FORMAT_ID;
                    case 17: // PRINT_ID
                        return CurrentItem.PRINT_ID;
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
                    case 1: // CODE
                        return CurrentItem.CODE == null;
                    case 2: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 3: // TRREF
                        return CurrentItem.TRREF == null;
                    case 4: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 5: // TRDET
                        return CurrentItem.TRDET == null;
                    case 6: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 7: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 8: // RTYPE
                        return CurrentItem.RTYPE == null;
                    case 9: // RECEIPT_USER
                        return CurrentItem.RECEIPT_USER == null;
                    case 10: // RECEIPT_DATE
                        return CurrentItem.RECEIPT_DATE == null;
                    case 11: // RECEIPT_TIME
                        return CurrentItem.RECEIPT_TIME == null;
                    case 12: // NEW_TRREF
                        return CurrentItem.NEW_TRREF == null;
                    case 13: // ERROR_FLAG
                        return CurrentItem.ERROR_FLAG == null;
                    case 14: // ERROR_COMMENT
                        return CurrentItem.ERROR_COMMENT == null;
                    case 15: // ERROR_USER
                        return CurrentItem.ERROR_USER == null;
                    case 16: // FORMAT_ID
                        return CurrentItem.FORMAT_ID == null;
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
                    case 0: // SIRHKEY
                        return "SIRHKEY";
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRXLEDGER
                        return "TRXLEDGER";
                    case 3: // TRREF
                        return "TRREF";
                    case 4: // TRBATCH
                        return "TRBATCH";
                    case 5: // TRDET
                        return "TRDET";
                    case 6: // TRDATE
                        return "TRDATE";
                    case 7: // TRAMT
                        return "TRAMT";
                    case 8: // RTYPE
                        return "RTYPE";
                    case 9: // RECEIPT_USER
                        return "RECEIPT_USER";
                    case 10: // RECEIPT_DATE
                        return "RECEIPT_DATE";
                    case 11: // RECEIPT_TIME
                        return "RECEIPT_TIME";
                    case 12: // NEW_TRREF
                        return "NEW_TRREF";
                    case 13: // ERROR_FLAG
                        return "ERROR_FLAG";
                    case 14: // ERROR_COMMENT
                        return "ERROR_COMMENT";
                    case 15: // ERROR_USER
                        return "ERROR_USER";
                    case 16: // FORMAT_ID
                        return "FORMAT_ID";
                    case 17: // PRINT_ID
                        return "PRINT_ID";
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
                    case "SIRHKEY":
                        return 0;
                    case "CODE":
                        return 1;
                    case "TRXLEDGER":
                        return 2;
                    case "TRREF":
                        return 3;
                    case "TRBATCH":
                        return 4;
                    case "TRDET":
                        return 5;
                    case "TRDATE":
                        return 6;
                    case "TRAMT":
                        return 7;
                    case "RTYPE":
                        return 8;
                    case "RECEIPT_USER":
                        return 9;
                    case "RECEIPT_DATE":
                        return 10;
                    case "RECEIPT_TIME":
                        return 11;
                    case "NEW_TRREF":
                        return 12;
                    case "ERROR_FLAG":
                        return 13;
                    case "ERROR_COMMENT":
                        return 14;
                    case "ERROR_USER":
                        return 15;
                    case "FORMAT_ID":
                        return 16;
                    case "PRINT_ID":
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
