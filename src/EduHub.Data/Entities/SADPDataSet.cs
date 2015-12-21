using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Prevention Measures Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADPDataSet : EduHubDataSet<SADP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SADP"; } }

        internal SADPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<Dictionary<int, IReadOnlyList<SADP>>>(() => this.ToGroupedDictionary(i => i.ACCIDENTID));
            Index_ACCIDENTID_PREVENTION = new Lazy<Dictionary<Tuple<int, short?>, SADP>>(() => this.ToDictionary(i => Tuple.Create(i.ACCIDENTID, i.PREVENTION)));
            Index_TID = new Lazy<Dictionary<int, SADP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADP" /> fields for each CSV column header</returns>
        protected override Action<SADP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = int.Parse(v);
                        break;
                    case "PREVENTION":
                        mapper[i] = (e, v) => e.PREVENTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_PREV_INFO":
                        mapper[i] = (e, v) => e.OTHER_PREV_INFO = v;
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
        /// Merges <see cref="SADP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SADP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SADP" /> items to added or update the base <see cref="SADP" /> items</param>
        /// <returns>A merged list of <see cref="SADP" /> items</returns>
        protected override List<SADP> ApplyDeltaItems(List<SADP> Items, List<SADP> DeltaItems)
        {
            Dictionary<Tuple<int, short?>, int> Index_ACCIDENTID_PREVENTION = Items.ToIndexDictionary(i => Tuple.Create(i.ACCIDENTID, i.PREVENTION));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SADP deltaItem in DeltaItems)
            {
                int index;

                if (Index_ACCIDENTID_PREVENTION.TryGetValue(Tuple.Create(deltaItem.ACCIDENTID, deltaItem.PREVENTION), out index))
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
                .OrderBy(i => i.ACCIDENTID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SADP>>> Index_ACCIDENTID;
        private Lazy<Dictionary<Tuple<int, short?>, SADP>> Index_ACCIDENTID_PREVENTION;
        private Lazy<Dictionary<int, SADP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <returns>List of related SADP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADP> FindByACCIDENTID(int ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="Value">List of related SADP entities</param>
        /// <returns>True if the list of related SADP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int ACCIDENTID, out IReadOnlyList<SADP> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <returns>List of related SADP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADP> TryFindByACCIDENTID(int ACCIDENTID)
        {
            IReadOnlyList<SADP> value;
            if (Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <returns>Related SADP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP FindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION)
        {
            return Index_ACCIDENTID_PREVENTION.Value[Tuple.Create(ACCIDENTID, PREVENTION)];
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <param name="Value">Related SADP entity</param>
        /// <returns>True if the related SADP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION, out SADP Value)
        {
            return Index_ACCIDENTID_PREVENTION.Value.TryGetValue(Tuple.Create(ACCIDENTID, PREVENTION), out Value);
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <returns>Related SADP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP TryFindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION)
        {
            SADP value;
            if (Index_ACCIDENTID_PREVENTION.Value.TryGetValue(Tuple.Create(ACCIDENTID, PREVENTION), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <returns>Related SADP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <param name="Value">Related SADP entity</param>
        /// <returns>True if the related SADP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SADP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <returns>Related SADP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP TryFindByTID(int TID)
        {
            SADP value;
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
        /// Returns SQL which checks for the existence of a SADP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SADP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SADP](
        [TID] int IDENTITY NOT NULL,
        [ACCIDENTID] int NOT NULL,
        [PREVENTION] smallint NULL,
        [OTHER_PREV_INFO] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SADP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SADP_Index_ACCIDENTID] ON [dbo].[SADP]
    (
            [ACCIDENTID] ASC
    );
    CREATE NONCLUSTERED INDEX [SADP_Index_ACCIDENTID_PREVENTION] ON [dbo].[SADP]
    (
            [ACCIDENTID] ASC,
            [PREVENTION] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SADPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADPDataReader : IDataReader, IDataRecord
        {
            private List<SADP> Items;
            private int CurrentIndex;
            private SADP CurrentItem;

            public SADPDataReader(List<SADP> Items)
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
                    case 1: // ACCIDENTID
                        return CurrentItem.ACCIDENTID;
                    case 2: // PREVENTION
                        return CurrentItem.PREVENTION;
                    case 3: // OTHER_PREV_INFO
                        return CurrentItem.OTHER_PREV_INFO;
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
                    case 2: // PREVENTION
                        return CurrentItem.PREVENTION == null;
                    case 3: // OTHER_PREV_INFO
                        return CurrentItem.OTHER_PREV_INFO == null;
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
                    case 1: // ACCIDENTID
                        return "ACCIDENTID";
                    case 2: // PREVENTION
                        return "PREVENTION";
                    case 3: // OTHER_PREV_INFO
                        return "OTHER_PREV_INFO";
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
                    case "ACCIDENTID":
                        return 1;
                    case "PREVENTION":
                        return 2;
                    case "OTHER_PREV_INFO":
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
