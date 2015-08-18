using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Suspension Details Data Set
    /// </summary>
    public sealed class STSPDataSet : SetBase<STSP>
    {

        internal STSPDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STSP"; } }

        protected override Action<STSP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STSP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SPKEY":
                        mapper[i] = (e, v) => e.SPKEY = v;
                        break;
                    case "ENTRY_DATE":
                        mapper[i] = (e, v) => e.ENTRY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUSP_NUMBER":
                        mapper[i] = (e, v) => e.SUSP_NUMBER = v;
                        break;
                    case "REF_TEACHERA":
                        mapper[i] = (e, v) => e.REF_TEACHERA = v;
                        break;
                    case "REF_TEACHERB":
                        mapper[i] = (e, v) => e.REF_TEACHERB = v;
                        break;
                    case "NO_DAYS":
                        mapper[i] = (e, v) => e.NO_DAYS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TO_DATE":
                        mapper[i] = (e, v) => e.TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RETURN_DATE":
                        mapper[i] = (e, v) => e.RETURN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NON_COMP":
                        mapper[i] = (e, v) => e.NON_COMP = v;
                        break;
                    case "SCH_AVOID":
                        mapper[i] = (e, v) => e.SCH_AVOID = v;
                        break;
                    case "VERBAL":
                        mapper[i] = (e, v) => e.VERBAL = v;
                        break;
                    case "PHYSICAL":
                        mapper[i] = (e, v) => e.PHYSICAL = v;
                        break;
                    case "MISUSE":
                        mapper[i] = (e, v) => e.MISUSE = v;
                        break;
                    case "SEXUAL":
                        mapper[i] = (e, v) => e.SEXUAL = v;
                        break;
                    case "INTIM":
                        mapper[i] = (e, v) => e.INTIM = v;
                        break;
                    case "VANDAL":
                        mapper[i] = (e, v) => e.VANDAL = v;
                        break;
                    case "STEALING":
                        mapper[i] = (e, v) => e.STEALING = v;
                        break;
                    case "SMOKING":
                        mapper[i] = (e, v) => e.SMOKING = v;
                        break;
                    case "DRUGS":
                        mapper[i] = (e, v) => e.DRUGS = v;
                        break;
                    case "FAIR":
                        mapper[i] = (e, v) => e.FAIR = v;
                        break;
                    case "CONSULT":
                        mapper[i] = (e, v) => e.CONSULT = v;
                        break;
                    case "PROCED":
                        mapper[i] = (e, v) => e.PROCED = v;
                        break;
                    case "COUNSEL":
                        mapper[i] = (e, v) => e.COUNSEL = v;
                        break;
                    case "CURRIC":
                        mapper[i] = (e, v) => e.CURRIC = v;
                        break;
                    case "PARENT":
                        mapper[i] = (e, v) => e.PARENT = v;
                        break;
                    case "DIRECT":
                        mapper[i] = (e, v) => e.DIRECT = v;
                        break;
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "OTHER_AGENCIES":
                        mapper[i] = (e, v) => e.OTHER_AGENCIES = v;
                        break;
                    case "POLICE":
                        mapper[i] = (e, v) => e.POLICE = v;
                        break;
                    case "OTHER_REAS":
                        mapper[i] = (e, v) => e.OTHER_REAS = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "PRINC_DECISION":
                        mapper[i] = (e, v) => e.PRINC_DECISION = v;
                        break;
                    case "PRINC_RECOM":
                        mapper[i] = (e, v) => e.PRINC_RECOM = v;
                        break;
                    case "RECOM_DIRECT":
                        mapper[i] = (e, v) => e.RECOM_DIRECT = v;
                        break;
                    case "SCHOOL_COMM":
                        mapper[i] = (e, v) => e.SCHOOL_COMM = v;
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
