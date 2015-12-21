using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Schools Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SKGSDataSet : EduHubDataSet<SKGS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SKGS"; } }

        internal SKGSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SKGS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SCHOOL = new Lazy<Dictionary<string, SKGS>>(() => this.ToDictionary(i => i.SCHOOL));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SKGS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SKGS" /> fields for each CSV column header</returns>
        protected override Action<SKGS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SKGS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SCHOOL_TYPE = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "SCHOOL_NUMBER":
                        mapper[i] = (e, v) => e.SCHOOL_NUMBER = v;
                        break;
                    case "CAMPUS_TYPE":
                        mapper[i] = (e, v) => e.CAMPUS_TYPE = v;
                        break;
                    case "CAMPUS_NAME":
                        mapper[i] = (e, v) => e.CAMPUS_NAME = v;
                        break;
                    case "REGION":
                        mapper[i] = (e, v) => e.REGION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGION_NAME":
                        mapper[i] = (e, v) => e.REGION_NAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MAILING_ADDRESS01":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS01 = v;
                        break;
                    case "MAILING_ADDRESS02":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS02 = v;
                        break;
                    case "MAILING_SUBURB":
                        mapper[i] = (e, v) => e.MAILING_SUBURB = v;
                        break;
                    case "MAILING_STATE":
                        mapper[i] = (e, v) => e.MAILING_STATE = v;
                        break;
                    case "MAILING_POSTCODE":
                        mapper[i] = (e, v) => e.MAILING_POSTCODE = v;
                        break;
                    case "DELIVERY_ADDRESS01":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS01 = v;
                        break;
                    case "DELIVERY_ADDRESS02":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS02 = v;
                        break;
                    case "DELIVERY_SUBURB":
                        mapper[i] = (e, v) => e.DELIVERY_SUBURB = v;
                        break;
                    case "DELIVERY_STATE":
                        mapper[i] = (e, v) => e.DELIVERY_STATE = v;
                        break;
                    case "DELIVERY_POSTCODE":
                        mapper[i] = (e, v) => e.DELIVERY_POSTCODE = v;
                        break;
                    case "DELIVERY_TELEPHONE":
                        mapper[i] = (e, v) => e.DELIVERY_TELEPHONE = v;
                        break;
                    case "DELIVERY_FAX":
                        mapper[i] = (e, v) => e.DELIVERY_FAX = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "INTERNET_ADDRESS":
                        mapper[i] = (e, v) => e.INTERNET_ADDRESS = v;
                        break;
                    case "CASES21_RELEASE":
                        mapper[i] = (e, v) => e.CASES21_RELEASE = v;
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "SCH_PRINCIPAL_SALUTATION":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SALUTATION = v;
                        break;
                    case "SCH_PRINCIPAL_FIRST_NAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_FIRST_NAME = v;
                        break;
                    case "SCH_PRINCIPAL_SURNAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SURNAME = v;
                        break;
                    case "SCH_PRINCIPAL_TELEPHONE":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_TELEPHONE = v;
                        break;
                    case "SALUTATION":
                        mapper[i] = (e, v) => e.SALUTATION = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "CLOSED":
                        mapper[i] = (e, v) => e.CLOSED = v;
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
        /// Merges <see cref="SKGS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SKGS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SKGS" /> items to added or update the base <see cref="SKGS" /> items</param>
        /// <returns>A merged list of <see cref="SKGS" /> items</returns>
        protected override List<SKGS> ApplyDeltaItems(List<SKGS> Items, List<SKGS> DeltaItems)
        {
            Dictionary<string, int> Index_SCHOOL = Items.ToIndexDictionary(i => i.SCHOOL);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SKGS deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCHOOL.TryGetValue(deltaItem.SCHOOL, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCHOOL)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SKGS>>> Index_LW_DATE;
        private Lazy<Dictionary<string, SKGS>> Index_SCHOOL;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SKGS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SKGS</param>
        /// <returns>List of related SKGS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SKGS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SKGS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SKGS</param>
        /// <param name="Value">List of related SKGS entities</param>
        /// <returns>True if the list of related SKGS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SKGS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SKGS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SKGS</param>
        /// <returns>List of related SKGS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SKGS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SKGS> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SKGS by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SKGS</param>
        /// <returns>Related SKGS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SKGS FindBySCHOOL(string SCHOOL)
        {
            return Index_SCHOOL.Value[SCHOOL];
        }

        /// <summary>
        /// Attempt to find SKGS by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SKGS</param>
        /// <param name="Value">Related SKGS entity</param>
        /// <returns>True if the related SKGS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL(string SCHOOL, out SKGS Value)
        {
            return Index_SCHOOL.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find SKGS by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SKGS</param>
        /// <returns>Related SKGS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SKGS TryFindBySCHOOL(string SCHOOL)
        {
            SKGS value;
            if (Index_SCHOOL.Value.TryGetValue(SCHOOL, out value))
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
        /// Returns SQL which checks for the existence of a SKGS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SKGS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SKGS](
        [SCHOOL] varchar(8) NOT NULL,
        [NAME] varchar(40) NULL,
        [SCHOOL_TYPE] varchar(33) NULL,
        [ENTITY] varchar(2) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [SCHOOL_NUMBER] varchar(2) NULL,
        [CAMPUS_TYPE] varchar(33) NULL,
        [CAMPUS_NAME] varchar(40) NULL,
        [REGION] smallint NULL,
        [REGION_NAME] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [MAILING_ADDRESS01] varchar(30) NULL,
        [MAILING_ADDRESS02] varchar(30) NULL,
        [MAILING_SUBURB] varchar(30) NULL,
        [MAILING_STATE] varchar(3) NULL,
        [MAILING_POSTCODE] varchar(4) NULL,
        [DELIVERY_ADDRESS01] varchar(30) NULL,
        [DELIVERY_ADDRESS02] varchar(30) NULL,
        [DELIVERY_SUBURB] varchar(30) NULL,
        [DELIVERY_STATE] varchar(3) NULL,
        [DELIVERY_POSTCODE] varchar(4) NULL,
        [DELIVERY_TELEPHONE] varchar(20) NULL,
        [DELIVERY_FAX] varchar(20) NULL,
        [E_MAIL] varchar(255) NULL,
        [INTERNET_ADDRESS] varchar(255) NULL,
        [CASES21_RELEASE] varchar(12) NULL,
        [MAP_TYPE] varchar(1) NULL,
        [MAP_NUM] varchar(4) NULL,
        [X_AXIS] varchar(2) NULL,
        [Y_AXIS] varchar(2) NULL,
        [SCH_PRINCIPAL_SALUTATION] varchar(4) NULL,
        [SCH_PRINCIPAL_FIRST_NAME] varchar(20) NULL,
        [SCH_PRINCIPAL_SURNAME] varchar(30) NULL,
        [SCH_PRINCIPAL_TELEPHONE] varchar(20) NULL,
        [SALUTATION] varchar(4) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [CLOSED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SKGS_Index_SCHOOL] PRIMARY KEY CLUSTERED (
            [SCHOOL] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SKGS_Index_LW_DATE] ON [dbo].[SKGS]
    (
            [LW_DATE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SKGS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SKGS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SKGSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SKGSDataReader : IDataReader, IDataRecord
        {
            private List<SKGS> Items;
            private int CurrentIndex;
            private SKGS CurrentItem;

            public SKGSDataReader(List<SKGS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 47; } }
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
                    case 0: // SCHOOL
                        return CurrentItem.SCHOOL;
                    case 1: // NAME
                        return CurrentItem.NAME;
                    case 2: // SCHOOL_TYPE
                        return CurrentItem.SCHOOL_TYPE;
                    case 3: // ENTITY
                        return CurrentItem.ENTITY;
                    case 4: // SCHOOL_ID
                        return CurrentItem.SCHOOL_ID;
                    case 5: // SCHOOL_NUMBER
                        return CurrentItem.SCHOOL_NUMBER;
                    case 6: // CAMPUS_TYPE
                        return CurrentItem.CAMPUS_TYPE;
                    case 7: // CAMPUS_NAME
                        return CurrentItem.CAMPUS_NAME;
                    case 8: // REGION
                        return CurrentItem.REGION;
                    case 9: // REGION_NAME
                        return CurrentItem.REGION_NAME;
                    case 10: // ADDRESS01
                        return CurrentItem.ADDRESS01;
                    case 11: // ADDRESS02
                        return CurrentItem.ADDRESS02;
                    case 12: // SUBURB
                        return CurrentItem.SUBURB;
                    case 13: // STATE
                        return CurrentItem.STATE;
                    case 14: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 15: // TELEPHONE
                        return CurrentItem.TELEPHONE;
                    case 16: // FAX
                        return CurrentItem.FAX;
                    case 17: // MAILING_ADDRESS01
                        return CurrentItem.MAILING_ADDRESS01;
                    case 18: // MAILING_ADDRESS02
                        return CurrentItem.MAILING_ADDRESS02;
                    case 19: // MAILING_SUBURB
                        return CurrentItem.MAILING_SUBURB;
                    case 20: // MAILING_STATE
                        return CurrentItem.MAILING_STATE;
                    case 21: // MAILING_POSTCODE
                        return CurrentItem.MAILING_POSTCODE;
                    case 22: // DELIVERY_ADDRESS01
                        return CurrentItem.DELIVERY_ADDRESS01;
                    case 23: // DELIVERY_ADDRESS02
                        return CurrentItem.DELIVERY_ADDRESS02;
                    case 24: // DELIVERY_SUBURB
                        return CurrentItem.DELIVERY_SUBURB;
                    case 25: // DELIVERY_STATE
                        return CurrentItem.DELIVERY_STATE;
                    case 26: // DELIVERY_POSTCODE
                        return CurrentItem.DELIVERY_POSTCODE;
                    case 27: // DELIVERY_TELEPHONE
                        return CurrentItem.DELIVERY_TELEPHONE;
                    case 28: // DELIVERY_FAX
                        return CurrentItem.DELIVERY_FAX;
                    case 29: // E_MAIL
                        return CurrentItem.E_MAIL;
                    case 30: // INTERNET_ADDRESS
                        return CurrentItem.INTERNET_ADDRESS;
                    case 31: // CASES21_RELEASE
                        return CurrentItem.CASES21_RELEASE;
                    case 32: // MAP_TYPE
                        return CurrentItem.MAP_TYPE;
                    case 33: // MAP_NUM
                        return CurrentItem.MAP_NUM;
                    case 34: // X_AXIS
                        return CurrentItem.X_AXIS;
                    case 35: // Y_AXIS
                        return CurrentItem.Y_AXIS;
                    case 36: // SCH_PRINCIPAL_SALUTATION
                        return CurrentItem.SCH_PRINCIPAL_SALUTATION;
                    case 37: // SCH_PRINCIPAL_FIRST_NAME
                        return CurrentItem.SCH_PRINCIPAL_FIRST_NAME;
                    case 38: // SCH_PRINCIPAL_SURNAME
                        return CurrentItem.SCH_PRINCIPAL_SURNAME;
                    case 39: // SCH_PRINCIPAL_TELEPHONE
                        return CurrentItem.SCH_PRINCIPAL_TELEPHONE;
                    case 40: // SALUTATION
                        return CurrentItem.SALUTATION;
                    case 41: // SURNAME
                        return CurrentItem.SURNAME;
                    case 42: // FIRST_NAME
                        return CurrentItem.FIRST_NAME;
                    case 43: // CLOSED
                        return CurrentItem.CLOSED;
                    case 44: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 45: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 46: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // NAME
                        return CurrentItem.NAME == null;
                    case 2: // SCHOOL_TYPE
                        return CurrentItem.SCHOOL_TYPE == null;
                    case 3: // ENTITY
                        return CurrentItem.ENTITY == null;
                    case 4: // SCHOOL_ID
                        return CurrentItem.SCHOOL_ID == null;
                    case 5: // SCHOOL_NUMBER
                        return CurrentItem.SCHOOL_NUMBER == null;
                    case 6: // CAMPUS_TYPE
                        return CurrentItem.CAMPUS_TYPE == null;
                    case 7: // CAMPUS_NAME
                        return CurrentItem.CAMPUS_NAME == null;
                    case 8: // REGION
                        return CurrentItem.REGION == null;
                    case 9: // REGION_NAME
                        return CurrentItem.REGION_NAME == null;
                    case 10: // ADDRESS01
                        return CurrentItem.ADDRESS01 == null;
                    case 11: // ADDRESS02
                        return CurrentItem.ADDRESS02 == null;
                    case 12: // SUBURB
                        return CurrentItem.SUBURB == null;
                    case 13: // STATE
                        return CurrentItem.STATE == null;
                    case 14: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 15: // TELEPHONE
                        return CurrentItem.TELEPHONE == null;
                    case 16: // FAX
                        return CurrentItem.FAX == null;
                    case 17: // MAILING_ADDRESS01
                        return CurrentItem.MAILING_ADDRESS01 == null;
                    case 18: // MAILING_ADDRESS02
                        return CurrentItem.MAILING_ADDRESS02 == null;
                    case 19: // MAILING_SUBURB
                        return CurrentItem.MAILING_SUBURB == null;
                    case 20: // MAILING_STATE
                        return CurrentItem.MAILING_STATE == null;
                    case 21: // MAILING_POSTCODE
                        return CurrentItem.MAILING_POSTCODE == null;
                    case 22: // DELIVERY_ADDRESS01
                        return CurrentItem.DELIVERY_ADDRESS01 == null;
                    case 23: // DELIVERY_ADDRESS02
                        return CurrentItem.DELIVERY_ADDRESS02 == null;
                    case 24: // DELIVERY_SUBURB
                        return CurrentItem.DELIVERY_SUBURB == null;
                    case 25: // DELIVERY_STATE
                        return CurrentItem.DELIVERY_STATE == null;
                    case 26: // DELIVERY_POSTCODE
                        return CurrentItem.DELIVERY_POSTCODE == null;
                    case 27: // DELIVERY_TELEPHONE
                        return CurrentItem.DELIVERY_TELEPHONE == null;
                    case 28: // DELIVERY_FAX
                        return CurrentItem.DELIVERY_FAX == null;
                    case 29: // E_MAIL
                        return CurrentItem.E_MAIL == null;
                    case 30: // INTERNET_ADDRESS
                        return CurrentItem.INTERNET_ADDRESS == null;
                    case 31: // CASES21_RELEASE
                        return CurrentItem.CASES21_RELEASE == null;
                    case 32: // MAP_TYPE
                        return CurrentItem.MAP_TYPE == null;
                    case 33: // MAP_NUM
                        return CurrentItem.MAP_NUM == null;
                    case 34: // X_AXIS
                        return CurrentItem.X_AXIS == null;
                    case 35: // Y_AXIS
                        return CurrentItem.Y_AXIS == null;
                    case 36: // SCH_PRINCIPAL_SALUTATION
                        return CurrentItem.SCH_PRINCIPAL_SALUTATION == null;
                    case 37: // SCH_PRINCIPAL_FIRST_NAME
                        return CurrentItem.SCH_PRINCIPAL_FIRST_NAME == null;
                    case 38: // SCH_PRINCIPAL_SURNAME
                        return CurrentItem.SCH_PRINCIPAL_SURNAME == null;
                    case 39: // SCH_PRINCIPAL_TELEPHONE
                        return CurrentItem.SCH_PRINCIPAL_TELEPHONE == null;
                    case 40: // SALUTATION
                        return CurrentItem.SALUTATION == null;
                    case 41: // SURNAME
                        return CurrentItem.SURNAME == null;
                    case 42: // FIRST_NAME
                        return CurrentItem.FIRST_NAME == null;
                    case 43: // CLOSED
                        return CurrentItem.CLOSED == null;
                    case 44: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 45: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 46: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCHOOL
                        return "SCHOOL";
                    case 1: // NAME
                        return "NAME";
                    case 2: // SCHOOL_TYPE
                        return "SCHOOL_TYPE";
                    case 3: // ENTITY
                        return "ENTITY";
                    case 4: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 5: // SCHOOL_NUMBER
                        return "SCHOOL_NUMBER";
                    case 6: // CAMPUS_TYPE
                        return "CAMPUS_TYPE";
                    case 7: // CAMPUS_NAME
                        return "CAMPUS_NAME";
                    case 8: // REGION
                        return "REGION";
                    case 9: // REGION_NAME
                        return "REGION_NAME";
                    case 10: // ADDRESS01
                        return "ADDRESS01";
                    case 11: // ADDRESS02
                        return "ADDRESS02";
                    case 12: // SUBURB
                        return "SUBURB";
                    case 13: // STATE
                        return "STATE";
                    case 14: // POSTCODE
                        return "POSTCODE";
                    case 15: // TELEPHONE
                        return "TELEPHONE";
                    case 16: // FAX
                        return "FAX";
                    case 17: // MAILING_ADDRESS01
                        return "MAILING_ADDRESS01";
                    case 18: // MAILING_ADDRESS02
                        return "MAILING_ADDRESS02";
                    case 19: // MAILING_SUBURB
                        return "MAILING_SUBURB";
                    case 20: // MAILING_STATE
                        return "MAILING_STATE";
                    case 21: // MAILING_POSTCODE
                        return "MAILING_POSTCODE";
                    case 22: // DELIVERY_ADDRESS01
                        return "DELIVERY_ADDRESS01";
                    case 23: // DELIVERY_ADDRESS02
                        return "DELIVERY_ADDRESS02";
                    case 24: // DELIVERY_SUBURB
                        return "DELIVERY_SUBURB";
                    case 25: // DELIVERY_STATE
                        return "DELIVERY_STATE";
                    case 26: // DELIVERY_POSTCODE
                        return "DELIVERY_POSTCODE";
                    case 27: // DELIVERY_TELEPHONE
                        return "DELIVERY_TELEPHONE";
                    case 28: // DELIVERY_FAX
                        return "DELIVERY_FAX";
                    case 29: // E_MAIL
                        return "E_MAIL";
                    case 30: // INTERNET_ADDRESS
                        return "INTERNET_ADDRESS";
                    case 31: // CASES21_RELEASE
                        return "CASES21_RELEASE";
                    case 32: // MAP_TYPE
                        return "MAP_TYPE";
                    case 33: // MAP_NUM
                        return "MAP_NUM";
                    case 34: // X_AXIS
                        return "X_AXIS";
                    case 35: // Y_AXIS
                        return "Y_AXIS";
                    case 36: // SCH_PRINCIPAL_SALUTATION
                        return "SCH_PRINCIPAL_SALUTATION";
                    case 37: // SCH_PRINCIPAL_FIRST_NAME
                        return "SCH_PRINCIPAL_FIRST_NAME";
                    case 38: // SCH_PRINCIPAL_SURNAME
                        return "SCH_PRINCIPAL_SURNAME";
                    case 39: // SCH_PRINCIPAL_TELEPHONE
                        return "SCH_PRINCIPAL_TELEPHONE";
                    case 40: // SALUTATION
                        return "SALUTATION";
                    case 41: // SURNAME
                        return "SURNAME";
                    case 42: // FIRST_NAME
                        return "FIRST_NAME";
                    case 43: // CLOSED
                        return "CLOSED";
                    case 44: // LW_DATE
                        return "LW_DATE";
                    case 45: // LW_TIME
                        return "LW_TIME";
                    case 46: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCHOOL":
                        return 0;
                    case "NAME":
                        return 1;
                    case "SCHOOL_TYPE":
                        return 2;
                    case "ENTITY":
                        return 3;
                    case "SCHOOL_ID":
                        return 4;
                    case "SCHOOL_NUMBER":
                        return 5;
                    case "CAMPUS_TYPE":
                        return 6;
                    case "CAMPUS_NAME":
                        return 7;
                    case "REGION":
                        return 8;
                    case "REGION_NAME":
                        return 9;
                    case "ADDRESS01":
                        return 10;
                    case "ADDRESS02":
                        return 11;
                    case "SUBURB":
                        return 12;
                    case "STATE":
                        return 13;
                    case "POSTCODE":
                        return 14;
                    case "TELEPHONE":
                        return 15;
                    case "FAX":
                        return 16;
                    case "MAILING_ADDRESS01":
                        return 17;
                    case "MAILING_ADDRESS02":
                        return 18;
                    case "MAILING_SUBURB":
                        return 19;
                    case "MAILING_STATE":
                        return 20;
                    case "MAILING_POSTCODE":
                        return 21;
                    case "DELIVERY_ADDRESS01":
                        return 22;
                    case "DELIVERY_ADDRESS02":
                        return 23;
                    case "DELIVERY_SUBURB":
                        return 24;
                    case "DELIVERY_STATE":
                        return 25;
                    case "DELIVERY_POSTCODE":
                        return 26;
                    case "DELIVERY_TELEPHONE":
                        return 27;
                    case "DELIVERY_FAX":
                        return 28;
                    case "E_MAIL":
                        return 29;
                    case "INTERNET_ADDRESS":
                        return 30;
                    case "CASES21_RELEASE":
                        return 31;
                    case "MAP_TYPE":
                        return 32;
                    case "MAP_NUM":
                        return 33;
                    case "X_AXIS":
                        return 34;
                    case "Y_AXIS":
                        return 35;
                    case "SCH_PRINCIPAL_SALUTATION":
                        return 36;
                    case "SCH_PRINCIPAL_FIRST_NAME":
                        return 37;
                    case "SCH_PRINCIPAL_SURNAME":
                        return 38;
                    case "SCH_PRINCIPAL_TELEPHONE":
                        return 39;
                    case "SALUTATION":
                        return 40;
                    case "SURNAME":
                        return 41;
                    case "FIRST_NAME":
                        return 42;
                    case "CLOSED":
                        return 43;
                    case "LW_DATE":
                        return 44;
                    case "LW_TIME":
                        return 45;
                    case "LW_USER":
                        return 46;
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
