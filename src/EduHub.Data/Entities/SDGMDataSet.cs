using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDGMDataSet : EduHubDataSet<SDGM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDGM"; } }

        internal SDGMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PERSON_LINK = new Lazy<NullDictionary<string, IReadOnlyList<SDGM>>>(() => this.ToGroupedNullDictionary(i => i.PERSON_LINK));
            Index_SDGMKEY = new Lazy<Dictionary<string, IReadOnlyList<SDGM>>>(() => this.ToGroupedDictionary(i => i.SDGMKEY));
            Index_TID = new Lazy<Dictionary<int, SDGM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDGM" /> fields for each CSV column header</returns>
        protected override Action<SDGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SDGMKEY":
                        mapper[i] = (e, v) => e.SDGMKEY = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OTHER_COMMENTS":
                        mapper[i] = (e, v) => e.OTHER_COMMENTS = v;
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
        /// Merges <see cref="SDGM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDGM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDGM" /> items to added or update the base <see cref="SDGM" /> items</param>
        /// <returns>A merged list of <see cref="SDGM" /> items</returns>
        protected override List<SDGM> ApplyDeltaItems(List<SDGM> Items, List<SDGM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDGM deltaItem in DeltaItems)
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
                .OrderBy(i => i.SDGMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SDGM>>> Index_PERSON_LINK;
        private Lazy<Dictionary<string, IReadOnlyList<SDGM>>> Index_SDGMKEY;
        private Lazy<Dictionary<int, SDGM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <returns>List of related SDGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> FindByPERSON_LINK(string PERSON_LINK)
        {
            return Index_PERSON_LINK.Value[PERSON_LINK];
        }

        /// <summary>
        /// Attempt to find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <param name="Value">List of related SDGM entities</param>
        /// <returns>True if the list of related SDGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPERSON_LINK(string PERSON_LINK, out IReadOnlyList<SDGM> Value)
        {
            return Index_PERSON_LINK.Value.TryGetValue(PERSON_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <returns>List of related SDGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> TryFindByPERSON_LINK(string PERSON_LINK)
        {
            IReadOnlyList<SDGM> value;
            if (Index_PERSON_LINK.Value.TryGetValue(PERSON_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <returns>List of related SDGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> FindBySDGMKEY(string SDGMKEY)
        {
            return Index_SDGMKEY.Value[SDGMKEY];
        }

        /// <summary>
        /// Attempt to find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <param name="Value">List of related SDGM entities</param>
        /// <returns>True if the list of related SDGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDGMKEY(string SDGMKEY, out IReadOnlyList<SDGM> Value)
        {
            return Index_SDGMKEY.Value.TryGetValue(SDGMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <returns>List of related SDGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> TryFindBySDGMKEY(string SDGMKEY)
        {
            IReadOnlyList<SDGM> value;
            if (Index_SDGMKEY.Value.TryGetValue(SDGMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <returns>Related SDGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDGM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <param name="Value">Related SDGM entity</param>
        /// <returns>True if the related SDGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SDGM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <returns>Related SDGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDGM TryFindByTID(int TID)
        {
            SDGM value;
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
        /// Returns SQL which checks for the existence of a SDGM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDGM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDGM](
        [TID] int IDENTITY NOT NULL,
        [SDGMKEY] varchar(12) NOT NULL,
        [PERSON_LINK] varchar(10) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [OTHER_COMMENTS] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDGM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SDGM_Index_PERSON_LINK] ON [dbo].[SDGM]
    (
            [PERSON_LINK] ASC
    );
    CREATE CLUSTERED INDEX [SDGM_Index_SDGMKEY] ON [dbo].[SDGM]
    (
            [SDGMKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDGM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDGM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SDGMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDGMDataReader : IDataReader, IDataRecord
        {
            private List<SDGM> Items;
            private int CurrentIndex;
            private SDGM CurrentItem;

            public SDGMDataReader(List<SDGM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 9; } }
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
                    case 1: // SDGMKEY
                        return CurrentItem.SDGMKEY;
                    case 2: // PERSON_LINK
                        return CurrentItem.PERSON_LINK;
                    case 3: // START_DATE
                        return CurrentItem.START_DATE;
                    case 4: // END_DATE
                        return CurrentItem.END_DATE;
                    case 5: // OTHER_COMMENTS
                        return CurrentItem.OTHER_COMMENTS;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PERSON_LINK
                        return CurrentItem.PERSON_LINK == null;
                    case 3: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 4: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 5: // OTHER_COMMENTS
                        return CurrentItem.OTHER_COMMENTS == null;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 8: // LW_USER
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
                    case 1: // SDGMKEY
                        return "SDGMKEY";
                    case 2: // PERSON_LINK
                        return "PERSON_LINK";
                    case 3: // START_DATE
                        return "START_DATE";
                    case 4: // END_DATE
                        return "END_DATE";
                    case 5: // OTHER_COMMENTS
                        return "OTHER_COMMENTS";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
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
                    case "SDGMKEY":
                        return 1;
                    case "PERSON_LINK":
                        return 2;
                    case "START_DATE":
                        return 3;
                    case "END_DATE":
                        return 4;
                    case "OTHER_COMMENTS":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
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
