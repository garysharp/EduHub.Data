using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCD Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCD_TFRDataSet : EduHubDataSet<KCD_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCD_TFR"; } }

        internal KCD_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCD_TRANS_ID = new Lazy<NullDictionary<string, KCD_TFR>>(() => this.ToNullDictionary(i => i.KCD_TRANS_ID));
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<KCD_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, KCD_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCD_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCD_TFR" /> fields for each CSV column header</returns>
        protected override Action<KCD_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCD_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "KCD_TRANS_ID":
                        mapper[i] = (e, v) => e.KCD_TRANS_ID = v;
                        break;
                    case "KCDKEY":
                        mapper[i] = (e, v) => e.KCDKEY = v;
                        break;
                    case "KCDKEY_NEW":
                        mapper[i] = (e, v) => e.KCDKEY_NEW = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DR_GROUP":
                        mapper[i] = (e, v) => e.DR_GROUP = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "KAP_LINK_NEW":
                        mapper[i] = (e, v) => e.KAP_LINK_NEW = v;
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
        /// Merges <see cref="KCD_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCD_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCD_TFR" /> items to added or update the base <see cref="KCD_TFR" /> items</param>
        /// <returns>A merged list of <see cref="KCD_TFR" /> items</returns>
        protected override List<KCD_TFR> ApplyDeltaItems(List<KCD_TFR> Items, List<KCD_TFR> DeltaItems)
        {
            NullDictionary<string, int> Index_KCD_TRANS_ID = Items.ToIndexNullDictionary(i => i.KCD_TRANS_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCD_TFR deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCD_TRANS_ID.TryGetValue(deltaItem.KCD_TRANS_ID, out index))
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

        private Lazy<NullDictionary<string, KCD_TFR>> Index_KCD_TRANS_ID;
        private Lazy<Dictionary<string, IReadOnlyList<KCD_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, KCD_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCD_TFR by KCD_TRANS_ID field
        /// </summary>
        /// <param name="KCD_TRANS_ID">KCD_TRANS_ID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR FindByKCD_TRANS_ID(string KCD_TRANS_ID)
        {
            return Index_KCD_TRANS_ID.Value[KCD_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find KCD_TFR by KCD_TRANS_ID field
        /// </summary>
        /// <param name="KCD_TRANS_ID">KCD_TRANS_ID value used to find KCD_TFR</param>
        /// <param name="Value">Related KCD_TFR entity</param>
        /// <returns>True if the related KCD_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCD_TRANS_ID(string KCD_TRANS_ID, out KCD_TFR Value)
        {
            return Index_KCD_TRANS_ID.Value.TryGetValue(KCD_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KCD_TFR by KCD_TRANS_ID field
        /// </summary>
        /// <param name="KCD_TRANS_ID">KCD_TRANS_ID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR TryFindByKCD_TRANS_ID(string KCD_TRANS_ID)
        {
            KCD_TFR value;
            if (Index_KCD_TRANS_ID.Value.TryGetValue(KCD_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCD_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCD_TFR</param>
        /// <returns>List of related KCD_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find KCD_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCD_TFR</param>
        /// <param name="Value">List of related KCD_TFR entities</param>
        /// <returns>True if the list of related KCD_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<KCD_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find KCD_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCD_TFR</param>
        /// <returns>List of related KCD_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<KCD_TFR> value;
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
        /// Find KCD_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KCD_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCD_TFR</param>
        /// <param name="Value">Related KCD_TFR entity</param>
        /// <returns>True if the related KCD_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KCD_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KCD_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR TryFindByTID(int TID)
        {
            KCD_TFR value;
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
        /// Returns SQL which checks for the existence of a KCD_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCD_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCD_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [KCD_TRANS_ID] varchar(30) NULL,
        [KCDKEY] varchar(10) NULL,
        [KCDKEY_NEW] varchar(10) NULL,
        [TITLE] varchar(30) NULL,
        [DR_GROUP] varchar(1) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [KAP_LINK] varchar(34) NULL,
        [KAP_LINK_NEW] varchar(34) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCD_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCD_TFR_Index_KCD_TRANS_ID] ON [dbo].[KCD_TFR]
    (
            [KCD_TRANS_ID] ASC
    );
    CREATE CLUSTERED INDEX [KCD_TFR_Index_ORIG_SCHOOL] ON [dbo].[KCD_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCD_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCD_TFR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCD_TFRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCD_TFRDataReader : IDataReader, IDataRecord
        {
            private List<KCD_TFR> Items;
            private int CurrentIndex;
            private KCD_TFR CurrentItem;

            public KCD_TFRDataReader(List<KCD_TFR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 21; } }
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
                    case 2: // KCD_TRANS_ID
                        return CurrentItem.KCD_TRANS_ID;
                    case 3: // KCDKEY
                        return CurrentItem.KCDKEY;
                    case 4: // KCDKEY_NEW
                        return CurrentItem.KCDKEY_NEW;
                    case 5: // TITLE
                        return CurrentItem.TITLE;
                    case 6: // DR_GROUP
                        return CurrentItem.DR_GROUP;
                    case 7: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 8: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 9: // SUBURB
                        return CurrentItem.SUBURB;
                    case 10: // STATE
                        return CurrentItem.STATE;
                    case 11: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 12: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 13: // FAX
                        return CurrentItem.FAX;
                    case 14: // KAP_LINK
                        return CurrentItem.KAP_LINK;
                    case 15: // KAP_LINK_NEW
                        return CurrentItem.KAP_LINK_NEW;
                    case 16: // IMP_STATUS
                        return CurrentItem.IMP_STATUS;
                    case 17: // IMP_DATE
                        return CurrentItem.IMP_DATE;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // KCD_TRANS_ID
                        return CurrentItem.KCD_TRANS_ID == null;
                    case 3: // KCDKEY
                        return CurrentItem.KCDKEY == null;
                    case 4: // KCDKEY_NEW
                        return CurrentItem.KCDKEY_NEW == null;
                    case 5: // TITLE
                        return CurrentItem.TITLE == null;
                    case 6: // DR_GROUP
                        return CurrentItem.DR_GROUP == null;
                    case 7: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 8: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 9: // SUBURB
                        return CurrentItem.SUBURB == null;
                    case 10: // STATE
                        return CurrentItem.STATE == null;
                    case 11: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 12: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 13: // FAX
                        return CurrentItem.FAX == null;
                    case 14: // KAP_LINK
                        return CurrentItem.KAP_LINK == null;
                    case 15: // KAP_LINK_NEW
                        return CurrentItem.KAP_LINK_NEW == null;
                    case 16: // IMP_STATUS
                        return CurrentItem.IMP_STATUS == null;
                    case 17: // IMP_DATE
                        return CurrentItem.IMP_DATE == null;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 20: // LW_USER
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
                    case 2: // KCD_TRANS_ID
                        return "KCD_TRANS_ID";
                    case 3: // KCDKEY
                        return "KCDKEY";
                    case 4: // KCDKEY_NEW
                        return "KCDKEY_NEW";
                    case 5: // TITLE
                        return "TITLE";
                    case 6: // DR_GROUP
                        return "DR_GROUP";
                    case 7: // ADDRESS01
                        return "ADDRESS01";
                    case 8: // ADDRESS02
                        return "ADDRESS02";
                    case 9: // SUBURB
                        return "SUBURB";
                    case 10: // STATE
                        return "STATE";
                    case 11: // POSTCODE
                        return "POSTCODE";
                    case 12: // TELEPHONE
                        return "TELEPHONE";
                    case 13: // FAX
                        return "FAX";
                    case 14: // KAP_LINK
                        return "KAP_LINK";
                    case 15: // KAP_LINK_NEW
                        return "KAP_LINK_NEW";
                    case 16: // IMP_STATUS
                        return "IMP_STATUS";
                    case 17: // IMP_DATE
                        return "IMP_DATE";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
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
                    case "KCD_TRANS_ID":
                        return 2;
                    case "KCDKEY":
                        return 3;
                    case "KCDKEY_NEW":
                        return 4;
                    case "TITLE":
                        return 5;
                    case "DR_GROUP":
                        return 6;
                    case "ADDRESS01":
                        return 7;
                    case "ADDRESS02":
                        return 8;
                    case "SUBURB":
                        return 9;
                    case "STATE":
                        return 10;
                    case "POSTCODE":
                        return 11;
                    case "TELEPHONE":
                        return 12;
                    case "FAX":
                        return 13;
                    case "KAP_LINK":
                        return 14;
                    case "KAP_LINK_NEW":
                        return 15;
                    case "IMP_STATUS":
                        return 16;
                    case "IMP_DATE":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
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
