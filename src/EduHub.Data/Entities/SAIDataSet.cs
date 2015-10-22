using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvements/Sickbay Visits Data Set
    /// </summary>
    public sealed partial class SAIDataSet : SetBase<SAI>
    {
        private Lazy<Dictionary<int, SAI>> SAIKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<SAII>>> SAII_INVOLVEMENTIDForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SAIM>>> SAIM_INVOLVEMENTIDForeignIndex;

        internal SAIDataSet(EduHubContext Context)
            : base(Context)
        {
            SAIKEYIndex = new Lazy<Dictionary<int, SAI>>(() => this.ToDictionary(e => e.SAIKEY));

            SAII_INVOLVEMENTIDForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SAII>>>(() =>
                    Context.SAII
                          .Where(e => e.INVOLVEMENTID != null)
                          .GroupBy(e => e.INVOLVEMENTID.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAII>)g.ToList()
                          .AsReadOnly()));

            SAIM_INVOLVEMENTIDForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SAIM>>>(() =>
                    Context.SAIM
                          .Where(e => e.INVOLVEMENTID != null)
                          .GroupBy(e => e.INVOLVEMENTID.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAIM>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAI"; } }

        /// <summary>
        /// Find SAI by SAIKEY key field
        /// </summary>
        /// <param name="Key">SAIKEY value used to find SAI</param>
        /// <returns>Related SAI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SAIKEY value didn't match any SAI entities</exception>
        public SAI FindBySAIKEY(int Key)
        {
            SAI result;
            if (SAIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SAI by SAIKEY key field
        /// </summary>
        /// <param name="Key">SAIKEY value used to find SAI</param>
        /// <param name="Value">Related SAI entity</param>
        /// <returns>True if the SAI entity is found</returns>
        public bool TryFindBySAIKEY(int Key, out SAI Value)
        {
            return SAIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SAI by SAIKEY key field
        /// </summary>
        /// <param name="Key">SAIKEY value used to find SAI</param>
        /// <returns>Related SAI entity, or null if not found</returns>
        public SAI TryFindBySAIKEY(int Key)
        {
            SAI result;
            if (SAIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SAII (Accident Involvement Injuries) entities by [SAII.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAII entities</param>
        /// <returns>A list of related SAII entities</returns>
        public IReadOnlyList<SAII> FindSAIIByINVOLVEMENTID(int SAIKEY)
        {
            IReadOnlyList<SAII> result;
            if (SAII_INVOLVEMENTIDForeignIndex.Value.TryGetValue(SAIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAII>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAII entities by [SAII.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAII entities</param>
        /// <param name="Value">A list of related SAII entities</param>
        /// <returns>True if any SAII entities are found</returns>
        public bool TryFindSAIIByINVOLVEMENTID(int SAIKEY, out IReadOnlyList<SAII> Value)
        {
            return SAII_INVOLVEMENTIDForeignIndex.Value.TryGetValue(SAIKEY, out Value);
        }

        /// <summary>
        /// Find all SAIM (Sickbay Medication Administrations) entities by [SAIM.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAIM entities</param>
        /// <returns>A list of related SAIM entities</returns>
        public IReadOnlyList<SAIM> FindSAIMByINVOLVEMENTID(int SAIKEY)
        {
            IReadOnlyList<SAIM> result;
            if (SAIM_INVOLVEMENTIDForeignIndex.Value.TryGetValue(SAIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAIM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAIM entities by [SAIM.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAIM entities</param>
        /// <param name="Value">A list of related SAIM entities</param>
        /// <returns>True if any SAIM entities are found</returns>
        public bool TryFindSAIMByINVOLVEMENTID(int SAIKEY, out IReadOnlyList<SAIM> Value)
        {
            return SAIM_INVOLVEMENTIDForeignIndex.Value.TryGetValue(SAIKEY, out Value);
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
    }
}
