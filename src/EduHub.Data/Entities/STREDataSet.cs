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
    /// Student Re-Enrolment Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STREDataSet : EduHubDataSet<STRE>
    {
        /// <inheritdoc />
        public override string Name { get { return "STRE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STREDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DF_LOTE_HOME_CODE_A = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.DF_LOTE_HOME_CODE_A));
            Index_DF_LOTE_HOME_CODE_B = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.DF_LOTE_HOME_CODE_B));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_ST_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_CAMPUS));
            Index_ST_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_HOME_GROUP));
            Index_ST_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_HOME_LANG));
            Index_ST_LOTE_HOME_CODE = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_LOTE_HOME_CODE));
            Index_ST_NEXT_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_NEXT_SCHOOL));
            Index_ST_PREVIOUS_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_PREVIOUS_SCHOOL));
            Index_ST_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_SCHOOL_YEAR));
            Index_ST_VISA_SUBCLASS = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.ST_VISA_SUBCLASS));
            Index_STPT_SCHL_NUM01 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM01));
            Index_STPT_SCHL_NUM02 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM02));
            Index_STPT_SCHL_NUM03 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM03));
            Index_STPT_SCHL_NUM04 = new Lazy<NullDictionary<string, IReadOnlyList<STRE>>>(() => this.ToGroupedNullDictionary(i => i.STPT_SCHL_NUM04));
            Index_TID = new Lazy<Dictionary<int, STRE>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STRE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STRE" /> fields for each CSV column header</returns>
        internal override Action<STRE, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        /// <summary>
        /// Merges <see cref="STRE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STRE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STRE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STRE}"/> of entities</returns>
        internal override IEnumerable<STRE> ApplyDeltaEntities(IEnumerable<STRE> Entities, List<STRE> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_DF_LOTE_HOME_CODE_A;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_DF_LOTE_HOME_CODE_B;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> Index_SKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<STRE>>> Index_ST_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_HOME_GROUP;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_HOME_LANG;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_LOTE_HOME_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_NEXT_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_PREVIOUS_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_SCHOOL_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_ST_VISA_SUBCLASS;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM01;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM02;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM03;
        private Lazy<NullDictionary<string, IReadOnlyList<STRE>>> Index_STPT_SCHL_NUM04;
        private Lazy<Dictionary<int, STRE>> Index_TID;

        #endregion

        #region Index Methods

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

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STRE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STRE](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [ST_ENTRY] datetime NULL,
        [ST_EXIT_DATE] datetime NULL,
        [ST_SCHOOL_YEAR] varchar(4) NULL,
        [ST_HOME_GROUP] varchar(3) NULL,
        [ST_PREVIOUS_SCHOOL] varchar(8) NULL,
        [ST_RESIDENT_STATUS] varchar(1) NULL,
        [ST_PERMANENT_BASIS] varchar(1) NULL,
        [ST_VISA_SUBCLASS] varchar(3) NULL,
        [ST_VISA_STAT_CODE] varchar(4) NULL,
        [ST_SGB_FUNDED] varchar(1) NULL,
        [ST_LIVING_ARR] varchar(1) NULL,
        [ST_FULLTIME] varchar(1) NULL,
        [ST_HOME_LANG] varchar(7) NULL,
        [ST_ED_ALLOW] varchar(1) NULL,
        [ST_YOUTH_ALLOW] varchar(1) NULL,
        [ST_CAMPUS] int NULL,
        [DF_OCCUP_STATUS_A] varchar(1) NULL,
        [DF_OCCUP_STATUS_B] varchar(1) NULL,
        [STPT_SCHL_NUM01] varchar(8) NULL,
        [STPT_SCHL_NUM02] varchar(8) NULL,
        [STPT_SCHL_NUM03] varchar(8) NULL,
        [STPT_SCHL_NUM04] varchar(8) NULL,
        [STPT_SGB_TIME_FRACTION01] float NULL,
        [STPT_SGB_TIME_FRACTION02] float NULL,
        [STPT_SGB_TIME_FRACTION03] float NULL,
        [STPT_SGB_TIME_FRACTION04] float NULL,
        [STPT_ACTUAL_TIME_FRACTION01] float NULL,
        [STPT_ACTUAL_TIME_FRACTION02] float NULL,
        [STPT_ACTUAL_TIME_FRACTION03] float NULL,
        [STPT_ACTUAL_TIME_FRACTION04] float NULL,
        [STPT_ENROLLED01] varchar(1) NULL,
        [STPT_ENROLLED02] varchar(1) NULL,
        [STPT_ENROLLED03] varchar(1) NULL,
        [STPT_ENROLLED04] varchar(1) NULL,
        [ST_NEXT_SCHOOL] varchar(8) NULL,
        [ST_VISA_EXPIRY] datetime NULL,
        [ST_PARENTAL_APPROVAL_NOTE] varchar(200) NULL,
        [ST_LOTE_HOME_CODE] varchar(7) NULL,
        [DF_LOTE_HOME_CODE_A] varchar(7) NULL,
        [DF_LOTE_HOME_CODE_B] varchar(7) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STRE_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_DF_LOTE_HOME_CODE_A] ON [dbo].[STRE]
    (
            [DF_LOTE_HOME_CODE_A] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_DF_LOTE_HOME_CODE_B] ON [dbo].[STRE]
    (
            [DF_LOTE_HOME_CODE_B] ASC
    );
    CREATE CLUSTERED INDEX [STRE_Index_SKEY] ON [dbo].[STRE]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_CAMPUS] ON [dbo].[STRE]
    (
            [ST_CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_HOME_GROUP] ON [dbo].[STRE]
    (
            [ST_HOME_GROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_HOME_LANG] ON [dbo].[STRE]
    (
            [ST_HOME_LANG] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_LOTE_HOME_CODE] ON [dbo].[STRE]
    (
            [ST_LOTE_HOME_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_NEXT_SCHOOL] ON [dbo].[STRE]
    (
            [ST_NEXT_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_PREVIOUS_SCHOOL] ON [dbo].[STRE]
    (
            [ST_PREVIOUS_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_SCHOOL_YEAR] ON [dbo].[STRE]
    (
            [ST_SCHOOL_YEAR] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_ST_VISA_SUBCLASS] ON [dbo].[STRE]
    (
            [ST_VISA_SUBCLASS] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_STPT_SCHL_NUM01] ON [dbo].[STRE]
    (
            [STPT_SCHL_NUM01] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_STPT_SCHL_NUM02] ON [dbo].[STRE]
    (
            [STPT_SCHL_NUM02] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_STPT_SCHL_NUM03] ON [dbo].[STRE]
    (
            [STPT_SCHL_NUM03] ASC
    );
    CREATE NONCLUSTERED INDEX [STRE_Index_STPT_SCHL_NUM04] ON [dbo].[STRE]
    (
            [STPT_SCHL_NUM04] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_DF_LOTE_HOME_CODE_A')
    ALTER INDEX [Index_DF_LOTE_HOME_CODE_A] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_DF_LOTE_HOME_CODE_B')
    ALTER INDEX [Index_DF_LOTE_HOME_CODE_B] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_CAMPUS')
    ALTER INDEX [Index_ST_CAMPUS] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_HOME_GROUP')
    ALTER INDEX [Index_ST_HOME_GROUP] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_HOME_LANG')
    ALTER INDEX [Index_ST_HOME_LANG] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_LOTE_HOME_CODE')
    ALTER INDEX [Index_ST_LOTE_HOME_CODE] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_NEXT_SCHOOL')
    ALTER INDEX [Index_ST_NEXT_SCHOOL] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_PREVIOUS_SCHOOL')
    ALTER INDEX [Index_ST_PREVIOUS_SCHOOL] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_SCHOOL_YEAR')
    ALTER INDEX [Index_ST_SCHOOL_YEAR] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_VISA_SUBCLASS')
    ALTER INDEX [Index_ST_VISA_SUBCLASS] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM01')
    ALTER INDEX [Index_STPT_SCHL_NUM01] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM02')
    ALTER INDEX [Index_STPT_SCHL_NUM02] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM03')
    ALTER INDEX [Index_STPT_SCHL_NUM03] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM04')
    ALTER INDEX [Index_STPT_SCHL_NUM04] ON [dbo].[STRE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STRE] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_DF_LOTE_HOME_CODE_A')
    ALTER INDEX [Index_DF_LOTE_HOME_CODE_A] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_DF_LOTE_HOME_CODE_B')
    ALTER INDEX [Index_DF_LOTE_HOME_CODE_B] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_CAMPUS')
    ALTER INDEX [Index_ST_CAMPUS] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_HOME_GROUP')
    ALTER INDEX [Index_ST_HOME_GROUP] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_HOME_LANG')
    ALTER INDEX [Index_ST_HOME_LANG] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_LOTE_HOME_CODE')
    ALTER INDEX [Index_ST_LOTE_HOME_CODE] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_NEXT_SCHOOL')
    ALTER INDEX [Index_ST_NEXT_SCHOOL] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_PREVIOUS_SCHOOL')
    ALTER INDEX [Index_ST_PREVIOUS_SCHOOL] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_SCHOOL_YEAR')
    ALTER INDEX [Index_ST_SCHOOL_YEAR] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_ST_VISA_SUBCLASS')
    ALTER INDEX [Index_ST_VISA_SUBCLASS] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM01')
    ALTER INDEX [Index_STPT_SCHL_NUM01] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM02')
    ALTER INDEX [Index_STPT_SCHL_NUM02] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM03')
    ALTER INDEX [Index_STPT_SCHL_NUM03] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_STPT_SCHL_NUM04')
    ALTER INDEX [Index_STPT_SCHL_NUM04] ON [dbo].[STRE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRE]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STRE] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STRE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STRE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STRE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STRE] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STRE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STRE data set</returns>
        public override EduHubDataSetDataReader<STRE> GetDataSetDataReader()
        {
            return new STREDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STRE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STRE data set</returns>
        public override EduHubDataSetDataReader<STRE> GetDataSetDataReader(List<STRE> Entities)
        {
            return new STREDataReader(new EduHubDataSetLoadedReader<STRE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STREDataReader : EduHubDataSetDataReader<STRE>
        {
            public STREDataReader(IEduHubDataSetReader<STRE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 45; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // ST_ENTRY
                        return Current.ST_ENTRY;
                    case 3: // ST_EXIT_DATE
                        return Current.ST_EXIT_DATE;
                    case 4: // ST_SCHOOL_YEAR
                        return Current.ST_SCHOOL_YEAR;
                    case 5: // ST_HOME_GROUP
                        return Current.ST_HOME_GROUP;
                    case 6: // ST_PREVIOUS_SCHOOL
                        return Current.ST_PREVIOUS_SCHOOL;
                    case 7: // ST_RESIDENT_STATUS
                        return Current.ST_RESIDENT_STATUS;
                    case 8: // ST_PERMANENT_BASIS
                        return Current.ST_PERMANENT_BASIS;
                    case 9: // ST_VISA_SUBCLASS
                        return Current.ST_VISA_SUBCLASS;
                    case 10: // ST_VISA_STAT_CODE
                        return Current.ST_VISA_STAT_CODE;
                    case 11: // ST_SGB_FUNDED
                        return Current.ST_SGB_FUNDED;
                    case 12: // ST_LIVING_ARR
                        return Current.ST_LIVING_ARR;
                    case 13: // ST_FULLTIME
                        return Current.ST_FULLTIME;
                    case 14: // ST_HOME_LANG
                        return Current.ST_HOME_LANG;
                    case 15: // ST_ED_ALLOW
                        return Current.ST_ED_ALLOW;
                    case 16: // ST_YOUTH_ALLOW
                        return Current.ST_YOUTH_ALLOW;
                    case 17: // ST_CAMPUS
                        return Current.ST_CAMPUS;
                    case 18: // DF_OCCUP_STATUS_A
                        return Current.DF_OCCUP_STATUS_A;
                    case 19: // DF_OCCUP_STATUS_B
                        return Current.DF_OCCUP_STATUS_B;
                    case 20: // STPT_SCHL_NUM01
                        return Current.STPT_SCHL_NUM01;
                    case 21: // STPT_SCHL_NUM02
                        return Current.STPT_SCHL_NUM02;
                    case 22: // STPT_SCHL_NUM03
                        return Current.STPT_SCHL_NUM03;
                    case 23: // STPT_SCHL_NUM04
                        return Current.STPT_SCHL_NUM04;
                    case 24: // STPT_SGB_TIME_FRACTION01
                        return Current.STPT_SGB_TIME_FRACTION01;
                    case 25: // STPT_SGB_TIME_FRACTION02
                        return Current.STPT_SGB_TIME_FRACTION02;
                    case 26: // STPT_SGB_TIME_FRACTION03
                        return Current.STPT_SGB_TIME_FRACTION03;
                    case 27: // STPT_SGB_TIME_FRACTION04
                        return Current.STPT_SGB_TIME_FRACTION04;
                    case 28: // STPT_ACTUAL_TIME_FRACTION01
                        return Current.STPT_ACTUAL_TIME_FRACTION01;
                    case 29: // STPT_ACTUAL_TIME_FRACTION02
                        return Current.STPT_ACTUAL_TIME_FRACTION02;
                    case 30: // STPT_ACTUAL_TIME_FRACTION03
                        return Current.STPT_ACTUAL_TIME_FRACTION03;
                    case 31: // STPT_ACTUAL_TIME_FRACTION04
                        return Current.STPT_ACTUAL_TIME_FRACTION04;
                    case 32: // STPT_ENROLLED01
                        return Current.STPT_ENROLLED01;
                    case 33: // STPT_ENROLLED02
                        return Current.STPT_ENROLLED02;
                    case 34: // STPT_ENROLLED03
                        return Current.STPT_ENROLLED03;
                    case 35: // STPT_ENROLLED04
                        return Current.STPT_ENROLLED04;
                    case 36: // ST_NEXT_SCHOOL
                        return Current.ST_NEXT_SCHOOL;
                    case 37: // ST_VISA_EXPIRY
                        return Current.ST_VISA_EXPIRY;
                    case 38: // ST_PARENTAL_APPROVAL_NOTE
                        return Current.ST_PARENTAL_APPROVAL_NOTE;
                    case 39: // ST_LOTE_HOME_CODE
                        return Current.ST_LOTE_HOME_CODE;
                    case 40: // DF_LOTE_HOME_CODE_A
                        return Current.DF_LOTE_HOME_CODE_A;
                    case 41: // DF_LOTE_HOME_CODE_B
                        return Current.DF_LOTE_HOME_CODE_B;
                    case 42: // LW_TIME
                        return Current.LW_TIME;
                    case 43: // LW_DATE
                        return Current.LW_DATE;
                    case 44: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ST_ENTRY
                        return Current.ST_ENTRY == null;
                    case 3: // ST_EXIT_DATE
                        return Current.ST_EXIT_DATE == null;
                    case 4: // ST_SCHOOL_YEAR
                        return Current.ST_SCHOOL_YEAR == null;
                    case 5: // ST_HOME_GROUP
                        return Current.ST_HOME_GROUP == null;
                    case 6: // ST_PREVIOUS_SCHOOL
                        return Current.ST_PREVIOUS_SCHOOL == null;
                    case 7: // ST_RESIDENT_STATUS
                        return Current.ST_RESIDENT_STATUS == null;
                    case 8: // ST_PERMANENT_BASIS
                        return Current.ST_PERMANENT_BASIS == null;
                    case 9: // ST_VISA_SUBCLASS
                        return Current.ST_VISA_SUBCLASS == null;
                    case 10: // ST_VISA_STAT_CODE
                        return Current.ST_VISA_STAT_CODE == null;
                    case 11: // ST_SGB_FUNDED
                        return Current.ST_SGB_FUNDED == null;
                    case 12: // ST_LIVING_ARR
                        return Current.ST_LIVING_ARR == null;
                    case 13: // ST_FULLTIME
                        return Current.ST_FULLTIME == null;
                    case 14: // ST_HOME_LANG
                        return Current.ST_HOME_LANG == null;
                    case 15: // ST_ED_ALLOW
                        return Current.ST_ED_ALLOW == null;
                    case 16: // ST_YOUTH_ALLOW
                        return Current.ST_YOUTH_ALLOW == null;
                    case 17: // ST_CAMPUS
                        return Current.ST_CAMPUS == null;
                    case 18: // DF_OCCUP_STATUS_A
                        return Current.DF_OCCUP_STATUS_A == null;
                    case 19: // DF_OCCUP_STATUS_B
                        return Current.DF_OCCUP_STATUS_B == null;
                    case 20: // STPT_SCHL_NUM01
                        return Current.STPT_SCHL_NUM01 == null;
                    case 21: // STPT_SCHL_NUM02
                        return Current.STPT_SCHL_NUM02 == null;
                    case 22: // STPT_SCHL_NUM03
                        return Current.STPT_SCHL_NUM03 == null;
                    case 23: // STPT_SCHL_NUM04
                        return Current.STPT_SCHL_NUM04 == null;
                    case 24: // STPT_SGB_TIME_FRACTION01
                        return Current.STPT_SGB_TIME_FRACTION01 == null;
                    case 25: // STPT_SGB_TIME_FRACTION02
                        return Current.STPT_SGB_TIME_FRACTION02 == null;
                    case 26: // STPT_SGB_TIME_FRACTION03
                        return Current.STPT_SGB_TIME_FRACTION03 == null;
                    case 27: // STPT_SGB_TIME_FRACTION04
                        return Current.STPT_SGB_TIME_FRACTION04 == null;
                    case 28: // STPT_ACTUAL_TIME_FRACTION01
                        return Current.STPT_ACTUAL_TIME_FRACTION01 == null;
                    case 29: // STPT_ACTUAL_TIME_FRACTION02
                        return Current.STPT_ACTUAL_TIME_FRACTION02 == null;
                    case 30: // STPT_ACTUAL_TIME_FRACTION03
                        return Current.STPT_ACTUAL_TIME_FRACTION03 == null;
                    case 31: // STPT_ACTUAL_TIME_FRACTION04
                        return Current.STPT_ACTUAL_TIME_FRACTION04 == null;
                    case 32: // STPT_ENROLLED01
                        return Current.STPT_ENROLLED01 == null;
                    case 33: // STPT_ENROLLED02
                        return Current.STPT_ENROLLED02 == null;
                    case 34: // STPT_ENROLLED03
                        return Current.STPT_ENROLLED03 == null;
                    case 35: // STPT_ENROLLED04
                        return Current.STPT_ENROLLED04 == null;
                    case 36: // ST_NEXT_SCHOOL
                        return Current.ST_NEXT_SCHOOL == null;
                    case 37: // ST_VISA_EXPIRY
                        return Current.ST_VISA_EXPIRY == null;
                    case 38: // ST_PARENTAL_APPROVAL_NOTE
                        return Current.ST_PARENTAL_APPROVAL_NOTE == null;
                    case 39: // ST_LOTE_HOME_CODE
                        return Current.ST_LOTE_HOME_CODE == null;
                    case 40: // DF_LOTE_HOME_CODE_A
                        return Current.DF_LOTE_HOME_CODE_A == null;
                    case 41: // DF_LOTE_HOME_CODE_B
                        return Current.DF_LOTE_HOME_CODE_B == null;
                    case 42: // LW_TIME
                        return Current.LW_TIME == null;
                    case 43: // LW_DATE
                        return Current.LW_DATE == null;
                    case 44: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // ST_ENTRY
                        return "ST_ENTRY";
                    case 3: // ST_EXIT_DATE
                        return "ST_EXIT_DATE";
                    case 4: // ST_SCHOOL_YEAR
                        return "ST_SCHOOL_YEAR";
                    case 5: // ST_HOME_GROUP
                        return "ST_HOME_GROUP";
                    case 6: // ST_PREVIOUS_SCHOOL
                        return "ST_PREVIOUS_SCHOOL";
                    case 7: // ST_RESIDENT_STATUS
                        return "ST_RESIDENT_STATUS";
                    case 8: // ST_PERMANENT_BASIS
                        return "ST_PERMANENT_BASIS";
                    case 9: // ST_VISA_SUBCLASS
                        return "ST_VISA_SUBCLASS";
                    case 10: // ST_VISA_STAT_CODE
                        return "ST_VISA_STAT_CODE";
                    case 11: // ST_SGB_FUNDED
                        return "ST_SGB_FUNDED";
                    case 12: // ST_LIVING_ARR
                        return "ST_LIVING_ARR";
                    case 13: // ST_FULLTIME
                        return "ST_FULLTIME";
                    case 14: // ST_HOME_LANG
                        return "ST_HOME_LANG";
                    case 15: // ST_ED_ALLOW
                        return "ST_ED_ALLOW";
                    case 16: // ST_YOUTH_ALLOW
                        return "ST_YOUTH_ALLOW";
                    case 17: // ST_CAMPUS
                        return "ST_CAMPUS";
                    case 18: // DF_OCCUP_STATUS_A
                        return "DF_OCCUP_STATUS_A";
                    case 19: // DF_OCCUP_STATUS_B
                        return "DF_OCCUP_STATUS_B";
                    case 20: // STPT_SCHL_NUM01
                        return "STPT_SCHL_NUM01";
                    case 21: // STPT_SCHL_NUM02
                        return "STPT_SCHL_NUM02";
                    case 22: // STPT_SCHL_NUM03
                        return "STPT_SCHL_NUM03";
                    case 23: // STPT_SCHL_NUM04
                        return "STPT_SCHL_NUM04";
                    case 24: // STPT_SGB_TIME_FRACTION01
                        return "STPT_SGB_TIME_FRACTION01";
                    case 25: // STPT_SGB_TIME_FRACTION02
                        return "STPT_SGB_TIME_FRACTION02";
                    case 26: // STPT_SGB_TIME_FRACTION03
                        return "STPT_SGB_TIME_FRACTION03";
                    case 27: // STPT_SGB_TIME_FRACTION04
                        return "STPT_SGB_TIME_FRACTION04";
                    case 28: // STPT_ACTUAL_TIME_FRACTION01
                        return "STPT_ACTUAL_TIME_FRACTION01";
                    case 29: // STPT_ACTUAL_TIME_FRACTION02
                        return "STPT_ACTUAL_TIME_FRACTION02";
                    case 30: // STPT_ACTUAL_TIME_FRACTION03
                        return "STPT_ACTUAL_TIME_FRACTION03";
                    case 31: // STPT_ACTUAL_TIME_FRACTION04
                        return "STPT_ACTUAL_TIME_FRACTION04";
                    case 32: // STPT_ENROLLED01
                        return "STPT_ENROLLED01";
                    case 33: // STPT_ENROLLED02
                        return "STPT_ENROLLED02";
                    case 34: // STPT_ENROLLED03
                        return "STPT_ENROLLED03";
                    case 35: // STPT_ENROLLED04
                        return "STPT_ENROLLED04";
                    case 36: // ST_NEXT_SCHOOL
                        return "ST_NEXT_SCHOOL";
                    case 37: // ST_VISA_EXPIRY
                        return "ST_VISA_EXPIRY";
                    case 38: // ST_PARENTAL_APPROVAL_NOTE
                        return "ST_PARENTAL_APPROVAL_NOTE";
                    case 39: // ST_LOTE_HOME_CODE
                        return "ST_LOTE_HOME_CODE";
                    case 40: // DF_LOTE_HOME_CODE_A
                        return "DF_LOTE_HOME_CODE_A";
                    case 41: // DF_LOTE_HOME_CODE_B
                        return "DF_LOTE_HOME_CODE_B";
                    case 42: // LW_TIME
                        return "LW_TIME";
                    case 43: // LW_DATE
                        return "LW_DATE";
                    case 44: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "SKEY":
                        return 1;
                    case "ST_ENTRY":
                        return 2;
                    case "ST_EXIT_DATE":
                        return 3;
                    case "ST_SCHOOL_YEAR":
                        return 4;
                    case "ST_HOME_GROUP":
                        return 5;
                    case "ST_PREVIOUS_SCHOOL":
                        return 6;
                    case "ST_RESIDENT_STATUS":
                        return 7;
                    case "ST_PERMANENT_BASIS":
                        return 8;
                    case "ST_VISA_SUBCLASS":
                        return 9;
                    case "ST_VISA_STAT_CODE":
                        return 10;
                    case "ST_SGB_FUNDED":
                        return 11;
                    case "ST_LIVING_ARR":
                        return 12;
                    case "ST_FULLTIME":
                        return 13;
                    case "ST_HOME_LANG":
                        return 14;
                    case "ST_ED_ALLOW":
                        return 15;
                    case "ST_YOUTH_ALLOW":
                        return 16;
                    case "ST_CAMPUS":
                        return 17;
                    case "DF_OCCUP_STATUS_A":
                        return 18;
                    case "DF_OCCUP_STATUS_B":
                        return 19;
                    case "STPT_SCHL_NUM01":
                        return 20;
                    case "STPT_SCHL_NUM02":
                        return 21;
                    case "STPT_SCHL_NUM03":
                        return 22;
                    case "STPT_SCHL_NUM04":
                        return 23;
                    case "STPT_SGB_TIME_FRACTION01":
                        return 24;
                    case "STPT_SGB_TIME_FRACTION02":
                        return 25;
                    case "STPT_SGB_TIME_FRACTION03":
                        return 26;
                    case "STPT_SGB_TIME_FRACTION04":
                        return 27;
                    case "STPT_ACTUAL_TIME_FRACTION01":
                        return 28;
                    case "STPT_ACTUAL_TIME_FRACTION02":
                        return 29;
                    case "STPT_ACTUAL_TIME_FRACTION03":
                        return 30;
                    case "STPT_ACTUAL_TIME_FRACTION04":
                        return 31;
                    case "STPT_ENROLLED01":
                        return 32;
                    case "STPT_ENROLLED02":
                        return 33;
                    case "STPT_ENROLLED03":
                        return 34;
                    case "STPT_ENROLLED04":
                        return 35;
                    case "ST_NEXT_SCHOOL":
                        return 36;
                    case "ST_VISA_EXPIRY":
                        return 37;
                    case "ST_PARENTAL_APPROVAL_NOTE":
                        return 38;
                    case "ST_LOTE_HOME_CODE":
                        return 39;
                    case "DF_LOTE_HOME_CODE_A":
                        return 40;
                    case "DF_LOTE_HOME_CODE_B":
                        return 41;
                    case "LW_TIME":
                        return 42;
                    case "LW_DATE":
                        return 43;
                    case "LW_USER":
                        return 44;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
