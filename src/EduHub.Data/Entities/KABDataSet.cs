using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KABDataSet : DataSetBase<KAB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAB"; } }

        internal KABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<Dictionary<string, KAB>>(() => this.ToDictionary(i => i.BSB));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAB" /> fields for each CSV column header</returns>
        protected override Action<KAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
        /// Merges <see cref="KAB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAB" /> items to added or update the base <see cref="KAB" /> items</param>
        /// <returns>A merged list of <see cref="KAB" /> items</returns>
        protected override List<KAB> ApplyDeltaItems(List<KAB> Items, List<KAB> DeltaItems)
        {
            Dictionary<string, int> Index_BSB = Items.ToIndexDictionary(i => i.BSB);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAB deltaItem in DeltaItems)
            {
                int index;

                if (Index_BSB.TryGetValue(deltaItem.BSB, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.BSB)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAB>> Index_BSB;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <returns>Related KAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAB FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <param name="Value">Related KAB entity</param>
        /// <returns>True if the related KAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out KAB Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <returns>Related KAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAB TryFindByBSB(string BSB)
        {
            KAB value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
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
        /// Returns SQL which checks for the existence of a KAB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAB](
        [BSB] varchar(6) NOT NULL,
        [BANK] varchar(10) NULL,
        [ADDRESS] varchar(50) NULL,
        [SUBURB] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAB_Index_BSB] PRIMARY KEY CLUSTERED (
            [BSB] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KABDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KABDataReader : IDataReader, IDataRecord
        {
            private List<KAB> Items;
            private int CurrentIndex;
            private KAB CurrentItem;

            public KABDataReader(List<KAB> Items)
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
                    case 0: // BSB
                        return CurrentItem.BSB;
                    case 1: // BANK
                        return CurrentItem.BANK;
                    case 2: // ADDRESS
                        return CurrentItem.ADDRESS;
                    case 3: // SUBURB
                        return CurrentItem.SUBURB;
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
                    case 1: // BANK
                        return CurrentItem.BANK == null;
                    case 2: // ADDRESS
                        return CurrentItem.ADDRESS == null;
                    case 3: // SUBURB
                        return CurrentItem.SUBURB == null;
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
                    case 0: // BSB
                        return "BSB";
                    case 1: // BANK
                        return "BANK";
                    case 2: // ADDRESS
                        return "ADDRESS";
                    case 3: // SUBURB
                        return "SUBURB";
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
                    case "BSB":
                        return 0;
                    case "BANK":
                        return 1;
                    case "ADDRESS":
                        return 2;
                    case "SUBURB":
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
