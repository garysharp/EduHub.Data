using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Login Log Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_LLOGDataSet : EduHubDataSet<SEC_LLOG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_LLOG"; } }

        internal SEC_LLOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOGINLOGID = new Lazy<Dictionary<int, SEC_LLOG>>(() => this.ToDictionary(i => i.LOGINLOGID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_LLOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_LLOG" /> fields for each CSV column header</returns>
        protected override Action<SEC_LLOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_LLOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOGINLOGID":
                        mapper[i] = (e, v) => e.LOGINLOGID = int.Parse(v);
                        break;
                    case "SERVER":
                        mapper[i] = (e, v) => e.SERVER = v;
                        break;
                    case "VERSION":
                        mapper[i] = (e, v) => e.VERSION = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "USERNAME":
                        mapper[i] = (e, v) => e.USERNAME = v;
                        break;
                    case "BROWSER":
                        mapper[i] = (e, v) => e.BROWSER = v;
                        break;
                    case "SCREENSIZE":
                        mapper[i] = (e, v) => e.SCREENSIZE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
                        break;
                    case "IPADDRESS":
                        mapper[i] = (e, v) => e.IPADDRESS = v;
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "LOGGEDOUT":
                        mapper[i] = (e, v) => e.LOGGEDOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LOGINTIME":
                        mapper[i] = (e, v) => e.LOGINTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LOGOUTTIME":
                        mapper[i] = (e, v) => e.LOGOUTTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LOGGEDPERIOD":
                        mapper[i] = (e, v) => e.LOGGEDPERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_LLOG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_LLOG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_LLOG" /> items to added or update the base <see cref="SEC_LLOG" /> items</param>
        /// <returns>A merged list of <see cref="SEC_LLOG" /> items</returns>
        protected override List<SEC_LLOG> ApplyDeltaItems(List<SEC_LLOG> Items, List<SEC_LLOG> DeltaItems)
        {
            Dictionary<int, int> Index_LOGINLOGID = Items.ToIndexDictionary(i => i.LOGINLOGID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_LLOG deltaItem in DeltaItems)
            {
                int index;

                if (Index_LOGINLOGID.TryGetValue(deltaItem.LOGINLOGID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.LOGINLOGID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_LLOG>> Index_LOGINLOGID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_LLOG FindByLOGINLOGID(int LOGINLOGID)
        {
            return Index_LOGINLOGID.Value[LOGINLOGID];
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <param name="Value">Related SEC_LLOG entity</param>
        /// <returns>True if the related SEC_LLOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOGINLOGID(int LOGINLOGID, out SEC_LLOG Value)
        {
            return Index_LOGINLOGID.Value.TryGetValue(LOGINLOGID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_LLOG TryFindByLOGINLOGID(int LOGINLOGID)
        {
            SEC_LLOG value;
            if (Index_LOGINLOGID.Value.TryGetValue(LOGINLOGID, out value))
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
        /// Returns SQL which checks for the existence of a SEC_LLOG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_LLOG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_LLOG](
        [LOGINLOGID] int IDENTITY NOT NULL,
        [SERVER] varchar(50) NULL,
        [VERSION] varchar(10) NULL,
        [USERID] varchar(50) NULL,
        [USERNAME] varchar(150) NULL,
        [BROWSER] varchar(100) NULL,
        [SCREENSIZE] varchar(10) NULL,
        [RESULT] varchar(20) NULL,
        [IPADDRESS] varchar(16) NULL,
        [SESSIONID] varchar(50) NULL,
        [LOGGEDOUT] smallint NULL,
        [LOGINTIME] datetime NULL,
        [LOGOUTTIME] datetime NULL,
        [LOGGEDPERIOD] smallint NULL,
        CONSTRAINT [SEC_LLOG_Index_LOGINLOGID] PRIMARY KEY CLUSTERED (
            [LOGINLOGID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_LLOG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_LLOG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SEC_LLOGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_LLOGDataReader : IDataReader, IDataRecord
        {
            private List<SEC_LLOG> Items;
            private int CurrentIndex;
            private SEC_LLOG CurrentItem;

            public SEC_LLOGDataReader(List<SEC_LLOG> Items)
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
                    case 0: // LOGINLOGID
                        return CurrentItem.LOGINLOGID;
                    case 1: // SERVER
                        return CurrentItem.SERVER;
                    case 2: // VERSION
                        return CurrentItem.VERSION;
                    case 3: // USERID
                        return CurrentItem.USERID;
                    case 4: // USERNAME
                        return CurrentItem.USERNAME;
                    case 5: // BROWSER
                        return CurrentItem.BROWSER;
                    case 6: // SCREENSIZE
                        return CurrentItem.SCREENSIZE;
                    case 7: // RESULT
                        return CurrentItem.RESULT;
                    case 8: // IPADDRESS
                        return CurrentItem.IPADDRESS;
                    case 9: // SESSIONID
                        return CurrentItem.SESSIONID;
                    case 10: // LOGGEDOUT
                        return CurrentItem.LOGGEDOUT;
                    case 11: // LOGINTIME
                        return CurrentItem.LOGINTIME;
                    case 12: // LOGOUTTIME
                        return CurrentItem.LOGOUTTIME;
                    case 13: // LOGGEDPERIOD
                        return CurrentItem.LOGGEDPERIOD;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SERVER
                        return CurrentItem.SERVER == null;
                    case 2: // VERSION
                        return CurrentItem.VERSION == null;
                    case 3: // USERID
                        return CurrentItem.USERID == null;
                    case 4: // USERNAME
                        return CurrentItem.USERNAME == null;
                    case 5: // BROWSER
                        return CurrentItem.BROWSER == null;
                    case 6: // SCREENSIZE
                        return CurrentItem.SCREENSIZE == null;
                    case 7: // RESULT
                        return CurrentItem.RESULT == null;
                    case 8: // IPADDRESS
                        return CurrentItem.IPADDRESS == null;
                    case 9: // SESSIONID
                        return CurrentItem.SESSIONID == null;
                    case 10: // LOGGEDOUT
                        return CurrentItem.LOGGEDOUT == null;
                    case 11: // LOGINTIME
                        return CurrentItem.LOGINTIME == null;
                    case 12: // LOGOUTTIME
                        return CurrentItem.LOGOUTTIME == null;
                    case 13: // LOGGEDPERIOD
                        return CurrentItem.LOGGEDPERIOD == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // LOGINLOGID
                        return "LOGINLOGID";
                    case 1: // SERVER
                        return "SERVER";
                    case 2: // VERSION
                        return "VERSION";
                    case 3: // USERID
                        return "USERID";
                    case 4: // USERNAME
                        return "USERNAME";
                    case 5: // BROWSER
                        return "BROWSER";
                    case 6: // SCREENSIZE
                        return "SCREENSIZE";
                    case 7: // RESULT
                        return "RESULT";
                    case 8: // IPADDRESS
                        return "IPADDRESS";
                    case 9: // SESSIONID
                        return "SESSIONID";
                    case 10: // LOGGEDOUT
                        return "LOGGEDOUT";
                    case 11: // LOGINTIME
                        return "LOGINTIME";
                    case 12: // LOGOUTTIME
                        return "LOGOUTTIME";
                    case 13: // LOGGEDPERIOD
                        return "LOGGEDPERIOD";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "LOGINLOGID":
                        return 0;
                    case "SERVER":
                        return 1;
                    case "VERSION":
                        return 2;
                    case "USERID":
                        return 3;
                    case "USERNAME":
                        return 4;
                    case "BROWSER":
                        return 5;
                    case "SCREENSIZE":
                        return 6;
                    case "RESULT":
                        return 7;
                    case "IPADDRESS":
                        return 8;
                    case "SESSIONID":
                        return 9;
                    case "LOGGEDOUT":
                        return 10;
                    case "LOGINTIME":
                        return 11;
                    case "LOGOUTTIME":
                        return 12;
                    case "LOGGEDPERIOD":
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
