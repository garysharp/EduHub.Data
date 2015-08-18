using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications Data Set
    /// </summary>
    public sealed class SFQADataSet : SetBase<SFQA>
    {

        internal SFQADataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFQA"; } }

        protected override Action<SFQA, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SFQA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "QUALIFICATION":
                        mapper[i] = (e, v) => e.QUALIFICATION = v;
                        break;
                    case "YEAR_COMPLETED":
                        mapper[i] = (e, v) => e.YEAR_COMPLETED = v;
                        break;
                    case "INSTITUTION":
                        mapper[i] = (e, v) => e.INSTITUTION = v;
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
