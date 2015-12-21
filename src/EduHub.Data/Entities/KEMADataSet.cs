using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSEF Receipt details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KEMADataSet : EduHubDataSet<KEMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KEMA"; } }

        internal KEMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KEMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KEMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KEMA" /> fields for each CSV column header</returns>
        protected override Action<KEMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KEMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY_KEY":
                        mapper[i] = (e, v) => e.FAMILY_KEY = v;
                        break;
                    case "STREGISTRATION":
                        mapper[i] = (e, v) => e.STREGISTRATION = v;
                        break;
                    case "EMA_PERIOD":
                        mapper[i] = (e, v) => e.EMA_PERIOD = v;
                        break;
                    case "EMA_TRAMT":
                        mapper[i] = (e, v) => e.EMA_TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
        /// Merges <see cref="KEMA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KEMA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KEMA" /> items to added or update the base <see cref="KEMA" /> items</param>
        /// <returns>A merged list of <see cref="KEMA" /> items</returns>
        protected override List<KEMA> ApplyDeltaItems(List<KEMA> Items, List<KEMA> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KEMA deltaItem in DeltaItems)
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
                .OrderBy(i => i.TID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KEMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KEMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <param name="Value">Related KEMA entity</param>
        /// <returns>True if the related KEMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KEMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KEMA TryFindByTID(int TID)
        {
            KEMA value;
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
        /// Returns SQL which checks for the existence of a KEMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KEMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KEMA](
        [TID] int IDENTITY NOT NULL,
        [FAMILY_KEY] varchar(10) NULL,
        [STREGISTRATION] varchar(15) NULL,
        [EMA_PERIOD] varchar(1) NULL,
        [EMA_TRAMT] money NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KEMA_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KEMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KEMA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KEMADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KEMADataReader : IDataReader, IDataRecord
        {
            private List<KEMA> Items;
            private int CurrentIndex;
            private KEMA CurrentItem;

            public KEMADataReader(List<KEMA> Items)
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
                    case 1: // FAMILY_KEY
                        return CurrentItem.FAMILY_KEY;
                    case 2: // STREGISTRATION
                        return CurrentItem.STREGISTRATION;
                    case 3: // EMA_PERIOD
                        return CurrentItem.EMA_PERIOD;
                    case 4: // EMA_TRAMT
                        return CurrentItem.EMA_TRAMT;
                    case 5: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG;
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
                    case 1: // FAMILY_KEY
                        return CurrentItem.FAMILY_KEY == null;
                    case 2: // STREGISTRATION
                        return CurrentItem.STREGISTRATION == null;
                    case 3: // EMA_PERIOD
                        return CurrentItem.EMA_PERIOD == null;
                    case 4: // EMA_TRAMT
                        return CurrentItem.EMA_TRAMT == null;
                    case 5: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG == null;
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
                    case 1: // FAMILY_KEY
                        return "FAMILY_KEY";
                    case 2: // STREGISTRATION
                        return "STREGISTRATION";
                    case 3: // EMA_PERIOD
                        return "EMA_PERIOD";
                    case 4: // EMA_TRAMT
                        return "EMA_TRAMT";
                    case 5: // DELETE_FLAG
                        return "DELETE_FLAG";
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
                    case "FAMILY_KEY":
                        return 1;
                    case "STREGISTRATION":
                        return 2;
                    case "EMA_PERIOD":
                        return 3;
                    case "EMA_TRAMT":
                        return 4;
                    case "DELETE_FLAG":
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
