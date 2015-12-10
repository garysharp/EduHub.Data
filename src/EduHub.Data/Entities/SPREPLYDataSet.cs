using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPREPLYDataSet : DataSetBase<SPREPLY>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPREPLY"; } }

        internal SPREPLYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPREPLY>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPREPLY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPREPLY" /> fields for each CSV column header</returns>
        protected override Action<SPREPLY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPREPLY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = int.Parse(v);
                        break;
                    case "SPRECIP_TID":
                        mapper[i] = (e, v) => e.SPRECIP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "PHONE_NUMBER":
                        mapper[i] = (e, v) => e.PHONE_NUMBER = v;
                        break;
                    case "RECEIVED_DATE":
                        mapper[i] = (e, v) => e.RECEIVED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SPREPLY" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPREPLY" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPREPLY" /> items to added or update the base <see cref="SPREPLY" /> items</param>
        /// <returns>A merged list of <see cref="SPREPLY" /> items</returns>
        protected override List<SPREPLY> ApplyDeltaItems(List<SPREPLY> Items, List<SPREPLY> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPREPLY deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>> Index_CODE;
        private Lazy<Dictionary<int, SPREPLY>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <returns>List of related SPREPLY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPREPLY> FindByCODE(int CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <param name="Value">List of related SPREPLY entities</param>
        /// <returns>True if the list of related SPREPLY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(int CODE, out IReadOnlyList<SPREPLY> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <returns>List of related SPREPLY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPREPLY> TryFindByCODE(int CODE)
        {
            IReadOnlyList<SPREPLY> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPREPLY FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <param name="Value">Related SPREPLY entity</param>
        /// <returns>True if the related SPREPLY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPREPLY Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPREPLY TryFindByTID(int TID)
        {
            SPREPLY value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns SQL which checks for the existence of a SPREPLY table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPREPLY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPREPLY](
        [TID] int IDENTITY NOT NULL,
        [CODE] int NOT NULL,
        [SPRECIP_TID] int NULL,
        [MESSAGE] varchar(255) NULL,
        [PHONE_NUMBER] varchar(15) NULL,
        [RECEIVED_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPREPLY_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SPREPLY_Index_CODE] ON [dbo].[SPREPLY]
    (
            [CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPREPLY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPREPLY data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SPREPLYDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPREPLYDataReader : IDataReader, IDataRecord
        {
            private List<SPREPLY> Items;
            private int CurrentIndex;
            private SPREPLY CurrentItem;

            public SPREPLYDataReader(List<SPREPLY> Items)
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // SPRECIP_TID
                        return CurrentItem.SPRECIP_TID;
                    case 3: // MESSAGE
                        return CurrentItem.MESSAGE;
                    case 4: // PHONE_NUMBER
                        return CurrentItem.PHONE_NUMBER;
                    case 5: // RECEIVED_DATE
                        return CurrentItem.RECEIVED_DATE;
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
                    case 2: // SPRECIP_TID
                        return CurrentItem.SPRECIP_TID == null;
                    case 3: // MESSAGE
                        return CurrentItem.MESSAGE == null;
                    case 4: // PHONE_NUMBER
                        return CurrentItem.PHONE_NUMBER == null;
                    case 5: // RECEIVED_DATE
                        return CurrentItem.RECEIVED_DATE == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // SPRECIP_TID
                        return "SPRECIP_TID";
                    case 3: // MESSAGE
                        return "MESSAGE";
                    case 4: // PHONE_NUMBER
                        return "PHONE_NUMBER";
                    case 5: // RECEIVED_DATE
                        return "RECEIVED_DATE";
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
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "SPRECIP_TID":
                        return 2;
                    case "MESSAGE":
                        return 3;
                    case "PHONE_NUMBER":
                        return 4;
                    case "RECEIVED_DATE":
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
