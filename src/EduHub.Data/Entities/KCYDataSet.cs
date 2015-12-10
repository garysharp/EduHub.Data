using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCYDataSet : DataSetBase<KCY>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCY"; } }

        internal KCYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCYKEY = new Lazy<Dictionary<string, KCY>>(() => this.ToDictionary(i => i.KCYKEY));
            Index_NEXT_YR = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_YR));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHER_B = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER_B));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCY" /> fields for each CSV column header</returns>
        protected override Action<KCY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCYKEY":
                        mapper[i] = (e, v) => e.KCYKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NUM_EQVT":
                        mapper[i] = (e, v) => e.NUM_EQVT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "NEXT_YR":
                        mapper[i] = (e, v) => e.NEXT_YR = v;
                        break;
                    case "FINAL_YR":
                        mapper[i] = (e, v) => e.FINAL_YR = v;
                        break;
                    case "CSF_REQUIRED":
                        mapper[i] = (e, v) => e.CSF_REQUIRED = v;
                        break;
                    case "HALF_DAY_ABS":
                        mapper[i] = (e, v) => e.HALF_DAY_ABS = v;
                        break;
                    case "PERIOD_ABS":
                        mapper[i] = (e, v) => e.PERIOD_ABS = v;
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
        /// Merges <see cref="KCY" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCY" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCY" /> items to added or update the base <see cref="KCY" /> items</param>
        /// <returns>A merged list of <see cref="KCY" /> items</returns>
        protected override List<KCY> ApplyDeltaItems(List<KCY> Items, List<KCY> DeltaItems)
        {
            Dictionary<string, int> Index_KCYKEY = Items.ToIndexDictionary(i => i.KCYKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCY deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCYKEY.TryGetValue(deltaItem.KCYKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCYKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCY>> Index_KCYKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_NEXT_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_TEACHER_B;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCY FindByKCYKEY(string KCYKEY)
        {
            return Index_KCYKEY.Value[KCYKEY];
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <param name="Value">Related KCY entity</param>
        /// <returns>True if the related KCY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCYKEY(string KCYKEY, out KCY Value)
        {
            return Index_KCYKEY.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCY TryFindByKCYKEY(string KCYKEY)
        {
            KCY value;
            if (Index_KCYKEY.Value.TryGetValue(KCYKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByNEXT_YR(string NEXT_YR)
        {
            return Index_NEXT_YR.Value[NEXT_YR];
        }

        /// <summary>
        /// Attempt to find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_YR(string NEXT_YR, out IReadOnlyList<KCY> Value)
        {
            return Index_NEXT_YR.Value.TryGetValue(NEXT_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByNEXT_YR(string NEXT_YR)
        {
            IReadOnlyList<KCY> value;
            if (Index_NEXT_YR.Value.TryGetValue(NEXT_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<KCY> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<KCY> value;
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
        /// Find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByTEACHER_B(string TEACHER_B)
        {
            return Index_TEACHER_B.Value[TEACHER_B];
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER_B(string TEACHER_B, out IReadOnlyList<KCY> Value)
        {
            return Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByTEACHER_B(string TEACHER_B)
        {
            IReadOnlyList<KCY> value;
            if (Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out value))
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
        /// Returns SQL which checks for the existence of a KCY table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCY](
        [KCYKEY] varchar(4) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [NUM_EQVT] smallint NULL,
        [SHORT_DESC] varchar(10) NULL,
        [TEACHER] varchar(4) NULL,
        [TEACHER_B] varchar(4) NULL,
        [NEXT_YR] varchar(4) NULL,
        [FINAL_YR] varchar(1) NULL,
        [CSF_REQUIRED] varchar(1) NULL,
        [HALF_DAY_ABS] varchar(1) NULL,
        [PERIOD_ABS] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCY_Index_KCYKEY] PRIMARY KEY CLUSTERED (
            [KCYKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCY_Index_NEXT_YR] ON [dbo].[KCY]
    (
            [NEXT_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [KCY_Index_TEACHER] ON [dbo].[KCY]
    (
            [TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [KCY_Index_TEACHER_B] ON [dbo].[KCY]
    (
            [TEACHER_B] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCY data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCYDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCYDataReader : IDataReader, IDataRecord
        {
            private List<KCY> Items;
            private int CurrentIndex;
            private KCY CurrentItem;

            public KCYDataReader(List<KCY> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 14; } }
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
                    case 0: // KCYKEY
                        return CurrentItem.KCYKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // NUM_EQVT
                        return CurrentItem.NUM_EQVT;
                    case 3: // SHORT_DESC
                        return CurrentItem.SHORT_DESC;
                    case 4: // TEACHER
                        return CurrentItem.TEACHER;
                    case 5: // TEACHER_B
                        return CurrentItem.TEACHER_B;
                    case 6: // NEXT_YR
                        return CurrentItem.NEXT_YR;
                    case 7: // FINAL_YR
                        return CurrentItem.FINAL_YR;
                    case 8: // CSF_REQUIRED
                        return CurrentItem.CSF_REQUIRED;
                    case 9: // HALF_DAY_ABS
                        return CurrentItem.HALF_DAY_ABS;
                    case 10: // PERIOD_ABS
                        return CurrentItem.PERIOD_ABS;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // NUM_EQVT
                        return CurrentItem.NUM_EQVT == null;
                    case 3: // SHORT_DESC
                        return CurrentItem.SHORT_DESC == null;
                    case 4: // TEACHER
                        return CurrentItem.TEACHER == null;
                    case 5: // TEACHER_B
                        return CurrentItem.TEACHER_B == null;
                    case 6: // NEXT_YR
                        return CurrentItem.NEXT_YR == null;
                    case 7: // FINAL_YR
                        return CurrentItem.FINAL_YR == null;
                    case 8: // CSF_REQUIRED
                        return CurrentItem.CSF_REQUIRED == null;
                    case 9: // HALF_DAY_ABS
                        return CurrentItem.HALF_DAY_ABS == null;
                    case 10: // PERIOD_ABS
                        return CurrentItem.PERIOD_ABS == null;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCYKEY
                        return "KCYKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // NUM_EQVT
                        return "NUM_EQVT";
                    case 3: // SHORT_DESC
                        return "SHORT_DESC";
                    case 4: // TEACHER
                        return "TEACHER";
                    case 5: // TEACHER_B
                        return "TEACHER_B";
                    case 6: // NEXT_YR
                        return "NEXT_YR";
                    case 7: // FINAL_YR
                        return "FINAL_YR";
                    case 8: // CSF_REQUIRED
                        return "CSF_REQUIRED";
                    case 9: // HALF_DAY_ABS
                        return "HALF_DAY_ABS";
                    case 10: // PERIOD_ABS
                        return "PERIOD_ABS";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCYKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "NUM_EQVT":
                        return 2;
                    case "SHORT_DESC":
                        return 3;
                    case "TEACHER":
                        return 4;
                    case "TEACHER_B":
                        return 5;
                    case "NEXT_YR":
                        return 6;
                    case "FINAL_YR":
                        return 7;
                    case "CSF_REQUIRED":
                        return 8;
                    case "HALF_DAY_ABS":
                        return 9;
                    case "PERIOD_ABS":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
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
