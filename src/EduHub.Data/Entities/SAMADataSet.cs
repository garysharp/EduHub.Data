using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Association Member Attendances Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMADataSet : EduHubDataSet<SAMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAMA"; } }

        internal SAMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SAMAKEY = new Lazy<Dictionary<int, IReadOnlyList<SAMA>>>(() => this.ToGroupedDictionary(i => i.SAMAKEY));
            Index_SAMAKEY_SCAM_TID = new Lazy<Dictionary<Tuple<int, int?>, SAMA>>(() => this.ToDictionary(i => Tuple.Create(i.SAMAKEY, i.SCAM_TID)));
            Index_TID = new Lazy<Dictionary<int, SAMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAMA" /> fields for each CSV column header</returns>
        protected override Action<SAMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SAMAKEY":
                        mapper[i] = (e, v) => e.SAMAKEY = int.Parse(v);
                        break;
                    case "SCAM_TID":
                        mapper[i] = (e, v) => e.SCAM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
        /// Merges <see cref="SAMA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAMA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAMA" /> items to added or update the base <see cref="SAMA" /> items</param>
        /// <returns>A merged list of <see cref="SAMA" /> items</returns>
        protected override List<SAMA> ApplyDeltaItems(List<SAMA> Items, List<SAMA> DeltaItems)
        {
            Dictionary<Tuple<int, int?>, int> Index_SAMAKEY_SCAM_TID = Items.ToIndexDictionary(i => Tuple.Create(i.SAMAKEY, i.SCAM_TID));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAMA deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAMAKEY_SCAM_TID.TryGetValue(Tuple.Create(deltaItem.SAMAKEY, deltaItem.SCAM_TID), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAMAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SAMA>>> Index_SAMAKEY;
        private Lazy<Dictionary<Tuple<int, int?>, SAMA>> Index_SAMAKEY_SCAM_TID;
        private Lazy<Dictionary<int, SAMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <returns>List of related SAMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAMA> FindBySAMAKEY(int SAMAKEY)
        {
            return Index_SAMAKEY.Value[SAMAKEY];
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="Value">List of related SAMA entities</param>
        /// <returns>True if the list of related SAMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMAKEY(int SAMAKEY, out IReadOnlyList<SAMA> Value)
        {
            return Index_SAMAKEY.Value.TryGetValue(SAMAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <returns>List of related SAMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAMA> TryFindBySAMAKEY(int SAMAKEY)
        {
            IReadOnlyList<SAMA> value;
            if (Index_SAMAKEY.Value.TryGetValue(SAMAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <returns>Related SAMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA FindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID)
        {
            return Index_SAMAKEY_SCAM_TID.Value[Tuple.Create(SAMAKEY, SCAM_TID)];
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <param name="Value">Related SAMA entity</param>
        /// <returns>True if the related SAMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID, out SAMA Value)
        {
            return Index_SAMAKEY_SCAM_TID.Value.TryGetValue(Tuple.Create(SAMAKEY, SCAM_TID), out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <returns>Related SAMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA TryFindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID)
        {
            SAMA value;
            if (Index_SAMAKEY_SCAM_TID.Value.TryGetValue(Tuple.Create(SAMAKEY, SCAM_TID), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <returns>Related SAMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <param name="Value">Related SAMA entity</param>
        /// <returns>True if the related SAMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <returns>Related SAMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA TryFindByTID(int TID)
        {
            SAMA value;
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
        /// Returns SQL which checks for the existence of a SAMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAMA](
        [TID] int IDENTITY NOT NULL,
        [SAMAKEY] int NOT NULL,
        [SCAM_TID] int NULL,
        [ATTENDED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAMA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SAMA_Index_SAMAKEY] ON [dbo].[SAMA]
    (
            [SAMAKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SAMA_Index_SAMAKEY_SCAM_TID] ON [dbo].[SAMA]
    (
            [SAMAKEY] ASC,
            [SCAM_TID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAMA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SAMADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAMADataReader : IDataReader, IDataRecord
        {
            private List<SAMA> Items;
            private int CurrentIndex;
            private SAMA CurrentItem;

            public SAMADataReader(List<SAMA> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 1: // SAMAKEY
                        return CurrentItem.SAMAKEY;
                    case 2: // SCAM_TID
                        return CurrentItem.SCAM_TID;
                    case 3: // ATTENDED
                        return CurrentItem.ATTENDED;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SCAM_TID
                        return CurrentItem.SCAM_TID == null;
                    case 3: // ATTENDED
                        return CurrentItem.ATTENDED == null;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // SAMAKEY
                        return "SAMAKEY";
                    case 2: // SCAM_TID
                        return "SCAM_TID";
                    case 3: // ATTENDED
                        return "ATTENDED";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "SAMAKEY":
                        return 1;
                    case "SCAM_TID":
                        return 2;
                    case "ATTENDED":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
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
