using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group Data Set
    /// </summary>
    public sealed class SSHG_DataSet : SetBase<SSHG_Entity>
    {

        internal SSHG_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SSHG"; } }

        protected override Action<SSHG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SSHG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOMEGROUP":
                        mapper[i] = (e, v) => e.HOMEGROUP = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "VARIATION":
                        mapper[i] = (e, v) => e.VARIATION = v;
                        break;
                    case "TEACHING_HG":
                        mapper[i] = (e, v) => e.TEACHING_HG = v;
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
