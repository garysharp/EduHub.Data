using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// ST Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST_TFRDataSet : SetBase<ST_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "ST_TFR"; } }

        internal ST_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOME_GROUP_NEW = new Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP_NEW));
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_SCHOOL_YEAR_NEW = new Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR_NEW));
            Index_ST_TRANS_ID = new Lazy<NullDictionary<string, ST_TFR>>(() => this.ToNullDictionary(i => i.ST_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, ST_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST_TFR" /> fields for each CSV column header</returns>
        protected override Action<ST_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "STKEY_NEW":
                        mapper[i] = (e, v) => e.STKEY_NEW = v;
                        break;
                    case "DUP_FAMILY":
                        mapper[i] = (e, v) => e.DUP_FAMILY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
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
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "FAMILY_DUP":
                        mapper[i] = (e, v) => e.FAMILY_DUP = v;
                        break;
                    case "FAMILY_DUP_ACT":
                        mapper[i] = (e, v) => e.FAMILY_DUP_ACT = v;
                        break;
                    case "ACADEMIC_A":
                        mapper[i] = (e, v) => e.ACADEMIC_A = v;
                        break;
                    case "LIVING_A":
                        mapper[i] = (e, v) => e.LIVING_A = v;
                        break;
                    case "RELATION_A01":
                        mapper[i] = (e, v) => e.RELATION_A01 = v;
                        break;
                    case "RELATION_A02":
                        mapper[i] = (e, v) => e.RELATION_A02 = v;
                        break;
                    case "CONTACT_A":
                        mapper[i] = (e, v) => e.CONTACT_A = v;
                        break;
                    case "FAMB":
                        mapper[i] = (e, v) => e.FAMB = v;
                        break;
                    case "FAMB_DUP":
                        mapper[i] = (e, v) => e.FAMB_DUP = v;
                        break;
                    case "FAMB_DUP_ACT":
                        mapper[i] = (e, v) => e.FAMB_DUP_ACT = v;
                        break;
                    case "ACADEMIC_B":
                        mapper[i] = (e, v) => e.ACADEMIC_B = v;
                        break;
                    case "LIVING_B":
                        mapper[i] = (e, v) => e.LIVING_B = v;
                        break;
                    case "RELATION_B01":
                        mapper[i] = (e, v) => e.RELATION_B01 = v;
                        break;
                    case "RELATION_B02":
                        mapper[i] = (e, v) => e.RELATION_B02 = v;
                        break;
                    case "CONTACT_B":
                        mapper[i] = (e, v) => e.CONTACT_B = v;
                        break;
                    case "FAMC":
                        mapper[i] = (e, v) => e.FAMC = v;
                        break;
                    case "FAMC_DUP":
                        mapper[i] = (e, v) => e.FAMC_DUP = v;
                        break;
                    case "FAMC_DUP_ACT":
                        mapper[i] = (e, v) => e.FAMC_DUP_ACT = v;
                        break;
                    case "ACADEMIC_C":
                        mapper[i] = (e, v) => e.ACADEMIC_C = v;
                        break;
                    case "LIVING_C":
                        mapper[i] = (e, v) => e.LIVING_C = v;
                        break;
                    case "RELATION_C01":
                        mapper[i] = (e, v) => e.RELATION_C01 = v;
                        break;
                    case "RELATION_C02":
                        mapper[i] = (e, v) => e.RELATION_C02 = v;
                        break;
                    case "CONTACT_C":
                        mapper[i] = (e, v) => e.CONTACT_C = v;
                        break;
                    case "LIVING_ARR":
                        mapper[i] = (e, v) => e.LIVING_ARR = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
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
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PROOF_DOB":
                        mapper[i] = (e, v) => e.PROOF_DOB = v;
                        break;
                    case "RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.RESIDENT_STATUS = v;
                        break;
                    case "PERMANENT_BASIS":
                        mapper[i] = (e, v) => e.PERMANENT_BASIS = v;
                        break;
                    case "ARRIVAL":
                        mapper[i] = (e, v) => e.ARRIVAL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INTEGRATION":
                        mapper[i] = (e, v) => e.INTEGRATION = v;
                        break;
                    case "FAM_ORDER":
                        mapper[i] = (e, v) => e.FAM_ORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "SCHOOL_YEAR_NEW":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR_NEW = v;
                        break;
                    case "HOME_GROUP_NEW":
                        mapper[i] = (e, v) => e.HOME_GROUP_NEW = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.VISA_STAT_CODE = v;
                        break;
                    case "VISA_EXPIRY":
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "ENG_SPEAK":
                        mapper[i] = (e, v) => e.ENG_SPEAK = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "OVERSEAS":
                        mapper[i] = (e, v) => e.OVERSEAS = v;
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "ACCESS":
                        mapper[i] = (e, v) => e.ACCESS = v;
                        break;
                    case "ACCESS_TYPE":
                        mapper[i] = (e, v) => e.ACCESS_TYPE = v;
                        break;
                    case "ACCESS_ALERT":
                        mapper[i] = (e, v) => e.ACCESS_ALERT = v;
                        break;
                    case "RISK_ALERT":
                        mapper[i] = (e, v) => e.RISK_ALERT = v;
                        break;
                    case "RISK_MEMO":
                        mapper[i] = (e, v) => e.RISK_MEMO = v;
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
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
                    case "ACC_DECLARATION":
                        mapper[i] = (e, v) => e.ACC_DECLARATION = v;
                        break;
                    case "MEDICARE_NO":
                        mapper[i] = (e, v) => e.MEDICARE_NO = v;
                        break;
                    case "INTERNATIONAL_ST_ID":
                        mapper[i] = (e, v) => e.INTERNATIONAL_ST_ID = v;
                        break;
                    case "MEDICAL_ALERT":
                        mapper[i] = (e, v) => e.MEDICAL_ALERT = v;
                        break;
                    case "MEDICAL_CONDITION":
                        mapper[i] = (e, v) => e.MEDICAL_CONDITION = v;
                        break;
                    case "ACTIVITY_RESTRICTION":
                        mapper[i] = (e, v) => e.ACTIVITY_RESTRICTION = v;
                        break;
                    case "IMMUNISE_CERT_STATUS":
                        mapper[i] = (e, v) => e.IMMUNISE_CERT_STATUS = v;
                        break;
                    case "IMMUN_CERT_SIGHTED":
                        mapper[i] = (e, v) => e.IMMUN_CERT_SIGHTED = v;
                        break;
                    case "IMMUNISE_PERMISSION":
                        mapper[i] = (e, v) => e.IMMUNISE_PERMISSION = v;
                        break;
                    case "IMMUNIZE":
                        mapper[i] = (e, v) => e.IMMUNIZE = v;
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
                    case "YEARS_PREVIOUS_EDUCATION":
                        mapper[i] = (e, v) => e.YEARS_PREVIOUS_EDUCATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "YEARS_INTERRUPTION_EDUCATION":
                        mapper[i] = (e, v) => e.YEARS_INTERRUPTION_EDUCATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LANGUAGE_PREVIOUS_SCHOOLING":
                        mapper[i] = (e, v) => e.LANGUAGE_PREVIOUS_SCHOOLING = v;
                        break;
                    case "LOTE_HOME_CODE":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE = v;
                        break;
                    case "VSN":
                        mapper[i] = (e, v) => e.VSN = v;
                        break;
                    case "SPEC_CURR":
                        mapper[i] = (e, v) => e.SPEC_CURR = v;
                        break;
                    case "DFA_TRANS_ID":
                        mapper[i] = (e, v) => e.DFA_TRANS_ID = v;
                        break;
                    case "DFB_TRANS_ID":
                        mapper[i] = (e, v) => e.DFB_TRANS_ID = v;
                        break;
                    case "DFC_TRANS_ID":
                        mapper[i] = (e, v) => e.DFC_TRANS_ID = v;
                        break;
                    case "KCD_TRANS_ID":
                        mapper[i] = (e, v) => e.KCD_TRANS_ID = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="ST_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="ST_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="ST_TFR" /> items to added or update the base <see cref="ST_TFR" /> items</param>
        /// <returns>A merged list of <see cref="ST_TFR" /> items</returns>
        protected override List<ST_TFR> ApplyDeltaItems(List<ST_TFR> Items, List<ST_TFR> DeltaItems)
        {
            NullDictionary<string, int> Index_ST_TRANS_ID = Items.ToIndexNullDictionary(i => i.ST_TRANS_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (ST_TFR deltaItem in DeltaItems)
            {
                int index;

                if (Index_ST_TRANS_ID.TryGetValue(deltaItem.ST_TRANS_ID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ORIG_SCHOOL)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>> Index_HOME_GROUP_NEW;
        private Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>> Index_SCHOOL_YEAR_NEW;
        private Lazy<NullDictionary<string, ST_TFR>> Index_ST_TRANS_ID;
        private Lazy<Dictionary<int, ST_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ST_TFR by HOME_GROUP_NEW field
        /// </summary>
        /// <param name="HOME_GROUP_NEW">HOME_GROUP_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> FindByHOME_GROUP_NEW(string HOME_GROUP_NEW)
        {
            return Index_HOME_GROUP_NEW.Value[HOME_GROUP_NEW];
        }

        /// <summary>
        /// Attempt to find ST_TFR by HOME_GROUP_NEW field
        /// </summary>
        /// <param name="HOME_GROUP_NEW">HOME_GROUP_NEW value used to find ST_TFR</param>
        /// <param name="Value">List of related ST_TFR entities</param>
        /// <returns>True if the list of related ST_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_GROUP_NEW(string HOME_GROUP_NEW, out IReadOnlyList<ST_TFR> Value)
        {
            return Index_HOME_GROUP_NEW.Value.TryGetValue(HOME_GROUP_NEW, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by HOME_GROUP_NEW field
        /// </summary>
        /// <param name="HOME_GROUP_NEW">HOME_GROUP_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> TryFindByHOME_GROUP_NEW(string HOME_GROUP_NEW)
        {
            IReadOnlyList<ST_TFR> value;
            if (Index_HOME_GROUP_NEW.Value.TryGetValue(HOME_GROUP_NEW, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find ST_TFR</param>
        /// <param name="Value">List of related ST_TFR entities</param>
        /// <returns>True if the list of related ST_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<ST_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<ST_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by SCHOOL_YEAR_NEW field
        /// </summary>
        /// <param name="SCHOOL_YEAR_NEW">SCHOOL_YEAR_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> FindBySCHOOL_YEAR_NEW(string SCHOOL_YEAR_NEW)
        {
            return Index_SCHOOL_YEAR_NEW.Value[SCHOOL_YEAR_NEW];
        }

        /// <summary>
        /// Attempt to find ST_TFR by SCHOOL_YEAR_NEW field
        /// </summary>
        /// <param name="SCHOOL_YEAR_NEW">SCHOOL_YEAR_NEW value used to find ST_TFR</param>
        /// <param name="Value">List of related ST_TFR entities</param>
        /// <returns>True if the list of related ST_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR_NEW(string SCHOOL_YEAR_NEW, out IReadOnlyList<ST_TFR> Value)
        {
            return Index_SCHOOL_YEAR_NEW.Value.TryGetValue(SCHOOL_YEAR_NEW, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by SCHOOL_YEAR_NEW field
        /// </summary>
        /// <param name="SCHOOL_YEAR_NEW">SCHOOL_YEAR_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> TryFindBySCHOOL_YEAR_NEW(string SCHOOL_YEAR_NEW)
        {
            IReadOnlyList<ST_TFR> value;
            if (Index_SCHOOL_YEAR_NEW.Value.TryGetValue(SCHOOL_YEAR_NEW, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR FindByST_TRANS_ID(string ST_TRANS_ID)
        {
            return Index_ST_TRANS_ID.Value[ST_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find ST_TFR by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFR</param>
        /// <param name="Value">Related ST_TFR entity</param>
        /// <returns>True if the related ST_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_TRANS_ID(string ST_TRANS_ID, out ST_TFR Value)
        {
            return Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR TryFindByST_TRANS_ID(string ST_TRANS_ID)
        {
            ST_TFR value;
            if (Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find ST_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFR</param>
        /// <param name="Value">Related ST_TFR entity</param>
        /// <returns>True if the related ST_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out ST_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR TryFindByTID(int TID)
        {
            ST_TFR value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
