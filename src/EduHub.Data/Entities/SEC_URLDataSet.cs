using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_URLDataSet : DataSetBase<SEC_URL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_URL"; } }

        internal SEC_URLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOLURLID = new Lazy<Dictionary<int, SEC_URL>>(() => this.ToDictionary(i => i.SCHOOLURLID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_URL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_URL" /> fields for each CSV column header</returns>
        protected override Action<SEC_URL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_URL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLURLID":
                        mapper[i] = (e, v) => e.SCHOOLURLID = int.Parse(v);
                        break;
                    case "LINKNAME":
                        mapper[i] = (e, v) => e.LINKNAME = v;
                        break;
                    case "MAINURL":
                        mapper[i] = (e, v) => e.MAINURL = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_URL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_URL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_URL" /> items to added or update the base <see cref="SEC_URL" /> items</param>
        /// <returns>A merged list of <see cref="SEC_URL" /> items</returns>
        protected override List<SEC_URL> ApplyDeltaItems(List<SEC_URL> Items, List<SEC_URL> DeltaItems)
        {
            Dictionary<int, int> Index_SCHOOLURLID = Items.ToIndexDictionary(i => i.SCHOOLURLID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_URL deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCHOOLURLID.TryGetValue(deltaItem.SCHOOLURLID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCHOOLURLID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_URL>> Index_SCHOOLURLID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_URL FindBySCHOOLURLID(int SCHOOLURLID)
        {
            return Index_SCHOOLURLID.Value[SCHOOLURLID];
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <param name="Value">Related SEC_URL entity</param>
        /// <returns>True if the related SEC_URL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOLURLID(int SCHOOLURLID, out SEC_URL Value)
        {
            return Index_SCHOOLURLID.Value.TryGetValue(SCHOOLURLID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_URL TryFindBySCHOOLURLID(int SCHOOLURLID)
        {
            SEC_URL value;
            if (Index_SCHOOLURLID.Value.TryGetValue(SCHOOLURLID, out value))
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
        /// Returns SQL which checks for the existence of a SEC_URL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_URL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_URL](
        [SCHOOLURLID] int IDENTITY NOT NULL,
        [LINKNAME] varchar(50) NULL,
        [MAINURL] varchar(200) NULL,
        CONSTRAINT [SEC_URL_Index_SCHOOLURLID] PRIMARY KEY CLUSTERED (
            [SCHOOLURLID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_URL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_URL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SEC_URLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_URLDataReader : IDataReader, IDataRecord
        {
            private List<SEC_URL> Items;
            private int CurrentIndex;
            private SEC_URL CurrentItem;

            public SEC_URLDataReader(List<SEC_URL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 3; } }
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
                    case 0: // SCHOOLURLID
                        return CurrentItem.SCHOOLURLID;
                    case 1: // LINKNAME
                        return CurrentItem.LINKNAME;
                    case 2: // MAINURL
                        return CurrentItem.MAINURL;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LINKNAME
                        return CurrentItem.LINKNAME == null;
                    case 2: // MAINURL
                        return CurrentItem.MAINURL == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCHOOLURLID
                        return "SCHOOLURLID";
                    case 1: // LINKNAME
                        return "LINKNAME";
                    case 2: // MAINURL
                        return "MAINURL";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCHOOLURLID":
                        return 0;
                    case "LINKNAME":
                        return 1;
                    case "MAINURL":
                        return 2;
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
