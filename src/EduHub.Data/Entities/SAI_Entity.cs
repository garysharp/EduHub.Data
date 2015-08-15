using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvements/Sickbay Visits
    /// </summary>
    public class SAI_Entity : EntityBase
    {
#region Navigation Property Cache
        private SAD_Entity _ACCIDENTID_SAD;
#endregion

#region Field Properties
        /// <summary>
        /// Record ID [Integer (32bit signed): l]
        /// </summary>
        public int SAIKEY { get; internal set; }
        /// <summary>
        /// Type of record: A=Accident, S=Sickbay, B=Both [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENTRY_TYPE { get; internal set; }
        /// <summary>
        /// Sequence no of accident [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCIDENTID { get; internal set; }
        /// <summary>
        /// Type of person involved: ST=Student, SF=Staff member, DF=Family member, OT=Other [Uppercase Alphanumeric: u2]
        /// </summary>
        public string INV_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person involved (if student, staff member or family member) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string INV_PERSONKEY { get; internal set; }
        /// <summary>
        /// Code indicating whether person involved is adult A or B in family (if family member) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INV_PERSON_DFAB { get; internal set; }
        /// <summary>
        /// Full name of person involved (automatically entered if student, staff member or family member) [Alphanumeric: a64]
        /// </summary>
        public string INV_FULL_NAME { get; internal set; }
        /// <summary>
        /// Address of person involved (automatically entered if student, staff member or family member) [Alphanumeric: a120]
        /// </summary>
        public string INV_ADDRESS { get; internal set; }
        /// <summary>
        /// Phone number of person involved (automatically entered if student, staff member or family member) [Alphanumeric: a20]
        /// </summary>
        public string INV_TELEPHONE { get; internal set; }
        /// <summary>
        /// Birth Date of person involved (automatically entered if student, staff member or family member) [Date Time nullable: d]
        /// </summary>
        public DateTime? INV_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Gender of person involved (automatically entered if student, staff member or family member) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INV_GENDER { get; internal set; }
        /// <summary>
        /// Central payroll record number of person involved if staff member (this column is not redundant as there may no longer be an associated SF record) [Uppercase Alphanumeric: u9]
        /// </summary>
        public string INV_PAYROLL_REC_NO { get; internal set; }
        /// <summary>
        /// Type of staff member if involved person is of type SF [Alphanumeric: a2]
        /// </summary>
        public string INV_STAFF_TYPE { get; internal set; }
        /// <summary>
        /// Type of person providing help: ST=Student, SF=Staff member, DF=Family member, OT=Other [Uppercase Alphanumeric: u2]
        /// </summary>
        public string HELP_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person providing help (if student, staff member or family member) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HELP_PERSONKEY { get; internal set; }
        /// <summary>
        /// Code indicating whether person providing help is adult A or B in family (if family member) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HELP_PERSON_DFAB { get; internal set; }
        /// <summary>
        /// Full name of person providing help (if not student, staff member or family member) [Alphanumeric: a32]
        /// </summary>
        public string HELP_FULL_NAME { get; internal set; }
        /// <summary>
        /// Incident Number used for reporting to DEECD [Uppercase Alphanumeric: u6]
        /// </summary>
        public string INCIDENT_NO { get; internal set; }
        /// <summary>
        /// Has this information been transmitted to DEECD? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SENT_TO_DEPT { get; internal set; }
        /// <summary>
        /// Has a claim been lodged? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLAIM_LODGED { get; internal set; }
        /// <summary>
        /// Date claim received [Date Time nullable: d]
        /// </summary>
        public DateTime? CLAIM_DATE { get; internal set; }
        /// <summary>
        /// Date work ceased [Date Time nullable: d]
        /// </summary>
        public DateTime? WORK_CEASED_DATE { get; internal set; }
        /// <summary>
        /// Name of contact associated with person involved if successfully contacted [Alphanumeric: a40]
        /// </summary>
        public string SUCCESSFUL_CONTACT { get; internal set; }
        /// <summary>
        /// Name of contact not associated with person involved if successfully contacted [Alphanumeric: a40]
        /// </summary>
        public string OTHER_SUCCESSFUL_CONTACT { get; internal set; }
        /// <summary>
        /// Name of attending doctor associated with person involved [Alphanumeric: a40]
        /// </summary>
        public string DOCTOR { get; internal set; }
        /// <summary>
        /// Name of attending doctor not associated with person involved [Alphanumeric: a40]
        /// </summary>
        public string OTHER_DOCTOR { get; internal set; }
        /// <summary>
        /// Hospital contacted [Alphanumeric: a40]
        /// </summary>
        public string HOSPITAL { get; internal set; }
        /// <summary>
        /// Ambulance contacted? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMBULANCE { get; internal set; }
        /// <summary>
        /// Date of attendance [Date Time nullable: d]
        /// </summary>
        public DateTime? ATTENDANCE_DATE { get; internal set; }
        /// <summary>
        /// Start time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ATTENDANCE_IN_TIME { get; internal set; }
        /// <summary>
        /// Finish time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ATTENDANCE_OUT_TIME { get; internal set; }
        /// <summary>
        /// Description of initial symptoms [Memo: m]
        /// </summary>
        public string SYMPTOMS { get; internal set; }
        /// <summary>
        /// Description of general action taken [Memo: m]
        /// </summary>
        public string SICKBAY_ACTION { get; internal set; }
        /// <summary>
        /// Description of outcome of action taken [Memo: m]
        /// </summary>
        public string ACTION_OUTCOME { get; internal set; }
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
        /// Navigation property for [ACCIDENTID] => [SAD_Entity].[SADKEY]
        /// Sequence no of accident
        /// </summary>
        public SAD_Entity ACCIDENTID_SAD {
            get
            {
                if (ACCIDENTID.HasValue)
                {
                    if (_ACCIDENTID_SAD == null)
                    {
                        _ACCIDENTID_SAD = Context.SAD.FindBySADKEY(ACCIDENTID.Value);
                    }
                    return _ACCIDENTID_SAD;
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
