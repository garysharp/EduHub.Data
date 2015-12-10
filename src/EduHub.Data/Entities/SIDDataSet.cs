using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDDataSet : DataSetBase<SID>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SID"; } }

        internal SIDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SID>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_INCIDENT_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SID>>>(() => this.ToGroupedNullDictionary(i => i.INCIDENT_TYPE));
            Index_SIDKEY = new Lazy<Dictionary<int, SID>>(() => this.ToDictionary(i => i.SIDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SID" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SID" /> fields for each CSV column header</returns>
        protected override Action<SID, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SID, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIDKEY":
                        mapper[i] = (e, v) => e.SIDKEY = int.Parse(v);
                        break;
                    case "SID_DATE":
                        mapper[i] = (e, v) => e.SID_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SID_TIME":
                        mapper[i] = (e, v) => e.SID_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INCIDENT_TYPE":
                        mapper[i] = (e, v) => e.INCIDENT_TYPE = v;
                        break;
                    case "INCIDENT_DESC":
                        mapper[i] = (e, v) => e.INCIDENT_DESC = v;
                        break;
                    case "OFFICE_USE_ONLY":
                        mapper[i] = (e, v) => e.OFFICE_USE_ONLY = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXT_ADDRESS":
                        mapper[i] = (e, v) => e.EXT_ADDRESS = v;
                        break;
                    case "RESP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.RESP_PERSON_TYPE = v;
                        break;
                    case "RESP_PERSON":
                        mapper[i] = (e, v) => e.RESP_PERSON = v;
                        break;
                    case "RESP_PERSON_NAME":
                        mapper[i] = (e, v) => e.RESP_PERSON_NAME = v;
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
        /// Merges <see cref="SID" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SID" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SID" /> items to added or update the base <see cref="SID" /> items</param>
        /// <returns>A merged list of <see cref="SID" /> items</returns>
        protected override List<SID> ApplyDeltaItems(List<SID> Items, List<SID> DeltaItems)
        {
            Dictionary<int, int> Index_SIDKEY = Items.ToIndexDictionary(i => i.SIDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SID deltaItem in DeltaItems)
            {
                int index;

                if (Index_SIDKEY.TryGetValue(deltaItem.SIDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SIDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SID>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SID>>> Index_INCIDENT_TYPE;
        private Lazy<Dictionary<int, SID>> Index_SIDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <returns>List of related SID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <param name="Value">List of related SID entities</param>
        /// <returns>True if the list of related SID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SID> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <returns>List of related SID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SID> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <returns>List of related SID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> FindByINCIDENT_TYPE(string INCIDENT_TYPE)
        {
            return Index_INCIDENT_TYPE.Value[INCIDENT_TYPE];
        }

        /// <summary>
        /// Attempt to find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <param name="Value">List of related SID entities</param>
        /// <returns>True if the list of related SID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_TYPE(string INCIDENT_TYPE, out IReadOnlyList<SID> Value)
        {
            return Index_INCIDENT_TYPE.Value.TryGetValue(INCIDENT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <returns>List of related SID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> TryFindByINCIDENT_TYPE(string INCIDENT_TYPE)
        {
            IReadOnlyList<SID> value;
            if (Index_INCIDENT_TYPE.Value.TryGetValue(INCIDENT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SID FindBySIDKEY(int SIDKEY)
        {
            return Index_SIDKEY.Value[SIDKEY];
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <param name="Value">Related SID entity</param>
        /// <returns>True if the related SID entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIDKEY(int SIDKEY, out SID Value)
        {
            return Index_SIDKEY.Value.TryGetValue(SIDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SID TryFindBySIDKEY(int SIDKEY)
        {
            SID value;
            if (Index_SIDKEY.Value.TryGetValue(SIDKEY, out value))
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
        /// Returns SQL which checks for the existence of a SID table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SID]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SID](
        [SIDKEY] int IDENTITY NOT NULL,
        [SID_DATE] datetime NULL,
        [SID_TIME] smallint NULL,
        [INCIDENT_TYPE] varchar(10) NULL,
        [INCIDENT_DESC] text NULL,
        [OFFICE_USE_ONLY] text NULL,
        [CAMPUS] int NULL,
        [EXT_ADDRESS] text NULL,
        [RESP_PERSON_TYPE] varchar(2) NULL,
        [RESP_PERSON] varchar(10) NULL,
        [RESP_PERSON_NAME] varchar(64) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SID_Index_SIDKEY] PRIMARY KEY CLUSTERED (
            [SIDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SID_Index_CAMPUS] ON [dbo].[SID]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SID_Index_INCIDENT_TYPE] ON [dbo].[SID]
    (
            [INCIDENT_TYPE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SID data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SID data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SIDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SIDDataReader : IDataReader, IDataRecord
        {
            private List<SID> Items;
            private int CurrentIndex;
            private SID CurrentItem;

            public SIDDataReader(List<SID> Items)
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
                    case 0: // SIDKEY
                        return CurrentItem.SIDKEY;
                    case 1: // SID_DATE
                        return CurrentItem.SID_DATE;
                    case 2: // SID_TIME
                        return CurrentItem.SID_TIME;
                    case 3: // INCIDENT_TYPE
                        return CurrentItem.INCIDENT_TYPE;
                    case 4: // INCIDENT_DESC
                        return CurrentItem.INCIDENT_DESC;
                    case 5: // OFFICE_USE_ONLY
                        return CurrentItem.OFFICE_USE_ONLY;
                    case 6: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 7: // EXT_ADDRESS
                        return CurrentItem.EXT_ADDRESS;
                    case 8: // RESP_PERSON_TYPE
                        return CurrentItem.RESP_PERSON_TYPE;
                    case 9: // RESP_PERSON
                        return CurrentItem.RESP_PERSON;
                    case 10: // RESP_PERSON_NAME
                        return CurrentItem.RESP_PERSON_NAME;
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
                    case 1: // SID_DATE
                        return CurrentItem.SID_DATE == null;
                    case 2: // SID_TIME
                        return CurrentItem.SID_TIME == null;
                    case 3: // INCIDENT_TYPE
                        return CurrentItem.INCIDENT_TYPE == null;
                    case 4: // INCIDENT_DESC
                        return CurrentItem.INCIDENT_DESC == null;
                    case 5: // OFFICE_USE_ONLY
                        return CurrentItem.OFFICE_USE_ONLY == null;
                    case 6: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 7: // EXT_ADDRESS
                        return CurrentItem.EXT_ADDRESS == null;
                    case 8: // RESP_PERSON_TYPE
                        return CurrentItem.RESP_PERSON_TYPE == null;
                    case 9: // RESP_PERSON
                        return CurrentItem.RESP_PERSON == null;
                    case 10: // RESP_PERSON_NAME
                        return CurrentItem.RESP_PERSON_NAME == null;
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
                    case 0: // SIDKEY
                        return "SIDKEY";
                    case 1: // SID_DATE
                        return "SID_DATE";
                    case 2: // SID_TIME
                        return "SID_TIME";
                    case 3: // INCIDENT_TYPE
                        return "INCIDENT_TYPE";
                    case 4: // INCIDENT_DESC
                        return "INCIDENT_DESC";
                    case 5: // OFFICE_USE_ONLY
                        return "OFFICE_USE_ONLY";
                    case 6: // CAMPUS
                        return "CAMPUS";
                    case 7: // EXT_ADDRESS
                        return "EXT_ADDRESS";
                    case 8: // RESP_PERSON_TYPE
                        return "RESP_PERSON_TYPE";
                    case 9: // RESP_PERSON
                        return "RESP_PERSON";
                    case 10: // RESP_PERSON_NAME
                        return "RESP_PERSON_NAME";
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
                    case "SIDKEY":
                        return 0;
                    case "SID_DATE":
                        return 1;
                    case "SID_TIME":
                        return 2;
                    case "INCIDENT_TYPE":
                        return 3;
                    case "INCIDENT_DESC":
                        return 4;
                    case "OFFICE_USE_ONLY":
                        return 5;
                    case "CAMPUS":
                        return 6;
                    case "EXT_ADDRESS":
                        return 7;
                    case "RESP_PERSON_TYPE":
                        return 8;
                    case "RESP_PERSON":
                        return 9;
                    case "RESP_PERSON_NAME":
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
