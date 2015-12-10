using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Tax Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKCTDataSet : DataSetBase<AKCT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKCT"; } }

        internal AKCTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CATEGORY = new Lazy<Dictionary<string, AKCT>>(() => this.ToDictionary(i => i.CATEGORY));
            Index_DEPN_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AKCT>>>(() => this.ToGroupedNullDictionary(i => i.DEPN_TMETHOD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKCT" /> fields for each CSV column header</returns>
        protected override Action<AKCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DEPN_TMETHOD":
                        mapper[i] = (e, v) => e.DEPN_TMETHOD = v;
                        break;
                    case "DEPN_TRATE":
                        mapper[i] = (e, v) => e.DEPN_TRATE = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="AKCT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKCT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKCT" /> items to added or update the base <see cref="AKCT" /> items</param>
        /// <returns>A merged list of <see cref="AKCT" /> items</returns>
        protected override List<AKCT> ApplyDeltaItems(List<AKCT> Items, List<AKCT> DeltaItems)
        {
            Dictionary<string, int> Index_CATEGORY = Items.ToIndexDictionary(i => i.CATEGORY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKCT deltaItem in DeltaItems)
            {
                int index;

                if (Index_CATEGORY.TryGetValue(deltaItem.CATEGORY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CATEGORY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKCT>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AKCT>>> Index_DEPN_TMETHOD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKCT by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKCT</param>
        /// <returns>Related AKCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKCT FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find AKCT by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKCT</param>
        /// <param name="Value">Related AKCT entity</param>
        /// <returns>True if the related AKCT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out AKCT Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find AKCT by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKCT</param>
        /// <returns>Related AKCT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKCT TryFindByCATEGORY(string CATEGORY)
        {
            AKCT value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKCT by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKCT</param>
        /// <returns>List of related AKCT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKCT> FindByDEPN_TMETHOD(string DEPN_TMETHOD)
        {
            return Index_DEPN_TMETHOD.Value[DEPN_TMETHOD];
        }

        /// <summary>
        /// Attempt to find AKCT by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKCT</param>
        /// <param name="Value">List of related AKCT entities</param>
        /// <returns>True if the list of related AKCT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPN_TMETHOD(string DEPN_TMETHOD, out IReadOnlyList<AKCT> Value)
        {
            return Index_DEPN_TMETHOD.Value.TryGetValue(DEPN_TMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find AKCT by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKCT</param>
        /// <returns>List of related AKCT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKCT> TryFindByDEPN_TMETHOD(string DEPN_TMETHOD)
        {
            IReadOnlyList<AKCT> value;
            if (Index_DEPN_TMETHOD.Value.TryGetValue(DEPN_TMETHOD, out value))
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
        /// Returns SQL which checks for the existence of a AKCT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKCT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKCT](
        [CATEGORY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [DEPN_TMETHOD] varchar(1) NULL,
        [DEPN_TRATE] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKCT_Index_CATEGORY] PRIMARY KEY CLUSTERED (
            [CATEGORY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [AKCT_Index_DEPN_TMETHOD] ON [dbo].[AKCT]
    (
            [DEPN_TMETHOD] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKCT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKCT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new AKCTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKCTDataReader : IDataReader, IDataRecord
        {
            private List<AKCT> Items;
            private int CurrentIndex;
            private AKCT CurrentItem;

            public AKCTDataReader(List<AKCT> Items)
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
                    case 0: // CATEGORY
                        return CurrentItem.CATEGORY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // DEPN_TMETHOD
                        return CurrentItem.DEPN_TMETHOD;
                    case 3: // DEPN_TRATE
                        return CurrentItem.DEPN_TRATE;
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
                    case 2: // DEPN_TMETHOD
                        return CurrentItem.DEPN_TMETHOD == null;
                    case 3: // DEPN_TRATE
                        return CurrentItem.DEPN_TRATE == null;
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
                    case 0: // CATEGORY
                        return "CATEGORY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // DEPN_TMETHOD
                        return "DEPN_TMETHOD";
                    case 3: // DEPN_TRATE
                        return "DEPN_TRATE";
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
                    case "CATEGORY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "DEPN_TMETHOD":
                        return 2;
                    case "DEPN_TRATE":
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
