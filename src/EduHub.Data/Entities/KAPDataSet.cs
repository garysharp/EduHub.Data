using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Australian Postcodes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAPDataSet : DataSetBase<KAP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAP"; } }

        internal KAPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KAPKEY = new Lazy<Dictionary<string, KAP>>(() => this.ToDictionary(i => i.KAPKEY));
            Index_PLACE_NAME = new Lazy<NullDictionary<string, IReadOnlyList<KAP>>>(() => this.ToGroupedNullDictionary(i => i.PLACE_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAP" /> fields for each CSV column header</returns>
        protected override Action<KAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAPKEY":
                        mapper[i] = (e, v) => e.KAPKEY = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "PLACE_NAME":
                        mapper[i] = (e, v) => e.PLACE_NAME = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "DISCRIMINATOR":
                        mapper[i] = (e, v) => e.DISCRIMINATOR = v;
                        break;
                    case "STREET_ADD":
                        mapper[i] = (e, v) => e.STREET_ADD = v;
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
        /// Merges <see cref="KAP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAP" /> items to added or update the base <see cref="KAP" /> items</param>
        /// <returns>A merged list of <see cref="KAP" /> items</returns>
        protected override List<KAP> ApplyDeltaItems(List<KAP> Items, List<KAP> DeltaItems)
        {
            Dictionary<string, int> Index_KAPKEY = Items.ToIndexDictionary(i => i.KAPKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAP deltaItem in DeltaItems)
            {
                int index;

                if (Index_KAPKEY.TryGetValue(deltaItem.KAPKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KAPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAP>> Index_KAPKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KAP>>> Index_PLACE_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAP FindByKAPKEY(string KAPKEY)
        {
            return Index_KAPKEY.Value[KAPKEY];
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <param name="Value">Related KAP entity</param>
        /// <returns>True if the related KAP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKAPKEY(string KAPKEY, out KAP Value)
        {
            return Index_KAPKEY.Value.TryGetValue(KAPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAP TryFindByKAPKEY(string KAPKEY)
        {
            KAP value;
            if (Index_KAPKEY.Value.TryGetValue(KAPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <returns>List of related KAP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KAP> FindByPLACE_NAME(string PLACE_NAME)
        {
            return Index_PLACE_NAME.Value[PLACE_NAME];
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <param name="Value">List of related KAP entities</param>
        /// <returns>True if the list of related KAP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLACE_NAME(string PLACE_NAME, out IReadOnlyList<KAP> Value)
        {
            return Index_PLACE_NAME.Value.TryGetValue(PLACE_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <returns>List of related KAP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KAP> TryFindByPLACE_NAME(string PLACE_NAME)
        {
            IReadOnlyList<KAP> value;
            if (Index_PLACE_NAME.Value.TryGetValue(PLACE_NAME, out value))
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
        /// Returns SQL which checks for the existence of a KAP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAP](
        [KAPKEY] varchar(34) NOT NULL,
        [POSTCODE] varchar(4) NULL,
        [PLACE_NAME] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [DISCRIMINATOR] varchar(30) NULL,
        [STREET_ADD] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAP_Index_KAPKEY] PRIMARY KEY CLUSTERED (
            [KAPKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KAP_Index_PLACE_NAME] ON [dbo].[KAP]
    (
            [PLACE_NAME] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KAPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KAPDataReader : IDataReader, IDataRecord
        {
            private List<KAP> Items;
            private int CurrentIndex;
            private KAP CurrentItem;

            public KAPDataReader(List<KAP> Items)
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
                    case 0: // KAPKEY
                        return CurrentItem.KAPKEY;
                    case 1: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 2: // PLACE_NAME
                        return CurrentItem.PLACE_NAME;
                    case 3: // STATE
                        return CurrentItem.STATE;
                    case 4: // DISCRIMINATOR
                        return CurrentItem.DISCRIMINATOR;
                    case 5: // STREET_ADD
                        return CurrentItem.STREET_ADD;
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
                    case 1: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 2: // PLACE_NAME
                        return CurrentItem.PLACE_NAME == null;
                    case 3: // STATE
                        return CurrentItem.STATE == null;
                    case 4: // DISCRIMINATOR
                        return CurrentItem.DISCRIMINATOR == null;
                    case 5: // STREET_ADD
                        return CurrentItem.STREET_ADD == null;
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
                    case 0: // KAPKEY
                        return "KAPKEY";
                    case 1: // POSTCODE
                        return "POSTCODE";
                    case 2: // PLACE_NAME
                        return "PLACE_NAME";
                    case 3: // STATE
                        return "STATE";
                    case 4: // DISCRIMINATOR
                        return "DISCRIMINATOR";
                    case 5: // STREET_ADD
                        return "STREET_ADD";
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
                    case "KAPKEY":
                        return 0;
                    case "POSTCODE":
                        return 1;
                    case "PLACE_NAME":
                        return 2;
                    case "STATE":
                        return 3;
                    case "DISCRIMINATOR":
                        return 4;
                    case "STREET_ADD":
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
