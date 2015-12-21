using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPYDataSet : EduHubDataSet<PEPY>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPY"; } }

        internal PEPYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPY>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_PURPOSE = new Lazy<NullDictionary<string, IReadOnlyList<PEPY>>>(() => this.ToGroupedNullDictionary(i => i.PURPOSE));
            Index_TID = new Lazy<Dictionary<int, PEPY>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPY" /> fields for each CSV column header</returns>
        protected override Action<PEPY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRANSDATE":
                        mapper[i] = (e, v) => e.TRANSDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "PURPOSE":
                        mapper[i] = (e, v) => e.PURPOSE = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="PEPY" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPY" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPY" /> items to added or update the base <see cref="PEPY" /> items</param>
        /// <returns>A merged list of <see cref="PEPY" /> items</returns>
        protected override List<PEPY> ApplyDeltaItems(List<PEPY> Items, List<PEPY> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPY deltaItem in DeltaItems)
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
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<PEPY>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPY>>> Index_PURPOSE;
        private Lazy<Dictionary<int, PEPY>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <returns>List of related PEPY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <param name="Value">List of related PEPY entities</param>
        /// <returns>True if the list of related PEPY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPY> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <returns>List of related PEPY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPY> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <returns>List of related PEPY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> FindByPURPOSE(string PURPOSE)
        {
            return Index_PURPOSE.Value[PURPOSE];
        }

        /// <summary>
        /// Attempt to find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <param name="Value">List of related PEPY entities</param>
        /// <returns>True if the list of related PEPY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPURPOSE(string PURPOSE, out IReadOnlyList<PEPY> Value)
        {
            return Index_PURPOSE.Value.TryGetValue(PURPOSE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <returns>List of related PEPY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> TryFindByPURPOSE(string PURPOSE)
        {
            IReadOnlyList<PEPY> value;
            if (Index_PURPOSE.Value.TryGetValue(PURPOSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <returns>Related PEPY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPY FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <param name="Value">Related PEPY entity</param>
        /// <returns>True if the related PEPY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPY Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <returns>Related PEPY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPY TryFindByTID(int TID)
        {
            PEPY value;
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
        /// Returns SQL which checks for the existence of a PEPY table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPY](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRANSDATE] datetime NULL,
        [STAFF] varchar(10) NULL,
        [PURPOSE] varchar(6) NULL,
        [NOTES] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPY_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEPY_Index_CODE] ON [dbo].[PEPY]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPY_Index_PURPOSE] ON [dbo].[PEPY]
    (
            [PURPOSE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPY data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEPYDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPYDataReader : IDataReader, IDataRecord
        {
            private List<PEPY> Items;
            private int CurrentIndex;
            private PEPY CurrentItem;

            public PEPYDataReader(List<PEPY> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 9; } }
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
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // TRANSDATE
                        return CurrentItem.TRANSDATE;
                    case 3: // STAFF
                        return CurrentItem.STAFF;
                    case 4: // PURPOSE
                        return CurrentItem.PURPOSE;
                    case 5: // NOTES
                        return CurrentItem.NOTES;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 8: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRANSDATE
                        return CurrentItem.TRANSDATE == null;
                    case 3: // STAFF
                        return CurrentItem.STAFF == null;
                    case 4: // PURPOSE
                        return CurrentItem.PURPOSE == null;
                    case 5: // NOTES
                        return CurrentItem.NOTES == null;
                    case 6: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 7: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 8: // LW_USER
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRANSDATE
                        return "TRANSDATE";
                    case 3: // STAFF
                        return "STAFF";
                    case 4: // PURPOSE
                        return "PURPOSE";
                    case 5: // NOTES
                        return "NOTES";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
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
                    case "CODE":
                        return 1;
                    case "TRANSDATE":
                        return 2;
                    case "STAFF":
                        return 3;
                    case "PURPOSE":
                        return 4;
                    case "NOTES":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
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
