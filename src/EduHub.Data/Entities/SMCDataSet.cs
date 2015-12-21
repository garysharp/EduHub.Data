using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medical Conditions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMCDataSet : EduHubDataSet<SMC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMC"; } }

        internal SMCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_MED_CONDITION = new Lazy<NullDictionary<string, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.MED_CONDITION));
            Index_SMCKEY = new Lazy<Dictionary<int, SMC>>(() => this.ToDictionary(i => i.SMCKEY));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMC" /> fields for each CSV column header</returns>
        protected override Action<SMC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SMCKEY":
                        mapper[i] = (e, v) => e.SMCKEY = int.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "MED_CONDITION":
                        mapper[i] = (e, v) => e.MED_CONDITION = v;
                        break;
                    case "SYMPTOMS":
                        mapper[i] = (e, v) => e.SYMPTOMS = v;
                        break;
                    case "SMC_COMMENT":
                        mapper[i] = (e, v) => e.SMC_COMMENT = v;
                        break;
                    case "REGULAR_MEDICATION":
                        mapper[i] = (e, v) => e.REGULAR_MEDICATION = v;
                        break;
                    case "REGULAR_POISON_RATING":
                        mapper[i] = (e, v) => e.REGULAR_POISON_RATING = v;
                        break;
                    case "REGULAR_DOSAGE":
                        mapper[i] = (e, v) => e.REGULAR_DOSAGE = v;
                        break;
                    case "REGULAR_FREQUENCY":
                        mapper[i] = (e, v) => e.REGULAR_FREQUENCY = v;
                        break;
                    case "REGULAR_DOSAGE_TIME":
                        mapper[i] = (e, v) => e.REGULAR_DOSAGE_TIME = v;
                        break;
                    case "REGULAR_MEDICATION_LOCAT":
                        mapper[i] = (e, v) => e.REGULAR_MEDICATION_LOCAT = v;
                        break;
                    case "REGULAR_ADMIN_BY":
                        mapper[i] = (e, v) => e.REGULAR_ADMIN_BY = v;
                        break;
                    case "REMINDER":
                        mapper[i] = (e, v) => e.REMINDER = v;
                        break;
                    case "INFORM_DOCTOR":
                        mapper[i] = (e, v) => e.INFORM_DOCTOR = v;
                        break;
                    case "INFORM_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.INFORM_EMERG_CONTACT = v;
                        break;
                    case "ADMINISTER_MEDICATION":
                        mapper[i] = (e, v) => e.ADMINISTER_MEDICATION = v;
                        break;
                    case "OTHER_MEDICAL_ACTION":
                        mapper[i] = (e, v) => e.OTHER_MEDICAL_ACTION = v;
                        break;
                    case "SMC_ACTION":
                        mapper[i] = (e, v) => e.SMC_ACTION = v;
                        break;
                    case "AD_HOC_MEDICATION":
                        mapper[i] = (e, v) => e.AD_HOC_MEDICATION = v;
                        break;
                    case "AD_HOC_POISON_RATING":
                        mapper[i] = (e, v) => e.AD_HOC_POISON_RATING = v;
                        break;
                    case "AD_HOC_DOSAGE":
                        mapper[i] = (e, v) => e.AD_HOC_DOSAGE = v;
                        break;
                    case "AD_HOC_FREQUENCY":
                        mapper[i] = (e, v) => e.AD_HOC_FREQUENCY = v;
                        break;
                    case "AD_HOC_MEDICATION_LOCAT":
                        mapper[i] = (e, v) => e.AD_HOC_MEDICATION_LOCAT = v;
                        break;
                    case "AD_HOC_ADMIN_BY":
                        mapper[i] = (e, v) => e.AD_HOC_ADMIN_BY = v;
                        break;
                    case "HOME_MEDICATION":
                        mapper[i] = (e, v) => e.HOME_MEDICATION = v;
                        break;
                    case "ASTHMA_WHEEZE":
                        mapper[i] = (e, v) => e.ASTHMA_WHEEZE = v;
                        break;
                    case "ASTHMA_COUGH":
                        mapper[i] = (e, v) => e.ASTHMA_COUGH = v;
                        break;
                    case "ASTHMA_DIFFBRE":
                        mapper[i] = (e, v) => e.ASTHMA_DIFFBRE = v;
                        break;
                    case "ASTHMA_TGTCHES":
                        mapper[i] = (e, v) => e.ASTHMA_TGTCHES = v;
                        break;
                    case "ASTHMA_SYMTEXE":
                        mapper[i] = (e, v) => e.ASTHMA_SYMTEXE = v;
                        break;
                    case "ASTHMA_MGT_PLAN":
                        mapper[i] = (e, v) => e.ASTHMA_MGT_PLAN = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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
        /// Merges <see cref="SMC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SMC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SMC" /> items to added or update the base <see cref="SMC" /> items</param>
        /// <returns>A merged list of <see cref="SMC" /> items</returns>
        protected override List<SMC> ApplyDeltaItems(List<SMC> Items, List<SMC> DeltaItems)
        {
            Dictionary<int, int> Index_SMCKEY = Items.ToIndexDictionary(i => i.SMCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SMC deltaItem in DeltaItems)
            {
                int index;

                if (Index_SMCKEY.TryGetValue(deltaItem.SMCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SMCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SMC>>> Index_CAMPUS;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SMC>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SMC>>> Index_MED_CONDITION;
        private Lazy<Dictionary<int, SMC>> Index_SMCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SMC>>> Index_STUDENT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SMC> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SMC> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SMC> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SMC> value;
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
        /// Find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByMED_CONDITION(string MED_CONDITION)
        {
            return Index_MED_CONDITION.Value[MED_CONDITION];
        }

        /// <summary>
        /// Attempt to find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMED_CONDITION(string MED_CONDITION, out IReadOnlyList<SMC> Value)
        {
            return Index_MED_CONDITION.Value.TryGetValue(MED_CONDITION, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByMED_CONDITION(string MED_CONDITION)
        {
            IReadOnlyList<SMC> value;
            if (Index_MED_CONDITION.Value.TryGetValue(MED_CONDITION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC FindBySMCKEY(int SMCKEY)
        {
            return Index_SMCKEY.Value[SMCKEY];
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <param name="Value">Related SMC entity</param>
        /// <returns>True if the related SMC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMCKEY(int SMCKEY, out SMC Value)
        {
            return Index_SMCKEY.Value.TryGetValue(SMCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC TryFindBySMCKEY(int SMCKEY)
        {
            SMC value;
            if (Index_SMCKEY.Value.TryGetValue(SMCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<SMC> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<SMC> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
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
        /// Returns SQL which checks for the existence of a SMC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMC](
        [SMCKEY] int IDENTITY NOT NULL,
        [STUDENT] varchar(10) NULL,
        [MED_CONDITION] varchar(10) NULL,
        [SYMPTOMS] text NULL,
        [SMC_COMMENT] text NULL,
        [REGULAR_MEDICATION] varchar(60) NULL,
        [REGULAR_POISON_RATING] varchar(2) NULL,
        [REGULAR_DOSAGE] varchar(30) NULL,
        [REGULAR_FREQUENCY] varchar(15) NULL,
        [REGULAR_DOSAGE_TIME] varchar(15) NULL,
        [REGULAR_MEDICATION_LOCAT] varchar(30) NULL,
        [REGULAR_ADMIN_BY] varchar(7) NULL,
        [REMINDER] varchar(1) NULL,
        [INFORM_DOCTOR] varchar(1) NULL,
        [INFORM_EMERG_CONTACT] varchar(1) NULL,
        [ADMINISTER_MEDICATION] varchar(1) NULL,
        [OTHER_MEDICAL_ACTION] varchar(1) NULL,
        [SMC_ACTION] text NULL,
        [AD_HOC_MEDICATION] varchar(60) NULL,
        [AD_HOC_POISON_RATING] varchar(2) NULL,
        [AD_HOC_DOSAGE] varchar(30) NULL,
        [AD_HOC_FREQUENCY] varchar(15) NULL,
        [AD_HOC_MEDICATION_LOCAT] varchar(30) NULL,
        [AD_HOC_ADMIN_BY] varchar(7) NULL,
        [HOME_MEDICATION] varchar(60) NULL,
        [ASTHMA_WHEEZE] varchar(1) NULL,
        [ASTHMA_COUGH] varchar(1) NULL,
        [ASTHMA_DIFFBRE] varchar(1) NULL,
        [ASTHMA_TGTCHES] varchar(1) NULL,
        [ASTHMA_SYMTEXE] varchar(1) NULL,
        [ASTHMA_MGT_PLAN] text NULL,
        [CAMPUS] int NULL,
        [FACULTY] varchar(10) NULL,
        [ROOM_TYPE] varchar(1) NULL,
        [NORMAL_ALLOTMENT] smallint NULL,
        [GROUP_INDICATOR] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMC_Index_SMCKEY] PRIMARY KEY CLUSTERED (
            [SMCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_CAMPUS] ON [dbo].[SMC]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_LW_DATE] ON [dbo].[SMC]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_MED_CONDITION] ON [dbo].[SMC]
    (
            [MED_CONDITION] ASC
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_STUDENT] ON [dbo].[SMC]
    (
            [STUDENT] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SMCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMCDataReader : IDataReader, IDataRecord
        {
            private List<SMC> Items;
            private int CurrentIndex;
            private SMC CurrentItem;

            public SMCDataReader(List<SMC> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 39; } }
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
                    case 0: // SMCKEY
                        return CurrentItem.SMCKEY;
                    case 1: // STUDENT
                        return CurrentItem.STUDENT;
                    case 2: // MED_CONDITION
                        return CurrentItem.MED_CONDITION;
                    case 3: // SYMPTOMS
                        return CurrentItem.SYMPTOMS;
                    case 4: // SMC_COMMENT
                        return CurrentItem.SMC_COMMENT;
                    case 5: // REGULAR_MEDICATION
                        return CurrentItem.REGULAR_MEDICATION;
                    case 6: // REGULAR_POISON_RATING
                        return CurrentItem.REGULAR_POISON_RATING;
                    case 7: // REGULAR_DOSAGE
                        return CurrentItem.REGULAR_DOSAGE;
                    case 8: // REGULAR_FREQUENCY
                        return CurrentItem.REGULAR_FREQUENCY;
                    case 9: // REGULAR_DOSAGE_TIME
                        return CurrentItem.REGULAR_DOSAGE_TIME;
                    case 10: // REGULAR_MEDICATION_LOCAT
                        return CurrentItem.REGULAR_MEDICATION_LOCAT;
                    case 11: // REGULAR_ADMIN_BY
                        return CurrentItem.REGULAR_ADMIN_BY;
                    case 12: // REMINDER
                        return CurrentItem.REMINDER;
                    case 13: // INFORM_DOCTOR
                        return CurrentItem.INFORM_DOCTOR;
                    case 14: // INFORM_EMERG_CONTACT
                        return CurrentItem.INFORM_EMERG_CONTACT;
                    case 15: // ADMINISTER_MEDICATION
                        return CurrentItem.ADMINISTER_MEDICATION;
                    case 16: // OTHER_MEDICAL_ACTION
                        return CurrentItem.OTHER_MEDICAL_ACTION;
                    case 17: // SMC_ACTION
                        return CurrentItem.SMC_ACTION;
                    case 18: // AD_HOC_MEDICATION
                        return CurrentItem.AD_HOC_MEDICATION;
                    case 19: // AD_HOC_POISON_RATING
                        return CurrentItem.AD_HOC_POISON_RATING;
                    case 20: // AD_HOC_DOSAGE
                        return CurrentItem.AD_HOC_DOSAGE;
                    case 21: // AD_HOC_FREQUENCY
                        return CurrentItem.AD_HOC_FREQUENCY;
                    case 22: // AD_HOC_MEDICATION_LOCAT
                        return CurrentItem.AD_HOC_MEDICATION_LOCAT;
                    case 23: // AD_HOC_ADMIN_BY
                        return CurrentItem.AD_HOC_ADMIN_BY;
                    case 24: // HOME_MEDICATION
                        return CurrentItem.HOME_MEDICATION;
                    case 25: // ASTHMA_WHEEZE
                        return CurrentItem.ASTHMA_WHEEZE;
                    case 26: // ASTHMA_COUGH
                        return CurrentItem.ASTHMA_COUGH;
                    case 27: // ASTHMA_DIFFBRE
                        return CurrentItem.ASTHMA_DIFFBRE;
                    case 28: // ASTHMA_TGTCHES
                        return CurrentItem.ASTHMA_TGTCHES;
                    case 29: // ASTHMA_SYMTEXE
                        return CurrentItem.ASTHMA_SYMTEXE;
                    case 30: // ASTHMA_MGT_PLAN
                        return CurrentItem.ASTHMA_MGT_PLAN;
                    case 31: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 32: // FACULTY
                        return CurrentItem.FACULTY;
                    case 33: // ROOM_TYPE
                        return CurrentItem.ROOM_TYPE;
                    case 34: // NORMAL_ALLOTMENT
                        return CurrentItem.NORMAL_ALLOTMENT;
                    case 35: // GROUP_INDICATOR
                        return CurrentItem.GROUP_INDICATOR;
                    case 36: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 37: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 38: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // STUDENT
                        return CurrentItem.STUDENT == null;
                    case 2: // MED_CONDITION
                        return CurrentItem.MED_CONDITION == null;
                    case 3: // SYMPTOMS
                        return CurrentItem.SYMPTOMS == null;
                    case 4: // SMC_COMMENT
                        return CurrentItem.SMC_COMMENT == null;
                    case 5: // REGULAR_MEDICATION
                        return CurrentItem.REGULAR_MEDICATION == null;
                    case 6: // REGULAR_POISON_RATING
                        return CurrentItem.REGULAR_POISON_RATING == null;
                    case 7: // REGULAR_DOSAGE
                        return CurrentItem.REGULAR_DOSAGE == null;
                    case 8: // REGULAR_FREQUENCY
                        return CurrentItem.REGULAR_FREQUENCY == null;
                    case 9: // REGULAR_DOSAGE_TIME
                        return CurrentItem.REGULAR_DOSAGE_TIME == null;
                    case 10: // REGULAR_MEDICATION_LOCAT
                        return CurrentItem.REGULAR_MEDICATION_LOCAT == null;
                    case 11: // REGULAR_ADMIN_BY
                        return CurrentItem.REGULAR_ADMIN_BY == null;
                    case 12: // REMINDER
                        return CurrentItem.REMINDER == null;
                    case 13: // INFORM_DOCTOR
                        return CurrentItem.INFORM_DOCTOR == null;
                    case 14: // INFORM_EMERG_CONTACT
                        return CurrentItem.INFORM_EMERG_CONTACT == null;
                    case 15: // ADMINISTER_MEDICATION
                        return CurrentItem.ADMINISTER_MEDICATION == null;
                    case 16: // OTHER_MEDICAL_ACTION
                        return CurrentItem.OTHER_MEDICAL_ACTION == null;
                    case 17: // SMC_ACTION
                        return CurrentItem.SMC_ACTION == null;
                    case 18: // AD_HOC_MEDICATION
                        return CurrentItem.AD_HOC_MEDICATION == null;
                    case 19: // AD_HOC_POISON_RATING
                        return CurrentItem.AD_HOC_POISON_RATING == null;
                    case 20: // AD_HOC_DOSAGE
                        return CurrentItem.AD_HOC_DOSAGE == null;
                    case 21: // AD_HOC_FREQUENCY
                        return CurrentItem.AD_HOC_FREQUENCY == null;
                    case 22: // AD_HOC_MEDICATION_LOCAT
                        return CurrentItem.AD_HOC_MEDICATION_LOCAT == null;
                    case 23: // AD_HOC_ADMIN_BY
                        return CurrentItem.AD_HOC_ADMIN_BY == null;
                    case 24: // HOME_MEDICATION
                        return CurrentItem.HOME_MEDICATION == null;
                    case 25: // ASTHMA_WHEEZE
                        return CurrentItem.ASTHMA_WHEEZE == null;
                    case 26: // ASTHMA_COUGH
                        return CurrentItem.ASTHMA_COUGH == null;
                    case 27: // ASTHMA_DIFFBRE
                        return CurrentItem.ASTHMA_DIFFBRE == null;
                    case 28: // ASTHMA_TGTCHES
                        return CurrentItem.ASTHMA_TGTCHES == null;
                    case 29: // ASTHMA_SYMTEXE
                        return CurrentItem.ASTHMA_SYMTEXE == null;
                    case 30: // ASTHMA_MGT_PLAN
                        return CurrentItem.ASTHMA_MGT_PLAN == null;
                    case 31: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 32: // FACULTY
                        return CurrentItem.FACULTY == null;
                    case 33: // ROOM_TYPE
                        return CurrentItem.ROOM_TYPE == null;
                    case 34: // NORMAL_ALLOTMENT
                        return CurrentItem.NORMAL_ALLOTMENT == null;
                    case 35: // GROUP_INDICATOR
                        return CurrentItem.GROUP_INDICATOR == null;
                    case 36: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 37: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 38: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SMCKEY
                        return "SMCKEY";
                    case 1: // STUDENT
                        return "STUDENT";
                    case 2: // MED_CONDITION
                        return "MED_CONDITION";
                    case 3: // SYMPTOMS
                        return "SYMPTOMS";
                    case 4: // SMC_COMMENT
                        return "SMC_COMMENT";
                    case 5: // REGULAR_MEDICATION
                        return "REGULAR_MEDICATION";
                    case 6: // REGULAR_POISON_RATING
                        return "REGULAR_POISON_RATING";
                    case 7: // REGULAR_DOSAGE
                        return "REGULAR_DOSAGE";
                    case 8: // REGULAR_FREQUENCY
                        return "REGULAR_FREQUENCY";
                    case 9: // REGULAR_DOSAGE_TIME
                        return "REGULAR_DOSAGE_TIME";
                    case 10: // REGULAR_MEDICATION_LOCAT
                        return "REGULAR_MEDICATION_LOCAT";
                    case 11: // REGULAR_ADMIN_BY
                        return "REGULAR_ADMIN_BY";
                    case 12: // REMINDER
                        return "REMINDER";
                    case 13: // INFORM_DOCTOR
                        return "INFORM_DOCTOR";
                    case 14: // INFORM_EMERG_CONTACT
                        return "INFORM_EMERG_CONTACT";
                    case 15: // ADMINISTER_MEDICATION
                        return "ADMINISTER_MEDICATION";
                    case 16: // OTHER_MEDICAL_ACTION
                        return "OTHER_MEDICAL_ACTION";
                    case 17: // SMC_ACTION
                        return "SMC_ACTION";
                    case 18: // AD_HOC_MEDICATION
                        return "AD_HOC_MEDICATION";
                    case 19: // AD_HOC_POISON_RATING
                        return "AD_HOC_POISON_RATING";
                    case 20: // AD_HOC_DOSAGE
                        return "AD_HOC_DOSAGE";
                    case 21: // AD_HOC_FREQUENCY
                        return "AD_HOC_FREQUENCY";
                    case 22: // AD_HOC_MEDICATION_LOCAT
                        return "AD_HOC_MEDICATION_LOCAT";
                    case 23: // AD_HOC_ADMIN_BY
                        return "AD_HOC_ADMIN_BY";
                    case 24: // HOME_MEDICATION
                        return "HOME_MEDICATION";
                    case 25: // ASTHMA_WHEEZE
                        return "ASTHMA_WHEEZE";
                    case 26: // ASTHMA_COUGH
                        return "ASTHMA_COUGH";
                    case 27: // ASTHMA_DIFFBRE
                        return "ASTHMA_DIFFBRE";
                    case 28: // ASTHMA_TGTCHES
                        return "ASTHMA_TGTCHES";
                    case 29: // ASTHMA_SYMTEXE
                        return "ASTHMA_SYMTEXE";
                    case 30: // ASTHMA_MGT_PLAN
                        return "ASTHMA_MGT_PLAN";
                    case 31: // CAMPUS
                        return "CAMPUS";
                    case 32: // FACULTY
                        return "FACULTY";
                    case 33: // ROOM_TYPE
                        return "ROOM_TYPE";
                    case 34: // NORMAL_ALLOTMENT
                        return "NORMAL_ALLOTMENT";
                    case 35: // GROUP_INDICATOR
                        return "GROUP_INDICATOR";
                    case 36: // LW_DATE
                        return "LW_DATE";
                    case 37: // LW_TIME
                        return "LW_TIME";
                    case 38: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SMCKEY":
                        return 0;
                    case "STUDENT":
                        return 1;
                    case "MED_CONDITION":
                        return 2;
                    case "SYMPTOMS":
                        return 3;
                    case "SMC_COMMENT":
                        return 4;
                    case "REGULAR_MEDICATION":
                        return 5;
                    case "REGULAR_POISON_RATING":
                        return 6;
                    case "REGULAR_DOSAGE":
                        return 7;
                    case "REGULAR_FREQUENCY":
                        return 8;
                    case "REGULAR_DOSAGE_TIME":
                        return 9;
                    case "REGULAR_MEDICATION_LOCAT":
                        return 10;
                    case "REGULAR_ADMIN_BY":
                        return 11;
                    case "REMINDER":
                        return 12;
                    case "INFORM_DOCTOR":
                        return 13;
                    case "INFORM_EMERG_CONTACT":
                        return 14;
                    case "ADMINISTER_MEDICATION":
                        return 15;
                    case "OTHER_MEDICAL_ACTION":
                        return 16;
                    case "SMC_ACTION":
                        return 17;
                    case "AD_HOC_MEDICATION":
                        return 18;
                    case "AD_HOC_POISON_RATING":
                        return 19;
                    case "AD_HOC_DOSAGE":
                        return 20;
                    case "AD_HOC_FREQUENCY":
                        return 21;
                    case "AD_HOC_MEDICATION_LOCAT":
                        return 22;
                    case "AD_HOC_ADMIN_BY":
                        return 23;
                    case "HOME_MEDICATION":
                        return 24;
                    case "ASTHMA_WHEEZE":
                        return 25;
                    case "ASTHMA_COUGH":
                        return 26;
                    case "ASTHMA_DIFFBRE":
                        return 27;
                    case "ASTHMA_TGTCHES":
                        return 28;
                    case "ASTHMA_SYMTEXE":
                        return 29;
                    case "ASTHMA_MGT_PLAN":
                        return 30;
                    case "CAMPUS":
                        return 31;
                    case "FACULTY":
                        return 32;
                    case "ROOM_TYPE":
                        return 33;
                    case "NORMAL_ALLOTMENT":
                        return 34;
                    case "GROUP_INDICATOR":
                        return 35;
                    case "LW_DATE":
                        return 36;
                    case "LW_TIME":
                        return 37;
                    case "LW_USER":
                        return 38;
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
