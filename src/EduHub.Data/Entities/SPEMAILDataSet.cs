using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report email templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEMAILDataSet : EduHubDataSet<SPEMAIL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPEMAIL"; } }

        internal SPEMAILDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_REPORT = new Lazy<NullDictionary<string, IReadOnlyList<SPEMAIL>>>(() => this.ToGroupedNullDictionary(i => i.REPORT));
            Index_SPEMAILKEY = new Lazy<Dictionary<string, SPEMAIL>>(() => this.ToDictionary(i => i.SPEMAILKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEMAIL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEMAIL" /> fields for each CSV column header</returns>
        protected override Action<SPEMAIL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEMAIL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPEMAILKEY":
                        mapper[i] = (e, v) => e.SPEMAILKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "REPORT":
                        mapper[i] = (e, v) => e.REPORT = v;
                        break;
                    case "PRINT_PATH":
                        mapper[i] = (e, v) => e.PRINT_PATH = v;
                        break;
                    case "IMPORTANCE":
                        mapper[i] = (e, v) => e.IMPORTANCE = v;
                        break;
                    case "SEND_OPTION":
                        mapper[i] = (e, v) => e.SEND_OPTION = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "EMAIL_HTML":
                        mapper[i] = (e, v) => e.EMAIL_HTML = v;
                        break;
                    case "HTML_MESSAGE":
                        mapper[i] = (e, v) => e.HTML_MESSAGE = v;
                        break;
                    case "FROM_ADDRESS":
                        mapper[i] = (e, v) => e.FROM_ADDRESS = v;
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
        /// Merges <see cref="SPEMAIL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPEMAIL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPEMAIL" /> items to added or update the base <see cref="SPEMAIL" /> items</param>
        /// <returns>A merged list of <see cref="SPEMAIL" /> items</returns>
        protected override List<SPEMAIL> ApplyDeltaItems(List<SPEMAIL> Items, List<SPEMAIL> DeltaItems)
        {
            Dictionary<string, int> Index_SPEMAILKEY = Items.ToIndexDictionary(i => i.SPEMAILKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPEMAIL deltaItem in DeltaItems)
            {
                int index;

                if (Index_SPEMAILKEY.TryGetValue(deltaItem.SPEMAILKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SPEMAILKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SPEMAIL>>> Index_REPORT;
        private Lazy<Dictionary<string, SPEMAIL>> Index_SPEMAILKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <returns>List of related SPEMAIL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMAIL> FindByREPORT(string REPORT)
        {
            return Index_REPORT.Value[REPORT];
        }

        /// <summary>
        /// Attempt to find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <param name="Value">List of related SPEMAIL entities</param>
        /// <returns>True if the list of related SPEMAIL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREPORT(string REPORT, out IReadOnlyList<SPEMAIL> Value)
        {
            return Index_REPORT.Value.TryGetValue(REPORT, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <returns>List of related SPEMAIL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMAIL> TryFindByREPORT(string REPORT)
        {
            IReadOnlyList<SPEMAIL> value;
            if (Index_REPORT.Value.TryGetValue(REPORT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMAIL FindBySPEMAILKEY(string SPEMAILKEY)
        {
            return Index_SPEMAILKEY.Value[SPEMAILKEY];
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <param name="Value">Related SPEMAIL entity</param>
        /// <returns>True if the related SPEMAIL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPEMAILKEY(string SPEMAILKEY, out SPEMAIL Value)
        {
            return Index_SPEMAILKEY.Value.TryGetValue(SPEMAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMAIL TryFindBySPEMAILKEY(string SPEMAILKEY)
        {
            SPEMAIL value;
            if (Index_SPEMAILKEY.Value.TryGetValue(SPEMAILKEY, out value))
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
        /// Returns SQL which checks for the existence of a SPEMAIL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPEMAIL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPEMAIL](
        [SPEMAILKEY] varchar(15) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [REPORT] varchar(10) NULL,
        [PRINT_PATH] varchar(128) NULL,
        [IMPORTANCE] varchar(6) NULL,
        [SEND_OPTION] varchar(15) NULL,
        [EMAIL_SUBJECT] varchar(70) NULL,
        [EMAIL_MESSAGE] text NULL,
        [EMAIL_HTML] varchar(128) NULL,
        [HTML_MESSAGE] varchar(1) NULL,
        [FROM_ADDRESS] varchar(128) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPEMAIL_Index_SPEMAILKEY] PRIMARY KEY CLUSTERED (
            [SPEMAILKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SPEMAIL_Index_REPORT] ON [dbo].[SPEMAIL]
    (
            [REPORT] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEMAIL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEMAIL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SPEMAILDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPEMAILDataReader : IDataReader, IDataRecord
        {
            private List<SPEMAIL> Items;
            private int CurrentIndex;
            private SPEMAIL CurrentItem;

            public SPEMAILDataReader(List<SPEMAIL> Items)
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
                    case 0: // SPEMAILKEY
                        return CurrentItem.SPEMAILKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // REPORT
                        return CurrentItem.REPORT;
                    case 3: // PRINT_PATH
                        return CurrentItem.PRINT_PATH;
                    case 4: // IMPORTANCE
                        return CurrentItem.IMPORTANCE;
                    case 5: // SEND_OPTION
                        return CurrentItem.SEND_OPTION;
                    case 6: // EMAIL_SUBJECT
                        return CurrentItem.EMAIL_SUBJECT;
                    case 7: // EMAIL_MESSAGE
                        return CurrentItem.EMAIL_MESSAGE;
                    case 8: // EMAIL_HTML
                        return CurrentItem.EMAIL_HTML;
                    case 9: // HTML_MESSAGE
                        return CurrentItem.HTML_MESSAGE;
                    case 10: // FROM_ADDRESS
                        return CurrentItem.FROM_ADDRESS;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // REPORT
                        return CurrentItem.REPORT == null;
                    case 3: // PRINT_PATH
                        return CurrentItem.PRINT_PATH == null;
                    case 4: // IMPORTANCE
                        return CurrentItem.IMPORTANCE == null;
                    case 5: // SEND_OPTION
                        return CurrentItem.SEND_OPTION == null;
                    case 6: // EMAIL_SUBJECT
                        return CurrentItem.EMAIL_SUBJECT == null;
                    case 7: // EMAIL_MESSAGE
                        return CurrentItem.EMAIL_MESSAGE == null;
                    case 8: // EMAIL_HTML
                        return CurrentItem.EMAIL_HTML == null;
                    case 9: // HTML_MESSAGE
                        return CurrentItem.HTML_MESSAGE == null;
                    case 10: // FROM_ADDRESS
                        return CurrentItem.FROM_ADDRESS == null;
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
                    case 0: // SPEMAILKEY
                        return "SPEMAILKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // REPORT
                        return "REPORT";
                    case 3: // PRINT_PATH
                        return "PRINT_PATH";
                    case 4: // IMPORTANCE
                        return "IMPORTANCE";
                    case 5: // SEND_OPTION
                        return "SEND_OPTION";
                    case 6: // EMAIL_SUBJECT
                        return "EMAIL_SUBJECT";
                    case 7: // EMAIL_MESSAGE
                        return "EMAIL_MESSAGE";
                    case 8: // EMAIL_HTML
                        return "EMAIL_HTML";
                    case 9: // HTML_MESSAGE
                        return "HTML_MESSAGE";
                    case 10: // FROM_ADDRESS
                        return "FROM_ADDRESS";
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
                    case "SPEMAILKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "REPORT":
                        return 2;
                    case "PRINT_PATH":
                        return 3;
                    case "IMPORTANCE":
                        return 4;
                    case "SEND_OPTION":
                        return 5;
                    case "EMAIL_SUBJECT":
                        return 6;
                    case "EMAIL_MESSAGE":
                        return 7;
                    case "EMAIL_HTML":
                        return 8;
                    case "HTML_MESSAGE":
                        return 9;
                    case "FROM_ADDRESS":
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
