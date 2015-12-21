using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SSHGDataSet : EduHubDataSet<SSHG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SSHG"; } }

        internal SSHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.HOMEGROUP));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_SUBJECT = new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedDictionary(i => i.SUBJECT));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHING_HG = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.TEACHING_HG));
            Index_TID = new Lazy<Dictionary<int, SSHG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SSHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SSHG" /> fields for each CSV column header</returns>
        protected override Action<SSHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SSHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "HOMEGROUP":
                        mapper[i] = (e, v) => e.HOMEGROUP = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "VARIATION":
                        mapper[i] = (e, v) => e.VARIATION = v;
                        break;
                    case "TEACHING_HG":
                        mapper[i] = (e, v) => e.TEACHING_HG = v;
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
        /// Merges <see cref="SSHG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SSHG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SSHG" /> items to added or update the base <see cref="SSHG" /> items</param>
        /// <returns>A merged list of <see cref="SSHG" /> items</returns>
        protected override List<SSHG> ApplyDeltaItems(List<SSHG> Items, List<SSHG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SSHG deltaItem in DeltaItems)
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
                .OrderBy(i => i.SUBJECT)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_HOMEGROUP;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SSHG>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_STUDENT;
        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_TEACHING_HG;
        private Lazy<Dictionary<int, SSHG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByHOMEGROUP(string HOMEGROUP)
        {
            return Index_HOMEGROUP.Value[HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOMEGROUP(string HOMEGROUP, out IReadOnlyList<SSHG> Value)
        {
            return Index_HOMEGROUP.Value.TryGetValue(HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByHOMEGROUP(string HOMEGROUP)
        {
            IReadOnlyList<SSHG> value;
            if (Index_HOMEGROUP.Value.TryGetValue(HOMEGROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SSHG> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SSHG> value;
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
        /// Find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<SSHG> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<SSHG> value;
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
        /// Find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<SSHG> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<SSHG> value;
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
        /// Find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<SSHG> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<SSHG> value;
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
        /// Find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByTEACHING_HG(string TEACHING_HG)
        {
            return Index_TEACHING_HG.Value[TEACHING_HG];
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHING_HG(string TEACHING_HG, out IReadOnlyList<SSHG> Value)
        {
            return Index_TEACHING_HG.Value.TryGetValue(TEACHING_HG, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByTEACHING_HG(string TEACHING_HG)
        {
            IReadOnlyList<SSHG> value;
            if (Index_TEACHING_HG.Value.TryGetValue(TEACHING_HG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <returns>Related SSHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SSHG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <param name="Value">Related SSHG entity</param>
        /// <returns>True if the related SSHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SSHG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <returns>Related SSHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SSHG TryFindByTID(int TID)
        {
            SSHG value;
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
        /// Returns SQL which checks for the existence of a SSHG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SSHG](
        [TID] int IDENTITY NOT NULL,
        [HOMEGROUP] varchar(3) NULL,
        [SUBJECT] varchar(10) NOT NULL,
        [TEACHER] varchar(4) NULL,
        [STUDENT] varchar(10) NULL,
        [VARIATION] varchar(3) NULL,
        [TEACHING_HG] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SSHG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_HOMEGROUP] ON [dbo].[SSHG]
    (
            [HOMEGROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_LW_DATE] ON [dbo].[SSHG]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_STUDENT] ON [dbo].[SSHG]
    (
            [STUDENT] ASC
    );
    CREATE CLUSTERED INDEX [SSHG_Index_SUBJECT] ON [dbo].[SSHG]
    (
            [SUBJECT] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_TEACHER] ON [dbo].[SSHG]
    (
            [TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_TEACHING_HG] ON [dbo].[SSHG]
    (
            [TEACHING_HG] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SSHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SSHG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SSHGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SSHGDataReader : IDataReader, IDataRecord
        {
            private List<SSHG> Items;
            private int CurrentIndex;
            private SSHG CurrentItem;

            public SSHGDataReader(List<SSHG> Items)
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
                    case 1: // HOMEGROUP
                        return CurrentItem.HOMEGROUP;
                    case 2: // SUBJECT
                        return CurrentItem.SUBJECT;
                    case 3: // TEACHER
                        return CurrentItem.TEACHER;
                    case 4: // STUDENT
                        return CurrentItem.STUDENT;
                    case 5: // VARIATION
                        return CurrentItem.VARIATION;
                    case 6: // TEACHING_HG
                        return CurrentItem.TEACHING_HG;
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
                    case 1: // HOMEGROUP
                        return CurrentItem.HOMEGROUP == null;
                    case 3: // TEACHER
                        return CurrentItem.TEACHER == null;
                    case 4: // STUDENT
                        return CurrentItem.STUDENT == null;
                    case 5: // VARIATION
                        return CurrentItem.VARIATION == null;
                    case 6: // TEACHING_HG
                        return CurrentItem.TEACHING_HG == null;
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
                    case 1: // HOMEGROUP
                        return "HOMEGROUP";
                    case 2: // SUBJECT
                        return "SUBJECT";
                    case 3: // TEACHER
                        return "TEACHER";
                    case 4: // STUDENT
                        return "STUDENT";
                    case 5: // VARIATION
                        return "VARIATION";
                    case 6: // TEACHING_HG
                        return "TEACHING_HG";
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
                    case "HOMEGROUP":
                        return 1;
                    case "SUBJECT":
                        return 2;
                    case "TEACHER":
                        return 3;
                    case "STUDENT":
                        return 4;
                    case "VARIATION":
                        return 5;
                    case "TEACHING_HG":
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
