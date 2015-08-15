using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Membership Eligibility Criteria Data Set
    /// </summary>
    public sealed class SGSG_DataSet : SetBase<SGSG_Entity>
    {

        internal SGSG_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SGSG"; } }

        protected override Action<SGSG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SGSG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGSGKEY":
                        mapper[i] = (e, v) => e.SGSGKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
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
