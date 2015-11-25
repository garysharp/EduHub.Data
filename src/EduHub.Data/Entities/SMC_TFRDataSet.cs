using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMC Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMC_TFRDataSet : SetBase<SMC_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMC_TFR"; } }

        internal SMC_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<SMC_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, SMC_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMC_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMC_TFR" /> fields for each CSV column header</returns>
        protected override Action<SMC_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMC_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "SMC_TRANS_ID":
                        mapper[i] = (e, v) => e.SMC_TRANS_ID = v;
                        break;
                    case "SMCKEY":
                        mapper[i] = (e, v) => e.SMCKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "CONDITION_EXISTS":
                        mapper[i] = (e, v) => e.CONDITION_EXISTS = v;
                        break;
                    case "STUDENT_NEW":
                        mapper[i] = (e, v) => e.STUDENT_NEW = v;
                        break;
                    case "MED_CONDITION":
                        mapper[i] = (e, v) => e.MED_CONDITION = v;
                        break;
                    case "MED_CONDITION_NEW":
                        mapper[i] = (e, v) => e.MED_CONDITION_NEW = v;
                        break;
                    case "MED_CONDITION_ACT":
                        mapper[i] = (e, v) => e.MED_CONDITION_ACT = v;
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
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "KCM_TRANS_ID":
                        mapper[i] = (e, v) => e.KCM_TRANS_ID = v;
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
        /// Merges <see cref="SMC_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SMC_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SMC_TFR" /> items to added or update the base <see cref="SMC_TFR" /> items</param>
        /// <returns>A merged list of <see cref="SMC_TFR" /> items</returns>
        protected override List<SMC_TFR> ApplyDeltaItems(List<SMC_TFR> Items, List<SMC_TFR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SMC_TFR deltaItem in DeltaItems)
            {
                int index;

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

        private Lazy<Dictionary<string, IReadOnlyList<SMC_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, SMC_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMC_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find SMC_TFR</param>
        /// <returns>List of related SMC_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find SMC_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find SMC_TFR</param>
        /// <param name="Value">List of related SMC_TFR entities</param>
        /// <returns>True if the list of related SMC_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<SMC_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find SMC_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find SMC_TFR</param>
        /// <returns>List of related SMC_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<SMC_TFR> value;
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
        /// Find SMC_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMC_TFR</param>
        /// <returns>Related SMC_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMC_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMC_TFR</param>
        /// <param name="Value">Related SMC_TFR entity</param>
        /// <returns>True if the related SMC_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMC_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMC_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMC_TFR</param>
        /// <returns>Related SMC_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC_TFR TryFindByTID(int TID)
        {
            SMC_TFR value;
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
