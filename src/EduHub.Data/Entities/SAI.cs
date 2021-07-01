using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvements/Sickbay Visits
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAI : EduHubEntity
    {

        #region Navigation Property Cache

        private SAD Cache_ACCIDENTID_SAD;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SAII> Cache_SAIKEY_SAII_INVOLVEMENTID;
        private IReadOnlyList<SAIM> Cache_SAIKEY_SAIM_INVOLVEMENTID;

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
        /// Record ID
        /// </summary>
        public int SAIKEY { get; internal set; }

        /// <summary>
        /// Type of record: A=Accident, S=Sickbay, B=Both
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENTRY_TYPE { get; internal set; }

        /// <summary>
        /// Sequence no of accident
        /// </summary>
        public int? ACCIDENTID { get; internal set; }

        /// <summary>
        /// Type of person involved: ST=Student, SF=Staff member, DF=Family member, OT=Other
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string INV_PERSON_TYPE { get; internal set; }

        /// <summary>
        /// Code identifying person involved (if student, staff member or family member)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string INV_PERSONKEY { get; internal set; }

        /// <summary>
        /// Code indicating whether person involved is adult A or B in family (if family member)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INV_PERSON_DFAB { get; internal set; }

        /// <summary>
        /// Full name of person involved (automatically entered if student, staff member or family member)
        /// [Alphanumeric (64)]
        /// </summary>
        public string INV_FULL_NAME { get; internal set; }

        /// <summary>
        /// Address of person involved (automatically entered if student, staff member or family member)
        /// [Alphanumeric (120)]
        /// </summary>
        public string INV_ADDRESS { get; internal set; }

        /// <summary>
        /// Phone number of person involved (automatically entered if student, staff member or family member)
        /// [Alphanumeric (20)]
        /// </summary>
        public string INV_TELEPHONE { get; internal set; }

        /// <summary>
        /// Birth Date of person involved (automatically entered if student, staff member or family member)
        /// </summary>
        public DateTime? INV_BIRTHDATE { get; internal set; }

        /// <summary>
        /// Gender of person involved (automatically entered if student, staff member or family member)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INV_GENDER { get; internal set; }

        /// <summary>
        /// Central payroll record number of person involved if staff member (this column is not redundant as there may no longer be an associated SF record)
        /// [Uppercase Alphanumeric (9)]
        /// </summary>
        public string INV_PAYROLL_REC_NO { get; internal set; }

        /// <summary>
        /// Type of staff member if involved person is of type SF
        /// [Alphanumeric (2)]
        /// </summary>
        public string INV_STAFF_TYPE { get; internal set; }

        /// <summary>
        /// Type of person providing help: ST=Student, SF=Staff member, DF=Family member, OT=Other
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string HELP_PERSON_TYPE { get; internal set; }

        /// <summary>
        /// Code identifying person providing help (if student, staff member or family member)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HELP_PERSONKEY { get; internal set; }

        /// <summary>
        /// Code indicating whether person providing help is adult A or B in family (if family member)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HELP_PERSON_DFAB { get; internal set; }

        /// <summary>
        /// Full name of person providing help (if not student, staff member or family member)
        /// [Alphanumeric (32)]
        /// </summary>
        public string HELP_FULL_NAME { get; internal set; }

        /// <summary>
        /// Incident Number used for reporting to Department
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string INCIDENT_NO { get; internal set; }

        /// <summary>
        /// Has this information been transmitted to Department? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SENT_TO_DEPT { get; internal set; }

        /// <summary>
        /// Has a claim been lodged? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLAIM_LODGED { get; internal set; }

        /// <summary>
        /// Date claim received
        /// </summary>
        public DateTime? CLAIM_DATE { get; internal set; }

        /// <summary>
        /// Date work ceased
        /// </summary>
        public DateTime? WORK_CEASED_DATE { get; internal set; }

        /// <summary>
        /// Name of contact associated with person involved if successfully contacted
        /// [Alphanumeric (40)]
        /// </summary>
        public string SUCCESSFUL_CONTACT { get; internal set; }

        /// <summary>
        /// Name of contact not associated with person involved if successfully contacted
        /// [Alphanumeric (40)]
        /// </summary>
        public string OTHER_SUCCESSFUL_CONTACT { get; internal set; }

        /// <summary>
        /// Name of attending doctor associated with person involved
        /// [Alphanumeric (40)]
        /// </summary>
        public string DOCTOR { get; internal set; }

        /// <summary>
        /// Name of attending doctor not associated with person involved
        /// [Alphanumeric (40)]
        /// </summary>
        public string OTHER_DOCTOR { get; internal set; }

        /// <summary>
        /// Hospital contacted
        /// [Alphanumeric (40)]
        /// </summary>
        public string HOSPITAL { get; internal set; }

        /// <summary>
        /// Ambulance contacted? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMBULANCE { get; internal set; }

        /// <summary>
        /// Date of attendance
        /// </summary>
        public DateTime? ATTENDANCE_DATE { get; internal set; }

        /// <summary>
        /// Start time
        /// </summary>
        public short? ATTENDANCE_IN_TIME { get; internal set; }

        /// <summary>
        /// Finish time
        /// </summary>
        public short? ATTENDANCE_OUT_TIME { get; internal set; }

        /// <summary>
        /// Description of initial symptoms
        /// [Memo]
        /// </summary>
        public string SYMPTOMS { get; internal set; }

        /// <summary>
        /// Description of general action taken
        /// [Memo]
        /// </summary>
        public string SICKBAY_ACTION { get; internal set; }

        /// <summary>
        /// Description of outcome of action taken
        /// [Memo]
        /// </summary>
        public string ACTION_OUTCOME { get; internal set; }

        /// <summary>
        /// Key of SMS recipient record sent relating this sickbay visit
        /// </summary>
        public int? SMS_KEY { get; internal set; }

        /// <summary>
        /// Key of Email recipient record sent relating this sickbay visit
        /// </summary>
        public int? EMAIL_KEY { get; internal set; }

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
        /// SAD (Accidents) related entity by [SAI.ACCIDENTID]-&gt;[SAD.SADKEY]
        /// Sequence no of accident
        /// </summary>
        public SAD ACCIDENTID_SAD
        {
            get
            {
                if (ACCIDENTID == null)
                {
                    return null;
                }
                if (Cache_ACCIDENTID_SAD == null)
                {
                    Cache_ACCIDENTID_SAD = Context.SAD.FindBySADKEY(ACCIDENTID.Value);
                }

                return Cache_ACCIDENTID_SAD;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SAII (Accident Involvement Injuries) related entities by [SAI.SAIKEY]-&gt;[SAII.INVOLVEMENTID]
        /// Record ID
        /// </summary>
        public IReadOnlyList<SAII> SAIKEY_SAII_INVOLVEMENTID
        {
            get
            {
                if (Cache_SAIKEY_SAII_INVOLVEMENTID == null &&
                    !Context.SAII.TryFindByINVOLVEMENTID(SAIKEY, out Cache_SAIKEY_SAII_INVOLVEMENTID))
                {
                    Cache_SAIKEY_SAII_INVOLVEMENTID = new List<SAII>().AsReadOnly();
                }

                return Cache_SAIKEY_SAII_INVOLVEMENTID;
            }
        }

        /// <summary>
        /// SAIM (Sickbay Medication Administrations) related entities by [SAI.SAIKEY]-&gt;[SAIM.INVOLVEMENTID]
        /// Record ID
        /// </summary>
        public IReadOnlyList<SAIM> SAIKEY_SAIM_INVOLVEMENTID
        {
            get
            {
                if (Cache_SAIKEY_SAIM_INVOLVEMENTID == null &&
                    !Context.SAIM.TryFindByINVOLVEMENTID(SAIKEY, out Cache_SAIKEY_SAIM_INVOLVEMENTID))
                {
                    Cache_SAIKEY_SAIM_INVOLVEMENTID = new List<SAIM>().AsReadOnly();
                }

                return Cache_SAIKEY_SAIM_INVOLVEMENTID;
            }
        }

        #endregion

    }
}
