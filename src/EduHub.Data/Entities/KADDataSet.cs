using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADDataSet : DataSetBase<KAD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAD"; } }

        internal KADDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KADKEY = new Lazy<Dictionary<string, KAD>>(() => this.ToDictionary(i => i.KADKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAD" /> fields for each CSV column header</returns>
        protected override Action<KAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADKEY":
                        mapper[i] = (e, v) => e.KADKEY = v;
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
        /// Merges <see cref="KAD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAD" /> items to added or update the base <see cref="KAD" /> items</param>
        /// <returns>A merged list of <see cref="KAD" /> items</returns>
        protected override List<KAD> ApplyDeltaItems(List<KAD> Items, List<KAD> DeltaItems)
        {
            Dictionary<string, int> Index_KADKEY = Items.ToIndexDictionary(i => i.KADKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAD deltaItem in DeltaItems)
            {
                int index;

                if (Index_KADKEY.TryGetValue(deltaItem.KADKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KADKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAD>> Index_KADKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAD FindByKADKEY(string KADKEY)
        {
            return Index_KADKEY.Value[KADKEY];
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <param name="Value">Related KAD entity</param>
        /// <returns>True if the related KAD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKADKEY(string KADKEY, out KAD Value)
        {
            return Index_KADKEY.Value.TryGetValue(KADKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAD TryFindByKADKEY(string KADKEY)
        {
            KAD value;
            if (Index_KADKEY.Value.TryGetValue(KADKEY, out value))
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
        /// Returns SQL which checks for the existence of a KAD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAD](
        [KADKEY] varchar(10) NOT NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAD_Index_KADKEY] PRIMARY KEY CLUSTERED (
            [KADKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KADDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KADDataReader : IDataReader, IDataRecord
        {
            private List<KAD> Items;
            private int CurrentIndex;
            private KAD CurrentItem;

            public KADDataReader(List<KAD> Items)
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
                    case 0: // KADKEY
                        return CurrentItem.KADKEY;
                    case 1: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 2: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 3: // ADDRESS03
                        return CurrentItem.ADDRESS03;
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
                    case 1: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 2: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 3: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
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
                    case 0: // KADKEY
                        return "KADKEY";
                    case 1: // ADDRESS01
                        return "ADDRESS01";
                    case 2: // ADDRESS02
                        return "ADDRESS02";
                    case 3: // ADDRESS03
                        return "ADDRESS03";
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
                    case "KADKEY":
                        return 0;
                    case "ADDRESS01":
                        return 1;
                    case "ADDRESS02":
                        return 2;
                    case "ADDRESS03":
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
