using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Witnesses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADWDataSet : DataSetBase<SADW>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SADW"; } }

        internal SADWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<Dictionary<int, IReadOnlyList<SADW>>>(() => this.ToGroupedDictionary(i => i.ACCIDENTID));
            Index_TID = new Lazy<Dictionary<int, SADW>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADW" /> fields for each CSV column header</returns>
        protected override Action<SADW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = int.Parse(v);
                        break;
                    case "WITNESS_TYPE":
                        mapper[i] = (e, v) => e.WITNESS_TYPE = v;
                        break;
                    case "WITNESSKEY":
                        mapper[i] = (e, v) => e.WITNESSKEY = v;
                        break;
                    case "WITNESS_DFAB":
                        mapper[i] = (e, v) => e.WITNESS_DFAB = v;
                        break;
                    case "FULL_NAME":
                        mapper[i] = (e, v) => e.FULL_NAME = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
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
        /// Merges <see cref="SADW" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SADW" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SADW" /> items to added or update the base <see cref="SADW" /> items</param>
        /// <returns>A merged list of <see cref="SADW" /> items</returns>
        protected override List<SADW> ApplyDeltaItems(List<SADW> Items, List<SADW> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SADW deltaItem in DeltaItems)
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
                .OrderBy(i => i.ACCIDENTID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SADW>>> Index_ACCIDENTID;
        private Lazy<Dictionary<int, SADW>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <returns>List of related SADW entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADW> FindByACCIDENTID(int ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <param name="Value">List of related SADW entities</param>
        /// <returns>True if the list of related SADW entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int ACCIDENTID, out IReadOnlyList<SADW> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <returns>List of related SADW entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADW> TryFindByACCIDENTID(int ACCIDENTID)
        {
            IReadOnlyList<SADW> value;
            if (Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <returns>Related SADW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADW FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <param name="Value">Related SADW entity</param>
        /// <returns>True if the related SADW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SADW Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <returns>Related SADW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADW TryFindByTID(int TID)
        {
            SADW value;
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
        /// Returns SQL which checks for the existence of a SADW table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SADW]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SADW](
        [TID] int IDENTITY NOT NULL,
        [ACCIDENTID] int NOT NULL,
        [WITNESS_TYPE] varchar(2) NULL,
        [WITNESSKEY] varchar(10) NULL,
        [WITNESS_DFAB] varchar(1) NULL,
        [FULL_NAME] varchar(64) NULL,
        [ADDRESS] varchar(120) NULL,
        [TELEPHONE] varchar(20) NULL,
        [STATEMENT] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SADW_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SADW_Index_ACCIDENTID] ON [dbo].[SADW]
    (
            [ACCIDENTID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADW data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADW data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SADWDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADWDataReader : IDataReader, IDataRecord
        {
            private List<SADW> Items;
            private int CurrentIndex;
            private SADW CurrentItem;

            public SADWDataReader(List<SADW> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 12; } }
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
                    case 1: // ACCIDENTID
                        return CurrentItem.ACCIDENTID;
                    case 2: // WITNESS_TYPE
                        return CurrentItem.WITNESS_TYPE;
                    case 3: // WITNESSKEY
                        return CurrentItem.WITNESSKEY;
                    case 4: // WITNESS_DFAB
                        return CurrentItem.WITNESS_DFAB;
                    case 5: // FULL_NAME
                        return CurrentItem.FULL_NAME;
                    case 6: // ADDRESS
                        return CurrentItem.ADDRESS;
                    case 7: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 8: // STATEMENT
                        return CurrentItem.STATEMENT;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 11: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // WITNESS_TYPE
                        return CurrentItem.WITNESS_TYPE == null;
                    case 3: // WITNESSKEY
                        return CurrentItem.WITNESSKEY == null;
                    case 4: // WITNESS_DFAB
                        return CurrentItem.WITNESS_DFAB == null;
                    case 5: // FULL_NAME
                        return CurrentItem.FULL_NAME == null;
                    case 6: // ADDRESS
                        return CurrentItem.ADDRESS == null;
                    case 7: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 8: // STATEMENT
                        return CurrentItem.STATEMENT == null;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 10: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 11: // LW_USER
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
                    case 1: // ACCIDENTID
                        return "ACCIDENTID";
                    case 2: // WITNESS_TYPE
                        return "WITNESS_TYPE";
                    case 3: // WITNESSKEY
                        return "WITNESSKEY";
                    case 4: // WITNESS_DFAB
                        return "WITNESS_DFAB";
                    case 5: // FULL_NAME
                        return "FULL_NAME";
                    case 6: // ADDRESS
                        return "ADDRESS";
                    case 7: // TELEPHONE
                        return "TELEPHONE";
                    case 8: // STATEMENT
                        return "STATEMENT";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
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
                    case "ACCIDENTID":
                        return 1;
                    case "WITNESS_TYPE":
                        return 2;
                    case "WITNESSKEY":
                        return 3;
                    case "WITNESS_DFAB":
                        return 4;
                    case "FULL_NAME":
                        return 5;
                    case "ADDRESS":
                        return 6;
                    case "TELEPHONE":
                        return 7;
                    case "STATEMENT":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
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
