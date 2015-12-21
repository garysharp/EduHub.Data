using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCADataSet : EduHubDataSet<SCA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCA"; } }

        internal SCADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCAKEY = new Lazy<Dictionary<string, SCA>>(() => this.ToDictionary(i => i.SCAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCA" /> fields for each CSV column header</returns>
        protected override Action<SCA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCAKEY":
                        mapper[i] = (e, v) => e.SCAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FIRST_DATE":
                        mapper[i] = (e, v) => e.FIRST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DATE":
                        mapper[i] = (e, v) => e.LAST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SCA_MEMO":
                        mapper[i] = (e, v) => e.SCA_MEMO = v;
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
        /// Merges <see cref="SCA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCA" /> items to added or update the base <see cref="SCA" /> items</param>
        /// <returns>A merged list of <see cref="SCA" /> items</returns>
        protected override List<SCA> ApplyDeltaItems(List<SCA> Items, List<SCA> DeltaItems)
        {
            Dictionary<string, int> Index_SCAKEY = Items.ToIndexDictionary(i => i.SCAKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCA deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCAKEY.TryGetValue(deltaItem.SCAKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SCA>> Index_SCAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCA FindBySCAKEY(string SCAKEY)
        {
            return Index_SCAKEY.Value[SCAKEY];
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <param name="Value">Related SCA entity</param>
        /// <returns>True if the related SCA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAKEY(string SCAKEY, out SCA Value)
        {
            return Index_SCAKEY.Value.TryGetValue(SCAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCA TryFindBySCAKEY(string SCAKEY)
        {
            SCA value;
            if (Index_SCAKEY.Value.TryGetValue(SCAKEY, out value))
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
        /// Returns SQL which checks for the existence of a SCA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCA](
        [SCAKEY] varchar(15) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [FIRST_DATE] datetime NULL,
        [LAST_DATE] datetime NULL,
        [SCA_MEMO] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCA_Index_SCAKEY] PRIMARY KEY CLUSTERED (
            [SCAKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCADataReader : IDataReader, IDataRecord
        {
            private List<SCA> Items;
            private int CurrentIndex;
            private SCA CurrentItem;

            public SCADataReader(List<SCA> Items)
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
                    case 0: // SCAKEY
                        return CurrentItem.SCAKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // FIRST_DATE
                        return CurrentItem.FIRST_DATE;
                    case 3: // LAST_DATE
                        return CurrentItem.LAST_DATE;
                    case 4: // SCA_MEMO
                        return CurrentItem.SCA_MEMO;
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
                    case 2: // FIRST_DATE
                        return CurrentItem.FIRST_DATE == null;
                    case 3: // LAST_DATE
                        return CurrentItem.LAST_DATE == null;
                    case 4: // SCA_MEMO
                        return CurrentItem.SCA_MEMO == null;
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
                    case 0: // SCAKEY
                        return "SCAKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // FIRST_DATE
                        return "FIRST_DATE";
                    case 3: // LAST_DATE
                        return "LAST_DATE";
                    case 4: // SCA_MEMO
                        return "SCA_MEMO";
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
                    case "SCAKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "FIRST_DATE":
                        return 2;
                    case "LAST_DATE":
                        return 3;
                    case "SCA_MEMO":
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
