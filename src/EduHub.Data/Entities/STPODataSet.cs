using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Position or Group Memberships Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPODataSet : DataSetBase<STPO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STPO"; } }

        internal STPODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGLINK = new Lazy<NullDictionary<string, IReadOnlyList<STPO>>>(() => this.ToGroupedNullDictionary(i => i.SGLINK));
            Index_STPOKEY = new Lazy<Dictionary<string, IReadOnlyList<STPO>>>(() => this.ToGroupedDictionary(i => i.STPOKEY));
            Index_TID = new Lazy<Dictionary<int, STPO>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPO" /> fields for each CSV column header</returns>
        protected override Action<STPO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STPOKEY":
                        mapper[i] = (e, v) => e.STPOKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERFORMANCE":
                        mapper[i] = (e, v) => e.PERFORMANCE = v;
                        break;
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
                        break;
                    case "PERMISSION":
                        mapper[i] = (e, v) => e.PERMISSION = v;
                        break;
                    case "SCH_PERMISSION":
                        mapper[i] = (e, v) => e.SCH_PERMISSION = v;
                        break;
                    case "FULLY_PAID":
                        mapper[i] = (e, v) => e.FULLY_PAID = v;
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
        /// Merges <see cref="STPO" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STPO" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STPO" /> items to added or update the base <see cref="STPO" /> items</param>
        /// <returns>A merged list of <see cref="STPO" /> items</returns>
        protected override List<STPO> ApplyDeltaItems(List<STPO> Items, List<STPO> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STPO deltaItem in DeltaItems)
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
                .OrderBy(i => i.STPOKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<STPO>>> Index_SGLINK;
        private Lazy<Dictionary<string, IReadOnlyList<STPO>>> Index_STPOKEY;
        private Lazy<Dictionary<int, STPO>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPO by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find STPO</param>
        /// <returns>List of related STPO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> FindBySGLINK(string SGLINK)
        {
            return Index_SGLINK.Value[SGLINK];
        }

        /// <summary>
        /// Attempt to find STPO by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find STPO</param>
        /// <param name="Value">List of related STPO entities</param>
        /// <returns>True if the list of related STPO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGLINK(string SGLINK, out IReadOnlyList<STPO> Value)
        {
            return Index_SGLINK.Value.TryGetValue(SGLINK, out Value);
        }

        /// <summary>
        /// Attempt to find STPO by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find STPO</param>
        /// <returns>List of related STPO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> TryFindBySGLINK(string SGLINK)
        {
            IReadOnlyList<STPO> value;
            if (Index_SGLINK.Value.TryGetValue(SGLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPO by STPOKEY field
        /// </summary>
        /// <param name="STPOKEY">STPOKEY value used to find STPO</param>
        /// <returns>List of related STPO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> FindBySTPOKEY(string STPOKEY)
        {
            return Index_STPOKEY.Value[STPOKEY];
        }

        /// <summary>
        /// Attempt to find STPO by STPOKEY field
        /// </summary>
        /// <param name="STPOKEY">STPOKEY value used to find STPO</param>
        /// <param name="Value">List of related STPO entities</param>
        /// <returns>True if the list of related STPO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPOKEY(string STPOKEY, out IReadOnlyList<STPO> Value)
        {
            return Index_STPOKEY.Value.TryGetValue(STPOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STPO by STPOKEY field
        /// </summary>
        /// <param name="STPOKEY">STPOKEY value used to find STPO</param>
        /// <returns>List of related STPO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> TryFindBySTPOKEY(string STPOKEY)
        {
            IReadOnlyList<STPO> value;
            if (Index_STPOKEY.Value.TryGetValue(STPOKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPO</param>
        /// <returns>Related STPO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPO</param>
        /// <param name="Value">Related STPO entity</param>
        /// <returns>True if the related STPO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPO</param>
        /// <returns>Related STPO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPO TryFindByTID(int TID)
        {
            STPO value;
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
        /// Returns SQL which checks for the existence of a STPO table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STPO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STPO](
        [TID] int IDENTITY NOT NULL,
        [STPOKEY] varchar(10) NOT NULL,
        [SGLINK] varchar(12) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [PERFORMANCE] text NULL,
        [GROUP_ROLE] varchar(30) NULL,
        [OTHER] text NULL,
        [SG_TYPE] varchar(1) NULL,
        [HOUSE_HG] varchar(10) NULL,
        [PERMISSION] varchar(1) NULL,
        [SCH_PERMISSION] varchar(1) NULL,
        [FULLY_PAID] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STPO_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STPO_Index_SGLINK] ON [dbo].[STPO]
    (
            [SGLINK] ASC
    );
    CREATE CLUSTERED INDEX [STPO_Index_STPOKEY] ON [dbo].[STPO]
    (
            [STPOKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STPO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPO data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STPODataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STPODataReader : IDataReader, IDataRecord
        {
            private List<STPO> Items;
            private int CurrentIndex;
            private STPO CurrentItem;

            public STPODataReader(List<STPO> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 16; } }
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
                    case 1: // STPOKEY
                        return CurrentItem.STPOKEY;
                    case 2: // SGLINK
                        return CurrentItem.SGLINK;
                    case 3: // START_DATE
                        return CurrentItem.START_DATE;
                    case 4: // END_DATE
                        return CurrentItem.END_DATE;
                    case 5: // PERFORMANCE
                        return CurrentItem.PERFORMANCE;
                    case 6: // GROUP_ROLE
                        return CurrentItem.GROUP_ROLE;
                    case 7: // OTHER
                        return CurrentItem.OTHER;
                    case 8: // SG_TYPE
                        return CurrentItem.SG_TYPE;
                    case 9: // HOUSE_HG
                        return CurrentItem.HOUSE_HG;
                    case 10: // PERMISSION
                        return CurrentItem.PERMISSION;
                    case 11: // SCH_PERMISSION
                        return CurrentItem.SCH_PERMISSION;
                    case 12: // FULLY_PAID
                        return CurrentItem.FULLY_PAID;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SGLINK
                        return CurrentItem.SGLINK == null;
                    case 3: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 4: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 5: // PERFORMANCE
                        return CurrentItem.PERFORMANCE == null;
                    case 6: // GROUP_ROLE
                        return CurrentItem.GROUP_ROLE == null;
                    case 7: // OTHER
                        return CurrentItem.OTHER == null;
                    case 8: // SG_TYPE
                        return CurrentItem.SG_TYPE == null;
                    case 9: // HOUSE_HG
                        return CurrentItem.HOUSE_HG == null;
                    case 10: // PERMISSION
                        return CurrentItem.PERMISSION == null;
                    case 11: // SCH_PERMISSION
                        return CurrentItem.SCH_PERMISSION == null;
                    case 12: // FULLY_PAID
                        return CurrentItem.FULLY_PAID == null;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 15: // LW_USER
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
                    case 1: // STPOKEY
                        return "STPOKEY";
                    case 2: // SGLINK
                        return "SGLINK";
                    case 3: // START_DATE
                        return "START_DATE";
                    case 4: // END_DATE
                        return "END_DATE";
                    case 5: // PERFORMANCE
                        return "PERFORMANCE";
                    case 6: // GROUP_ROLE
                        return "GROUP_ROLE";
                    case 7: // OTHER
                        return "OTHER";
                    case 8: // SG_TYPE
                        return "SG_TYPE";
                    case 9: // HOUSE_HG
                        return "HOUSE_HG";
                    case 10: // PERMISSION
                        return "PERMISSION";
                    case 11: // SCH_PERMISSION
                        return "SCH_PERMISSION";
                    case 12: // FULLY_PAID
                        return "FULLY_PAID";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
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
                    case "STPOKEY":
                        return 1;
                    case "SGLINK":
                        return 2;
                    case "START_DATE":
                        return 3;
                    case "END_DATE":
                        return 4;
                    case "PERFORMANCE":
                        return 5;
                    case "GROUP_ROLE":
                        return 6;
                    case "OTHER":
                        return 7;
                    case "SG_TYPE":
                        return 8;
                    case "HOUSE_HG":
                        return 9;
                    case "PERMISSION":
                        return 10;
                    case "SCH_PERMISSION":
                        return 11;
                    case "FULLY_PAID":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
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
