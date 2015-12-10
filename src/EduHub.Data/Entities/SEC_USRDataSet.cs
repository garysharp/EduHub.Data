using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_USRDataSet : DataSetBase<SEC_USR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_USR"; } }

        internal SEC_USRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROWID = new Lazy<Dictionary<int, SEC_USR>>(() => this.ToDictionary(i => i.ROWID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_USR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_USR" /> fields for each CSV column header</returns>
        protected override Action<SEC_USR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_USR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROWID":
                        mapper[i] = (e, v) => e.ROWID = int.Parse(v);
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "DATECREATED":
                        mapper[i] = (e, v) => e.DATECREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_USR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_USR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_USR" /> items to added or update the base <see cref="SEC_USR" /> items</param>
        /// <returns>A merged list of <see cref="SEC_USR" /> items</returns>
        protected override List<SEC_USR> ApplyDeltaItems(List<SEC_USR> Items, List<SEC_USR> DeltaItems)
        {
            Dictionary<int, int> Index_ROWID = Items.ToIndexDictionary(i => i.ROWID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_USR deltaItem in DeltaItems)
            {
                int index;

                if (Index_ROWID.TryGetValue(deltaItem.ROWID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ROWID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_USR>> Index_ROWID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_USR FindByROWID(int ROWID)
        {
            return Index_ROWID.Value[ROWID];
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <param name="Value">Related SEC_USR entity</param>
        /// <returns>True if the related SEC_USR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROWID(int ROWID, out SEC_USR Value)
        {
            return Index_ROWID.Value.TryGetValue(ROWID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_USR TryFindByROWID(int ROWID)
        {
            SEC_USR value;
            if (Index_ROWID.Value.TryGetValue(ROWID, out value))
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
        /// Returns SQL which checks for the existence of a SEC_USR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_USR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_USR](
        [ROWID] int IDENTITY NOT NULL,
        [SESSIONID] varchar(255) NULL,
        [USERID] varchar(50) NULL,
        [DATECREATED] datetime NULL,
        CONSTRAINT [SEC_USR_Index_ROWID] PRIMARY KEY CLUSTERED (
            [ROWID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_USR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_USR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SEC_USRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_USRDataReader : IDataReader, IDataRecord
        {
            private List<SEC_USR> Items;
            private int CurrentIndex;
            private SEC_USR CurrentItem;

            public SEC_USRDataReader(List<SEC_USR> Items)
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
                    case 0: // ROWID
                        return CurrentItem.ROWID;
                    case 1: // SESSIONID
                        return CurrentItem.SESSIONID;
                    case 2: // USERID
                        return CurrentItem.USERID;
                    case 3: // DATECREATED
                        return CurrentItem.DATECREATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SESSIONID
                        return CurrentItem.SESSIONID == null;
                    case 2: // USERID
                        return CurrentItem.USERID == null;
                    case 3: // DATECREATED
                        return CurrentItem.DATECREATED == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ROWID
                        return "ROWID";
                    case 1: // SESSIONID
                        return "SESSIONID";
                    case 2: // USERID
                        return "USERID";
                    case 3: // DATECREATED
                        return "DATECREATED";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ROWID":
                        return 0;
                    case "SESSIONID":
                        return 1;
                    case "USERID":
                        return 2;
                    case "DATECREATED":
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
