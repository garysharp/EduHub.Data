using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUDataSet : DataSetBase<SU>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SU"; } }

        internal SUDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FACULTY = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_PROMOTE = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.PROMOTE));
            Index_SUBJECT_ACADEMIC_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<SU>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT_ACADEMIC_YEAR));
            Index_SUKEY = new Lazy<Dictionary<string, SU>>(() => this.ToDictionary(i => i.SUKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SU" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SU" /> fields for each CSV column header</returns>
        protected override Action<SU, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SU, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUKEY":
                        mapper[i] = (e, v) => e.SUKEY = v;
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "SHORTNAME":
                        mapper[i] = (e, v) => e.SHORTNAME = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "PROMOTE":
                        mapper[i] = (e, v) => e.PROMOTE = v;
                        break;
                    case "OVERVIEW":
                        mapper[i] = (e, v) => e.OVERVIEW = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUBJECT_ACADEMIC_YEAR":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DURATION":
                        mapper[i] = (e, v) => e.DURATION = v;
                        break;
                    case "SUBJECT_TYPE":
                        mapper[i] = (e, v) => e.SUBJECT_TYPE = v;
                        break;
                    case "PRINT_SEQ_NO":
                        mapper[i] = (e, v) => e.PRINT_SEQ_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ELECTIVE":
                        mapper[i] = (e, v) => e.ELECTIVE = v;
                        break;
                    case "VCAA_ID":
                        mapper[i] = (e, v) => e.VCAA_ID = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
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
        /// Merges <see cref="SU" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SU" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SU" /> items to added or update the base <see cref="SU" /> items</param>
        /// <returns>A merged list of <see cref="SU" /> items</returns>
        protected override List<SU> ApplyDeltaItems(List<SU> Items, List<SU> DeltaItems)
        {
            Dictionary<string, int> Index_SUKEY = Items.ToIndexDictionary(i => i.SUKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SU deltaItem in DeltaItems)
            {
                int index;

                if (Index_SUKEY.TryGetValue(deltaItem.SUKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SUKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_FACULTY;
        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_FEE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_PROMOTE;
        private Lazy<NullDictionary<string, IReadOnlyList<SU>>> Index_SUBJECT_ACADEMIC_YEAR;
        private Lazy<Dictionary<string, SU>> Index_SUKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SU by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindByFACULTY(string FACULTY)
        {
            return Index_FACULTY.Value[FACULTY];
        }

        /// <summary>
        /// Attempt to find SU by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY(string FACULTY, out IReadOnlyList<SU> Value)
        {
            return Index_FACULTY.Value.TryGetValue(FACULTY, out Value);
        }

        /// <summary>
        /// Attempt to find SU by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindByFACULTY(string FACULTY)
        {
            IReadOnlyList<SU> value;
            if (Index_FACULTY.Value.TryGetValue(FACULTY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find SU by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<SU> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SU by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<SU> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by PROMOTE field
        /// </summary>
        /// <param name="PROMOTE">PROMOTE value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindByPROMOTE(string PROMOTE)
        {
            return Index_PROMOTE.Value[PROMOTE];
        }

        /// <summary>
        /// Attempt to find SU by PROMOTE field
        /// </summary>
        /// <param name="PROMOTE">PROMOTE value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPROMOTE(string PROMOTE, out IReadOnlyList<SU> Value)
        {
            return Index_PROMOTE.Value.TryGetValue(PROMOTE, out Value);
        }

        /// <summary>
        /// Attempt to find SU by PROMOTE field
        /// </summary>
        /// <param name="PROMOTE">PROMOTE value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindByPROMOTE(string PROMOTE)
        {
            IReadOnlyList<SU> value;
            if (Index_PROMOTE.Value.TryGetValue(PROMOTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SU</param>
        /// <returns>List of related SU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> FindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR)
        {
            return Index_SUBJECT_ACADEMIC_YEAR.Value[SUBJECT_ACADEMIC_YEAR];
        }

        /// <summary>
        /// Attempt to find SU by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SU</param>
        /// <param name="Value">List of related SU entities</param>
        /// <returns>True if the list of related SU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR, out IReadOnlyList<SU> Value)
        {
            return Index_SUBJECT_ACADEMIC_YEAR.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find SU by SUBJECT_ACADEMIC_YEAR field
        /// </summary>
        /// <param name="SUBJECT_ACADEMIC_YEAR">SUBJECT_ACADEMIC_YEAR value used to find SU</param>
        /// <returns>List of related SU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SU> TryFindBySUBJECT_ACADEMIC_YEAR(string SUBJECT_ACADEMIC_YEAR)
        {
            IReadOnlyList<SU> value;
            if (Index_SUBJECT_ACADEMIC_YEAR.Value.TryGetValue(SUBJECT_ACADEMIC_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SU by SUKEY field
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU</param>
        /// <returns>Related SU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SU FindBySUKEY(string SUKEY)
        {
            return Index_SUKEY.Value[SUKEY];
        }

        /// <summary>
        /// Attempt to find SU by SUKEY field
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU</param>
        /// <param name="Value">Related SU entity</param>
        /// <returns>True if the related SU entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUKEY(string SUKEY, out SU Value)
        {
            return Index_SUKEY.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SU by SUKEY field
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU</param>
        /// <returns>Related SU entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SU TryFindBySUKEY(string SUKEY)
        {
            SU value;
            if (Index_SUKEY.Value.TryGetValue(SUKEY, out value))
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
        /// Returns SQL which checks for the existence of a SU table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SU]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SU](
        [SUKEY] varchar(5) NOT NULL,
        [FULLNAME] varchar(30) NULL,
        [SHORTNAME] varchar(10) NULL,
        [FACULTY] varchar(10) NULL,
        [PROMOTE] varchar(5) NULL,
        [OVERVIEW] text NULL,
        [PRIORITY] smallint NULL,
        [SUBJECT_ACADEMIC_YEAR] varchar(4) NULL,
        [SEMESTER] smallint NULL,
        [DURATION] varchar(1) NULL,
        [SUBJECT_TYPE] varchar(1) NULL,
        [PRINT_SEQ_NO] smallint NULL,
        [ELECTIVE] varchar(1) NULL,
        [VCAA_ID] varchar(5) NULL,
        [FEE_CODE] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SU_Index_SUKEY] PRIMARY KEY CLUSTERED (
            [SUKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SU_Index_FACULTY] ON [dbo].[SU]
    (
            [FACULTY] ASC
    );
    CREATE NONCLUSTERED INDEX [SU_Index_FEE_CODE] ON [dbo].[SU]
    (
            [FEE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [SU_Index_PROMOTE] ON [dbo].[SU]
    (
            [PROMOTE] ASC
    );
    CREATE NONCLUSTERED INDEX [SU_Index_SUBJECT_ACADEMIC_YEAR] ON [dbo].[SU]
    (
            [SUBJECT_ACADEMIC_YEAR] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SU data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SU data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SUDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SUDataReader : IDataReader, IDataRecord
        {
            private List<SU> Items;
            private int CurrentIndex;
            private SU CurrentItem;

            public SUDataReader(List<SU> Items)
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
                    case 0: // SUKEY
                        return CurrentItem.SUKEY;
                    case 1: // FULLNAME
                        return CurrentItem.FULLNAME;
                    case 2: // SHORTNAME
                        return CurrentItem.SHORTNAME;
                    case 3: // FACULTY
                        return CurrentItem.FACULTY;
                    case 4: // PROMOTE
                        return CurrentItem.PROMOTE;
                    case 5: // OVERVIEW
                        return CurrentItem.OVERVIEW;
                    case 6: // PRIORITY
                        return CurrentItem.PRIORITY;
                    case 7: // SUBJECT_ACADEMIC_YEAR
                        return CurrentItem.SUBJECT_ACADEMIC_YEAR;
                    case 8: // SEMESTER
                        return CurrentItem.SEMESTER;
                    case 9: // DURATION
                        return CurrentItem.DURATION;
                    case 10: // SUBJECT_TYPE
                        return CurrentItem.SUBJECT_TYPE;
                    case 11: // PRINT_SEQ_NO
                        return CurrentItem.PRINT_SEQ_NO;
                    case 12: // ELECTIVE
                        return CurrentItem.ELECTIVE;
                    case 13: // VCAA_ID
                        return CurrentItem.VCAA_ID;
                    case 14: // FEE_CODE
                        return CurrentItem.FEE_CODE;
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
                    case 1: // FULLNAME
                        return CurrentItem.FULLNAME == null;
                    case 2: // SHORTNAME
                        return CurrentItem.SHORTNAME == null;
                    case 3: // FACULTY
                        return CurrentItem.FACULTY == null;
                    case 4: // PROMOTE
                        return CurrentItem.PROMOTE == null;
                    case 5: // OVERVIEW
                        return CurrentItem.OVERVIEW == null;
                    case 6: // PRIORITY
                        return CurrentItem.PRIORITY == null;
                    case 7: // SUBJECT_ACADEMIC_YEAR
                        return CurrentItem.SUBJECT_ACADEMIC_YEAR == null;
                    case 8: // SEMESTER
                        return CurrentItem.SEMESTER == null;
                    case 9: // DURATION
                        return CurrentItem.DURATION == null;
                    case 10: // SUBJECT_TYPE
                        return CurrentItem.SUBJECT_TYPE == null;
                    case 11: // PRINT_SEQ_NO
                        return CurrentItem.PRINT_SEQ_NO == null;
                    case 12: // ELECTIVE
                        return CurrentItem.ELECTIVE == null;
                    case 13: // VCAA_ID
                        return CurrentItem.VCAA_ID == null;
                    case 14: // FEE_CODE
                        return CurrentItem.FEE_CODE == null;
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
                    case 0: // SUKEY
                        return "SUKEY";
                    case 1: // FULLNAME
                        return "FULLNAME";
                    case 2: // SHORTNAME
                        return "SHORTNAME";
                    case 3: // FACULTY
                        return "FACULTY";
                    case 4: // PROMOTE
                        return "PROMOTE";
                    case 5: // OVERVIEW
                        return "OVERVIEW";
                    case 6: // PRIORITY
                        return "PRIORITY";
                    case 7: // SUBJECT_ACADEMIC_YEAR
                        return "SUBJECT_ACADEMIC_YEAR";
                    case 8: // SEMESTER
                        return "SEMESTER";
                    case 9: // DURATION
                        return "DURATION";
                    case 10: // SUBJECT_TYPE
                        return "SUBJECT_TYPE";
                    case 11: // PRINT_SEQ_NO
                        return "PRINT_SEQ_NO";
                    case 12: // ELECTIVE
                        return "ELECTIVE";
                    case 13: // VCAA_ID
                        return "VCAA_ID";
                    case 14: // FEE_CODE
                        return "FEE_CODE";
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
                    case "SUKEY":
                        return 0;
                    case "FULLNAME":
                        return 1;
                    case "SHORTNAME":
                        return 2;
                    case "FACULTY":
                        return 3;
                    case "PROMOTE":
                        return 4;
                    case "OVERVIEW":
                        return 5;
                    case "PRIORITY":
                        return 6;
                    case "SUBJECT_ACADEMIC_YEAR":
                        return 7;
                    case "SEMESTER":
                        return 8;
                    case "DURATION":
                        return 9;
                    case "SUBJECT_TYPE":
                        return 10;
                    case "PRINT_SEQ_NO":
                        return 11;
                    case "ELECTIVE":
                        return 12;
                    case "VCAA_ID":
                        return 13;
                    case "FEE_CODE":
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
