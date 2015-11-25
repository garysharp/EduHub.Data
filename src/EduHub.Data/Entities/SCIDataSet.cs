using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCIDataSet : SetBase<SCI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCI"; } }

        internal SCIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCIKEY = new Lazy<Dictionary<int, SCI>>(() => this.ToDictionary(i => i.SCIKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SCHOOL_LINK = new Lazy<NullDictionary<string, SCI>>(() => this.ToNullDictionary(i => i.SCHOOL_LINK));
            Index_SCH_PRINCIPAL = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_PRINCIPAL));
            Index_SF_OIC = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_OIC));
            Index_SF_VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_VPRIN));
            Index_SF_2VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_2VPRIN));
            Index_SF_3VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_3VPRIN));
            Index_SF_APRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_APRIN));
            Index_SF_BMANAGER = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_BMANAGER));
            Index_SF_VAC_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_VAC_CONTACT));
            Index_SF_EMERG_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_EMERG_CONTACT));
            Index_SAM_SCH_COUNCIL = new Lazy<NullDictionary<int?, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SAM_SCH_COUNCIL));
            Index_CURRENT_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.CURRENT_QUILT));
            Index_REL_INSTR = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.REL_INSTR));
            Index_DESTINATION_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.DESTINATION_SCHOOL));
            Index_SCH_AOIC = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_AOIC));
            Index_SCH_VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_VPRIN));
            Index_SCH_BMANAGER = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_BMANAGER));
            Index_SCH_VAC_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_VAC_CONTACT));
            Index_SCH_EMERG_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_EMERG_CONTACT));
            Index_SCH_COUNCIL_PRES = new Lazy<NullDictionary<int?, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_COUNCIL_PRES));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCI" /> fields for each CSV column header</returns>
        protected override Action<SCI, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        #region Index Fields

        private Lazy<Dictionary<int, SCI>> Index_SCIKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SCI>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, SCI>> Index_SCHOOL_LINK;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_PRINCIPAL;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_OIC;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_VPRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_2VPRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_3VPRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_APRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_BMANAGER;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_VAC_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_EMERG_CONTACT;
        private Lazy<NullDictionary<int?, IReadOnlyList<SCI>>> Index_SAM_SCH_COUNCIL;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_CURRENT_QUILT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_REL_INSTR;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_DESTINATION_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_AOIC;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_VPRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_BMANAGER;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_VAC_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_EMERG_CONTACT;
        private Lazy<NullDictionary<int?, IReadOnlyList<SCI>>> Index_SCH_COUNCIL_PRES;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCI by SCIKEY field
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCI</param>
        /// <returns>Related SCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCI FindBySCIKEY(int SCIKEY)
        {
            return Index_SCIKEY.Value[SCIKEY];
        }

        /// <summary>
        /// Attempt to find SCI by SCIKEY field
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCI</param>
        /// <param name="Value">Related SCI entity</param>
        /// <returns>True if the related SCI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCIKEY(int SCIKEY, out SCI Value)
        {
            return Index_SCIKEY.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCIKEY field
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCI</param>
        /// <returns>Related SCI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCI TryFindBySCIKEY(int SCIKEY)
        {
            SCI value;
            if (Index_SCIKEY.Value.TryGetValue(SCIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SCI by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SCI> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SCI> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCHOOL_LINK field
        /// </summary>
        /// <param name="SCHOOL_LINK">SCHOOL_LINK value used to find SCI</param>
        /// <returns>Related SCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCI FindBySCHOOL_LINK(string SCHOOL_LINK)
        {
            return Index_SCHOOL_LINK.Value[SCHOOL_LINK];
        }

        /// <summary>
        /// Attempt to find SCI by SCHOOL_LINK field
        /// </summary>
        /// <param name="SCHOOL_LINK">SCHOOL_LINK value used to find SCI</param>
        /// <param name="Value">Related SCI entity</param>
        /// <returns>True if the related SCI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_LINK(string SCHOOL_LINK, out SCI Value)
        {
            return Index_SCHOOL_LINK.Value.TryGetValue(SCHOOL_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCHOOL_LINK field
        /// </summary>
        /// <param name="SCHOOL_LINK">SCHOOL_LINK value used to find SCI</param>
        /// <returns>Related SCI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCI TryFindBySCHOOL_LINK(string SCHOOL_LINK)
        {
            SCI value;
            if (Index_SCHOOL_LINK.Value.TryGetValue(SCHOOL_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_PRINCIPAL field
        /// </summary>
        /// <param name="SCH_PRINCIPAL">SCH_PRINCIPAL value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_PRINCIPAL(string SCH_PRINCIPAL)
        {
            return Index_SCH_PRINCIPAL.Value[SCH_PRINCIPAL];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_PRINCIPAL field
        /// </summary>
        /// <param name="SCH_PRINCIPAL">SCH_PRINCIPAL value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_PRINCIPAL(string SCH_PRINCIPAL, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_PRINCIPAL.Value.TryGetValue(SCH_PRINCIPAL, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_PRINCIPAL field
        /// </summary>
        /// <param name="SCH_PRINCIPAL">SCH_PRINCIPAL value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_PRINCIPAL(string SCH_PRINCIPAL)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_PRINCIPAL.Value.TryGetValue(SCH_PRINCIPAL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_OIC field
        /// </summary>
        /// <param name="SF_OIC">SF_OIC value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_OIC(string SF_OIC)
        {
            return Index_SF_OIC.Value[SF_OIC];
        }

        /// <summary>
        /// Attempt to find SCI by SF_OIC field
        /// </summary>
        /// <param name="SF_OIC">SF_OIC value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_OIC(string SF_OIC, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_OIC.Value.TryGetValue(SF_OIC, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_OIC field
        /// </summary>
        /// <param name="SF_OIC">SF_OIC value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_OIC(string SF_OIC)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_OIC.Value.TryGetValue(SF_OIC, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_VPRIN field
        /// </summary>
        /// <param name="SF_VPRIN">SF_VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_VPRIN(string SF_VPRIN)
        {
            return Index_SF_VPRIN.Value[SF_VPRIN];
        }

        /// <summary>
        /// Attempt to find SCI by SF_VPRIN field
        /// </summary>
        /// <param name="SF_VPRIN">SF_VPRIN value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_VPRIN(string SF_VPRIN, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_VPRIN.Value.TryGetValue(SF_VPRIN, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_VPRIN field
        /// </summary>
        /// <param name="SF_VPRIN">SF_VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_VPRIN(string SF_VPRIN)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_VPRIN.Value.TryGetValue(SF_VPRIN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_2VPRIN field
        /// </summary>
        /// <param name="SF_2VPRIN">SF_2VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_2VPRIN(string SF_2VPRIN)
        {
            return Index_SF_2VPRIN.Value[SF_2VPRIN];
        }

        /// <summary>
        /// Attempt to find SCI by SF_2VPRIN field
        /// </summary>
        /// <param name="SF_2VPRIN">SF_2VPRIN value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_2VPRIN(string SF_2VPRIN, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_2VPRIN.Value.TryGetValue(SF_2VPRIN, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_2VPRIN field
        /// </summary>
        /// <param name="SF_2VPRIN">SF_2VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_2VPRIN(string SF_2VPRIN)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_2VPRIN.Value.TryGetValue(SF_2VPRIN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_3VPRIN field
        /// </summary>
        /// <param name="SF_3VPRIN">SF_3VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_3VPRIN(string SF_3VPRIN)
        {
            return Index_SF_3VPRIN.Value[SF_3VPRIN];
        }

        /// <summary>
        /// Attempt to find SCI by SF_3VPRIN field
        /// </summary>
        /// <param name="SF_3VPRIN">SF_3VPRIN value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_3VPRIN(string SF_3VPRIN, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_3VPRIN.Value.TryGetValue(SF_3VPRIN, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_3VPRIN field
        /// </summary>
        /// <param name="SF_3VPRIN">SF_3VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_3VPRIN(string SF_3VPRIN)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_3VPRIN.Value.TryGetValue(SF_3VPRIN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_APRIN field
        /// </summary>
        /// <param name="SF_APRIN">SF_APRIN value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_APRIN(string SF_APRIN)
        {
            return Index_SF_APRIN.Value[SF_APRIN];
        }

        /// <summary>
        /// Attempt to find SCI by SF_APRIN field
        /// </summary>
        /// <param name="SF_APRIN">SF_APRIN value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_APRIN(string SF_APRIN, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_APRIN.Value.TryGetValue(SF_APRIN, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_APRIN field
        /// </summary>
        /// <param name="SF_APRIN">SF_APRIN value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_APRIN(string SF_APRIN)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_APRIN.Value.TryGetValue(SF_APRIN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_BMANAGER field
        /// </summary>
        /// <param name="SF_BMANAGER">SF_BMANAGER value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_BMANAGER(string SF_BMANAGER)
        {
            return Index_SF_BMANAGER.Value[SF_BMANAGER];
        }

        /// <summary>
        /// Attempt to find SCI by SF_BMANAGER field
        /// </summary>
        /// <param name="SF_BMANAGER">SF_BMANAGER value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_BMANAGER(string SF_BMANAGER, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_BMANAGER.Value.TryGetValue(SF_BMANAGER, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_BMANAGER field
        /// </summary>
        /// <param name="SF_BMANAGER">SF_BMANAGER value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_BMANAGER(string SF_BMANAGER)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_BMANAGER.Value.TryGetValue(SF_BMANAGER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_VAC_CONTACT field
        /// </summary>
        /// <param name="SF_VAC_CONTACT">SF_VAC_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_VAC_CONTACT(string SF_VAC_CONTACT)
        {
            return Index_SF_VAC_CONTACT.Value[SF_VAC_CONTACT];
        }

        /// <summary>
        /// Attempt to find SCI by SF_VAC_CONTACT field
        /// </summary>
        /// <param name="SF_VAC_CONTACT">SF_VAC_CONTACT value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_VAC_CONTACT(string SF_VAC_CONTACT, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_VAC_CONTACT.Value.TryGetValue(SF_VAC_CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_VAC_CONTACT field
        /// </summary>
        /// <param name="SF_VAC_CONTACT">SF_VAC_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_VAC_CONTACT(string SF_VAC_CONTACT)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_VAC_CONTACT.Value.TryGetValue(SF_VAC_CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SF_EMERG_CONTACT field
        /// </summary>
        /// <param name="SF_EMERG_CONTACT">SF_EMERG_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySF_EMERG_CONTACT(string SF_EMERG_CONTACT)
        {
            return Index_SF_EMERG_CONTACT.Value[SF_EMERG_CONTACT];
        }

        /// <summary>
        /// Attempt to find SCI by SF_EMERG_CONTACT field
        /// </summary>
        /// <param name="SF_EMERG_CONTACT">SF_EMERG_CONTACT value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySF_EMERG_CONTACT(string SF_EMERG_CONTACT, out IReadOnlyList<SCI> Value)
        {
            return Index_SF_EMERG_CONTACT.Value.TryGetValue(SF_EMERG_CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SF_EMERG_CONTACT field
        /// </summary>
        /// <param name="SF_EMERG_CONTACT">SF_EMERG_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySF_EMERG_CONTACT(string SF_EMERG_CONTACT)
        {
            IReadOnlyList<SCI> value;
            if (Index_SF_EMERG_CONTACT.Value.TryGetValue(SF_EMERG_CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SAM_SCH_COUNCIL field
        /// </summary>
        /// <param name="SAM_SCH_COUNCIL">SAM_SCH_COUNCIL value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySAM_SCH_COUNCIL(int? SAM_SCH_COUNCIL)
        {
            return Index_SAM_SCH_COUNCIL.Value[SAM_SCH_COUNCIL];
        }

        /// <summary>
        /// Attempt to find SCI by SAM_SCH_COUNCIL field
        /// </summary>
        /// <param name="SAM_SCH_COUNCIL">SAM_SCH_COUNCIL value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAM_SCH_COUNCIL(int? SAM_SCH_COUNCIL, out IReadOnlyList<SCI> Value)
        {
            return Index_SAM_SCH_COUNCIL.Value.TryGetValue(SAM_SCH_COUNCIL, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SAM_SCH_COUNCIL field
        /// </summary>
        /// <param name="SAM_SCH_COUNCIL">SAM_SCH_COUNCIL value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySAM_SCH_COUNCIL(int? SAM_SCH_COUNCIL)
        {
            IReadOnlyList<SCI> value;
            if (Index_SAM_SCH_COUNCIL.Value.TryGetValue(SAM_SCH_COUNCIL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            return Index_CURRENT_QUILT.Value[CURRENT_QUILT];
        }

        /// <summary>
        /// Attempt to find SCI by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCURRENT_QUILT(string CURRENT_QUILT, out IReadOnlyList<SCI> Value)
        {
            return Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            IReadOnlyList<SCI> value;
            if (Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by REL_INSTR field
        /// </summary>
        /// <param name="REL_INSTR">REL_INSTR value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindByREL_INSTR(string REL_INSTR)
        {
            return Index_REL_INSTR.Value[REL_INSTR];
        }

        /// <summary>
        /// Attempt to find SCI by REL_INSTR field
        /// </summary>
        /// <param name="REL_INSTR">REL_INSTR value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREL_INSTR(string REL_INSTR, out IReadOnlyList<SCI> Value)
        {
            return Index_REL_INSTR.Value.TryGetValue(REL_INSTR, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by REL_INSTR field
        /// </summary>
        /// <param name="REL_INSTR">REL_INSTR value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindByREL_INSTR(string REL_INSTR)
        {
            IReadOnlyList<SCI> value;
            if (Index_REL_INSTR.Value.TryGetValue(REL_INSTR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by DESTINATION_SCHOOL field
        /// </summary>
        /// <param name="DESTINATION_SCHOOL">DESTINATION_SCHOOL value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindByDESTINATION_SCHOOL(string DESTINATION_SCHOOL)
        {
            return Index_DESTINATION_SCHOOL.Value[DESTINATION_SCHOOL];
        }

        /// <summary>
        /// Attempt to find SCI by DESTINATION_SCHOOL field
        /// </summary>
        /// <param name="DESTINATION_SCHOOL">DESTINATION_SCHOOL value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDESTINATION_SCHOOL(string DESTINATION_SCHOOL, out IReadOnlyList<SCI> Value)
        {
            return Index_DESTINATION_SCHOOL.Value.TryGetValue(DESTINATION_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by DESTINATION_SCHOOL field
        /// </summary>
        /// <param name="DESTINATION_SCHOOL">DESTINATION_SCHOOL value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindByDESTINATION_SCHOOL(string DESTINATION_SCHOOL)
        {
            IReadOnlyList<SCI> value;
            if (Index_DESTINATION_SCHOOL.Value.TryGetValue(DESTINATION_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_AOIC field
        /// </summary>
        /// <param name="SCH_AOIC">SCH_AOIC value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_AOIC(string SCH_AOIC)
        {
            return Index_SCH_AOIC.Value[SCH_AOIC];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_AOIC field
        /// </summary>
        /// <param name="SCH_AOIC">SCH_AOIC value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_AOIC(string SCH_AOIC, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_AOIC.Value.TryGetValue(SCH_AOIC, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_AOIC field
        /// </summary>
        /// <param name="SCH_AOIC">SCH_AOIC value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_AOIC(string SCH_AOIC)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_AOIC.Value.TryGetValue(SCH_AOIC, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_VPRIN field
        /// </summary>
        /// <param name="SCH_VPRIN">SCH_VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_VPRIN(string SCH_VPRIN)
        {
            return Index_SCH_VPRIN.Value[SCH_VPRIN];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_VPRIN field
        /// </summary>
        /// <param name="SCH_VPRIN">SCH_VPRIN value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_VPRIN(string SCH_VPRIN, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_VPRIN.Value.TryGetValue(SCH_VPRIN, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_VPRIN field
        /// </summary>
        /// <param name="SCH_VPRIN">SCH_VPRIN value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_VPRIN(string SCH_VPRIN)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_VPRIN.Value.TryGetValue(SCH_VPRIN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_BMANAGER field
        /// </summary>
        /// <param name="SCH_BMANAGER">SCH_BMANAGER value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_BMANAGER(string SCH_BMANAGER)
        {
            return Index_SCH_BMANAGER.Value[SCH_BMANAGER];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_BMANAGER field
        /// </summary>
        /// <param name="SCH_BMANAGER">SCH_BMANAGER value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_BMANAGER(string SCH_BMANAGER, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_BMANAGER.Value.TryGetValue(SCH_BMANAGER, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_BMANAGER field
        /// </summary>
        /// <param name="SCH_BMANAGER">SCH_BMANAGER value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_BMANAGER(string SCH_BMANAGER)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_BMANAGER.Value.TryGetValue(SCH_BMANAGER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_VAC_CONTACT field
        /// </summary>
        /// <param name="SCH_VAC_CONTACT">SCH_VAC_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_VAC_CONTACT(string SCH_VAC_CONTACT)
        {
            return Index_SCH_VAC_CONTACT.Value[SCH_VAC_CONTACT];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_VAC_CONTACT field
        /// </summary>
        /// <param name="SCH_VAC_CONTACT">SCH_VAC_CONTACT value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_VAC_CONTACT(string SCH_VAC_CONTACT, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_VAC_CONTACT.Value.TryGetValue(SCH_VAC_CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_VAC_CONTACT field
        /// </summary>
        /// <param name="SCH_VAC_CONTACT">SCH_VAC_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_VAC_CONTACT(string SCH_VAC_CONTACT)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_VAC_CONTACT.Value.TryGetValue(SCH_VAC_CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_EMERG_CONTACT field
        /// </summary>
        /// <param name="SCH_EMERG_CONTACT">SCH_EMERG_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_EMERG_CONTACT(string SCH_EMERG_CONTACT)
        {
            return Index_SCH_EMERG_CONTACT.Value[SCH_EMERG_CONTACT];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_EMERG_CONTACT field
        /// </summary>
        /// <param name="SCH_EMERG_CONTACT">SCH_EMERG_CONTACT value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_EMERG_CONTACT(string SCH_EMERG_CONTACT, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_EMERG_CONTACT.Value.TryGetValue(SCH_EMERG_CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_EMERG_CONTACT field
        /// </summary>
        /// <param name="SCH_EMERG_CONTACT">SCH_EMERG_CONTACT value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_EMERG_CONTACT(string SCH_EMERG_CONTACT)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_EMERG_CONTACT.Value.TryGetValue(SCH_EMERG_CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCI by SCH_COUNCIL_PRES field
        /// </summary>
        /// <param name="SCH_COUNCIL_PRES">SCH_COUNCIL_PRES value used to find SCI</param>
        /// <returns>List of related SCI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> FindBySCH_COUNCIL_PRES(int? SCH_COUNCIL_PRES)
        {
            return Index_SCH_COUNCIL_PRES.Value[SCH_COUNCIL_PRES];
        }

        /// <summary>
        /// Attempt to find SCI by SCH_COUNCIL_PRES field
        /// </summary>
        /// <param name="SCH_COUNCIL_PRES">SCH_COUNCIL_PRES value used to find SCI</param>
        /// <param name="Value">List of related SCI entities</param>
        /// <returns>True if the list of related SCI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCH_COUNCIL_PRES(int? SCH_COUNCIL_PRES, out IReadOnlyList<SCI> Value)
        {
            return Index_SCH_COUNCIL_PRES.Value.TryGetValue(SCH_COUNCIL_PRES, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCH_COUNCIL_PRES field
        /// </summary>
        /// <param name="SCH_COUNCIL_PRES">SCH_COUNCIL_PRES value used to find SCI</param>
        /// <returns>List of related SCI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCI> TryFindBySCH_COUNCIL_PRES(int? SCH_COUNCIL_PRES)
        {
            IReadOnlyList<SCI> value;
            if (Index_SCH_COUNCIL_PRES.Value.TryGetValue(SCH_COUNCIL_PRES, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
