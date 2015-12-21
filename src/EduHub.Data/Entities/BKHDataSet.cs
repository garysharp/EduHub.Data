using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHDataSet : EduHubDataSet<BKH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BKH"; } }

        internal BKHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKHKEY = new Lazy<Dictionary<string, BKH>>(() => this.ToDictionary(i => i.BKHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BKH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BKH" /> fields for each CSV column header</returns>
        protected override Action<BKH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BKH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BKHKEY":
                        mapper[i] = (e, v) => e.BKHKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "EDITION":
                        mapper[i] = (e, v) => e.EDITION = v;
                        break;
                    case "AUTHOR":
                        mapper[i] = (e, v) => e.AUTHOR = v;
                        break;
                    case "PUBLISHER":
                        mapper[i] = (e, v) => e.PUBLISHER = v;
                        break;
                    case "PRICE":
                        mapper[i] = (e, v) => e.PRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "NO_COPIES":
                        mapper[i] = (e, v) => e.NO_COPIES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEEDED_NUM":
                        mapper[i] = (e, v) => e.SEEDED_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AVAIL_COPIES":
                        mapper[i] = (e, v) => e.AVAIL_COPIES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ISBN":
                        mapper[i] = (e, v) => e.ISBN = v;
                        break;
                    case "ANNOTATIONS":
                        mapper[i] = (e, v) => e.ANNOTATIONS = v;
                        break;
                    case "PURCHASE_DATE":
                        mapper[i] = (e, v) => e.PURCHASE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURCHASE_PRICE":
                        mapper[i] = (e, v) => e.PURCHASE_PRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HIRE_FEE":
                        mapper[i] = (e, v) => e.HIRE_FEE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REMOVE":
                        mapper[i] = (e, v) => e.REMOVE = v;
                        break;
                    case "BOOK_MOVIE":
                        mapper[i] = (e, v) => e.BOOK_MOVIE = null; // eduHub is not encoding byte arrays
                        break;
                    case "BOOK_SOUND":
                        mapper[i] = (e, v) => e.BOOK_SOUND = null; // eduHub is not encoding byte arrays
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
        /// Merges <see cref="BKH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="BKH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="BKH" /> items to added or update the base <see cref="BKH" /> items</param>
        /// <returns>A merged list of <see cref="BKH" /> items</returns>
        protected override List<BKH> ApplyDeltaItems(List<BKH> Items, List<BKH> DeltaItems)
        {
            Dictionary<string, int> Index_BKHKEY = Items.ToIndexDictionary(i => i.BKHKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (BKH deltaItem in DeltaItems)
            {
                int index;

                if (Index_BKHKEY.TryGetValue(deltaItem.BKHKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.BKHKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, BKH>> Index_BKHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKH FindByBKHKEY(string BKHKEY)
        {
            return Index_BKHKEY.Value[BKHKEY];
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <param name="Value">Related BKH entity</param>
        /// <returns>True if the related BKH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKHKEY(string BKHKEY, out BKH Value)
        {
            return Index_BKHKEY.Value.TryGetValue(BKHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKH TryFindByBKHKEY(string BKHKEY)
        {
            BKH value;
            if (Index_BKHKEY.Value.TryGetValue(BKHKEY, out value))
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
        /// Returns SQL which checks for the existence of a BKH table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BKH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BKH](
        [BKHKEY] varchar(13) NOT NULL,
        [TITLE] varchar(40) NULL,
        [EDITION] varchar(20) NULL,
        [AUTHOR] varchar(20) NULL,
        [PUBLISHER] varchar(30) NULL,
        [PRICE] money NULL,
        [ITEM_TYPE] varchar(1) NULL,
        [NO_COPIES] smallint NULL,
        [SEEDED_NUM] smallint NULL,
        [AVAIL_COPIES] smallint NULL,
        [ISBN] varchar(13) NULL,
        [ANNOTATIONS] text NULL,
        [PURCHASE_DATE] datetime NULL,
        [PURCHASE_PRICE] money NULL,
        [HIRE_FEE] money NULL,
        [REMOVE] varchar(1) NULL,
        [BOOK_MOVIE] image NULL,
        [BOOK_SOUND] image NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BKH_Index_BKHKEY] PRIMARY KEY CLUSTERED (
            [BKHKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BKH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BKH data set</returns>
        public override IDataReader GetDataReader()
        {
            return new BKHDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BKHDataReader : IDataReader, IDataRecord
        {
            private List<BKH> Items;
            private int CurrentIndex;
            private BKH CurrentItem;

            public BKHDataReader(List<BKH> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 21; } }
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
                    case 0: // BKHKEY
                        return CurrentItem.BKHKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // EDITION
                        return CurrentItem.EDITION;
                    case 3: // AUTHOR
                        return CurrentItem.AUTHOR;
                    case 4: // PUBLISHER
                        return CurrentItem.PUBLISHER;
                    case 5: // PRICE
                        return CurrentItem.PRICE;
                    case 6: // ITEM_TYPE
                        return CurrentItem.ITEM_TYPE;
                    case 7: // NO_COPIES
                        return CurrentItem.NO_COPIES;
                    case 8: // SEEDED_NUM
                        return CurrentItem.SEEDED_NUM;
                    case 9: // AVAIL_COPIES
                        return CurrentItem.AVAIL_COPIES;
                    case 10: // ISBN
                        return CurrentItem.ISBN;
                    case 11: // ANNOTATIONS
                        return CurrentItem.ANNOTATIONS;
                    case 12: // PURCHASE_DATE
                        return CurrentItem.PURCHASE_DATE;
                    case 13: // PURCHASE_PRICE
                        return CurrentItem.PURCHASE_PRICE;
                    case 14: // HIRE_FEE
                        return CurrentItem.HIRE_FEE;
                    case 15: // REMOVE
                        return CurrentItem.REMOVE;
                    case 16: // BOOK_MOVIE
                        return CurrentItem.BOOK_MOVIE;
                    case 17: // BOOK_SOUND
                        return CurrentItem.BOOK_SOUND;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // EDITION
                        return CurrentItem.EDITION == null;
                    case 3: // AUTHOR
                        return CurrentItem.AUTHOR == null;
                    case 4: // PUBLISHER
                        return CurrentItem.PUBLISHER == null;
                    case 5: // PRICE
                        return CurrentItem.PRICE == null;
                    case 6: // ITEM_TYPE
                        return CurrentItem.ITEM_TYPE == null;
                    case 7: // NO_COPIES
                        return CurrentItem.NO_COPIES == null;
                    case 8: // SEEDED_NUM
                        return CurrentItem.SEEDED_NUM == null;
                    case 9: // AVAIL_COPIES
                        return CurrentItem.AVAIL_COPIES == null;
                    case 10: // ISBN
                        return CurrentItem.ISBN == null;
                    case 11: // ANNOTATIONS
                        return CurrentItem.ANNOTATIONS == null;
                    case 12: // PURCHASE_DATE
                        return CurrentItem.PURCHASE_DATE == null;
                    case 13: // PURCHASE_PRICE
                        return CurrentItem.PURCHASE_PRICE == null;
                    case 14: // HIRE_FEE
                        return CurrentItem.HIRE_FEE == null;
                    case 15: // REMOVE
                        return CurrentItem.REMOVE == null;
                    case 16: // BOOK_MOVIE
                        return CurrentItem.BOOK_MOVIE == null;
                    case 17: // BOOK_SOUND
                        return CurrentItem.BOOK_SOUND == null;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // BKHKEY
                        return "BKHKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // EDITION
                        return "EDITION";
                    case 3: // AUTHOR
                        return "AUTHOR";
                    case 4: // PUBLISHER
                        return "PUBLISHER";
                    case 5: // PRICE
                        return "PRICE";
                    case 6: // ITEM_TYPE
                        return "ITEM_TYPE";
                    case 7: // NO_COPIES
                        return "NO_COPIES";
                    case 8: // SEEDED_NUM
                        return "SEEDED_NUM";
                    case 9: // AVAIL_COPIES
                        return "AVAIL_COPIES";
                    case 10: // ISBN
                        return "ISBN";
                    case 11: // ANNOTATIONS
                        return "ANNOTATIONS";
                    case 12: // PURCHASE_DATE
                        return "PURCHASE_DATE";
                    case 13: // PURCHASE_PRICE
                        return "PURCHASE_PRICE";
                    case 14: // HIRE_FEE
                        return "HIRE_FEE";
                    case 15: // REMOVE
                        return "REMOVE";
                    case 16: // BOOK_MOVIE
                        return "BOOK_MOVIE";
                    case 17: // BOOK_SOUND
                        return "BOOK_SOUND";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "BKHKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "EDITION":
                        return 2;
                    case "AUTHOR":
                        return 3;
                    case "PUBLISHER":
                        return 4;
                    case "PRICE":
                        return 5;
                    case "ITEM_TYPE":
                        return 6;
                    case "NO_COPIES":
                        return 7;
                    case "SEEDED_NUM":
                        return 8;
                    case "AVAIL_COPIES":
                        return 9;
                    case "ISBN":
                        return 10;
                    case "ANNOTATIONS":
                        return 11;
                    case "PURCHASE_DATE":
                        return 12;
                    case "PURCHASE_PRICE":
                        return 13;
                    case "HIRE_FEE":
                        return 14;
                    case "REMOVE":
                        return 15;
                    case "BOOK_MOVIE":
                        return 16;
                    case "BOOK_SOUND":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
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
