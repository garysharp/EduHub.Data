using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCDataSet : EduHubDataSet<KPC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPC"; } }

        internal KPCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPCKEY = new Lazy<Dictionary<string, KPC>>(() => this.ToDictionary(i => i.KPCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPC" /> fields for each CSV column header</returns>
        protected override Action<KPC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCKEY":
                        mapper[i] = (e, v) => e.KPCKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
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
                    case "POST":
                        mapper[i] = (e, v) => e.POST = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "HOME_PHONE":
                        mapper[i] = (e, v) => e.HOME_PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
        /// Merges <see cref="KPC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPC" /> items to added or update the base <see cref="KPC" /> items</param>
        /// <returns>A merged list of <see cref="KPC" /> items</returns>
        protected override List<KPC> ApplyDeltaItems(List<KPC> Items, List<KPC> DeltaItems)
        {
            Dictionary<string, int> Index_KPCKEY = Items.ToIndexDictionary(i => i.KPCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPCKEY.TryGetValue(deltaItem.KPCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KPC>> Index_KPCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPC FindByKPCKEY(string KPCKEY)
        {
            return Index_KPCKEY.Value[KPCKEY];
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <param name="Value">Related KPC entity</param>
        /// <returns>True if the related KPC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCKEY(string KPCKEY, out KPC Value)
        {
            return Index_KPCKEY.Value.TryGetValue(KPCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPC TryFindByKPCKEY(string KPCKEY)
        {
            KPC value;
            if (Index_KPCKEY.Value.TryGetValue(KPCKEY, out value))
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
        /// Returns SQL which checks for the existence of a KPC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPC](
        [KPCKEY] varchar(10) NOT NULL,
        [SURNAME] varchar(20) NULL,
        [FIRST_NAME] varchar(15) NULL,
        [SECOND_NAME] varchar(15) NULL,
        [GENDER] varchar(1) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POST] varchar(4) NULL,
        [BUS_PHONE] varchar(15) NULL,
        [HOME_PHONE] varchar(15) NULL,
        [MOBILE] varchar(15) NULL,
        [EMAIL] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPC_Index_KPCKEY] PRIMARY KEY CLUSTERED (
            [KPCKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KPCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPCDataReader : IDataReader, IDataRecord
        {
            private List<KPC> Items;
            private int CurrentIndex;
            private KPC CurrentItem;

            public KPCDataReader(List<KPC> Items)
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
                    case 0: // KPCKEY
                        return CurrentItem.KPCKEY;
                    case 1: // SURNAME
                        return CurrentItem.SURNAME;
                    case 2: // FIRST_NAME
                        return CurrentItem.FIRST_NAME;
                    case 3: // SECOND_NAME
                        return CurrentItem.SECOND_NAME;
                    case 4: // GENDER
                        return CurrentItem.GENDER;
                    case 5: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 6: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 7: // ADDRESS03
                        return CurrentItem.ADDRESS03;
                    case 8: // STATE
                        return CurrentItem.STATE;
                    case 9: // POST
                        return CurrentItem.POST;
                    case 10: // BUS_PHONE
                        return CurrentItem.BUS_PHONE;
                    case 11: // HOME_PHONE
                        return CurrentItem.HOME_PHONE;
                    case 12: // MOBILE
                        return CurrentItem.MOBILE;
                    case 13: // EMAIL
                        return CurrentItem.EMAIL;
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
                    case 1: // SURNAME
                        return CurrentItem.SURNAME == null;
                    case 2: // FIRST_NAME
                        return CurrentItem.FIRST_NAME == null;
                    case 3: // SECOND_NAME
                        return CurrentItem.SECOND_NAME == null;
                    case 4: // GENDER
                        return CurrentItem.GENDER == null;
                    case 5: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 6: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 7: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
                    case 8: // STATE
                        return CurrentItem.STATE == null;
                    case 9: // POST
                        return CurrentItem.POST == null;
                    case 10: // BUS_PHONE
                        return CurrentItem.BUS_PHONE == null;
                    case 11: // HOME_PHONE
                        return CurrentItem.HOME_PHONE == null;
                    case 12: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 13: // EMAIL
                        return CurrentItem.EMAIL == null;
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
                    case 0: // KPCKEY
                        return "KPCKEY";
                    case 1: // SURNAME
                        return "SURNAME";
                    case 2: // FIRST_NAME
                        return "FIRST_NAME";
                    case 3: // SECOND_NAME
                        return "SECOND_NAME";
                    case 4: // GENDER
                        return "GENDER";
                    case 5: // ADDRESS01
                        return "ADDRESS01";
                    case 6: // ADDRESS02
                        return "ADDRESS02";
                    case 7: // ADDRESS03
                        return "ADDRESS03";
                    case 8: // STATE
                        return "STATE";
                    case 9: // POST
                        return "POST";
                    case 10: // BUS_PHONE
                        return "BUS_PHONE";
                    case 11: // HOME_PHONE
                        return "HOME_PHONE";
                    case 12: // MOBILE
                        return "MOBILE";
                    case 13: // EMAIL
                        return "EMAIL";
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
                    case "KPCKEY":
                        return 0;
                    case "SURNAME":
                        return 1;
                    case "FIRST_NAME":
                        return 2;
                    case "SECOND_NAME":
                        return 3;
                    case "GENDER":
                        return 4;
                    case "ADDRESS01":
                        return 5;
                    case "ADDRESS02":
                        return 6;
                    case "ADDRESS03":
                        return 7;
                    case "STATE":
                        return 8;
                    case "POST":
                        return 9;
                    case "BUS_PHONE":
                        return 10;
                    case "HOME_PHONE":
                        return 11;
                    case "MOBILE":
                        return 12;
                    case "EMAIL":
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
