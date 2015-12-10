using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGDDataSet : DataSetBase<KGD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGD"; } }

        internal KGDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGDKEY = new Lazy<Dictionary<string, KGD>>(() => this.ToDictionary(i => i.KGDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGD" /> fields for each CSV column header</returns>
        protected override Action<KGD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGDKEY":
                        mapper[i] = (e, v) => e.KGDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KGD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGD" /> items to added or update the base <see cref="KGD" /> items</param>
        /// <returns>A merged list of <see cref="KGD" /> items</returns>
        protected override List<KGD> ApplyDeltaItems(List<KGD> Items, List<KGD> DeltaItems)
        {
            Dictionary<string, int> Index_KGDKEY = Items.ToIndexDictionary(i => i.KGDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGD deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGDKEY.TryGetValue(deltaItem.KGDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGD>> Index_KGDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGD FindByKGDKEY(string KGDKEY)
        {
            return Index_KGDKEY.Value[KGDKEY];
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <param name="Value">Related KGD entity</param>
        /// <returns>True if the related KGD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGDKEY(string KGDKEY, out KGD Value)
        {
            return Index_KGDKEY.Value.TryGetValue(KGDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGD TryFindByKGDKEY(string KGDKEY)
        {
            KGD value;
            if (Index_KGDKEY.Value.TryGetValue(KGDKEY, out value))
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
        /// Returns SQL which checks for the existence of a KGD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGD](
        [KGDKEY] varchar(6) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [CATEGORY] varchar(50) NULL,
        [OPEN_CLOSED] varchar(1) NULL,
        CONSTRAINT [KGD_Index_KGDKEY] PRIMARY KEY CLUSTERED (
            [KGDKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGDDataReader : IDataReader, IDataRecord
        {
            private List<KGD> Items;
            private int CurrentIndex;
            private KGD CurrentItem;

            public KGDDataReader(List<KGD> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 4; } }
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
                    case 0: // KGDKEY
                        return CurrentItem.KGDKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // CATEGORY
                        return CurrentItem.CATEGORY;
                    case 3: // OPEN_CLOSED
                        return CurrentItem.OPEN_CLOSED;
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
                    case 2: // CATEGORY
                        return CurrentItem.CATEGORY == null;
                    case 3: // OPEN_CLOSED
                        return CurrentItem.OPEN_CLOSED == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGDKEY
                        return "KGDKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // CATEGORY
                        return "CATEGORY";
                    case 3: // OPEN_CLOSED
                        return "OPEN_CLOSED";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGDKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "CATEGORY":
                        return 2;
                    case "OPEN_CLOSED":
                        return 3;
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
