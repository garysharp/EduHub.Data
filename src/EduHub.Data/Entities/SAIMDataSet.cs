using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sickbay Medication Administrations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIMDataSet : EduHubDataSet<SAIM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAIM"; } }

        internal SAIMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INVOLVEMENTID = new Lazy<Dictionary<int, IReadOnlyList<SAIM>>>(() => this.ToGroupedDictionary(i => i.INVOLVEMENTID));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<SAIM>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, SAIM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAIM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAIM" /> fields for each CSV column header</returns>
        protected override Action<SAIM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAIM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = int.Parse(v);
                        break;
                    case "MEDICATION":
                        mapper[i] = (e, v) => e.MEDICATION = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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
        /// Merges <see cref="SAIM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAIM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAIM" /> items to added or update the base <see cref="SAIM" /> items</param>
        /// <returns>A merged list of <see cref="SAIM" /> items</returns>
        protected override List<SAIM> ApplyDeltaItems(List<SAIM> Items, List<SAIM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAIM deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, IReadOnlyList<SAIM>>> Index_INVOLVEMENTID;
        private Lazy<NullDictionary<string, IReadOnlyList<SAIM>>> Index_STAFF;
        private Lazy<Dictionary<int, SAIM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <returns>List of related SAIM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> FindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            return Index_INVOLVEMENTID.Value[INVOLVEMENTID];
        }

        /// <summary>
        /// Attempt to find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <param name="Value">List of related SAIM entities</param>
        /// <returns>True if the list of related SAIM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOLVEMENTID(int INVOLVEMENTID, out IReadOnlyList<SAIM> Value)
        {
            return Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <returns>List of related SAIM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> TryFindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            IReadOnlyList<SAIM> value;
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
        /// Find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <returns>List of related SAIM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <param name="Value">List of related SAIM entities</param>
        /// <returns>True if the list of related SAIM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<SAIM> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <returns>List of related SAIM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<SAIM> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <returns>Related SAIM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAIM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <param name="Value">Related SAIM entity</param>
        /// <returns>True if the related SAIM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAIM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <returns>Related SAIM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAIM TryFindByTID(int TID)
        {
            SAIM value;
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
        /// Returns SQL which checks for the existence of a SAIM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAIM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAIM](
        [TID] int IDENTITY NOT NULL,
        [INVOLVEMENTID] int NOT NULL,
        [MEDICATION] varchar(30) NULL,
        [STAFF] varchar(4) NULL,
        [ADMIN_BY_OTHER] varchar(30) NULL,
        [ADMIN_TIME] smallint NULL,
        [DOSE] varchar(30) NULL,
        [ADMIN_NOTES] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAIM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SAIM_Index_INVOLVEMENTID] ON [dbo].[SAIM]
    (
            [INVOLVEMENTID] ASC
    );
    CREATE NONCLUSTERED INDEX [SAIM_Index_STAFF] ON [dbo].[SAIM]
    (
            [STAFF] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAIM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAIM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SAIMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAIMDataReader : IDataReader, IDataRecord
        {
            private List<SAIM> Items;
            private int CurrentIndex;
            private SAIM CurrentItem;

            public SAIMDataReader(List<SAIM> Items)
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
                    case 1: // INVOLVEMENTID
                        return CurrentItem.INVOLVEMENTID;
                    case 2: // MEDICATION
                        return CurrentItem.MEDICATION;
                    case 3: // STAFF
                        return CurrentItem.STAFF;
                    case 4: // ADMIN_BY_OTHER
                        return CurrentItem.ADMIN_BY_OTHER;
                    case 5: // ADMIN_TIME
                        return CurrentItem.ADMIN_TIME;
                    case 6: // DOSE
                        return CurrentItem.DOSE;
                    case 7: // ADMIN_NOTES
                        return CurrentItem.ADMIN_NOTES;
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
                    case 2: // MEDICATION
                        return CurrentItem.MEDICATION == null;
                    case 3: // STAFF
                        return CurrentItem.STAFF == null;
                    case 4: // ADMIN_BY_OTHER
                        return CurrentItem.ADMIN_BY_OTHER == null;
                    case 5: // ADMIN_TIME
                        return CurrentItem.ADMIN_TIME == null;
                    case 6: // DOSE
                        return CurrentItem.DOSE == null;
                    case 7: // ADMIN_NOTES
                        return CurrentItem.ADMIN_NOTES == null;
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
                    case 1: // INVOLVEMENTID
                        return "INVOLVEMENTID";
                    case 2: // MEDICATION
                        return "MEDICATION";
                    case 3: // STAFF
                        return "STAFF";
                    case 4: // ADMIN_BY_OTHER
                        return "ADMIN_BY_OTHER";
                    case 5: // ADMIN_TIME
                        return "ADMIN_TIME";
                    case 6: // DOSE
                        return "DOSE";
                    case 7: // ADMIN_NOTES
                        return "ADMIN_NOTES";
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
                    case "INVOLVEMENTID":
                        return 1;
                    case "MEDICATION":
                        return 2;
                    case "STAFF":
                        return 3;
                    case "ADMIN_BY_OTHER":
                        return 4;
                    case "ADMIN_TIME":
                        return 5;
                    case "DOSE":
                        return 6;
                    case "ADMIN_NOTES":
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
