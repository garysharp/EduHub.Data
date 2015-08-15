using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medical Conditions
    /// </summary>
    public class SMC_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _STUDENT_ST;
        private KCM_Entity _MED_CONDITION_KCM;
        private SCI_Entity _CAMPUS_SCI;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int SMCKEY { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// Medical condition [Uppercase Alphanumeric: u10]
        /// </summary>
        public string MED_CONDITION { get; internal set; }
        /// <summary>
        /// Description of symptoms exhibited as a result of this condition [Memo: m]
        /// </summary>
        public string SYMPTOMS { get; internal set; }
        /// <summary>
        /// General comments about this condition [Memo: m]
        /// </summary>
        public string SMC_COMMENT { get; internal set; }
        /// <summary>
        /// Description of medication taken regularly to prevent medical condition occurring [Alphanumeric: a60]
        /// </summary>
        public string REGULAR_MEDICATION { get; internal set; }
        /// <summary>
        /// (Was POISON_RATING) Poison rating of preventative medication (eg. S1) [Uppercase Alphanumeric: u2]
        /// </summary>
        public string REGULAR_POISON_RATING { get; internal set; }
        /// <summary>
        /// Normal Dosage of preventative medication taken regularly (eg. 1 tablet) [Alphanumeric: a30]
        /// </summary>
        public string REGULAR_DOSAGE { get; internal set; }
        /// <summary>
        /// How often should the preventative medication be taken (eg. Daily, Twice Daily) [Alphanumeric: a15]
        /// </summary>
        public string REGULAR_FREQUENCY { get; internal set; }
        /// <summary>
        /// At what time of day should the preventative medication be taken (eg. Start of day, Lunchtime) [Alphanumeric: a15]
        /// </summary>
        public string REGULAR_DOSAGE_TIME { get; internal set; }
        /// <summary>
        /// Where is the preventative medication stored? [Alphanumeric: a30]
        /// </summary>
        public string REGULAR_MEDICATION_LOCAT { get; internal set; }
        /// <summary>
        /// Who should administer the preventative medication (Student, Teacher, Nurse, Other) [Alphanumeric: a7]
        /// </summary>
        public string REGULAR_ADMIN_BY { get; internal set; }
        /// <summary>
        /// Does the student require a reminder to take the preventative medication? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REMINDER { get; internal set; }
        /// <summary>
        /// Should doctor be informed if the condition occurs? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INFORM_DOCTOR { get; internal set; }
        /// <summary>
        /// Should emergency contact(s) be informed if the condition occurs? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INFORM_EMERG_CONTACT { get; internal set; }
        /// <summary>
        /// Should medication be administered if the condition occurs? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ADMINISTER_MEDICATION { get; internal set; }
        /// <summary>
        /// Should any other action be taken if the condition occurs? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OTHER_MEDICAL_ACTION { get; internal set; }
        /// <summary>
        /// Description of other action that should be taken if the condition occurs; must be filled in if OTHER_MEDICAL_ACTION filled in [Memo: m]
        /// </summary>
        public string SMC_ACTION { get; internal set; }
        /// <summary>
        /// Description of medication that should be taken if the condition occurs [Alphanumeric: a60]
        /// </summary>
        public string AD_HOC_MEDICATION { get; internal set; }
        /// <summary>
        /// Poison rating of medication that should be taken if the condition occurs (eg. S1) [Uppercase Alphanumeric: u2]
        /// </summary>
        public string AD_HOC_POISON_RATING { get; internal set; }
        /// <summary>
        /// Dosage of medication that should be taken if the condition occurs (eg. 1 tablet) [Alphanumeric: a30]
        /// </summary>
        public string AD_HOC_DOSAGE { get; internal set; }
        /// <summary>
        /// How often following the onset of the condition should this medication be taken (eg. Once, Hourly, Every 10 mins) [Alphanumeric: a15]
        /// </summary>
        public string AD_HOC_FREQUENCY { get; internal set; }
        /// <summary>
        /// Where is the medication stored that should be taken if the condition occurs [Alphanumeric: a30]
        /// </summary>
        public string AD_HOC_MEDICATION_LOCAT { get; internal set; }
        /// <summary>
        /// Who should administer the medication that should be taken if the condition occurs (Student, Teacher, Nurse, Other) [Alphanumeric: a7]
        /// </summary>
        public string AD_HOC_ADMIN_BY { get; internal set; }
        /// <summary>
        /// Description of medication taken at home to prevent medical condition occurring [Alphanumeric: a60]
        /// </summary>
        public string HOME_MEDICATION { get; internal set; }
        /// <summary>
        /// Wheeze? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ASTHMA_WHEEZE { get; internal set; }
        /// <summary>
        /// Cough? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ASTHMA_COUGH { get; internal set; }
        /// <summary>
        /// Difficulty breathing? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ASTHMA_DIFFBRE { get; internal set; }
        /// <summary>
        /// Tight chest? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ASTHMA_TGTCHES { get; internal set; }
        /// <summary>
        /// Symptoms after exertion? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ASTHMA_SYMTEXE { get; internal set; }
        /// <summary>
        /// Management plan notes [Memo: m]
        /// </summary>
        public string ASTHMA_MGT_PLAN { get; internal set; }
        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY { get; internal set; }
        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ROOM_TYPE { get; internal set; }
        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GROUP_INDICATOR { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STUDENT_ST {
            get
            {
                if (STUDENT != null)
                {
                    if (_STUDENT_ST == null)
                    {
                        _STUDENT_ST = Context.ST.FindBySTKEY(STUDENT);
                    }
                    return _STUDENT_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MED_CONDITION] => [KCM_Entity].[KCMKEY]
        /// Medical condition
        /// </summary>
        public KCM_Entity MED_CONDITION_KCM {
            get
            {
                if (MED_CONDITION != null)
                {
                    if (_MED_CONDITION_KCM == null)
                    {
                        _MED_CONDITION_KCM = Context.KCM.FindByKCMKEY(MED_CONDITION);
                    }
                    return _MED_CONDITION_KCM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Dummy field necessary because table is an ACCOUNT table with a short name starting with SM
        /// </summary>
        public SCI_Entity CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
