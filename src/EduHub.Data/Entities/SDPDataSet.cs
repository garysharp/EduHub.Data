using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDPDataSet : EduHubDataSet<SDP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDP"; } }

        internal SDPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INCIDENT_KEY = new Lazy<NullDictionary<int?, IReadOnlyList<SDP>>>(() => this.ToGroupedNullDictionary(i => i.INCIDENT_KEY));
            Index_SDPKEY = new Lazy<Dictionary<int, SDP>>(() => this.ToDictionary(i => i.SDPKEY));
            Index_STUDENT_KEY = new Lazy<NullDictionary<string, IReadOnlyList<SDP>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT_KEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDP" /> fields for each CSV column header</returns>
        protected override Action<SDP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDPKEY":
                        mapper[i] = (e, v) => e.SDPKEY = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INCIDENT_TYPE":
                        mapper[i] = (e, v) => e.INCIDENT_TYPE = v;
                        break;
                    case "INCIDENT_DATE":
                        mapper[i] = (e, v) => e.INCIDENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STUDENT_KEY":
                        mapper[i] = (e, v) => e.STUDENT_KEY = v;
                        break;
                    case "INVOLVEMENT_DESC":
                        mapper[i] = (e, v) => e.INVOLVEMENT_DESC = v;
                        break;
                    case "FOLLOW_UP_DATE":
                        mapper[i] = (e, v) => e.FOLLOW_UP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FOLLOW_UP_DETAILS":
                        mapper[i] = (e, v) => e.FOLLOW_UP_DETAILS = v;
                        break;
                    case "FOLLOW_UP_OUTCOME":
                        mapper[i] = (e, v) => e.FOLLOW_UP_OUTCOME = v;
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
        /// Merges <see cref="SDP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDP" /> items to added or update the base <see cref="SDP" /> items</param>
        /// <returns>A merged list of <see cref="SDP" /> items</returns>
        protected override List<SDP> ApplyDeltaItems(List<SDP> Items, List<SDP> DeltaItems)
        {
            Dictionary<int, int> Index_SDPKEY = Items.ToIndexDictionary(i => i.SDPKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDP deltaItem in DeltaItems)
            {
                int index;

                if (Index_SDPKEY.TryGetValue(deltaItem.SDPKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SDPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SDP>>> Index_INCIDENT_KEY;
        private Lazy<Dictionary<int, SDP>> Index_SDPKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SDP>>> Index_STUDENT_KEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> FindByINCIDENT_KEY(int? INCIDENT_KEY)
        {
            return Index_INCIDENT_KEY.Value[INCIDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <param name="Value">List of related SDP entities</param>
        /// <returns>True if the list of related SDP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_KEY(int? INCIDENT_KEY, out IReadOnlyList<SDP> Value)
        {
            return Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> TryFindByINCIDENT_KEY(int? INCIDENT_KEY)
        {
            IReadOnlyList<SDP> value;
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
        /// Find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDP FindBySDPKEY(int SDPKEY)
        {
            return Index_SDPKEY.Value[SDPKEY];
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <param name="Value">Related SDP entity</param>
        /// <returns>True if the related SDP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDPKEY(int SDPKEY, out SDP Value)
        {
            return Index_SDPKEY.Value.TryGetValue(SDPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDP TryFindBySDPKEY(int SDPKEY)
        {
            SDP value;
            if (Index_SDPKEY.Value.TryGetValue(SDPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> FindBySTUDENT_KEY(string STUDENT_KEY)
        {
            return Index_STUDENT_KEY.Value[STUDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <param name="Value">List of related SDP entities</param>
        /// <returns>True if the list of related SDP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT_KEY(string STUDENT_KEY, out IReadOnlyList<SDP> Value)
        {
            return Index_STUDENT_KEY.Value.TryGetValue(STUDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> TryFindBySTUDENT_KEY(string STUDENT_KEY)
        {
            IReadOnlyList<SDP> value;
            if (Index_STUDENT_KEY.Value.TryGetValue(STUDENT_KEY, out value))
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
        /// Returns SQL which checks for the existence of a SDP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDP](
        [SDPKEY] int IDENTITY NOT NULL,
        [INCIDENT_KEY] int NULL,
        [INCIDENT_TYPE] varchar(5) NULL,
        [INCIDENT_DATE] datetime NULL,
        [STUDENT_KEY] varchar(10) NULL,
        [INVOLVEMENT_DESC] text NULL,
        [FOLLOW_UP_DATE] datetime NULL,
        [FOLLOW_UP_DETAILS] text NULL,
        [FOLLOW_UP_OUTCOME] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDP_Index_SDPKEY] PRIMARY KEY CLUSTERED (
            [SDPKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SDP_Index_INCIDENT_KEY] ON [dbo].[SDP]
    (
            [INCIDENT_KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SDP_Index_STUDENT_KEY] ON [dbo].[SDP]
    (
            [STUDENT_KEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SDPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDPDataReader : IDataReader, IDataRecord
        {
            private List<SDP> Items;
            private int CurrentIndex;
            private SDP CurrentItem;

            public SDPDataReader(List<SDP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 12; } }
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
                    case 0: // SDPKEY
                        return CurrentItem.SDPKEY;
                    case 1: // INCIDENT_KEY
                        return CurrentItem.INCIDENT_KEY;
                    case 2: // INCIDENT_TYPE
                        return CurrentItem.INCIDENT_TYPE;
                    case 3: // INCIDENT_DATE
                        return CurrentItem.INCIDENT_DATE;
                    case 4: // STUDENT_KEY
                        return CurrentItem.STUDENT_KEY;
                    case 5: // INVOLVEMENT_DESC
                        return CurrentItem.INVOLVEMENT_DESC;
                    case 6: // FOLLOW_UP_DATE
                        return CurrentItem.FOLLOW_UP_DATE;
                    case 7: // FOLLOW_UP_DETAILS
                        return CurrentItem.FOLLOW_UP_DETAILS;
                    case 8: // FOLLOW_UP_OUTCOME
                        return CurrentItem.FOLLOW_UP_OUTCOME;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 11: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // INCIDENT_KEY
                        return CurrentItem.INCIDENT_KEY == null;
                    case 2: // INCIDENT_TYPE
                        return CurrentItem.INCIDENT_TYPE == null;
                    case 3: // INCIDENT_DATE
                        return CurrentItem.INCIDENT_DATE == null;
                    case 4: // STUDENT_KEY
                        return CurrentItem.STUDENT_KEY == null;
                    case 5: // INVOLVEMENT_DESC
                        return CurrentItem.INVOLVEMENT_DESC == null;
                    case 6: // FOLLOW_UP_DATE
                        return CurrentItem.FOLLOW_UP_DATE == null;
                    case 7: // FOLLOW_UP_DETAILS
                        return CurrentItem.FOLLOW_UP_DETAILS == null;
                    case 8: // FOLLOW_UP_OUTCOME
                        return CurrentItem.FOLLOW_UP_OUTCOME == null;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 11: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SDPKEY
                        return "SDPKEY";
                    case 1: // INCIDENT_KEY
                        return "INCIDENT_KEY";
                    case 2: // INCIDENT_TYPE
                        return "INCIDENT_TYPE";
                    case 3: // INCIDENT_DATE
                        return "INCIDENT_DATE";
                    case 4: // STUDENT_KEY
                        return "STUDENT_KEY";
                    case 5: // INVOLVEMENT_DESC
                        return "INVOLVEMENT_DESC";
                    case 6: // FOLLOW_UP_DATE
                        return "FOLLOW_UP_DATE";
                    case 7: // FOLLOW_UP_DETAILS
                        return "FOLLOW_UP_DETAILS";
                    case 8: // FOLLOW_UP_OUTCOME
                        return "FOLLOW_UP_OUTCOME";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SDPKEY":
                        return 0;
                    case "INCIDENT_KEY":
                        return 1;
                    case "INCIDENT_TYPE":
                        return 2;
                    case "INCIDENT_DATE":
                        return 3;
                    case "STUDENT_KEY":
                        return 4;
                    case "INVOLVEMENT_DESC":
                        return 5;
                    case "FOLLOW_UP_DATE":
                        return 6;
                    case "FOLLOW_UP_DETAILS":
                        return 7;
                    case "FOLLOW_UP_OUTCOME":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
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
