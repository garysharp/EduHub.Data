using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FTE Student Retentions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SRAGDataSet : EduHubDataSet<SRAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SRAG"; } }

        internal SRAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SRAG_ID = new Lazy<Dictionary<int, SRAG>>(() => this.ToDictionary(i => i.SRAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SRAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SRAG" /> fields for each CSV column header</returns>
        protected override Action<SRAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SRAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SRAG_ID":
                        mapper[i] = (e, v) => e.SRAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "RETENTION":
                        mapper[i] = (e, v) => e.RETENTION = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SRAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SRAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SRAG" /> items to added or update the base <see cref="SRAG" /> items</param>
        /// <returns>A merged list of <see cref="SRAG" /> items</returns>
        protected override List<SRAG> ApplyDeltaItems(List<SRAG> Items, List<SRAG> DeltaItems)
        {
            Dictionary<int, int> Index_SRAG_ID = Items.ToIndexDictionary(i => i.SRAG_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SRAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SRAG_ID.TryGetValue(deltaItem.SRAG_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SRAG_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SRAG>> Index_SRAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SRAG FindBySRAG_ID(int SRAG_ID)
        {
            return Index_SRAG_ID.Value[SRAG_ID];
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <param name="Value">Related SRAG entity</param>
        /// <returns>True if the related SRAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySRAG_ID(int SRAG_ID, out SRAG Value)
        {
            return Index_SRAG_ID.Value.TryGetValue(SRAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SRAG TryFindBySRAG_ID(int SRAG_ID)
        {
            SRAG value;
            if (Index_SRAG_ID.Value.TryGetValue(SRAG_ID, out value))
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
        /// Returns SQL which checks for the existence of a SRAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SRAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SRAG](
        [SRAG_ID] int IDENTITY NOT NULL,
        [BRY] smallint NULL,
        [PERIOD] varchar(20) NULL,
        [RETENTION] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SRAG_Index_SRAG_ID] PRIMARY KEY CLUSTERED (
            [SRAG_ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SRAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SRAG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SRAGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SRAGDataReader : IDataReader, IDataRecord
        {
            private List<SRAG> Items;
            private int CurrentIndex;
            private SRAG CurrentItem;

            public SRAGDataReader(List<SRAG> Items)
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
                    case 0: // SRAG_ID
                        return CurrentItem.SRAG_ID;
                    case 1: // BRY
                        return CurrentItem.BRY;
                    case 2: // PERIOD
                        return CurrentItem.PERIOD;
                    case 3: // RETENTION
                        return CurrentItem.RETENTION;
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
                    case 1: // BRY
                        return CurrentItem.BRY == null;
                    case 2: // PERIOD
                        return CurrentItem.PERIOD == null;
                    case 3: // RETENTION
                        return CurrentItem.RETENTION == null;
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
                    case 0: // SRAG_ID
                        return "SRAG_ID";
                    case 1: // BRY
                        return "BRY";
                    case 2: // PERIOD
                        return "PERIOD";
                    case 3: // RETENTION
                        return "RETENTION";
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
                    case "SRAG_ID":
                        return 0;
                    case "BRY":
                        return 1;
                    case "PERIOD":
                        return 2;
                    case "RETENTION":
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
