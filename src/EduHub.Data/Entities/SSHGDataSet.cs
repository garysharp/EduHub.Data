using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group Data Set
    /// </summary>
    public sealed class SSHGDataSet : SetBase<SSHG>
    {

        internal SSHGDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SSHG"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SSHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SSHG" /> fields for each CSV column header</returns>
        protected override Action<SSHG, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SSHG, string>[Headers.Count];

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
