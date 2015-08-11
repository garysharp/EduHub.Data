using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments Data Set
    /// </summary>
    public sealed class STPT_DataSet : SetBase<STPT_Entity>
    {
        internal STPT_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "STPT"; } }


        
        protected override Action<STPT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STPT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STPTKEY":
                        mapper[i] = (e, v) => e.STPTKEY = v;
                        break;
                    case "SCHL_NUM":
                        mapper[i] = (e, v) => e.SCHL_NUM = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ENROLLED":
                        mapper[i] = (e, v) => e.ENROLLED = v;
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
