using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABTDataSet : DataSetBase<SABT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SABT"; } }

        internal SABTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SABT>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_SABTKEY = new Lazy<Dictionary<string, IReadOnlyList<SABT>>>(() => this.ToGroupedDictionary(i => i.SABTKEY));
            Index_TID = new Lazy<Dictionary<int, SABT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SABT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SABT" /> fields for each CSV column header</returns>
        protected override Action<SABT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SABT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SABTKEY":
                        mapper[i] = (e, v) => e.SABTKEY = v;
                        break;
                    case "LINKKEY":
                        mapper[i] = (e, v) => e.LINKKEY = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="SABT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SABT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SABT" /> items to added or update the base <see cref="SABT" /> items</param>
        /// <returns>A merged list of <see cref="SABT" /> items</returns>
        protected override List<SABT> ApplyDeltaItems(List<SABT> Items, List<SABT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SABT deltaItem in DeltaItems)
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
                .OrderBy(i => i.SABTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SABT>>> Index_FEE_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<SABT>>> Index_SABTKEY;
        private Lazy<Dictionary<int, SABT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <returns>List of related SABT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <param name="Value">List of related SABT entities</param>
        /// <returns>True if the list of related SABT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<SABT> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <returns>List of related SABT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<SABT> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <returns>List of related SABT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> FindBySABTKEY(string SABTKEY)
        {
            return Index_SABTKEY.Value[SABTKEY];
        }

        /// <summary>
        /// Attempt to find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <param name="Value">List of related SABT entities</param>
        /// <returns>True if the list of related SABT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySABTKEY(string SABTKEY, out IReadOnlyList<SABT> Value)
        {
            return Index_SABTKEY.Value.TryGetValue(SABTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <returns>List of related SABT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> TryFindBySABTKEY(string SABTKEY)
        {
            IReadOnlyList<SABT> value;
            if (Index_SABTKEY.Value.TryGetValue(SABTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <returns>Related SABT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SABT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <param name="Value">Related SABT entity</param>
        /// <returns>True if the related SABT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SABT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <returns>Related SABT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SABT TryFindByTID(int TID)
        {
            SABT value;
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
        /// Returns SQL which checks for the existence of a SABT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SABT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SABT](
        [TID] int IDENTITY NOT NULL,
        [SABTKEY] varchar(10) NOT NULL,
        [LINKKEY] varchar(10) NULL,
        [FEE_CODE] varchar(10) NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SABT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SABT_Index_FEE_CODE] ON [dbo].[SABT]
    (
            [FEE_CODE] ASC
    );
    CREATE CLUSTERED INDEX [SABT_Index_SABTKEY] ON [dbo].[SABT]
    (
            [SABTKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SABT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SABT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SABTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SABTDataReader : IDataReader, IDataRecord
        {
            private List<SABT> Items;
            private int CurrentIndex;
            private SABT CurrentItem;

            public SABTDataReader(List<SABT> Items)
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
                    case 1: // SABTKEY
                        return CurrentItem.SABTKEY;
                    case 2: // LINKKEY
                        return CurrentItem.LINKKEY;
                    case 3: // FEE_CODE
                        return CurrentItem.FEE_CODE;
                    case 4: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
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
                    case 2: // LINKKEY
                        return CurrentItem.LINKKEY == null;
                    case 3: // FEE_CODE
                        return CurrentItem.FEE_CODE == null;
                    case 4: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
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
                    case 1: // SABTKEY
                        return "SABTKEY";
                    case 2: // LINKKEY
                        return "LINKKEY";
                    case 3: // FEE_CODE
                        return "FEE_CODE";
                    case 4: // DESCRIPTION
                        return "DESCRIPTION";
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
                    case "SABTKEY":
                        return 1;
                    case "LINKKEY":
                        return 2;
                    case "FEE_CODE":
                        return 3;
                    case "DESCRIPTION":
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
