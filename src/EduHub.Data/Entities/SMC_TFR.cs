using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMC Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMC_TFR : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_ORIG_SCHOOL_SKGS;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Orignating School
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }

        /// <summary>
        /// Unique SMC Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SMC_TRANS_ID { get; internal set; }

        /// <summary>
        /// Sequence no
        /// </summary>
        public int? SMCKEY { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT { get; internal set; }

        /// <summary>
        /// Indicates if medical condition could not be imported
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONDITION_EXISTS { get; internal set; }

        /// <summary>
        /// New STKEY
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT_NEW { get; internal set; }

        /// <summary>
        /// Medical condition
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string MED_CONDITION { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string MED_CONDITION_NEW { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MED_CONDITION_ACT { get; internal set; }

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
        /// [Alphanumeric (30)]
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
        /// [Alphanumeric (30)]
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
        /// Unique DF Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }

        /// <summary>
        /// Unique DF Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string KCM_TRANS_ID { get; internal set; }

        /// <summary>
        /// Current Status of Import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string IMP_STATUS { get; internal set; }

        /// <summary>
        /// Actual Date data transfered into live table
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }

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
        /// SKGS (Schools) related entity by [SMC_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS ORIG_SCHOOL_SKGS
        {
            get
            {
                if (Cache_ORIG_SCHOOL_SKGS == null)
                {
                    Cache_ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                }

                return Cache_ORIG_SCHOOL_SKGS;
            }
        }

        #endregion

    }
}
