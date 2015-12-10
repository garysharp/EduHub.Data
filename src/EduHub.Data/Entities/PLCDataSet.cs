using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLCDataSet : DataSetBase<PLC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLC"; } }

        internal PLCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PLCKEY = new Lazy<Dictionary<string, PLC>>(() => this.ToDictionary(i => i.PLCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLC" /> fields for each CSV column header</returns>
        protected override Action<PLC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLCKEY":
                        mapper[i] = (e, v) => e.PLCKEY = v;
                        break;
                    case "LEAVE_DESC":
                        mapper[i] = (e, v) => e.LEAVE_DESC = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PLC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PLC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PLC" /> items to added or update the base <see cref="PLC" /> items</param>
        /// <returns>A merged list of <see cref="PLC" /> items</returns>
        protected override List<PLC> ApplyDeltaItems(List<PLC> Items, List<PLC> DeltaItems)
        {
            Dictionary<string, int> Index_PLCKEY = Items.ToIndexDictionary(i => i.PLCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PLC deltaItem in DeltaItems)
            {
                int index;

                if (Index_PLCKEY.TryGetValue(deltaItem.PLCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PLCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, PLC>> Index_PLCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLC FindByPLCKEY(string PLCKEY)
        {
            return Index_PLCKEY.Value[PLCKEY];
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <param name="Value">Related PLC entity</param>
        /// <returns>True if the related PLC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLCKEY(string PLCKEY, out PLC Value)
        {
            return Index_PLCKEY.Value.TryGetValue(PLCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLC TryFindByPLCKEY(string PLCKEY)
        {
            PLC value;
            if (Index_PLCKEY.Value.TryGetValue(PLCKEY, out value))
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
        /// Returns SQL which checks for the existence of a PLC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PLC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PLC](
        [PLCKEY] varchar(8) NOT NULL,
        [LEAVE_DESC] varchar(30) NULL,
        [CATEGORY] varchar(8) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PLC_Index_PLCKEY] PRIMARY KEY CLUSTERED (
            [PLCKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PLCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PLCDataReader : IDataReader, IDataRecord
        {
            private List<PLC> Items;
            private int CurrentIndex;
            private PLC CurrentItem;

            public PLCDataReader(List<PLC> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 0: // PLCKEY
                        return CurrentItem.PLCKEY;
                    case 1: // LEAVE_DESC
                        return CurrentItem.LEAVE_DESC;
                    case 2: // CATEGORY
                        return CurrentItem.CATEGORY;
                    case 3: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEAVE_DESC
                        return CurrentItem.LEAVE_DESC == null;
                    case 2: // CATEGORY
                        return CurrentItem.CATEGORY == null;
                    case 3: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PLCKEY
                        return "PLCKEY";
                    case 1: // LEAVE_DESC
                        return "LEAVE_DESC";
                    case 2: // CATEGORY
                        return "CATEGORY";
                    case 3: // ACTIVE
                        return "ACTIVE";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PLCKEY":
                        return 0;
                    case "LEAVE_DESC":
                        return 1;
                    case "CATEGORY":
                        return 2;
                    case "ACTIVE":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
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
