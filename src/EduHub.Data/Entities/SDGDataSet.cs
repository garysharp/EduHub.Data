using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fee Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDGDataSet : DataSetBase<SDG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDG"; } }

        internal SDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SDGKEY = new Lazy<Dictionary<string, SDG>>(() => this.ToDictionary(i => i.SDGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDG" /> fields for each CSV column header</returns>
        protected override Action<SDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDGKEY":
                        mapper[i] = (e, v) => e.SDGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MEMBER_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_TYPE = v;
                        break;
                    case "SDG_MEMO":
                        mapper[i] = (e, v) => e.SDG_MEMO = v;
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
        /// Merges <see cref="SDG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDG" /> items to added or update the base <see cref="SDG" /> items</param>
        /// <returns>A merged list of <see cref="SDG" /> items</returns>
        protected override List<SDG> ApplyDeltaItems(List<SDG> Items, List<SDG> DeltaItems)
        {
            Dictionary<string, int> Index_SDGKEY = Items.ToIndexDictionary(i => i.SDGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SDGKEY.TryGetValue(deltaItem.SDGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SDGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SDG>> Index_SDGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDG FindBySDGKEY(string SDGKEY)
        {
            return Index_SDGKEY.Value[SDGKEY];
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <param name="Value">Related SDG entity</param>
        /// <returns>True if the related SDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDGKEY(string SDGKEY, out SDG Value)
        {
            return Index_SDGKEY.Value.TryGetValue(SDGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDG TryFindBySDGKEY(string SDGKEY)
        {
            SDG value;
            if (Index_SDGKEY.Value.TryGetValue(SDGKEY, out value))
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
        /// Returns SQL which checks for the existence of a SDG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDG](
        [SDGKEY] varchar(12) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [MEMBER_TYPE] varchar(1) NULL,
        [SDG_MEMO] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDG_Index_SDGKEY] PRIMARY KEY CLUSTERED (
            [SDGKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SDGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDGDataReader : IDataReader, IDataRecord
        {
            private List<SDG> Items;
            private int CurrentIndex;
            private SDG CurrentItem;

            public SDGDataReader(List<SDG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 0: // SDGKEY
                        return CurrentItem.SDGKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // MEMBER_TYPE
                        return CurrentItem.MEMBER_TYPE;
                    case 3: // SDG_MEMO
                        return CurrentItem.SDG_MEMO;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 6: // LW_USER
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
                    case 2: // MEMBER_TYPE
                        return CurrentItem.MEMBER_TYPE == null;
                    case 3: // SDG_MEMO
                        return CurrentItem.SDG_MEMO == null;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SDGKEY
                        return "SDGKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // MEMBER_TYPE
                        return "MEMBER_TYPE";
                    case 3: // SDG_MEMO
                        return "SDG_MEMO";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SDGKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "MEMBER_TYPE":
                        return 2;
                    case "SDG_MEMO":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
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
