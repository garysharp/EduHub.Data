using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Absences Data Set
    /// </summary>
    public sealed class TCTB_DataSet : SetBase<TCTB_Entity>
    {
        internal TCTB_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "TCTB"; } }


        
        protected override Action<TCTB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TCTB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TCTBKEY":
                        mapper[i] = (e, v) => e.TCTBKEY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TEACHER_AVAILABLE":
                        mapper[i] = (e, v) => e.TEACHER_AVAILABLE = v;
                        break;
                    case "ROOM_AVAILABLE":
                        mapper[i] = (e, v) => e.ROOM_AVAILABLE = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "COMMENT_A":
                        mapper[i] = (e, v) => e.COMMENT_A = v;
                        break;
                    case "ABSENCE_TYPE":
                        mapper[i] = (e, v) => e.ABSENCE_TYPE = v;
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
