using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Data Set
    /// </summary>
    public sealed class SF_DataSet : SetBase<SF_Entity>
    {
        private Lazy<Dictionary<string, SF_Entity>> SFKEY_Index;

        internal SF_DataSet(EduHubContext Context)
            : base(Context)
        {
            SFKEY_Index = new Lazy<Dictionary<string, SF_Entity>>(() => this.ToDictionary(e => e.SFKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SF"; } }

        /// <summary>
        /// Find SF by SFKEY key field
        /// </summary>
        /// <param name="Key">SFKEY value used to find SF</param>
        /// <returns>Related SF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SFKEY value didn't match any SF entities</exception>
        public SF_Entity FindBySFKEY(string Key)
        {
            SF_Entity result;
            if (SFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SF by SFKEY key field
        /// </summary>
        /// <param name="Key">SFKEY value used to find SF</param>
        /// <param name="Value">Related SF entity</param>
        /// <returns>True if the SF Entity is found</returns>
        public bool TryFindBySFKEY(string Key, out SF_Entity Value)
        {
            return SFKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SFKEY key field
        /// </summary>
        /// <param name="Key">SFKEY value used to find SF</param>
        /// <returns>Related SF entity, or null if not found</returns>
        public SF_Entity TryFindBySFKEY(string Key)
        {
            SF_Entity result;
            if (SFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SF_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SF_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SFKEY":
                        mapper[i] = (e, v) => e.SFKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PREF_NAME":
                        mapper[i] = (e, v) => e.PREF_NAME = v;
                        break;
                    case "PREVIOUS_NAME":
                        mapper[i] = (e, v) => e.PREVIOUS_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "VIT_NO":
                        mapper[i] = (e, v) => e.VIT_NO = v;
                        break;
                    case "START":
                        mapper[i] = (e, v) => e.START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FINISH":
                        mapper[i] = (e, v) => e.FINISH = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FACULTY01":
                        mapper[i] = (e, v) => e.FACULTY01 = v;
                        break;
                    case "FACULTY02":
                        mapper[i] = (e, v) => e.FACULTY02 = v;
                        break;
                    case "FACULTY03":
                        mapper[i] = (e, v) => e.FACULTY03 = v;
                        break;
                    case "FACULTY04":
                        mapper[i] = (e, v) => e.FACULTY04 = v;
                        break;
                    case "SUBJECT01":
                        mapper[i] = (e, v) => e.SUBJECT01 = v;
                        break;
                    case "SUBJECT02":
                        mapper[i] = (e, v) => e.SUBJECT02 = v;
                        break;
                    case "SUBJECT03":
                        mapper[i] = (e, v) => e.SUBJECT03 = v;
                        break;
                    case "SUBJECT04":
                        mapper[i] = (e, v) => e.SUBJECT04 = v;
                        break;
                    case "SUBJECT05":
                        mapper[i] = (e, v) => e.SUBJECT05 = v;
                        break;
                    case "SUBJECT06":
                        mapper[i] = (e, v) => e.SUBJECT06 = v;
                        break;
                    case "SUBJECT07":
                        mapper[i] = (e, v) => e.SUBJECT07 = v;
                        break;
                    case "SUBJECT08":
                        mapper[i] = (e, v) => e.SUBJECT08 = v;
                        break;
                    case "SUBJECT09":
                        mapper[i] = (e, v) => e.SUBJECT09 = v;
                        break;
                    case "SUBJECT10":
                        mapper[i] = (e, v) => e.SUBJECT10 = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AVAILABILITY01":
                        mapper[i] = (e, v) => e.AVAILABILITY01 = v;
                        break;
                    case "AVAILABILITY02":
                        mapper[i] = (e, v) => e.AVAILABILITY02 = v;
                        break;
                    case "AVAILABILITY03":
                        mapper[i] = (e, v) => e.AVAILABILITY03 = v;
                        break;
                    case "AVAILABILITY04":
                        mapper[i] = (e, v) => e.AVAILABILITY04 = v;
                        break;
                    case "AVAILABILITY05":
                        mapper[i] = (e, v) => e.AVAILABILITY05 = v;
                        break;
                    case "RANK":
                        mapper[i] = (e, v) => e.RANK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "OTHER_LOCATION":
                        mapper[i] = (e, v) => e.OTHER_LOCATION = v;
                        break;
                    case "CAR_REGO":
                        mapper[i] = (e, v) => e.CAR_REGO = v;
                        break;
                    case "STAFF_TYPE":
                        mapper[i] = (e, v) => e.STAFF_TYPE = v;
                        break;
                    case "POS_CODE_A":
                        mapper[i] = (e, v) => e.POS_CODE_A = v;
                        break;
                    case "POS_CODE_B":
                        mapper[i] = (e, v) => e.POS_CODE_B = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STAFF_STATUS":
                        mapper[i] = (e, v) => e.STAFF_STATUS = v;
                        break;
                    case "MAJORA":
                        mapper[i] = (e, v) => e.MAJORA = v;
                        break;
                    case "MAJORB":
                        mapper[i] = (e, v) => e.MAJORB = v;
                        break;
                    case "MAJORC":
                        mapper[i] = (e, v) => e.MAJORC = v;
                        break;
                    case "SKILL_QUALIFICATION":
                        mapper[i] = (e, v) => e.SKILL_QUALIFICATION = v;
                        break;
                    case "PAYROLL_REC_NO":
                        mapper[i] = (e, v) => e.PAYROLL_REC_NO = v;
                        break;
                    case "PAYROLL_CLASS":
                        mapper[i] = (e, v) => e.PAYROLL_CLASS = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
                        break;
                    case "POLICE_CLEARANCE":
                        mapper[i] = (e, v) => e.POLICE_CLEARANCE = v;
                        break;
                    case "CLEARANCE_DATE":
                        mapper[i] = (e, v) => e.CLEARANCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF_PIC":
                        mapper[i] = (e, v) => e.STAFF_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "OK_TO_PUBLISH":
                        mapper[i] = (e, v) => e.OK_TO_PUBLISH = v;
                        break;
                    case "PIC_LW_DATE":
                        mapper[i] = (e, v) => e.PIC_LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PIC_STATUS":
                        mapper[i] = (e, v) => e.PIC_STATUS = v;
                        break;
                    case "AVAILABLE":
                        mapper[i] = (e, v) => e.AVAILABLE = null; // eduHub is not encoding byte arrays
                        break;
                    case "MAX_EXTRAS":
                        mapper[i] = (e, v) => e.MAX_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACC_EXTRAS":
                        mapper[i] = (e, v) => e.ACC_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK_EXTRAS":
                        mapper[i] = (e, v) => e.WEEK_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LAST_EXTRAS":
                        mapper[i] = (e, v) => e.LAST_EXTRAS = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "LANG01":
                        mapper[i] = (e, v) => e.LANG01 = v;
                        break;
                    case "LANG02":
                        mapper[i] = (e, v) => e.LANG02 = v;
                        break;
                    case "INTERPRETER01":
                        mapper[i] = (e, v) => e.INTERPRETER01 = v;
                        break;
                    case "INTERPRETER02":
                        mapper[i] = (e, v) => e.INTERPRETER02 = v;
                        break;
                    case "EMERG_NAME01":
                        mapper[i] = (e, v) => e.EMERG_NAME01 = v;
                        break;
                    case "EMERG_NAME02":
                        mapper[i] = (e, v) => e.EMERG_NAME02 = v;
                        break;
                    case "EMERG_LANG01":
                        mapper[i] = (e, v) => e.EMERG_LANG01 = v;
                        break;
                    case "EMERG_LANG02":
                        mapper[i] = (e, v) => e.EMERG_LANG02 = v;
                        break;
                    case "EMERG_RELATION01":
                        mapper[i] = (e, v) => e.EMERG_RELATION01 = v;
                        break;
                    case "EMERG_RELATION02":
                        mapper[i] = (e, v) => e.EMERG_RELATION02 = v;
                        break;
                    case "EMERG_CONTACT01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT01 = v;
                        break;
                    case "EMERG_CONTACT02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT02 = v;
                        break;
                    case "GROUP_AVAILABILITY":
                        mapper[i] = (e, v) => e.GROUP_AVAILABILITY = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HRMS_UPDATE":
                        mapper[i] = (e, v) => e.HRMS_UPDATE = v;
                        break;
                    case "HRMS_DATETIME":
                        mapper[i] = (e, v) => e.HRMS_DATETIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEBTOR_ID":
                        mapper[i] = (e, v) => e.DEBTOR_ID = v;
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
