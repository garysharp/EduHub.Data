using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// UM Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UM_TFRDataSet : EduHubDataSet<UM_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM_TFR"; } }

        internal UM_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<UM_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, UM_TFR>>(() => this.ToDictionary(i => i.TID));
            Index_UM_TRANS_ID = new Lazy<NullDictionary<string, UM_TFR>>(() => this.ToNullDictionary(i => i.UM_TRANS_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM_TFR" /> fields for each CSV column header</returns>
        protected override Action<UM_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<UM_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "UM_TRANS_ID":
                        mapper[i] = (e, v) => e.UM_TRANS_ID = v;
                        break;
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UMKEY_NEW":
                        mapper[i] = (e, v) => e.UMKEY_NEW = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
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
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
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
        /// Merges <see cref="UM_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="UM_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="UM_TFR" /> items to added or update the base <see cref="UM_TFR" /> items</param>
        /// <returns>A merged list of <see cref="UM_TFR" /> items</returns>
        protected override List<UM_TFR> ApplyDeltaItems(List<UM_TFR> Items, List<UM_TFR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            NullDictionary<string, int> Index_UM_TRANS_ID = Items.ToIndexNullDictionary(i => i.UM_TRANS_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (UM_TFR deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_UM_TRANS_ID.TryGetValue(deltaItem.UM_TRANS_ID, out index))
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

        private Lazy<Dictionary<string, IReadOnlyList<UM_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, UM_TFR>> Index_TID;
        private Lazy<NullDictionary<string, UM_TFR>> Index_UM_TRANS_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find UM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find UM_TFR</param>
        /// <returns>List of related UM_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find UM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find UM_TFR</param>
        /// <param name="Value">List of related UM_TFR entities</param>
        /// <returns>True if the list of related UM_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<UM_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find UM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find UM_TFR</param>
        /// <returns>List of related UM_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<UM_TFR> value;
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
        /// Find UM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find UM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find UM_TFR</param>
        /// <param name="Value">Related UM_TFR entity</param>
        /// <returns>True if the related UM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out UM_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find UM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR TryFindByTID(int TID)
        {
            UM_TFR value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM_TFR by UM_TRANS_ID field
        /// </summary>
        /// <param name="UM_TRANS_ID">UM_TRANS_ID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR FindByUM_TRANS_ID(string UM_TRANS_ID)
        {
            return Index_UM_TRANS_ID.Value[UM_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find UM_TFR by UM_TRANS_ID field
        /// </summary>
        /// <param name="UM_TRANS_ID">UM_TRANS_ID value used to find UM_TFR</param>
        /// <param name="Value">Related UM_TFR entity</param>
        /// <returns>True if the related UM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByUM_TRANS_ID(string UM_TRANS_ID, out UM_TFR Value)
        {
            return Index_UM_TRANS_ID.Value.TryGetValue(UM_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find UM_TFR by UM_TRANS_ID field
        /// </summary>
        /// <param name="UM_TRANS_ID">UM_TRANS_ID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR TryFindByUM_TRANS_ID(string UM_TRANS_ID)
        {
            UM_TFR value;
            if (Index_UM_TRANS_ID.Value.TryGetValue(UM_TRANS_ID, out value))
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
        /// Returns SQL which checks for the existence of a UM_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[UM_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[UM_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [UM_TRANS_ID] varchar(30) NULL,
        [UMKEY] int NULL,
        [UMKEY_NEW] int NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [MOBILE] varchar(20) NULL,
        [SILENT] varchar(1) NULL,
        [FAX] varchar(20) NULL,
        [KAP_LINK] varchar(34) NULL,
        [COUNTRY] varchar(6) NULL,
        [DPID] int NULL,
        [BARCODE] varchar(37) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [UM_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [UM_TFR_Index_ORIG_SCHOOL] ON [dbo].[UM_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [UM_TFR_Index_UM_TRANS_ID] ON [dbo].[UM_TFR]
    (
            [UM_TRANS_ID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the UM_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the UM_TFR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new UM_TFRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class UM_TFRDataReader : IDataReader, IDataRecord
        {
            private List<UM_TFR> Items;
            private int CurrentIndex;
            private UM_TFR CurrentItem;

            public UM_TFRDataReader(List<UM_TFR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 23; } }
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
                    case 2: // UM_TRANS_ID
                        return CurrentItem.UM_TRANS_ID;
                    case 3: // UMKEY
                        return CurrentItem.UMKEY;
                    case 4: // UMKEY_NEW
                        return CurrentItem.UMKEY_NEW;
                    case 5: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 6: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 7: // ADDRESS03
                        return CurrentItem.ADDRESS03;
                    case 8: // STATE
                        return CurrentItem.STATE;
                    case 9: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 10: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 11: // MOBILE
                        return CurrentItem.MOBILE;
                    case 12: // SILENT
                        return CurrentItem.SILENT;
                    case 13: // FAX
                        return CurrentItem.FAX;
                    case 14: // KAP_LINK
                        return CurrentItem.KAP_LINK;
                    case 15: // COUNTRY
                        return CurrentItem.COUNTRY;
                    case 16: // DPID
                        return CurrentItem.DPID;
                    case 17: // BARCODE
                        return CurrentItem.BARCODE;
                    case 18: // IMP_STATUS
                        return CurrentItem.IMP_STATUS;
                    case 19: // IMP_DATE
                        return CurrentItem.IMP_DATE;
                    case 20: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 21: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 22: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // UM_TRANS_ID
                        return CurrentItem.UM_TRANS_ID == null;
                    case 3: // UMKEY
                        return CurrentItem.UMKEY == null;
                    case 4: // UMKEY_NEW
                        return CurrentItem.UMKEY_NEW == null;
                    case 5: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 6: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 7: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
                    case 8: // STATE
                        return CurrentItem.STATE == null;
                    case 9: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 10: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 11: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 12: // SILENT
                        return CurrentItem.SILENT == null;
                    case 13: // FAX
                        return CurrentItem.FAX == null;
                    case 14: // KAP_LINK
                        return CurrentItem.KAP_LINK == null;
                    case 15: // COUNTRY
                        return CurrentItem.COUNTRY == null;
                    case 16: // DPID
                        return CurrentItem.DPID == null;
                    case 17: // BARCODE
                        return CurrentItem.BARCODE == null;
                    case 18: // IMP_STATUS
                        return CurrentItem.IMP_STATUS == null;
                    case 19: // IMP_DATE
                        return CurrentItem.IMP_DATE == null;
                    case 20: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 21: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 22: // LW_USER
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
                    case 2: // UM_TRANS_ID
                        return "UM_TRANS_ID";
                    case 3: // UMKEY
                        return "UMKEY";
                    case 4: // UMKEY_NEW
                        return "UMKEY_NEW";
                    case 5: // ADDRESS01
                        return "ADDRESS01";
                    case 6: // ADDRESS02
                        return "ADDRESS02";
                    case 7: // ADDRESS03
                        return "ADDRESS03";
                    case 8: // STATE
                        return "STATE";
                    case 9: // POSTCODE
                        return "POSTCODE";
                    case 10: // TELEPHONE
                        return "TELEPHONE";
                    case 11: // MOBILE
                        return "MOBILE";
                    case 12: // SILENT
                        return "SILENT";
                    case 13: // FAX
                        return "FAX";
                    case 14: // KAP_LINK
                        return "KAP_LINK";
                    case 15: // COUNTRY
                        return "COUNTRY";
                    case 16: // DPID
                        return "DPID";
                    case 17: // BARCODE
                        return "BARCODE";
                    case 18: // IMP_STATUS
                        return "IMP_STATUS";
                    case 19: // IMP_DATE
                        return "IMP_DATE";
                    case 20: // LW_DATE
                        return "LW_DATE";
                    case 21: // LW_TIME
                        return "LW_TIME";
                    case 22: // LW_USER
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
                    case "UM_TRANS_ID":
                        return 2;
                    case "UMKEY":
                        return 3;
                    case "UMKEY_NEW":
                        return 4;
                    case "ADDRESS01":
                        return 5;
                    case "ADDRESS02":
                        return 6;
                    case "ADDRESS03":
                        return 7;
                    case "STATE":
                        return 8;
                    case "POSTCODE":
                        return 9;
                    case "TELEPHONE":
                        return 10;
                    case "MOBILE":
                        return 11;
                    case "SILENT":
                        return 12;
                    case "FAX":
                        return 13;
                    case "KAP_LINK":
                        return 14;
                    case "COUNTRY":
                        return 15;
                    case "DPID":
                        return 16;
                    case "BARCODE":
                        return 17;
                    case "IMP_STATUS":
                        return 18;
                    case "IMP_DATE":
                        return 19;
                    case "LW_DATE":
                        return 20;
                    case "LW_TIME":
                        return 21;
                    case "LW_USER":
                        return 22;
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
