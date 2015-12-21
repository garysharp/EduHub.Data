using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Temporary Group Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGTRXDataSet : EduHubDataSet<SGTRX>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGTRX"; } }

        internal SGTRXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGTRXKEY = new Lazy<Dictionary<string, IReadOnlyList<SGTRX>>>(() => this.ToGroupedDictionary(i => i.SGTRXKEY));
            Index_TID = new Lazy<Dictionary<int, SGTRX>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGTRX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGTRX" /> fields for each CSV column header</returns>
        protected override Action<SGTRX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGTRX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGTRXKEY":
                        mapper[i] = (e, v) => e.SGTRXKEY = v;
                        break;
                    case "TRXTYPE":
                        mapper[i] = (e, v) => e.TRXTYPE = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
        /// Merges <see cref="SGTRX" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGTRX" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGTRX" /> items to added or update the base <see cref="SGTRX" /> items</param>
        /// <returns>A merged list of <see cref="SGTRX" /> items</returns>
        protected override List<SGTRX> ApplyDeltaItems(List<SGTRX> Items, List<SGTRX> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGTRX deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGTRXKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGTRX>>> Index_SGTRXKEY;
        private Lazy<Dictionary<int, SGTRX>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <returns>List of related SGTRX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGTRX> FindBySGTRXKEY(string SGTRXKEY)
        {
            return Index_SGTRXKEY.Value[SGTRXKEY];
        }

        /// <summary>
        /// Attempt to find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <param name="Value">List of related SGTRX entities</param>
        /// <returns>True if the list of related SGTRX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGTRXKEY(string SGTRXKEY, out IReadOnlyList<SGTRX> Value)
        {
            return Index_SGTRXKEY.Value.TryGetValue(SGTRXKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <returns>List of related SGTRX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGTRX> TryFindBySGTRXKEY(string SGTRXKEY)
        {
            IReadOnlyList<SGTRX> value;
            if (Index_SGTRXKEY.Value.TryGetValue(SGTRXKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <returns>Related SGTRX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGTRX FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <param name="Value">Related SGTRX entity</param>
        /// <returns>True if the related SGTRX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGTRX Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <returns>Related SGTRX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGTRX TryFindByTID(int TID)
        {
            SGTRX value;
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
        /// Returns SQL which checks for the existence of a SGTRX table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGTRX]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGTRX](
        [TID] int IDENTITY NOT NULL,
        [SGTRXKEY] varchar(12) NOT NULL,
        [TRXTYPE] varchar(4) NULL,
        [SGLINK] varchar(10) NULL,
        [KGCLINK] varchar(10) NULL,
        [SULINK] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TTPERIOD] varchar(6) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGTRX_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGTRX_Index_SGTRXKEY] ON [dbo].[SGTRX]
    (
            [SGTRXKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGTRX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGTRX data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGTRXDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGTRXDataReader : IDataReader, IDataRecord
        {
            private List<SGTRX> Items;
            private int CurrentIndex;
            private SGTRX CurrentItem;

            public SGTRXDataReader(List<SGTRX> Items)
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
                    case 1: // SGTRXKEY
                        return CurrentItem.SGTRXKEY;
                    case 2: // TRXTYPE
                        return CurrentItem.TRXTYPE;
                    case 3: // SGLINK
                        return CurrentItem.SGLINK;
                    case 4: // KGCLINK
                        return CurrentItem.KGCLINK;
                    case 5: // SULINK
                        return CurrentItem.SULINK;
                    case 6: // CLASS
                        return CurrentItem.CLASS;
                    case 7: // TTPERIOD
                        return CurrentItem.TTPERIOD;
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
                    case 2: // TRXTYPE
                        return CurrentItem.TRXTYPE == null;
                    case 3: // SGLINK
                        return CurrentItem.SGLINK == null;
                    case 4: // KGCLINK
                        return CurrentItem.KGCLINK == null;
                    case 5: // SULINK
                        return CurrentItem.SULINK == null;
                    case 6: // CLASS
                        return CurrentItem.CLASS == null;
                    case 7: // TTPERIOD
                        return CurrentItem.TTPERIOD == null;
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
                    case 1: // SGTRXKEY
                        return "SGTRXKEY";
                    case 2: // TRXTYPE
                        return "TRXTYPE";
                    case 3: // SGLINK
                        return "SGLINK";
                    case 4: // KGCLINK
                        return "KGCLINK";
                    case 5: // SULINK
                        return "SULINK";
                    case 6: // CLASS
                        return "CLASS";
                    case 7: // TTPERIOD
                        return "TTPERIOD";
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
                    case "SGTRXKEY":
                        return 1;
                    case "TRXTYPE":
                        return 2;
                    case "SGLINK":
                        return 3;
                    case "KGCLINK":
                        return 4;
                    case "SULINK":
                        return 5;
                    case "CLASS":
                        return 6;
                    case "TTPERIOD":
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
