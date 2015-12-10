using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADMDataSet : DataSetBase<KADM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KADM"; } }

        internal KADMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KADMKEY = new Lazy<Dictionary<string, KADM>>(() => this.ToDictionary(i => i.KADMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KADM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KADM" /> fields for each CSV column header</returns>
        protected override Action<KADM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KADM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADMKEY":
                        mapper[i] = (e, v) => e.KADMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "DATE_BASED":
                        mapper[i] = (e, v) => e.DATE_BASED = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
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
        /// Merges <see cref="KADM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KADM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KADM" /> items to added or update the base <see cref="KADM" /> items</param>
        /// <returns>A merged list of <see cref="KADM" /> items</returns>
        protected override List<KADM> ApplyDeltaItems(List<KADM> Items, List<KADM> DeltaItems)
        {
            Dictionary<string, int> Index_KADMKEY = Items.ToIndexDictionary(i => i.KADMKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KADM deltaItem in DeltaItems)
            {
                int index;

                if (Index_KADMKEY.TryGetValue(deltaItem.KADMKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KADMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KADM>> Index_KADMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KADM FindByKADMKEY(string KADMKEY)
        {
            return Index_KADMKEY.Value[KADMKEY];
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <param name="Value">Related KADM entity</param>
        /// <returns>True if the related KADM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKADMKEY(string KADMKEY, out KADM Value)
        {
            return Index_KADMKEY.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KADM TryFindByKADMKEY(string KADMKEY)
        {
            KADM value;
            if (Index_KADMKEY.Value.TryGetValue(KADMKEY, out value))
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
        /// Returns SQL which checks for the existence of a KADM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KADM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KADM](
        [KADMKEY] varchar(1) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [DETAIL] text NULL,
        [DATE_BASED] varchar(1) NULL,
        [TAX] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KADM_Index_KADMKEY] PRIMARY KEY CLUSTERED (
            [KADMKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KADM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KADM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KADMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KADMDataReader : IDataReader, IDataRecord
        {
            private List<KADM> Items;
            private int CurrentIndex;
            private KADM CurrentItem;

            public KADMDataReader(List<KADM> Items)
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
                    case 0: // KADMKEY
                        return CurrentItem.KADMKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // DETAIL
                        return CurrentItem.DETAIL;
                    case 3: // DATE_BASED
                        return CurrentItem.DATE_BASED;
                    case 4: // TAX
                        return CurrentItem.TAX;
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
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // DETAIL
                        return CurrentItem.DETAIL == null;
                    case 3: // DATE_BASED
                        return CurrentItem.DATE_BASED == null;
                    case 4: // TAX
                        return CurrentItem.TAX == null;
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
                    case 0: // KADMKEY
                        return "KADMKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // DETAIL
                        return "DETAIL";
                    case 3: // DATE_BASED
                        return "DATE_BASED";
                    case 4: // TAX
                        return "TAX";
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
                    case "KADMKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "DETAIL":
                        return 2;
                    case "DATE_BASED":
                        return 3;
                    case "TAX":
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
