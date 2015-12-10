using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCHIDataSet : DataSetBase<KGCHI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGCHI"; } }

        internal KGCHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGCHIKEY = new Lazy<Dictionary<int, KGCHI>>(() => this.ToDictionary(i => i.KGCHIKEY));
            Index_KGCKEY = new Lazy<NullDictionary<string, IReadOnlyList<KGCHI>>>(() => this.ToGroupedNullDictionary(i => i.KGCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGCHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGCHI" /> fields for each CSV column header</returns>
        protected override Action<KGCHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGCHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCHIKEY":
                        mapper[i] = (e, v) => e.KGCHIKEY = int.Parse(v);
                        break;
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KGCHI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGCHI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGCHI" /> items to added or update the base <see cref="KGCHI" /> items</param>
        /// <returns>A merged list of <see cref="KGCHI" /> items</returns>
        protected override List<KGCHI> ApplyDeltaItems(List<KGCHI> Items, List<KGCHI> DeltaItems)
        {
            Dictionary<int, int> Index_KGCHIKEY = Items.ToIndexDictionary(i => i.KGCHIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGCHI deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGCHIKEY.TryGetValue(deltaItem.KGCHIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGCHIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KGCHI>> Index_KGCHIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KGCHI>>> Index_KGCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCHI FindByKGCHIKEY(int KGCHIKEY)
        {
            return Index_KGCHIKEY.Value[KGCHIKEY];
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <param name="Value">Related KGCHI entity</param>
        /// <returns>True if the related KGCHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCHIKEY(int KGCHIKEY, out KGCHI Value)
        {
            return Index_KGCHIKEY.Value.TryGetValue(KGCHIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCHI TryFindByKGCHIKEY(int KGCHIKEY)
        {
            KGCHI value;
            if (Index_KGCHIKEY.Value.TryGetValue(KGCHIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <returns>List of related KGCHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGCHI> FindByKGCKEY(string KGCKEY)
        {
            return Index_KGCKEY.Value[KGCKEY];
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <param name="Value">List of related KGCHI entities</param>
        /// <returns>True if the list of related KGCHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCKEY(string KGCKEY, out IReadOnlyList<KGCHI> Value)
        {
            return Index_KGCKEY.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <returns>List of related KGCHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGCHI> TryFindByKGCKEY(string KGCKEY)
        {
            IReadOnlyList<KGCHI> value;
            if (Index_KGCKEY.Value.TryGetValue(KGCKEY, out value))
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
        /// Returns SQL which checks for the existence of a KGCHI table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGCHI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGCHI](
        [KGCHIKEY] int IDENTITY NOT NULL,
        [KGCKEY] varchar(3) NULL,
        [CREATION_USER] varchar(128) NULL,
        [CREATION_DATE] datetime NULL,
        [CREATION_TIME] smallint NULL,
        [OBSOLETE_USER] varchar(128) NULL,
        [OBSOLETE_DATE] datetime NULL,
        [OBSOLETE_TIME] smallint NULL,
        [CAMPUS] varchar(45) NULL,
        [TEACHER] varchar(35) NULL,
        [TEACHER_B] varchar(35) NULL,
        [ROOM] varchar(30) NULL,
        [CHANGE_MADE] varchar(40) NULL,
        CONSTRAINT [KGCHI_Index_KGCHIKEY] PRIMARY KEY CLUSTERED (
            [KGCHIKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGCHI_Index_KGCKEY] ON [dbo].[KGCHI]
    (
            [KGCKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGCHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGCHI data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGCHIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGCHIDataReader : IDataReader, IDataRecord
        {
            private List<KGCHI> Items;
            private int CurrentIndex;
            private KGCHI CurrentItem;

            public KGCHIDataReader(List<KGCHI> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 13; } }
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
                    case 0: // KGCHIKEY
                        return CurrentItem.KGCHIKEY;
                    case 1: // KGCKEY
                        return CurrentItem.KGCKEY;
                    case 2: // CREATION_USER
                        return CurrentItem.CREATION_USER;
                    case 3: // CREATION_DATE
                        return CurrentItem.CREATION_DATE;
                    case 4: // CREATION_TIME
                        return CurrentItem.CREATION_TIME;
                    case 5: // OBSOLETE_USER
                        return CurrentItem.OBSOLETE_USER;
                    case 6: // OBSOLETE_DATE
                        return CurrentItem.OBSOLETE_DATE;
                    case 7: // OBSOLETE_TIME
                        return CurrentItem.OBSOLETE_TIME;
                    case 8: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 9: // TEACHER
                        return CurrentItem.TEACHER;
                    case 10: // TEACHER_B
                        return CurrentItem.TEACHER_B;
                    case 11: // ROOM
                        return CurrentItem.ROOM;
                    case 12: // CHANGE_MADE
                        return CurrentItem.CHANGE_MADE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // KGCKEY
                        return CurrentItem.KGCKEY == null;
                    case 2: // CREATION_USER
                        return CurrentItem.CREATION_USER == null;
                    case 3: // CREATION_DATE
                        return CurrentItem.CREATION_DATE == null;
                    case 4: // CREATION_TIME
                        return CurrentItem.CREATION_TIME == null;
                    case 5: // OBSOLETE_USER
                        return CurrentItem.OBSOLETE_USER == null;
                    case 6: // OBSOLETE_DATE
                        return CurrentItem.OBSOLETE_DATE == null;
                    case 7: // OBSOLETE_TIME
                        return CurrentItem.OBSOLETE_TIME == null;
                    case 8: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 9: // TEACHER
                        return CurrentItem.TEACHER == null;
                    case 10: // TEACHER_B
                        return CurrentItem.TEACHER_B == null;
                    case 11: // ROOM
                        return CurrentItem.ROOM == null;
                    case 12: // CHANGE_MADE
                        return CurrentItem.CHANGE_MADE == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGCHIKEY
                        return "KGCHIKEY";
                    case 1: // KGCKEY
                        return "KGCKEY";
                    case 2: // CREATION_USER
                        return "CREATION_USER";
                    case 3: // CREATION_DATE
                        return "CREATION_DATE";
                    case 4: // CREATION_TIME
                        return "CREATION_TIME";
                    case 5: // OBSOLETE_USER
                        return "OBSOLETE_USER";
                    case 6: // OBSOLETE_DATE
                        return "OBSOLETE_DATE";
                    case 7: // OBSOLETE_TIME
                        return "OBSOLETE_TIME";
                    case 8: // CAMPUS
                        return "CAMPUS";
                    case 9: // TEACHER
                        return "TEACHER";
                    case 10: // TEACHER_B
                        return "TEACHER_B";
                    case 11: // ROOM
                        return "ROOM";
                    case 12: // CHANGE_MADE
                        return "CHANGE_MADE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGCHIKEY":
                        return 0;
                    case "KGCKEY":
                        return 1;
                    case "CREATION_USER":
                        return 2;
                    case "CREATION_DATE":
                        return 3;
                    case "CREATION_TIME":
                        return 4;
                    case "OBSOLETE_USER":
                        return 5;
                    case "OBSOLETE_DATE":
                        return 6;
                    case "OBSOLETE_TIME":
                        return 7;
                    case "CAMPUS":
                        return 8;
                    case "TEACHER":
                        return 9;
                    case "TEACHER_B":
                        return 10;
                    case "ROOM":
                        return 11;
                    case "CHANGE_MADE":
                        return 12;
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
