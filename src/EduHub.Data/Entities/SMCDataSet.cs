﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medical Conditions Data Set
    /// </summary>
    public sealed partial class SMCDataSet : SetBase<SMC>
    {
        private Lazy<Dictionary<int, SMC>> SMCKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<SMCD>>> SMCD_SMCDKEYForeignIndex;

        internal SMCDataSet(EduHubContext Context)
            : base(Context)
        {
            SMCKEYIndex = new Lazy<Dictionary<int, SMC>>(() => this.ToDictionary(e => e.SMCKEY));

            SMCD_SMCDKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SMCD>>>(() =>
                    Context.SMCD
                          .Where(e => e.SMCDKEY != null)
                          .GroupBy(e => e.SMCDKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMCD>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMC"; } }

        /// <summary>
        /// Find SMC by SMCKEY key field
        /// </summary>
        /// <param name="Key">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SMCKEY value didn't match any SMC entities</exception>
        public SMC FindBySMCKEY(int Key)
        {
            SMC result;
            if (SMCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY key field
        /// </summary>
        /// <param name="Key">SMCKEY value used to find SMC</param>
        /// <param name="Value">Related SMC entity</param>
        /// <returns>True if the SMC entity is found</returns>
        public bool TryFindBySMCKEY(int Key, out SMC Value)
        {
            return SMCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY key field
        /// </summary>
        /// <param name="Key">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity, or null if not found</returns>
        public SMC TryFindBySMCKEY(int Key)
        {
            SMC result;
            if (SMCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SMCD (Student Medication Doses) entities by [SMCD.SMCDKEY]-&gt;[SMC.SMCKEY]
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMCD entities</param>
        /// <returns>A list of related SMCD entities</returns>
        public IReadOnlyList<SMCD> FindSMCDBySMCDKEY(int SMCKEY)
        {
            IReadOnlyList<SMCD> result;
            if (SMCD_SMCDKEYForeignIndex.Value.TryGetValue(SMCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SMCD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMCD entities by [SMCD.SMCDKEY]-&gt;[SMC.SMCKEY]
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMCD entities</param>
        /// <param name="Value">A list of related SMCD entities</param>
        /// <returns>True if any SMCD entities are found</returns>
        public bool TryFindSMCDBySMCDKEY(int SMCKEY, out IReadOnlyList<SMCD> Value)
        {
            return SMCD_SMCDKEYForeignIndex.Value.TryGetValue(SMCKEY, out Value);
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
    }
}
