using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAMDataSet : EduHubDataSet<KAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAM"; } }

        internal KAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KAMKEY = new Lazy<Dictionary<string, KAM>>(() => this.ToDictionary(i => i.KAMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAM" /> fields for each CSV column header</returns>
        protected override Action<KAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAMKEY":
                        mapper[i] = (e, v) => e.KAMKEY = v;
                        break;
                    case "BRIEF":
                        mapper[i] = (e, v) => e.BRIEF = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
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
        /// Merges <see cref="KAM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAM" /> items to added or update the base <see cref="KAM" /> items</param>
        /// <returns>A merged list of <see cref="KAM" /> items</returns>
        protected override List<KAM> ApplyDeltaItems(List<KAM> Items, List<KAM> DeltaItems)
        {
            Dictionary<string, int> Index_KAMKEY = Items.ToIndexDictionary(i => i.KAMKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAM deltaItem in DeltaItems)
            {
                int index;

                if (Index_KAMKEY.TryGetValue(deltaItem.KAMKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KAMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAM>> Index_KAMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAM FindByKAMKEY(string KAMKEY)
        {
            return Index_KAMKEY.Value[KAMKEY];
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <param name="Value">Related KAM entity</param>
        /// <returns>True if the related KAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKAMKEY(string KAMKEY, out KAM Value)
        {
            return Index_KAMKEY.Value.TryGetValue(KAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAM TryFindByKAMKEY(string KAMKEY)
        {
            KAM value;
            if (Index_KAMKEY.Value.TryGetValue(KAMKEY, out value))
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
        /// Returns SQL which checks for the existence of a KAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAM](
        [KAMKEY] varchar(5) NOT NULL,
        [BRIEF] varchar(40) NULL,
        [DETAIL] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAM_Index_KAMKEY] PRIMARY KEY CLUSTERED (
            [KAMKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KAMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KAMDataReader : IDataReader, IDataRecord
        {
            private List<KAM> Items;
            private int CurrentIndex;
            private KAM CurrentItem;

            public KAMDataReader(List<KAM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 0: // KAMKEY
                        return CurrentItem.KAMKEY;
                    case 1: // BRIEF
                        return CurrentItem.BRIEF;
                    case 2: // DETAIL
                        return CurrentItem.DETAIL;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // BRIEF
                        return CurrentItem.BRIEF == null;
                    case 2: // DETAIL
                        return CurrentItem.DETAIL == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KAMKEY
                        return "KAMKEY";
                    case 1: // BRIEF
                        return "BRIEF";
                    case 2: // DETAIL
                        return "DETAIL";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KAMKEY":
                        return 0;
                    case "BRIEF":
                        return 1;
                    case "DETAIL":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
