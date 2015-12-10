using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PELDDataSet : DataSetBase<PELD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PELD"; } }

        internal PELDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PELD>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_PEKEY = new Lazy<Dictionary<string, IReadOnlyList<PELD>>>(() => this.ToGroupedDictionary(i => i.PEKEY));
            Index_PEKEY_LEAVE_CODE = new Lazy<Dictionary<Tuple<string, string>, PELD>>(() => this.ToDictionary(i => Tuple.Create(i.PEKEY, i.LEAVE_CODE)));
            Index_PLTKEY = new Lazy<NullDictionary<string, IReadOnlyList<PELD>>>(() => this.ToGroupedNullDictionary(i => i.PLTKEY));
            Index_TID = new Lazy<Dictionary<int, PELD>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PELD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PELD" /> fields for each CSV column header</returns>
        protected override Action<PELD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PELD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
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
                    case "WORKED":
                        mapper[i] = (e, v) => e.WORKED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STANDARD":
                        mapper[i] = (e, v) => e.STANDARD = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="PELD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PELD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PELD" /> items to added or update the base <see cref="PELD" /> items</param>
        /// <returns>A merged list of <see cref="PELD" /> items</returns>
        protected override List<PELD> ApplyDeltaItems(List<PELD> Items, List<PELD> DeltaItems)
        {
            Dictionary<Tuple<string, string>, int> Index_PEKEY_LEAVE_CODE = Items.ToIndexDictionary(i => Tuple.Create(i.PEKEY, i.LEAVE_CODE));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PELD deltaItem in DeltaItems)
            {
                int index;

                if (Index_PEKEY_LEAVE_CODE.TryGetValue(Tuple.Create(deltaItem.PEKEY, deltaItem.LEAVE_CODE), out index))
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
                .OrderBy(i => i.PEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PELD>>> Index_LEAVE_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<PELD>>> Index_PEKEY;
        private Lazy<Dictionary<Tuple<string, string>, PELD>> Index_PEKEY_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PELD>>> Index_PLTKEY;
        private Lazy<Dictionary<int, PELD>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PELD by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>List of related PELD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PELD by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <param name="Value">List of related PELD entities</param>
        /// <returns>True if the list of related PELD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PELD> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>List of related PELD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PELD> value;
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
        /// Find PELD by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <returns>List of related PELD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> FindByPEKEY(string PEKEY)
        {
            return Index_PEKEY.Value[PEKEY];
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="Value">List of related PELD entities</param>
        /// <returns>True if the list of related PELD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY(string PEKEY, out IReadOnlyList<PELD> Value)
        {
            return Index_PEKEY.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <returns>List of related PELD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> TryFindByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELD> value;
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
        /// Find PELD by PEKEY and LEAVE_CODE fields
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>Related PELD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD FindByPEKEY_LEAVE_CODE(string PEKEY, string LEAVE_CODE)
        {
            return Index_PEKEY_LEAVE_CODE.Value[Tuple.Create(PEKEY, LEAVE_CODE)];
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY and LEAVE_CODE fields
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <param name="Value">Related PELD entity</param>
        /// <returns>True if the related PELD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY_LEAVE_CODE(string PEKEY, string LEAVE_CODE, out PELD Value)
        {
            return Index_PEKEY_LEAVE_CODE.Value.TryGetValue(Tuple.Create(PEKEY, LEAVE_CODE), out Value);
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY and LEAVE_CODE fields
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>Related PELD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD TryFindByPEKEY_LEAVE_CODE(string PEKEY, string LEAVE_CODE)
        {
            PELD value;
            if (Index_PEKEY_LEAVE_CODE.Value.TryGetValue(Tuple.Create(PEKEY, LEAVE_CODE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELD by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD</param>
        /// <returns>List of related PELD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PELD by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD</param>
        /// <param name="Value">List of related PELD entities</param>
        /// <returns>True if the list of related PELD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out IReadOnlyList<PELD> Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD</param>
        /// <returns>List of related PELD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> TryFindByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PELD> value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELD</param>
        /// <returns>Related PELD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PELD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELD</param>
        /// <param name="Value">Related PELD entity</param>
        /// <returns>True if the related PELD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PELD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELD</param>
        /// <returns>Related PELD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD TryFindByTID(int TID)
        {
            PELD value;
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
        /// Returns SQL which checks for the existence of a PELD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PELD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PELD](
        [TID] int IDENTITY NOT NULL,
        [PLTKEY] varchar(16) NULL,
        [PEKEY] varchar(10) NOT NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [LEAVE_STARTDATE] datetime NULL,
        [LAST_CALC_DATE] datetime NULL,
        [LAST_ANNIV_DATE] datetime NULL,
        [ANNIVERSARY_DATE] datetime NULL,
        [LEAVE_ENT_HOURS] float NULL,
        [LEAVE_PRORATA_HOURS] float NULL,
        [PERIOD_LENGTH_STEP] smallint NULL,
        [WORKED] float NULL,
        [STANDARD] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PELD_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PELD_Index_LEAVE_CODE] ON [dbo].[PELD]
    (
            [LEAVE_CODE] ASC
    );
    CREATE CLUSTERED INDEX [PELD_Index_PEKEY] ON [dbo].[PELD]
    (
            [PEKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PELD_Index_PEKEY_LEAVE_CODE] ON [dbo].[PELD]
    (
            [PEKEY] ASC,
            [LEAVE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PELD_Index_PLTKEY] ON [dbo].[PELD]
    (
            [PLTKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PELD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PELD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PELDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PELDDataReader : IDataReader, IDataRecord
        {
            private List<PELD> Items;
            private int CurrentIndex;
            private PELD CurrentItem;

            public PELDDataReader(List<PELD> Items)
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
                    case 1: // PLTKEY
                        return CurrentItem.PLTKEY;
                    case 2: // PEKEY
                        return CurrentItem.PEKEY;
                    case 3: // LEAVE_CODE
                        return CurrentItem.LEAVE_CODE;
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
                    case 11: // WORKED
                        return CurrentItem.WORKED;
                    case 12: // STANDARD
                        return CurrentItem.STANDARD;
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
                    case 1: // PLTKEY
                        return CurrentItem.PLTKEY == null;
                    case 3: // LEAVE_CODE
                        return CurrentItem.LEAVE_CODE == null;
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
                    case 11: // WORKED
                        return CurrentItem.WORKED == null;
                    case 12: // STANDARD
                        return CurrentItem.STANDARD == null;
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
                    case 1: // PLTKEY
                        return "PLTKEY";
                    case 2: // PEKEY
                        return "PEKEY";
                    case 3: // LEAVE_CODE
                        return "LEAVE_CODE";
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
                    case 11: // WORKED
                        return "WORKED";
                    case 12: // STANDARD
                        return "STANDARD";
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
                    case "PLTKEY":
                        return 1;
                    case "PEKEY":
                        return 2;
                    case "LEAVE_CODE":
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
                    case "WORKED":
                        return 11;
                    case "STANDARD":
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
