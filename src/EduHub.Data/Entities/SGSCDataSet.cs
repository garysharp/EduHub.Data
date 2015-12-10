using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject/Class Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSCDataSet : DataSetBase<SGSC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGSC"; } }

        internal SGSCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGSCKEY = new Lazy<Dictionary<string, IReadOnlyList<SGSC>>>(() => this.ToGroupedDictionary(i => i.SGSCKEY));
            Index_SULINK = new Lazy<NullDictionary<string, IReadOnlyList<SGSC>>>(() => this.ToGroupedNullDictionary(i => i.SULINK));
            Index_TID = new Lazy<Dictionary<int, SGSC>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSC" /> fields for each CSV column header</returns>
        protected override Action<SGSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGSCKEY":
                        mapper[i] = (e, v) => e.SGSCKEY = v;
                        break;
                    case "SULINK":
                        mapper[i] = (e, v) => e.SULINK = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
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
        /// Merges <see cref="SGSC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGSC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGSC" /> items to added or update the base <see cref="SGSC" /> items</param>
        /// <returns>A merged list of <see cref="SGSC" /> items</returns>
        protected override List<SGSC> ApplyDeltaItems(List<SGSC> Items, List<SGSC> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGSC deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGSCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGSC>>> Index_SGSCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SGSC>>> Index_SULINK;
        private Lazy<Dictionary<int, SGSC>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <returns>List of related SGSC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> FindBySGSCKEY(string SGSCKEY)
        {
            return Index_SGSCKEY.Value[SGSCKEY];
        }

        /// <summary>
        /// Attempt to find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <param name="Value">List of related SGSC entities</param>
        /// <returns>True if the list of related SGSC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGSCKEY(string SGSCKEY, out IReadOnlyList<SGSC> Value)
        {
            return Index_SGSCKEY.Value.TryGetValue(SGSCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <returns>List of related SGSC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> TryFindBySGSCKEY(string SGSCKEY)
        {
            IReadOnlyList<SGSC> value;
            if (Index_SGSCKEY.Value.TryGetValue(SGSCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <returns>List of related SGSC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> FindBySULINK(string SULINK)
        {
            return Index_SULINK.Value[SULINK];
        }

        /// <summary>
        /// Attempt to find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <param name="Value">List of related SGSC entities</param>
        /// <returns>True if the list of related SGSC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySULINK(string SULINK, out IReadOnlyList<SGSC> Value)
        {
            return Index_SULINK.Value.TryGetValue(SULINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <returns>List of related SGSC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> TryFindBySULINK(string SULINK)
        {
            IReadOnlyList<SGSC> value;
            if (Index_SULINK.Value.TryGetValue(SULINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <returns>Related SGSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSC FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <param name="Value">Related SGSC entity</param>
        /// <returns>True if the related SGSC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGSC Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <returns>Related SGSC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSC TryFindByTID(int TID)
        {
            SGSC value;
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
        /// Returns SQL which checks for the existence of a SGSC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGSC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGSC](
        [TID] int IDENTITY NOT NULL,
        [SGSCKEY] varchar(12) NOT NULL,
        [SULINK] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TTPERIOD] varchar(8) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGSC_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGSC_Index_SGSCKEY] ON [dbo].[SGSC]
    (
            [SGSCKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SGSC_Index_SULINK] ON [dbo].[SGSC]
    (
            [SULINK] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGSC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGSC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGSCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGSCDataReader : IDataReader, IDataRecord
        {
            private List<SGSC> Items;
            private int CurrentIndex;
            private SGSC CurrentItem;

            public SGSCDataReader(List<SGSC> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 8; } }
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
                    case 1: // SGSCKEY
                        return CurrentItem.SGSCKEY;
                    case 2: // SULINK
                        return CurrentItem.SULINK;
                    case 3: // CLASS
                        return CurrentItem.CLASS;
                    case 4: // TTPERIOD
                        return CurrentItem.TTPERIOD;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 7: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SULINK
                        return CurrentItem.SULINK == null;
                    case 3: // CLASS
                        return CurrentItem.CLASS == null;
                    case 4: // TTPERIOD
                        return CurrentItem.TTPERIOD == null;
                    case 5: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 6: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 7: // LW_USER
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
                    case 1: // SGSCKEY
                        return "SGSCKEY";
                    case 2: // SULINK
                        return "SULINK";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // TTPERIOD
                        return "TTPERIOD";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
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
                    case "SGSCKEY":
                        return 1;
                    case "SULINK":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "TTPERIOD":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
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
