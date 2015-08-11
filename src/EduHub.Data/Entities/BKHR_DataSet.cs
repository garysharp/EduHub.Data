using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records Data Set
    /// </summary>
    public sealed class BKHR_DataSet : SetBase<BKHR_Entity>
    {
        internal BKHR_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "BKHR"; } }


        
        protected override Action<BKHR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<BKHR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BKHRKEY":
                        mapper[i] = (e, v) => e.BKHRKEY = v;
                        break;
                    case "REF_NUMBER":
                        mapper[i] = (e, v) => e.REF_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ISSUE_DATE":
                        mapper[i] = (e, v) => e.ISSUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DUE_DATE":
                        mapper[i] = (e, v) => e.DUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RETURNED_DATE":
                        mapper[i] = (e, v) => e.RETURNED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONDITION":
                        mapper[i] = (e, v) => e.CONDITION = v;
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
