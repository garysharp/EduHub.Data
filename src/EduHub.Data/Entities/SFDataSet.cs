using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFDataSet : EduHubDataSet<SF>
    {
        /// <inheritdoc />
        public override string Name { get { return "SF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BIRTH_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_DEBTOR_ID = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.DEBTOR_ID));
            Index_EMERG_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG01));
            Index_EMERG_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG02));
            Index_FACULTY01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY01));
            Index_FACULTY02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY02));
            Index_FACULTY03 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY03));
            Index_FACULTY04 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY04));
            Index_HOMEKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.HOMEKEY));
            Index_HOUSE = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.HOUSE));
            Index_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.LANG01));
            Index_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.LANG02));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_MAJORA = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAJORA));
            Index_MAJORB = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAJORB));
            Index_MAJORC = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.MAJORC));
            Index_OTHER_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.OTHER_LOCATION));
            Index_POS_CODE_A = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.POS_CODE_A));
            Index_POS_CODE_B = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.POS_CODE_B));
            Index_RELIGION = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.RELIGION));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_SFKEY = new Lazy<Dictionary<string, SF>>(() => this.ToDictionary(i => i.SFKEY));
            Index_SMS_REPLY = new Lazy<NullDictionary<string, IReadOnlyList<SF>>>(() => this.ToGroupedNullDictionary(i => i.SMS_REPLY));
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
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SF" /> fields for each CSV column header</returns>
        internal override Action<SF, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "FINISH":
                        mapper[i] = (e, v) => e.FINISH = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.CLEARANCE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "STAFF_PIC":
                        mapper[i] = (e, v) => e.STAFF_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "OK_TO_PUBLISH":
                        mapper[i] = (e, v) => e.OK_TO_PUBLISH = v;
                        break;
                    case "PIC_LW_DATE":
                        mapper[i] = (e, v) => e.PIC_LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.LAST_EXTRAS = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.HRMS_DATETIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DEBTOR_ID":
                        mapper[i] = (e, v) => e.DEBTOR_ID = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "DRIVERS_LIC_NO":
                        mapper[i] = (e, v) => e.DRIVERS_LIC_NO = v;
                        break;
                    case "DRIVERS_LIC_EXPIRY":
                        mapper[i] = (e, v) => e.DRIVERS_LIC_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "VIT_EXPIRY":
                        mapper[i] = (e, v) => e.VIT_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "WWCC_NUMBER":
                        mapper[i] = (e, v) => e.WWCC_NUMBER = v;
                        break;
                    case "WWCC_EXPIRY":
                        mapper[i] = (e, v) => e.WWCC_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "WWCC_TYPE":
                        mapper[i] = (e, v) => e.WWCC_TYPE = v;
                        break;
                    case "SMS_REPLY":
                        mapper[i] = (e, v) => e.SMS_REPLY = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SF}"/> of entities</returns>
        internal override IEnumerable<SF> ApplyDeltaEntities(IEnumerable<SF> Entities, List<SF> DeltaEntities)
        {
            HashSet<string> Index_SFKEY = new HashSet<string>(DeltaEntities.Select(i => i.SFKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SFKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SFKEY.Remove(entity.SFKEY);
                            
                            if (entity.SFKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_BIRTH_COUNTRY;
        private Lazy<NullDictionary<int?, IReadOnlyList<SF>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_DEBTOR_ID;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_EMERG_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_EMERG_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY02;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY03;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_FACULTY04;
        private Lazy<NullDictionary<int?, IReadOnlyList<SF>>> Index_HOMEKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_HOUSE;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_LANG02;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SF>>> Index_LW_DATE;
        private Lazy<NullDictionary<int?, IReadOnlyList<SF>>> Index_MAILKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_MAJORA;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_MAJORB;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_MAJORC;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_OTHER_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_POS_CODE_A;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_POS_CODE_B;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_RELIGION;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_ROOM;
        private Lazy<Dictionary<string, SF>> Index_SFKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SF>>> Index_SMS_REPLY;
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

        #endregion

        #region Index Methods

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
        /// Find SF by SMS_REPLY field
        /// </summary>
        /// <param name="SMS_REPLY">SMS_REPLY value used to find SF</param>
        /// <returns>List of related SF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> FindBySMS_REPLY(string SMS_REPLY)
        {
            return Index_SMS_REPLY.Value[SMS_REPLY];
        }

        /// <summary>
        /// Attempt to find SF by SMS_REPLY field
        /// </summary>
        /// <param name="SMS_REPLY">SMS_REPLY value used to find SF</param>
        /// <param name="Value">List of related SF entities</param>
        /// <returns>True if the list of related SF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMS_REPLY(string SMS_REPLY, out IReadOnlyList<SF> Value)
        {
            return Index_SMS_REPLY.Value.TryGetValue(SMS_REPLY, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SMS_REPLY field
        /// </summary>
        /// <param name="SMS_REPLY">SMS_REPLY value used to find SF</param>
        /// <returns>List of related SF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SF> TryFindBySMS_REPLY(string SMS_REPLY)
        {
            IReadOnlyList<SF> value;
            if (Index_SMS_REPLY.Value.TryGetValue(SMS_REPLY, out value))
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

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SF](
        [SFKEY] varchar(4) NOT NULL,
        [SURNAME] varchar(30) NULL,
        [TITLE] varchar(4) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [PREF_NAME] varchar(15) NULL,
        [PREVIOUS_NAME] varchar(30) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTHDATE] datetime NULL,
        [HOMEKEY] int NULL,
        [MAILKEY] int NULL,
        [MOBILE] varchar(20) NULL,
        [WORK_PHONE] varchar(20) NULL,
        [E_MAIL] varchar(60) NULL,
        [VIT_NO] varchar(10) NULL,
        [START] datetime NULL,
        [FINISH] datetime NULL,
        [FACULTY01] varchar(10) NULL,
        [FACULTY02] varchar(10) NULL,
        [FACULTY03] varchar(10) NULL,
        [FACULTY04] varchar(10) NULL,
        [SUBJECT01] varchar(5) NULL,
        [SUBJECT02] varchar(5) NULL,
        [SUBJECT03] varchar(5) NULL,
        [SUBJECT04] varchar(5) NULL,
        [SUBJECT05] varchar(5) NULL,
        [SUBJECT06] varchar(5) NULL,
        [SUBJECT07] varchar(5) NULL,
        [SUBJECT08] varchar(5) NULL,
        [SUBJECT09] varchar(5) NULL,
        [SUBJECT10] varchar(5) NULL,
        [FTE] float NULL,
        [AVAILABILITY01] varchar(1) NULL,
        [AVAILABILITY02] varchar(1) NULL,
        [AVAILABILITY03] varchar(1) NULL,
        [AVAILABILITY04] varchar(1) NULL,
        [AVAILABILITY05] varchar(1) NULL,
        [RANK] smallint NULL,
        [CAMPUS] int NULL,
        [HOUSE] varchar(10) NULL,
        [ROOM] varchar(4) NULL,
        [OTHER_LOCATION] varchar(4) NULL,
        [CAR_REGO] varchar(10) NULL,
        [STAFF_TYPE] varchar(1) NULL,
        [POS_CODE_A] varchar(6) NULL,
        [POS_CODE_B] varchar(6) NULL,
        [STATUS] varchar(1) NULL,
        [STAFF_STATUS] varchar(4) NULL,
        [MAJORA] varchar(4) NULL,
        [MAJORB] varchar(4) NULL,
        [MAJORC] varchar(4) NULL,
        [SKILL_QUALIFICATION] varchar(MAX) NULL,
        [PAYROLL_REC_NO] varchar(9) NULL,
        [PAYROLL_CLASS] varchar(20) NULL,
        [RELIGION] varchar(12) NULL,
        [REPORT_NAME] varchar(30) NULL,
        [POLICE_CLEARANCE] varchar(1) NULL,
        [CLEARANCE_DATE] datetime NULL,
        [STAFF_PIC] varbinary(MAX) NULL,
        [OK_TO_PUBLISH] varchar(1) NULL,
        [PIC_LW_DATE] datetime NULL,
        [PIC_STATUS] varchar(1) NULL,
        [AVAILABLE] varbinary(MAX) NULL,
        [MAX_EXTRAS] smallint NULL,
        [ACC_EXTRAS] smallint NULL,
        [WEEK_EXTRAS] smallint NULL,
        [LAST_EXTRAS] datetime NULL,
        [BIRTH_COUNTRY] varchar(6) NULL,
        [LANG01] varchar(7) NULL,
        [LANG02] varchar(7) NULL,
        [INTERPRETER01] varchar(1) NULL,
        [INTERPRETER02] varchar(1) NULL,
        [EMERG_NAME01] varchar(30) NULL,
        [EMERG_NAME02] varchar(30) NULL,
        [EMERG_LANG01] varchar(7) NULL,
        [EMERG_LANG02] varchar(7) NULL,
        [EMERG_RELATION01] varchar(12) NULL,
        [EMERG_RELATION02] varchar(12) NULL,
        [EMERG_CONTACT01] varchar(MAX) NULL,
        [EMERG_CONTACT02] varchar(MAX) NULL,
        [GROUP_AVAILABILITY] varchar(1) NULL,
        [NORMAL_ALLOTMENT] smallint NULL,
        [HRMS_UPDATE] varchar(1) NULL,
        [HRMS_DATETIME] datetime NULL,
        [DEBTOR_ID] varchar(10) NULL,
        [NOTES] varchar(MAX) NULL,
        [DRIVERS_LIC_NO] varchar(15) NULL,
        [DRIVERS_LIC_EXPIRY] datetime NULL,
        [VIT_EXPIRY] datetime NULL,
        [WWCC_NUMBER] varchar(11) NULL,
        [WWCC_EXPIRY] datetime NULL,
        [WWCC_TYPE] varchar(1) NULL,
        [SMS_REPLY] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SF_Index_SFKEY] PRIMARY KEY CLUSTERED (
            [SFKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SF_Index_BIRTH_COUNTRY] ON [dbo].[SF]
    (
            [BIRTH_COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_CAMPUS] ON [dbo].[SF]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_DEBTOR_ID] ON [dbo].[SF]
    (
            [DEBTOR_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_EMERG_LANG01] ON [dbo].[SF]
    (
            [EMERG_LANG01] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_EMERG_LANG02] ON [dbo].[SF]
    (
            [EMERG_LANG02] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_FACULTY01] ON [dbo].[SF]
    (
            [FACULTY01] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_FACULTY02] ON [dbo].[SF]
    (
            [FACULTY02] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_FACULTY03] ON [dbo].[SF]
    (
            [FACULTY03] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_FACULTY04] ON [dbo].[SF]
    (
            [FACULTY04] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_HOMEKEY] ON [dbo].[SF]
    (
            [HOMEKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_HOUSE] ON [dbo].[SF]
    (
            [HOUSE] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_LANG01] ON [dbo].[SF]
    (
            [LANG01] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_LANG02] ON [dbo].[SF]
    (
            [LANG02] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_LW_DATE] ON [dbo].[SF]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_MAILKEY] ON [dbo].[SF]
    (
            [MAILKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_MAJORA] ON [dbo].[SF]
    (
            [MAJORA] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_MAJORB] ON [dbo].[SF]
    (
            [MAJORB] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_MAJORC] ON [dbo].[SF]
    (
            [MAJORC] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_OTHER_LOCATION] ON [dbo].[SF]
    (
            [OTHER_LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_POS_CODE_A] ON [dbo].[SF]
    (
            [POS_CODE_A] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_POS_CODE_B] ON [dbo].[SF]
    (
            [POS_CODE_B] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_RELIGION] ON [dbo].[SF]
    (
            [RELIGION] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_ROOM] ON [dbo].[SF]
    (
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SMS_REPLY] ON [dbo].[SF]
    (
            [SMS_REPLY] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT01] ON [dbo].[SF]
    (
            [SUBJECT01] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT02] ON [dbo].[SF]
    (
            [SUBJECT02] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT03] ON [dbo].[SF]
    (
            [SUBJECT03] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT04] ON [dbo].[SF]
    (
            [SUBJECT04] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT05] ON [dbo].[SF]
    (
            [SUBJECT05] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT06] ON [dbo].[SF]
    (
            [SUBJECT06] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT07] ON [dbo].[SF]
    (
            [SUBJECT07] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT08] ON [dbo].[SF]
    (
            [SUBJECT08] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT09] ON [dbo].[SF]
    (
            [SUBJECT09] ASC
    );
    CREATE NONCLUSTERED INDEX [SF_Index_SUBJECT10] ON [dbo].[SF]
    (
            [SUBJECT10] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_BIRTH_COUNTRY')
    ALTER INDEX [Index_BIRTH_COUNTRY] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_DEBTOR_ID')
    ALTER INDEX [Index_DEBTOR_ID] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_EMERG_LANG01')
    ALTER INDEX [Index_EMERG_LANG01] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_EMERG_LANG02')
    ALTER INDEX [Index_EMERG_LANG02] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY01')
    ALTER INDEX [Index_FACULTY01] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY02')
    ALTER INDEX [Index_FACULTY02] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY03')
    ALTER INDEX [Index_FACULTY03] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY04')
    ALTER INDEX [Index_FACULTY04] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_HOMEKEY')
    ALTER INDEX [Index_HOMEKEY] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_HOUSE')
    ALTER INDEX [Index_HOUSE] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_LANG01')
    ALTER INDEX [Index_LANG01] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_LANG02')
    ALTER INDEX [Index_LANG02] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAILKEY')
    ALTER INDEX [Index_MAILKEY] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAJORA')
    ALTER INDEX [Index_MAJORA] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAJORB')
    ALTER INDEX [Index_MAJORB] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAJORC')
    ALTER INDEX [Index_MAJORC] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_OTHER_LOCATION')
    ALTER INDEX [Index_OTHER_LOCATION] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_POS_CODE_A')
    ALTER INDEX [Index_POS_CODE_A] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_POS_CODE_B')
    ALTER INDEX [Index_POS_CODE_B] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_RELIGION')
    ALTER INDEX [Index_RELIGION] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SMS_REPLY')
    ALTER INDEX [Index_SMS_REPLY] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT01')
    ALTER INDEX [Index_SUBJECT01] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT02')
    ALTER INDEX [Index_SUBJECT02] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT03')
    ALTER INDEX [Index_SUBJECT03] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT04')
    ALTER INDEX [Index_SUBJECT04] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT05')
    ALTER INDEX [Index_SUBJECT05] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT06')
    ALTER INDEX [Index_SUBJECT06] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT07')
    ALTER INDEX [Index_SUBJECT07] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT08')
    ALTER INDEX [Index_SUBJECT08] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT09')
    ALTER INDEX [Index_SUBJECT09] ON [dbo].[SF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT10')
    ALTER INDEX [Index_SUBJECT10] ON [dbo].[SF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_BIRTH_COUNTRY')
    ALTER INDEX [Index_BIRTH_COUNTRY] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_DEBTOR_ID')
    ALTER INDEX [Index_DEBTOR_ID] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_EMERG_LANG01')
    ALTER INDEX [Index_EMERG_LANG01] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_EMERG_LANG02')
    ALTER INDEX [Index_EMERG_LANG02] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY01')
    ALTER INDEX [Index_FACULTY01] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY02')
    ALTER INDEX [Index_FACULTY02] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY03')
    ALTER INDEX [Index_FACULTY03] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_FACULTY04')
    ALTER INDEX [Index_FACULTY04] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_HOMEKEY')
    ALTER INDEX [Index_HOMEKEY] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_HOUSE')
    ALTER INDEX [Index_HOUSE] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_LANG01')
    ALTER INDEX [Index_LANG01] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_LANG02')
    ALTER INDEX [Index_LANG02] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAILKEY')
    ALTER INDEX [Index_MAILKEY] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAJORA')
    ALTER INDEX [Index_MAJORA] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAJORB')
    ALTER INDEX [Index_MAJORB] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_MAJORC')
    ALTER INDEX [Index_MAJORC] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_OTHER_LOCATION')
    ALTER INDEX [Index_OTHER_LOCATION] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_POS_CODE_A')
    ALTER INDEX [Index_POS_CODE_A] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_POS_CODE_B')
    ALTER INDEX [Index_POS_CODE_B] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_RELIGION')
    ALTER INDEX [Index_RELIGION] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SMS_REPLY')
    ALTER INDEX [Index_SMS_REPLY] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT01')
    ALTER INDEX [Index_SUBJECT01] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT02')
    ALTER INDEX [Index_SUBJECT02] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT03')
    ALTER INDEX [Index_SUBJECT03] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT04')
    ALTER INDEX [Index_SUBJECT04] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT05')
    ALTER INDEX [Index_SUBJECT05] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT06')
    ALTER INDEX [Index_SUBJECT06] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT07')
    ALTER INDEX [Index_SUBJECT07] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT08')
    ALTER INDEX [Index_SUBJECT08] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT09')
    ALTER INDEX [Index_SUBJECT09] ON [dbo].[SF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SF]') AND name = N'Index_SUBJECT10')
    ALTER INDEX [Index_SUBJECT10] ON [dbo].[SF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SFKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SFKEY.Add(entity.SFKEY);
            }

            builder.AppendLine("DELETE [dbo].[SF] WHERE");


            // Index_SFKEY
            builder.Append("[SFKEY] IN (");
            for (int index = 0; index < Index_SFKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SFKEY
                var parameterSFKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSFKEY);
                command.Parameters.Add(parameterSFKEY, SqlDbType.VarChar, 4).Value = Index_SFKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SF data set</returns>
        public override EduHubDataSetDataReader<SF> GetDataSetDataReader()
        {
            return new SFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SF data set</returns>
        public override EduHubDataSetDataReader<SF> GetDataSetDataReader(List<SF> Entities)
        {
            return new SFDataReader(new EduHubDataSetLoadedReader<SF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SFDataReader : EduHubDataSetDataReader<SF>
        {
            public SFDataReader(IEduHubDataSetReader<SF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 96; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SFKEY
                        return Current.SFKEY;
                    case 1: // SURNAME
                        return Current.SURNAME;
                    case 2: // TITLE
                        return Current.TITLE;
                    case 3: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 4: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 5: // PREF_NAME
                        return Current.PREF_NAME;
                    case 6: // PREVIOUS_NAME
                        return Current.PREVIOUS_NAME;
                    case 7: // GENDER
                        return Current.GENDER;
                    case 8: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 9: // HOMEKEY
                        return Current.HOMEKEY;
                    case 10: // MAILKEY
                        return Current.MAILKEY;
                    case 11: // MOBILE
                        return Current.MOBILE;
                    case 12: // WORK_PHONE
                        return Current.WORK_PHONE;
                    case 13: // E_MAIL
                        return Current.E_MAIL;
                    case 14: // VIT_NO
                        return Current.VIT_NO;
                    case 15: // START
                        return Current.START;
                    case 16: // FINISH
                        return Current.FINISH;
                    case 17: // FACULTY01
                        return Current.FACULTY01;
                    case 18: // FACULTY02
                        return Current.FACULTY02;
                    case 19: // FACULTY03
                        return Current.FACULTY03;
                    case 20: // FACULTY04
                        return Current.FACULTY04;
                    case 21: // SUBJECT01
                        return Current.SUBJECT01;
                    case 22: // SUBJECT02
                        return Current.SUBJECT02;
                    case 23: // SUBJECT03
                        return Current.SUBJECT03;
                    case 24: // SUBJECT04
                        return Current.SUBJECT04;
                    case 25: // SUBJECT05
                        return Current.SUBJECT05;
                    case 26: // SUBJECT06
                        return Current.SUBJECT06;
                    case 27: // SUBJECT07
                        return Current.SUBJECT07;
                    case 28: // SUBJECT08
                        return Current.SUBJECT08;
                    case 29: // SUBJECT09
                        return Current.SUBJECT09;
                    case 30: // SUBJECT10
                        return Current.SUBJECT10;
                    case 31: // FTE
                        return Current.FTE;
                    case 32: // AVAILABILITY01
                        return Current.AVAILABILITY01;
                    case 33: // AVAILABILITY02
                        return Current.AVAILABILITY02;
                    case 34: // AVAILABILITY03
                        return Current.AVAILABILITY03;
                    case 35: // AVAILABILITY04
                        return Current.AVAILABILITY04;
                    case 36: // AVAILABILITY05
                        return Current.AVAILABILITY05;
                    case 37: // RANK
                        return Current.RANK;
                    case 38: // CAMPUS
                        return Current.CAMPUS;
                    case 39: // HOUSE
                        return Current.HOUSE;
                    case 40: // ROOM
                        return Current.ROOM;
                    case 41: // OTHER_LOCATION
                        return Current.OTHER_LOCATION;
                    case 42: // CAR_REGO
                        return Current.CAR_REGO;
                    case 43: // STAFF_TYPE
                        return Current.STAFF_TYPE;
                    case 44: // POS_CODE_A
                        return Current.POS_CODE_A;
                    case 45: // POS_CODE_B
                        return Current.POS_CODE_B;
                    case 46: // STATUS
                        return Current.STATUS;
                    case 47: // STAFF_STATUS
                        return Current.STAFF_STATUS;
                    case 48: // MAJORA
                        return Current.MAJORA;
                    case 49: // MAJORB
                        return Current.MAJORB;
                    case 50: // MAJORC
                        return Current.MAJORC;
                    case 51: // SKILL_QUALIFICATION
                        return Current.SKILL_QUALIFICATION;
                    case 52: // PAYROLL_REC_NO
                        return Current.PAYROLL_REC_NO;
                    case 53: // PAYROLL_CLASS
                        return Current.PAYROLL_CLASS;
                    case 54: // RELIGION
                        return Current.RELIGION;
                    case 55: // REPORT_NAME
                        return Current.REPORT_NAME;
                    case 56: // POLICE_CLEARANCE
                        return Current.POLICE_CLEARANCE;
                    case 57: // CLEARANCE_DATE
                        return Current.CLEARANCE_DATE;
                    case 58: // STAFF_PIC
                        return Current.STAFF_PIC;
                    case 59: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH;
                    case 60: // PIC_LW_DATE
                        return Current.PIC_LW_DATE;
                    case 61: // PIC_STATUS
                        return Current.PIC_STATUS;
                    case 62: // AVAILABLE
                        return Current.AVAILABLE;
                    case 63: // MAX_EXTRAS
                        return Current.MAX_EXTRAS;
                    case 64: // ACC_EXTRAS
                        return Current.ACC_EXTRAS;
                    case 65: // WEEK_EXTRAS
                        return Current.WEEK_EXTRAS;
                    case 66: // LAST_EXTRAS
                        return Current.LAST_EXTRAS;
                    case 67: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY;
                    case 68: // LANG01
                        return Current.LANG01;
                    case 69: // LANG02
                        return Current.LANG02;
                    case 70: // INTERPRETER01
                        return Current.INTERPRETER01;
                    case 71: // INTERPRETER02
                        return Current.INTERPRETER02;
                    case 72: // EMERG_NAME01
                        return Current.EMERG_NAME01;
                    case 73: // EMERG_NAME02
                        return Current.EMERG_NAME02;
                    case 74: // EMERG_LANG01
                        return Current.EMERG_LANG01;
                    case 75: // EMERG_LANG02
                        return Current.EMERG_LANG02;
                    case 76: // EMERG_RELATION01
                        return Current.EMERG_RELATION01;
                    case 77: // EMERG_RELATION02
                        return Current.EMERG_RELATION02;
                    case 78: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01;
                    case 79: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02;
                    case 80: // GROUP_AVAILABILITY
                        return Current.GROUP_AVAILABILITY;
                    case 81: // NORMAL_ALLOTMENT
                        return Current.NORMAL_ALLOTMENT;
                    case 82: // HRMS_UPDATE
                        return Current.HRMS_UPDATE;
                    case 83: // HRMS_DATETIME
                        return Current.HRMS_DATETIME;
                    case 84: // DEBTOR_ID
                        return Current.DEBTOR_ID;
                    case 85: // NOTES
                        return Current.NOTES;
                    case 86: // DRIVERS_LIC_NO
                        return Current.DRIVERS_LIC_NO;
                    case 87: // DRIVERS_LIC_EXPIRY
                        return Current.DRIVERS_LIC_EXPIRY;
                    case 88: // VIT_EXPIRY
                        return Current.VIT_EXPIRY;
                    case 89: // WWCC_NUMBER
                        return Current.WWCC_NUMBER;
                    case 90: // WWCC_EXPIRY
                        return Current.WWCC_EXPIRY;
                    case 91: // WWCC_TYPE
                        return Current.WWCC_TYPE;
                    case 92: // SMS_REPLY
                        return Current.SMS_REPLY;
                    case 93: // LW_DATE
                        return Current.LW_DATE;
                    case 94: // LW_TIME
                        return Current.LW_TIME;
                    case 95: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SURNAME
                        return Current.SURNAME == null;
                    case 2: // TITLE
                        return Current.TITLE == null;
                    case 3: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 4: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 5: // PREF_NAME
                        return Current.PREF_NAME == null;
                    case 6: // PREVIOUS_NAME
                        return Current.PREVIOUS_NAME == null;
                    case 7: // GENDER
                        return Current.GENDER == null;
                    case 8: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 9: // HOMEKEY
                        return Current.HOMEKEY == null;
                    case 10: // MAILKEY
                        return Current.MAILKEY == null;
                    case 11: // MOBILE
                        return Current.MOBILE == null;
                    case 12: // WORK_PHONE
                        return Current.WORK_PHONE == null;
                    case 13: // E_MAIL
                        return Current.E_MAIL == null;
                    case 14: // VIT_NO
                        return Current.VIT_NO == null;
                    case 15: // START
                        return Current.START == null;
                    case 16: // FINISH
                        return Current.FINISH == null;
                    case 17: // FACULTY01
                        return Current.FACULTY01 == null;
                    case 18: // FACULTY02
                        return Current.FACULTY02 == null;
                    case 19: // FACULTY03
                        return Current.FACULTY03 == null;
                    case 20: // FACULTY04
                        return Current.FACULTY04 == null;
                    case 21: // SUBJECT01
                        return Current.SUBJECT01 == null;
                    case 22: // SUBJECT02
                        return Current.SUBJECT02 == null;
                    case 23: // SUBJECT03
                        return Current.SUBJECT03 == null;
                    case 24: // SUBJECT04
                        return Current.SUBJECT04 == null;
                    case 25: // SUBJECT05
                        return Current.SUBJECT05 == null;
                    case 26: // SUBJECT06
                        return Current.SUBJECT06 == null;
                    case 27: // SUBJECT07
                        return Current.SUBJECT07 == null;
                    case 28: // SUBJECT08
                        return Current.SUBJECT08 == null;
                    case 29: // SUBJECT09
                        return Current.SUBJECT09 == null;
                    case 30: // SUBJECT10
                        return Current.SUBJECT10 == null;
                    case 31: // FTE
                        return Current.FTE == null;
                    case 32: // AVAILABILITY01
                        return Current.AVAILABILITY01 == null;
                    case 33: // AVAILABILITY02
                        return Current.AVAILABILITY02 == null;
                    case 34: // AVAILABILITY03
                        return Current.AVAILABILITY03 == null;
                    case 35: // AVAILABILITY04
                        return Current.AVAILABILITY04 == null;
                    case 36: // AVAILABILITY05
                        return Current.AVAILABILITY05 == null;
                    case 37: // RANK
                        return Current.RANK == null;
                    case 38: // CAMPUS
                        return Current.CAMPUS == null;
                    case 39: // HOUSE
                        return Current.HOUSE == null;
                    case 40: // ROOM
                        return Current.ROOM == null;
                    case 41: // OTHER_LOCATION
                        return Current.OTHER_LOCATION == null;
                    case 42: // CAR_REGO
                        return Current.CAR_REGO == null;
                    case 43: // STAFF_TYPE
                        return Current.STAFF_TYPE == null;
                    case 44: // POS_CODE_A
                        return Current.POS_CODE_A == null;
                    case 45: // POS_CODE_B
                        return Current.POS_CODE_B == null;
                    case 46: // STATUS
                        return Current.STATUS == null;
                    case 47: // STAFF_STATUS
                        return Current.STAFF_STATUS == null;
                    case 48: // MAJORA
                        return Current.MAJORA == null;
                    case 49: // MAJORB
                        return Current.MAJORB == null;
                    case 50: // MAJORC
                        return Current.MAJORC == null;
                    case 51: // SKILL_QUALIFICATION
                        return Current.SKILL_QUALIFICATION == null;
                    case 52: // PAYROLL_REC_NO
                        return Current.PAYROLL_REC_NO == null;
                    case 53: // PAYROLL_CLASS
                        return Current.PAYROLL_CLASS == null;
                    case 54: // RELIGION
                        return Current.RELIGION == null;
                    case 55: // REPORT_NAME
                        return Current.REPORT_NAME == null;
                    case 56: // POLICE_CLEARANCE
                        return Current.POLICE_CLEARANCE == null;
                    case 57: // CLEARANCE_DATE
                        return Current.CLEARANCE_DATE == null;
                    case 58: // STAFF_PIC
                        return Current.STAFF_PIC == null;
                    case 59: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH == null;
                    case 60: // PIC_LW_DATE
                        return Current.PIC_LW_DATE == null;
                    case 61: // PIC_STATUS
                        return Current.PIC_STATUS == null;
                    case 62: // AVAILABLE
                        return Current.AVAILABLE == null;
                    case 63: // MAX_EXTRAS
                        return Current.MAX_EXTRAS == null;
                    case 64: // ACC_EXTRAS
                        return Current.ACC_EXTRAS == null;
                    case 65: // WEEK_EXTRAS
                        return Current.WEEK_EXTRAS == null;
                    case 66: // LAST_EXTRAS
                        return Current.LAST_EXTRAS == null;
                    case 67: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY == null;
                    case 68: // LANG01
                        return Current.LANG01 == null;
                    case 69: // LANG02
                        return Current.LANG02 == null;
                    case 70: // INTERPRETER01
                        return Current.INTERPRETER01 == null;
                    case 71: // INTERPRETER02
                        return Current.INTERPRETER02 == null;
                    case 72: // EMERG_NAME01
                        return Current.EMERG_NAME01 == null;
                    case 73: // EMERG_NAME02
                        return Current.EMERG_NAME02 == null;
                    case 74: // EMERG_LANG01
                        return Current.EMERG_LANG01 == null;
                    case 75: // EMERG_LANG02
                        return Current.EMERG_LANG02 == null;
                    case 76: // EMERG_RELATION01
                        return Current.EMERG_RELATION01 == null;
                    case 77: // EMERG_RELATION02
                        return Current.EMERG_RELATION02 == null;
                    case 78: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01 == null;
                    case 79: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02 == null;
                    case 80: // GROUP_AVAILABILITY
                        return Current.GROUP_AVAILABILITY == null;
                    case 81: // NORMAL_ALLOTMENT
                        return Current.NORMAL_ALLOTMENT == null;
                    case 82: // HRMS_UPDATE
                        return Current.HRMS_UPDATE == null;
                    case 83: // HRMS_DATETIME
                        return Current.HRMS_DATETIME == null;
                    case 84: // DEBTOR_ID
                        return Current.DEBTOR_ID == null;
                    case 85: // NOTES
                        return Current.NOTES == null;
                    case 86: // DRIVERS_LIC_NO
                        return Current.DRIVERS_LIC_NO == null;
                    case 87: // DRIVERS_LIC_EXPIRY
                        return Current.DRIVERS_LIC_EXPIRY == null;
                    case 88: // VIT_EXPIRY
                        return Current.VIT_EXPIRY == null;
                    case 89: // WWCC_NUMBER
                        return Current.WWCC_NUMBER == null;
                    case 90: // WWCC_EXPIRY
                        return Current.WWCC_EXPIRY == null;
                    case 91: // WWCC_TYPE
                        return Current.WWCC_TYPE == null;
                    case 92: // SMS_REPLY
                        return Current.SMS_REPLY == null;
                    case 93: // LW_DATE
                        return Current.LW_DATE == null;
                    case 94: // LW_TIME
                        return Current.LW_TIME == null;
                    case 95: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SFKEY
                        return "SFKEY";
                    case 1: // SURNAME
                        return "SURNAME";
                    case 2: // TITLE
                        return "TITLE";
                    case 3: // FIRST_NAME
                        return "FIRST_NAME";
                    case 4: // SECOND_NAME
                        return "SECOND_NAME";
                    case 5: // PREF_NAME
                        return "PREF_NAME";
                    case 6: // PREVIOUS_NAME
                        return "PREVIOUS_NAME";
                    case 7: // GENDER
                        return "GENDER";
                    case 8: // BIRTHDATE
                        return "BIRTHDATE";
                    case 9: // HOMEKEY
                        return "HOMEKEY";
                    case 10: // MAILKEY
                        return "MAILKEY";
                    case 11: // MOBILE
                        return "MOBILE";
                    case 12: // WORK_PHONE
                        return "WORK_PHONE";
                    case 13: // E_MAIL
                        return "E_MAIL";
                    case 14: // VIT_NO
                        return "VIT_NO";
                    case 15: // START
                        return "START";
                    case 16: // FINISH
                        return "FINISH";
                    case 17: // FACULTY01
                        return "FACULTY01";
                    case 18: // FACULTY02
                        return "FACULTY02";
                    case 19: // FACULTY03
                        return "FACULTY03";
                    case 20: // FACULTY04
                        return "FACULTY04";
                    case 21: // SUBJECT01
                        return "SUBJECT01";
                    case 22: // SUBJECT02
                        return "SUBJECT02";
                    case 23: // SUBJECT03
                        return "SUBJECT03";
                    case 24: // SUBJECT04
                        return "SUBJECT04";
                    case 25: // SUBJECT05
                        return "SUBJECT05";
                    case 26: // SUBJECT06
                        return "SUBJECT06";
                    case 27: // SUBJECT07
                        return "SUBJECT07";
                    case 28: // SUBJECT08
                        return "SUBJECT08";
                    case 29: // SUBJECT09
                        return "SUBJECT09";
                    case 30: // SUBJECT10
                        return "SUBJECT10";
                    case 31: // FTE
                        return "FTE";
                    case 32: // AVAILABILITY01
                        return "AVAILABILITY01";
                    case 33: // AVAILABILITY02
                        return "AVAILABILITY02";
                    case 34: // AVAILABILITY03
                        return "AVAILABILITY03";
                    case 35: // AVAILABILITY04
                        return "AVAILABILITY04";
                    case 36: // AVAILABILITY05
                        return "AVAILABILITY05";
                    case 37: // RANK
                        return "RANK";
                    case 38: // CAMPUS
                        return "CAMPUS";
                    case 39: // HOUSE
                        return "HOUSE";
                    case 40: // ROOM
                        return "ROOM";
                    case 41: // OTHER_LOCATION
                        return "OTHER_LOCATION";
                    case 42: // CAR_REGO
                        return "CAR_REGO";
                    case 43: // STAFF_TYPE
                        return "STAFF_TYPE";
                    case 44: // POS_CODE_A
                        return "POS_CODE_A";
                    case 45: // POS_CODE_B
                        return "POS_CODE_B";
                    case 46: // STATUS
                        return "STATUS";
                    case 47: // STAFF_STATUS
                        return "STAFF_STATUS";
                    case 48: // MAJORA
                        return "MAJORA";
                    case 49: // MAJORB
                        return "MAJORB";
                    case 50: // MAJORC
                        return "MAJORC";
                    case 51: // SKILL_QUALIFICATION
                        return "SKILL_QUALIFICATION";
                    case 52: // PAYROLL_REC_NO
                        return "PAYROLL_REC_NO";
                    case 53: // PAYROLL_CLASS
                        return "PAYROLL_CLASS";
                    case 54: // RELIGION
                        return "RELIGION";
                    case 55: // REPORT_NAME
                        return "REPORT_NAME";
                    case 56: // POLICE_CLEARANCE
                        return "POLICE_CLEARANCE";
                    case 57: // CLEARANCE_DATE
                        return "CLEARANCE_DATE";
                    case 58: // STAFF_PIC
                        return "STAFF_PIC";
                    case 59: // OK_TO_PUBLISH
                        return "OK_TO_PUBLISH";
                    case 60: // PIC_LW_DATE
                        return "PIC_LW_DATE";
                    case 61: // PIC_STATUS
                        return "PIC_STATUS";
                    case 62: // AVAILABLE
                        return "AVAILABLE";
                    case 63: // MAX_EXTRAS
                        return "MAX_EXTRAS";
                    case 64: // ACC_EXTRAS
                        return "ACC_EXTRAS";
                    case 65: // WEEK_EXTRAS
                        return "WEEK_EXTRAS";
                    case 66: // LAST_EXTRAS
                        return "LAST_EXTRAS";
                    case 67: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 68: // LANG01
                        return "LANG01";
                    case 69: // LANG02
                        return "LANG02";
                    case 70: // INTERPRETER01
                        return "INTERPRETER01";
                    case 71: // INTERPRETER02
                        return "INTERPRETER02";
                    case 72: // EMERG_NAME01
                        return "EMERG_NAME01";
                    case 73: // EMERG_NAME02
                        return "EMERG_NAME02";
                    case 74: // EMERG_LANG01
                        return "EMERG_LANG01";
                    case 75: // EMERG_LANG02
                        return "EMERG_LANG02";
                    case 76: // EMERG_RELATION01
                        return "EMERG_RELATION01";
                    case 77: // EMERG_RELATION02
                        return "EMERG_RELATION02";
                    case 78: // EMERG_CONTACT01
                        return "EMERG_CONTACT01";
                    case 79: // EMERG_CONTACT02
                        return "EMERG_CONTACT02";
                    case 80: // GROUP_AVAILABILITY
                        return "GROUP_AVAILABILITY";
                    case 81: // NORMAL_ALLOTMENT
                        return "NORMAL_ALLOTMENT";
                    case 82: // HRMS_UPDATE
                        return "HRMS_UPDATE";
                    case 83: // HRMS_DATETIME
                        return "HRMS_DATETIME";
                    case 84: // DEBTOR_ID
                        return "DEBTOR_ID";
                    case 85: // NOTES
                        return "NOTES";
                    case 86: // DRIVERS_LIC_NO
                        return "DRIVERS_LIC_NO";
                    case 87: // DRIVERS_LIC_EXPIRY
                        return "DRIVERS_LIC_EXPIRY";
                    case 88: // VIT_EXPIRY
                        return "VIT_EXPIRY";
                    case 89: // WWCC_NUMBER
                        return "WWCC_NUMBER";
                    case 90: // WWCC_EXPIRY
                        return "WWCC_EXPIRY";
                    case 91: // WWCC_TYPE
                        return "WWCC_TYPE";
                    case 92: // SMS_REPLY
                        return "SMS_REPLY";
                    case 93: // LW_DATE
                        return "LW_DATE";
                    case 94: // LW_TIME
                        return "LW_TIME";
                    case 95: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SFKEY":
                        return 0;
                    case "SURNAME":
                        return 1;
                    case "TITLE":
                        return 2;
                    case "FIRST_NAME":
                        return 3;
                    case "SECOND_NAME":
                        return 4;
                    case "PREF_NAME":
                        return 5;
                    case "PREVIOUS_NAME":
                        return 6;
                    case "GENDER":
                        return 7;
                    case "BIRTHDATE":
                        return 8;
                    case "HOMEKEY":
                        return 9;
                    case "MAILKEY":
                        return 10;
                    case "MOBILE":
                        return 11;
                    case "WORK_PHONE":
                        return 12;
                    case "E_MAIL":
                        return 13;
                    case "VIT_NO":
                        return 14;
                    case "START":
                        return 15;
                    case "FINISH":
                        return 16;
                    case "FACULTY01":
                        return 17;
                    case "FACULTY02":
                        return 18;
                    case "FACULTY03":
                        return 19;
                    case "FACULTY04":
                        return 20;
                    case "SUBJECT01":
                        return 21;
                    case "SUBJECT02":
                        return 22;
                    case "SUBJECT03":
                        return 23;
                    case "SUBJECT04":
                        return 24;
                    case "SUBJECT05":
                        return 25;
                    case "SUBJECT06":
                        return 26;
                    case "SUBJECT07":
                        return 27;
                    case "SUBJECT08":
                        return 28;
                    case "SUBJECT09":
                        return 29;
                    case "SUBJECT10":
                        return 30;
                    case "FTE":
                        return 31;
                    case "AVAILABILITY01":
                        return 32;
                    case "AVAILABILITY02":
                        return 33;
                    case "AVAILABILITY03":
                        return 34;
                    case "AVAILABILITY04":
                        return 35;
                    case "AVAILABILITY05":
                        return 36;
                    case "RANK":
                        return 37;
                    case "CAMPUS":
                        return 38;
                    case "HOUSE":
                        return 39;
                    case "ROOM":
                        return 40;
                    case "OTHER_LOCATION":
                        return 41;
                    case "CAR_REGO":
                        return 42;
                    case "STAFF_TYPE":
                        return 43;
                    case "POS_CODE_A":
                        return 44;
                    case "POS_CODE_B":
                        return 45;
                    case "STATUS":
                        return 46;
                    case "STAFF_STATUS":
                        return 47;
                    case "MAJORA":
                        return 48;
                    case "MAJORB":
                        return 49;
                    case "MAJORC":
                        return 50;
                    case "SKILL_QUALIFICATION":
                        return 51;
                    case "PAYROLL_REC_NO":
                        return 52;
                    case "PAYROLL_CLASS":
                        return 53;
                    case "RELIGION":
                        return 54;
                    case "REPORT_NAME":
                        return 55;
                    case "POLICE_CLEARANCE":
                        return 56;
                    case "CLEARANCE_DATE":
                        return 57;
                    case "STAFF_PIC":
                        return 58;
                    case "OK_TO_PUBLISH":
                        return 59;
                    case "PIC_LW_DATE":
                        return 60;
                    case "PIC_STATUS":
                        return 61;
                    case "AVAILABLE":
                        return 62;
                    case "MAX_EXTRAS":
                        return 63;
                    case "ACC_EXTRAS":
                        return 64;
                    case "WEEK_EXTRAS":
                        return 65;
                    case "LAST_EXTRAS":
                        return 66;
                    case "BIRTH_COUNTRY":
                        return 67;
                    case "LANG01":
                        return 68;
                    case "LANG02":
                        return 69;
                    case "INTERPRETER01":
                        return 70;
                    case "INTERPRETER02":
                        return 71;
                    case "EMERG_NAME01":
                        return 72;
                    case "EMERG_NAME02":
                        return 73;
                    case "EMERG_LANG01":
                        return 74;
                    case "EMERG_LANG02":
                        return 75;
                    case "EMERG_RELATION01":
                        return 76;
                    case "EMERG_RELATION02":
                        return 77;
                    case "EMERG_CONTACT01":
                        return 78;
                    case "EMERG_CONTACT02":
                        return 79;
                    case "GROUP_AVAILABILITY":
                        return 80;
                    case "NORMAL_ALLOTMENT":
                        return 81;
                    case "HRMS_UPDATE":
                        return 82;
                    case "HRMS_DATETIME":
                        return 83;
                    case "DEBTOR_ID":
                        return 84;
                    case "NOTES":
                        return 85;
                    case "DRIVERS_LIC_NO":
                        return 86;
                    case "DRIVERS_LIC_EXPIRY":
                        return 87;
                    case "VIT_EXPIRY":
                        return 88;
                    case "WWCC_NUMBER":
                        return 89;
                    case "WWCC_EXPIRY":
                        return 90;
                    case "WWCC_TYPE":
                        return 91;
                    case "SMS_REPLY":
                        return 92;
                    case "LW_DATE":
                        return 93;
                    case "LW_TIME":
                        return 94;
                    case "LW_USER":
                        return 95;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
