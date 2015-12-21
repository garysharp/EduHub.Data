using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCRDataSet : EduHubDataSet<KPCR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPCR"; } }

        internal KPCRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPCRKEY = new Lazy<Dictionary<string, KPCR>>(() => this.ToDictionary(i => i.KPCRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCR" /> fields for each CSV column header</returns>
        protected override Action<KPCR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCRKEY":
                        mapper[i] = (e, v) => e.KPCRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KPCR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPCR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPCR" /> items to added or update the base <see cref="KPCR" /> items</param>
        /// <returns>A merged list of <see cref="KPCR" /> items</returns>
        protected override List<KPCR> ApplyDeltaItems(List<KPCR> Items, List<KPCR> DeltaItems)
        {
            Dictionary<string, int> Index_KPCRKEY = Items.ToIndexDictionary(i => i.KPCRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPCR deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPCRKEY.TryGetValue(deltaItem.KPCRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPCRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KPCR>> Index_KPCRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCR FindByKPCRKEY(string KPCRKEY)
        {
            return Index_KPCRKEY.Value[KPCRKEY];
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <param name="Value">Related KPCR entity</param>
        /// <returns>True if the related KPCR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCRKEY(string KPCRKEY, out KPCR Value)
        {
            return Index_KPCRKEY.Value.TryGetValue(KPCRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCR TryFindByKPCRKEY(string KPCRKEY)
        {
            KPCR value;
            if (Index_KPCRKEY.Value.TryGetValue(KPCRKEY, out value))
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
        /// Returns SQL which checks for the existence of a KPCR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPCR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPCR](
        [KPCRKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPCR_Index_KPCRKEY] PRIMARY KEY CLUSTERED (
            [KPCRKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPCR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPCR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KPCRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPCRDataReader : IDataReader, IDataRecord
        {
            private List<KPCR> Items;
            private int CurrentIndex;
            private KPCR CurrentItem;

            public KPCRDataReader(List<KPCR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 5; } }
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
                    case 0: // KPCRKEY
                        return CurrentItem.KPCRKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 3: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 3: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 4: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KPCRKEY
                        return "KPCRKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KPCRKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
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
