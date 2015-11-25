using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medical Conditions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMCDataSet : SetBase<SMC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMC"; } }

        internal SMCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SMCKEY = new Lazy<Dictionary<int, SMC>>(() => this.ToDictionary(i => i.SMCKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_MED_CONDITION = new Lazy<NullDictionary<string, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.MED_CONDITION));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMC" /> fields for each CSV column header</returns>
        protected override Action<SMC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SMCKEY":
                        mapper[i] = (e, v) => e.SMCKEY = int.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "MED_CONDITION":
                        mapper[i] = (e, v) => e.MED_CONDITION = v;
                        break;
                    case "SYMPTOMS":
                        mapper[i] = (e, v) => e.SYMPTOMS = v;
                        break;
                    case "SMC_COMMENT":
                        mapper[i] = (e, v) => e.SMC_COMMENT = v;
                        break;
                    case "REGULAR_MEDICATION":
                        mapper[i] = (e, v) => e.REGULAR_MEDICATION = v;
                        break;
                    case "REGULAR_POISON_RATING":
                        mapper[i] = (e, v) => e.REGULAR_POISON_RATING = v;
                        break;
                    case "REGULAR_DOSAGE":
                        mapper[i] = (e, v) => e.REGULAR_DOSAGE = v;
                        break;
                    case "REGULAR_FREQUENCY":
                        mapper[i] = (e, v) => e.REGULAR_FREQUENCY = v;
                        break;
                    case "REGULAR_DOSAGE_TIME":
                        mapper[i] = (e, v) => e.REGULAR_DOSAGE_TIME = v;
                        break;
                    case "REGULAR_MEDICATION_LOCAT":
                        mapper[i] = (e, v) => e.REGULAR_MEDICATION_LOCAT = v;
                        break;
                    case "REGULAR_ADMIN_BY":
                        mapper[i] = (e, v) => e.REGULAR_ADMIN_BY = v;
                        break;
                    case "REMINDER":
                        mapper[i] = (e, v) => e.REMINDER = v;
                        break;
                    case "INFORM_DOCTOR":
                        mapper[i] = (e, v) => e.INFORM_DOCTOR = v;
                        break;
                    case "INFORM_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.INFORM_EMERG_CONTACT = v;
                        break;
                    case "ADMINISTER_MEDICATION":
                        mapper[i] = (e, v) => e.ADMINISTER_MEDICATION = v;
                        break;
                    case "OTHER_MEDICAL_ACTION":
                        mapper[i] = (e, v) => e.OTHER_MEDICAL_ACTION = v;
                        break;
                    case "SMC_ACTION":
                        mapper[i] = (e, v) => e.SMC_ACTION = v;
                        break;
                    case "AD_HOC_MEDICATION":
                        mapper[i] = (e, v) => e.AD_HOC_MEDICATION = v;
                        break;
                    case "AD_HOC_POISON_RATING":
                        mapper[i] = (e, v) => e.AD_HOC_POISON_RATING = v;
                        break;
                    case "AD_HOC_DOSAGE":
                        mapper[i] = (e, v) => e.AD_HOC_DOSAGE = v;
                        break;
                    case "AD_HOC_FREQUENCY":
                        mapper[i] = (e, v) => e.AD_HOC_FREQUENCY = v;
                        break;
                    case "AD_HOC_MEDICATION_LOCAT":
                        mapper[i] = (e, v) => e.AD_HOC_MEDICATION_LOCAT = v;
                        break;
                    case "AD_HOC_ADMIN_BY":
                        mapper[i] = (e, v) => e.AD_HOC_ADMIN_BY = v;
                        break;
                    case "HOME_MEDICATION":
                        mapper[i] = (e, v) => e.HOME_MEDICATION = v;
                        break;
                    case "ASTHMA_WHEEZE":
                        mapper[i] = (e, v) => e.ASTHMA_WHEEZE = v;
                        break;
                    case "ASTHMA_COUGH":
                        mapper[i] = (e, v) => e.ASTHMA_COUGH = v;
                        break;
                    case "ASTHMA_DIFFBRE":
                        mapper[i] = (e, v) => e.ASTHMA_DIFFBRE = v;
                        break;
                    case "ASTHMA_TGTCHES":
                        mapper[i] = (e, v) => e.ASTHMA_TGTCHES = v;
                        break;
                    case "ASTHMA_SYMTEXE":
                        mapper[i] = (e, v) => e.ASTHMA_SYMTEXE = v;
                        break;
                    case "ASTHMA_MGT_PLAN":
                        mapper[i] = (e, v) => e.ASTHMA_MGT_PLAN = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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

        private Lazy<Dictionary<int, SMC>> Index_SMCKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SMC>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SMC>>> Index_STUDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<SMC>>> Index_MED_CONDITION;
        private Lazy<NullDictionary<int?, IReadOnlyList<SMC>>> Index_CAMPUS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC FindBySMCKEY(int SMCKEY)
        {
            return Index_SMCKEY.Value[SMCKEY];
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <param name="Value">Related SMC entity</param>
        /// <returns>True if the related SMC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMCKEY(int SMCKEY, out SMC Value)
        {
            return Index_SMCKEY.Value.TryGetValue(SMCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC TryFindBySMCKEY(int SMCKEY)
        {
            SMC value;
            if (Index_SMCKEY.Value.TryGetValue(SMCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SMC> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SMC> value;
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
        /// Find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<SMC> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<SMC> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByMED_CONDITION(string MED_CONDITION)
        {
            return Index_MED_CONDITION.Value[MED_CONDITION];
        }

        /// <summary>
        /// Attempt to find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMED_CONDITION(string MED_CONDITION, out IReadOnlyList<SMC> Value)
        {
            return Index_MED_CONDITION.Value.TryGetValue(MED_CONDITION, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByMED_CONDITION(string MED_CONDITION)
        {
            IReadOnlyList<SMC> value;
            if (Index_MED_CONDITION.Value.TryGetValue(MED_CONDITION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SMC> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SMC> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
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
