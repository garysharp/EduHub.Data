using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Data Transfer Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST_TFRIODataSet : EduHubDataSet<ST_TFRIO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "ST_TFRIO"; } }

        internal ST_TFRIODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEST_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>>(() => this.ToGroupedDictionary(i => i.DEST_SCHOOL));
            Index_ST_TRANS_ID = new Lazy<NullDictionary<string, ST_TFRIO>>(() => this.ToNullDictionary(i => i.ST_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, ST_TFRIO>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST_TFRIO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST_TFRIO" /> fields for each CSV column header</returns>
        protected override Action<ST_TFRIO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST_TFRIO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "STKEY_NEW":
                        mapper[i] = (e, v) => e.STKEY_NEW = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TFR_PERMISSION":
                        mapper[i] = (e, v) => e.TFR_PERMISSION = v;
                        break;
                    case "SOURCE_SCHOOL":
                        mapper[i] = (e, v) => e.SOURCE_SCHOOL = v;
                        break;
                    case "DEST_SCHOOL":
                        mapper[i] = (e, v) => e.DEST_SCHOOL = v;
                        break;
                    case "RECD_AT_DEST":
                        mapper[i] = (e, v) => e.RECD_AT_DEST = v;
                        break;
                    case "TFR_STATUS":
                        mapper[i] = (e, v) => e.TFR_STATUS = v;
                        break;
                    case "TFR_DATE":
                        mapper[i] = (e, v) => e.TFR_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TFR_COMMENT":
                        mapper[i] = (e, v) => e.TFR_COMMENT = v;
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
        /// Merges <see cref="ST_TFRIO" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="ST_TFRIO" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="ST_TFRIO" /> items to added or update the base <see cref="ST_TFRIO" /> items</param>
        /// <returns>A merged list of <see cref="ST_TFRIO" /> items</returns>
        protected override List<ST_TFRIO> ApplyDeltaItems(List<ST_TFRIO> Items, List<ST_TFRIO> DeltaItems)
        {
            NullDictionary<string, int> Index_ST_TRANS_ID = Items.ToIndexNullDictionary(i => i.ST_TRANS_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (ST_TFRIO deltaItem in DeltaItems)
            {
                int index;

                if (Index_ST_TRANS_ID.TryGetValue(deltaItem.ST_TRANS_ID, out index))
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
                .OrderBy(i => i.DEST_SCHOOL)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>> Index_DEST_SCHOOL;
        private Lazy<NullDictionary<string, ST_TFRIO>> Index_ST_TRANS_ID;
        private Lazy<Dictionary<int, ST_TFRIO>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <returns>List of related ST_TFRIO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFRIO> FindByDEST_SCHOOL(string DEST_SCHOOL)
        {
            return Index_DEST_SCHOOL.Value[DEST_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <param name="Value">List of related ST_TFRIO entities</param>
        /// <returns>True if the list of related ST_TFRIO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEST_SCHOOL(string DEST_SCHOOL, out IReadOnlyList<ST_TFRIO> Value)
        {
            return Index_DEST_SCHOOL.Value.TryGetValue(DEST_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <returns>List of related ST_TFRIO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFRIO> TryFindByDEST_SCHOOL(string DEST_SCHOOL)
        {
            IReadOnlyList<ST_TFRIO> value;
            if (Index_DEST_SCHOOL.Value.TryGetValue(DEST_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO FindByST_TRANS_ID(string ST_TRANS_ID)
        {
            return Index_ST_TRANS_ID.Value[ST_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <param name="Value">Related ST_TFRIO entity</param>
        /// <returns>True if the related ST_TFRIO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_TRANS_ID(string ST_TRANS_ID, out ST_TFRIO Value)
        {
            return Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO TryFindByST_TRANS_ID(string ST_TRANS_ID)
        {
            ST_TFRIO value;
            if (Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <param name="Value">Related ST_TFRIO entity</param>
        /// <returns>True if the related ST_TFRIO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out ST_TFRIO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO TryFindByTID(int TID)
        {
            ST_TFRIO value;
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
        /// Returns SQL which checks for the existence of a ST_TFRIO table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ST_TFRIO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[ST_TFRIO](
        [TID] int IDENTITY NOT NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [STKEY] varchar(10) NULL,
        [STKEY_NEW] varchar(10) NULL,
        [REGISTRATION] smallint NULL,
        [TFR_PERMISSION] varchar(1) NULL,
        [SOURCE_SCHOOL] varchar(8) NULL,
        [DEST_SCHOOL] varchar(8) NOT NULL,
        [RECD_AT_DEST] varchar(1) NULL,
        [TFR_STATUS] varchar(10) NULL,
        [TFR_DATE] datetime NULL,
        [TFR_COMMENT] varchar(250) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [ST_TFRIO_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [ST_TFRIO_Index_DEST_SCHOOL] ON [dbo].[ST_TFRIO]
    (
            [DEST_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_TFRIO_Index_ST_TRANS_ID] ON [dbo].[ST_TFRIO]
    (
            [ST_TRANS_ID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ST_TFRIO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST_TFRIO data set</returns>
        public override IDataReader GetDataReader()
        {
            return new ST_TFRIODataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class ST_TFRIODataReader : IDataReader, IDataRecord
        {
            private List<ST_TFRIO> Items;
            private int CurrentIndex;
            private ST_TFRIO CurrentItem;

            public ST_TFRIODataReader(List<ST_TFRIO> Items)
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
                    case 1: // ST_TRANS_ID
                        return CurrentItem.ST_TRANS_ID;
                    case 2: // STKEY
                        return CurrentItem.STKEY;
                    case 3: // STKEY_NEW
                        return CurrentItem.STKEY_NEW;
                    case 4: // REGISTRATION
                        return CurrentItem.REGISTRATION;
                    case 5: // TFR_PERMISSION
                        return CurrentItem.TFR_PERMISSION;
                    case 6: // SOURCE_SCHOOL
                        return CurrentItem.SOURCE_SCHOOL;
                    case 7: // DEST_SCHOOL
                        return CurrentItem.DEST_SCHOOL;
                    case 8: // RECD_AT_DEST
                        return CurrentItem.RECD_AT_DEST;
                    case 9: // TFR_STATUS
                        return CurrentItem.TFR_STATUS;
                    case 10: // TFR_DATE
                        return CurrentItem.TFR_DATE;
                    case 11: // TFR_COMMENT
                        return CurrentItem.TFR_COMMENT;
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
                    case 1: // ST_TRANS_ID
                        return CurrentItem.ST_TRANS_ID == null;
                    case 2: // STKEY
                        return CurrentItem.STKEY == null;
                    case 3: // STKEY_NEW
                        return CurrentItem.STKEY_NEW == null;
                    case 4: // REGISTRATION
                        return CurrentItem.REGISTRATION == null;
                    case 5: // TFR_PERMISSION
                        return CurrentItem.TFR_PERMISSION == null;
                    case 6: // SOURCE_SCHOOL
                        return CurrentItem.SOURCE_SCHOOL == null;
                    case 8: // RECD_AT_DEST
                        return CurrentItem.RECD_AT_DEST == null;
                    case 9: // TFR_STATUS
                        return CurrentItem.TFR_STATUS == null;
                    case 10: // TFR_DATE
                        return CurrentItem.TFR_DATE == null;
                    case 11: // TFR_COMMENT
                        return CurrentItem.TFR_COMMENT == null;
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
                    case 1: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // STKEY_NEW
                        return "STKEY_NEW";
                    case 4: // REGISTRATION
                        return "REGISTRATION";
                    case 5: // TFR_PERMISSION
                        return "TFR_PERMISSION";
                    case 6: // SOURCE_SCHOOL
                        return "SOURCE_SCHOOL";
                    case 7: // DEST_SCHOOL
                        return "DEST_SCHOOL";
                    case 8: // RECD_AT_DEST
                        return "RECD_AT_DEST";
                    case 9: // TFR_STATUS
                        return "TFR_STATUS";
                    case 10: // TFR_DATE
                        return "TFR_DATE";
                    case 11: // TFR_COMMENT
                        return "TFR_COMMENT";
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
                    case "ST_TRANS_ID":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "STKEY_NEW":
                        return 3;
                    case "REGISTRATION":
                        return 4;
                    case "TFR_PERMISSION":
                        return 5;
                    case "SOURCE_SCHOOL":
                        return 6;
                    case "DEST_SCHOOL":
                        return 7;
                    case "RECD_AT_DEST":
                        return 8;
                    case "TFR_STATUS":
                        return 9;
                    case "TFR_DATE":
                        return 10;
                    case "TFR_COMMENT":
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
