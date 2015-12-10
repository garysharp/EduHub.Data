using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Role Codes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KROLEDataSet : DataSetBase<KROLE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KROLE"; } }

        internal KROLEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KROLEKEY = new Lazy<Dictionary<string, KROLE>>(() => this.ToDictionary(i => i.KROLEKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KROLE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KROLE" /> fields for each CSV column header</returns>
        protected override Action<KROLE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KROLE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KROLEKEY":
                        mapper[i] = (e, v) => e.KROLEKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_NAME":
                        mapper[i] = (e, v) => e.ROLE_NAME = v;
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
        /// Merges <see cref="KROLE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KROLE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KROLE" /> items to added or update the base <see cref="KROLE" /> items</param>
        /// <returns>A merged list of <see cref="KROLE" /> items</returns>
        protected override List<KROLE> ApplyDeltaItems(List<KROLE> Items, List<KROLE> DeltaItems)
        {
            Dictionary<string, int> Index_KROLEKEY = Items.ToIndexDictionary(i => i.KROLEKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KROLE deltaItem in DeltaItems)
            {
                int index;

                if (Index_KROLEKEY.TryGetValue(deltaItem.KROLEKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KROLEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KROLE>> Index_KROLEKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KROLE FindByKROLEKEY(string KROLEKEY)
        {
            return Index_KROLEKEY.Value[KROLEKEY];
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <param name="Value">Related KROLE entity</param>
        /// <returns>True if the related KROLE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKROLEKEY(string KROLEKEY, out KROLE Value)
        {
            return Index_KROLEKEY.Value.TryGetValue(KROLEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KROLE TryFindByKROLEKEY(string KROLEKEY)
        {
            KROLE value;
            if (Index_KROLEKEY.Value.TryGetValue(KROLEKEY, out value))
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
        /// Returns SQL which checks for the existence of a KROLE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KROLE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KROLE](
        [KROLEKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ROLE_NAME] varchar(32) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KROLE_Index_KROLEKEY] PRIMARY KEY CLUSTERED (
            [KROLEKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KROLE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KROLE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KROLEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KROLEDataReader : IDataReader, IDataRecord
        {
            private List<KROLE> Items;
            private int CurrentIndex;
            private KROLE CurrentItem;

            public KROLEDataReader(List<KROLE> Items)
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
                    case 0: // KROLEKEY
                        return CurrentItem.KROLEKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // ROLE_NAME
                        return CurrentItem.ROLE_NAME;
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
                    case 2: // ROLE_NAME
                        return CurrentItem.ROLE_NAME == null;
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
                    case 0: // KROLEKEY
                        return "KROLEKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ROLE_NAME
                        return "ROLE_NAME";
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
                    case "KROLEKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ROLE_NAME":
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
