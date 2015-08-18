using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Information Data Set
    /// </summary>
    public sealed class SCIDataSet : SetBase<SCI>
    {
        private Lazy<Dictionary<int, SCI>> SCIKEYIndex;

        internal SCIDataSet(EduHubContext Context)
            : base(Context)
        {
            SCIKEYIndex = new Lazy<Dictionary<int, SCI>>(() => this.ToDictionary(e => e.SCIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCI"; } }

        /// <summary>
        /// Find SCI by SCIKEY key field
        /// </summary>
        /// <param name="Key">SCIKEY value used to find SCI</param>
        /// <returns>Related SCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCIKEY value didn't match any SCI entities</exception>
        public SCI FindBySCIKEY(int Key)
        {
            SCI result;
            if (SCIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCI by SCIKEY key field
        /// </summary>
        /// <param name="Key">SCIKEY value used to find SCI</param>
        /// <param name="Value">Related SCI entity</param>
        /// <returns>True if the SCI Entity is found</returns>
        public bool TryFindBySCIKEY(int Key, out SCI Value)
        {
            return SCIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCIKEY key field
        /// </summary>
        /// <param name="Key">SCIKEY value used to find SCI</param>
        /// <returns>Related SCI entity, or null if not found</returns>
        public SCI TryFindBySCIKEY(int Key)
        {
            SCI result;
            if (SCIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCI, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCIKEY":
                        mapper[i] = (e, v) => e.SCIKEY = int.Parse(v);
                        break;
                    case "CAMPUS_NAME":
                        mapper[i] = (e, v) => e.CAMPUS_NAME = v;
                        break;
                    case "CAMPUS_TYPE":
                        mapper[i] = (e, v) => e.CAMPUS_TYPE = v;
                        break;
                    case "SCHOOL_LINK":
                        mapper[i] = (e, v) => e.SCHOOL_LINK = v;
                        break;
                    case "SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SCHOOL_TYPE = v;
                        break;
                    case "SCHOOL_NAME":
                        mapper[i] = (e, v) => e.SCHOOL_NAME = v;
                        break;
                    case "MASTER_KEY":
                        mapper[i] = (e, v) => e.MASTER_KEY = v;
                        break;
                    case "ADMIN_SITE":
                        mapper[i] = (e, v) => e.ADMIN_SITE = v;
                        break;
                    case "SCH_PRINCIPAL":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL = v;
                        break;
                    case "SF_OIC":
                        mapper[i] = (e, v) => e.SF_OIC = v;
                        break;
                    case "SF_VPRIN":
                        mapper[i] = (e, v) => e.SF_VPRIN = v;
                        break;
                    case "SF_2VPRIN":
                        mapper[i] = (e, v) => e.SF_2VPRIN = v;
                        break;
                    case "SF_3VPRIN":
                        mapper[i] = (e, v) => e.SF_3VPRIN = v;
                        break;
                    case "SF_APRIN":
                        mapper[i] = (e, v) => e.SF_APRIN = v;
                        break;
                    case "SF_BMANAGER":
                        mapper[i] = (e, v) => e.SF_BMANAGER = v;
                        break;
                    case "SF_VAC_CONTACT":
                        mapper[i] = (e, v) => e.SF_VAC_CONTACT = v;
                        break;
                    case "SF_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.SF_EMERG_CONTACT = v;
                        break;
                    case "SAM_SCH_COUNCIL":
                        mapper[i] = (e, v) => e.SAM_SCH_COUNCIL = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PLATFORM":
                        mapper[i] = (e, v) => e.PLATFORM = v;
                        break;
                    case "CURRENT_RELEASE":
                        mapper[i] = (e, v) => e.CURRENT_RELEASE = v;
                        break;
                    case "RELEASE_ACTION":
                        mapper[i] = (e, v) => e.RELEASE_ACTION = v;
                        break;
                    case "RELEASE_DATE":
                        mapper[i] = (e, v) => e.RELEASE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SCHEMA_VERIFIED":
                        mapper[i] = (e, v) => e.SCHEMA_VERIFIED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "UPGRADE_VERSION":
                        mapper[i] = (e, v) => e.UPGRADE_VERSION = v;
                        break;
                    case "ECASES21_VERSION":
                        mapper[i] = (e, v) => e.ECASES21_VERSION = v;
                        break;
                    case "DMIRROR_VERSION":
                        mapper[i] = (e, v) => e.DMIRROR_VERSION = v;
                        break;
                    case "CURRENT_QUILT":
                        mapper[i] = (e, v) => e.CURRENT_QUILT = v;
                        break;
                    case "CURRENT_SEMESTER":
                        mapper[i] = (e, v) => e.CURRENT_SEMESTER = v;
                        break;
                    case "LAST_PROMOTION_DATE":
                        mapper[i] = (e, v) => e.LAST_PROMOTION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AGE_CALCULATION_DATE":
                        mapper[i] = (e, v) => e.AGE_CALCULATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXT_ENROLMENT_DATE":
                        mapper[i] = (e, v) => e.NEXT_ENROLMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDER_DEFAULT":
                        mapper[i] = (e, v) => e.GENDER_DEFAULT = v;
                        break;
                    case "TELEPHONE_PREFIX":
                        mapper[i] = (e, v) => e.TELEPHONE_PREFIX = v;
                        break;
                    case "REL_INSTR":
                        mapper[i] = (e, v) => e.REL_INSTR = v;
                        break;
                    case "CONSECUTIVE_DAYS":
                        mapper[i] = (e, v) => e.CONSECUTIVE_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CUMULATIVE_DAYS":
                        mapper[i] = (e, v) => e.CUMULATIVE_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OVERALL_DAYS":
                        mapper[i] = (e, v) => e.OVERALL_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MAILING_ADDRESS01":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS01 = v;
                        break;
                    case "MAILING_ADDRESS02":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS02 = v;
                        break;
                    case "MAILING_SUBURB":
                        mapper[i] = (e, v) => e.MAILING_SUBURB = v;
                        break;
                    case "MAILING_STATE":
                        mapper[i] = (e, v) => e.MAILING_STATE = v;
                        break;
                    case "MAILING_POSTCODE":
                        mapper[i] = (e, v) => e.MAILING_POSTCODE = v;
                        break;
                    case "DELIVERY_ADDRESS01":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS01 = v;
                        break;
                    case "DELIVERY_ADDRESS02":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS02 = v;
                        break;
                    case "DELIVERY_SUBURB":
                        mapper[i] = (e, v) => e.DELIVERY_SUBURB = v;
                        break;
                    case "DELIVERY_STATE":
                        mapper[i] = (e, v) => e.DELIVERY_STATE = v;
                        break;
                    case "DELIVERY_POSTCODE":
                        mapper[i] = (e, v) => e.DELIVERY_POSTCODE = v;
                        break;
                    case "DELIVERY_TELEPHONE":
                        mapper[i] = (e, v) => e.DELIVERY_TELEPHONE = v;
                        break;
                    case "DELIVERY_FAX":
                        mapper[i] = (e, v) => e.DELIVERY_FAX = v;
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "DESTINATION_SCHOOL":
                        mapper[i] = (e, v) => e.DESTINATION_SCHOOL = v;
                        break;
                    case "CAMPUS_EMAIL_CONTACT":
                        mapper[i] = (e, v) => e.CAMPUS_EMAIL_CONTACT = v;
                        break;
                    case "SCH_AOIC":
                        mapper[i] = (e, v) => e.SCH_AOIC = v;
                        break;
                    case "SCH_VPRIN":
                        mapper[i] = (e, v) => e.SCH_VPRIN = v;
                        break;
                    case "SCH_BMANAGER":
                        mapper[i] = (e, v) => e.SCH_BMANAGER = v;
                        break;
                    case "SCH_VAC_CONTACT":
                        mapper[i] = (e, v) => e.SCH_VAC_CONTACT = v;
                        break;
                    case "SCH_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.SCH_EMERG_CONTACT = v;
                        break;
                    case "SCH_COUNCIL_PRES":
                        mapper[i] = (e, v) => e.SCH_COUNCIL_PRES = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SCH_MASTER_KEY":
                        mapper[i] = (e, v) => e.SCH_MASTER_KEY = v;
                        break;
                    case "PROFILE_UPDATED":
                        mapper[i] = (e, v) => e.PROFILE_UPDATED = v;
                        break;
                    case "CAMPUS_OPEN_IND":
                        mapper[i] = (e, v) => e.CAMPUS_OPEN_IND = v;
                        break;
                    case "PROFILE_SENT":
                        mapper[i] = (e, v) => e.PROFILE_SENT = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SPEC_CURR_IND":
                        mapper[i] = (e, v) => e.SPEC_CURR_IND = v;
                        break;
                    case "GLOBAL_ID":
                        mapper[i] = (e, v) => e.GLOBAL_ID = v == null ? (int?)null : int.Parse(v);
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
