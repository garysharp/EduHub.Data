using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSDataSet : EduHubDataSet<PS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PS"; } }

        internal PSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSKEY = new Lazy<Dictionary<short, PS>>(() => this.ToDictionary(i => i.PSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PS" /> fields for each CSV column header</returns>
        protected override Action<PS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "EFFECTIVE_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MONTHLY_RATE":
                        mapper[i] = (e, v) => e.MONTHLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FORTNIGHTLY_RATE":
                        mapper[i] = (e, v) => e.FORTNIGHTLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_RATE":
                        mapper[i] = (e, v) => e.WEEKLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.STD_WEEKLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_MONTHLY_HOURS":
                        mapper[i] = (e, v) => e.STD_MONTHLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PS" /> items to added or update the base <see cref="PS" /> items</param>
        /// <returns>A merged list of <see cref="PS" /> items</returns>
        protected override List<PS> ApplyDeltaItems(List<PS> Items, List<PS> DeltaItems)
        {
            Dictionary<short, int> Index_PSKEY = Items.ToIndexDictionary(i => i.PSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PS deltaItem in DeltaItems)
            {
                int index;

                if (Index_PSKEY.TryGetValue(deltaItem.PSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, PS>> Index_PSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <returns>Related PS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PS FindByPSKEY(short PSKEY)
        {
            return Index_PSKEY.Value[PSKEY];
        }

        /// <summary>
        /// Attempt to find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <param name="Value">Related PS entity</param>
        /// <returns>True if the related PS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSKEY(short PSKEY, out PS Value)
        {
            return Index_PSKEY.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <returns>Related PS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PS TryFindByPSKEY(short PSKEY)
        {
            PS value;
            if (Index_PSKEY.Value.TryGetValue(PSKEY, out value))
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
        /// Returns SQL which checks for the existence of a PS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PS](
        [PSKEY] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [PAY_TYPE] varchar(1) NULL,
        [EFFECTIVE_DATE] datetime NULL,
        [ANNUAL_RATE] money NULL,
        [MONTHLY_RATE] money NULL,
        [FORTNIGHTLY_RATE] money NULL,
        [WEEKLY_RATE] money NULL,
        [HOURLY_RATE] money NULL,
        [STD_WEEKLY_HOURS] money NULL,
        [STD_MONTHLY_HOURS] money NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PS_Index_PSKEY] PRIMARY KEY CLUSTERED (
            [PSKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PSDataReader : IDataReader, IDataRecord
        {
            private List<PS> Items;
            private int CurrentIndex;
            private PS CurrentItem;

            public PSDataReader(List<PS> Items)
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
                    case 0: // PSKEY
                        return CurrentItem.PSKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // PAY_TYPE
                        return CurrentItem.PAY_TYPE;
                    case 3: // EFFECTIVE_DATE
                        return CurrentItem.EFFECTIVE_DATE;
                    case 4: // ANNUAL_RATE
                        return CurrentItem.ANNUAL_RATE;
                    case 5: // MONTHLY_RATE
                        return CurrentItem.MONTHLY_RATE;
                    case 6: // FORTNIGHTLY_RATE
                        return CurrentItem.FORTNIGHTLY_RATE;
                    case 7: // WEEKLY_RATE
                        return CurrentItem.WEEKLY_RATE;
                    case 8: // HOURLY_RATE
                        return CurrentItem.HOURLY_RATE;
                    case 9: // STD_WEEKLY_HOURS
                        return CurrentItem.STD_WEEKLY_HOURS;
                    case 10: // STD_MONTHLY_HOURS
                        return CurrentItem.STD_MONTHLY_HOURS;
                    case 11: // ACTIVE
                        return CurrentItem.ACTIVE;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // PAY_TYPE
                        return CurrentItem.PAY_TYPE == null;
                    case 3: // EFFECTIVE_DATE
                        return CurrentItem.EFFECTIVE_DATE == null;
                    case 4: // ANNUAL_RATE
                        return CurrentItem.ANNUAL_RATE == null;
                    case 5: // MONTHLY_RATE
                        return CurrentItem.MONTHLY_RATE == null;
                    case 6: // FORTNIGHTLY_RATE
                        return CurrentItem.FORTNIGHTLY_RATE == null;
                    case 7: // WEEKLY_RATE
                        return CurrentItem.WEEKLY_RATE == null;
                    case 8: // HOURLY_RATE
                        return CurrentItem.HOURLY_RATE == null;
                    case 9: // STD_WEEKLY_HOURS
                        return CurrentItem.STD_WEEKLY_HOURS == null;
                    case 10: // STD_MONTHLY_HOURS
                        return CurrentItem.STD_MONTHLY_HOURS == null;
                    case 11: // ACTIVE
                        return CurrentItem.ACTIVE == null;
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
                    case 0: // PSKEY
                        return "PSKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // PAY_TYPE
                        return "PAY_TYPE";
                    case 3: // EFFECTIVE_DATE
                        return "EFFECTIVE_DATE";
                    case 4: // ANNUAL_RATE
                        return "ANNUAL_RATE";
                    case 5: // MONTHLY_RATE
                        return "MONTHLY_RATE";
                    case 6: // FORTNIGHTLY_RATE
                        return "FORTNIGHTLY_RATE";
                    case 7: // WEEKLY_RATE
                        return "WEEKLY_RATE";
                    case 8: // HOURLY_RATE
                        return "HOURLY_RATE";
                    case 9: // STD_WEEKLY_HOURS
                        return "STD_WEEKLY_HOURS";
                    case 10: // STD_MONTHLY_HOURS
                        return "STD_MONTHLY_HOURS";
                    case 11: // ACTIVE
                        return "ACTIVE";
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
                    case "PSKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "PAY_TYPE":
                        return 2;
                    case "EFFECTIVE_DATE":
                        return 3;
                    case "ANNUAL_RATE":
                        return 4;
                    case "MONTHLY_RATE":
                        return 5;
                    case "FORTNIGHTLY_RATE":
                        return 6;
                    case "WEEKLY_RATE":
                        return 7;
                    case "HOURLY_RATE":
                        return 8;
                    case "STD_WEEKLY_HOURS":
                        return 9;
                    case "STD_MONTHLY_HOURS":
                        return 10;
                    case "ACTIVE":
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
