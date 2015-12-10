using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Data Export Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FDT_EXPDataSet : DataSetBase<FDT_EXP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FDT_EXP"; } }

        internal FDT_EXPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEST = new Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>>(() => this.ToGroupedDictionary(i => i.DEST));
            Index_TID = new Lazy<Dictionary<int, FDT_EXP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FDT_EXP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FDT_EXP" /> fields for each CSV column header</returns>
        protected override Action<FDT_EXP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FDT_EXP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "DEST":
                        mapper[i] = (e, v) => e.DEST = v;
                        break;
                    case "DEST_ID":
                        mapper[i] = (e, v) => e.DEST_ID = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "EXP_DATE":
                        mapper[i] = (e, v) => e.EXP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXP_TIME":
                        mapper[i] = (e, v) => e.EXP_TIME = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="FDT_EXP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="FDT_EXP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="FDT_EXP" /> items to added or update the base <see cref="FDT_EXP" /> items</param>
        /// <returns>A merged list of <see cref="FDT_EXP" /> items</returns>
        protected override List<FDT_EXP> ApplyDeltaItems(List<FDT_EXP> Items, List<FDT_EXP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (FDT_EXP deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.DEST)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>> Index_DEST;
        private Lazy<Dictionary<int, FDT_EXP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <returns>List of related FDT_EXP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FDT_EXP> FindByDEST(string DEST)
        {
            return Index_DEST.Value[DEST];
        }

        /// <summary>
        /// Attempt to find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <param name="Value">List of related FDT_EXP entities</param>
        /// <returns>True if the list of related FDT_EXP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEST(string DEST, out IReadOnlyList<FDT_EXP> Value)
        {
            return Index_DEST.Value.TryGetValue(DEST, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <returns>List of related FDT_EXP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FDT_EXP> TryFindByDEST(string DEST)
        {
            IReadOnlyList<FDT_EXP> value;
            if (Index_DEST.Value.TryGetValue(DEST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_EXP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <param name="Value">Related FDT_EXP entity</param>
        /// <returns>True if the related FDT_EXP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out FDT_EXP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_EXP TryFindByTID(int TID)
        {
            FDT_EXP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns SQL which checks for the existence of a FDT_EXP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FDT_EXP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[FDT_EXP](
        [TID] int IDENTITY NOT NULL,
        [DEST] varchar(8) NOT NULL,
        [DEST_ID] varchar(8) NULL,
        [SOURCE] varchar(5) NULL,
        [SOURCE_KEY] varchar(15) NULL,
        [NOTES] text NULL,
        [EXP_DATE] datetime NULL,
        [EXP_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [FDT_EXP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [FDT_EXP_Index_DEST] ON [dbo].[FDT_EXP]
    (
            [DEST] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FDT_EXP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FDT_EXP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new FDT_EXPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class FDT_EXPDataReader : IDataReader, IDataRecord
        {
            private List<FDT_EXP> Items;
            private int CurrentIndex;
            private FDT_EXP CurrentItem;

            public FDT_EXPDataReader(List<FDT_EXP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // DEST
                        return CurrentItem.DEST;
                    case 2: // DEST_ID
                        return CurrentItem.DEST_ID;
                    case 3: // SOURCE
                        return CurrentItem.SOURCE;
                    case 4: // SOURCE_KEY
                        return CurrentItem.SOURCE_KEY;
                    case 5: // NOTES
                        return CurrentItem.NOTES;
                    case 6: // EXP_DATE
                        return CurrentItem.EXP_DATE;
                    case 7: // EXP_TIME
                        return CurrentItem.EXP_TIME;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // DEST_ID
                        return CurrentItem.DEST_ID == null;
                    case 3: // SOURCE
                        return CurrentItem.SOURCE == null;
                    case 4: // SOURCE_KEY
                        return CurrentItem.SOURCE_KEY == null;
                    case 5: // NOTES
                        return CurrentItem.NOTES == null;
                    case 6: // EXP_DATE
                        return CurrentItem.EXP_DATE == null;
                    case 7: // EXP_TIME
                        return CurrentItem.EXP_TIME == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // DEST
                        return "DEST";
                    case 2: // DEST_ID
                        return "DEST_ID";
                    case 3: // SOURCE
                        return "SOURCE";
                    case 4: // SOURCE_KEY
                        return "SOURCE_KEY";
                    case 5: // NOTES
                        return "NOTES";
                    case 6: // EXP_DATE
                        return "EXP_DATE";
                    case 7: // EXP_TIME
                        return "EXP_TIME";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "DEST":
                        return 1;
                    case "DEST_ID":
                        return 2;
                    case "SOURCE":
                        return 3;
                    case "SOURCE_KEY":
                        return 4;
                    case "NOTES":
                        return 5;
                    case "EXP_DATE":
                        return 6;
                    case "EXP_TIME":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
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
