using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Dates for Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCCDataSet : EduHubDataSet<KCC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCC"; } }

        internal KCCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CURRENT_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<KCC>>>(() => this.ToGroupedNullDictionary(i => i.CURRENT_QUILT));
            Index_KCCKEY = new Lazy<Dictionary<DateTime, KCC>>(() => this.ToDictionary(i => i.KCCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCC" /> fields for each CSV column header</returns>
        protected override Action<KCC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCCKEY":
                        mapper[i] = (e, v) => e.KCCKEY = DateTime.Parse(v);
                        break;
                    case "DAYTODAY":
                        mapper[i] = (e, v) => e.DAYTODAY = v;
                        break;
                    case "DAY_TYPE":
                        mapper[i] = (e, v) => e.DAY_TYPE = v;
                        break;
                    case "JULIAN":
                        mapper[i] = (e, v) => e.JULIAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_YEAR":
                        mapper[i] = (e, v) => e.DAY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_MONTH":
                        mapper[i] = (e, v) => e.DAY_MONTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERM":
                        mapper[i] = (e, v) => e.TERM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK":
                        mapper[i] = (e, v) => e.WEEK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_CYCLE":
                        mapper[i] = (e, v) => e.DAY_CYCLE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CURRENT_QUILT":
                        mapper[i] = (e, v) => e.CURRENT_QUILT = v;
                        break;
                    case "HALF_DAY_GENERATED":
                        mapper[i] = (e, v) => e.HALF_DAY_GENERATED = v;
                        break;
                    case "PERIOD_GENERATED":
                        mapper[i] = (e, v) => e.PERIOD_GENERATED = v;
                        break;
                    case "PAR_SOURCE":
                        mapper[i] = (e, v) => e.PAR_SOURCE = v;
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
        /// Merges <see cref="KCC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCC" /> items to added or update the base <see cref="KCC" /> items</param>
        /// <returns>A merged list of <see cref="KCC" /> items</returns>
        protected override List<KCC> ApplyDeltaItems(List<KCC> Items, List<KCC> DeltaItems)
        {
            Dictionary<DateTime, int> Index_KCCKEY = Items.ToIndexDictionary(i => i.KCCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCCKEY.TryGetValue(deltaItem.KCCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KCC>>> Index_CURRENT_QUILT;
        private Lazy<Dictionary<DateTime, KCC>> Index_KCCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <returns>List of related KCC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCC> FindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            return Index_CURRENT_QUILT.Value[CURRENT_QUILT];
        }

        /// <summary>
        /// Attempt to find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <param name="Value">List of related KCC entities</param>
        /// <returns>True if the list of related KCC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCURRENT_QUILT(string CURRENT_QUILT, out IReadOnlyList<KCC> Value)
        {
            return Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <returns>List of related KCC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCC> TryFindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            IReadOnlyList<KCC> value;
            if (Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCC FindByKCCKEY(DateTime KCCKEY)
        {
            return Index_KCCKEY.Value[KCCKEY];
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <param name="Value">Related KCC entity</param>
        /// <returns>True if the related KCC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCCKEY(DateTime KCCKEY, out KCC Value)
        {
            return Index_KCCKEY.Value.TryGetValue(KCCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCC TryFindByKCCKEY(DateTime KCCKEY)
        {
            KCC value;
            if (Index_KCCKEY.Value.TryGetValue(KCCKEY, out value))
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
        /// Returns SQL which checks for the existence of a KCC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCC](
        [KCCKEY] datetime NOT NULL,
        [DAYTODAY] varchar(10) NULL,
        [DAY_TYPE] varchar(1) NULL,
        [JULIAN] smallint NULL,
        [SEMESTER] smallint NULL,
        [DAY_YEAR] smallint NULL,
        [DAY_MONTH] smallint NULL,
        [TERM] smallint NULL,
        [WEEK] smallint NULL,
        [DAY_CYCLE] smallint NULL,
        [CURRENT_QUILT] varchar(8) NULL,
        [HALF_DAY_GENERATED] varchar(1) NULL,
        [PERIOD_GENERATED] varchar(1) NULL,
        [PAR_SOURCE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCC_Index_KCCKEY] PRIMARY KEY CLUSTERED (
            [KCCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCC_Index_CURRENT_QUILT] ON [dbo].[KCC]
    (
            [CURRENT_QUILT] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCCDataReader : IDataReader, IDataRecord
        {
            private List<KCC> Items;
            private int CurrentIndex;
            private KCC CurrentItem;

            public KCCDataReader(List<KCC> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 17; } }
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
                    case 0: // KCCKEY
                        return CurrentItem.KCCKEY;
                    case 1: // DAYTODAY
                        return CurrentItem.DAYTODAY;
                    case 2: // DAY_TYPE
                        return CurrentItem.DAY_TYPE;
                    case 3: // JULIAN
                        return CurrentItem.JULIAN;
                    case 4: // SEMESTER
                        return CurrentItem.SEMESTER;
                    case 5: // DAY_YEAR
                        return CurrentItem.DAY_YEAR;
                    case 6: // DAY_MONTH
                        return CurrentItem.DAY_MONTH;
                    case 7: // TERM
                        return CurrentItem.TERM;
                    case 8: // WEEK
                        return CurrentItem.WEEK;
                    case 9: // DAY_CYCLE
                        return CurrentItem.DAY_CYCLE;
                    case 10: // CURRENT_QUILT
                        return CurrentItem.CURRENT_QUILT;
                    case 11: // HALF_DAY_GENERATED
                        return CurrentItem.HALF_DAY_GENERATED;
                    case 12: // PERIOD_GENERATED
                        return CurrentItem.PERIOD_GENERATED;
                    case 13: // PAR_SOURCE
                        return CurrentItem.PAR_SOURCE;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DAYTODAY
                        return CurrentItem.DAYTODAY == null;
                    case 2: // DAY_TYPE
                        return CurrentItem.DAY_TYPE == null;
                    case 3: // JULIAN
                        return CurrentItem.JULIAN == null;
                    case 4: // SEMESTER
                        return CurrentItem.SEMESTER == null;
                    case 5: // DAY_YEAR
                        return CurrentItem.DAY_YEAR == null;
                    case 6: // DAY_MONTH
                        return CurrentItem.DAY_MONTH == null;
                    case 7: // TERM
                        return CurrentItem.TERM == null;
                    case 8: // WEEK
                        return CurrentItem.WEEK == null;
                    case 9: // DAY_CYCLE
                        return CurrentItem.DAY_CYCLE == null;
                    case 10: // CURRENT_QUILT
                        return CurrentItem.CURRENT_QUILT == null;
                    case 11: // HALF_DAY_GENERATED
                        return CurrentItem.HALF_DAY_GENERATED == null;
                    case 12: // PERIOD_GENERATED
                        return CurrentItem.PERIOD_GENERATED == null;
                    case 13: // PAR_SOURCE
                        return CurrentItem.PAR_SOURCE == null;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 16: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCCKEY
                        return "KCCKEY";
                    case 1: // DAYTODAY
                        return "DAYTODAY";
                    case 2: // DAY_TYPE
                        return "DAY_TYPE";
                    case 3: // JULIAN
                        return "JULIAN";
                    case 4: // SEMESTER
                        return "SEMESTER";
                    case 5: // DAY_YEAR
                        return "DAY_YEAR";
                    case 6: // DAY_MONTH
                        return "DAY_MONTH";
                    case 7: // TERM
                        return "TERM";
                    case 8: // WEEK
                        return "WEEK";
                    case 9: // DAY_CYCLE
                        return "DAY_CYCLE";
                    case 10: // CURRENT_QUILT
                        return "CURRENT_QUILT";
                    case 11: // HALF_DAY_GENERATED
                        return "HALF_DAY_GENERATED";
                    case 12: // PERIOD_GENERATED
                        return "PERIOD_GENERATED";
                    case 13: // PAR_SOURCE
                        return "PAR_SOURCE";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCCKEY":
                        return 0;
                    case "DAYTODAY":
                        return 1;
                    case "DAY_TYPE":
                        return 2;
                    case "JULIAN":
                        return 3;
                    case "SEMESTER":
                        return 4;
                    case "DAY_YEAR":
                        return 5;
                    case "DAY_MONTH":
                        return 6;
                    case "TERM":
                        return 7;
                    case "WEEK":
                        return 8;
                    case "DAY_CYCLE":
                        return 9;
                    case "CURRENT_QUILT":
                        return 10;
                    case "HALF_DAY_GENERATED":
                        return 11;
                    case "PERIOD_GENERATED":
                        return 12;
                    case "PAR_SOURCE":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
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
