using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTESDataSet : DataSetBase<TTES>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTES"; } }

        internal TTESDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTES>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TTES>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_TID = new Lazy<Dictionary<int, TTES>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTES" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTES" /> fields for each CSV column header</returns>
        protected override Action<TTES, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTES, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEI_TID":
                        mapper[i] = (e, v) => e.TTEI_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "UNITS":
                        mapper[i] = (e, v) => e.UNITS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INCLUDE01":
                        mapper[i] = (e, v) => e.INCLUDE01 = v;
                        break;
                    case "INCLUDE02":
                        mapper[i] = (e, v) => e.INCLUDE02 = v;
                        break;
                    case "INCLUDE03":
                        mapper[i] = (e, v) => e.INCLUDE03 = v;
                        break;
                    case "INCLUDE04":
                        mapper[i] = (e, v) => e.INCLUDE04 = v;
                        break;
                    case "INCLUDE05":
                        mapper[i] = (e, v) => e.INCLUDE05 = v;
                        break;
                    case "INCLUDE06":
                        mapper[i] = (e, v) => e.INCLUDE06 = v;
                        break;
                    case "INCLUDE07":
                        mapper[i] = (e, v) => e.INCLUDE07 = v;
                        break;
                    case "INCLUDE08":
                        mapper[i] = (e, v) => e.INCLUDE08 = v;
                        break;
                    case "INCLUDE09":
                        mapper[i] = (e, v) => e.INCLUDE09 = v;
                        break;
                    case "INCLUDE10":
                        mapper[i] = (e, v) => e.INCLUDE10 = v;
                        break;
                    case "INCLUDE11":
                        mapper[i] = (e, v) => e.INCLUDE11 = v;
                        break;
                    case "INCLUDE12":
                        mapper[i] = (e, v) => e.INCLUDE12 = v;
                        break;
                    case "INCLUDE13":
                        mapper[i] = (e, v) => e.INCLUDE13 = v;
                        break;
                    case "INCLUDE14":
                        mapper[i] = (e, v) => e.INCLUDE14 = v;
                        break;
                    case "INCLUDE15":
                        mapper[i] = (e, v) => e.INCLUDE15 = v;
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
        /// Merges <see cref="TTES" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TTES" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TTES" /> items to added or update the base <see cref="TTES" /> items</param>
        /// <returns>A merged list of <see cref="TTES" /> items</returns>
        protected override List<TTES> ApplyDeltaItems(List<TTES> Items, List<TTES> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TTES deltaItem in DeltaItems)
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
                .OrderBy(i => i.GKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<TTES>>> Index_GKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TTES>>> Index_SUBJ;
        private Lazy<Dictionary<int, TTES>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTES by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTES</param>
        /// <returns>List of related TTES entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTES by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTES</param>
        /// <param name="Value">List of related TTES entities</param>
        /// <returns>True if the list of related TTES entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTES> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTES by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTES</param>
        /// <returns>List of related TTES entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTES> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTES by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTES</param>
        /// <returns>List of related TTES entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TTES by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTES</param>
        /// <param name="Value">List of related TTES entities</param>
        /// <returns>True if the list of related TTES entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TTES> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TTES by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTES</param>
        /// <returns>List of related TTES entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TTES> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTES by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTES</param>
        /// <returns>Related TTES entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTES FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTES by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTES</param>
        /// <param name="Value">Related TTES entity</param>
        /// <returns>True if the related TTES entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTES Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTES by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTES</param>
        /// <returns>Related TTES entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTES TryFindByTID(int TID)
        {
            TTES value;
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
        /// Returns SQL which checks for the existence of a TTES table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTES]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTES](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTEI_TID] int NULL,
        [SUBJ] varchar(5) NULL,
        [UNITS] smallint NULL,
        [INCLUDE01] varchar(1) NULL,
        [INCLUDE02] varchar(1) NULL,
        [INCLUDE03] varchar(1) NULL,
        [INCLUDE04] varchar(1) NULL,
        [INCLUDE05] varchar(1) NULL,
        [INCLUDE06] varchar(1) NULL,
        [INCLUDE07] varchar(1) NULL,
        [INCLUDE08] varchar(1) NULL,
        [INCLUDE09] varchar(1) NULL,
        [INCLUDE10] varchar(1) NULL,
        [INCLUDE11] varchar(1) NULL,
        [INCLUDE12] varchar(1) NULL,
        [INCLUDE13] varchar(1) NULL,
        [INCLUDE14] varchar(1) NULL,
        [INCLUDE15] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTES_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTES_Index_GKEY] ON [dbo].[TTES]
    (
            [GKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TTES_Index_SUBJ] ON [dbo].[TTES]
    (
            [SUBJ] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTES data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTES data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TTESDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTESDataReader : IDataReader, IDataRecord
        {
            private List<TTES> Items;
            private int CurrentIndex;
            private TTES CurrentItem;

            public TTESDataReader(List<TTES> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 23; } }
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
                    case 1: // GKEY
                        return CurrentItem.GKEY;
                    case 2: // TTEI_TID
                        return CurrentItem.TTEI_TID;
                    case 3: // SUBJ
                        return CurrentItem.SUBJ;
                    case 4: // UNITS
                        return CurrentItem.UNITS;
                    case 5: // INCLUDE01
                        return CurrentItem.INCLUDE01;
                    case 6: // INCLUDE02
                        return CurrentItem.INCLUDE02;
                    case 7: // INCLUDE03
                        return CurrentItem.INCLUDE03;
                    case 8: // INCLUDE04
                        return CurrentItem.INCLUDE04;
                    case 9: // INCLUDE05
                        return CurrentItem.INCLUDE05;
                    case 10: // INCLUDE06
                        return CurrentItem.INCLUDE06;
                    case 11: // INCLUDE07
                        return CurrentItem.INCLUDE07;
                    case 12: // INCLUDE08
                        return CurrentItem.INCLUDE08;
                    case 13: // INCLUDE09
                        return CurrentItem.INCLUDE09;
                    case 14: // INCLUDE10
                        return CurrentItem.INCLUDE10;
                    case 15: // INCLUDE11
                        return CurrentItem.INCLUDE11;
                    case 16: // INCLUDE12
                        return CurrentItem.INCLUDE12;
                    case 17: // INCLUDE13
                        return CurrentItem.INCLUDE13;
                    case 18: // INCLUDE14
                        return CurrentItem.INCLUDE14;
                    case 19: // INCLUDE15
                        return CurrentItem.INCLUDE15;
                    case 20: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 21: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 22: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TTEI_TID
                        return CurrentItem.TTEI_TID == null;
                    case 3: // SUBJ
                        return CurrentItem.SUBJ == null;
                    case 4: // UNITS
                        return CurrentItem.UNITS == null;
                    case 5: // INCLUDE01
                        return CurrentItem.INCLUDE01 == null;
                    case 6: // INCLUDE02
                        return CurrentItem.INCLUDE02 == null;
                    case 7: // INCLUDE03
                        return CurrentItem.INCLUDE03 == null;
                    case 8: // INCLUDE04
                        return CurrentItem.INCLUDE04 == null;
                    case 9: // INCLUDE05
                        return CurrentItem.INCLUDE05 == null;
                    case 10: // INCLUDE06
                        return CurrentItem.INCLUDE06 == null;
                    case 11: // INCLUDE07
                        return CurrentItem.INCLUDE07 == null;
                    case 12: // INCLUDE08
                        return CurrentItem.INCLUDE08 == null;
                    case 13: // INCLUDE09
                        return CurrentItem.INCLUDE09 == null;
                    case 14: // INCLUDE10
                        return CurrentItem.INCLUDE10 == null;
                    case 15: // INCLUDE11
                        return CurrentItem.INCLUDE11 == null;
                    case 16: // INCLUDE12
                        return CurrentItem.INCLUDE12 == null;
                    case 17: // INCLUDE13
                        return CurrentItem.INCLUDE13 == null;
                    case 18: // INCLUDE14
                        return CurrentItem.INCLUDE14 == null;
                    case 19: // INCLUDE15
                        return CurrentItem.INCLUDE15 == null;
                    case 20: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 21: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 22: // LW_USER
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
                    case 1: // GKEY
                        return "GKEY";
                    case 2: // TTEI_TID
                        return "TTEI_TID";
                    case 3: // SUBJ
                        return "SUBJ";
                    case 4: // UNITS
                        return "UNITS";
                    case 5: // INCLUDE01
                        return "INCLUDE01";
                    case 6: // INCLUDE02
                        return "INCLUDE02";
                    case 7: // INCLUDE03
                        return "INCLUDE03";
                    case 8: // INCLUDE04
                        return "INCLUDE04";
                    case 9: // INCLUDE05
                        return "INCLUDE05";
                    case 10: // INCLUDE06
                        return "INCLUDE06";
                    case 11: // INCLUDE07
                        return "INCLUDE07";
                    case 12: // INCLUDE08
                        return "INCLUDE08";
                    case 13: // INCLUDE09
                        return "INCLUDE09";
                    case 14: // INCLUDE10
                        return "INCLUDE10";
                    case 15: // INCLUDE11
                        return "INCLUDE11";
                    case 16: // INCLUDE12
                        return "INCLUDE12";
                    case 17: // INCLUDE13
                        return "INCLUDE13";
                    case 18: // INCLUDE14
                        return "INCLUDE14";
                    case 19: // INCLUDE15
                        return "INCLUDE15";
                    case 20: // LW_DATE
                        return "LW_DATE";
                    case 21: // LW_TIME
                        return "LW_TIME";
                    case 22: // LW_USER
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
                    case "GKEY":
                        return 1;
                    case "TTEI_TID":
                        return 2;
                    case "SUBJ":
                        return 3;
                    case "UNITS":
                        return 4;
                    case "INCLUDE01":
                        return 5;
                    case "INCLUDE02":
                        return 6;
                    case "INCLUDE03":
                        return 7;
                    case "INCLUDE04":
                        return 8;
                    case "INCLUDE05":
                        return 9;
                    case "INCLUDE06":
                        return 10;
                    case "INCLUDE07":
                        return 11;
                    case "INCLUDE08":
                        return 12;
                    case "INCLUDE09":
                        return 13;
                    case "INCLUDE10":
                        return 14;
                    case "INCLUDE11":
                        return 15;
                    case "INCLUDE12":
                        return 16;
                    case "INCLUDE13":
                        return 17;
                    case "INCLUDE14":
                        return 18;
                    case "INCLUDE15":
                        return 19;
                    case "LW_DATE":
                        return 20;
                    case "LW_TIME":
                        return 21;
                    case "LW_USER":
                        return 22;
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
