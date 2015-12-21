using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCTDataSet : EduHubDataSet<KCT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCT"; } }

        internal KCTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCTKEY = new Lazy<Dictionary<short, KCT>>(() => this.ToDictionary(i => i.KCTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCT" /> fields for each CSV column header</returns>
        protected override Action<KCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCTKEY":
                        mapper[i] = (e, v) => e.KCTKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABBREV_DESC":
                        mapper[i] = (e, v) => e.ABBREV_DESC = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
                        break;
                    case "DOE_TYPE":
                        mapper[i] = (e, v) => e.DOE_TYPE = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "PRE_APPROVED":
                        mapper[i] = (e, v) => e.PRE_APPROVED = v;
                        break;
                    case "ABS_RATE":
                        mapper[i] = (e, v) => e.ABS_RATE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SMS":
                        mapper[i] = (e, v) => e.SMS = v;
                        break;
                    case "SMS_MESSAGE":
                        mapper[i] = (e, v) => e.SMS_MESSAGE = v;
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
        /// Merges <see cref="KCT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCT" /> items to added or update the base <see cref="KCT" /> items</param>
        /// <returns>A merged list of <see cref="KCT" /> items</returns>
        protected override List<KCT> ApplyDeltaItems(List<KCT> Items, List<KCT> DeltaItems)
        {
            Dictionary<short, int> Index_KCTKEY = Items.ToIndexDictionary(i => i.KCTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCT deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCTKEY.TryGetValue(deltaItem.KCTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, KCT>> Index_KCTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCT FindByKCTKEY(short KCTKEY)
        {
            return Index_KCTKEY.Value[KCTKEY];
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <param name="Value">Related KCT entity</param>
        /// <returns>True if the related KCT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCTKEY(short KCTKEY, out KCT Value)
        {
            return Index_KCTKEY.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCT TryFindByKCTKEY(short KCTKEY)
        {
            KCT value;
            if (Index_KCTKEY.Value.TryGetValue(KCTKEY, out value))
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
        /// Returns SQL which checks for the existence of a KCT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCT](
        [KCTKEY] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ABBREV_DESC] varchar(8) NULL,
        [CURRICULUM] varchar(1) NULL,
        [DOE_TYPE] varchar(1) NULL,
        [ENABLED] varchar(1) NULL,
        [PRE_APPROVED] varchar(1) NULL,
        [ABS_RATE] smallint NULL,
        [SMS] varchar(1) NULL,
        [SMS_MESSAGE] varchar(160) NULL,
        [EMAIL] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCT_Index_KCTKEY] PRIMARY KEY CLUSTERED (
            [KCTKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCTDataReader : IDataReader, IDataRecord
        {
            private List<KCT> Items;
            private int CurrentIndex;
            private KCT CurrentItem;

            public KCTDataReader(List<KCT> Items)
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
                    case 0: // KCTKEY
                        return CurrentItem.KCTKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // ABBREV_DESC
                        return CurrentItem.ABBREV_DESC;
                    case 3: // CURRICULUM
                        return CurrentItem.CURRICULUM;
                    case 4: // DOE_TYPE
                        return CurrentItem.DOE_TYPE;
                    case 5: // ENABLED
                        return CurrentItem.ENABLED;
                    case 6: // PRE_APPROVED
                        return CurrentItem.PRE_APPROVED;
                    case 7: // ABS_RATE
                        return CurrentItem.ABS_RATE;
                    case 8: // SMS
                        return CurrentItem.SMS;
                    case 9: // SMS_MESSAGE
                        return CurrentItem.SMS_MESSAGE;
                    case 10: // EMAIL
                        return CurrentItem.EMAIL;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // ABBREV_DESC
                        return CurrentItem.ABBREV_DESC == null;
                    case 3: // CURRICULUM
                        return CurrentItem.CURRICULUM == null;
                    case 4: // DOE_TYPE
                        return CurrentItem.DOE_TYPE == null;
                    case 5: // ENABLED
                        return CurrentItem.ENABLED == null;
                    case 6: // PRE_APPROVED
                        return CurrentItem.PRE_APPROVED == null;
                    case 7: // ABS_RATE
                        return CurrentItem.ABS_RATE == null;
                    case 8: // SMS
                        return CurrentItem.SMS == null;
                    case 9: // SMS_MESSAGE
                        return CurrentItem.SMS_MESSAGE == null;
                    case 10: // EMAIL
                        return CurrentItem.EMAIL == null;
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
                    case 0: // KCTKEY
                        return "KCTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ABBREV_DESC
                        return "ABBREV_DESC";
                    case 3: // CURRICULUM
                        return "CURRICULUM";
                    case 4: // DOE_TYPE
                        return "DOE_TYPE";
                    case 5: // ENABLED
                        return "ENABLED";
                    case 6: // PRE_APPROVED
                        return "PRE_APPROVED";
                    case 7: // ABS_RATE
                        return "ABS_RATE";
                    case 8: // SMS
                        return "SMS";
                    case 9: // SMS_MESSAGE
                        return "SMS_MESSAGE";
                    case 10: // EMAIL
                        return "EMAIL";
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
                    case "KCTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ABBREV_DESC":
                        return 2;
                    case "CURRICULUM":
                        return 3;
                    case "DOE_TYPE":
                        return 4;
                    case "ENABLED":
                        return 5;
                    case "PRE_APPROVED":
                        return 6;
                    case "ABS_RATE":
                        return 7;
                    case "SMS":
                        return 8;
                    case "SMS_MESSAGE":
                        return 9;
                    case "EMAIL":
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
