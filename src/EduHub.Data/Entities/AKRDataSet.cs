using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKRDataSet : DataSetBase<AKR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKR"; } }

        internal AKRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AKRKEY = new Lazy<Dictionary<string, AKR>>(() => this.ToDictionary(i => i.AKRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKR" /> fields for each CSV column header</returns>
        protected override Action<AKR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKRKEY":
                        mapper[i] = (e, v) => e.AKRKEY = v;
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
        /// Merges <see cref="AKR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKR" /> items to added or update the base <see cref="AKR" /> items</param>
        /// <returns>A merged list of <see cref="AKR" /> items</returns>
        protected override List<AKR> ApplyDeltaItems(List<AKR> Items, List<AKR> DeltaItems)
        {
            Dictionary<string, int> Index_AKRKEY = Items.ToIndexDictionary(i => i.AKRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKR deltaItem in DeltaItems)
            {
                int index;

                if (Index_AKRKEY.TryGetValue(deltaItem.AKRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.AKRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKR>> Index_AKRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKR FindByAKRKEY(string AKRKEY)
        {
            return Index_AKRKEY.Value[AKRKEY];
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <param name="Value">Related AKR entity</param>
        /// <returns>True if the related AKR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAKRKEY(string AKRKEY, out AKR Value)
        {
            return Index_AKRKEY.Value.TryGetValue(AKRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKR TryFindByAKRKEY(string AKRKEY)
        {
            AKR value;
            if (Index_AKRKEY.Value.TryGetValue(AKRKEY, out value))
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
        /// Returns SQL which checks for the existence of a AKR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKR](
        [AKRKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKR_Index_AKRKEY] PRIMARY KEY CLUSTERED (
            [AKRKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new AKRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKRDataReader : IDataReader, IDataRecord
        {
            private List<AKR> Items;
            private int CurrentIndex;
            private AKR CurrentItem;

            public AKRDataReader(List<AKR> Items)
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
                    case 0: // AKRKEY
                        return CurrentItem.AKRKEY;
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
                    case 0: // AKRKEY
                        return "AKRKEY";
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
                    case "AKRKEY":
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
