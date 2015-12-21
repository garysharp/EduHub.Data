using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCM Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCM_TFRDataSet : EduHubDataSet<KCM_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCM_TFR"; } }

        internal KCM_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCM_TRANS_ID = new Lazy<NullDictionary<string, KCM_TFR>>(() => this.ToNullDictionary(i => i.KCM_TRANS_ID));
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, KCM_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM_TFR" /> fields for each CSV column header</returns>
        protected override Action<KCM_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "KCM_TRANS_ID":
                        mapper[i] = (e, v) => e.KCM_TRANS_ID = v;
                        break;
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
                        break;
                    case "KCMKEY_NEW":
                        mapper[i] = (e, v) => e.KCMKEY_NEW = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="KCM_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCM_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCM_TFR" /> items to added or update the base <see cref="KCM_TFR" /> items</param>
        /// <returns>A merged list of <see cref="KCM_TFR" /> items</returns>
        protected override List<KCM_TFR> ApplyDeltaItems(List<KCM_TFR> Items, List<KCM_TFR> DeltaItems)
        {
            NullDictionary<string, int> Index_KCM_TRANS_ID = Items.ToIndexNullDictionary(i => i.KCM_TRANS_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCM_TFR deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCM_TRANS_ID.TryGetValue(deltaItem.KCM_TRANS_ID, out index))
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
                .OrderBy(i => i.ORIG_SCHOOL)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, KCM_TFR>> Index_KCM_TRANS_ID;
        private Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, KCM_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR FindByKCM_TRANS_ID(string KCM_TRANS_ID)
        {
            return Index_KCM_TRANS_ID.Value[KCM_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <param name="Value">Related KCM_TFR entity</param>
        /// <returns>True if the related KCM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCM_TRANS_ID(string KCM_TRANS_ID, out KCM_TFR Value)
        {
            return Index_KCM_TRANS_ID.Value.TryGetValue(KCM_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR TryFindByKCM_TRANS_ID(string KCM_TRANS_ID)
        {
            KCM_TFR value;
            if (Index_KCM_TRANS_ID.Value.TryGetValue(KCM_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <returns>List of related KCM_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <param name="Value">List of related KCM_TFR entities</param>
        /// <returns>True if the list of related KCM_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<KCM_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <returns>List of related KCM_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<KCM_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <param name="Value">Related KCM_TFR entity</param>
        /// <returns>True if the related KCM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KCM_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR TryFindByTID(int TID)
        {
            KCM_TFR value;
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
        /// Returns SQL which checks for the existence of a KCM_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCM_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [KCM_TRANS_ID] varchar(30) NULL,
        [KCMKEY] varchar(10) NULL,
        [KCMKEY_NEW] varchar(10) NULL,
        [DESCRIPTION] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCM_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCM_TFR_Index_KCM_TRANS_ID] ON [dbo].[KCM_TFR]
    (
            [KCM_TRANS_ID] ASC
    );
    CREATE CLUSTERED INDEX [KCM_TFR_Index_ORIG_SCHOOL] ON [dbo].[KCM_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCM_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCM_TFR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCM_TFRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCM_TFRDataReader : IDataReader, IDataRecord
        {
            private List<KCM_TFR> Items;
            private int CurrentIndex;
            private KCM_TFR CurrentItem;

            public KCM_TFRDataReader(List<KCM_TFR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 1: // ORIG_SCHOOL
                        return CurrentItem.ORIG_SCHOOL;
                    case 2: // KCM_TRANS_ID
                        return CurrentItem.KCM_TRANS_ID;
                    case 3: // KCMKEY
                        return CurrentItem.KCMKEY;
                    case 4: // KCMKEY_NEW
                        return CurrentItem.KCMKEY_NEW;
                    case 5: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 6: // IMP_STATUS
                        return CurrentItem.IMP_STATUS;
                    case 7: // IMP_DATE
                        return CurrentItem.IMP_DATE;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // KCM_TRANS_ID
                        return CurrentItem.KCM_TRANS_ID == null;
                    case 3: // KCMKEY
                        return CurrentItem.KCMKEY == null;
                    case 4: // KCMKEY_NEW
                        return CurrentItem.KCMKEY_NEW == null;
                    case 5: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 6: // IMP_STATUS
                        return CurrentItem.IMP_STATUS == null;
                    case 7: // IMP_DATE
                        return CurrentItem.IMP_DATE == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
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
                    case 1: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 2: // KCM_TRANS_ID
                        return "KCM_TRANS_ID";
                    case 3: // KCMKEY
                        return "KCMKEY";
                    case 4: // KCMKEY_NEW
                        return "KCMKEY_NEW";
                    case 5: // DESCRIPTION
                        return "DESCRIPTION";
                    case 6: // IMP_STATUS
                        return "IMP_STATUS";
                    case 7: // IMP_DATE
                        return "IMP_DATE";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
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
                    case "ORIG_SCHOOL":
                        return 1;
                    case "KCM_TRANS_ID":
                        return 2;
                    case "KCMKEY":
                        return 3;
                    case "KCMKEY_NEW":
                        return 4;
                    case "DESCRIPTION":
                        return 5;
                    case "IMP_STATUS":
                        return 6;
                    case "IMP_DATE":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
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
