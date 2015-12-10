using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PRMS Order Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPRMSDataSet : DataSetBase<KPRMS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPRMS"; } }

        internal KPRMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KPRMS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPRMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPRMS" /> fields for each CSV column header</returns>
        protected override Action<KPRMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPRMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PRMS_ORDERNO":
                        mapper[i] = (e, v) => e.PRMS_ORDERNO = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ORDER_LINENO":
                        mapper[i] = (e, v) => e.ORDER_LINENO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ORDER_DESC":
                        mapper[i] = (e, v) => e.ORDER_DESC = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "GLSUBPROG":
                        mapper[i] = (e, v) => e.GLSUBPROG = v;
                        break;
                    case "GLINIT":
                        mapper[i] = (e, v) => e.GLINIT = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "GST_CODE":
                        mapper[i] = (e, v) => e.GST_CODE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
        /// Merges <see cref="KPRMS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPRMS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPRMS" /> items to added or update the base <see cref="KPRMS" /> items</param>
        /// <returns>A merged list of <see cref="KPRMS" /> items</returns>
        protected override List<KPRMS> ApplyDeltaItems(List<KPRMS> Items, List<KPRMS> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPRMS deltaItem in DeltaItems)
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
                .OrderBy(i => i.TID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KPRMS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPRMS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <param name="Value">Related KPRMS entity</param>
        /// <returns>True if the related KPRMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KPRMS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPRMS TryFindByTID(int TID)
        {
            KPRMS value;
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
        /// Returns SQL which checks for the existence of a KPRMS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPRMS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPRMS](
        [TID] int IDENTITY NOT NULL,
        [PRMS_ORDERNO] varchar(10) NULL,
        [TRDATE] datetime NULL,
        [ORDER_LINENO] smallint NULL,
        [ORDER_DESC] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [GLSUBPROG] varchar(4) NULL,
        [GLINIT] varchar(3) NULL,
        [TRQTY] float NULL,
        [AMOUNT] money NULL,
        [CRKEY] varchar(10) NULL,
        [GST_CODE] varchar(4) NULL,
        [GST_RATE] money NULL,
        [ABN] varchar(15) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPRMS_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPRMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPRMS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KPRMSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPRMSDataReader : IDataReader, IDataRecord
        {
            private List<KPRMS> Items;
            private int CurrentIndex;
            private KPRMS CurrentItem;

            public KPRMSDataReader(List<KPRMS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 20; } }
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
                    case 1: // PRMS_ORDERNO
                        return CurrentItem.PRMS_ORDERNO;
                    case 2: // TRDATE
                        return CurrentItem.TRDATE;
                    case 3: // ORDER_LINENO
                        return CurrentItem.ORDER_LINENO;
                    case 4: // ORDER_DESC
                        return CurrentItem.ORDER_DESC;
                    case 5: // GLCODE
                        return CurrentItem.GLCODE;
                    case 6: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 7: // GLSUBPROG
                        return CurrentItem.GLSUBPROG;
                    case 8: // GLINIT
                        return CurrentItem.GLINIT;
                    case 9: // TRQTY
                        return CurrentItem.TRQTY;
                    case 10: // AMOUNT
                        return CurrentItem.AMOUNT;
                    case 11: // CRKEY
                        return CurrentItem.CRKEY;
                    case 12: // GST_CODE
                        return CurrentItem.GST_CODE;
                    case 13: // GST_RATE
                        return CurrentItem.GST_RATE;
                    case 14: // ABN
                        return CurrentItem.ABN;
                    case 15: // SCHOOL_ID
                        return CurrentItem.SCHOOL_ID;
                    case 16: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG;
                    case 17: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 18: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 19: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // PRMS_ORDERNO
                        return CurrentItem.PRMS_ORDERNO == null;
                    case 2: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 3: // ORDER_LINENO
                        return CurrentItem.ORDER_LINENO == null;
                    case 4: // ORDER_DESC
                        return CurrentItem.ORDER_DESC == null;
                    case 5: // GLCODE
                        return CurrentItem.GLCODE == null;
                    case 6: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 7: // GLSUBPROG
                        return CurrentItem.GLSUBPROG == null;
                    case 8: // GLINIT
                        return CurrentItem.GLINIT == null;
                    case 9: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 10: // AMOUNT
                        return CurrentItem.AMOUNT == null;
                    case 11: // CRKEY
                        return CurrentItem.CRKEY == null;
                    case 12: // GST_CODE
                        return CurrentItem.GST_CODE == null;
                    case 13: // GST_RATE
                        return CurrentItem.GST_RATE == null;
                    case 14: // ABN
                        return CurrentItem.ABN == null;
                    case 15: // SCHOOL_ID
                        return CurrentItem.SCHOOL_ID == null;
                    case 16: // DELETE_FLAG
                        return CurrentItem.DELETE_FLAG == null;
                    case 17: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 18: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 19: // LW_USER
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
                    case 1: // PRMS_ORDERNO
                        return "PRMS_ORDERNO";
                    case 2: // TRDATE
                        return "TRDATE";
                    case 3: // ORDER_LINENO
                        return "ORDER_LINENO";
                    case 4: // ORDER_DESC
                        return "ORDER_DESC";
                    case 5: // GLCODE
                        return "GLCODE";
                    case 6: // GLPROGRAM
                        return "GLPROGRAM";
                    case 7: // GLSUBPROG
                        return "GLSUBPROG";
                    case 8: // GLINIT
                        return "GLINIT";
                    case 9: // TRQTY
                        return "TRQTY";
                    case 10: // AMOUNT
                        return "AMOUNT";
                    case 11: // CRKEY
                        return "CRKEY";
                    case 12: // GST_CODE
                        return "GST_CODE";
                    case 13: // GST_RATE
                        return "GST_RATE";
                    case 14: // ABN
                        return "ABN";
                    case 15: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 16: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 17: // LW_DATE
                        return "LW_DATE";
                    case 18: // LW_TIME
                        return "LW_TIME";
                    case 19: // LW_USER
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
                    case "PRMS_ORDERNO":
                        return 1;
                    case "TRDATE":
                        return 2;
                    case "ORDER_LINENO":
                        return 3;
                    case "ORDER_DESC":
                        return 4;
                    case "GLCODE":
                        return 5;
                    case "GLPROGRAM":
                        return 6;
                    case "GLSUBPROG":
                        return 7;
                    case "GLINIT":
                        return 8;
                    case "TRQTY":
                        return 9;
                    case "AMOUNT":
                        return 10;
                    case "CRKEY":
                        return 11;
                    case "GST_CODE":
                        return 12;
                    case "GST_RATE":
                        return 13;
                    case "ABN":
                        return 14;
                    case "SCHOOL_ID":
                        return 15;
                    case "DELETE_FLAG":
                        return 16;
                    case "LW_DATE":
                        return 17;
                    case "LW_TIME":
                        return 18;
                    case "LW_USER":
                        return 19;
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
