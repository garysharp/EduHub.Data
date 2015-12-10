using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFHIDataSet : DataSetBase<DFHI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFHI"; } }

        internal DFHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FKEY = new Lazy<Dictionary<string, IReadOnlyList<DFHI>>>(() => this.ToGroupedDictionary(i => i.FKEY));
            Index_TID = new Lazy<Dictionary<int, DFHI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFHI" /> fields for each CSV column header</returns>
        protected override Action<DFHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FKEY":
                        mapper[i] = (e, v) => e.FKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HKEY":
                        mapper[i] = (e, v) => e.HKEY = v;
                        break;
                    case "NAME_A":
                        mapper[i] = (e, v) => e.NAME_A = v;
                        break;
                    case "SURNAME_A":
                        mapper[i] = (e, v) => e.SURNAME_A = v;
                        break;
                    case "TITLE_A":
                        mapper[i] = (e, v) => e.TITLE_A = v;
                        break;
                    case "GENDER_A":
                        mapper[i] = (e, v) => e.GENDER_A = v;
                        break;
                    case "NAME_B":
                        mapper[i] = (e, v) => e.NAME_B = v;
                        break;
                    case "SURNAME_B":
                        mapper[i] = (e, v) => e.SURNAME_B = v;
                        break;
                    case "TITLE_B":
                        mapper[i] = (e, v) => e.TITLE_B = v;
                        break;
                    case "GENDER_B":
                        mapper[i] = (e, v) => e.GENDER_B = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="DFHI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFHI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFHI" /> items to added or update the base <see cref="DFHI" /> items</param>
        /// <returns>A merged list of <see cref="DFHI" /> items</returns>
        protected override List<DFHI> ApplyDeltaItems(List<DFHI> Items, List<DFHI> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFHI deltaItem in DeltaItems)
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
                .OrderBy(i => i.FKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFHI>>> Index_FKEY;
        private Lazy<Dictionary<int, DFHI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <returns>List of related DFHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFHI> FindByFKEY(string FKEY)
        {
            return Index_FKEY.Value[FKEY];
        }

        /// <summary>
        /// Attempt to find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <param name="Value">List of related DFHI entities</param>
        /// <returns>True if the list of related DFHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFKEY(string FKEY, out IReadOnlyList<DFHI> Value)
        {
            return Index_FKEY.Value.TryGetValue(FKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <returns>List of related DFHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFHI> TryFindByFKEY(string FKEY)
        {
            IReadOnlyList<DFHI> value;
            if (Index_FKEY.Value.TryGetValue(FKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <returns>Related DFHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFHI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <param name="Value">Related DFHI entity</param>
        /// <returns>True if the related DFHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFHI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <returns>Related DFHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFHI TryFindByTID(int TID)
        {
            DFHI value;
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
        /// Returns SQL which checks for the existence of a DFHI table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DFHI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DFHI](
        [TID] int IDENTITY NOT NULL,
        [FKEY] varchar(10) NOT NULL,
        [CREATION_USER] varchar(128) NULL,
        [CREATION_DATE] datetime NULL,
        [CREATION_TIME] smallint NULL,
        [OBSOLETE_USER] varchar(128) NULL,
        [OBSOLETE_DATE] datetime NULL,
        [OBSOLETE_TIME] smallint NULL,
        [HKEY] varchar(10) NULL,
        [NAME_A] varchar(30) NULL,
        [SURNAME_A] varchar(30) NULL,
        [TITLE_A] varchar(4) NULL,
        [GENDER_A] varchar(1) NULL,
        [NAME_B] varchar(30) NULL,
        [SURNAME_B] varchar(30) NULL,
        [TITLE_B] varchar(4) NULL,
        [GENDER_B] varchar(1) NULL,
        [HOMEKEY] int NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [CHANGE_MADE] varchar(80) NULL,
        CONSTRAINT [DFHI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [DFHI_Index_FKEY] ON [dbo].[DFHI]
    (
            [FKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DFHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFHI data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DFHIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFHIDataReader : IDataReader, IDataRecord
        {
            private List<DFHI> Items;
            private int CurrentIndex;
            private DFHI CurrentItem;

            public DFHIDataReader(List<DFHI> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 25; } }
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
                    case 1: // FKEY
                        return CurrentItem.FKEY;
                    case 2: // CREATION_USER
                        return CurrentItem.CREATION_USER;
                    case 3: // CREATION_DATE
                        return CurrentItem.CREATION_DATE;
                    case 4: // CREATION_TIME
                        return CurrentItem.CREATION_TIME;
                    case 5: // OBSOLETE_USER
                        return CurrentItem.OBSOLETE_USER;
                    case 6: // OBSOLETE_DATE
                        return CurrentItem.OBSOLETE_DATE;
                    case 7: // OBSOLETE_TIME
                        return CurrentItem.OBSOLETE_TIME;
                    case 8: // HKEY
                        return CurrentItem.HKEY;
                    case 9: // NAME_A
                        return CurrentItem.NAME_A;
                    case 10: // SURNAME_A
                        return CurrentItem.SURNAME_A;
                    case 11: // TITLE_A
                        return CurrentItem.TITLE_A;
                    case 12: // GENDER_A
                        return CurrentItem.GENDER_A;
                    case 13: // NAME_B
                        return CurrentItem.NAME_B;
                    case 14: // SURNAME_B
                        return CurrentItem.SURNAME_B;
                    case 15: // TITLE_B
                        return CurrentItem.TITLE_B;
                    case 16: // GENDER_B
                        return CurrentItem.GENDER_B;
                    case 17: // HOMEKEY
                        return CurrentItem.HOMEKEY;
                    case 18: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 19: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 20: // ADDRESS03
                        return CurrentItem.ADDRESS03;
                    case 21: // STATE
                        return CurrentItem.STATE;
                    case 22: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 23: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 24: // CHANGE_MADE
                        return CurrentItem.CHANGE_MADE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // CREATION_USER
                        return CurrentItem.CREATION_USER == null;
                    case 3: // CREATION_DATE
                        return CurrentItem.CREATION_DATE == null;
                    case 4: // CREATION_TIME
                        return CurrentItem.CREATION_TIME == null;
                    case 5: // OBSOLETE_USER
                        return CurrentItem.OBSOLETE_USER == null;
                    case 6: // OBSOLETE_DATE
                        return CurrentItem.OBSOLETE_DATE == null;
                    case 7: // OBSOLETE_TIME
                        return CurrentItem.OBSOLETE_TIME == null;
                    case 8: // HKEY
                        return CurrentItem.HKEY == null;
                    case 9: // NAME_A
                        return CurrentItem.NAME_A == null;
                    case 10: // SURNAME_A
                        return CurrentItem.SURNAME_A == null;
                    case 11: // TITLE_A
                        return CurrentItem.TITLE_A == null;
                    case 12: // GENDER_A
                        return CurrentItem.GENDER_A == null;
                    case 13: // NAME_B
                        return CurrentItem.NAME_B == null;
                    case 14: // SURNAME_B
                        return CurrentItem.SURNAME_B == null;
                    case 15: // TITLE_B
                        return CurrentItem.TITLE_B == null;
                    case 16: // GENDER_B
                        return CurrentItem.GENDER_B == null;
                    case 17: // HOMEKEY
                        return CurrentItem.HOMEKEY == null;
                    case 18: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 19: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 20: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
                    case 21: // STATE
                        return CurrentItem.STATE == null;
                    case 22: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 23: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 24: // CHANGE_MADE
                        return CurrentItem.CHANGE_MADE == null;
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
                    case 1: // FKEY
                        return "FKEY";
                    case 2: // CREATION_USER
                        return "CREATION_USER";
                    case 3: // CREATION_DATE
                        return "CREATION_DATE";
                    case 4: // CREATION_TIME
                        return "CREATION_TIME";
                    case 5: // OBSOLETE_USER
                        return "OBSOLETE_USER";
                    case 6: // OBSOLETE_DATE
                        return "OBSOLETE_DATE";
                    case 7: // OBSOLETE_TIME
                        return "OBSOLETE_TIME";
                    case 8: // HKEY
                        return "HKEY";
                    case 9: // NAME_A
                        return "NAME_A";
                    case 10: // SURNAME_A
                        return "SURNAME_A";
                    case 11: // TITLE_A
                        return "TITLE_A";
                    case 12: // GENDER_A
                        return "GENDER_A";
                    case 13: // NAME_B
                        return "NAME_B";
                    case 14: // SURNAME_B
                        return "SURNAME_B";
                    case 15: // TITLE_B
                        return "TITLE_B";
                    case 16: // GENDER_B
                        return "GENDER_B";
                    case 17: // HOMEKEY
                        return "HOMEKEY";
                    case 18: // ADDRESS01
                        return "ADDRESS01";
                    case 19: // ADDRESS02
                        return "ADDRESS02";
                    case 20: // ADDRESS03
                        return "ADDRESS03";
                    case 21: // STATE
                        return "STATE";
                    case 22: // POSTCODE
                        return "POSTCODE";
                    case 23: // TELEPHONE
                        return "TELEPHONE";
                    case 24: // CHANGE_MADE
                        return "CHANGE_MADE";
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
                    case "FKEY":
                        return 1;
                    case "CREATION_USER":
                        return 2;
                    case "CREATION_DATE":
                        return 3;
                    case "CREATION_TIME":
                        return 4;
                    case "OBSOLETE_USER":
                        return 5;
                    case "OBSOLETE_DATE":
                        return 6;
                    case "OBSOLETE_TIME":
                        return 7;
                    case "HKEY":
                        return 8;
                    case "NAME_A":
                        return 9;
                    case "SURNAME_A":
                        return 10;
                    case "TITLE_A":
                        return 11;
                    case "GENDER_A":
                        return 12;
                    case "NAME_B":
                        return 13;
                    case "SURNAME_B":
                        return 14;
                    case "TITLE_B":
                        return 15;
                    case "GENDER_B":
                        return 16;
                    case "HOMEKEY":
                        return 17;
                    case "ADDRESS01":
                        return 18;
                    case "ADDRESS02":
                        return 19;
                    case "ADDRESS03":
                        return 20;
                    case "STATE":
                        return 21;
                    case "POSTCODE":
                        return 22;
                    case "TELEPHONE":
                        return 23;
                    case "CHANGE_MADE":
                        return 24;
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
