using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSCDataSet : DataSetBase<KSC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSC"; } }

        internal KSCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSCKEY = new Lazy<Dictionary<string, KSC>>(() => this.ToDictionary(i => i.KSCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSC" /> fields for each CSV column header</returns>
        protected override Action<KSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSCKEY":
                        mapper[i] = (e, v) => e.KSCKEY = v;
                        break;
                    case "SF_POSITION":
                        mapper[i] = (e, v) => e.SF_POSITION = v;
                        break;
                    case "ALLOTMENT":
                        mapper[i] = (e, v) => e.ALLOTMENT = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KSC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KSC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KSC" /> items to added or update the base <see cref="KSC" /> items</param>
        /// <returns>A merged list of <see cref="KSC" /> items</returns>
        protected override List<KSC> ApplyDeltaItems(List<KSC> Items, List<KSC> DeltaItems)
        {
            Dictionary<string, int> Index_KSCKEY = Items.ToIndexDictionary(i => i.KSCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KSC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KSCKEY.TryGetValue(deltaItem.KSCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KSCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KSC>> Index_KSCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSC FindByKSCKEY(string KSCKEY)
        {
            return Index_KSCKEY.Value[KSCKEY];
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <param name="Value">Related KSC entity</param>
        /// <returns>True if the related KSC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSCKEY(string KSCKEY, out KSC Value)
        {
            return Index_KSCKEY.Value.TryGetValue(KSCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSC TryFindByKSCKEY(string KSCKEY)
        {
            KSC value;
            if (Index_KSCKEY.Value.TryGetValue(KSCKEY, out value))
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
        /// Returns SQL which checks for the existence of a KSC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSC](
        [KSCKEY] varchar(6) NOT NULL,
        [SF_POSITION] varchar(30) NULL,
        [ALLOTMENT] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSC_Index_KSCKEY] PRIMARY KEY CLUSTERED (
            [KSCKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KSCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSCDataReader : IDataReader, IDataRecord
        {
            private List<KSC> Items;
            private int CurrentIndex;
            private KSC CurrentItem;

            public KSCDataReader(List<KSC> Items)
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
                    case 0: // KSCKEY
                        return CurrentItem.KSCKEY;
                    case 1: // SF_POSITION
                        return CurrentItem.SF_POSITION;
                    case 2: // ALLOTMENT
                        return CurrentItem.ALLOTMENT;
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
                    case 1: // SF_POSITION
                        return CurrentItem.SF_POSITION == null;
                    case 2: // ALLOTMENT
                        return CurrentItem.ALLOTMENT == null;
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
                    case 0: // KSCKEY
                        return "KSCKEY";
                    case 1: // SF_POSITION
                        return "SF_POSITION";
                    case 2: // ALLOTMENT
                        return "ALLOTMENT";
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
                    case "KSCKEY":
                        return 0;
                    case "SF_POSITION":
                        return 1;
                    case "ALLOTMENT":
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
