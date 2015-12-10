using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report file audit Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEPRINTDataSet : DataSetBase<SPEPRINT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPEPRINT"; } }

        internal SPEPRINTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPEPRINT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEPRINT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEPRINT" /> fields for each CSV column header</returns>
        protected override Action<SPEPRINT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEPRINT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PRINT_DATE":
                        mapper[i] = (e, v) => e.PRINT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PRINT_BY":
                        mapper[i] = (e, v) => e.PRINT_BY = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SEND_BY":
                        mapper[i] = (e, v) => e.SEND_BY = v;
                        break;
                    case "ENTITY_TABLE":
                        mapper[i] = (e, v) => e.ENTITY_TABLE = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "COPY_ADDRESS":
                        mapper[i] = (e, v) => e.COPY_ADDRESS = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "ATTACHMENT_PATH":
                        mapper[i] = (e, v) => e.ATTACHMENT_PATH = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "DISPLAY":
                        mapper[i] = (e, v) => e.DISPLAY = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
        /// Merges <see cref="SPEPRINT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPEPRINT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPEPRINT" /> items to added or update the base <see cref="SPEPRINT" /> items</param>
        /// <returns>A merged list of <see cref="SPEPRINT" /> items</returns>
        protected override List<SPEPRINT> ApplyDeltaItems(List<SPEPRINT> Items, List<SPEPRINT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPEPRINT deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>> Index_CODE;
        private Lazy<Dictionary<int, SPEPRINT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <returns>List of related SPEPRINT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEPRINT> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <param name="Value">List of related SPEPRINT entities</param>
        /// <returns>True if the list of related SPEPRINT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<SPEPRINT> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <returns>List of related SPEPRINT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEPRINT> TryFindByCODE(string CODE)
        {
            IReadOnlyList<SPEPRINT> value;
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
        /// Find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEPRINT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <param name="Value">Related SPEPRINT entity</param>
        /// <returns>True if the related SPEPRINT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPEPRINT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEPRINT TryFindByTID(int TID)
        {
            SPEPRINT value;
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
        /// Returns SQL which checks for the existence of a SPEPRINT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPEPRINT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPEPRINT](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(15) NOT NULL,
        [PRINT_DATE] datetime NULL,
        [PRINT_BY] varchar(128) NULL,
        [SEND_DATE] datetime NULL,
        [SEND_BY] varchar(128) NULL,
        [ENTITY_TABLE] varchar(8) NULL,
        [ENTITY_KEY] varchar(20) NULL,
        [EMAIL_ADDRESS] varchar(60) NULL,
        [COPY_ADDRESS] varchar(60) NULL,
        [EMAIL_SUBJECT] varchar(100) NULL,
        [EMAIL_MESSAGE] text NULL,
        [ATTACHMENT_PATH] varchar(255) NULL,
        [STATUS] varchar(30) NULL,
        [DISPLAY] varchar(1) NULL,
        [COMMENTS] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPEPRINT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SPEPRINT_Index_CODE] ON [dbo].[SPEPRINT]
    (
            [CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEPRINT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEPRINT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SPEPRINTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPEPRINTDataReader : IDataReader, IDataRecord
        {
            private List<SPEPRINT> Items;
            private int CurrentIndex;
            private SPEPRINT CurrentItem;

            public SPEPRINTDataReader(List<SPEPRINT> Items)
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // PRINT_DATE
                        return CurrentItem.PRINT_DATE;
                    case 3: // PRINT_BY
                        return CurrentItem.PRINT_BY;
                    case 4: // SEND_DATE
                        return CurrentItem.SEND_DATE;
                    case 5: // SEND_BY
                        return CurrentItem.SEND_BY;
                    case 6: // ENTITY_TABLE
                        return CurrentItem.ENTITY_TABLE;
                    case 7: // ENTITY_KEY
                        return CurrentItem.ENTITY_KEY;
                    case 8: // EMAIL_ADDRESS
                        return CurrentItem.EMAIL_ADDRESS;
                    case 9: // COPY_ADDRESS
                        return CurrentItem.COPY_ADDRESS;
                    case 10: // EMAIL_SUBJECT
                        return CurrentItem.EMAIL_SUBJECT;
                    case 11: // EMAIL_MESSAGE
                        return CurrentItem.EMAIL_MESSAGE;
                    case 12: // ATTACHMENT_PATH
                        return CurrentItem.ATTACHMENT_PATH;
                    case 13: // STATUS
                        return CurrentItem.STATUS;
                    case 14: // DISPLAY
                        return CurrentItem.DISPLAY;
                    case 15: // COMMENTS
                        return CurrentItem.COMMENTS;
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
                    case 2: // PRINT_DATE
                        return CurrentItem.PRINT_DATE == null;
                    case 3: // PRINT_BY
                        return CurrentItem.PRINT_BY == null;
                    case 4: // SEND_DATE
                        return CurrentItem.SEND_DATE == null;
                    case 5: // SEND_BY
                        return CurrentItem.SEND_BY == null;
                    case 6: // ENTITY_TABLE
                        return CurrentItem.ENTITY_TABLE == null;
                    case 7: // ENTITY_KEY
                        return CurrentItem.ENTITY_KEY == null;
                    case 8: // EMAIL_ADDRESS
                        return CurrentItem.EMAIL_ADDRESS == null;
                    case 9: // COPY_ADDRESS
                        return CurrentItem.COPY_ADDRESS == null;
                    case 10: // EMAIL_SUBJECT
                        return CurrentItem.EMAIL_SUBJECT == null;
                    case 11: // EMAIL_MESSAGE
                        return CurrentItem.EMAIL_MESSAGE == null;
                    case 12: // ATTACHMENT_PATH
                        return CurrentItem.ATTACHMENT_PATH == null;
                    case 13: // STATUS
                        return CurrentItem.STATUS == null;
                    case 14: // DISPLAY
                        return CurrentItem.DISPLAY == null;
                    case 15: // COMMENTS
                        return CurrentItem.COMMENTS == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // PRINT_DATE
                        return "PRINT_DATE";
                    case 3: // PRINT_BY
                        return "PRINT_BY";
                    case 4: // SEND_DATE
                        return "SEND_DATE";
                    case 5: // SEND_BY
                        return "SEND_BY";
                    case 6: // ENTITY_TABLE
                        return "ENTITY_TABLE";
                    case 7: // ENTITY_KEY
                        return "ENTITY_KEY";
                    case 8: // EMAIL_ADDRESS
                        return "EMAIL_ADDRESS";
                    case 9: // COPY_ADDRESS
                        return "COPY_ADDRESS";
                    case 10: // EMAIL_SUBJECT
                        return "EMAIL_SUBJECT";
                    case 11: // EMAIL_MESSAGE
                        return "EMAIL_MESSAGE";
                    case 12: // ATTACHMENT_PATH
                        return "ATTACHMENT_PATH";
                    case 13: // STATUS
                        return "STATUS";
                    case 14: // DISPLAY
                        return "DISPLAY";
                    case 15: // COMMENTS
                        return "COMMENTS";
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
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "PRINT_DATE":
                        return 2;
                    case "PRINT_BY":
                        return 3;
                    case "SEND_DATE":
                        return 4;
                    case "SEND_BY":
                        return 5;
                    case "ENTITY_TABLE":
                        return 6;
                    case "ENTITY_KEY":
                        return 7;
                    case "EMAIL_ADDRESS":
                        return 8;
                    case "COPY_ADDRESS":
                        return 9;
                    case "EMAIL_SUBJECT":
                        return 10;
                    case "EMAIL_MESSAGE":
                        return 11;
                    case "ATTACHMENT_PATH":
                        return 12;
                    case "STATUS":
                        return 13;
                    case "DISPLAY":
                        return 14;
                    case "COMMENTS":
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
