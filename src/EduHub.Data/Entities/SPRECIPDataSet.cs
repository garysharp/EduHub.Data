using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPRECIPDataSet : DataSetBase<SPRECIP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPRECIP"; } }

        internal SPRECIPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPRECIP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPRECIP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPRECIP" /> fields for each CSV column header</returns>
        protected override Action<SPRECIP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPRECIP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = int.Parse(v);
                        break;
                    case "RECIPIENT_TABLE":
                        mapper[i] = (e, v) => e.RECIPIENT_TABLE = v;
                        break;
                    case "RECIPIENT_KEY":
                        mapper[i] = (e, v) => e.RECIPIENT_KEY = v;
                        break;
                    case "RECIPIENT_NUMBER":
                        mapper[i] = (e, v) => e.RECIPIENT_NUMBER = v;
                        break;
                    case "READ_RECEIPT":
                        mapper[i] = (e, v) => e.READ_RECEIPT = v;
                        break;
                    case "SOURCE_TABLE":
                        mapper[i] = (e, v) => e.SOURCE_TABLE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STATUS_MESSAGE":
                        mapper[i] = (e, v) => e.STATUS_MESSAGE = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELIVERED_DATE":
                        mapper[i] = (e, v) => e.DELIVERED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MESSAGEID":
                        mapper[i] = (e, v) => e.MESSAGEID = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SPRECIP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPRECIP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPRECIP" /> items to added or update the base <see cref="SPRECIP" /> items</param>
        /// <returns>A merged list of <see cref="SPRECIP" /> items</returns>
        protected override List<SPRECIP> ApplyDeltaItems(List<SPRECIP> Items, List<SPRECIP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPRECIP deltaItem in DeltaItems)
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
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>> Index_CODE;
        private Lazy<Dictionary<int, SPRECIP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <returns>List of related SPRECIP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPRECIP> FindByCODE(int CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <param name="Value">List of related SPRECIP entities</param>
        /// <returns>True if the list of related SPRECIP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(int CODE, out IReadOnlyList<SPRECIP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <returns>List of related SPRECIP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPRECIP> TryFindByCODE(int CODE)
        {
            IReadOnlyList<SPRECIP> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPRECIP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <param name="Value">Related SPRECIP entity</param>
        /// <returns>True if the related SPRECIP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPRECIP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPRECIP TryFindByTID(int TID)
        {
            SPRECIP value;
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
        /// Returns SQL which checks for the existence of a SPRECIP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPRECIP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPRECIP](
        [TID] int IDENTITY NOT NULL,
        [CODE] int NOT NULL,
        [RECIPIENT_TABLE] varchar(8) NULL,
        [RECIPIENT_KEY] varchar(20) NULL,
        [RECIPIENT_NUMBER] varchar(15) NULL,
        [READ_RECEIPT] varchar(1) NULL,
        [SOURCE_TABLE] varchar(8) NULL,
        [SOURCE_KEY] varchar(20) NULL,
        [STATUS] varchar(1) NULL,
        [STATUS_MESSAGE] varchar(100) NULL,
        [SEND_DATE] datetime NULL,
        [DELIVERED_DATE] datetime NULL,
        [MESSAGEID] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPRECIP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SPRECIP_Index_CODE] ON [dbo].[SPRECIP]
    (
            [CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPRECIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPRECIP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SPRECIPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPRECIPDataReader : IDataReader, IDataRecord
        {
            private List<SPRECIP> Items;
            private int CurrentIndex;
            private SPRECIP CurrentItem;

            public SPRECIPDataReader(List<SPRECIP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 16; } }
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
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // RECIPIENT_TABLE
                        return CurrentItem.RECIPIENT_TABLE;
                    case 3: // RECIPIENT_KEY
                        return CurrentItem.RECIPIENT_KEY;
                    case 4: // RECIPIENT_NUMBER
                        return CurrentItem.RECIPIENT_NUMBER;
                    case 5: // READ_RECEIPT
                        return CurrentItem.READ_RECEIPT;
                    case 6: // SOURCE_TABLE
                        return CurrentItem.SOURCE_TABLE;
                    case 7: // SOURCE_KEY
                        return CurrentItem.SOURCE_KEY;
                    case 8: // STATUS
                        return CurrentItem.STATUS;
                    case 9: // STATUS_MESSAGE
                        return CurrentItem.STATUS_MESSAGE;
                    case 10: // SEND_DATE
                        return CurrentItem.SEND_DATE;
                    case 11: // DELIVERED_DATE
                        return CurrentItem.DELIVERED_DATE;
                    case 12: // MESSAGEID
                        return CurrentItem.MESSAGEID;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // RECIPIENT_TABLE
                        return CurrentItem.RECIPIENT_TABLE == null;
                    case 3: // RECIPIENT_KEY
                        return CurrentItem.RECIPIENT_KEY == null;
                    case 4: // RECIPIENT_NUMBER
                        return CurrentItem.RECIPIENT_NUMBER == null;
                    case 5: // READ_RECEIPT
                        return CurrentItem.READ_RECEIPT == null;
                    case 6: // SOURCE_TABLE
                        return CurrentItem.SOURCE_TABLE == null;
                    case 7: // SOURCE_KEY
                        return CurrentItem.SOURCE_KEY == null;
                    case 8: // STATUS
                        return CurrentItem.STATUS == null;
                    case 9: // STATUS_MESSAGE
                        return CurrentItem.STATUS_MESSAGE == null;
                    case 10: // SEND_DATE
                        return CurrentItem.SEND_DATE == null;
                    case 11: // DELIVERED_DATE
                        return CurrentItem.DELIVERED_DATE == null;
                    case 12: // MESSAGEID
                        return CurrentItem.MESSAGEID == null;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 15: // LW_USER
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // RECIPIENT_TABLE
                        return "RECIPIENT_TABLE";
                    case 3: // RECIPIENT_KEY
                        return "RECIPIENT_KEY";
                    case 4: // RECIPIENT_NUMBER
                        return "RECIPIENT_NUMBER";
                    case 5: // READ_RECEIPT
                        return "READ_RECEIPT";
                    case 6: // SOURCE_TABLE
                        return "SOURCE_TABLE";
                    case 7: // SOURCE_KEY
                        return "SOURCE_KEY";
                    case 8: // STATUS
                        return "STATUS";
                    case 9: // STATUS_MESSAGE
                        return "STATUS_MESSAGE";
                    case 10: // SEND_DATE
                        return "SEND_DATE";
                    case 11: // DELIVERED_DATE
                        return "DELIVERED_DATE";
                    case 12: // MESSAGEID
                        return "MESSAGEID";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
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
                    case "CODE":
                        return 1;
                    case "RECIPIENT_TABLE":
                        return 2;
                    case "RECIPIENT_KEY":
                        return 3;
                    case "RECIPIENT_NUMBER":
                        return 4;
                    case "READ_RECEIPT":
                        return 5;
                    case "SOURCE_TABLE":
                        return 6;
                    case "SOURCE_KEY":
                        return 7;
                    case "STATUS":
                        return 8;
                    case "STATUS_MESSAGE":
                        return 9;
                    case "SEND_DATE":
                        return 10;
                    case "DELIVERED_DATE":
                        return 11;
                    case "MESSAGEID":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
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
