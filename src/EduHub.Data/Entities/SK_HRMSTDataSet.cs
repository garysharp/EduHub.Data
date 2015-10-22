using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// HRMS Temp Import Table Data Set
    /// </summary>
    public sealed partial class SK_HRMSTDataSet : SetBase<SK_HRMST>
    {
        private Lazy<Dictionary<int, SK_HRMST>> SEQIndex;


        internal SK_HRMSTDataSet(EduHubContext Context)
            : base(Context)
        {
            SEQIndex = new Lazy<Dictionary<int, SK_HRMST>>(() => this.ToDictionary(e => e.SEQ));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SK_HRMST"; } }

        /// <summary>
        /// Find SK_HRMST by SEQ key field
        /// </summary>
        /// <param name="Key">SEQ value used to find SK_HRMST</param>
        /// <returns>Related SK_HRMST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SEQ value didn't match any SK_HRMST entities</exception>
        public SK_HRMST FindBySEQ(int Key)
        {
            SK_HRMST result;
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
        /// Attempt to find SK_HRMST by SEQ key field
        /// </summary>
        /// <param name="Key">SEQ value used to find SK_HRMST</param>
        /// <param name="Value">Related SK_HRMST entity</param>
        /// <returns>True if the SK_HRMST entity is found</returns>
        public bool TryFindBySEQ(int Key, out SK_HRMST Value)
        {
            return SEQIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SK_HRMST by SEQ key field
        /// </summary>
        /// <param name="Key">SEQ value used to find SK_HRMST</param>
        /// <returns>Related SK_HRMST entity, or null if not found</returns>
        public SK_HRMST TryFindBySEQ(int Key)
        {
            SK_HRMST result;
            if (SEQIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SK_HRMST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SK_HRMST" /> fields for each CSV column header</returns>
        protected override Action<SK_HRMST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SK_HRMST, string>[Headers.Count];

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
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}
