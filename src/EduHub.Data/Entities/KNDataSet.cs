using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Notes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNDataSet : DataSetBase<KN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KN"; } }

        internal KNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_NOTE_ID = new Lazy<Dictionary<string, KN>>(() => this.ToDictionary(i => i.NOTE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KN" /> fields for each CSV column header</returns>
        protected override Action<KN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "NOTE_ID":
                        mapper[i] = (e, v) => e.NOTE_ID = v;
                        break;
                    case "CONTENTS":
                        mapper[i] = (e, v) => e.CONTENTS = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
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
        /// Merges <see cref="KN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KN" /> items to added or update the base <see cref="KN" /> items</param>
        /// <returns>A merged list of <see cref="KN" /> items</returns>
        protected override List<KN> ApplyDeltaItems(List<KN> Items, List<KN> DeltaItems)
        {
            Dictionary<string, int> Index_NOTE_ID = Items.ToIndexDictionary(i => i.NOTE_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KN deltaItem in DeltaItems)
            {
                int index;

                if (Index_NOTE_ID.TryGetValue(deltaItem.NOTE_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.NOTE_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KN>> Index_NOTE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KN FindByNOTE_ID(string NOTE_ID)
        {
            return Index_NOTE_ID.Value[NOTE_ID];
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <param name="Value">Related KN entity</param>
        /// <returns>True if the related KN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNOTE_ID(string NOTE_ID, out KN Value)
        {
            return Index_NOTE_ID.Value.TryGetValue(NOTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KN TryFindByNOTE_ID(string NOTE_ID)
        {
            KN value;
            if (Index_NOTE_ID.Value.TryGetValue(NOTE_ID, out value))
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
        /// Returns SQL which checks for the existence of a KN table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KN](
        [NOTE_ID] varchar(4) NOT NULL,
        [CONTENTS] text NULL,
        [ACTIVE] varchar(1) NULL,
        [SCOPE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KN_Index_NOTE_ID] PRIMARY KEY CLUSTERED (
            [NOTE_ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KN data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KNDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KNDataReader : IDataReader, IDataRecord
        {
            private List<KN> Items;
            private int CurrentIndex;
            private KN CurrentItem;

            public KNDataReader(List<KN> Items)
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
                    case 0: // NOTE_ID
                        return CurrentItem.NOTE_ID;
                    case 1: // CONTENTS
                        return CurrentItem.CONTENTS;
                    case 2: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 3: // SCOPE
                        return CurrentItem.SCOPE;
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
                    case 1: // CONTENTS
                        return CurrentItem.CONTENTS == null;
                    case 2: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 3: // SCOPE
                        return CurrentItem.SCOPE == null;
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
                    case 0: // NOTE_ID
                        return "NOTE_ID";
                    case 1: // CONTENTS
                        return "CONTENTS";
                    case 2: // ACTIVE
                        return "ACTIVE";
                    case 3: // SCOPE
                        return "SCOPE";
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
                    case "NOTE_ID":
                        return 0;
                    case "CONTENTS":
                        return 1;
                    case "ACTIVE":
                        return 2;
                    case "SCOPE":
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
