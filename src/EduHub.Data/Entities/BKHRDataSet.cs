using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHRDataSet : DataSetBase<BKHR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BKHR"; } }

        internal BKHRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKHRKEY = new Lazy<Dictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedDictionary(i => i.BKHRKEY));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_TID = new Lazy<Dictionary<int, BKHR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BKHR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BKHR" /> fields for each CSV column header</returns>
        protected override Action<BKHR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BKHR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BKHRKEY":
                        mapper[i] = (e, v) => e.BKHRKEY = v;
                        break;
                    case "REF_NUMBER":
                        mapper[i] = (e, v) => e.REF_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ISSUE_DATE":
                        mapper[i] = (e, v) => e.ISSUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DUE_DATE":
                        mapper[i] = (e, v) => e.DUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RETURNED_DATE":
                        mapper[i] = (e, v) => e.RETURNED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONDITION":
                        mapper[i] = (e, v) => e.CONDITION = v;
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
        /// Merges <see cref="BKHR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="BKHR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="BKHR" /> items to added or update the base <see cref="BKHR" /> items</param>
        /// <returns>A merged list of <see cref="BKHR" /> items</returns>
        protected override List<BKHR> ApplyDeltaItems(List<BKHR> Items, List<BKHR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (BKHR deltaItem in DeltaItems)
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
                .OrderBy(i => i.BKHRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<BKHR>>> Index_BKHRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<BKHR>>> Index_STAFF;
        private Lazy<NullDictionary<string, IReadOnlyList<BKHR>>> Index_STUDENT;
        private Lazy<Dictionary<int, BKHR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindByBKHRKEY(string BKHRKEY)
        {
            return Index_BKHRKEY.Value[BKHRKEY];
        }

        /// <summary>
        /// Attempt to find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKHRKEY(string BKHRKEY, out IReadOnlyList<BKHR> Value)
        {
            return Index_BKHRKEY.Value.TryGetValue(BKHRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindByBKHRKEY(string BKHRKEY)
        {
            IReadOnlyList<BKHR> value;
            if (Index_BKHRKEY.Value.TryGetValue(BKHRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<BKHR> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<BKHR> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<BKHR> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<BKHR> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <returns>Related BKHR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKHR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <param name="Value">Related BKHR entity</param>
        /// <returns>True if the related BKHR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BKHR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <returns>Related BKHR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKHR TryFindByTID(int TID)
        {
            BKHR value;
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
        /// Returns SQL which checks for the existence of a BKHR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BKHR](
        [TID] int IDENTITY NOT NULL,
        [BKHRKEY] varchar(13) NOT NULL,
        [REF_NUMBER] smallint NULL,
        [STUDENT] varchar(10) NULL,
        [STAFF] varchar(4) NULL,
        [ISSUE_DATE] datetime NULL,
        [DUE_DATE] datetime NULL,
        [RETURNED_DATE] datetime NULL,
        [CONDITION] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BKHR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [BKHR_Index_BKHRKEY] ON [dbo].[BKHR]
    (
            [BKHRKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [BKHR_Index_STAFF] ON [dbo].[BKHR]
    (
            [STAFF] ASC
    );
    CREATE NONCLUSTERED INDEX [BKHR_Index_STUDENT] ON [dbo].[BKHR]
    (
            [STUDENT] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BKHR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BKHR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new BKHRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BKHRDataReader : IDataReader, IDataRecord
        {
            private List<BKHR> Items;
            private int CurrentIndex;
            private BKHR CurrentItem;

            public BKHRDataReader(List<BKHR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 12; } }
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
                    case 1: // BKHRKEY
                        return CurrentItem.BKHRKEY;
                    case 2: // REF_NUMBER
                        return CurrentItem.REF_NUMBER;
                    case 3: // STUDENT
                        return CurrentItem.STUDENT;
                    case 4: // STAFF
                        return CurrentItem.STAFF;
                    case 5: // ISSUE_DATE
                        return CurrentItem.ISSUE_DATE;
                    case 6: // DUE_DATE
                        return CurrentItem.DUE_DATE;
                    case 7: // RETURNED_DATE
                        return CurrentItem.RETURNED_DATE;
                    case 8: // CONDITION
                        return CurrentItem.CONDITION;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 11: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // REF_NUMBER
                        return CurrentItem.REF_NUMBER == null;
                    case 3: // STUDENT
                        return CurrentItem.STUDENT == null;
                    case 4: // STAFF
                        return CurrentItem.STAFF == null;
                    case 5: // ISSUE_DATE
                        return CurrentItem.ISSUE_DATE == null;
                    case 6: // DUE_DATE
                        return CurrentItem.DUE_DATE == null;
                    case 7: // RETURNED_DATE
                        return CurrentItem.RETURNED_DATE == null;
                    case 8: // CONDITION
                        return CurrentItem.CONDITION == null;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 11: // LW_USER
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
                    case 1: // BKHRKEY
                        return "BKHRKEY";
                    case 2: // REF_NUMBER
                        return "REF_NUMBER";
                    case 3: // STUDENT
                        return "STUDENT";
                    case 4: // STAFF
                        return "STAFF";
                    case 5: // ISSUE_DATE
                        return "ISSUE_DATE";
                    case 6: // DUE_DATE
                        return "DUE_DATE";
                    case 7: // RETURNED_DATE
                        return "RETURNED_DATE";
                    case 8: // CONDITION
                        return "CONDITION";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
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
                    case "BKHRKEY":
                        return 1;
                    case "REF_NUMBER":
                        return 2;
                    case "STUDENT":
                        return 3;
                    case "STAFF":
                        return 4;
                    case "ISSUE_DATE":
                        return 5;
                    case "DUE_DATE":
                        return 6;
                    case "RETURNED_DATE":
                        return 7;
                    case "CONDITION":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
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
