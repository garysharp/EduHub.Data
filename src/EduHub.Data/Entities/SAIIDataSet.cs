using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvement Injuries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIIDataSet : DataSetBase<SAII>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAII"; } }

        internal SAIIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INVOLVEMENTID = new Lazy<Dictionary<int, IReadOnlyList<SAII>>>(() => this.ToGroupedDictionary(i => i.INVOLVEMENTID));
            Index_TID = new Lazy<Dictionary<int, SAII>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAII" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAII" /> fields for each CSV column header</returns>
        protected override Action<SAII, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAII, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = int.Parse(v);
                        break;
                    case "SEVERITY":
                        mapper[i] = (e, v) => e.SEVERITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SRI_TYPE":
                        mapper[i] = (e, v) => e.SRI_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NATURE":
                        mapper[i] = (e, v) => e.NATURE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_INFO":
                        mapper[i] = (e, v) => e.OTHER_INFO = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SAII" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAII" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAII" /> items to added or update the base <see cref="SAII" /> items</param>
        /// <returns>A merged list of <see cref="SAII" /> items</returns>
        protected override List<SAII> ApplyDeltaItems(List<SAII> Items, List<SAII> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAII deltaItem in DeltaItems)
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
                .OrderBy(i => i.INVOLVEMENTID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SAII>>> Index_INVOLVEMENTID;
        private Lazy<Dictionary<int, SAII>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <returns>List of related SAII entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAII> FindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            return Index_INVOLVEMENTID.Value[INVOLVEMENTID];
        }

        /// <summary>
        /// Attempt to find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <param name="Value">List of related SAII entities</param>
        /// <returns>True if the list of related SAII entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOLVEMENTID(int INVOLVEMENTID, out IReadOnlyList<SAII> Value)
        {
            return Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <returns>List of related SAII entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAII> TryFindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            IReadOnlyList<SAII> value;
            if (Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <returns>Related SAII entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAII FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <param name="Value">Related SAII entity</param>
        /// <returns>True if the related SAII entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAII Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <returns>Related SAII entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAII TryFindByTID(int TID)
        {
            SAII value;
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
        /// Returns SQL which checks for the existence of a SAII table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAII]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAII](
        [TID] int IDENTITY NOT NULL,
        [INVOLVEMENTID] int NOT NULL,
        [SEVERITY] smallint NULL,
        [SRI_TYPE] smallint NULL,
        [NATURE] smallint NULL,
        [OTHER_INFO] text NULL,
        [LOCATION] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAII_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SAII_Index_INVOLVEMENTID] ON [dbo].[SAII]
    (
            [INVOLVEMENTID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAII data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAII data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SAIIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAIIDataReader : IDataReader, IDataRecord
        {
            private List<SAII> Items;
            private int CurrentIndex;
            private SAII CurrentItem;

            public SAIIDataReader(List<SAII> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 10; } }
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
                    case 1: // INVOLVEMENTID
                        return CurrentItem.INVOLVEMENTID;
                    case 2: // SEVERITY
                        return CurrentItem.SEVERITY;
                    case 3: // SRI_TYPE
                        return CurrentItem.SRI_TYPE;
                    case 4: // NATURE
                        return CurrentItem.NATURE;
                    case 5: // OTHER_INFO
                        return CurrentItem.OTHER_INFO;
                    case 6: // LOCATION
                        return CurrentItem.LOCATION;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 9: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SEVERITY
                        return CurrentItem.SEVERITY == null;
                    case 3: // SRI_TYPE
                        return CurrentItem.SRI_TYPE == null;
                    case 4: // NATURE
                        return CurrentItem.NATURE == null;
                    case 5: // OTHER_INFO
                        return CurrentItem.OTHER_INFO == null;
                    case 6: // LOCATION
                        return CurrentItem.LOCATION == null;
                    case 7: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 9: // LW_USER
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
                    case 1: // INVOLVEMENTID
                        return "INVOLVEMENTID";
                    case 2: // SEVERITY
                        return "SEVERITY";
                    case 3: // SRI_TYPE
                        return "SRI_TYPE";
                    case 4: // NATURE
                        return "NATURE";
                    case 5: // OTHER_INFO
                        return "OTHER_INFO";
                    case 6: // LOCATION
                        return "LOCATION";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
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
                    case "INVOLVEMENTID":
                        return 1;
                    case "SEVERITY":
                        return 2;
                    case "SRI_TYPE":
                        return 3;
                    case "NATURE":
                        return 4;
                    case "OTHER_INFO":
                        return 5;
                    case "LOCATION":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
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
