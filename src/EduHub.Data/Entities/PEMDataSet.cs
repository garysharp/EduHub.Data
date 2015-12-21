using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Advice Slip Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEMDataSet : EduHubDataSet<PEM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEM"; } }

        internal PEMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEM>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEM" /> fields for each CSV column header</returns>
        protected override Action<PEM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "START_TRPAYPERD":
                        mapper[i] = (e, v) => e.START_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "END_TRPAYPERD":
                        mapper[i] = (e, v) => e.END_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMP_MESSAGE":
                        mapper[i] = (e, v) => e.EMP_MESSAGE = v;
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
        /// Merges <see cref="PEM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEM" /> items to added or update the base <see cref="PEM" /> items</param>
        /// <returns>A merged list of <see cref="PEM" /> items</returns>
        protected override List<PEM> ApplyDeltaItems(List<PEM> Items, List<PEM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEM deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEM>>> Index_CODE;
        private Lazy<Dictionary<int, PEM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <returns>List of related PEM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEM> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <param name="Value">List of related PEM entities</param>
        /// <returns>True if the list of related PEM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEM> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <returns>List of related PEM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEM> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEM> value;
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
        /// Find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <returns>Related PEM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <param name="Value">Related PEM entity</param>
        /// <returns>True if the related PEM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <returns>Related PEM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEM TryFindByTID(int TID)
        {
            PEM value;
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
        /// Returns SQL which checks for the existence of a PEM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEM](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [START_TRPAYPERD] int NULL,
        [END_TRPAYPERD] int NULL,
        [EMP_MESSAGE] varchar(90) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEM_Index_CODE] ON [dbo].[PEM]
    (
            [CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEMDataReader : IDataReader, IDataRecord
        {
            private List<PEM> Items;
            private int CurrentIndex;
            private PEM CurrentItem;

            public PEMDataReader(List<PEM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 8; } }
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
                    case 2: // START_TRPAYPERD
                        return CurrentItem.START_TRPAYPERD;
                    case 3: // END_TRPAYPERD
                        return CurrentItem.END_TRPAYPERD;
                    case 4: // EMP_MESSAGE
                        return CurrentItem.EMP_MESSAGE;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 7: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // START_TRPAYPERD
                        return CurrentItem.START_TRPAYPERD == null;
                    case 3: // END_TRPAYPERD
                        return CurrentItem.END_TRPAYPERD == null;
                    case 4: // EMP_MESSAGE
                        return CurrentItem.EMP_MESSAGE == null;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 7: // LW_USER
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
                    case 2: // START_TRPAYPERD
                        return "START_TRPAYPERD";
                    case 3: // END_TRPAYPERD
                        return "END_TRPAYPERD";
                    case 4: // EMP_MESSAGE
                        return "EMP_MESSAGE";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
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
                    case "START_TRPAYPERD":
                        return 2;
                    case "END_TRPAYPERD":
                        return 3;
                    case "EMP_MESSAGE":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
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
