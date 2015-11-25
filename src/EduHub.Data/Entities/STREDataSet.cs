using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Re-Enrolment Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STREDataSet : SetBase<STRE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STRE"; } }

        internal STREDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STRE>>(() => this.ToDictionary(i => i.TID));
            Index_ST_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_SCHOOL_YEAR));
            Index_ST_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_HOME_GROUP));
            Index_ST_PREVIOUS_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_PREVIOUS_SCHOOL));
            Index_ST_VISA_SUBCLASS = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_VISA_SUBCLASS));
            Index_ST_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_HOME_LANG));
            Index_ST_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_CAMPUS));
            Index_STPT_SCHL_NUM01 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM01));
            Index_STPT_SCHL_NUM02 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM02));
            Index_STPT_SCHL_NUM03 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM03));
            Index_STPT_SCHL_NUM04 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM04));
            Index_ST_NEXT_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_NEXT_SCHOOL));
            Index_ST_LOTE_HOME_CODE = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_LOTE_HOME_CODE));
            Index_DF_LOTE_HOME_CODE_A = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.DF_LOTE_HOME_CODE_A));
            Index_DF_LOTE_HOME_CODE_B = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.DF_LOTE_HOME_CODE_B));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STRE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STRE" /> fields for each CSV column header</returns>
        protected override Action<STRE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STRE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "ST_ENTRY":
                        mapper[i] = (e, v) => e.ST_ENTRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ST_EXIT_DATE":
                        mapper[i] = (e, v) => e.ST_EXIT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ST_SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.ST_SCHOOL_YEAR = v;
                        break;
                    case "ST_HOME_GROUP":
                        mapper[i] = (e, v) => e.ST_HOME_GROUP = v;
                        break;
                    case "ST_PREVIOUS_SCHOOL":
                        mapper[i] = (e, v) => e.ST_PREVIOUS_SCHOOL = v;
                        break;
                    case "ST_RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.ST_RESIDENT_STATUS = v;
                        break;
                    case "ST_PERMANENT_BASIS":
                        mapper[i] = (e, v) => e.ST_PERMANENT_BASIS = v;
                        break;
                    case "ST_VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.ST_VISA_SUBCLASS = v;
                        break;
                    case "ST_VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.ST_VISA_STAT_CODE = v;
                        break;
                    case "ST_SGB_FUNDED":
                        mapper[i] = (e, v) => e.ST_SGB_FUNDED = v;
                        break;
                    case "ST_LIVING_ARR":
                        mapper[i] = (e, v) => e.ST_LIVING_ARR = v;
                        break;
                    case "ST_FULLTIME":
                        mapper[i] = (e, v) => e.ST_FULLTIME = v;
                        break;
                    case "ST_HOME_LANG":
                        mapper[i] = (e, v) => e.ST_HOME_LANG = v;
                        break;
                    case "ST_ED_ALLOW":
                        mapper[i] = (e, v) => e.ST_ED_ALLOW = v;
                        break;
                    case "ST_YOUTH_ALLOW":
                        mapper[i] = (e, v) => e.ST_YOUTH_ALLOW = v;
                        break;
                    case "ST_CAMPUS":
                        mapper[i] = (e, v) => e.ST_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DF_OCCUP_STATUS_A":
                        mapper[i] = (e, v) => e.DF_OCCUP_STATUS_A = v;
                        break;
                    case "DF_OCCUP_STATUS_B":
                        mapper[i] = (e, v) => e.DF_OCCUP_STATUS_B = v;
                        break;
                    case "STPT_SCHL_NUM01":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM01 = v;
                        break;
                    case "STPT_SCHL_NUM02":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM02 = v;
                        break;
                    case "STPT_SCHL_NUM03":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM03 = v;
                        break;
                    case "STPT_SCHL_NUM04":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM04 = v;
                        break;
                    case "STPT_SGB_TIME_FRACTION01":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SGB_TIME_FRACTION02":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SGB_TIME_FRACTION03":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SGB_TIME_FRACTION04":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_ACTUAL_TIME_FRACTION01":
                        mapper[i] = (e, v) => e.STPT_ACTUAL_TIME_FRACTION01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_ACTUAL_TIME_FRACTION02":
                        mapper[i] = (e, v) => e.STPT_ACTUAL_TIME_FRACTION02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_ACTUAL_TIME_FRACTION03":
                        mapper[i] = (e, v) => e.STPT_ACTUAL_TIME_FRACTION03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_ACTUAL_TIME_FRACTION04":
                        mapper[i] = (e, v) => e.STPT_ACTUAL_TIME_FRACTION04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_ENROLLED01":
                        mapper[i] = (e, v) => e.STPT_ENROLLED01 = v;
                        break;
                    case "STPT_ENROLLED02":
                        mapper[i] = (e, v) => e.STPT_ENROLLED02 = v;
                        break;
                    case "STPT_ENROLLED03":
                        mapper[i] = (e, v) => e.STPT_ENROLLED03 = v;
                        break;
                    case "STPT_ENROLLED04":
                        mapper[i] = (e, v) => e.STPT_ENROLLED04 = v;
                        break;
                    case "ST_NEXT_SCHOOL":
                        mapper[i] = (e, v) => e.ST_NEXT_SCHOOL = v;
                        break;
                    case "ST_VISA_EXPIRY":
                        mapper[i] = (e, v) => e.ST_VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ST_PARENTAL_APPROVAL_NOTE":
                        mapper[i] = (e, v) => e.ST_PARENTAL_APPROVAL_NOTE = v;
                        break;
                    case "ST_LOTE_HOME_CODE":
                        mapper[i] = (e, v) => e.ST_LOTE_HOME_CODE = v;
                        break;
                    case "DF_LOTE_HOME_CODE_A":
                        mapper[i] = (e, v) => e.DF_LOTE_HOME_CODE_A = v;
                        break;
                    case "DF_LOTE_HOME_CODE_B":
                        mapper[i] = (e, v) => e.DF_LOTE_HOME_CODE_B = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> Index_SKEY;
        private Lazy<Dictionary<int, STRE>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_SCHOOL_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_HOME_GROUP;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_PREVIOUS_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_VISA_SUBCLASS;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_HOME_LANG;
        private Lazy<NullDictionary<int?, IReadOnlyList<STRE>>> Index_ST_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM01;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM02;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM03;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM04;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_NEXT_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_LOTE_HOME_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_DF_LOTE_HOME_CODE_A;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_DF_LOTE_HOME_CODE_B;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STRE by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STRE by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STRE> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STRE> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRE</param>
        /// <returns>Related STRE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRE FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STRE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRE</param>
        /// <param name="Value">Related STRE entity</param>
        /// <returns>True if the related STRE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STRE Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRE</param>
        /// <returns>Related STRE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRE TryFindByTID(int TID)
        {
            STRE value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_SCHOOL_YEAR field
        /// </summary>
        /// <param name="ST_SCHOOL_YEAR">ST_SCHOOL_YEAR value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_SCHOOL_YEAR(string ST_SCHOOL_YEAR)
        {
            return Index_ST_SCHOOL_YEAR.Value[ST_SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find STRE by ST_SCHOOL_YEAR field
        /// </summary>
        /// <param name="ST_SCHOOL_YEAR">ST_SCHOOL_YEAR value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_SCHOOL_YEAR(string ST_SCHOOL_YEAR, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_SCHOOL_YEAR.Value.TryGetValue(ST_SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_SCHOOL_YEAR field
        /// </summary>
        /// <param name="ST_SCHOOL_YEAR">ST_SCHOOL_YEAR value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_SCHOOL_YEAR(string ST_SCHOOL_YEAR)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_SCHOOL_YEAR.Value.TryGetValue(ST_SCHOOL_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_HOME_GROUP field
        /// </summary>
        /// <param name="ST_HOME_GROUP">ST_HOME_GROUP value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_HOME_GROUP(string ST_HOME_GROUP)
        {
            return Index_ST_HOME_GROUP.Value[ST_HOME_GROUP];
        }

        /// <summary>
        /// Attempt to find STRE by ST_HOME_GROUP field
        /// </summary>
        /// <param name="ST_HOME_GROUP">ST_HOME_GROUP value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_HOME_GROUP(string ST_HOME_GROUP, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_HOME_GROUP.Value.TryGetValue(ST_HOME_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_HOME_GROUP field
        /// </summary>
        /// <param name="ST_HOME_GROUP">ST_HOME_GROUP value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_HOME_GROUP(string ST_HOME_GROUP)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_HOME_GROUP.Value.TryGetValue(ST_HOME_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_PREVIOUS_SCHOOL field
        /// </summary>
        /// <param name="ST_PREVIOUS_SCHOOL">ST_PREVIOUS_SCHOOL value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_PREVIOUS_SCHOOL(string ST_PREVIOUS_SCHOOL)
        {
            return Index_ST_PREVIOUS_SCHOOL.Value[ST_PREVIOUS_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STRE by ST_PREVIOUS_SCHOOL field
        /// </summary>
        /// <param name="ST_PREVIOUS_SCHOOL">ST_PREVIOUS_SCHOOL value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_PREVIOUS_SCHOOL(string ST_PREVIOUS_SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_PREVIOUS_SCHOOL.Value.TryGetValue(ST_PREVIOUS_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_PREVIOUS_SCHOOL field
        /// </summary>
        /// <param name="ST_PREVIOUS_SCHOOL">ST_PREVIOUS_SCHOOL value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_PREVIOUS_SCHOOL(string ST_PREVIOUS_SCHOOL)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_PREVIOUS_SCHOOL.Value.TryGetValue(ST_PREVIOUS_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_VISA_SUBCLASS field
        /// </summary>
        /// <param name="ST_VISA_SUBCLASS">ST_VISA_SUBCLASS value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_VISA_SUBCLASS(string ST_VISA_SUBCLASS)
        {
            return Index_ST_VISA_SUBCLASS.Value[ST_VISA_SUBCLASS];
        }

        /// <summary>
        /// Attempt to find STRE by ST_VISA_SUBCLASS field
        /// </summary>
        /// <param name="ST_VISA_SUBCLASS">ST_VISA_SUBCLASS value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_VISA_SUBCLASS(string ST_VISA_SUBCLASS, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_VISA_SUBCLASS.Value.TryGetValue(ST_VISA_SUBCLASS, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_VISA_SUBCLASS field
        /// </summary>
        /// <param name="ST_VISA_SUBCLASS">ST_VISA_SUBCLASS value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_VISA_SUBCLASS(string ST_VISA_SUBCLASS)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_VISA_SUBCLASS.Value.TryGetValue(ST_VISA_SUBCLASS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_HOME_LANG field
        /// </summary>
        /// <param name="ST_HOME_LANG">ST_HOME_LANG value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_HOME_LANG(string ST_HOME_LANG)
        {
            return Index_ST_HOME_LANG.Value[ST_HOME_LANG];
        }

        /// <summary>
        /// Attempt to find STRE by ST_HOME_LANG field
        /// </summary>
        /// <param name="ST_HOME_LANG">ST_HOME_LANG value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_HOME_LANG(string ST_HOME_LANG, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_HOME_LANG.Value.TryGetValue(ST_HOME_LANG, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_HOME_LANG field
        /// </summary>
        /// <param name="ST_HOME_LANG">ST_HOME_LANG value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_HOME_LANG(string ST_HOME_LANG)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_HOME_LANG.Value.TryGetValue(ST_HOME_LANG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_CAMPUS field
        /// </summary>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_CAMPUS(int? ST_CAMPUS)
        {
            return Index_ST_CAMPUS.Value[ST_CAMPUS];
        }

        /// <summary>
        /// Attempt to find STRE by ST_CAMPUS field
        /// </summary>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_CAMPUS(int? ST_CAMPUS, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_CAMPUS.Value.TryGetValue(ST_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_CAMPUS field
        /// </summary>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_CAMPUS(int? ST_CAMPUS)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_CAMPUS.Value.TryGetValue(ST_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by STPT_SCHL_NUM01 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM01">STPT_SCHL_NUM01 value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindBySTPT_SCHL_NUM01(string STPT_SCHL_NUM01)
        {
            return Index_STPT_SCHL_NUM01.Value[STPT_SCHL_NUM01];
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM01 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM01">STPT_SCHL_NUM01 value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPT_SCHL_NUM01(string STPT_SCHL_NUM01, out IReadOnlyList<STRE> Value)
        {
            return Index_STPT_SCHL_NUM01.Value.TryGetValue(STPT_SCHL_NUM01, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM01 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM01">STPT_SCHL_NUM01 value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindBySTPT_SCHL_NUM01(string STPT_SCHL_NUM01)
        {
            IReadOnlyList<STRE> value;
            if (Index_STPT_SCHL_NUM01.Value.TryGetValue(STPT_SCHL_NUM01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by STPT_SCHL_NUM02 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM02">STPT_SCHL_NUM02 value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindBySTPT_SCHL_NUM02(string STPT_SCHL_NUM02)
        {
            return Index_STPT_SCHL_NUM02.Value[STPT_SCHL_NUM02];
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM02 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM02">STPT_SCHL_NUM02 value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPT_SCHL_NUM02(string STPT_SCHL_NUM02, out IReadOnlyList<STRE> Value)
        {
            return Index_STPT_SCHL_NUM02.Value.TryGetValue(STPT_SCHL_NUM02, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM02 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM02">STPT_SCHL_NUM02 value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindBySTPT_SCHL_NUM02(string STPT_SCHL_NUM02)
        {
            IReadOnlyList<STRE> value;
            if (Index_STPT_SCHL_NUM02.Value.TryGetValue(STPT_SCHL_NUM02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by STPT_SCHL_NUM03 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM03">STPT_SCHL_NUM03 value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindBySTPT_SCHL_NUM03(string STPT_SCHL_NUM03)
        {
            return Index_STPT_SCHL_NUM03.Value[STPT_SCHL_NUM03];
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM03 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM03">STPT_SCHL_NUM03 value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPT_SCHL_NUM03(string STPT_SCHL_NUM03, out IReadOnlyList<STRE> Value)
        {
            return Index_STPT_SCHL_NUM03.Value.TryGetValue(STPT_SCHL_NUM03, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM03 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM03">STPT_SCHL_NUM03 value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindBySTPT_SCHL_NUM03(string STPT_SCHL_NUM03)
        {
            IReadOnlyList<STRE> value;
            if (Index_STPT_SCHL_NUM03.Value.TryGetValue(STPT_SCHL_NUM03, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by STPT_SCHL_NUM04 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM04">STPT_SCHL_NUM04 value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindBySTPT_SCHL_NUM04(string STPT_SCHL_NUM04)
        {
            return Index_STPT_SCHL_NUM04.Value[STPT_SCHL_NUM04];
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM04 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM04">STPT_SCHL_NUM04 value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPT_SCHL_NUM04(string STPT_SCHL_NUM04, out IReadOnlyList<STRE> Value)
        {
            return Index_STPT_SCHL_NUM04.Value.TryGetValue(STPT_SCHL_NUM04, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by STPT_SCHL_NUM04 field
        /// </summary>
        /// <param name="STPT_SCHL_NUM04">STPT_SCHL_NUM04 value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindBySTPT_SCHL_NUM04(string STPT_SCHL_NUM04)
        {
            IReadOnlyList<STRE> value;
            if (Index_STPT_SCHL_NUM04.Value.TryGetValue(STPT_SCHL_NUM04, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_NEXT_SCHOOL field
        /// </summary>
        /// <param name="ST_NEXT_SCHOOL">ST_NEXT_SCHOOL value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_NEXT_SCHOOL(string ST_NEXT_SCHOOL)
        {
            return Index_ST_NEXT_SCHOOL.Value[ST_NEXT_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STRE by ST_NEXT_SCHOOL field
        /// </summary>
        /// <param name="ST_NEXT_SCHOOL">ST_NEXT_SCHOOL value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_NEXT_SCHOOL(string ST_NEXT_SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_NEXT_SCHOOL.Value.TryGetValue(ST_NEXT_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_NEXT_SCHOOL field
        /// </summary>
        /// <param name="ST_NEXT_SCHOOL">ST_NEXT_SCHOOL value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_NEXT_SCHOOL(string ST_NEXT_SCHOOL)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_NEXT_SCHOOL.Value.TryGetValue(ST_NEXT_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by ST_LOTE_HOME_CODE field
        /// </summary>
        /// <param name="ST_LOTE_HOME_CODE">ST_LOTE_HOME_CODE value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByST_LOTE_HOME_CODE(string ST_LOTE_HOME_CODE)
        {
            return Index_ST_LOTE_HOME_CODE.Value[ST_LOTE_HOME_CODE];
        }

        /// <summary>
        /// Attempt to find STRE by ST_LOTE_HOME_CODE field
        /// </summary>
        /// <param name="ST_LOTE_HOME_CODE">ST_LOTE_HOME_CODE value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_LOTE_HOME_CODE(string ST_LOTE_HOME_CODE, out IReadOnlyList<STRE> Value)
        {
            return Index_ST_LOTE_HOME_CODE.Value.TryGetValue(ST_LOTE_HOME_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by ST_LOTE_HOME_CODE field
        /// </summary>
        /// <param name="ST_LOTE_HOME_CODE">ST_LOTE_HOME_CODE value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByST_LOTE_HOME_CODE(string ST_LOTE_HOME_CODE)
        {
            IReadOnlyList<STRE> value;
            if (Index_ST_LOTE_HOME_CODE.Value.TryGetValue(ST_LOTE_HOME_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by DF_LOTE_HOME_CODE_A field
        /// </summary>
        /// <param name="DF_LOTE_HOME_CODE_A">DF_LOTE_HOME_CODE_A value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByDF_LOTE_HOME_CODE_A(string DF_LOTE_HOME_CODE_A)
        {
            return Index_DF_LOTE_HOME_CODE_A.Value[DF_LOTE_HOME_CODE_A];
        }

        /// <summary>
        /// Attempt to find STRE by DF_LOTE_HOME_CODE_A field
        /// </summary>
        /// <param name="DF_LOTE_HOME_CODE_A">DF_LOTE_HOME_CODE_A value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDF_LOTE_HOME_CODE_A(string DF_LOTE_HOME_CODE_A, out IReadOnlyList<STRE> Value)
        {
            return Index_DF_LOTE_HOME_CODE_A.Value.TryGetValue(DF_LOTE_HOME_CODE_A, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by DF_LOTE_HOME_CODE_A field
        /// </summary>
        /// <param name="DF_LOTE_HOME_CODE_A">DF_LOTE_HOME_CODE_A value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByDF_LOTE_HOME_CODE_A(string DF_LOTE_HOME_CODE_A)
        {
            IReadOnlyList<STRE> value;
            if (Index_DF_LOTE_HOME_CODE_A.Value.TryGetValue(DF_LOTE_HOME_CODE_A, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRE by DF_LOTE_HOME_CODE_B field
        /// </summary>
        /// <param name="DF_LOTE_HOME_CODE_B">DF_LOTE_HOME_CODE_B value used to find STRE</param>
        /// <returns>List of related STRE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> FindByDF_LOTE_HOME_CODE_B(string DF_LOTE_HOME_CODE_B)
        {
            return Index_DF_LOTE_HOME_CODE_B.Value[DF_LOTE_HOME_CODE_B];
        }

        /// <summary>
        /// Attempt to find STRE by DF_LOTE_HOME_CODE_B field
        /// </summary>
        /// <param name="DF_LOTE_HOME_CODE_B">DF_LOTE_HOME_CODE_B value used to find STRE</param>
        /// <param name="Value">List of related STRE entities</param>
        /// <returns>True if the list of related STRE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDF_LOTE_HOME_CODE_B(string DF_LOTE_HOME_CODE_B, out IReadOnlyList<STRE> Value)
        {
            return Index_DF_LOTE_HOME_CODE_B.Value.TryGetValue(DF_LOTE_HOME_CODE_B, out Value);
        }

        /// <summary>
        /// Attempt to find STRE by DF_LOTE_HOME_CODE_B field
        /// </summary>
        /// <param name="DF_LOTE_HOME_CODE_B">DF_LOTE_HOME_CODE_B value used to find STRE</param>
        /// <returns>List of related STRE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRE> TryFindByDF_LOTE_HOME_CODE_B(string DF_LOTE_HOME_CODE_B)
        {
            IReadOnlyList<STRE> value;
            if (Index_DF_LOTE_HOME_CODE_B.Value.TryGetValue(DF_LOTE_HOME_CODE_B, out value))
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
