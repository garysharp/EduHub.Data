using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMDataSet : EduHubDataSet<SAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAM"; } }

        internal SAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ADDRESSKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ADDRESSKEY));
            Index_ASSOC_NAME = new Lazy<NullDictionary<string, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ASSOC_NAME));
            Index_ASSOC_POSN = new Lazy<NullDictionary<string, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ASSOC_POSN));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_SAMKEY = new Lazy<Dictionary<int, SAM>>(() => this.ToDictionary(i => i.SAMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAM" /> fields for each CSV column header</returns>
        protected override Action<SAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAMKEY":
                        mapper[i] = (e, v) => e.SAMKEY = int.Parse(v);
                        break;
                    case "PERSON_TYPE":
                        mapper[i] = (e, v) => e.PERSON_TYPE = v;
                        break;
                    case "PERSON":
                        mapper[i] = (e, v) => e.PERSON = v;
                        break;
                    case "WHICH_PARENT":
                        mapper[i] = (e, v) => e.WHICH_PARENT = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "PARENT_OS":
                        mapper[i] = (e, v) => e.PARENT_OS = v;
                        break;
                    case "LOTE":
                        mapper[i] = (e, v) => e.LOTE = v;
                        break;
                    case "LBOTE":
                        mapper[i] = (e, v) => e.LBOTE = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "ASSOC_NAME":
                        mapper[i] = (e, v) => e.ASSOC_NAME = v;
                        break;
                    case "ASSOC_POSN":
                        mapper[i] = (e, v) => e.ASSOC_POSN = v;
                        break;
                    case "ADDRESSKEY":
                        mapper[i] = (e, v) => e.ADDRESSKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOME_E_MAIL":
                        mapper[i] = (e, v) => e.HOME_E_MAIL = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "WORK_FAX":
                        mapper[i] = (e, v) => e.WORK_FAX = v;
                        break;
                    case "WORK_E_MAIL":
                        mapper[i] = (e, v) => e.WORK_E_MAIL = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "SIGNATORY":
                        mapper[i] = (e, v) => e.SIGNATORY = v;
                        break;
                    case "SAM_COMMENT":
                        mapper[i] = (e, v) => e.SAM_COMMENT = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SAM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAM" /> items to added or update the base <see cref="SAM" /> items</param>
        /// <returns>A merged list of <see cref="SAM" /> items</returns>
        protected override List<SAM> ApplyDeltaItems(List<SAM> Items, List<SAM> DeltaItems)
        {
            Dictionary<int, int> Index_SAMKEY = Items.ToIndexDictionary(i => i.SAMKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAM deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAMKEY.TryGetValue(deltaItem.SAMKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SAM>>> Index_ADDRESSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SAM>>> Index_ASSOC_NAME;
        private Lazy<NullDictionary<string, IReadOnlyList<SAM>>> Index_ASSOC_POSN;
        private Lazy<NullDictionary<int?, IReadOnlyList<SAM>>> Index_MAILKEY;
        private Lazy<Dictionary<int, SAM>> Index_SAMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByADDRESSKEY(int? ADDRESSKEY)
        {
            return Index_ADDRESSKEY.Value[ADDRESSKEY];
        }

        /// <summary>
        /// Attempt to find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByADDRESSKEY(int? ADDRESSKEY, out IReadOnlyList<SAM> Value)
        {
            return Index_ADDRESSKEY.Value.TryGetValue(ADDRESSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByADDRESSKEY(int? ADDRESSKEY)
        {
            IReadOnlyList<SAM> value;
            if (Index_ADDRESSKEY.Value.TryGetValue(ADDRESSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByASSOC_NAME(string ASSOC_NAME)
        {
            return Index_ASSOC_NAME.Value[ASSOC_NAME];
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSOC_NAME(string ASSOC_NAME, out IReadOnlyList<SAM> Value)
        {
            return Index_ASSOC_NAME.Value.TryGetValue(ASSOC_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByASSOC_NAME(string ASSOC_NAME)
        {
            IReadOnlyList<SAM> value;
            if (Index_ASSOC_NAME.Value.TryGetValue(ASSOC_NAME, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByASSOC_POSN(string ASSOC_POSN)
        {
            return Index_ASSOC_POSN.Value[ASSOC_POSN];
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSOC_POSN(string ASSOC_POSN, out IReadOnlyList<SAM> Value)
        {
            return Index_ASSOC_POSN.Value.TryGetValue(ASSOC_POSN, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByASSOC_POSN(string ASSOC_POSN)
        {
            IReadOnlyList<SAM> value;
            if (Index_ASSOC_POSN.Value.TryGetValue(ASSOC_POSN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByMAILKEY(int? MAILKEY)
        {
            return Index_MAILKEY.Value[MAILKEY];
        }

        /// <summary>
        /// Attempt to find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILKEY(int? MAILKEY, out IReadOnlyList<SAM> Value)
        {
            return Index_MAILKEY.Value.TryGetValue(MAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByMAILKEY(int? MAILKEY)
        {
            IReadOnlyList<SAM> value;
            if (Index_MAILKEY.Value.TryGetValue(MAILKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAM FindBySAMKEY(int SAMKEY)
        {
            return Index_SAMKEY.Value[SAMKEY];
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <param name="Value">Related SAM entity</param>
        /// <returns>True if the related SAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMKEY(int SAMKEY, out SAM Value)
        {
            return Index_SAMKEY.Value.TryGetValue(SAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAM TryFindBySAMKEY(int SAMKEY)
        {
            SAM value;
            if (Index_SAMKEY.Value.TryGetValue(SAMKEY, out value))
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
        /// Returns SQL which checks for the existence of a SAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAM](
        [SAMKEY] int IDENTITY NOT NULL,
        [PERSON_TYPE] varchar(2) NULL,
        [PERSON] varchar(10) NULL,
        [WHICH_PARENT] varchar(1) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTHDATE] datetime NULL,
        [KOORIE] varchar(1) NULL,
        [PARENT_OS] varchar(1) NULL,
        [LOTE] varchar(1) NULL,
        [LBOTE] varchar(1) NULL,
        [DISABILITY] varchar(1) NULL,
        [ASSOC_NAME] varchar(15) NULL,
        [ASSOC_POSN] varchar(25) NULL,
        [ADDRESSKEY] int NULL,
        [MAILKEY] int NULL,
        [HOME_E_MAIL] varchar(60) NULL,
        [WORK_PHONE] varchar(20) NULL,
        [WORK_FAX] varchar(20) NULL,
        [WORK_E_MAIL] varchar(60) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [TITLE] varchar(4) NULL,
        [MOBILE_PHONE] varchar(20) NULL,
        [SIGNATORY] varchar(1) NULL,
        [SAM_COMMENT] text NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAM_Index_SAMKEY] PRIMARY KEY CLUSTERED (
            [SAMKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_ADDRESSKEY] ON [dbo].[SAM]
    (
            [ADDRESSKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_ASSOC_NAME] ON [dbo].[SAM]
    (
            [ASSOC_NAME] ASC
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_ASSOC_POSN] ON [dbo].[SAM]
    (
            [ASSOC_POSN] ASC
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_MAILKEY] ON [dbo].[SAM]
    (
            [MAILKEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAM data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SAMDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAMDataReader : IDataReader, IDataRecord
        {
            private List<SAM> Items;
            private int CurrentIndex;
            private SAM CurrentItem;

            public SAMDataReader(List<SAM> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 30; } }
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
                    case 0: // SAMKEY
                        return CurrentItem.SAMKEY;
                    case 1: // PERSON_TYPE
                        return CurrentItem.PERSON_TYPE;
                    case 2: // PERSON
                        return CurrentItem.PERSON;
                    case 3: // WHICH_PARENT
                        return CurrentItem.WHICH_PARENT;
                    case 4: // GENDER
                        return CurrentItem.GENDER;
                    case 5: // BIRTHDATE
                        return CurrentItem.BIRTHDATE;
                    case 6: // KOORIE
                        return CurrentItem.KOORIE;
                    case 7: // PARENT_OS
                        return CurrentItem.PARENT_OS;
                    case 8: // LOTE
                        return CurrentItem.LOTE;
                    case 9: // LBOTE
                        return CurrentItem.LBOTE;
                    case 10: // DISABILITY
                        return CurrentItem.DISABILITY;
                    case 11: // ASSOC_NAME
                        return CurrentItem.ASSOC_NAME;
                    case 12: // ASSOC_POSN
                        return CurrentItem.ASSOC_POSN;
                    case 13: // ADDRESSKEY
                        return CurrentItem.ADDRESSKEY;
                    case 14: // MAILKEY
                        return CurrentItem.MAILKEY;
                    case 15: // HOME_E_MAIL
                        return CurrentItem.HOME_E_MAIL;
                    case 16: // WORK_PHONE
                        return CurrentItem.WORK_PHONE;
                    case 17: // WORK_FAX
                        return CurrentItem.WORK_FAX;
                    case 18: // WORK_E_MAIL
                        return CurrentItem.WORK_E_MAIL;
                    case 19: // SURNAME
                        return CurrentItem.SURNAME;
                    case 20: // FIRST_NAME
                        return CurrentItem.FIRST_NAME;
                    case 21: // TITLE
                        return CurrentItem.TITLE;
                    case 22: // MOBILE_PHONE
                        return CurrentItem.MOBILE_PHONE;
                    case 23: // SIGNATORY
                        return CurrentItem.SIGNATORY;
                    case 24: // SAM_COMMENT
                        return CurrentItem.SAM_COMMENT;
                    case 25: // START_DATE
                        return CurrentItem.START_DATE;
                    case 26: // END_DATE
                        return CurrentItem.END_DATE;
                    case 27: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 28: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 29: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // PERSON_TYPE
                        return CurrentItem.PERSON_TYPE == null;
                    case 2: // PERSON
                        return CurrentItem.PERSON == null;
                    case 3: // WHICH_PARENT
                        return CurrentItem.WHICH_PARENT == null;
                    case 4: // GENDER
                        return CurrentItem.GENDER == null;
                    case 5: // BIRTHDATE
                        return CurrentItem.BIRTHDATE == null;
                    case 6: // KOORIE
                        return CurrentItem.KOORIE == null;
                    case 7: // PARENT_OS
                        return CurrentItem.PARENT_OS == null;
                    case 8: // LOTE
                        return CurrentItem.LOTE == null;
                    case 9: // LBOTE
                        return CurrentItem.LBOTE == null;
                    case 10: // DISABILITY
                        return CurrentItem.DISABILITY == null;
                    case 11: // ASSOC_NAME
                        return CurrentItem.ASSOC_NAME == null;
                    case 12: // ASSOC_POSN
                        return CurrentItem.ASSOC_POSN == null;
                    case 13: // ADDRESSKEY
                        return CurrentItem.ADDRESSKEY == null;
                    case 14: // MAILKEY
                        return CurrentItem.MAILKEY == null;
                    case 15: // HOME_E_MAIL
                        return CurrentItem.HOME_E_MAIL == null;
                    case 16: // WORK_PHONE
                        return CurrentItem.WORK_PHONE == null;
                    case 17: // WORK_FAX
                        return CurrentItem.WORK_FAX == null;
                    case 18: // WORK_E_MAIL
                        return CurrentItem.WORK_E_MAIL == null;
                    case 19: // SURNAME
                        return CurrentItem.SURNAME == null;
                    case 20: // FIRST_NAME
                        return CurrentItem.FIRST_NAME == null;
                    case 21: // TITLE
                        return CurrentItem.TITLE == null;
                    case 22: // MOBILE_PHONE
                        return CurrentItem.MOBILE_PHONE == null;
                    case 23: // SIGNATORY
                        return CurrentItem.SIGNATORY == null;
                    case 24: // SAM_COMMENT
                        return CurrentItem.SAM_COMMENT == null;
                    case 25: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 26: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 27: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 28: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 29: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SAMKEY
                        return "SAMKEY";
                    case 1: // PERSON_TYPE
                        return "PERSON_TYPE";
                    case 2: // PERSON
                        return "PERSON";
                    case 3: // WHICH_PARENT
                        return "WHICH_PARENT";
                    case 4: // GENDER
                        return "GENDER";
                    case 5: // BIRTHDATE
                        return "BIRTHDATE";
                    case 6: // KOORIE
                        return "KOORIE";
                    case 7: // PARENT_OS
                        return "PARENT_OS";
                    case 8: // LOTE
                        return "LOTE";
                    case 9: // LBOTE
                        return "LBOTE";
                    case 10: // DISABILITY
                        return "DISABILITY";
                    case 11: // ASSOC_NAME
                        return "ASSOC_NAME";
                    case 12: // ASSOC_POSN
                        return "ASSOC_POSN";
                    case 13: // ADDRESSKEY
                        return "ADDRESSKEY";
                    case 14: // MAILKEY
                        return "MAILKEY";
                    case 15: // HOME_E_MAIL
                        return "HOME_E_MAIL";
                    case 16: // WORK_PHONE
                        return "WORK_PHONE";
                    case 17: // WORK_FAX
                        return "WORK_FAX";
                    case 18: // WORK_E_MAIL
                        return "WORK_E_MAIL";
                    case 19: // SURNAME
                        return "SURNAME";
                    case 20: // FIRST_NAME
                        return "FIRST_NAME";
                    case 21: // TITLE
                        return "TITLE";
                    case 22: // MOBILE_PHONE
                        return "MOBILE_PHONE";
                    case 23: // SIGNATORY
                        return "SIGNATORY";
                    case 24: // SAM_COMMENT
                        return "SAM_COMMENT";
                    case 25: // START_DATE
                        return "START_DATE";
                    case 26: // END_DATE
                        return "END_DATE";
                    case 27: // LW_DATE
                        return "LW_DATE";
                    case 28: // LW_TIME
                        return "LW_TIME";
                    case 29: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SAMKEY":
                        return 0;
                    case "PERSON_TYPE":
                        return 1;
                    case "PERSON":
                        return 2;
                    case "WHICH_PARENT":
                        return 3;
                    case "GENDER":
                        return 4;
                    case "BIRTHDATE":
                        return 5;
                    case "KOORIE":
                        return 6;
                    case "PARENT_OS":
                        return 7;
                    case "LOTE":
                        return 8;
                    case "LBOTE":
                        return 9;
                    case "DISABILITY":
                        return 10;
                    case "ASSOC_NAME":
                        return 11;
                    case "ASSOC_POSN":
                        return 12;
                    case "ADDRESSKEY":
                        return 13;
                    case "MAILKEY":
                        return 14;
                    case "HOME_E_MAIL":
                        return 15;
                    case "WORK_PHONE":
                        return 16;
                    case "WORK_FAX":
                        return 17;
                    case "WORK_E_MAIL":
                        return 18;
                    case "SURNAME":
                        return 19;
                    case "FIRST_NAME":
                        return 20;
                    case "TITLE":
                        return 21;
                    case "MOBILE_PHONE":
                        return 22;
                    case "SIGNATORY":
                        return 23;
                    case "SAM_COMMENT":
                        return 24;
                    case "START_DATE":
                        return 25;
                    case "END_DATE":
                        return 26;
                    case "LW_DATE":
                        return 27;
                    case "LW_TIME":
                        return 28;
                    case "LW_USER":
                        return 29;
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
