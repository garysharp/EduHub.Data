using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvements/Sickbay Visits Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIDataSet : DataSetBase<SAI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAI"; } }

        internal SAIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<NullDictionary<int?, IReadOnlyList<SAI>>>(() => this.ToGroupedNullDictionary(i => i.ACCIDENTID));
            Index_SAIKEY = new Lazy<Dictionary<int, SAI>>(() => this.ToDictionary(i => i.SAIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAI" /> fields for each CSV column header</returns>
        protected override Action<SAI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAIKEY":
                        mapper[i] = (e, v) => e.SAIKEY = int.Parse(v);
                        break;
                    case "ENTRY_TYPE":
                        mapper[i] = (e, v) => e.ENTRY_TYPE = v;
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INV_PERSON_TYPE":
                        mapper[i] = (e, v) => e.INV_PERSON_TYPE = v;
                        break;
                    case "INV_PERSONKEY":
                        mapper[i] = (e, v) => e.INV_PERSONKEY = v;
                        break;
                    case "INV_PERSON_DFAB":
                        mapper[i] = (e, v) => e.INV_PERSON_DFAB = v;
                        break;
                    case "INV_FULL_NAME":
                        mapper[i] = (e, v) => e.INV_FULL_NAME = v;
                        break;
                    case "INV_ADDRESS":
                        mapper[i] = (e, v) => e.INV_ADDRESS = v;
                        break;
                    case "INV_TELEPHONE":
                        mapper[i] = (e, v) => e.INV_TELEPHONE = v;
                        break;
                    case "INV_BIRTHDATE":
                        mapper[i] = (e, v) => e.INV_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INV_GENDER":
                        mapper[i] = (e, v) => e.INV_GENDER = v;
                        break;
                    case "INV_PAYROLL_REC_NO":
                        mapper[i] = (e, v) => e.INV_PAYROLL_REC_NO = v;
                        break;
                    case "INV_STAFF_TYPE":
                        mapper[i] = (e, v) => e.INV_STAFF_TYPE = v;
                        break;
                    case "HELP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.HELP_PERSON_TYPE = v;
                        break;
                    case "HELP_PERSONKEY":
                        mapper[i] = (e, v) => e.HELP_PERSONKEY = v;
                        break;
                    case "HELP_PERSON_DFAB":
                        mapper[i] = (e, v) => e.HELP_PERSON_DFAB = v;
                        break;
                    case "HELP_FULL_NAME":
                        mapper[i] = (e, v) => e.HELP_FULL_NAME = v;
                        break;
                    case "INCIDENT_NO":
                        mapper[i] = (e, v) => e.INCIDENT_NO = v;
                        break;
                    case "SENT_TO_DEPT":
                        mapper[i] = (e, v) => e.SENT_TO_DEPT = v;
                        break;
                    case "CLAIM_LODGED":
                        mapper[i] = (e, v) => e.CLAIM_LODGED = v;
                        break;
                    case "CLAIM_DATE":
                        mapper[i] = (e, v) => e.CLAIM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "WORK_CEASED_DATE":
                        mapper[i] = (e, v) => e.WORK_CEASED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUCCESSFUL_CONTACT":
                        mapper[i] = (e, v) => e.SUCCESSFUL_CONTACT = v;
                        break;
                    case "OTHER_SUCCESSFUL_CONTACT":
                        mapper[i] = (e, v) => e.OTHER_SUCCESSFUL_CONTACT = v;
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
                        break;
                    case "OTHER_DOCTOR":
                        mapper[i] = (e, v) => e.OTHER_DOCTOR = v;
                        break;
                    case "HOSPITAL":
                        mapper[i] = (e, v) => e.HOSPITAL = v;
                        break;
                    case "AMBULANCE":
                        mapper[i] = (e, v) => e.AMBULANCE = v;
                        break;
                    case "ATTENDANCE_DATE":
                        mapper[i] = (e, v) => e.ATTENDANCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ATTENDANCE_IN_TIME":
                        mapper[i] = (e, v) => e.ATTENDANCE_IN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ATTENDANCE_OUT_TIME":
                        mapper[i] = (e, v) => e.ATTENDANCE_OUT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SYMPTOMS":
                        mapper[i] = (e, v) => e.SYMPTOMS = v;
                        break;
                    case "SICKBAY_ACTION":
                        mapper[i] = (e, v) => e.SICKBAY_ACTION = v;
                        break;
                    case "ACTION_OUTCOME":
                        mapper[i] = (e, v) => e.ACTION_OUTCOME = v;
                        break;
                    case "SMS_KEY":
                        mapper[i] = (e, v) => e.SMS_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMAIL_KEY":
                        mapper[i] = (e, v) => e.EMAIL_KEY = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SAI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAI" /> items to added or update the base <see cref="SAI" /> items</param>
        /// <returns>A merged list of <see cref="SAI" /> items</returns>
        protected override List<SAI> ApplyDeltaItems(List<SAI> Items, List<SAI> DeltaItems)
        {
            Dictionary<int, int> Index_SAIKEY = Items.ToIndexDictionary(i => i.SAIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAI deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAIKEY.TryGetValue(deltaItem.SAIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SAI>>> Index_ACCIDENTID;
        private Lazy<Dictionary<int, SAI>> Index_SAIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAI by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SAI</param>
        /// <returns>List of related SAI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAI> FindByACCIDENTID(int? ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SAI by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SAI</param>
        /// <param name="Value">List of related SAI entities</param>
        /// <returns>True if the list of related SAI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int? ACCIDENTID, out IReadOnlyList<SAI> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAI by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SAI</param>
        /// <returns>List of related SAI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAI> TryFindByACCIDENTID(int? ACCIDENTID)
        {
            IReadOnlyList<SAI> value;
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
        /// Find SAI by SAIKEY field
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAI</param>
        /// <returns>Related SAI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAI FindBySAIKEY(int SAIKEY)
        {
            return Index_SAIKEY.Value[SAIKEY];
        }

        /// <summary>
        /// Attempt to find SAI by SAIKEY field
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAI</param>
        /// <param name="Value">Related SAI entity</param>
        /// <returns>True if the related SAI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAIKEY(int SAIKEY, out SAI Value)
        {
            return Index_SAIKEY.Value.TryGetValue(SAIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAI by SAIKEY field
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAI</param>
        /// <returns>Related SAI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAI TryFindBySAIKEY(int SAIKEY)
        {
            SAI value;
            if (Index_SAIKEY.Value.TryGetValue(SAIKEY, out value))
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
        /// Returns SQL which checks for the existence of a SAI table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAI](
        [SAIKEY] int IDENTITY NOT NULL,
        [ENTRY_TYPE] varchar(1) NULL,
        [ACCIDENTID] int NULL,
        [INV_PERSON_TYPE] varchar(2) NULL,
        [INV_PERSONKEY] varchar(10) NULL,
        [INV_PERSON_DFAB] varchar(1) NULL,
        [INV_FULL_NAME] varchar(64) NULL,
        [INV_ADDRESS] varchar(120) NULL,
        [INV_TELEPHONE] varchar(20) NULL,
        [INV_BIRTHDATE] datetime NULL,
        [INV_GENDER] varchar(1) NULL,
        [INV_PAYROLL_REC_NO] varchar(9) NULL,
        [INV_STAFF_TYPE] varchar(2) NULL,
        [HELP_PERSON_TYPE] varchar(2) NULL,
        [HELP_PERSONKEY] varchar(10) NULL,
        [HELP_PERSON_DFAB] varchar(1) NULL,
        [HELP_FULL_NAME] varchar(32) NULL,
        [INCIDENT_NO] varchar(6) NULL,
        [SENT_TO_DEPT] varchar(1) NULL,
        [CLAIM_LODGED] varchar(1) NULL,
        [CLAIM_DATE] datetime NULL,
        [WORK_CEASED_DATE] datetime NULL,
        [SUCCESSFUL_CONTACT] varchar(40) NULL,
        [OTHER_SUCCESSFUL_CONTACT] varchar(40) NULL,
        [DOCTOR] varchar(40) NULL,
        [OTHER_DOCTOR] varchar(40) NULL,
        [HOSPITAL] varchar(40) NULL,
        [AMBULANCE] varchar(1) NULL,
        [ATTENDANCE_DATE] datetime NULL,
        [ATTENDANCE_IN_TIME] smallint NULL,
        [ATTENDANCE_OUT_TIME] smallint NULL,
        [SYMPTOMS] text NULL,
        [SICKBAY_ACTION] text NULL,
        [ACTION_OUTCOME] text NULL,
        [SMS_KEY] int NULL,
        [EMAIL_KEY] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAI_Index_SAIKEY] PRIMARY KEY CLUSTERED (
            [SAIKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SAI_Index_ACCIDENTID] ON [dbo].[SAI]
    (
            [ACCIDENTID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAI data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SAIDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAIDataReader : IDataReader, IDataRecord
        {
            private List<SAI> Items;
            private int CurrentIndex;
            private SAI CurrentItem;

            public SAIDataReader(List<SAI> Items)
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
                    case 0: // SAIKEY
                        return CurrentItem.SAIKEY;
                    case 1: // ENTRY_TYPE
                        return CurrentItem.ENTRY_TYPE;
                    case 2: // ACCIDENTID
                        return CurrentItem.ACCIDENTID;
                    case 3: // INV_PERSON_TYPE
                        return CurrentItem.INV_PERSON_TYPE;
                    case 4: // INV_PERSONKEY
                        return CurrentItem.INV_PERSONKEY;
                    case 5: // INV_PERSON_DFAB
                        return CurrentItem.INV_PERSON_DFAB;
                    case 6: // INV_FULL_NAME
                        return CurrentItem.INV_FULL_NAME;
                    case 7: // INV_ADDRESS
                        return CurrentItem.INV_ADDRESS;
                    case 8: // INV_TELEPHONE
                        return CurrentItem.INV_TELEPHONE;
                    case 9: // INV_BIRTHDATE
                        return CurrentItem.INV_BIRTHDATE;
                    case 10: // INV_GENDER
                        return CurrentItem.INV_GENDER;
                    case 11: // INV_PAYROLL_REC_NO
                        return CurrentItem.INV_PAYROLL_REC_NO;
                    case 12: // INV_STAFF_TYPE
                        return CurrentItem.INV_STAFF_TYPE;
                    case 13: // HELP_PERSON_TYPE
                        return CurrentItem.HELP_PERSON_TYPE;
                    case 14: // HELP_PERSONKEY
                        return CurrentItem.HELP_PERSONKEY;
                    case 15: // HELP_PERSON_DFAB
                        return CurrentItem.HELP_PERSON_DFAB;
                    case 16: // HELP_FULL_NAME
                        return CurrentItem.HELP_FULL_NAME;
                    case 17: // INCIDENT_NO
                        return CurrentItem.INCIDENT_NO;
                    case 18: // SENT_TO_DEPT
                        return CurrentItem.SENT_TO_DEPT;
                    case 19: // CLAIM_LODGED
                        return CurrentItem.CLAIM_LODGED;
                    case 20: // CLAIM_DATE
                        return CurrentItem.CLAIM_DATE;
                    case 21: // WORK_CEASED_DATE
                        return CurrentItem.WORK_CEASED_DATE;
                    case 22: // SUCCESSFUL_CONTACT
                        return CurrentItem.SUCCESSFUL_CONTACT;
                    case 23: // OTHER_SUCCESSFUL_CONTACT
                        return CurrentItem.OTHER_SUCCESSFUL_CONTACT;
                    case 24: // DOCTOR
                        return CurrentItem.DOCTOR;
                    case 25: // OTHER_DOCTOR
                        return CurrentItem.OTHER_DOCTOR;
                    case 26: // HOSPITAL
                        return CurrentItem.HOSPITAL;
                    case 27: // AMBULANCE
                        return CurrentItem.AMBULANCE;
                    case 28: // ATTENDANCE_DATE
                        return CurrentItem.ATTENDANCE_DATE;
                    case 29: // ATTENDANCE_IN_TIME
                        return CurrentItem.ATTENDANCE_IN_TIME;
                    case 30: // ATTENDANCE_OUT_TIME
                        return CurrentItem.ATTENDANCE_OUT_TIME;
                    case 31: // SYMPTOMS
                        return CurrentItem.SYMPTOMS;
                    case 32: // SICKBAY_ACTION
                        return CurrentItem.SICKBAY_ACTION;
                    case 33: // ACTION_OUTCOME
                        return CurrentItem.ACTION_OUTCOME;
                    case 34: // SMS_KEY
                        return CurrentItem.SMS_KEY;
                    case 35: // EMAIL_KEY
                        return CurrentItem.EMAIL_KEY;
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
                    case 1: // ENTRY_TYPE
                        return CurrentItem.ENTRY_TYPE == null;
                    case 2: // ACCIDENTID
                        return CurrentItem.ACCIDENTID == null;
                    case 3: // INV_PERSON_TYPE
                        return CurrentItem.INV_PERSON_TYPE == null;
                    case 4: // INV_PERSONKEY
                        return CurrentItem.INV_PERSONKEY == null;
                    case 5: // INV_PERSON_DFAB
                        return CurrentItem.INV_PERSON_DFAB == null;
                    case 6: // INV_FULL_NAME
                        return CurrentItem.INV_FULL_NAME == null;
                    case 7: // INV_ADDRESS
                        return CurrentItem.INV_ADDRESS == null;
                    case 8: // INV_TELEPHONE
                        return CurrentItem.INV_TELEPHONE == null;
                    case 9: // INV_BIRTHDATE
                        return CurrentItem.INV_BIRTHDATE == null;
                    case 10: // INV_GENDER
                        return CurrentItem.INV_GENDER == null;
                    case 11: // INV_PAYROLL_REC_NO
                        return CurrentItem.INV_PAYROLL_REC_NO == null;
                    case 12: // INV_STAFF_TYPE
                        return CurrentItem.INV_STAFF_TYPE == null;
                    case 13: // HELP_PERSON_TYPE
                        return CurrentItem.HELP_PERSON_TYPE == null;
                    case 14: // HELP_PERSONKEY
                        return CurrentItem.HELP_PERSONKEY == null;
                    case 15: // HELP_PERSON_DFAB
                        return CurrentItem.HELP_PERSON_DFAB == null;
                    case 16: // HELP_FULL_NAME
                        return CurrentItem.HELP_FULL_NAME == null;
                    case 17: // INCIDENT_NO
                        return CurrentItem.INCIDENT_NO == null;
                    case 18: // SENT_TO_DEPT
                        return CurrentItem.SENT_TO_DEPT == null;
                    case 19: // CLAIM_LODGED
                        return CurrentItem.CLAIM_LODGED == null;
                    case 20: // CLAIM_DATE
                        return CurrentItem.CLAIM_DATE == null;
                    case 21: // WORK_CEASED_DATE
                        return CurrentItem.WORK_CEASED_DATE == null;
                    case 22: // SUCCESSFUL_CONTACT
                        return CurrentItem.SUCCESSFUL_CONTACT == null;
                    case 23: // OTHER_SUCCESSFUL_CONTACT
                        return CurrentItem.OTHER_SUCCESSFUL_CONTACT == null;
                    case 24: // DOCTOR
                        return CurrentItem.DOCTOR == null;
                    case 25: // OTHER_DOCTOR
                        return CurrentItem.OTHER_DOCTOR == null;
                    case 26: // HOSPITAL
                        return CurrentItem.HOSPITAL == null;
                    case 27: // AMBULANCE
                        return CurrentItem.AMBULANCE == null;
                    case 28: // ATTENDANCE_DATE
                        return CurrentItem.ATTENDANCE_DATE == null;
                    case 29: // ATTENDANCE_IN_TIME
                        return CurrentItem.ATTENDANCE_IN_TIME == null;
                    case 30: // ATTENDANCE_OUT_TIME
                        return CurrentItem.ATTENDANCE_OUT_TIME == null;
                    case 31: // SYMPTOMS
                        return CurrentItem.SYMPTOMS == null;
                    case 32: // SICKBAY_ACTION
                        return CurrentItem.SICKBAY_ACTION == null;
                    case 33: // ACTION_OUTCOME
                        return CurrentItem.ACTION_OUTCOME == null;
                    case 34: // SMS_KEY
                        return CurrentItem.SMS_KEY == null;
                    case 35: // EMAIL_KEY
                        return CurrentItem.EMAIL_KEY == null;
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
                    case 0: // SAIKEY
                        return "SAIKEY";
                    case 1: // ENTRY_TYPE
                        return "ENTRY_TYPE";
                    case 2: // ACCIDENTID
                        return "ACCIDENTID";
                    case 3: // INV_PERSON_TYPE
                        return "INV_PERSON_TYPE";
                    case 4: // INV_PERSONKEY
                        return "INV_PERSONKEY";
                    case 5: // INV_PERSON_DFAB
                        return "INV_PERSON_DFAB";
                    case 6: // INV_FULL_NAME
                        return "INV_FULL_NAME";
                    case 7: // INV_ADDRESS
                        return "INV_ADDRESS";
                    case 8: // INV_TELEPHONE
                        return "INV_TELEPHONE";
                    case 9: // INV_BIRTHDATE
                        return "INV_BIRTHDATE";
                    case 10: // INV_GENDER
                        return "INV_GENDER";
                    case 11: // INV_PAYROLL_REC_NO
                        return "INV_PAYROLL_REC_NO";
                    case 12: // INV_STAFF_TYPE
                        return "INV_STAFF_TYPE";
                    case 13: // HELP_PERSON_TYPE
                        return "HELP_PERSON_TYPE";
                    case 14: // HELP_PERSONKEY
                        return "HELP_PERSONKEY";
                    case 15: // HELP_PERSON_DFAB
                        return "HELP_PERSON_DFAB";
                    case 16: // HELP_FULL_NAME
                        return "HELP_FULL_NAME";
                    case 17: // INCIDENT_NO
                        return "INCIDENT_NO";
                    case 18: // SENT_TO_DEPT
                        return "SENT_TO_DEPT";
                    case 19: // CLAIM_LODGED
                        return "CLAIM_LODGED";
                    case 20: // CLAIM_DATE
                        return "CLAIM_DATE";
                    case 21: // WORK_CEASED_DATE
                        return "WORK_CEASED_DATE";
                    case 22: // SUCCESSFUL_CONTACT
                        return "SUCCESSFUL_CONTACT";
                    case 23: // OTHER_SUCCESSFUL_CONTACT
                        return "OTHER_SUCCESSFUL_CONTACT";
                    case 24: // DOCTOR
                        return "DOCTOR";
                    case 25: // OTHER_DOCTOR
                        return "OTHER_DOCTOR";
                    case 26: // HOSPITAL
                        return "HOSPITAL";
                    case 27: // AMBULANCE
                        return "AMBULANCE";
                    case 28: // ATTENDANCE_DATE
                        return "ATTENDANCE_DATE";
                    case 29: // ATTENDANCE_IN_TIME
                        return "ATTENDANCE_IN_TIME";
                    case 30: // ATTENDANCE_OUT_TIME
                        return "ATTENDANCE_OUT_TIME";
                    case 31: // SYMPTOMS
                        return "SYMPTOMS";
                    case 32: // SICKBAY_ACTION
                        return "SICKBAY_ACTION";
                    case 33: // ACTION_OUTCOME
                        return "ACTION_OUTCOME";
                    case 34: // SMS_KEY
                        return "SMS_KEY";
                    case 35: // EMAIL_KEY
                        return "EMAIL_KEY";
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
                    case "SAIKEY":
                        return 0;
                    case "ENTRY_TYPE":
                        return 1;
                    case "ACCIDENTID":
                        return 2;
                    case "INV_PERSON_TYPE":
                        return 3;
                    case "INV_PERSONKEY":
                        return 4;
                    case "INV_PERSON_DFAB":
                        return 5;
                    case "INV_FULL_NAME":
                        return 6;
                    case "INV_ADDRESS":
                        return 7;
                    case "INV_TELEPHONE":
                        return 8;
                    case "INV_BIRTHDATE":
                        return 9;
                    case "INV_GENDER":
                        return 10;
                    case "INV_PAYROLL_REC_NO":
                        return 11;
                    case "INV_STAFF_TYPE":
                        return 12;
                    case "HELP_PERSON_TYPE":
                        return 13;
                    case "HELP_PERSONKEY":
                        return 14;
                    case "HELP_PERSON_DFAB":
                        return 15;
                    case "HELP_FULL_NAME":
                        return 16;
                    case "INCIDENT_NO":
                        return 17;
                    case "SENT_TO_DEPT":
                        return 18;
                    case "CLAIM_LODGED":
                        return 19;
                    case "CLAIM_DATE":
                        return 20;
                    case "WORK_CEASED_DATE":
                        return 21;
                    case "SUCCESSFUL_CONTACT":
                        return 22;
                    case "OTHER_SUCCESSFUL_CONTACT":
                        return 23;
                    case "DOCTOR":
                        return 24;
                    case "OTHER_DOCTOR":
                        return 25;
                    case "HOSPITAL":
                        return 26;
                    case "AMBULANCE":
                        return 27;
                    case "ATTENDANCE_DATE":
                        return 28;
                    case "ATTENDANCE_IN_TIME":
                        return 29;
                    case "ATTENDANCE_OUT_TIME":
                        return 30;
                    case "SYMPTOMS":
                        return 31;
                    case "SICKBAY_ACTION":
                        return 32;
                    case "ACTION_OUTCOME":
                        return 33;
                    case "SMS_KEY":
                        return 34;
                    case "EMAIL_KEY":
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
