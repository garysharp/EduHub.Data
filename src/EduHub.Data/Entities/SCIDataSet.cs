using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCIDataSet : EduHubDataSet<SCI>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SCIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CURRENT_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.CURRENT_QUILT));
            Index_DESTINATION_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.DESTINATION_SCHOOL));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_REL_INSTR = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.REL_INSTR));
            Index_SAM_SCH_COUNCIL = new Lazy<NullDictionary<int?, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SAM_SCH_COUNCIL));
            Index_SCH_AOIC = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_AOIC));
            Index_SCH_BMANAGER = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_BMANAGER));
            Index_SCH_COUNCIL_PRES = new Lazy<NullDictionary<int?, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_COUNCIL_PRES));
            Index_SCH_EMERG_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_EMERG_CONTACT));
            Index_SCH_PRINCIPAL = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_PRINCIPAL));
            Index_SCH_VAC_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_VAC_CONTACT));
            Index_SCH_VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SCH_VPRIN));
            Index_SCHOOL_LINK = new Lazy<NullDictionary<string, SCI>>(() => this.ToNullDictionary(i => i.SCHOOL_LINK));
            Index_SCIKEY = new Lazy<Dictionary<int, SCI>>(() => this.ToDictionary(i => i.SCIKEY));
            Index_SF_2VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_2VPRIN));
            Index_SF_3VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_3VPRIN));
            Index_SF_APRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_APRIN));
            Index_SF_BMANAGER = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_BMANAGER));
            Index_SF_EMERG_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_EMERG_CONTACT));
            Index_SF_OIC = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_OIC));
            Index_SF_VAC_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_VAC_CONTACT));
            Index_SF_VPRIN = new Lazy<NullDictionary<string, IReadOnlyList<SCI>>>(() => this.ToGroupedNullDictionary(i => i.SF_VPRIN));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCI" /> fields for each CSV column header</returns>
        internal override Action<SCI, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                    case "TFR_ENROLMENT_DATE":
                        mapper[i] = (e, v) => e.TFR_ENROLMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                    case "SCH_DEFINED01":
                        mapper[i] = (e, v) => e.SCH_DEFINED01 = v;
                        break;
                    case "SCH_DEFINED02":
                        mapper[i] = (e, v) => e.SCH_DEFINED02 = v;
                        break;
                    case "PREF_MAIL_MECH":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH = v;
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

        /// <summary>
        /// Merges <see cref="SCI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCI}"/> of entities</returns>
        internal override IEnumerable<SCI> ApplyDeltaEntities(IEnumerable<SCI> Entities, List<SCI> DeltaEntities)
        {
            HashSet<string> Index_SCHOOL_LINK = new HashSet<string>(DeltaEntities.Select(i => i.SCHOOL_LINK));
            HashSet<int> Index_SCIKEY = new HashSet<int>(DeltaEntities.Select(i => i.SCIKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCIKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SCHOOL_LINK.Remove(entity.SCHOOL_LINK);
                            overwritten = overwritten || Index_SCIKEY.Remove(entity.SCIKEY);
                            
                            if (entity.SCIKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_CURRENT_QUILT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_DESTINATION_SCHOOL;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SCI>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_REL_INSTR;
        private Lazy<NullDictionary<int?, IReadOnlyList<SCI>>> Index_SAM_SCH_COUNCIL;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_AOIC;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_BMANAGER;
        private Lazy<NullDictionary<int?, IReadOnlyList<SCI>>> Index_SCH_COUNCIL_PRES;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_EMERG_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_PRINCIPAL;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_VAC_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SCH_VPRIN;
        private Lazy<NullDictionary<string, SCI>> Index_SCHOOL_LINK;
        private Lazy<Dictionary<int, SCI>> Index_SCIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_2VPRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_3VPRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_APRIN;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_BMANAGER;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_EMERG_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_OIC;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_VAC_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCI>>> Index_SF_VPRIN;

        #endregion

        #region Index Methods

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

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCI](
        [SCIKEY] int NOT NULL,
        [CAMPUS_NAME] varchar(40) NULL,
        [CAMPUS_TYPE] varchar(10) NULL,
        [SCHOOL_LINK] varchar(8) NULL,
        [SCHOOL_TYPE] varchar(10) NULL,
        [SCHOOL_NAME] varchar(40) NULL,
        [MASTER_KEY] varchar(6) NULL,
        [ADMIN_SITE] varchar(1) NULL,
        [SCH_PRINCIPAL] varchar(4) NULL,
        [SF_OIC] varchar(4) NULL,
        [SF_VPRIN] varchar(4) NULL,
        [SF_2VPRIN] varchar(4) NULL,
        [SF_3VPRIN] varchar(4) NULL,
        [SF_APRIN] varchar(4) NULL,
        [SF_BMANAGER] varchar(4) NULL,
        [SF_VAC_CONTACT] varchar(4) NULL,
        [SF_EMERG_CONTACT] varchar(4) NULL,
        [SAM_SCH_COUNCIL] int NULL,
        [PLATFORM] varchar(5) NULL,
        [CURRENT_RELEASE] varchar(20) NULL,
        [RELEASE_ACTION] varchar(7) NULL,
        [RELEASE_DATE] datetime NULL,
        [SCHEMA_VERIFIED] datetime NULL,
        [UPGRADE_VERSION] varchar(30) NULL,
        [ECASES21_VERSION] varchar(10) NULL,
        [DMIRROR_VERSION] varchar(30) NULL,
        [CURRENT_QUILT] varchar(8) NULL,
        [CURRENT_SEMESTER] varchar(6) NULL,
        [LAST_PROMOTION_DATE] datetime NULL,
        [AGE_CALCULATION_DATE] datetime NULL,
        [NEXT_ENROLMENT_DATE] datetime NULL,
        [TFR_ENROLMENT_DATE] datetime NULL,
        [GENDER_DEFAULT] varchar(1) NULL,
        [TELEPHONE_PREFIX] varchar(20) NULL,
        [REL_INSTR] varchar(10) NULL,
        [CONSECUTIVE_DAYS] smallint NULL,
        [CUMULATIVE_DAYS] smallint NULL,
        [OVERALL_DAYS] smallint NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [MAILING_ADDRESS01] varchar(30) NULL,
        [MAILING_ADDRESS02] varchar(30) NULL,
        [MAILING_SUBURB] varchar(30) NULL,
        [MAILING_STATE] varchar(3) NULL,
        [MAILING_POSTCODE] varchar(4) NULL,
        [DELIVERY_ADDRESS01] varchar(30) NULL,
        [DELIVERY_ADDRESS02] varchar(30) NULL,
        [DELIVERY_SUBURB] varchar(30) NULL,
        [DELIVERY_STATE] varchar(3) NULL,
        [DELIVERY_POSTCODE] varchar(4) NULL,
        [DELIVERY_TELEPHONE] varchar(20) NULL,
        [DELIVERY_FAX] varchar(20) NULL,
        [MAP_TYPE] varchar(1) NULL,
        [MAP_NUM] varchar(4) NULL,
        [X_AXIS] varchar(2) NULL,
        [Y_AXIS] varchar(2) NULL,
        [DESTINATION_SCHOOL] varchar(8) NULL,
        [CAMPUS_EMAIL_CONTACT] varchar(60) NULL,
        [SCH_AOIC] varchar(4) NULL,
        [SCH_VPRIN] varchar(4) NULL,
        [SCH_BMANAGER] varchar(4) NULL,
        [SCH_VAC_CONTACT] varchar(4) NULL,
        [SCH_EMERG_CONTACT] varchar(4) NULL,
        [SCH_COUNCIL_PRES] int NULL,
        [SCH_MASTER_KEY] varchar(6) NULL,
        [PROFILE_UPDATED] varchar(1) NULL,
        [CAMPUS_OPEN_IND] varchar(1) NULL,
        [PROFILE_SENT] datetime NULL,
        [SPEC_CURR_IND] varchar(1) NULL,
        [GLOBAL_ID] int NULL,
        [SCH_DEFINED01] varchar(20) NULL,
        [SCH_DEFINED02] varchar(20) NULL,
        [PREF_MAIL_MECH] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCI_Index_SCIKEY] PRIMARY KEY CLUSTERED (
            [SCIKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_CURRENT_QUILT] ON [dbo].[SCI]
    (
            [CURRENT_QUILT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_DESTINATION_SCHOOL] ON [dbo].[SCI]
    (
            [DESTINATION_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_LW_DATE] ON [dbo].[SCI]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_REL_INSTR] ON [dbo].[SCI]
    (
            [REL_INSTR] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SAM_SCH_COUNCIL] ON [dbo].[SCI]
    (
            [SAM_SCH_COUNCIL] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_AOIC] ON [dbo].[SCI]
    (
            [SCH_AOIC] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_BMANAGER] ON [dbo].[SCI]
    (
            [SCH_BMANAGER] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_COUNCIL_PRES] ON [dbo].[SCI]
    (
            [SCH_COUNCIL_PRES] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_EMERG_CONTACT] ON [dbo].[SCI]
    (
            [SCH_EMERG_CONTACT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_PRINCIPAL] ON [dbo].[SCI]
    (
            [SCH_PRINCIPAL] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_VAC_CONTACT] ON [dbo].[SCI]
    (
            [SCH_VAC_CONTACT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCH_VPRIN] ON [dbo].[SCI]
    (
            [SCH_VPRIN] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SCHOOL_LINK] ON [dbo].[SCI]
    (
            [SCHOOL_LINK] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_2VPRIN] ON [dbo].[SCI]
    (
            [SF_2VPRIN] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_3VPRIN] ON [dbo].[SCI]
    (
            [SF_3VPRIN] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_APRIN] ON [dbo].[SCI]
    (
            [SF_APRIN] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_BMANAGER] ON [dbo].[SCI]
    (
            [SF_BMANAGER] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_EMERG_CONTACT] ON [dbo].[SCI]
    (
            [SF_EMERG_CONTACT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_OIC] ON [dbo].[SCI]
    (
            [SF_OIC] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_VAC_CONTACT] ON [dbo].[SCI]
    (
            [SF_VAC_CONTACT] ASC
    );
    CREATE NONCLUSTERED INDEX [SCI_Index_SF_VPRIN] ON [dbo].[SCI]
    (
            [SF_VPRIN] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_CURRENT_QUILT')
    ALTER INDEX [Index_CURRENT_QUILT] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_DESTINATION_SCHOOL')
    ALTER INDEX [Index_DESTINATION_SCHOOL] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_REL_INSTR')
    ALTER INDEX [Index_REL_INSTR] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SAM_SCH_COUNCIL')
    ALTER INDEX [Index_SAM_SCH_COUNCIL] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_AOIC')
    ALTER INDEX [Index_SCH_AOIC] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_BMANAGER')
    ALTER INDEX [Index_SCH_BMANAGER] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_COUNCIL_PRES')
    ALTER INDEX [Index_SCH_COUNCIL_PRES] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_EMERG_CONTACT')
    ALTER INDEX [Index_SCH_EMERG_CONTACT] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_PRINCIPAL')
    ALTER INDEX [Index_SCH_PRINCIPAL] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_VAC_CONTACT')
    ALTER INDEX [Index_SCH_VAC_CONTACT] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_VPRIN')
    ALTER INDEX [Index_SCH_VPRIN] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCHOOL_LINK')
    ALTER INDEX [Index_SCHOOL_LINK] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_2VPRIN')
    ALTER INDEX [Index_SF_2VPRIN] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_3VPRIN')
    ALTER INDEX [Index_SF_3VPRIN] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_APRIN')
    ALTER INDEX [Index_SF_APRIN] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_BMANAGER')
    ALTER INDEX [Index_SF_BMANAGER] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_EMERG_CONTACT')
    ALTER INDEX [Index_SF_EMERG_CONTACT] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_OIC')
    ALTER INDEX [Index_SF_OIC] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_VAC_CONTACT')
    ALTER INDEX [Index_SF_VAC_CONTACT] ON [dbo].[SCI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_VPRIN')
    ALTER INDEX [Index_SF_VPRIN] ON [dbo].[SCI] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_CURRENT_QUILT')
    ALTER INDEX [Index_CURRENT_QUILT] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_DESTINATION_SCHOOL')
    ALTER INDEX [Index_DESTINATION_SCHOOL] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_REL_INSTR')
    ALTER INDEX [Index_REL_INSTR] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SAM_SCH_COUNCIL')
    ALTER INDEX [Index_SAM_SCH_COUNCIL] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_AOIC')
    ALTER INDEX [Index_SCH_AOIC] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_BMANAGER')
    ALTER INDEX [Index_SCH_BMANAGER] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_COUNCIL_PRES')
    ALTER INDEX [Index_SCH_COUNCIL_PRES] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_EMERG_CONTACT')
    ALTER INDEX [Index_SCH_EMERG_CONTACT] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_PRINCIPAL')
    ALTER INDEX [Index_SCH_PRINCIPAL] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_VAC_CONTACT')
    ALTER INDEX [Index_SCH_VAC_CONTACT] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCH_VPRIN')
    ALTER INDEX [Index_SCH_VPRIN] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SCHOOL_LINK')
    ALTER INDEX [Index_SCHOOL_LINK] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_2VPRIN')
    ALTER INDEX [Index_SF_2VPRIN] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_3VPRIN')
    ALTER INDEX [Index_SF_3VPRIN] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_APRIN')
    ALTER INDEX [Index_SF_APRIN] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_BMANAGER')
    ALTER INDEX [Index_SF_BMANAGER] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_EMERG_CONTACT')
    ALTER INDEX [Index_SF_EMERG_CONTACT] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_OIC')
    ALTER INDEX [Index_SF_OIC] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_VAC_CONTACT')
    ALTER INDEX [Index_SF_VAC_CONTACT] ON [dbo].[SCI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCI]') AND name = N'Index_SF_VPRIN')
    ALTER INDEX [Index_SF_VPRIN] ON [dbo].[SCI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SCHOOL_LINK = new List<string>();
            List<int> Index_SCIKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SCHOOL_LINK.Add(entity.SCHOOL_LINK);
                Index_SCIKEY.Add(entity.SCIKEY);
            }

            builder.AppendLine("DELETE [dbo].[SCI] WHERE");


            // Index_SCHOOL_LINK
            builder.Append("[SCHOOL_LINK] IN (");
            for (int index = 0; index < Index_SCHOOL_LINK.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCHOOL_LINK
                var parameterSCHOOL_LINK = $"@p{parameterIndex++}";
                builder.Append(parameterSCHOOL_LINK);
                command.Parameters.Add(parameterSCHOOL_LINK, SqlDbType.VarChar, 8).Value = (object)Index_SCHOOL_LINK[index] ?? DBNull.Value;
            }
            builder.AppendLine(") OR");

            // Index_SCIKEY
            builder.Append("[SCIKEY] IN (");
            for (int index = 0; index < Index_SCIKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCIKEY
                var parameterSCIKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSCIKEY);
                command.Parameters.Add(parameterSCIKEY, SqlDbType.Int).Value = Index_SCIKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCI data set</returns>
        public override EduHubDataSetDataReader<SCI> GetDataSetDataReader()
        {
            return new SCIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCI data set</returns>
        public override EduHubDataSetDataReader<SCI> GetDataSetDataReader(List<SCI> Entities)
        {
            return new SCIDataReader(new EduHubDataSetLoadedReader<SCI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCIDataReader : EduHubDataSetDataReader<SCI>
        {
            public SCIDataReader(IEduHubDataSetReader<SCI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 81; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCIKEY
                        return Current.SCIKEY;
                    case 1: // CAMPUS_NAME
                        return Current.CAMPUS_NAME;
                    case 2: // CAMPUS_TYPE
                        return Current.CAMPUS_TYPE;
                    case 3: // SCHOOL_LINK
                        return Current.SCHOOL_LINK;
                    case 4: // SCHOOL_TYPE
                        return Current.SCHOOL_TYPE;
                    case 5: // SCHOOL_NAME
                        return Current.SCHOOL_NAME;
                    case 6: // MASTER_KEY
                        return Current.MASTER_KEY;
                    case 7: // ADMIN_SITE
                        return Current.ADMIN_SITE;
                    case 8: // SCH_PRINCIPAL
                        return Current.SCH_PRINCIPAL;
                    case 9: // SF_OIC
                        return Current.SF_OIC;
                    case 10: // SF_VPRIN
                        return Current.SF_VPRIN;
                    case 11: // SF_2VPRIN
                        return Current.SF_2VPRIN;
                    case 12: // SF_3VPRIN
                        return Current.SF_3VPRIN;
                    case 13: // SF_APRIN
                        return Current.SF_APRIN;
                    case 14: // SF_BMANAGER
                        return Current.SF_BMANAGER;
                    case 15: // SF_VAC_CONTACT
                        return Current.SF_VAC_CONTACT;
                    case 16: // SF_EMERG_CONTACT
                        return Current.SF_EMERG_CONTACT;
                    case 17: // SAM_SCH_COUNCIL
                        return Current.SAM_SCH_COUNCIL;
                    case 18: // PLATFORM
                        return Current.PLATFORM;
                    case 19: // CURRENT_RELEASE
                        return Current.CURRENT_RELEASE;
                    case 20: // RELEASE_ACTION
                        return Current.RELEASE_ACTION;
                    case 21: // RELEASE_DATE
                        return Current.RELEASE_DATE;
                    case 22: // SCHEMA_VERIFIED
                        return Current.SCHEMA_VERIFIED;
                    case 23: // UPGRADE_VERSION
                        return Current.UPGRADE_VERSION;
                    case 24: // ECASES21_VERSION
                        return Current.ECASES21_VERSION;
                    case 25: // DMIRROR_VERSION
                        return Current.DMIRROR_VERSION;
                    case 26: // CURRENT_QUILT
                        return Current.CURRENT_QUILT;
                    case 27: // CURRENT_SEMESTER
                        return Current.CURRENT_SEMESTER;
                    case 28: // LAST_PROMOTION_DATE
                        return Current.LAST_PROMOTION_DATE;
                    case 29: // AGE_CALCULATION_DATE
                        return Current.AGE_CALCULATION_DATE;
                    case 30: // NEXT_ENROLMENT_DATE
                        return Current.NEXT_ENROLMENT_DATE;
                    case 31: // TFR_ENROLMENT_DATE
                        return Current.TFR_ENROLMENT_DATE;
                    case 32: // GENDER_DEFAULT
                        return Current.GENDER_DEFAULT;
                    case 33: // TELEPHONE_PREFIX
                        return Current.TELEPHONE_PREFIX;
                    case 34: // REL_INSTR
                        return Current.REL_INSTR;
                    case 35: // CONSECUTIVE_DAYS
                        return Current.CONSECUTIVE_DAYS;
                    case 36: // CUMULATIVE_DAYS
                        return Current.CUMULATIVE_DAYS;
                    case 37: // OVERALL_DAYS
                        return Current.OVERALL_DAYS;
                    case 38: // ADDRESS01
                        return Current.ADDRESS01;
                    case 39: // ADDRESS02
                        return Current.ADDRESS02;
                    case 40: // SUBURB
                        return Current.SUBURB;
                    case 41: // STATE
                        return Current.STATE;
                    case 42: // POSTCODE
                        return Current.POSTCODE;
                    case 43: // TELEPHONE
                        return Current.TELEPHONE;
                    case 44: // FAX
                        return Current.FAX;
                    case 45: // MAILING_ADDRESS01
                        return Current.MAILING_ADDRESS01;
                    case 46: // MAILING_ADDRESS02
                        return Current.MAILING_ADDRESS02;
                    case 47: // MAILING_SUBURB
                        return Current.MAILING_SUBURB;
                    case 48: // MAILING_STATE
                        return Current.MAILING_STATE;
                    case 49: // MAILING_POSTCODE
                        return Current.MAILING_POSTCODE;
                    case 50: // DELIVERY_ADDRESS01
                        return Current.DELIVERY_ADDRESS01;
                    case 51: // DELIVERY_ADDRESS02
                        return Current.DELIVERY_ADDRESS02;
                    case 52: // DELIVERY_SUBURB
                        return Current.DELIVERY_SUBURB;
                    case 53: // DELIVERY_STATE
                        return Current.DELIVERY_STATE;
                    case 54: // DELIVERY_POSTCODE
                        return Current.DELIVERY_POSTCODE;
                    case 55: // DELIVERY_TELEPHONE
                        return Current.DELIVERY_TELEPHONE;
                    case 56: // DELIVERY_FAX
                        return Current.DELIVERY_FAX;
                    case 57: // MAP_TYPE
                        return Current.MAP_TYPE;
                    case 58: // MAP_NUM
                        return Current.MAP_NUM;
                    case 59: // X_AXIS
                        return Current.X_AXIS;
                    case 60: // Y_AXIS
                        return Current.Y_AXIS;
                    case 61: // DESTINATION_SCHOOL
                        return Current.DESTINATION_SCHOOL;
                    case 62: // CAMPUS_EMAIL_CONTACT
                        return Current.CAMPUS_EMAIL_CONTACT;
                    case 63: // SCH_AOIC
                        return Current.SCH_AOIC;
                    case 64: // SCH_VPRIN
                        return Current.SCH_VPRIN;
                    case 65: // SCH_BMANAGER
                        return Current.SCH_BMANAGER;
                    case 66: // SCH_VAC_CONTACT
                        return Current.SCH_VAC_CONTACT;
                    case 67: // SCH_EMERG_CONTACT
                        return Current.SCH_EMERG_CONTACT;
                    case 68: // SCH_COUNCIL_PRES
                        return Current.SCH_COUNCIL_PRES;
                    case 69: // SCH_MASTER_KEY
                        return Current.SCH_MASTER_KEY;
                    case 70: // PROFILE_UPDATED
                        return Current.PROFILE_UPDATED;
                    case 71: // CAMPUS_OPEN_IND
                        return Current.CAMPUS_OPEN_IND;
                    case 72: // PROFILE_SENT
                        return Current.PROFILE_SENT;
                    case 73: // SPEC_CURR_IND
                        return Current.SPEC_CURR_IND;
                    case 74: // GLOBAL_ID
                        return Current.GLOBAL_ID;
                    case 75: // SCH_DEFINED01
                        return Current.SCH_DEFINED01;
                    case 76: // SCH_DEFINED02
                        return Current.SCH_DEFINED02;
                    case 77: // PREF_MAIL_MECH
                        return Current.PREF_MAIL_MECH;
                    case 78: // LW_DATE
                        return Current.LW_DATE;
                    case 79: // LW_TIME
                        return Current.LW_TIME;
                    case 80: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CAMPUS_NAME
                        return Current.CAMPUS_NAME == null;
                    case 2: // CAMPUS_TYPE
                        return Current.CAMPUS_TYPE == null;
                    case 3: // SCHOOL_LINK
                        return Current.SCHOOL_LINK == null;
                    case 4: // SCHOOL_TYPE
                        return Current.SCHOOL_TYPE == null;
                    case 5: // SCHOOL_NAME
                        return Current.SCHOOL_NAME == null;
                    case 6: // MASTER_KEY
                        return Current.MASTER_KEY == null;
                    case 7: // ADMIN_SITE
                        return Current.ADMIN_SITE == null;
                    case 8: // SCH_PRINCIPAL
                        return Current.SCH_PRINCIPAL == null;
                    case 9: // SF_OIC
                        return Current.SF_OIC == null;
                    case 10: // SF_VPRIN
                        return Current.SF_VPRIN == null;
                    case 11: // SF_2VPRIN
                        return Current.SF_2VPRIN == null;
                    case 12: // SF_3VPRIN
                        return Current.SF_3VPRIN == null;
                    case 13: // SF_APRIN
                        return Current.SF_APRIN == null;
                    case 14: // SF_BMANAGER
                        return Current.SF_BMANAGER == null;
                    case 15: // SF_VAC_CONTACT
                        return Current.SF_VAC_CONTACT == null;
                    case 16: // SF_EMERG_CONTACT
                        return Current.SF_EMERG_CONTACT == null;
                    case 17: // SAM_SCH_COUNCIL
                        return Current.SAM_SCH_COUNCIL == null;
                    case 18: // PLATFORM
                        return Current.PLATFORM == null;
                    case 19: // CURRENT_RELEASE
                        return Current.CURRENT_RELEASE == null;
                    case 20: // RELEASE_ACTION
                        return Current.RELEASE_ACTION == null;
                    case 21: // RELEASE_DATE
                        return Current.RELEASE_DATE == null;
                    case 22: // SCHEMA_VERIFIED
                        return Current.SCHEMA_VERIFIED == null;
                    case 23: // UPGRADE_VERSION
                        return Current.UPGRADE_VERSION == null;
                    case 24: // ECASES21_VERSION
                        return Current.ECASES21_VERSION == null;
                    case 25: // DMIRROR_VERSION
                        return Current.DMIRROR_VERSION == null;
                    case 26: // CURRENT_QUILT
                        return Current.CURRENT_QUILT == null;
                    case 27: // CURRENT_SEMESTER
                        return Current.CURRENT_SEMESTER == null;
                    case 28: // LAST_PROMOTION_DATE
                        return Current.LAST_PROMOTION_DATE == null;
                    case 29: // AGE_CALCULATION_DATE
                        return Current.AGE_CALCULATION_DATE == null;
                    case 30: // NEXT_ENROLMENT_DATE
                        return Current.NEXT_ENROLMENT_DATE == null;
                    case 31: // TFR_ENROLMENT_DATE
                        return Current.TFR_ENROLMENT_DATE == null;
                    case 32: // GENDER_DEFAULT
                        return Current.GENDER_DEFAULT == null;
                    case 33: // TELEPHONE_PREFIX
                        return Current.TELEPHONE_PREFIX == null;
                    case 34: // REL_INSTR
                        return Current.REL_INSTR == null;
                    case 35: // CONSECUTIVE_DAYS
                        return Current.CONSECUTIVE_DAYS == null;
                    case 36: // CUMULATIVE_DAYS
                        return Current.CUMULATIVE_DAYS == null;
                    case 37: // OVERALL_DAYS
                        return Current.OVERALL_DAYS == null;
                    case 38: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 39: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 40: // SUBURB
                        return Current.SUBURB == null;
                    case 41: // STATE
                        return Current.STATE == null;
                    case 42: // POSTCODE
                        return Current.POSTCODE == null;
                    case 43: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 44: // FAX
                        return Current.FAX == null;
                    case 45: // MAILING_ADDRESS01
                        return Current.MAILING_ADDRESS01 == null;
                    case 46: // MAILING_ADDRESS02
                        return Current.MAILING_ADDRESS02 == null;
                    case 47: // MAILING_SUBURB
                        return Current.MAILING_SUBURB == null;
                    case 48: // MAILING_STATE
                        return Current.MAILING_STATE == null;
                    case 49: // MAILING_POSTCODE
                        return Current.MAILING_POSTCODE == null;
                    case 50: // DELIVERY_ADDRESS01
                        return Current.DELIVERY_ADDRESS01 == null;
                    case 51: // DELIVERY_ADDRESS02
                        return Current.DELIVERY_ADDRESS02 == null;
                    case 52: // DELIVERY_SUBURB
                        return Current.DELIVERY_SUBURB == null;
                    case 53: // DELIVERY_STATE
                        return Current.DELIVERY_STATE == null;
                    case 54: // DELIVERY_POSTCODE
                        return Current.DELIVERY_POSTCODE == null;
                    case 55: // DELIVERY_TELEPHONE
                        return Current.DELIVERY_TELEPHONE == null;
                    case 56: // DELIVERY_FAX
                        return Current.DELIVERY_FAX == null;
                    case 57: // MAP_TYPE
                        return Current.MAP_TYPE == null;
                    case 58: // MAP_NUM
                        return Current.MAP_NUM == null;
                    case 59: // X_AXIS
                        return Current.X_AXIS == null;
                    case 60: // Y_AXIS
                        return Current.Y_AXIS == null;
                    case 61: // DESTINATION_SCHOOL
                        return Current.DESTINATION_SCHOOL == null;
                    case 62: // CAMPUS_EMAIL_CONTACT
                        return Current.CAMPUS_EMAIL_CONTACT == null;
                    case 63: // SCH_AOIC
                        return Current.SCH_AOIC == null;
                    case 64: // SCH_VPRIN
                        return Current.SCH_VPRIN == null;
                    case 65: // SCH_BMANAGER
                        return Current.SCH_BMANAGER == null;
                    case 66: // SCH_VAC_CONTACT
                        return Current.SCH_VAC_CONTACT == null;
                    case 67: // SCH_EMERG_CONTACT
                        return Current.SCH_EMERG_CONTACT == null;
                    case 68: // SCH_COUNCIL_PRES
                        return Current.SCH_COUNCIL_PRES == null;
                    case 69: // SCH_MASTER_KEY
                        return Current.SCH_MASTER_KEY == null;
                    case 70: // PROFILE_UPDATED
                        return Current.PROFILE_UPDATED == null;
                    case 71: // CAMPUS_OPEN_IND
                        return Current.CAMPUS_OPEN_IND == null;
                    case 72: // PROFILE_SENT
                        return Current.PROFILE_SENT == null;
                    case 73: // SPEC_CURR_IND
                        return Current.SPEC_CURR_IND == null;
                    case 74: // GLOBAL_ID
                        return Current.GLOBAL_ID == null;
                    case 75: // SCH_DEFINED01
                        return Current.SCH_DEFINED01 == null;
                    case 76: // SCH_DEFINED02
                        return Current.SCH_DEFINED02 == null;
                    case 77: // PREF_MAIL_MECH
                        return Current.PREF_MAIL_MECH == null;
                    case 78: // LW_DATE
                        return Current.LW_DATE == null;
                    case 79: // LW_TIME
                        return Current.LW_TIME == null;
                    case 80: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCIKEY
                        return "SCIKEY";
                    case 1: // CAMPUS_NAME
                        return "CAMPUS_NAME";
                    case 2: // CAMPUS_TYPE
                        return "CAMPUS_TYPE";
                    case 3: // SCHOOL_LINK
                        return "SCHOOL_LINK";
                    case 4: // SCHOOL_TYPE
                        return "SCHOOL_TYPE";
                    case 5: // SCHOOL_NAME
                        return "SCHOOL_NAME";
                    case 6: // MASTER_KEY
                        return "MASTER_KEY";
                    case 7: // ADMIN_SITE
                        return "ADMIN_SITE";
                    case 8: // SCH_PRINCIPAL
                        return "SCH_PRINCIPAL";
                    case 9: // SF_OIC
                        return "SF_OIC";
                    case 10: // SF_VPRIN
                        return "SF_VPRIN";
                    case 11: // SF_2VPRIN
                        return "SF_2VPRIN";
                    case 12: // SF_3VPRIN
                        return "SF_3VPRIN";
                    case 13: // SF_APRIN
                        return "SF_APRIN";
                    case 14: // SF_BMANAGER
                        return "SF_BMANAGER";
                    case 15: // SF_VAC_CONTACT
                        return "SF_VAC_CONTACT";
                    case 16: // SF_EMERG_CONTACT
                        return "SF_EMERG_CONTACT";
                    case 17: // SAM_SCH_COUNCIL
                        return "SAM_SCH_COUNCIL";
                    case 18: // PLATFORM
                        return "PLATFORM";
                    case 19: // CURRENT_RELEASE
                        return "CURRENT_RELEASE";
                    case 20: // RELEASE_ACTION
                        return "RELEASE_ACTION";
                    case 21: // RELEASE_DATE
                        return "RELEASE_DATE";
                    case 22: // SCHEMA_VERIFIED
                        return "SCHEMA_VERIFIED";
                    case 23: // UPGRADE_VERSION
                        return "UPGRADE_VERSION";
                    case 24: // ECASES21_VERSION
                        return "ECASES21_VERSION";
                    case 25: // DMIRROR_VERSION
                        return "DMIRROR_VERSION";
                    case 26: // CURRENT_QUILT
                        return "CURRENT_QUILT";
                    case 27: // CURRENT_SEMESTER
                        return "CURRENT_SEMESTER";
                    case 28: // LAST_PROMOTION_DATE
                        return "LAST_PROMOTION_DATE";
                    case 29: // AGE_CALCULATION_DATE
                        return "AGE_CALCULATION_DATE";
                    case 30: // NEXT_ENROLMENT_DATE
                        return "NEXT_ENROLMENT_DATE";
                    case 31: // TFR_ENROLMENT_DATE
                        return "TFR_ENROLMENT_DATE";
                    case 32: // GENDER_DEFAULT
                        return "GENDER_DEFAULT";
                    case 33: // TELEPHONE_PREFIX
                        return "TELEPHONE_PREFIX";
                    case 34: // REL_INSTR
                        return "REL_INSTR";
                    case 35: // CONSECUTIVE_DAYS
                        return "CONSECUTIVE_DAYS";
                    case 36: // CUMULATIVE_DAYS
                        return "CUMULATIVE_DAYS";
                    case 37: // OVERALL_DAYS
                        return "OVERALL_DAYS";
                    case 38: // ADDRESS01
                        return "ADDRESS01";
                    case 39: // ADDRESS02
                        return "ADDRESS02";
                    case 40: // SUBURB
                        return "SUBURB";
                    case 41: // STATE
                        return "STATE";
                    case 42: // POSTCODE
                        return "POSTCODE";
                    case 43: // TELEPHONE
                        return "TELEPHONE";
                    case 44: // FAX
                        return "FAX";
                    case 45: // MAILING_ADDRESS01
                        return "MAILING_ADDRESS01";
                    case 46: // MAILING_ADDRESS02
                        return "MAILING_ADDRESS02";
                    case 47: // MAILING_SUBURB
                        return "MAILING_SUBURB";
                    case 48: // MAILING_STATE
                        return "MAILING_STATE";
                    case 49: // MAILING_POSTCODE
                        return "MAILING_POSTCODE";
                    case 50: // DELIVERY_ADDRESS01
                        return "DELIVERY_ADDRESS01";
                    case 51: // DELIVERY_ADDRESS02
                        return "DELIVERY_ADDRESS02";
                    case 52: // DELIVERY_SUBURB
                        return "DELIVERY_SUBURB";
                    case 53: // DELIVERY_STATE
                        return "DELIVERY_STATE";
                    case 54: // DELIVERY_POSTCODE
                        return "DELIVERY_POSTCODE";
                    case 55: // DELIVERY_TELEPHONE
                        return "DELIVERY_TELEPHONE";
                    case 56: // DELIVERY_FAX
                        return "DELIVERY_FAX";
                    case 57: // MAP_TYPE
                        return "MAP_TYPE";
                    case 58: // MAP_NUM
                        return "MAP_NUM";
                    case 59: // X_AXIS
                        return "X_AXIS";
                    case 60: // Y_AXIS
                        return "Y_AXIS";
                    case 61: // DESTINATION_SCHOOL
                        return "DESTINATION_SCHOOL";
                    case 62: // CAMPUS_EMAIL_CONTACT
                        return "CAMPUS_EMAIL_CONTACT";
                    case 63: // SCH_AOIC
                        return "SCH_AOIC";
                    case 64: // SCH_VPRIN
                        return "SCH_VPRIN";
                    case 65: // SCH_BMANAGER
                        return "SCH_BMANAGER";
                    case 66: // SCH_VAC_CONTACT
                        return "SCH_VAC_CONTACT";
                    case 67: // SCH_EMERG_CONTACT
                        return "SCH_EMERG_CONTACT";
                    case 68: // SCH_COUNCIL_PRES
                        return "SCH_COUNCIL_PRES";
                    case 69: // SCH_MASTER_KEY
                        return "SCH_MASTER_KEY";
                    case 70: // PROFILE_UPDATED
                        return "PROFILE_UPDATED";
                    case 71: // CAMPUS_OPEN_IND
                        return "CAMPUS_OPEN_IND";
                    case 72: // PROFILE_SENT
                        return "PROFILE_SENT";
                    case 73: // SPEC_CURR_IND
                        return "SPEC_CURR_IND";
                    case 74: // GLOBAL_ID
                        return "GLOBAL_ID";
                    case 75: // SCH_DEFINED01
                        return "SCH_DEFINED01";
                    case 76: // SCH_DEFINED02
                        return "SCH_DEFINED02";
                    case 77: // PREF_MAIL_MECH
                        return "PREF_MAIL_MECH";
                    case 78: // LW_DATE
                        return "LW_DATE";
                    case 79: // LW_TIME
                        return "LW_TIME";
                    case 80: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCIKEY":
                        return 0;
                    case "CAMPUS_NAME":
                        return 1;
                    case "CAMPUS_TYPE":
                        return 2;
                    case "SCHOOL_LINK":
                        return 3;
                    case "SCHOOL_TYPE":
                        return 4;
                    case "SCHOOL_NAME":
                        return 5;
                    case "MASTER_KEY":
                        return 6;
                    case "ADMIN_SITE":
                        return 7;
                    case "SCH_PRINCIPAL":
                        return 8;
                    case "SF_OIC":
                        return 9;
                    case "SF_VPRIN":
                        return 10;
                    case "SF_2VPRIN":
                        return 11;
                    case "SF_3VPRIN":
                        return 12;
                    case "SF_APRIN":
                        return 13;
                    case "SF_BMANAGER":
                        return 14;
                    case "SF_VAC_CONTACT":
                        return 15;
                    case "SF_EMERG_CONTACT":
                        return 16;
                    case "SAM_SCH_COUNCIL":
                        return 17;
                    case "PLATFORM":
                        return 18;
                    case "CURRENT_RELEASE":
                        return 19;
                    case "RELEASE_ACTION":
                        return 20;
                    case "RELEASE_DATE":
                        return 21;
                    case "SCHEMA_VERIFIED":
                        return 22;
                    case "UPGRADE_VERSION":
                        return 23;
                    case "ECASES21_VERSION":
                        return 24;
                    case "DMIRROR_VERSION":
                        return 25;
                    case "CURRENT_QUILT":
                        return 26;
                    case "CURRENT_SEMESTER":
                        return 27;
                    case "LAST_PROMOTION_DATE":
                        return 28;
                    case "AGE_CALCULATION_DATE":
                        return 29;
                    case "NEXT_ENROLMENT_DATE":
                        return 30;
                    case "TFR_ENROLMENT_DATE":
                        return 31;
                    case "GENDER_DEFAULT":
                        return 32;
                    case "TELEPHONE_PREFIX":
                        return 33;
                    case "REL_INSTR":
                        return 34;
                    case "CONSECUTIVE_DAYS":
                        return 35;
                    case "CUMULATIVE_DAYS":
                        return 36;
                    case "OVERALL_DAYS":
                        return 37;
                    case "ADDRESS01":
                        return 38;
                    case "ADDRESS02":
                        return 39;
                    case "SUBURB":
                        return 40;
                    case "STATE":
                        return 41;
                    case "POSTCODE":
                        return 42;
                    case "TELEPHONE":
                        return 43;
                    case "FAX":
                        return 44;
                    case "MAILING_ADDRESS01":
                        return 45;
                    case "MAILING_ADDRESS02":
                        return 46;
                    case "MAILING_SUBURB":
                        return 47;
                    case "MAILING_STATE":
                        return 48;
                    case "MAILING_POSTCODE":
                        return 49;
                    case "DELIVERY_ADDRESS01":
                        return 50;
                    case "DELIVERY_ADDRESS02":
                        return 51;
                    case "DELIVERY_SUBURB":
                        return 52;
                    case "DELIVERY_STATE":
                        return 53;
                    case "DELIVERY_POSTCODE":
                        return 54;
                    case "DELIVERY_TELEPHONE":
                        return 55;
                    case "DELIVERY_FAX":
                        return 56;
                    case "MAP_TYPE":
                        return 57;
                    case "MAP_NUM":
                        return 58;
                    case "X_AXIS":
                        return 59;
                    case "Y_AXIS":
                        return 60;
                    case "DESTINATION_SCHOOL":
                        return 61;
                    case "CAMPUS_EMAIL_CONTACT":
                        return 62;
                    case "SCH_AOIC":
                        return 63;
                    case "SCH_VPRIN":
                        return 64;
                    case "SCH_BMANAGER":
                        return 65;
                    case "SCH_VAC_CONTACT":
                        return 66;
                    case "SCH_EMERG_CONTACT":
                        return 67;
                    case "SCH_COUNCIL_PRES":
                        return 68;
                    case "SCH_MASTER_KEY":
                        return 69;
                    case "PROFILE_UPDATED":
                        return 70;
                    case "CAMPUS_OPEN_IND":
                        return 71;
                    case "PROFILE_SENT":
                        return 72;
                    case "SPEC_CURR_IND":
                        return 73;
                    case "GLOBAL_ID":
                        return 74;
                    case "SCH_DEFINED01":
                        return 75;
                    case "SCH_DEFINED02":
                        return 76;
                    case "PREF_MAIL_MECH":
                        return 77;
                    case "LW_DATE":
                        return 78;
                    case "LW_TIME":
                        return 79;
                    case "LW_USER":
                        return 80;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
