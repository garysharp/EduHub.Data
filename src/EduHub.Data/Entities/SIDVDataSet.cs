using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDVDataSet : EduHubDataSet<SIDV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SIDV"; } }

        internal SIDVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INCIDENT_KEY = new Lazy<Dictionary<int, IReadOnlyList<SIDV>>>(() => this.ToGroupedDictionary(i => i.INCIDENT_KEY));
            Index_TID = new Lazy<Dictionary<int, SIDV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIDV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIDV" /> fields for each CSV column header</returns>
        protected override Action<SIDV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIDV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = int.Parse(v);
                        break;
                    case "RECIPIENT_TYPE":
                        mapper[i] = (e, v) => e.RECIPIENT_TYPE = v;
                        break;
                    case "RECIPIENT":
                        mapper[i] = (e, v) => e.RECIPIENT = v;
                        break;
                    case "RECIPIENT_NAME":
                        mapper[i] = (e, v) => e.RECIPIENT_NAME = v;
                        break;
                    case "RECIPIENT_ADDRESS":
                        mapper[i] = (e, v) => e.RECIPIENT_ADDRESS = v;
                        break;
                    case "RECIPIENT_PHONE":
                        mapper[i] = (e, v) => e.RECIPIENT_PHONE = v;
                        break;
                    case "HOW_AFFECTED":
                        mapper[i] = (e, v) => e.HOW_AFFECTED = v;
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
        /// Merges <see cref="SIDV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SIDV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SIDV" /> items to added or update the base <see cref="SIDV" /> items</param>
        /// <returns>A merged list of <see cref="SIDV" /> items</returns>
        protected override List<SIDV> ApplyDeltaItems(List<SIDV> Items, List<SIDV> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SIDV deltaItem in DeltaItems)
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
                .OrderBy(i => i.INCIDENT_KEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SIDV>>> Index_INCIDENT_KEY;
        private Lazy<Dictionary<int, SIDV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <returns>List of related SIDV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SIDV> FindByINCIDENT_KEY(int INCIDENT_KEY)
        {
            return Index_INCIDENT_KEY.Value[INCIDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <param name="Value">List of related SIDV entities</param>
        /// <returns>True if the list of related SIDV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_KEY(int INCIDENT_KEY, out IReadOnlyList<SIDV> Value)
        {
            return Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <returns>List of related SIDV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SIDV> TryFindByINCIDENT_KEY(int INCIDENT_KEY)
        {
            IReadOnlyList<SIDV> value;
            if (Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIDV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <param name="Value">Related SIDV entity</param>
        /// <returns>True if the related SIDV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SIDV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIDV TryFindByTID(int TID)
        {
            SIDV value;
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
        /// Returns SQL which checks for the existence of a SIDV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SIDV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SIDV](
        [TID] int IDENTITY NOT NULL,
        [INCIDENT_KEY] int NOT NULL,
        [RECIPIENT_TYPE] varchar(2) NULL,
        [RECIPIENT] varchar(10) NULL,
        [RECIPIENT_NAME] varchar(64) NULL,
        [RECIPIENT_ADDRESS] text NULL,
        [RECIPIENT_PHONE] varchar(20) NULL,
        [HOW_AFFECTED] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SIDV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SIDV_Index_INCIDENT_KEY] ON [dbo].[SIDV]
    (
            [INCIDENT_KEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SIDV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SIDV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SIDVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SIDVDataReader : IDataReader, IDataRecord
        {
            private List<SIDV> Items;
            private int CurrentIndex;
            private SIDV CurrentItem;

            public SIDVDataReader(List<SIDV> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 1: // INCIDENT_KEY
                        return CurrentItem.INCIDENT_KEY;
                    case 2: // RECIPIENT_TYPE
                        return CurrentItem.RECIPIENT_TYPE;
                    case 3: // RECIPIENT
                        return CurrentItem.RECIPIENT;
                    case 4: // RECIPIENT_NAME
                        return CurrentItem.RECIPIENT_NAME;
                    case 5: // RECIPIENT_ADDRESS
                        return CurrentItem.RECIPIENT_ADDRESS;
                    case 6: // RECIPIENT_PHONE
                        return CurrentItem.RECIPIENT_PHONE;
                    case 7: // HOW_AFFECTED
                        return CurrentItem.HOW_AFFECTED;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // RECIPIENT_TYPE
                        return CurrentItem.RECIPIENT_TYPE == null;
                    case 3: // RECIPIENT
                        return CurrentItem.RECIPIENT == null;
                    case 4: // RECIPIENT_NAME
                        return CurrentItem.RECIPIENT_NAME == null;
                    case 5: // RECIPIENT_ADDRESS
                        return CurrentItem.RECIPIENT_ADDRESS == null;
                    case 6: // RECIPIENT_PHONE
                        return CurrentItem.RECIPIENT_PHONE == null;
                    case 7: // HOW_AFFECTED
                        return CurrentItem.HOW_AFFECTED == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
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
                    case 1: // INCIDENT_KEY
                        return "INCIDENT_KEY";
                    case 2: // RECIPIENT_TYPE
                        return "RECIPIENT_TYPE";
                    case 3: // RECIPIENT
                        return "RECIPIENT";
                    case 4: // RECIPIENT_NAME
                        return "RECIPIENT_NAME";
                    case 5: // RECIPIENT_ADDRESS
                        return "RECIPIENT_ADDRESS";
                    case 6: // RECIPIENT_PHONE
                        return "RECIPIENT_PHONE";
                    case 7: // HOW_AFFECTED
                        return "HOW_AFFECTED";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
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
                    case "INCIDENT_KEY":
                        return 1;
                    case "RECIPIENT_TYPE":
                        return 2;
                    case "RECIPIENT":
                        return 3;
                    case "RECIPIENT_NAME":
                        return 4;
                    case "RECIPIENT_ADDRESS":
                        return 5;
                    case "RECIPIENT_PHONE":
                        return 6;
                    case "HOW_AFFECTED":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
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
