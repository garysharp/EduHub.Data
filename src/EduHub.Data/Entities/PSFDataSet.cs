using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Pay Steps or Pay Class Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSFDataSet : EduHubDataSet<PSF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PSF"; } }

        internal PSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSKEY = new Lazy<Dictionary<short, IReadOnlyList<PSF>>>(() => this.ToGroupedDictionary(i => i.PSKEY));
            Index_TID = new Lazy<Dictionary<int, PSF>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSF" /> fields for each CSV column header</returns>
        protected override Action<PSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "EFFECTIVE_FROM_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EFFECTIVE_TO_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="PSF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PSF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PSF" /> items to added or update the base <see cref="PSF" /> items</param>
        /// <returns>A merged list of <see cref="PSF" /> items</returns>
        protected override List<PSF> ApplyDeltaItems(List<PSF> Items, List<PSF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PSF deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, IReadOnlyList<PSF>>> Index_PSKEY;
        private Lazy<Dictionary<int, PSF>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <returns>List of related PSF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PSF> FindByPSKEY(short PSKEY)
        {
            return Index_PSKEY.Value[PSKEY];
        }

        /// <summary>
        /// Attempt to find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <param name="Value">List of related PSF entities</param>
        /// <returns>True if the list of related PSF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSKEY(short PSKEY, out IReadOnlyList<PSF> Value)
        {
            return Index_PSKEY.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <returns>List of related PSF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PSF> TryFindByPSKEY(short PSKEY)
        {
            IReadOnlyList<PSF> value;
            if (Index_PSKEY.Value.TryGetValue(PSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <returns>Related PSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <param name="Value">Related PSF entity</param>
        /// <returns>True if the related PSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PSF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <returns>Related PSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSF TryFindByTID(int TID)
        {
            PSF value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns SQL which checks for the existence of a PSF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PSF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PSF](
        [TID] int IDENTITY NOT NULL,
        [PSKEY] smallint NOT NULL,
        [EFFECTIVE_FROM_DATE] datetime NULL,
        [EFFECTIVE_TO_DATE] datetime NULL,
        [ANNUAL_RATE] money NULL,
        [HOURLY_RATE] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PSF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PSF_Index_PSKEY] ON [dbo].[PSF]
    (
            [PSKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PSF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PSFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PSFDataReader : IDataReader, IDataRecord
        {
            private List<PSF> Items;
            private int CurrentIndex;
            private PSF CurrentItem;

            public PSFDataReader(List<PSF> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 9; } }
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // PSKEY
                        return CurrentItem.PSKEY;
                    case 2: // EFFECTIVE_FROM_DATE
                        return CurrentItem.EFFECTIVE_FROM_DATE;
                    case 3: // EFFECTIVE_TO_DATE
                        return CurrentItem.EFFECTIVE_TO_DATE;
                    case 4: // ANNUAL_RATE
                        return CurrentItem.ANNUAL_RATE;
                    case 5: // HOURLY_RATE
                        return CurrentItem.HOURLY_RATE;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // EFFECTIVE_FROM_DATE
                        return CurrentItem.EFFECTIVE_FROM_DATE == null;
                    case 3: // EFFECTIVE_TO_DATE
                        return CurrentItem.EFFECTIVE_TO_DATE == null;
                    case 4: // ANNUAL_RATE
                        return CurrentItem.ANNUAL_RATE == null;
                    case 5: // HOURLY_RATE
                        return CurrentItem.HOURLY_RATE == null;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // PSKEY
                        return "PSKEY";
                    case 2: // EFFECTIVE_FROM_DATE
                        return "EFFECTIVE_FROM_DATE";
                    case 3: // EFFECTIVE_TO_DATE
                        return "EFFECTIVE_TO_DATE";
                    case 4: // ANNUAL_RATE
                        return "ANNUAL_RATE";
                    case 5: // HOURLY_RATE
                        return "HOURLY_RATE";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "PSKEY":
                        return 1;
                    case "EFFECTIVE_FROM_DATE":
                        return 2;
                    case "EFFECTIVE_TO_DATE":
                        return 3;
                    case "ANNUAL_RATE":
                        return 4;
                    case "HOURLY_RATE":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
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
