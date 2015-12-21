using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDODataSet : EduHubDataSet<KDO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDO"; } }

        internal KDODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KDOKEY = new Lazy<Dictionary<string, KDO>>(() => this.ToDictionary(i => i.KDOKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDO" /> fields for each CSV column header</returns>
        protected override Action<KDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AUSVELS_START":
                        mapper[i] = (e, v) => e.AUSVELS_START = v;
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
        /// Merges <see cref="KDO" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KDO" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KDO" /> items to added or update the base <see cref="KDO" /> items</param>
        /// <returns>A merged list of <see cref="KDO" /> items</returns>
        protected override List<KDO> ApplyDeltaItems(List<KDO> Items, List<KDO> DeltaItems)
        {
            Dictionary<string, int> Index_KDOKEY = Items.ToIndexDictionary(i => i.KDOKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KDO deltaItem in DeltaItems)
            {
                int index;

                if (Index_KDOKEY.TryGetValue(deltaItem.KDOKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KDOKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KDO>> Index_KDOKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDO FindByKDOKEY(string KDOKEY)
        {
            return Index_KDOKEY.Value[KDOKEY];
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <param name="Value">Related KDO entity</param>
        /// <returns>True if the related KDO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKDOKEY(string KDOKEY, out KDO Value)
        {
            return Index_KDOKEY.Value.TryGetValue(KDOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDO TryFindByKDOKEY(string KDOKEY)
        {
            KDO value;
            if (Index_KDOKEY.Value.TryGetValue(KDOKEY, out value))
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
        /// Returns SQL which checks for the existence of a KDO table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KDO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KDO](
        [KDOKEY] varchar(5) NOT NULL,
        [DESCRIPTION] varchar(255) NULL,
        [AUSVELS_START] varchar(6) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KDO_Index_KDOKEY] PRIMARY KEY CLUSTERED (
            [KDOKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDO data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KDODataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KDODataReader : IDataReader, IDataRecord
        {
            private List<KDO> Items;
            private int CurrentIndex;
            private KDO CurrentItem;

            public KDODataReader(List<KDO> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 0: // KDOKEY
                        return CurrentItem.KDOKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // AUSVELS_START
                        return CurrentItem.AUSVELS_START;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
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
                    case 2: // AUSVELS_START
                        return CurrentItem.AUSVELS_START == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KDOKEY
                        return "KDOKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // AUSVELS_START
                        return "AUSVELS_START";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KDOKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "AUSVELS_START":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
