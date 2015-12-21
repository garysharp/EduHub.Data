using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medicare Levy Parameters Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PMLDataSet : EduHubDataSet<PML>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PML"; } }

        internal PMLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCALE = new Lazy<Dictionary<short, PML>>(() => this.ToDictionary(i => i.SCALE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PML" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PML" /> fields for each CSV column header</returns>
        protected override Action<PML, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PML, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCALE":
                        mapper[i] = (e, v) => e.SCALE = short.Parse(v);
                        break;
                    case "WEEKLY_EARNING_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_EARNING_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_SHADEIN_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_SHADEIN_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MEDLEVY_FAMILY_THRESHOLD":
                        mapper[i] = (e, v) => e.MEDLEVY_FAMILY_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WFT_DIVISOR":
                        mapper[i] = (e, v) => e.WFT_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ADDITIONAL_CHILD":
                        mapper[i] = (e, v) => e.ADDITIONAL_CHILD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SOP_MULTIPLIER":
                        mapper[i] = (e, v) => e.SOP_MULTIPLIER = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SOP_DIVISOR":
                        mapper[i] = (e, v) => e.SOP_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "WLA_FALCTOR":
                        mapper[i] = (e, v) => e.WLA_FALCTOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MEDICARE_LEVY":
                        mapper[i] = (e, v) => e.MEDICARE_LEVY = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="PML" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PML" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PML" /> items to added or update the base <see cref="PML" /> items</param>
        /// <returns>A merged list of <see cref="PML" /> items</returns>
        protected override List<PML> ApplyDeltaItems(List<PML> Items, List<PML> DeltaItems)
        {
            Dictionary<short, int> Index_SCALE = Items.ToIndexDictionary(i => i.SCALE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PML deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCALE.TryGetValue(deltaItem.SCALE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCALE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, PML>> Index_SCALE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <returns>Related PML entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML FindBySCALE(short SCALE)
        {
            return Index_SCALE.Value[SCALE];
        }

        /// <summary>
        /// Attempt to find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <param name="Value">Related PML entity</param>
        /// <returns>True if the related PML entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCALE(short SCALE, out PML Value)
        {
            return Index_SCALE.Value.TryGetValue(SCALE, out Value);
        }

        /// <summary>
        /// Attempt to find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <returns>Related PML entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML TryFindBySCALE(short SCALE)
        {
            PML value;
            if (Index_SCALE.Value.TryGetValue(SCALE, out value))
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
        /// Returns SQL which checks for the existence of a PML table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PML]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PML](
        [SCALE] smallint NOT NULL,
        [WEEKLY_EARNING_THRESHOLD] money NULL,
        [WEEKLY_SHADEIN_THRESHOLD] money NULL,
        [MEDLEVY_FAMILY_THRESHOLD] money NULL,
        [WFT_DIVISOR] float NULL,
        [ADDITIONAL_CHILD] money NULL,
        [SOP_MULTIPLIER] float NULL,
        [SOP_DIVISOR] float NULL,
        [WLA_FALCTOR] float NULL,
        [MEDICARE_LEVY] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PML_Index_SCALE] PRIMARY KEY CLUSTERED (
            [SCALE] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PML data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PML data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PMLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PMLDataReader : IDataReader, IDataRecord
        {
            private List<PML> Items;
            private int CurrentIndex;
            private PML CurrentItem;

            public PMLDataReader(List<PML> Items)
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
                    case 0: // SCALE
                        return CurrentItem.SCALE;
                    case 1: // WEEKLY_EARNING_THRESHOLD
                        return CurrentItem.WEEKLY_EARNING_THRESHOLD;
                    case 2: // WEEKLY_SHADEIN_THRESHOLD
                        return CurrentItem.WEEKLY_SHADEIN_THRESHOLD;
                    case 3: // MEDLEVY_FAMILY_THRESHOLD
                        return CurrentItem.MEDLEVY_FAMILY_THRESHOLD;
                    case 4: // WFT_DIVISOR
                        return CurrentItem.WFT_DIVISOR;
                    case 5: // ADDITIONAL_CHILD
                        return CurrentItem.ADDITIONAL_CHILD;
                    case 6: // SOP_MULTIPLIER
                        return CurrentItem.SOP_MULTIPLIER;
                    case 7: // SOP_DIVISOR
                        return CurrentItem.SOP_DIVISOR;
                    case 8: // WLA_FALCTOR
                        return CurrentItem.WLA_FALCTOR;
                    case 9: // MEDICARE_LEVY
                        return CurrentItem.MEDICARE_LEVY;
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
                    case 1: // WEEKLY_EARNING_THRESHOLD
                        return CurrentItem.WEEKLY_EARNING_THRESHOLD == null;
                    case 2: // WEEKLY_SHADEIN_THRESHOLD
                        return CurrentItem.WEEKLY_SHADEIN_THRESHOLD == null;
                    case 3: // MEDLEVY_FAMILY_THRESHOLD
                        return CurrentItem.MEDLEVY_FAMILY_THRESHOLD == null;
                    case 4: // WFT_DIVISOR
                        return CurrentItem.WFT_DIVISOR == null;
                    case 5: // ADDITIONAL_CHILD
                        return CurrentItem.ADDITIONAL_CHILD == null;
                    case 6: // SOP_MULTIPLIER
                        return CurrentItem.SOP_MULTIPLIER == null;
                    case 7: // SOP_DIVISOR
                        return CurrentItem.SOP_DIVISOR == null;
                    case 8: // WLA_FALCTOR
                        return CurrentItem.WLA_FALCTOR == null;
                    case 9: // MEDICARE_LEVY
                        return CurrentItem.MEDICARE_LEVY == null;
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
                    case 0: // SCALE
                        return "SCALE";
                    case 1: // WEEKLY_EARNING_THRESHOLD
                        return "WEEKLY_EARNING_THRESHOLD";
                    case 2: // WEEKLY_SHADEIN_THRESHOLD
                        return "WEEKLY_SHADEIN_THRESHOLD";
                    case 3: // MEDLEVY_FAMILY_THRESHOLD
                        return "MEDLEVY_FAMILY_THRESHOLD";
                    case 4: // WFT_DIVISOR
                        return "WFT_DIVISOR";
                    case 5: // ADDITIONAL_CHILD
                        return "ADDITIONAL_CHILD";
                    case 6: // SOP_MULTIPLIER
                        return "SOP_MULTIPLIER";
                    case 7: // SOP_DIVISOR
                        return "SOP_DIVISOR";
                    case 8: // WLA_FALCTOR
                        return "WLA_FALCTOR";
                    case 9: // MEDICARE_LEVY
                        return "MEDICARE_LEVY";
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
                    case "SCALE":
                        return 0;
                    case "WEEKLY_EARNING_THRESHOLD":
                        return 1;
                    case "WEEKLY_SHADEIN_THRESHOLD":
                        return 2;
                    case "MEDLEVY_FAMILY_THRESHOLD":
                        return 3;
                    case "WFT_DIVISOR":
                        return 4;
                    case "ADDITIONAL_CHILD":
                        return 5;
                    case "SOP_MULTIPLIER":
                        return 6;
                    case "SOP_DIVISOR":
                        return 7;
                    case "WLA_FALCTOR":
                        return 8;
                    case "MEDICARE_LEVY":
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
