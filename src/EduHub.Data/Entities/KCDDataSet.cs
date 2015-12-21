using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Doctors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCDDataSet : EduHubDataSet<KCD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCD"; } }

        internal KCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCDKEY = new Lazy<Dictionary<string, KCD>>(() => this.ToDictionary(i => i.KCDKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KCD>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCD" /> fields for each CSV column header</returns>
        protected override Action<KCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCDKEY":
                        mapper[i] = (e, v) => e.KCDKEY = v;
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
        /// Merges <see cref="KCD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCD" /> items to added or update the base <see cref="KCD" /> items</param>
        /// <returns>A merged list of <see cref="KCD" /> items</returns>
        protected override List<KCD> ApplyDeltaItems(List<KCD> Items, List<KCD> DeltaItems)
        {
            Dictionary<string, int> Index_KCDKEY = Items.ToIndexDictionary(i => i.KCDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCD deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCDKEY.TryGetValue(deltaItem.KCDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCD>> Index_KCDKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KCD>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD FindByKCDKEY(string KCDKEY)
        {
            return Index_KCDKEY.Value[KCDKEY];
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <param name="Value">Related KCD entity</param>
        /// <returns>True if the related KCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCDKEY(string KCDKEY, out KCD Value)
        {
            return Index_KCDKEY.Value.TryGetValue(KCDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD TryFindByKCDKEY(string KCDKEY)
        {
            KCD value;
            if (Index_KCDKEY.Value.TryGetValue(KCDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <returns>List of related KCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <param name="Value">List of related KCD entities</param>
        /// <returns>True if the list of related KCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KCD> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <returns>List of related KCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KCD> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
        /// Returns SQL which checks for the existence of a KCD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCD](
        [KCDKEY] varchar(10) NOT NULL,
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
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCD_Index_KCDKEY] PRIMARY KEY CLUSTERED (
            [KCDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCD_Index_LW_DATE] ON [dbo].[KCD]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCDDataReader : IDataReader, IDataRecord
        {
            private List<KCD> Items;
            private int CurrentIndex;
            private KCD CurrentItem;

            public KCDDataReader(List<KCD> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 14; } }
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
                    case 0: // KCDKEY
                        return CurrentItem.KCDKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // DR_GROUP
                        return CurrentItem.DR_GROUP;
                    case 3: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 4: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 5: // SUBURB
                        return CurrentItem.SUBURB;
                    case 6: // STATE
                        return CurrentItem.STATE;
                    case 7: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 8: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 9: // FAX
                        return CurrentItem.FAX;
                    case 10: // KAP_LINK
                        return CurrentItem.KAP_LINK;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // DR_GROUP
                        return CurrentItem.DR_GROUP == null;
                    case 3: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 4: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 5: // SUBURB
                        return CurrentItem.SUBURB == null;
                    case 6: // STATE
                        return CurrentItem.STATE == null;
                    case 7: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 8: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 9: // FAX
                        return CurrentItem.FAX == null;
                    case 10: // KAP_LINK
                        return CurrentItem.KAP_LINK == null;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCDKEY
                        return "KCDKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // DR_GROUP
                        return "DR_GROUP";
                    case 3: // ADDRESS01
                        return "ADDRESS01";
                    case 4: // ADDRESS02
                        return "ADDRESS02";
                    case 5: // SUBURB
                        return "SUBURB";
                    case 6: // STATE
                        return "STATE";
                    case 7: // POSTCODE
                        return "POSTCODE";
                    case 8: // TELEPHONE
                        return "TELEPHONE";
                    case 9: // FAX
                        return "FAX";
                    case 10: // KAP_LINK
                        return "KAP_LINK";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCDKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "DR_GROUP":
                        return 2;
                    case "ADDRESS01":
                        return 3;
                    case "ADDRESS02":
                        return 4;
                    case "SUBURB":
                        return 5;
                    case "STATE":
                        return 6;
                    case "POSTCODE":
                        return 7;
                    case "TELEPHONE":
                        return 8;
                    case "FAX":
                        return 9;
                    case "KAP_LINK":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
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
