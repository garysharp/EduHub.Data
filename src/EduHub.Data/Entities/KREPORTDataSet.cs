using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KREPORTDataSet : EduHubDataSet<KREPORT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KREPORT"; } }

        internal KREPORTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KREPORTKEY = new Lazy<Dictionary<string, KREPORT>>(() => this.ToDictionary(i => i.KREPORTKEY));
            Index_ROLE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KREPORT>>>(() => this.ToGroupedNullDictionary(i => i.ROLE_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KREPORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KREPORT" /> fields for each CSV column header</returns>
        protected override Action<KREPORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KREPORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KREPORTKEY":
                        mapper[i] = (e, v) => e.KREPORTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_CODE":
                        mapper[i] = (e, v) => e.ROLE_CODE = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
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
        /// Merges <see cref="KREPORT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KREPORT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KREPORT" /> items to added or update the base <see cref="KREPORT" /> items</param>
        /// <returns>A merged list of <see cref="KREPORT" /> items</returns>
        protected override List<KREPORT> ApplyDeltaItems(List<KREPORT> Items, List<KREPORT> DeltaItems)
        {
            Dictionary<string, int> Index_KREPORTKEY = Items.ToIndexDictionary(i => i.KREPORTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KREPORT deltaItem in DeltaItems)
            {
                int index;

                if (Index_KREPORTKEY.TryGetValue(deltaItem.KREPORTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KREPORTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KREPORT>> Index_KREPORTKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KREPORT>>> Index_ROLE_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KREPORT FindByKREPORTKEY(string KREPORTKEY)
        {
            return Index_KREPORTKEY.Value[KREPORTKEY];
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <param name="Value">Related KREPORT entity</param>
        /// <returns>True if the related KREPORT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKREPORTKEY(string KREPORTKEY, out KREPORT Value)
        {
            return Index_KREPORTKEY.Value.TryGetValue(KREPORTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KREPORT TryFindByKREPORTKEY(string KREPORTKEY)
        {
            KREPORT value;
            if (Index_KREPORTKEY.Value.TryGetValue(KREPORTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <returns>List of related KREPORT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KREPORT> FindByROLE_CODE(string ROLE_CODE)
        {
            return Index_ROLE_CODE.Value[ROLE_CODE];
        }

        /// <summary>
        /// Attempt to find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <param name="Value">List of related KREPORT entities</param>
        /// <returns>True if the list of related KREPORT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROLE_CODE(string ROLE_CODE, out IReadOnlyList<KREPORT> Value)
        {
            return Index_ROLE_CODE.Value.TryGetValue(ROLE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <returns>List of related KREPORT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KREPORT> TryFindByROLE_CODE(string ROLE_CODE)
        {
            IReadOnlyList<KREPORT> value;
            if (Index_ROLE_CODE.Value.TryGetValue(ROLE_CODE, out value))
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
        /// Returns SQL which checks for the existence of a KREPORT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KREPORT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KREPORT](
        [KREPORTKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [ROLE_CODE] varchar(2) NULL,
        [REPORT_NAME] varchar(80) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KREPORT_Index_KREPORTKEY] PRIMARY KEY CLUSTERED (
            [KREPORTKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KREPORT_Index_ROLE_CODE] ON [dbo].[KREPORT]
    (
            [ROLE_CODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KREPORT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KREPORT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KREPORTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KREPORTDataReader : IDataReader, IDataRecord
        {
            private List<KREPORT> Items;
            private int CurrentIndex;
            private KREPORT CurrentItem;

            public KREPORTDataReader(List<KREPORT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 0: // KREPORTKEY
                        return CurrentItem.KREPORTKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // ROLE_CODE
                        return CurrentItem.ROLE_CODE;
                    case 3: // REPORT_NAME
                        return CurrentItem.REPORT_NAME;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 6: // LW_USER
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
                    case 2: // ROLE_CODE
                        return CurrentItem.ROLE_CODE == null;
                    case 3: // REPORT_NAME
                        return CurrentItem.REPORT_NAME == null;
                    case 4: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 5: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 6: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KREPORTKEY
                        return "KREPORTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ROLE_CODE
                        return "ROLE_CODE";
                    case 3: // REPORT_NAME
                        return "REPORT_NAME";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KREPORTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ROLE_CODE":
                        return 2;
                    case "REPORT_NAME":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
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
