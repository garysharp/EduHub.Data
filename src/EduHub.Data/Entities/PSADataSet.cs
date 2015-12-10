using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Award Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSADataSet : DataSetBase<PSA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PSA"; } }

        internal PSADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSAKEY = new Lazy<Dictionary<string, PSA>>(() => this.ToDictionary(i => i.PSAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSA" /> fields for each CSV column header</returns>
        protected override Action<PSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSAKEY":
                        mapper[i] = (e, v) => e.PSAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AWARD_TYPE":
                        mapper[i] = (e, v) => e.AWARD_TYPE = v;
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
        /// Merges <see cref="PSA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PSA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PSA" /> items to added or update the base <see cref="PSA" /> items</param>
        /// <returns>A merged list of <see cref="PSA" /> items</returns>
        protected override List<PSA> ApplyDeltaItems(List<PSA> Items, List<PSA> DeltaItems)
        {
            Dictionary<string, int> Index_PSAKEY = Items.ToIndexDictionary(i => i.PSAKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PSA deltaItem in DeltaItems)
            {
                int index;

                if (Index_PSAKEY.TryGetValue(deltaItem.PSAKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PSAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, PSA>> Index_PSAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSA FindByPSAKEY(string PSAKEY)
        {
            return Index_PSAKEY.Value[PSAKEY];
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <param name="Value">Related PSA entity</param>
        /// <returns>True if the related PSA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSAKEY(string PSAKEY, out PSA Value)
        {
            return Index_PSAKEY.Value.TryGetValue(PSAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSA TryFindByPSAKEY(string PSAKEY)
        {
            PSA value;
            if (Index_PSAKEY.Value.TryGetValue(PSAKEY, out value))
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
        /// Returns SQL which checks for the existence of a PSA table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PSA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PSA](
        [PSAKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [AWARD_TYPE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PSA_Index_PSAKEY] PRIMARY KEY CLUSTERED (
            [PSAKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PSA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PSA data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PSADataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PSADataReader : IDataReader, IDataRecord
        {
            private List<PSA> Items;
            private int CurrentIndex;
            private PSA CurrentItem;

            public PSADataReader(List<PSA> Items)
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
                    case 0: // PSAKEY
                        return CurrentItem.PSAKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // AWARD_TYPE
                        return CurrentItem.AWARD_TYPE;
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
                    case 2: // AWARD_TYPE
                        return CurrentItem.AWARD_TYPE == null;
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
                    case 0: // PSAKEY
                        return "PSAKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // AWARD_TYPE
                        return "AWARD_TYPE";
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
                    case "PSAKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "AWARD_TYPE":
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
