using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Re-Enrolment Data Set
    /// </summary>
    public sealed class STREDataSet : SetBase<STRE>
    {

        internal STREDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STRE"; } }


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
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
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
    }
}
