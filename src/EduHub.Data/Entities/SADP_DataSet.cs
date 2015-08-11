using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Prevention Measures Data Set
    /// </summary>
    public sealed class SADP_DataSet : SetBase<SADP_Entity>
    {
        internal SADP_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "SADP"; } }


        
        protected override Action<SADP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SADP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PREVENTION":
                        mapper[i] = (e, v) => e.PREVENTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_PREV_INFO":
                        mapper[i] = (e, v) => e.OTHER_PREV_INFO = v;
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
