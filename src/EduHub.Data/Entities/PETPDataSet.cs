using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Termination Payment Data Set
    /// </summary>
    public sealed class PETPDataSet : SetBase<PETP>
    {

        internal PETPDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PETP"; } }

        protected override Action<PETP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PETP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PEFTID":
                        mapper[i] = (e, v) => e.PEFTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DEATH_BENEFIT":
                        mapper[i] = (e, v) => e.DEATH_BENEFIT = v;
                        break;
                    case "BENEFIT_TYPE":
                        mapper[i] = (e, v) => e.BENEFIT_TYPE = v;
                        break;
                    case "TRANSITIONAL":
                        mapper[i] = (e, v) => e.TRANSITIONAL = v;
                        break;
                    case "RELATED":
                        mapper[i] = (e, v) => e.RELATED = v;
                        break;
                    case "ETP_CODE":
                        mapper[i] = (e, v) => e.ETP_CODE = v;
                        break;
                    case "TAX_RATE":
                        mapper[i] = (e, v) => e.TAX_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PATCH_RECORD":
                        mapper[i] = (e, v) => e.PATCH_RECORD = v;
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
