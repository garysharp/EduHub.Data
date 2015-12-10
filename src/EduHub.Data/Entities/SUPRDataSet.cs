using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Prerequisites Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUPRDataSet : DataSetBase<SUPR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SUPR"; } }

        internal SUPRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PREREQUISITE = new Lazy<NullDictionary<string, IReadOnlyList<SUPR>>>(() => this.ToGroupedNullDictionary(i => i.PREREQUISITE));
            Index_SUPRKEY = new Lazy<Dictionary<string, IReadOnlyList<SUPR>>>(() => this.ToGroupedDictionary(i => i.SUPRKEY));
            Index_TID = new Lazy<Dictionary<int, SUPR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SUPR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SUPR" /> fields for each CSV column header</returns>
        protected override Action<SUPR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SUPR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SUPRKEY":
                        mapper[i] = (e, v) => e.SUPRKEY = v;
                        break;
                    case "PREREQUISITE":
                        mapper[i] = (e, v) => e.PREREQUISITE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
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
        /// Merges <see cref="SUPR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SUPR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SUPR" /> items to added or update the base <see cref="SUPR" /> items</param>
        /// <returns>A merged list of <see cref="SUPR" /> items</returns>
        protected override List<SUPR> ApplyDeltaItems(List<SUPR> Items, List<SUPR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SUPR deltaItem in DeltaItems)
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
                .OrderBy(i => i.SUPRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SUPR>>> Index_PREREQUISITE;
        private Lazy<Dictionary<string, IReadOnlyList<SUPR>>> Index_SUPRKEY;
        private Lazy<Dictionary<int, SUPR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <returns>List of related SUPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> FindByPREREQUISITE(string PREREQUISITE)
        {
            return Index_PREREQUISITE.Value[PREREQUISITE];
        }

        /// <summary>
        /// Attempt to find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <param name="Value">List of related SUPR entities</param>
        /// <returns>True if the list of related SUPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPREREQUISITE(string PREREQUISITE, out IReadOnlyList<SUPR> Value)
        {
            return Index_PREREQUISITE.Value.TryGetValue(PREREQUISITE, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <returns>List of related SUPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> TryFindByPREREQUISITE(string PREREQUISITE)
        {
            IReadOnlyList<SUPR> value;
            if (Index_PREREQUISITE.Value.TryGetValue(PREREQUISITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <returns>List of related SUPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> FindBySUPRKEY(string SUPRKEY)
        {
            return Index_SUPRKEY.Value[SUPRKEY];
        }

        /// <summary>
        /// Attempt to find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <param name="Value">List of related SUPR entities</param>
        /// <returns>True if the list of related SUPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPRKEY(string SUPRKEY, out IReadOnlyList<SUPR> Value)
        {
            return Index_SUPRKEY.Value.TryGetValue(SUPRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <returns>List of related SUPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> TryFindBySUPRKEY(string SUPRKEY)
        {
            IReadOnlyList<SUPR> value;
            if (Index_SUPRKEY.Value.TryGetValue(SUPRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <returns>Related SUPR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUPR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <param name="Value">Related SUPR entity</param>
        /// <returns>True if the related SUPR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SUPR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <returns>Related SUPR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUPR TryFindByTID(int TID)
        {
            SUPR value;
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
        /// Returns SQL which checks for the existence of a SUPR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SUPR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SUPR](
        [TID] int IDENTITY NOT NULL,
        [SUPRKEY] varchar(5) NOT NULL,
        [PREREQUISITE] varchar(5) NULL,
        [RESULT] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SUPR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SUPR_Index_PREREQUISITE] ON [dbo].[SUPR]
    (
            [PREREQUISITE] ASC
    );
    CREATE CLUSTERED INDEX [SUPR_Index_SUPRKEY] ON [dbo].[SUPR]
    (
            [SUPRKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SUPR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SUPR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SUPRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SUPRDataReader : IDataReader, IDataRecord
        {
            private List<SUPR> Items;
            private int CurrentIndex;
            private SUPR CurrentItem;

            public SUPRDataReader(List<SUPR> Items)
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // SUPRKEY
                        return CurrentItem.SUPRKEY;
                    case 2: // PREREQUISITE
                        return CurrentItem.PREREQUISITE;
                    case 3: // RESULT
                        return CurrentItem.RESULT;
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
                    case 2: // PREREQUISITE
                        return CurrentItem.PREREQUISITE == null;
                    case 3: // RESULT
                        return CurrentItem.RESULT == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // SUPRKEY
                        return "SUPRKEY";
                    case 2: // PREREQUISITE
                        return "PREREQUISITE";
                    case 3: // RESULT
                        return "RESULT";
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
                    case "TID":
                        return 0;
                    case "SUPRKEY":
                        return 1;
                    case "PREREQUISITE":
                        return 2;
                    case "RESULT":
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
