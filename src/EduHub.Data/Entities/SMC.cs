using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medical Conditions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMC : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_STUDENT_ST;
        private KCM Cache_MED_CONDITION_KCM;
        private SCI Cache_CAMPUS_SCI;

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<SMCD> Cache_SMCKEY_SMCD_SMCDKEY;
#endif

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Sequence no
        /// </summary>
        public int SMCKEY { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT { get; internal set; }

        /// <summary>
        /// Medical condition
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string MED_CONDITION { get; internal set; }

        /// <summary>
        /// Description of symptoms exhibited as a result of this condition
        /// [Memo]
        /// </summary>
        public string SYMPTOMS { get; internal set; }

        /// <summary>
        /// General comments about this condition
        /// [Memo]
        /// </summary>
        public string SMC_COMMENT { get; internal set; }

        /// <summary>
        /// Description of medication taken regularly to prevent medical condition occurring
        /// [Alphanumeric (60)]
        /// </summary>
        public string REGULAR_MEDICATION { get; internal set; }

        /// <summary>
        /// (Was POISON_RATING) Poison rating of preventative medication (eg. S1)
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string REGULAR_POISON_RATING { get; internal set; }

        /// <summary>
        /// Normal Dosage of preventative medication taken regularly (eg. 1 tablet)
        /// [Alphanumeric (30)]
        /// </summary>
        public string REGULAR_DOSAGE { get; internal set; }

        /// <summary>
        /// How often should the preventative medication be taken (eg. Daily, Twice Daily)
        /// [Alphanumeric (15)]
        /// </summary>
        public string REGULAR_FREQUENCY { get; internal set; }

        /// <summary>
        /// At what time of day should the preventative medication be taken (eg. Start of day, Lunchtime)
        /// [Alphanumeric (15)]
        /// </summary>
        public string REGULAR_DOSAGE_TIME { get; internal set; }

        /// <summary>
        /// Where is the preventative medication stored?
        /// [Alphanumeric (100)]
        /// </summary>
        public string REGULAR_MEDICATION_LOCAT { get; internal set; }

        /// <summary>
        /// Who should administer the preventative medication (Student, Teacher, Nurse, Other)
        /// [Alphanumeric (7)]
        /// </summary>
        public string REGULAR_ADMIN_BY { get; internal set; }

        /// <summary>
        /// Does the student require a reminder to take the preventative medication? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REMINDER { get; internal set; }

        /// <summary>
        /// Should doctor be informed if the condition occurs? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INFORM_DOCTOR { get; internal set; }

        /// <summary>
        /// Should emergency contact(s) be informed if the condition occurs? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INFORM_EMERG_CONTACT { get; internal set; }

        /// <summary>
        /// Should medication be administered if the condition occurs? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ADMINISTER_MEDICATION { get; internal set; }

        /// <summary>
        /// Should any other action be taken if the condition occurs? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OTHER_MEDICAL_ACTION { get; internal set; }

        /// <summary>
        /// Description of other action that should be taken if the condition occurs; must be filled in if OTHER_MEDICAL_ACTION filled in
        /// [Memo]
        /// </summary>
        public string SMC_ACTION { get; internal set; }

        /// <summary>
        /// Description of medication that should be taken if the condition occurs
        /// [Alphanumeric (60)]
        /// </summary>
        public string AD_HOC_MEDICATION { get; internal set; }

        /// <summary>
        /// Poison rating of medication that should be taken if the condition occurs (eg. S1)
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AD_HOC_POISON_RATING { get; internal set; }

        /// <summary>
        /// Dosage of medication that should be taken if the condition occurs (eg. 1 tablet)
        /// [Alphanumeric (30)]
        /// </summary>
        public string AD_HOC_DOSAGE { get; internal set; }

        /// <summary>
        /// How often following the onset of the condition should this medication be taken (eg. Once, Hourly, Every 10 mins)
        /// [Alphanumeric (15)]
        /// </summary>
        public string AD_HOC_FREQUENCY { get; internal set; }

        /// <summary>
        /// Where is the medication stored that should be taken if the condition occurs
        /// [Alphanumeric (100)]
        /// </summary>
        public string AD_HOC_MEDICATION_LOCAT { get; internal set; }

        /// <summary>
        /// Who should administer the medication that should be taken if the condition occurs (Student, Teacher, Nurse, Other)
        /// [Alphanumeric (7)]
        /// </summary>
        public string AD_HOC_ADMIN_BY { get; internal set; }

        /// <summary>
        /// Description of medication taken at home to prevent medical condition occurring
        /// [Alphanumeric (60)]
        /// </summary>
        public string HOME_MEDICATION { get; internal set; }

        /// <summary>
        /// Wheeze? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASTHMA_WHEEZE { get; internal set; }

        /// <summary>
        /// Cough? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASTHMA_COUGH { get; internal set; }

        /// <summary>
        /// Difficulty breathing? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASTHMA_DIFFBRE { get; internal set; }

        /// <summary>
        /// Tight chest? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASTHMA_TGTCHES { get; internal set; }

        /// <summary>
        /// Symptoms after exertion? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASTHMA_SYMTEXE { get; internal set; }

        /// <summary>
        /// Management plan notes
        /// [Memo]
        /// </summary>
        public string ASTHMA_MGT_PLAN { get; internal set; }

        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY { get; internal set; }

        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_TYPE { get; internal set; }

        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }

        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_INDICATOR { get; internal set; }

        /// <summary>
        /// Adjustment details
        /// [Memo]
        /// </summary>
        public string DISABILITY_ADJUSTMENT { get; internal set; }

        /// <summary>
        /// Regular Medication Expiry
        /// </summary>
        public DateTime? EXP_REG_MED { get; internal set; }

        /// <summary>
        /// As-Required Medication Expiry
        /// </summary>
        public DateTime? EXP_ASREQ_MED { get; internal set; }

        /// <summary>
        /// Student Insight (NextGen) unique identifier
        /// [Alphanumeric (20)]
        /// </summary>
        public string HEALTH_INFO_SI_ID { get; internal set; }

        /// <summary>
        /// Flag to identify the most critical/important medical conditions for a student
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ALERT { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [SMC.STUDENT]-&gt;[ST.STKEY]
        /// Student ID
        /// </summary>
        public ST STUDENT_ST
        {
            get
            {
                if (STUDENT == null)
                {
                    return null;
                }
                if (Cache_STUDENT_ST == null)
                {
                    Cache_STUDENT_ST = Context.ST.FindBySTKEY(STUDENT);
                }

                return Cache_STUDENT_ST;
            }
        }

        /// <summary>
        /// KCM (Medical Conditions) related entity by [SMC.MED_CONDITION]-&gt;[KCM.KCMKEY]
        /// Medical condition
        /// </summary>
        public KCM MED_CONDITION_KCM
        {
            get
            {
                if (MED_CONDITION == null)
                {
                    return null;
                }
                if (Cache_MED_CONDITION_KCM == null)
                {
                    Cache_MED_CONDITION_KCM = Context.KCM.FindByKCMKEY(MED_CONDITION);
                }

                return Cache_MED_CONDITION_KCM;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SMC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// SMCD (Student Medication Doses) related entities by [SMC.SMCKEY]-&gt;[SMCD.SMCDKEY]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SMCD> SMCKEY_SMCD_SMCDKEY
        {
            get
            {
                if (Cache_SMCKEY_SMCD_SMCDKEY == null &&
                    !Context.SMCD.TryFindBySMCDKEY(SMCKEY, out Cache_SMCKEY_SMCD_SMCDKEY))
                {
                    Cache_SMCKEY_SMCD_SMCDKEY = new List<SMCD>().AsReadOnly();
                }

                return Cache_SMCKEY_SMCD_SMCDKEY;
            }
        }

#endif
        #endregion

    }
}
