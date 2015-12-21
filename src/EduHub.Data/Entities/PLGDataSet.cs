using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLGDataSet : EduHubDataSet<PLG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLG"; } }

        internal PLGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_GROUP = new Lazy<Dictionary<string, PLG>>(() => this.ToDictionary(i => i.LEAVE_GROUP));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLG" /> fields for each CSV column header</returns>
        protected override Action<PLG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_GROUP_DESC":
                        mapper[i] = (e, v) => e.LEAVE_GROUP_DESC = v;
                        break;
                    case "WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.WEEKLY_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DAILY_HOURS":
                        mapper[i] = (e, v) => e.DAILY_HOURS = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="PLG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PLG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PLG" /> items to added or update the base <see cref="PLG" /> items</param>
        /// <returns>A merged list of <see cref="PLG" /> items</returns>
        protected override List<PLG> ApplyDeltaItems(List<PLG> Items, List<PLG> DeltaItems)
        {
            Dictionary<string, int> Index_LEAVE_GROUP = Items.ToIndexDictionary(i => i.LEAVE_GROUP);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PLG deltaItem in DeltaItems)
            {
                int index;

                if (Index_LEAVE_GROUP.TryGetValue(deltaItem.LEAVE_GROUP, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.LEAVE_GROUP)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, PLG>> Index_LEAVE_GROUP;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLG FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <param name="Value">Related PLG entity</param>
        /// <returns>True if the related PLG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out PLG Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLG TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            PLG value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
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
        /// Returns SQL which checks for the existence of a PLG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PLG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PLG](
        [LEAVE_GROUP] varchar(8) NOT NULL,
        [LEAVE_GROUP_DESC] varchar(30) NULL,
        [WEEKLY_HOURS] float NULL,
        [DAILY_HOURS] float NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PLG_Index_LEAVE_GROUP] PRIMARY KEY CLUSTERED (
            [LEAVE_GROUP] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PLGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PLGDataReader : IDataReader, IDataRecord
        {
            private List<PLG> Items;
            private int CurrentIndex;
            private PLG CurrentItem;

            public PLGDataReader(List<PLG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 8; } }
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
                    case 0: // LEAVE_GROUP
                        return CurrentItem.LEAVE_GROUP;
                    case 1: // LEAVE_GROUP_DESC
                        return CurrentItem.LEAVE_GROUP_DESC;
                    case 2: // WEEKLY_HOURS
                        return CurrentItem.WEEKLY_HOURS;
                    case 3: // DAILY_HOURS
                        return CurrentItem.DAILY_HOURS;
                    case 4: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 7: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEAVE_GROUP_DESC
                        return CurrentItem.LEAVE_GROUP_DESC == null;
                    case 2: // WEEKLY_HOURS
                        return CurrentItem.WEEKLY_HOURS == null;
                    case 3: // DAILY_HOURS
                        return CurrentItem.DAILY_HOURS == null;
                    case 4: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 7: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // LEAVE_GROUP
                        return "LEAVE_GROUP";
                    case 1: // LEAVE_GROUP_DESC
                        return "LEAVE_GROUP_DESC";
                    case 2: // WEEKLY_HOURS
                        return "WEEKLY_HOURS";
                    case 3: // DAILY_HOURS
                        return "DAILY_HOURS";
                    case 4: // ACTIVE
                        return "ACTIVE";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "LEAVE_GROUP":
                        return 0;
                    case "LEAVE_GROUP_DESC":
                        return 1;
                    case "WEEKLY_HOURS":
                        return 2;
                    case "DAILY_HOURS":
                        return 3;
                    case "ACTIVE":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
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
