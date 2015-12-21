using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// DF Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DF_TFRDataSet : EduHubDataSet<DF_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DF_TFR"; } }

        internal DF_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DF_TRANS_ID = new Lazy<NullDictionary<string, DF_TFR>>(() => this.ToNullDictionary(i => i.DF_TRANS_ID));
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<DF_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, DF_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DF_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DF_TFR" /> fields for each CSV column header</returns>
        protected override Action<DF_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DF_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "DF_TRANS_ID":
                        mapper[i] = (e, v) => e.DF_TRANS_ID = v;
                        break;
                    case "DFKEY":
                        mapper[i] = (e, v) => e.DFKEY = v;
                        break;
                    case "DFKEY_NEW":
                        mapper[i] = (e, v) => e.DFKEY_NEW = v;
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
                    case "WORK_CONT_A":
                        mapper[i] = (e, v) => e.WORK_CONT_A = v;
                        break;
                    case "OCCUPATION_A":
                        mapper[i] = (e, v) => e.OCCUPATION_A = v;
                        break;
                    case "EMPLOYER_A":
                        mapper[i] = (e, v) => e.EMPLOYER_A = v;
                        break;
                    case "NATIVE_LANG_A":
                        mapper[i] = (e, v) => e.NATIVE_LANG_A = v;
                        break;
                    case "OTHER_LANG_A":
                        mapper[i] = (e, v) => e.OTHER_LANG_A = v;
                        break;
                    case "INTERPRETER_A":
                        mapper[i] = (e, v) => e.INTERPRETER_A = v;
                        break;
                    case "BIRTH_COUNTRY_A":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY_A = v;
                        break;
                    case "BH_AT_HOME_A":
                        mapper[i] = (e, v) => e.BH_AT_HOME_A = v;
                        break;
                    case "BH_CONTACT_A":
                        mapper[i] = (e, v) => e.BH_CONTACT_A = v;
                        break;
                    case "AH_AT_HOME_A":
                        mapper[i] = (e, v) => e.AH_AT_HOME_A = v;
                        break;
                    case "AH_CONTACT_A":
                        mapper[i] = (e, v) => e.AH_CONTACT_A = v;
                        break;
                    case "E_MAIL_A":
                        mapper[i] = (e, v) => e.E_MAIL_A = v;
                        break;
                    case "PREF_MAIL_MECH_A":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH_A = v;
                        break;
                    case "FAX_A":
                        mapper[i] = (e, v) => e.FAX_A = v;
                        break;
                    case "GENDER_A":
                        mapper[i] = (e, v) => e.GENDER_A = v;
                        break;
                    case "SCH_ED_A":
                        mapper[i] = (e, v) => e.SCH_ED_A = v;
                        break;
                    case "NON_SCH_ED_A":
                        mapper[i] = (e, v) => e.NON_SCH_ED_A = v;
                        break;
                    case "OCCUP_STATUS_A":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_A = v;
                        break;
                    case "LOTE_HOME_CODE_A":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE_A = v;
                        break;
                    case "MOBILE_A":
                        mapper[i] = (e, v) => e.MOBILE_A = v;
                        break;
                    case "SMS_NOTIFY_A":
                        mapper[i] = (e, v) => e.SMS_NOTIFY_A = v;
                        break;
                    case "E_MAIL_NOTIFY_A":
                        mapper[i] = (e, v) => e.E_MAIL_NOTIFY_A = v;
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
                    case "WORK_CONT_B":
                        mapper[i] = (e, v) => e.WORK_CONT_B = v;
                        break;
                    case "OCCUPATION_B":
                        mapper[i] = (e, v) => e.OCCUPATION_B = v;
                        break;
                    case "EMPLOYER_B":
                        mapper[i] = (e, v) => e.EMPLOYER_B = v;
                        break;
                    case "NATIVE_LANG_B":
                        mapper[i] = (e, v) => e.NATIVE_LANG_B = v;
                        break;
                    case "OTHER_LANG_B":
                        mapper[i] = (e, v) => e.OTHER_LANG_B = v;
                        break;
                    case "INTERPRETER_B":
                        mapper[i] = (e, v) => e.INTERPRETER_B = v;
                        break;
                    case "BIRTH_COUNTRY_B":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY_B = v;
                        break;
                    case "BH_AT_HOME_B":
                        mapper[i] = (e, v) => e.BH_AT_HOME_B = v;
                        break;
                    case "BH_CONTACT_B":
                        mapper[i] = (e, v) => e.BH_CONTACT_B = v;
                        break;
                    case "AH_AT_HOME_B":
                        mapper[i] = (e, v) => e.AH_AT_HOME_B = v;
                        break;
                    case "AH_CONTACT_B":
                        mapper[i] = (e, v) => e.AH_CONTACT_B = v;
                        break;
                    case "E_MAIL_B":
                        mapper[i] = (e, v) => e.E_MAIL_B = v;
                        break;
                    case "PREF_MAIL_MECH_B":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH_B = v;
                        break;
                    case "FAX_B":
                        mapper[i] = (e, v) => e.FAX_B = v;
                        break;
                    case "GENDER_B":
                        mapper[i] = (e, v) => e.GENDER_B = v;
                        break;
                    case "SCH_ED_B":
                        mapper[i] = (e, v) => e.SCH_ED_B = v;
                        break;
                    case "NON_SCH_ED_B":
                        mapper[i] = (e, v) => e.NON_SCH_ED_B = v;
                        break;
                    case "OCCUP_STATUS_B":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_B = v;
                        break;
                    case "LOTE_HOME_CODE_B":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE_B = v;
                        break;
                    case "MOBILE_B":
                        mapper[i] = (e, v) => e.MOBILE_B = v;
                        break;
                    case "SMS_NOTIFY_B":
                        mapper[i] = (e, v) => e.SMS_NOTIFY_B = v;
                        break;
                    case "E_MAIL_NOTIFY_B":
                        mapper[i] = (e, v) => e.E_MAIL_NOTIFY_B = v;
                        break;
                    case "PREF_NOTICE_LANG":
                        mapper[i] = (e, v) => e.PREF_NOTICE_LANG = v;
                        break;
                    case "GROUP_AVAILABILITY":
                        mapper[i] = (e, v) => e.GROUP_AVAILABILITY = v;
                        break;
                    case "OCCUP_STATUS_GRP":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_GRP = v;
                        break;
                    case "HOMETITLE":
                        mapper[i] = (e, v) => e.HOMETITLE = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOMEKEY_NEW":
                        mapper[i] = (e, v) => e.HOMEKEY_NEW = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILTITLE":
                        mapper[i] = (e, v) => e.MAILTITLE = v;
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY_NEW":
                        mapper[i] = (e, v) => e.MAILKEY_NEW = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLINGTITLE":
                        mapper[i] = (e, v) => e.BILLINGTITLE = v;
                        break;
                    case "BILLINGKEY":
                        mapper[i] = (e, v) => e.BILLINGKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLINGKEY_NEW":
                        mapper[i] = (e, v) => e.BILLINGKEY_NEW = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLING_MEMO":
                        mapper[i] = (e, v) => e.BILLING_MEMO = v;
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRICELEVEL":
                        mapper[i] = (e, v) => e.PRICELEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
                        break;
                    case "EMERG_NAME01":
                        mapper[i] = (e, v) => e.EMERG_NAME01 = v;
                        break;
                    case "EMERG_NAME02":
                        mapper[i] = (e, v) => e.EMERG_NAME02 = v;
                        break;
                    case "EMERG_NAME03":
                        mapper[i] = (e, v) => e.EMERG_NAME03 = v;
                        break;
                    case "EMERG_NAME04":
                        mapper[i] = (e, v) => e.EMERG_NAME04 = v;
                        break;
                    case "EMERG_RELATION01":
                        mapper[i] = (e, v) => e.EMERG_RELATION01 = v;
                        break;
                    case "EMERG_RELATION02":
                        mapper[i] = (e, v) => e.EMERG_RELATION02 = v;
                        break;
                    case "EMERG_RELATION03":
                        mapper[i] = (e, v) => e.EMERG_RELATION03 = v;
                        break;
                    case "EMERG_RELATION04":
                        mapper[i] = (e, v) => e.EMERG_RELATION04 = v;
                        break;
                    case "EMERG_LANG01":
                        mapper[i] = (e, v) => e.EMERG_LANG01 = v;
                        break;
                    case "EMERG_LANG02":
                        mapper[i] = (e, v) => e.EMERG_LANG02 = v;
                        break;
                    case "EMERG_LANG03":
                        mapper[i] = (e, v) => e.EMERG_LANG03 = v;
                        break;
                    case "EMERG_LANG04":
                        mapper[i] = (e, v) => e.EMERG_LANG04 = v;
                        break;
                    case "EMERG_CONTACT01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT01 = v;
                        break;
                    case "EMERG_CONTACT02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT02 = v;
                        break;
                    case "EMERG_CONTACT03":
                        mapper[i] = (e, v) => e.EMERG_CONTACT03 = v;
                        break;
                    case "EMERG_CONTACT04":
                        mapper[i] = (e, v) => e.EMERG_CONTACT04 = v;
                        break;
                    case "ACC_DECLARATION":
                        mapper[i] = (e, v) => e.ACC_DECLARATION = v;
                        break;
                    case "AMBULANCE_SUBSCRIBER":
                        mapper[i] = (e, v) => e.AMBULANCE_SUBSCRIBER = v;
                        break;
                    case "MEDICARE_NO":
                        mapper[i] = (e, v) => e.MEDICARE_NO = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "DRAWER":
                        mapper[i] = (e, v) => e.DRAWER = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "BILLING_EMAIL":
                        mapper[i] = (e, v) => e.BILLING_EMAIL = v;
                        break;
                    case "PREF_EMAIL":
                        mapper[i] = (e, v) => e.PREF_EMAIL = v;
                        break;
                    case "UMH_TRANS_ID":
                        mapper[i] = (e, v) => e.UMH_TRANS_ID = v;
                        break;
                    case "UMM_TRANS_ID":
                        mapper[i] = (e, v) => e.UMM_TRANS_ID = v;
                        break;
                    case "UMB_TRANS_ID":
                        mapper[i] = (e, v) => e.UMB_TRANS_ID = v;
                        break;
                    case "KCD_TRANS_ID":
                        mapper[i] = (e, v) => e.KCD_TRANS_ID = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="DF_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DF_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DF_TFR" /> items to added or update the base <see cref="DF_TFR" /> items</param>
        /// <returns>A merged list of <see cref="DF_TFR" /> items</returns>
        protected override List<DF_TFR> ApplyDeltaItems(List<DF_TFR> Items, List<DF_TFR> DeltaItems)
        {
            NullDictionary<string, int> Index_DF_TRANS_ID = Items.ToIndexNullDictionary(i => i.DF_TRANS_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DF_TFR deltaItem in DeltaItems)
            {
                int index;

                if (Index_DF_TRANS_ID.TryGetValue(deltaItem.DF_TRANS_ID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ORIG_SCHOOL)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, DF_TFR>> Index_DF_TRANS_ID;
        private Lazy<Dictionary<string, IReadOnlyList<DF_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, DF_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DF_TFR by DF_TRANS_ID field
        /// </summary>
        /// <param name="DF_TRANS_ID">DF_TRANS_ID value used to find DF_TFR</param>
        /// <returns>Related DF_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF_TFR FindByDF_TRANS_ID(string DF_TRANS_ID)
        {
            return Index_DF_TRANS_ID.Value[DF_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find DF_TFR by DF_TRANS_ID field
        /// </summary>
        /// <param name="DF_TRANS_ID">DF_TRANS_ID value used to find DF_TFR</param>
        /// <param name="Value">Related DF_TFR entity</param>
        /// <returns>True if the related DF_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDF_TRANS_ID(string DF_TRANS_ID, out DF_TFR Value)
        {
            return Index_DF_TRANS_ID.Value.TryGetValue(DF_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find DF_TFR by DF_TRANS_ID field
        /// </summary>
        /// <param name="DF_TRANS_ID">DF_TRANS_ID value used to find DF_TFR</param>
        /// <returns>Related DF_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF_TFR TryFindByDF_TRANS_ID(string DF_TRANS_ID)
        {
            DF_TFR value;
            if (Index_DF_TRANS_ID.Value.TryGetValue(DF_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find DF_TFR</param>
        /// <returns>List of related DF_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find DF_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find DF_TFR</param>
        /// <param name="Value">List of related DF_TFR entities</param>
        /// <returns>True if the list of related DF_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<DF_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find DF_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find DF_TFR</param>
        /// <returns>List of related DF_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<DF_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DF_TFR</param>
        /// <returns>Related DF_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DF_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DF_TFR</param>
        /// <param name="Value">Related DF_TFR entity</param>
        /// <returns>True if the related DF_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DF_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DF_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DF_TFR</param>
        /// <returns>Related DF_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF_TFR TryFindByTID(int TID)
        {
            DF_TFR value;
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
        /// Returns SQL which checks for the existence of a DF_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DF_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [DF_TRANS_ID] varchar(30) NULL,
        [DFKEY] varchar(10) NULL,
        [DFKEY_NEW] varchar(10) NULL,
        [NAME_A] varchar(30) NULL,
        [SURNAME_A] varchar(30) NULL,
        [TITLE_A] varchar(4) NULL,
        [WORK_CONT_A] varchar(1) NULL,
        [OCCUPATION_A] varchar(35) NULL,
        [EMPLOYER_A] varchar(30) NULL,
        [NATIVE_LANG_A] varchar(7) NULL,
        [OTHER_LANG_A] varchar(7) NULL,
        [INTERPRETER_A] varchar(1) NULL,
        [BIRTH_COUNTRY_A] varchar(6) NULL,
        [BH_AT_HOME_A] varchar(1) NULL,
        [BH_CONTACT_A] text NULL,
        [AH_AT_HOME_A] varchar(1) NULL,
        [AH_CONTACT_A] text NULL,
        [E_MAIL_A] varchar(60) NULL,
        [PREF_MAIL_MECH_A] varchar(1) NULL,
        [FAX_A] varchar(20) NULL,
        [GENDER_A] varchar(1) NULL,
        [SCH_ED_A] varchar(1) NULL,
        [NON_SCH_ED_A] varchar(1) NULL,
        [OCCUP_STATUS_A] varchar(1) NULL,
        [LOTE_HOME_CODE_A] varchar(7) NULL,
        [MOBILE_A] varchar(20) NULL,
        [SMS_NOTIFY_A] varchar(1) NULL,
        [E_MAIL_NOTIFY_A] varchar(1) NULL,
        [NAME_B] varchar(30) NULL,
        [SURNAME_B] varchar(30) NULL,
        [TITLE_B] varchar(4) NULL,
        [WORK_CONT_B] varchar(1) NULL,
        [OCCUPATION_B] varchar(35) NULL,
        [EMPLOYER_B] varchar(30) NULL,
        [NATIVE_LANG_B] varchar(7) NULL,
        [OTHER_LANG_B] varchar(7) NULL,
        [INTERPRETER_B] varchar(1) NULL,
        [BIRTH_COUNTRY_B] varchar(6) NULL,
        [BH_AT_HOME_B] varchar(1) NULL,
        [BH_CONTACT_B] text NULL,
        [AH_AT_HOME_B] varchar(1) NULL,
        [AH_CONTACT_B] text NULL,
        [E_MAIL_B] varchar(60) NULL,
        [PREF_MAIL_MECH_B] varchar(1) NULL,
        [FAX_B] varchar(20) NULL,
        [GENDER_B] varchar(1) NULL,
        [SCH_ED_B] varchar(1) NULL,
        [NON_SCH_ED_B] varchar(1) NULL,
        [OCCUP_STATUS_B] varchar(1) NULL,
        [LOTE_HOME_CODE_B] varchar(7) NULL,
        [MOBILE_B] varchar(20) NULL,
        [SMS_NOTIFY_B] varchar(1) NULL,
        [E_MAIL_NOTIFY_B] varchar(1) NULL,
        [PREF_NOTICE_LANG] varchar(7) NULL,
        [GROUP_AVAILABILITY] varchar(1) NULL,
        [OCCUP_STATUS_GRP] varchar(1) NULL,
        [HOMETITLE] varchar(30) NULL,
        [HOMEKEY] int NULL,
        [HOMEKEY_NEW] int NULL,
        [MAILTITLE] varchar(30) NULL,
        [MAILKEY] int NULL,
        [MAILKEY_NEW] int NULL,
        [BILLINGTITLE] varchar(40) NULL,
        [BILLINGKEY] int NULL,
        [BILLINGKEY_NEW] int NULL,
        [BILLING_MEMO] text NULL,
        [ACCTYPE] smallint NULL,
        [PRICELEVEL] smallint NULL,
        [BPAY_SEQUENCE] int NULL,
        [BPAY_REFERENCE] int NULL,
        [DOCTOR] varchar(10) NULL,
        [EMERG_NAME01] varchar(30) NULL,
        [EMERG_NAME02] varchar(30) NULL,
        [EMERG_NAME03] varchar(30) NULL,
        [EMERG_NAME04] varchar(30) NULL,
        [EMERG_RELATION01] varchar(11) NULL,
        [EMERG_RELATION02] varchar(11) NULL,
        [EMERG_RELATION03] varchar(11) NULL,
        [EMERG_RELATION04] varchar(11) NULL,
        [EMERG_LANG01] varchar(7) NULL,
        [EMERG_LANG02] varchar(7) NULL,
        [EMERG_LANG03] varchar(7) NULL,
        [EMERG_LANG04] varchar(7) NULL,
        [EMERG_CONTACT01] text NULL,
        [EMERG_CONTACT02] text NULL,
        [EMERG_CONTACT03] text NULL,
        [EMERG_CONTACT04] text NULL,
        [ACC_DECLARATION] varchar(1) NULL,
        [AMBULANCE_SUBSCRIBER] varchar(1) NULL,
        [MEDICARE_NO] varchar(12) NULL,
        [HOME_LANG] varchar(7) NULL,
        [DRAWER] varchar(30) NULL,
        [BSB] varchar(6) NULL,
        [ABN] varchar(15) NULL,
        [BILLING_EMAIL] varchar(60) NULL,
        [PREF_EMAIL] varchar(1) NULL,
        [UMH_TRANS_ID] varchar(30) NULL,
        [UMM_TRANS_ID] varchar(30) NULL,
        [UMB_TRANS_ID] varchar(30) NULL,
        [KCD_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DF_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [DF_TFR_Index_DF_TRANS_ID] ON [dbo].[DF_TFR]
    (
            [DF_TRANS_ID] ASC
    );
    CREATE CLUSTERED INDEX [DF_TFR_Index_ORIG_SCHOOL] ON [dbo].[DF_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DF_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DF_TFR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DF_TFRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DF_TFRDataReader : IDataReader, IDataRecord
        {
            private List<DF_TFR> Items;
            private int CurrentIndex;
            private DF_TFR CurrentItem;

            public DF_TFRDataReader(List<DF_TFR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 107; } }
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
                    case 1: // ORIG_SCHOOL
                        return CurrentItem.ORIG_SCHOOL;
                    case 2: // DF_TRANS_ID
                        return CurrentItem.DF_TRANS_ID;
                    case 3: // DFKEY
                        return CurrentItem.DFKEY;
                    case 4: // DFKEY_NEW
                        return CurrentItem.DFKEY_NEW;
                    case 5: // NAME_A
                        return CurrentItem.NAME_A;
                    case 6: // SURNAME_A
                        return CurrentItem.SURNAME_A;
                    case 7: // TITLE_A
                        return CurrentItem.TITLE_A;
                    case 8: // WORK_CONT_A
                        return CurrentItem.WORK_CONT_A;
                    case 9: // OCCUPATION_A
                        return CurrentItem.OCCUPATION_A;
                    case 10: // EMPLOYER_A
                        return CurrentItem.EMPLOYER_A;
                    case 11: // NATIVE_LANG_A
                        return CurrentItem.NATIVE_LANG_A;
                    case 12: // OTHER_LANG_A
                        return CurrentItem.OTHER_LANG_A;
                    case 13: // INTERPRETER_A
                        return CurrentItem.INTERPRETER_A;
                    case 14: // BIRTH_COUNTRY_A
                        return CurrentItem.BIRTH_COUNTRY_A;
                    case 15: // BH_AT_HOME_A
                        return CurrentItem.BH_AT_HOME_A;
                    case 16: // BH_CONTACT_A
                        return CurrentItem.BH_CONTACT_A;
                    case 17: // AH_AT_HOME_A
                        return CurrentItem.AH_AT_HOME_A;
                    case 18: // AH_CONTACT_A
                        return CurrentItem.AH_CONTACT_A;
                    case 19: // E_MAIL_A
                        return CurrentItem.E_MAIL_A;
                    case 20: // PREF_MAIL_MECH_A
                        return CurrentItem.PREF_MAIL_MECH_A;
                    case 21: // FAX_A
                        return CurrentItem.FAX_A;
                    case 22: // GENDER_A
                        return CurrentItem.GENDER_A;
                    case 23: // SCH_ED_A
                        return CurrentItem.SCH_ED_A;
                    case 24: // NON_SCH_ED_A
                        return CurrentItem.NON_SCH_ED_A;
                    case 25: // OCCUP_STATUS_A
                        return CurrentItem.OCCUP_STATUS_A;
                    case 26: // LOTE_HOME_CODE_A
                        return CurrentItem.LOTE_HOME_CODE_A;
                    case 27: // MOBILE_A
                        return CurrentItem.MOBILE_A;
                    case 28: // SMS_NOTIFY_A
                        return CurrentItem.SMS_NOTIFY_A;
                    case 29: // E_MAIL_NOTIFY_A
                        return CurrentItem.E_MAIL_NOTIFY_A;
                    case 30: // NAME_B
                        return CurrentItem.NAME_B;
                    case 31: // SURNAME_B
                        return CurrentItem.SURNAME_B;
                    case 32: // TITLE_B
                        return CurrentItem.TITLE_B;
                    case 33: // WORK_CONT_B
                        return CurrentItem.WORK_CONT_B;
                    case 34: // OCCUPATION_B
                        return CurrentItem.OCCUPATION_B;
                    case 35: // EMPLOYER_B
                        return CurrentItem.EMPLOYER_B;
                    case 36: // NATIVE_LANG_B
                        return CurrentItem.NATIVE_LANG_B;
                    case 37: // OTHER_LANG_B
                        return CurrentItem.OTHER_LANG_B;
                    case 38: // INTERPRETER_B
                        return CurrentItem.INTERPRETER_B;
                    case 39: // BIRTH_COUNTRY_B
                        return CurrentItem.BIRTH_COUNTRY_B;
                    case 40: // BH_AT_HOME_B
                        return CurrentItem.BH_AT_HOME_B;
                    case 41: // BH_CONTACT_B
                        return CurrentItem.BH_CONTACT_B;
                    case 42: // AH_AT_HOME_B
                        return CurrentItem.AH_AT_HOME_B;
                    case 43: // AH_CONTACT_B
                        return CurrentItem.AH_CONTACT_B;
                    case 44: // E_MAIL_B
                        return CurrentItem.E_MAIL_B;
                    case 45: // PREF_MAIL_MECH_B
                        return CurrentItem.PREF_MAIL_MECH_B;
                    case 46: // FAX_B
                        return CurrentItem.FAX_B;
                    case 47: // GENDER_B
                        return CurrentItem.GENDER_B;
                    case 48: // SCH_ED_B
                        return CurrentItem.SCH_ED_B;
                    case 49: // NON_SCH_ED_B
                        return CurrentItem.NON_SCH_ED_B;
                    case 50: // OCCUP_STATUS_B
                        return CurrentItem.OCCUP_STATUS_B;
                    case 51: // LOTE_HOME_CODE_B
                        return CurrentItem.LOTE_HOME_CODE_B;
                    case 52: // MOBILE_B
                        return CurrentItem.MOBILE_B;
                    case 53: // SMS_NOTIFY_B
                        return CurrentItem.SMS_NOTIFY_B;
                    case 54: // E_MAIL_NOTIFY_B
                        return CurrentItem.E_MAIL_NOTIFY_B;
                    case 55: // PREF_NOTICE_LANG
                        return CurrentItem.PREF_NOTICE_LANG;
                    case 56: // GROUP_AVAILABILITY
                        return CurrentItem.GROUP_AVAILABILITY;
                    case 57: // OCCUP_STATUS_GRP
                        return CurrentItem.OCCUP_STATUS_GRP;
                    case 58: // HOMETITLE
                        return CurrentItem.HOMETITLE;
                    case 59: // HOMEKEY
                        return CurrentItem.HOMEKEY;
                    case 60: // HOMEKEY_NEW
                        return CurrentItem.HOMEKEY_NEW;
                    case 61: // MAILTITLE
                        return CurrentItem.MAILTITLE;
                    case 62: // MAILKEY
                        return CurrentItem.MAILKEY;
                    case 63: // MAILKEY_NEW
                        return CurrentItem.MAILKEY_NEW;
                    case 64: // BILLINGTITLE
                        return CurrentItem.BILLINGTITLE;
                    case 65: // BILLINGKEY
                        return CurrentItem.BILLINGKEY;
                    case 66: // BILLINGKEY_NEW
                        return CurrentItem.BILLINGKEY_NEW;
                    case 67: // BILLING_MEMO
                        return CurrentItem.BILLING_MEMO;
                    case 68: // ACCTYPE
                        return CurrentItem.ACCTYPE;
                    case 69: // PRICELEVEL
                        return CurrentItem.PRICELEVEL;
                    case 70: // BPAY_SEQUENCE
                        return CurrentItem.BPAY_SEQUENCE;
                    case 71: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE;
                    case 72: // DOCTOR
                        return CurrentItem.DOCTOR;
                    case 73: // EMERG_NAME01
                        return CurrentItem.EMERG_NAME01;
                    case 74: // EMERG_NAME02
                        return CurrentItem.EMERG_NAME02;
                    case 75: // EMERG_NAME03
                        return CurrentItem.EMERG_NAME03;
                    case 76: // EMERG_NAME04
                        return CurrentItem.EMERG_NAME04;
                    case 77: // EMERG_RELATION01
                        return CurrentItem.EMERG_RELATION01;
                    case 78: // EMERG_RELATION02
                        return CurrentItem.EMERG_RELATION02;
                    case 79: // EMERG_RELATION03
                        return CurrentItem.EMERG_RELATION03;
                    case 80: // EMERG_RELATION04
                        return CurrentItem.EMERG_RELATION04;
                    case 81: // EMERG_LANG01
                        return CurrentItem.EMERG_LANG01;
                    case 82: // EMERG_LANG02
                        return CurrentItem.EMERG_LANG02;
                    case 83: // EMERG_LANG03
                        return CurrentItem.EMERG_LANG03;
                    case 84: // EMERG_LANG04
                        return CurrentItem.EMERG_LANG04;
                    case 85: // EMERG_CONTACT01
                        return CurrentItem.EMERG_CONTACT01;
                    case 86: // EMERG_CONTACT02
                        return CurrentItem.EMERG_CONTACT02;
                    case 87: // EMERG_CONTACT03
                        return CurrentItem.EMERG_CONTACT03;
                    case 88: // EMERG_CONTACT04
                        return CurrentItem.EMERG_CONTACT04;
                    case 89: // ACC_DECLARATION
                        return CurrentItem.ACC_DECLARATION;
                    case 90: // AMBULANCE_SUBSCRIBER
                        return CurrentItem.AMBULANCE_SUBSCRIBER;
                    case 91: // MEDICARE_NO
                        return CurrentItem.MEDICARE_NO;
                    case 92: // HOME_LANG
                        return CurrentItem.HOME_LANG;
                    case 93: // DRAWER
                        return CurrentItem.DRAWER;
                    case 94: // BSB
                        return CurrentItem.BSB;
                    case 95: // ABN
                        return CurrentItem.ABN;
                    case 96: // BILLING_EMAIL
                        return CurrentItem.BILLING_EMAIL;
                    case 97: // PREF_EMAIL
                        return CurrentItem.PREF_EMAIL;
                    case 98: // UMH_TRANS_ID
                        return CurrentItem.UMH_TRANS_ID;
                    case 99: // UMM_TRANS_ID
                        return CurrentItem.UMM_TRANS_ID;
                    case 100: // UMB_TRANS_ID
                        return CurrentItem.UMB_TRANS_ID;
                    case 101: // KCD_TRANS_ID
                        return CurrentItem.KCD_TRANS_ID;
                    case 102: // IMP_STATUS
                        return CurrentItem.IMP_STATUS;
                    case 103: // IMP_DATE
                        return CurrentItem.IMP_DATE;
                    case 104: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 105: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 106: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // DF_TRANS_ID
                        return CurrentItem.DF_TRANS_ID == null;
                    case 3: // DFKEY
                        return CurrentItem.DFKEY == null;
                    case 4: // DFKEY_NEW
                        return CurrentItem.DFKEY_NEW == null;
                    case 5: // NAME_A
                        return CurrentItem.NAME_A == null;
                    case 6: // SURNAME_A
                        return CurrentItem.SURNAME_A == null;
                    case 7: // TITLE_A
                        return CurrentItem.TITLE_A == null;
                    case 8: // WORK_CONT_A
                        return CurrentItem.WORK_CONT_A == null;
                    case 9: // OCCUPATION_A
                        return CurrentItem.OCCUPATION_A == null;
                    case 10: // EMPLOYER_A
                        return CurrentItem.EMPLOYER_A == null;
                    case 11: // NATIVE_LANG_A
                        return CurrentItem.NATIVE_LANG_A == null;
                    case 12: // OTHER_LANG_A
                        return CurrentItem.OTHER_LANG_A == null;
                    case 13: // INTERPRETER_A
                        return CurrentItem.INTERPRETER_A == null;
                    case 14: // BIRTH_COUNTRY_A
                        return CurrentItem.BIRTH_COUNTRY_A == null;
                    case 15: // BH_AT_HOME_A
                        return CurrentItem.BH_AT_HOME_A == null;
                    case 16: // BH_CONTACT_A
                        return CurrentItem.BH_CONTACT_A == null;
                    case 17: // AH_AT_HOME_A
                        return CurrentItem.AH_AT_HOME_A == null;
                    case 18: // AH_CONTACT_A
                        return CurrentItem.AH_CONTACT_A == null;
                    case 19: // E_MAIL_A
                        return CurrentItem.E_MAIL_A == null;
                    case 20: // PREF_MAIL_MECH_A
                        return CurrentItem.PREF_MAIL_MECH_A == null;
                    case 21: // FAX_A
                        return CurrentItem.FAX_A == null;
                    case 22: // GENDER_A
                        return CurrentItem.GENDER_A == null;
                    case 23: // SCH_ED_A
                        return CurrentItem.SCH_ED_A == null;
                    case 24: // NON_SCH_ED_A
                        return CurrentItem.NON_SCH_ED_A == null;
                    case 25: // OCCUP_STATUS_A
                        return CurrentItem.OCCUP_STATUS_A == null;
                    case 26: // LOTE_HOME_CODE_A
                        return CurrentItem.LOTE_HOME_CODE_A == null;
                    case 27: // MOBILE_A
                        return CurrentItem.MOBILE_A == null;
                    case 28: // SMS_NOTIFY_A
                        return CurrentItem.SMS_NOTIFY_A == null;
                    case 29: // E_MAIL_NOTIFY_A
                        return CurrentItem.E_MAIL_NOTIFY_A == null;
                    case 30: // NAME_B
                        return CurrentItem.NAME_B == null;
                    case 31: // SURNAME_B
                        return CurrentItem.SURNAME_B == null;
                    case 32: // TITLE_B
                        return CurrentItem.TITLE_B == null;
                    case 33: // WORK_CONT_B
                        return CurrentItem.WORK_CONT_B == null;
                    case 34: // OCCUPATION_B
                        return CurrentItem.OCCUPATION_B == null;
                    case 35: // EMPLOYER_B
                        return CurrentItem.EMPLOYER_B == null;
                    case 36: // NATIVE_LANG_B
                        return CurrentItem.NATIVE_LANG_B == null;
                    case 37: // OTHER_LANG_B
                        return CurrentItem.OTHER_LANG_B == null;
                    case 38: // INTERPRETER_B
                        return CurrentItem.INTERPRETER_B == null;
                    case 39: // BIRTH_COUNTRY_B
                        return CurrentItem.BIRTH_COUNTRY_B == null;
                    case 40: // BH_AT_HOME_B
                        return CurrentItem.BH_AT_HOME_B == null;
                    case 41: // BH_CONTACT_B
                        return CurrentItem.BH_CONTACT_B == null;
                    case 42: // AH_AT_HOME_B
                        return CurrentItem.AH_AT_HOME_B == null;
                    case 43: // AH_CONTACT_B
                        return CurrentItem.AH_CONTACT_B == null;
                    case 44: // E_MAIL_B
                        return CurrentItem.E_MAIL_B == null;
                    case 45: // PREF_MAIL_MECH_B
                        return CurrentItem.PREF_MAIL_MECH_B == null;
                    case 46: // FAX_B
                        return CurrentItem.FAX_B == null;
                    case 47: // GENDER_B
                        return CurrentItem.GENDER_B == null;
                    case 48: // SCH_ED_B
                        return CurrentItem.SCH_ED_B == null;
                    case 49: // NON_SCH_ED_B
                        return CurrentItem.NON_SCH_ED_B == null;
                    case 50: // OCCUP_STATUS_B
                        return CurrentItem.OCCUP_STATUS_B == null;
                    case 51: // LOTE_HOME_CODE_B
                        return CurrentItem.LOTE_HOME_CODE_B == null;
                    case 52: // MOBILE_B
                        return CurrentItem.MOBILE_B == null;
                    case 53: // SMS_NOTIFY_B
                        return CurrentItem.SMS_NOTIFY_B == null;
                    case 54: // E_MAIL_NOTIFY_B
                        return CurrentItem.E_MAIL_NOTIFY_B == null;
                    case 55: // PREF_NOTICE_LANG
                        return CurrentItem.PREF_NOTICE_LANG == null;
                    case 56: // GROUP_AVAILABILITY
                        return CurrentItem.GROUP_AVAILABILITY == null;
                    case 57: // OCCUP_STATUS_GRP
                        return CurrentItem.OCCUP_STATUS_GRP == null;
                    case 58: // HOMETITLE
                        return CurrentItem.HOMETITLE == null;
                    case 59: // HOMEKEY
                        return CurrentItem.HOMEKEY == null;
                    case 60: // HOMEKEY_NEW
                        return CurrentItem.HOMEKEY_NEW == null;
                    case 61: // MAILTITLE
                        return CurrentItem.MAILTITLE == null;
                    case 62: // MAILKEY
                        return CurrentItem.MAILKEY == null;
                    case 63: // MAILKEY_NEW
                        return CurrentItem.MAILKEY_NEW == null;
                    case 64: // BILLINGTITLE
                        return CurrentItem.BILLINGTITLE == null;
                    case 65: // BILLINGKEY
                        return CurrentItem.BILLINGKEY == null;
                    case 66: // BILLINGKEY_NEW
                        return CurrentItem.BILLINGKEY_NEW == null;
                    case 67: // BILLING_MEMO
                        return CurrentItem.BILLING_MEMO == null;
                    case 68: // ACCTYPE
                        return CurrentItem.ACCTYPE == null;
                    case 69: // PRICELEVEL
                        return CurrentItem.PRICELEVEL == null;
                    case 70: // BPAY_SEQUENCE
                        return CurrentItem.BPAY_SEQUENCE == null;
                    case 71: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE == null;
                    case 72: // DOCTOR
                        return CurrentItem.DOCTOR == null;
                    case 73: // EMERG_NAME01
                        return CurrentItem.EMERG_NAME01 == null;
                    case 74: // EMERG_NAME02
                        return CurrentItem.EMERG_NAME02 == null;
                    case 75: // EMERG_NAME03
                        return CurrentItem.EMERG_NAME03 == null;
                    case 76: // EMERG_NAME04
                        return CurrentItem.EMERG_NAME04 == null;
                    case 77: // EMERG_RELATION01
                        return CurrentItem.EMERG_RELATION01 == null;
                    case 78: // EMERG_RELATION02
                        return CurrentItem.EMERG_RELATION02 == null;
                    case 79: // EMERG_RELATION03
                        return CurrentItem.EMERG_RELATION03 == null;
                    case 80: // EMERG_RELATION04
                        return CurrentItem.EMERG_RELATION04 == null;
                    case 81: // EMERG_LANG01
                        return CurrentItem.EMERG_LANG01 == null;
                    case 82: // EMERG_LANG02
                        return CurrentItem.EMERG_LANG02 == null;
                    case 83: // EMERG_LANG03
                        return CurrentItem.EMERG_LANG03 == null;
                    case 84: // EMERG_LANG04
                        return CurrentItem.EMERG_LANG04 == null;
                    case 85: // EMERG_CONTACT01
                        return CurrentItem.EMERG_CONTACT01 == null;
                    case 86: // EMERG_CONTACT02
                        return CurrentItem.EMERG_CONTACT02 == null;
                    case 87: // EMERG_CONTACT03
                        return CurrentItem.EMERG_CONTACT03 == null;
                    case 88: // EMERG_CONTACT04
                        return CurrentItem.EMERG_CONTACT04 == null;
                    case 89: // ACC_DECLARATION
                        return CurrentItem.ACC_DECLARATION == null;
                    case 90: // AMBULANCE_SUBSCRIBER
                        return CurrentItem.AMBULANCE_SUBSCRIBER == null;
                    case 91: // MEDICARE_NO
                        return CurrentItem.MEDICARE_NO == null;
                    case 92: // HOME_LANG
                        return CurrentItem.HOME_LANG == null;
                    case 93: // DRAWER
                        return CurrentItem.DRAWER == null;
                    case 94: // BSB
                        return CurrentItem.BSB == null;
                    case 95: // ABN
                        return CurrentItem.ABN == null;
                    case 96: // BILLING_EMAIL
                        return CurrentItem.BILLING_EMAIL == null;
                    case 97: // PREF_EMAIL
                        return CurrentItem.PREF_EMAIL == null;
                    case 98: // UMH_TRANS_ID
                        return CurrentItem.UMH_TRANS_ID == null;
                    case 99: // UMM_TRANS_ID
                        return CurrentItem.UMM_TRANS_ID == null;
                    case 100: // UMB_TRANS_ID
                        return CurrentItem.UMB_TRANS_ID == null;
                    case 101: // KCD_TRANS_ID
                        return CurrentItem.KCD_TRANS_ID == null;
                    case 102: // IMP_STATUS
                        return CurrentItem.IMP_STATUS == null;
                    case 103: // IMP_DATE
                        return CurrentItem.IMP_DATE == null;
                    case 104: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 105: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 106: // LW_USER
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
                    case 1: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 2: // DF_TRANS_ID
                        return "DF_TRANS_ID";
                    case 3: // DFKEY
                        return "DFKEY";
                    case 4: // DFKEY_NEW
                        return "DFKEY_NEW";
                    case 5: // NAME_A
                        return "NAME_A";
                    case 6: // SURNAME_A
                        return "SURNAME_A";
                    case 7: // TITLE_A
                        return "TITLE_A";
                    case 8: // WORK_CONT_A
                        return "WORK_CONT_A";
                    case 9: // OCCUPATION_A
                        return "OCCUPATION_A";
                    case 10: // EMPLOYER_A
                        return "EMPLOYER_A";
                    case 11: // NATIVE_LANG_A
                        return "NATIVE_LANG_A";
                    case 12: // OTHER_LANG_A
                        return "OTHER_LANG_A";
                    case 13: // INTERPRETER_A
                        return "INTERPRETER_A";
                    case 14: // BIRTH_COUNTRY_A
                        return "BIRTH_COUNTRY_A";
                    case 15: // BH_AT_HOME_A
                        return "BH_AT_HOME_A";
                    case 16: // BH_CONTACT_A
                        return "BH_CONTACT_A";
                    case 17: // AH_AT_HOME_A
                        return "AH_AT_HOME_A";
                    case 18: // AH_CONTACT_A
                        return "AH_CONTACT_A";
                    case 19: // E_MAIL_A
                        return "E_MAIL_A";
                    case 20: // PREF_MAIL_MECH_A
                        return "PREF_MAIL_MECH_A";
                    case 21: // FAX_A
                        return "FAX_A";
                    case 22: // GENDER_A
                        return "GENDER_A";
                    case 23: // SCH_ED_A
                        return "SCH_ED_A";
                    case 24: // NON_SCH_ED_A
                        return "NON_SCH_ED_A";
                    case 25: // OCCUP_STATUS_A
                        return "OCCUP_STATUS_A";
                    case 26: // LOTE_HOME_CODE_A
                        return "LOTE_HOME_CODE_A";
                    case 27: // MOBILE_A
                        return "MOBILE_A";
                    case 28: // SMS_NOTIFY_A
                        return "SMS_NOTIFY_A";
                    case 29: // E_MAIL_NOTIFY_A
                        return "E_MAIL_NOTIFY_A";
                    case 30: // NAME_B
                        return "NAME_B";
                    case 31: // SURNAME_B
                        return "SURNAME_B";
                    case 32: // TITLE_B
                        return "TITLE_B";
                    case 33: // WORK_CONT_B
                        return "WORK_CONT_B";
                    case 34: // OCCUPATION_B
                        return "OCCUPATION_B";
                    case 35: // EMPLOYER_B
                        return "EMPLOYER_B";
                    case 36: // NATIVE_LANG_B
                        return "NATIVE_LANG_B";
                    case 37: // OTHER_LANG_B
                        return "OTHER_LANG_B";
                    case 38: // INTERPRETER_B
                        return "INTERPRETER_B";
                    case 39: // BIRTH_COUNTRY_B
                        return "BIRTH_COUNTRY_B";
                    case 40: // BH_AT_HOME_B
                        return "BH_AT_HOME_B";
                    case 41: // BH_CONTACT_B
                        return "BH_CONTACT_B";
                    case 42: // AH_AT_HOME_B
                        return "AH_AT_HOME_B";
                    case 43: // AH_CONTACT_B
                        return "AH_CONTACT_B";
                    case 44: // E_MAIL_B
                        return "E_MAIL_B";
                    case 45: // PREF_MAIL_MECH_B
                        return "PREF_MAIL_MECH_B";
                    case 46: // FAX_B
                        return "FAX_B";
                    case 47: // GENDER_B
                        return "GENDER_B";
                    case 48: // SCH_ED_B
                        return "SCH_ED_B";
                    case 49: // NON_SCH_ED_B
                        return "NON_SCH_ED_B";
                    case 50: // OCCUP_STATUS_B
                        return "OCCUP_STATUS_B";
                    case 51: // LOTE_HOME_CODE_B
                        return "LOTE_HOME_CODE_B";
                    case 52: // MOBILE_B
                        return "MOBILE_B";
                    case 53: // SMS_NOTIFY_B
                        return "SMS_NOTIFY_B";
                    case 54: // E_MAIL_NOTIFY_B
                        return "E_MAIL_NOTIFY_B";
                    case 55: // PREF_NOTICE_LANG
                        return "PREF_NOTICE_LANG";
                    case 56: // GROUP_AVAILABILITY
                        return "GROUP_AVAILABILITY";
                    case 57: // OCCUP_STATUS_GRP
                        return "OCCUP_STATUS_GRP";
                    case 58: // HOMETITLE
                        return "HOMETITLE";
                    case 59: // HOMEKEY
                        return "HOMEKEY";
                    case 60: // HOMEKEY_NEW
                        return "HOMEKEY_NEW";
                    case 61: // MAILTITLE
                        return "MAILTITLE";
                    case 62: // MAILKEY
                        return "MAILKEY";
                    case 63: // MAILKEY_NEW
                        return "MAILKEY_NEW";
                    case 64: // BILLINGTITLE
                        return "BILLINGTITLE";
                    case 65: // BILLINGKEY
                        return "BILLINGKEY";
                    case 66: // BILLINGKEY_NEW
                        return "BILLINGKEY_NEW";
                    case 67: // BILLING_MEMO
                        return "BILLING_MEMO";
                    case 68: // ACCTYPE
                        return "ACCTYPE";
                    case 69: // PRICELEVEL
                        return "PRICELEVEL";
                    case 70: // BPAY_SEQUENCE
                        return "BPAY_SEQUENCE";
                    case 71: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 72: // DOCTOR
                        return "DOCTOR";
                    case 73: // EMERG_NAME01
                        return "EMERG_NAME01";
                    case 74: // EMERG_NAME02
                        return "EMERG_NAME02";
                    case 75: // EMERG_NAME03
                        return "EMERG_NAME03";
                    case 76: // EMERG_NAME04
                        return "EMERG_NAME04";
                    case 77: // EMERG_RELATION01
                        return "EMERG_RELATION01";
                    case 78: // EMERG_RELATION02
                        return "EMERG_RELATION02";
                    case 79: // EMERG_RELATION03
                        return "EMERG_RELATION03";
                    case 80: // EMERG_RELATION04
                        return "EMERG_RELATION04";
                    case 81: // EMERG_LANG01
                        return "EMERG_LANG01";
                    case 82: // EMERG_LANG02
                        return "EMERG_LANG02";
                    case 83: // EMERG_LANG03
                        return "EMERG_LANG03";
                    case 84: // EMERG_LANG04
                        return "EMERG_LANG04";
                    case 85: // EMERG_CONTACT01
                        return "EMERG_CONTACT01";
                    case 86: // EMERG_CONTACT02
                        return "EMERG_CONTACT02";
                    case 87: // EMERG_CONTACT03
                        return "EMERG_CONTACT03";
                    case 88: // EMERG_CONTACT04
                        return "EMERG_CONTACT04";
                    case 89: // ACC_DECLARATION
                        return "ACC_DECLARATION";
                    case 90: // AMBULANCE_SUBSCRIBER
                        return "AMBULANCE_SUBSCRIBER";
                    case 91: // MEDICARE_NO
                        return "MEDICARE_NO";
                    case 92: // HOME_LANG
                        return "HOME_LANG";
                    case 93: // DRAWER
                        return "DRAWER";
                    case 94: // BSB
                        return "BSB";
                    case 95: // ABN
                        return "ABN";
                    case 96: // BILLING_EMAIL
                        return "BILLING_EMAIL";
                    case 97: // PREF_EMAIL
                        return "PREF_EMAIL";
                    case 98: // UMH_TRANS_ID
                        return "UMH_TRANS_ID";
                    case 99: // UMM_TRANS_ID
                        return "UMM_TRANS_ID";
                    case 100: // UMB_TRANS_ID
                        return "UMB_TRANS_ID";
                    case 101: // KCD_TRANS_ID
                        return "KCD_TRANS_ID";
                    case 102: // IMP_STATUS
                        return "IMP_STATUS";
                    case 103: // IMP_DATE
                        return "IMP_DATE";
                    case 104: // LW_DATE
                        return "LW_DATE";
                    case 105: // LW_TIME
                        return "LW_TIME";
                    case 106: // LW_USER
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
                    case "ORIG_SCHOOL":
                        return 1;
                    case "DF_TRANS_ID":
                        return 2;
                    case "DFKEY":
                        return 3;
                    case "DFKEY_NEW":
                        return 4;
                    case "NAME_A":
                        return 5;
                    case "SURNAME_A":
                        return 6;
                    case "TITLE_A":
                        return 7;
                    case "WORK_CONT_A":
                        return 8;
                    case "OCCUPATION_A":
                        return 9;
                    case "EMPLOYER_A":
                        return 10;
                    case "NATIVE_LANG_A":
                        return 11;
                    case "OTHER_LANG_A":
                        return 12;
                    case "INTERPRETER_A":
                        return 13;
                    case "BIRTH_COUNTRY_A":
                        return 14;
                    case "BH_AT_HOME_A":
                        return 15;
                    case "BH_CONTACT_A":
                        return 16;
                    case "AH_AT_HOME_A":
                        return 17;
                    case "AH_CONTACT_A":
                        return 18;
                    case "E_MAIL_A":
                        return 19;
                    case "PREF_MAIL_MECH_A":
                        return 20;
                    case "FAX_A":
                        return 21;
                    case "GENDER_A":
                        return 22;
                    case "SCH_ED_A":
                        return 23;
                    case "NON_SCH_ED_A":
                        return 24;
                    case "OCCUP_STATUS_A":
                        return 25;
                    case "LOTE_HOME_CODE_A":
                        return 26;
                    case "MOBILE_A":
                        return 27;
                    case "SMS_NOTIFY_A":
                        return 28;
                    case "E_MAIL_NOTIFY_A":
                        return 29;
                    case "NAME_B":
                        return 30;
                    case "SURNAME_B":
                        return 31;
                    case "TITLE_B":
                        return 32;
                    case "WORK_CONT_B":
                        return 33;
                    case "OCCUPATION_B":
                        return 34;
                    case "EMPLOYER_B":
                        return 35;
                    case "NATIVE_LANG_B":
                        return 36;
                    case "OTHER_LANG_B":
                        return 37;
                    case "INTERPRETER_B":
                        return 38;
                    case "BIRTH_COUNTRY_B":
                        return 39;
                    case "BH_AT_HOME_B":
                        return 40;
                    case "BH_CONTACT_B":
                        return 41;
                    case "AH_AT_HOME_B":
                        return 42;
                    case "AH_CONTACT_B":
                        return 43;
                    case "E_MAIL_B":
                        return 44;
                    case "PREF_MAIL_MECH_B":
                        return 45;
                    case "FAX_B":
                        return 46;
                    case "GENDER_B":
                        return 47;
                    case "SCH_ED_B":
                        return 48;
                    case "NON_SCH_ED_B":
                        return 49;
                    case "OCCUP_STATUS_B":
                        return 50;
                    case "LOTE_HOME_CODE_B":
                        return 51;
                    case "MOBILE_B":
                        return 52;
                    case "SMS_NOTIFY_B":
                        return 53;
                    case "E_MAIL_NOTIFY_B":
                        return 54;
                    case "PREF_NOTICE_LANG":
                        return 55;
                    case "GROUP_AVAILABILITY":
                        return 56;
                    case "OCCUP_STATUS_GRP":
                        return 57;
                    case "HOMETITLE":
                        return 58;
                    case "HOMEKEY":
                        return 59;
                    case "HOMEKEY_NEW":
                        return 60;
                    case "MAILTITLE":
                        return 61;
                    case "MAILKEY":
                        return 62;
                    case "MAILKEY_NEW":
                        return 63;
                    case "BILLINGTITLE":
                        return 64;
                    case "BILLINGKEY":
                        return 65;
                    case "BILLINGKEY_NEW":
                        return 66;
                    case "BILLING_MEMO":
                        return 67;
                    case "ACCTYPE":
                        return 68;
                    case "PRICELEVEL":
                        return 69;
                    case "BPAY_SEQUENCE":
                        return 70;
                    case "BPAY_REFERENCE":
                        return 71;
                    case "DOCTOR":
                        return 72;
                    case "EMERG_NAME01":
                        return 73;
                    case "EMERG_NAME02":
                        return 74;
                    case "EMERG_NAME03":
                        return 75;
                    case "EMERG_NAME04":
                        return 76;
                    case "EMERG_RELATION01":
                        return 77;
                    case "EMERG_RELATION02":
                        return 78;
                    case "EMERG_RELATION03":
                        return 79;
                    case "EMERG_RELATION04":
                        return 80;
                    case "EMERG_LANG01":
                        return 81;
                    case "EMERG_LANG02":
                        return 82;
                    case "EMERG_LANG03":
                        return 83;
                    case "EMERG_LANG04":
                        return 84;
                    case "EMERG_CONTACT01":
                        return 85;
                    case "EMERG_CONTACT02":
                        return 86;
                    case "EMERG_CONTACT03":
                        return 87;
                    case "EMERG_CONTACT04":
                        return 88;
                    case "ACC_DECLARATION":
                        return 89;
                    case "AMBULANCE_SUBSCRIBER":
                        return 90;
                    case "MEDICARE_NO":
                        return 91;
                    case "HOME_LANG":
                        return 92;
                    case "DRAWER":
                        return 93;
                    case "BSB":
                        return 94;
                    case "ABN":
                        return 95;
                    case "BILLING_EMAIL":
                        return 96;
                    case "PREF_EMAIL":
                        return 97;
                    case "UMH_TRANS_ID":
                        return 98;
                    case "UMM_TRANS_ID":
                        return 99;
                    case "UMB_TRANS_ID":
                        return 100;
                    case "KCD_TRANS_ID":
                        return 101;
                    case "IMP_STATUS":
                        return 102;
                    case "IMP_DATE":
                        return 103;
                    case "LW_DATE":
                        return 104;
                    case "LW_TIME":
                        return 105;
                    case "LW_USER":
                        return 106;
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
