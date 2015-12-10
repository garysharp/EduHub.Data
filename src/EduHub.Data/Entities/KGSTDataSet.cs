using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGSTDataSet : DataSetBase<KGST>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGST"; } }

        internal KGSTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLGST_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KGST>>>(() => this.ToGroupedNullDictionary(i => i.GLGST_CODE));
            Index_KGSTKEY = new Lazy<Dictionary<string, KGST>>(() => this.ToDictionary(i => i.KGSTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGST" /> fields for each CSV column header</returns>
        protected override Action<KGST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGSTKEY":
                        mapper[i] = (e, v) => e.KGSTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SALE_PURCH":
                        mapper[i] = (e, v) => e.SALE_PURCH = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GLGST_CODE":
                        mapper[i] = (e, v) => e.GLGST_CODE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "PRIOR_PERIOD_GST":
                        mapper[i] = (e, v) => e.PRIOR_PERIOD_GST = v;
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
        /// Merges <see cref="KGST" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGST" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGST" /> items to added or update the base <see cref="KGST" /> items</param>
        /// <returns>A merged list of <see cref="KGST" /> items</returns>
        protected override List<KGST> ApplyDeltaItems(List<KGST> Items, List<KGST> DeltaItems)
        {
            Dictionary<string, int> Index_KGSTKEY = Items.ToIndexDictionary(i => i.KGSTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGST deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGSTKEY.TryGetValue(deltaItem.KGSTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGSTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KGST>>> Index_GLGST_CODE;
        private Lazy<Dictionary<string, KGST>> Index_KGSTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <returns>List of related KGST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGST> FindByGLGST_CODE(string GLGST_CODE)
        {
            return Index_GLGST_CODE.Value[GLGST_CODE];
        }

        /// <summary>
        /// Attempt to find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <param name="Value">List of related KGST entities</param>
        /// <returns>True if the list of related KGST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLGST_CODE(string GLGST_CODE, out IReadOnlyList<KGST> Value)
        {
            return Index_GLGST_CODE.Value.TryGetValue(GLGST_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <returns>List of related KGST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGST> TryFindByGLGST_CODE(string GLGST_CODE)
        {
            IReadOnlyList<KGST> value;
            if (Index_GLGST_CODE.Value.TryGetValue(GLGST_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGST FindByKGSTKEY(string KGSTKEY)
        {
            return Index_KGSTKEY.Value[KGSTKEY];
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <param name="Value">Related KGST entity</param>
        /// <returns>True if the related KGST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGSTKEY(string KGSTKEY, out KGST Value)
        {
            return Index_KGSTKEY.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGST TryFindByKGSTKEY(string KGSTKEY)
        {
            KGST value;
            if (Index_KGSTKEY.Value.TryGetValue(KGSTKEY, out value))
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
        /// Returns SQL which checks for the existence of a KGST table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGST](
        [KGSTKEY] varchar(4) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [SALE_PURCH] varchar(2) NULL,
        [GST_RATE] float NULL,
        [GST_BOX] varchar(3) NULL,
        [GLGST_CODE] varchar(10) NULL,
        [GST_RECLAIM] varchar(1) NULL,
        [PRIOR_PERIOD_GST] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGST_Index_KGSTKEY] PRIMARY KEY CLUSTERED (
            [KGSTKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGST_Index_GLGST_CODE] ON [dbo].[KGST]
    (
            [GLGST_CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGST data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KGSTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGSTDataReader : IDataReader, IDataRecord
        {
            private List<KGST> Items;
            private int CurrentIndex;
            private KGST CurrentItem;

            public KGSTDataReader(List<KGST> Items)
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
                    case 0: // KGSTKEY
                        return CurrentItem.KGSTKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // SALE_PURCH
                        return CurrentItem.SALE_PURCH;
                    case 3: // GST_RATE
                        return CurrentItem.GST_RATE;
                    case 4: // GST_BOX
                        return CurrentItem.GST_BOX;
                    case 5: // GLGST_CODE
                        return CurrentItem.GLGST_CODE;
                    case 6: // GST_RECLAIM
                        return CurrentItem.GST_RECLAIM;
                    case 7: // PRIOR_PERIOD_GST
                        return CurrentItem.PRIOR_PERIOD_GST;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // SALE_PURCH
                        return CurrentItem.SALE_PURCH == null;
                    case 3: // GST_RATE
                        return CurrentItem.GST_RATE == null;
                    case 4: // GST_BOX
                        return CurrentItem.GST_BOX == null;
                    case 5: // GLGST_CODE
                        return CurrentItem.GLGST_CODE == null;
                    case 6: // GST_RECLAIM
                        return CurrentItem.GST_RECLAIM == null;
                    case 7: // PRIOR_PERIOD_GST
                        return CurrentItem.PRIOR_PERIOD_GST == null;
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
                    case 0: // KGSTKEY
                        return "KGSTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SALE_PURCH
                        return "SALE_PURCH";
                    case 3: // GST_RATE
                        return "GST_RATE";
                    case 4: // GST_BOX
                        return "GST_BOX";
                    case 5: // GLGST_CODE
                        return "GLGST_CODE";
                    case 6: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 7: // PRIOR_PERIOD_GST
                        return "PRIOR_PERIOD_GST";
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
                    case "KGSTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SALE_PURCH":
                        return 2;
                    case "GST_RATE":
                        return 3;
                    case "GST_BOX":
                        return 4;
                    case "GLGST_CODE":
                        return 5;
                    case "GST_RECLAIM":
                        return 6;
                    case "PRIOR_PERIOD_GST":
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
