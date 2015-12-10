using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Commitments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBANKDataSet : DataSetBase<GLFBANK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLFBANK"; } }

        internal GLFBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLFBANK>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FUND_ID = new Lazy<NullDictionary<short?, GLFBANK>>(() => this.ToNullDictionary(i => i.FUND_ID));
            Index_TID = new Lazy<Dictionary<int, GLFBANK>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFBANK" /> fields for each CSV column header</returns>
        protected override Action<GLFBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "FUND_ID":
                        mapper[i] = (e, v) => e.FUND_ID = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TIME_FRAME":
                        mapper[i] = (e, v) => e.TIME_FRAME = v;
                        break;
                    case "LY_AMOUNT":
                        mapper[i] = (e, v) => e.LY_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_TIME_FRAME":
                        mapper[i] = (e, v) => e.LY_TIME_FRAME = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLFBANK" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLFBANK" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLFBANK" /> items to added or update the base <see cref="GLFBANK" /> items</param>
        /// <returns>A merged list of <see cref="GLFBANK" /> items</returns>
        protected override List<GLFBANK> ApplyDeltaItems(List<GLFBANK> Items, List<GLFBANK> DeltaItems)
        {
            NullDictionary<short?, int> Index_FUND_ID = Items.ToIndexNullDictionary(i => i.FUND_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLFBANK deltaItem in DeltaItems)
            {
                int index;

                if (Index_FUND_ID.TryGetValue(deltaItem.FUND_ID, out index))
                {
                    removeIndexes.Add(index);
                }
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

        private Lazy<Dictionary<string, IReadOnlyList<GLFBANK>>> Index_CODE;
        private Lazy<NullDictionary<short?, GLFBANK>> Index_FUND_ID;
        private Lazy<Dictionary<int, GLFBANK>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <returns>List of related GLFBANK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBANK> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <param name="Value">List of related GLFBANK entities</param>
        /// <returns>True if the list of related GLFBANK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLFBANK> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <returns>List of related GLFBANK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBANK> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLFBANK> value;
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
        /// Find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK FindByFUND_ID(short? FUND_ID)
        {
            return Index_FUND_ID.Value[FUND_ID];
        }

        /// <summary>
        /// Attempt to find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <param name="Value">Related GLFBANK entity</param>
        /// <returns>True if the related GLFBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUND_ID(short? FUND_ID, out GLFBANK Value)
        {
            return Index_FUND_ID.Value.TryGetValue(FUND_ID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK TryFindByFUND_ID(short? FUND_ID)
        {
            GLFBANK value;
            if (Index_FUND_ID.Value.TryGetValue(FUND_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <param name="Value">Related GLFBANK entity</param>
        /// <returns>True if the related GLFBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFBANK Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK TryFindByTID(int TID)
        {
            GLFBANK value;
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
        /// Returns SQL which checks for the existence of a GLFBANK table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLFBANK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLFBANK](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [FUND_ID] smallint NULL,
        [DESCRIPTION] varchar(50) NULL,
        [AMOUNT] money NULL,
        [TIME_FRAME] varchar(1) NULL,
        [LY_AMOUNT] money NULL,
        [LY_TIME_FRAME] varchar(1) NULL,
        [TRBATCH] smallint NULL,
        [TRAMT] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLFBANK_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [GLFBANK_Index_CODE] ON [dbo].[GLFBANK]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFBANK_Index_FUND_ID] ON [dbo].[GLFBANK]
    (
            [FUND_ID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLFBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFBANK data set</returns>
        public override IDataReader GetDataReader()
        {
            return new GLFBANKDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLFBANKDataReader : IDataReader, IDataRecord
        {
            private List<GLFBANK> Items;
            private int CurrentIndex;
            private GLFBANK CurrentItem;

            public GLFBANKDataReader(List<GLFBANK> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 13; } }
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
                    case 2: // FUND_ID
                        return CurrentItem.FUND_ID;
                    case 3: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 4: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 5: // TIME_FRAME
                        return CurrentItem.TIME_FRAME;
                    case 6: // LY_AMOUNT
                        return CurrentItem.LY_AMOUNT;
                    case 7: // LY_TIME_FRAME
                        return CurrentItem.LY_TIME_FRAME;
                    case 8: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 9: // TRAMT
                        return CurrentItem.TRAMT;
                    case 10: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 11: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 12: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FUND_ID
                        return CurrentItem.FUND_ID == null;
                    case 3: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 4: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 5: // TIME_FRAME
                        return CurrentItem.TIME_FRAME == null;
                    case 6: // LY_AMOUNT
                        return CurrentItem.LY_AMOUNT == null;
                    case 7: // LY_TIME_FRAME
                        return CurrentItem.LY_TIME_FRAME == null;
                    case 8: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 9: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 10: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 11: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 12: // LW_USER
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
                    case 2: // FUND_ID
                        return "FUND_ID";
                    case 3: // DESCRIPTION
                        return "DESCRIPTION";
                    case 4: // AMOUNT
                        return "AMOUNT";
                    case 5: // TIME_FRAME
                        return "TIME_FRAME";
                    case 6: // LY_AMOUNT
                        return "LY_AMOUNT";
                    case 7: // LY_TIME_FRAME
                        return "LY_TIME_FRAME";
                    case 8: // TRBATCH
                        return "TRBATCH";
                    case 9: // TRAMT
                        return "TRAMT";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
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
                    case "FUND_ID":
                        return 2;
                    case "DESCRIPTION":
                        return 3;
                    case "AMOUNT":
                        return 4;
                    case "TIME_FRAME":
                        return 5;
                    case "LY_AMOUNT":
                        return 6;
                    case "LY_TIME_FRAME":
                        return 7;
                    case "TRBATCH":
                        return 8;
                    case "TRAMT":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
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
