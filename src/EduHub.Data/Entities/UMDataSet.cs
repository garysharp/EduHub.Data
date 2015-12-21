using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UMDataSet : EduHubDataSet<UM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM"; } }

        internal UMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<UM>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<UM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_UMKEY = new Lazy<Dictionary<int, UM>>(() => this.ToDictionary(i => i.UMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM" /> fields for each CSV column header</returns>
        protected override Action<UM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<UM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = int.Parse(v);
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
        /// Merges <see cref="UM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="UM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="UM" /> items to added or update the base <see cref="UM" /> items</param>
        /// <returns>A merged list of <see cref="UM" /> items</returns>
        protected override List<UM> ApplyDeltaItems(List<UM> Items, List<UM> DeltaItems)
        {
            Dictionary<int, int> Index_UMKEY = Items.ToIndexDictionary(i => i.UMKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (UM deltaItem in DeltaItems)
            {
                int index;

                if (Index_UMKEY.TryGetValue(deltaItem.UMKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.UMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<UM>>> Index_COUNTRY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<UM>>> Index_LW_DATE;
        private Lazy<Dictionary<int, UM>> Index_UMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <returns>List of related UM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <param name="Value">List of related UM entities</param>
        /// <returns>True if the list of related UM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<UM> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <returns>List of related UM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<UM> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <returns>List of related UM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <param name="Value">List of related UM entities</param>
        /// <returns>True if the list of related UM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<UM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <returns>List of related UM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<UM> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <returns>Related UM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM FindByUMKEY(int UMKEY)
        {
            return Index_UMKEY.Value[UMKEY];
        }

        /// <summary>
        /// Attempt to find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <param name="Value">Related UM entity</param>
        /// <returns>True if the related UM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByUMKEY(int UMKEY, out UM Value)
        {
            return Index_UMKEY.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <returns>Related UM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM TryFindByUMKEY(int UMKEY)
        {
            UM value;
            if (Index_UMKEY.Value.TryGetValue(UMKEY, out value))
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
        /// Returns SQL which checks for the existence of a UM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[UM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[UM](
        [UMKEY] int IDENTITY NOT NULL,
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
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [UM_Index_UMKEY] PRIMARY KEY CLUSTERED (
            [UMKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [UM_Index_COUNTRY] ON [dbo].[UM]
    (
            [COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [UM_Index_LW_DATE] ON [dbo].[UM]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the UM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the UM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new UMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class UMDataReader : IDataReader, IDataRecord
        {
            private List<UM> Items;
            private int CurrentIndex;
            private UM CurrentItem;

            public UMDataReader(List<UM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 17; } }
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
                    case 0: // UMKEY
                        return CurrentItem.UMKEY;
                    case 1: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 2: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 3: // ADDRESS03
                        return CurrentItem.ADDRESS03;
                    case 4: // STATE
                        return CurrentItem.STATE;
                    case 5: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 6: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 7: // MOBILE
                        return CurrentItem.MOBILE;
                    case 8: // SILENT
                        return CurrentItem.SILENT;
                    case 9: // FAX
                        return CurrentItem.FAX;
                    case 10: // KAP_LINK
                        return CurrentItem.KAP_LINK;
                    case 11: // COUNTRY
                        return CurrentItem.COUNTRY;
                    case 12: // DPID
                        return CurrentItem.DPID;
                    case 13: // BARCODE
                        return CurrentItem.BARCODE;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 2: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 3: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
                    case 4: // STATE
                        return CurrentItem.STATE == null;
                    case 5: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 6: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 7: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 8: // SILENT
                        return CurrentItem.SILENT == null;
                    case 9: // FAX
                        return CurrentItem.FAX == null;
                    case 10: // KAP_LINK
                        return CurrentItem.KAP_LINK == null;
                    case 11: // COUNTRY
                        return CurrentItem.COUNTRY == null;
                    case 12: // DPID
                        return CurrentItem.DPID == null;
                    case 13: // BARCODE
                        return CurrentItem.BARCODE == null;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // UMKEY
                        return "UMKEY";
                    case 1: // ADDRESS01
                        return "ADDRESS01";
                    case 2: // ADDRESS02
                        return "ADDRESS02";
                    case 3: // ADDRESS03
                        return "ADDRESS03";
                    case 4: // STATE
                        return "STATE";
                    case 5: // POSTCODE
                        return "POSTCODE";
                    case 6: // TELEPHONE
                        return "TELEPHONE";
                    case 7: // MOBILE
                        return "MOBILE";
                    case 8: // SILENT
                        return "SILENT";
                    case 9: // FAX
                        return "FAX";
                    case 10: // KAP_LINK
                        return "KAP_LINK";
                    case 11: // COUNTRY
                        return "COUNTRY";
                    case 12: // DPID
                        return "DPID";
                    case 13: // BARCODE
                        return "BARCODE";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "UMKEY":
                        return 0;
                    case "ADDRESS01":
                        return 1;
                    case "ADDRESS02":
                        return 2;
                    case "ADDRESS03":
                        return 3;
                    case "STATE":
                        return 4;
                    case "POSTCODE":
                        return 5;
                    case "TELEPHONE":
                        return 6;
                    case "MOBILE":
                        return 7;
                    case "SILENT":
                        return 8;
                    case "FAX":
                        return 9;
                    case "KAP_LINK":
                        return 10;
                    case "COUNTRY":
                        return 11;
                    case "DPID":
                        return 12;
                    case "BARCODE":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
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
