using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Merit Behaviour Details Data Set
    /// </summary>
    public sealed class STMBDataSet : SetBase<STMB>
    {

        internal STMBDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STMB"; } }

        protected override Action<STMB, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STMB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "B_CODE":
                        mapper[i] = (e, v) => e.B_CODE = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECOMMEND_TYPE":
                        mapper[i] = (e, v) => e.RECOMMEND_TYPE = v;
                        break;
                    case "RECOMMEND_KEY":
                        mapper[i] = (e, v) => e.RECOMMEND_KEY = v;
                        break;
                    case "RECOMMEND_DFAB":
                        mapper[i] = (e, v) => e.RECOMMEND_DFAB = v;
                        break;
                    case "RECOMMEND_OTHER":
                        mapper[i] = (e, v) => e.RECOMMEND_OTHER = v;
                        break;
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "STMB_COMMENT":
                        mapper[i] = (e, v) => e.STMB_COMMENT = v;
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
