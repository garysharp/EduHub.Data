using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFQADataSet : DataSetBase<SFQA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFQA"; } }

        internal SFQADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TEACH = new Lazy<Dictionary<string, IReadOnlyList<SFQA>>>(() => this.ToGroupedDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, SFQA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFQA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFQA" /> fields for each CSV column header</returns>
        protected override Action<SFQA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFQA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "QUALIFICATION":
                        mapper[i] = (e, v) => e.QUALIFICATION = v;
                        break;
                    case "YEAR_COMPLETED":
                        mapper[i] = (e, v) => e.YEAR_COMPLETED = v;
                        break;
                    case "INSTITUTION":
                        mapper[i] = (e, v) => e.INSTITUTION = v;
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
        /// Merges <see cref="SFQA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SFQA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SFQA" /> items to added or update the base <see cref="SFQA" /> items</param>
        /// <returns>A merged list of <see cref="SFQA" /> items</returns>
        protected override List<SFQA> ApplyDeltaItems(List<SFQA> Items, List<SFQA> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SFQA deltaItem in DeltaItems)
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
                .OrderBy(i => i.TEACH)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SFQA>>> Index_TEACH;
        private Lazy<Dictionary<int, SFQA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <returns>List of related SFQA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFQA> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <param name="Value">List of related SFQA entities</param>
        /// <returns>True if the list of related SFQA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<SFQA> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <returns>List of related SFQA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFQA> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<SFQA> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <returns>Related SFQA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFQA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <param name="Value">Related SFQA entity</param>
        /// <returns>True if the related SFQA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFQA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <returns>Related SFQA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFQA TryFindByTID(int TID)
        {
            SFQA value;
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
        /// Returns SQL which checks for the existence of a SFQA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SFQA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SFQA](
        [TID] int IDENTITY NOT NULL,
        [TEACH] varchar(4) NOT NULL,
        [QUALIFICATION] varchar(30) NULL,
        [YEAR_COMPLETED] varchar(4) NULL,
        [INSTITUTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SFQA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SFQA_Index_TEACH] ON [dbo].[SFQA]
    (
            [TEACH] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SFQA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFQA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SFQADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SFQADataReader : IDataReader, IDataRecord
        {
            private List<SFQA> Items;
            private int CurrentIndex;
            private SFQA CurrentItem;

            public SFQADataReader(List<SFQA> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 8; } }
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
                    case 1: // TEACH
                        return CurrentItem.TEACH;
                    case 2: // QUALIFICATION
                        return CurrentItem.QUALIFICATION;
                    case 3: // YEAR_COMPLETED
                        return CurrentItem.YEAR_COMPLETED;
                    case 4: // INSTITUTION
                        return CurrentItem.INSTITUTION;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 7: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // QUALIFICATION
                        return CurrentItem.QUALIFICATION == null;
                    case 3: // YEAR_COMPLETED
                        return CurrentItem.YEAR_COMPLETED == null;
                    case 4: // INSTITUTION
                        return CurrentItem.INSTITUTION == null;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 7: // LW_USER
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
                    case 1: // TEACH
                        return "TEACH";
                    case 2: // QUALIFICATION
                        return "QUALIFICATION";
                    case 3: // YEAR_COMPLETED
                        return "YEAR_COMPLETED";
                    case 4: // INSTITUTION
                        return "INSTITUTION";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
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
                    case "TEACH":
                        return 1;
                    case "QUALIFICATION":
                        return 2;
                    case "YEAR_COMPLETED":
                        return 3;
                    case "INSTITUTION":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
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
