using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored SQL Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSDataSet : EduHubDataSet<QS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "QS"; } }

        internal QSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QSKEY = new Lazy<Dictionary<string, QS>>(() => this.ToDictionary(i => i.QSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QS" /> fields for each CSV column header</returns>
        protected override Action<QS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSKEY":
                        mapper[i] = (e, v) => e.QSKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SQLTEXT":
                        mapper[i] = (e, v) => e.SQLTEXT = v;
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
        /// Merges <see cref="QS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="QS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="QS" /> items to added or update the base <see cref="QS" /> items</param>
        /// <returns>A merged list of <see cref="QS" /> items</returns>
        protected override List<QS> ApplyDeltaItems(List<QS> Items, List<QS> DeltaItems)
        {
            Dictionary<string, int> Index_QSKEY = Items.ToIndexDictionary(i => i.QSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (QS deltaItem in DeltaItems)
            {
                int index;

                if (Index_QSKEY.TryGetValue(deltaItem.QSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.QSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, QS>> Index_QSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <returns>Related QS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QS FindByQSKEY(string QSKEY)
        {
            return Index_QSKEY.Value[QSKEY];
        }

        /// <summary>
        /// Attempt to find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <param name="Value">Related QS entity</param>
        /// <returns>True if the related QS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQSKEY(string QSKEY, out QS Value)
        {
            return Index_QSKEY.Value.TryGetValue(QSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <returns>Related QS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QS TryFindByQSKEY(string QSKEY)
        {
            QS value;
            if (Index_QSKEY.Value.TryGetValue(QSKEY, out value))
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
        /// Returns SQL which checks for the existence of a QS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QS](
        [QSKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [SQLTEXT] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QS_Index_QSKEY] PRIMARY KEY CLUSTERED (
            [QSKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new QSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QSDataReader : IDataReader, IDataRecord
        {
            private List<QS> Items;
            private int CurrentIndex;
            private QS CurrentItem;

            public QSDataReader(List<QS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 0: // QSKEY
                        return CurrentItem.QSKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // SQLTEXT
                        return CurrentItem.SQLTEXT;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // SQLTEXT
                        return CurrentItem.SQLTEXT == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // QSKEY
                        return "QSKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SQLTEXT
                        return "SQLTEXT";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "QSKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SQLTEXT":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
