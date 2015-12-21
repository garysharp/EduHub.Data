using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Merit Behaviour Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STMBDataSet : EduHubDataSet<STMB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STMB"; } }

        internal STMBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AWARD = new Lazy<NullDictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedNullDictionary(i => i.AWARD));
            Index_B_CODE = new Lazy<NullDictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedNullDictionary(i => i.B_CODE));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STMB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STMB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STMB" /> fields for each CSV column header</returns>
        protected override Action<STMB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STMB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "B_CODE":
                        mapper[i] = (e, v) => e.B_CODE = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECOMMEND_TYPE":
                        mapper[i] = (e, v) => e.RECOMMEND_TYPE = v;
                        break;
                    case "RECOMMEND_KEY":
                        mapper[i] = (e, v) => e.RECOMMEND_KEY = v;
                        break;
                    case "RECOMMEND_DFAB":
                        mapper[i] = (e, v) => e.RECOMMEND_DFAB = v;
                        break;
                    case "RECOMMEND_OTHER":
                        mapper[i] = (e, v) => e.RECOMMEND_OTHER = v;
                        break;
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "STMB_COMMENT":
                        mapper[i] = (e, v) => e.STMB_COMMENT = v;
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
        /// Merges <see cref="STMB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STMB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STMB" /> items to added or update the base <see cref="STMB" /> items</param>
        /// <returns>A merged list of <see cref="STMB" /> items</returns>
        protected override List<STMB> ApplyDeltaItems(List<STMB> Items, List<STMB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STMB deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STMB>>> Index_AWARD;
        private Lazy<NullDictionary<string, IReadOnlyList<STMB>>> Index_B_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<STMB>>> Index_SKEY;
        private Lazy<Dictionary<int, STMB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindByAWARD(string AWARD)
        {
            return Index_AWARD.Value[AWARD];
        }

        /// <summary>
        /// Attempt to find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAWARD(string AWARD, out IReadOnlyList<STMB> Value)
        {
            return Index_AWARD.Value.TryGetValue(AWARD, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindByAWARD(string AWARD)
        {
            IReadOnlyList<STMB> value;
            if (Index_AWARD.Value.TryGetValue(AWARD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindByB_CODE(string B_CODE)
        {
            return Index_B_CODE.Value[B_CODE];
        }

        /// <summary>
        /// Attempt to find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByB_CODE(string B_CODE, out IReadOnlyList<STMB> Value)
        {
            return Index_B_CODE.Value.TryGetValue(B_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindByB_CODE(string B_CODE)
        {
            IReadOnlyList<STMB> value;
            if (Index_B_CODE.Value.TryGetValue(B_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STMB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STMB> value;
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
        /// Find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <returns>Related STMB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <param name="Value">Related STMB entity</param>
        /// <returns>True if the related STMB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STMB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <returns>Related STMB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMB TryFindByTID(int TID)
        {
            STMB value;
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
        /// Returns SQL which checks for the existence of a STMB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STMB](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [B_CODE] varchar(10) NULL,
        [DETAIL] text NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [RECOMMEND_TYPE] varchar(2) NULL,
        [RECOMMEND_KEY] varchar(10) NULL,
        [RECOMMEND_DFAB] varchar(1) NULL,
        [RECOMMEND_OTHER] text NULL,
        [AWARD] varchar(10) NULL,
        [STMB_COMMENT] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STMB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STMB_Index_AWARD] ON [dbo].[STMB]
    (
            [AWARD] ASC
    );
    CREATE NONCLUSTERED INDEX [STMB_Index_B_CODE] ON [dbo].[STMB]
    (
            [B_CODE] ASC
    );
    CREATE CLUSTERED INDEX [STMB_Index_SKEY] ON [dbo].[STMB]
    (
            [SKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STMB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STMB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STMBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STMBDataReader : IDataReader, IDataRecord
        {
            private List<STMB> Items;
            private int CurrentIndex;
            private STMB CurrentItem;

            public STMBDataReader(List<STMB> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 15; } }
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
                    case 2: // B_CODE
                        return CurrentItem.B_CODE;
                    case 3: // DETAIL
                        return CurrentItem.DETAIL;
                    case 4: // START_DATE
                        return CurrentItem.START_DATE;
                    case 5: // END_DATE
                        return CurrentItem.END_DATE;
                    case 6: // RECOMMEND_TYPE
                        return CurrentItem.RECOMMEND_TYPE;
                    case 7: // RECOMMEND_KEY
                        return CurrentItem.RECOMMEND_KEY;
                    case 8: // RECOMMEND_DFAB
                        return CurrentItem.RECOMMEND_DFAB;
                    case 9: // RECOMMEND_OTHER
                        return CurrentItem.RECOMMEND_OTHER;
                    case 10: // AWARD
                        return CurrentItem.AWARD;
                    case 11: // STMB_COMMENT
                        return CurrentItem.STMB_COMMENT;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // B_CODE
                        return CurrentItem.B_CODE == null;
                    case 3: // DETAIL
                        return CurrentItem.DETAIL == null;
                    case 4: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 5: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 6: // RECOMMEND_TYPE
                        return CurrentItem.RECOMMEND_TYPE == null;
                    case 7: // RECOMMEND_KEY
                        return CurrentItem.RECOMMEND_KEY == null;
                    case 8: // RECOMMEND_DFAB
                        return CurrentItem.RECOMMEND_DFAB == null;
                    case 9: // RECOMMEND_OTHER
                        return CurrentItem.RECOMMEND_OTHER == null;
                    case 10: // AWARD
                        return CurrentItem.AWARD == null;
                    case 11: // STMB_COMMENT
                        return CurrentItem.STMB_COMMENT == null;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 14: // LW_USER
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
                    case 2: // B_CODE
                        return "B_CODE";
                    case 3: // DETAIL
                        return "DETAIL";
                    case 4: // START_DATE
                        return "START_DATE";
                    case 5: // END_DATE
                        return "END_DATE";
                    case 6: // RECOMMEND_TYPE
                        return "RECOMMEND_TYPE";
                    case 7: // RECOMMEND_KEY
                        return "RECOMMEND_KEY";
                    case 8: // RECOMMEND_DFAB
                        return "RECOMMEND_DFAB";
                    case 9: // RECOMMEND_OTHER
                        return "RECOMMEND_OTHER";
                    case 10: // AWARD
                        return "AWARD";
                    case 11: // STMB_COMMENT
                        return "STMB_COMMENT";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
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
                    case "B_CODE":
                        return 2;
                    case "DETAIL":
                        return 3;
                    case "START_DATE":
                        return 4;
                    case "END_DATE":
                        return 5;
                    case "RECOMMEND_TYPE":
                        return 6;
                    case "RECOMMEND_KEY":
                        return 7;
                    case "RECOMMEND_DFAB":
                        return 8;
                    case "RECOMMEND_OTHER":
                        return 9;
                    case "AWARD":
                        return 10;
                    case "STMB_COMMENT":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
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
