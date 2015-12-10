using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTIEDataSet : DataSetBase<KTIE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTIE"; } }

        internal KTIEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RECORD_ID = new Lazy<Dictionary<int, KTIE>>(() => this.ToDictionary(i => i.RECORD_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTIE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTIE" /> fields for each CSV column header</returns>
        protected override Action<KTIE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTIE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RECORD_ID":
                        mapper[i] = (e, v) => e.RECORD_ID = int.Parse(v);
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KTIE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KTIE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KTIE" /> items to added or update the base <see cref="KTIE" /> items</param>
        /// <returns>A merged list of <see cref="KTIE" /> items</returns>
        protected override List<KTIE> ApplyDeltaItems(List<KTIE> Items, List<KTIE> DeltaItems)
        {
            Dictionary<int, int> Index_RECORD_ID = Items.ToIndexDictionary(i => i.RECORD_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KTIE deltaItem in DeltaItems)
            {
                int index;

                if (Index_RECORD_ID.TryGetValue(deltaItem.RECORD_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.RECORD_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KTIE>> Index_RECORD_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTIE FindByRECORD_ID(int RECORD_ID)
        {
            return Index_RECORD_ID.Value[RECORD_ID];
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <param name="Value">Related KTIE entity</param>
        /// <returns>True if the related KTIE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRECORD_ID(int RECORD_ID, out KTIE Value)
        {
            return Index_RECORD_ID.Value.TryGetValue(RECORD_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTIE TryFindByRECORD_ID(int RECORD_ID)
        {
            KTIE value;
            if (Index_RECORD_ID.Value.TryGetValue(RECORD_ID, out value))
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
        /// Returns SQL which checks for the existence of a KTIE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KTIE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KTIE](
        [RECORD_ID] int IDENTITY NOT NULL,
        [ENTITY] varchar(2) NULL,
        [ENTITY_KEY] varchar(20) NULL,
        [ERROR_TEXT] varchar(60) NULL,
        CONSTRAINT [KTIE_Index_RECORD_ID] PRIMARY KEY CLUSTERED (
            [RECORD_ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTIE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTIE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KTIEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KTIEDataReader : IDataReader, IDataRecord
        {
            private List<KTIE> Items;
            private int CurrentIndex;
            private KTIE CurrentItem;

            public KTIEDataReader(List<KTIE> Items)
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
                    case 0: // RECORD_ID
                        return CurrentItem.RECORD_ID;
                    case 1: // ENTITY
                        return CurrentItem.ENTITY;
                    case 2: // ENTITY_KEY
                        return CurrentItem.ENTITY_KEY;
                    case 3: // ERROR_TEXT
                        return CurrentItem.ERROR_TEXT;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ENTITY
                        return CurrentItem.ENTITY == null;
                    case 2: // ENTITY_KEY
                        return CurrentItem.ENTITY_KEY == null;
                    case 3: // ERROR_TEXT
                        return CurrentItem.ERROR_TEXT == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // RECORD_ID
                        return "RECORD_ID";
                    case 1: // ENTITY
                        return "ENTITY";
                    case 2: // ENTITY_KEY
                        return "ENTITY_KEY";
                    case 3: // ERROR_TEXT
                        return "ERROR_TEXT";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "RECORD_ID":
                        return 0;
                    case "ENTITY":
                        return 1;
                    case "ENTITY_KEY":
                        return 2;
                    case "ERROR_TEXT":
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
