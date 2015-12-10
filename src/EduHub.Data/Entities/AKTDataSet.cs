using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKTDataSet : DataSetBase<AKT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKT"; } }

        internal AKTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AKTKEY = new Lazy<Dictionary<string, AKT>>(() => this.ToDictionary(i => i.AKTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKT" /> fields for each CSV column header</returns>
        protected override Action<AKT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKTKEY":
                        mapper[i] = (e, v) => e.AKTKEY = v;
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
        /// Merges <see cref="AKT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKT" /> items to added or update the base <see cref="AKT" /> items</param>
        /// <returns>A merged list of <see cref="AKT" /> items</returns>
        protected override List<AKT> ApplyDeltaItems(List<AKT> Items, List<AKT> DeltaItems)
        {
            Dictionary<string, int> Index_AKTKEY = Items.ToIndexDictionary(i => i.AKTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKT deltaItem in DeltaItems)
            {
                int index;

                if (Index_AKTKEY.TryGetValue(deltaItem.AKTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.AKTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKT>> Index_AKTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKT FindByAKTKEY(string AKTKEY)
        {
            return Index_AKTKEY.Value[AKTKEY];
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <param name="Value">Related AKT entity</param>
        /// <returns>True if the related AKT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAKTKEY(string AKTKEY, out AKT Value)
        {
            return Index_AKTKEY.Value.TryGetValue(AKTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKT TryFindByAKTKEY(string AKTKEY)
        {
            AKT value;
            if (Index_AKTKEY.Value.TryGetValue(AKTKEY, out value))
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
        /// Returns SQL which checks for the existence of a AKT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKT](
        [AKTKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKT_Index_AKTKEY] PRIMARY KEY CLUSTERED (
            [AKTKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new AKTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKTDataReader : IDataReader, IDataRecord
        {
            private List<AKT> Items;
            private int CurrentIndex;
            private AKT CurrentItem;

            public AKTDataReader(List<AKT> Items)
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
                    case 0: // AKTKEY
                        return CurrentItem.AKTKEY;
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
                    case 0: // AKTKEY
                        return "AKTKEY";
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
                    case "AKTKEY":
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
