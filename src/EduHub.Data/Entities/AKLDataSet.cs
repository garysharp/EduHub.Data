using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKLDataSet : DataSetBase<AKL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKL"; } }

        internal AKLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<Dictionary<string, AKL>>(() => this.ToDictionary(i => i.LOCATION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKL" /> fields for each CSV column header</returns>
        protected override Action<AKL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ESTIMATE_UNITS":
                        mapper[i] = (e, v) => e.ESTIMATE_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS_TO_DATE":
                        mapper[i] = (e, v) => e.UNITS_TO_DATE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACUTOFF":
                        mapper[i] = (e, v) => e.ACUTOFF = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATEFU":
                        mapper[i] = (e, v) => e.DATEFU = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURDATE":
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
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
        /// Merges <see cref="AKL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKL" /> items to added or update the base <see cref="AKL" /> items</param>
        /// <returns>A merged list of <see cref="AKL" /> items</returns>
        protected override List<AKL> ApplyDeltaItems(List<AKL> Items, List<AKL> DeltaItems)
        {
            Dictionary<string, int> Index_LOCATION = Items.ToIndexDictionary(i => i.LOCATION);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKL deltaItem in DeltaItems)
            {
                int index;

                if (Index_LOCATION.TryGetValue(deltaItem.LOCATION, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.LOCATION)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKL>> Index_LOCATION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKL FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <param name="Value">Related AKL entity</param>
        /// <returns>True if the related AKL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out AKL Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKL TryFindByLOCATION(string LOCATION)
        {
            AKL value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
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
        /// Returns SQL which checks for the existence of a AKL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKL](
        [LOCATION] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ESTIMATE_UNITS] int NULL,
        [PERIOD_UNITS] int NULL,
        [UNITS_TO_DATE] int NULL,
        [ACUTOFF] smallint NULL,
        [DATEFU] datetime NULL,
        [PURDATE] datetime NULL,
        [AFLAG] varchar(1) NULL,
        [TFLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKL_Index_LOCATION] PRIMARY KEY CLUSTERED (
            [LOCATION] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new AKLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKLDataReader : IDataReader, IDataRecord
        {
            private List<AKL> Items;
            private int CurrentIndex;
            private AKL CurrentItem;

            public AKLDataReader(List<AKL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 13; } }
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
                    case 0: // LOCATION
                        return CurrentItem.LOCATION;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // ESTIMATE_UNITS
                        return CurrentItem.ESTIMATE_UNITS;
                    case 3: // PERIOD_UNITS
                        return CurrentItem.PERIOD_UNITS;
                    case 4: // UNITS_TO_DATE
                        return CurrentItem.UNITS_TO_DATE;
                    case 5: // ACUTOFF
                        return CurrentItem.ACUTOFF;
                    case 6: // DATEFU
                        return CurrentItem.DATEFU;
                    case 7: // PURDATE
                        return CurrentItem.PURDATE;
                    case 8: // AFLAG
                        return CurrentItem.AFLAG;
                    case 9: // TFLAG
                        return CurrentItem.TFLAG;
                    case 10: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 11: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 12: // LW_USER
                        return CurrentItem.LW_USER;
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
                    case 2: // ESTIMATE_UNITS
                        return CurrentItem.ESTIMATE_UNITS == null;
                    case 3: // PERIOD_UNITS
                        return CurrentItem.PERIOD_UNITS == null;
                    case 4: // UNITS_TO_DATE
                        return CurrentItem.UNITS_TO_DATE == null;
                    case 5: // ACUTOFF
                        return CurrentItem.ACUTOFF == null;
                    case 6: // DATEFU
                        return CurrentItem.DATEFU == null;
                    case 7: // PURDATE
                        return CurrentItem.PURDATE == null;
                    case 8: // AFLAG
                        return CurrentItem.AFLAG == null;
                    case 9: // TFLAG
                        return CurrentItem.TFLAG == null;
                    case 10: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 11: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 12: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // LOCATION
                        return "LOCATION";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ESTIMATE_UNITS
                        return "ESTIMATE_UNITS";
                    case 3: // PERIOD_UNITS
                        return "PERIOD_UNITS";
                    case 4: // UNITS_TO_DATE
                        return "UNITS_TO_DATE";
                    case 5: // ACUTOFF
                        return "ACUTOFF";
                    case 6: // DATEFU
                        return "DATEFU";
                    case 7: // PURDATE
                        return "PURDATE";
                    case 8: // AFLAG
                        return "AFLAG";
                    case 9: // TFLAG
                        return "TFLAG";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "LOCATION":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ESTIMATE_UNITS":
                        return 2;
                    case "PERIOD_UNITS":
                        return 3;
                    case "UNITS_TO_DATE":
                        return 4;
                    case "ACUTOFF":
                        return 5;
                    case "DATEFU":
                        return 6;
                    case "PURDATE":
                        return 7;
                    case "AFLAG":
                        return 8;
                    case "TFLAG":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
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
