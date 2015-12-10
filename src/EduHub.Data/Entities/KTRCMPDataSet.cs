using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Company Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTRCMPDataSet : DataSetBase<KTRCMP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTRCMP"; } }

        internal KTRCMPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COMPANY_CODE = new Lazy<NullDictionary<string, KTRCMP>>(() => this.ToNullDictionary(i => i.COMPANY_CODE));
            Index_COMPANY_ID = new Lazy<Dictionary<int, KTRCMP>>(() => this.ToDictionary(i => i.COMPANY_ID));
            Index_COMPANY_NAME = new Lazy<NullDictionary<string, KTRCMP>>(() => this.ToNullDictionary(i => i.COMPANY_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTRCMP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTRCMP" /> fields for each CSV column header</returns>
        protected override Action<KTRCMP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTRCMP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COMPANY_ID":
                        mapper[i] = (e, v) => e.COMPANY_ID = int.Parse(v);
                        break;
                    case "COMPANY_CODE":
                        mapper[i] = (e, v) => e.COMPANY_CODE = v;
                        break;
                    case "COMPANY_NAME":
                        mapper[i] = (e, v) => e.COMPANY_NAME = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
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
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KTRCMP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KTRCMP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KTRCMP" /> items to added or update the base <see cref="KTRCMP" /> items</param>
        /// <returns>A merged list of <see cref="KTRCMP" /> items</returns>
        protected override List<KTRCMP> ApplyDeltaItems(List<KTRCMP> Items, List<KTRCMP> DeltaItems)
        {
            NullDictionary<string, int> Index_COMPANY_CODE = Items.ToIndexNullDictionary(i => i.COMPANY_CODE);
            Dictionary<int, int> Index_COMPANY_ID = Items.ToIndexDictionary(i => i.COMPANY_ID);
            NullDictionary<string, int> Index_COMPANY_NAME = Items.ToIndexNullDictionary(i => i.COMPANY_NAME);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KTRCMP deltaItem in DeltaItems)
            {
                int index;

                if (Index_COMPANY_CODE.TryGetValue(deltaItem.COMPANY_CODE, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_COMPANY_ID.TryGetValue(deltaItem.COMPANY_ID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_COMPANY_NAME.TryGetValue(deltaItem.COMPANY_NAME, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.COMPANY_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, KTRCMP>> Index_COMPANY_CODE;
        private Lazy<Dictionary<int, KTRCMP>> Index_COMPANY_ID;
        private Lazy<NullDictionary<string, KTRCMP>> Index_COMPANY_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_CODE(string COMPANY_CODE)
        {
            return Index_COMPANY_CODE.Value[COMPANY_CODE];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_CODE(string COMPANY_CODE, out KTRCMP Value)
        {
            return Index_COMPANY_CODE.Value.TryGetValue(COMPANY_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_CODE(string COMPANY_CODE)
        {
            KTRCMP value;
            if (Index_COMPANY_CODE.Value.TryGetValue(COMPANY_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_ID(int COMPANY_ID)
        {
            return Index_COMPANY_ID.Value[COMPANY_ID];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_ID(int COMPANY_ID, out KTRCMP Value)
        {
            return Index_COMPANY_ID.Value.TryGetValue(COMPANY_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_ID(int COMPANY_ID)
        {
            KTRCMP value;
            if (Index_COMPANY_ID.Value.TryGetValue(COMPANY_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_NAME(string COMPANY_NAME)
        {
            return Index_COMPANY_NAME.Value[COMPANY_NAME];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_NAME(string COMPANY_NAME, out KTRCMP Value)
        {
            return Index_COMPANY_NAME.Value.TryGetValue(COMPANY_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_NAME(string COMPANY_NAME)
        {
            KTRCMP value;
            if (Index_COMPANY_NAME.Value.TryGetValue(COMPANY_NAME, out value))
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
        /// Returns SQL which checks for the existence of a KTRCMP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KTRCMP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KTRCMP](
        [COMPANY_ID] int NOT NULL,
        [COMPANY_CODE] varchar(20) NULL,
        [COMPANY_NAME] varchar(60) NULL,
        [CONTACT] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [PHONE] varchar(20) NULL,
        [MOBILE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [EMAIL] varchar(60) NULL,
        [NOTES] varchar(200) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        CONSTRAINT [KTRCMP_Index_COMPANY_ID] PRIMARY KEY CLUSTERED (
            [COMPANY_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KTRCMP_Index_COMPANY_CODE] ON [dbo].[KTRCMP]
    (
            [COMPANY_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [KTRCMP_Index_COMPANY_NAME] ON [dbo].[KTRCMP]
    (
            [COMPANY_NAME] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTRCMP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTRCMP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KTRCMPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KTRCMPDataReader : IDataReader, IDataRecord
        {
            private List<KTRCMP> Items;
            private int CurrentIndex;
            private KTRCMP CurrentItem;

            public KTRCMPDataReader(List<KTRCMP> Items)
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
                    case 0: // COMPANY_ID
                        return CurrentItem.COMPANY_ID;
                    case 1: // COMPANY_CODE
                        return CurrentItem.COMPANY_CODE;
                    case 2: // COMPANY_NAME
                        return CurrentItem.COMPANY_NAME;
                    case 3: // CONTACT
                        return CurrentItem.CONTACT;
                    case 4: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 5: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 6: // ADDRESS03
                        return CurrentItem.ADDRESS03;
                    case 7: // STATE
                        return CurrentItem.STATE;
                    case 8: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 9: // PHONE
                        return CurrentItem.PHONE;
                    case 10: // MOBILE
                        return CurrentItem.MOBILE;
                    case 11: // FAX
                        return CurrentItem.FAX;
                    case 12: // EMAIL
                        return CurrentItem.EMAIL;
                    case 13: // NOTES
                        return CurrentItem.NOTES;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // COMPANY_CODE
                        return CurrentItem.COMPANY_CODE == null;
                    case 2: // COMPANY_NAME
                        return CurrentItem.COMPANY_NAME == null;
                    case 3: // CONTACT
                        return CurrentItem.CONTACT == null;
                    case 4: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 5: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 6: // ADDRESS03
                        return CurrentItem.ADDRESS03 == null;
                    case 7: // STATE
                        return CurrentItem.STATE == null;
                    case 8: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 9: // PHONE
                        return CurrentItem.PHONE == null;
                    case 10: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 11: // FAX
                        return CurrentItem.FAX == null;
                    case 12: // EMAIL
                        return CurrentItem.EMAIL == null;
                    case 13: // NOTES
                        return CurrentItem.NOTES == null;
                    case 14: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 15: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // COMPANY_ID
                        return "COMPANY_ID";
                    case 1: // COMPANY_CODE
                        return "COMPANY_CODE";
                    case 2: // COMPANY_NAME
                        return "COMPANY_NAME";
                    case 3: // CONTACT
                        return "CONTACT";
                    case 4: // ADDRESS01
                        return "ADDRESS01";
                    case 5: // ADDRESS02
                        return "ADDRESS02";
                    case 6: // ADDRESS03
                        return "ADDRESS03";
                    case 7: // STATE
                        return "STATE";
                    case 8: // POSTCODE
                        return "POSTCODE";
                    case 9: // PHONE
                        return "PHONE";
                    case 10: // MOBILE
                        return "MOBILE";
                    case 11: // FAX
                        return "FAX";
                    case 12: // EMAIL
                        return "EMAIL";
                    case 13: // NOTES
                        return "NOTES";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "COMPANY_ID":
                        return 0;
                    case "COMPANY_CODE":
                        return 1;
                    case "COMPANY_NAME":
                        return 2;
                    case "CONTACT":
                        return 3;
                    case "ADDRESS01":
                        return 4;
                    case "ADDRESS02":
                        return 5;
                    case "ADDRESS03":
                        return 6;
                    case "STATE":
                        return 7;
                    case "POSTCODE":
                        return 8;
                    case "PHONE":
                        return 9;
                    case "MOBILE":
                        return 10;
                    case "FAX":
                        return 11;
                    case "EMAIL":
                        return 12;
                    case "NOTES":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
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
