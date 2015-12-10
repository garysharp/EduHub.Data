using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Actual Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXASDataSet : DataSetBase<TXAS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TXAS"; } }

        internal TXASDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SCL_LINK = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.SCL_LINK));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TID = new Lazy<Dictionary<int, TXAS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXAS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXAS" /> fields for each CSV column header</returns>
        protected override Action<TXAS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TXAS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "THTQ_TID":
                        mapper[i] = (e, v) => e.THTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SESSION":
                        mapper[i] = (e, v) => e.CLASS_SESSION = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "PERIOD_NO":
                        mapper[i] = (e, v) => e.PERIOD_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_NO":
                        mapper[i] = (e, v) => e.DAY_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SESSION_DATE":
                        mapper[i] = (e, v) => e.SESSION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERIOD_DESC":
                        mapper[i] = (e, v) => e.PERIOD_DESC = v;
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FINISH_TIME":
                        mapper[i] = (e, v) => e.FINISH_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROLL_MARKED":
                        mapper[i] = (e, v) => e.ROLL_MARKED = v;
                        break;
                    case "SCL_LINK":
                        mapper[i] = (e, v) => e.SCL_LINK = v;
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
        /// Merges <see cref="TXAS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TXAS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TXAS" /> items to added or update the base <see cref="TXAS" /> items</param>
        /// <returns>A merged list of <see cref="TXAS" /> items</returns>
        protected override List<TXAS> ApplyDeltaItems(List<TXAS> Items, List<TXAS> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TXAS deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_LOCATION;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TXAS>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_SCL_LINK;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_TEACHER;
        private Lazy<Dictionary<int, TXAS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TXAS> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TXAS> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TXAS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TXAS> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindBySCL_LINK(string SCL_LINK)
        {
            return Index_SCL_LINK.Value[SCL_LINK];
        }

        /// <summary>
        /// Attempt to find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCL_LINK(string SCL_LINK, out IReadOnlyList<TXAS> Value)
        {
            return Index_SCL_LINK.Value.TryGetValue(SCL_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindBySCL_LINK(string SCL_LINK)
        {
            IReadOnlyList<TXAS> value;
            if (Index_SCL_LINK.Value.TryGetValue(SCL_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<TXAS> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<TXAS> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<TXAS> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<TXAS> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXAS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <param name="Value">Related TXAS entity</param>
        /// <returns>True if the related TXAS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TXAS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXAS TryFindByTID(int TID)
        {
            TXAS value;
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
        /// Returns SQL which checks for the existence of a TXAS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TXAS](
        [TID] int IDENTITY NOT NULL,
        [THTQ_TID] int NULL,
        [CLASS_SESSION] varchar(9) NULL,
        [SUBJECT] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TEACHER] varchar(4) NULL,
        [LOCATION] varchar(4) NULL,
        [PERIOD_NO] smallint NULL,
        [DAY_NO] smallint NULL,
        [SESSION_DATE] datetime NULL,
        [PERIOD_DESC] varchar(10) NULL,
        [START_TIME] smallint NULL,
        [FINISH_TIME] smallint NULL,
        [ROLL_MARKED] varchar(1) NULL,
        [SCL_LINK] varchar(17) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TXAS_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_LOCATION] ON [dbo].[TXAS]
    (
            [LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_LW_DATE] ON [dbo].[TXAS]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_SCL_LINK] ON [dbo].[TXAS]
    (
            [SCL_LINK] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_SUBJECT] ON [dbo].[TXAS]
    (
            [SUBJECT] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_TEACHER] ON [dbo].[TXAS]
    (
            [TEACHER] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TXAS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TXAS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TXASDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TXASDataReader : IDataReader, IDataRecord
        {
            private List<TXAS> Items;
            private int CurrentIndex;
            private TXAS CurrentItem;

            public TXASDataReader(List<TXAS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 18; } }
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
                    case 1: // THTQ_TID
                        return CurrentItem.THTQ_TID;
                    case 2: // CLASS_SESSION
                        return CurrentItem.CLASS_SESSION;
                    case 3: // SUBJECT
                        return CurrentItem.SUBJECT;
                    case 4: // CLASS
                        return CurrentItem.CLASS;
                    case 5: // TEACHER
                        return CurrentItem.TEACHER;
                    case 6: // LOCATION
                        return CurrentItem.LOCATION;
                    case 7: // PERIOD_NO
                        return CurrentItem.PERIOD_NO;
                    case 8: // DAY_NO
                        return CurrentItem.DAY_NO;
                    case 9: // SESSION_DATE
                        return CurrentItem.SESSION_DATE;
                    case 10: // PERIOD_DESC
                        return CurrentItem.PERIOD_DESC;
                    case 11: // START_TIME
                        return CurrentItem.START_TIME;
                    case 12: // FINISH_TIME
                        return CurrentItem.FINISH_TIME;
                    case 13: // ROLL_MARKED
                        return CurrentItem.ROLL_MARKED;
                    case 14: // SCL_LINK
                        return CurrentItem.SCL_LINK;
                    case 15: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 16: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 17: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // THTQ_TID
                        return CurrentItem.THTQ_TID == null;
                    case 2: // CLASS_SESSION
                        return CurrentItem.CLASS_SESSION == null;
                    case 3: // SUBJECT
                        return CurrentItem.SUBJECT == null;
                    case 4: // CLASS
                        return CurrentItem.CLASS == null;
                    case 5: // TEACHER
                        return CurrentItem.TEACHER == null;
                    case 6: // LOCATION
                        return CurrentItem.LOCATION == null;
                    case 7: // PERIOD_NO
                        return CurrentItem.PERIOD_NO == null;
                    case 8: // DAY_NO
                        return CurrentItem.DAY_NO == null;
                    case 9: // SESSION_DATE
                        return CurrentItem.SESSION_DATE == null;
                    case 10: // PERIOD_DESC
                        return CurrentItem.PERIOD_DESC == null;
                    case 11: // START_TIME
                        return CurrentItem.START_TIME == null;
                    case 12: // FINISH_TIME
                        return CurrentItem.FINISH_TIME == null;
                    case 13: // ROLL_MARKED
                        return CurrentItem.ROLL_MARKED == null;
                    case 14: // SCL_LINK
                        return CurrentItem.SCL_LINK == null;
                    case 15: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 16: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 17: // LW_USER
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
                    case 1: // THTQ_TID
                        return "THTQ_TID";
                    case 2: // CLASS_SESSION
                        return "CLASS_SESSION";
                    case 3: // SUBJECT
                        return "SUBJECT";
                    case 4: // CLASS
                        return "CLASS";
                    case 5: // TEACHER
                        return "TEACHER";
                    case 6: // LOCATION
                        return "LOCATION";
                    case 7: // PERIOD_NO
                        return "PERIOD_NO";
                    case 8: // DAY_NO
                        return "DAY_NO";
                    case 9: // SESSION_DATE
                        return "SESSION_DATE";
                    case 10: // PERIOD_DESC
                        return "PERIOD_DESC";
                    case 11: // START_TIME
                        return "START_TIME";
                    case 12: // FINISH_TIME
                        return "FINISH_TIME";
                    case 13: // ROLL_MARKED
                        return "ROLL_MARKED";
                    case 14: // SCL_LINK
                        return "SCL_LINK";
                    case 15: // LW_DATE
                        return "LW_DATE";
                    case 16: // LW_TIME
                        return "LW_TIME";
                    case 17: // LW_USER
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
                    case "THTQ_TID":
                        return 1;
                    case "CLASS_SESSION":
                        return 2;
                    case "SUBJECT":
                        return 3;
                    case "CLASS":
                        return 4;
                    case "TEACHER":
                        return 5;
                    case "LOCATION":
                        return 6;
                    case "PERIOD_NO":
                        return 7;
                    case "DAY_NO":
                        return 8;
                    case "SESSION_DATE":
                        return 9;
                    case "PERIOD_DESC":
                        return 10;
                    case "START_TIME":
                        return 11;
                    case "FINISH_TIME":
                        return 12;
                    case "ROLL_MARKED":
                        return 13;
                    case "SCL_LINK":
                        return 14;
                    case "LW_DATE":
                        return 15;
                    case "LW_TIME":
                        return 16;
                    case "LW_USER":
                        return 17;
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
