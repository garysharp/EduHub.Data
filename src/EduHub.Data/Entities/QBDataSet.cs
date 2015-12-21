using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Batch Headers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QBDataSet : EduHubDataSet<QB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "QB"; } }

        internal QBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QBKEY = new Lazy<Dictionary<int, QB>>(() => this.ToDictionary(i => i.QBKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QB" /> fields for each CSV column header</returns>
        protected override Action<QB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QBKEY":
                        mapper[i] = (e, v) => e.QBKEY = int.Parse(v);
                        break;
                    case "NARRATIVE":
                        mapper[i] = (e, v) => e.NARRATIVE = v;
                        break;
                    case "TOTAL":
                        mapper[i] = (e, v) => e.TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v;
                        break;
                    case "QUANTITY":
                        mapper[i] = (e, v) => e.QUANTITY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BATCHTYPE":
                        mapper[i] = (e, v) => e.BATCHTYPE = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "BATCHDATA":
                        mapper[i] = (e, v) => e.BATCHDATA = null; // eduHub is not encoding byte arrays
                        break;
                    case "BATCHPRINTED":
                        mapper[i] = (e, v) => e.BATCHPRINTED = v;
                        break;
                    case "BANKPRINTED":
                        mapper[i] = (e, v) => e.BANKPRINTED = v;
                        break;
                    case "BATCHTRACE":
                        mapper[i] = (e, v) => e.BATCHTRACE = v;
                        break;
                    case "BATCHCLASS":
                        mapper[i] = (e, v) => e.BATCHCLASS = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="QB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="QB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="QB" /> items to added or update the base <see cref="QB" /> items</param>
        /// <returns>A merged list of <see cref="QB" /> items</returns>
        protected override List<QB> ApplyDeltaItems(List<QB> Items, List<QB> DeltaItems)
        {
            Dictionary<int, int> Index_QBKEY = Items.ToIndexDictionary(i => i.QBKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (QB deltaItem in DeltaItems)
            {
                int index;

                if (Index_QBKEY.TryGetValue(deltaItem.QBKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.QBKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, QB>> Index_QBKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <returns>Related QB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QB FindByQBKEY(int QBKEY)
        {
            return Index_QBKEY.Value[QBKEY];
        }

        /// <summary>
        /// Attempt to find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <param name="Value">Related QB entity</param>
        /// <returns>True if the related QB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQBKEY(int QBKEY, out QB Value)
        {
            return Index_QBKEY.Value.TryGetValue(QBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <returns>Related QB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QB TryFindByQBKEY(int QBKEY)
        {
            QB value;
            if (Index_QBKEY.Value.TryGetValue(QBKEY, out value))
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
        /// Returns SQL which checks for the existence of a QB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QB](
        [QBKEY] int NOT NULL,
        [NARRATIVE] varchar(40) NULL,
        [TOTAL] money NULL,
        [CLASS] varchar(2) NULL,
        [QUANTITY] int NULL,
        [BATCHTYPE] varchar(1) NULL,
        [TRANSTYPE] varchar(1) NULL,
        [BATCHDATA] image NULL,
        [BATCHPRINTED] varchar(1) NULL,
        [BANKPRINTED] varchar(1) NULL,
        [BATCHTRACE] varchar(1) NULL,
        [BATCHCLASS] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QB_Index_QBKEY] PRIMARY KEY CLUSTERED (
            [QBKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new QBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QBDataReader : IDataReader, IDataRecord
        {
            private List<QB> Items;
            private int CurrentIndex;
            private QB CurrentItem;

            public QBDataReader(List<QB> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 15; } }
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
                    case 0: // QBKEY
                        return CurrentItem.QBKEY;
                    case 1: // NARRATIVE
                        return CurrentItem.NARRATIVE;
                    case 2: // TOTAL
                        return CurrentItem.TOTAL;
                    case 3: // CLASS
                        return CurrentItem.CLASS;
                    case 4: // QUANTITY
                        return CurrentItem.QUANTITY;
                    case 5: // BATCHTYPE
                        return CurrentItem.BATCHTYPE;
                    case 6: // TRANSTYPE
                        return CurrentItem.TRANSTYPE;
                    case 7: // BATCHDATA
                        return CurrentItem.BATCHDATA;
                    case 8: // BATCHPRINTED
                        return CurrentItem.BATCHPRINTED;
                    case 9: // BANKPRINTED
                        return CurrentItem.BANKPRINTED;
                    case 10: // BATCHTRACE
                        return CurrentItem.BATCHTRACE;
                    case 11: // BATCHCLASS
                        return CurrentItem.BATCHCLASS;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // NARRATIVE
                        return CurrentItem.NARRATIVE == null;
                    case 2: // TOTAL
                        return CurrentItem.TOTAL == null;
                    case 3: // CLASS
                        return CurrentItem.CLASS == null;
                    case 4: // QUANTITY
                        return CurrentItem.QUANTITY == null;
                    case 5: // BATCHTYPE
                        return CurrentItem.BATCHTYPE == null;
                    case 6: // TRANSTYPE
                        return CurrentItem.TRANSTYPE == null;
                    case 7: // BATCHDATA
                        return CurrentItem.BATCHDATA == null;
                    case 8: // BATCHPRINTED
                        return CurrentItem.BATCHPRINTED == null;
                    case 9: // BANKPRINTED
                        return CurrentItem.BANKPRINTED == null;
                    case 10: // BATCHTRACE
                        return CurrentItem.BATCHTRACE == null;
                    case 11: // BATCHCLASS
                        return CurrentItem.BATCHCLASS == null;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // QBKEY
                        return "QBKEY";
                    case 1: // NARRATIVE
                        return "NARRATIVE";
                    case 2: // TOTAL
                        return "TOTAL";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // QUANTITY
                        return "QUANTITY";
                    case 5: // BATCHTYPE
                        return "BATCHTYPE";
                    case 6: // TRANSTYPE
                        return "TRANSTYPE";
                    case 7: // BATCHDATA
                        return "BATCHDATA";
                    case 8: // BATCHPRINTED
                        return "BATCHPRINTED";
                    case 9: // BANKPRINTED
                        return "BANKPRINTED";
                    case 10: // BATCHTRACE
                        return "BATCHTRACE";
                    case 11: // BATCHCLASS
                        return "BATCHCLASS";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "QBKEY":
                        return 0;
                    case "NARRATIVE":
                        return 1;
                    case "TOTAL":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "QUANTITY":
                        return 4;
                    case "BATCHTYPE":
                        return 5;
                    case "TRANSTYPE":
                        return 6;
                    case "BATCHDATA":
                        return 7;
                    case "BATCHPRINTED":
                        return 8;
                    case "BANKPRINTED":
                        return 9;
                    case "BATCHTRACE":
                        return 10;
                    case "BATCHCLASS":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
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
