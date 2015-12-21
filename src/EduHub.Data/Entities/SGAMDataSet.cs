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
    public sealed partial class SGAMDataSet : EduHubDataSet<SGAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGAM"; } }

        internal SGAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGAMKEY = new Lazy<Dictionary<string, IReadOnlyList<SGAM>>>(() => this.ToGroupedDictionary(i => i.SGAMKEY));
            Index_TID = new Lazy<Dictionary<int, SGAM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGAM" /> fields for each CSV column header</returns>
        protected override Action<SGAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGAMKEY":
                        mapper[i] = (e, v) => e.SGAMKEY = v;
                        break;
                    case "ADULT_PERSON_TYPE":
                        mapper[i] = (e, v) => e.ADULT_PERSON_TYPE = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "RESPONSIBLE":
                        mapper[i] = (e, v) => e.RESPONSIBLE = v;
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
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
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
        /// Merges <see cref="SGAM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGAM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGAM" /> items to added or update the base <see cref="SGAM" /> items</param>
        /// <returns>A merged list of <see cref="SGAM" /> items</returns>
        protected override List<SGAM> ApplyDeltaItems(List<SGAM> Items, List<SGAM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGAM deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGAMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGAM>>> Index_SGAMKEY;
        private Lazy<Dictionary<int, SGAM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <returns>List of related SGAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGAM> FindBySGAMKEY(string SGAMKEY)
        {
            return Index_SGAMKEY.Value[SGAMKEY];
        }

        /// <summary>
        /// Attempt to find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <param name="Value">List of related SGAM entities</param>
        /// <returns>True if the list of related SGAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGAMKEY(string SGAMKEY, out IReadOnlyList<SGAM> Value)
        {
            return Index_SGAMKEY.Value.TryGetValue(SGAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <returns>List of related SGAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGAM> TryFindBySGAMKEY(string SGAMKEY)
        {
            IReadOnlyList<SGAM> value;
            if (Index_SGAMKEY.Value.TryGetValue(SGAMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <returns>Related SGAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGAM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <param name="Value">Related SGAM entity</param>
        /// <returns>True if the related SGAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGAM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <returns>Related SGAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGAM TryFindByTID(int TID)
        {
            SGAM value;
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
        /// Returns SQL which checks for the existence of a SGAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGAM](
        [TID] int IDENTITY NOT NULL,
        [SGAMKEY] varchar(12) NOT NULL,
        [ADULT_PERSON_TYPE] varchar(2) NULL,
        [PERSON_LINK] varchar(10) NULL,
        [DF_PARTICIPATION] varchar(1) NULL,
        [RESPONSIBLE] varchar(1) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [OTHER_COMMENTS] text NULL,
        [GROUP_ROLE] varchar(30) NULL,
        [SG_TYPE] varchar(1) NULL,
        [HOUSE_HG] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGAM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGAM_Index_SGAMKEY] ON [dbo].[SGAM]
    (
            [SGAMKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGAM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGAMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGAMDataReader : IDataReader, IDataRecord
        {
            private List<SGAM> Items;
            private int CurrentIndex;
            private SGAM CurrentItem;

            public SGAMDataReader(List<SGAM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 15; } }
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
                    case 1: // SGAMKEY
                        return CurrentItem.SGAMKEY;
                    case 2: // ADULT_PERSON_TYPE
                        return CurrentItem.ADULT_PERSON_TYPE;
                    case 3: // PERSON_LINK
                        return CurrentItem.PERSON_LINK;
                    case 4: // DF_PARTICIPATION
                        return CurrentItem.DF_PARTICIPATION;
                    case 5: // RESPONSIBLE
                        return CurrentItem.RESPONSIBLE;
                    case 6: // START_DATE
                        return CurrentItem.START_DATE;
                    case 7: // END_DATE
                        return CurrentItem.END_DATE;
                    case 8: // OTHER_COMMENTS
                        return CurrentItem.OTHER_COMMENTS;
                    case 9: // GROUP_ROLE
                        return CurrentItem.GROUP_ROLE;
                    case 10: // SG_TYPE
                        return CurrentItem.SG_TYPE;
                    case 11: // HOUSE_HG
                        return CurrentItem.HOUSE_HG;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 14: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ADULT_PERSON_TYPE
                        return CurrentItem.ADULT_PERSON_TYPE == null;
                    case 3: // PERSON_LINK
                        return CurrentItem.PERSON_LINK == null;
                    case 4: // DF_PARTICIPATION
                        return CurrentItem.DF_PARTICIPATION == null;
                    case 5: // RESPONSIBLE
                        return CurrentItem.RESPONSIBLE == null;
                    case 6: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 7: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 8: // OTHER_COMMENTS
                        return CurrentItem.OTHER_COMMENTS == null;
                    case 9: // GROUP_ROLE
                        return CurrentItem.GROUP_ROLE == null;
                    case 10: // SG_TYPE
                        return CurrentItem.SG_TYPE == null;
                    case 11: // HOUSE_HG
                        return CurrentItem.HOUSE_HG == null;
                    case 12: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 13: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 14: // LW_USER
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
                    case 1: // SGAMKEY
                        return "SGAMKEY";
                    case 2: // ADULT_PERSON_TYPE
                        return "ADULT_PERSON_TYPE";
                    case 3: // PERSON_LINK
                        return "PERSON_LINK";
                    case 4: // DF_PARTICIPATION
                        return "DF_PARTICIPATION";
                    case 5: // RESPONSIBLE
                        return "RESPONSIBLE";
                    case 6: // START_DATE
                        return "START_DATE";
                    case 7: // END_DATE
                        return "END_DATE";
                    case 8: // OTHER_COMMENTS
                        return "OTHER_COMMENTS";
                    case 9: // GROUP_ROLE
                        return "GROUP_ROLE";
                    case 10: // SG_TYPE
                        return "SG_TYPE";
                    case 11: // HOUSE_HG
                        return "HOUSE_HG";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
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
                    case "SGAMKEY":
                        return 1;
                    case "ADULT_PERSON_TYPE":
                        return 2;
                    case "PERSON_LINK":
                        return 3;
                    case "DF_PARTICIPATION":
                        return 4;
                    case "RESPONSIBLE":
                        return 5;
                    case "START_DATE":
                        return 6;
                    case "END_DATE":
                        return 7;
                    case "OTHER_COMMENTS":
                        return 8;
                    case "GROUP_ROLE":
                        return 9;
                    case "SG_TYPE":
                        return 10;
                    case "HOUSE_HG":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
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
