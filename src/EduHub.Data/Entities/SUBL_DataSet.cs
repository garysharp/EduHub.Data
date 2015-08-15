using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Book List Data Set
    /// </summary>
    public sealed class SUBL_DataSet : SetBase<SUBL_Entity>
    {

        internal SUBL_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SUBL"; } }

        protected override Action<SUBL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SUBL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BLKEY":
                        mapper[i] = (e, v) => e.BLKEY = v;
                        break;
                    case "BOOK":
                        mapper[i] = (e, v) => e.BOOK = v;
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "TAG":
                        mapper[i] = (e, v) => e.TAG = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_REQUIRED":
                        mapper[i] = (e, v) => e.NUMBER_REQUIRED = v == null ? (short?)null : short.Parse(v);
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
