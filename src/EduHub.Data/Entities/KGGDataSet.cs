using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGGDataSet : EduHubDataSet<KGG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGG"; } }

        internal KGGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGGKEY = new Lazy<Dictionary<string, KGG>>(() => this.ToDictionary(i => i.KGGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGG" /> fields for each CSV column header</returns>
        protected override Action<KGG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGGKEY":
                        mapper[i] = (e, v) => e.KGGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "EDFLAG_ORDER":
                        mapper[i] = (e, v) => e.EDFLAG_ORDER = v;
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
        /// Merges <see cref="KGG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGG" /> items to added or update the base <see cref="KGG" /> items</param>
        /// <returns>A merged list of <see cref="KGG" /> items</returns>
        protected override List<KGG> ApplyDeltaItems(List<KGG> Items, List<KGG> DeltaItems)
        {
            Dictionary<string, int> Index_KGGKEY = Items.ToIndexDictionary(i => i.KGGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGG deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGGKEY.TryGetValue(deltaItem.KGGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGG>> Index_KGGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGG FindByKGGKEY(string KGGKEY)
        {
            return Index_KGGKEY.Value[KGGKEY];
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <param name="Value">Related KGG entity</param>
        /// <returns>True if the related KGG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGGKEY(string KGGKEY, out KGG Value)
        {
            return Index_KGGKEY.Value.TryGetValue(KGGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGG TryFindByKGGKEY(string KGGKEY)
        {
            KGG value;
            if (Index_KGGKEY.Value.TryGetValue(KGGKEY, out value))
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
        /// Returns SQL which checks for the existence of a KGG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGG](
        [KGGKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [EDFLAG_ORDER] varchar(2) NULL,
        [OPEN_CLOSED] varchar(1) NULL,
        CONSTRAINT [KGG_Index_KGGKEY] PRIMARY KEY CLUSTERED (
            [KGGKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGGDataReader : IDataReader, IDataRecord
        {
            private List<KGG> Items;
            private int CurrentIndex;
            private KGG CurrentItem;

            public KGGDataReader(List<KGG> Items)
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
                    case 0: // KGGKEY
                        return CurrentItem.KGGKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // EDFLAG_ORDER
                        return CurrentItem.EDFLAG_ORDER;
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
                    case 2: // EDFLAG_ORDER
                        return CurrentItem.EDFLAG_ORDER == null;
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
                    case 0: // KGGKEY
                        return "KGGKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // EDFLAG_ORDER
                        return "EDFLAG_ORDER";
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
                    case "KGGKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "EDFLAG_ORDER":
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
