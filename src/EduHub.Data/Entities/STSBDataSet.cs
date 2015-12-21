using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Invoice Allocations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSBDataSet : EduHubDataSet<STSB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STSB"; } }

        internal STSBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAMILY = new Lazy<NullDictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedNullDictionary(i => i.FAMILY));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_SPLIT_ITEM = new Lazy<NullDictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedNullDictionary(i => i.SPLIT_ITEM));
            Index_TID = new Lazy<Dictionary<int, STSB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSB" /> fields for each CSV column header</returns>
        protected override Action<STSB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "PERCENTAGE":
                        mapper[i] = (e, v) => e.PERCENTAGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SPLIT_ITEM":
                        mapper[i] = (e, v) => e.SPLIT_ITEM = v;
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "SPLIT_ITEM_SU":
                        mapper[i] = (e, v) => e.SPLIT_ITEM_SU = v;
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
        /// Merges <see cref="STSB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STSB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STSB" /> items to added or update the base <see cref="STSB" /> items</param>
        /// <returns>A merged list of <see cref="STSB" /> items</returns>
        protected override List<STSB> ApplyDeltaItems(List<STSB> Items, List<STSB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STSB deltaItem in DeltaItems)
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
                .OrderBy(i => i.SKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<STSB>>> Index_FAMILY;
        private Lazy<Dictionary<string, IReadOnlyList<STSB>>> Index_SKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<STSB>>> Index_SPLIT_ITEM;
        private Lazy<Dictionary<int, STSB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<STSB> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<STSB> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STSB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STSB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindBySPLIT_ITEM(string SPLIT_ITEM)
        {
            return Index_SPLIT_ITEM.Value[SPLIT_ITEM];
        }

        /// <summary>
        /// Attempt to find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPLIT_ITEM(string SPLIT_ITEM, out IReadOnlyList<STSB> Value)
        {
            return Index_SPLIT_ITEM.Value.TryGetValue(SPLIT_ITEM, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindBySPLIT_ITEM(string SPLIT_ITEM)
        {
            IReadOnlyList<STSB> value;
            if (Index_SPLIT_ITEM.Value.TryGetValue(SPLIT_ITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <returns>Related STSB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <param name="Value">Related STSB entity</param>
        /// <returns>True if the related STSB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <returns>Related STSB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSB TryFindByTID(int TID)
        {
            STSB value;
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
        /// Returns SQL which checks for the existence of a STSB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STSB](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [FAMILY] varchar(10) NULL,
        [PERCENTAGE] smallint NULL,
        [SPLIT_ITEM] varchar(10) NULL,
        [ITEM_TYPE] varchar(1) NULL,
        [SPLIT_ITEM_SU] varchar(5) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STSB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STSB_Index_FAMILY] ON [dbo].[STSB]
    (
            [FAMILY] ASC
    );
    CREATE CLUSTERED INDEX [STSB_Index_SKEY] ON [dbo].[STSB]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STSB_Index_SPLIT_ITEM] ON [dbo].[STSB]
    (
            [SPLIT_ITEM] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STSBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STSBDataReader : IDataReader, IDataRecord
        {
            private List<STSB> Items;
            private int CurrentIndex;
            private STSB CurrentItem;

            public STSBDataReader(List<STSB> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 10; } }
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
                    case 1: // SKEY
                        return CurrentItem.SKEY;
                    case 2: // FAMILY
                        return CurrentItem.FAMILY;
                    case 3: // PERCENTAGE
                        return CurrentItem.PERCENTAGE;
                    case 4: // SPLIT_ITEM
                        return CurrentItem.SPLIT_ITEM;
                    case 5: // ITEM_TYPE
                        return CurrentItem.ITEM_TYPE;
                    case 6: // SPLIT_ITEM_SU
                        return CurrentItem.SPLIT_ITEM_SU;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 9: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FAMILY
                        return CurrentItem.FAMILY == null;
                    case 3: // PERCENTAGE
                        return CurrentItem.PERCENTAGE == null;
                    case 4: // SPLIT_ITEM
                        return CurrentItem.SPLIT_ITEM == null;
                    case 5: // ITEM_TYPE
                        return CurrentItem.ITEM_TYPE == null;
                    case 6: // SPLIT_ITEM_SU
                        return CurrentItem.SPLIT_ITEM_SU == null;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 9: // LW_USER
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
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // FAMILY
                        return "FAMILY";
                    case 3: // PERCENTAGE
                        return "PERCENTAGE";
                    case 4: // SPLIT_ITEM
                        return "SPLIT_ITEM";
                    case 5: // ITEM_TYPE
                        return "ITEM_TYPE";
                    case 6: // SPLIT_ITEM_SU
                        return "SPLIT_ITEM_SU";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
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
                    case "SKEY":
                        return 1;
                    case "FAMILY":
                        return 2;
                    case "PERCENTAGE":
                        return 3;
                    case "SPLIT_ITEM":
                        return 4;
                    case "ITEM_TYPE":
                        return 5;
                    case "SPLIT_ITEM_SU":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
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
