using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KERRORDataSet : EduHubDataSet<KERROR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KERROR"; } }

        internal KERRORDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KERROR_ID = new Lazy<Dictionary<int, KERROR>>(() => this.ToDictionary(i => i.KERROR_ID));
            Index_SPOUTKEY = new Lazy<NullDictionary<string, IReadOnlyList<KERROR>>>(() => this.ToGroupedNullDictionary(i => i.SPOUTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KERROR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KERROR" /> fields for each CSV column header</returns>
        protected override Action<KERROR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KERROR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KERROR_ID":
                        mapper[i] = (e, v) => e.KERROR_ID = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "TEXT01":
                        mapper[i] = (e, v) => e.TEXT01 = v;
                        break;
                    case "TEXT02":
                        mapper[i] = (e, v) => e.TEXT02 = v;
                        break;
                    case "TEXT03":
                        mapper[i] = (e, v) => e.TEXT03 = v;
                        break;
                    case "TEXT04":
                        mapper[i] = (e, v) => e.TEXT04 = v;
                        break;
                    case "TEXT05":
                        mapper[i] = (e, v) => e.TEXT05 = v;
                        break;
                    case "TEXT06":
                        mapper[i] = (e, v) => e.TEXT06 = v;
                        break;
                    case "TEXT07":
                        mapper[i] = (e, v) => e.TEXT07 = v;
                        break;
                    case "TEXT08":
                        mapper[i] = (e, v) => e.TEXT08 = v;
                        break;
                    case "TEXT09":
                        mapper[i] = (e, v) => e.TEXT09 = v;
                        break;
                    case "VALIDATION":
                        mapper[i] = (e, v) => e.VALIDATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROCESSED":
                        mapper[i] = (e, v) => e.PROCESSED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KERROR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KERROR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KERROR" /> items to added or update the base <see cref="KERROR" /> items</param>
        /// <returns>A merged list of <see cref="KERROR" /> items</returns>
        protected override List<KERROR> ApplyDeltaItems(List<KERROR> Items, List<KERROR> DeltaItems)
        {
            Dictionary<int, int> Index_KERROR_ID = Items.ToIndexDictionary(i => i.KERROR_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KERROR deltaItem in DeltaItems)
            {
                int index;

                if (Index_KERROR_ID.TryGetValue(deltaItem.KERROR_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KERROR_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KERROR>> Index_KERROR_ID;
        private Lazy<NullDictionary<string, IReadOnlyList<KERROR>>> Index_SPOUTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KERROR FindByKERROR_ID(int KERROR_ID)
        {
            return Index_KERROR_ID.Value[KERROR_ID];
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <param name="Value">Related KERROR entity</param>
        /// <returns>True if the related KERROR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKERROR_ID(int KERROR_ID, out KERROR Value)
        {
            return Index_KERROR_ID.Value.TryGetValue(KERROR_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KERROR TryFindByKERROR_ID(int KERROR_ID)
        {
            KERROR value;
            if (Index_KERROR_ID.Value.TryGetValue(KERROR_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <returns>List of related KERROR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KERROR> FindBySPOUTKEY(string SPOUTKEY)
        {
            return Index_SPOUTKEY.Value[SPOUTKEY];
        }

        /// <summary>
        /// Attempt to find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <param name="Value">List of related KERROR entities</param>
        /// <returns>True if the list of related KERROR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPOUTKEY(string SPOUTKEY, out IReadOnlyList<KERROR> Value)
        {
            return Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <returns>List of related KERROR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KERROR> TryFindBySPOUTKEY(string SPOUTKEY)
        {
            IReadOnlyList<KERROR> value;
            if (Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out value))
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
        /// Returns SQL which checks for the existence of a KERROR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KERROR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KERROR](
        [KERROR_ID] int IDENTITY NOT NULL,
        [SOURCE] varchar(10) NULL,
        [TEXT01] varchar(30) NULL,
        [TEXT02] varchar(30) NULL,
        [TEXT03] varchar(30) NULL,
        [TEXT04] varchar(30) NULL,
        [TEXT05] varchar(30) NULL,
        [TEXT06] varchar(30) NULL,
        [TEXT07] varchar(30) NULL,
        [TEXT08] varchar(30) NULL,
        [TEXT09] varchar(30) NULL,
        [VALIDATION] smallint NULL,
        [PROCESSED] datetime NULL,
        [STATUS] varchar(3) NULL,
        [ERROR_TEXT] text NULL,
        [SPOUTKEY] varchar(100) NULL,
        CONSTRAINT [KERROR_Index_KERROR_ID] PRIMARY KEY CLUSTERED (
            [KERROR_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KERROR_Index_SPOUTKEY] ON [dbo].[KERROR]
    (
            [SPOUTKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KERROR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KERROR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KERRORDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KERRORDataReader : IDataReader, IDataRecord
        {
            private List<KERROR> Items;
            private int CurrentIndex;
            private KERROR CurrentItem;

            public KERRORDataReader(List<KERROR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 16; } }
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
                    case 0: // KERROR_ID
                        return CurrentItem.KERROR_ID;
                    case 1: // SOURCE
                        return CurrentItem.SOURCE;
                    case 2: // TEXT01
                        return CurrentItem.TEXT01;
                    case 3: // TEXT02
                        return CurrentItem.TEXT02;
                    case 4: // TEXT03
                        return CurrentItem.TEXT03;
                    case 5: // TEXT04
                        return CurrentItem.TEXT04;
                    case 6: // TEXT05
                        return CurrentItem.TEXT05;
                    case 7: // TEXT06
                        return CurrentItem.TEXT06;
                    case 8: // TEXT07
                        return CurrentItem.TEXT07;
                    case 9: // TEXT08
                        return CurrentItem.TEXT08;
                    case 10: // TEXT09
                        return CurrentItem.TEXT09;
                    case 11: // VALIDATION
                        return CurrentItem.VALIDATION;
                    case 12: // PROCESSED
                        return CurrentItem.PROCESSED;
                    case 13: // STATUS
                        return CurrentItem.STATUS;
                    case 14: // ERROR_TEXT
                        return CurrentItem.ERROR_TEXT;
                    case 15: // SPOUTKEY
                        return CurrentItem.SPOUTKEY;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SOURCE
                        return CurrentItem.SOURCE == null;
                    case 2: // TEXT01
                        return CurrentItem.TEXT01 == null;
                    case 3: // TEXT02
                        return CurrentItem.TEXT02 == null;
                    case 4: // TEXT03
                        return CurrentItem.TEXT03 == null;
                    case 5: // TEXT04
                        return CurrentItem.TEXT04 == null;
                    case 6: // TEXT05
                        return CurrentItem.TEXT05 == null;
                    case 7: // TEXT06
                        return CurrentItem.TEXT06 == null;
                    case 8: // TEXT07
                        return CurrentItem.TEXT07 == null;
                    case 9: // TEXT08
                        return CurrentItem.TEXT08 == null;
                    case 10: // TEXT09
                        return CurrentItem.TEXT09 == null;
                    case 11: // VALIDATION
                        return CurrentItem.VALIDATION == null;
                    case 12: // PROCESSED
                        return CurrentItem.PROCESSED == null;
                    case 13: // STATUS
                        return CurrentItem.STATUS == null;
                    case 14: // ERROR_TEXT
                        return CurrentItem.ERROR_TEXT == null;
                    case 15: // SPOUTKEY
                        return CurrentItem.SPOUTKEY == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KERROR_ID
                        return "KERROR_ID";
                    case 1: // SOURCE
                        return "SOURCE";
                    case 2: // TEXT01
                        return "TEXT01";
                    case 3: // TEXT02
                        return "TEXT02";
                    case 4: // TEXT03
                        return "TEXT03";
                    case 5: // TEXT04
                        return "TEXT04";
                    case 6: // TEXT05
                        return "TEXT05";
                    case 7: // TEXT06
                        return "TEXT06";
                    case 8: // TEXT07
                        return "TEXT07";
                    case 9: // TEXT08
                        return "TEXT08";
                    case 10: // TEXT09
                        return "TEXT09";
                    case 11: // VALIDATION
                        return "VALIDATION";
                    case 12: // PROCESSED
                        return "PROCESSED";
                    case 13: // STATUS
                        return "STATUS";
                    case 14: // ERROR_TEXT
                        return "ERROR_TEXT";
                    case 15: // SPOUTKEY
                        return "SPOUTKEY";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KERROR_ID":
                        return 0;
                    case "SOURCE":
                        return 1;
                    case "TEXT01":
                        return 2;
                    case "TEXT02":
                        return 3;
                    case "TEXT03":
                        return 4;
                    case "TEXT04":
                        return 5;
                    case "TEXT05":
                        return 6;
                    case "TEXT06":
                        return 7;
                    case "TEXT07":
                        return 8;
                    case "TEXT08":
                        return 9;
                    case "TEXT09":
                        return 10;
                    case "VALIDATION":
                        return 11;
                    case "PROCESSED":
                        return 12;
                    case "STATUS":
                        return 13;
                    case "ERROR_TEXT":
                        return 14;
                    case "SPOUTKEY":
                        return 15;
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
