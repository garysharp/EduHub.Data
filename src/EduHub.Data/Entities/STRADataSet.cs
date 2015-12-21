using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Multiple Day Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STRADataSet : EduHubDataSet<STRA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STRA"; } }

        internal STRADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<STRA>>>(() => this.ToGroupedNullDictionary(i => i.ABS_TYPE));
            Index_STKEY = new Lazy<Dictionary<string, IReadOnlyList<STRA>>>(() => this.ToGroupedDictionary(i => i.STKEY));
            Index_TID = new Lazy<Dictionary<int, STRA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STRA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STRA" /> fields for each CSV column header</returns>
        protected override Action<STRA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STRA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "START_AM_PM":
                        mapper[i] = (e, v) => e.START_AM_PM = v;
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_AM_PM":
                        mapper[i] = (e, v) => e.END_AM_PM = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "ABS_TYPE":
                        mapper[i] = (e, v) => e.ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v;
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
        /// Merges <see cref="STRA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STRA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STRA" /> items to added or update the base <see cref="STRA" /> items</param>
        /// <returns>A merged list of <see cref="STRA" /> items</returns>
        protected override List<STRA> ApplyDeltaItems(List<STRA> Items, List<STRA> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STRA deltaItem in DeltaItems)
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
                .OrderBy(i => i.STKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<short?, IReadOnlyList<STRA>>> Index_ABS_TYPE;
        private Lazy<Dictionary<string, IReadOnlyList<STRA>>> Index_STKEY;
        private Lazy<Dictionary<int, STRA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <returns>List of related STRA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> FindByABS_TYPE(short? ABS_TYPE)
        {
            return Index_ABS_TYPE.Value[ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <param name="Value">List of related STRA entities</param>
        /// <returns>True if the list of related STRA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABS_TYPE(short? ABS_TYPE, out IReadOnlyList<STRA> Value)
        {
            return Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <returns>List of related STRA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> TryFindByABS_TYPE(short? ABS_TYPE)
        {
            IReadOnlyList<STRA> value;
            if (Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <returns>List of related STRA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <param name="Value">List of related STRA entities</param>
        /// <returns>True if the list of related STRA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<STRA> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <returns>List of related STRA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<STRA> value;
            if (Index_STKEY.Value.TryGetValue(STKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <returns>Related STRA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <param name="Value">Related STRA entity</param>
        /// <returns>True if the related STRA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STRA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <returns>Related STRA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRA TryFindByTID(int TID)
        {
            STRA value;
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
        /// Returns SQL which checks for the existence of a STRA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STRA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STRA](
        [TID] int IDENTITY NOT NULL,
        [STKEY] varchar(10) NOT NULL,
        [START_DATE] datetime NULL,
        [START_AM_PM] varchar(1) NULL,
        [END_DATE] datetime NULL,
        [END_AM_PM] varchar(1) NULL,
        [COMMENTS] varchar(30) NULL,
        [ABS_TYPE] smallint NULL,
        [START_PERIOD] smallint NULL,
        [END_PERIOD] smallint NULL,
        [FREQUENCY] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STRA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STRA_Index_ABS_TYPE] ON [dbo].[STRA]
    (
            [ABS_TYPE] ASC
    );
    CREATE CLUSTERED INDEX [STRA_Index_STKEY] ON [dbo].[STRA]
    (
            [STKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STRA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STRA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STRADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STRADataReader : IDataReader, IDataRecord
        {
            private List<STRA> Items;
            private int CurrentIndex;
            private STRA CurrentItem;

            public STRADataReader(List<STRA> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 14; } }
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
                    case 1: // STKEY
                        return CurrentItem.STKEY;
                    case 2: // START_DATE
                        return CurrentItem.START_DATE;
                    case 3: // START_AM_PM
                        return CurrentItem.START_AM_PM;
                    case 4: // END_DATE
                        return CurrentItem.END_DATE;
                    case 5: // END_AM_PM
                        return CurrentItem.END_AM_PM;
                    case 6: // COMMENTS
                        return CurrentItem.COMMENTS;
                    case 7: // ABS_TYPE
                        return CurrentItem.ABS_TYPE;
                    case 8: // START_PERIOD
                        return CurrentItem.START_PERIOD;
                    case 9: // END_PERIOD
                        return CurrentItem.END_PERIOD;
                    case 10: // FREQUENCY
                        return CurrentItem.FREQUENCY;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 13: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 3: // START_AM_PM
                        return CurrentItem.START_AM_PM == null;
                    case 4: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 5: // END_AM_PM
                        return CurrentItem.END_AM_PM == null;
                    case 6: // COMMENTS
                        return CurrentItem.COMMENTS == null;
                    case 7: // ABS_TYPE
                        return CurrentItem.ABS_TYPE == null;
                    case 8: // START_PERIOD
                        return CurrentItem.START_PERIOD == null;
                    case 9: // END_PERIOD
                        return CurrentItem.END_PERIOD == null;
                    case 10: // FREQUENCY
                        return CurrentItem.FREQUENCY == null;
                    case 11: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 12: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 13: // LW_USER
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
                    case 1: // STKEY
                        return "STKEY";
                    case 2: // START_DATE
                        return "START_DATE";
                    case 3: // START_AM_PM
                        return "START_AM_PM";
                    case 4: // END_DATE
                        return "END_DATE";
                    case 5: // END_AM_PM
                        return "END_AM_PM";
                    case 6: // COMMENTS
                        return "COMMENTS";
                    case 7: // ABS_TYPE
                        return "ABS_TYPE";
                    case 8: // START_PERIOD
                        return "START_PERIOD";
                    case 9: // END_PERIOD
                        return "END_PERIOD";
                    case 10: // FREQUENCY
                        return "FREQUENCY";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
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
                    case "STKEY":
                        return 1;
                    case "START_DATE":
                        return 2;
                    case "START_AM_PM":
                        return 3;
                    case "END_DATE":
                        return 4;
                    case "END_AM_PM":
                        return 5;
                    case "COMMENTS":
                        return 6;
                    case "ABS_TYPE":
                        return 7;
                    case "START_PERIOD":
                        return 8;
                    case "END_PERIOD":
                        return 9;
                    case "FREQUENCY":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
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
