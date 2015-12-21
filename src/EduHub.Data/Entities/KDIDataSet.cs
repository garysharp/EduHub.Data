using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDIDataSet : EduHubDataSet<KDI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDI"; } }

        internal KDIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KDIKEY = new Lazy<Dictionary<string, KDI>>(() => this.ToDictionary(i => i.KDIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDI" /> fields for each CSV column header</returns>
        protected override Action<KDI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDIKEY":
                        mapper[i] = (e, v) => e.KDIKEY = v;
                        break;
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MIN_SCORE":
                        mapper[i] = (e, v) => e.MIN_SCORE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MAX_SCORE":
                        mapper[i] = (e, v) => e.MAX_SCORE = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="KDI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KDI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KDI" /> items to added or update the base <see cref="KDI" /> items</param>
        /// <returns>A merged list of <see cref="KDI" /> items</returns>
        protected override List<KDI> ApplyDeltaItems(List<KDI> Items, List<KDI> DeltaItems)
        {
            Dictionary<string, int> Index_KDIKEY = Items.ToIndexDictionary(i => i.KDIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KDI deltaItem in DeltaItems)
            {
                int index;

                if (Index_KDIKEY.TryGetValue(deltaItem.KDIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KDIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KDI>> Index_KDIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDI FindByKDIKEY(string KDIKEY)
        {
            return Index_KDIKEY.Value[KDIKEY];
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <param name="Value">Related KDI entity</param>
        /// <returns>True if the related KDI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKDIKEY(string KDIKEY, out KDI Value)
        {
            return Index_KDIKEY.Value.TryGetValue(KDIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDI TryFindByKDIKEY(string KDIKEY)
        {
            KDI value;
            if (Index_KDIKEY.Value.TryGetValue(KDIKEY, out value))
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
        /// Returns SQL which checks for the existence of a KDI table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KDI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KDI](
        [KDIKEY] varchar(10) NOT NULL,
        [KDOKEY] varchar(5) NULL,
        [DESCRIPTION] varchar(255) NULL,
        [MIN_SCORE] float NULL,
        [MAX_SCORE] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KDI_Index_KDIKEY] PRIMARY KEY CLUSTERED (
            [KDIKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDI data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KDIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KDIDataReader : IDataReader, IDataRecord
        {
            private List<KDI> Items;
            private int CurrentIndex;
            private KDI CurrentItem;

            public KDIDataReader(List<KDI> Items)
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
                    case 0: // KDIKEY
                        return CurrentItem.KDIKEY;
                    case 1: // KDOKEY
                        return CurrentItem.KDOKEY;
                    case 2: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 3: // MIN_SCORE
                        return CurrentItem.MIN_SCORE;
                    case 4: // MAX_SCORE
                        return CurrentItem.MAX_SCORE;
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
                    case 1: // KDOKEY
                        return CurrentItem.KDOKEY == null;
                    case 2: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 3: // MIN_SCORE
                        return CurrentItem.MIN_SCORE == null;
                    case 4: // MAX_SCORE
                        return CurrentItem.MAX_SCORE == null;
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
                    case 0: // KDIKEY
                        return "KDIKEY";
                    case 1: // KDOKEY
                        return "KDOKEY";
                    case 2: // DESCRIPTION
                        return "DESCRIPTION";
                    case 3: // MIN_SCORE
                        return "MIN_SCORE";
                    case 4: // MAX_SCORE
                        return "MAX_SCORE";
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
                    case "KDIKEY":
                        return 0;
                    case "KDOKEY":
                        return 1;
                    case "DESCRIPTION":
                        return 2;
                    case "MIN_SCORE":
                        return 3;
                    case "MAX_SCORE":
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
