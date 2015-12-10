using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_MSGDataSet : DataSetBase<SEC_MSG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_MSG"; } }

        internal SEC_MSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOLMSGID = new Lazy<Dictionary<int, SEC_MSG>>(() => this.ToDictionary(i => i.SCHOOLMSGID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_MSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_MSG" /> fields for each CSV column header</returns>
        protected override Action<SEC_MSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_MSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLMSGID":
                        mapper[i] = (e, v) => e.SCHOOLMSGID = int.Parse(v);
                        break;
                    case "MSGTEXT":
                        mapper[i] = (e, v) => e.MSGTEXT = v;
                        break;
                    case "EDITBYUSERID":
                        mapper[i] = (e, v) => e.EDITBYUSERID = v;
                        break;
                    case "EDITDATE":
                        mapper[i] = (e, v) => e.EDITDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_MSG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_MSG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_MSG" /> items to added or update the base <see cref="SEC_MSG" /> items</param>
        /// <returns>A merged list of <see cref="SEC_MSG" /> items</returns>
        protected override List<SEC_MSG> ApplyDeltaItems(List<SEC_MSG> Items, List<SEC_MSG> DeltaItems)
        {
            Dictionary<int, int> Index_SCHOOLMSGID = Items.ToIndexDictionary(i => i.SCHOOLMSGID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_MSG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCHOOLMSGID.TryGetValue(deltaItem.SCHOOLMSGID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCHOOLMSGID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_MSG>> Index_SCHOOLMSGID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_MSG FindBySCHOOLMSGID(int SCHOOLMSGID)
        {
            return Index_SCHOOLMSGID.Value[SCHOOLMSGID];
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <param name="Value">Related SEC_MSG entity</param>
        /// <returns>True if the related SEC_MSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOLMSGID(int SCHOOLMSGID, out SEC_MSG Value)
        {
            return Index_SCHOOLMSGID.Value.TryGetValue(SCHOOLMSGID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_MSG TryFindBySCHOOLMSGID(int SCHOOLMSGID)
        {
            SEC_MSG value;
            if (Index_SCHOOLMSGID.Value.TryGetValue(SCHOOLMSGID, out value))
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
        /// Returns SQL which checks for the existence of a SEC_MSG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_MSG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_MSG](
        [SCHOOLMSGID] int IDENTITY NOT NULL,
        [MSGTEXT] text NULL,
        [EDITBYUSERID] varchar(10) NULL,
        [EDITDATE] datetime NULL,
        CONSTRAINT [SEC_MSG_Index_SCHOOLMSGID] PRIMARY KEY CLUSTERED (
            [SCHOOLMSGID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_MSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_MSG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SEC_MSGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_MSGDataReader : IDataReader, IDataRecord
        {
            private List<SEC_MSG> Items;
            private int CurrentIndex;
            private SEC_MSG CurrentItem;

            public SEC_MSGDataReader(List<SEC_MSG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 4; } }
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
                    case 0: // SCHOOLMSGID
                        return CurrentItem.SCHOOLMSGID;
                    case 1: // MSGTEXT
                        return CurrentItem.MSGTEXT;
                    case 2: // EDITBYUSERID
                        return CurrentItem.EDITBYUSERID;
                    case 3: // EDITDATE
                        return CurrentItem.EDITDATE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // MSGTEXT
                        return CurrentItem.MSGTEXT == null;
                    case 2: // EDITBYUSERID
                        return CurrentItem.EDITBYUSERID == null;
                    case 3: // EDITDATE
                        return CurrentItem.EDITDATE == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCHOOLMSGID
                        return "SCHOOLMSGID";
                    case 1: // MSGTEXT
                        return "MSGTEXT";
                    case 2: // EDITBYUSERID
                        return "EDITBYUSERID";
                    case 3: // EDITDATE
                        return "EDITDATE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCHOOLMSGID":
                        return 0;
                    case "MSGTEXT":
                        return 1;
                    case "EDITBYUSERID":
                        return 2;
                    case "EDITDATE":
                        return 3;
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
