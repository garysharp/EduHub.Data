using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Error Log Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_ELOGDataSet : EduHubDataSet<SEC_ELOG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_ELOG"; } }

        internal SEC_ELOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ERRORCOUNT = new Lazy<Dictionary<int, SEC_ELOG>>(() => this.ToDictionary(i => i.ERRORCOUNT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_ELOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_ELOG" /> fields for each CSV column header</returns>
        protected override Action<SEC_ELOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_ELOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ERRORCOUNT":
                        mapper[i] = (e, v) => e.ERRORCOUNT = int.Parse(v);
                        break;
                    case "ERRORDESCRIPTION":
                        mapper[i] = (e, v) => e.ERRORDESCRIPTION = v;
                        break;
                    case "ERRORTYPE":
                        mapper[i] = (e, v) => e.ERRORTYPE = v;
                        break;
                    case "ERRORTIME":
                        mapper[i] = (e, v) => e.ERRORTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_ELOG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_ELOG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_ELOG" /> items to added or update the base <see cref="SEC_ELOG" /> items</param>
        /// <returns>A merged list of <see cref="SEC_ELOG" /> items</returns>
        protected override List<SEC_ELOG> ApplyDeltaItems(List<SEC_ELOG> Items, List<SEC_ELOG> DeltaItems)
        {
            Dictionary<int, int> Index_ERRORCOUNT = Items.ToIndexDictionary(i => i.ERRORCOUNT);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_ELOG deltaItem in DeltaItems)
            {
                int index;

                if (Index_ERRORCOUNT.TryGetValue(deltaItem.ERRORCOUNT, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ERRORCOUNT)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_ELOG>> Index_ERRORCOUNT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_ELOG FindByERRORCOUNT(int ERRORCOUNT)
        {
            return Index_ERRORCOUNT.Value[ERRORCOUNT];
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <param name="Value">Related SEC_ELOG entity</param>
        /// <returns>True if the related SEC_ELOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByERRORCOUNT(int ERRORCOUNT, out SEC_ELOG Value)
        {
            return Index_ERRORCOUNT.Value.TryGetValue(ERRORCOUNT, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_ELOG TryFindByERRORCOUNT(int ERRORCOUNT)
        {
            SEC_ELOG value;
            if (Index_ERRORCOUNT.Value.TryGetValue(ERRORCOUNT, out value))
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
        /// Returns SQL which checks for the existence of a SEC_ELOG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_ELOG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_ELOG](
        [ERRORCOUNT] int IDENTITY NOT NULL,
        [ERRORDESCRIPTION] varchar(255) NULL,
        [ERRORTYPE] varchar(50) NULL,
        [ERRORTIME] datetime NULL,
        CONSTRAINT [SEC_ELOG_Index_ERRORCOUNT] PRIMARY KEY CLUSTERED (
            [ERRORCOUNT] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_ELOG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_ELOG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SEC_ELOGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_ELOGDataReader : IDataReader, IDataRecord
        {
            private List<SEC_ELOG> Items;
            private int CurrentIndex;
            private SEC_ELOG CurrentItem;

            public SEC_ELOGDataReader(List<SEC_ELOG> Items)
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
                    case 0: // ERRORCOUNT
                        return CurrentItem.ERRORCOUNT;
                    case 1: // ERRORDESCRIPTION
                        return CurrentItem.ERRORDESCRIPTION;
                    case 2: // ERRORTYPE
                        return CurrentItem.ERRORTYPE;
                    case 3: // ERRORTIME
                        return CurrentItem.ERRORTIME;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ERRORDESCRIPTION
                        return CurrentItem.ERRORDESCRIPTION == null;
                    case 2: // ERRORTYPE
                        return CurrentItem.ERRORTYPE == null;
                    case 3: // ERRORTIME
                        return CurrentItem.ERRORTIME == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ERRORCOUNT
                        return "ERRORCOUNT";
                    case 1: // ERRORDESCRIPTION
                        return "ERRORDESCRIPTION";
                    case 2: // ERRORTYPE
                        return "ERRORTYPE";
                    case 3: // ERRORTIME
                        return "ERRORTIME";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ERRORCOUNT":
                        return 0;
                    case "ERRORDESCRIPTION":
                        return 1;
                    case "ERRORTYPE":
                        return 2;
                    case "ERRORTIME":
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
