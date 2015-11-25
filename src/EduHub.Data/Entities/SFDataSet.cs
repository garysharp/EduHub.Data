using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFDataSet : SetBase<SF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SF"; } }

        internal SFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SFKEY = new Lazy<Dictionary<string, SF>>(() => this.ToDictionary(i => i.SFKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_HOMEKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.HOMEKEY));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_FACULTY01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY01));
            Index_FACULTY02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY02));
            Index_FACULTY03 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY03));
            Index_FACULTY04 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY04));
            Index_SUBJECT01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT01));
            Index_SUBJECT02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT02));
            Index_SUBJECT03 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT03));
            Index_SUBJECT04 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT04));
            Index_SUBJECT05 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT05));
            Index_SUBJECT06 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT06));
            Index_SUBJECT07 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT07));
            Index_SUBJECT08 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT08));
            Index_SUBJECT09 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT09));
            Index_SUBJECT10 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT10));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_HOUSE = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.HOUSE));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_OTHER_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.OTHER_LOCATION));
            Index_POS_CODE_A = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.POS_CODE_A));
            Index_POS_CODE_B = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.POS_CODE_B));
            Index_MAJORA = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAJORA));
            Index_MAJORB = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAJORB));
            Index_MAJORC = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAJORC));
            Index_RELIGION = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.RELIGION));
            Index_BIRTH_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY));
            Index_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.LANG01));
            Index_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.LANG02));
            Index_EMERG_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG01));
            Index_EMERG_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG02));
            Index_DEBTOR_ID = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.DEBTOR_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SF" /> fields for each CSV column header</returns>
        protected override Action<SF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SFKEY":
                        mapper[i] = (e, v) => e.SFKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
                    case "PREVIOUS_NAME":
                        mapper[i] = (e, v) => e.PREVIOUS_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "VIT_NO":
                        mapper[i] = (e, v) => e.VIT_NO = v;
                        break;
                    case "START":
                        mapper[i] = (e, v) => e.START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FINISH":
                        mapper[i] = (e, v) => e.FINISH = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FACULTY01":
                        mapper[i] = (e, v) => e.FACULTY01 = v;
                        break;
                    case "FACULTY02":
                        mapper[i] = (e, v) => e.FACULTY02 = v;
                        break;
                    case "FACULTY03":
                        mapper[i] = (e, v) => e.FACULTY03 = v;
                        break;
                    case "FACULTY04":
                        mapper[i] = (e, v) => e.FACULTY04 = v;
                        break;
                    case "SUBJECT01":
                        mapper[i] = (e, v) => e.SUBJECT01 = v;
                        break;
                    case "SUBJECT02":
                        mapper[i] = (e, v) => e.SUBJECT02 = v;
                        break;
                    case "SUBJECT03":
                        mapper[i] = (e, v) => e.SUBJECT03 = v;
                        break;
                    case "SUBJECT04":
                        mapper[i] = (e, v) => e.SUBJECT04 = v;
                        break;
                    case "SUBJECT05":
                        mapper[i] = (e, v) => e.SUBJECT05 = v;
                        break;
                    case "SUBJECT06":
                        mapper[i] = (e, v) => e.SUBJECT06 = v;
                        break;
                    case "SUBJECT07":
                        mapper[i] = (e, v) => e.SUBJECT07 = v;
                        break;
                    case "SUBJECT08":
                        mapper[i] = (e, v) => e.SUBJECT08 = v;
                        break;
                    case "SUBJECT09":
                        mapper[i] = (e, v) => e.SUBJECT09 = v;
                        break;
                    case "SUBJECT10":
                        mapper[i] = (e, v) => e.SUBJECT10 = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AVAILABILITY01":
                        mapper[i] = (e, v) => e.AVAILABILITY01 = v;
                        break;
                    case "AVAILABILITY02":
                        mapper[i] = (e, v) => e.AVAILABILITY02 = v;
                        break;
                    case "AVAILABILITY03":
                        mapper[i] = (e, v) => e.AVAILABILITY03 = v;
                        break;
                    case "AVAILABILITY04":
                        mapper[i] = (e, v) => e.AVAILABILITY04 = v;
                        break;
                    case "AVAILABILITY05":
                        mapper[i] = (e, v) => e.AVAILABILITY05 = v;
                        break;
                    case "RANK":
                        mapper[i] = (e, v) => e.RANK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "OTHER_LOCATION":
                        mapper[i] = (e, v) => e.OTHER_LOCATION = v;
                        break;
                    case "CAR_REGO":
                        mapper[i] = (e, v) => e.CAR_REGO = v;
                        break;
                    case "STAFF_TYPE":
                        mapper[i] = (e, v) => e.STAFF_TYPE = v;
                        break;
                    case "POS_CODE_A":
                        mapper[i] = (e, v) => e.POS_CODE_A = v;
                        break;
                    case "POS_CODE_B":
                        mapper[i] = (e, v) => e.POS_CODE_B = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STAFF_STATUS":
                        mapper[i] = (e, v) => e.STAFF_STATUS = v;
                        break;
                    case "MAJORA":
                        mapper[i] = (e, v) => e.MAJORA = v;
                        break;
                    case "MAJORB":
                        mapper[i] = (e, v) => e.MAJORB = v;
                        break;
                    case "MAJORC":
                        mapper[i] = (e, v) => e.MAJORC = v;
                        break;
                    case "SKILL_QUALIFICATION":
                        mapper[i] = (e, v) => e.SKILL_QUALIFICATION = v;
                        break;
                    case "PAYROLL_REC_NO":
                        mapper[i] = (e, v) => e.PAYROLL_REC_NO = v;
                        break;
                    case "PAYROLL_CLASS":
                        mapper[i] = (e, v) => e.PAYROLL_CLASS = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
                        break;
                    case "POLICE_CLEARANCE":
                        mapper[i] = (e, v) => e.POLICE_CLEARANCE = v;
                        break;
                    case "CLEARANCE_DATE":
                        mapper[i] = (e, v) => e.CLEARANCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF_PIC":
                        mapper[i] = (e, v) => e.STAFF_PIC = null; // eduHub is not encoding byte arrays
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
                    case "AVAILABLE":
                        mapper[i] = (e, v) => e.AVAILABLE = null; // eduHub is not encoding byte arrays
                        break;
                    case "MAX_EXTRAS":
                        mapper[i] = (e, v) => e.MAX_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACC_EXTRAS":
                        mapper[i] = (e, v) => e.ACC_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK_EXTRAS":
                        mapper[i] = (e, v) => e.WEEK_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LAST_EXTRAS":
                        mapper[i] = (e, v) => e.LAST_EXTRAS = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "LANG01":
                        mapper[i] = (e, v) => e.LANG01 = v;
                        break;
                    case "LANG02":
                        mapper[i] = (e, v) => e.LANG02 = v;
                        break;
                    case "INTERPRETER01":
                        mapper[i] = (e, v) => e.INTERPRETER01 = v;
                        break;
                    case "INTERPRETER02":
                        mapper[i] = (e, v) => e.INTERPRETER02 = v;
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
                    case "GROUP_AVAILABILITY":
                        mapper[i] = (e, v) => e.GROUP_AVAILABILITY = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HRMS_UPDATE":
                        mapper[i] = (e, v) => e.HRMS_UPDATE = v;
                        break;
                    case "HRMS_DATETIME":
                        mapper[i] = (e, v) => e.HRMS_DATETIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEBTOR_ID":
                        mapper[i] = (e, v) => e.DEBTOR_ID = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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

        private Lazy<Dictionary<string, SF>> Index_SFKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SF>>> Index_LW_DATE;
        private Lazy<NullDictionary<int?, IReadOnlyList<SF>>> Index_HOMEKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<SF>>> Index_MAILKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY02;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY03;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY04;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT02;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT03;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT04;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT05;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT06;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT07;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT08;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT09;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SUBJECT10;
        private Lazy<NullDictionary<int?, IReadOnlyList<SF>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_HOUSE;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_OTHER_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_POS_CODE_A;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_POS_CODE_B;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_MAJORA;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_MAJORB;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_MAJORC;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_RELIGION;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_BIRTH_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_EMERG_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_EMERG_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_DEBTOR_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SF by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SF</param>
        /// <returns>Related SF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SF FindBySFKEY(string SFKEY)
        {
            return Index_SFKEY.Value[SFKEY];
        }

        /// <summary>
        /// Attempt to find SF by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SF</param>
        /// <param name="Value">Related SF entity</param>
        /// <returns>True if the related SF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFKEY(string SFKEY, out SF Value)
        {
            return Index_SFKEY.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SF</param>
        /// <returns>Related SF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SF TryFindBySFKEY(string SFKEY)
        {
            SF value;
            if (Index_SFKEY.Value.TryGetValue(SFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SF by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SF> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SF by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SF> value;
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
        /// Find SF by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByHOMEKEY(int? HOMEKEY)
        {
            return Index_HOMEKEY.Value[HOMEKEY];
        }

        /// <summary>
        /// Attempt to find SF by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOMEKEY(int? HOMEKEY, out IReadOnlyList<SF> Value)
        {
            return Index_HOMEKEY.Value.TryGetValue(HOMEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SF by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByHOMEKEY(int? HOMEKEY)
        {
            IReadOnlyList<SF> value;
            if (Index_HOMEKEY.Value.TryGetValue(HOMEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByMAILKEY(int? MAILKEY)
        {
            return Index_MAILKEY.Value[MAILKEY];
        }

        /// <summary>
        /// Attempt to find SF by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILKEY(int? MAILKEY, out IReadOnlyList<SF> Value)
        {
            return Index_MAILKEY.Value.TryGetValue(MAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SF by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByMAILKEY(int? MAILKEY)
        {
            IReadOnlyList<SF> value;
            if (Index_MAILKEY.Value.TryGetValue(MAILKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by FACULTY01 field
        /// </summary>
        /// <param name="FACULTY01">FACULTY01 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByFACULTY01(string FACULTY01)
        {
            return Index_FACULTY01.Value[FACULTY01];
        }

        /// <summary>
        /// Attempt to find SF by FACULTY01 field
        /// </summary>
        /// <param name="FACULTY01">FACULTY01 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY01(string FACULTY01, out IReadOnlyList<SF> Value)
        {
            return Index_FACULTY01.Value.TryGetValue(FACULTY01, out Value);
        }

        /// <summary>
        /// Attempt to find SF by FACULTY01 field
        /// </summary>
        /// <param name="FACULTY01">FACULTY01 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByFACULTY01(string FACULTY01)
        {
            IReadOnlyList<SF> value;
            if (Index_FACULTY01.Value.TryGetValue(FACULTY01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by FACULTY02 field
        /// </summary>
        /// <param name="FACULTY02">FACULTY02 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByFACULTY02(string FACULTY02)
        {
            return Index_FACULTY02.Value[FACULTY02];
        }

        /// <summary>
        /// Attempt to find SF by FACULTY02 field
        /// </summary>
        /// <param name="FACULTY02">FACULTY02 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY02(string FACULTY02, out IReadOnlyList<SF> Value)
        {
            return Index_FACULTY02.Value.TryGetValue(FACULTY02, out Value);
        }

        /// <summary>
        /// Attempt to find SF by FACULTY02 field
        /// </summary>
        /// <param name="FACULTY02">FACULTY02 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByFACULTY02(string FACULTY02)
        {
            IReadOnlyList<SF> value;
            if (Index_FACULTY02.Value.TryGetValue(FACULTY02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by FACULTY03 field
        /// </summary>
        /// <param name="FACULTY03">FACULTY03 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByFACULTY03(string FACULTY03)
        {
            return Index_FACULTY03.Value[FACULTY03];
        }

        /// <summary>
        /// Attempt to find SF by FACULTY03 field
        /// </summary>
        /// <param name="FACULTY03">FACULTY03 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY03(string FACULTY03, out IReadOnlyList<SF> Value)
        {
            return Index_FACULTY03.Value.TryGetValue(FACULTY03, out Value);
        }

        /// <summary>
        /// Attempt to find SF by FACULTY03 field
        /// </summary>
        /// <param name="FACULTY03">FACULTY03 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByFACULTY03(string FACULTY03)
        {
            IReadOnlyList<SF> value;
            if (Index_FACULTY03.Value.TryGetValue(FACULTY03, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by FACULTY04 field
        /// </summary>
        /// <param name="FACULTY04">FACULTY04 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByFACULTY04(string FACULTY04)
        {
            return Index_FACULTY04.Value[FACULTY04];
        }

        /// <summary>
        /// Attempt to find SF by FACULTY04 field
        /// </summary>
        /// <param name="FACULTY04">FACULTY04 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY04(string FACULTY04, out IReadOnlyList<SF> Value)
        {
            return Index_FACULTY04.Value.TryGetValue(FACULTY04, out Value);
        }

        /// <summary>
        /// Attempt to find SF by FACULTY04 field
        /// </summary>
        /// <param name="FACULTY04">FACULTY04 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByFACULTY04(string FACULTY04)
        {
            IReadOnlyList<SF> value;
            if (Index_FACULTY04.Value.TryGetValue(FACULTY04, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT01 field
        /// </summary>
        /// <param name="SUBJECT01">SUBJECT01 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT01(string SUBJECT01)
        {
            return Index_SUBJECT01.Value[SUBJECT01];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT01 field
        /// </summary>
        /// <param name="SUBJECT01">SUBJECT01 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT01(string SUBJECT01, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT01.Value.TryGetValue(SUBJECT01, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT01 field
        /// </summary>
        /// <param name="SUBJECT01">SUBJECT01 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT01(string SUBJECT01)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT01.Value.TryGetValue(SUBJECT01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT02 field
        /// </summary>
        /// <param name="SUBJECT02">SUBJECT02 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT02(string SUBJECT02)
        {
            return Index_SUBJECT02.Value[SUBJECT02];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT02 field
        /// </summary>
        /// <param name="SUBJECT02">SUBJECT02 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT02(string SUBJECT02, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT02.Value.TryGetValue(SUBJECT02, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT02 field
        /// </summary>
        /// <param name="SUBJECT02">SUBJECT02 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT02(string SUBJECT02)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT02.Value.TryGetValue(SUBJECT02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT03 field
        /// </summary>
        /// <param name="SUBJECT03">SUBJECT03 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT03(string SUBJECT03)
        {
            return Index_SUBJECT03.Value[SUBJECT03];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT03 field
        /// </summary>
        /// <param name="SUBJECT03">SUBJECT03 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT03(string SUBJECT03, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT03.Value.TryGetValue(SUBJECT03, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT03 field
        /// </summary>
        /// <param name="SUBJECT03">SUBJECT03 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT03(string SUBJECT03)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT03.Value.TryGetValue(SUBJECT03, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT04 field
        /// </summary>
        /// <param name="SUBJECT04">SUBJECT04 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT04(string SUBJECT04)
        {
            return Index_SUBJECT04.Value[SUBJECT04];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT04 field
        /// </summary>
        /// <param name="SUBJECT04">SUBJECT04 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT04(string SUBJECT04, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT04.Value.TryGetValue(SUBJECT04, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT04 field
        /// </summary>
        /// <param name="SUBJECT04">SUBJECT04 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT04(string SUBJECT04)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT04.Value.TryGetValue(SUBJECT04, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT05 field
        /// </summary>
        /// <param name="SUBJECT05">SUBJECT05 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT05(string SUBJECT05)
        {
            return Index_SUBJECT05.Value[SUBJECT05];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT05 field
        /// </summary>
        /// <param name="SUBJECT05">SUBJECT05 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT05(string SUBJECT05, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT05.Value.TryGetValue(SUBJECT05, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT05 field
        /// </summary>
        /// <param name="SUBJECT05">SUBJECT05 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT05(string SUBJECT05)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT05.Value.TryGetValue(SUBJECT05, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT06 field
        /// </summary>
        /// <param name="SUBJECT06">SUBJECT06 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT06(string SUBJECT06)
        {
            return Index_SUBJECT06.Value[SUBJECT06];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT06 field
        /// </summary>
        /// <param name="SUBJECT06">SUBJECT06 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT06(string SUBJECT06, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT06.Value.TryGetValue(SUBJECT06, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT06 field
        /// </summary>
        /// <param name="SUBJECT06">SUBJECT06 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT06(string SUBJECT06)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT06.Value.TryGetValue(SUBJECT06, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT07 field
        /// </summary>
        /// <param name="SUBJECT07">SUBJECT07 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT07(string SUBJECT07)
        {
            return Index_SUBJECT07.Value[SUBJECT07];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT07 field
        /// </summary>
        /// <param name="SUBJECT07">SUBJECT07 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT07(string SUBJECT07, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT07.Value.TryGetValue(SUBJECT07, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT07 field
        /// </summary>
        /// <param name="SUBJECT07">SUBJECT07 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT07(string SUBJECT07)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT07.Value.TryGetValue(SUBJECT07, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT08 field
        /// </summary>
        /// <param name="SUBJECT08">SUBJECT08 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT08(string SUBJECT08)
        {
            return Index_SUBJECT08.Value[SUBJECT08];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT08 field
        /// </summary>
        /// <param name="SUBJECT08">SUBJECT08 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT08(string SUBJECT08, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT08.Value.TryGetValue(SUBJECT08, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT08 field
        /// </summary>
        /// <param name="SUBJECT08">SUBJECT08 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT08(string SUBJECT08)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT08.Value.TryGetValue(SUBJECT08, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT09 field
        /// </summary>
        /// <param name="SUBJECT09">SUBJECT09 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT09(string SUBJECT09)
        {
            return Index_SUBJECT09.Value[SUBJECT09];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT09 field
        /// </summary>
        /// <param name="SUBJECT09">SUBJECT09 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT09(string SUBJECT09, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT09.Value.TryGetValue(SUBJECT09, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT09 field
        /// </summary>
        /// <param name="SUBJECT09">SUBJECT09 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT09(string SUBJECT09)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT09.Value.TryGetValue(SUBJECT09, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by SUBJECT10 field
        /// </summary>
        /// <param name="SUBJECT10">SUBJECT10 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySUBJECT10(string SUBJECT10)
        {
            return Index_SUBJECT10.Value[SUBJECT10];
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT10 field
        /// </summary>
        /// <param name="SUBJECT10">SUBJECT10 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT10(string SUBJECT10, out IReadOnlyList<SF> Value)
        {
            return Index_SUBJECT10.Value.TryGetValue(SUBJECT10, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SUBJECT10 field
        /// </summary>
        /// <param name="SUBJECT10">SUBJECT10 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySUBJECT10(string SUBJECT10)
        {
            IReadOnlyList<SF> value;
            if (Index_SUBJECT10.Value.TryGetValue(SUBJECT10, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SF by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SF> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SF by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SF> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByHOUSE(string HOUSE)
        {
            return Index_HOUSE.Value[HOUSE];
        }

        /// <summary>
        /// Attempt to find SF by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOUSE(string HOUSE, out IReadOnlyList<SF> Value)
        {
            return Index_HOUSE.Value.TryGetValue(HOUSE, out Value);
        }

        /// <summary>
        /// Attempt to find SF by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByHOUSE(string HOUSE)
        {
            IReadOnlyList<SF> value;
            if (Index_HOUSE.Value.TryGetValue(HOUSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SF> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SF> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by OTHER_LOCATION field
        /// </summary>
        /// <param name="OTHER_LOCATION">OTHER_LOCATION value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByOTHER_LOCATION(string OTHER_LOCATION)
        {
            return Index_OTHER_LOCATION.Value[OTHER_LOCATION];
        }

        /// <summary>
        /// Attempt to find SF by OTHER_LOCATION field
        /// </summary>
        /// <param name="OTHER_LOCATION">OTHER_LOCATION value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByOTHER_LOCATION(string OTHER_LOCATION, out IReadOnlyList<SF> Value)
        {
            return Index_OTHER_LOCATION.Value.TryGetValue(OTHER_LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find SF by OTHER_LOCATION field
        /// </summary>
        /// <param name="OTHER_LOCATION">OTHER_LOCATION value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByOTHER_LOCATION(string OTHER_LOCATION)
        {
            IReadOnlyList<SF> value;
            if (Index_OTHER_LOCATION.Value.TryGetValue(OTHER_LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by POS_CODE_A field
        /// </summary>
        /// <param name="POS_CODE_A">POS_CODE_A value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByPOS_CODE_A(string POS_CODE_A)
        {
            return Index_POS_CODE_A.Value[POS_CODE_A];
        }

        /// <summary>
        /// Attempt to find SF by POS_CODE_A field
        /// </summary>
        /// <param name="POS_CODE_A">POS_CODE_A value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPOS_CODE_A(string POS_CODE_A, out IReadOnlyList<SF> Value)
        {
            return Index_POS_CODE_A.Value.TryGetValue(POS_CODE_A, out Value);
        }

        /// <summary>
        /// Attempt to find SF by POS_CODE_A field
        /// </summary>
        /// <param name="POS_CODE_A">POS_CODE_A value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByPOS_CODE_A(string POS_CODE_A)
        {
            IReadOnlyList<SF> value;
            if (Index_POS_CODE_A.Value.TryGetValue(POS_CODE_A, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by POS_CODE_B field
        /// </summary>
        /// <param name="POS_CODE_B">POS_CODE_B value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByPOS_CODE_B(string POS_CODE_B)
        {
            return Index_POS_CODE_B.Value[POS_CODE_B];
        }

        /// <summary>
        /// Attempt to find SF by POS_CODE_B field
        /// </summary>
        /// <param name="POS_CODE_B">POS_CODE_B value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPOS_CODE_B(string POS_CODE_B, out IReadOnlyList<SF> Value)
        {
            return Index_POS_CODE_B.Value.TryGetValue(POS_CODE_B, out Value);
        }

        /// <summary>
        /// Attempt to find SF by POS_CODE_B field
        /// </summary>
        /// <param name="POS_CODE_B">POS_CODE_B value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByPOS_CODE_B(string POS_CODE_B)
        {
            IReadOnlyList<SF> value;
            if (Index_POS_CODE_B.Value.TryGetValue(POS_CODE_B, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by MAJORA field
        /// </summary>
        /// <param name="MAJORA">MAJORA value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByMAJORA(string MAJORA)
        {
            return Index_MAJORA.Value[MAJORA];
        }

        /// <summary>
        /// Attempt to find SF by MAJORA field
        /// </summary>
        /// <param name="MAJORA">MAJORA value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAJORA(string MAJORA, out IReadOnlyList<SF> Value)
        {
            return Index_MAJORA.Value.TryGetValue(MAJORA, out Value);
        }

        /// <summary>
        /// Attempt to find SF by MAJORA field
        /// </summary>
        /// <param name="MAJORA">MAJORA value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByMAJORA(string MAJORA)
        {
            IReadOnlyList<SF> value;
            if (Index_MAJORA.Value.TryGetValue(MAJORA, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by MAJORB field
        /// </summary>
        /// <param name="MAJORB">MAJORB value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByMAJORB(string MAJORB)
        {
            return Index_MAJORB.Value[MAJORB];
        }

        /// <summary>
        /// Attempt to find SF by MAJORB field
        /// </summary>
        /// <param name="MAJORB">MAJORB value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAJORB(string MAJORB, out IReadOnlyList<SF> Value)
        {
            return Index_MAJORB.Value.TryGetValue(MAJORB, out Value);
        }

        /// <summary>
        /// Attempt to find SF by MAJORB field
        /// </summary>
        /// <param name="MAJORB">MAJORB value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByMAJORB(string MAJORB)
        {
            IReadOnlyList<SF> value;
            if (Index_MAJORB.Value.TryGetValue(MAJORB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by MAJORC field
        /// </summary>
        /// <param name="MAJORC">MAJORC value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByMAJORC(string MAJORC)
        {
            return Index_MAJORC.Value[MAJORC];
        }

        /// <summary>
        /// Attempt to find SF by MAJORC field
        /// </summary>
        /// <param name="MAJORC">MAJORC value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAJORC(string MAJORC, out IReadOnlyList<SF> Value)
        {
            return Index_MAJORC.Value.TryGetValue(MAJORC, out Value);
        }

        /// <summary>
        /// Attempt to find SF by MAJORC field
        /// </summary>
        /// <param name="MAJORC">MAJORC value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByMAJORC(string MAJORC)
        {
            IReadOnlyList<SF> value;
            if (Index_MAJORC.Value.TryGetValue(MAJORC, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByRELIGION(string RELIGION)
        {
            return Index_RELIGION.Value[RELIGION];
        }

        /// <summary>
        /// Attempt to find SF by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELIGION(string RELIGION, out IReadOnlyList<SF> Value)
        {
            return Index_RELIGION.Value.TryGetValue(RELIGION, out Value);
        }

        /// <summary>
        /// Attempt to find SF by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByRELIGION(string RELIGION)
        {
            IReadOnlyList<SF> value;
            if (Index_RELIGION.Value.TryGetValue(RELIGION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByBIRTH_COUNTRY(string BIRTH_COUNTRY)
        {
            return Index_BIRTH_COUNTRY.Value[BIRTH_COUNTRY];
        }

        /// <summary>
        /// Attempt to find SF by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBIRTH_COUNTRY(string BIRTH_COUNTRY, out IReadOnlyList<SF> Value)
        {
            return Index_BIRTH_COUNTRY.Value.TryGetValue(BIRTH_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find SF by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByBIRTH_COUNTRY(string BIRTH_COUNTRY)
        {
            IReadOnlyList<SF> value;
            if (Index_BIRTH_COUNTRY.Value.TryGetValue(BIRTH_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by LANG01 field
        /// </summary>
        /// <param name="LANG01">LANG01 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByLANG01(string LANG01)
        {
            return Index_LANG01.Value[LANG01];
        }

        /// <summary>
        /// Attempt to find SF by LANG01 field
        /// </summary>
        /// <param name="LANG01">LANG01 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLANG01(string LANG01, out IReadOnlyList<SF> Value)
        {
            return Index_LANG01.Value.TryGetValue(LANG01, out Value);
        }

        /// <summary>
        /// Attempt to find SF by LANG01 field
        /// </summary>
        /// <param name="LANG01">LANG01 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByLANG01(string LANG01)
        {
            IReadOnlyList<SF> value;
            if (Index_LANG01.Value.TryGetValue(LANG01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by LANG02 field
        /// </summary>
        /// <param name="LANG02">LANG02 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByLANG02(string LANG02)
        {
            return Index_LANG02.Value[LANG02];
        }

        /// <summary>
        /// Attempt to find SF by LANG02 field
        /// </summary>
        /// <param name="LANG02">LANG02 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLANG02(string LANG02, out IReadOnlyList<SF> Value)
        {
            return Index_LANG02.Value.TryGetValue(LANG02, out Value);
        }

        /// <summary>
        /// Attempt to find SF by LANG02 field
        /// </summary>
        /// <param name="LANG02">LANG02 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByLANG02(string LANG02)
        {
            IReadOnlyList<SF> value;
            if (Index_LANG02.Value.TryGetValue(LANG02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByEMERG_LANG01(string EMERG_LANG01)
        {
            return Index_EMERG_LANG01.Value[EMERG_LANG01];
        }

        /// <summary>
        /// Attempt to find SF by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG01(string EMERG_LANG01, out IReadOnlyList<SF> Value)
        {
            return Index_EMERG_LANG01.Value.TryGetValue(EMERG_LANG01, out Value);
        }

        /// <summary>
        /// Attempt to find SF by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByEMERG_LANG01(string EMERG_LANG01)
        {
            IReadOnlyList<SF> value;
            if (Index_EMERG_LANG01.Value.TryGetValue(EMERG_LANG01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByEMERG_LANG02(string EMERG_LANG02)
        {
            return Index_EMERG_LANG02.Value[EMERG_LANG02];
        }

        /// <summary>
        /// Attempt to find SF by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG02(string EMERG_LANG02, out IReadOnlyList<SF> Value)
        {
            return Index_EMERG_LANG02.Value.TryGetValue(EMERG_LANG02, out Value);
        }

        /// <summary>
        /// Attempt to find SF by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByEMERG_LANG02(string EMERG_LANG02)
        {
            IReadOnlyList<SF> value;
            if (Index_EMERG_LANG02.Value.TryGetValue(EMERG_LANG02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SF by DEBTOR_ID field
        /// </summary>
        /// <param name="DEBTOR_ID">DEBTOR_ID value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindByDEBTOR_ID(string DEBTOR_ID)
        {
            return Index_DEBTOR_ID.Value[DEBTOR_ID];
        }

        /// <summary>
        /// Attempt to find SF by DEBTOR_ID field
        /// </summary>
        /// <param name="DEBTOR_ID">DEBTOR_ID value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEBTOR_ID(string DEBTOR_ID, out IReadOnlyList<SF> Value)
        {
            return Index_DEBTOR_ID.Value.TryGetValue(DEBTOR_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SF by DEBTOR_ID field
        /// </summary>
        /// <param name="DEBTOR_ID">DEBTOR_ID value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindByDEBTOR_ID(string DEBTOR_ID)
        {
            IReadOnlyList<SF> value;
            if (Index_DEBTOR_ID.Value.TryGetValue(DEBTOR_ID, out value))
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
