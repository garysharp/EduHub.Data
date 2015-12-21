using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS messages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPSMSDataSet : EduHubDataSet<SPSMS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPSMS"; } }

        internal SPSMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPSMSKEY = new Lazy<Dictionary<int, SPSMS>>(() => this.ToDictionary(i => i.SPSMSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPSMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPSMS" /> fields for each CSV column header</returns>
        protected override Action<SPSMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPSMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPSMSKEY":
                        mapper[i] = (e, v) => e.SPSMSKEY = int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "CREATED_DATE":
                        mapper[i] = (e, v) => e.CREATED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATED_BY":
                        mapper[i] = (e, v) => e.CREATED_BY = v;
                        break;
                    case "NOTIFY_REPLIES":
                        mapper[i] = (e, v) => e.NOTIFY_REPLIES = v;
                        break;
                    case "AUTO_MESSAGE":
                        mapper[i] = (e, v) => e.AUTO_MESSAGE = v;
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
        /// Merges <see cref="SPSMS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPSMS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPSMS" /> items to added or update the base <see cref="SPSMS" /> items</param>
        /// <returns>A merged list of <see cref="SPSMS" /> items</returns>
        protected override List<SPSMS> ApplyDeltaItems(List<SPSMS> Items, List<SPSMS> DeltaItems)
        {
            Dictionary<int, int> Index_SPSMSKEY = Items.ToIndexDictionary(i => i.SPSMSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPSMS deltaItem in DeltaItems)
            {
                int index;

                if (Index_SPSMSKEY.TryGetValue(deltaItem.SPSMSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SPSMSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SPSMS>> Index_SPSMSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPSMS FindBySPSMSKEY(int SPSMSKEY)
        {
            return Index_SPSMSKEY.Value[SPSMSKEY];
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <param name="Value">Related SPSMS entity</param>
        /// <returns>True if the related SPSMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPSMSKEY(int SPSMSKEY, out SPSMS Value)
        {
            return Index_SPSMSKEY.Value.TryGetValue(SPSMSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPSMS TryFindBySPSMSKEY(int SPSMSKEY)
        {
            SPSMS value;
            if (Index_SPSMSKEY.Value.TryGetValue(SPSMSKEY, out value))
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
        /// Returns SQL which checks for the existence of a SPSMS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPSMS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPSMS](
        [SPSMSKEY] int IDENTITY NOT NULL,
        [MESSAGE] varchar(160) NULL,
        [CREATED_DATE] datetime NULL,
        [CREATED_BY] varchar(128) NULL,
        [NOTIFY_REPLIES] varchar(1) NULL,
        [AUTO_MESSAGE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPSMS_Index_SPSMSKEY] PRIMARY KEY CLUSTERED (
            [SPSMSKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPSMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPSMS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SPSMSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPSMSDataReader : IDataReader, IDataRecord
        {
            private List<SPSMS> Items;
            private int CurrentIndex;
            private SPSMS CurrentItem;

            public SPSMSDataReader(List<SPSMS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 9; } }
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
                    case 0: // SPSMSKEY
                        return CurrentItem.SPSMSKEY;
                    case 1: // MESSAGE
                        return CurrentItem.MESSAGE;
                    case 2: // CREATED_DATE
                        return CurrentItem.CREATED_DATE;
                    case 3: // CREATED_BY
                        return CurrentItem.CREATED_BY;
                    case 4: // NOTIFY_REPLIES
                        return CurrentItem.NOTIFY_REPLIES;
                    case 5: // AUTO_MESSAGE
                        return CurrentItem.AUTO_MESSAGE;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // MESSAGE
                        return CurrentItem.MESSAGE == null;
                    case 2: // CREATED_DATE
                        return CurrentItem.CREATED_DATE == null;
                    case 3: // CREATED_BY
                        return CurrentItem.CREATED_BY == null;
                    case 4: // NOTIFY_REPLIES
                        return CurrentItem.NOTIFY_REPLIES == null;
                    case 5: // AUTO_MESSAGE
                        return CurrentItem.AUTO_MESSAGE == null;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SPSMSKEY
                        return "SPSMSKEY";
                    case 1: // MESSAGE
                        return "MESSAGE";
                    case 2: // CREATED_DATE
                        return "CREATED_DATE";
                    case 3: // CREATED_BY
                        return "CREATED_BY";
                    case 4: // NOTIFY_REPLIES
                        return "NOTIFY_REPLIES";
                    case 5: // AUTO_MESSAGE
                        return "AUTO_MESSAGE";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SPSMSKEY":
                        return 0;
                    case "MESSAGE":
                        return 1;
                    case "CREATED_DATE":
                        return 2;
                    case "CREATED_BY":
                        return 3;
                    case "NOTIFY_REPLIES":
                        return 4;
                    case "AUTO_MESSAGE":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
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
