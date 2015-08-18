using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// HRMS Import Table Data Set
    /// </summary>
    public sealed class SK_HRMSDataSet : SetBase<SK_HRMS>
    {
        private Lazy<Dictionary<int, SK_HRMS>> SEQIndex;

        internal SK_HRMSDataSet(EduHubContext Context)
            : base(Context)
        {
            SEQIndex = new Lazy<Dictionary<int, SK_HRMS>>(() => this.ToDictionary(e => e.SEQ));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SK_HRMS"; } }

        /// <summary>
        /// Find SK_HRMS by SEQ key field
        /// </summary>
        /// <param name="Key">SEQ value used to find SK_HRMS</param>
        /// <returns>Related SK_HRMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SEQ value didn't match any SK_HRMS entities</exception>
        public SK_HRMS FindBySEQ(int Key)
        {
            SK_HRMS result;
            if (SEQIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SK_HRMS by SEQ key field
        /// </summary>
        /// <param name="Key">SEQ value used to find SK_HRMS</param>
        /// <param name="Value">Related SK_HRMS entity</param>
        /// <returns>True if the SK_HRMS Entity is found</returns>
        public bool TryFindBySEQ(int Key, out SK_HRMS Value)
        {
            return SEQIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SK_HRMS by SEQ key field
        /// </summary>
        /// <param name="Key">SEQ value used to find SK_HRMS</param>
        /// <returns>Related SK_HRMS entity, or null if not found</returns>
        public SK_HRMS TryFindBySEQ(int Key)
        {
            SK_HRMS result;
            if (SEQIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SK_HRMS, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SK_HRMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SEQ":
                        mapper[i] = (e, v) => e.SEQ = int.Parse(v);
                        break;
                    case "DEPTID":
                        mapper[i] = (e, v) => e.DEPTID = v;
                        break;
                    case "EMPLID":
                        mapper[i] = (e, v) => e.EMPLID = v;
                        break;
                    case "JOBCODE":
                        mapper[i] = (e, v) => e.JOBCODE = v;
                        break;
                    case "LAST_NAME":
                        mapper[i] = (e, v) => e.LAST_NAME = v;
                        break;
                    case "PREFIX":
                        mapper[i] = (e, v) => e.PREFIX = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "MIDDLE_NAME":
                        mapper[i] = (e, v) => e.MIDDLE_NAME = v;
                        break;
                    case "PREF_NAME":
                        mapper[i] = (e, v) => e.PREF_NAME = v;
                        break;
                    case "PREV_SURNAME":
                        mapper[i] = (e, v) => e.PREV_SURNAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTH_DATE":
                        mapper[i] = (e, v) => e.BIRTH_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "H_ADDRESS01":
                        mapper[i] = (e, v) => e.H_ADDRESS01 = v;
                        break;
                    case "H_ADDRESS02":
                        mapper[i] = (e, v) => e.H_ADDRESS02 = v;
                        break;
                    case "H_ADDRESS03":
                        mapper[i] = (e, v) => e.H_ADDRESS03 = v;
                        break;
                    case "H_STATE":
                        mapper[i] = (e, v) => e.H_STATE = v;
                        break;
                    case "H_POST_CODE":
                        mapper[i] = (e, v) => e.H_POST_CODE = v;
                        break;
                    case "P_ADDRESS01":
                        mapper[i] = (e, v) => e.P_ADDRESS01 = v;
                        break;
                    case "P_ADDRESS02":
                        mapper[i] = (e, v) => e.P_ADDRESS02 = v;
                        break;
                    case "P_ADDRESS03":
                        mapper[i] = (e, v) => e.P_ADDRESS03 = v;
                        break;
                    case "P_STATE":
                        mapper[i] = (e, v) => e.P_STATE = v;
                        break;
                    case "P_POST_CODE":
                        mapper[i] = (e, v) => e.P_POST_CODE = v;
                        break;
                    case "HOME_PHONE":
                        mapper[i] = (e, v) => e.HOME_PHONE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "EMERG_CONTACT":
                        mapper[i] = (e, v) => e.EMERG_CONTACT = v;
                        break;
                    case "EMERG_RELATE":
                        mapper[i] = (e, v) => e.EMERG_RELATE = v;
                        break;
                    case "EMERG_PHONE":
                        mapper[i] = (e, v) => e.EMERG_PHONE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FINISH_DATE":
                        mapper[i] = (e, v) => e.FINISH_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REC_TYPE_FLAG":
                        mapper[i] = (e, v) => e.REC_TYPE_FLAG = v;
                        break;
                    case "REC_PROCESS_FLAG":
                        mapper[i] = (e, v) => e.REC_PROCESS_FLAG = v;
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
