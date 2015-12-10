using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Meeting Attendance Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGMADataSet : DataSetBase<SGMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGMA"; } }

        internal SGMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGMAKEY = new Lazy<Dictionary<string, IReadOnlyList<SGMA>>>(() => this.ToGroupedDictionary(i => i.SGMAKEY));
            Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = new Lazy<Dictionary<Tuple<string, int?, string, string, string>, SGMA>>(() => this.ToDictionary(i => Tuple.Create(i.SGMAKEY, i.SGM_TID, i.MEMBER_PERSON_TYPE, i.MEMBER_LINK, i.DF_PARTICIPATION)));
            Index_TID = new Lazy<Dictionary<int, SGMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGMA" /> fields for each CSV column header</returns>
        protected override Action<SGMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGMAKEY":
                        mapper[i] = (e, v) => e.SGMAKEY = v;
                        break;
                    case "SGM_TID":
                        mapper[i] = (e, v) => e.SGM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEMBER_PERSON_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_PERSON_TYPE = v;
                        break;
                    case "MEMBER_LINK":
                        mapper[i] = (e, v) => e.MEMBER_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
        /// Merges <see cref="SGMA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGMA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGMA" /> items to added or update the base <see cref="SGMA" /> items</param>
        /// <returns>A merged list of <see cref="SGMA" /> items</returns>
        protected override List<SGMA> ApplyDeltaItems(List<SGMA> Items, List<SGMA> DeltaItems)
        {
            Dictionary<Tuple<string, int?, string, string, string>, int> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = Items.ToIndexDictionary(i => Tuple.Create(i.SGMAKEY, i.SGM_TID, i.MEMBER_PERSON_TYPE, i.MEMBER_LINK, i.DF_PARTICIPATION));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGMA deltaItem in DeltaItems)
            {
                int index;

                if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.TryGetValue(Tuple.Create(deltaItem.SGMAKEY, deltaItem.SGM_TID, deltaItem.MEMBER_PERSON_TYPE, deltaItem.MEMBER_LINK, deltaItem.DF_PARTICIPATION), out index))
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
                .OrderBy(i => i.SGMAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGMA>>> Index_SGMAKEY;
        private Lazy<Dictionary<Tuple<string, int?, string, string, string>, SGMA>> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION;
        private Lazy<Dictionary<int, SGMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <returns>List of related SGMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGMA> FindBySGMAKEY(string SGMAKEY)
        {
            return Index_SGMAKEY.Value[SGMAKEY];
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="Value">List of related SGMA entities</param>
        /// <returns>True if the list of related SGMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMAKEY(string SGMAKEY, out IReadOnlyList<SGMA> Value)
        {
            return Index_SGMAKEY.Value.TryGetValue(SGMAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <returns>List of related SGMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGMA> TryFindBySGMAKEY(string SGMAKEY)
        {
            IReadOnlyList<SGMA> value;
            if (Index_SGMAKEY.Value.TryGetValue(SGMAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <returns>Related SGMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA FindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION)
        {
            return Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value[Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION)];
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <param name="Value">Related SGMA entity</param>
        /// <returns>True if the related SGMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION, out SGMA Value)
        {
            return Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value.TryGetValue(Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION), out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <returns>Related SGMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA TryFindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION)
        {
            SGMA value;
            if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value.TryGetValue(Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <returns>Related SGMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <param name="Value">Related SGMA entity</param>
        /// <returns>True if the related SGMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <returns>Related SGMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA TryFindByTID(int TID)
        {
            SGMA value;
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
        /// Returns SQL which checks for the existence of a SGMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGMA](
        [TID] int IDENTITY NOT NULL,
        [SGMAKEY] varchar(12) NOT NULL,
        [SGM_TID] int NULL,
        [MEMBER_PERSON_TYPE] varchar(2) NULL,
        [MEMBER_LINK] varchar(10) NULL,
        [DF_PARTICIPATION] varchar(1) NULL,
        [ATTENDED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGMA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGMA_Index_SGMAKEY] ON [dbo].[SGMA]
    (
            [SGMAKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SGMA_Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION] ON [dbo].[SGMA]
    (
            [SGMAKEY] ASC,
            [SGM_TID] ASC,
            [MEMBER_PERSON_TYPE] ASC,
            [MEMBER_LINK] ASC,
            [DF_PARTICIPATION] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGMA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGMADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGMADataReader : IDataReader, IDataRecord
        {
            private List<SGMA> Items;
            private int CurrentIndex;
            private SGMA CurrentItem;

            public SGMADataReader(List<SGMA> Items)
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
                    case 1: // SGMAKEY
                        return CurrentItem.SGMAKEY;
                    case 2: // SGM_TID
                        return CurrentItem.SGM_TID;
                    case 3: // MEMBER_PERSON_TYPE
                        return CurrentItem.MEMBER_PERSON_TYPE;
                    case 4: // MEMBER_LINK
                        return CurrentItem.MEMBER_LINK;
                    case 5: // DF_PARTICIPATION
                        return CurrentItem.DF_PARTICIPATION;
                    case 6: // ATTENDED
                        return CurrentItem.ATTENDED;
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
                    case 2: // SGM_TID
                        return CurrentItem.SGM_TID == null;
                    case 3: // MEMBER_PERSON_TYPE
                        return CurrentItem.MEMBER_PERSON_TYPE == null;
                    case 4: // MEMBER_LINK
                        return CurrentItem.MEMBER_LINK == null;
                    case 5: // DF_PARTICIPATION
                        return CurrentItem.DF_PARTICIPATION == null;
                    case 6: // ATTENDED
                        return CurrentItem.ATTENDED == null;
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
                    case 1: // SGMAKEY
                        return "SGMAKEY";
                    case 2: // SGM_TID
                        return "SGM_TID";
                    case 3: // MEMBER_PERSON_TYPE
                        return "MEMBER_PERSON_TYPE";
                    case 4: // MEMBER_LINK
                        return "MEMBER_LINK";
                    case 5: // DF_PARTICIPATION
                        return "DF_PARTICIPATION";
                    case 6: // ATTENDED
                        return "ATTENDED";
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
                    case "SGMAKEY":
                        return 1;
                    case "SGM_TID":
                        return 2;
                    case "MEMBER_PERSON_TYPE":
                        return 3;
                    case "MEMBER_LINK":
                        return 4;
                    case "DF_PARTICIPATION":
                        return 5;
                    case "ATTENDED":
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
