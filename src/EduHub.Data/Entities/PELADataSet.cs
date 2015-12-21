using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Audit Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PELADataSet : EduHubDataSet<PELA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PELA"; } }

        internal PELADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PELA>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_PEKEY = new Lazy<Dictionary<string, IReadOnlyList<PELA>>>(() => this.ToGroupedDictionary(i => i.PEKEY));
            Index_TID = new Lazy<Dictionary<int, PELA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PELA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PELA" /> fields for each CSV column header</returns>
        protected override Action<PELA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PELA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_STARTDATE":
                        mapper[i] = (e, v) => e.LEAVE_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_CALC_DATE":
                        mapper[i] = (e, v) => e.LAST_CALC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_ANNIV_DATE":
                        mapper[i] = (e, v) => e.LAST_ANNIV_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNIVERSARY_DATE":
                        mapper[i] = (e, v) => e.ANNIVERSARY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LEAVE_ENT_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_ENT_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_PRORATA_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_PRORATA_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH_STEP":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PENALTY_DAYS":
                        mapper[i] = (e, v) => e.PENALTY_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATE_START":
                        mapper[i] = (e, v) => e.DATE_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DATE_END":
                        mapper[i] = (e, v) => e.DATE_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CHANGE_TYPE":
                        mapper[i] = (e, v) => e.CHANGE_TYPE = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
        /// Merges <see cref="PELA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PELA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PELA" /> items to added or update the base <see cref="PELA" /> items</param>
        /// <returns>A merged list of <see cref="PELA" /> items</returns>
        protected override List<PELA> ApplyDeltaItems(List<PELA> Items, List<PELA> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PELA deltaItem in DeltaItems)
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
                .OrderBy(i => i.PEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PELA>>> Index_LEAVE_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<PELA>>> Index_PEKEY;
        private Lazy<Dictionary<int, PELA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <returns>List of related PELA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <param name="Value">List of related PELA entities</param>
        /// <returns>True if the list of related PELA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PELA> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <returns>List of related PELA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PELA> value;
            if (Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <returns>List of related PELA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> FindByPEKEY(string PEKEY)
        {
            return Index_PEKEY.Value[PEKEY];
        }

        /// <summary>
        /// Attempt to find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <param name="Value">List of related PELA entities</param>
        /// <returns>True if the list of related PELA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY(string PEKEY, out IReadOnlyList<PELA> Value)
        {
            return Index_PEKEY.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <returns>List of related PELA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> TryFindByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELA> value;
            if (Index_PEKEY.Value.TryGetValue(PEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <returns>Related PELA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <param name="Value">Related PELA entity</param>
        /// <returns>True if the related PELA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PELA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <returns>Related PELA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELA TryFindByTID(int TID)
        {
            PELA value;
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
        /// Returns SQL which checks for the existence of a PELA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PELA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PELA](
        [TID] int IDENTITY NOT NULL,
        [PEKEY] varchar(10) NOT NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [TRQTY] float NULL,
        [LEAVE_STARTDATE] datetime NULL,
        [LAST_CALC_DATE] datetime NULL,
        [LAST_ANNIV_DATE] datetime NULL,
        [ANNIVERSARY_DATE] datetime NULL,
        [LEAVE_ENT_HOURS] float NULL,
        [LEAVE_PRORATA_HOURS] float NULL,
        [PERIOD_LENGTH_STEP] smallint NULL,
        [PENALTY_DAYS] smallint NULL,
        [DATE_START] datetime NULL,
        [DATE_END] datetime NULL,
        [CHANGE_TYPE] varchar(8) NULL,
        [COMMENTS] varchar(35) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PELA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PELA_Index_LEAVE_CODE] ON [dbo].[PELA]
    (
            [LEAVE_CODE] ASC
    );
    CREATE CLUSTERED INDEX [PELA_Index_PEKEY] ON [dbo].[PELA]
    (
            [PEKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PELA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PELA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PELADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PELADataReader : IDataReader, IDataRecord
        {
            private List<PELA> Items;
            private int CurrentIndex;
            private PELA CurrentItem;

            public PELADataReader(List<PELA> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 19; } }
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
                    case 1: // PEKEY
                        return CurrentItem.PEKEY;
                    case 2: // LEAVE_CODE
                        return CurrentItem.LEAVE_CODE;
                    case 3: // TRQTY
                        return CurrentItem.TRQTY;
                    case 4: // LEAVE_STARTDATE
                        return CurrentItem.LEAVE_STARTDATE;
                    case 5: // LAST_CALC_DATE
                        return CurrentItem.LAST_CALC_DATE;
                    case 6: // LAST_ANNIV_DATE
                        return CurrentItem.LAST_ANNIV_DATE;
                    case 7: // ANNIVERSARY_DATE
                        return CurrentItem.ANNIVERSARY_DATE;
                    case 8: // LEAVE_ENT_HOURS
                        return CurrentItem.LEAVE_ENT_HOURS;
                    case 9: // LEAVE_PRORATA_HOURS
                        return CurrentItem.LEAVE_PRORATA_HOURS;
                    case 10: // PERIOD_LENGTH_STEP
                        return CurrentItem.PERIOD_LENGTH_STEP;
                    case 11: // PENALTY_DAYS
                        return CurrentItem.PENALTY_DAYS;
                    case 12: // DATE_START
                        return CurrentItem.DATE_START;
                    case 13: // DATE_END
                        return CurrentItem.DATE_END;
                    case 14: // CHANGE_TYPE
                        return CurrentItem.CHANGE_TYPE;
                    case 15: // COMMENTS
                        return CurrentItem.COMMENTS;
                    case 16: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 17: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 18: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // LEAVE_CODE
                        return CurrentItem.LEAVE_CODE == null;
                    case 3: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 4: // LEAVE_STARTDATE
                        return CurrentItem.LEAVE_STARTDATE == null;
                    case 5: // LAST_CALC_DATE
                        return CurrentItem.LAST_CALC_DATE == null;
                    case 6: // LAST_ANNIV_DATE
                        return CurrentItem.LAST_ANNIV_DATE == null;
                    case 7: // ANNIVERSARY_DATE
                        return CurrentItem.ANNIVERSARY_DATE == null;
                    case 8: // LEAVE_ENT_HOURS
                        return CurrentItem.LEAVE_ENT_HOURS == null;
                    case 9: // LEAVE_PRORATA_HOURS
                        return CurrentItem.LEAVE_PRORATA_HOURS == null;
                    case 10: // PERIOD_LENGTH_STEP
                        return CurrentItem.PERIOD_LENGTH_STEP == null;
                    case 11: // PENALTY_DAYS
                        return CurrentItem.PENALTY_DAYS == null;
                    case 12: // DATE_START
                        return CurrentItem.DATE_START == null;
                    case 13: // DATE_END
                        return CurrentItem.DATE_END == null;
                    case 14: // CHANGE_TYPE
                        return CurrentItem.CHANGE_TYPE == null;
                    case 15: // COMMENTS
                        return CurrentItem.COMMENTS == null;
                    case 16: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 17: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 18: // LW_USER
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
                    case 1: // PEKEY
                        return "PEKEY";
                    case 2: // LEAVE_CODE
                        return "LEAVE_CODE";
                    case 3: // TRQTY
                        return "TRQTY";
                    case 4: // LEAVE_STARTDATE
                        return "LEAVE_STARTDATE";
                    case 5: // LAST_CALC_DATE
                        return "LAST_CALC_DATE";
                    case 6: // LAST_ANNIV_DATE
                        return "LAST_ANNIV_DATE";
                    case 7: // ANNIVERSARY_DATE
                        return "ANNIVERSARY_DATE";
                    case 8: // LEAVE_ENT_HOURS
                        return "LEAVE_ENT_HOURS";
                    case 9: // LEAVE_PRORATA_HOURS
                        return "LEAVE_PRORATA_HOURS";
                    case 10: // PERIOD_LENGTH_STEP
                        return "PERIOD_LENGTH_STEP";
                    case 11: // PENALTY_DAYS
                        return "PENALTY_DAYS";
                    case 12: // DATE_START
                        return "DATE_START";
                    case 13: // DATE_END
                        return "DATE_END";
                    case 14: // CHANGE_TYPE
                        return "CHANGE_TYPE";
                    case 15: // COMMENTS
                        return "COMMENTS";
                    case 16: // LW_DATE
                        return "LW_DATE";
                    case 17: // LW_TIME
                        return "LW_TIME";
                    case 18: // LW_USER
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
                    case "PEKEY":
                        return 1;
                    case "LEAVE_CODE":
                        return 2;
                    case "TRQTY":
                        return 3;
                    case "LEAVE_STARTDATE":
                        return 4;
                    case "LAST_CALC_DATE":
                        return 5;
                    case "LAST_ANNIV_DATE":
                        return 6;
                    case "ANNIVERSARY_DATE":
                        return 7;
                    case "LEAVE_ENT_HOURS":
                        return 8;
                    case "LEAVE_PRORATA_HOURS":
                        return 9;
                    case "PERIOD_LENGTH_STEP":
                        return 10;
                    case "PENALTY_DAYS":
                        return 11;
                    case "DATE_START":
                        return 12;
                    case "DATE_END":
                        return 13;
                    case "CHANGE_TYPE":
                        return 14;
                    case "COMMENTS":
                        return 15;
                    case "LW_DATE":
                        return 16;
                    case "LW_TIME":
                        return 17;
                    case "LW_USER":
                        return 18;
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
