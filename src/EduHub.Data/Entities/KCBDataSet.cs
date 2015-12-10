using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCBDataSet : DataSetBase<KCB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCB"; } }

        internal KCBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCBKEY = new Lazy<Dictionary<string, KCB>>(() => this.ToDictionary(i => i.KCBKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCB" /> fields for each CSV column header</returns>
        protected override Action<KCB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCBKEY":
                        mapper[i] = (e, v) => e.KCBKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "POS_NEG":
                        mapper[i] = (e, v) => e.POS_NEG = v;
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
        /// Merges <see cref="KCB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCB" /> items to added or update the base <see cref="KCB" /> items</param>
        /// <returns>A merged list of <see cref="KCB" /> items</returns>
        protected override List<KCB> ApplyDeltaItems(List<KCB> Items, List<KCB> DeltaItems)
        {
            Dictionary<string, int> Index_KCBKEY = Items.ToIndexDictionary(i => i.KCBKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCB deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCBKEY.TryGetValue(deltaItem.KCBKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCBKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCB>> Index_KCBKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCB FindByKCBKEY(string KCBKEY)
        {
            return Index_KCBKEY.Value[KCBKEY];
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <param name="Value">Related KCB entity</param>
        /// <returns>True if the related KCB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCBKEY(string KCBKEY, out KCB Value)
        {
            return Index_KCBKEY.Value.TryGetValue(KCBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCB TryFindByKCBKEY(string KCBKEY)
        {
            KCB value;
            if (Index_KCBKEY.Value.TryGetValue(KCBKEY, out value))
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
        /// Returns SQL which checks for the existence of a KCB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCB](
        [KCBKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [POS_NEG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCB_Index_KCBKEY] PRIMARY KEY CLUSTERED (
            [KCBKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCBDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCBDataReader : IDataReader, IDataRecord
        {
            private List<KCB> Items;
            private int CurrentIndex;
            private KCB CurrentItem;

            public KCBDataReader(List<KCB> Items)
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
                    case 0: // KCBKEY
                        return CurrentItem.KCBKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // POS_NEG
                        return CurrentItem.POS_NEG;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // POS_NEG
                        return CurrentItem.POS_NEG == null;
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
                    case 0: // KCBKEY
                        return "KCBKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // POS_NEG
                        return "POS_NEG";
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
                    case "KCBKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "POS_NEG":
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
