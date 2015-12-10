using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payment Summary Box Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGDataSet : DataSetBase<PG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PG"; } }

        internal PGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PAYG_BOX = new Lazy<Dictionary<short, PG>>(() => this.ToDictionary(i => i.PAYG_BOX));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PG" /> fields for each CSV column header</returns>
        protected override Action<PG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = short.Parse(v);
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
        /// Merges <see cref="PG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PG" /> items to added or update the base <see cref="PG" /> items</param>
        /// <returns>A merged list of <see cref="PG" /> items</returns>
        protected override List<PG> ApplyDeltaItems(List<PG> Items, List<PG> DeltaItems)
        {
            Dictionary<short, int> Index_PAYG_BOX = Items.ToIndexDictionary(i => i.PAYG_BOX);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PG deltaItem in DeltaItems)
            {
                int index;

                if (Index_PAYG_BOX.TryGetValue(deltaItem.PAYG_BOX, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PAYG_BOX)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, PG>> Index_PAYG_BOX;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PG FindByPAYG_BOX(short PAYG_BOX)
        {
            return Index_PAYG_BOX.Value[PAYG_BOX];
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <param name="Value">Related PG entity</param>
        /// <returns>True if the related PG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYG_BOX(short PAYG_BOX, out PG Value)
        {
            return Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out Value);
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PG TryFindByPAYG_BOX(short PAYG_BOX)
        {
            PG value;
            if (Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out value))
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
        /// Returns SQL which checks for the existence of a PG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PG](
        [PAYG_BOX] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PG_Index_PAYG_BOX] PRIMARY KEY CLUSTERED (
            [PAYG_BOX] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PGDataReader : IDataReader, IDataRecord
        {
            private List<PG> Items;
            private int CurrentIndex;
            private PG CurrentItem;

            public PGDataReader(List<PG> Items)
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
                    case 0: // PAYG_BOX
                        return CurrentItem.PAYG_BOX;
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
                    case 0: // PAYG_BOX
                        return "PAYG_BOX";
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
                    case "PAYG_BOX":
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
